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
        public static int labels; //order price
        public static string pizza; //type of pizza for order
        public static string toppings;
        private void button1_Click(object sender, EventArgs e)
        {
            if (pizzaTopping.Count <= 1)
            {
                for (int i = 0; i < 1; i++)
                {
                    toppings = toppings + " " + pizzaTopping[i];
                }
            }
            if (pizzaTopping.Count == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    toppings = toppings + " " + pizzaTopping[i];
                }
            }
            if (pizzaTopping.Count == 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    toppings = toppings + " " + pizzaTopping[i];
                }
            }
            if (pizzaTopping.Count == 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    toppings = toppings + " " + pizzaTopping[i];
                }
            }
            pizza = pizzaSize + " " + pizzaCrust + "crust ";
            labels = price; //To hold price
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
        public static List<string> pizzaTopping = new List<string>(); //pizza topping holder for order detail
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender; //variable for checkbox
            if (box.Checked) //if user checks checkbox
            {
                pizzaTopping.Add("Pepperoni"); //holds topping for order detail
                counterCheck++; //counter going up since user chose a topping
                price += 1; //price up
                label4.Text = "Price: $" + price; //label update
            }
            else
            {
                pizzaTopping.Remove("Pepperoni"); //user unchecks wanting pepperoni won't be in order detail anymore
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
                pizzaTopping.Add("Sausage");
                counterCheck++;
                price += 2;
                label4.Text = "Price: $" + price;
            } //same comments as pepperoni checkbox
            else
            {
                pizzaTopping.Remove("Sausage");
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
                pizzaTopping.Add("Bacon");
                counterCheck++;
                price += 2;
                label4.Text = "Price: $" + price;
            } //same comments as pepperoni
            else
            {
                pizzaTopping.Remove("Bacon");
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
                pizzaTopping.Add("Grilled Chicken");
                counterCheck++;
                price += 3;
                label4.Text = "Price: $" + price;
            } //same comments as pepperoni
            else
            {
                pizzaTopping.Remove("Grilled Chicken");
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
                pizzaTopping.Add("Onion");
                counterCheck++;
                price += 1;
                label4.Text = "Price: $" + price;
            } //same comments as pepperoni
            else
            {
                pizzaTopping.Remove("Onion");
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
                pizzaTopping.Add("Mushroom");
                counterCheck++;
                price += 2;
                label4.Text = "Price: $" + price;
            } //same comments as pepperoni
            else
            {
                pizzaTopping.Remove("Mushroom");
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
                pizzaTopping.Add("Black Olives");
                counterCheck++;
                price += 1;
                label4.Text = "Price: $" + price;
            } //same comments as pepperoni
            else
            {
                pizzaTopping.Remove("Black Olives");
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
                pizzaTopping.Add("Jalepenos");
                counterCheck++;
                price += 2;
                label4.Text = "Price: $" + price;
            }
            else
            {
                pizzaTopping.Remove("Jalepenos");
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
        private string pizzaSize;
        private void radioButton1_CheckedChanged_2(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender; //if user checks box
            if (box.Checked)
            {
                pizzaSize = "Small";
                price += 3; //changes to price and label due to pizza size cost
                label4.Text = "Price: $" + price;
            }
            else
            {
                pizzaSize = "";
                price -= 3; //changes to price and label due to pizza size cost
                label4.Text = "Price: $" + price;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender; //if user checks box
            if (box.Checked)
            {
                pizzaSize = "Medium";
                price += 5; //changes to price and label due to pizza size cost
                label4.Text = "Price: $" + price;
            }
            else
            {
                pizzaSize = "";
                price -= 5; //changes to price and label due to pizza size cost
                label4.Text = "Price: $" + price;
            }
        }
        private string pizzaCrust; //pizza crust holder for order details
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender; //if user checks box
            if (box.Checked)
            {
                pizzaCrust = "Medium ";
            }
            else
            {
                pizzaCrust = "";
            }
        }
        /// <summary>
        /// Variable to hold price
        /// </summary>
        public static int price = 0; 
        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender;
            if (box.Checked) //if user checks box
            {
                pizzaSize = "Large";
                price += 7; //changes to price and label due to pizza size cost
                label4.Text = "Price: $" + price;
            }
            else
            {
                pizzaSize = "";
                price -= 7; //changes to price and label due to pizza size cost
                label4.Text = "Price: $" + price;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender;
            if (box.Checked) //if user checks box
            {
                pizzaSize = "Extra Large";
                price += 9; //changes to price and label due to pizza size cost
                label4.Text = "Price: $" + price;
            }
            else
            {
                pizzaSize = "";
                price -= 9; //changes to price and label due to pizza size cost
                label4.Text = "Price: $" + price;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender; //if user checks box
            if (box.Checked)
            {
                pizzaCrust = "Thin ";
            }
            else
            {
                pizzaCrust = "";
            }
        }
    }
}
