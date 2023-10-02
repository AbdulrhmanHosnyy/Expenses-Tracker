using ExpensesTracker.Code;
using ExpensesTracker.Properties;
using ExpensesTrackerCore;
using ExpensesTrackerData;
using Microsoft.Extensions.Configuration.UserSecrets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesTracker
{
    public partial class Starter : Form
    {
        private readonly IDataHelper<User> dataHelper;

        public Starter()
        {
            InitializeComponent();
            dataHelper = (IDataHelper<User>)ConfigrationObjectManager.Get("User");
        }

        #region Events
        private void Starter_Load(object sender, EventArgs e)
        {
            CheckConnection();
        }
        #endregion

        #region Methods
        private async void CheckConnection()
        {
            stateLabel.Text = "Connecting to database";
            ExpensesTrackerData.SqlServer.AppDbContext appDbContext =
                new ExpensesTrackerData.SqlServer.AppDbContext();
            if (await appDbContext.Database.CanConnectAsync())
            {
                var data = await dataHelper.GetAllDataAsync();
                if (data.Count > 0)
                {
                    GUI.UserGUI.UserLogInForm logInForm = new GUI.UserGUI.UserLogInForm();
                    logInForm.Show();
                    Hide();
                }
                else
                {
                    GUI.UserGUI.AddAndEditUserForm addAndEditUserForm = new GUI.UserGUI
                        .AddAndEditUserForm(0, new GUI.UserGUI.UserUserControl(), true);
                    addAndEditUserForm.Show();
                    Hide();
                }
            }
            else
            {
                Hide();
                var result = MessageBox.Show("Connection error click yes to reconnect, no to exit", "Connection Error",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    GUI.SettingsGUI.SettingsForm settingsForm = new GUI.SettingsGUI.SettingsForm(true);
                    settingsForm.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
        #endregion  
    }
}
