namespace Coursework
{
    partial class RoomSelectionForm
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
            roomsLayoutPanel = new TableLayoutPanel();
            roomsControlPanel = new Panel();
            btnCancel = new Button();
            btnRoomFilters = new Button();
            btnSelectRoom = new Button();
            roomsFilterPanel = new Panel();
            label3 = new Label();
            dtpCheckOutSelection = new DateTimePicker();
            dtpCheckInSelection = new DateTimePicker();
            label9 = new Label();
            label2 = new Label();
            numMinCapacityFilter = new NumericUpDown();
            numMaxCapacityFilter = new NumericUpDown();
            label1 = new Label();
            lblRoomView = new Label();
            lblRoomType = new Label();
            lblBedType = new Label();
            lblRoomStatus = new Label();
            lblCapacity = new Label();
            lblPrice = new Label();
            lblFloor = new Label();
            lblRoomNumber = new Label();
            btnRoomFilterClear = new Button();
            btnRoomSearch = new Button();
            chkIsPetFriendlyFilter = new CheckBox();
            chkIsSmokingAllowedFilter = new CheckBox();
            chkHasKitchenFilter = new CheckBox();
            chkHasBalconyFilter = new CheckBox();
            numMinPriceFilter = new NumericUpDown();
            numMaxPriceFilter = new NumericUpDown();
            cmbBedTypeFilter = new ComboBox();
            numMaxFloorFilter = new NumericUpDown();
            numMinFloorFilter = new NumericUpDown();
            cmbRoomViewFilter = new ComboBox();
            cmbRoomStatusFilter = new ComboBox();
            cmbRoomTypeFilter = new ComboBox();
            txtRoomNumberFilter = new TextBox();
            availableRoomsFlowLayoutPanel = new FlowLayoutPanel();
            roomsLayoutPanel.SuspendLayout();
            roomsControlPanel.SuspendLayout();
            roomsFilterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMinCapacityFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaxCapacityFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinPriceFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaxPriceFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaxFloorFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinFloorFilter).BeginInit();
            SuspendLayout();
            // 
            // roomsLayoutPanel
            // 
            roomsLayoutPanel.ColumnCount = 1;
            roomsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            roomsLayoutPanel.Controls.Add(roomsControlPanel, 0, 0);
            roomsLayoutPanel.Controls.Add(roomsFilterPanel, 0, 1);
            roomsLayoutPanel.Controls.Add(availableRoomsFlowLayoutPanel, 1, 2);
            roomsLayoutPanel.Dock = DockStyle.Fill;
            roomsLayoutPanel.Location = new Point(0, 0);
            roomsLayoutPanel.Name = "roomsLayoutPanel";
            roomsLayoutPanel.RowCount = 3;
            roomsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            roomsLayoutPanel.RowStyles.Add(new RowStyle());
            roomsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            roomsLayoutPanel.Size = new Size(800, 450);
            roomsLayoutPanel.TabIndex = 1;
            // 
            // roomsControlPanel
            // 
            roomsControlPanel.Controls.Add(btnCancel);
            roomsControlPanel.Controls.Add(btnRoomFilters);
            roomsControlPanel.Controls.Add(btnSelectRoom);
            roomsControlPanel.Dock = DockStyle.Fill;
            roomsControlPanel.Location = new Point(3, 3);
            roomsControlPanel.Name = "roomsControlPanel";
            roomsControlPanel.Size = new Size(794, 23);
            roomsControlPanel.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(603, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRoomFilters
            // 
            btnRoomFilters.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnRoomFilters.FlatStyle = FlatStyle.Flat;
            btnRoomFilters.Location = new Point(3, 0);
            btnRoomFilters.Name = "btnRoomFilters";
            btnRoomFilters.Size = new Size(96, 23);
            btnRoomFilters.TabIndex = 5;
            btnRoomFilters.Text = "Show filters";
            btnRoomFilters.UseVisualStyleBackColor = true;
            btnRoomFilters.Click += btnRoomFilters_Click;
            // 
            // btnSelectRoom
            // 
            btnSelectRoom.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnSelectRoom.FlatStyle = FlatStyle.Flat;
            btnSelectRoom.Location = new Point(684, 0);
            btnSelectRoom.Name = "btnSelectRoom";
            btnSelectRoom.Size = new Size(75, 23);
            btnSelectRoom.TabIndex = 4;
            btnSelectRoom.Text = "Select";
            btnSelectRoom.UseVisualStyleBackColor = true;
            btnSelectRoom.Click += btnSelectRoom_Click;
            // 
            // roomsFilterPanel
            // 
            roomsFilterPanel.Controls.Add(label3);
            roomsFilterPanel.Controls.Add(dtpCheckOutSelection);
            roomsFilterPanel.Controls.Add(dtpCheckInSelection);
            roomsFilterPanel.Controls.Add(label9);
            roomsFilterPanel.Controls.Add(label2);
            roomsFilterPanel.Controls.Add(numMinCapacityFilter);
            roomsFilterPanel.Controls.Add(numMaxCapacityFilter);
            roomsFilterPanel.Controls.Add(label1);
            roomsFilterPanel.Controls.Add(lblRoomView);
            roomsFilterPanel.Controls.Add(lblRoomType);
            roomsFilterPanel.Controls.Add(lblBedType);
            roomsFilterPanel.Controls.Add(lblRoomStatus);
            roomsFilterPanel.Controls.Add(lblCapacity);
            roomsFilterPanel.Controls.Add(lblPrice);
            roomsFilterPanel.Controls.Add(lblFloor);
            roomsFilterPanel.Controls.Add(lblRoomNumber);
            roomsFilterPanel.Controls.Add(btnRoomFilterClear);
            roomsFilterPanel.Controls.Add(btnRoomSearch);
            roomsFilterPanel.Controls.Add(chkIsPetFriendlyFilter);
            roomsFilterPanel.Controls.Add(chkIsSmokingAllowedFilter);
            roomsFilterPanel.Controls.Add(chkHasKitchenFilter);
            roomsFilterPanel.Controls.Add(chkHasBalconyFilter);
            roomsFilterPanel.Controls.Add(numMinPriceFilter);
            roomsFilterPanel.Controls.Add(numMaxPriceFilter);
            roomsFilterPanel.Controls.Add(cmbBedTypeFilter);
            roomsFilterPanel.Controls.Add(numMaxFloorFilter);
            roomsFilterPanel.Controls.Add(numMinFloorFilter);
            roomsFilterPanel.Controls.Add(cmbRoomViewFilter);
            roomsFilterPanel.Controls.Add(cmbRoomStatusFilter);
            roomsFilterPanel.Controls.Add(cmbRoomTypeFilter);
            roomsFilterPanel.Controls.Add(txtRoomNumberFilter);
            roomsFilterPanel.Dock = DockStyle.Fill;
            roomsFilterPanel.Location = new Point(3, 32);
            roomsFilterPanel.Name = "roomsFilterPanel";
            roomsFilterPanel.Size = new Size(794, 120);
            roomsFilterPanel.TabIndex = 4;
            roomsFilterPanel.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(624, 68);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 29;
            label3.Text = "-";
            // 
            // dtpCheckOutSelection
            // 
            dtpCheckOutSelection.Format = DateTimePickerFormat.Short;
            dtpCheckOutSelection.Location = new Point(641, 64);
            dtpCheckOutSelection.Name = "dtpCheckOutSelection";
            dtpCheckOutSelection.Size = new Size(120, 23);
            dtpCheckOutSelection.TabIndex = 28;
            // 
            // dtpCheckInSelection
            // 
            dtpCheckInSelection.Format = DateTimePickerFormat.Short;
            dtpCheckInSelection.Location = new Point(499, 64);
            dtpCheckInSelection.Name = "dtpCheckInSelection";
            dtpCheckInSelection.Size = new Size(120, 23);
            dtpCheckInSelection.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(168, 96);
            label9.Name = "label9";
            label9.Size = new Size(12, 15);
            label9.TabIndex = 26;
            label9.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 66);
            label2.Name = "label2";
            label2.Size = new Size(12, 15);
            label2.TabIndex = 25;
            label2.Text = "-";
            // 
            // numMinCapacityFilter
            // 
            numMinCapacityFilter.Location = new Point(112, 93);
            numMinCapacityFilter.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMinCapacityFilter.Name = "numMinCapacityFilter";
            numMinCapacityFilter.Size = new Size(50, 23);
            numMinCapacityFilter.TabIndex = 6;
            numMinCapacityFilter.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numMaxCapacityFilter
            // 
            numMaxCapacityFilter.Location = new Point(186, 93);
            numMaxCapacityFilter.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMaxCapacityFilter.Name = "numMaxCapacityFilter";
            numMaxCapacityFilter.Size = new Size(50, 23);
            numMaxCapacityFilter.TabIndex = 7;
            numMaxCapacityFilter.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 36);
            label1.Name = "label1";
            label1.Size = new Size(12, 15);
            label1.TabIndex = 24;
            label1.Text = "-";
            // 
            // lblRoomView
            // 
            lblRoomView.AutoSize = true;
            lblRoomView.Location = new Point(252, 97);
            lblRoomView.Name = "lblRoomView";
            lblRoomView.Size = new Size(69, 15);
            lblRoomView.TabIndex = 23;
            lblRoomView.Text = "Room view:";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Location = new Point(252, 37);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(68, 15);
            lblRoomType.TabIndex = 22;
            lblRoomType.Text = "Room type:";
            // 
            // lblBedType
            // 
            lblBedType.AutoSize = true;
            lblBedType.Location = new Point(252, 7);
            lblBedType.Name = "lblBedType";
            lblBedType.Size = new Size(56, 15);
            lblBedType.TabIndex = 21;
            lblBedType.Text = "Bed type:";
            // 
            // lblRoomStatus
            // 
            lblRoomStatus.AutoSize = true;
            lblRoomStatus.Location = new Point(252, 67);
            lblRoomStatus.Name = "lblRoomStatus";
            lblRoomStatus.Size = new Size(76, 15);
            lblRoomStatus.TabIndex = 20;
            lblRoomStatus.Text = "Room status:";
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Location = new Point(13, 97);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(56, 15);
            lblCapacity.TabIndex = 19;
            lblCapacity.Text = "Capacity:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(13, 67);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 18;
            lblPrice.Text = "Price:";
            // 
            // lblFloor
            // 
            lblFloor.AutoSize = true;
            lblFloor.Location = new Point(13, 37);
            lblFloor.Name = "lblFloor";
            lblFloor.Size = new Size(37, 15);
            lblFloor.TabIndex = 17;
            lblFloor.Text = "Floor:";
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Location = new Point(12, 7);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(87, 15);
            lblRoomNumber.TabIndex = 16;
            lblRoomNumber.Text = "Room number:";
            // 
            // btnRoomFilterClear
            // 
            btnRoomFilterClear.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnRoomFilterClear.FlatStyle = FlatStyle.Flat;
            btnRoomFilterClear.Location = new Point(603, 92);
            btnRoomFilterClear.Name = "btnRoomFilterClear";
            btnRoomFilterClear.Size = new Size(75, 23);
            btnRoomFilterClear.TabIndex = 15;
            btnRoomFilterClear.Text = "Clear";
            btnRoomFilterClear.UseVisualStyleBackColor = true;
            btnRoomFilterClear.Click += btnRoomFilterClear_Click;
            // 
            // btnRoomSearch
            // 
            btnRoomSearch.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnRoomSearch.FlatStyle = FlatStyle.Flat;
            btnRoomSearch.Location = new Point(684, 92);
            btnRoomSearch.Name = "btnRoomSearch";
            btnRoomSearch.Size = new Size(75, 23);
            btnRoomSearch.TabIndex = 6;
            btnRoomSearch.Text = "Search";
            btnRoomSearch.UseVisualStyleBackColor = true;
            btnRoomSearch.Click += btnRoomSearch_Click;
            // 
            // chkIsPetFriendlyFilter
            // 
            chkIsPetFriendlyFilter.AutoSize = true;
            chkIsPetFriendlyFilter.Location = new Point(652, 37);
            chkIsPetFriendlyFilter.Name = "chkIsPetFriendlyFilter";
            chkIsPetFriendlyFilter.Size = new Size(92, 19);
            chkIsPetFriendlyFilter.TabIndex = 14;
            chkIsPetFriendlyFilter.Text = "Pets allowed";
            chkIsPetFriendlyFilter.UseVisualStyleBackColor = true;
            // 
            // chkIsSmokingAllowedFilter
            // 
            chkIsSmokingAllowedFilter.AutoSize = true;
            chkIsSmokingAllowedFilter.Location = new Point(652, 8);
            chkIsSmokingAllowedFilter.Name = "chkIsSmokingAllowedFilter";
            chkIsSmokingAllowedFilter.Size = new Size(117, 19);
            chkIsSmokingAllowedFilter.TabIndex = 13;
            chkIsSmokingAllowedFilter.Text = "Smoking allowed";
            chkIsSmokingAllowedFilter.UseVisualStyleBackColor = true;
            // 
            // chkHasKitchenFilter
            // 
            chkHasKitchenFilter.AutoSize = true;
            chkHasKitchenFilter.Location = new Point(499, 37);
            chkHasKitchenFilter.Name = "chkHasKitchenFilter";
            chkHasKitchenFilter.Size = new Size(66, 19);
            chkHasKitchenFilter.TabIndex = 12;
            chkHasKitchenFilter.Text = "Kitchen";
            chkHasKitchenFilter.UseVisualStyleBackColor = true;
            // 
            // chkHasBalconyFilter
            // 
            chkHasBalconyFilter.AutoSize = true;
            chkHasBalconyFilter.Location = new Point(499, 8);
            chkHasBalconyFilter.Name = "chkHasBalconyFilter";
            chkHasBalconyFilter.Size = new Size(68, 19);
            chkHasBalconyFilter.TabIndex = 11;
            chkHasBalconyFilter.Text = "Balcony";
            chkHasBalconyFilter.UseVisualStyleBackColor = true;
            // 
            // numMinPriceFilter
            // 
            numMinPriceFilter.DecimalPlaces = 2;
            numMinPriceFilter.Location = new Point(53, 63);
            numMinPriceFilter.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numMinPriceFilter.Name = "numMinPriceFilter";
            numMinPriceFilter.Size = new Size(80, 23);
            numMinPriceFilter.TabIndex = 10;
            // 
            // numMaxPriceFilter
            // 
            numMaxPriceFilter.DecimalPlaces = 2;
            numMaxPriceFilter.Location = new Point(156, 63);
            numMaxPriceFilter.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numMaxPriceFilter.Name = "numMaxPriceFilter";
            numMaxPriceFilter.Size = new Size(80, 23);
            numMaxPriceFilter.TabIndex = 9;
            numMaxPriceFilter.Value = new decimal(new int[] { 99999, 0, 0, 0 });
            // 
            // cmbBedTypeFilter
            // 
            cmbBedTypeFilter.FormattingEnabled = true;
            cmbBedTypeFilter.Location = new Point(361, 3);
            cmbBedTypeFilter.Name = "cmbBedTypeFilter";
            cmbBedTypeFilter.Size = new Size(99, 23);
            cmbBedTypeFilter.TabIndex = 8;
            // 
            // numMaxFloorFilter
            // 
            numMaxFloorFilter.Location = new Point(186, 33);
            numMaxFloorFilter.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numMaxFloorFilter.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMaxFloorFilter.Name = "numMaxFloorFilter";
            numMaxFloorFilter.Size = new Size(50, 23);
            numMaxFloorFilter.TabIndex = 5;
            numMaxFloorFilter.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // numMinFloorFilter
            // 
            numMinFloorFilter.Location = new Point(112, 33);
            numMinFloorFilter.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numMinFloorFilter.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMinFloorFilter.Name = "numMinFloorFilter";
            numMinFloorFilter.Size = new Size(50, 23);
            numMinFloorFilter.TabIndex = 4;
            numMinFloorFilter.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbRoomViewFilter
            // 
            cmbRoomViewFilter.FormattingEnabled = true;
            cmbRoomViewFilter.Location = new Point(361, 93);
            cmbRoomViewFilter.Name = "cmbRoomViewFilter";
            cmbRoomViewFilter.Size = new Size(99, 23);
            cmbRoomViewFilter.TabIndex = 3;
            // 
            // cmbRoomStatusFilter
            // 
            cmbRoomStatusFilter.FormattingEnabled = true;
            cmbRoomStatusFilter.Location = new Point(361, 63);
            cmbRoomStatusFilter.Name = "cmbRoomStatusFilter";
            cmbRoomStatusFilter.Size = new Size(99, 23);
            cmbRoomStatusFilter.TabIndex = 2;
            // 
            // cmbRoomTypeFilter
            // 
            cmbRoomTypeFilter.FormattingEnabled = true;
            cmbRoomTypeFilter.Location = new Point(361, 33);
            cmbRoomTypeFilter.Name = "cmbRoomTypeFilter";
            cmbRoomTypeFilter.Size = new Size(99, 23);
            cmbRoomTypeFilter.TabIndex = 1;
            // 
            // txtRoomNumberFilter
            // 
            txtRoomNumberFilter.BackColor = SystemColors.Window;
            txtRoomNumberFilter.BorderStyle = BorderStyle.FixedSingle;
            txtRoomNumberFilter.Location = new Point(176, 3);
            txtRoomNumberFilter.Name = "txtRoomNumberFilter";
            txtRoomNumberFilter.Size = new Size(60, 23);
            txtRoomNumberFilter.TabIndex = 0;
            // 
            // availableRoomsFlowLayoutPanel
            // 
            availableRoomsFlowLayoutPanel.AutoScroll = true;
            availableRoomsFlowLayoutPanel.AutoSize = true;
            availableRoomsFlowLayoutPanel.Dock = DockStyle.Fill;
            availableRoomsFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            availableRoomsFlowLayoutPanel.Location = new Point(3, 158);
            availableRoomsFlowLayoutPanel.Name = "availableRoomsFlowLayoutPanel";
            availableRoomsFlowLayoutPanel.Size = new Size(794, 289);
            availableRoomsFlowLayoutPanel.TabIndex = 1;
            availableRoomsFlowLayoutPanel.WrapContents = false;
            // 
            // RoomSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(roomsLayoutPanel);
            Name = "RoomSelectionForm";
            Text = "RoomSelectionForm";
            roomsLayoutPanel.ResumeLayout(false);
            roomsLayoutPanel.PerformLayout();
            roomsControlPanel.ResumeLayout(false);
            roomsFilterPanel.ResumeLayout(false);
            roomsFilterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMinCapacityFilter).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMaxCapacityFilter).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinPriceFilter).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMaxPriceFilter).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMaxFloorFilter).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinFloorFilter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel roomsLayoutPanel;
        private Panel roomsControlPanel;
        private Button btnRoomFilters;
        private Button btnSelectRoom;
        private Panel roomsFilterPanel;
        private Label label9;
        private Label label2;
        private NumericUpDown numMinCapacityFilter;
        private NumericUpDown numMaxCapacityFilter;
        private Label label1;
        private Label lblRoomView;
        private Label lblRoomType;
        private Label lblBedType;
        private Label lblRoomStatus;
        private Label lblCapacity;
        private Label lblPrice;
        private Label lblFloor;
        private Label lblRoomNumber;
        private Button btnRoomFilterClear;
        private Button btnRoomSearch;
        private CheckBox chkIsPetFriendlyFilter;
        private CheckBox chkIsSmokingAllowedFilter;
        private CheckBox chkHasKitchenFilter;
        private CheckBox chkHasBalconyFilter;
        private NumericUpDown numMinPriceFilter;
        private NumericUpDown numMaxPriceFilter;
        private ComboBox cmbBedTypeFilter;
        private NumericUpDown numMaxFloorFilter;
        private NumericUpDown numMinFloorFilter;
        private ComboBox cmbRoomViewFilter;
        private ComboBox cmbRoomStatusFilter;
        private ComboBox cmbRoomTypeFilter;
        private TextBox txtRoomNumberFilter;
        private FlowLayoutPanel availableRoomsFlowLayoutPanel;
        private Label label3;
        private DateTimePicker dtpCheckOutSelection;
        private DateTimePicker dtpCheckInSelection;
        private Button btnCancel;
    }
}