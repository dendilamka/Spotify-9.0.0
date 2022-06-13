using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotify_9._0._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Visible = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            Visible = false;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            Visible = false;
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            label16.Text = label2.Text;
            guna2PictureBox12.Image = guna2PictureBox2.Image;
            guna2ProgressBar1.Value = 0;
            label18.Text = "0:00";
            label19.Text = "1:0:20";

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            label16.Text = label7.Text;
            guna2PictureBox12.Image = guna2PictureBox3.Image;
            guna2ProgressBar1.Value = 0;
            label18.Text = "0:00";
            label19.Text = "4:0:20";
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            label16.Text = label10.Text;
            guna2PictureBox12.Image = guna2PictureBox4.Image;
            guna2ProgressBar1.Value = 0;
            label18.Text = "0:00";
            label19.Text = "50:20";
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            label16.Text = label13.Text;
            guna2PictureBox12.Image = guna2PictureBox5.Image;
            guna2ProgressBar1.Value = 0;
            label18.Text = "0:00";
            label19.Text = "7:0:00";
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            label16.Text = label21.Text;
            guna2PictureBox12.Image = guna2PictureBox6.Image;
            guna2ProgressBar1.Value = 0;
            label18.Text = "0:00";
            label19.Text = "30:20";
        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {
            label16.Text = label24.Text;
            guna2PictureBox12.Image = guna2PictureBox7.Image;
            guna2ProgressBar1.Value = 0;
            label18.Text = "0:00";
            label19.Text = "3:0:00";
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to add to your library?", "Library", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Your item was added to library", "Library", MessageBoxButtons.OK);
            }
        }

        private void guna2PictureBox2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void guna2PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            guna2PictureBox2.BorderRadius = 20;
        }

        private void guna2PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            guna2PictureBox2.BorderRadius = 50;
        }

        private void guna2PictureBox3_MouseEnter(object sender, EventArgs e)
        {
            guna2PictureBox3.BorderRadius = 50;
        }

        private void guna2PictureBox3_MouseLeave(object sender, EventArgs e)
        {
            guna2PictureBox3.BorderRadius = 20;
        }

        private void guna2PictureBox4_MouseEnter(object sender, EventArgs e)
        {
            guna2PictureBox4.BorderRadius = 50;
        }

        private void guna2PictureBox4_MouseLeave(object sender, EventArgs e)
        {
            guna2PictureBox4.BorderRadius = 20;
        }

        private void guna2PictureBox5_MouseEnter(object sender, EventArgs e)
        {
            guna2PictureBox5.BorderRadius = 50;
        }

        private void guna2PictureBox5_MouseLeave(object sender, EventArgs e)
        {
            guna2PictureBox5.BorderRadius = 20;
        }

        private void guna2PictureBox6_MouseEnter(object sender, EventArgs e)
        {
            guna2PictureBox6.BorderRadius = 50;
        }

        private void guna2PictureBox6_MouseLeave(object sender, EventArgs e)
        {
            guna2PictureBox6.BorderRadius = 20;
        }

        private void guna2PictureBox7_MouseEnter(object sender, EventArgs e)
        {
            guna2PictureBox7.BorderRadius = 50;
        }

        private void guna2PictureBox7_MouseLeave(object sender, EventArgs e)
        {
            guna2PictureBox7.BorderRadius = 20;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to shut down?", "Spotify 9.0.0", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                Application.Restart();
        }
    }
}
