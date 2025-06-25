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
    public partial class AddStaffProfile : Form
    {
        public Staff CreatedStaff { get; private set; }
        public AddStaffProfile()
        {
            InitializeComponent();

            cmbProfession.DataSource = Enum.GetValues(typeof(StaffProfession));
            cmbEmploymentStatus.DataSource = Enum.GetValues(typeof(StaffEmploymentStatus));

            cmbProfession.SelectedItem = StaffProfession.Receptionist;
            cmbEmploymentStatus.SelectedItem = StaffEmploymentStatus.Active;

            dtpWorkStartTime.Value = DateTime.Today.AddHours(9);
            dtpWorkEndTime.Value = DateTime.Today.AddHours(17);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string phone = txtPhoneNumber.Text;
            string passport = txtPassport.Text;

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSurname.Text) || string.IsNullOrWhiteSpace(surname))
            {
                MessageBox.Show("Surname is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(numSalary.Value.ToString(), out decimal salary))
            {
                MessageBox.Show("Invalid salary format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpBirthDate.Value > DateTime.Today)
            {
                MessageBox.Show("Date of Birth cannot be in the future.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CreatedStaff = new Staff
            {
                StaffId = Guid.NewGuid().ToString(),
                Name = name.Trim(),
                Surname = surname.Trim(),
                Profession = (StaffProfession)cmbProfession.SelectedItem,
                EmploymentStatus = (StaffEmploymentStatus)cmbEmploymentStatus.SelectedItem,
                Salary = salary,
                Photo = ImageHelp.ImageToBase64(pictureBoxPreview.Image, ImageFormat.Png),
                Phone = (string.IsNullOrWhiteSpace(phone)) ? "" : phone.Trim(),
                Passport = (string.IsNullOrWhiteSpace(passport)) ? "" : passport.Trim(),
                DateOfBirth = dtpBirthDate.Value,
                WorkStartTime = dtpWorkStartTime.Value.TimeOfDay,
                WorkEndTime = dtpWorkEndTime.Value.TimeOfDay
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg",
                Title = "Select Staff Photo"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtPhotoPath.Text = ofd.FileName;
                    txtPhotoPath.ForeColor = SystemColors.WindowText;

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
                    txtPhotoPath.Text = "Error loading photo";
                    txtPhotoPath.ForeColor = SystemColors.GrayText;
                }
            }
        }
    }
}
