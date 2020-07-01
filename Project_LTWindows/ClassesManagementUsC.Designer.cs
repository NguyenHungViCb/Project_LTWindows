namespace Project_LTWindows
{
    partial class ClassesManagementUsC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.departmentNameCb = new System.Windows.Forms.ComboBox();
            this.resetBt = new System.Windows.Forms.Button();
            this.updateBt = new System.Windows.Forms.Button();
            this.saveBt = new System.Windows.Forms.Button();
            this.deleteBt = new System.Windows.Forms.Button();
            this.addBt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentCountTb = new System.Windows.Forms.TextBox();
            this.lecturerTb = new System.Windows.Forms.TextBox();
            this.classNameTb = new System.Windows.Forms.TextBox();
            this.classIDTb = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.classIDCb = new System.Windows.Forms.ComboBox();
            this.classDgV = new System.Windows.Forms.DataGridView();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lecturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classDgV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 59);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản lý lớp";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 59);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(556, 408);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.departmentNameCb);
            this.panel2.Controls.Add(this.resetBt);
            this.panel2.Controls.Add(this.updateBt);
            this.panel2.Controls.Add(this.saveBt);
            this.panel2.Controls.Add(this.deleteBt);
            this.panel2.Controls.Add(this.addBt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.studentCountTb);
            this.panel2.Controls.Add(this.lecturerTb);
            this.panel2.Controls.Add(this.classNameTb);
            this.panel2.Controls.Add(this.classIDTb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(556, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 408);
            this.panel2.TabIndex = 1;
            // 
            // departmentNameCb
            // 
            this.departmentNameCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentNameCb.FormattingEnabled = true;
            this.departmentNameCb.Location = new System.Drawing.Point(123, 134);
            this.departmentNameCb.Name = "departmentNameCb";
            this.departmentNameCb.Size = new System.Drawing.Size(126, 21);
            this.departmentNameCb.TabIndex = 4;
            // 
            // resetBt
            // 
            this.resetBt.Location = new System.Drawing.Point(60, 351);
            this.resetBt.Name = "resetBt";
            this.resetBt.Size = new System.Drawing.Size(75, 23);
            this.resetBt.TabIndex = 3;
            this.resetBt.Text = "Reset";
            this.resetBt.UseVisualStyleBackColor = true;
            this.resetBt.Click += new System.EventHandler(this.resetBt_Click);
            // 
            // updateBt
            // 
            this.updateBt.Location = new System.Drawing.Point(174, 299);
            this.updateBt.Name = "updateBt";
            this.updateBt.Size = new System.Drawing.Size(75, 23);
            this.updateBt.TabIndex = 2;
            this.updateBt.Text = "Sửa";
            this.updateBt.UseVisualStyleBackColor = true;
            this.updateBt.Click += new System.EventHandler(this.updateBt_Click);
            // 
            // saveBt
            // 
            this.saveBt.Location = new System.Drawing.Point(141, 351);
            this.saveBt.Name = "saveBt";
            this.saveBt.Size = new System.Drawing.Size(75, 23);
            this.saveBt.TabIndex = 3;
            this.saveBt.Text = "Lưu";
            this.saveBt.UseVisualStyleBackColor = true;
            this.saveBt.Click += new System.EventHandler(this.saveBt_Click);
            // 
            // deleteBt
            // 
            this.deleteBt.Location = new System.Drawing.Point(93, 299);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(75, 23);
            this.deleteBt.TabIndex = 3;
            this.deleteBt.Text = "Xoá";
            this.deleteBt.UseVisualStyleBackColor = true;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // addBt
            // 
            this.addBt.Location = new System.Drawing.Point(12, 299);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(75, 23);
            this.addBt.TabIndex = 2;
            this.addBt.Text = "Thêm";
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số sinh viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giảng viên phụ trách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã lớp";
            // 
            // studentCountTb
            // 
            this.studentCountTb.Enabled = false;
            this.studentCountTb.Location = new System.Drawing.Point(123, 248);
            this.studentCountTb.Name = "studentCountTb";
            this.studentCountTb.Size = new System.Drawing.Size(126, 20);
            this.studentCountTb.TabIndex = 0;
            // 
            // lecturerTb
            // 
            this.lecturerTb.Location = new System.Drawing.Point(123, 192);
            this.lecturerTb.Name = "lecturerTb";
            this.lecturerTb.Size = new System.Drawing.Size(126, 20);
            this.lecturerTb.TabIndex = 0;
            // 
            // classNameTb
            // 
            this.classNameTb.Location = new System.Drawing.Point(123, 87);
            this.classNameTb.Name = "classNameTb";
            this.classNameTb.Size = new System.Drawing.Size(126, 20);
            this.classNameTb.TabIndex = 0;
            // 
            // classIDTb
            // 
            this.classIDTb.Location = new System.Drawing.Point(123, 38);
            this.classIDTb.Name = "classIDTb";
            this.classIDTb.Size = new System.Drawing.Size(126, 20);
            this.classIDTb.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.classIDCb);
            this.panel3.Controls.Add(this.classDgV);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(556, 408);
            this.panel3.TabIndex = 2;
            // 
            // classIDCb
            // 
            this.classIDCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classIDCb.FormattingEnabled = true;
            this.classIDCb.Location = new System.Drawing.Point(167, 37);
            this.classIDCb.Name = "classIDCb";
            this.classIDCb.Size = new System.Drawing.Size(170, 21);
            this.classIDCb.TabIndex = 1;
            this.classIDCb.SelectedIndexChanged += new System.EventHandler(this.classIDCb_SelectedIndexChanged);
            // 
            // classDgV
            // 
            this.classDgV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classDgV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassID,
            this.DepartmentName,
            this.ClassName,
            this.Lecturer,
            this.studentCount});
            this.classDgV.Location = new System.Drawing.Point(0, 103);
            this.classDgV.Name = "classDgV";
            this.classDgV.Size = new System.Drawing.Size(556, 305);
            this.classDgV.TabIndex = 0;
            this.classDgV.Click += new System.EventHandler(this.classDgV_Click);
            // 
            // ClassID
            // 
            this.ClassID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClassID.DataPropertyName = "ClassID";
            this.ClassID.HeaderText = "Mã lớp";
            this.ClassID.Name = "ClassID";
            // 
            // DepartmentName
            // 
            this.DepartmentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DepartmentName.DataPropertyName = "DepartmentName";
            this.DepartmentName.HeaderText = "Khoa";
            this.DepartmentName.Name = "DepartmentName";
            // 
            // ClassName
            // 
            this.ClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "Tên lớp";
            this.ClassName.Name = "ClassName";
            // 
            // Lecturer
            // 
            this.Lecturer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Lecturer.DataPropertyName = "Lecturer";
            this.Lecturer.HeaderText = "Giảng viên phụ trách";
            this.Lecturer.Name = "Lecturer";
            // 
            // studentCount
            // 
            this.studentCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentCount.DataPropertyName = "StudentCount";
            this.studentCount.HeaderText = "Số sinh viên";
            this.studentCount.Name = "studentCount";
            // 
            // ClassesManagementUsC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ClassesManagementUsC";
            this.Size = new System.Drawing.Size(821, 467);
            this.Load += new System.EventHandler(this.ClassesManagementUsC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.classDgV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView classDgV;
        private System.Windows.Forms.Button resetBt;
        private System.Windows.Forms.Button updateBt;
        private System.Windows.Forms.Button saveBt;
        private System.Windows.Forms.Button deleteBt;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentCountTb;
        private System.Windows.Forms.TextBox lecturerTb;
        private System.Windows.Forms.TextBox classNameTb;
        private System.Windows.Forms.TextBox classIDTb;
        private System.Windows.Forms.ComboBox classIDCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox departmentNameCb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lecturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentCount;
    }
}
