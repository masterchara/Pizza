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
        public static int price; //price total variable
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private string drinkSize;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender;
            if (box.Checked) //if user checks box
            {
                drinkSize = "24 ounce";
                price += 2; //changes to price and label due to pizza size cost
                label2.Text = "Price: $" + price;
            }
            else
            {
                drinkSize = "";
                price -= 2; //changes to price and label due to pizza size cost
                label2.Text = "Price: $" + price;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender;
            if (box.Checked) //if user checks box
            {
                drinkSize = "32 ounce";
                price += 3; //changes to price and label due to pizza size cost
                label2.Text = "Price: $" + price;
            }
            else
            {
                drinkSize = "";
                price -= 3; //changes to price and label due to pizza size cost
                label2.Text = "Price: $" + price;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender;
            if (box.Checked) //if user checks box
            {
                drinkSize = "40 ounce";
                price += 4; //changes to price and label due to pizza size cost
                label2.Text = "Price: $" + price;
            }
            else
            {
                drinkSize = "";
                price -= 4; //changes to price and label due to pizza size cost
                label2.Text = "Price: $" + price;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender;
            if (box.Checked) //if user checks box
            {
                drinkType = "Gatorade";
                price += 1; //changes to price and label due to pizza size cost
                label2.Text = "Price: $" + price;
            }
            else
            {
                drinkType = "";
                price -= 1; //changes to price and label due to pizza size cost
                label2.Text = "Price: $" + price;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender;
            if (box.Checked) //if user checks box
            {
                drinkType = "Sweet Tea";
                price += 1; //changes to price and label due to pizza size cost
                label2.Text = "Price: $" + price;
            }
            else
            {
                drinkType = "";
                price -= 1; //changes to price and label due to pizza size cost
                label2.Text = "Price: $" + price;
            }
        }
        public static int labels;
        private void button2_Click(object sender, EventArgs e)
        {
            labels = price;
            drink = drinkSize + " " + drinkType;
            this.Hide();
            Order o1 = new Order();
            o1.ShowDialog();
        }
        private string drinkType; //holds variable type of drink
        public static string drink; //type of drink for the order portion
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender;
            if (box.Checked) //if user checks box
            {
                drinkType = "Coke";
            }
            else
            {
                drinkType = "";
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender;
            if (box.Checked) //if user checks box
            {
                drinkType = "Sprite";
            }
            else
            {
                drinkType = "";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender;
            if (box.Checked) //if user checks box
            {
                drinkType = "Water";
            }
            else
            {
                drinkType = "";
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender;
            if (box.Checked) //if user checks box
            {
                drinkSize = "None";
            }
            else
            {
                drinkSize = "";
            }
        }
    }
}
