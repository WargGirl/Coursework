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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Username" && txtPassword.Text == "password")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                txtUsername.Clear();
                txtPassword.Clear();
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
