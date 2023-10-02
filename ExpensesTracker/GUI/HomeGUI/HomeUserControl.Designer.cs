namespace ExpensesTracker.GUI.HomeGUI
{
    partial class HomeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            addCollectButton = new Button();
            adddPaymentButton = new Button();
            addUsersButton = new Button();
            addProjectsButton = new Button();
            addSuppliersButton = new Button();
            addCustomersButton = new Button();
            addCategoriesButton = new Button();
            label1 = new Label();
            panel2 = new Panel();
            companyNameLabel = new Label();
            logoPictureBox = new PictureBox();
            welcomeLabel = new Label();
            panel3 = new Panel();
            projectsComboBox = new ComboBox();
            projectsLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 280);
            panel1.Name = "panel1";
            panel1.Size = new Size(959, 146);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.Access;
            pictureBox1.Location = new Point(525, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(addCollectButton);
            groupBox1.Controls.Add(adddPaymentButton);
            groupBox1.Controls.Add(addUsersButton);
            groupBox1.Controls.Add(addProjectsButton);
            groupBox1.Controls.Add(addSuppliersButton);
            groupBox1.Controls.Add(addCustomersButton);
            groupBox1.Controls.Add(addCategoriesButton);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(16, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(929, 80);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add";
            // 
            // addCollectButton
            // 
            addCollectButton.Image = Properties.Resources.Collect;
            addCollectButton.ImageAlign = ContentAlignment.MiddleLeft;
            addCollectButton.Location = new Point(785, 27);
            addCollectButton.Margin = new Padding(5);
            addCollectButton.Name = "addCollectButton";
            addCollectButton.Size = new Size(136, 45);
            addCollectButton.TabIndex = 7;
            addCollectButton.Text = "Outcome";
            addCollectButton.TextAlign = ContentAlignment.MiddleRight;
            addCollectButton.UseVisualStyleBackColor = true;
            addCollectButton.Click += addCollectButton_Click;
            // 
            // adddPaymentButton
            // 
            adddPaymentButton.Image = Properties.Resources.Payment;
            adddPaymentButton.ImageAlign = ContentAlignment.MiddleLeft;
            adddPaymentButton.Location = new Point(647, 27);
            adddPaymentButton.Margin = new Padding(5);
            adddPaymentButton.Name = "adddPaymentButton";
            adddPaymentButton.Size = new Size(128, 45);
            adddPaymentButton.TabIndex = 6;
            adddPaymentButton.Text = "Income";
            adddPaymentButton.TextAlign = ContentAlignment.MiddleRight;
            adddPaymentButton.UseVisualStyleBackColor = true;
            adddPaymentButton.Click += adddPaymentButton_Click;
            // 
            // addUsersButton
            // 
            addUsersButton.Image = Properties.Resources.User;
            addUsersButton.ImageAlign = ContentAlignment.TopLeft;
            addUsersButton.Location = new Point(542, 27);
            addUsersButton.Margin = new Padding(5);
            addUsersButton.Name = "addUsersButton";
            addUsersButton.Size = new Size(95, 45);
            addUsersButton.TabIndex = 5;
            addUsersButton.Text = "User";
            addUsersButton.TextAlign = ContentAlignment.MiddleRight;
            addUsersButton.UseVisualStyleBackColor = true;
            addUsersButton.Click += addUsersButton_Click;
            // 
            // addProjectsButton
            // 
            addProjectsButton.Image = Properties.Resources.Projects;
            addProjectsButton.ImageAlign = ContentAlignment.MiddleLeft;
            addProjectsButton.Location = new Point(412, 27);
            addProjectsButton.Margin = new Padding(5);
            addProjectsButton.Name = "addProjectsButton";
            addProjectsButton.Size = new Size(120, 45);
            addProjectsButton.TabIndex = 4;
            addProjectsButton.Text = "Project";
            addProjectsButton.TextAlign = ContentAlignment.MiddleRight;
            addProjectsButton.UseVisualStyleBackColor = true;
            addProjectsButton.Click += addProjectsButton_Click;
            // 
            // addSuppliersButton
            // 
            addSuppliersButton.Image = Properties.Resources.Suppliers;
            addSuppliersButton.ImageAlign = ContentAlignment.MiddleLeft;
            addSuppliersButton.Location = new Point(282, 27);
            addSuppliersButton.Margin = new Padding(5);
            addSuppliersButton.Name = "addSuppliersButton";
            addSuppliersButton.Size = new Size(120, 45);
            addSuppliersButton.TabIndex = 3;
            addSuppliersButton.Text = "Supplier";
            addSuppliersButton.TextAlign = ContentAlignment.MiddleRight;
            addSuppliersButton.UseVisualStyleBackColor = true;
            addSuppliersButton.Click += addSuppliersButton_Click;
            // 
            // addCustomersButton
            // 
            addCustomersButton.Image = Properties.Resources.Customers;
            addCustomersButton.ImageAlign = ContentAlignment.MiddleLeft;
            addCustomersButton.Location = new Point(140, 27);
            addCustomersButton.Margin = new Padding(5);
            addCustomersButton.Name = "addCustomersButton";
            addCustomersButton.Size = new Size(132, 45);
            addCustomersButton.TabIndex = 2;
            addCustomersButton.Text = "Customer";
            addCustomersButton.TextAlign = ContentAlignment.MiddleRight;
            addCustomersButton.UseVisualStyleBackColor = true;
            addCustomersButton.Click += addCustomersButton_Click;
            // 
            // addCategoriesButton
            // 
            addCategoriesButton.Image = Properties.Resources.Categories;
            addCategoriesButton.ImageAlign = ContentAlignment.MiddleLeft;
            addCategoriesButton.Location = new Point(8, 27);
            addCategoriesButton.Margin = new Padding(5);
            addCategoriesButton.Name = "addCategoriesButton";
            addCategoriesButton.Size = new Size(122, 45);
            addCategoriesButton.TabIndex = 1;
            addCategoriesButton.Text = "Category";
            addCategoriesButton.TextAlign = ContentAlignment.MiddleRight;
            addCategoriesButton.UseVisualStyleBackColor = true;
            addCategoriesButton.Click += addCategoriesButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(589, 12);
            label1.Name = "label1";
            label1.Size = new Size(159, 26);
            label1.TabIndex = 0;
            label1.Text = "Quick Access";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(companyNameLabel);
            panel2.Controls.Add(logoPictureBox);
            panel2.Location = new Point(583, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(336, 100);
            panel2.TabIndex = 1;
            // 
            // companyNameLabel
            // 
            companyNameLabel.BackColor = Color.CadetBlue;
            companyNameLabel.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            companyNameLabel.Location = new Point(-1, 0);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new Size(239, 98);
            companyNameLabel.TabIndex = 3;
            companyNameLabel.Text = "Quick Access";
            companyNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logoPictureBox
            // 
            logoPictureBox.BackColor = Color.CadetBlue;
            logoPictureBox.BorderStyle = BorderStyle.FixedSingle;
            logoPictureBox.Dock = DockStyle.Right;
            logoPictureBox.Image = Properties.Resources.Expenses;
            logoPictureBox.Location = new Point(235, 0);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(99, 98);
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoPictureBox.TabIndex = 3;
            logoPictureBox.TabStop = false;
            // 
            // welcomeLabel
            // 
            welcomeLabel.BackColor = Color.White;
            welcomeLabel.Font = new Font("Arial Rounded MT Bold", 35F, FontStyle.Regular, GraphicsUnit.Point);
            welcomeLabel.ForeColor = Color.CadetBlue;
            welcomeLabel.Location = new Point(52, 66);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(402, 60);
            welcomeLabel.TabIndex = 4;
            welcomeLabel.Text = "Welcome Again";
            welcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom;
            panel3.Controls.Add(projectsComboBox);
            panel3.Controls.Add(projectsLabel);
            panel3.Location = new Point(308, 204);
            panel3.Name = "panel3";
            panel3.Size = new Size(342, 75);
            panel3.TabIndex = 5;
            // 
            // projectsComboBox
            // 
            projectsComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            projectsComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            projectsComboBox.FormattingEnabled = true;
            projectsComboBox.Location = new Point(0, 46);
            projectsComboBox.Name = "projectsComboBox";
            projectsComboBox.Size = new Size(342, 26);
            projectsComboBox.TabIndex = 7;
            projectsComboBox.SelectedIndexChanged += projectsComboBox_SelectedIndexChanged;
            // 
            // projectsLabel
            // 
            projectsLabel.BackColor = Color.White;
            projectsLabel.Dock = DockStyle.Top;
            projectsLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            projectsLabel.ForeColor = Color.CadetBlue;
            projectsLabel.Location = new Point(0, 0);
            projectsLabel.Name = "projectsLabel";
            projectsLabel.Size = new Size(342, 43);
            projectsLabel.TabIndex = 6;
            projectsLabel.Text = "Projects";
            projectsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel3);
            Controls.Add(welcomeLabel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "HomeUserControl";
            Size = new Size(959, 426);
            Load += HomeUserControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addCategoriesButton;
        private System.Windows.Forms.Button adddPaymentButton;
        private System.Windows.Forms.Button addUsersButton;
        private System.Windows.Forms.Button addProjectsButton;
        private System.Windows.Forms.Button addSuppliersButton;
        private System.Windows.Forms.Button addCustomersButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addCollectButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label welcomeLabel;
        private Panel panel3;
        private ComboBox projectsComboBox;
        private Label projectsLabel;
    }
}
