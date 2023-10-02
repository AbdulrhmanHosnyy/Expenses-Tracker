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

namespace ExpensesTracker.GUI.UserGUI
{
    public partial class AddAndEditUserForm : Form
    {
        //  Variables
        private readonly int id;
        private readonly UserUserControl userUserControl;
        private User user;
        private readonly bool firstStart;
        private readonly IDataHelper<User> dataHelper;
        private readonly IDataHelper<UserPermission> dataHelperUserPermission;
        private readonly IDataHelper<SystemRecord> dataHelperSystemRecord;
        private readonly LoadingForm loadingForm;
        private Dictionary<string, bool> ListOFPermissions = new Dictionary<string, bool>();

        public AddAndEditUserForm(int id, UserUserControl userUserControl, bool firstStart)
        {
            InitializeComponent();
            dataHelper = (IDataHelper<User>)ConfigrationObjectManager.Get("User");
            dataHelperUserPermission = (IDataHelper<UserPermission>)ConfigrationObjectManager.Get("UserPermission");
            dataHelperSystemRecord = (IDataHelper<SystemRecord>)ConfigrationObjectManager.Get("SystemRecord");
            loadingForm = new LoadingForm();
            this.id = id;
            this.userUserControl = userUserControl;

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
                    if (firstStart)
                    {
                        MessageBox.Show("Rerun the program");
                        Application.Exit();
                    }
                    else
                    {
                        Close();
                    }
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

        private async void AddAndEditUserForm_Load(object sender, EventArgs e)
        {
            //  Set Field
            loadingForm.Show();
            SetFieldData();
            loadingForm.Hide();
            if (firstStart)
            {
                saveButton.Enabled = false;
            }
        }

        private void AddAndEditUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (firstStart)
            {
                Application.Exit();
            }
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
            if (fullNameTextBox.Text == string.Empty
                || usernameTextBox.Text == string.Empty
                || passwordTextBox.Text == string.Empty)
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
            user = new User
            {
                FullName = fullNameTextBox.Text,
                UserName = usernameTextBox.Text,
                Password = passwordTextBox.Text,
                Email = emailTextBox.Text,
                Phone = phoneTextBox.Text,
                AddedDate = DateTime.Now,
            };
            //  Submit
            var result = await dataHelper.AddAsync(user);
            if (result == 0)
            {
                return false;
            }
            else
            {
                //  Add permissions
                var data = await dataHelper.GetAllDataAsync();
                var userId = data.Select(x => x.Id).Last();
                SetPermissions();
                //  Loop into user permissions
                for (int i = 0; i < ListOFPermissions.Count; i++)
                {
                    UserPermission userPermission = new UserPermission
                    {
                        UserId = userId,
                        Key = ListOFPermissions.Keys.ToList()[i],
                        Value = ListOFPermissions.Values.ToList()[i]
                    };
                    await dataHelperUserPermission.AddAsync(userPermission);
                }
                //  Save system records
                SystemRecord systemRecord = new SystemRecord
                {
                    Title = "Add User Operation",
                    Username = Properties.Settings.Default.UserName,
                    Details = "New user is added: " + user.FullName,
                    AddedDate = DateTime.Now,
                };
                await dataHelperSystemRecord.AddAsync(systemRecord);
                userUserControl.LoadData();
                return true;
            }
        }

        private void SetPermissions()
        {
            ListOFPermissions.Clear();
            ListOFPermissions.Add(homeCheckBox.Name, homeCheckBox.Checked);
            ListOFPermissions.Add(categoryCheckBox.Name, categoryCheckBox.Checked);
            ListOFPermissions.Add(customerCheckBox.Name, customerCheckBox.Checked);
            ListOFPermissions.Add(supplierCheckBox.Name, supplierCheckBox.Checked);
            ListOFPermissions.Add(projectCheckBox.Name, projectCheckBox.Checked);
            ListOFPermissions.Add(userCheckBox.Name, userCheckBox.Checked);
            ListOFPermissions.Add(settingsCheckBox.Name, settingsCheckBox.Checked);
            ListOFPermissions.Add(systemLogCheckBox.Name, systemLogCheckBox.Checked);
            //
            ListOFPermissions.Add(categoryAccessCheckBox.Name, categoryAccessCheckBox.Checked);
            ListOFPermissions.Add(customerAccessCheckBox.Name, customerAccessCheckBox.Checked);
            ListOFPermissions.Add(supplierAccessCheckBox.Name, supplierAccessCheckBox.Checked);
            ListOFPermissions.Add(projectAccessCheckBox.Name, projectAccessCheckBox.Checked);
            ListOFPermissions.Add(userAccessCheckBox.Name, userAccessCheckBox.Checked);
            ListOFPermissions.Add(incomeAccessCheckBox.Name, incomeAccessCheckBox.Checked);
            ListOFPermissions.Add(outcomeAccessCheckBox.Name, outcomeAccessCheckBox.Checked);
            //
            ListOFPermissions.Add(addCheckBox.Name, addCheckBox.Checked);
            ListOFPermissions.Add(deleteCheckBox.Name, deleteCheckBox.Checked);
            ListOFPermissions.Add(editCheckBox.Name, editCheckBox.Checked);
            ListOFPermissions.Add(exportCheckBox.Name, exportCheckBox.Checked);
            ListOFPermissions.Add(searchCheckBox.Name, searchCheckBox.Checked);
            ListOFPermissions.Add(openCheckBox.Name, openCheckBox.Checked);

        }

        private async Task<bool> EditData()
        {
            //  Set Data
            user = new User
            {
                Id = id,
                FullName = fullNameTextBox.Text,
                UserName = usernameTextBox.Text,
                Password = passwordTextBox.Text,
                Email = emailTextBox.Text,
                Phone = phoneTextBox.Text,
                AddedDate = DateTime.Now,
            };
            //  Submit
            var result = await dataHelper.EditAsync(user);
            if (result == 0)
            {
                return false;
            }
            else
            {
                //  Add permissions
                var permissionsData = await dataHelperUserPermission.GetAllDataAsync();
                var ListOfPermissionsId = permissionsData.Where(x => x.UserId == id).Select(x => x.Id).ToList();
                //  Loop into ListOfPermissions to delete
                for (int i = 0; i < ListOfPermissionsId.Count; i++)
                {
                    await dataHelperUserPermission.DeleteAsync(ListOfPermissionsId[i]);
                }
                SetPermissions();
                //  Loop into user permissions
                for (int i = 0; i < ListOFPermissions.Count; i++)
                {
                    UserPermission userPermission = new UserPermission
                    {
                        UserId = id,
                        Key = ListOFPermissions.Keys.ToList()[i],
                        Value = ListOFPermissions.Values.ToList()[i]
                    };
                    await dataHelperUserPermission.AddAsync(userPermission);
                }
                //  Save system records
                SystemRecord systemRecord = new SystemRecord
                {
                    Title = "Edit User Operation",
                        Username = Properties.Settings.Default.UserName,
                    Details = "User is Edited: " + user.FullName,
                    AddedDate = DateTime.Now,
                };
                await dataHelperSystemRecord.AddAsync(systemRecord);
                userUserControl.LoadData();
                return true;
            }
        }

        private async void SetFieldData()
        {
            if (id != 0)
            {
                user = await dataHelper.FindAsync(id);
                var permissionsData = await dataHelperUserPermission.GetAllDataAsync();
                List<bool> ListOfPermissions = permissionsData.Where(x => x.UserId == id).Select(x => x.Value).ToList();
                if (user != null)
                {
                    fullNameTextBox.Text = user.FullName;
                    usernameTextBox.Text = user.UserName;
                    passwordTextBox.Text = user.Password;
                    emailTextBox.Text = user.Email;
                    phoneTextBox.Text = user.Phone;

                    //  Set Current permissions:
                    homeCheckBox.Checked = ListOfPermissions[0];
                    categoryCheckBox.Checked = ListOfPermissions[1];
                    customerCheckBox.Checked = ListOfPermissions[2];
                    supplierCheckBox.Checked = ListOfPermissions[3];
                    projectCheckBox.Checked = ListOfPermissions[4];
                    userCheckBox.Checked = ListOfPermissions[5];
                    settingsCheckBox.Checked = ListOfPermissions[6];
                    systemLogCheckBox.Checked = ListOfPermissions[7];

                    categoryAccessCheckBox.Checked = ListOfPermissions[8];
                    customerAccessCheckBox.Checked = ListOfPermissions[9];
                    supplierAccessCheckBox.Checked = ListOfPermissions[10];
                    projectAccessCheckBox.Checked = ListOfPermissions[11];
                    userAccessCheckBox.Checked = ListOfPermissions[12];
                    incomeAccessCheckBox.Checked = ListOfPermissions[13];
                    outcomeAccessCheckBox.Checked = ListOfPermissions[14];

                    addCheckBox.Checked = ListOfPermissions[15];
                    deleteCheckBox.Checked = ListOfPermissions[16];
                    editCheckBox.Checked = ListOfPermissions[17];
                    exportCheckBox.Checked = ListOfPermissions[18];
                    searchCheckBox.Checked = ListOfPermissions[19];
                    openCheckBox.Checked = ListOfPermissions[20];

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
