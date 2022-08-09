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
    public partial class practicLab1 : Form
    {
        public practicLab1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (lyamdatcheckBox.Checked)
            {
                ndeltattextBox.ReadOnly = false;
                ndeltattextBox.BackColor = Color.White;

                //  NsrtextBox.ReadOnly = false;
                //  NsrtextBox.BackColor = Color.White;

                deltattextBox.ReadOnly = false;
                deltattextBox.BackColor = Color.White;

                NtextBox.ReadOnly = false;
                NtextBox.BackColor = Color.White;

                ttextBox.ReadOnly = false;
                ttextBox.BackColor = Color.White;

                ndeltattextBox.ReadOnly = false;
                ndeltattextBox.BackColor = Color.White;

                nttextBox.ReadOnly = false;
                nttextBox.BackColor = Color.White;
            }
            else
            {
                ndeltattextBox.ReadOnly = true;
                ndeltattextBox.BackColor = Color.Gray;

                //   NsrtextBox.ReadOnly = true;
                //  NsrtextBox.BackColor = Color.Gray;

                deltattextBox.ReadOnly = true;
                deltattextBox.BackColor = Color.Gray;

                ttextBox.ReadOnly = true;
                ttextBox.BackColor = Color.Gray;

                NtextBox.ReadOnly = true;
                NtextBox.BackColor = Color.Gray;

                ndeltattextBox.ReadOnly = true;
                ndeltattextBox.BackColor = Color.Gray;

                nttextBox.ReadOnly = true;
                nttextBox.BackColor = Color.Gray;
            }
        }

        private void practicLab1_Load(object sender, EventArgs e)
        {

            // PttextBox.ReadOnly = true;
            // PttextBox.BackColor = Color.Gray;

            // fttextBox.ReadOnly = true;
            //  fttextBox.BackColor = Color.Gray;

            // qttextBox.ReadOnly = true;
            // qttextBox.BackColor = Color.Gray;

            // mttextBox.ReadOnly = true;
            // mttextBox.BackColor = Color.Gray;

            //lyamdattextBox.ReadOnly = true;
            // lyamdattextBox.BackColor = Color.Gray;

            NtextBox.ReadOnly = true;
            NtextBox.BackColor = Color.Gray;

            nttextBox.ReadOnly = true;
            nttextBox.BackColor = Color.Gray;

            ttextBox.ReadOnly = true;
            ttextBox.BackColor = Color.Gray;

            deltattextBox.ReadOnly = true;
            deltattextBox.BackColor = Color.Gray;

            ndeltattextBox.ReadOnly = true;
            ndeltattextBox.BackColor = Color.Gray;

            //NsrtextBox.ReadOnly = true;
            // NsrtextBox.BackColor = Color.Gray;

            mtpanel.Visible = false;
            Dtpanel.Visible = false;
            Ptpanel.Visible = false;
            qtpanel.Visible = false;
            ftpanel.Visible = false;
            Nsrpanel.Visible = false;
            lyamdatpanel.Visible = false;
            mtsecondpanel.Visible = false;

        }

        private void PttextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            //Pt
            if (PtcheckBox.Checked)
            {
                label24.Text = NtextBox.Text + " - " + nttextBox.Text;
                label25.Text = NtextBox.Text;
                label27.Text = (Math.Round(((Convert.ToDouble(NtextBox.Text) - Convert.ToDouble(nttextBox.Text)) / Convert.ToDouble(NtextBox.Text)), 3)).ToString() + ";";
                Ptpanel.Visible = true;
            }

            //q*(t)
            if (qtcheckBox.Checked)
            {
                label30.Text = NtextBox.Text;
                label32.Text = nttextBox.Text;
                label34.Text = (Math.Round((Convert.ToDouble(nttextBox.Text) / Convert.ToDouble(NtextBox.Text)), 6)).ToString() + ";";
                qtpanel.Visible = true;
            }

            //f*(t)
            if (ftcheckBox.Checked)
            {
                label37.Text = ndeltattextBox.Text;
                label40.Text = NtextBox.Text + " * " + deltattextBox.Text;
                label41.Text = (Math.Round((Convert.ToDecimal(ndeltattextBox.Text) / (Convert.ToDecimal(NtextBox.Text) * Convert.ToDecimal(deltattextBox.Text))), 6)).ToString() + ";";
                ftpanel.Visible = true;
            }

            //lyamdat
            if (lyamdatcheckBox.Checked)
            {
                label46.Text = ndeltattextBox.Text;
                label53.Text = "(" + NtextBox.Text + " - " + nttextBox.Text + ") + (" + NtextBox.Text + " - " + nttextBox.Text + " - " + ndeltattextBox.Text + ")";
                decimal Ni = ((Convert.ToDecimal(NtextBox.Text) - Convert.ToDecimal(nttextBox.Text)) + (Convert.ToDecimal(NtextBox.Text) - Convert.ToDecimal(nttextBox.Text) - Convert.ToDecimal(ndeltattextBox.Text)));
                label49.Text = (Ni / 2).ToString() + ";";
                label43.Text = (Ni / 2).ToString() + " * " + deltattextBox.Text;
                label42.Text = (Math.Round((Convert.ToDecimal(ndeltattextBox.Text) / (Ni / 2 * Convert.ToDecimal(deltattextBox.Text))), 6)).ToString() + ";";
                Nsrpanel.Visible = true;
                lyamdatpanel.Visible = true;
            }

            //m*t
            if (mtcheckBox.Checked)
            {
                
            }

            //D*(t)
            if (DtcheckBox.Checked)
            {
                //label44.Text = ((1 / Convert.ToDecimal(NtextBoxPanel2.Text))
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void PtcheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (PtcheckBox.Checked)
            {
                NtextBox.ReadOnly = false;
                NtextBox.BackColor = Color.White;
                nttextBox.ReadOnly = false;
                nttextBox.BackColor = Color.White;
                ttextBox.ReadOnly = false;
                ttextBox.BackColor = Color.White;

            }
            else
            {
                nttextBox.ReadOnly = true;
                nttextBox.BackColor = Color.Gray;

                NtextBox.ReadOnly = true;
                NtextBox.BackColor = Color.Gray;

                ttextBox.ReadOnly = true;
                ttextBox.BackColor = Color.Gray;
                Ptpanel.Visible = false;

            }
        }

        private void qtcheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (qtcheckBox.Checked)
            {
                NtextBox.ReadOnly = false;
                NtextBox.BackColor = Color.White;
                nttextBox.ReadOnly = false;
                nttextBox.BackColor = Color.White;
                ttextBox.ReadOnly = false;
                ttextBox.BackColor = Color.White;


            }
            else
            {
                nttextBox.ReadOnly = true;
                nttextBox.BackColor = Color.Gray;

                NtextBox.ReadOnly = true;
                NtextBox.BackColor = Color.Gray;

                ttextBox.ReadOnly = true;
                ttextBox.BackColor = Color.Gray;
                qtpanel.Visible = false;
            }
        }

        private void ftcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ftcheckBox.Checked)
            {
                ndeltattextBox.ReadOnly = false;
                ndeltattextBox.BackColor = Color.White;

                NtextBox.ReadOnly = false;
                NtextBox.BackColor = Color.White;

                deltattextBox.ReadOnly = false;
                deltattextBox.BackColor = Color.White;

                ttextBox.ReadOnly = false;
                ttextBox.BackColor = Color.White;

                nttextBox.ReadOnly = false;
                nttextBox.BackColor = Color.White;
            }
            else
            {
                ndeltattextBox.ReadOnly = true;
                ndeltattextBox.BackColor = Color.Gray;

                NtextBox.ReadOnly = true;
                NtextBox.BackColor = Color.Gray;

                deltattextBox.ReadOnly = true;
                deltattextBox.BackColor = Color.Gray;

                ttextBox.ReadOnly = true;
                ttextBox.BackColor = Color.Gray;

                nttextBox.ReadOnly = true;
                nttextBox.BackColor = Color.Gray;
            }
        }

        private void mtcheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (mtcheckBox.Checked)
            {
                mtpanel.Visible = true;
                mtsecondpanel.Visible = true;
                textBox23.ReadOnly = true;
                textBox23.BackColor = Color.Gray;

                textBox25.ReadOnly = true;
                textBox25.BackColor = Color.Gray;

                textBox26.ReadOnly = true;
                textBox26.BackColor = Color.Gray;

                textBox27.ReadOnly = true;
                textBox27.BackColor = Color.Gray;

                textBox28.ReadOnly = true;
                textBox28.BackColor = Color.Gray;

                textBox29.ReadOnly = true;
                textBox29.BackColor = Color.Gray;

                textBox30.ReadOnly = true;
                textBox30.BackColor = Color.Gray;

                textBox31.ReadOnly = true;
                textBox31.BackColor = Color.Gray;

                textBox32.ReadOnly = true;
                textBox32.BackColor = Color.Gray;

                textBox33.ReadOnly = true;
                textBox33.BackColor = Color.Gray;

                textBox34.ReadOnly = true;
                textBox34.BackColor = Color.Gray;

                textBox35.ReadOnly = true;
                textBox35.BackColor = Color.Gray;

                textBox36.ReadOnly = true;
                textBox36.BackColor = Color.Gray;

                textBox37.ReadOnly = true;
                textBox37.BackColor = Color.Gray;

                textBox38.ReadOnly = true;
                textBox38.BackColor = Color.Gray;

                textBox39.ReadOnly = true;
                textBox39.BackColor = Color.Gray;

                textBox40.ReadOnly = true;
                textBox40.BackColor = Color.Gray;

                textBox41.ReadOnly = true;
                textBox41.BackColor = Color.Gray;

                textBox42.ReadOnly = true;
                textBox42.BackColor = Color.Gray;

                textBox43.ReadOnly = true;
                textBox43.BackColor = Color.Gray;
            }
            else
            {
                mtpanel.Visible = false;
                mtsecondpanel.Visible = false;
            }
        }

        private void DtcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DtcheckBox.Checked)
            {
                Dtpanel.Visible = true;

                textBox1.ReadOnly = true;
                textBox1.BackColor = Color.Gray;

                textBox2.ReadOnly = true;
                textBox2.BackColor = Color.Gray;

                textBox4.ReadOnly = true;
                textBox4.BackColor = Color.Gray;

                textBox5.ReadOnly = true;
                textBox5.BackColor = Color.Gray;

                textBox6.ReadOnly = true;
                textBox6.BackColor = Color.Gray;

                textBox7.ReadOnly = true;
                textBox7.BackColor = Color.Gray;

                textBox8.ReadOnly = true;
                textBox8.BackColor = Color.Gray;

                textBox9.ReadOnly = true;
                textBox9.BackColor = Color.Gray;

                textBox10.ReadOnly = true;
                textBox10.BackColor = Color.Gray;

                textBox11.ReadOnly = true;
                textBox11.BackColor = Color.Gray;

                textBox12.ReadOnly = true;
                textBox12.BackColor = Color.Gray;

                textBox13.ReadOnly = true;
                textBox13.BackColor = Color.Gray;

                textBox14.ReadOnly = true;
                textBox14.BackColor = Color.Gray;

                textBox15.ReadOnly = true;
                textBox15.BackColor = Color.Gray;

                textBox16.ReadOnly = true;
                textBox16.BackColor = Color.Gray;

                textBox17.ReadOnly = true;
                textBox17.BackColor = Color.Gray;

                textBox18.ReadOnly = true;
                textBox18.BackColor = Color.Gray;

                textBox19.ReadOnly = true;
                textBox19.BackColor = Color.Gray;

                textBox20.ReadOnly = true;
                textBox20.BackColor = Color.Gray;

                textBox21.ReadOnly = true;
                textBox21.BackColor = Color.Gray;

            }
            else
            {
                Dtpanel.Visible = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void NtextBoxPanel1_TextChanged(object sender, EventArgs e)
        {
            NlabelPanel1.Text = NtextBoxPanel1.Text;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mtpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void NtextBoxPanel2_TextChanged(object sender, EventArgs e)
        {
            NlabelPanel2.Text = (Convert.ToInt32(NtextBoxPanel2.Text) + 1).ToString();
        }

        private void Ptpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label22_Click_1(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            mainForm main = new mainForm();
            main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ndeltattextBox.Clear();
            deltattextBox.Clear();
            ttextBox.Clear();
            nttextBox.Clear();
            NtextBox.Clear();
            mtpanel.Visible = false;
            Dtpanel.Visible = false;
            Mainpanel.Visible = false;
        }

        private void NtextBoxPanel2_TextChanged_1(object sender, EventArgs e)
        {
            if (NtextBoxPanel2.Text == String.Empty)
            {
                textBox1.ReadOnly = true;
                textBox1.BackColor = Color.Gray;

                textBox2.ReadOnly = true;
                textBox2.BackColor = Color.Gray;

                textBox4.ReadOnly = true;
                textBox4.BackColor = Color.Gray;

                textBox5.ReadOnly = true;
                textBox5.BackColor = Color.Gray;

                textBox6.ReadOnly = true;
                textBox6.BackColor = Color.Gray;

                textBox7.ReadOnly = true;
                textBox7.BackColor = Color.Gray;

                textBox8.ReadOnly = true;
                textBox8.BackColor = Color.Gray;

                textBox9.ReadOnly = true;
                textBox9.BackColor = Color.Gray;

                textBox10.ReadOnly = true;
                textBox10.BackColor = Color.Gray;

                textBox11.ReadOnly = true;
                textBox11.BackColor = Color.Gray;

                textBox12.ReadOnly = true;
                textBox12.BackColor = Color.Gray;

                textBox13.ReadOnly = true;
                textBox13.BackColor = Color.Gray;

                textBox14.ReadOnly = true;
                textBox14.BackColor = Color.Gray;

                textBox15.ReadOnly = true;
                textBox15.BackColor = Color.Gray;

                textBox16.ReadOnly = true;
                textBox16.BackColor = Color.Gray;

                textBox17.ReadOnly = true;
                textBox17.BackColor = Color.Gray;

                textBox18.ReadOnly = true;
                textBox18.BackColor = Color.Gray;

                textBox19.ReadOnly = true;
                textBox19.BackColor = Color.Gray;

                textBox20.ReadOnly = true;
                textBox20.BackColor = Color.Gray;

                textBox21.ReadOnly = true;
                textBox21.BackColor = Color.Gray;
            }
            else
            {

                switch (NtextBoxPanel2.Text)
                {
                    case "1":
                        textBox1.ReadOnly = false;
                        textBox1.BackColor = Color.White;

                        textBox21.ReadOnly = false;
                        textBox21.BackColor = Color.White;
                        break;

                    case "2":
                        textBox1.ReadOnly = false;
                        textBox1.BackColor = Color.White;
                   
                        textBox21.ReadOnly = false;
                        textBox21.BackColor = Color.White;

                        textBox2.ReadOnly = false;
                        textBox2.BackColor = Color.White;

                        textBox20.ReadOnly = false;
                        textBox20.BackColor = Color.White;
                        break;

                    case "3":
                        textBox1.ReadOnly = false;
                        textBox1.BackColor = Color.White;

                        textBox21.ReadOnly = false;
                        textBox21.BackColor = Color.White;

                        textBox2.ReadOnly = false;
                        textBox2.BackColor = Color.White;

                        textBox20.ReadOnly = false;
                        textBox20.BackColor = Color.White;

                        textBox4.ReadOnly = false;
                        textBox4.BackColor = Color.White;

                        textBox19.ReadOnly = false;
                        textBox19.BackColor = Color.White;
                        break;

                    case "4":
                        textBox1.ReadOnly = false;
                        textBox1.BackColor = Color.White;

                        textBox21.ReadOnly = false;
                        textBox21.BackColor = Color.White;

                        textBox2.ReadOnly = false;
                        textBox2.BackColor = Color.White;

                        textBox20.ReadOnly = false;
                        textBox20.BackColor = Color.White;

                        textBox4.ReadOnly = false;
                        textBox4.BackColor = Color.White;

                        textBox19.ReadOnly = false;
                        textBox19.BackColor = Color.White;

                        textBox5.ReadOnly = false;
                        textBox5.BackColor = Color.White;

                        textBox18.ReadOnly = false;
                        textBox18.BackColor = Color.White;
                        break;

                    case "5":
                        textBox1.ReadOnly = false;
                        textBox1.BackColor = Color.White;

                        textBox21.ReadOnly = false;
                        textBox21.BackColor = Color.White;

                        textBox2.ReadOnly = false;
                        textBox2.BackColor = Color.White;

                        textBox20.ReadOnly = false;
                        textBox20.BackColor = Color.White;

                        textBox4.ReadOnly = false;
                        textBox4.BackColor = Color.White;

                        textBox19.ReadOnly = false;
                        textBox19.BackColor = Color.White;

                        textBox5.ReadOnly = false;
                        textBox5.BackColor = Color.White;

                        textBox18.ReadOnly = false;
                        textBox18.BackColor = Color.White;

                        textBox6.ReadOnly = false;
                        textBox6.BackColor = Color.White;

                        textBox17.ReadOnly = false;
                        textBox17.BackColor = Color.White;
                        break;

                    case "6":
                        textBox1.ReadOnly = false;
                        textBox1.BackColor = Color.White;

                        textBox21.ReadOnly = false;
                        textBox21.BackColor = Color.White;

                        textBox2.ReadOnly = false;
                        textBox2.BackColor = Color.White;

                        textBox20.ReadOnly = false;
                        textBox20.BackColor = Color.White;

                        textBox4.ReadOnly = false;
                        textBox4.BackColor = Color.White;

                        textBox19.ReadOnly = false;
                        textBox19.BackColor = Color.White;

                        textBox5.ReadOnly = false;
                        textBox5.BackColor = Color.White;

                        textBox18.ReadOnly = false;
                        textBox18.BackColor = Color.White;

                        textBox6.ReadOnly = false;
                        textBox6.BackColor = Color.White;

                        textBox17.ReadOnly = false;
                        textBox17.BackColor = Color.White;

                        textBox7.ReadOnly = false;
                        textBox7.BackColor = Color.White;

                        textBox16.ReadOnly = false;
                        textBox16.BackColor = Color.White;
                        break;

                    case "7":
                        textBox1.ReadOnly = false;
                        textBox1.BackColor = Color.White;

                        textBox21.ReadOnly = false;
                        textBox21.BackColor = Color.White;

                        textBox2.ReadOnly = false;
                        textBox2.BackColor = Color.White;

                        textBox20.ReadOnly = false;
                        textBox20.BackColor = Color.White;

                        textBox4.ReadOnly = false;
                        textBox4.BackColor = Color.White;

                        textBox19.ReadOnly = false;
                        textBox19.BackColor = Color.White;

                        textBox5.ReadOnly = false;
                        textBox5.BackColor = Color.White;

                        textBox18.ReadOnly = false;
                        textBox18.BackColor = Color.White;

                        textBox6.ReadOnly = false;
                        textBox6.BackColor = Color.White;

                        textBox17.ReadOnly = false;
                        textBox17.BackColor = Color.White;

                        textBox7.ReadOnly = false;
                        textBox7.BackColor = Color.White;

                        textBox16.ReadOnly = false;
                        textBox16.BackColor = Color.White;

                        textBox8.ReadOnly = false;
                        textBox8.BackColor = Color.White;

                        textBox15.ReadOnly = false;
                        textBox15.BackColor = Color.White;
                        break;

                    case "8":
                        textBox1.ReadOnly = false;
                        textBox1.BackColor = Color.White;

                        textBox21.ReadOnly = false;
                        textBox21.BackColor = Color.White;

                        textBox2.ReadOnly = false;
                        textBox2.BackColor = Color.White;

                        textBox20.ReadOnly = false;
                        textBox20.BackColor = Color.White;

                        textBox4.ReadOnly = false;
                        textBox4.BackColor = Color.White;

                        textBox19.ReadOnly = false;
                        textBox19.BackColor = Color.White;

                        textBox5.ReadOnly = false;
                        textBox5.BackColor = Color.White;

                        textBox18.ReadOnly = false;
                        textBox18.BackColor = Color.White;

                        textBox6.ReadOnly = false;
                        textBox6.BackColor = Color.White;

                        textBox17.ReadOnly = false;
                        textBox17.BackColor = Color.White;

                        textBox7.ReadOnly = false;
                        textBox7.BackColor = Color.White;

                        textBox16.ReadOnly = false;
                        textBox16.BackColor = Color.White;

                        textBox8.ReadOnly = false;
                        textBox8.BackColor = Color.White;

                        textBox15.ReadOnly = false;
                        textBox15.BackColor = Color.White;

                        textBox9.ReadOnly = false;
                        textBox9.BackColor = Color.White;

                        textBox14.ReadOnly = false;
                        textBox14.BackColor = Color.White;
                        break;

                    case "9":
                        textBox1.ReadOnly = false;
                        textBox1.BackColor = Color.White;

                        textBox21.ReadOnly = false;
                        textBox21.BackColor = Color.White;

                        textBox2.ReadOnly = false;
                        textBox2.BackColor = Color.White;

                        textBox20.ReadOnly = false;
                        textBox20.BackColor = Color.White;

                        textBox4.ReadOnly = false;
                        textBox4.BackColor = Color.White;

                        textBox19.ReadOnly = false;
                        textBox19.BackColor = Color.White;

                        textBox5.ReadOnly = false;
                        textBox5.BackColor = Color.White;

                        textBox18.ReadOnly = false;
                        textBox18.BackColor = Color.White;

                        textBox6.ReadOnly = false;
                        textBox6.BackColor = Color.White;

                        textBox17.ReadOnly = false;
                        textBox17.BackColor = Color.White;

                        textBox7.ReadOnly = false;
                        textBox7.BackColor = Color.White;

                        textBox16.ReadOnly = false;
                        textBox16.BackColor = Color.White;

                        textBox8.ReadOnly = false;
                        textBox8.BackColor = Color.White;

                        textBox15.ReadOnly = false;
                        textBox15.BackColor = Color.White;

                        textBox9.ReadOnly = false;
                        textBox9.BackColor = Color.White;

                        textBox14.ReadOnly = false;
                        textBox14.BackColor = Color.White;

                        textBox10.ReadOnly = false;
                        textBox10.BackColor = Color.White;

                        textBox13.ReadOnly = false;
                        textBox13.BackColor = Color.White;
                        break;

                    case "10":
                        textBox1.ReadOnly = false;
                        textBox1.BackColor = Color.White;

                        textBox21.ReadOnly = false;
                        textBox21.BackColor = Color.White;

                        textBox2.ReadOnly = false;
                        textBox2.BackColor = Color.White;

                        textBox20.ReadOnly = false;
                        textBox20.BackColor = Color.White;

                        textBox4.ReadOnly = false;
                        textBox4.BackColor = Color.White;

                        textBox19.ReadOnly = false;
                        textBox19.BackColor = Color.White;

                        textBox5.ReadOnly = false;
                        textBox5.BackColor = Color.White;

                        textBox18.ReadOnly = false;
                        textBox18.BackColor = Color.White;

                        textBox6.ReadOnly = false;
                        textBox6.BackColor = Color.White;

                        textBox17.ReadOnly = false;
                        textBox17.BackColor = Color.White;

                        textBox7.ReadOnly = false;
                        textBox7.BackColor = Color.White;

                        textBox16.ReadOnly = false;
                        textBox16.BackColor = Color.White;

                        textBox8.ReadOnly = false;
                        textBox8.BackColor = Color.White;

                        textBox15.ReadOnly = false;
                        textBox15.BackColor = Color.White;

                        textBox9.ReadOnly = false;
                        textBox9.BackColor = Color.White;

                        textBox14.ReadOnly = false;
                        textBox14.BackColor = Color.White;

                        textBox10.ReadOnly = false;
                        textBox10.BackColor = Color.White;

                        textBox13.ReadOnly = false;
                        textBox13.BackColor = Color.White;

                        textBox11.ReadOnly = false;
                        textBox11.BackColor = Color.White;

                        textBox12.ReadOnly = false;
                        textBox12.BackColor = Color.White;
                        break;

                    default:
                        textBox1.ReadOnly = true;
                        textBox1.BackColor = Color.Gray;

                        textBox2.ReadOnly = true;
                        textBox2.BackColor = Color.Gray;

                        textBox4.ReadOnly = true;
                        textBox4.BackColor = Color.Gray;

                        textBox5.ReadOnly = true;
                        textBox5.BackColor = Color.Gray;

                        textBox6.ReadOnly = true;
                        textBox6.BackColor = Color.Gray;

                        textBox7.ReadOnly = true;
                        textBox7.BackColor = Color.Gray;

                        textBox8.ReadOnly = true;
                        textBox8.BackColor = Color.Gray;

                        textBox9.ReadOnly = true;
                        textBox9.BackColor = Color.Gray;

                        textBox10.ReadOnly = true;
                        textBox10.BackColor = Color.Gray;

                        textBox11.ReadOnly = true;
                        textBox11.BackColor = Color.Gray;

                        textBox12.ReadOnly = true;
                        textBox12.BackColor = Color.Gray;

                        textBox13.ReadOnly = true;
                        textBox13.BackColor = Color.Gray;

                        textBox14.ReadOnly = true;
                        textBox14.BackColor = Color.Gray;

                        textBox15.ReadOnly = true;
                        textBox15.BackColor = Color.Gray;

                        textBox16.ReadOnly = true;
                        textBox16.BackColor = Color.Gray;

                        textBox17.ReadOnly = true;
                        textBox17.BackColor = Color.Gray;

                        textBox18.ReadOnly = true;
                        textBox18.BackColor = Color.Gray;

                        textBox19.ReadOnly = true;
                        textBox19.BackColor = Color.Gray;

                        textBox20.ReadOnly = true;
                        textBox20.BackColor = Color.Gray;

                        textBox21.ReadOnly = true;
                        textBox21.BackColor = Color.Gray;
                        break;
                }

            }
        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void mtcost_Click(object sender, EventArgs e)
        {
            resultlabelPanel1.Text = (Math.Round(((1 / Convert.ToDecimal(NtextBoxPanel1.Text)) * Convert.ToDecimal(textBox3.Text)), 5)).ToString() + ";";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            switch (NtextBoxPanel2.Text)
            {
                case "1":
                    label65.Text = (Math.Round((Math.Pow(Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox21.Text), 2)) / Convert.ToDouble(NtextBoxPanel2.Text), 3)).ToString();
                break;

                case "2":
                    label65.Text = (Math.Round(Math.Pow(Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox21.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox20.Text), 2) / Convert.ToDouble(NtextBoxPanel2.Text), 3)).ToString();
                break;

                case "3":
                    label65.Text = (Math.Round(Math.Pow(Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox21.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox20.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox4.Text) - Convert.ToDouble(textBox19.Text), 2) / Convert.ToDouble(NtextBoxPanel2.Text), 3)).ToString();
                break;

                case "4":
                    label65.Text = (Math.Round(Math.Pow(Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox21.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox20.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox4.Text) - Convert.ToDouble(textBox19.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox5.Text) - Convert.ToDouble(textBox18.Text), 2) / Convert.ToDouble(NtextBoxPanel2.Text), 3)).ToString();
                break;

                case "5":
                    label65.Text = (Math.Round(Math.Pow(Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox21.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox20.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox4.Text) - Convert.ToDouble(textBox19.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox5.Text) - Convert.ToDouble(textBox18.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox6.Text) - Convert.ToDouble(textBox17.Text), 2) / Convert.ToDouble(NtextBoxPanel2.Text), 3)).ToString();
                break;

                case "6":
                    label65.Text = (Math.Round(Math.Pow(Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox21.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox20.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox4.Text) - Convert.ToDouble(textBox19.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox5.Text) - Convert.ToDouble(textBox18.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox6.Text) - Convert.ToDouble(textBox17.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox7.Text) - Convert.ToDouble(textBox16.Text), 2) / Convert.ToDouble(NtextBoxPanel2.Text), 3)).ToString();
                break;

                case "7":
                    label65.Text = (Math.Round(Math.Pow(Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox21.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox20.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox4.Text) - Convert.ToDouble(textBox19.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox5.Text) - Convert.ToDouble(textBox18.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox6.Text) - Convert.ToDouble(textBox17.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox7.Text) - Convert.ToDouble(textBox16.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox8.Text) - Convert.ToDouble(textBox15.Text), 2) / Convert.ToDouble(NtextBoxPanel2.Text), 3)).ToString();
                break;

                case "8":
                    label65.Text = (Math.Round(Math.Pow(Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox21.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox20.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox4.Text) - Convert.ToDouble(textBox19.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox5.Text) - Convert.ToDouble(textBox18.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox6.Text) - Convert.ToDouble(textBox17.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox7.Text) - Convert.ToDouble(textBox16.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox8.Text) - Convert.ToDouble(textBox15.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox9.Text) - Convert.ToDouble(textBox14.Text), 2) / Convert.ToDouble(NtextBoxPanel2.Text), 3)).ToString();
                break;

                case "9":
                    label65.Text = (Math.Round(Math.Pow(Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox21.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox20.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox4.Text) - Convert.ToDouble(textBox19.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox5.Text) - Convert.ToDouble(textBox18.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox6.Text) - Convert.ToDouble(textBox17.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox7.Text) - Convert.ToDouble(textBox16.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox8.Text) - Convert.ToDouble(textBox15.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox9.Text) - Convert.ToDouble(textBox14.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox10.Text) - Convert.ToDouble(textBox13.Text), 2) / Convert.ToDouble(NtextBoxPanel2.Text), 3)).ToString();
                break;

                case "10":
                    label65.Text = (Math.Round(Math.Pow(Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox21.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox20.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox4.Text) - Convert.ToDouble(textBox19.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox5.Text) - Convert.ToDouble(textBox18.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox6.Text) - Convert.ToDouble(textBox17.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox7.Text) - Convert.ToDouble(textBox16.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox8.Text) - Convert.ToDouble(textBox15.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox9.Text) - Convert.ToDouble(textBox14.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox10.Text) - Convert.ToDouble(textBox13.Text), 2)
                        + Math.Pow(Convert.ToDouble(textBox11.Text) - Convert.ToDouble(textBox12.Text), 2) / Convert.ToDouble(NtextBoxPanel2.Text), 3)).ToString();
                break;
                default:
                    MessageBox.Show("Введите значения!");
                break;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            label65.Text = "";
            NtextBoxPanel2.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (textBox22.Text == String.Empty)
            {
                textBox23.ReadOnly = true;
                textBox23.BackColor = Color.Gray;

                textBox25.ReadOnly = true;
                textBox25.BackColor = Color.Gray;

                textBox26.ReadOnly = true;
                textBox26.BackColor = Color.Gray;

                textBox27.ReadOnly = true;
                textBox27.BackColor = Color.Gray;

                textBox28.ReadOnly = true;
                textBox28.BackColor = Color.Gray;

                textBox29.ReadOnly = true;
                textBox29.BackColor = Color.Gray;

                textBox30.ReadOnly = true;
                textBox30.BackColor = Color.Gray;

                textBox31.ReadOnly = true;
                textBox31.BackColor = Color.Gray;

                textBox32.ReadOnly = true;
                textBox32.BackColor = Color.Gray;

                textBox33.ReadOnly = true;
                textBox33.BackColor = Color.Gray;

                textBox34.ReadOnly = true;
                textBox34.BackColor = Color.Gray;

                textBox35.ReadOnly = true;
                textBox35.BackColor = Color.Gray;

                textBox36.ReadOnly = true;
                textBox36.BackColor = Color.Gray;

                textBox37.ReadOnly = true;
                textBox37.BackColor = Color.Gray;

                textBox38.ReadOnly = true;
                textBox38.BackColor = Color.Gray;

                textBox39.ReadOnly = true;
                textBox39.BackColor = Color.Gray;

                textBox40.ReadOnly = true;
                textBox40.BackColor = Color.Gray;

                textBox41.ReadOnly = true;
                textBox41.BackColor = Color.Gray;

                textBox42.ReadOnly = true;
                textBox42.BackColor = Color.Gray;

                textBox43.ReadOnly = true;
                textBox43.BackColor = Color.Gray;
            }
            else
            {

                switch (textBox22.Text)
                {
                    case "1":
                        textBox43.ReadOnly = false;
                        textBox43.BackColor = Color.White;

                        textBox33.ReadOnly = false;
                        textBox33.BackColor = Color.White;
                        break;

                    case "2":
                        textBox43.ReadOnly = false;
                        textBox43.BackColor = Color.White;

                        textBox33.ReadOnly = false;
                        textBox33.BackColor = Color.White;

                        textBox42.ReadOnly = false;
                        textBox42.BackColor = Color.White;

                        textBox32.ReadOnly = false;
                        textBox32.BackColor = Color.White;
                        break;

                    case "3":
                        textBox43.ReadOnly = false;
                        textBox43.BackColor = Color.White;

                        textBox33.ReadOnly = false;
                        textBox33.BackColor = Color.White;

                        textBox42.ReadOnly = false;
                        textBox42.BackColor = Color.White;

                        textBox32.ReadOnly = false;
                        textBox32.BackColor = Color.White;

                        textBox41.ReadOnly = false;
                        textBox41.BackColor = Color.White;

                        textBox31.ReadOnly = false;
                        textBox31.BackColor = Color.White;
                        break;

                    case "4":
                        textBox43.ReadOnly = false;
                        textBox43.BackColor = Color.White;

                        textBox33.ReadOnly = false;
                        textBox33.BackColor = Color.White;

                        textBox42.ReadOnly = false;
                        textBox42.BackColor = Color.White;

                        textBox32.ReadOnly = false;
                        textBox32.BackColor = Color.White;

                        textBox41.ReadOnly = false;
                        textBox41.BackColor = Color.White;

                        textBox31.ReadOnly = false;
                        textBox31.BackColor = Color.White;

                        textBox40.ReadOnly = false;
                        textBox40.BackColor = Color.White;

                        textBox30.ReadOnly = false;
                        textBox30.BackColor = Color.White;
                        break;

                    case "5":
                        textBox43.ReadOnly = false;
                        textBox43.BackColor = Color.White;

                        textBox33.ReadOnly = false;
                        textBox33.BackColor = Color.White;

                        textBox42.ReadOnly = false;
                        textBox42.BackColor = Color.White;

                        textBox32.ReadOnly = false;
                        textBox32.BackColor = Color.White;

                        textBox41.ReadOnly = false;
                        textBox41.BackColor = Color.White;

                        textBox31.ReadOnly = false;
                        textBox31.BackColor = Color.White;

                        textBox40.ReadOnly = false;
                        textBox40.BackColor = Color.White;

                        textBox30.ReadOnly = false;
                        textBox30.BackColor = Color.White;

                        textBox39.ReadOnly = false;
                        textBox39.BackColor = Color.White;

                        textBox29.ReadOnly = false;
                        textBox29.BackColor = Color.White;
                        break;

                    case "6":
                        textBox43.ReadOnly = false;
                        textBox43.BackColor = Color.White;

                        textBox33.ReadOnly = false;
                        textBox33.BackColor = Color.White;

                        textBox42.ReadOnly = false;
                        textBox42.BackColor = Color.White;

                        textBox32.ReadOnly = false;
                        textBox32.BackColor = Color.White;

                        textBox41.ReadOnly = false;
                        textBox41.BackColor = Color.White;

                        textBox31.ReadOnly = false;
                        textBox31.BackColor = Color.White;

                        textBox40.ReadOnly = false;
                        textBox40.BackColor = Color.White;

                        textBox30.ReadOnly = false;
                        textBox30.BackColor = Color.White;

                        textBox39.ReadOnly = false;
                        textBox39.BackColor = Color.White;

                        textBox29.ReadOnly = false;
                        textBox29.BackColor = Color.White;

                        textBox38.ReadOnly = false;
                        textBox38.BackColor = Color.White;

                        textBox28.ReadOnly = false;
                        textBox28.BackColor = Color.White;
                        break;

                    case "7":
                        textBox43.ReadOnly = false;
                        textBox43.BackColor = Color.White;

                        textBox33.ReadOnly = false;
                        textBox33.BackColor = Color.White;

                        textBox42.ReadOnly = false;
                        textBox42.BackColor = Color.White;

                        textBox32.ReadOnly = false;
                        textBox32.BackColor = Color.White;

                        textBox41.ReadOnly = false;
                        textBox41.BackColor = Color.White;

                        textBox31.ReadOnly = false;
                        textBox31.BackColor = Color.White;

                        textBox40.ReadOnly = false;
                        textBox40.BackColor = Color.White;

                        textBox30.ReadOnly = false;
                        textBox30.BackColor = Color.White;

                        textBox39.ReadOnly = false;
                        textBox39.BackColor = Color.White;

                        textBox29.ReadOnly = false;
                        textBox29.BackColor = Color.White;

                        textBox38.ReadOnly = false;
                        textBox38.BackColor = Color.White;

                        textBox28.ReadOnly = false;
                        textBox28.BackColor = Color.White;

                        textBox37.ReadOnly = false;
                        textBox37.BackColor = Color.White;

                        textBox27.ReadOnly = false;
                        textBox27.BackColor = Color.White;
                        break;

                    case "8":
                        textBox43.ReadOnly = false;
                        textBox43.BackColor = Color.White;

                        textBox33.ReadOnly = false;
                        textBox33.BackColor = Color.White;

                        textBox42.ReadOnly = false;
                        textBox42.BackColor = Color.White;

                        textBox32.ReadOnly = false;
                        textBox32.BackColor = Color.White;

                        textBox41.ReadOnly = false;
                        textBox41.BackColor = Color.White;

                        textBox31.ReadOnly = false;
                        textBox31.BackColor = Color.White;

                        textBox40.ReadOnly = false;
                        textBox40.BackColor = Color.White;

                        textBox30.ReadOnly = false;
                        textBox30.BackColor = Color.White;

                        textBox39.ReadOnly = false;
                        textBox39.BackColor = Color.White;

                        textBox29.ReadOnly = false;
                        textBox29.BackColor = Color.White;

                        textBox38.ReadOnly = false;
                        textBox38.BackColor = Color.White;

                        textBox28.ReadOnly = false;
                        textBox28.BackColor = Color.White;

                        textBox37.ReadOnly = false;
                        textBox37.BackColor = Color.White;

                        textBox27.ReadOnly = false;
                        textBox27.BackColor = Color.White;

                        textBox36.ReadOnly = false;
                        textBox36.BackColor = Color.White;

                        textBox26.ReadOnly = false;
                        textBox26.BackColor = Color.White;
                        break;

                    case "9":
                        textBox43.ReadOnly = false;
                        textBox43.BackColor = Color.White;

                        textBox33.ReadOnly = false;
                        textBox33.BackColor = Color.White;

                        textBox42.ReadOnly = false;
                        textBox42.BackColor = Color.White;

                        textBox32.ReadOnly = false;
                        textBox32.BackColor = Color.White;

                        textBox41.ReadOnly = false;
                        textBox41.BackColor = Color.White;

                        textBox31.ReadOnly = false;
                        textBox31.BackColor = Color.White;

                        textBox40.ReadOnly = false;
                        textBox40.BackColor = Color.White;

                        textBox30.ReadOnly = false;
                        textBox30.BackColor = Color.White;

                        textBox39.ReadOnly = false;
                        textBox39.BackColor = Color.White;

                        textBox29.ReadOnly = false;
                        textBox29.BackColor = Color.White;

                        textBox38.ReadOnly = false;
                        textBox38.BackColor = Color.White;

                        textBox28.ReadOnly = false;
                        textBox28.BackColor = Color.White;

                        textBox37.ReadOnly = false;
                        textBox37.BackColor = Color.White;

                        textBox27.ReadOnly = false;
                        textBox27.BackColor = Color.White;

                        textBox36.ReadOnly = false;
                        textBox36.BackColor = Color.White;

                        textBox26.ReadOnly = false;
                        textBox26.BackColor = Color.White;

                        textBox35.ReadOnly = false;
                        textBox35.BackColor = Color.White;

                        textBox25.ReadOnly = false;
                        textBox25.BackColor = Color.White;
                        break;

                    case "10":
                        textBox43.ReadOnly = false;
                        textBox43.BackColor = Color.White;

                        textBox33.ReadOnly = false;
                        textBox33.BackColor = Color.White;

                        textBox42.ReadOnly = false;
                        textBox42.BackColor = Color.White;

                        textBox32.ReadOnly = false;
                        textBox32.BackColor = Color.White;

                        textBox41.ReadOnly = false;
                        textBox41.BackColor = Color.White;

                        textBox31.ReadOnly = false;
                        textBox31.BackColor = Color.White;

                        textBox40.ReadOnly = false;
                        textBox40.BackColor = Color.White;

                        textBox30.ReadOnly = false;
                        textBox30.BackColor = Color.White;

                        textBox39.ReadOnly = false;
                        textBox39.BackColor = Color.White;

                        textBox29.ReadOnly = false;
                        textBox29.BackColor = Color.White;

                        textBox38.ReadOnly = false;
                        textBox38.BackColor = Color.White;

                        textBox28.ReadOnly = false;
                        textBox28.BackColor = Color.White;

                        textBox37.ReadOnly = false;
                        textBox37.BackColor = Color.White;

                        textBox27.ReadOnly = false;
                        textBox27.BackColor = Color.White;

                        textBox36.ReadOnly = false;
                        textBox36.BackColor = Color.White;

                        textBox26.ReadOnly = false;
                        textBox26.BackColor = Color.White;

                        textBox35.ReadOnly = false;
                        textBox35.BackColor = Color.White;

                        textBox25.ReadOnly = false;
                        textBox25.BackColor = Color.White;

                        textBox34.ReadOnly = false;
                        textBox34.BackColor = Color.White;

                        textBox23.ReadOnly = false;
                        textBox23.BackColor = Color.White;
                        break;
                } 
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            switch (textBox22.Text)
            { 
                case "1":
                    label83.Text = (Math.Round(Convert.ToDouble(textBox43.Text) * Convert.ToDouble(textBox33.Text) / Convert.ToDouble(textBox24.Text), 3)).ToString();
                    break;

                case "2":
                    label83.Text = (Math.Round(Convert.ToDouble(textBox43.Text) * Convert.ToDouble(textBox33.Text)
                        + (Convert.ToDouble(textBox42.Text) * Convert.ToDouble(textBox32.Text) / Convert.ToDouble(textBox24.Text)), 3)).ToString();
                    break;

                case "3":
                    label83.Text = (Math.Round(Convert.ToDouble(textBox43.Text) * Convert.ToDouble(textBox33.Text)
                        + (Convert.ToDouble(textBox42.Text) * Convert.ToDouble(textBox32.Text))
                        + (Convert.ToDouble(textBox41.Text) * Convert.ToDouble(textBox31.Text) / Convert.ToDouble(textBox24.Text)), 3)).ToString();
                    break;

                case "4":
                    label83.Text = (Math.Round(Convert.ToDouble(textBox43.Text) * Convert.ToDouble(textBox33.Text)
                        + (Convert.ToDouble(textBox42.Text) * Convert.ToDouble(textBox32.Text))
                        + (Convert.ToDouble(textBox41.Text) * Convert.ToDouble(textBox31.Text)
                        + (Convert.ToDouble(textBox40.Text) * Convert.ToDouble(textBox30.Text)) / Convert.ToDouble(textBox24.Text)), 3)).ToString();
                    break;

                case "5":
                    label83.Text = (Math.Round(Convert.ToDouble(textBox43.Text) * Convert.ToDouble(textBox33.Text)
                        + (Convert.ToDouble(textBox42.Text) * Convert.ToDouble(textBox32.Text))
                        + (Convert.ToDouble(textBox41.Text) * Convert.ToDouble(textBox31.Text)
                        + (Convert.ToDouble(textBox40.Text) * Convert.ToDouble(textBox30.Text)) 
                        + (Convert.ToDouble(textBox39.Text) * Convert.ToDouble(textBox29.Text)) / Convert.ToDouble(textBox24.Text)), 3)).ToString();
                    break;

                case "6":
                    label83.Text = (Math.Round(Convert.ToDouble(textBox43.Text) * Convert.ToDouble(textBox33.Text)
                        + (Convert.ToDouble(textBox42.Text) * Convert.ToDouble(textBox32.Text))
                        + (Convert.ToDouble(textBox41.Text) * Convert.ToDouble(textBox31.Text)
                        + (Convert.ToDouble(textBox40.Text) * Convert.ToDouble(textBox30.Text))
                        + (Convert.ToDouble(textBox39.Text) * Convert.ToDouble(textBox29.Text))
                        + (Convert.ToDouble(textBox38.Text) * Convert.ToDouble(textBox28.Text)) / Convert.ToDouble(textBox24.Text)), 3)).ToString();
                    break;

                case "7":
                    label83.Text = (Math.Round(Convert.ToDouble(textBox43.Text) * Convert.ToDouble(textBox33.Text)
                        + (Convert.ToDouble(textBox42.Text) * Convert.ToDouble(textBox32.Text))
                        + (Convert.ToDouble(textBox41.Text) * Convert.ToDouble(textBox31.Text)
                        + (Convert.ToDouble(textBox40.Text) * Convert.ToDouble(textBox30.Text))
                        + (Convert.ToDouble(textBox39.Text) * Convert.ToDouble(textBox29.Text))
                        + (Convert.ToDouble(textBox38.Text) * Convert.ToDouble(textBox28.Text))
                        + (Convert.ToDouble(textBox37.Text) * Convert.ToDouble(textBox27.Text)) / Convert.ToDouble(textBox24.Text)), 3)).ToString();
                    break;

                case "8":
                    label83.Text = (Math.Round(Convert.ToDouble(textBox43.Text) * Convert.ToDouble(textBox33.Text)
                        + (Convert.ToDouble(textBox42.Text) * Convert.ToDouble(textBox32.Text))
                        + (Convert.ToDouble(textBox41.Text) * Convert.ToDouble(textBox31.Text)
                        + (Convert.ToDouble(textBox40.Text) * Convert.ToDouble(textBox30.Text))
                        + (Convert.ToDouble(textBox39.Text) * Convert.ToDouble(textBox29.Text))
                        + (Convert.ToDouble(textBox38.Text) * Convert.ToDouble(textBox28.Text))
                        + (Convert.ToDouble(textBox37.Text) * Convert.ToDouble(textBox27.Text))
                        + (Convert.ToDouble(textBox36.Text) * Convert.ToDouble(textBox26.Text)) / Convert.ToDouble(textBox24.Text)), 3)).ToString();
                    break;

                case "9":
                    label83.Text = (Math.Round(Convert.ToDouble(textBox43.Text) * Convert.ToDouble(textBox33.Text)
                        + (Convert.ToDouble(textBox42.Text) * Convert.ToDouble(textBox32.Text))
                        + (Convert.ToDouble(textBox41.Text) * Convert.ToDouble(textBox31.Text)
                        + (Convert.ToDouble(textBox40.Text) * Convert.ToDouble(textBox30.Text))
                        + (Convert.ToDouble(textBox39.Text) * Convert.ToDouble(textBox29.Text))
                        + (Convert.ToDouble(textBox38.Text) * Convert.ToDouble(textBox28.Text))
                        + (Convert.ToDouble(textBox37.Text) * Convert.ToDouble(textBox27.Text))
                        + (Convert.ToDouble(textBox36.Text) * Convert.ToDouble(textBox26.Text))
                        + (Convert.ToDouble(textBox35.Text) * Convert.ToDouble(textBox25.Text)) / Convert.ToDouble(textBox24.Text)), 3)).ToString();
                    break;

                case "10":
                    label83.Text = (Math.Round(Convert.ToDouble(textBox43.Text) * Convert.ToDouble(textBox33.Text)
                        + (Convert.ToDouble(textBox42.Text) * Convert.ToDouble(textBox32.Text))
                        + (Convert.ToDouble(textBox41.Text) * Convert.ToDouble(textBox31.Text)
                        + (Convert.ToDouble(textBox40.Text) * Convert.ToDouble(textBox30.Text))
                        + (Convert.ToDouble(textBox39.Text) * Convert.ToDouble(textBox29.Text))
                        + (Convert.ToDouble(textBox38.Text) * Convert.ToDouble(textBox28.Text))
                        + (Convert.ToDouble(textBox37.Text) * Convert.ToDouble(textBox27.Text))
                        + (Convert.ToDouble(textBox36.Text) * Convert.ToDouble(textBox26.Text))
                        + (Convert.ToDouble(textBox35.Text) * Convert.ToDouble(textBox25.Text))
                        + (Convert.ToDouble(textBox34.Text) * Convert.ToDouble(textBox23.Text)) / Convert.ToDouble(textBox24.Text)), 3)).ToString();
                    break;
            }
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            textBox22.Clear();
            textBox24.Clear();
            textBox23.Clear();
            textBox25.Clear();
            textBox26.Clear();
            textBox27.Clear();
            textBox28.Clear();
            textBox29.Clear();
            textBox30.Clear();
            textBox31.Clear();
            textBox32.Clear();
            textBox33.Clear();
            textBox34.Clear();
            textBox35.Clear();
            textBox36.Clear();
            textBox37.Clear();
            textBox38.Clear();
            textBox39.Clear();
            textBox40.Clear();
            textBox41.Clear();
            textBox42.Clear();
            textBox43.Clear();
            label83.Text = "";
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
