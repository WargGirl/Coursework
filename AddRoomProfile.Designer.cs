namespace Coursework
{
    partial class AddRoomProfile
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
            pictureBoxRoomPreview = new PictureBox();
            txtRoomNumber = new TextBox();
            cmbRoomType = new ComboBox();
            cmbRoomStatus = new ComboBox();
            txtDescription = new TextBox();
            txtPhotoPath = new TextBox();
            btnChoosePhoto = new Button();
            chkHasBalcony = new CheckBox();
            chkIsSmokingAllowed = new CheckBox();
            chkHasKitchen = new CheckBox();
            chkIsPetFriendly = new CheckBox();
            cmbRoomView = new ComboBox();
            numFloor = new NumericUpDown();
            btnAdd = new Button();
            btnCancel = new Button();
            lblDescription = new Label();
            lblRoomNumber = new Label();
            label3 = new Label();
            lblRoomType = new Label();
            lblRoomStatus = new Label();
            lblRoomView = new Label();
            lblFloor = new Label();
            pnlBedConfigs = new Panel();
            btnAddBedConfig = new Button();
            lblBeds = new Label();
            lblPreviewPhoto = new Label();
            numPrice = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoomPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFloor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxRoomPreview
            // 
            pictureBoxRoomPreview.Location = new Point(12, 33);
            pictureBoxRoomPreview.Name = "pictureBoxRoomPreview";
            pictureBoxRoomPreview.Size = new Size(220, 135);
            pictureBoxRoomPreview.TabIndex = 0;
            pictureBoxRoomPreview.TabStop = false;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.BorderStyle = BorderStyle.FixedSingle;
            txtRoomNumber.Location = new Point(118, 207);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(120, 23);
            txtRoomNumber.TabIndex = 1;
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(118, 263);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(121, 23);
            cmbRoomType.TabIndex = 4;
            // 
            // cmbRoomStatus
            // 
            cmbRoomStatus.FormattingEnabled = true;
            cmbRoomStatus.Location = new Point(118, 292);
            cmbRoomStatus.Name = "cmbRoomStatus";
            cmbRoomStatus.Size = new Size(121, 23);
            cmbRoomStatus.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Location = new Point(506, 33);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(282, 183);
            txtDescription.TabIndex = 6;
            // 
            // txtPhotoPath
            // 
            txtPhotoPath.BorderStyle = BorderStyle.FixedSingle;
            txtPhotoPath.Enabled = false;
            txtPhotoPath.Location = new Point(12, 178);
            txtPhotoPath.Name = "txtPhotoPath";
            txtPhotoPath.ReadOnly = true;
            txtPhotoPath.Size = new Size(226, 23);
            txtPhotoPath.TabIndex = 7;
            // 
            // btnChoosePhoto
            // 
            btnChoosePhoto.Location = new Point(150, 4);
            btnChoosePhoto.Name = "btnChoosePhoto";
            btnChoosePhoto.Size = new Size(82, 26);
            btnChoosePhoto.TabIndex = 8;
            btnChoosePhoto.Text = "Choose";
            btnChoosePhoto.UseVisualStyleBackColor = true;
            btnChoosePhoto.Click += btnChoosePhoto_Click;
            // 
            // chkHasBalcony
            // 
            chkHasBalcony.AutoSize = true;
            chkHasBalcony.Location = new Point(12, 385);
            chkHasBalcony.Name = "chkHasBalcony";
            chkHasBalcony.Size = new Size(68, 19);
            chkHasBalcony.TabIndex = 9;
            chkHasBalcony.Text = "Balcony";
            chkHasBalcony.UseVisualStyleBackColor = true;
            // 
            // chkIsSmokingAllowed
            // 
            chkIsSmokingAllowed.AutoSize = true;
            chkIsSmokingAllowed.Location = new Point(118, 385);
            chkIsSmokingAllowed.Name = "chkIsSmokingAllowed";
            chkIsSmokingAllowed.Size = new Size(117, 19);
            chkIsSmokingAllowed.TabIndex = 10;
            chkIsSmokingAllowed.Text = "Smoking allowed";
            chkIsSmokingAllowed.UseVisualStyleBackColor = true;
            // 
            // chkHasKitchen
            // 
            chkHasKitchen.AutoSize = true;
            chkHasKitchen.Location = new Point(12, 413);
            chkHasKitchen.Name = "chkHasKitchen";
            chkHasKitchen.Size = new Size(66, 19);
            chkHasKitchen.TabIndex = 11;
            chkHasKitchen.Text = "Kitchen";
            chkHasKitchen.UseVisualStyleBackColor = true;
            // 
            // chkIsPetFriendly
            // 
            chkIsPetFriendly.AutoSize = true;
            chkIsPetFriendly.Location = new Point(118, 413);
            chkIsPetFriendly.Name = "chkIsPetFriendly";
            chkIsPetFriendly.Size = new Size(92, 19);
            chkIsPetFriendly.TabIndex = 12;
            chkIsPetFriendly.Text = "Pets allowed";
            chkIsPetFriendly.UseVisualStyleBackColor = true;
            // 
            // cmbRoomView
            // 
            cmbRoomView.FormattingEnabled = true;
            cmbRoomView.Location = new Point(118, 321);
            cmbRoomView.Name = "cmbRoomView";
            cmbRoomView.Size = new Size(121, 23);
            cmbRoomView.TabIndex = 13;
            // 
            // numFloor
            // 
            numFloor.Location = new Point(118, 350);
            numFloor.Name = "numFloor";
            numFloor.Size = new Size(120, 23);
            numFloor.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(719, 419);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 26);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(638, 419);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 26);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(506, 12);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 21;
            lblDescription.Text = "Description:";
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Location = new Point(12, 210);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(87, 15);
            lblRoomNumber.TabIndex = 22;
            lblRoomNumber.Text = "Room number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 237);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 24;
            label3.Text = "Price:";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Location = new Point(12, 266);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(68, 15);
            lblRoomType.TabIndex = 25;
            lblRoomType.Text = "Room type:";
            // 
            // lblRoomStatus
            // 
            lblRoomStatus.AutoSize = true;
            lblRoomStatus.Location = new Point(12, 295);
            lblRoomStatus.Name = "lblRoomStatus";
            lblRoomStatus.Size = new Size(76, 15);
            lblRoomStatus.TabIndex = 26;
            lblRoomStatus.Text = "Room status:";
            // 
            // lblRoomView
            // 
            lblRoomView.AutoSize = true;
            lblRoomView.Location = new Point(12, 324);
            lblRoomView.Name = "lblRoomView";
            lblRoomView.Size = new Size(69, 15);
            lblRoomView.TabIndex = 27;
            lblRoomView.Text = "Room view:";
            // 
            // lblFloor
            // 
            lblFloor.AutoSize = true;
            lblFloor.Location = new Point(12, 352);
            lblFloor.Name = "lblFloor";
            lblFloor.Size = new Size(37, 15);
            lblFloor.TabIndex = 28;
            lblFloor.Text = "Floor:";
            // 
            // pnlBedConfigs
            // 
            pnlBedConfigs.Location = new Point(244, 33);
            pnlBedConfigs.Name = "pnlBedConfigs";
            pnlBedConfigs.Size = new Size(256, 183);
            pnlBedConfigs.TabIndex = 29;
            // 
            // btnAddBedConfig
            // 
            btnAddBedConfig.Location = new Point(418, 4);
            btnAddBedConfig.Name = "btnAddBedConfig";
            btnAddBedConfig.Size = new Size(82, 26);
            btnAddBedConfig.TabIndex = 30;
            btnAddBedConfig.Text = "Add bed";
            btnAddBedConfig.UseVisualStyleBackColor = true;
            // 
            // lblBeds
            // 
            lblBeds.AutoSize = true;
            lblBeds.Location = new Point(244, 12);
            lblBeds.Name = "lblBeds";
            lblBeds.Size = new Size(35, 15);
            lblBeds.TabIndex = 31;
            lblBeds.Text = "Beds:";
            // 
            // lblPreviewPhoto
            // 
            lblPreviewPhoto.AutoSize = true;
            lblPreviewPhoto.Location = new Point(12, 12);
            lblPreviewPhoto.Name = "lblPreviewPhoto";
            lblPreviewPhoto.Size = new Size(42, 15);
            lblPreviewPhoto.TabIndex = 32;
            lblPreviewPhoto.Text = "Photo:";
            // 
            // numPrice
            // 
            numPrice.Location = new Point(118, 235);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(120, 23);
            numPrice.TabIndex = 33;
            // 
            // AddRoomProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numPrice);
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
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
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
            Name = "AddRoomProfile";
            Text = "AddRoomProfile";
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoomPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFloor).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxRoomPreview;
        private TextBox txtRoomNumber;
        private ComboBox cmbRoomType;
        private ComboBox cmbRoomStatus;
        private TextBox txtDescription;
        private TextBox txtPhotoPath;
        private Button btnChoosePhoto;
        private CheckBox chkHasBalcony;
        private CheckBox chkIsSmokingAllowed;
        private CheckBox chkHasKitchen;
        private CheckBox chkIsPetFriendly;
        private ComboBox cmbRoomView;
        private NumericUpDown numFloor;
        private Button btnAdd;
        private Button btnCancel;
        private Label lblDescription;
        private Label lblRoomNumber;
        private Label label3;
        private Label lblRoomType;
        private Label lblRoomStatus;
        private Label lblRoomView;
        private Label lblFloor;
        private Panel pnlBedConfigs;
        private Button btnAddBedConfig;
        private Label lblBeds;
        private Label lblPreviewPhoto;
        private NumericUpDown numPrice;
    }
}