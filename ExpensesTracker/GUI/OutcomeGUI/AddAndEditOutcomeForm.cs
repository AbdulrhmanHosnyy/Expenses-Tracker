using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using DocumentFormat.OpenXml.ExtendedProperties;
using ExpensesTracker.Code;
using ExpensesTracker.GUI.CategoryGUI;
using ExpensesTracker.GUI.CustomerGUI;
using ExpensesTracker.GUI.GUI_Loading;
using ExpensesTracker.GUI.SupplierGUI;
using ExpensesTrackerCore;
using ExpensesTrackerData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ExpensesTracker.GUI.OutcomeGUI
{
    public partial class AddAndEditOutcomeForm : Form
    {
        //  Variables
        private readonly int id;
        private readonly OutcomeUserControl outcomeUserControl;
        private Outcome outcome;
        private readonly IDataHelper<Outcome> dataHelper;
        private readonly IDataHelper<Supplier> dataHelperSupplier;
        private readonly IDataHelper<Category> dataHelperCategory;
        private readonly IDataHelper<SystemRecord> dataHelperSystemRecord;
        private readonly LoadingForm loadingForm;

        public int CategoryId { get; private set; }
        public int SupplierId { get; private set; }
        public int ProjectId { get; private set; }

        public AddAndEditOutcomeForm(int id, int projectId, OutcomeUserControl outcomeUserControl)
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Outcome>)ConfigrationObjectManager.Get("Outcome");
            dataHelperSupplier = (IDataHelper<Supplier>)ConfigrationObjectManager.Get("Supplier");
            dataHelperCategory = (IDataHelper<Category>)ConfigrationObjectManager.Get("Category");
            dataHelperSystemRecord = (IDataHelper<SystemRecord>)ConfigrationObjectManager.Get("SystemRecord");
            loadingForm = new LoadingForm();
            this.id = id;
            this.outcomeUserControl = outcomeUserControl;
            this.ProjectId = projectId;
        }

        #region Events
        private async void saveAndCloseButton_Click(object sender, EventArgs e)
        {
            if (isFieldEmpty())
            {
                MessageCollection.ShowFieldsRequired();
            }
            else
            {
                loadingForm.Show();
                if (await SaveData())
                {
                    if (id == 0)
                    {
                        MessageCollection.ShowAddNotification();
                    }
                    else
                    {
                        MessageCollection.ShowUpdateNotification();
                    }
                    Close();
                }
                else
                {
                    MessageCollection.ShowServerError();
                }
                loadingForm.Hide();
            }
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            if (isFieldEmpty())
            {
                MessageCollection.ShowFieldsRequired();
            }
            else
            {
                loadingForm.Show();
                if (await SaveData())
                {
                    if (id == 0)
                    {
                        MessageCollection.ShowAddNotification();
                    }
                    else
                    {
                        MessageCollection.ShowUpdateNotification();
                    }
                }
                else
                {
                    MessageCollection.ShowServerError();
                }
                loadingForm.Hide();
            }
        }

        private async void AddAndEditOutcomeForm_Load(object sender, EventArgs e)
        {
            //  Set Field
            loadingForm.Show();
            SetFieldData();
            loadingForm.Hide();
        }

        #endregion

        #region Methods

        private async Task<bool> SaveData()
        {

            await Task.Run(() => SetCategoryId());
            await Task.Run(() => SetRecipientId());
            // Check if fileds are empty
            //  Add
            if (id == 0)
            {
                return await AddData();
            }
            //  Edit
            else
            {
                return await EditData();
            }
        }
        private bool isFieldEmpty()
        {
            if (categoryComboBox.SelectedItem == null ||
                RecipientComboBox.SelectedItem == null ||
                amountTextBox.Text == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private async Task<bool> AddData()
        {
            //  Set Data
            outcome = new Outcome
            {
                CategoryName = categoryComboBox.SelectedItem.ToString(),
                SupplierName = RecipientComboBox.SelectedItem.ToString(),
                ReceiptNumber = receiptNumberTextBox.Text,
                Details = detailsRichTextBox.Text,
                Amount = Convert.ToDouble(amountTextBox.Text),
                OutcomeDate = OutcomeDateTimePicker.Value,
                CategoryId = CategoryId,
                SupplierId = SupplierId,
                ProjectId = ProjectId
            };
            //  Submit
            var result = await dataHelper.AddAsync(outcome);
            if (result == 0)
            {
                return false;
            }
            else
            {
                //  Save system records
                SystemRecord systemRecord = new SystemRecord
                {
                    Title = "Add Outcome Operation",
                    Username = Properties.Settings.Default.UserName,
                    Details = "New Outcome is added: " + outcome.CategoryName,
                    AddedDate = DateTime.Now,
                };
                await dataHelperSystemRecord.AddAsync(systemRecord);
                outcomeUserControl.LoadData();
                return true;
            }
        }

        private async Task<bool> EditData()
        {
            //  Set Data
            outcome = new Outcome
            {
                Id = id,
                CategoryName = categoryComboBox.SelectedItem.ToString(),
                SupplierName = RecipientComboBox.SelectedItem.ToString(),
                ReceiptNumber = receiptNumberTextBox.Text,
                Details = detailsRichTextBox.Text,
                Amount = Convert.ToDouble(amountTextBox.Text),
                OutcomeDate = OutcomeDateTimePicker.Value,
                CategoryId = CategoryId,
                SupplierId = SupplierId,
                ProjectId = ProjectId
            };
            //  Submit
            var result = await dataHelper.EditAsync(outcome);
            if (result == 0)
            {
                return false;
            }
            else
            {
                //  Save system records
                SystemRecord systemRecord = new SystemRecord
                {
                    Title = "Edit Outcome Operation",
                    Username = Properties.Settings.Default.UserName,
                    Details = "Outcome is Edited: " + outcome.CategoryName,
                    AddedDate = DateTime.Now,
                };
                await dataHelperSystemRecord.AddAsync(systemRecord);
                outcomeUserControl.LoadData();
                return true;
            }
        }

        private async void SetFieldData()
        {

            //  Get List of Categories 
            var categoriesList = await dataHelperCategory.GetAllDataAsync();
            categoryComboBox.DataSource = categoriesList.Select(x => x.Name).ToList(); // Fill
                                                                                       // Auto complete
            AutoCompleteStringCollection categoryAutoCompleteStringCollection = new AutoCompleteStringCollection();
            categoryAutoCompleteStringCollection.AddRange(categoriesList.Select(x => x.Name).ToArray());
            categoryComboBox.AutoCompleteCustomSource = categoryAutoCompleteStringCollection;
            categoriesList.Clear();  // Clear

            //  Get List of Suppliers 
            var suppliersList = await dataHelperSupplier.GetAllDataAsync();
            RecipientComboBox.DataSource = suppliersList.Select(x => x.Name).ToList(); // Fill
                                                                                       // Auto complete
            AutoCompleteStringCollection supplierAutoCompleteStringCollection = new AutoCompleteStringCollection();
            supplierAutoCompleteStringCollection.AddRange(suppliersList.Select(x => x.Name).ToArray());
            RecipientComboBox.AutoCompleteCustomSource = supplierAutoCompleteStringCollection;
            suppliersList.Clear();  // Clear


            if (id != 0)
            {
                //  Set Fields
                outcome = await dataHelper.FindAsync(id);
                if (outcome != null)
                {
                    categoryComboBox.SelectedItem = outcome.CategoryName;
                    RecipientComboBox.SelectedItem = outcome.SupplierName;
                    receiptNumberTextBox.Text = outcome.ReceiptNumber;
                    detailsRichTextBox.Text = outcome.Details;
                    amountTextBox.Text = outcome.Amount.ToString();
                    OutcomeDateTimePicker.Value = outcome.OutcomeDate;
                    CategoryId = outcome.CategoryId;
                    SupplierId = outcome.SupplierId;
                    ProjectId = outcome.ProjectId;
                }
                else
                {
                    MessageCollection.ShowServerError();
                }

            }
        }

        private void SetCategoryId()
        {
            if (categoryComboBox.Text != string.Empty)
            {
                var CategoryName = categoryComboBox.SelectedItem.ToString();
                CategoryId = dataHelperCategory.GetAllData().Where(x => x.Name == CategoryName)
                    .Select(x => x.Id).First();
            }

        }
        private void SetRecipientId()
        {
            if (RecipientComboBox.Text != string.Empty)
            {
                var RecipientName = RecipientComboBox.SelectedItem.ToString();
                SupplierId = dataHelperSupplier.GetAllData().Where(x => x.Name == RecipientName)
                    .Select(x => x.Id).First();
            }

        }

        #endregion

        private async void NewCategoryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddAndEditCategoryForm addAndEditCategoryForm = new AddAndEditCategoryForm(0, new CategoryUserControl());
            var result = addAndEditCategoryForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                //  Get List of Categories 
                var categoriesList = await dataHelperCategory.GetAllDataAsync();
                categoryComboBox.DataSource = categoriesList.Select(x => x.Name).ToList(); // Fill
                                                                                           // Auto complete
                AutoCompleteStringCollection categoryAutoCompleteStringCollection = new AutoCompleteStringCollection();
                categoryAutoCompleteStringCollection.AddRange(categoriesList.Select(x => x.Name).ToArray());
                categoryComboBox.AutoCompleteCustomSource = categoryAutoCompleteStringCollection;
                categoriesList.Clear();  // Clear
            }
        }

        private async void NewSupplierLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddAndEditSupplierForm addAndEditSupplierForm = new AddAndEditSupplierForm(0, new SupplierUserControl());
            var result = addAndEditSupplierForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                //  Get List of Suppliers 
                var suppliersList = await dataHelperSupplier.GetAllDataAsync();
                RecipientComboBox.DataSource = suppliersList.Select(x => x.Name).ToList(); // Fill
                                                                                           // Auto complete
                AutoCompleteStringCollection supplierAutoCompleteStringCollection = new AutoCompleteStringCollection();
                supplierAutoCompleteStringCollection.AddRange(suppliersList.Select(x => x.Name).ToArray());
                RecipientComboBox.AutoCompleteCustomSource = supplierAutoCompleteStringCollection;
                suppliersList.Clear();  // Clear
            }
        }
    }
}
