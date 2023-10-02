namespace ExpensesTracker.GUI.IncomeGUI
{
    partial class IncomeUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            flowLayoutPanel1 = new FlowLayoutPanel();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            UpdateButton = new Button();
            exportButton = new Button();
            panel1 = new Panel();
            searchTextBox = new TextBox();
            searchButton = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            PageNoComboBox = new ComboBox();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.CadetBlue;
            flowLayoutPanel1.Controls.Add(addButton);
            flowLayoutPanel1.Controls.Add(editButton);
            flowLayoutPanel1.Controls.Add(deleteButton);
            flowLayoutPanel1.Controls.Add(UpdateButton);
            flowLayoutPanel1.Controls.Add(exportButton);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(789, 88);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.Image = Properties.Resources.Add;
            addButton.ImageAlign = ContentAlignment.TopCenter;
            addButton.Location = new Point(7, 7);
            addButton.Margin = new Padding(2);
            addButton.Name = "addButton";
            addButton.Size = new Size(51, 75);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.TextAlign = ContentAlignment.BottomCenter;
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            editButton.Image = Properties.Resources.Edit;
            editButton.ImageAlign = ContentAlignment.TopCenter;
            editButton.Location = new Point(62, 7);
            editButton.Margin = new Padding(2);
            editButton.Name = "editButton";
            editButton.Size = new Size(54, 75);
            editButton.TabIndex = 3;
            editButton.Text = "Edit";
            editButton.TextAlign = ContentAlignment.BottomCenter;
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.Image = Properties.Resources.Delete;
            deleteButton.ImageAlign = ContentAlignment.TopCenter;
            deleteButton.Location = new Point(120, 7);
            deleteButton.Margin = new Padding(2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(63, 75);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Delete";
            deleteButton.TextAlign = ContentAlignment.BottomCenter;
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateButton.Image = Properties.Resources.Update;
            UpdateButton.ImageAlign = ContentAlignment.TopCenter;
            UpdateButton.Location = new Point(187, 7);
            UpdateButton.Margin = new Padding(2);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(69, 75);
            UpdateButton.TabIndex = 6;
            UpdateButton.Text = "Update";
            UpdateButton.TextAlign = ContentAlignment.BottomCenter;
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // exportButton
            // 
            exportButton.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            exportButton.Image = Properties.Resources.Export;
            exportButton.ImageAlign = ContentAlignment.TopCenter;
            exportButton.Location = new Point(260, 7);
            exportButton.Margin = new Padding(2);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(71, 75);
            exportButton.TabIndex = 5;
            exportButton.Text = "Export";
            exportButton.TextAlign = ContentAlignment.BottomCenter;
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(searchTextBox);
            panel1.Controls.Add(searchButton);
            panel1.Location = new Point(343, 15);
            panel1.Margin = new Padding(10, 3, 3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 59);
            panel1.TabIndex = 6;
            // 
            // searchTextBox
            // 
            searchTextBox.Dock = DockStyle.Fill;
            searchTextBox.Font = new Font("Arial Rounded MT Bold", 30F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.Location = new Point(0, 0);
            searchTextBox.Multiline = true;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(220, 57);
            searchTextBox.TabIndex = 8;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // searchButton
            // 
            searchButton.BackColor = SystemColors.Control;
            searchButton.Dock = DockStyle.Right;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.Image = Properties.Resources.Search;
            searchButton.ImageAlign = ContentAlignment.MiddleLeft;
            searchButton.Location = new Point(220, 0);
            searchButton.Margin = new Padding(5);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(59, 57);
            searchButton.TabIndex = 7;
            searchButton.TextAlign = ContentAlignment.MiddleRight;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.Export;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(379, 133);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(111, 54);
            button2.TabIndex = 6;
            button2.Text = "Export";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(789, 338);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // PageNoComboBox
            // 
            PageNoComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PageNoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PageNoComboBox.FormattingEnabled = true;
            PageNoComboBox.Location = new Point(0, 400);
            PageNoComboBox.Name = "PageNoComboBox";
            PageNoComboBox.Size = new Size(121, 26);
            PageNoComboBox.TabIndex = 3;
            PageNoComboBox.SelectedIndexChanged += PageNocomboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.BackColor = Color.CadetBlue;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(651, 382);
            label1.Name = "label1";
            label1.Size = new Size(135, 44);
            label1.TabIndex = 8;
            label1.Text = "Incomes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IncomeUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(PageNoComboBox);
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button2);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "IncomeUserControl";
            Size = new Size(789, 426);
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private Button UpdateButton;
        private DataGridView dataGridView1;
        private ComboBox PageNoComboBox;
        private Button button2;
        private Label label1;
    }
}
