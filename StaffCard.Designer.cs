namespace Coursework
{
    partial class StaffCard
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
            staffPicBox = new PictureBox();
            lblSurname = new Label();
            lblName = new Label();
            lblProfession = new Label();
            lblEmploymentStatus = new Label();
            lblWorkStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)staffPicBox).BeginInit();
            SuspendLayout();
            // 
            // staffPicBox
            // 
            staffPicBox.BackColor = Color.White;
            staffPicBox.Location = new Point(4, 2);
            staffPicBox.Name = "staffPicBox";
            staffPicBox.Size = new Size(56, 70);
            staffPicBox.TabIndex = 1;
            staffPicBox.TabStop = false;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(71, 43);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(38, 15);
            lblSurname.TabIndex = 5;
            lblSurname.Text = "label2";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(71, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(38, 15);
            lblName.TabIndex = 4;
            lblName.Text = "label1";
            // 
            // lblProfession
            // 
            lblProfession.AutoSize = true;
            lblProfession.Location = new Point(306, 20);
            lblProfession.Name = "lblProfession";
            lblProfession.Size = new Size(38, 15);
            lblProfession.TabIndex = 6;
            lblProfession.Text = "label1";
            // 
            // lblEmploymentStatus
            // 
            lblEmploymentStatus.AutoSize = true;
            lblEmploymentStatus.Location = new Point(306, 43);
            lblEmploymentStatus.Name = "lblEmploymentStatus";
            lblEmploymentStatus.Size = new Size(38, 15);
            lblEmploymentStatus.TabIndex = 7;
            lblEmploymentStatus.Text = "label1";
            // 
            // lblWorkStatus
            // 
            lblWorkStatus.AutoSize = true;
            lblWorkStatus.Location = new Point(539, 32);
            lblWorkStatus.Name = "lblWorkStatus";
            lblWorkStatus.Size = new Size(38, 15);
            lblWorkStatus.TabIndex = 8;
            lblWorkStatus.Text = "label1";
            // 
            // StaffCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblWorkStatus);
            Controls.Add(lblEmploymentStatus);
            Controls.Add(lblProfession);
            Controls.Add(lblSurname);
            Controls.Add(lblName);
            Controls.Add(staffPicBox);
            Name = "StaffCard";
            Size = new Size(755, 76);
            ((System.ComponentModel.ISupportInitialize)staffPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox staffPicBox;
        private Label lblSurname;
        private Label lblName;
        private Label lblProfession;
        private Label lblEmploymentStatus;
        private Label lblWorkStatus;
    }
}
