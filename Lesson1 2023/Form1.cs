using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lesson1_2023
{
    public partial class Form1 : Form
    {
        int age = 0; //declare a Global variable that can be used anywhere in the program

        public Form1()
        {
            InitializeComponent();
            //pass across the age to that variable when the form loads. 
            age = Convert.ToInt16(txtAge.Text);
        }

        private void btnGenerateDetails_Click(object sender, EventArgs e)
        {
            //add 1 to the age each time the button is clicked. 
            age = age + 1;

            lblOutput.Text = "Hi " + txtFirstName.Text + " " + txtLastName.Text + ". You are " + age + " years old. What would you like to do today?";

            MessageBox.Show("Hi " + txtFirstName.Text + " " + txtLastName.Text + ". You are " + age + " years old. What would you like to do today?");
        }
    }
}
