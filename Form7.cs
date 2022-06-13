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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Visible = false;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2Button2.Text = "FOLLOW";
            guna2Button2.ForeColor = Color.Red;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            guna2Button6.Text = "FOLLOW";
            guna2Button6.ForeColor = Color.Red;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            guna2Button7.Text = "FOLLOW";
            guna2Button7.ForeColor = Color.Red;
            
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            guna2Button8.Text = "FOLLOW";
            guna2Button8.ForeColor = Color.Red;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to add to your library?", "Library", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Your item was added to library", "Library", MessageBoxButtons.OK);
            }
        }

        private void guna2Button2_DoubleClick(object sender, EventArgs e)
        {
            guna2Button2.Text = "FOLLOWING";
            guna2Button2.ForeColor = Color.Green;
        }

        private void guna2Button7_DoubleClick(object sender, EventArgs e)
        {
            guna2Button7.Text = "FOLLOWING";
            guna2Button7.ForeColor = Color.Green;
        }

        private void guna2Button6_DoubleClick(object sender, EventArgs e)
        {
            guna2Button6.Text = "FOLLOWING";
            guna2Button6.ForeColor = Color.Green;
        }

        private void guna2Button8_DoubleClick(object sender, EventArgs e)
        {
            guna2Button8.Text = "FOLLOWING";
            guna2Button8.ForeColor = Color.Green;
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
