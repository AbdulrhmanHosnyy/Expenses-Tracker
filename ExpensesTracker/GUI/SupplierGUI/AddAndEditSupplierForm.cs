using DocumentFormat.OpenXml.Drawing.Spreadsheet;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesTracker.GUI.SupplierGUI
{
    public partial class AddAndEditSupplierForm : Form
    {
        //  Variables
        private readonly int id;
        private readonly SupplierUserControl customerUserControl;
        private Supplier customer;
        private readonly IDataHelper<Supplier> dataHelper;
        private readonly IDataHelper<SystemRecord> dataHelperSystemRecord;
        private readonly LoadingForm loadingForm;

        public AddAndEditSupplierForm(int id, SupplierUserControl customerUserControl)
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Supplier>)ConfigrationObjectManager.Get("Supplier");
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
                        this.DialogResult = DialogResult.OK;
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
                        this.DialogResult = DialogResult.OK;
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

        private async void AddAndEditSupplierForm_Load(object sender, EventArgs e)
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
            customer = new Supplier
            {
                Name = nameTextBox.Text,
                Address = addressTextBox.Text,
                PhoneNumber = phoneNumberTextBox.Text,
                Details = detailsRichTextBox.Text,
                AddedDate = DateTime.Now,
                Email = emailTextBox.Text,
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
                    Title = "Add Supplier Operation",
                    Username = Properties.Settings.Default.UserName,
                    Details = "New Supplier is added: " + customer.Name,
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
            customer = new Supplier
            {
                Id = id,
                Name = nameTextBox.Text,
                Address = addressTextBox.Text,
                PhoneNumber = phoneNumberTextBox.Text,
                Details = detailsRichTextBox.Text,
                AddedDate = DateTime.Now,
                Email = emailTextBox.Text,
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
                    Title = "Edit Supplier Operation",
                    Username = Properties.Settings.Default.UserName,
                    Details = "Supplier is Edited: " + customer.Name,
                    AddedDate = DateTime.Now,
                };
                await dataHelperSystemRecord.AddAsync(systemRecord);
                customerUserControl.LoadData();
                return true;
            }
        }

        private async void SetFieldData()
        {
            if (id != 0)
            {
                customer = await dataHelper.FindAsync(id);
                if (customer != null)
                {
                    nameTextBox.Text = customer.Name;
                    addressTextBox.Text = customer.Address;
                    phoneNumberTextBox.Text = customer.PhoneNumber;
                    emailTextBox.Text = customer.Email;
                    balanceTextBox.Text = customer.Balance.ToString();
                    detailsRichTextBox.Text = customer.Details;
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
