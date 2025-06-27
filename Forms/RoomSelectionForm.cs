using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coursework.Models;
using static Coursework.Utils.Enums;

namespace Coursework
{
    public partial class RoomSelectionForm : Form
    {
        private MainPage mainPageInstance;
        private List<Room> allRooms;
        private List<Guest> allGuests;
        public DateTime SelectedCheckInDate { get; private set; }
        public DateTime SelectedCheckOutDate { get; private set; }

        public Room SelectedRoom { get; private set; }

        public RoomSelectionForm(MainPage mainPage)
        {
            InitializeComponent();
            mainPageInstance = mainPage;
            allRooms = mainPageInstance.GetAllRooms();
            allGuests = mainPageInstance.GetAllGuests();

            dtpCheckOutSelection.Value = DateTime.Today.AddDays(1);

            PopulateFilterComboBox<RoomType>(cmbRoomTypeFilter, "Any Type");
            PopulateFilterComboBox<BedType>(cmbBedTypeFilter, "Any Bed Type");
            PopulateFilterComboBox<RoomView>(cmbRoomViewFilter, "Any View");
            PopulateFilterComboBox<RoomStatus>(cmbRoomStatusFilter, "Any Status");

            DisplayAvailableRooms();
        }
        private bool DoDateRangesOverlap(DateTime start1, DateTime end1, DateTime start2, DateTime end2)
        {
            return start1.Date < end2.Date && start2.Date < end1.Date;
        }

        private void DisplayAvailableRooms()
        {
            availableRoomsFlowLayoutPanel.Controls.Clear();
            availableRoomsFlowLayoutPanel.SuspendLayout();

            SelectedCheckInDate = dtpCheckInSelection.Value.Date;
            SelectedCheckOutDate = dtpCheckOutSelection.Value.Date;

            if (SelectedCheckInDate < DateTime.Today.Date)
            {
                MessageBox.Show("Check-in date cannot be in the past.", "Wrong Check-in Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpCheckInSelection.Value = DateTime.Today;
                availableRoomsFlowLayoutPanel.ResumeLayout();
                return;
            }
            if (SelectedCheckOutDate <= SelectedCheckInDate)
            {
                MessageBox.Show("Check-out date must be after check-in date.", "Wrong Check-out Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpCheckOutSelection.Value = dtpCheckInSelection.Value.Date.AddDays(1);
                availableRoomsFlowLayoutPanel.ResumeLayout();
                return;
            }

            IEnumerable<Room> roomsAfterDateConflictCheck = allRooms.Where(room => {
                if (room.Status == RoomStatus.Maintenance) return false;

                bool hasConflict = allGuests.Any(existingGuest =>
                    !string.IsNullOrWhiteSpace(existingGuest.RoomNumber) && 
                    existingGuest.RoomNumber == room.Number &&            
                    (existingGuest.InHotelStatus == GuestStatus.InHotel ||
                     existingGuest.InHotelStatus == GuestStatus.Booked ||
                     existingGuest.InHotelStatus == GuestStatus.BookedCheckIn ||
                     existingGuest.InHotelStatus == GuestStatus.InHotelCheckOutDay) &&
                    DoDateRangesOverlap(SelectedCheckInDate, SelectedCheckOutDate, existingGuest.CheckInDate, existingGuest.CheckOutDate)
                );

                return !hasConflict;
            });


            RoomType? selectedRoomType = cmbRoomTypeFilter.SelectedItem?.ToString() == "Any Type" ? (RoomType?)null : (RoomType)Enum.Parse(typeof(RoomType), cmbRoomTypeFilter.SelectedItem.ToString());
            RoomStatus? selectedStatus = cmbRoomStatusFilter.SelectedItem?.ToString() == "Any Status" ? (RoomStatus?)null : (RoomStatus)Enum.Parse(typeof(RoomStatus), cmbRoomStatusFilter.SelectedItem.ToString());
            BedType? selectedBedType = cmbBedTypeFilter.SelectedItem?.ToString() == "Any Bed Type" ? (BedType?)null : (BedType)Enum.Parse(typeof(BedType), cmbBedTypeFilter.SelectedItem.ToString());
            RoomView? selectedRoomView = cmbRoomViewFilter.SelectedItem?.ToString() == "Any View" ? (RoomView?)null : (RoomView)Enum.Parse(typeof(RoomView), cmbRoomViewFilter.SelectedItem.ToString());

            int minCapacity = (int)numMinCapacityFilter.Value;
            int maxCapacity = (int)numMaxCapacityFilter.Value;
            decimal minPrice = numMinPriceFilter.Value;
            decimal maxPrice = numMaxPriceFilter.Value;

            string roomNumberFilter = txtRoomNumberFilter.Text.ToLower();

            bool filterHasBalcony = chkHasBalconyFilter.Checked;
            bool filterHasKitchenette = chkHasKitchenFilter.Checked;
            bool filterIsSmokingAllowed = chkIsSmokingAllowedFilter.Checked;
            bool filterIsPetFriendly = chkIsPetFriendlyFilter.Checked;


            IEnumerable<Room> finalFilteredRooms = roomsAfterDateConflictCheck;

            if (!string.IsNullOrWhiteSpace(roomNumberFilter))
            {
                finalFilteredRooms = finalFilteredRooms.Where(r => r.Number.ToLower().Contains(roomNumberFilter));
            }
            if (selectedRoomType.HasValue)
            {
                finalFilteredRooms = finalFilteredRooms.Where(r => r.Type == selectedRoomType.Value);
            }
            if (selectedStatus.HasValue)
            {
                finalFilteredRooms = finalFilteredRooms.Where(r => r.Status == selectedStatus.Value);
            }
            if (selectedBedType.HasValue)
            {
                finalFilteredRooms = finalFilteredRooms.Where(r => r.BedConfigurations.Any(bc => bc.Type == selectedBedType.Value));
            }
            if (selectedRoomView.HasValue)
            {
                finalFilteredRooms = finalFilteredRooms.Where(r => r.View == selectedRoomView.Value);
            }

            finalFilteredRooms = finalFilteredRooms.Where(r => r.Price >= minPrice && r.Price <= maxPrice);
            finalFilteredRooms = finalFilteredRooms.Where(r => r.CalculatedCapacity >= minCapacity && r.CalculatedCapacity <= maxCapacity);
            finalFilteredRooms = finalFilteredRooms.Where(r => r.CalculatedCapacity <= maxCapacity); 

            if (filterHasBalcony) finalFilteredRooms = finalFilteredRooms.Where(r => r.HasBalcony);
            if (filterHasKitchenette) finalFilteredRooms = finalFilteredRooms.Where(r => r.HasKitchen);
            if (filterIsSmokingAllowed) finalFilteredRooms = finalFilteredRooms.Where(r => r.IsSmokingAllowed);
            if (filterIsPetFriendly) finalFilteredRooms = finalFilteredRooms.Where(r => r.IsPetFriendly);


            var finalRoomsToShow = finalFilteredRooms.OrderBy(r => r.Number).ToList();

            if (finalRoomsToShow.Any())
            {
                foreach (var room in finalRoomsToShow)
                {
                    var card = new RoomCard(room);
                    card.Click += RoomCard_Click;
                    availableRoomsFlowLayoutPanel.Controls.Add(card);
                }
            }
            availableRoomsFlowLayoutPanel.ResumeLayout();
        }

        private void RoomCard_Click(object sender, EventArgs e)
        {
            foreach (Control control in availableRoomsFlowLayoutPanel.Controls)
            {
                if (control is RoomCard rc)
                {
                    rc.BackColor = SystemColors.Control;
                }
            }

            if (sender is RoomCard clickedCard)
            {
                SelectedRoom = clickedCard.RoomData;
                clickedCard.BackColor = SystemColors.Highlight;
                btnSelectRoom.Enabled = true;
            }
        }
        private void btnSelectRoom_Click(object sender, EventArgs e)
        {
            if (SelectedRoom != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please select a room first.", "No Room Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRoomFilterClear_Click(object sender, EventArgs e)
        {
            cmbRoomTypeFilter.SelectedIndex = 0;
            cmbRoomStatusFilter.SelectedIndex = 0;
            cmbBedTypeFilter.SelectedIndex = 0;
            cmbRoomViewFilter.SelectedIndex = 0;

            dtpCheckInSelection.Value = DateTime.Today;
            dtpCheckOutSelection.Value = DateTime.Today.AddDays(1);

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
            DisplayAvailableRooms();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
            Close();
        }
    }
}
