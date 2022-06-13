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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
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

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Visible = false;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2Button2.Text = "OFFLINE";
            guna2Button2.ForeColor = Color.Red;
            guna2Button4.HoverState.ForeColor = Color.Red;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            guna2Button4.Text = guna2TextBox2.Text;
            label2.Text = guna2TextBox2.Text;

            


            if (guna2TextBox2.Text == "Dendi♕")
            {
                MessageBox.Show("Incorrect name!", "Error", MessageBoxButtons.OK);
            }
            if (guna2TextBox2.Text != "Dendi♕")
            {
                MessageBox.Show("Your name has been changed!", "Name", MessageBoxButtons.OK);
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "") {
                guna2Button6.Enabled = false;
            }
            else
            {
                guna2Button6.Enabled = true;
            }
            
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to add to your library?", "Library", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Your item was added to library", "Library", MessageBoxButtons.OK);
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Your password has been changed!", "Password", MessageBoxButtons.OK);
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox3.Text == "")
            {
                guna2Button7.Enabled = false;
            }
            else
            {
                guna2Button7.Enabled = true;
            }
        }

        private void guna2Button2_DoubleClick(object sender, EventArgs e)
        {
            guna2Button2.Text = "ONLINE";
            guna2Button2.ForeColor = Color.Green;
            guna2Button4.HoverState.ForeColor = Color.Green;
        }

        private void guna2Button2_MouseClick(object sender, MouseEventArgs e)
        {
            
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
