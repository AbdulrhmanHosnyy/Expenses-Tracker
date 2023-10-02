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

namespace ExpensesTracker.GUI.ProjectGUI
{
    public partial class ProjectUserControl : UserControl
    {
        //  Variables
        private readonly IDataHelper<Project> dataHelper;
        private readonly IDataHelper<Income> IncomeDataHelper;
        private readonly IDataHelper<Outcome> OutcomeDataHelper;
        private readonly IDataHelper<SystemRecord> dataHelperSystemRecord;
        private static ProjectUserControl customerUserControl;
        private readonly LoadingForm loadingForm;
        private int RowId;
        private List<int> IdList = new List<int>();
        private string SearchItem;
        private double IncomeAmount;
        private double OutcomeAmount;
        private List<int> ProjectsId = new List<int>();

        //  Constructors
        public ProjectUserControl()
        {
            InitializeComponent();
            setPermissions();
            dataHelper = (IDataHelper<Project>)ConfigrationObjectManager.Get("Project");
            IncomeDataHelper = (IDataHelper<Income>)ConfigrationObjectManager.Get("Income");
            OutcomeDataHelper = (IDataHelper<Outcome>)ConfigrationObjectManager.Get("Outcome");
            dataHelperSystemRecord = (IDataHelper<SystemRecord>)ConfigrationObjectManager.Get("SystemRecord");
            loadingForm = new LoadingForm();
            LoadData();
        }

        #region Events
        private void addButton_Click(object sender, EventArgs e)
        {
            AddAndEditProjectForm addAndEditProjectForm = new AddAndEditProjectForm(0, this);
            addAndEditProjectForm.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Edit();
        }

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
                                    Details = "Project with id " + RowId.ToString() + "is deleted",
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ExploreProject();
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

        private void openButton_Click(object sender, EventArgs e)
        {
            ExploreProject();
        }

        private async void ProjectUserControl_Load(object sender, EventArgs e)
        {
            await Task.Run(() => UpdateData(ProjectsId));
        }

        #endregion

        #region Methods

        public static ProjectUserControl Instance()
        {
            return customerUserControl ?? (new ProjectUserControl());
        }

        private void ExploreProject()
        {
            if (dataGridView1.RowCount > 0)
            {
                //  Get Id
                RowId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                ProjectManagementForm projectManagementForm =
                    new ProjectManagementForm(RowId);
                projectManagementForm.Show();
            }
            else
            {
                MessageCollection.ShowEmptyDataMessage();
            }
        }

        public async void LoadData()
        {
            loadingForm.Show();
            var data = await dataHelper.GetAllDataAsync();
            ProjectsId = data.Select(x => x.Id).ToList();
            await Task.Run(() => UpdateData(ProjectsId));
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
            dataTable.Columns["Name"].SetOrdinal(1);
            dataTable.Columns["Name"].ColumnName = "Name";
            dataTable.Columns["Customer"].SetOrdinal(2);
            dataTable.Columns["Customer"].ColumnName = "Customer";
            dataTable.Columns["Address"].SetOrdinal(3);
            dataTable.Columns["Address"].ColumnName = "Address";
            dataTable.Columns["Comapny"].SetOrdinal(4);
            dataTable.Columns["Comapny"].ColumnName = "Comapny";
            dataTable.Columns["Details"].SetOrdinal(5);
            dataTable.Columns["Details"].ColumnName = "Details";
            dataTable.Columns["Income"].SetOrdinal(6);
            dataTable.Columns["Income"].ColumnName = "Income";
            dataTable.Columns["Project"].SetOrdinal(7);
            dataTable.Columns["Project"].ColumnName = "Project";
            dataTable.Columns["Revenue"].SetOrdinal(8);
            dataTable.Columns["Revenue"].ColumnName = "Revenue";
            dataTable.Columns["StartDate"].SetOrdinal(9);
            dataTable.Columns["StartDate"].ColumnName = "StartDate";
            dataTable.Columns["FinishDate"].SetOrdinal(10);
            dataTable.Columns["FinishDate"].ColumnName = "FinishDate";
            dataTable.Columns["AddedDate"].SetOrdinal(11);
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
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Customer";
            dataGridView1.Columns[3].HeaderText = "Address";
            dataGridView1.Columns[4].HeaderText = "Company";
            dataGridView1.Columns[5].HeaderText = "Details";
            dataGridView1.Columns[6].HeaderText = "Income";
            dataGridView1.Columns[7].HeaderText = "Project";
            dataGridView1.Columns[8].HeaderText = "Revenue";
            dataGridView1.Columns[9].HeaderText = "StartDate";
            dataGridView1.Columns[10].HeaderText = "FinishDate";
            dataGridView1.Columns[11].HeaderText = "AddedDate";

            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }

        private void Edit()
        {
            if (dataGridView1.RowCount > 0)
            {
                //  Get Id
                RowId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                AddAndEditProjectForm addAndEditProjectForm =
                    new AddAndEditProjectForm(RowId, this);
                addAndEditProjectForm.Show();
            }
            else
            {
                MessageCollection.ShowEmptyDataMessage();
            }
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

        private void UpdateData(List<int> ProjectsId)
        {
            //  Get Data
            //  Loop Into CategoriesId
            for (int i = 0; i < ProjectsId.Count; i++)
            {
                var ProjectId = ProjectsId[i];
                try
                {
                    IncomeAmount = IncomeDataHelper.GetAllData().Where(x => x.ProjectId == ProjectId)
                                .Select(x => x.Amount).ToArray().Sum();
                    OutcomeAmount = OutcomeDataHelper.GetAllData().Where(x => x.ProjectId == ProjectId)
                                .Select(x => x.Amount).ToArray().Sum();
                }
                catch
                {
                }

                //  Set Data
                Project Project = dataHelper.GetAllData().Where(x => x.Id == ProjectId).First();
                Project.Income = IncomeAmount;
                Project.Outcome = OutcomeAmount;
                Project.Revenue = IncomeAmount - OutcomeAmount;
                dataHelper.Edit(Project);

            }
        }

        private void setPermissions()
        {
            if (!UserPermissionsManager.Get("addCheckBox"))
            {
                addButton.Visible = false;
            }
            if (!UserPermissionsManager.Get("deleteCheckBox"))
            {
                deleteButton.Visible = false;
            }
            if (!UserPermissionsManager.Get("editCheckBox"))
            {
                editButton.Visible = false;
            }
            if (!UserPermissionsManager.Get("exportCheckBox"))
            {
                exportButton.Visible = false;
            }
            if (!UserPermissionsManager.Get("searchCheckBox"))
            {
                searchButton.Visible = false;
            }
            if (!UserPermissionsManager.Get("openCheckBox"))
            {
                openButton.Visible = false;
            }
        }

        #endregion

    }
}
