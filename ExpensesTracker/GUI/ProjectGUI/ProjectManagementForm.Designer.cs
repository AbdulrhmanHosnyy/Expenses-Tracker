namespace ExpensesTracker.GUI.ProjectGUI
{
    partial class ProjectManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            IncomeLabel = new Label();
            OutcomeLabel = new Label();
            RevenueLabel = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            incomePanel = new Panel();
            outcomePanel = new Panel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(IncomeLabel);
            panel1.Controls.Add(OutcomeLabel);
            panel1.Controls.Add(RevenueLabel);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 426);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 75);
            panel1.TabIndex = 0;
            // 
            // IncomeLabel
            // 
            IncomeLabel.BackColor = Color.FromArgb(224, 224, 224);
            IncomeLabel.BorderStyle = BorderStyle.FixedSingle;
            IncomeLabel.Dock = DockStyle.Right;
            IncomeLabel.Location = new Point(276, 0);
            IncomeLabel.Name = "IncomeLabel";
            IncomeLabel.Size = new Size(188, 75);
            IncomeLabel.TabIndex = 3;
            IncomeLabel.Text = "Income";
            IncomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OutcomeLabel
            // 
            OutcomeLabel.BackColor = Color.FromArgb(224, 224, 224);
            OutcomeLabel.BorderStyle = BorderStyle.FixedSingle;
            OutcomeLabel.Dock = DockStyle.Right;
            OutcomeLabel.Location = new Point(464, 0);
            OutcomeLabel.Name = "OutcomeLabel";
            OutcomeLabel.Size = new Size(188, 75);
            OutcomeLabel.TabIndex = 2;
            OutcomeLabel.Text = "Outcome";
            OutcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RevenueLabel
            // 
            RevenueLabel.BackColor = Color.FromArgb(224, 224, 224);
            RevenueLabel.BorderStyle = BorderStyle.FixedSingle;
            RevenueLabel.Dock = DockStyle.Right;
            RevenueLabel.Location = new Point(652, 0);
            RevenueLabel.Name = "RevenueLabel";
            RevenueLabel.Size = new Size(188, 75);
            RevenueLabel.TabIndex = 1;
            RevenueLabel.Text = "Revenue";
            RevenueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.CadetBlue;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(271, 75);
            label1.TabIndex = 0;
            label1.Text = "Expenses Tracker";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(incomePanel, 0, 0);
            tableLayoutPanel1.Controls.Add(outcomePanel, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(840, 426);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // incomePanel
            // 
            incomePanel.Dock = DockStyle.Fill;
            incomePanel.Location = new Point(3, 3);
            incomePanel.Name = "incomePanel";
            incomePanel.Size = new Size(414, 420);
            incomePanel.TabIndex = 0;
            // 
            // outcomePanel
            // 
            outcomePanel.Dock = DockStyle.Fill;
            outcomePanel.Location = new Point(423, 3);
            outcomePanel.Name = "outcomePanel";
            outcomePanel.Size = new Size(414, 420);
            outcomePanel.TabIndex = 1;
            // 
            // ProjectManagementForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 501);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ProjectManagementForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProjectManagementForm";
            WindowState = FormWindowState.Maximized;
            Activated += ProjectManagementForm_Activated;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label IncomeLabel;
        private Label OutcomeLabel;
        private Label RevenueLabel;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel incomePanel;
        private Panel outcomePanel;
    }
}