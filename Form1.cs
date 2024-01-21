using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eric_Howard_CPT_206_Chapter_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create Data context object 
            ProductDBDataContext db = new ProductDBDataContext();

            //Get all Product objects form the products collection 
            var results = from product in db.Products
                          select product;
            //Assign the results of the query to DataGridView control 
            productDataGridView.DataSource = results;
        }

        private void prodNumberBtn_Click(object sender, EventArgs e)
        {
            //Create Data context object 
            string prodNum = productNumberTextBox.Text;

            //Get all Product objects form the products collection that are prodNum  
            ProductDBDataContext db = new ProductDBDataContext();
            var results = from product in db.Products
                          where product.Product_Number == prodNum
                          select product;
            //Assign the results of the query to DataGridView control 
            productDataGridView.DataSource = results;
        }

        private void prodDescBtn_Click(object sender, EventArgs e)
        {
            //Create Data context object 
            string prodDesc = productDescTextBox.Text;

            //Get all Product objects form the products collection that contain prodDesc
            ProductDBDataContext db = new ProductDBDataContext();
            var results = from product in db.Products
                          where product.Description.Contains (prodDesc)
                          select product;
            //Assign the results of the query to DataGridView control 
            productDataGridView.DataSource = results;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            //Create new form to reset application 
            Form1 newForm = new Form1();
            newForm.Show();
            this.Dispose(false);


        }

        private void ascendingOnhandBtn_Click(object sender, EventArgs e)
        {
            //Create Data context object 
            ProductDBDataContext db = new ProductDBDataContext();

            //Get all Product objects form the products collection 
            var results = from product in db.Products
                          orderby product.Units_On_Hand ascending
                          select product;
            //Assign the results of the query to DataGridView control 
            productDataGridView.DataSource = results;
        }

        private void gtUnitsBtn_Click(object sender, EventArgs e)
        {
            int onHand = 0;
            if(int.TryParse(gtUnitsTextBox.Text, out onHand))
            {
                //Create Data context object 
                ProductDBDataContext db = new ProductDBDataContext();

                //Get all Product objects form the products collection that are > onHand 
                var results = from product in db.Products
                              where product.Units_On_Hand > onHand
                              select product;
                //Assign the results of the query to DataGridView control 
                productDataGridView.DataSource = results;
            }
            else
            {
                //Display if number is not entered 
                MessageBox.Show("You did not enter a number");
                gtUnitsTextBox.Text = "";
            }

        }

        private void ltUnitsBtn_Click(object sender, EventArgs e)
        {
            int onHand = 0;
            if (int.TryParse(ltUnitsTextBox.Text, out onHand))
            {
                //Create Data context object 
                ProductDBDataContext db = new ProductDBDataContext();

                //Get all Product objects form the products collection that are < onHand 
                var results = from product in db.Products
                              where product.Units_On_Hand < onHand
                              select product;
                //Assign the results of the query to DataGridView control 
                productDataGridView.DataSource = results;
            }
            else
            {
                //Display if number is not entered 
                MessageBox.Show("You did not enter a number");
                gtUnitsTextBox.Text = "";
            }
        }

        private void sortPriceAscBtn_Click(object sender, EventArgs e)
        {
            //Create Data context object 
            ProductDBDataContext db = new ProductDBDataContext();

            //Get all Product objects form the products collection 
            var results = from product in db.Products
                          orderby product.Price ascending
                          select product;
            //Assign the results of the query to DataGridView control 
            productDataGridView.DataSource = results;
        }

        private void gtPriceBtn_Click(object sender, EventArgs e)
        {
            decimal price = 0m;
            if (decimal.TryParse(gtPriceTextBox.Text, out price))
            {
                //Create Data context object 
                ProductDBDataContext db = new ProductDBDataContext();

                //Get all Product objects form the products collection that are > Price
                var results = from product in db.Products
                              where product.Price < price
                              select product;
                //Assign the results of the query to DataGridView control 
                productDataGridView.DataSource = results;
            }
            else
            {
                //Display if number is not entered 
                MessageBox.Show("Please enter a number ");
                gtPriceTextBox.Text = "";
            }
        }

        private void ltPriceBtn_Click(object sender, EventArgs e)
        {
            decimal price = 0m;
            if (decimal.TryParse(ltPriceTextBox.Text, out price))
            {
                //Create Data context object 
                ProductDBDataContext db = new ProductDBDataContext();

                //Get all Product objects form the products collection that are > Price
                var results = from product in db.Products
                              where product.Price > price
                              select product;
                //Assign the results of the query to DataGridView control 
                productDataGridView.DataSource = results;
            }
            else
            {
                //Display if number is not entered 
                MessageBox.Show("Please enter a number ");
                ltPriceTextBox.Text = "";
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            //close form 
            this.Close();
        }
    }
}
