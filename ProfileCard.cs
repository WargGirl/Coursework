using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class ProfileCard : UserControl
    {
        public event EventHandler<GuestEventArgs> ProfileCardDoubleClicked;

        public class GuestEventArgs : EventArgs
        {
            public Guest Guest { get; }
            public GuestEventArgs(Guest guest) => Guest = guest;
        }
        public string ProfileName { get => lblName.Text; set => lblName.Text = value; }
        public string ProfileSurname { get => lblSurname.Text; set => lblSurname.Text = value; }
        public string ProfileRoom { get => lblGuestRoom.Text; set => lblGuestRoom.Text = value; }
        public Enums.GuestStatus ProfileInHotelStatus { set => lblInHotelStatus.Text = value.ToString(); }
        public Image ProfileImage { get => guestPicBox.Image; set => guestPicBox.Image = value; }
        public PictureBoxSizeMode ProfileImageSizeMode { get => guestPicBox.SizeMode; set => guestPicBox.SizeMode = value; }
        public bool ProfileIsVIP { set => lblVIPStatus.Text = value ? "VIP" : "Non-VIP"; }
        public Guest GuestData { get; private set; }
        public string Role { get; set; }

        public ProfileCard(Guest guest)
        {
            InitializeComponent();
            GuestData = guest;
            ProfileName = guest.Name;
            ProfileSurname = guest.Surname;
            ProfileInHotelStatus = guest.InHotelStatus;
            if (!string.IsNullOrWhiteSpace(guest.RoomNumber))
            {
                ProfileRoom = guest.RoomNumber;
            }
            else
            {
                ProfileRoom = "-";
            }
            ProfileIsVIP = guest.IsVIP;
            guestPicBox.SizeMode = PictureBoxSizeMode.Zoom;

            Image loadedImage = ImageHelp.Base64ToImage(guest.PhotoBase64);
            if (loadedImage != null)
            {
                guestPicBox.Image = loadedImage;
            }
            else
            {
                guestPicBox.Image = Properties.Resources.DefaultGuestImage;
            }

            Role = "Guest";

            this.DoubleClick += ProfileCard_DoubleClick;
            foreach (Control control in this.Controls)
            {
                control.DoubleClick += ProfileCard_DoubleClick;
            }
        }
        private void ProfileCard_DoubleClick(object sender, EventArgs e)
        {
            ProfileCardDoubleClicked?.Invoke(this, new GuestEventArgs(GuestData));
        }
    }
}
