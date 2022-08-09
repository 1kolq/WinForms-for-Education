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
    public partial class practicLab2 : Form
    {
        public practicLab2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            
            mainForm main = new mainForm();
            main.Show();
            this.Hide();
        }

        private void DtcheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void startbutton_Click(object sender, EventArgs e)
        {

        }

        private void mtcheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ftcheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void qtcheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PtcheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void DtcheckBox_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void mtcheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void ftcheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            
            
        }

        private void lyamdatcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void qtcheckBox_CheckedChanged_1(object sender, EventArgs e)
        {  
            
        }

        private void PtcheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            
         
        }

        private void practicLab2_Load(object sender, EventArgs e)
        {
            Expopanel.Visible = false;
            PTExpopanel.Visible = false;
            qtExpopanel.Visible = false;
            ftExpopanel.Visible = false;
            lyamdaExpopanel.Visible = false;
            LyamdaftExpopanel.Visible = false;
            mtExpopanel.Visible = false;
            Normalpanel.Visible = false;
            UNormalpanel.Visible = false;
            FNormalpanel.Visible = false;
            FINormalpanel.Visible = false;
            PtNormalpanel.Visible = false;
            qtNormalpanel.Visible = false;
            lyamdaNormalpanel.Visible = false;
            ftNormalpanel.Visible = false;
            Veybullapanel.Visible = false;
            PtVeybullapanel.Visible = false;
            ftVeybullapanel.Visible = false;
            lyamdaVeybullapanel.Visible = false;
            qtVeybullapanel.Visible = false;
            mtVeybullapanel.Visible = false;
            Releyapanel.Visible = false;
            PtReleyapanel.Visible = false;
            qtRelleyapanel.Visible = false;
            lyamdaRelleyapanel.Visible = false;
            ftRelleyapanel.Visible = false;
            mtRelleyapanel.Visible = false;
        }

        private void startbutton_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Expopanel.Visible = true;
                if (PtcheckBox.Checked)
                {
                    PTExpopanel.Visible = true;
                    label9.Text = "-" + deltattextBox.Text + "*" + ttextBox.Text;
                    double lab11 = Math.Round(Math.Exp(-Convert.ToDouble(deltattextBox.Text) * Convert.ToDouble(ttextBox.Text)), 5);
                    label11.Text = lab11.ToString() + ";";
                }

                if (qtcheckBox.Checked)
                {
                    qtExpopanel.Visible = true;
                    label14.Text = "-" + deltattextBox.Text + "*" + ttextBox.Text;
                    double lab18 = Math.Round(1 - Math.Exp(-Convert.ToDouble(deltattextBox.Text) * Convert.ToDouble(ttextBox.Text)), 5);
                    label18.Text = lab18.ToString() + ";";
                }

                if (ftcheckBox.Checked)
                {
                    ftExpopanel.Visible = true;
                    label30.Text = deltattextBox.Text + " - ";
                    label19.Text = "-" + deltattextBox.Text + "*" + ttextBox.Text;
                    decimal lab29 = Convert.ToDecimal(Math.Round(Convert.ToDouble(deltattextBox.Text) * Math.Exp( -Convert.ToDouble(deltattextBox.Text) * Convert.ToDouble(ttextBox.Text)), 5));
                    label29.Text = lab29.ToString() + ";";
                }

                if (lyamdatcheckBox.Checked)
                {
                    if (textBox5.Text != String.Empty && ttextBox.Text != String.Empty)
                    {
                        lyamdaExpopanel.Visible = true;
                        label33.Text = "ln(" + textBox5.Text + ")";
                        label31.Text = ttextBox.Text;
                        decimal lab37 = Convert.ToDecimal(Math.Round(-(Math.Log(Convert.ToDouble(textBox5.Text)) / Convert.ToDouble(ttextBox.Text)), 5));
                        label37.Text = lab37.ToString() + ";";
                    }

                    if (textBox5.Text != String.Empty && textBox6.Text != String.Empty)
                    {
                        LyamdaftExpopanel.Visible = true;
                        label42.Text = textBox6.Text;
                        label40.Text = textBox5.Text;
                        decimal lab38 = Convert.ToDecimal(Math.Round((Convert.ToDouble(textBox6.Text) / Convert.ToDouble(textBox5.Text)), 5));
                        label38.Text = lab38.ToString() + ";";
                    }
                }


                if(mtcheckBox.Checked)
                {
                    mtExpopanel.Visible = true;
                    label48.Text = deltattextBox.Text;
                    decimal lab46 = Convert.ToDecimal(Math.Round((1 / Convert.ToDouble(deltattextBox.Text)), 5));
                    label46.Text = lab46.ToString() + ";";
                }
            }

            if (checkBox2.Checked)
            {
                Normalpanel.Visible = true;

                if (PtcheckBox.Checked || qtcheckBox.Checked || lyamdatcheckBox.Checked)
                {
                    UNormalpanel.Visible = true;
                    label54.Text = ttextBox.Text + " - " + textBox1.Text;
                    label55.Text = textBox2.Text;
                    decimal lab49 = Convert.ToDecimal(Math.Round(((Convert.ToDouble(ttextBox.Text) - Convert.ToDouble(textBox1.Text)) / Convert.ToDouble(textBox2.Text)), 1));
                    label49.Text = lab49.ToString() + ";";

                    FNormalpanel.Visible = true;
                    label62.Text = "Ф(" + lab49.ToString() + ") = ";
                }

                if (ftcheckBox.Checked || lyamdatcheckBox.Checked)
                {
                    FINormalpanel.Visible = true;
                    decimal lab49 = Convert.ToDecimal(Math.Round(((Convert.ToDouble(ttextBox.Text) - Convert.ToDouble(textBox1.Text)) / Convert.ToDouble(textBox2.Text)), 1));
                    label64.Text = "ф(" + lab49.ToString() + ") = ";
                }
            }

            if (checkBox3.Checked)
            {
                Veybullapanel.Visible = true;
                if (PtcheckBox.Checked)
                {
                    PtVeybullapanel.Visible = true;
                    label99.Text = "-" + textBox4.Text + "*" + ttextBox.Text + "^" + textBox3.Text;
                    decimal lab97 = Convert.ToDecimal(Math.Round((Math.Exp(- Convert.ToDouble(textBox4.Text) * Math.Pow(Convert.ToDouble(ttextBox.Text), Convert.ToDouble(textBox3.Text)))), 3));
                    label97.Text = lab97.ToString() + ";";
                }

                if (ftcheckBox.Checked)
                {
                    ftVeybullapanel.Visible = true;
                    PtVeybullapanel.Visible = true;
                    lyamdaVeybullapanel.Visible = true;

                    label99.Text = "-" + textBox4.Text + "*" + ttextBox.Text + "^" + textBox3.Text;
                    decimal lab97 = Convert.ToDecimal(Math.Round((Math.Exp(-Convert.ToDouble(textBox4.Text) * Math.Pow(Convert.ToDouble(ttextBox.Text), Convert.ToDouble(textBox3.Text)))), 3));
                    label97.Text = lab97.ToString() + ";";

                    label108.Text = textBox4.Text + "*" + textBox3.Text + "*" + ttextBox.Text + "^(" + textBox3.Text + " - 1) * P(t)";
                    decimal lab104 = Math.Round(Convert.ToDecimal((Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox3.Text) * Math.Pow(Convert.ToDouble(ttextBox.Text), Convert.ToDouble(textBox3.Text) - 1))) * lab97, 6);
                    label104.Text = lab104.ToString() + ";";

                    decimal lab112 = Math.Round(Convert.ToDecimal((Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox3.Text) * Math.Pow(Convert.ToDouble(ttextBox.Text), Convert.ToDouble(textBox3.Text) - 1))), 5);
                    label112.Text = "=  " + lab112.ToString() + ";";
                    label116.Text = textBox4.Text + "*" + textBox3.Text + "*" + ttextBox.Text + "^(" + textBox3.Text + " - 1)";
                }

                if(lyamdatcheckBox.Checked)
                {
                    lyamdaVeybullapanel.Visible = true;
                    decimal lab112 = Math.Round(Convert.ToDecimal((Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox3.Text) * Math.Pow(Convert.ToDouble(ttextBox.Text), Convert.ToDouble(textBox3.Text) - 1))), 5);
                    label112.Text = "=  " + lab112.ToString() + ";";
                    label116.Text =  textBox4.Text + "*" + textBox3.Text + "*" + ttextBox.Text + "^(" + textBox3.Text + " - 1)";
                }

                if(qtcheckBox.Checked)
                {
                    qtVeybullapanel.Visible = true;
                    label124.Text = "-" + textBox4.Text + "*" + ttextBox.Text + "^" + textBox3.Text;
                    decimal lab117 = Convert.ToDecimal(Math.Round(1 - (Math.Exp(-Convert.ToDouble(textBox4.Text) * Math.Pow(Convert.ToDouble(ttextBox.Text), Convert.ToDouble(textBox3.Text)))), 3));
                    label117.Text = lab117.ToString() + ";";
                }

                if(mtcheckBox.Checked)
                {
                    mtVeybullapanel.Visible = true;
                    label127.Text = "(1/" + textBox3.Text + ")* Г(1/" + textBox3.Text + ")";
                    label129.Text = textBox4.Text + "^(1/" + textBox3.Text + ")";

                    if (Convert.ToDecimal(textBox3.Text) > 1)
                    {
                        label133.Text = "Г(" + Math.Round(Convert.ToDecimal((1 / (Convert.ToDecimal(textBox3.Text)) + 1)), 3) + ") = ";
                        MessageBox.Show("Т.к. 1/k < 1, то нужно найти значение Г(" + Math.Round(Convert.ToDecimal((1 / (Convert.ToDecimal(textBox3.Text)) + 1)), 3) + ")");
                    }
                    else
                    {
                        label133.Text = "Г(" + Math.Round(Convert.ToDecimal(1 / Convert.ToDecimal(textBox3.Text)), 3) + ") = ";
                    }
                }
            }

            if(checkBox4.Checked)
            {
                Releyapanel.Visible = true;                 
                if (PtcheckBox.Checked || qtcheckBox.Checked || ftcheckBox.Checked)
                {
                    PtReleyapanel.Visible = true;
                    label139.Text = Math.Round(Math.Pow(Convert.ToDouble(ttextBox.Text),2), 2).ToString();
                    label138.Text = Math.Round(2 * Math.Pow(Convert.ToDouble(textBox2.Text), 2), 2).ToString();
                    decimal lab140 = Convert.ToDecimal(Math.Round(Math.Exp((-Math.Pow(Convert.ToDouble(ttextBox.Text), 2) / (2 * Math.Pow(Convert.ToDouble(textBox2.Text), 2)))), 4));
                    label140.Text = lab140.ToString() + ";";

                }

                if(qtcheckBox.Checked)
                {
                    qtRelleyapanel.Visible = true;
                    label143.Text = Math.Round(Math.Pow(Convert.ToDouble(ttextBox.Text), 2), 2).ToString();
                    label147.Text = Math.Round(2 * Math.Pow(Convert.ToDouble(textBox2.Text), 2), 2).ToString();
                    decimal lab140 = Convert.ToDecimal(Math.Round(Math.Exp((-Math.Pow(Convert.ToDouble(ttextBox.Text), 2) / (2 * Math.Pow(Convert.ToDouble(textBox2.Text), 2)))), 4));
                    decimal lab150 = 1 - lab140;
                    label150.Text = lab150.ToString() + ";";
                }

                if(ftcheckBox.Checked || lyamdatcheckBox.Checked)
                {
                    lyamdaRelleyapanel.Visible = true;
                    label151.Text = ttextBox.Text;
                    label152.Text = Math.Pow(Convert.ToDouble(textBox2.Text), 2).ToString();
                    decimal lab153 = Convert.ToDecimal(Math.Round((Convert.ToDouble(ttextBox.Text) / Math.Pow(Convert.ToDouble(textBox2.Text), 2)), 4));
                    label153.Text = lab153.ToString() + ";";
                }

                if (ftcheckBox.Checked)
                {
                    ftRelleyapanel.Visible = true;
                    decimal lab153 = Convert.ToDecimal(Math.Round((Convert.ToDouble(ttextBox.Text) / Math.Pow(Convert.ToDouble(textBox2.Text), 2)), 4));
                    label156.Text = lab153.ToString();
                    label157.Text = Math.Round(Math.Pow(Convert.ToDouble(ttextBox.Text), 2), 2).ToString();
                    label159.Text = Math.Round(2 * Math.Pow(Convert.ToDouble(textBox2.Text), 2), 2).ToString();
                    decimal lab140 = Convert.ToDecimal(Math.Round(Math.Exp((-Math.Pow(Convert.ToDouble(ttextBox.Text), 2) / (2 * Math.Pow(Convert.ToDouble(textBox2.Text), 2)))), 4));
                    decimal lab160 = Math.Round(lab153 * lab140, 7);
                    label160.Text = lab160.ToString() + ";";
                }

                if (mtcheckBox.Checked)
                {
                    mtRelleyapanel.Visible = true;
                    label162.Text = textBox2.Text + " * √𝝅 / √2";
                    decimal lab164 = Convert.ToDecimal(Math.Round((Convert.ToDouble(textBox2.Text) * Math.Sqrt(Math.Round(Math.PI, 2) / 2)), 3));
                    label164.Text = lab164.ToString() + ";";
                }
            }

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lyamdaftpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void UNormalpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string filename = "pril1.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            string filename = "pril2.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != String.Empty)
            {
                if (PtcheckBox.Checked)
                {
                    PtNormalpanel.Visible = true;
                    label68.Text = textBox7.Text;
                    decimal lab71 = Convert.ToDecimal(Math.Round((0.5 - Convert.ToDouble(textBox7.Text)), 3));
                    label71.Text = lab71.ToString() + ";";
                }

                if (qtcheckBox.Checked)
                {
                    qtNormalpanel.Visible = true;
                    label75.Text = textBox7.Text;
                    decimal lab78 = Convert.ToDecimal(Math.Round((0.5 + Convert.ToDouble(textBox7.Text)), 3));
                    label78.Text = lab78.ToString() + ";";
                }
            }
            else
            {
                MessageBox.Show("Для начала введите значение функции Лапласа (см. Приложение 1)");

            }
        }

        private void qtNormalpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != String.Empty && textBox8.Text != String.Empty)
            {
                if (lyamdatcheckBox.Checked)
                {
                    lyamdaNormalpanel.Visible = true;
                    label81.Text = textBox8.Text;
                    label82.Text = textBox2.Text;
                    decimal lab49 = Convert.ToDecimal(Math.Round(((Convert.ToDouble(ttextBox.Text) - Convert.ToDouble(textBox1.Text)) / Convert.ToDouble(textBox2.Text)), 1));
                    label89.Text = "0,5 - Ф(" + lab49.ToString() + ")";
                    decimal lab79 = Convert.ToDecimal(Math.Round((Convert.ToDouble(textBox8.Text) / Convert.ToDouble(textBox2.Text)) * (1 / (0.5 - Convert.ToDouble(lab49))), 8));
                    label79.Text = lab79.ToString() + ";";
                }

                if (ftcheckBox.Checked)
                {
                    ftNormalpanel.Visible = true;
                    label92.Text = textBox8.Text;
                    label93.Text = textBox2.Text;
                    decimal lab90 = Convert.ToDecimal(Math.Round((Convert.ToDouble(textBox8.Text) / Convert.ToDouble(textBox2.Text)), 8));
                    label90.Text = lab90.ToString() + ";";
                }
            }
            else
            {
                MessageBox.Show("Для начала введите значения функции Лапласа и функции фи (см. Приложения 1 и 2)");

            }
        }

        private void Veybullapanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label134_Click(object sender, EventArgs e)
        {

        }

        private void label127_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != String.Empty)
            {
                if (Convert.ToDecimal(textBox3.Text) > 1)
                {
                    label126.Text = "Г(" + (Math.Round(Convert.ToDecimal((1 / (Convert.ToDecimal(textBox3.Text))) + 1), 3)).ToString() + ")";
                }
                else
                {
                    label126.Text = (Math.Round(Convert.ToDecimal((1 / (Convert.ToDecimal(textBox3.Text)))), 3)).ToString() + " * Г(" + (Math.Round(Convert.ToDecimal((1 / (Convert.ToDecimal(textBox3.Text)))), 3)).ToString() + ")";
                }
                decimal lab130 = Convert.ToDecimal(Math.Round(Math.Pow(Convert.ToDouble(textBox4.Text), Convert.ToDouble(1 / Convert.ToDouble(textBox3.Text))), 3));
                label130.Text = lab130.ToString();
                decimal lab132 = Convert.ToDecimal(Math.Round(Convert.ToDouble(textBox9.Text) / (Math.Pow(Convert.ToDouble(textBox4.Text), Convert.ToDouble(1 / Convert.ToDouble(textBox3.Text)))), 3));
                label132.Text = lab132.ToString() + ";";
            }
            else
            {
                MessageBox.Show("Для начала введите значение Гамма-функции (см. Приложение 3)"); 
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            string filename = "pril3.pdf";
            System.Diagnostics.Process.Start(filename);
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
