namespace ExpensesTracker
{
    partial class Main
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            homeButton = new Button();
            categoriesButton = new Button();
            customersButton = new Button();
            suppliersButton = new Button();
            projectsButton = new Button();
            usersButton = new Button();
            settingsButton = new Button();
            logOutButton = new Button();
            systemLogButton = new Button();
            helpButton = new Button();
            aboutButton = new Button();
            containerPanel = new Panel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(homeButton);
            flowLayoutPanel1.Controls.Add(categoriesButton);
            flowLayoutPanel1.Controls.Add(customersButton);
            flowLayoutPanel1.Controls.Add(suppliersButton);
            flowLayoutPanel1.Controls.Add(projectsButton);
            flowLayoutPanel1.Controls.Add(usersButton);
            flowLayoutPanel1.Controls.Add(settingsButton);
            flowLayoutPanel1.Controls.Add(logOutButton);
            flowLayoutPanel1.Controls.Add(systemLogButton);
            flowLayoutPanel1.Controls.Add(helpButton);
            flowLayoutPanel1.Controls.Add(aboutButton);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 426);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(959, 55);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // homeButton
            // 
            homeButton.BackgroundImageLayout = ImageLayout.Center;
            homeButton.Image = Properties.Resources.Home;
            homeButton.ImageAlign = ContentAlignment.MiddleLeft;
            homeButton.Location = new Point(10, 10);
            homeButton.Margin = new Padding(5);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(110, 45);
            homeButton.TabIndex = 0;
            homeButton.Text = "Home";
            homeButton.TextAlign = ContentAlignment.MiddleRight;
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += homeButton_Click;
            // 
            // categoriesButton
            // 
            categoriesButton.Image = Properties.Resources.Categories;
            categoriesButton.ImageAlign = ContentAlignment.MiddleLeft;
            categoriesButton.Location = new Point(130, 10);
            categoriesButton.Margin = new Padding(5);
            categoriesButton.Name = "categoriesButton";
            categoriesButton.Size = new Size(136, 45);
            categoriesButton.TabIndex = 1;
            categoriesButton.Text = "Categories";
            categoriesButton.TextAlign = ContentAlignment.MiddleRight;
            categoriesButton.UseVisualStyleBackColor = true;
            categoriesButton.Click += categoriesButton_Click;
            // 
            // customersButton
            // 
            customersButton.Image = Properties.Resources.Customers;
            customersButton.ImageAlign = ContentAlignment.MiddleLeft;
            customersButton.Location = new Point(276, 10);
            customersButton.Margin = new Padding(5);
            customersButton.Name = "customersButton";
            customersButton.Size = new Size(151, 45);
            customersButton.TabIndex = 2;
            customersButton.Text = "Customers";
            customersButton.TextAlign = ContentAlignment.MiddleRight;
            customersButton.UseVisualStyleBackColor = true;
            customersButton.Click += customersButton_Click;
            // 
            // suppliersButton
            // 
            suppliersButton.Image = Properties.Resources.Suppliers;
            suppliersButton.ImageAlign = ContentAlignment.MiddleLeft;
            suppliersButton.Location = new Point(437, 10);
            suppliersButton.Margin = new Padding(5);
            suppliersButton.Name = "suppliersButton";
            suppliersButton.Size = new Size(126, 45);
            suppliersButton.TabIndex = 3;
            suppliersButton.Text = "Suppliers";
            suppliersButton.TextAlign = ContentAlignment.MiddleRight;
            suppliersButton.UseVisualStyleBackColor = true;
            suppliersButton.Click += suppliersButton_Click;
            // 
            // projectsButton
            // 
            projectsButton.Image = Properties.Resources.Projects;
            projectsButton.ImageAlign = ContentAlignment.MiddleLeft;
            projectsButton.Location = new Point(573, 10);
            projectsButton.Margin = new Padding(5);
            projectsButton.Name = "projectsButton";
            projectsButton.Size = new Size(132, 45);
            projectsButton.TabIndex = 4;
            projectsButton.Text = "Projects";
            projectsButton.TextAlign = ContentAlignment.MiddleRight;
            projectsButton.UseVisualStyleBackColor = true;
            projectsButton.Click += projectsButton_Click;
            // 
            // usersButton
            // 
            usersButton.Image = Properties.Resources.User;
            usersButton.ImageAlign = ContentAlignment.TopLeft;
            usersButton.Location = new Point(715, 10);
            usersButton.Margin = new Padding(5);
            usersButton.Name = "usersButton";
            usersButton.Size = new Size(108, 45);
            usersButton.TabIndex = 6;
            usersButton.Text = "Users";
            usersButton.TextAlign = ContentAlignment.MiddleRight;
            usersButton.UseVisualStyleBackColor = true;
            usersButton.Click += usersButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.Image = Properties.Resources.Settings;
            settingsButton.ImageAlign = ContentAlignment.MiddleLeft;
            settingsButton.Location = new Point(10, 65);
            settingsButton.Margin = new Padding(5);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(131, 45);
            settingsButton.TabIndex = 5;
            settingsButton.Text = "Settings";
            settingsButton.TextAlign = ContentAlignment.MiddleRight;
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // logOutButton
            // 
            logOutButton.Image = Properties.Resources.Log_out;
            logOutButton.ImageAlign = ContentAlignment.MiddleLeft;
            logOutButton.Location = new Point(151, 65);
            logOutButton.Margin = new Padding(5);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(121, 45);
            logOutButton.TabIndex = 6;
            logOutButton.Text = "Log out";
            logOutButton.TextAlign = ContentAlignment.MiddleRight;
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // systemLogButton
            // 
            systemLogButton.Image = Properties.Resources.Records;
            systemLogButton.ImageAlign = ContentAlignment.TopLeft;
            systemLogButton.Location = new Point(282, 65);
            systemLogButton.Margin = new Padding(5);
            systemLogButton.Name = "systemLogButton";
            systemLogButton.Size = new Size(141, 45);
            systemLogButton.TabIndex = 9;
            systemLogButton.Text = "System Log";
            systemLogButton.TextAlign = ContentAlignment.MiddleRight;
            systemLogButton.UseVisualStyleBackColor = true;
            systemLogButton.Click += systemLogButton_Click;
            // 
            // helpButton
            // 
            helpButton.Image = Properties.Resources.Help;
            helpButton.ImageAlign = ContentAlignment.TopLeft;
            helpButton.Location = new Point(433, 65);
            helpButton.Margin = new Padding(5);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(107, 45);
            helpButton.TabIndex = 7;
            helpButton.Text = "Help";
            helpButton.TextAlign = ContentAlignment.MiddleRight;
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += helpButton_Click;
            // 
            // aboutButton
            // 
            aboutButton.Image = Properties.Resources.About;
            aboutButton.ImageAlign = ContentAlignment.TopLeft;
            aboutButton.Location = new Point(550, 65);
            aboutButton.Margin = new Padding(5);
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new Size(119, 45);
            aboutButton.TabIndex = 8;
            aboutButton.Text = "About";
            aboutButton.TextAlign = ContentAlignment.MiddleRight;
            aboutButton.UseVisualStyleBackColor = true;
            aboutButton.Click += aboutButton_Click;
            // 
            // containerPanel
            // 
            containerPanel.BackColor = Color.White;
            containerPanel.Dock = DockStyle.Fill;
            containerPanel.Location = new Point(0, 0);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(959, 426);
            containerPanel.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 481);
            Controls.Add(containerPanel);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExpensesTracker";
            WindowState = FormWindowState.Maximized;
            FormClosed += Main_FormClosed;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button categoriesButton;
        private System.Windows.Forms.Button customersButton;
        private System.Windows.Forms.Button suppliersButton;
        private System.Windows.Forms.Button projectsButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button usersButton;
        public System.Windows.Forms.Panel containerPanel;
        private Button systemLogButton;
    }
}

