using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.CodeDom;
using System.Security.AccessControl;

namespace Project_LTWindows
{
    public partial class GradesManagement : UserControl
    {
        public GradesManagement()
        {
            InitializeComponent();
            //transPanel.BackColor = Color.FromArgb(125, Color.Black);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void DisableControls()
        {
            var c = this.Controls;
            for (int i = 0; i < c.Count; i++)
            {
                c[i].Enabled = false;
            }

        }
        private void EnableControls()
        {
            var c = this.Controls;
            for (int i = 0; i < c.Count; i++)
            {
                c[i].Enabled = true;
            }
        }
        private void GradesManagement_Load(object sender, EventArgs e)
        {
            editByStDgV.Hide();
            transPanel.Visible = true;
            groupBox2.Enabled = false;
            editBySjRb.Checked = true;
            editByStIDControlsPn.Visible = false;
            editBySjDgV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 20, 76);
            editByStDgV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 20, 76);
            editBySjDgV.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 20, 76);
            editByStDgV.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 20, 76);
            editBySjDgV.EnableHeadersVisualStyles = false;
            editByStDgV.EnableHeadersVisualStyles = false;
            
            if(!this.DesignMode)
            {
                FormLoadBinding();
                Mediator.GetInstance().reloadPanel += (s, ev) =>
                {
                    var bt = (Button)s;
                    if(bt.Name== "gradesManagementBt")
                        FormLoadBinding();
                };
            }    
        }

        private void editBySjRb_Click(object sender, EventArgs e)
        {
            resetData();
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            editBySjRb.Checked = true;
            editByStRb.Checked = false;
            //editBySjDgV.Show();
            editByStDgV.Hide();
            transPanel.Show();
            editByStIDControlsPn.Hide();
            studentIDTb.Text = null;
        }


        private void editByStRb_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            editByStRb.Checked = true;
            editBySjRb.Checked = false;
            transPanel.Show();
            editByStDgV.Show();
            editByStIDControlsPn.Show();
            subjectNameCb.SelectedIndex = 0;
            classIDCb1.SelectedIndex = 0;
        }
        private void FormLoadBinding()
        {
            StMDBE stM = new StMDBE();
            var subjectList= stM.Subjects.ToList();
            Subject sj = new Subject { SubjectID = null, SubjectName = "Chọn môn học", Credit = null };
            subjectList.Insert(0, sj);
            subjectNameCb.DataSource = subjectList;
            subjectNameCb.DisplayMember = "SubjectName";
            var classList = stM.Classes.ToList();
            Class cl = new Class { ClassID = "ALL", ClassName = null, Lecturer = null, Department = null };
            classList.Insert(0, cl);
            classIDCb1.DataSource = classList;
            classIDCb1.DisplayMember = "ClassID";
            
        }
        private void editBySubjectName_DataBinding()
        {
            stIDTb_SjPn.DataBindings.Clear();
            stIDTb_SjPn.DataBindings.Add(new Binding("Text", editBySjDgV.DataSource, "StudentID"));
            sjNameTb_SjPn.DataBindings.Clear();
            sjNameTb_SjPn.DataBindings.Add(new Binding("Text", subjectNameCb.DataSource, "SubjectName"));
            clIDTb_SjPn.DataBindings.Clear();
            clIDTb_SjPn.DataBindings.Add(new Binding("Text", editBySjDgV.DataSource, "ClassID"));
            midTermGradeTb_SjPn.DataBindings.Clear();
            midTermGradeTb_SjPn.DataBindings.Add(new Binding("Text", editBySjDgV.DataSource, "Mid_term_Grade", true, DataSourceUpdateMode.Never));
            lastTermGradeTb_SjPn.DataBindings.Clear();
            lastTermGradeTb_SjPn.DataBindings.Add(new Binding("Text", editBySjDgV.DataSource, "Last_term_Grade", true, DataSourceUpdateMode.Never));
            finalGradeTb_SjPn.DataBindings.Clear();
            finalGradeTb_SjPn.DataBindings.Add(new Binding("Text", editBySjDgV.DataSource, "FinalGrade", true, DataSourceUpdateMode.Never));
        }
        private void subjectNameCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!this.DesignMode)
            {
                editBySubjectName_DgVBinding();
            }    
        }
        private void editBySubjectName_DgVBinding()
        {
            StMDBE stM = new StMDBE();
            Subject sj = (Subject)subjectNameCb.SelectedItem;
            if(sj.SubjectName!= "Chọn môn học")
            {
                midTermGradeTb_SjPn.Enabled = true;
                lastTermGradeTb_SjPn.Enabled = true;
                transPanel.Hide();
                classIDCb1.Enabled = true;
                var students = from st in stM.Grades where st.Subject.SubjectName == sj.SubjectName select new { StudentID = st.StudentID, ClassID = st.ClassID, Mid_term_Grade = st.Mid_term_Grade, Last_term_Grade = st.Last_term_Grade, FinalGrade = st.FinalGrade };
                var studentList = students.ToList();
                editBySjDgV.DataSource = studentList;
                
                editBySubjectName_DataBinding();
            }
            else
            {
                resetData();
                transPanel.Show();
                midTermGradeTb_SjPn.Enabled = false;
                lastTermGradeTb_SjPn.Enabled = false;
                classIDCb1.Enabled = false;
            }
        }
        private void resetData()
        {
            stIDTb_SjPn.Text = null;
            sjNameTb_SjPn.Text = null;
            clIDTb_SjPn.Text = null;
            midTermGradeTb_SjPn.Text = null;
            lastTermGradeTb_SjPn.Text = null;
            finalGradeTb_SjPn.Text = null;
        }
        private void classIDCb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!this.DesignMode)
            {
                editBySubjectNameAndClassID_DgVBinding();
            }
        }
        private void editBySubjectNameAndClassID_DgVBinding()
        {
            StMDBE stM = new StMDBE();
            Subject sj = (Subject)subjectNameCb.SelectedItem;
            Class cl = (Class)classIDCb1.SelectedItem;
            if(cl!=null)
            {
                if(cl.ClassID != "ALL")
                {
                    var classes = stM.Grades.Where(st => st.Subject.SubjectName == sj.SubjectName && st.ClassID == cl.ClassID).Select(st => new { StudentID = st.StudentID, ClassID = st.ClassID, Mid_term_Grade = st.Mid_term_Grade, Last_term_Grade = st.Last_term_Grade, FinalGrade = st.FinalGrade });
                    var studentList = classes.ToList();
                    editBySjDgV.DataSource = studentList;
                    editBySubjectName_DataBinding();
                }
                else
                {
                    editBySubjectName_DgVBinding();
                }
            }
        }
        private void searchStudentID()
        {
            StMDBE stM = new StMDBE();
            string s = studentIDTb.Text;
            var subjects = from sj in stM.Grades where sj.StudentID == s select new { SubjectID = sj.SubjectID, SubjectName=sj.Subject.SubjectName, Mid_term_Grade = sj.Mid_term_Grade, Last_term_Grade = sj.Last_term_Grade, FinalGrade = sj.FinalGrade };
            if (subjects != null && subjects.Count() > 0)
            {
                var subjectList = subjects.ToList();
                editByStDgV.DataSource = subjectList;
                editByStIDControlsPn_DataBinding();
            }
            else
                MessageBox.Show("Không tìm thấy mã sinh viên");
        }
        private void editByStIDControlsPn_DataBinding()
        {
            StMDBE stM = new StMDBE();
            stIDTb_StPn.Text = studentIDTb.Text;
            var info = stM.Grades.Where(i => i.StudentID == studentIDTb.Text).GroupBy(i => i.StudentID).Select(i => i);
            sjNameTb_StPn.DataBindings.Clear();
            sjNameTb_StPn.DataBindings.Add(new Binding("Text", editByStDgV.DataSource, "SubjectName"));
            foreach(var variable in info)
            {
                foreach (var item in variable)
                    clIDTb_StPn.Text = item.ClassID;
            }
            midTermGradeTb_StPn.DataBindings.Clear();
            midTermGradeTb_StPn.DataBindings.Add(new Binding("Text", editByStDgV.DataSource, "Mid_term_Grade", true, DataSourceUpdateMode.Never));
            lastTermGradeTb_StPn.DataBindings.Clear();
            lastTermGradeTb_StPn.DataBindings.Add(new Binding("Text", editByStDgV.DataSource, "Last_term_Grade", true, DataSourceUpdateMode.Never));
            finalGradeTb_StPn.DataBindings.Clear();
            finalGradeTb_StPn.DataBindings.Add(new Binding("Text", editByStDgV.DataSource, "FinalGrade", true, DataSourceUpdateMode.Never));
        }
        private void searchBt_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                searchStudentID();  
            }    
                
        }

        private void calculateBt_SjPn_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
                calculateFinalGrade_SjPn();
        }
        private void calculateFinalGrade_SjPn()
        {
            if(!string.IsNullOrWhiteSpace(midTermGradeTb_SjPn.Text) && !string.IsNullOrWhiteSpace(lastTermGradeTb_SjPn.Text))
            {
                double mid_term_grade = Convert.ToDouble(midTermGradeTb_SjPn.Text);
                double last_term_grade = Convert.ToDouble(lastTermGradeTb_SjPn.Text);
                double final_grade = (mid_term_grade * 40) / 100 + (last_term_grade * 60) / 100;
                finalGradeTb_SjPn.Text = Convert.ToString(final_grade);
            }
        }

        private void saveBt_SjPn_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
                SavevGrade_SjPn();
        }
        private void SavevGrade_SjPn()
        {
            StMDBE stM = new StMDBE();
            var student = stM.Grades.Where(st => st.StudentID == stIDTb_SjPn.Text && st.Subject.SubjectName == sjNameTb_SjPn.Text).SingleOrDefault();
            if(!string.IsNullOrWhiteSpace(midTermGradeTb_SjPn.Text))
                student.Mid_term_Grade = Convert.ToDouble(midTermGradeTb_SjPn.Text);
            if (!string.IsNullOrWhiteSpace(lastTermGradeTb_SjPn.Text))
                student.Last_term_Grade = Convert.ToDouble(lastTermGradeTb_SjPn.Text);
            if (!string.IsNullOrWhiteSpace(finalGradeTb_SjPn.Text))
                student.FinalGrade = Convert.ToDouble(finalGradeTb_SjPn.Text);
            stM.SaveChanges();
            editBySubjectName_DgVBinding();
            editBySubjectNameAndClassID_DgVBinding();
        }

        private void resetBt_SjPn_Click(object sender, EventArgs e)
        {
            midTermGradeTb_SjPn.Text = null;
            lastTermGradeTb_SjPn.Text = null;
            finalGradeTb_SjPn.Text = null;
        }

        private void calculateBt_StPn_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
                calculateFinalGrade_StPn();
        }
        private void calculateFinalGrade_StPn()
        {
            if (!string.IsNullOrWhiteSpace(midTermGradeTb_StPn.Text) && !string.IsNullOrWhiteSpace(lastTermGradeTb_StPn.Text))
            {
                double mid_term_grade = Convert.ToDouble(midTermGradeTb_StPn.Text);
                double last_term_grade = Convert.ToDouble(lastTermGradeTb_StPn.Text);
                double final_grade = (mid_term_grade * 40) / 100 + (last_term_grade * 60) / 100;
                finalGradeTb_StPn.Text = Convert.ToString(final_grade);
            }
        }

        private void saveBt_StPn_Click(object sender, EventArgs e)
        {
            if(!this.DesignMode)
                SaveGrade_StPn();
        }
        private void SaveGrade_StPn()
        {
            StMDBE stM = new StMDBE();
            var student = stM.Grades.Where(st => st.StudentID == stIDTb_StPn.Text && st.Subject.SubjectName == sjNameTb_StPn.Text).SingleOrDefault();
            if (!string.IsNullOrWhiteSpace(midTermGradeTb_StPn.Text))
                student.Mid_term_Grade = Convert.ToDouble(midTermGradeTb_StPn.Text);
            else
                student.Mid_term_Grade = 0;
            if (!string.IsNullOrWhiteSpace(lastTermGradeTb_StPn.Text))
                student.Last_term_Grade = Convert.ToDouble(lastTermGradeTb_StPn.Text);
            else
                student.Last_term_Grade = 0;
            if (!string.IsNullOrWhiteSpace(finalGradeTb_StPn.Text))
                student.FinalGrade = Convert.ToDouble(finalGradeTb_StPn.Text);
            else
                student.FinalGrade = 0;
            stM.SaveChanges();
            searchStudentID();
            //editByStIDControlsPn_DataBinding();
        }

        private void resetBt_StPn_Click(object sender, EventArgs e)
        {
            midTermGradeTb_StPn.Text = null;
            lastTermGradeTb_StPn.Text = null;
            finalGradeTb_StPn.Text = null;
        }
        
        private void editByStIDControlsPn_Paint(object sender, PaintEventArgs e)
        {
            //var c = this.Controls;
            //List<TextBox> textBoxes = new List<TextBox>();
            //foreach (var item in c)
            //{
            //    if (item is TextBox)
            //    {
            //        textBoxes.Add((TextBox)item);
            //    }

            //}
            //foreach (var item in textBoxes)
            //{

            //}
            
        }
    }
}
