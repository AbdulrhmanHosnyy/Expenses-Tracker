using ClosedXML.Excel;
using ExpensesTracker.Code;
using ExpensesTracker.GUI.GUI_Loading;
using ExpensesTracker.GUI.HomeGUI;
using ExpensesTrackerCore;
using ExpensesTrackerData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ExpensesTracker.GUI.SystemRecordGUI
{
    public partial class SystemRecordUserControl : UserControl
    {
        //  Variables
        private readonly IDataHelper<SystemRecord> dataHelper;
        private readonly IDataHelper<Income> IncomeDataHelper;
        private readonly IDataHelper<Outcome> OutcomeDataHelper;
        private readonly IDataHelper<SystemRecord> dataHelperSystemRecord;
        private static SystemRecordUserControl systemRecordUserControl;
        private readonly LoadingForm loadingForm;
        private int RowId;
        private List<int> IdList = new List<int>();
        private string SearchItem;
        private List<int> CategoriesId = new List<int>();
        private double IncomeAmount;
        private double OutcomeAmount;

        //  Constructors
        public SystemRecordUserControl()
        {
            InitializeComponent();
            setPermissions();
            dataHelper = (IDataHelper<SystemRecord>)ConfigrationObjectManager.Get("SystemRecord");
            IncomeDataHelper = (IDataHelper<Income>)ConfigrationObjectManager.Get("Income");
            OutcomeDataHelper = (IDataHelper<Outcome>)ConfigrationObjectManager.Get("Outcome");
            dataHelperSystemRecord = (IDataHelper<SystemRecord>)ConfigrationObjectManager.Get("SystemRecord");
            loadingForm = new LoadingForm();
            LoadData();
        }

        #region Events
        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                var Deleteresult = MessageCollection.ShowDeleteDialog();
                if (Deleteresult)
                {
                    IdList.Clear();
                    SetIdRowForDelete();
                    loadingForm.Show();
                    if (IdList.Count > 0)
                    {
                        for (int i = 0; i < IdList.Count; i++)
                        {
                            RowId = IdList[i];
                            var result = await dataHelper.DeleteAsync(RowId);
                            if (result == 1)
                            {
                                //  Save system records
                                SystemRecord systemRecord = new SystemRecord
                                {
                                    Title = "Delete Operation",
                                    Username = Properties.Settings.Default.UserName,
                                    Details = "Object with id " + RowId.ToString() + "is deleted",
                                    AddedDate = DateTime.Now,
                                };
                                await dataHelperSystemRecord.AddAsync(systemRecord);
                                MessageCollection.ShowDeleteNotification();
                            }
                            else
                            {
                                MessageCollection.ShowServerError();
                            }
                        }
                        LoadData();
                    }
                    else
                    {
                        MessageCollection.ShowRequiredDeleteRow();
                    }

                    loadingForm.Hide();
                }
            }
            else
            {
                MessageCollection.ShowEmptyDataMessage();
            }
        }

        private async void exportButton_Click(object sender, EventArgs e)
        {
            //  Convert lise of data to datatable
            DataTable dataTable = new DataTable();
            loadingForm.Show();
            var data = await dataHelper.GetAllDataAsync();
            loadingForm.Hide();
            using (var reader = FastMember.ObjectReader.Create(data))
            {
                dataTable.Load(reader);
            }
            //  Reset columns
            DataTable dataTableArranged = SetDataTableColumns(dataTable);
            //  Export data as sheet excel
            ExportAsXlsxFile(dataTableArranged);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private async void PageNocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadingForm.Show();
            var data = await dataHelper.GetAllDataAsync();
            var dataId = data.Select(x => x.Id).ToArray();
            int index = PageNoComboBox.SelectedIndex;
            int NoOfRows = index * Properties.Settings.Default.DataGridViewRowNo;

            dataGridView1.DataSource = data.Where(x => x.Id >= dataId[NoOfRows]).Take(Properties.Settings.Default.DataGridViewRowNo).ToList();

            if (dataGridView1.DataSource == null)
            {
                MessageCollection.ShowServerError();
            }
            else
            {
                SetColumnsTitles();
            }
            loadingForm.Hide();
            data.Clear();
        }

        #endregion


        #region Methods

        public static SystemRecordUserControl Instance()
        {
            return systemRecordUserControl ?? (new SystemRecordUserControl());
        }

        public async void LoadData()
        {
            loadingForm.Show();
            var data = await dataHelper.GetAllDataAsync();
            CategoriesId = data.Select(x => x.Id).ToList();
            dataGridView1.DataSource = data.Take(Properties.Settings.Default.DataGridViewRowNo).ToList();
            PageNoComboBox.Items.Clear();

            double value = (Convert.ToDouble(data.Count) / Convert.ToDouble(Properties.Settings.Default.DataGridViewRowNo));
            int NoOfPages = (int)Math.Round(value, MidpointRounding.AwayFromZero);

            //  Add pages number to combo box
            for (int i = 0; i < NoOfPages; i++)
            {
                PageNoComboBox.Items.Add(i);
            }

            if (dataGridView1.DataSource == null)
            {
                MessageCollection.ShowServerError();
            }
            else
            {
                SetColumnsTitles();
            }
            loadingForm.Hide();
            data.Clear();
        }

        public async void Search()
        {
            loadingForm.Show();
            SearchItem = searchTextBox.Text;
            dataGridView1.DataSource = await dataHelper.SearchAsync(SearchItem);
            if (dataGridView1.DataSource == null)
            {
                MessageCollection.ShowServerError();
            }
            else
            {
                SetColumnsTitles();
            }
            loadingForm.Hide();
        }

        private DataTable SetDataTableColumns(DataTable dataTable)
        {
            dataTable.Columns["Id"].SetOrdinal(0);
            dataTable.Columns["Id"].ColumnName = "Id";
            dataTable.Columns["Username"].SetOrdinal(1);
            dataTable.Columns["Username"].ColumnName = "Username";
            dataTable.Columns["Title"].SetOrdinal(2);
            dataTable.Columns["Title"].ColumnName = "Title";
            dataTable.Columns["Details"].SetOrdinal(3);
            dataTable.Columns["Details"].ColumnName = "Details";
            dataTable.Columns["AddedDate"].SetOrdinal(4);
            dataTable.Columns["AddedDate"].ColumnName = "AddedDate";
            return dataTable;

        }

        private void ExportAsXlsxFile(DataTable dataTableArranged)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export as excel file";
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.AddExtension = true;
            saveFileDialog.Filter = "Excel File (.xlsx)|*.xlsx";
            saveFileDialog.RestoreDirectory = true;
            var result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook xLWorkbook = new XLWorkbook()) // Create Excel file
                    {
                        xLWorkbook.AddWorksheet(dataTableArranged, "Data"); //  Add sheet
                        using (MemoryStream ma = new MemoryStream())
                        {
                            xLWorkbook.SaveAs(ma);
                            File.WriteAllBytes(saveFileDialog.FileName, ma.ToArray());
                        }
                    }
                    System.Diagnostics.Process.Start(saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SetColumnsTitles()
        {
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Username";
            dataGridView1.Columns[2].HeaderText = "Title";
            dataGridView1.Columns[3].HeaderText = "Details";
            dataGridView1.Columns[4].HeaderText = "AddedDate";
        }

        private void SetIdRowForDelete()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    IdList.Add(Convert.ToInt32(row.Cells[0].Value));
                }
            }
        }

        private void setPermissions()
        {

            if (!UserPermissionsManager.Get("deleteCheckBox"))
            {
                deleteButton.Visible = false;
            }
            if (!UserPermissionsManager.Get("exportCheckBox"))
            {
                exportButton.Visible = false;
            }
            if (!UserPermissionsManager.Get("searchCheckBox"))
            {
                searchButton.Visible = false;
            }
        }

        #endregion

    }
}
