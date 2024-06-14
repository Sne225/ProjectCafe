using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCafe
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dialog result to confirm for exiting app
            DialogResult res = MessageBox.Show("Do you want to exit the application?", "Exit Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //Focus on the textbox and unfocus second textbox of password
            usernameTxt.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            passwordTxt.BackColor = SystemColors.Control;
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            //Focus on the textbox and unfocus first textbox of username
            passwordTxt.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            usernameTxt.BackColor = SystemColors.Control;
           
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            //Show password if clicked on the icon of the password
            passwordTxt.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            //Hide password if stopped clicking on the icon of the password
            passwordTxt.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Check if the the textboxes are empty. If so, then the program won't run
            if (usernameTxt.Text == "")
            {
                MessageBox.Show("Please enter your username on the field below!", "Username Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTxt.Focus();
            }
            else
            {
                if (passwordTxt.Text == "")
                {
                    MessageBox.Show("Please enter your password on the field below!", "Password Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordTxt.Focus();
                }
                //if data provided, then move to the loading form
                else
                {
                    LoadingForm load = new LoadingForm();
                    load.Show();
                    this.Hide();
                }
            }
        }
    }
}
