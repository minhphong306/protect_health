using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace protect_health {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }
        private int min = 0, sec = 0, mil = 0;
        private bool isWork = false;

        private void breakTime(int _min) {
            this.Show();
            btnMoreTime.Visible = true;
            btnOk.Visible = true;
            this.isWork = false;
            this.BackColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Opacity = 0.8;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            sec = _min;
            timerMain.Start();
        }

        private void workTime(int _min) {
            this.isWork = true;
            this.Hide();
            sec = _min;
            timerMain.Start();

        }

        private void btnOk_Click(object sender, EventArgs e) {
            btnOk.Visible = false;
            btnMoreTime.Visible = false;
        }

        private void btnMoreTime_Click(object sender, EventArgs e) { 
            workTime(5);
        }

        private void button1_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void timerMain_Tick(object sender, EventArgs e) {
            if (mil == 0) {
                if (min == 0 && sec == 0) {
                    timerMain.Stop();
                    if (isWork == true)
                        breakTime(5);
                    else
                        workTime(30);
                }
                else if (min != 0 && sec == 0) {
                    min--;
                    sec = 59;
                }
                else if (sec != 0) {
                    sec--;
                }
                mil = 99;
            }
            else
                mil--;

            lbMinutes.Text = min.ToString();
            lbSecond.Text = sec.ToString();
            lbMilliSecond.Text = mil.ToString();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.ShowInTaskbar = false; 
            this.WindowState = FormWindowState.Minimized;
            workTime(5);
        }
    }
}
