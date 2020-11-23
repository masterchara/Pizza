using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Pizza
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();///hides this page
            Form1 f1 = new Form1(); ///1st page variable
            f1.ShowDialog(); ///switches to the first page 
        }
        private int price; //price total variable
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender;
            if (box.Checked) //if user checks box
            {
                price += 2; //changes to price and label due to pizza size cost
                label2.Text = "Price: $" + price;
            }
            else
            {
                price -= 2; //changes to price and label due to pizza size cost
                label2.Text = "Price: $" + price;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender;
            if (box.Checked) //if user checks box
            {
                price += 3; //changes to price and label due to pizza size cost
                label2.Text = "Price: $" + price;
            }
            else
            {
                price -= 3; //changes to price and label due to pizza size cost
                label2.Text = "Price: $" + price;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender;
            if (box.Checked) //if user checks box
            {
                price += 4; //changes to price and label due to pizza size cost
                label2.Text = "Price: $" + price;
            }
            else
            {
                price -= 4; //changes to price and label due to pizza size cost
                label2.Text = "Price: $" + price;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender;
            if (box.Checked) //if user checks box
            {
                price += 1; //changes to price and label due to pizza size cost
                label2.Text = "Price: $" + price;
            }
            else
            {
                price -= 1; //changes to price and label due to pizza size cost
                label2.Text = "Price: $" + price;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender;
            if (box.Checked) //if user checks box
            {
                price += 1; //changes to price and label due to pizza size cost
                label2.Text = "Price: $" + price;
            }
            else
            {
                price -= 1; //changes to price and label due to pizza size cost
                label2.Text = "Price: $" + price;
            }
        }
    }
}
