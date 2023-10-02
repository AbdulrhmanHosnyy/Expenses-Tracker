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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ExpensesTracker.GUI.CategoryGUI
{
    public partial class AddAndEditCategoryForm : Form
    {
        //  Variables
        private readonly int id;
        private readonly CategoryUserControl categoryUserControl;
        private Category category;
        private readonly IDataHelper<Category> dataHelper;
        private readonly IDataHelper<SystemRecord> dataHelperSystemRecord;
        private readonly LoadingForm loadingForm;

        public AddAndEditCategoryForm(int id, CategoryUserControl categoryUserControl)
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Category>)ConfigrationObjectManager.Get("Category");
            dataHelperSystemRecord = (IDataHelper<SystemRecord>)ConfigrationObjectManager.Get("SystemRecord");
            loadingForm = new LoadingForm();
            this.id = id;
            this.categoryUserControl = categoryUserControl;
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
                    if(id == 0)
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

        private async void AddAndEditCategoryForm_Load(object sender, EventArgs e)
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
            if (nameTextBox.Text == string.Empty || typeComboBox.Text == string.Empty)
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
            category = new Category
            {
                Name = nameTextBox.Text,
                Type = typeComboBox.SelectedItem.ToString(),
                Details = detailsRichTextBox.Text,
                AddedDate = DateTime.Now,
            };
            //  Submit
            var result = await dataHelper.AddAsync(category);
            if (result == 0)
            {
                return false;
            }
            else
            {
                //  Save system records
                SystemRecord systemRecord = new SystemRecord
                {
                    Title = "Add Category Operation",
                    Username = Properties.Settings.Default.UserName,
                    Details = "New category is added: " + category.Name,
                    AddedDate = DateTime.Now,
                };
                await dataHelperSystemRecord.AddAsync(systemRecord);
                categoryUserControl.LoadData();
                return true;
            }
        }

        private async Task<bool> EditData()
        {
            //  Set Data
            category = new Category
            {
                Id = id,
                Name = nameTextBox.Text,
                Type = typeComboBox.SelectedItem.ToString(),
                Details = detailsRichTextBox.Text,
                AddedDate = DateTime.Now,
            };
            //  Submit
            var result = await dataHelper.EditAsync(category);
            if (result == 0)
            {
                return false;
            }
            else
            {
                //  Save system records
                SystemRecord systemRecord = new SystemRecord
                {
                    Title = "Edit Category Operation",
                    Username = Properties.Settings.Default.UserName,
                    Details = "Category is Edited: " + category.Name,
                    AddedDate = DateTime.Now,
                };
                await dataHelperSystemRecord.AddAsync(systemRecord);
                categoryUserControl.LoadData();
                return true;
            }
        }

        private async void SetFieldData()
        {
            if (id != 0)
            {
                category = await dataHelper.FindAsync(id);
                if (category != null)
                {
                    nameTextBox.Text = category.Name;
                    balanceTextBox.Text = category.Balance.ToString();
                    typeComboBox.SelectedItem = category.Type;
                    detailsRichTextBox.Text = category.Details;
                }
                else
                {
                    MessageCollection.ShowServerError();
                }

            }
        }

        
        #endregion

    }
}
