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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Animate the loading tank 
            panel1.Width += 2;

            
            if (panel1.Width >= 599)
            {
                //Stop after some time then show messagebox
                timer1.Stop();
                MessageBox.Show("Dear User," + "\r\n" +"You have been successfully logged in!" + "\r\n" + "\r\n" + "Welcome to The net Place Cafe!" + "\r\n" + "Press OK to continue.", "Details Verified", MessageBoxButtons.OK);

                //Go to the About Form after loading
                AboutForm about = new AboutForm();
                about.Show();
                this.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
