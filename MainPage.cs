using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Coursework.Enums;
using static Coursework.RoomCard;

namespace Coursework
{
    public partial class MainPage : Form
    {
        private List<Guest> guests = new List<Guest>();
        private List<Room> rooms = new List<Room>();
        private List<Staff> staff = new List<Staff>();

        private string guestsFilePath;
        private string roomsFilePath;
        private string staffFilePath;

        public MainPage()
        {
            InitializeComponent();
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appSpecificFolder = Path.Combine(appDataFolder, "CourseworkHotelApp");
            Directory.CreateDirectory(appSpecificFolder);
            roomsFilePath = Path.Combine(appSpecificFolder, "rooms.json");
            guestsFilePath = Path.Combine(appSpecificFolder, "guests.json"); 
            staffFilePath = Path.Combine(appSpecificFolder, "staff.json");

            PopulateFilterComboBox<GuestStatus>(cmbGuestInHotelStatus, "All Statuses");

            PopulateFilterComboBox<RoomType>(cmbRoomTypeFilter, "All Types");
            PopulateFilterComboBox<RoomStatus>(cmbRoomStatusFilter, "All Statuses");
            PopulateFilterComboBox<BedType>(cmbBedTypeFilter, "All Bed Types");
            PopulateFilterComboBox<RoomView>(cmbRoomViewFilter, "All Views");

            PopulateFilterComboBox<StaffProfession>(cmbStaffProfessionFilter, "All Professions");
            PopulateFilterComboBox<StaffEmploymentStatus>(cmbStaffEmploymentStatusFilter, "All Statuses");
            cmbStaffShiftStatusFilter.SelectedIndex = 0;

            LoadData();
            SearchGuests();
            SearchRooms();
            SearchStaff();
            this.FormClosing += MainPage_FormClosing;
        }

        private void SaveData()
        {
            SynchronizeGuestRoomAssignments();
            SaveGuests();
            SaveRooms();
            SaveStaff();
        }
        private void LoadData()
        {
            LoadGuests();
            LoadRooms();
            LoadStaff();
            SynchronizeGuestRoomAssignments();
        }

        private void SaveGuests()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(guests, options);
                File.WriteAllText(guestsFilePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving guest data: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadGuests()
        {
            if (File.Exists(guestsFilePath))
            {
                try
                {
                    string jsonString = File.ReadAllText(guestsFilePath);
                    List<Guest> loadedGuests = JsonSerializer.Deserialize<List<Guest>>(jsonString);
                    if (loadedGuests != null)
                    {
                        guests = loadedGuests;
                    }
                }
                catch (JsonException ex)
                {
                    MessageBox.Show($"Error reading data (invalid JSON format): {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    guests = new List<Guest>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"General error loading guest data: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    guests = new List<Guest>();
                }
            }
            else
            {
                guests = new List<Guest>();
            }
        }

        private void SaveRooms()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(rooms, options);
                File.WriteAllText(roomsFilePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving room data: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadRooms()
        {
            if (File.Exists(roomsFilePath))
            {
                try
                {
                    string jsonString = File.ReadAllText(roomsFilePath);
                    List<Room> loadedRooms = JsonSerializer.Deserialize<List<Room>>(jsonString);
                    if (loadedRooms != null) { rooms = loadedRooms; }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading room data: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rooms = new List<Room>();
                }
            }
            else
            {
                rooms = new List<Room>();
            }
        }

        private void SaveStaff()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(staff, options);
                File.WriteAllText(staffFilePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving staff data: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadStaff()
        {
            if (File.Exists(staffFilePath))
            {
                try
                {
                    string jsonString = File.ReadAllText(staffFilePath);
                    List<Staff> loadedStaff = JsonSerializer.Deserialize<List<Staff>>(jsonString);
                    if (loadedStaff != null) { staff = loadedStaff; }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading staff data: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    staff = new List<Staff>();
                }
            }
            else
            {
                staff = new List<Staff>();
                Console.WriteLine("Staff data file not found. Starting with an empty staff list.");
            }
        }

        private void SynchronizeGuestRoomAssignments()
        {
            foreach (var room in rooms)
            {
                room.OccupantGuestIds.Clear();
                if (room.Status != RoomStatus.Maintenance && room.Status != RoomStatus.Cleaning)
                {
                    room.Status = RoomStatus.Available;
                }
            }

            foreach (var guest in guests)
            {
                if (!string.IsNullOrWhiteSpace(guest.RoomNumber))
                {
                    Room assignedRoom = rooms.FirstOrDefault(r => r.Number == guest.RoomNumber);
                    if (assignedRoom != null)
                    {
                        if (guest.InHotelStatus == GuestStatus.InHotel || guest.InHotelStatus == GuestStatus.InHotelCheckOutDay)
                        {
                            if (!assignedRoom.OccupantGuestIds.Contains(guest.GuestId))
                            {
                                assignedRoom.OccupantGuestIds.Add(guest.GuestId);
                            }
                            assignedRoom.Status = RoomStatus.Occupied;
                        }
                        else if (guest.InHotelStatus == GuestStatus.Booked || guest.InHotelStatus == GuestStatus.BookedCheckIn)
                        {
                        }
                        else 
                        {
                            if (assignedRoom.OccupantGuestIds.Contains(guest.GuestId))
                            {
                                assignedRoom.OccupantGuestIds.Remove(guest.GuestId);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Guest {guest.Name} {guest.Surname} is assigned to non-existent room {guest.RoomNumber}. Resetting room assignment.");
                        guest.RoomNumber = null;
                    }
                }
            }
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            SynchronizeGuestRoomAssignments();
            SaveData();
        }

        public void SearchGuests()
        {
            string name = txtNameSearch.Text.ToLower();
            string surname = txtSurnameSearch.Text.ToLower();
            string room = txtGuestRoom.Text.ToLower();
            string vipStatus = cmbVIP.SelectedItem?.ToString();
            bool? isVip = null;
            if (vipStatus == "VIP")
                isVip = true;
            else if (vipStatus == "Non-VIP")
                isVip = false;
            GuestStatus? inHotelStatus = null;
            if (cmbGuestInHotelStatus.SelectedItem?.ToString() != "All Statuses")
            {
                inHotelStatus = (GuestStatus)Enum.Parse(typeof(GuestStatus), cmbGuestInHotelStatus.SelectedItem.ToString());
            }
            guestsFlowLayoutPanel.Controls.Clear();
            guestsFlowLayoutPanel.SuspendLayout();
            var loadedCards = new List<ProfileCard>();

            foreach (var guest in guests)
            {
                if (!string.IsNullOrWhiteSpace(name) && !guest.Name.ToLower().Contains(name))
                    continue;

                if (!string.IsNullOrWhiteSpace(surname) && !guest.Surname.ToLower().Contains(surname))
                    continue;

                if (!string.IsNullOrWhiteSpace(room) && !guest.RoomNumber.ToLower().Contains(room))
                    continue;

                if (!string.IsNullOrWhiteSpace(vipStatus) && guest.IsVIP != isVip)
                    continue;

                if (inHotelStatus.HasValue && guest.InHotelStatus != inHotelStatus.Value)
                    continue;

                var card = new ProfileCard(guest);
                loadedCards.Add(card);
            }
            foreach (var card in loadedCards)
            {
                guestsFlowLayoutPanel.Controls.Add(card);
                card.ProfileCardDoubleClicked += ProfileCard_ProfileCardDoubleClicked;
            }
            guestsFlowLayoutPanel.ResumeLayout();
        }
        public void SearchRooms()
        {
            SynchronizeGuestRoomAssignments();

            roomsFlowLayoutPanel.Controls.Clear();
            roomsFlowLayoutPanel.SuspendLayout();

            string roomNumberFilter = txtRoomNumberFilter.Text.ToLower();

            RoomType? selectedType = null;
            if (cmbRoomTypeFilter.SelectedItem?.ToString() != "All Types")
            {
                selectedType = (RoomType)Enum.Parse(typeof(RoomType), cmbRoomTypeFilter.SelectedItem.ToString());
            }

            RoomStatus? selectedStatus = null;
            if (cmbRoomStatusFilter.SelectedItem?.ToString() != "All Statuses")
            {
                selectedStatus = (RoomStatus)Enum.Parse(typeof(RoomStatus), cmbRoomStatusFilter.SelectedItem.ToString());
            }

            BedType? selectedBedType = null;
            if (cmbBedTypeFilter.SelectedItem?.ToString() != "All Bed Types")
            {
                selectedBedType = (BedType)Enum.Parse(typeof(BedType), cmbBedTypeFilter.SelectedItem.ToString());
            }

            RoomView? selectedRoomView = null;
            if (cmbRoomViewFilter.SelectedItem?.ToString() != "All Views")
            {
                selectedRoomView = (RoomView)Enum.Parse(typeof(RoomView), cmbRoomViewFilter.SelectedItem.ToString());
            }

            decimal minPrice = numMinPriceFilter.Value;
            decimal maxPrice = numMaxPriceFilter.Value;
            int minCapacity = (int)numMinCapacityFilter.Value;
            int maxCapacity = (int)numMaxCapacityFilter.Value;

            bool filterHasBalcony = chkHasBalconyFilter.Checked;
            bool filterHasKitchenette = chkHasKitchenFilter.Checked;
            bool filterIsSmokingAllowed = chkIsSmokingAllowedFilter.Checked;
            bool filterIsPetFriendly = chkIsPetFriendlyFilter.Checked;

            foreach (var room in rooms)
            {
                if (!string.IsNullOrWhiteSpace(roomNumberFilter) && !room.Number.ToLower().Contains(roomNumberFilter))
                    continue;

                if (selectedType.HasValue && room.Type != selectedType.Value)
                    continue;

                if (selectedStatus.HasValue && room.Status != selectedStatus.Value)
                    continue;

                if (selectedBedType.HasValue && !room.BedConfigurations.Any(bc => bc.Type == selectedBedType.Value))
                    continue;

                if (room.Price < minPrice || room.Price > maxPrice)
                    continue;

                if (room.CalculatedCapacity < minCapacity || room.CalculatedCapacity > maxCapacity)
                    continue;

                if (filterHasBalcony && !room.HasBalcony) continue;
                if (filterHasKitchenette && !room.HasKitchen) continue;
                if (filterIsSmokingAllowed && !room.IsSmokingAllowed) continue;
                if (filterIsPetFriendly && !room.IsPetFriendly) continue;

                if (selectedRoomView.HasValue && room.View != selectedRoomView.Value)
                    continue;

                var card = new RoomCard(room);
                card.RoomCardDoubleClicked += RoomCard_RoomCardDoubleClicked;
                roomsFlowLayoutPanel.Controls.Add(card);
            }

            roomsFlowLayoutPanel.ResumeLayout();
        }
        public void SearchStaff()
        {
            staffFlowLayoutPanel.Controls.Clear();
            staffFlowLayoutPanel.SuspendLayout();

            string nameFilter = txtStaffNameFilter.Text.ToLower();
            string surnameFilter = txtStaffSurnameFilter.Text.ToLower();

            StaffProfession? selectedProfession = cmbStaffProfessionFilter.SelectedItem?.ToString() == "All Professions" ? (StaffProfession?)null : (StaffProfession)Enum.Parse(typeof(StaffProfession), cmbStaffProfessionFilter.SelectedItem.ToString());
            StaffEmploymentStatus? selectedEmploymentStatus = cmbStaffEmploymentStatusFilter.SelectedItem?.ToString() == "All Statuses" ? (StaffEmploymentStatus?)null : (StaffEmploymentStatus)Enum.Parse(typeof(StaffEmploymentStatus), cmbStaffEmploymentStatusFilter.SelectedItem.ToString());

            string currentShiftStatusSelection = cmbStaffShiftStatusFilter.SelectedItem?.ToString();
            bool? filterByIsCurrentlyWorking = null;
            if (currentShiftStatusSelection == "Working")
            {
                filterByIsCurrentlyWorking = true;
            }
            else if (currentShiftStatusSelection == "Not Working")
            {
                filterByIsCurrentlyWorking = false;
            }
            decimal minSalary = numMinSalaryFilter.Value;
            decimal maxSalary = numMaxSalaryFilter.Value;

            foreach (var staffMember in staff)
            {
                if (!string.IsNullOrWhiteSpace(nameFilter) && !staffMember.Name.ToLower().Contains(nameFilter)) continue;
                if (!string.IsNullOrWhiteSpace(surnameFilter) && !staffMember.Surname.ToLower().Contains(surnameFilter)) continue;
                if (selectedProfession.HasValue && staffMember.Profession != selectedProfession.Value) continue;
                if (selectedEmploymentStatus.HasValue && staffMember.EmploymentStatus != selectedEmploymentStatus.Value) continue;
                if (filterByIsCurrentlyWorking.HasValue && staffMember.IsCurrentlyWorking != filterByIsCurrentlyWorking.Value) continue;
                if (staffMember.Salary < minSalary || staffMember.Salary > maxSalary) continue;

                var card = new StaffCard(staffMember);
                card.StaffCardDoubleClicked += StaffCard_StaffCardDoubleClicked;
                staffFlowLayoutPanel.Controls.Add(card);
            }

            staffFlowLayoutPanel.ResumeLayout();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            SearchGuests();
        }
        private void btAddProfile_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddGuestProfile())
            {
                var result = addForm.ShowDialog();

                if (result == DialogResult.OK && addForm.CreatedGuest != null)
                {
                    Guest guest = addForm.CreatedGuest;
                    guests.Add(guest);
                    var card = new ProfileCard(guest);
                    guestsFlowLayoutPanel.Controls.Add(card);
                    SearchGuests();
                }
            }
        }
        public void DeleteGuest(Guest guestToDelete)
        {
            guests.Remove(guestToDelete);
        }
        private void ProfileCard_ProfileCardDoubleClicked(object sender, ProfileCard.GuestEventArgs e)
        {
            Guest clickedGuest = e.Guest;
            try
            {
                GuestProfile detailsForm = new GuestProfile(clickedGuest, this);

                detailsForm.Owner = this;

                detailsForm.FormClosed += (s, args) =>
                {
                    (s as Form)?.Dispose();
                };

                detailsForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening guest profile: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Guest GetGuestById(string guestId)
        {
            return guests.FirstOrDefault(g => g.GuestId == guestId);
        }
        public List<Guest> GetAllGuests()
        {
            return guests;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            using (var addRoomForm = new AddRoomProfile())
            {
                var result = addRoomForm.ShowDialog();
                if (result == DialogResult.OK && addRoomForm.CreatedRoom != null)
                {
                    Room room = addRoomForm.CreatedRoom;
                    rooms.Add(room);
                    var card = new RoomCard(room);
                    roomsFlowLayoutPanel.Controls.Add(card);
                    SearchRooms();
                }
            }
        }
        private void btnRoomFilters_Click(object sender, EventArgs e)
        {
            roomsFilterPanel.Visible = !roomsFilterPanel.Visible;
            if (roomsFilterPanel.Visible)
            {
                btnRoomFilters.Text = "Hide Filters";
            }
            else
            {
                btnRoomFilters.Text = "Show Filters";
            }
        }
        private void btnRoomSearch_Click(object sender, EventArgs e)
        {
            SearchRooms();
        }
        private void btnRoomFilterClear_Click(object sender, EventArgs e)
        {
            cmbRoomTypeFilter.SelectedIndex = 0;
            cmbRoomStatusFilter.SelectedIndex = 0;
            cmbBedTypeFilter.SelectedIndex = 0;
            cmbRoomViewFilter.SelectedIndex = 0;

            numMinPriceFilter.Value = numMinPriceFilter.Minimum;
            numMaxPriceFilter.Value = numMaxPriceFilter.Maximum;
            numMinCapacityFilter.Value = numMinCapacityFilter.Minimum;
            numMaxCapacityFilter.Value = numMaxCapacityFilter.Maximum;
            numMinFloorFilter.Value = numMinFloorFilter.Minimum;
            numMaxFloorFilter.Value = numMaxFloorFilter.Maximum;

            chkHasBalconyFilter.Checked = false;
            chkHasKitchenFilter.Checked = false;
            chkIsSmokingAllowedFilter.Checked = false;
            chkIsPetFriendlyFilter.Checked = false;
        }
        private void RoomCard_RoomCardDoubleClicked(object sender, RoomCard.RoomEventArgs e)
        {
            Room clickedRoom = e.Room;
            try
            {
                RoomProfile detailsForm = new RoomProfile(clickedRoom, this);
                detailsForm.Owner = this;

                detailsForm.FormClosed += (s, args) =>
                {
                    (s as Form)?.Dispose();
                };

                detailsForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening room profile: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteRoom(Room roomToDelete)
        {
            rooms.Remove(roomToDelete);
        }
        public List<Room> GetAllRooms()
        {
            return rooms;
        }
        public Room GetRoomById(string roomId)
        {
            return rooms.FirstOrDefault(r => r.RoomId == roomId);
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            using (var addStaffForm = new AddStaffProfile())
            {
                var result = addStaffForm.ShowDialog();
                if (result == DialogResult.OK && addStaffForm.CreatedStaff != null)
                {
                    Staff newStaff = addStaffForm.CreatedStaff;
                    staff.Add(newStaff);
                    SearchStaff();
                }
            }
        }
        public void DeleteStaff(Staff staffToDelete)
        {
            staff.Remove(staffToDelete);
            SearchStaff();
        }
        public Staff GetStaffById(string staffId)
        {
            return staff.FirstOrDefault(s => s.StaffId == staffId);
        }
        private void StaffCard_StaffCardDoubleClicked(object sender, StaffCard.StaffEventArgs e)
        {
            Staff clickedStaff = e.Staff;
            try
            {
                StaffProfile detailsForm = new StaffProfile(clickedStaff, this);
                detailsForm.Owner = this;
                detailsForm.FormClosed += (s, args) => { (s as Form)?.Dispose(); };
                detailsForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening staff profile: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnStaffFilters_Click(object sender, EventArgs e)
        {
            staffFilterPanel.Visible = !staffFilterPanel.Visible;
            btnStaffFilters.Text = staffFilterPanel.Visible ? "Hide Filters" : "Show Filters";
        }
        private void btnStaffFilterClear_Click(object sender, EventArgs e)
        {
            txtStaffNameFilter.Clear();
            txtStaffSurnameFilter.Clear();

            cmbStaffProfessionFilter.SelectedIndex = 0;
            cmbStaffEmploymentStatusFilter.SelectedIndex = 0;
            cmbStaffShiftStatusFilter.SelectedIndex = 0;

            numMinSalaryFilter.Value = numMinSalaryFilter.Minimum;
            numMaxSalaryFilter.Value = numMaxSalaryFilter.Maximum;
            SearchStaff();
        }
        private void btnStaffSearch_Click(object sender, EventArgs e)
        {
            SearchStaff();
        }
    }
}
