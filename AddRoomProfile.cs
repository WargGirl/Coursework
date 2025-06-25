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

namespace Coursework
{
    public partial class AddRoomProfile : Form
    {
        public Room CreatedRoom { get; private set; }

        public AddRoomProfile()
        {
            InitializeComponent();

            cmbRoomType.DataSource = Enum.GetValues(typeof(Enums.RoomType));
            cmbRoomStatus.DataSource = Enum.GetValues(typeof(Enums.RoomStatus));
            cmbRoomView.DataSource = Enum.GetValues(typeof(Enums.RoomView));

            cmbRoomType.SelectedItem = Enums.RoomType.Standard;
            cmbRoomStatus.SelectedItem = Enums.RoomStatus.Available;
            cmbRoomView.SelectedItem = Enums.RoomView.NoView;

            numPrice.Minimum = 0;
            numPrice.Maximum = 99999;
            numPrice.DecimalPlaces = 2;

            pictureBoxRoomPreview.SizeMode = PictureBoxSizeMode.Zoom;

            btnAddBedConfig.Click += btnAddBedConfig_Click;

            numPrice.DecimalPlaces = 2;

            AddBedConfigurationRow(null);
        }

        private void AddBedConfigurationRow(Room.BedConfiguration initialConfig)
        {
            Panel rowPanel = new Panel();
            rowPanel.Dock = DockStyle.Top;
            rowPanel.Height = 30;
            rowPanel.Padding = new Padding(0, 5, 0, 0);

            ComboBox cmbBedType = new ComboBox();
            cmbBedType.DataSource = Enum.GetValues(typeof(Enums.BedType));
            cmbBedType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBedType.Width = 120;
            cmbBedType.Left = 0;
            cmbBedType.Top = 0;
            rowPanel.Controls.Add(cmbBedType);

            NumericUpDown numQuantity = new NumericUpDown();
            numQuantity.Minimum = 1;
            numQuantity.Maximum = 10;
            numQuantity.Width = 50;
            numQuantity.Left = cmbBedType.Right + 5;
            numQuantity.Top = 0;
            rowPanel.Controls.Add(numQuantity);

            Button btnRemove = new Button();
            btnRemove.Text = "Remove";
            btnRemove.Width = 70;
            btnRemove.Left = numQuantity.Right + 5;
            btnRemove.Top = 0;
            btnRemove.Click += (s, e) => pnlBedConfigs.Controls.Remove(rowPanel);
            rowPanel.Controls.Add(btnRemove);

            if (initialConfig != null)
            {
                cmbBedType.SelectedItem = initialConfig.Type;
                numQuantity.Value = initialConfig.Quantity;
            }
            else
            {
                cmbBedType.SelectedItem = Enums.BedType.Double;
                numQuantity.Value = 1;
            }

            pnlBedConfigs.Controls.Add(rowPanel);
        }

        private void btnAddBedConfig_Click(object sender, EventArgs e)
        {
            AddBedConfigurationRow(null);
        }


        private void btnAdd_Click(object sender, EventArgs e)
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
                        bedConfigs.Add(new Room.BedConfiguration(
                            (Enums.BedType)cmbBedType.SelectedItem,
                            (int)numQuantity.Value
                        ));
                    }
                }
            }
            if (!bedConfigs.Any())
            {
                MessageBox.Show("Please add at least one bed configuration for the room.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CreatedRoom = new Room
            {
                RoomId = Guid.NewGuid().ToString(),
                Number = txtRoomNumber.Text.Trim(),
                Type = (Enums.RoomType)cmbRoomType.SelectedItem,
                BedConfigurations = bedConfigs,
                Price = numPrice.Value,
                Status = (Enums.RoomStatus)cmbRoomStatus.SelectedItem,
                Description = txtDescription.Text.Trim(),
                Photo = ImageHelp.ImageToBase64(pictureBoxRoomPreview.Image, ImageFormat.Png),
                HasBalcony = chkHasBalcony.Checked,
                HasKitchen = chkHasKitchen.Checked,
                IsSmokingAllowed = chkIsSmokingAllowed.Checked,
                IsPetFriendly = chkIsPetFriendly.Checked,
                View = (Enums.RoomView)cmbRoomView.SelectedItem,
                Floor = (int)numFloor.Value,
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
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
                    txtPhotoPath.Text = ofd.FileName;
                    using (Image originalImage = Image.FromFile(ofd.FileName))
                    {
                        Size targetSize = pictureBoxRoomPreview.Size;
                        Bitmap croppedAndResizedImage = ImageHelp.CropAndResizeToBitmap(originalImage, targetSize);
                        pictureBoxRoomPreview.Image = croppedAndResizedImage;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading or processing image: {ex.Message}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
