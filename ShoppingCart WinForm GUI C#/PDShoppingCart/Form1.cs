using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDShoppingCart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private float calculateShirtTotal()
        {
            if (txtShirtQunatity.Text == "")
            {
                txtShirtQunatity.Text = "0";
                lblShirtTotal.Text = "0";
            }
            float price = float.Parse(txtShirtQunatity.Text);
            price = price * (float.Parse(lblShirtPrice.Text));
            lblShirtTotal.Text = price.ToString();
            return price;
        }
        private float calculateShoesTotal()
        {
            if (txtShoesQuantity.Text == "")
            {
                txtShoesQuantity.Text = "0";
                lblShoesTotal.Text = "0";


            }
            float price = float.Parse(txtShoesQuantity.Text);
            price = price * (float.Parse(lblShoesPrice.Text));
            lblShoesTotal.Text = price.ToString();
            return price;
        }
        private float calculatePantsTotal()
        {
            if (txtPantsQuantity.Text == "")
            {
                txtPantsQuantity.Text = "0";
                lblPantsTotal.Text = "0";
            }
            float price = float.Parse(txtPantsQuantity.Text);
            price = price * (float.Parse(lblPantsPrice.Text));
            lblPantsTotal.Text = price.ToString();
            return price;
        }
        private void lblShirtQunatity_TextChanged(object sender, EventArgs e)
        {
            /*float price = float.Parse(txtShirtQunatity.Text);
            price = price * (float.Parse(lblShirtPrice.Text));
            lblShirtTotal.Text = price.ToString();
            /*totalMoney();
        }

        private void txtShoesQuantity_TextChanged(object sender, EventArgs e)
        {
           /* float price = float.Parse(txtShoesQuantity.Text);
            price = price * (float.Parse(lblShoesPrice.Text));
            lblShoesTotal.Text = price.ToString();
           /* totalMoney();*/
        }

        private void txtPantsQuantity_TextChanged(object sender, EventArgs e)
        {
           /* float price = float.Parse(txtPantsQuantity.Text);
            price = price * (float.Parse(lblPantsPrice.Text));
            lblPantsTotal.Text = price.ToString();
            *//*totalMoney();*/
        }

        private void lblTotalMoney_Click(object sender, EventArgs e)
        {
            
        }
        private void totalMoney()
        {
            
            float total = (float.Parse(lblShirtTotal.Text)) + (float.Parse(lblShoesTotal.Text)) + (float.Parse(lblPantsTotal.Text));
            lblTotalMoney.Text = total.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            float total = calculateShirtTotal() + calculateShoesTotal() + calculatePantsTotal();
            lblTotalMoney.Text = total.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtShirtQunatity.Text = "";
            txtShoesQuantity.Text = "";
            txtPantsQuantity.Text = "";
            lblShirtTotal.Text = "";
            lblShoesTotal.Text = "";
            lblPantsTotal.Text = "";
            lblTotalMoney.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lblTotalMoney.Text=="")
            {
                lblTotalMoney.Text = "0";
            }
            if (lblShirtTotal.Text == "")
            {
                lblShirtTotal.Text = "0";
            }
            float sub = float.Parse(lblTotalMoney.Text) - float.Parse(lblShirtTotal.Text);
            lblTotalMoney.Text = sub.ToString();
            txtShirtQunatity.Text = "";
            lblShirtTotal.Text = "";
        }

        private void btnRemoveShoesQuantity_Click(object sender, EventArgs e)
        {
            if (lblTotalMoney.Text == "")
            {
                lblTotalMoney.Text = "0";
            }
            if (lblShoesTotal.Text == "")
            {
                lblShoesTotal.Text = "0";
            }
            float sub = float.Parse(lblTotalMoney.Text) - float.Parse(lblShoesTotal.Text);
            lblTotalMoney.Text = sub.ToString();
            txtShoesQuantity.Text = "";
            lblShoesTotal.Text = "";
        }

        private void btnRemovePantsQuantity_Click(object sender, EventArgs e)
        {
            if (lblTotalMoney.Text == "")
            {
                lblTotalMoney.Text = "0";
            }
            if (lblPantsTotal.Text == "")
            {
                lblPantsTotal.Text = "0";
            }
            float sub = float.Parse(lblTotalMoney.Text) - float.Parse(lblPantsTotal.Text);
            lblTotalMoney.Text = sub.ToString();
            txtPantsQuantity.Text = "";
            lblPantsTotal.Text = "";
        }
    }
}
