using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_LTWindows
{
    public partial class LoginForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            facultyIDTb.Enabled = false;
            passwordTb.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!this.DesignMode)
            {
                StMDBE stM = new StMDBE();
                int facultyID = Convert.ToInt32(facultyIDTb.Text);
                var faculty = stM.FacultyLogins.Where(f => f.FacultyID == facultyID && f.Password == passwordTb.Text).SingleOrDefault();
                if (faculty != null)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                    Mediator.GetInstance().OnLogin(this, facultyID);
                    Mediator.GetInstance().OnProfileImgTransferer(this, faculty);
                }
                else
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác, vui lòng nhập lại");
            }    
        }
        
        private void panel1_Click(object sender, EventArgs e)
        {
            facultyIDTb.Enabled = true;
            panel1.BackColor = Color.FromArgb(235, 20, 76);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            passwordTb.Enabled = true;
            panel2.BackColor = Color.FromArgb(235, 20, 76);
        }

        private void LoginForm_Enter(object sender, EventArgs e)
        {
            
        }

        private void passwordTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }
    }
}
