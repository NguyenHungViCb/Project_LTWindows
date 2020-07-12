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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.updateBt = new ePOSOne.btnProduct.Button_WOC();
            this.deleteBt = new ePOSOne.btnProduct.Button_WOC();
            this.saveBt = new ePOSOne.btnProduct.Button_WOC();
            this.resetBt = new ePOSOne.btnProduct.Button_WOC();
            this.addBt = new ePOSOne.btnProduct.Button_WOC();
            this.departmentNameCb = new System.Windows.Forms.ComboBox();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classDgV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 59);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Metrophobic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(329, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 42);
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
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.updateBt);
            this.panel2.Controls.Add(this.deleteBt);
            this.panel2.Controls.Add(this.saveBt);
            this.panel2.Controls.Add(this.resetBt);
            this.panel2.Controls.Add(this.addBt);
            this.panel2.Controls.Add(this.departmentNameCb);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.studentCountTb);
            this.panel2.Controls.Add(this.lecturerTb);
            this.panel2.Controls.Add(this.classNameTb);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.classIDTb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(558, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 408);
            this.panel2.TabIndex = 1;
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
            this.updateBt.Location = new System.Drawing.Point(183, 294);
            this.updateBt.Name = "updateBt";
            this.updateBt.OnHoverBorderColor = System.Drawing.Color.White;
            this.updateBt.OnHoverButtonColor = System.Drawing.Color.LightPink;
            this.updateBt.OnHoverTextColor = System.Drawing.Color.White;
            this.updateBt.Size = new System.Drawing.Size(79, 33);
            this.updateBt.TabIndex = 5;
            this.updateBt.Text = "Sửa";
            this.updateBt.TextColor = System.Drawing.Color.White;
            this.updateBt.UseVisualStyleBackColor = true;
            this.updateBt.Click += new System.EventHandler(this.updateBt_Click);
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
            this.deleteBt.Location = new System.Drawing.Point(91, 294);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.OnHoverBorderColor = System.Drawing.Color.White;
            this.deleteBt.OnHoverButtonColor = System.Drawing.Color.LightPink;
            this.deleteBt.OnHoverTextColor = System.Drawing.Color.White;
            this.deleteBt.Size = new System.Drawing.Size(79, 33);
            this.deleteBt.TabIndex = 5;
            this.deleteBt.Text = "Xoá";
            this.deleteBt.TextColor = System.Drawing.Color.White;
            this.deleteBt.UseVisualStyleBackColor = true;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // saveBt
            // 
            this.saveBt.BorderColor = System.Drawing.Color.White;
            this.saveBt.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.saveBt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveBt.FlatAppearance.BorderSize = 0;
            this.saveBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.saveBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.saveBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBt.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBt.Location = new System.Drawing.Point(141, 346);
            this.saveBt.Name = "saveBt";
            this.saveBt.OnHoverBorderColor = System.Drawing.Color.White;
            this.saveBt.OnHoverButtonColor = System.Drawing.Color.LightPink;
            this.saveBt.OnHoverTextColor = System.Drawing.Color.White;
            this.saveBt.Size = new System.Drawing.Size(79, 33);
            this.saveBt.TabIndex = 5;
            this.saveBt.Text = "Lưu";
            this.saveBt.TextColor = System.Drawing.Color.White;
            this.saveBt.UseVisualStyleBackColor = true;
            this.saveBt.Click += new System.EventHandler(this.saveBt_Click);
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
            this.resetBt.Location = new System.Drawing.Point(56, 346);
            this.resetBt.Name = "resetBt";
            this.resetBt.OnHoverBorderColor = System.Drawing.Color.White;
            this.resetBt.OnHoverButtonColor = System.Drawing.Color.LightPink;
            this.resetBt.OnHoverTextColor = System.Drawing.Color.White;
            this.resetBt.Size = new System.Drawing.Size(79, 33);
            this.resetBt.TabIndex = 5;
            this.resetBt.Text = "Reset";
            this.resetBt.TextColor = System.Drawing.Color.White;
            this.resetBt.UseVisualStyleBackColor = true;
            this.resetBt.Click += new System.EventHandler(this.resetBt_Click);
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
            this.addBt.Location = new System.Drawing.Point(6, 294);
            this.addBt.Name = "addBt";
            this.addBt.OnHoverBorderColor = System.Drawing.Color.White;
            this.addBt.OnHoverButtonColor = System.Drawing.Color.LightPink;
            this.addBt.OnHoverTextColor = System.Drawing.Color.White;
            this.addBt.Size = new System.Drawing.Size(79, 33);
            this.addBt.TabIndex = 5;
            this.addBt.Text = "Thêm";
            this.addBt.TextColor = System.Drawing.Color.White;
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // departmentNameCb
            // 
            this.departmentNameCb.BackColor = System.Drawing.Color.White;
            this.departmentNameCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentNameCb.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentNameCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.departmentNameCb.FormattingEnabled = true;
            this.departmentNameCb.Location = new System.Drawing.Point(136, 134);
            this.departmentNameCb.Name = "departmentNameCb";
            this.departmentNameCb.Size = new System.Drawing.Size(126, 28);
            this.departmentNameCb.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.label5.Location = new System.Drawing.Point(9, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số sinh viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.label4.Location = new System.Drawing.Point(0, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giảng viên phụ trách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.label6.Location = new System.Drawing.Point(9, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã lớp";
            // 
            // studentCountTb
            // 
            this.studentCountTb.Enabled = false;
            this.studentCountTb.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentCountTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.studentCountTb.Location = new System.Drawing.Point(139, 248);
            this.studentCountTb.Name = "studentCountTb";
            this.studentCountTb.Size = new System.Drawing.Size(126, 24);
            this.studentCountTb.TabIndex = 0;
            // 
            // lecturerTb
            // 
            this.lecturerTb.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturerTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.lecturerTb.Location = new System.Drawing.Point(136, 192);
            this.lecturerTb.Name = "lecturerTb";
            this.lecturerTb.Size = new System.Drawing.Size(126, 24);
            this.lecturerTb.TabIndex = 0;
            // 
            // classNameTb
            // 
            this.classNameTb.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classNameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.classNameTb.Location = new System.Drawing.Point(136, 87);
            this.classNameTb.Name = "classNameTb";
            this.classNameTb.Size = new System.Drawing.Size(126, 24);
            this.classNameTb.TabIndex = 0;
            // 
            // classIDTb
            // 
            this.classIDTb.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classIDTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.classIDTb.Location = new System.Drawing.Point(136, 38);
            this.classIDTb.Name = "classIDTb";
            this.classIDTb.Size = new System.Drawing.Size(126, 24);
            this.classIDTb.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
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
            this.classIDCb.BackColor = System.Drawing.Color.White;
            this.classIDCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classIDCb.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classIDCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.classIDCb.FormattingEnabled = true;
            this.classIDCb.Location = new System.Drawing.Point(167, 37);
            this.classIDCb.Name = "classIDCb";
            this.classIDCb.Size = new System.Drawing.Size(170, 28);
            this.classIDCb.TabIndex = 1;
            this.classIDCb.SelectedIndexChanged += new System.EventHandler(this.classIDCb_SelectedIndexChanged);
            // 
            // classDgV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.classDgV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.classDgV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classDgV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.classDgV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classDgV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassID,
            this.DepartmentName,
            this.ClassName,
            this.Lecturer,
            this.studentCount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.classDgV.DefaultCellStyle = dataGridViewCellStyle3;
            this.classDgV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.classDgV.Location = new System.Drawing.Point(0, 103);
            this.classDgV.Name = "classDgV";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classDgV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.classDgV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.classDgV.Size = new System.Drawing.Size(553, 305);
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Metrophobic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(76)))));
            this.textBox1.Location = new System.Drawing.Point(136, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 24);
            this.textBox1.TabIndex = 0;
            // 
            // ClassesManagementUsC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ClassesManagementUsC";
            this.Size = new System.Drawing.Size(829, 467);
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
        private ePOSOne.btnProduct.Button_WOC addBt;
        private ePOSOne.btnProduct.Button_WOC updateBt;
        private ePOSOne.btnProduct.Button_WOC deleteBt;
        private ePOSOne.btnProduct.Button_WOC saveBt;
        private ePOSOne.btnProduct.Button_WOC resetBt;
        private System.Windows.Forms.TextBox textBox1;
    }
}
