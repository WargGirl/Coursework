namespace Coursework
{
    partial class RoomProfile
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
            lblPreviewPhoto = new Label();
            lblBeds = new Label();
            btnAddBedConfig = new Button();
            pnlBedConfigs = new Panel();
            lblFloor = new Label();
            lblRoomView = new Label();
            lblRoomStatus = new Label();
            lblRoomType = new Label();
            label3 = new Label();
            lblRoomNumber = new Label();
            lblDescription = new Label();
            numFloor = new NumericUpDown();
            cmbRoomView = new ComboBox();
            chkIsPetFriendly = new CheckBox();
            chkHasKitchen = new CheckBox();
            chkIsSmokingAllowed = new CheckBox();
            chkHasBalcony = new CheckBox();
            btnChoosePhoto = new Button();
            txtPhotoPath = new TextBox();
            txtDescription = new TextBox();
            cmbRoomStatus = new ComboBox();
            cmbRoomType = new ComboBox();
            txtRoomNumber = new TextBox();
            pictureBoxRoomPreview = new PictureBox();
            btnDelete = new Button();
            btnCancel = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            numPrice = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numFloor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoomPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            SuspendLayout();
            // 
            // lblPreviewPhoto
            // 
            lblPreviewPhoto.AutoSize = true;
            lblPreviewPhoto.Location = new Point(12, 12);
            lblPreviewPhoto.Name = "lblPreviewPhoto";
            lblPreviewPhoto.Size = new Size(42, 15);
            lblPreviewPhoto.TabIndex = 59;
            lblPreviewPhoto.Text = "Photo:";
            // 
            // lblBeds
            // 
            lblBeds.AutoSize = true;
            lblBeds.Location = new Point(244, 12);
            lblBeds.Name = "lblBeds";
            lblBeds.Size = new Size(35, 15);
            lblBeds.TabIndex = 58;
            lblBeds.Text = "Beds:";
            // 
            // btnAddBedConfig
            // 
            btnAddBedConfig.Location = new Point(418, 4);
            btnAddBedConfig.Name = "btnAddBedConfig";
            btnAddBedConfig.Size = new Size(82, 26);
            btnAddBedConfig.TabIndex = 57;
            btnAddBedConfig.Text = "Add bed";
            btnAddBedConfig.UseVisualStyleBackColor = true;
            btnAddBedConfig.Click += btnAddBedConfig_Click;
            // 
            // pnlBedConfigs
            // 
            pnlBedConfigs.Location = new Point(244, 33);
            pnlBedConfigs.Name = "pnlBedConfigs";
            pnlBedConfigs.Size = new Size(256, 183);
            pnlBedConfigs.TabIndex = 56;
            // 
            // lblFloor
            // 
            lblFloor.AutoSize = true;
            lblFloor.Location = new Point(12, 352);
            lblFloor.Name = "lblFloor";
            lblFloor.Size = new Size(37, 15);
            lblFloor.TabIndex = 55;
            lblFloor.Text = "Floor:";
            // 
            // lblRoomView
            // 
            lblRoomView.AutoSize = true;
            lblRoomView.Location = new Point(12, 324);
            lblRoomView.Name = "lblRoomView";
            lblRoomView.Size = new Size(69, 15);
            lblRoomView.TabIndex = 54;
            lblRoomView.Text = "Room view:";
            // 
            // lblRoomStatus
            // 
            lblRoomStatus.AutoSize = true;
            lblRoomStatus.Location = new Point(12, 295);
            lblRoomStatus.Name = "lblRoomStatus";
            lblRoomStatus.Size = new Size(76, 15);
            lblRoomStatus.TabIndex = 53;
            lblRoomStatus.Text = "Room status:";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Location = new Point(12, 266);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(68, 15);
            lblRoomType.TabIndex = 52;
            lblRoomType.Text = "Room type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 237);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 51;
            label3.Text = "Price:";
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Location = new Point(12, 210);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(87, 15);
            lblRoomNumber.TabIndex = 50;
            lblRoomNumber.Text = "Room number:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(506, 12);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 49;
            lblDescription.Text = "Description:";
            // 
            // numFloor
            // 
            numFloor.Enabled = false;
            numFloor.Location = new Point(118, 350);
            numFloor.Name = "numFloor";
            numFloor.ReadOnly = true;
            numFloor.Size = new Size(120, 23);
            numFloor.TabIndex = 46;
            // 
            // cmbRoomView
            // 
            cmbRoomView.Enabled = false;
            cmbRoomView.FormattingEnabled = true;
            cmbRoomView.Location = new Point(118, 321);
            cmbRoomView.Name = "cmbRoomView";
            cmbRoomView.Size = new Size(121, 23);
            cmbRoomView.TabIndex = 45;
            // 
            // chkIsPetFriendly
            // 
            chkIsPetFriendly.AutoSize = true;
            chkIsPetFriendly.Enabled = false;
            chkIsPetFriendly.Location = new Point(118, 413);
            chkIsPetFriendly.Name = "chkIsPetFriendly";
            chkIsPetFriendly.Size = new Size(92, 19);
            chkIsPetFriendly.TabIndex = 44;
            chkIsPetFriendly.Text = "Pets allowed";
            chkIsPetFriendly.UseVisualStyleBackColor = true;
            // 
            // chkHasKitchen
            // 
            chkHasKitchen.AutoSize = true;
            chkHasKitchen.Enabled = false;
            chkHasKitchen.Location = new Point(12, 413);
            chkHasKitchen.Name = "chkHasKitchen";
            chkHasKitchen.Size = new Size(66, 19);
            chkHasKitchen.TabIndex = 43;
            chkHasKitchen.Text = "Kitchen";
            chkHasKitchen.UseVisualStyleBackColor = true;
            // 
            // chkIsSmokingAllowed
            // 
            chkIsSmokingAllowed.AutoSize = true;
            chkIsSmokingAllowed.Enabled = false;
            chkIsSmokingAllowed.Location = new Point(118, 385);
            chkIsSmokingAllowed.Name = "chkIsSmokingAllowed";
            chkIsSmokingAllowed.Size = new Size(117, 19);
            chkIsSmokingAllowed.TabIndex = 42;
            chkIsSmokingAllowed.Text = "Smoking allowed";
            chkIsSmokingAllowed.UseVisualStyleBackColor = true;
            // 
            // chkHasBalcony
            // 
            chkHasBalcony.AutoSize = true;
            chkHasBalcony.Enabled = false;
            chkHasBalcony.Location = new Point(12, 385);
            chkHasBalcony.Name = "chkHasBalcony";
            chkHasBalcony.Size = new Size(68, 19);
            chkHasBalcony.TabIndex = 41;
            chkHasBalcony.Text = "Balcony";
            chkHasBalcony.UseVisualStyleBackColor = true;
            // 
            // btnChoosePhoto
            // 
            btnChoosePhoto.Enabled = false;
            btnChoosePhoto.Location = new Point(150, 4);
            btnChoosePhoto.Name = "btnChoosePhoto";
            btnChoosePhoto.Size = new Size(82, 26);
            btnChoosePhoto.TabIndex = 40;
            btnChoosePhoto.Text = "Choose";
            btnChoosePhoto.UseVisualStyleBackColor = true;
            btnChoosePhoto.Click += btnChoosePhoto_Click;
            // 
            // txtPhotoPath
            // 
            txtPhotoPath.BorderStyle = BorderStyle.FixedSingle;
            txtPhotoPath.Enabled = false;
            txtPhotoPath.Location = new Point(12, 178);
            txtPhotoPath.Name = "txtPhotoPath";
            txtPhotoPath.ReadOnly = true;
            txtPhotoPath.Size = new Size(226, 23);
            txtPhotoPath.TabIndex = 39;
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Enabled = false;
            txtDescription.Location = new Point(506, 33);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(282, 183);
            txtDescription.TabIndex = 38;
            // 
            // cmbRoomStatus
            // 
            cmbRoomStatus.Enabled = false;
            cmbRoomStatus.FormattingEnabled = true;
            cmbRoomStatus.Location = new Point(118, 292);
            cmbRoomStatus.Name = "cmbRoomStatus";
            cmbRoomStatus.Size = new Size(121, 23);
            cmbRoomStatus.TabIndex = 37;
            // 
            // cmbRoomType
            // 
            cmbRoomType.Enabled = false;
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(118, 263);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(121, 23);
            cmbRoomType.TabIndex = 36;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.BorderStyle = BorderStyle.FixedSingle;
            txtRoomNumber.Enabled = false;
            txtRoomNumber.Location = new Point(118, 207);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.ReadOnly = true;
            txtRoomNumber.Size = new Size(120, 23);
            txtRoomNumber.TabIndex = 34;
            // 
            // pictureBoxRoomPreview
            // 
            pictureBoxRoomPreview.Location = new Point(12, 33);
            pictureBoxRoomPreview.Name = "pictureBoxRoomPreview";
            pictureBoxRoomPreview.Size = new Size(220, 135);
            pictureBoxRoomPreview.TabIndex = 33;
            pictureBoxRoomPreview.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(470, 416);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 26);
            btnDelete.TabIndex = 63;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(551, 416);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 26);
            btnCancel.TabIndex = 62;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(713, 416);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 26);
            btnEdit.TabIndex = 61;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(632, 416);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 26);
            btnSave.TabIndex = 60;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // numPrice
            // 
            numPrice.Enabled = false;
            numPrice.Location = new Point(118, 235);
            numPrice.Name = "numPrice";
            numPrice.ReadOnly = true;
            numPrice.Size = new Size(120, 23);
            numPrice.TabIndex = 64;
            // 
            // RoomProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numPrice);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(lblPreviewPhoto);
            Controls.Add(lblBeds);
            Controls.Add(btnAddBedConfig);
            Controls.Add(pnlBedConfigs);
            Controls.Add(lblFloor);
            Controls.Add(lblRoomView);
            Controls.Add(lblRoomStatus);
            Controls.Add(lblRoomType);
            Controls.Add(label3);
            Controls.Add(lblRoomNumber);
            Controls.Add(lblDescription);
            Controls.Add(numFloor);
            Controls.Add(cmbRoomView);
            Controls.Add(chkIsPetFriendly);
            Controls.Add(chkHasKitchen);
            Controls.Add(chkIsSmokingAllowed);
            Controls.Add(chkHasBalcony);
            Controls.Add(btnChoosePhoto);
            Controls.Add(txtPhotoPath);
            Controls.Add(txtDescription);
            Controls.Add(cmbRoomStatus);
            Controls.Add(cmbRoomType);
            Controls.Add(txtRoomNumber);
            Controls.Add(pictureBoxRoomPreview);
            Name = "RoomProfile";
            Text = "RoomProfile";
            ((System.ComponentModel.ISupportInitialize)numFloor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoomPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPreviewPhoto;
        private Label lblBeds;
        private Button btnAddBedConfig;
        private Panel pnlBedConfigs;
        private Label lblFloor;
        private Label lblRoomView;
        private Label lblRoomStatus;
        private Label lblRoomType;
        private Label label3;
        private Label lblRoomNumber;
        private Label lblDescription;
        private NumericUpDown numFloor;
        private ComboBox cmbRoomView;
        private CheckBox chkIsPetFriendly;
        private CheckBox chkHasKitchen;
        private CheckBox chkIsSmokingAllowed;
        private CheckBox chkHasBalcony;
        private Button btnChoosePhoto;
        private TextBox txtPhotoPath;
        private TextBox txtDescription;
        private ComboBox cmbRoomStatus;
        private ComboBox cmbRoomType;
        private TextBox txtRoomNumber;
        private PictureBox pictureBoxRoomPreview;
        private Button btnDelete;
        private Button btnCancel;
        private Button btnEdit;
        private Button btnSave;
        private NumericUpDown numPrice;
    }
}