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
    public partial class StaffProfile : Form
    {
        private Staff staff;
        private Staff snapshot;
        private bool editMode = false;
        private MainPage mainPageInstance;

        public StaffProfile(Staff staff, MainPage mainPage)
        {
            InitializeComponent();
            this.staff = staff;
            this.mainPageInstance = mainPage;

            cmbProfession.DataSource = Enum.GetValues(typeof(StaffProfession));
            cmbEmploymentStatus.DataSource = Enum.GetValues(typeof(StaffEmploymentStatus));

            dtpWorkStartTime.Format = DateTimePickerFormat.Time;
            dtpWorkStartTime.ShowUpDown = true;
            dtpWorkEndTime.Format = DateTimePickerFormat.Time;
            dtpWorkEndTime.ShowUpDown = true;

            LoadStaffData();
            ToggleEdit(false);
        }

        private void LoadStaffData()
        {
            this.Text = $"Staff Profile: {staff.Name} {staff.Surname}";

            txtName.Text = staff.Name;
            txtSurname.Text = staff.Surname;
            txtPhoneNumber.Text = staff.Phone;
            txtPassport.Text = staff.Passport;
            numSalary.Value = staff.Salary;
            cmbProfession.SelectedItem = staff.Profession;
            cmbEmploymentStatus.SelectedItem = staff.EmploymentStatus;
            dtpBirthDate.Value = staff.DateOfBirth;
            dtpWorkStartTime.Value = DateTime.Today.Add(staff.WorkStartTime);
            dtpWorkEndTime.Value = DateTime.Today.Add(staff.WorkEndTime);

            Image loadedImage = ImageHelp.Base64ToImage(staff.Photo);
            if (loadedImage != null)
            {
                pictureBoxPreview.Image = loadedImage;
            }
        }

        private void ToggleEdit(bool enable)
        {
            editMode = enable;

            btnEdit.Enabled = !enable;
            btnSave.Enabled = enable;
            btnCancel.Enabled = enable;
            btnDelete.Enabled = !enable;

            txtName.ReadOnly = !enable;
            txtName.Enabled = enable;
            txtSurname.ReadOnly = !enable;
            txtSurname.Enabled = enable;
            txtPhoneNumber.ReadOnly = !enable;
            txtPhoneNumber.Enabled = enable;
            txtPassport.ReadOnly = !enable;
            txtPassport.Enabled = enable;
            numSalary.Enabled = enable;
            numSalary.ReadOnly = !enable;
            cmbProfession.Enabled = enable;
            cmbEmploymentStatus.Enabled = enable;
            dtpBirthDate.Enabled = enable;
            dtpWorkStartTime.Enabled = enable;
            dtpWorkEndTime.Enabled = enable;
            btnChoosePhoto.Enabled = enable;
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete staff member '{staff.Name} {staff.Surname}'?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                mainPageInstance?.DeleteStaff(this.staff);
                this.Close();
            }
        }

        private Staff CloneStaff(Staff s)
        {
            return new Staff
            {
                StaffId = s.StaffId,
                Name = s.Name,
                Surname = s.Surname,
                Profession = s.Profession,
                EmploymentStatus = s.EmploymentStatus,
                Salary = s.Salary,
                Photo = s.Photo,
                Phone = s.Phone,
                Passport = s.Passport,
                DateOfBirth = s.DateOfBirth,
                WorkStartTime = s.WorkStartTime,
                WorkEndTime = s.WorkEndTime
            };
        }

        private void CopyStaffProperties(Staff source, Staff target)
        {
            target.Name = source.Name;
            target.Surname = source.Surname;
            target.Profession = source.Profession;
            target.EmploymentStatus = source.EmploymentStatus;
            target.Salary = source.Salary;
            target.Photo = source.Photo;
            target.Phone = source.Phone;
            target.Passport = source.Passport;
            target.DateOfBirth = source.DateOfBirth;
            target.WorkStartTime = source.WorkStartTime;
            target.WorkEndTime = source.WorkEndTime;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            snapshot = CloneStaff(staff);
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
                MessageBox.Show("Name is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(surname))
            {
                MessageBox.Show("Surname is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpBirthDate.Value > DateTime.Today)
            {
                MessageBox.Show("Date of Birth cannot be in the future.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            staff.Name = name;
            staff.Surname = surname;
            staff.Profession = (StaffProfession)cmbProfession.SelectedItem;
            staff.EmploymentStatus = (StaffEmploymentStatus)cmbEmploymentStatus.SelectedItem;
            staff.Salary = numSalary.Value;
            staff.Photo = ImageHelp.ImageToBase64(pictureBoxPreview.Image, ImageFormat.Png);
            staff.Phone = phone;
            staff.Passport = passport;
            staff.DateOfBirth = dtpBirthDate.Value;
            staff.WorkStartTime = dtpWorkStartTime.Value.TimeOfDay;
            staff.WorkEndTime = dtpWorkEndTime.Value.TimeOfDay;

            ToggleEdit(false);
            LoadStaffData();
            mainPageInstance?.SearchStaff();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CopyStaffProperties(snapshot, staff);
            LoadStaffData();
            ToggleEdit(false);
            mainPageInstance?.SearchStaff();
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
                    using (Image originalImage = Image.FromFile(ofd.FileName))
                    {
                        Size targetSize = pictureBoxPreview.Size;
                        Bitmap croppedAndResizedImage = ImageHelp.CropAndResizeToBitmap(originalImage, targetSize);

                        pictureBoxPreview.Image = croppedAndResizedImage;

                        staff.Photo = ImageHelp.ImageToBase64(croppedAndResizedImage, ImageFormat.Png);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    staff.Photo = null;
                }
            }
        }
    }
}