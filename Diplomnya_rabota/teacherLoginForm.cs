using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplomnya_rabota
{
    public partial class teacherLoginForm : Form
    {

        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=database.mdb";

        private OleDbConnection myConnection;
        



        public teacherLoginForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void teacherLoginForm_Load(object sender, EventArgs e)
        {
            
            loginField.ForeColor = Color.Gray;
            loginField.TabStop = false;
            flowLayoutPanel1.BackColor = Color.Gray;

            flowLayoutPanel2.BackColor = Color.Gray;
            passField.ForeColor = Color.Gray;
        }
        private void userLoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm main = new mainForm();
            main.ShowDialog();
        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.FromArgb(33, 33, 36);
            loginField.ForeColor = Color.FromArgb(33, 33, 36);
            flowLayoutPanel2.BackColor = Color.Gray;
            passField.ForeColor = Color.Gray;
            
        }

        

        private void label4_Click(object sender, EventArgs e)
        {
            teacherRegistrationForm teacherRegistration = new teacherRegistrationForm();
            teacherRegistration.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM users WHERE login = '" + loginField.Text + "' AND password='" + passField.Text + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader readerq = command.ExecuteReader();
            if (readerq.Read())
            {
                string queryPosition = "SELECT * FROM users WHERE role = '0' AND password='" + passField.Text + "' AND login='" + loginField.Text + "'";
                OleDbCommand commandPosition = new OleDbCommand(queryPosition, myConnection);
                OleDbDataReader reader = commandPosition.ExecuteReader();
                if (reader.Read())
                {
                    
                    mainForm newForm = new mainForm();
                    string queryHello = "SELECT name FROM users WHERE login = '" + loginField.Text + "'";
                    OleDbCommand commandHello = new OleDbCommand(queryHello, myConnection);
                    newForm.mainFormHelloLabel.Text = "Добро пожаловать, " + commandHello.ExecuteScalar().ToString();
                    newForm.Show();
                    this.Hide();
                }
                else
                {

                    teacherMainForm teacherForm = new teacherMainForm();
                    mainForm newForm = new mainForm();
                    string queryHello = "SELECT name FROM users WHERE login = '" + loginField.Text + "'";
                    OleDbCommand commandHello = new OleDbCommand(queryHello, myConnection);
                    teacherForm.teacherMainFormHelloLabel.Text = "Добро пожаловать, " + commandHello.ExecuteScalar().ToString();
                    teacherForm.Show();
                    this.Hide();
                }
            }
            else
            {
               MessageBox.Show("Неверный логин или пароль");
            }

            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void loginField_MouseClick(object sender, MouseEventArgs e)
        {
            
            
        }

        private void loginField_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void loginField_MouseEnter(object sender, EventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.FromArgb(33, 33, 36);
            loginField.ForeColor = Color.FromArgb(33, 33, 36);
            //flowLayoutPanel2.BackColor = Color.Gray;
            //passField.ForeColor = Color.Gray;
        }

        private void loginField_MouseLeave(object sender, EventArgs e)
        {
           // flowLayoutPanel1.BackColor = Color.Gray;
           // loginField.ForeColor = Color.Gray;
        }

        private void loginField_Click(object sender, EventArgs e)
        {

        }

        private void passField_MouseEnter(object sender, EventArgs e)
        {
            flowLayoutPanel2.BackColor = Color.FromArgb(33, 33, 36);
            passField.ForeColor = Color.FromArgb(33, 33, 36);
        }

        private void passField_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel2.BackColor = Color.FromArgb(33, 33, 36);
            passField.ForeColor = Color.FromArgb(33, 33, 36);
            loginField.ForeColor = Color.Gray;
            flowLayoutPanel1.BackColor = Color.Gray;
        }

        private void passField_MouseClick(object sender, MouseEventArgs e)
        {
            flowLayoutPanel2.BackColor = Color.FromArgb(33, 33, 36);
            passField.ForeColor = Color.FromArgb(33, 33, 36);
            loginField.ForeColor = Color.Gray;
            flowLayoutPanel1.BackColor = Color.Gray;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderColor = Color.Gray;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
