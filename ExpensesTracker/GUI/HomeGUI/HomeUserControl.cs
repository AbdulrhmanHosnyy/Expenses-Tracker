using ExpensesTracker.Code;
using ExpensesTracker.GUI.CategoryGUI;
using ExpensesTracker.GUI.CustomerGUI;
using ExpensesTracker.GUI.IncomeGUI;
using ExpensesTracker.GUI.OutcomeGUI;
using ExpensesTracker.GUI.ProjectGUI;
using ExpensesTracker.GUI.SupplierGUI;
using ExpensesTracker.GUI.UserGUI;
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

namespace ExpensesTracker.GUI.HomeGUI
{
    public partial class HomeUserControl : UserControl
    {
        private static HomeUserControl homeUserControl;
        private int ProjectId;
        private readonly IDataHelper<Project> dataHelper;

        public HomeUserControl()
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Project>)ConfigrationObjectManager.Get("Project");
            setPermissions();
            SetGeneralSettings();
            SetHello();
        }
        #region Events
        public static HomeUserControl Instance()
        {
            return homeUserControl ?? new HomeUserControl();
        }
        private void addCategoriesButton_Click(object sender, EventArgs e)
        {
            AddAndEditCategoryForm addAndEditCategoryForm =
                new AddAndEditCategoryForm(0, new CategoryUserControl());
            addAndEditCategoryForm.Show();
        }

        private void addCustomersButton_Click(object sender, EventArgs e)
        {
            AddAndEditCustomerForm addAndEditCustomerForm =
                new AddAndEditCustomerForm(0, new CustomerUserControl());
            addAndEditCustomerForm.Show();
        }

        private void addSuppliersButton_Click(object sender, EventArgs e)
        {
            AddAndEditSupplierForm addAndEditSupplierForm =
                new AddAndEditSupplierForm(0, new SupplierUserControl());
            addAndEditSupplierForm.Show();
        }

        private void addProjectsButton_Click(object sender, EventArgs e)
        {
            AddAndEditProjectForm addAndEditProjectForm =
                new AddAndEditProjectForm(0, new ProjectUserControl());
            addAndEditProjectForm.Show();
        }

        private void addUsersButton_Click(object sender, EventArgs e)
        {
            AddAndEditUserForm addAndEditUserForm =
                new AddAndEditUserForm(0, new UserUserControl(), false);
            addAndEditUserForm.Show();
        }

        private void adddPaymentButton_Click(object sender, EventArgs e)
        {
            if(ProjectId > 0)
            {
                AddAndEditIncomeForm addAndEditIncomeForm = 
                    new AddAndEditIncomeForm(0, ProjectId, new IncomeUserControl(ProjectId));
                addAndEditIncomeForm.Show();
            }
            else
            {
                MessageBox.Show("Kindly, Pick a project");
            }
        }

        private void addCollectButton_Click(object sender, EventArgs e)
        {
            if (ProjectId > 0)
            {
                AddAndEditOutcomeForm addAndEditOutcomeForm = 
                    new AddAndEditOutcomeForm(0, ProjectId, new OutcomeUserControl(ProjectId));
                addAndEditOutcomeForm.Show();
            }
            else
            {
                MessageBox.Show("Kindly, Pick a project");
            }       
        }
        private async void HomeUserControl_Load(object sender, EventArgs e)
        {
            //  Get List of Suppliers 
            var projectsList = await dataHelper.GetAllDataAsync();
            projectsComboBox.DataSource = projectsList.Select(x => x.Name).ToList(); // Fill
                                                                                     // Auto complete
            AutoCompleteStringCollection supplierAutoCompleteStringCollection = new AutoCompleteStringCollection();
            supplierAutoCompleteStringCollection.AddRange(projectsList.Select(x => x.Name).ToArray());
            projectsComboBox.AutoCompleteCustomSource = supplierAutoCompleteStringCollection;
            projectsList.Clear();  // Clear
        }
        private async void projectsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var projectName = projectsComboBox.SelectedItem.ToString();
            ProjectId = dataHelper.GetAllData().Where(x => x.Name == projectName).
                Select(x => x.Id).FirstOrDefault();
        }
        #endregion

        #region Methods

        private void setPermissions()
        {
            if (!UserPermissionsManager.Get("categoryAccessCheckBox"))
            {
                addCategoriesButton.Visible = false;
            }
            if (!UserPermissionsManager.Get("customerAccessCheckBox"))
            {
                addCustomersButton.Visible = false;
            }
            if (!UserPermissionsManager.Get("supplierAccessCheckBox"))
            {
                addSuppliersButton.Visible = false;
            }
            if (!UserPermissionsManager.Get("projectAccessCheckBox"))
            {
                addProjectsButton.Visible = false;
            }
            if (!UserPermissionsManager.Get("userAccessCheckBox"))
            {
                addUsersButton.Visible = false;
            }
            if (!UserPermissionsManager.Get("incomeAccessCheckBox"))
            {
                adddPaymentButton.Visible = false;
            }
            if (!UserPermissionsManager.Get("outcomeAccessCheckBox"))
            {
                addCollectButton.Visible = false;
            }
        }

        private void SetGeneralSettings()
        {
            companyNameLabel.Text = Properties.Settings.Default.CompanyName;
            if (Properties.Settings.Default.CompanyLogo != String.Empty)
            {
                var ImageAsBytes = Convert.FromBase64String(Properties.Settings.Default.CompanyLogo);

                using (MemoryStream ms = new MemoryStream(ImageAsBytes))
                {
                    logoPictureBox.Image = Image.FromStream(ms);
                }
            }

        }

        private void SetHello()
        {
            welcomeLabel.Text = "Welcome " + Properties.Settings.Default.UserName;
        }

        #endregion



       
    }
}
