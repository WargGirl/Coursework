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
    public partial class StaffCard : UserControl
    {
        public event EventHandler<StaffEventArgs> StaffCardDoubleClicked;
        public class StaffEventArgs : EventArgs
        {
            public Staff Staff { get; }
            public StaffEventArgs(Staff staff) => Staff = staff;
        }

        public Staff StaffData { get; private set; }

        public StaffCard(Staff staff)
        {
            InitializeComponent();
            StaffData = staff;

            lblName.Text = staff.Name;
            lblSurname.Text = staff.Surname;
            lblProfession.Text = $"Profession: {staff.Profession.ToString()}";
            lblEmploymentStatus.Text = $"Employment: {staff.EmploymentStatus.ToString()}{(staff.IsCurrentlyWorking ? " (Working)" : "")}";
            lblWorkStatus.Text = $"Shift: {staff.WorkStatusDisplay}";

            staffPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            Image loadedImage = ImageHelp.Base64ToImage(staff.Photo);
            if (loadedImage != null)
            {
                staffPicBox.Image = loadedImage;
            }

            this.DoubleClick += StaffCard_DoubleClick;
            foreach (Control control in this.Controls)
            {
                control.DoubleClick += StaffCard_DoubleClick;
            }
        }

        private void StaffCard_DoubleClick(object sender, EventArgs e)
        {
            StaffCardDoubleClicked?.Invoke(this, new StaffEventArgs(StaffData));
        }
    }
}
