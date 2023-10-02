namespace ExpensesTracker
{
    partial class Starter
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
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            stateLabel = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.Expenses;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(752, 313);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 352);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(728, 45);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 1;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new Point(12, 331);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(65, 18);
            stateLabel.TabIndex = 2;
            stateLabel.Text = "Starter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(586, 400);
            label2.Name = "label2";
            label2.Size = new Size(154, 18);
            label2.TabIndex = 3;
            label2.Text = "All rights reserved";
            // 
            // Starter
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 448);
            Controls.Add(label2);
            Controls.Add(stateLabel);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Starter";
            Text = "Starter";
            Load += Starter_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private Label stateLabel;
        private Label label2;
    }
}