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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();///hides this page
            Form2 f2 = new Form2(); ///2nd page variable
            f2.ShowDialog(); ///switches to second page
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private int counterCheck; //counter for max toppings
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender; //variable for checkbox
            if (box.Checked) //if user checks checkbox
            {
                counterCheck++; //counter going up since user chose a topping
                price += 1; //price up
                label4.Text = "Price: $" + price; //label update
            }
            else
            {
                counterCheck--; //counter down user didn't want topping
                price -= 1; //price down
                label4.Text = "Price: $" + price;//label update
            }
            if(counterCheck == 5){
                MessageBox.Show("Only 4");
                box.Checked = false;
            }
            
        }
        
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                counterCheck++;
                price += 2;
                label4.Text = "Price: $" + price;
            } //same comments as pepperoni checkbox
            else
            {
                counterCheck--;
                price -= 2;
                label4.Text = "Price: $" + price;
            }
            if (counterCheck == 5)
            {
                MessageBox.Show("Only 4");
                box.Checked = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                counterCheck++;
                price += 2;
                label4.Text = "Price: $" + price;
            } //same comments as pepperoni
            else
            {
                counterCheck--;
                price -= 2;
                label4.Text = "Price: $" + price;
            }
            if (counterCheck == 5)
            {
                MessageBox.Show("Only 4");
                box.Checked = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                counterCheck++;
                price += 3;
                label4.Text = "Price: $" + price;
            } //same comments as pepperoni
            else
            {
                counterCheck--;
                price -= 3;
                label4.Text = "Price: $" + price;
            }
            if (counterCheck == 5)
            {
                MessageBox.Show("Only 4");
                box.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                counterCheck++;
                price += 1;
                label4.Text = "Price: $" + price;
            } //same comments as pepperoni
            else
            {
                counterCheck--;
                price -= 1;
                label4.Text = "Price: $" + price;
            }
            if (counterCheck == 5)
            {
                MessageBox.Show("Only 4");
                box.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                counterCheck++;
                price += 2;
                label4.Text = "Price: $" + price;
            } //same comments as pepperoni
            else
            {
                counterCheck--;
                price -= 2;
                label4.Text = "Price: $" + price;
            }
            if (counterCheck == 5)
            {
                MessageBox.Show("Only 4");
                box.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender; //if user checks box
            if (box.Checked)
            {
                counterCheck++;
                price += 1;
                label4.Text = "Price: $" + price;
            } //same comments as pepperoni
            else
            {
                counterCheck--;
                price -= 1;
                label4.Text = "Price: $" + price;
            }
            if (counterCheck == 5)
            {
                MessageBox.Show("Only 4");
                box.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender; //if user checks box
            if (box.Checked)
            {
                counterCheck++;
                price += 2;
                label4.Text = "Price: $" + price;
            }
            else
            {
                counterCheck--;
                price -= 2;
                label4.Text = "Price: $" + price;
            }
            if (counterCheck == 5)
            {
                MessageBox.Show("Only 4");
                box.Checked = false;
            }
        }

        private void radioButton1_CheckedChanged_2(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender; //if user checks box
            if (box.Checked)
            {
                price += 3; //changes to price and label due to pizza size cost
                label4.Text = "Price: $" + price;
            }
            else
            {
                price -= 3; //changes to price and label due to pizza size cost
                label4.Text = "Price: $" + price;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender; //if user checks box
            if (box.Checked)
            {
                price += 5; //changes to price and label due to pizza size cost
                label4.Text = "Price: $" + price;
            }
            else
            {
                price -= 5; //changes to price and label due to pizza size cost
                label4.Text = "Price: $" + price;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Variable to hold price
        /// </summary>
        private int price = 0; 
        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender;
            if (box.Checked) //if user checks box
            {
                price += 7; //changes to price and label due to pizza size cost
                label4.Text = "Price: $" + price;
            }
            else
            {
                price -= 7; //changes to price and label due to pizza size cost
                label4.Text = "Price: $" + price;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender;
            if (box.Checked) //if user checks box
            {
                price += 9; //changes to price and label due to pizza size cost
                label4.Text = "Price: $" + price;
            }
            else
            {
                price -= 9; //changes to price and label due to pizza size cost
                label4.Text = "Price: $" + price;
            }
        }
    }
}
