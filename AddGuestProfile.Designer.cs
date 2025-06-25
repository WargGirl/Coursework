using System.ComponentModel.Design;
using System.Globalization;

namespace Coursework
{
    partial class AddGuestProfile
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
            btnAdd = new Button();
            btnCancel = new Button();
            txtPhotoPath = new TextBox();
            pictureBoxPreview = new PictureBox();
            btnChoosePhoto = new Button();
            txtPassport = new TextBox();
            dtpBirthDate = new DateTimePicker();
            lblPassport = new Label();
            lblBirthDate = new Label();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            lblGender = new Label();
            cmbGender = new ComboBox();
            lblGuestSurname = new Label();
            lblGuestName = new Label();
            chkVIP = new CheckBox();
            txtSurname = new TextBox();
            txtName = new TextBox();
            txtAdditionalInfo = new TextBox();
            lblAdditionalInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(713, 416);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 26);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(632, 416);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 26);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtPhotoPath
            // 
            txtPhotoPath.BorderStyle = BorderStyle.FixedSingle;
            txtPhotoPath.Enabled = false;
            txtPhotoPath.Location = new Point(19, 162);
            txtPhotoPath.Name = "txtPhotoPath";
            txtPhotoPath.ReadOnly = true;
            txtPhotoPath.Size = new Size(274, 23);
            txtPhotoPath.TabIndex = 7;
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.Location = new Point(19, 18);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(100, 125);
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPreview.TabIndex = 8;
            pictureBoxPreview.TabStop = false;
            // 
            // btnChoosePhoto
            // 
            btnChoosePhoto.Location = new Point(299, 162);
            btnChoosePhoto.Name = "btnChoosePhoto";
            btnChoosePhoto.Size = new Size(32, 24);
            btnChoosePhoto.TabIndex = 9;
            btnChoosePhoto.Text = "...";
            btnChoosePhoto.UseVisualStyleBackColor = true;
            btnChoosePhoto.Click += btnChoosePhoto_Click;
            // 
            // txtPassport
            // 
            txtPassport.BorderStyle = BorderStyle.FixedSingle;
            txtPassport.Location = new Point(439, 23);
            txtPassport.Name = "txtPassport";
            txtPassport.Size = new Size(306, 23);
            txtPassport.TabIndex = 13;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(440, 60);
            dtpBirthDate.MaxDate = new DateTime(2350, 12, 31, 0, 0, 0, 0);
            dtpBirthDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(305, 23);
            dtpBirthDate.TabIndex = 14;
            // 
            // lblPassport
            // 
            lblPassport.AutoSize = true;
            lblPassport.Location = new Point(373, 26);
            lblPassport.Name = "lblPassport";
            lblPassport.Size = new Size(55, 15);
            lblPassport.TabIndex = 15;
            lblPassport.Text = "Passport:";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(373, 64);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(61, 15);
            lblBirthDate.TabIndex = 16;
            lblBirthDate.Text = "Birth date:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Location = new Point(439, 97);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(306, 23);
            txtPhoneNumber.TabIndex = 17;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(373, 101);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(44, 15);
            lblPhoneNumber.TabIndex = 18;
            lblPhoneNumber.Text = "Phone:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(19, 263);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(48, 15);
            lblGender.TabIndex = 64;
            lblGender.Text = "Gender:";
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(84, 259);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(190, 23);
            cmbGender.TabIndex = 63;
            // 
            // lblGuestSurname
            // 
            lblGuestSurname.AutoSize = true;
            lblGuestSurname.Location = new Point(19, 232);
            lblGuestSurname.Name = "lblGuestSurname";
            lblGuestSurname.Size = new Size(57, 15);
            lblGuestSurname.TabIndex = 61;
            lblGuestSurname.Text = "Surname:";
            // 
            // lblGuestName
            // 
            lblGuestName.AutoSize = true;
            lblGuestName.Location = new Point(19, 202);
            lblGuestName.Name = "lblGuestName";
            lblGuestName.Size = new Size(42, 15);
            lblGuestName.TabIndex = 60;
            lblGuestName.Text = "Name:";
            // 
            // chkVIP
            // 
            chkVIP.AutoSize = true;
            chkVIP.Location = new Point(19, 291);
            chkVIP.Name = "chkVIP";
            chkVIP.Size = new Size(43, 19);
            chkVIP.TabIndex = 59;
            chkVIP.Text = "VIP";
            chkVIP.UseVisualStyleBackColor = true;
            // 
            // txtSurname
            // 
            txtSurname.BorderStyle = BorderStyle.FixedSingle;
            txtSurname.Location = new Point(84, 229);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(190, 23);
            txtSurname.TabIndex = 57;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(84, 199);
            txtName.Name = "txtName";
            txtName.Size = new Size(190, 23);
            txtName.TabIndex = 56;
            // 
            // txtAdditionalInfo
            // 
            txtAdditionalInfo.BorderStyle = BorderStyle.FixedSingle;
            txtAdditionalInfo.Location = new Point(439, 135);
            txtAdditionalInfo.Multiline = true;
            txtAdditionalInfo.Name = "txtAdditionalInfo";
            txtAdditionalInfo.Size = new Size(306, 146);
            txtAdditionalInfo.TabIndex = 65;
            // 
            // lblAdditionalInfo
            // 
            lblAdditionalInfo.AutoSize = true;
            lblAdditionalInfo.Location = new Point(373, 138);
            lblAdditionalInfo.Name = "lblAdditionalInfo";
            lblAdditionalInfo.Size = new Size(59, 15);
            lblAdditionalInfo.TabIndex = 66;
            lblAdditionalInfo.Text = "Add. info:";
            // 
            // AddGuestProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAdditionalInfo);
            Controls.Add(txtAdditionalInfo);
            Controls.Add(lblGender);
            Controls.Add(cmbGender);
            Controls.Add(lblGuestSurname);
            Controls.Add(lblGuestName);
            Controls.Add(chkVIP);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblBirthDate);
            Controls.Add(lblPassport);
            Controls.Add(dtpBirthDate);
            Controls.Add(txtPassport);
            Controls.Add(btnChoosePhoto);
            Controls.Add(pictureBoxPreview);
            Controls.Add(txtPhotoPath);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Name = "AddGuestProfile";
            Text = "AddGuestProfile";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnCancel;
        private TextBox txtPhotoPath;
        private PictureBox pictureBoxPreview;
        private Button btnChoosePhoto;
        private TextBox txtPassport;
        private DateTimePicker dtpBirthDate;
        private Label lblPassport;
        private Label lblBirthDate;
        private TextBox txtPhoneNumber;
        private Label lblPhoneNumber;
        private Label lblGender;
        private ComboBox cmbGender;
        private Label lblGuestSurname;
        private Label lblGuestName;
        private CheckBox chkVIP;
        private TextBox txtSurname;
        private TextBox txtName;
        private TextBox txtAdditionalInfo;
        private Label lblAdditionalInfo;
    }
}