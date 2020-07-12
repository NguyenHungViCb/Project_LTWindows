using ePOSOne.btnProduct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_LTWindows
{
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
            if(!this.DesignMode)
            {
                LoadProfileImg();
                
            }    
        }
        private void LoadProfileImg()
        {
            Mediator.GetInstance().profileImgTransferer += (s, e) =>
            {
                StMDBE stM = new StMDBE();
                if (e != null)
                {
                    FacultyLogin faculty = e;
                    var imgBytes = stM.ProfileImages.Where(i => i.FacultyID == faculty.FacultyID).SingleOrDefault();
                    Image img = bytesToImage(imgBytes.ProfileImage1);
                    roundedPictureBox2.Image = img;
                }
                else
                {
                    string path = "icons8-customer-256.png";
                    roundedPictureBox2.ImageLocation = path;
                    //pictureBox1.ImageLocation = path;
                }
            };
        }
        private Image bytesToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }
        private void OnDefaultColor(List<object> defaultColor)
        {
            foreach(var item in defaultColor)
            {
                if(item.GetType()==typeof(Panel))
                {
                    Panel pn = (Panel)item;
                    pn.BackColor = Color.FromArgb(235, 20, 76);
                }
                else if(item.GetType()==typeof(Button) || item.GetType()==typeof(Button_WOC))
                {
                    Button bt = (Button)item;
                    bt.Enabled = true;
                }
                else
                {
                    Label lb = (Label)item;
                    lb.Enabled = true;
                }
            }
        }
        private void studentManagementBt_Click(object sender, EventArgs e)
        {
            
            studentManagementBt.Enabled = false;
            label2.Enabled = false;
            panel1.BackColor = Color.FromArgb(77, 197, 213);
            List<object> defaultColor = new List<object> { panel3, panel4, gradesManagementBt, classesManagementBt, label3, label4, button8, button_WOC1 };
            OnDefaultColor(defaultColor);
            studentManagementBt.Enabled = false;
            gradesManagementBt.Enabled = true;
            classesManagementBt.Enabled = true;

            gradesManagement1.Visible = false;
            classesManagementUsC1.Visible = false;
            profileManagement1.Visible = false;
            studentManagementUsC1.Visible = true;
            Mediator.GetInstance().OnReloadPanel(sender, e);
        }

        private void gradesManagement_Click(object sender, EventArgs e)
        {
            gradesManagementBt.Enabled = false;
            label3.Enabled = false;
            panel3.BackColor = Color.FromArgb(77, 197, 213);
            List<object> defaultColor = new List<object> { panel1, panel4, studentManagementBt, classesManagementBt, label2, label4, button8, button_WOC1 };
            OnDefaultColor(defaultColor);
            gradesManagementBt.Enabled = false;
            classesManagementBt.Enabled = true;
            studentManagementBt.Enabled = true;
            classesManagementUsC1.Visible = false;
            profileManagement1.Visible = false;
            studentManagementUsC1.Visible = false;
            gradesManagement1.Visible = true;
            Mediator.GetInstance().OnReloadPanel(sender, e);
        }

        private void classesManagement_Click(object sender, EventArgs e)
        {
            classesManagementBt.Enabled = false;
            label4.Enabled = false;
            panel4.BackColor = Color.FromArgb(77, 197, 213);
            List<object> defaultColor = new List<object> { panel1, panel3, studentManagementBt, gradesManagementBt, label2, label3, button8, button_WOC1 };
            OnDefaultColor(defaultColor);
            classesManagementBt.Enabled = false;
            studentManagementBt.Enabled = true;
            gradesManagementBt.Enabled = true;
            profileManagement1.Visible = false;
            studentManagementUsC1.Visible = false;
            gradesManagement1.Visible = false;
            classesManagementUsC1.Visible = true;
        }
        private event EventHandler<EventArgs> eventConstraints;
        private void label2_Click(object sender, EventArgs e)
        {
            eventConstraints = null;
            eventConstraints += studentManagementBt_Click;
            eventConstraints(this, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            eventConstraints = null;
            eventConstraints += gradesManagement_Click;
            eventConstraints(this, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            eventConstraints = null;
            eventConstraints += classesManagement_Click;
            eventConstraints(this, e);
        }

        private void studentManagementBt_MouseHover(object sender, EventArgs e)
        {
            studentManagementBt.BackColor = Color.LightPink;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            studentManagementUsC1.Visible = false;
            gradesManagement1.Visible = false;
            classesManagementUsC1.Visible = false;
            profileManagement1.Visible = true;
            button8.Enabled = false;
            button_WOC1.Enabled = false;
            List<object> diableObject = new List<object> { studentManagementBt, classesManagementBt, gradesManagementBt, label2, label3, label4, panel1, panel3, panel4 };
            OnDefaultColor(diableObject);
        }
        private void hideSt()
        {
            if(isShow==false)
            {
                roundedPictureBox2.Visible = false;
                button8.Visible = false;
                button_WOC1.Visible = true;
            }
            else
            {
                roundedPictureBox2.Visible = true;
                button8.Visible = true;
                button_WOC1.Visible = false;
                LoadProfileImg();
            }
        }
        bool isShow = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            if(MenuPanel.Width<=70)
            {
                isShow = true;
                
                timer1.Start();
                hideSt();

            }
            else if(MenuPanel.Width>=210)
            {
                isShow = false;
                
                timer1.Start();
                hideSt();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isShow==true)
            {
                if (MenuPanel.Width >= 140)
                {
                    pictureBox1.Location = new Point(204, 37);
                    timer1.Stop();
                }   
                MenuPanel.Width += 70;
                studentManagementBt.Width += 66;
                classesManagementBt.Width += 66;
                gradesManagementBt.Width += 66;
            }
            else
            {
                if (MenuPanel.Width <= 140)
                {
                    pictureBox1.Location = new Point(61, 37);
                    
                    timer1.Stop();
                }
                hideSt();
                MenuPanel.Width -= 70;
                studentManagementBt.Width -= 66;
                classesManagementBt.Width -= 66;
                gradesManagementBt.Width -= 66;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            gradesManagement1.Visible = false;
            classesManagementUsC1.Visible = false;
            profileManagement1.Visible = false;
            studentManagementUsC1.Enabled = true;
            studentManagementBt.Enabled = false;
            panel1.BackColor = Color.FromArgb(77, 197, 213);
            studentManagementBt.Enabled = false;
            label2.Enabled = false;
            MenuPanel.Width = 70;
            pictureBox1.Location = new Point(61, 37);
            hideSt();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
