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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        //Declaring the variables
        const double priceOne = 20;
        const double priceTwo = 15;
        const double priceThree = 10;
        const double priceFour = 7.50;
        const double coupon = 0.20;
        double amount = 0;
        const double vatt = 0.14;
        double discount = 0;
        double newTotal = 0;
        double custmer = 0;
        double vat = 0;
        double total = 0;
        double totalDiscounts = 0;
        double totalVat = 0;
        double totalAmount = 0;



        private void button2_Click(object sender, EventArgs e)
        {
            //Calling the method for calculation
            Calculator();

            //Counting  the customers
            custmer++;

        }
        //Creating a calculating method
        private void Calculator()
        {
            //Check if the textfields are empty or not
            if (custmerNameTxt.Text == "")
            {
                MessageBox.Show("Please the customer name below!", "Enter Data", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                custmerNameTxt.Focus();
            }
            else
            {
                if (hoursTxt.Text == "")
                {
                    MessageBox.Show("Please enter the number of hours.", "Hours Input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    hoursTxt.Focus();
                }
                else
                {
                    try
                    {
                        //Calculation of the hours
                        double hours = double.Parse(hoursTxt.Text);

                        if (hours >= 0 && hours <= 1)
                        {
                            amount = hours * priceOne;
                        }
                        else if (hours >= 1 && hours <= 2)
                        {
                            amount = hours * priceTwo;
                        }
                        else if (hours >= 2 && hours <= 4)
                        {
                            amount = hours * priceThree;
                        }
                        else if (hours >= 4 && hours <= 8)
                        {
                            amount = hours * priceFour;
                        }
                        else
                        {

                        }
                    }
                    catch (FormatException error)
                    {
                                                                                               
                        MessageBox.Show("Error data input. Please input a number" + "\r\n" + "---------------------------------------------------" +
                            "\r\n" + error.Message, "Error input data type", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
                    }
                }

                //casting data and vat & total values
                grossIncomeTxt.Text = amount.ToString("C");
                vat = amount * vatt;
                vatTxt.Text = vat.ToString("C");
                total = amount + vat;
                totalTxt.Text = total.ToString("C");

                //If there is a customer that has reached R100 or above his name appears on list
                if (total >= 100)
                {
                    aboveHundred.Items.Add(custmerNameTxt.Text);
                }
            }
            //discount calculation if radio button clicked
            if (radBtn1.Checked)
            {
                discount = total * coupon;
                newTotal = total - discount;
                totalDiscounts += discount;
                discountTxt.Text = discount.ToString("C");
                newTotalTxt.Text = newTotal.ToString("C");
            }
            //Summing the totals after each order
            totalVat += vat;
            totalAmount += total;
        }

        private void telephoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Contact details
            MessageBox.Show("Call us on our numbers:" + "\r\n" + "\r\n" + "Landline: " + "021 536 2154" + "\r\n" + "Telephone: " + "078 522 5648", "Contact Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Call for About Form
            AboutForm form = new AboutForm();
            form.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
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
            //Check if the textfields are cleared or not
            if (custmerNameTxt.Text == "" && employeeNameTxt.Text == "")
            {
                MessageBox.Show("Textfields already cleared. Proceed to enter for a new user", "Textfields Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //dialog result to confirm for clearing for new user
                DialogResult res = MessageBox.Show("Do you want to clear the text fields?", "Clear Textfields?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    //clear all text boxes and uncheck the radio button
                    radBtn1.Checked = false;
                    employeeNameTxt.Clear();
                    custmerNameTxt.Clear();
                    hoursTxt.Clear();
                    grossIncomeTxt.Clear();
                    vatTxt.Clear();
                    totalTxt.Clear();
                    discountTxt.Clear();
                    newTotalTxt.Clear();
                }
              
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
            //Check if there is data to summarize
            if (totalAmount == 0)
            {
                MessageBox.Show("No data to summarize", "No data", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                //Summarizing of data
                MessageBox.Show("The summary of details for today" + "\r\n" + "----------------------------------" + "\r\n" +
                   "Customers: " + custmer.ToString() + "\r\n" + "Total Amount is: " + totalAmount.ToString("C") + "\r\n" +
                   "Total Discounts is: " + totalDiscounts.ToString("C") + "\r\n" + "Total Vat is: " + totalVat.ToString("C"),
                   "Summary of transactions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Call for the staff form
            StaffForm staff = new StaffForm();
            staff.Show();
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dialog result to confirm for exiting app
            DialogResult res = MessageBox.Show("Do you want to exit the application?", "Exit Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void themesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show font dialog
            fontDialog1.ShowDialog();
            
            //contents which will be affected
            label1.Font = fontDialog1.Font;
            label2.Font = fontDialog1.Font;
            label3.Font = fontDialog1.Font;
            label4.Font = fontDialog1.Font;
            label5.Font = fontDialog1.Font;
            label6.Font = fontDialog1.Font;
            label7.Font = fontDialog1.Font;
            label9.Font = fontDialog1.Font;
            label10.Font = fontDialog1.Font;
            radBtn1.Font = fontDialog1.Font;
            Calculate.Font = fontDialog1.Font;
            Calculate.Font = fontDialog1.Font;
            button1.Font = fontDialog1.Font;
            button1.Font = fontDialog1.Font;
            button3.Font = fontDialog1.Font;
            button3.Font = fontDialog1.Font;
            button4.Font = fontDialog1.Font;
            menuStrip1.Font = fontDialog1.Font;
            employeeNameTxt.Font = fontDialog1.Font;
            custmerNameTxt.Font = fontDialog1.Font;
            hoursTxt.Font = fontDialog1.Font;
            grossIncomeTxt.Font = fontDialog1.Font;
            vatTxt.Font = fontDialog1.Font;
            totalTxt.Font = fontDialog1.Font;
            discountTxt.Font = fontDialog1.Font;
            newTotalTxt.Font = fontDialog1.Font;
            aboveHundred.Font = fontDialog1.Font;



        }
      

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void foreColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show font dialog
            colorDialog1.ShowDialog();

            //controls which will be affected
            label1.ForeColor = colorDialog1.Color;
            label2.ForeColor = colorDialog1.Color;
            label3.ForeColor = colorDialog1.Color;
            label4.ForeColor = colorDialog1.Color;
            label5.ForeColor = colorDialog1.Color;
            label6.ForeColor = colorDialog1.Color;
            label7.ForeColor = colorDialog1.Color;
            label9.ForeColor = colorDialog1.Color;
            label10.ForeColor = colorDialog1.Color;
            radBtn1.ForeColor = colorDialog1.Color;
            employeeNameTxt.ForeColor = colorDialog1.Color;
            custmerNameTxt.ForeColor = colorDialog1.Color;
            hoursTxt.ForeColor = colorDialog1.Color;
            grossIncomeTxt.ForeColor = colorDialog1.Color;
            vatTxt.ForeColor = colorDialog1.Color;
            totalTxt.ForeColor = colorDialog1.Color;
            discountTxt.ForeColor = colorDialog1.Color;
            newTotalTxt.ForeColor = colorDialog1.Color;
            aboveHundred.ForeColor = colorDialog1.Color;
        }

        private void backColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show colour dialog
            colorDialog1.ShowDialog();

            //controls which will be affected
            employeeNameTxt.BackColor = colorDialog1.Color;
            custmerNameTxt.BackColor = colorDialog1.Color;
            hoursTxt.BackColor = colorDialog1.Color;
            grossIncomeTxt.BackColor = colorDialog1.Color;
            vatTxt.BackColor = colorDialog1.Color;
            totalTxt.BackColor = colorDialog1.Color;
            discountTxt.BackColor = colorDialog1.Color;
            newTotalTxt.BackColor = colorDialog1.Color;
            aboveHundred.BackColor = colorDialog1.Color;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Check if the list is empty or not
            if (aboveHundred.Items.Count == 0)
            {
                MessageBox.Show("List already cleared.", "List Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                //dialog result to confirm for clearing the list
                DialogResult res = MessageBox.Show("Do you want to clear the list?", "Clear list?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    aboveHundred.Items.Clear();
                }
            }
            
        }
    }
}