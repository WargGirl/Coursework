namespace Coursework
{
    partial class MainPage
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
            tabControl = new TabControl();
            tabGuests = new TabPage();
            guestsFilterPanel = new Panel();
            txtSurnameSearch = new TextBox();
            txtGuestRoom = new TextBox();
            btnAddProfile = new Button();
            cmbGuestInHotelStatus = new ComboBox();
            cmbVIP = new ComboBox();
            txtNameSearch = new TextBox();
            btnSearchGuest = new Button();
            guestsFlowLayoutPanel = new FlowLayoutPanel();
            tabRooms = new TabPage();
            roomsLayoutPanel = new TableLayoutPanel();
            roomsControlPanel = new Panel();
            btnRoomFilters = new Button();
            btnAddRoom = new Button();
            roomsFilterPanel = new Panel();
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
            roomsFlowLayoutPanel = new FlowLayoutPanel();
            tabStuff = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            staffFlowLayoutPanel = new FlowLayoutPanel();
            staffFilterPanel = new Panel();
            cmbStaffEmploymentStatusFilter = new ComboBox();
            txtStaffSurnameFilter = new TextBox();
            label4 = new Label();
            lblStaffStatus = new Label();
            lblStaffSalary = new Label();
            label10 = new Label();
            lblStaffProfession = new Label();
            lblStaffSurname = new Label();
            lblStaffName = new Label();
            btnStaffFilterClear = new Button();
            btnStaffSearch = new Button();
            numMinSalaryFilter = new NumericUpDown();
            numMaxSalaryFilter = new NumericUpDown();
            cmbStaffShiftStatusFilter = new ComboBox();
            cmbStaffProfessionFilter = new ComboBox();
            txtStaffNameFilter = new TextBox();
            panel1 = new Panel();
            btnStaffFilters = new Button();
            btnAddStaff = new Button();
            tabControl.SuspendLayout();
            tabGuests.SuspendLayout();
            guestsFilterPanel.SuspendLayout();
            tabRooms.SuspendLayout();
            roomsLayoutPanel.SuspendLayout();
            roomsControlPanel.SuspendLayout();
            roomsFilterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMinCapacityFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaxCapacityFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinPriceFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaxPriceFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaxFloorFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinFloorFilter).BeginInit();
            tabStuff.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            staffFilterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMinSalaryFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaxSalaryFilter).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabGuests);
            tabControl.Controls.Add(tabRooms);
            tabControl.Controls.Add(tabStuff);
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(800, 451);
            tabControl.TabIndex = 0;
            // 
            // tabGuests
            // 
            tabGuests.Controls.Add(guestsFilterPanel);
            tabGuests.Controls.Add(guestsFlowLayoutPanel);
            tabGuests.Location = new Point(4, 24);
            tabGuests.Name = "tabGuests";
            tabGuests.Padding = new Padding(3);
            tabGuests.Size = new Size(792, 423);
            tabGuests.TabIndex = 0;
            tabGuests.Text = "Guests";
            tabGuests.UseVisualStyleBackColor = true;
            // 
            // guestsFilterPanel
            // 
            guestsFilterPanel.Controls.Add(txtSurnameSearch);
            guestsFilterPanel.Controls.Add(txtGuestRoom);
            guestsFilterPanel.Controls.Add(btnAddProfile);
            guestsFilterPanel.Controls.Add(cmbGuestInHotelStatus);
            guestsFilterPanel.Controls.Add(cmbVIP);
            guestsFilterPanel.Controls.Add(txtNameSearch);
            guestsFilterPanel.Controls.Add(btnSearchGuest);
            guestsFilterPanel.Dock = DockStyle.Top;
            guestsFilterPanel.Location = new Point(3, 3);
            guestsFilterPanel.Name = "guestsFilterPanel";
            guestsFilterPanel.Size = new Size(786, 29);
            guestsFilterPanel.TabIndex = 2;
            // 
            // txtSurnameSearch
            // 
            txtSurnameSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSurnameSearch.Location = new Point(148, 3);
            txtSurnameSearch.Name = "txtSurnameSearch";
            txtSurnameSearch.Size = new Size(138, 23);
            txtSurnameSearch.TabIndex = 6;
            // 
            // txtGuestRoom
            // 
            txtGuestRoom.BorderStyle = BorderStyle.FixedSingle;
            txtGuestRoom.Location = new Point(383, 3);
            txtGuestRoom.Name = "txtGuestRoom";
            txtGuestRoom.Size = new Size(90, 23);
            txtGuestRoom.TabIndex = 5;
            // 
            // btnAddProfile
            // 
            btnAddProfile.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnAddProfile.FlatStyle = FlatStyle.Flat;
            btnAddProfile.Location = new Point(687, 3);
            btnAddProfile.Name = "btnAddProfile";
            btnAddProfile.Size = new Size(75, 23);
            btnAddProfile.TabIndex = 4;
            btnAddProfile.Text = "Add";
            btnAddProfile.UseVisualStyleBackColor = true;
            btnAddProfile.Click += btAddProfile_Click;
            // 
            // cmbGuestInHotelStatus
            // 
            cmbGuestInHotelStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGuestInHotelStatus.FormattingEnabled = true;
            cmbGuestInHotelStatus.Items.AddRange(new object[] { "", "In hotel", "Booked", "Not in hotel" });
            cmbGuestInHotelStatus.Location = new Point(479, 3);
            cmbGuestInHotelStatus.Name = "cmbGuestInHotelStatus";
            cmbGuestInHotelStatus.Size = new Size(121, 23);
            cmbGuestInHotelStatus.TabIndex = 3;
            // 
            // cmbVIP
            // 
            cmbVIP.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVIP.FormattingEnabled = true;
            cmbVIP.Items.AddRange(new object[] { "", "VIP", "Non-VIP" });
            cmbVIP.Location = new Point(292, 3);
            cmbVIP.Name = "cmbVIP";
            cmbVIP.Size = new Size(85, 23);
            cmbVIP.TabIndex = 2;
            // 
            // txtNameSearch
            // 
            txtNameSearch.BorderStyle = BorderStyle.FixedSingle;
            txtNameSearch.Location = new Point(3, 3);
            txtNameSearch.Name = "txtNameSearch";
            txtNameSearch.Size = new Size(139, 23);
            txtNameSearch.TabIndex = 0;
            // 
            // btnSearchGuest
            // 
            btnSearchGuest.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnSearchGuest.FlatStyle = FlatStyle.Flat;
            btnSearchGuest.Location = new Point(606, 3);
            btnSearchGuest.Name = "btnSearchGuest";
            btnSearchGuest.Size = new Size(75, 23);
            btnSearchGuest.TabIndex = 1;
            btnSearchGuest.Text = "Search";
            btnSearchGuest.UseVisualStyleBackColor = true;
            btnSearchGuest.Click += btSearch_Click;
            // 
            // guestsFlowLayoutPanel
            // 
            guestsFlowLayoutPanel.AutoScroll = true;
            guestsFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            guestsFlowLayoutPanel.Location = new Point(3, 33);
            guestsFlowLayoutPanel.Name = "guestsFlowLayoutPanel";
            guestsFlowLayoutPanel.Size = new Size(786, 387);
            guestsFlowLayoutPanel.TabIndex = 0;
            guestsFlowLayoutPanel.WrapContents = false;
            // 
            // tabRooms
            // 
            tabRooms.Controls.Add(roomsLayoutPanel);
            tabRooms.Location = new Point(4, 24);
            tabRooms.Name = "tabRooms";
            tabRooms.Padding = new Padding(3);
            tabRooms.Size = new Size(792, 423);
            tabRooms.TabIndex = 1;
            tabRooms.Text = "Rooms";
            tabRooms.UseVisualStyleBackColor = true;
            // 
            // roomsLayoutPanel
            // 
            roomsLayoutPanel.ColumnCount = 1;
            roomsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            roomsLayoutPanel.Controls.Add(roomsControlPanel, 0, 0);
            roomsLayoutPanel.Controls.Add(roomsFilterPanel, 0, 1);
            roomsLayoutPanel.Controls.Add(roomsFlowLayoutPanel, 1, 2);
            roomsLayoutPanel.Dock = DockStyle.Fill;
            roomsLayoutPanel.Location = new Point(3, 3);
            roomsLayoutPanel.Name = "roomsLayoutPanel";
            roomsLayoutPanel.RowCount = 3;
            roomsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            roomsLayoutPanel.RowStyles.Add(new RowStyle());
            roomsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            roomsLayoutPanel.Size = new Size(786, 417);
            roomsLayoutPanel.TabIndex = 0;
            // 
            // roomsControlPanel
            // 
            roomsControlPanel.Controls.Add(btnRoomFilters);
            roomsControlPanel.Controls.Add(btnAddRoom);
            roomsControlPanel.Dock = DockStyle.Fill;
            roomsControlPanel.Location = new Point(3, 3);
            roomsControlPanel.Name = "roomsControlPanel";
            roomsControlPanel.Size = new Size(780, 23);
            roomsControlPanel.TabIndex = 3;
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
            // btnAddRoom
            // 
            btnAddRoom.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnAddRoom.FlatStyle = FlatStyle.Flat;
            btnAddRoom.Location = new Point(684, 0);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(75, 23);
            btnAddRoom.TabIndex = 4;
            btnAddRoom.Text = "Add";
            btnAddRoom.UseVisualStyleBackColor = true;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // roomsFilterPanel
            // 
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
            roomsFilterPanel.Size = new Size(780, 120);
            roomsFilterPanel.TabIndex = 4;
            roomsFilterPanel.Visible = false;
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
            // roomsFlowLayoutPanel
            // 
            roomsFlowLayoutPanel.AutoScroll = true;
            roomsFlowLayoutPanel.AutoSize = true;
            roomsFlowLayoutPanel.Dock = DockStyle.Fill;
            roomsFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            roomsFlowLayoutPanel.Location = new Point(3, 158);
            roomsFlowLayoutPanel.Name = "roomsFlowLayoutPanel";
            roomsFlowLayoutPanel.Size = new Size(780, 256);
            roomsFlowLayoutPanel.TabIndex = 1;
            roomsFlowLayoutPanel.WrapContents = false;
            // 
            // tabStuff
            // 
            tabStuff.Controls.Add(tableLayoutPanel1);
            tabStuff.Location = new Point(4, 24);
            tabStuff.Name = "tabStuff";
            tabStuff.Padding = new Padding(3);
            tabStuff.Size = new Size(792, 423);
            tabStuff.TabIndex = 2;
            tabStuff.Text = "Staff";
            tabStuff.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(staffFlowLayoutPanel, 0, 2);
            tableLayoutPanel1.Controls.Add(staffFilterPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(786, 417);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // staffFlowLayoutPanel
            // 
            staffFlowLayoutPanel.AutoScroll = true;
            staffFlowLayoutPanel.AutoSize = true;
            staffFlowLayoutPanel.Dock = DockStyle.Fill;
            staffFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            staffFlowLayoutPanel.Location = new Point(3, 128);
            staffFlowLayoutPanel.Name = "staffFlowLayoutPanel";
            staffFlowLayoutPanel.Size = new Size(780, 286);
            staffFlowLayoutPanel.TabIndex = 6;
            staffFlowLayoutPanel.WrapContents = false;
            // 
            // staffFilterPanel
            // 
            staffFilterPanel.Controls.Add(cmbStaffEmploymentStatusFilter);
            staffFilterPanel.Controls.Add(txtStaffSurnameFilter);
            staffFilterPanel.Controls.Add(label4);
            staffFilterPanel.Controls.Add(lblStaffStatus);
            staffFilterPanel.Controls.Add(lblStaffSalary);
            staffFilterPanel.Controls.Add(label10);
            staffFilterPanel.Controls.Add(lblStaffProfession);
            staffFilterPanel.Controls.Add(lblStaffSurname);
            staffFilterPanel.Controls.Add(lblStaffName);
            staffFilterPanel.Controls.Add(btnStaffFilterClear);
            staffFilterPanel.Controls.Add(btnStaffSearch);
            staffFilterPanel.Controls.Add(numMinSalaryFilter);
            staffFilterPanel.Controls.Add(numMaxSalaryFilter);
            staffFilterPanel.Controls.Add(cmbStaffShiftStatusFilter);
            staffFilterPanel.Controls.Add(cmbStaffProfessionFilter);
            staffFilterPanel.Controls.Add(txtStaffNameFilter);
            staffFilterPanel.Dock = DockStyle.Fill;
            staffFilterPanel.Location = new Point(3, 32);
            staffFilterPanel.Name = "staffFilterPanel";
            staffFilterPanel.Size = new Size(780, 90);
            staffFilterPanel.TabIndex = 5;
            staffFilterPanel.Visible = false;
            // 
            // cmbStaffEmploymentStatusFilter
            // 
            cmbStaffEmploymentStatusFilter.FormattingEnabled = true;
            cmbStaffEmploymentStatusFilter.Location = new Point(337, 33);
            cmbStaffEmploymentStatusFilter.Name = "cmbStaffEmploymentStatusFilter";
            cmbStaffEmploymentStatusFilter.Size = new Size(183, 23);
            cmbStaffEmploymentStatusFilter.TabIndex = 28;
            // 
            // txtStaffSurnameFilter
            // 
            txtStaffSurnameFilter.BackColor = SystemColors.Window;
            txtStaffSurnameFilter.BorderStyle = BorderStyle.FixedSingle;
            txtStaffSurnameFilter.Location = new Point(87, 33);
            txtStaffSurnameFilter.Name = "txtStaffSurnameFilter";
            txtStaffSurnameFilter.Size = new Size(163, 23);
            txtStaffSurnameFilter.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 8);
            label4.Name = "label4";
            label4.Size = new Size(12, 15);
            label4.TabIndex = 25;
            label4.Text = "-";
            // 
            // lblStaffStatus
            // 
            lblStaffStatus.AutoSize = true;
            lblStaffStatus.Location = new Point(275, 37);
            lblStaffStatus.Name = "lblStaffStatus";
            lblStaffStatus.Size = new Size(42, 15);
            lblStaffStatus.TabIndex = 22;
            lblStaffStatus.Text = "Status:";
            // 
            // lblStaffSalary
            // 
            lblStaffSalary.AutoSize = true;
            lblStaffSalary.Location = new Point(275, 7);
            lblStaffSalary.Name = "lblStaffSalary";
            lblStaffSalary.Size = new Size(41, 15);
            lblStaffSalary.TabIndex = 21;
            lblStaffSalary.Text = "Salary:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(275, 67);
            label10.Name = "label10";
            label10.Size = new Size(34, 15);
            label10.TabIndex = 20;
            label10.Text = "Shift:";
            // 
            // lblStaffProfession
            // 
            lblStaffProfession.AutoSize = true;
            lblStaffProfession.Location = new Point(13, 67);
            lblStaffProfession.Name = "lblStaffProfession";
            lblStaffProfession.Size = new Size(65, 15);
            lblStaffProfession.TabIndex = 18;
            lblStaffProfession.Text = "Profession:";
            // 
            // lblStaffSurname
            // 
            lblStaffSurname.AutoSize = true;
            lblStaffSurname.Location = new Point(13, 37);
            lblStaffSurname.Name = "lblStaffSurname";
            lblStaffSurname.Size = new Size(57, 15);
            lblStaffSurname.TabIndex = 17;
            lblStaffSurname.Text = "Surname:";
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Location = new Point(12, 7);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(42, 15);
            lblStaffName.TabIndex = 16;
            lblStaffName.Text = "Name:";
            // 
            // btnStaffFilterClear
            // 
            btnStaffFilterClear.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnStaffFilterClear.FlatStyle = FlatStyle.Flat;
            btnStaffFilterClear.Location = new Point(603, 62);
            btnStaffFilterClear.Name = "btnStaffFilterClear";
            btnStaffFilterClear.Size = new Size(75, 23);
            btnStaffFilterClear.TabIndex = 15;
            btnStaffFilterClear.Text = "Clear";
            btnStaffFilterClear.UseVisualStyleBackColor = true;
            btnStaffFilterClear.Click += btnStaffFilterClear_Click;
            // 
            // btnStaffSearch
            // 
            btnStaffSearch.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnStaffSearch.FlatStyle = FlatStyle.Flat;
            btnStaffSearch.Location = new Point(684, 62);
            btnStaffSearch.Name = "btnStaffSearch";
            btnStaffSearch.Size = new Size(75, 23);
            btnStaffSearch.TabIndex = 6;
            btnStaffSearch.Text = "Search";
            btnStaffSearch.UseVisualStyleBackColor = true;
            btnStaffSearch.Click += btnStaffSearch_Click;
            // 
            // numMinSalaryFilter
            // 
            numMinSalaryFilter.DecimalPlaces = 2;
            numMinSalaryFilter.Location = new Point(337, 5);
            numMinSalaryFilter.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numMinSalaryFilter.Name = "numMinSalaryFilter";
            numMinSalaryFilter.Size = new Size(80, 23);
            numMinSalaryFilter.TabIndex = 10;
            // 
            // numMaxSalaryFilter
            // 
            numMaxSalaryFilter.DecimalPlaces = 2;
            numMaxSalaryFilter.Location = new Point(440, 5);
            numMaxSalaryFilter.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numMaxSalaryFilter.Name = "numMaxSalaryFilter";
            numMaxSalaryFilter.Size = new Size(80, 23);
            numMaxSalaryFilter.TabIndex = 9;
            numMaxSalaryFilter.Value = new decimal(new int[] { 99999, 0, 0, 0 });
            // 
            // cmbStaffShiftStatusFilter
            // 
            cmbStaffShiftStatusFilter.DisplayMember = "0";
            cmbStaffShiftStatusFilter.FormattingEnabled = true;
            cmbStaffShiftStatusFilter.Items.AddRange(new object[] { "All Statuses", "Working", "Not Working" });
            cmbStaffShiftStatusFilter.Location = new Point(337, 62);
            cmbStaffShiftStatusFilter.Name = "cmbStaffShiftStatusFilter";
            cmbStaffShiftStatusFilter.Size = new Size(183, 23);
            cmbStaffShiftStatusFilter.TabIndex = 2;
            // 
            // cmbStaffProfessionFilter
            // 
            cmbStaffProfessionFilter.FormattingEnabled = true;
            cmbStaffProfessionFilter.Location = new Point(87, 62);
            cmbStaffProfessionFilter.Name = "cmbStaffProfessionFilter";
            cmbStaffProfessionFilter.Size = new Size(163, 23);
            cmbStaffProfessionFilter.TabIndex = 1;
            // 
            // txtStaffNameFilter
            // 
            txtStaffNameFilter.BackColor = SystemColors.Window;
            txtStaffNameFilter.BorderStyle = BorderStyle.FixedSingle;
            txtStaffNameFilter.Location = new Point(87, 3);
            txtStaffNameFilter.Name = "txtStaffNameFilter";
            txtStaffNameFilter.Size = new Size(163, 23);
            txtStaffNameFilter.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnStaffFilters);
            panel1.Controls.Add(btnAddStaff);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 23);
            panel1.TabIndex = 4;
            // 
            // btnStaffFilters
            // 
            btnStaffFilters.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnStaffFilters.FlatStyle = FlatStyle.Flat;
            btnStaffFilters.Location = new Point(3, 0);
            btnStaffFilters.Name = "btnStaffFilters";
            btnStaffFilters.Size = new Size(96, 23);
            btnStaffFilters.TabIndex = 5;
            btnStaffFilters.Text = "Show filters";
            btnStaffFilters.UseVisualStyleBackColor = true;
            btnStaffFilters.Click += btnStaffFilters_Click;
            // 
            // btnAddStaff
            // 
            btnAddStaff.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnAddStaff.FlatStyle = FlatStyle.Flat;
            btnAddStaff.Location = new Point(684, 0);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.Size = new Size(75, 23);
            btnAddStaff.TabIndex = 4;
            btnAddStaff.Text = "Add";
            btnAddStaff.UseVisualStyleBackColor = true;
            btnAddStaff.Click += btnAddStaff_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Name = "MainPage";
            Text = "MainPage";
            tabControl.ResumeLayout(false);
            tabGuests.ResumeLayout(false);
            guestsFilterPanel.ResumeLayout(false);
            guestsFilterPanel.PerformLayout();
            tabRooms.ResumeLayout(false);
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
            tabStuff.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            staffFilterPanel.ResumeLayout(false);
            staffFilterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMinSalaryFilter).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMaxSalaryFilter).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabGuests;
        private TabPage tabRooms;
        private TabPage tabStuff;
        private FlowLayoutPanel guestsFlowLayoutPanel;
        private Panel guestsFilterPanel;
        private TextBox txtNameSearch;
        private Button btnSearchGuest;
        private ComboBox cmbGuestInHotelStatus;
        private ComboBox cmbVIP;
        private Button btnAddProfile;
        private TextBox txtGuestRoom;
        private TextBox txtSurnameSearch;
        private FlowLayoutPanel roomsFlowLayoutPanel;
        private Panel roomsControlPanel;
        private Button btnAddRoom;
        private TableLayoutPanel roomsLayoutPanel;
        private Panel roomsFilterPanel;
        private Button btnRoomFilters;
        private TextBox txtRoomNumberFilter;
        private NumericUpDown numMinPriceFilter;
        private NumericUpDown numMaxPriceFilter;
        private ComboBox cmbBedTypeFilter;
        private NumericUpDown numMaxCapacityFilter;
        private NumericUpDown numMinCapacityFilter;
        private NumericUpDown numMaxFloorFilter;
        private NumericUpDown numMinFloorFilter;
        private ComboBox cmbRoomViewFilter;
        private ComboBox cmbRoomStatusFilter;
        private ComboBox cmbRoomTypeFilter;
        private Button btnRoomFilterClear;
        private Button btnRoomSearch;
        private CheckBox chkIsPetFriendlyFilter;
        private CheckBox chkIsSmokingAllowedFilter;
        private CheckBox chkHasKitchenFilter;
        private CheckBox chkHasBalconyFilter;
        private Label lblRoomView;
        private Label lblRoomType;
        private Label lblBedType;
        private Label lblRoomStatus;
        private Label lblCapacity;
        private Label lblPrice;
        private Label lblFloor;
        private Label lblRoomNumber;
        private Label label9;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel staffFlowLayoutPanel;
        private Panel staffFilterPanel;
        private Label label4;
        private Label label5;
        private Label lblStaffStatus;
        private Label lblStaffSalary;
        private Label label10;
        private Label lblStaffProfession;
        private Label lblStaffSurname;
        private Label lblStaffName;
        private Button btnStaffFilterClear;
        private Button btnStaffSearch;
        private NumericUpDown numMinSalaryFilter;
        private NumericUpDown numMaxSalaryFilter;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown6;
        private ComboBox cmbStaffShiftStatusFilter;
        private ComboBox cmbStaffProfessionFilter;
        private TextBox txtStaffNameFilter;
        private Panel panel1;
        private Button btnStaffFilters;
        private Button btnAddStaff;
        private TextBox txtStaffSurnameFilter;
        private ComboBox cmbStaffEmploymentStatusFilter;
    }
}