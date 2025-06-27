using Coursework.Models;
using Coursework.Utils;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Coursework.Utils.Enums;

namespace Coursework
{
    public partial class GuestProfile : Form
    {
        private Guest guest;
        private Guest snapshot;
        private bool editMode = false;
        private MainPage mainPageInstance;
        public GuestProfile(Guest guest, MainPage mainPage)
        {
            InitializeComponent();
            this.guest = guest;
            mainPageInstance = mainPage;
            cmbGender.DataSource = Enum.GetValues(typeof(Gender));
            LoadGuestData();
            ToggleEdit(false);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            snapshot = CloneGuest(guest);
            ToggleEdit(true);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string phone = txtPhoneNumber.Text.Trim();
            string passport = txtPassport.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(surname))
            {
                MessageBox.Show("Surname is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(passport))
            {
                MessageBox.Show("Passport ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpBirthDate.Value.Date > DateTime.Today.Date)
            {
                MessageBox.Show("Date of Birth cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            guest.Name = name;
            guest.Surname = surname;
            guest.Phone = string.IsNullOrWhiteSpace(phone) ? "" : phone;
            guest.Passport = string.IsNullOrWhiteSpace(passport) ? "" : passport;

            guest.DateOfBirth = dtpBirthDate.Value;
            guest.GuestGender = (Gender)Enum.Parse(typeof(Gender), cmbGender.SelectedItem.ToString());
            guest.IsVIP = chkVIP.Checked;

            guest.CheckInDate = dtpCheckInDate.Value.Date;
            guest.CheckOutDate = dtpCheckOutDate.Value.Date;
            guest.PhotoBase64 = ImageHelp.ImageToBase64(pictureBoxPreview.Image, ImageFormat.Png);

            if (guest.InHotelStatus == GuestStatus.InHotel && string.IsNullOrWhiteSpace(guest.RoomNumber))
            {
                MessageBox.Show("Guest status is 'In Hotel' but no room is assigned. This might be a data inconsistency. Please use 'Check-in' button to assign a room.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (guest.InHotelStatus == GuestStatus.NotInHotel && !string.IsNullOrWhiteSpace(guest.RoomNumber) && guest.CheckOutDate.Date >= DateTime.Today.Date)
            {
                MessageBox.Show("Guest status is 'Not In Hotel' but they still have a room assigned, and their check-out date is in the future. Please use 'Check-out' button.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (guest.InHotelStatus == GuestStatus.Booked && string.IsNullOrWhiteSpace(guest.RoomNumber))
            {
                MessageBox.Show("Guest status is 'Booked' but no room is assigned. Please assign a room using 'Check-in' for booking.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ToggleEdit(false);
            LoadGuestData();
            mainPageInstance?.SearchGuests();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            CopyGuestProperties(snapshot, guest);
            LoadGuestData();
            ToggleEdit(false);
        }
        private void ToggleEdit(bool enable)
        {
            editMode = enable;
            btnEdit.Enabled = !enable;
            btnSave.Enabled = enable;
            btnCancel.Enabled = enable;
            btnDelete.Enabled = !enable;
            btnChoosePhoto.Enabled = enable;

            txtName.ReadOnly = !enable;
            txtSurname.ReadOnly = !enable;
            txtPhoneNumber.ReadOnly = !enable;
            txtPassport.ReadOnly = !enable;
            txtAdditionalInfo.ReadOnly = !enable;

            txtName.Enabled = enable;
            txtSurname.Enabled = enable;
            txtPhoneNumber.Enabled = enable;
            txtPassport.Enabled = enable;
            txtAdditionalInfo.Enabled = enable;

            dtpBirthDate.Enabled = enable;
            cmbGender.Enabled = enable;
            chkVIP.Enabled = enable;

            txtRoomNumber.Enabled = false;
            txtRoomNumber.ReadOnly = true;


            UpdateActionButtonStates();
        }

        private void LoadGuestData()
        {
            this.Text = $"Guest Profile: {guest.Name} {guest.Surname}";

            txtName.Text = guest.Name;
            txtSurname.Text = guest.Surname;
            txtPassport.Text = guest.Passport;
            txtRoomNumber.Text = guest.RoomNumber;
            txtPhoneNumber.Text = guest.Phone;
            dtpBirthDate.Value = guest.DateOfBirth;
            cmbGender.SelectedItem = guest.GuestGender;
            chkVIP.Checked = guest.IsVIP;
            txtInHotelStatus.Text = guest.InHotelStatus.ToString();
            txtAdditionalInfo.Text = guest.AdditionalInfo;
            if(guest.InHotelStatus != GuestStatus.NotInHotel)
            {
                dtpCheckInDate.Visible = true;
                dtpCheckOutDate.Visible = true;
                label1.Visible = true;
                lblCheckIn.Visible = true;
                lblCheckOut.Visible = true;
                dtpCheckInDate.Value = guest.CheckInDate;
                dtpCheckOutDate.Value = guest.CheckOutDate;
            }
            else
            {
                dtpCheckInDate.Visible = false;
                dtpCheckOutDate.Visible = false;
                label1.Visible = false;
                lblCheckIn.Visible = false;
                lblCheckOut.Visible = false;
            }

            if (!string.IsNullOrWhiteSpace(guest.RoomNumber))
            {
                txtRoomNumber.Text = guest.RoomNumber;
            }

            dtpCheckInDate.Value = (guest.CheckInDate == DateTime.MinValue) ? DateTime.Today : guest.CheckInDate;
            dtpCheckOutDate.Value = (guest.CheckOutDate == DateTime.MinValue) ? DateTime.Today.AddDays(1) : guest.CheckOutDate;

            lblAgeNumber.Text = guest.Age.ToString();
            Image loadedImage = ImageHelp.Base64ToImage(guest.PhotoBase64);

            if (loadedImage != null)
            {
                pictureBoxPreview.Image = loadedImage;
            }

            UpdateActionButtonStates();
        }

        private Guest CloneGuest(Guest g)
        {
            return new Guest
            {
                GuestId = g.GuestId,
                Name = g.Name,
                Surname = g.Surname,
                RoomNumber = g.RoomNumber,
                Phone = g.Phone,
                Passport = g.Passport,
                DateOfBirth = g.DateOfBirth,
                GuestGender = g.GuestGender,
                IsVIP = g.IsVIP,
                CheckInDate = g.CheckInDate,
                CheckOutDate = g.CheckOutDate,
                PhotoBase64 = g.PhotoBase64
            };
        }
        private void CopyGuestProperties(Guest source, Guest target)
        {
            target.Name = source.Name;
            target.Surname = source.Surname;
            target.RoomNumber = source.RoomNumber;
            target.Phone = source.Phone;
            target.Passport = source.Passport;
            target.DateOfBirth = source.DateOfBirth;
            target.GuestGender = source.GuestGender;
            target.IsVIP = source.IsVIP;
            target.CheckInDate = source.CheckInDate;
            target.CheckOutDate = source.CheckOutDate;
            target.PhotoBase64 = source.PhotoBase64;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete the profile for guest '{guest.Name} {guest.Surname}'?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {
                mainPageInstance?.DeleteGuest(this.guest);
                mainPageInstance?.SearchGuests();
                this.Close();
            }
        }
        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Image originalImage = Image.FromFile(ofd.FileName))
                    {
                        Size targetSize = pictureBoxPreview.Size;
                        Bitmap croppedAndResizedImage = ImageHelp.CropAndResizeToBitmap(originalImage, targetSize);

                        pictureBoxPreview.Image = croppedAndResizedImage;
                        guest.PhotoBase64 = ImageHelp.ImageToBase64(croppedAndResizedImage, ImageFormat.Png);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    guest.PhotoBase64 = null;
                }
            }
        }
        private void UpdateActionButtonStates()
        {
            btnBook.Enabled = !editMode;
            btnCheckIn.Enabled = !editMode;
            btnCheckOut.Enabled = !editMode;
            btnExtendStay.Enabled = !editMode;

            if (!editMode)
            {
                bool hasBasicInfo = !string.IsNullOrWhiteSpace(guest.Name) && !string.IsNullOrWhiteSpace(guest.Passport);
                btnBook.Enabled = (guest.InHotelStatus == GuestStatus.NotInHotel || guest.InHotelStatus == GuestStatus.Booked)
                                      && hasBasicInfo;
                btnCheckIn.Enabled = guest.InHotelStatus == GuestStatus.BookedCheckIn && !string.IsNullOrWhiteSpace(guest.RoomNumber)
                                      && hasBasicInfo;
                btnCheckOut.Enabled = guest.InHotelStatus == GuestStatus.InHotel || guest.InHotelStatus == GuestStatus.InHotelCheckOutDay;
                btnExtendStay.Enabled = (guest.InHotelStatus == GuestStatus.InHotel || guest.InHotelStatus == GuestStatus.InHotelCheckOutDay || guest.InHotelStatus == GuestStatus.Booked)
                                         && !string.IsNullOrWhiteSpace(guest.RoomNumber);
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guest.Name) || string.IsNullOrWhiteSpace(guest.Passport))
            {
                MessageBox.Show("Guest must have a Name and Passport ID before booking a room.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!(guest.InHotelStatus == GuestStatus.NotInHotel || guest.InHotelStatus == GuestStatus.Booked))
            {
                MessageBox.Show("Guest is already checked in or has a room assigned. Cannot create a new booking.", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var roomSelectionForm = new RoomSelectionForm(mainPageInstance))
            {
                roomSelectionForm.Text = $"Book Room for {guest.Name} {guest.Surname}";

                var result = roomSelectionForm.ShowDialog();

                if (result == DialogResult.OK && roomSelectionForm.SelectedRoom != null)
                {
                    Room selectedRoom = roomSelectionForm.SelectedRoom;

                    DateTime bookedCheckInDate = roomSelectionForm.SelectedCheckInDate;
                    DateTime bookedCheckOutDate = roomSelectionForm.SelectedCheckOutDate;

                    if (bookedCheckInDate.Date < DateTime.Today.Date)
                    {
                        MessageBox.Show("Booking check-in date cannot be in the past. Please select a future date.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (bookedCheckOutDate.Date <= bookedCheckInDate.Date)
                    {
                        MessageBox.Show("Booking check-out date must be after check-in date.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    guest.RoomNumber = selectedRoom.Number;
                    guest.AssignedRoom = selectedRoom;
                    guest.CheckInDate = bookedCheckInDate;
                    guest.CheckOutDate = bookedCheckOutDate;
                    mainPageInstance.SearchGuests();
                    UpdateActionButtonStates();
                    LoadGuestData();

                    MessageBox.Show($"Guest {guest.Name} {guest.Surname} successfully booked room {selectedRoom.Number}.\n" +
                                    $"Booked Check-in Date: {guest.CheckInDate.ToShortDateString()}\n" +
                                    $"Booked Check-out Date: {guest.CheckOutDate.ToShortDateString()}.",
                                    "Room Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guest.Name) || string.IsNullOrWhiteSpace(guest.Passport))
            {
                MessageBox.Show("Guest must have a Name and Passport ID before check-in.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            guest.inHotelCheck = true;
            mainPageInstance.SearchGuests();
            mainPageInstance.SearchRooms();
            LoadGuestData();
            UpdateActionButtonStates();
            ReceiptGenerator.GenerateCheckInReceipt(guest, guest.AssignedRoom, null);       
            MessageBox.Show($"Guest {guest.Name} {guest.Surname} successfully checked into room {guest.RoomNumber}.\n" +
                                    $"Check-in Date: {guest.CheckInDate.ToShortDateString()}\n" +
                                    $"Check-out Date: {guest.CheckOutDate.ToShortDateString()}.",
                                    "Check-in Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnExtendStay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guest.RoomNumber) || (guest.InHotelStatus != GuestStatus.InHotel && guest.InHotelStatus != GuestStatus.InHotelCheckOutDay && guest.InHotelStatus != GuestStatus.Booked && guest.InHotelStatus != GuestStatus.BookedCheckIn))
            {
                MessageBox.Show("Guest is not currently checked in or assigned a room to extend stay for.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newDateString = Interaction.InputBox(
                $"Enter new check-out date for {guest.Name} {guest.Surname} (YYYY-MM-DD format):",
                "Extend Stay", guest.CheckOutDate.AddDays(1).ToShortDateString());

            if (!string.IsNullOrWhiteSpace(newDateString))
            {
                if (DateTime.TryParse(newDateString, out DateTime newCheckOutDate))
                {
                    if (newCheckOutDate > guest.CheckOutDate)
                    {
                        DateTime oldCheckOutDate = guest.CheckOutDate;
                        guest.CheckOutDate = newCheckOutDate.Date;
                        ReceiptGenerator.GenerateExtendStayReceipt(guest, oldCheckOutDate, guest.CheckOutDate, guest.AssignedRoom);
                        mainPageInstance.SearchGuests();
                        LoadGuestData();
                        MessageBox.Show($"Guest {guest.Name} {guest.Surname}'s stay extended to {guest.CheckOutDate.ToShortDateString()}.\n" +
                                        "Additional charges may apply. Consult for a detailed receipt.",
                                        "Stay Extended", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("New check-out date must be later than the current check-out date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid date format. Please use YYYY-MM-DD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guest.RoomNumber) || (guest.InHotelStatus != GuestStatus.InHotel && guest.InHotelStatus != GuestStatus.InHotelCheckOutDay))
            {
                MessageBox.Show("Guest is not currently checked in or assigned a room to check out from.", "Check-out Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(guest.RoomNumber))
            {
                MessageBox.Show("Guest has no room assigned to check out from.", "Check-out Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmResult = MessageBox.Show(
                $"Are you sure you want to check out guest {guest.Name} {guest.Surname} from room {guest.RoomNumber}?",
                "Confirm Check-out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                ReceiptGenerator.GenerateCheckOutReceipt(guest, guest.AssignedRoom);
                guest.inHotelCheck = false;
                MessageBox.Show($"Guest {guest.Name} {guest.Surname} successfully checked out from room {guest.RoomNumber}.\n" +
                                $"Check-out Date: {DateTime.Today.ToShortDateString()}",
                                "Check-out Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainPageInstance.GetRoomById(guest.AssignedRoom.RoomId).Status = RoomStatus.Cleaning;
                guest.RoomNumber = null;
                guest.CheckOutDate = DateTime.MinValue;
                guest.CheckInDate = DateTime.MinValue;
                mainPageInstance.SearchGuests();
                mainPageInstance.SearchRooms();
                LoadGuestData();
                UpdateActionButtonStates();
            }
        }
    }
}
