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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dialog result to confirm for exiting app
            DialogResult res = MessageBox.Show("Do you want to exit the application?", "Exit Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Call for the staff form
            StaffForm staff = new StaffForm();
            staff.Show();
            this.Hide();
        }

        private void telephoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Telephone messagebox
            MessageBox.Show("Call us on our numbers:" + "\r\n" + "\r\n" + "Landline: " + "021 536 2154" + "\r\n" + "Telephone: " + "078 522 5648", "Contact Details",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void orderFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Call for the order form
            OrderForm order = new OrderForm();
            order.Show();
            this.Hide();
        }

        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Address messagebox
            MessageBox.Show("24 Lewis Saint Street" + "\r\n" + "Woodstock" + "\r\n" + "Cape Town" + "\r\n" + "7580", "Address", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Email messagebox
            MessageBox.Show("Our email is below:" + "\r\n" + "\r\n" + "customer@netplace.org", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}