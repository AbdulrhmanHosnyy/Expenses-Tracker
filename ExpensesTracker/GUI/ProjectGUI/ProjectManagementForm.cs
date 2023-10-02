using ExpensesTracker.Code;
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

namespace ExpensesTracker.GUI.ProjectGUI
{
    public partial class ProjectManagementForm : Form
    {
        private readonly int projectId;
        private readonly IDataHelper<Income> IncomeDataHelper;
        private readonly IDataHelper<Outcome> OutcomeDataHelper;
        private double TotalIncome;
        private double TotalOutcome;

        public ProjectManagementForm(int ProjectId)
        {
            IncomeDataHelper = (IDataHelper<Income>)ConfigrationObjectManager.Get("Income");
            OutcomeDataHelper = (IDataHelper<Outcome>)ConfigrationObjectManager.Get("Outcome");
            InitializeComponent();
            projectId = ProjectId;
            LoadOutcomeUI();
            LoadIncomeUI();
        }

        private void LoadOutcomeUI()
        {
            //  Load Outcome UI
            OutcomeGUI.OutcomeUserControl outcomeGUI = new OutcomeGUI.OutcomeUserControl(projectId);
            outcomeGUI.Dock = DockStyle.Fill;
            outcomePanel.Controls.Add(outcomeGUI);
        }

        private void LoadIncomeUI()
        {
            //  Load Income UI
            IncomeGUI.IncomeUserControl incomeGUI = new IncomeGUI.IncomeUserControl(projectId);
            incomeGUI.Dock = DockStyle.Fill;
            incomePanel.Controls.Add(incomeGUI);
        }

        private void ProjectManagementForm_Activated(object sender, EventArgs e)
        {
            GetTotalData();
        }

        private void GetTotalData()
        {
            //  Get Data
            try
            {
                TotalIncome = IncomeDataHelper.GetAllData().Where(x => x.ProjectId == projectId)
                              .Select(x => x.Amount).ToArray().Sum();
                TotalOutcome = OutcomeDataHelper.GetAllData().Where(x => x.ProjectId == projectId)
                             .Select(x => x.Amount).ToArray().Sum();
            }
            catch
            {

            }

            var TotalRevenue = TotalIncome - TotalOutcome;
            //  Set
            IncomeLabel.Text = "Income " + TotalIncome.ToString("#0.00");
            OutcomeLabel.Text = "Outcome " + TotalOutcome.ToString("#0.00");
            RevenueLabel.Text = "Revenue " + TotalRevenue.ToString("#0.00");

        }
    }
}
