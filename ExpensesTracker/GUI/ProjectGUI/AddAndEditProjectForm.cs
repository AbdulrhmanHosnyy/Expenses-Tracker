using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using DocumentFormat.OpenXml.ExtendedProperties;
using ExpensesTracker.Code;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ExpensesTracker.GUI.ProjectGUI
{
    public partial class AddAndEditProjectForm : Form
    {
        //  Variables
        private readonly int id;
        private readonly ProjectUserControl customerUserControl;
        private Project customer;
        private readonly IDataHelper<Project> dataHelper;
        private readonly IDataHelper<Customer> dataHelperCustomer;
        private readonly IDataHelper<SystemRecord> dataHelperSystemRecord;
        private readonly LoadingForm loadingForm;

        public AddAndEditProjectForm(int id, ProjectUserControl customerUserControl)
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Project>)ConfigrationObjectManager.Get("Project");
            dataHelperCustomer = (IDataHelper<Customer>)ConfigrationObjectManager.Get("Customer");
            dataHelperSystemRecord = (IDataHelper<SystemRecord>)ConfigrationObjectManager.Get("SystemRecord");
            loadingForm = new LoadingForm();
            this.id = id;
            this.customerUserControl = customerUserControl;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private async void AddAndEditProjectForm_Load(object sender, EventArgs e)
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
            if (nameTextBox.Text == string.Empty)
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
            customer = new Project
            {
                Name = nameTextBox.Text,
                Customer = companyTextBox.Text,
                Company = companyTextBox.Text,
                Address = addressTextBox.Text,
                Details = detailsRichTextBox.Text,
                Income = Convert.ToDouble(incomeTextBox.Text),
                Outcome = Convert.ToDouble(outcomeTextBox.Text),
                Revenue = Convert.ToDouble(revenueTextBox.Text),
                StartDate = projectStartDateTimePicker.Value,
                FinishDate = projectEndDateTimePicker.Value,
                AddedDate = DateTime.Now,
            };
            //  Submit
            var result = await dataHelper.AddAsync(customer);
            if (result == 0)
            {
                return false;
            }
            else
            {
                //  Save system records
                SystemRecord systemRecord = new SystemRecord
                {
                    Title = "Add Project Operation",
                    Username = Properties.Settings.Default.UserName,
                    Details = "New Project is added: " + customer.Name,
                    AddedDate = DateTime.Now,
                };
                await dataHelperSystemRecord.AddAsync(systemRecord);
                customerUserControl.LoadData();
                return true;
            }
        }

        private async Task<bool> EditData()
        {
            //  Set Data
            customer = new Project
            {
                Id = id,
                Name = nameTextBox.Text,
                Customer = companyTextBox.Text,
                Company = companyTextBox.Text,
                Address = addressTextBox.Text,
                Details = detailsRichTextBox.Text,
                Income = Convert.ToDouble(incomeTextBox.Text),
                Outcome = Convert.ToDouble(outcomeTextBox.Text),
                Revenue = Convert.ToDouble(revenueTextBox.Text),
                StartDate = projectStartDateTimePicker.Value,
                FinishDate = projectEndDateTimePicker.Value,
                AddedDate = DateTime.Now,
            };
            //  Submit
            var result = await dataHelper.EditAsync(customer);
            if (result == 0)
            {
                return false;
            }
            else
            {
                //  Save system records
                SystemRecord systemRecord = new SystemRecord
                {
                    Title = "Edit Project Operation",
                    Username = Properties.Settings.Default.UserName,
                    Details = "Project is Edited: " + customer.Name,
                    AddedDate = DateTime.Now,
                };
                await dataHelperSystemRecord.AddAsync(systemRecord);
                customerUserControl.LoadData();
                return true;
            }
        }

        private async void SetFieldData()
        {
            //  Get List of Customers
            var customersList = await dataHelperCustomer.GetAllDataAsync();
            customerComboBox.DataSource = customersList.Select(x => x.Name).ToList(); // Fill
                                                                                      // Auto complete
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(customersList.Select(x => x.Name).ToArray());
            customerComboBox.AutoCompleteCustomSource = autoCompleteStringCollection;
            customersList.Clear();  // Clear

            if (id != 0)
            {
                //  Set Fields
                customer = await dataHelper.FindAsync(id);
                if (customer != null)
                {
                    nameTextBox.Text = customer.Name;
                    companyTextBox.Text = customer.Customer;
                    companyTextBox.Text = customer.Company;
                    addressTextBox.Text = customer.Address;
                    detailsRichTextBox.Text = customer.Details;
                    incomeTextBox.Text = customer.Income.ToString();
                    outcomeTextBox.Text = customer.Outcome.ToString();
                    revenueTextBox.Text = customer.Revenue.ToString();
                    projectStartDateTimePicker.Value = customer.StartDate;
                    projectEndDateTimePicker.Value = customer.FinishDate;
                }
                else
                {
                    MessageCollection.ShowServerError();
                }

            }
        }

        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}
