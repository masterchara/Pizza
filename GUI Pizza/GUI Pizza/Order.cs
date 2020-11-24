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
    public partial class Order : Form
    {
        private int price = Form1.labels + Form2.labels;
        public Order()
        {
            InitializeComponent();
            label1.Text = "Total Price: $" + price; //Total price
            label2.Text = "Drink: " + Form2.drink; //drink type
            label5.Text = "$" + Form2.labels; //drink price
            label6.Text = "$" + Form1.labels; //food price
            label3.Text = "Pizza: " + Form1.pizza; //type of pizza
            label7.Text = "Toppings: " + Form1.toppings; //pizza toppings
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Price: $" + price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Order_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
