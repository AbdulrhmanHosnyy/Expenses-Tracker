using ExpensesTracker.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesTracker
{
    public partial class Main : Form
    {
        private readonly PageManager pageManager;
        public Main()
        {
            InitializeComponent();
            pageManager = new PageManager(this);
            //  Load home page:
            pageManager.LoadPage(GUI.HomeGUI.HomeUserControl.Instance());
            setPermissions();
        }

        #region Events
        private void homeButton_Click(object sender, EventArgs e)
        {
            //  Load home page:
            pageManager.LoadPage(GUI.HomeGUI.HomeUserControl.Instance());
        }
        private void categoriesButton_Click(object sender, EventArgs e)
        {
            //  Load category page:
            pageManager.LoadPage(GUI.CategoryGUI.CategoryUserControl.Instance());
        }
        private void customersButton_Click(object sender, EventArgs e)
        {
            //  Load customer page:
            pageManager.LoadPage(GUI.CustomerGUI.CustomerUserControl.Instance());
        }
        private void suppliersButton_Click(object sender, EventArgs e)
        {
            //  Load supplier page:
            pageManager.LoadPage(GUI.SupplierGUI.SupplierUserControl.Instance());
        }
        private void projectsButton_Click(object sender, EventArgs e)
        {
            //  Load project page:
            pageManager.LoadPage(GUI.ProjectGUI.ProjectUserControl.Instance());
        }
        private void usersButton_Click(object sender, EventArgs e)
        {
            //  Load User page:
            pageManager.LoadPage(GUI.UserGUI.UserUserControl.Instance());
        }
        private void settingsButton_Click(object sender, EventArgs e)
        {
            //  Load Settings page:
            GUI.SettingsGUI.SettingsForm settingsForm = new GUI.SettingsGUI.SettingsForm(false);
            settingsForm.Show();
        }
        private void logOutButton_Click(object sender, EventArgs e)
        {
            GUI.UserGUI.UserLogInForm logInForm = new GUI.UserGUI.UserLogInForm();
            logInForm.Show();
            Hide();
        }
        private void systemLogButton_Click(object sender, EventArgs e)
        {
            //  Load System Record page:
            pageManager.LoadPage(GUI.SystemRecordGUI.SystemRecordUserControl.Instance());
        }
        private void aboutButton_Click(object sender, EventArgs e)
        {
            //  Load About page:
            GUI.AboutGUI.About about = new GUI.AboutGUI.About();
            about.Show();
        }
        private void helpButton_Click(object sender, EventArgs e)
        {
            //  Load hlp url 
            var url = "https://www.youtube.com";
            Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Methods

        private void setPermissions()
        {
            if (!UserPermissionsManager.Get("homeCheckBox"))
            {
                homeButton.Visible = false;
            }
            if (!UserPermissionsManager.Get("categoryCheckBox"))
            {
                categoriesButton.Visible = false;
            }
            if (!UserPermissionsManager.Get("customerCheckBox"))
            {
                customersButton.Visible = false;
            }
            if (!UserPermissionsManager.Get("supplierCheckBox"))
            {
                suppliersButton.Visible = false;
            }
            if (!UserPermissionsManager.Get("projectCheckBox"))
            {
                projectsButton.Visible = false;
            }
            if (!UserPermissionsManager.Get("userCheckBox"))
            {
                usersButton.Visible = false;
            }
            if (!UserPermissionsManager.Get("settingsCheckBox"))
            {
                settingsButton.Visible = false;
            }
            if (!UserPermissionsManager.Get("systemLogCheckBox"))
            {
                systemLogButton.Visible = false;
            }
        }

        #endregion






     
    }
}
