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
    public partial class AddGuestProfile : Form
    {
        public Guest CreatedGuest { get; private set; }

        public AddGuestProfile()
        {
            InitializeComponent();
            cmbGender.DataSource = Enum.GetValues(typeof(Gender));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string phone = txtPhoneNumber.Text.Trim();
            string passport = txtPassport.Text.Trim();
            string additionalInfo = txtAdditionalInfo.Text.Trim();

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

            CreatedGuest = new Guest
            {
                Name = name,
                Surname = surname,
                RoomNumber = null,
                IsVIP = chkVIP.Checked,
                GuestGender = (Gender)Enum.Parse(typeof(Gender), cmbGender.SelectedItem.ToString()),
                PhotoBase64 = ImageHelp.ImageToBase64(pictureBoxPreview.Image, ImageFormat.Png),
                Phone = phone,
                Passport = passport,
                DateOfBirth = dtpBirthDate.Value,
                AdditionalInfo = additionalInfo
            };

            DialogResult = DialogResult.OK;
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
                        Size targetSize = pictureBoxPreview.Size;
                        Bitmap croppedAndResizedImage = ImageHelp.CropAndResizeToBitmap(originalImage, targetSize);
                        pictureBoxPreview.Image = croppedAndResizedImage;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading or processing image: {ex.Message}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pictureBoxPreview.Image = Properties.Resources.DefaultGuestImage;
                }
            }
        }
    }
}
