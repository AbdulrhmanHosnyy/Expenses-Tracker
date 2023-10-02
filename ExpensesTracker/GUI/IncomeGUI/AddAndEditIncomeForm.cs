using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using DocumentFormat.OpenXml.ExtendedProperties;
using ExpensesTracker.Code;
using ExpensesTracker.GUI.CategoryGUI;
using ExpensesTracker.GUI.CustomerGUI;
using ExpensesTracker.GUI.GUI_Loading;
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

namespace ExpensesTracker.GUI.IncomeGUI
{
    public partial class AddAndEditIncomeForm : Form
    {
        //  Variables
        private readonly int id;
        private readonly IncomeUserControl incomeUserControl;
        private Income income;
        private readonly IDataHelper<Income> dataHelper;
        private readonly IDataHelper<Customer> dataHelperCustomer;
        private readonly IDataHelper<Category> dataHelperCategory;
        private readonly IDataHelper<SystemRecord> dataHelperSystemRecord;
        private readonly LoadingForm loadingForm;

        public int CategoryId { get; private set; }
        public int SupplierId { get; private set; }
        public int ProjectId { get; private set; }

        public AddAndEditIncomeForm(int id, int projectId, IncomeUserControl incomeUserControl)
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Income>)ConfigrationObjectManager.Get("Income");
            dataHelperCustomer = (IDataHelper<Customer>)ConfigrationObjectManager.Get("Customer");
            dataHelperCategory = (IDataHelper<Category>)ConfigrationObjectManager.Get("Category");
            dataHelperSystemRecord = (IDataHelper<SystemRecord>)ConfigrationObjectManager.Get("SystemRecord");
            loadingForm = new LoadingForm();
            this.id = id;
            this.incomeUserControl = incomeUserControl;
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

        private async void AddAndEditIncomeForm_Load(object sender, EventArgs e)
        {
            //  Set Field
            loadingForm.Show();
            SetFieldData();
            loadingForm.Hide();
        }

        private async void NewCategoryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddAndEditCategoryForm addAndEditCategoryForm = new AddAndEditCategoryForm(0, new CategoryUserControl());
            var result = addAndEditCategoryForm.ShowDialog();
            if(result == DialogResult.OK)
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

        private async void NewCustomerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddAndEditCustomerForm addAndEditCustomerForm = new AddAndEditCustomerForm(0, new CustomerUserControl());
            var result = addAndEditCustomerForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                //  Get List of Customers 
                var customersList = await dataHelperCustomer.GetAllDataAsync();
                RecipientComboBox.DataSource = customersList.Select(x => x.Name).ToList(); // Fill
                                                                                           // Auto complete
                AutoCompleteStringCollection customerAutoCompleteStringCollection = new AutoCompleteStringCollection();
                customerAutoCompleteStringCollection.AddRange(customersList.Select(x => x.Name).ToArray());
                RecipientComboBox.AutoCompleteCustomSource = customerAutoCompleteStringCollection;
                customersList.Clear();  // Clear
            }
        }

        private void AddAndEditIncomeForm_Activated(object sender, EventArgs e)
        {
            
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
            income = new Income
            {
                CategoryName = categoryComboBox.SelectedItem.ToString(),
                SupplierName = RecipientComboBox.SelectedItem.ToString(),
                ReceiptNumber = receiptNumberTextBox.Text,
                Details = detailsRichTextBox.Text,
                Amount = Convert.ToDouble(amountTextBox.Text),
                IncomeDate = IncomeDateTimePicker.Value,
                CategoryId = CategoryId,
                SupplierId = SupplierId,
                ProjectId = ProjectId
            };
            //  Submit
            var result = await dataHelper.AddAsync(income);
            if (result == 0)
            {
                return false;
            }
            else
            {
                //  Save system records
                SystemRecord systemRecord = new SystemRecord
                {
                    Title = "Add Income Operation",
                    Username = Properties.Settings.Default.UserName,
                    Details = "New Income is added: " + income.CategoryName,
                    AddedDate = DateTime.Now,
                };
                await dataHelperSystemRecord.AddAsync(systemRecord);
                incomeUserControl.LoadData();
                return true;
            }
        }

        private async Task<bool> EditData()
        {
            //  Set Data
            income = new Income
            {
                Id = id,
                CategoryName = categoryComboBox.SelectedItem.ToString(),
                SupplierName = RecipientComboBox.SelectedItem.ToString(),
                ReceiptNumber = receiptNumberTextBox.Text,
                Details = detailsRichTextBox.Text,
                Amount = Convert.ToDouble(amountTextBox.Text),
                IncomeDate = IncomeDateTimePicker.Value,
                CategoryId = CategoryId,
                SupplierId = SupplierId,
                ProjectId = ProjectId
            };
            //  Submit
            var result = await dataHelper.EditAsync(income);
            if (result == 0)
            {
                return false;
            }
            else
            {
                //  Save system records
                SystemRecord systemRecord = new SystemRecord
                {
                    Title = "Edit Income Operation",
                    Username = Properties.Settings.Default.UserName,
                    Details = "Income is Edited: " + income.CategoryName,
                    AddedDate = DateTime.Now,
                };
                await dataHelperSystemRecord.AddAsync(systemRecord);
                incomeUserControl.LoadData();
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

            //  Get List of Customers 
            var customersList = await dataHelperCustomer.GetAllDataAsync();
            RecipientComboBox.DataSource = customersList.Select(x => x.Name).ToList(); // Fill
                                                                                       // Auto complete
            AutoCompleteStringCollection customerAutoCompleteStringCollection = new AutoCompleteStringCollection();
            customerAutoCompleteStringCollection.AddRange(customersList.Select(x => x.Name).ToArray());
            RecipientComboBox.AutoCompleteCustomSource = customerAutoCompleteStringCollection;
            customersList.Clear();  // Clear


            if (id != 0)
            {
                //  Set Fields
                income = await dataHelper.FindAsync(id);
                if (income != null)
                {
                    categoryComboBox.SelectedItem = income.CategoryName;
                    RecipientComboBox.SelectedItem = income.SupplierName;
                    receiptNumberTextBox.Text = income.ReceiptNumber;
                    detailsRichTextBox.Text = income.Details;
                    amountTextBox.Text = income.Amount.ToString();
                    IncomeDateTimePicker.Value = income.IncomeDate;
                    CategoryId = income.CategoryId;
                    SupplierId = income.SupplierId;
                    ProjectId = income.ProjectId;
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
                SupplierId = dataHelperCustomer.GetAllData().Where(x => x.Name == RecipientName)
                    .Select(x => x.Id).First();
            }

        }

        #endregion


       
    }
}
