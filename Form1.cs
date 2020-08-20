using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetable_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            logoPictureBox.BackColor = Color.Transparent;
            lblPassword.BackColor = Color.Transparent;
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageStudentsDashboard obj = new ManageStudentsDashboard();
            obj.Show();
        }

       
    }
}
