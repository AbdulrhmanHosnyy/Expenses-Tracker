using ExpensesTracker.GUI.GUI_Loading;
using ExpensesTrackerData.SqlServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesTracker.GUI.SettingsGUI
{
    public partial class SettingsForm : Form
    {
        private LoadingForm loadingForm;

        private readonly bool firstStart;
        public SettingsForm(bool firstStart)
        {
            InitializeComponent();
            SetGeneralSettings();
            loadingForm = new LoadingForm();
        }

        #region Events
        private void saveGenralSettingsButton_Click(object sender, EventArgs e)
        {
            SaveGeneralSettings();
        }
        private void saveConnectionStringButton_Click(object sender, EventArgs e)
        {
            var Server = serverTextBox.Text;
            var Database = databaseTextBox.Text;
            var Timeout = timeOutNumericUpDown.Value;
            var Username = usernameTextBox.Text;
            var Password = passwordTextBox.Text;
            if (localConnectionRadioButton.Checked)
            {
                // Local connection
                SetLocalConnection(Server, Database);
            }
            else
            {
                // Network connection
                SetNetworkConnection(Server, Database, Username, Password, Timeout);
            }
            MessageBox.Show("Saved Successfuly, Rerun the program");
            Application.Exit();
        }
        private void localConnectionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            usernameTextBox.Enabled = false;
            passwordTextBox.Enabled = false;
            timeOutNumericUpDown.Enabled = false;
        }
        private void networkConnectionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            usernameTextBox.Enabled = true;
            passwordTextBox.Enabled = true;
            timeOutNumericUpDown.Enabled = true;
        }
        private void uploadLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose Company Logo";
            openFileDialog.RestoreDirectory = true;
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                logoPictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
        private async void backUpButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Choose backup path and avoid chosing C";
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackUpRestoreHelper backUpRestoreHelper = new BackUpRestoreHelper();
                loadingForm.Show();
                string processResult =
                    await Task.Run(() => backUpRestoreHelper.BackUp(folderBrowserDialog.SelectedPath));
                if (processResult == "1")
                {
                    loadingForm.Hide();
                    MessageBox.Show("Successful Backup");
                }
                else
                {
                    loadingForm.Hide();
                    MessageBox.Show("Failed Backup: " + processResult);
                }
            }
        }
        private async void restoreButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose backup file";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "Bak File|*.bak";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackUpRestoreHelper backUpRestoreHelper = new BackUpRestoreHelper();
                loadingForm.Show();
                string processResult =
                    await Task.Run(() => backUpRestoreHelper.Restore(openFileDialog.FileName));
                if (processResult == "1")
                {
                    loadingForm.Hide();
                    MessageBox.Show("Successful Restore");
                }
                else
                {
                    loadingForm.Hide();
                    MessageBox.Show("Failed Restore: " + processResult);
                }
            }
        }
        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(firstStart)
            {
                Application.Exit();
            }
        }

        #endregion

        #region Methods
        private void SaveGeneralSettings()
        {
            Properties.Settings.Default.CompanyName = companyTextBox.Text;
            Properties.Settings.Default.HideNotificationInterval = Convert.ToInt32(notificationNumericUpDown.Value);
            Properties.Settings.Default.DataGridViewRowNo = Convert.ToInt32(dataRowNumericUpDown.Value);
            //  Save Picture
            using (MemoryStream ms = new MemoryStream())
            {
                logoPictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                Properties.Settings.Default.CompanyLogo = Convert.ToBase64String(ms.ToArray());
            }

            //  Save Settings
            Properties.Settings.Default.Save();
            MessageBox.Show("Saved Successfuly");

        }
        private void SetGeneralSettings()
        {
            companyTextBox.Text = Properties.Settings.Default.CompanyName;
            notificationNumericUpDown.Value = Convert.ToInt32(Properties.Settings.Default.HideNotificationInterval / 1000);
            dataRowNumericUpDown.Value = Properties.Settings.Default.DataGridViewRowNo;
            if (Properties.Settings.Default.CompanyLogo != String.Empty)
            {
                var ImageAsBytes = Convert.FromBase64String(Properties.Settings.Default.CompanyLogo);

                using (MemoryStream ms = new MemoryStream(ImageAsBytes))
                {
                    logoPictureBox.Image = Image.FromStream(ms);
                }
            }

        }
        private void SetLocalConnection(string server, string database)
        {
            var ConString = "Server = " + server + " ; Database = " + database +
                " ; Integrated Security = SSPI ; TrustServerCertificate = True";
            Properties.Settings.Default.SqlServerConString = ConString;
            Properties.Settings.Default.Save();


        }
        private void SetNetworkConnection(string server, string database, string username, string password, decimal timeout)
        {
            var ConString = "Server = " + server + " ; Database = " + database + " ; User Id = " +
                username + " ; Password = " + password + " ; Timeout = " + timeout +
                " ; Integrated Security = SSPI ; TrustServerCertificate = True";
            Properties.Settings.Default.SqlServerConString = ConString;
            Properties.Settings.Default.Save();
        }
        #endregion


     
    }
}
