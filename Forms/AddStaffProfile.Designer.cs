namespace Coursework
{
    partial class AddStaffProfile
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
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            lblBirthDate = new Label();
            lblPassport = new Label();
            dtpBirthDate = new DateTimePicker();
            txtPassport = new TextBox();
            lblGuestSurname = new Label();
            lblGuestName = new Label();
            btnChoosePhoto = new Button();
            pictureBoxPreview = new PictureBox();
            txtPhotoPath = new TextBox();
            txtSurname = new TextBox();
            txtName = new TextBox();
            btnCancel = new Button();
            btnAdd = new Button();
            numSalary = new NumericUpDown();
            lblSalary = new Label();
            cmbProfession = new ComboBox();
            lblProfession = new Label();
            cmbEmploymentStatus = new ComboBox();
            lblEmploymentStatus = new Label();
            dtpWorkStartTime = new DateTimePicker();
            dtpWorkEndTime = new DateTimePicker();
            lblWorkTime = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSalary).BeginInit();
            SuspendLayout();
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(446, 101);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(44, 15);
            lblPhoneNumber.TabIndex = 40;
            lblPhoneNumber.Text = "Phone:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Location = new Point(521, 97);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(248, 23);
            txtPhoneNumber.TabIndex = 39;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(446, 64);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(61, 15);
            lblBirthDate.TabIndex = 38;
            lblBirthDate.Text = "Birth date:";
            // 
            // lblPassport
            // 
            lblPassport.AutoSize = true;
            lblPassport.Location = new Point(446, 26);
            lblPassport.Name = "lblPassport";
            lblPassport.Size = new Size(55, 15);
            lblPassport.TabIndex = 37;
            lblPassport.Text = "Passport:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(522, 60);
            dtpBirthDate.MaxDate = new DateTime(2350, 12, 31, 0, 0, 0, 0);
            dtpBirthDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(247, 23);
            dtpBirthDate.TabIndex = 36;
            // 
            // txtPassport
            // 
            txtPassport.BorderStyle = BorderStyle.FixedSingle;
            txtPassport.Location = new Point(521, 23);
            txtPassport.Name = "txtPassport";
            txtPassport.Size = new Size(248, 23);
            txtPassport.TabIndex = 35;
            // 
            // lblGuestSurname
            // 
            lblGuestSurname.AutoSize = true;
            lblGuestSurname.Location = new Point(19, 248);
            lblGuestSurname.Name = "lblGuestSurname";
            lblGuestSurname.Size = new Size(57, 15);
            lblGuestSurname.TabIndex = 33;
            lblGuestSurname.Text = "Surname:";
            // 
            // lblGuestName
            // 
            lblGuestName.AutoSize = true;
            lblGuestName.Location = new Point(20, 211);
            lblGuestName.Name = "lblGuestName";
            lblGuestName.Size = new Size(42, 15);
            lblGuestName.TabIndex = 32;
            lblGuestName.Text = "Name:";
            // 
            // btnChoosePhoto
            // 
            btnChoosePhoto.Location = new Point(299, 162);
            btnChoosePhoto.Name = "btnChoosePhoto";
            btnChoosePhoto.Size = new Size(32, 24);
            btnChoosePhoto.TabIndex = 31;
            btnChoosePhoto.Text = "...";
            btnChoosePhoto.UseVisualStyleBackColor = true;
            btnChoosePhoto.Click += btnChoosePhoto_Click;
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.Location = new Point(19, 18);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(100, 125);
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPreview.TabIndex = 30;
            pictureBoxPreview.TabStop = false;
            // 
            // txtPhotoPath
            // 
            txtPhotoPath.BorderStyle = BorderStyle.FixedSingle;
            txtPhotoPath.Enabled = false;
            txtPhotoPath.Location = new Point(19, 162);
            txtPhotoPath.Name = "txtPhotoPath";
            txtPhotoPath.ReadOnly = true;
            txtPhotoPath.Size = new Size(274, 23);
            txtPhotoPath.TabIndex = 29;
            // 
            // txtSurname
            // 
            txtSurname.BorderStyle = BorderStyle.FixedSingle;
            txtSurname.Location = new Point(141, 246);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(166, 23);
            txtSurname.TabIndex = 26;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(141, 209);
            txtName.Name = "txtName";
            txtName.Size = new Size(166, 23);
            txtName.TabIndex = 25;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(632, 416);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 26);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(713, 416);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 26);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // numSalary
            // 
            numSalary.DecimalPlaces = 2;
            numSalary.Location = new Point(141, 283);
            numSalary.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numSalary.Name = "numSalary";
            numSalary.Size = new Size(166, 23);
            numSalary.TabIndex = 41;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(20, 285);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(41, 15);
            lblSalary.TabIndex = 42;
            lblSalary.Text = "Salary:";
            // 
            // cmbProfession
            // 
            cmbProfession.FormattingEnabled = true;
            cmbProfession.Location = new Point(141, 320);
            cmbProfession.Name = "cmbProfession";
            cmbProfession.Size = new Size(166, 23);
            cmbProfession.TabIndex = 43;
            // 
            // lblProfession
            // 
            lblProfession.AutoSize = true;
            lblProfession.Location = new Point(21, 323);
            lblProfession.Name = "lblProfession";
            lblProfession.Size = new Size(65, 15);
            lblProfession.TabIndex = 44;
            lblProfession.Text = "Profession:";
            // 
            // cmbEmploymentStatus
            // 
            cmbEmploymentStatus.FormattingEnabled = true;
            cmbEmploymentStatus.Location = new Point(141, 357);
            cmbEmploymentStatus.Name = "cmbEmploymentStatus";
            cmbEmploymentStatus.Size = new Size(166, 23);
            cmbEmploymentStatus.TabIndex = 45;
            // 
            // lblEmploymentStatus
            // 
            lblEmploymentStatus.AutoSize = true;
            lblEmploymentStatus.Location = new Point(21, 360);
            lblEmploymentStatus.Name = "lblEmploymentStatus";
            lblEmploymentStatus.Size = new Size(112, 15);
            lblEmploymentStatus.TabIndex = 46;
            lblEmploymentStatus.Text = "Employment status:";
            // 
            // dtpWorkStartTime
            // 
            dtpWorkStartTime.Format = DateTimePickerFormat.Time;
            dtpWorkStartTime.Location = new Point(563, 134);
            dtpWorkStartTime.Name = "dtpWorkStartTime";
            dtpWorkStartTime.ShowUpDown = true;
            dtpWorkStartTime.Size = new Size(90, 23);
            dtpWorkStartTime.TabIndex = 47;
            dtpWorkStartTime.Value = new DateTime(2025, 6, 17, 0, 0, 0, 0);
            // 
            // dtpWorkEndTime
            // 
            dtpWorkEndTime.Format = DateTimePickerFormat.Time;
            dtpWorkEndTime.Location = new Point(679, 134);
            dtpWorkEndTime.Name = "dtpWorkEndTime";
            dtpWorkEndTime.ShowUpDown = true;
            dtpWorkEndTime.Size = new Size(90, 23);
            dtpWorkEndTime.TabIndex = 48;
            dtpWorkEndTime.Value = new DateTime(2025, 6, 17, 0, 0, 0, 0);
            // 
            // lblWorkTime
            // 
            lblWorkTime.AutoSize = true;
            lblWorkTime.Location = new Point(446, 140);
            lblWorkTime.Name = "lblWorkTime";
            lblWorkTime.Size = new Size(65, 15);
            lblWorkTime.TabIndex = 49;
            lblWorkTime.Text = "Work time:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(661, 138);
            label1.Name = "label1";
            label1.Size = new Size(12, 15);
            label1.TabIndex = 50;
            label1.Text = "-";
            // 
            // AddStaffProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblWorkTime);
            Controls.Add(dtpWorkEndTime);
            Controls.Add(dtpWorkStartTime);
            Controls.Add(lblEmploymentStatus);
            Controls.Add(cmbEmploymentStatus);
            Controls.Add(lblProfession);
            Controls.Add(cmbProfession);
            Controls.Add(lblSalary);
            Controls.Add(numSalary);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblBirthDate);
            Controls.Add(lblPassport);
            Controls.Add(dtpBirthDate);
            Controls.Add(txtPassport);
            Controls.Add(lblGuestSurname);
            Controls.Add(lblGuestName);
            Controls.Add(btnChoosePhoto);
            Controls.Add(pictureBoxPreview);
            Controls.Add(txtPhotoPath);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Name = "AddStaffProfile";
            Text = "s";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSalary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private Label lblBirthDate;
        private Label lblPassport;
        private DateTimePicker dtpBirthDate;
        private TextBox txtPassport;
        private Label lblGuestSurname;
        private Label lblGuestName;
        private Button btnChoosePhoto;
        private PictureBox pictureBoxPreview;
        private TextBox txtPhotoPath;
        private TextBox txtSurname;
        private TextBox txtName;
        private Button btnCancel;
        private Button btnAdd;
        private NumericUpDown numSalary;
        private Label lblSalary;
        private ComboBox cmbProfession;
        private Label lblProfession;
        private ComboBox cmbEmploymentStatus;
        private Label lblEmploymentStatus;
        private DateTimePicker dtpWorkStartTime;
        private DateTimePicker dtpWorkEndTime;
        private Label lblWorkTime;
        private Label label1;
    }
}