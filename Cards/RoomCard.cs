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
using Coursework.Utils;

namespace Coursework
{
    public partial class RoomCard : UserControl
    {
        public event EventHandler<RoomEventArgs> RoomCardDoubleClicked;

        public class RoomEventArgs : EventArgs
        {
            public Room Room { get; }
            public RoomEventArgs(Room room) => Room = room;
        }

        public Room RoomData { get; private set; }
        public RoomCard(Room room)
        {
            InitializeComponent();
            RoomData = room;

            lblRoomNumber.Text = $"Room: {room.Number}";
            lblRoomType.Text = $"Type: {room.Type.ToString()}";
            lblPrice.Text = $"Price: {room.Price:C}/night";
            lblStatus.Text = $"Status: {room.Status.ToString()}";
            lblCapacity.Text = $"Capacity: {room.CalculatedCapacity} guests";
            if (room.BedConfigurations != null && room.BedConfigurations.Any())
            {
                lblBeds.Text = "Beds: " + string.Join(", ", room.BedConfigurations.Select(b => b.ToString()));
            }
            else
            {
                lblBeds.Text = "Beds: N/A";
            }

            roomPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            Image loadedImage = ImageHelp.Base64ToImage(room.Photo);
            if (loadedImage != null)
            {
                roomPicBox.Image = loadedImage;
            }

            this.DoubleClick += RoomCard_DoubleClick;
            foreach (Control control in this.Controls)
            {
                control.DoubleClick += RoomCard_DoubleClick;
            }
        }
        private void RoomCard_DoubleClick(object sender, EventArgs e)
        {
            RoomCardDoubleClicked?.Invoke(this, new RoomEventArgs(RoomData));
        }
    }
}
