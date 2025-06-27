namespace Coursework
{
    partial class ProfileCard
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
            guestPicBox = new PictureBox();
            lblName = new Label();
            lblSurname = new Label();
            lblVIPStatus = new Label();
            lblGuestRoom = new Label();
            lblInHotelStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)guestPicBox).BeginInit();
            SuspendLayout();
            // 
            // guestPicBox
            // 
            guestPicBox.BackColor = Color.White;
            guestPicBox.Location = new Point(4, 3);
            guestPicBox.Name = "guestPicBox";
            guestPicBox.Size = new Size(56, 70);
            guestPicBox.TabIndex = 0;
            guestPicBox.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(71, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(38, 15);
            lblName.TabIndex = 1;
            lblName.Text = "label1";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(71, 43);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(38, 15);
            lblSurname.TabIndex = 3;
            lblSurname.Text = "label2";
            // 
            // lblVIPStatus
            // 
            lblVIPStatus.AutoSize = true;
            lblVIPStatus.Location = new Point(297, 32);
            lblVIPStatus.Name = "lblVIPStatus";
            lblVIPStatus.Size = new Size(38, 15);
            lblVIPStatus.TabIndex = 4;
            lblVIPStatus.Text = "label1";
            // 
            // lblGuestRoom
            // 
            lblGuestRoom.AutoSize = true;
            lblGuestRoom.Location = new Point(386, 32);
            lblGuestRoom.Name = "lblGuestRoom";
            lblGuestRoom.Size = new Size(38, 15);
            lblGuestRoom.TabIndex = 5;
            lblGuestRoom.Text = "label1";
            // 
            // lblInHotelStatus
            // 
            lblInHotelStatus.AutoSize = true;
            lblInHotelStatus.Location = new Point(492, 32);
            lblInHotelStatus.Name = "lblInHotelStatus";
            lblInHotelStatus.Size = new Size(38, 15);
            lblInHotelStatus.TabIndex = 6;
            lblInHotelStatus.Text = "label1";
            // 
            // ProfileCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblInHotelStatus);
            Controls.Add(lblGuestRoom);
            Controls.Add(lblVIPStatus);
            Controls.Add(lblSurname);
            Controls.Add(lblName);
            Controls.Add(guestPicBox);
            Name = "ProfileCard";
            Size = new Size(758, 78);
            ((System.ComponentModel.ISupportInitialize)guestPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox guestPicBox;
        private Label lblName;
        private Label lblSurname;
        private Label lblVIPStatus;
        private Label lblGuestRoom;
        private Label lblInHotelStatus;
    }
}
