using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pizza size selection
            if (radioButton1.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust Small Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("5.00");
                    listBox1.Items.Add(item);
                }
                else if(radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Cheesy Crust Small Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("5.00");
                    listBox1.Items.Add(item);
                }
                else if( radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Sausage Crust Small Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("5.00");
                    listBox1.Items.Add(item);
                }
            }
            else if(radioButton2.Checked == true)
            {
                if(radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust Medium Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("7.00");
                    listBox1.Items.Add(item);
                }
                else if(radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Cheesy Crust Medium Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("7.00");
                    listBox1.Items.Add(item);
                }
                else if(radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Sausage Crust Medium Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("7.00");
                    listBox1.Items.Add(item);
                }
            }
            else if(radioButton3.Checked == true)
            {
                if(radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("10.00");
                    listBox1.Items.Add(item);
                }
                else if(radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Cheesy Crust Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("10.00");
                    listBox1.Items.Add(item);
                }
                else if(radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Sausage Crust Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("10.00");
                    listBox1.Items.Add(item);
                }
            }
            else if (radioButton4.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust Extra Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("13.00");
                    listBox1.Items.Add(item);
                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Cheesy Crust Extra Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("13.00");
                    listBox1.Items.Add(item);
                }
                else if (radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Sausage Crust Extra Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("13.00");
                    listBox1.Items.Add(item);
                }
            }

            //Pizza Toppings selection

            if(checkBox1.Checked == true)
            {
                ListViewItem item = new ListViewItem("Pepperoni Topping");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listBox1.Items.Add(item);
            }
            if (checkBox2.Checked == true)
            {
                ListViewItem item = new ListViewItem("Extra Cheese Topping");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listBox1.Items.Add(item);
            }
            if (checkBox3.Checked == true)
            {
                ListViewItem item = new ListViewItem("Mushroom Topping");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listBox1.Items.Add(item);
            }
            if (checkBox4.Checked == true)
            {
                ListViewItem item = new ListViewItem("Ham Topping");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listBox1.Items.Add(item);
            }
            if (checkBox5.Checked == true)
            {
                ListViewItem item = new ListViewItem("Becon Topping");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listBox1.Items.Add(item);
            }
            if (checkBox6.Checked == true)
            {
                ListViewItem item = new ListViewItem("Ground Beef Topping");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listBox1.Items.Add(item);
            }
            if (checkBox7.Checked == true)
            {
                ListViewItem item = new ListViewItem("Jalapeno Topping");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listBox1.Items.Add(item);
            }
            if (checkBox8.Checked == true)
            {
                ListViewItem item = new ListViewItem("pineapple Topping");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listBox1.Items.Add(item);
            }
            if (checkBox9.Checked == true)
            {
                ListViewItem item = new ListViewItem("Dried shrimps Topping");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listBox1.Items.Add(item);
            }
            if (checkBox10.Checked == true)
            {
                ListViewItem item = new ListViewItem("Anchovies Topping");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listBox1.Items.Add(item);
            }
            if (checkBox11.Checked == true)
            {
                ListViewItem item = new ListViewItem("Sun Dried Tomatose Topping");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listBox1.Items.Add(item);
            }
            if (checkBox12.Checked == true)
            {
                ListViewItem item = new ListViewItem("Spinach Topping");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listBox1.Items.Add(item);
            }
            if (checkBox13.Checked == true)
            {
                ListViewItem item = new ListViewItem("Roasted Garlic Topping");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listBox1.Items.Add(item);
            }
            if (checkBox14.Checked == true)
            {
                ListViewItem item = new ListViewItem("Shredded Topping");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listBox1.Items.Add(item);
            }

            //Drink selection

            if (checkBox15.Checked == true)
            {
                ListViewItem item = new ListViewItem("Coke Bottle");
                item.SubItems.Add(textBox1.Text);
                int qty = int.Parse(textBox1.Text);
                double cost = qty * 1.45;
                item.SubItems.Add(cost.ToString());
                listBox1.Items.Add(item);
            }
            else
                textBox1.Text = "";

            if (checkBox16.Checked == true)
            {
                ListViewItem item = new ListViewItem("Diet Coke Bottle");
                item.SubItems.Add(textBox2.Text);
                int qty = int.Parse(textBox2.Text);
                double cost = qty * 1.45;
                item.SubItems.Add(cost.ToString());
                listBox1.Items.Add(item);
            }
            else
                textBox2.Text = "";

            if (checkBox17.Checked == true)
            {
                ListViewItem item = new ListViewItem("Iced Tea Bottle");
                item.SubItems.Add(textBox3.Text);
                int qty = int.Parse(textBox3.Text);
                double cost = qty * 1.45;
                item.SubItems.Add(cost.ToString());
                listBox1.Items.Add(item);
            }
            else
                textBox3.Text = "";

            if (checkBox18.Checked == true)
            {
                ListViewItem item = new ListViewItem("Ginger Ale Bottle");
                item.SubItems.Add(textBox4.Text);
                int qty = int.Parse(textBox4.Text);
                double cost = qty * 1.45;
                item.SubItems.Add(cost.ToString());
                listBox1.Items.Add(item);
            }
            else
                textBox4.Text = "";

            if (checkBox19.Checked == true)
            {
                ListViewItem item = new ListViewItem("Sprite Bottle");
                item.SubItems.Add(textBox5.Text);
                int qty = int.Parse(textBox5.Text);
                double cost = qty * 1.45;
                item.SubItems.Add(cost.ToString());
                listBox1.Items.Add(item);
            }
            else
                textBox5.Text = "";

            if (checkBox20.Checked == true)
            {
                ListViewItem item = new ListViewItem("Root Beer Bottle");
                item.SubItems.Add(textBox6.Text);
                int qty = int.Parse(textBox6.Text);
                double cost = qty * 1.45;
                item.SubItems.Add(cost.ToString());
                listBox1.Items.Add(item);
            }
            else
                textBox6.Text = "";

            if (checkBox21.Checked == true)
            {
                ListViewItem item = new ListViewItem("Water Bottle");
                item.SubItems.Add(textBox7.Text);
                int qty = int.Parse(textBox7.Text);
                double cost = qty * 1.25;
                item.SubItems.Add(cost.ToString());
                listBox1.Items.Add(item);
            }
            else
                textBox7.Text = "";


            //Other item selection

            if(checkBox22.Checked == true)
            {
                ListViewItem item = new ListViewItem("Chicken Wings");
                item.SubItems.Add("");
                item.SubItems.Add("3.00");
                listBox1.Items.Add(item);
            }

            if (checkBox23.Checked == true)
            {
                ListViewItem item = new ListViewItem("Pouting");
                item.SubItems.Add("");
                item.SubItems.Add("3.00");
                listBox1.Items.Add(item);
            }

            if (checkBox24.Checked == true)
            {
                ListViewItem item = new ListViewItem("Onion Rings");
                item.SubItems.Add("");
                item.SubItems.Add("3.00");
                listBox1.Items.Add(item);
            }

            if (checkBox25.Checked == true)
            {
                ListViewItem item = new ListViewItem("Cheesy Garlic Bread");
                item.SubItems.Add("");
                item.SubItems.Add("3.00");
                listBox1.Items.Add(item);
            }

            if (checkBox26.Checked == true)
            {
                ListViewItem item = new ListViewItem("Garlic Dip");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listBox1.Items.Add(item);
            }

            if (checkBox27.Checked == true)
            {
                ListViewItem item = new ListViewItem("BBQ Dip");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listBox1.Items.Add(item);
            }

            if (checkBox28.Checked == true)
            {
                ListViewItem item = new ListViewItem("Sour Cream Dip");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listBox1.Items.Add(item);
            }

            //Calculate total

            double tot = 0;
            double vat = 0;
            double totAmount = 0;

            foreach(ListViewItem item in listBox1.Items)
            {
                tot += double.Parse(item.SubItems[2].Text);

            }

            vat = tot * 0.13;
            totAmount = tot + vat;

            textBox8.Text = tot.ToString();
            textBox9.Text = vat.ToString();
            textBox10.Text = totAmount.ToString();
            textBox19.Text = totAmount.ToString();


            tabControl1.SelectTab("tabPage2");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton5.Checked = true;

            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox19.Enabled = false;
            textBox21.Enabled = false;

            comboBox1.Items.Add("Central");
            comboBox1.Items.Add("North Central");
            comboBox1.Items.Add("Northern");
            comboBox1.Items.Add("Eastern");
            comboBox1.Items.Add("North Western");
            comboBox1.Items.Add("Southern");
            comboBox1.Items.Add("Uva");
            comboBox1.Items.Add("Sabaragamuwa");
            comboBox1.Items.Add("Western");

            CB2.Items.Add("Cash");
            CB2.Items.Add("Credit Card");
            CB2.Items.Add("Debit Card");
            CB2.Items.Add("Promo Card");

            button7.Enabled = false;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("are you sure,Do you really want to exit....?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage1");
            listBox1.Items.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled= true;
            }

        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled=! true;
            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&& e.KeyChar != 8)
            {
                e.Handled= true;
            }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&& e.KeyChar != 8)
            {
                e.Handled= true;
            }
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CB2.Text == "cash")
            {
                textBox18.Enabled= false;
                textBox18.Text = "";

            }
            else
            {
                textBox18.Enabled= true;
            }
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit((char)e.KeyChar) && e.KeyChar != 46 && e.KeyChar !=8)
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(textBox11.Text == ""||textBox12.Text == ""||textBox13.Text == ""||textBox14.Text == ""||CB2.Text == ""||textBox20.Text == "")
            {
                MessageBox.Show("please fill in required fields");
            }
            else
            {
                double paymoney = double.Parse(textBox10.Text);
                double money = double.Parse(textBox20.Text);
                double change = money - paymoney;

                textBox21.Text = change.ToString(""+Math.Round(change));    


                if(change<0)
                {
                    MessageBox.Show("Please pay your bill");
                    textBox21.Text = "";
                }
                else
                {
                    button7.Enabled = true;
                }
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage3");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox11.Text.Length > 0 && textBox12.Text.Length > 0 && textBox13.Text.Length > 0  && comboBox1.Text.Length > 0 && textBox15.Text.Length > 0 && textBox14.Text.Length > 0 && textBox16.Text.Length > 0 && textBox17.Text.Length > 0)
            {
                customers std = new customers(textBox11.Text.Trim(), textBox12.Text.Trim(), textBox13.Text.Trim(),comboBox1.Text.Trim(), textBox15.Text.Trim(), textBox14.Text.Trim(), textBox16.Text.Trim(), textBox17.Text.Trim());
                pizzaDB.addCustomer(std);
            }
            else
            {
                MessageBox.Show("Complete the data entry", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //FOR PAYMENT DATA ENTRY

             if (textBox19.Text.Length > 0 && textBox18.Text.Length > 0 && textBox20.Text.Length > 0 && CB2.Text.Length > 0)
             {
                 payment std = new payment (CB2.Text.Trim(),textBox18.Text.Trim(), textBox19.Text.Trim(),textBox20.Text.Trim());
                 pizzaDB.addPayment(std);
             }
             else
             {
                 MessageBox.Show("Complete the data entry", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }


            DialogResult dialog = MessageBox.Show("Thanks for Ordering at Pizza House.Your Ordered items will be ready and delivered in 30 minutes.Do you want to order some more?","Exit",MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                radioButton1.Checked = true;
                radioButton5.Checked = true;

                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
                checkBox19.Checked = false; 
                checkBox20.Checked = false;
                checkBox21.Checked = false;
                checkBox22.Checked = false;
                checkBox23.Checked = false;
                checkBox24.Checked = false;
                checkBox25.Checked = false;
                checkBox26.Checked = false;
                checkBox27.Checked = false;
                checkBox28.Checked = false;

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";

                listBox1.Items.Clear();
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";

                button7.Enabled = false;

                textBox11.Text = "";
                textBox12.Text = "";
                textBox13.Text = "";
                comboBox1.Text = "";
                textBox15.Text = "";
                textBox14.Text = "";
                textBox16.Text = "";
                textBox17.Text = "";
                CB2.Text = "";
                textBox18.Text = "";
                textBox19.Text = "";
                textBox20.Text = "";
                textBox21.Text = "";


                tabControl1.SelectTab("tabPage1");

            
            }
            else if(dialog == DialogResult.No)
            {
                this.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage2");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear ();
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";

            //clear order tabPage1(pizza size & crust)
            radioButton1.Checked = true;
            radioButton5.Checked = true;


            //clear order tabPage1(toppings)
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;

            //clear order tabPage1(Drinks)
            checkBox15.Checked = false;
            textBox1.Text = "";
            checkBox16.Checked = false;
            textBox2.Text = "";
            checkBox17.Checked = false;
            textBox3.Text = "";
            checkBox18.Checked = false;
            textBox4.Text = "";
            checkBox19.Checked = false;
            textBox5.Text = "";
            checkBox20.Checked = false;
            textBox6.Text = "";
            checkBox21.Checked = false;
            textBox7.Text = "";


            //clear order tabPage1(other items)
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
            checkBox26.Checked = false;
            checkBox27.Checked = false;
            checkBox28.Checked = false;


            tabControl1.SelectTab(tabPage1);



        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
