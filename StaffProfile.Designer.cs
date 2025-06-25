namespace Coursework
{
    partial class StaffProfile
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
            label1 = new Label();
            lblWorkTime = new Label();
            dtpWorkEndTime = new DateTimePicker();
            dtpWorkStartTime = new DateTimePicker();
            lblEmploymentStatus = new Label();
            cmbEmploymentStatus = new ComboBox();
            lblProfession = new Label();
            cmbProfession = new ComboBox();
            lblSalary = new Label();
            numSalary = new NumericUpDown();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            lblBirthDate = new Label();
            lblPassport = new Label();
            dtpBirthDate = new DateTimePicker();
            txtPassport = new TextBox();
            lblGuestSurname = new Label();
            lblGuestName = new Label();
            pictureBoxPreview = new PictureBox();
            txtSurname = new TextBox();
            txtName = new TextBox();
            btnSave = new Button();
            btnEdit = new Button();
            btnChoosePhoto = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(661, 138);
            label1.Name = "label1";
            label1.Size = new Size(12, 15);
            label1.TabIndex = 75;
            label1.Text = "-";
            // 
            // lblWorkTime
            // 
            lblWorkTime.AutoSize = true;
            lblWorkTime.Location = new Point(446, 140);
            lblWorkTime.Name = "lblWorkTime";
            lblWorkTime.Size = new Size(65, 15);
            lblWorkTime.TabIndex = 74;
            lblWorkTime.Text = "Work time:";
            // 
            // dtpWorkEndTime
            // 
            dtpWorkEndTime.Enabled = false;
            dtpWorkEndTime.Format = DateTimePickerFormat.Time;
            dtpWorkEndTime.Location = new Point(679, 134);
            dtpWorkEndTime.Name = "dtpWorkEndTime";
            dtpWorkEndTime.ShowUpDown = true;
            dtpWorkEndTime.Size = new Size(90, 23);
            dtpWorkEndTime.TabIndex = 73;
            dtpWorkEndTime.Value = new DateTime(2025, 6, 17, 0, 0, 0, 0);
            // 
            // dtpWorkStartTime
            // 
            dtpWorkStartTime.Enabled = false;
            dtpWorkStartTime.Format = DateTimePickerFormat.Time;
            dtpWorkStartTime.Location = new Point(563, 134);
            dtpWorkStartTime.Name = "dtpWorkStartTime";
            dtpWorkStartTime.ShowUpDown = true;
            dtpWorkStartTime.Size = new Size(90, 23);
            dtpWorkStartTime.TabIndex = 72;
            dtpWorkStartTime.Value = new DateTime(2025, 6, 17, 0, 0, 0, 0);
            // 
            // lblEmploymentStatus
            // 
            lblEmploymentStatus.AutoSize = true;
            lblEmploymentStatus.Location = new Point(21, 360);
            lblEmploymentStatus.Name = "lblEmploymentStatus";
            lblEmploymentStatus.Size = new Size(112, 15);
            lblEmploymentStatus.TabIndex = 71;
            lblEmploymentStatus.Text = "Employment status:";
            // 
            // cmbEmploymentStatus
            // 
            cmbEmploymentStatus.Enabled = false;
            cmbEmploymentStatus.FormattingEnabled = true;
            cmbEmploymentStatus.Location = new Point(141, 357);
            cmbEmploymentStatus.Name = "cmbEmploymentStatus";
            cmbEmploymentStatus.Size = new Size(166, 23);
            cmbEmploymentStatus.TabIndex = 70;
            // 
            // lblProfession
            // 
            lblProfession.AutoSize = true;
            lblProfession.Location = new Point(21, 323);
            lblProfession.Name = "lblProfession";
            lblProfession.Size = new Size(65, 15);
            lblProfession.TabIndex = 69;
            lblProfession.Text = "Profession:";
            // 
            // cmbProfession
            // 
            cmbProfession.Enabled = false;
            cmbProfession.FormattingEnabled = true;
            cmbProfession.Location = new Point(141, 320);
            cmbProfession.Name = "cmbProfession";
            cmbProfession.Size = new Size(166, 23);
            cmbProfession.TabIndex = 68;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(20, 285);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(41, 15);
            lblSalary.TabIndex = 67;
            lblSalary.Text = "Salary:";
            // 
            // numSalary
            // 
            numSalary.DecimalPlaces = 2;
            numSalary.Enabled = false;
            numSalary.Location = new Point(141, 283);
            numSalary.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numSalary.Name = "numSalary";
            numSalary.ReadOnly = true;
            numSalary.Size = new Size(166, 23);
            numSalary.TabIndex = 66;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(446, 101);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(44, 15);
            lblPhoneNumber.TabIndex = 65;
            lblPhoneNumber.Text = "Phone:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Enabled = false;
            txtPhoneNumber.Location = new Point(521, 97);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(248, 23);
            txtPhoneNumber.TabIndex = 64;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(446, 64);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(61, 15);
            lblBirthDate.TabIndex = 63;
            lblBirthDate.Text = "Birth date:";
            // 
            // lblPassport
            // 
            lblPassport.AutoSize = true;
            lblPassport.Location = new Point(446, 26);
            lblPassport.Name = "lblPassport";
            lblPassport.Size = new Size(55, 15);
            lblPassport.TabIndex = 62;
            lblPassport.Text = "Passport:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Enabled = false;
            dtpBirthDate.Location = new Point(522, 60);
            dtpBirthDate.MaxDate = new DateTime(2350, 12, 31, 0, 0, 0, 0);
            dtpBirthDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(247, 23);
            dtpBirthDate.TabIndex = 61;
            // 
            // txtPassport
            // 
            txtPassport.BorderStyle = BorderStyle.FixedSingle;
            txtPassport.Enabled = false;
            txtPassport.Location = new Point(521, 23);
            txtPassport.Name = "txtPassport";
            txtPassport.ReadOnly = true;
            txtPassport.Size = new Size(248, 23);
            txtPassport.TabIndex = 60;
            // 
            // lblGuestSurname
            // 
            lblGuestSurname.AutoSize = true;
            lblGuestSurname.Location = new Point(19, 248);
            lblGuestSurname.Name = "lblGuestSurname";
            lblGuestSurname.Size = new Size(57, 15);
            lblGuestSurname.TabIndex = 59;
            lblGuestSurname.Text = "Surname:";
            // 
            // lblGuestName
            // 
            lblGuestName.AutoSize = true;
            lblGuestName.Location = new Point(20, 211);
            lblGuestName.Name = "lblGuestName";
            lblGuestName.Size = new Size(42, 15);
            lblGuestName.TabIndex = 58;
            lblGuestName.Text = "Name:";
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.Location = new Point(19, 18);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(100, 125);
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPreview.TabIndex = 56;
            pictureBoxPreview.TabStop = false;
            // 
            // txtSurname
            // 
            txtSurname.BorderStyle = BorderStyle.FixedSingle;
            txtSurname.Enabled = false;
            txtSurname.Location = new Point(141, 246);
            txtSurname.Name = "txtSurname";
            txtSurname.ReadOnly = true;
            txtSurname.Size = new Size(166, 23);
            txtSurname.TabIndex = 54;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Enabled = false;
            txtName.Location = new Point(141, 209);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(166, 23);
            txtName.TabIndex = 53;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(632, 416);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 26);
            btnSave.TabIndex = 52;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(713, 416);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 26);
            btnEdit.TabIndex = 51;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnChoosePhoto
            // 
            btnChoosePhoto.Enabled = false;
            btnChoosePhoto.Location = new Point(19, 149);
            btnChoosePhoto.Name = "btnChoosePhoto";
            btnChoosePhoto.Size = new Size(100, 24);
            btnChoosePhoto.TabIndex = 76;
            btnChoosePhoto.Text = "Change";
            btnChoosePhoto.UseVisualStyleBackColor = true;
            btnChoosePhoto.Click += btnChoosePhoto_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(470, 416);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 26);
            btnDelete.TabIndex = 78;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(551, 416);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 26);
            btnCancel.TabIndex = 77;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // StaffProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnChoosePhoto);
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
            Controls.Add(pictureBoxPreview);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Name = "StaffProfile";
            Text = "StaffProfile";
            ((System.ComponentModel.ISupportInitialize)numSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblWorkTime;
        private DateTimePicker dtpWorkEndTime;
        private DateTimePicker dtpWorkStartTime;
        private Label lblEmploymentStatus;
        private ComboBox cmbEmploymentStatus;
        private Label lblProfession;
        private ComboBox cmbProfession;
        private Label lblSalary;
        private NumericUpDown numSalary;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private Label lblBirthDate;
        private Label lblPassport;
        private DateTimePicker dtpBirthDate;
        private TextBox txtPassport;
        private Label lblGuestSurname;
        private Label lblGuestName;
        private PictureBox pictureBoxPreview;
        private TextBox txtSurname;
        private TextBox txtName;
        private Button btnSave;
        private Button btnEdit;
        private Button btnChoosePhoto;
        private Button btnDelete;
        private Button btnCancel;
    }
}