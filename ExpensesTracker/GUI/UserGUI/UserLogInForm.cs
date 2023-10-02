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
    public partial class UserLogInForm : Form
    {
        //  Variables
        private readonly int id;
        private readonly UserUserControl userUserControl;
        private User user;
        private readonly IDataHelper<User> dataHelper;
        private readonly IDataHelper<UserPermission> dataHelperUserPermission;
        private readonly IDataHelper<SystemRecord> dataHelperSystemRecord;
        private readonly LoadingForm loadingForm;
        private Dictionary<string, bool> ListOFPermissions = new Dictionary<string, bool>();

        public UserLogInForm()
        {
            InitializeComponent();
            dataHelper = (IDataHelper<User>)ConfigrationObjectManager.Get("User");
            dataHelperUserPermission = (IDataHelper<UserPermission>)ConfigrationObjectManager.Get("UserPermission");
            dataHelperSystemRecord = (IDataHelper<SystemRecord>)ConfigrationObjectManager.Get("SystemRecord");
            loadingForm = new LoadingForm();
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
                var username = usernameTextBox.Text;
                var password = passwordTextBox.Text;
                loadingForm.Show();
                var userLoginResult = await Task.Run(() => LogIn(username, password));
                if (userLoginResult == 1)
                {
                    Main main = new Main();
                    main.Show();
                    Hide();
                }
                else if (userLoginResult == 2)
                {
                    MessageCollection.ShowServerError();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }
                loadingForm.Hide();
            }
        }
        private void UserLogInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Methods

        private bool isFieldEmpty()
        {
            if (usernameTextBox.Text == string.Empty
                || passwordTextBox.Text == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int LogIn(string username, string password)
        {
            try
            {
                User user = dataHelper.GetAllData().FirstOrDefault(x => x.UserName == username && x.Password == password);
                if (user != null)
                {
                    Properties.Settings.Default.UserName = user.FullName;
                    Properties.Settings.Default.Save();
                    //  Get permissions
                    var listOfPermissions = dataHelperUserPermission.GetAllData().
                        Where(x => x.UserId == user.Id);
                    //  Set user permissions 
                    UserPermissionsManager.ClearPermissions();
                    foreach (var permission in listOfPermissions)
                    {
                        UserPermissionsManager.Register(permission.Key, permission.Value);
                    }
                    //  Save system records
                    SystemRecord systemRecord = new SystemRecord
                    {
                        Title = "Login Operation",
                        Username = Properties.Settings.Default.UserName,
                        Details = "Login successfully: " + user.FullName,
                        AddedDate = DateTime.Now,
                    };
                    dataHelperSystemRecord.Add(systemRecord);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 2;
            }
        }

        #endregion

        
    }
}
