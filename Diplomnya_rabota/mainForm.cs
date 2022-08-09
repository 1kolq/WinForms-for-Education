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
    public partial class mainForm : Form
    {
        
        

        public mainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            teacherLoginForm teacherLogin = new teacherLoginForm();
            teacherLogin.Show();
            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            practicLab1 practicLabFirst = new practicLab1();
            practicLabFirst.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filename = "laba2.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filename = "laba3.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filename = "laba4.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filename = "laba5.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            practicLab2 practicLabSecond = new practicLab2();
            practicLabSecond.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            practicLab3 practicLabThird = new practicLab3();
            practicLabThird.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            practicLab4 practicLabFourth = new practicLab4();
            practicLabFourth.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            practicLab5 practicLabFifth = new practicLab5();
            practicLabFifth.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string filename = "laba1.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            button2.TabStop = false;
            button3.TabStop = false;
            button4.TabStop = false;
            button5.TabStop = false;
            button6.TabStop = false;
            button7.TabStop = false;
            button8.TabStop = false;
            button9.TabStop = false;
            button10.TabStop = false;
            button11.TabStop = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            
            teacherMainForm teacherMain = new teacherMainForm();
            teacherMain.Show();
            this.Hide();
        }

        Point lastPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {   
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
