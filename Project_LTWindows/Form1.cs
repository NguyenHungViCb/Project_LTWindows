using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_LTWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gradesManagementUsCt.Hide();
            studentManagementUsC1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void studentManagementUsC1_Load(object sender, EventArgs e)
        {

        }
        private void studentManagementBt_Click(object sender, EventArgs e)
        {
            gradesManagementUsCt.Hide();
            studentManagementUsC1.Visible = true;
        }
        private void gradeManagementBt_Click(object sender, EventArgs e)
        {
            studentManagementUsC1.Hide();
            gradesManagementUsCt.Visible = true;
        }

        
    }
}
