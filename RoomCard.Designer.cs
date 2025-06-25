namespace Coursework
{
    partial class RoomCard
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
            roomPicBox = new PictureBox();
            lblRoomNumber = new Label();
            lblRoomType = new Label();
            lblCapacity = new Label();
            lblPrice = new Label();
            lblStatus = new Label();
            lblBeds = new Label();
            ((System.ComponentModel.ISupportInitialize)roomPicBox).BeginInit();
            SuspendLayout();
            // 
            // roomPicBox
            // 
            roomPicBox.Location = new Point(3, 3);
            roomPicBox.Name = "roomPicBox";
            roomPicBox.Size = new Size(138, 85);
            roomPicBox.TabIndex = 0;
            roomPicBox.TabStop = false;
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Location = new Point(152, 24);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(38, 15);
            lblRoomNumber.TabIndex = 1;
            lblRoomNumber.Text = "label1";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Location = new Point(152, 50);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(38, 15);
            lblRoomType.TabIndex = 2;
            lblRoomType.Text = "label2";
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Location = new Point(332, 12);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(38, 15);
            lblCapacity.TabIndex = 3;
            lblCapacity.Text = "label3";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(332, 38);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(38, 15);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "label1";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(607, 38);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(38, 15);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "label2";
            // 
            // lblBeds
            // 
            lblBeds.AutoSize = true;
            lblBeds.Location = new Point(332, 64);
            lblBeds.Name = "lblBeds";
            lblBeds.Size = new Size(38, 15);
            lblBeds.TabIndex = 6;
            lblBeds.Text = "label1";
            // 
            // RoomCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblBeds);
            Controls.Add(lblStatus);
            Controls.Add(lblPrice);
            Controls.Add(lblCapacity);
            Controls.Add(lblRoomType);
            Controls.Add(lblRoomNumber);
            Controls.Add(roomPicBox);
            Name = "RoomCard";
            Size = new Size(757, 91);
            ((System.ComponentModel.ISupportInitialize)roomPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox roomPicBox;
        private Label lblRoomNumber;
        private Label lblRoomType;
        private Label lblCapacity;
        private Label lblPrice;
        private Label lblStatus;
        private Label lblBeds;
    }
}
