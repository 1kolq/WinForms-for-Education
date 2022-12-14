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
    public partial class practicLab4 : Form
    {
        public practicLab4()
        {
            InitializeComponent();
        }

        private double getLambda()
        {
            if (lambdaBox.Text.Length > 0) return Convert.ToDouble(lambdaBox.Text);
            if (mtiBox.Text.Length > 0)
            {
                if (calcL0m())
                {
                    lam0mPanel.Visible = true;
                    double res = 0;
                    double mti = Convert.ToDouble(mtiBox.Text);
                    int n = Convert.ToInt32(nBox.Text);
                    res = n / mti;
                    return res;
                }
            }

            if (lamiBox.Text.Length > 0)
            {
                if (calcL0l())
                {
                    lam0lPanel.Visible = true;
                    double lami = Convert.ToDouble(lamiBox.Text);
                    int n = Convert.ToInt32(nBox.Text);
                    double res = lami * n;
                    return res;
                }
            }

            if (l1Box.Text.Length > 0)
            {
                TextBox[] ts = new TextBox[] { l1Box, l2Box, l3Box };
                l0LiPanel.Visible = true;

                double res = 0;
                for (int i = 0; i < 3; ++i)
                {
                    if (ts[i].Text.Length > 0)
                    {
                        double l = Convert.ToDouble(ts[i].Text);
                        res += l;
                    }
                }
                l0LiResult.Text = res.ToString("N5");
                return res;
            }
            throw new FormatException();
        }
        private bool calcL0m()
        {
            double m;
            int n;
            try
            {
                n = Convert.ToInt32(nBox.Text);
                m = Convert.ToDouble(mtiBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета λ через m", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double res = n / m;

            l0mnLabel.Text = n.ToString();
            l0mmtiLabel.Text = m.ToString("N3");
            l0mResult.Text = res.ToString("N5");
            return true;
        }

        private bool calcL0l()
        {
            double l;
            int n;
            try
            {
                n = Convert.ToInt32(nBox.Text);
                l = Convert.ToDouble(lamiBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета λ через λi", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double res = n * l;

            l0l1Label.Text = l.ToString("N3") + "*" + n.ToString();
            l0lResult.Text = res.ToString("N5");
            return true;
        }

        private bool calcPct()
        {
            double l, t;
            int m;
            try
            {
                m = Convert.ToInt32(mBox.Text);
                l = getLambda();
                t = Convert.ToDouble(timeBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета Pc(t)", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double res = 1 - Math.Pow(1 - Math.Exp(-l * t), m + 1);
            pct1Label.Text = l.ToString("N3") + "*" + t.ToString("N3");
            pctmLabel.Text = (m + 1).ToString();


            pctResult.Text = res.ToString("N5");
            return true;
        }

        private bool calcMtc()
        {
            double l;
            int m;
            try
            {
                m = Convert.ToInt32(mBox.Text);
                l = getLambda();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета m", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double k = 0;
            for (int i = 0; i <= m; ++i)
            {
                k += 1d / (1 + i);
            }

            mtc1Label.Text = k.ToString("N5");
            mtclLabel.Text = l.ToString("N5");

            double res = k / l;
            mtcResult.Text = res.ToString("N5");
            return true;
        }

        private bool calcFct()
        {
            double l, t;
            int m;
            try
            {
                m = Convert.ToInt32(mBox.Text);
                l = getLambda();
                t = Convert.ToDouble(timeBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета f", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double res = l * (m + 1) * Math.Exp(-l * t) * Math.Pow(1 - Math.Exp(-l * t), m);

            fctl1Label.Text = l.ToString("N3");
            fctmLabel.Text = (m + 1).ToString();
            fctl2Label.Text = l.ToString("N3") + "*" + t.ToString("N3");
            fctl3Label.Text = l.ToString("N3") + "*" + t.ToString("N3");
            fctResult.Text = res.ToString("N5");
            return true;
        }

        private bool calcQct()
        {
            double l, t;
            int m;
            try
            {
                m = Convert.ToInt32(mBox.Text);
                l = getLambda();
                t = Convert.ToDouble(timeBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета f", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double res = Math.Pow(1 - Math.Exp(-l * t), m + 1);

            qct1Label.Text = l.ToString("N3") + "*" + t.ToString("N3");
            qct2Label.Text = (m + 1).ToString();
            qctResult.Text = res.ToString("N5");

            return true;
        }

        private bool calcLct()
        {
            double l, t;
            int m;
            try
            {
                m = Convert.ToInt32(mBox.Text);
                l = getLambda();
                t = Convert.ToDouble(timeBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета f", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double f = l * (m + 1) * Math.Exp(-l * t) * Math.Pow(1 - Math.Exp(-l * t), m);
            double p = 1 - Math.Pow(1 - Math.Exp(-l * t), m + 1);
            double res = f / p;

            lcResult.Text = res.ToString("N5");
            lcpLabel.Text = p.ToString("N5");
            lctfLabel.Text = f.ToString("N5");
            return true;
        }

        private void practicLab4_Load(object sender, EventArgs e)
        {

        }

        

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            
            mainForm main = new mainForm();
            main.Show();
            this.Hide();
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            lam0mPanel.Visible = false;
            if (lam0mCheckBox.Checked)
            {
                try
                {
                    getLambda();
                }
                catch (FormatException) { }
            }

            lam0lPanel.Visible = false;

            pctPanel.Visible = false;
            if (pctCheckBox.Checked)
            {
                pctPanel.Visible = calcPct();
            }

            mtcPanel.Visible = false;
            if (mtcCheckBox.Checked)
            {
                mtcPanel.Visible = calcMtc();
            }

            fctPanel.Visible = false;
            if (fctCheckBox.Checked)
            {
                fctPanel.Visible = calcFct();
            }

            qctPanel.Visible = false;
            if (qctCheckBox.Checked)
            {
                qctPanel.Visible = calcQct();
            }

            lctPanel.Visible = false;
            if (lamtCheckBox.Checked)
            {
                lctPanel.Visible = calcLct();
            }
        }

        private void lambdaBox_TextChanged(object sender, EventArgs e)
        {

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

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
