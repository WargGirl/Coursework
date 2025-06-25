using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Coursework.Enums;

namespace Coursework
{
    public partial class RoomProfile : Form
    {
        private Room room;
        private Room snapshot;
        private bool editMode = false;
        private MainPage mainPageInstance;
        public RoomProfile(Room room, MainPage mainPage)
        {
            InitializeComponent();
            this.room = room;
            this.mainPageInstance = mainPage;

            cmbRoomType.DataSource = Enum.GetValues(typeof(RoomType));
            cmbRoomStatus.DataSource = Enum.GetValues(typeof(RoomStatus));
            cmbRoomView.DataSource = Enum.GetValues(typeof(RoomView));

            numPrice.Minimum = 0;
            numPrice.Maximum = 99999;
            numPrice.DecimalPlaces = 2;

            pictureBoxRoomPreview.SizeMode = PictureBoxSizeMode.Zoom;
            btnAddBedConfig.Click += btnAddBedConfig_Click;

            LoadRoomData();
            ToggleEdit(false);
        }
        private void AddBedConfigurationRow(Room.BedConfiguration initialConfig, bool editable)
        {
            Panel rowPanel = new Panel();
            rowPanel.Dock = DockStyle.Top;
            rowPanel.Height = 30;
            rowPanel.Padding = new Padding(0, 5, 0, 0);

            ComboBox cmbBedType = new ComboBox();
            cmbBedType.DataSource = Enum.GetValues(typeof(BedType));
            cmbBedType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBedType.Width = 120;
            cmbBedType.Left = 0;
            cmbBedType.Top = 0;
            cmbBedType.Enabled = editable;
            rowPanel.Controls.Add(cmbBedType);

            NumericUpDown numQuantity = new NumericUpDown();
            numQuantity.Minimum = 1;
            numQuantity.Maximum = 10;
            numQuantity.Width = 50;
            numQuantity.Left = cmbBedType.Right + 5;
            numQuantity.Top = 0;
            numQuantity.Enabled = editable;
            rowPanel.Controls.Add(numQuantity);

            if (editable)
            {
                Button btnRemove = new Button();
                btnRemove.Text = "Remove";
                btnRemove.Width = 70;
                btnRemove.Left = numQuantity.Right + 5;
                btnRemove.Top = 0;
                btnRemove.Click += (s, e) => pnlBedConfigs.Controls.Remove(rowPanel);
                rowPanel.Controls.Add(btnRemove);
            }

            if (initialConfig != null)
            {
                cmbBedType.SelectedItem = initialConfig.Type;
                numQuantity.Value = initialConfig.Quantity;
            }
            else
            {
                cmbBedType.SelectedItem = BedType.Double;
                numQuantity.Value = 1;
            }

            pnlBedConfigs.Controls.Add(rowPanel);
        }
        private void LoadRoomData()
        {
            this.Text = $"Room Profile: {room.Number}";

            txtRoomNumber.Text = room.Number;
            numPrice.Value = room.Price;
            cmbRoomType.SelectedItem = room.Type;
            cmbRoomStatus.SelectedItem = room.Status;
            txtDescription.Text = room.Description;
            chkHasBalcony.Checked = room.HasBalcony;
            chkHasKitchen.Checked = room.HasKitchen;
            chkIsSmokingAllowed.Checked = room.IsSmokingAllowed;
            chkIsPetFriendly.Checked = room.IsPetFriendly;
            cmbRoomView.SelectedItem = room.View;
            numFloor.Value = room.Floor;

            Image loadedImage = ImageHelp.Base64ToImage(room.Photo);
            if (loadedImage != null)
            {
                pictureBoxRoomPreview.Image = loadedImage;
                txtPhotoPath.ForeColor = SystemColors.WindowText;
            }
            else
            {
                txtPhotoPath.ForeColor = SystemColors.GrayText;
            }

            pnlBedConfigs.Controls.Clear();
            if (room.BedConfigurations != null && room.BedConfigurations.Any())
            {
                foreach (var config in room.BedConfigurations)
                {
                    AddBedConfigurationRow(config, editMode);
                }
            }
        }
        private void ToggleEdit(bool enable)
        {
            editMode = enable;

            btnEdit.Enabled = !enable;
            btnSave.Enabled = enable;
            btnCancel.Enabled = enable;
            btnDelete.Enabled = !enable;
            btnAddBedConfig.Visible = enable;

            txtRoomNumber.ReadOnly = !enable;
            txtRoomNumber.Enabled = enable;
            numPrice.Enabled = enable;
            numPrice.ReadOnly = enable;
            cmbRoomType.Enabled = enable;
            cmbRoomStatus.Enabled = enable;
            txtDescription.ReadOnly = !enable;
            txtDescription.Enabled = enable;
            btnChoosePhoto.Enabled = enable;
            chkHasBalcony.Enabled = enable;
            chkHasKitchen.Enabled = enable;
            chkIsSmokingAllowed.Enabled = enable;
            chkIsPetFriendly.Enabled = enable;
            cmbRoomView.Enabled = enable;
            numFloor.Enabled = enable;
            numFloor.ReadOnly = enable;

            pnlBedConfigs.Controls.Clear();
            if (room.BedConfigurations != null)
            {
                foreach (var config in room.BedConfigurations)
                {
                    AddBedConfigurationRow(config, enable);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            snapshot = CloneRoom(room);
            ToggleEdit(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomNumber.Text))
            {
                MessageBox.Show("Room Number is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Room.BedConfiguration> bedConfigs = new List<Room.BedConfiguration>();
            foreach (Control control in pnlBedConfigs.Controls)
            {
                if (control is Panel rowPanel)
                {
                    ComboBox cmbBedType = rowPanel.Controls.OfType<ComboBox>().FirstOrDefault();
                    NumericUpDown numQuantity = rowPanel.Controls.OfType<NumericUpDown>().FirstOrDefault();

                    if (cmbBedType?.SelectedItem != null && numQuantity != null)
                    {
                        if ((Enums.BedType)cmbBedType.SelectedItem != Enums.BedType.Double || numQuantity.Value != 1 || room.BedConfigurations.Any(bc => bc.Type == (Enums.BedType)cmbBedType.SelectedItem && bc.Quantity == (int)numQuantity.Value))
                        {
                            bedConfigs.Add(new Room.BedConfiguration(
                                (Enums.BedType)cmbBedType.SelectedItem,
                                (int)numQuantity.Value
                            ));
                        }
                    }
                }
            }

            if (!bedConfigs.Any())
            {
                MessageBox.Show("Please add at least one bed configuration for the room.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            room.Number = txtRoomNumber.Text.Trim();
            room.Price = numPrice.Value;
            room.Type = (RoomType)cmbRoomType.SelectedItem;
            room.Status = (RoomStatus)cmbRoomStatus.SelectedItem;
            room.Description = txtDescription.Text.Trim();
            room.BedConfigurations = bedConfigs;
            room.HasBalcony = chkHasBalcony.Checked;
            room.HasKitchen = chkHasKitchen.Checked;
            room.IsSmokingAllowed = chkIsSmokingAllowed.Checked;
            room.IsPetFriendly = chkIsPetFriendly.Checked;
            room.View = (RoomView)cmbRoomView.SelectedItem;
            room.Floor = (int)numFloor.Value;

            room.Photo = ImageHelp.ImageToBase64(pictureBoxRoomPreview.Image, ImageFormat.Png);

            ToggleEdit(false);
            LoadRoomData();
            mainPageInstance?.SearchRooms();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CopyRoomProperties(snapshot, room);
            LoadRoomData();
            ToggleEdit(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete room '{room.Number}'?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                mainPageInstance?.DeleteRoom(this.room);
                mainPageInstance?.SearchRooms();
                this.Close();
            }
        }
        private Room CloneRoom(Room r)
        {
            List<string> occupantIdsCopy = r.OccupantGuestIds != null ? new List<string>(r.OccupantGuestIds) : new List<string>();
            List<Room.BedConfiguration> bedConfigsCopy = r.BedConfigurations != null ?
                r.BedConfigurations.Select(bc => new Room.BedConfiguration(bc.Type, bc.Quantity)).ToList() :
                new List<Room.BedConfiguration>();

            return new Room
            {
                RoomId = r.RoomId,
                Number = r.Number,
                Type = r.Type,
                BedConfigurations = bedConfigsCopy,
                Price = r.Price,
                Status = r.Status,
                Description = r.Description,
                Photo = r.Photo,
                OccupantGuestIds = occupantIdsCopy,
                HasBalcony = r.HasBalcony,
                HasKitchen = r.HasKitchen,
                IsSmokingAllowed = r.IsSmokingAllowed,
                IsPetFriendly = r.IsPetFriendly,
                SquareFootage = r.SquareFootage,
                View = r.View,
                Floor = r.Floor,
            };
        }
        private void CopyRoomProperties(Room source, Room target)
        {
            target.Number = source.Number;
            target.Type = source.Type;
            target.Price = source.Price;
            target.Status = source.Status;
            target.Description = source.Description;
            target.Photo = source.Photo;
            target.HasBalcony = source.HasBalcony;
            target.HasKitchen = source.HasKitchen;
            target.IsSmokingAllowed = source.IsSmokingAllowed;
            target.IsPetFriendly = source.IsPetFriendly;
            target.SquareFootage = source.SquareFootage;
            target.View = source.View;
            target.Floor = source.Floor;

            target.OccupantGuestIds.Clear();
            if (source.OccupantGuestIds != null)
            {
                target.OccupantGuestIds.AddRange(source.OccupantGuestIds);
            }
            target.BedConfigurations.Clear();
            if (source.BedConfigurations != null)
            {
                foreach (var config in source.BedConfigurations)
                {
                    target.BedConfigurations.Add(new Room.BedConfiguration(config.Type, config.Quantity));
                }
            }
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg",
                Title = "Select Room Photo"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtPhotoPath.Text = ofd.FileName;
                    txtPhotoPath.ForeColor = SystemColors.WindowText;

                    using (Image originalImage = Image.FromFile(ofd.FileName))
                    {
                        Size targetSize = pictureBoxRoomPreview.Size;
                        Bitmap croppedAndResizedImage = ImageHelp.CropAndResizeToBitmap(originalImage, targetSize);

                        pictureBoxRoomPreview.Image = croppedAndResizedImage;

                        room.Photo = ImageHelp.ImageToBase64(croppedAndResizedImage, ImageFormat.Png);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    room.Photo = null;
                    txtPhotoPath.Text = "Error loading photo";
                    txtPhotoPath.ForeColor = SystemColors.GrayText;
                }
            }
        }

        private void btnAddBedConfig_Click(object sender, EventArgs e)
        {
            AddBedConfigurationRow(null, true);
        }
    }
}
