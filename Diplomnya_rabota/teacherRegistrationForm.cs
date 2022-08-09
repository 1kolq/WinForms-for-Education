using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Diplomnya_rabota
{
    public partial class teacherRegistrationForm : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=database.mdb";

        private OleDbConnection myConnection;

        public teacherRegistrationForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void teacherRegistrationForm_Load(object sender, EventArgs e)
        {
            textBox3.Text = "Код преподавателя";
            textBox3.ForeColor = Color.Gray;
            textBox3.TabStop = false;
            textBox1.Text = "Имя";
            textBox1.ForeColor = Color.Gray;
            textBox1.TabStop = false;
            textBox2.Text = "Фамилия";
            textBox2.ForeColor = Color.Gray;
            textBox2.TabStop = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = null;
            textBox3.ForeColor = Color.Black;
            textBox3.PasswordChar = Convert.ToChar("•");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginField.Text != String.Empty && passField.Text != String.Empty && textBox3.Text != String.Empty && textBox1.Text != String.Empty && textBox2.Text != String.Empty)
            {
                string queryLogin = "SELECT * FROM users WHERE login = '" + loginField.Text + "'";
                OleDbCommand commandLogin = new OleDbCommand(queryLogin, myConnection);
                OleDbDataReader readerLogin = commandLogin.ExecuteReader();
                if (readerLogin.Read())
                {
                    MessageBox.Show("Пользователь с таким логином уже существует!");
                }
                else
                {
                    string queryCode = "SELECT code FROM users WHERE login = 'elena'";
                    OleDbCommand commandCode = new OleDbCommand(queryCode, myConnection);
                    if (textBox3.Text != commandCode.ExecuteScalar().ToString())
                    {
                        MessageBox.Show("Код преподавателя неверный!");
                    }
                    else
                    {
                        string queryVvod = "INSERT INTO users ([login], [password], [name], [surname], [role]) VALUES ('" + loginField.Text + "' , '" + passField.Text + "', '" +
                            textBox1.Text + "', '" + textBox2.Text + "', '0')";
                        OleDbCommand commandVvod = new OleDbCommand(queryVvod, myConnection);
                        commandVvod.ExecuteNonQuery();
                        if (MessageBox.Show("Регистрация прошла успешно!") == DialogResult.OK)
                        {
                            
                            teacherLoginForm LoginForm = new teacherLoginForm();
                            LoginForm.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox2.ForeColor = Color.Black;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox1.ForeColor = Color.Black;
        }
    }
}
