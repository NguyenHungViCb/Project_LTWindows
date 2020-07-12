namespace Project_LTWindows
{
    partial class StudentManagementUsC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.departmentNameCb = new System.Windows.Forms.ComboBox();
            this.classNameCb = new System.Windows.Forms.ComboBox();
            this.addressTb = new System.Windows.Forms.TextBox();
            this.birthPicker = new System.Windows.Forms.DateTimePicker();
            this.femaleRb = new System.Windows.Forms.RadioButton();
            this.maleRb = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameTb = new System.Windows.Forms.TextBox();
            this.lastNameTb = new System.Windows.Forms.TextBox();
            this.studentIDTb = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchStNameTb = new System.Windows.Forms.TextBox();
            this.searchStIDTb = new System.Windows.Forms.TextBox();
            this.StudentDGrv = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.searchDepartmentCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.searchClassCb = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.updateBt = new ePOSOne.btnProduct.Button_WOC();
            this.resetBt = new ePOSOne.btnProduct.Button_WOC();
            this.SaveBt = new ePOSOne.btnProduct.Button_WOC();
            this.deleteBt = new ePOSOne.btnProduct.Button_WOC();
            this.addBt = new ePOSOne.btnProduct.Button_WOC();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDGrv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 59);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(693, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Metrophobic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.label5.Location = new System.Drawing.Point(287, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 42);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quản lý sinh viên";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.updateBt);
            this.panel2.Controls.Add(this.resetBt);
            this.panel2.Controls.Add(this.SaveBt);
            this.panel2.Controls.Add(this.deleteBt);
            this.panel2.Controls.Add(this.addBt);
            this.panel2.Controls.Add(this.departmentNameCb);
            this.panel2.Controls.Add(this.classNameCb);
            this.panel2.Controls.Add(this.addressTb);
            this.panel2.Controls.Add(this.birthPicker);
            this.panel2.Controls.Add(this.femaleRb);
            this.panel2.Controls.Add(this.maleRb);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.firstNameTb);
            this.panel2.Controls.Add(this.lastNameTb);
            this.panel2.Controls.Add(this.studentIDTb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(556, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 408);
            this.panel2.TabIndex = 1;
            // 
            // departmentNameCb
            // 
            this.departmentNameCb.BackColor = System.Drawing.Color.White;
            this.departmentNameCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentNameCb.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentNameCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.departmentNameCb.FormattingEnabled = true;
            this.departmentNameCb.Location = new System.Drawing.Point(110, 274);
            this.departmentNameCb.Name = "departmentNameCb";
            this.departmentNameCb.Size = new System.Drawing.Size(137, 28);
            this.departmentNameCb.TabIndex = 8;
            // 
            // classNameCb
            // 
            this.classNameCb.BackColor = System.Drawing.Color.White;
            this.classNameCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classNameCb.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classNameCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.classNameCb.FormattingEnabled = true;
            this.classNameCb.Location = new System.Drawing.Point(110, 237);
            this.classNameCb.Name = "classNameCb";
            this.classNameCb.Size = new System.Drawing.Size(137, 28);
            this.classNameCb.TabIndex = 7;
            // 
            // addressTb
            // 
            this.addressTb.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTb.Location = new System.Drawing.Point(110, 202);
            this.addressTb.Name = "addressTb";
            this.addressTb.Size = new System.Drawing.Size(137, 24);
            this.addressTb.TabIndex = 6;
            // 
            // birthPicker
            // 
            this.birthPicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.birthPicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.birthPicker.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.birthPicker.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.birthPicker.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthPicker.Location = new System.Drawing.Point(110, 166);
            this.birthPicker.Name = "birthPicker";
            this.birthPicker.Size = new System.Drawing.Size(137, 24);
            this.birthPicker.TabIndex = 5;
            // 
            // femaleRb
            // 
            this.femaleRb.AutoSize = true;
            this.femaleRb.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.femaleRb.Location = new System.Drawing.Point(208, 133);
            this.femaleRb.Name = "femaleRb";
            this.femaleRb.Size = new System.Drawing.Size(46, 24);
            this.femaleRb.TabIndex = 4;
            this.femaleRb.TabStop = true;
            this.femaleRb.Text = "Nữ";
            this.femaleRb.UseVisualStyleBackColor = true;
            // 
            // maleRb
            // 
            this.maleRb.AutoSize = true;
            this.maleRb.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.maleRb.Location = new System.Drawing.Point(110, 133);
            this.maleRb.Name = "maleRb";
            this.maleRb.Size = new System.Drawing.Size(56, 24);
            this.maleRb.TabIndex = 3;
            this.maleRb.TabStop = true;
            this.maleRb.Text = "Nam";
            this.maleRb.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.label11.Location = new System.Drawing.Point(17, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Khoa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.label10.Location = new System.Drawing.Point(17, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Lớp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.label9.Location = new System.Drawing.Point(17, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.label8.Location = new System.Drawing.Point(17, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.label4.Location = new System.Drawing.Point(17, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(17, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sinh viên";
            // 
            // firstNameTb
            // 
            this.firstNameTb.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTb.Location = new System.Drawing.Point(110, 99);
            this.firstNameTb.Name = "firstNameTb";
            this.firstNameTb.Size = new System.Drawing.Size(137, 24);
            this.firstNameTb.TabIndex = 0;
            // 
            // lastNameTb
            // 
            this.lastNameTb.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTb.Location = new System.Drawing.Point(110, 66);
            this.lastNameTb.Name = "lastNameTb";
            this.lastNameTb.Size = new System.Drawing.Size(137, 24);
            this.lastNameTb.TabIndex = 0;
            // 
            // studentIDTb
            // 
            this.studentIDTb.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDTb.Location = new System.Drawing.Point(110, 32);
            this.studentIDTb.Name = "studentIDTb";
            this.studentIDTb.Size = new System.Drawing.Size(137, 24);
            this.studentIDTb.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.searchStNameTb);
            this.panel3.Controls.Add(this.searchStIDTb);
            this.panel3.Controls.Add(this.StudentDGrv);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.searchDepartmentCb);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.searchClassCb);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(556, 408);
            this.panel3.TabIndex = 2;
            // 
            // searchStNameTb
            // 
            this.searchStNameTb.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStNameTb.Location = new System.Drawing.Point(108, 53);
            this.searchStNameTb.Name = "searchStNameTb";
            this.searchStNameTb.Size = new System.Drawing.Size(154, 24);
            this.searchStNameTb.TabIndex = 1;
            this.searchStNameTb.TextChanged += new System.EventHandler(this.searchStNameTb_TextChanged);
            // 
            // searchStIDTb
            // 
            this.searchStIDTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.searchStIDTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchStIDTb.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStIDTb.Location = new System.Drawing.Point(108, 18);
            this.searchStIDTb.Name = "searchStIDTb";
            this.searchStIDTb.Size = new System.Drawing.Size(154, 24);
            this.searchStIDTb.TabIndex = 1;
            this.searchStIDTb.TextChanged += new System.EventHandler(this.searchStIDTb_TextChanged);
            // 
            // StudentDGrv
            // 
            this.StudentDGrv.BackgroundColor = System.Drawing.Color.White;
            this.StudentDGrv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentDGrv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentDGrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDGrv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.LastName,
            this.FirstName,
            this.Sex,
            this.Birth,
            this.Address,
            this.ClassName,
            this.DepartmentName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentDGrv.DefaultCellStyle = dataGridViewCellStyle2;
            this.StudentDGrv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(192)))));
            this.StudentDGrv.Location = new System.Drawing.Point(0, 102);
            this.StudentDGrv.Name = "StudentDGrv";
            this.StudentDGrv.Size = new System.Drawing.Size(556, 303);
            this.StudentDGrv.TabIndex = 0;
            this.StudentDGrv.Click += new System.EventHandler(this.StudentDGrv_Click);
            // 
            // StudentID
            // 
            this.StudentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.HeaderText = "Mã SV";
            this.StudentID.Name = "StudentID";
            this.StudentID.Width = 71;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Họ";
            this.LastName.Name = "LastName";
            this.LastName.Width = 49;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Tên";
            this.FirstName.Name = "FirstName";
            // 
            // Sex
            // 
            this.Sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "Giới tính";
            this.Sex.Name = "Sex";
            // 
            // Birth
            // 
            this.Birth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Birth.DataPropertyName = "Birth";
            this.Birth.HeaderText = "Ngày sinh";
            this.Birth.Name = "Birth";
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa chỉ";
            this.Address.Name = "Address";
            // 
            // ClassName
            // 
            this.ClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "Lớp";
            this.ClassName.Name = "ClassName";
            // 
            // DepartmentName
            // 
            this.DepartmentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DepartmentName.DataPropertyName = "DepartmentName";
            this.DepartmentName.HeaderText = "Khoa";
            this.DepartmentName.Name = "DepartmentName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.label6.Location = new System.Drawing.Point(16, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã sinh viên";
            // 
            // searchDepartmentCb
            // 
            this.searchDepartmentCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchDepartmentCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.searchDepartmentCb.FormattingEnabled = true;
            this.searchDepartmentCb.Location = new System.Drawing.Point(384, 53);
            this.searchDepartmentCb.Name = "searchDepartmentCb";
            this.searchDepartmentCb.Size = new System.Drawing.Size(137, 21);
            this.searchDepartmentCb.TabIndex = 8;
            this.searchDepartmentCb.SelectedIndexChanged += new System.EventHandler(this.searchDepartmentCb_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.label7.Location = new System.Drawing.Point(16, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Họ tên sv";
            // 
            // searchClassCb
            // 
            this.searchClassCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchClassCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.searchClassCb.FormattingEnabled = true;
            this.searchClassCb.Location = new System.Drawing.Point(384, 21);
            this.searchClassCb.Name = "searchClassCb";
            this.searchClassCb.Size = new System.Drawing.Size(137, 21);
            this.searchClassCb.TabIndex = 7;
            this.searchClassCb.SelectedIndexChanged += new System.EventHandler(this.searchClassCb_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.label12.Location = new System.Drawing.Point(328, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Lớp";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.label13.Location = new System.Drawing.Point(328, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Khoa";
            // 
            // updateBt
            // 
            this.updateBt.BorderColor = System.Drawing.Color.White;
            this.updateBt.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.updateBt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.updateBt.FlatAppearance.BorderSize = 0;
            this.updateBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.updateBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.updateBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBt.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBt.Location = new System.Drawing.Point(175, 324);
            this.updateBt.Name = "updateBt";
            this.updateBt.OnHoverBorderColor = System.Drawing.Color.White;
            this.updateBt.OnHoverButtonColor = System.Drawing.Color.LightPink;
            this.updateBt.OnHoverTextColor = System.Drawing.Color.White;
            this.updateBt.Size = new System.Drawing.Size(79, 33);
            this.updateBt.TabIndex = 12;
            this.updateBt.Text = "Sửa";
            this.updateBt.TextColor = System.Drawing.Color.White;
            this.updateBt.UseVisualStyleBackColor = true;
            this.updateBt.Click += new System.EventHandler(this.updateBt_Click);
            // 
            // resetBt
            // 
            this.resetBt.BorderColor = System.Drawing.Color.White;
            this.resetBt.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.resetBt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.resetBt.FlatAppearance.BorderSize = 0;
            this.resetBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.resetBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.resetBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBt.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBt.Location = new System.Drawing.Point(48, 363);
            this.resetBt.Name = "resetBt";
            this.resetBt.OnHoverBorderColor = System.Drawing.Color.White;
            this.resetBt.OnHoverButtonColor = System.Drawing.Color.LightPink;
            this.resetBt.OnHoverTextColor = System.Drawing.Color.White;
            this.resetBt.Size = new System.Drawing.Size(79, 33);
            this.resetBt.TabIndex = 12;
            this.resetBt.Text = "Reset";
            this.resetBt.TextColor = System.Drawing.Color.White;
            this.resetBt.UseVisualStyleBackColor = true;
            this.resetBt.Click += new System.EventHandler(this.resetBt_Click);
            // 
            // SaveBt
            // 
            this.SaveBt.BorderColor = System.Drawing.Color.White;
            this.SaveBt.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.SaveBt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SaveBt.FlatAppearance.BorderSize = 0;
            this.SaveBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.SaveBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SaveBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBt.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBt.Location = new System.Drawing.Point(139, 363);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.OnHoverBorderColor = System.Drawing.Color.White;
            this.SaveBt.OnHoverButtonColor = System.Drawing.Color.LightPink;
            this.SaveBt.OnHoverTextColor = System.Drawing.Color.White;
            this.SaveBt.Size = new System.Drawing.Size(79, 33);
            this.SaveBt.TabIndex = 12;
            this.SaveBt.Text = "Lưu";
            this.SaveBt.TextColor = System.Drawing.Color.White;
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteBt
            // 
            this.deleteBt.BorderColor = System.Drawing.Color.White;
            this.deleteBt.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.deleteBt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteBt.FlatAppearance.BorderSize = 0;
            this.deleteBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.deleteBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.deleteBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBt.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBt.Location = new System.Drawing.Point(90, 324);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.OnHoverBorderColor = System.Drawing.Color.White;
            this.deleteBt.OnHoverButtonColor = System.Drawing.Color.LightPink;
            this.deleteBt.OnHoverTextColor = System.Drawing.Color.White;
            this.deleteBt.Size = new System.Drawing.Size(79, 33);
            this.deleteBt.TabIndex = 12;
            this.deleteBt.Text = "Xoá";
            this.deleteBt.TextColor = System.Drawing.Color.White;
            this.deleteBt.UseVisualStyleBackColor = true;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // addBt
            // 
            this.addBt.BorderColor = System.Drawing.Color.White;
            this.addBt.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.addBt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addBt.FlatAppearance.BorderSize = 0;
            this.addBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.addBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.addBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBt.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBt.Location = new System.Drawing.Point(3, 324);
            this.addBt.Name = "addBt";
            this.addBt.OnHoverBorderColor = System.Drawing.Color.White;
            this.addBt.OnHoverButtonColor = System.Drawing.Color.LightPink;
            this.addBt.OnHoverTextColor = System.Drawing.Color.White;
            this.addBt.Size = new System.Drawing.Size(79, 33);
            this.addBt.TabIndex = 12;
            this.addBt.Text = "Thêm";
            this.addBt.TextColor = System.Drawing.Color.White;
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // StudentManagementUsC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.Name = "StudentManagementUsC";
            this.Size = new System.Drawing.Size(821, 467);
            this.Load += new System.EventHandler(this.StudentManagementUsC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDGrv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox departmentNameCb;
        private System.Windows.Forms.ComboBox classNameCb;
        private System.Windows.Forms.TextBox addressTb;
        private System.Windows.Forms.DateTimePicker birthPicker;
        private System.Windows.Forms.RadioButton femaleRb;
        private System.Windows.Forms.RadioButton maleRb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameTb;
        private System.Windows.Forms.TextBox lastNameTb;
        private System.Windows.Forms.TextBox studentIDTb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox searchStIDTb;
        private System.Windows.Forms.DataGridView StudentDGrv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchStNameTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox searchDepartmentCb;
        private System.Windows.Forms.ComboBox searchClassCb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private ePOSOne.btnProduct.Button_WOC addBt;
        private ePOSOne.btnProduct.Button_WOC deleteBt;
        private ePOSOne.btnProduct.Button_WOC SaveBt;
        private ePOSOne.btnProduct.Button_WOC updateBt;
        private ePOSOne.btnProduct.Button_WOC resetBt;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentName;
    }
}
