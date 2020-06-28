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
    
    public partial class StudentManagementUsC : UserControl
    {
        public StudentManagementUsC()
        {
            InitializeComponent();
            
        }
        
        private void StudentManagementUsC_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                LoadGridView();
                birthPicker.CustomFormat = "MMM-dd-yyyy";
                birthPicker.Format = DateTimePickerFormat.Custom;
                searchStIDTb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                searchStIDTb.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //DefaultDisable();
            }
        }
        private void LoadGridView()
        {            
            StMDBE stM = new StMDBE();
            var _students = from st in stM.Students select new { StudentID = st.StudentID, LastName = st.LastName, FirstName = st.FirstName, Sex = st.Sex, Birth = st.Birth, Address = st.Address, ClassName = st.Class.ClassName, DepartmentName = st.Class.Department.DepartmentName };
            StudentDGrv.DataSource = _students.ToList();
            bindData();
        }
        private void bindData()
        {
            StMDBE stM = new StMDBE();
            studentIDTb.DataBindings.Clear();
            studentIDTb.DataBindings.Add(new Binding("Text", StudentDGrv.DataSource, "StudentID"));
            lastNameTb.DataBindings.Clear();
            lastNameTb.DataBindings.Add(new Binding("Text", StudentDGrv.DataSource, "LastName"));
            firstNameTb.DataBindings.Clear();
            firstNameTb.DataBindings.Add(new Binding("Text", StudentDGrv.DataSource, "FirstName"));
            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", StudentDGrv.DataSource, "Sex");
            birthPicker.DataBindings.Clear();
            birthPicker.DataBindings.Add("Value", StudentDGrv.DataSource, "Birth");
            addressTb.DataBindings.Clear();
            addressTb.DataBindings.Add(new Binding("Text", StudentDGrv.DataSource, "Address"));
            classNameCb.DataSource = stM.Classes.ToList();
            classNameCb.DisplayMember = "ClassName";
            classNameCb.DataBindings.Clear();
            classNameCb.DataBindings.Add(new Binding("Text", StudentDGrv.DataSource, "ClassName"));
            departmentNameCb.DataSource = stM.Departments.ToList();
            departmentNameCb.DisplayMember = "DepartmentName";
            departmentNameCb.DataBindings.Clear();
            departmentNameCb.DataBindings.Add(new Binding("Text", StudentDGrv.DataSource, "DepartmentName"));
            Class allClass = new Class { ClassID = null, ClassName = "ALL", Department = null, DepartmentID = null, Lecturer = null, Students = null }; 
            var classList= stM.Classes.ToList();
            classList.Insert(0, allClass);
            searchClassCb.DataSource = classList;
            searchClassCb.DisplayMember = "ClassName";
            //searchClassCb.DataBindings.Clear();
            //searchClassCb.DataBindings.Add(new Binding("Text", StudentDGrv.DataSource, "ClassName"));
            Department allDepartment = new Department { DepartmentID = null, DepartmentName = "ALL" };
            var departmentList = stM.Departments.ToList();
            departmentList.Insert(0, allDepartment);
            searchDepartmentCb.DataSource = departmentList;
            searchDepartmentCb.DisplayMember = "DepartmentName";
            //searchDepartmentCb.DataBindings.Clear();
            //searchDepartmentCb.DataBindings.Add(new Binding("Text", StudentDGrv.DataSource, "DepartmentName"));
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
        private void DefaultDisable()
        {
            studentIDTb.Enabled = false;
            lastNameTb.Enabled = false;
            firstNameTb.Enabled = false;
            maleRb.Enabled = false;
            femaleRb.Enabled = false;
            birthPicker.Enabled = false;
            addressTb.Enabled = false;
            classNameCb.Enabled = false;
            departmentNameCb.Enabled = false;

        }
        private void DefaultEnable()
        {
            studentIDTb.Enabled = true;
            lastNameTb.Enabled = true;
            firstNameTb.Enabled = true;
            maleRb.Enabled = true;
            femaleRb.Enabled = true;
            birthPicker.Enabled = true;
            addressTb.Enabled = true;
            classNameCb.Enabled = true;
            departmentNameCb.Enabled = true;

        }
        private void addBt_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                //DefaultEnable();
                var yes = MessageBox.Show("Xác nhận thêm sinh viên?", "", MessageBoxButtons.YesNo);
                StMDBE addDBE = new StMDBE();
                if (!string.IsNullOrEmpty(studentIDTb.Text) && yes==DialogResult.Yes)
                {
                    var _student = addDBE.Students.Where(st => st.StudentID == studentIDTb.Text).SingleOrDefault();
                    if (_student == null)
                    {
                        Student item = new Student();
                        item.StudentID = studentIDTb.Text;
                        item.LastName = lastNameTb.Text;
                        item.FirstName = firstNameTb.Text;
                        if (maleRb.Checked == true)
                        {
                            item.Sex = "Nam";
                        }
                        else if (femaleRb.Checked == true)
                        {
                            item.Sex = "Nữ";
                        }
                        item.Birth = birthPicker.Value;
                        item.Address = addressTb.Text;
                        Class cl = (Class)classNameCb.SelectedItem;
                        string className = cl.ClassName;
                        var _Class = from c in addDBE.Classes where c.ClassName == className select c;
                        bool validate = true;
                        Department d = (Department)departmentNameCb.SelectedItem;
                        string departmentName = d.DepartmentName;
                        foreach (var variable in _Class)
                        {
                            if (variable.Department.DepartmentName != departmentName)
                            {
                                MessageBox.Show("dữ liệu nhập vào không chính xác, kiểm tra lại tên lớp và tên khoa", "Error", MessageBoxButtons.OK);
                                validate = false;
                            }
                            else
                                item.ClassID = variable.ClassID;
                        }
                        if (validate == true)
                        {

                            addDBE.Students.Add(item);
                            //LoadGridView();
                            addDBE.SaveChanges();
                            MessageBox.Show("dữ liệu đã được thêm vào");
                        }
                        LoadGridView();
                    }
                    else
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại trong cơ sở dữ liệu", "Error", MessageBoxButtons.OK);
                    }

                }
                else if (string.IsNullOrEmpty(studentIDTb.Text))
                {
                    MessageBox.Show("Mã sinh viên không được để trống");
                }
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nam")
                maleRb.Checked = true;
            else
                femaleRb.Checked = true;
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            DisableControls();
            if (!this.DesignMode)
            {
                var choose = MessageBox.Show("xác nhân xoá sinh viên?", "Warning", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == choose)
                {
                    StMDBE dellDBE = new StMDBE();
                    string StudentID = studentIDTb.Text;
                    Student st = dellDBE.Students.Where(s => s.StudentID == StudentID).SingleOrDefault();
                    if (st != null)
                    {
                        dellDBE.Students.Remove(st);
                        dellDBE.SaveChanges();
                        MessageBox.Show("Dữ liệu đã được cập nhật", "Success", MessageBoxButtons.OK);
                        LoadGridView();
                    }
                    else
                        MessageBox.Show("Không tìm thấy mã sinh viên, vui lòng kiểm tra lại dữ liệu", "Error", MessageBoxButtons.OK);
                    EnableControls();
                }
                else
                    EnableControls();
            }    
        }

        private void updateBt_Click(object sender, EventArgs e)
        {

            if(!this.DesignMode)
            {
                DisableControls();
                var confirm = MessageBox.Show("xác nhận lưu thay đổi?", "", MessageBoxButtons.YesNo);
                StMDBE updateDBE = new StMDBE();
                if (confirm == DialogResult.Yes)
                {
                    bool validate = false;
                    Class _class = new Class();
                    _class = (Class)classNameCb.SelectedItem;
                    string className = _class.ClassName;
                    
                    Department _department = new Department();
                    _department = (Department)departmentNameCb.SelectedItem;
                    string departmentName = _department.DepartmentName;
                    string StudentID = studentIDTb.Text;
                    Student st = updateDBE.Students.Where(s => s.StudentID == StudentID).SingleOrDefault();
                    if (st != null)
                    {
                        st.LastName = lastNameTb.Text;
                        st.FirstName = firstNameTb.Text;
                        st.Address = addressTb.Text;
                        st.Birth = birthPicker.Value;
                        if (maleRb.Checked == true)
                        {
                            if (st.Sex != "Nam")
                            {
                                MessageBox.Show("Không thể thay đổi giới tính");
                                femaleRb.Checked = true;
                                validate = false;
                            }

                        }
                        else if (femaleRb.Checked == true)
                        {
                            if (st.Sex != "Nữ")
                            {
                                MessageBox.Show("Không thể thay đổi giới tính");
                                maleRb.Checked = true;
                                validate = false;
                            }

                        }
                        var ClassOrDepartmentChange = from c in updateDBE.Classes where c.ClassName == className select c;

                        foreach (var variable in ClassOrDepartmentChange)
                        {
                            if (variable.Department.DepartmentName == departmentName)
                            {
                                st.ClassID = variable.ClassID;
                                validate = true;
                            }
                            else
                                MessageBox.Show("dữ liệu nhập vào không chính xác, kiểm tra lại tên lớp và tên khoa", "Error", MessageBoxButtons.OK);
                        }
                        if (ClassOrDepartmentChange != null && validate == true)
                        {
                            updateDBE.SaveChanges();
                            MessageBox.Show("Dữ liệu đã được cập nhật");
                            LoadGridView();
                        }
                    }
                    else
                        MessageBox.Show("Không tim thây ma sinh vien");
                }
                EnableControls();
            }    
        }

        private void searchStIDTb_TextChanged(object sender, EventArgs e)
        {
            if(!this.DesignMode)
            {
                
                StMDBE stM = new StMDBE();
                var _students = from st in stM.Students select new { StudentID = st.StudentID, LastName = st.LastName, FirstName = st.FirstName, Sex = st.Sex, Birth = st.Birth, Address = st.Address, ClassName = st.Class.ClassName, DepartmentName = st.Class.Department.DepartmentName };
                var studentList = _students.ToList();
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                foreach(var variable in studentList)
                {
                    col.Add(variable.StudentID);
                }
                textBox1.AutoCompleteCustomSource = col;
                var t = studentList.Where(st => st.StudentID.Contains(searchStIDTb.Text) || st.StudentID == searchStIDTb.Text).Select(st => st);
                var l = t.ToList();
                StudentDGrv.DataSource = l;
            }    
        }

        private void searchStNameTb_TextChanged(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                StMDBE stM = new StMDBE();
                var _students = from st in stM.Students select new { StudentID = st.StudentID, LastName = st.LastName, FirstName = st.FirstName, Sex = st.Sex, Birth = st.Birth, Address = st.Address, ClassName = st.Class.ClassName, DepartmentName = st.Class.Department.DepartmentName };
                var studentList = _students.ToList();
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                foreach (var variable in studentList)
                {
                    col.Add(variable.StudentID);
                }
                textBox1.AutoCompleteCustomSource = col;
                var t = studentList.Where(st =>st.LastName.Contains(searchStNameTb.Text) || st.LastName==searchStNameTb.Text || st.FirstName.Contains(searchStNameTb.Text) || st.FirstName == searchStNameTb.Text).Select(st => st);
                var l = t.ToList();
                StudentDGrv.DataSource = l;
            }
        }


        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void searchClassCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                Class selectedClass = (Class)searchClassCb.SelectedItem;
                string _className = selectedClass.ClassName;
                if (_className != "ALL")
                {
                    StMDBE stM = new StMDBE();
                    var _students = from st in stM.Students select new { StudentID = st.StudentID, LastName = st.LastName, FirstName = st.FirstName, Sex = st.Sex, Birth = st.Birth, Address = st.Address, ClassName = st.Class.ClassName, DepartmentName = st.Class.Department.DepartmentName };
                    var studentList = _students.ToList();

                    var t = studentList.Where(st => st.ClassName == _className).Select(st => st);
                    var l = t.ToList();
                    StudentDGrv.DataSource = l;
                }
                else
                    LoadGridView();
            }
        }

        private void searchDepartmentCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                Department selectedDepartment = (Department)searchDepartmentCb.SelectedItem;
                string _departmentName = selectedDepartment.DepartmentName;
                if (_departmentName != "ALL")
                {
                    StMDBE stM = new StMDBE();
                    var _students = from st in stM.Students select new { StudentID = st.StudentID, LastName = st.LastName, FirstName = st.FirstName, Sex = st.Sex, Birth = st.Birth, Address = st.Address, ClassName = st.Class.ClassName, DepartmentName = st.Class.Department.DepartmentName };
                    var studentList = _students.ToList();
                    var t = studentList.Where(st => st.DepartmentName == _departmentName).Select(st => st);
                    var l = t.ToList();
                    StudentDGrv.DataSource = l;
                }
                else
                    LoadGridView();
            }
        }
    }
}
