using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplomnya_rabota
{
    public partial class teacherMainForm : Form
    {
        public teacherMainForm()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            mainForm main = new mainForm();
            main.pictureBox20.Visible = true;
            main.Show();
            this.Hide();

        }

        private void teacherMainForm_Load(object sender, EventArgs e)
        {
            button1.TabStop = false;
            button11.TabStop = false;
            button2.TabStop = false;
            button3.TabStop = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            teacherLoginForm LoginForm = new teacherLoginForm();
            LoginForm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            teacherAddForm teacherAdd = new teacherAddForm();
            teacherAdd.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            teacherSettings teacherEdit = new teacherSettings();
            teacherEdit.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            tasksAddForm tasksAdd = new tasksAddForm();
            tasksAdd.Show();
            this.Hide();
        }
    }
}
