using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplomnya_rabota
{
    public partial class tasksAddForm : Form
    {
        public tasksAddForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacherMainForm teacherMain = new teacherMainForm();
            teacherMain.ShowDialog();
        }

        private void tasksAddForm_Load(object sender, EventArgs e)
        {
            button1.TabStop = false;
            button2.TabStop = false;
            button3.TabStop = false;
            button4.TabStop = false;
            button5.TabStop = false;
            button6.TabStop = false;
            button7.TabStop = false;
            button8.TabStop = false;
            button9.TabStop = false;
            button10.TabStop = false;
        
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            lab1panel.Visible = true;
            lab2panel.Visible = false;
        }

        private void lab1panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Black;
            panel7.BackColor = Color.Black;
            
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Gray;
            panel7.BackColor = Color.Gray;
            
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            label9.ForeColor = Color.Black;
            panel8.BackColor = Color.Black;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.ForeColor = Color.Gray;
            panel8.BackColor = Color.Gray;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            practicLab1 lab1 = new practicLab1();
            lab1.Show();
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

        private void label8_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = ".doc";
            saveFileDialog1.Filter = "Текстовый файл*|.doc";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, true))
                {
                    sw.WriteLine(richTextBox1.Text);
                    sw.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "На испытание поставлено 100 однотипных изделий. За 4000 час. отказало 50 изделий. За интервал времени 4000 - 4100 час. отказало ещё 20 изделий. Требуется определить f∗(t), λ∗(t) при t = 4000 час.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "На испытание поставлено 8 однотипных изделий. Получены следующие значения ti (ti - время безотказной работы i-го изделия): t1 = 560час.; t2 = 700час.; t3 = 800час.; t4 = 650час.; t5 = 580час.; t6 = =760час.; t7 = 920час.; t8 = 850час. Определить статистическую оценку среднего времени безотказной работы изделия.";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "За наблюдаемый период эксплуатации в аппаратуре было зарегистрировано 6 отказов. Время восстановления составило: t1 = 15мин.; t2 = 20мин.; t3 = 10мин.; t4 = 28мин.; t5 = 22мин.; t6 = 30мин. Требуется определить среднее время восстановления аппаратуры mtв∗.";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "На испытание поставлено 1000 изделий. За время t = 11000 час. вышло из строя 510 изделий. За последующий интервал времени 11000-12000 час. вышло из строя еще 140 изделий. Необходимо вычислить P∗(t) при t = 11000 час. и t = 12000 час., а также f∗(t), λ∗(t) при t = 11000 час.";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "На испытание поставлено 65 изделий. За время t = 100 час. вышло из строя 35 изделий. За последующий интервал времени 100 - 105 час. вышло из строя еще 5 изделий. Необходимо вычислить P∗(t) при t= 100час. и t = 105 час.; f∗(t), λ∗(t) при t = 100 час.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lab2panel.Visible = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            practicLab2 lab2 = new practicLab2();
            lab2.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = ".doc";
            saveFileDialog1.Filter = "Текстовый файл*|.doc";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, true))
                {
                    sw.WriteLine(richTextBox2.Text);
                    sw.Close();
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "Вероятность безотказной работы автоматической линии изготовления запасных частей в течении 120 час. равна 0.9. Предполагается, что справедлив экспоненциальный закон надежности. Требуется рассчитать интенсивность отказов и частоту отказов линии для момента времени t = 120 час., а также среднее время безотказной работы.";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "Среднее время безотказной работы автоматической системы управления равно 700 час. Предполагается, что справедлив экспоненциальный закон надежности. Необходимо определить вероятность безотказной работы в течение 150 час., частоту отказов для момента времени t = 150 час и интенсивность отказов.";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "Время работы изделия подчинено нормальному закону с параметрами mt = 8000 час., t = 1000 час. Требуется вычислить количественные характеристики надежности p(t), f(t), (t), mt для t = 8000 час.";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "Время исправной работы устройства подчинено закону Вейбулла с параметрами к=2,5; а= =1,7∙10-7 1/час. Требуется вычислить количественные характеристики надежности Р(t),f(t),(t) для t = 150 час. и среднее время безотказной работы устройства.";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "Определить вероятность безотказной работы и интенсивность отказов прибора при t = 1200 часов работы, если при испытаниях получено значение среднего времени безотказной работы mt = 1500 час. и среднее квадратичное отклонение t = 100 час.";
        }
    }
}
