namespace Coursework
{
    partial class GuestProfile
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
            lblGuestRoom = new Label();
            lblGuestSurname = new Label();
            lblGuestName = new Label();
            btnChoosePhoto = new Button();
            pictureBoxPreview = new PictureBox();
            chkVIP = new CheckBox();
            txtRoomNumber = new TextBox();
            txtSurname = new TextBox();
            txtName = new TextBox();
            btnSave = new Button();
            lblAge = new Label();
            lblAgeNumber = new Label();
            btnEdit = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            btnCheckIn = new Button();
            btnCheckOut = new Button();
            btnExtendStay = new Button();
            dtpCheckInDate = new DateTimePicker();
            dtpCheckOutDate = new DateTimePicker();
            cmbGender = new ComboBox();
            lblGender = new Label();
            lblStatus = new Label();
            lblAdditionalInfo = new Label();
            txtAdditionalInfo = new TextBox();
            txtInHotelStatus = new TextBox();
            btnBook = new Button();
            lblCheckIn = new Label();
            lblCheckOut = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            SuspendLayout();
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(373, 101);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(44, 15);
            lblPhoneNumber.TabIndex = 40;
            lblPhoneNumber.Text = "Phone:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Enabled = false;
            txtPhoneNumber.Location = new Point(439, 97);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(306, 23);
            txtPhoneNumber.TabIndex = 39;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(373, 64);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(61, 15);
            lblBirthDate.TabIndex = 38;
            lblBirthDate.Text = "Birth date:";
            // 
            // lblPassport
            // 
            lblPassport.AutoSize = true;
            lblPassport.Location = new Point(373, 26);
            lblPassport.Name = "lblPassport";
            lblPassport.Size = new Size(55, 15);
            lblPassport.TabIndex = 37;
            lblPassport.Text = "Passport:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Enabled = false;
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(440, 60);
            dtpBirthDate.MaxDate = new DateTime(2350, 12, 31, 0, 0, 0, 0);
            dtpBirthDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(203, 23);
            dtpBirthDate.TabIndex = 36;
            // 
            // txtPassport
            // 
            txtPassport.BorderStyle = BorderStyle.FixedSingle;
            txtPassport.Enabled = false;
            txtPassport.Location = new Point(439, 23);
            txtPassport.Name = "txtPassport";
            txtPassport.ReadOnly = true;
            txtPassport.Size = new Size(306, 23);
            txtPassport.TabIndex = 35;
            // 
            // lblGuestRoom
            // 
            lblGuestRoom.AutoSize = true;
            lblGuestRoom.Location = new Point(18, 281);
            lblGuestRoom.Name = "lblGuestRoom";
            lblGuestRoom.Size = new Size(42, 15);
            lblGuestRoom.TabIndex = 34;
            lblGuestRoom.Text = "Room:";
            // 
            // lblGuestSurname
            // 
            lblGuestSurname.AutoSize = true;
            lblGuestSurname.Location = new Point(18, 222);
            lblGuestSurname.Name = "lblGuestSurname";
            lblGuestSurname.Size = new Size(57, 15);
            lblGuestSurname.TabIndex = 33;
            lblGuestSurname.Text = "Surname:";
            // 
            // lblGuestName
            // 
            lblGuestName.AutoSize = true;
            lblGuestName.Location = new Point(18, 192);
            lblGuestName.Name = "lblGuestName";
            lblGuestName.Size = new Size(42, 15);
            lblGuestName.TabIndex = 32;
            lblGuestName.Text = "Name:";
            // 
            // btnChoosePhoto
            // 
            btnChoosePhoto.Enabled = false;
            btnChoosePhoto.Location = new Point(19, 151);
            btnChoosePhoto.Name = "btnChoosePhoto";
            btnChoosePhoto.Size = new Size(100, 24);
            btnChoosePhoto.TabIndex = 31;
            btnChoosePhoto.Text = "Change";
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
            // chkVIP
            // 
            chkVIP.AutoSize = true;
            chkVIP.Enabled = false;
            chkVIP.Location = new Point(144, 280);
            chkVIP.Name = "chkVIP";
            chkVIP.Size = new Size(43, 19);
            chkVIP.TabIndex = 28;
            chkVIP.Text = "VIP";
            chkVIP.UseVisualStyleBackColor = true;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.BorderStyle = BorderStyle.FixedSingle;
            txtRoomNumber.Enabled = false;
            txtRoomNumber.Location = new Point(83, 277);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.ReadOnly = true;
            txtRoomNumber.Size = new Size(42, 23);
            txtRoomNumber.TabIndex = 27;
            // 
            // txtSurname
            // 
            txtSurname.BorderStyle = BorderStyle.FixedSingle;
            txtSurname.Enabled = false;
            txtSurname.Location = new Point(83, 219);
            txtSurname.Name = "txtSurname";
            txtSurname.ReadOnly = true;
            txtSurname.Size = new Size(190, 23);
            txtSurname.TabIndex = 26;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Enabled = false;
            txtName.Location = new Point(83, 189);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(190, 23);
            txtName.TabIndex = 25;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(632, 416);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 26);
            btnSave.TabIndex = 24;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(653, 64);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(31, 15);
            lblAge.TabIndex = 42;
            lblAge.Text = "Age:";
            // 
            // lblAgeNumber
            // 
            lblAgeNumber.AutoSize = true;
            lblAgeNumber.Location = new Point(694, 64);
            lblAgeNumber.Name = "lblAgeNumber";
            lblAgeNumber.Size = new Size(12, 15);
            lblAgeNumber.TabIndex = 43;
            lblAgeNumber.Text = "-";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(713, 416);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 26);
            btnEdit.TabIndex = 44;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(551, 416);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 26);
            btnCancel.TabIndex = 45;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(470, 416);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 26);
            btnDelete.TabIndex = 46;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Enabled = false;
            btnCheckIn.Location = new Point(91, 416);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(75, 26);
            btnCheckIn.TabIndex = 49;
            btnCheckIn.Text = "Check-in";
            btnCheckIn.UseVisualStyleBackColor = true;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Enabled = false;
            btnCheckOut.Location = new Point(253, 416);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(75, 26);
            btnCheckOut.TabIndex = 48;
            btnCheckOut.Text = "Check-out";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnExtendStay
            // 
            btnExtendStay.Enabled = false;
            btnExtendStay.Location = new Point(172, 416);
            btnExtendStay.Name = "btnExtendStay";
            btnExtendStay.Size = new Size(75, 26);
            btnExtendStay.TabIndex = 47;
            btnExtendStay.Text = "Extend stay";
            btnExtendStay.UseVisualStyleBackColor = true;
            btnExtendStay.Click += btnExtendStay_Click;
            // 
            // dtpCheckInDate
            // 
            dtpCheckInDate.Enabled = false;
            dtpCheckInDate.Format = DateTimePickerFormat.Short;
            dtpCheckInDate.Location = new Point(15, 377);
            dtpCheckInDate.Name = "dtpCheckInDate";
            dtpCheckInDate.Size = new Size(143, 23);
            dtpCheckInDate.TabIndex = 50;
            dtpCheckInDate.Value = new DateTime(2025, 6, 23, 19, 38, 50, 0);
            // 
            // dtpCheckOutDate
            // 
            dtpCheckOutDate.Enabled = false;
            dtpCheckOutDate.Format = DateTimePickerFormat.Short;
            dtpCheckOutDate.Location = new Point(178, 377);
            dtpCheckOutDate.Name = "dtpCheckOutDate";
            dtpCheckOutDate.Size = new Size(143, 23);
            dtpCheckOutDate.TabIndex = 51;
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(83, 248);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(190, 23);
            cmbGender.TabIndex = 52;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(18, 252);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(48, 15);
            lblGender.TabIndex = 53;
            lblGender.Text = "Gender:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(18, 309);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 55;
            lblStatus.Text = "Status:";
            // 
            // lblAdditionalInfo
            // 
            lblAdditionalInfo.AutoSize = true;
            lblAdditionalInfo.Location = new Point(373, 139);
            lblAdditionalInfo.Name = "lblAdditionalInfo";
            lblAdditionalInfo.Size = new Size(59, 15);
            lblAdditionalInfo.TabIndex = 68;
            lblAdditionalInfo.Text = "Add. info:";
            // 
            // txtAdditionalInfo
            // 
            txtAdditionalInfo.BorderStyle = BorderStyle.FixedSingle;
            txtAdditionalInfo.Enabled = false;
            txtAdditionalInfo.Location = new Point(439, 136);
            txtAdditionalInfo.Multiline = true;
            txtAdditionalInfo.Name = "txtAdditionalInfo";
            txtAdditionalInfo.ReadOnly = true;
            txtAdditionalInfo.Size = new Size(306, 146);
            txtAdditionalInfo.TabIndex = 67;
            // 
            // txtInHotelStatus
            // 
            txtInHotelStatus.BorderStyle = BorderStyle.FixedSingle;
            txtInHotelStatus.Enabled = false;
            txtInHotelStatus.Location = new Point(83, 306);
            txtInHotelStatus.Name = "txtInHotelStatus";
            txtInHotelStatus.ReadOnly = true;
            txtInHotelStatus.Size = new Size(190, 23);
            txtInHotelStatus.TabIndex = 69;
            // 
            // btnBook
            // 
            btnBook.Enabled = false;
            btnBook.Location = new Point(12, 416);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(75, 26);
            btnBook.TabIndex = 70;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Location = new Point(12, 350);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(84, 15);
            lblCheckIn.TabIndex = 71;
            lblCheckIn.Text = "Check-in date:";
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Location = new Point(178, 350);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(92, 15);
            lblCheckOut.TabIndex = 72;
            lblCheckOut.Text = "Check-out date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 381);
            label1.Name = "label1";
            label1.Size = new Size(12, 15);
            label1.TabIndex = 73;
            label1.Text = "-";
            // 
            // GuestProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblCheckOut);
            Controls.Add(lblCheckIn);
            Controls.Add(btnBook);
            Controls.Add(txtInHotelStatus);
            Controls.Add(lblAdditionalInfo);
            Controls.Add(txtAdditionalInfo);
            Controls.Add(lblStatus);
            Controls.Add(lblGender);
            Controls.Add(cmbGender);
            Controls.Add(dtpCheckOutDate);
            Controls.Add(dtpCheckInDate);
            Controls.Add(btnCheckIn);
            Controls.Add(btnCheckOut);
            Controls.Add(btnExtendStay);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(lblAgeNumber);
            Controls.Add(lblAge);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblBirthDate);
            Controls.Add(lblPassport);
            Controls.Add(dtpBirthDate);
            Controls.Add(txtPassport);
            Controls.Add(lblGuestRoom);
            Controls.Add(lblGuestSurname);
            Controls.Add(lblGuestName);
            Controls.Add(btnChoosePhoto);
            Controls.Add(pictureBoxPreview);
            Controls.Add(chkVIP);
            Controls.Add(txtRoomNumber);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(btnSave);
            Name = "GuestProfile";
            Text = "GuestProfile";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
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
        private Label lblGuestRoom;
        private Label lblGuestSurname;
        private Label lblGuestName;
        private Button btnChoosePhoto;
        private PictureBox pictureBoxPreview;
        private CheckBox chkVIP;
        private TextBox txtRoomNumber;
        private TextBox txtSurname;
        private TextBox txtName;
        private Button btnSave;
        private Label lblAge;
        private Label lblAgeNumber;
        private Button btnEdit;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnCheckIn;
        private Button btnCheckOut;
        private Button btnExtendStay;
        private DateTimePicker dtpCheckInDate;
        private DateTimePicker dtpCheckOutDate;
        private ComboBox cmbGender;
        private Label lblGender;
        private Label lblStatus;
        private Label lblAdditionalInfo;
        private TextBox txtAdditionalInfo;
        private TextBox txtInHotelStatus;
        private Button btnBook;
        private Label lblCheckIn;
        private Label lblCheckOut;
        private Label label1;
    }
}