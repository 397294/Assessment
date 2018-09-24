using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1Recap
{
    public partial class Form1 : Form
    {

        private Class1 list = new Class1();
        List<string> basket = new List<string>();

        public Form1()
        {
            InitializeComponent();

            cboCategory.Items.Add("Winnie-the-Pooh");
            cboCategory.Items.Add("Tigger");
            cboCategory.Items.Add("Eeyore");
            cboQty.Items.Add(1);
            cboQty.Items.Add(2);
        }

        // Displays the product selected
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            list.Lists = basket. 
        }

        
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstItems.Items.Clear();

            string chosen = cboCategory.Text;
            if (cboCategory.Text == "Winnie-the-Pooh")
            {
                lstItems.Items.Add("Pooh soft toy");
                lstItems.Items.Add("Pooh door mat");
                lstItems.Items.Add("Pooh dress");
                lstItems.Items.Add("Pooh sweatshirt");
            }
            else if (cboCategory.Text == "Tigger")
            {
                lstItems.Items.Add("Tigger soft toy");
                lstItems.Items.Add("Tigger cookie jar");
            }
            else if (cboCategory.Text == "Eeyore")
            {
                lstItems.Items.Add("Eeyore soft toy");
                lstItems.Items.Add("Eeyore lamp");
            }
        }

       

        private void lstItems_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItem.ToString() == "Pooh soft toy")
            {
                picItem.Image = Image.FromFile("Pooh.jpg");
            }
            else if (lstItems.SelectedItem.ToString() == "Eeyore soft toy")
            {
                picItem.Image = Image.FromFile("Eeyore.jpg");
            }
            else if (lstItems.SelectedItem.ToString() == "Eeyore lamp")
            {
                picItem.Image = Image.FromFile("EeyoreLamp.jpg");
            }
            else if (lstItems.SelectedItem.ToString() == "Pooh door mat")
            {
                picItem.Image = Image.FromFile("PoohDoorMat.jpg");
            }
            else if (lstItems.SelectedItem.ToString() == "Pooh dress")
            {
                picItem.Image = Image.FromFile("PoohDress.jpg");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
      

            if (cboQty.Text == "2")
            {
                if (lstItems.SelectedItem.ToString() == "Pooh soft toy")
                {
                    basket.Add("Pooh soft toy");
                    basket.Add("Pooh soft toy");
                }
                else if (lstItems.SelectedItem.ToString() == "Eeyore soft toy")
                {
                    basket.Add("Eeyore soft toy");
                    basket.Add("Eeyore soft toy");
                }
                else if (lstItems.SelectedItem.ToString() == "Eeyore lamp")
                {
                    basket.Add("Eeyore lamp");
                    basket.Add("Eeyore lamp");
                }
                else if (lstItems.SelectedItem.ToString() == "Pooh door mat")
                {
                    basket.Add("Pooh door mat");
                    basket.Add("Pooh door mat");
                }
                else if (lstItems.SelectedItem.ToString() == "Pooh dress")
                {
                    basket.Add("Pooh dress");
                    basket.Add("Pooh dress");
                }
                else
                {
                    MessageBox.Show("Invalid Order");
                }
            }
            else if (cboQty.Text == "1")
            {
                if (lstItems.SelectedItem.ToString() == "Pooh soft toy")
                {
                    basket.Add("Pooh soft toy");
                   
                }
                else if (lstItems.SelectedItem.ToString() == "Eeyore soft toy")
                {
                    basket.Add("Eeyore soft toy");
                   
                }
                else if (lstItems.SelectedItem.ToString() == "Eeyore lamp")
                {
                    basket.Add("Eeyore lamp");
                   
                }
                else if (lstItems.SelectedItem.ToString() == "Pooh door mat")
                {
                    basket.Add("Pooh door mat");
                    
                }
                else if (lstItems.SelectedItem.ToString() == "Pooh dress")
                {
                    basket.Add("Pooh dress");
                    
                }
                else
                {
                    MessageBox.Show("Invalid Order");
                }
            }
            else
            {
                MessageBox.Show("Invalid Order");

            }
                    

        }
    }
}
