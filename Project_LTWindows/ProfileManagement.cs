using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_LTWindows
{
    public partial class ProfileManagement : UserControl
    {
        public ProfileManagement()
        {
            InitializeComponent();
        }
        private void ProfileManagement_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                LoadImage();
                LoadData();
            }    
                
        }
        private void LoadImage()
        {
            StMDBE stM = new StMDBE();
            //Mediator.GetInstance().login = null;
            Mediator.GetInstance().login += (s, e) =>
            {
                var profileImage = stM.ProfileImages.Where(p => p.FacultyID == e).SingleOrDefault();
                if (profileImage.ProfileImage1 != null)
                {
                    Image img = bytesToImage(profileImage.ProfileImage1);
                    profilePb.Image = img;
                }
                else
                {
                    string path = "icons8-customer-256.png";
                    profilePb.ImageLocation = path;
                }
            };
        }
        private void LoadData()
        {
            StMDBE stM = new StMDBE();
            Mediator.GetInstance().login += (s, e) =>
            {
                var faculty = stM.FacultyLogins.Where(f => f.FacultyID == e).SingleOrDefault();
                if (faculty != null)
                {
                    facultyIDTb.Text = Convert.ToString(faculty.FacultyID);
                    facultyNameTb.Text = faculty.FacultyName;
                    passwordTb.Text = faculty.Password;
                    jobTitleTb.Text = faculty.JobTitle;
                    emailTb.Text = faculty.Email;
                    phoneTb.Text = Convert.ToString(faculty.Phone);
                }
            };
        }
        private void changeProfilePBt_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                profilePb.Image = new Bitmap(open.FileName);
                string s = open.FileName;
                if (!this.DesignMode)
                {
                    StMDBE stM = new StMDBE();
                    int id = Convert.ToInt32(facultyIDTb.Text + "001");
                    var imageToByte = ImageToByteArray(profilePb.Image);
                    int facultyID = Convert.ToInt32(facultyIDTb.Text);
                    var faculty = stM.ProfileImages.Where(f => f.FacultyID == facultyID).SingleOrDefault();
                    faculty.ProfileImage1 = imageToByte;
                    stM.SaveChanges();
                }
            }
        }
        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        private Image bytesToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }

        
        private FacultyLogin getFaculty()
        {
            StMDBE stM = new StMDBE();
            int facultyID = Convert.ToInt32(facultyIDTb.Text);
            var faculty = stM.FacultyLogins.Where(f => f.FacultyID == facultyID).SingleOrDefault();
            if (faculty != null)
                return faculty;
            return null;
        }
        private event EventHandler<EventArgs> action;
        private event EventHandler<EventArgs> clicked;
        private void facultyNameLb_Click(object sender, EventArgs e)
        {
            facultyNameTb.Enabled = true;
            facultyNameLb.BackColor = Color.FromArgb(235, 20, 76);
            facultyIDTb.SelectAll();
            if (!this.DesignMode)
            {
                action += (s, ev) =>
                {
                    FacultyLogin faculty = getFaculty();
                    if (faculty != null)
                    {
                        faculty.FacultyName = facultyNameTb.Text;
                    }    
                };
                  
            }    
        }

        private void jobTitleLb_Click(object sender, EventArgs e)
        {
            jobTitleTb.Enabled = true;
            jobTitleLb.BackColor = Color.FromArgb(235, 20, 76);
            jobTitleTb.SelectAll();
            if (!this.DesignMode)
            {
                action += (s, ev) =>
                {
                    FacultyLogin faculty = getFaculty();
                    if (faculty != null)
                    {
                        faculty.JobTitle = jobTitleTb.Text;
                    }
                };

            }
        }

        private void passwordLb_Click(object sender, EventArgs e)
        {
            passwordTb.Enabled = true;
            passwordLb.BackColor = Color.FromArgb(235, 20, 76);
            passwordTb.SelectAll();
            
            if (!this.DesignMode)
            {
                action += (s, ev) =>
                {
                    FacultyLogin faculty = getFaculty();
                    if (faculty != null)
                    {
                        faculty.Password = passwordTb.Text;
                    }
                };

            }
        }

        private void emailLb_Click(object sender, EventArgs e)
        {
            emailTb.Enabled = true;
            emailLb.BackColor = Color.FromArgb(235, 20, 76);
            emailTb.SelectAll();
            if (!this.DesignMode)
            {
                action += (s, ev) =>
                {
                    FacultyLogin faculty = getFaculty();
                    if (faculty != null)
                    {
                        faculty.Email = emailTb.Text;
                    }
                };

            }
        }

        private void phoneLb_Click(object sender, EventArgs e)
        {
            phoneTb.Enabled = true;
            phoneLb.BackColor = Color.FromArgb(235, 20, 76);
            clicked += phoneTb_Click;
            if (!this.DesignMode)
            {
                action += (s, ev) =>
                {
                    FacultyLogin faculty = getFaculty();
                    if (faculty != null)
                    {
                        faculty.Phone = Convert.ToInt32(phoneTb.Text);
                    }
                };

            }
        }

        private void saevBt_Click(object sender, EventArgs e)
        {
            action(this, e);
        }

        

        private void phoneTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneTb_Click(object sender, EventArgs e)
        {
            phoneTb.SelectAll();
        }
    }
}
