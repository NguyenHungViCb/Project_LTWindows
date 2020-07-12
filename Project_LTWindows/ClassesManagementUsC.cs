using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_LTWindows
{
    public partial class ClassesManagementUsC : UserControl
    {
        public ClassesManagementUsC()
        {
            InitializeComponent();
        }
        private EventHandler<EventArgs> changeColor;
        private void OnChangeColor(object sender, EventArgs e)
        {
            if (saveBt.Enabled == false)
            {
                saveBt.ButtonColor = Color.LightPink;
            }
            else
                saveBt.ButtonColor = Color.FromArgb(235, 20, 76);
        }
        private void ClassesManagementUsC_Load(object sender, EventArgs e)
        {
            
            if(!this.DesignMode)
            {

                Mediator.GetInstance().reloadPanel += (s, ev) =>
                {
                    LoadFormBinding();
                    LoadDgV();
                };
                classDgV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 20, 76);
                classDgV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                classDgV.EnableHeadersVisualStyles = false;
                DefaultDisable();
                LoadFormBinding();
                LoadDgV();
                changeColor += OnChangeColor;
                saveBt.Enabled = false;
                changeColor(this, e);
            }    
        }
        private void LoadFormBinding()
        {
            StMDBE stM = new StMDBE();
            var classList = stM.Classes.ToList();
            Class all = new Class { ClassID = "ALL", ClassName = null, Department = null, DepartmentID = null, Lecturer = null, Students = null };
            classList.Insert(0, all);
            classIDCb.DataSource = classList;
            classIDCb.DisplayMember = "ClassID";
        }
        private void DefaultDisable()
        {
            classIDTb.Enabled = false;
            classNameTb.Enabled = false;
            lecturerTb.Enabled = false;
            departmentNameCb.Enabled = false;
            studentCountTb.Enabled = false;
        }
        private void DefaultEnable()
        {
            classIDTb.Enabled = true;
            classNameTb.Enabled = true;
            lecturerTb.Enabled = true;
            departmentNameCb.Enabled = true;
            studentCountTb.Enabled = true;
        }
        
        private void LoadDgV()
        {
            StMDBE stM = new StMDBE();
            Class selectedClass = (Class)classIDCb.SelectedItem;
            var _class = from cl in stM.Classes
                    join st in stM.Students on cl.ClassID equals st.ClassID into classes
                    select new
                    {
                        ClassID = cl.ClassID,
                        ClassName = cl.ClassName,
                        Lecturer = cl.Lecturer,
                        DepartmentName = cl.Department.DepartmentName,
                        StudentCount = classes.Count()
                    };
            classDgV.DataSource = _class.ToList();
            DataBinding();
        }
        private void DataBinding()
        {
            StMDBE stM = new StMDBE();
            classIDTb.DataBindings.Clear();
            classIDTb.DataBindings.Add(new Binding("Text", classDgV.DataSource, "ClassID"));
            classNameTb.DataBindings.Clear();
            classNameTb.DataBindings.Add(new Binding("Text", classDgV.DataSource, "ClassName"));
            lecturerTb.DataBindings.Clear();
            lecturerTb.DataBindings.Add(new Binding("Text", classDgV.DataSource, "Lecturer"));
            departmentNameCb.DataSource = stM.Departments.ToList();
            departmentNameCb.DisplayMember = "DepartmentName";
            departmentNameCb.DataBindings.Clear();
            departmentNameCb.DataBindings.Add(new Binding("Text", classDgV.DataSource, "DepartmentName"));
            studentCountTb.DataBindings.Clear();
            studentCountTb.DataBindings.Add(new Binding("Text", classDgV.DataSource, "StudentCount"));
        }

        private void classIDCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.DesignMode)
                selectedItem();
        }
        private void selectedItem()
        {
            
            Class selectedClass = (Class)classIDCb.SelectedItem;
            if (selectedClass.ClassID != "ALL")
            {
                StMDBE stM = new StMDBE();
                var _class = from cl in stM.Classes
                             join st in stM.Students on cl.ClassID equals st.ClassID into classes
                             where cl.ClassID == selectedClass.ClassID
                             select new
                             {
                                 ClassID = cl.ClassID,
                                 ClassName = cl.ClassName,
                                 Lecturer = cl.Lecturer,
                                 DepartmentName = cl.Department.DepartmentName,
                                 StudentCount = classes.Count()
                             };
                classDgV.DataSource = _class.ToList();
                DataBinding();
            }
            else
                LoadDgV();
        }
        private void resetBt_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
                ResetData();
        }
        private void ResetData()
        {
            classIDTb.Text = null;
            classNameTb.Text = null;
            departmentNameCb.SelectedIndex = 0;
            lecturerTb.Text = null;
            studentCountTb.Text = null;
        }
        private EventHandler<EventArgs> action;
        private void addBt_Click(object sender, EventArgs e)
        {
            addBt.Enabled = false;
            deleteBt.Enabled = false;
            updateBt.Enabled = false;
            saveBt.Enabled = true;
            addBt.ButtonColor = Color.LightPink;
            deleteBt.ButtonColor = Color.LightPink;
            updateBt.ButtonColor = Color.LightPink;
            changeColor(this, e);
            ResetData();
            DefaultEnable();
            studentCountTb.Enabled = false;
            action = null;
            action += addClass;
        }
        private void addClass(object sender, EventArgs e)
        {
            var choice=MessageBox.Show("Xác nhận thêm lớp học?", "Warning", MessageBoxButtons.YesNo);
            if(DialogResult.Yes==choice)
            {
                StMDBE StM = new StMDBE();
                var _class = StM.Classes.Where(c => c.ClassID == classIDTb.Text).SingleOrDefault();
                if (_class == null)
                {
                    Department d = (Department)departmentNameCb.SelectedItem;
                    if (!string.IsNullOrWhiteSpace(classIDTb.Text))
                    {
                        Class c = new Class { ClassID = classIDTb.Text, ClassName = classNameTb.Text, Lecturer = lecturerTb.Text, DepartmentID = d.DepartmentID };
                        StM.Classes.Add(c);
                        StM.SaveChanges();
                        MessageBox.Show("dữ liệu đã được cập nhật");
                        LoadFormBinding();
                        LoadDgV();
                        //Mediator.GetInstance().reloadPanel += ClassesManagementUsC_Load;
                    }
                    else
                        MessageBox.Show("Mã lớp học không được để trống");
                }
                else
                    MessageBox.Show("Mã lớp học đã tồn tại trong cơ sở dữ liệu");
            }    
        }
        private void deleteBt_Click(object sender, EventArgs e)
        {
            DefaultDisable();
            if (!this.DesignMode)
            {
                var choice = MessageBox.Show("Xác nhận xoá lớp học?", "Warning", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == choice)
                {
                    saveBt.Enabled = true;
                    changeColor(this, e);
                    MessageBox.Show("Nhấn lưu để xác nhận thay đổi");
                    action = null;
                    action += deleteClass;
                    
                }
                
            }    
        }
        private void deleteClass(object sender, EventArgs e)
        {
            StMDBE StM = new StMDBE();
            var _class = StM.Classes.Where(c => c.ClassID == classIDTb.Text).SingleOrDefault();
            var student = StM.Students.Where(st => st.ClassID == classIDTb.Text).SingleOrDefault();
            if(student!=null)
            {
                var grade = from gr in StM.Grades where gr.StudentID == student.StudentID select gr;
                if (grade != null)
                {
                    var gradeList = grade.ToList();
                    if (student != null)
                    {
                        foreach (var variable in gradeList)
                        {
                            StM.Grades.Remove(variable);
                        }
                        StM.Students.Remove(student);
                        StM.SaveChanges();
                    }
                }
            }
            StM.Classes.Remove(_class);
            StM.SaveChanges();
            LoadDgV();
            LoadFormBinding();
            MessageBox.Show("Dữ liệu đã được cập nhật");
            saveBt.Enabled = false;
        }
        private void updateBt_Click(object sender, EventArgs e)
        {
            DefaultEnable();
            classIDTb.Enabled = false;
            studentCountTb.Enabled = false;
            saveBt.Enabled = true;
            changeColor(this, e);
            addBt.Enabled = false;
            addBt.ButtonColor = Color.LightPink;
            deleteBt.Enabled = false;
            deleteBt.ButtonColor = Color.LightPink;
            updateBt.Enabled = false;
            updateBt.ButtonColor = Color.LightPink;
            action = null;
            action += updateClass;
        }
        private void updateClass(object sender, EventArgs e)
        {
            StMDBE StM = new StMDBE();
            Class _class = StM.Classes.Where(c => c.ClassID == classIDTb.Text).SingleOrDefault();
            if (_class != null)
            {
                //var student = from st in StM.Students where st.ClassID == _class.ClassID select st;
                _class.ClassID = classIDTb.Text;
                _class.ClassName = classNameTb.Text;
                _class.Lecturer = lecturerTb.Text;
                Department d = (Department)departmentNameCb.SelectedItem;
                _class.DepartmentID = d.DepartmentID;
                StM.SaveChanges();
                LoadDgV();
                MessageBox.Show("Dữ liệu đã được cập nhật");
                
                
            }
        }
        private void saveBt_Click(object sender, EventArgs e)
        {
            action(this, e);
            //Mediator.GetInstance().OnReloadPanel(this, e);
        }

        private void classDgV_Click(object sender, EventArgs e)
        {
            DefaultDisable();
            DataBinding();
            addBt.Enabled = true;
            deleteBt.Enabled = true;
            updateBt.Enabled = true;
            saveBt.Enabled = false;
            addBt.ButtonColor = Color.FromArgb(235, 20, 76);
            deleteBt.ButtonColor = Color.FromArgb(235,20,76);
            updateBt.ButtonColor = Color.FromArgb(235,20,76);
            changeColor(this, e);
        }

        
    }
}
