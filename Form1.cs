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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton8_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton9_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton10_Click(object sender, EventArgs e)
        {
            
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            show.Visible = false;
            hide.Visible = true;
            guna2Panel3.Visible = false;
            guna2Panel3.Width = 46;
            guna2Transition1.ShowSync(guna2Panel3);
        }

        private void hide_Click(object sender, EventArgs e)
        {
            guna2Panel3.Visible = false;
            hide.Visible = false;
            show.Visible = true;
            guna2Panel3.Width = 200;
            guna2Transition1.ShowSync(guna2Panel3);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to add to your library?", "Library", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Your item was added to library", "Library", MessageBoxButtons.OK);
            }
            


        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to restart?", "Windows 10", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Restart();
            }
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

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to shut down?", "Windows 10", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            label16.Text = label2.Text;
            label17.Text = label3.Text;
            guna2PictureBox12.Image = guna2PictureBox2.Image;
            guna2ProgressBar1.Value = 0;
            label18.Text = "0:00";
            label19.Text = "3:20";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            label16.Text = label5.Text;
            label17.Text = label4.Text;
            guna2PictureBox12.Image = guna2PictureBox3.Image;
            guna2ProgressBar1.Value = 0;
            label18.Text = "0:00";
            label19.Text = "5:00";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            label16.Text = label7.Text;
            label17.Text = label6.Text;
            guna2PictureBox12.Image = guna2PictureBox4.Image;
            guna2ProgressBar1.Value = 0;
            label18.Text = "0:00";
            label19.Text = "2:20";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox11_Click(object sender, EventArgs e)
        {
            label16.Text = label15.Text;
            label17.Text = "Playlist on spotify";
            guna2PictureBox12.Image = guna2PictureBox11.Image;
            guna2ProgressBar1.Value = 0;
            label18.Text = "0:00";
            label19.Text = "1:0:20";
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox10_Click(object sender, EventArgs e)
        {
            label16.Text = label14.Text;
            label17.Text = "Playlist on spotify";
            guna2PictureBox12.Image = guna2PictureBox10.Image;
            guna2ProgressBar1.Value = 0;
            label18.Text = "0:00";
            label19.Text = "10:20";
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox9_Click(object sender, EventArgs e)
        {
            label16.Text = label13.Text;
            label17.Text = "Playlist on spotify";
            guna2PictureBox12.Image = guna2PictureBox9.Image;
            guna2ProgressBar1.Value = 0;
            label18.Text = "0:00";
            label19.Text = "1:40";
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox8_Click(object sender, EventArgs e)
        {
            label16.Text = label12.Text;
            label17.Text = "Playlist on spotify";
            guna2PictureBox12.Image = guna2PictureBox8.Image;
            guna2ProgressBar1.Value = 0;
            label18.Text = "0:00";
            label19.Text = "2:20";
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {
            label16.Text = label11.Text;
            label17.Text = "Playlist on spotify";
            guna2PictureBox12.Image = guna2PictureBox7.Image;
            guna2ProgressBar1.Value = 0;
            label18.Text = "0:00";
            label19.Text = "3:50";
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            label16.Text = label10.Text;
            label17.Text = "Playlist on spotify";
            guna2PictureBox12.Image = guna2PictureBox6.Image;
            guna2ProgressBar1.Value = 0;
            label18.Text = "0:00";
            label19.Text = "3:17";
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            label16.Text = label9.Text;
            label17.Text = "Playlist on spotify";
            guna2PictureBox12.Image = guna2PictureBox5.Image;
            guna2ProgressBar1.Value = 30;
            label18.Text = "1:20";
            label19.Text = "4:02";

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton11_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            Visible = false;
            
            
        }

        private void guna2CircleButton13_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            guna2PictureBox2.BorderRadius = 50;
        }

        private void guna2PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            guna2PictureBox2.BorderRadius = 20;
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
            guna2PictureBox5.BorderRadius = 40;
        }

        private void guna2PictureBox5_MouseLeave(object sender, EventArgs e)
        {
            guna2PictureBox5.BorderRadius = 20;
        }

        private void guna2PictureBox6_MouseEnter(object sender, EventArgs e)
        {
            guna2PictureBox6.BorderRadius = 40;
        }

        private void guna2PictureBox6_MouseLeave(object sender, EventArgs e)
        {
            guna2PictureBox6.BorderRadius = 20;
        }

        private void guna2PictureBox7_MouseEnter(object sender, EventArgs e)
        {
            guna2PictureBox7.BorderRadius = 40;
        }

        private void guna2PictureBox7_MouseLeave(object sender, EventArgs e)
        {
            guna2PictureBox7.BorderRadius = 20;
        }

        private void guna2PictureBox8_MouseEnter(object sender, EventArgs e)
        {
            guna2PictureBox8.BorderRadius = 40;
        }

        private void guna2PictureBox8_MouseLeave(object sender, EventArgs e)
        {
            guna2PictureBox8.BorderRadius = 20;
        }

        private void guna2PictureBox9_MouseEnter(object sender, EventArgs e)
        {
            guna2PictureBox9.BorderRadius = 40;
        }

        private void guna2PictureBox9_MouseLeave(object sender, EventArgs e)
        {
            guna2PictureBox9.BorderRadius = 20;
        }

        private void guna2PictureBox10_MouseEnter(object sender, EventArgs e)
        {
            guna2PictureBox10.BorderRadius = 40;
        }

        private void guna2PictureBox10_MouseLeave(object sender, EventArgs e)
        {
            guna2PictureBox10.BorderRadius = 20;
        }

        private void guna2PictureBox11_MouseEnter(object sender, EventArgs e)
        {
            guna2PictureBox11.BorderRadius = 40;
        }

        private void guna2PictureBox11_MouseLeave(object sender, EventArgs e)
        {
            guna2PictureBox11.BorderRadius = 20;
        }
    }
}
