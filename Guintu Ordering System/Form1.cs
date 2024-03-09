namespace Guintu_Ordering_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double total;
        private double cash;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbDish.Text)
            {
                case "McSpaghetti Solo":
                    priceDish.Text = "56";
                    break;
                case "Cheeseburger":
                    priceDish.Text = "100";
                    break;
                case "1pc Chicken McDo Original":
                    priceDish.Text = "95";
                    break;
                case "1pc Chicken McDo Spicy":
                    priceDish.Text = "98";
                    break;
                case "Big Mac":
                    priceDish.Text = "173";
                    break;

            }
            calculateTotal();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cbDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbDrinks.Text)
            {
                case "McCafe Coffee Float":
                    priceDrinks.Text = "59";
                    break;
                case "Original McCafe Iced Coffee":
                    priceDrinks.Text = "40";
                    break;
                case "Coke McFloat":
                    priceDrinks.Text = "29";
                    break;
                case "Mc Freeze":
                    priceDrinks.Text = "32";
                    break;
                case "Mc Iced Coffee Chocolate":
                    priceDrinks.Text = "50";
                    break;

            }
            calculateTotal();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void priceDrinks_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            priceDish.Text = "---";
            cbDish.Text = null;
            priceDrinks.Text = "---";
            cbDrinks.Text = null;
            txtPayment.Text = null;
            btnPurchase.Enabled = false;
            lblChange.Text = null;
        }

        private void priceDish_Click(object sender, EventArgs e)
        {

        }

        private void calculateTotal()
        {
            double dishPrice;
            double drinkPrice;
            try
            {
                dishPrice = double.Parse(priceDish.Text);
            }
            catch
            {
                dishPrice = 0;
            }

            try
            {
                drinkPrice = double.Parse(priceDrinks.Text);
            }
            catch
            {
                drinkPrice = 0;
            }

            total = dishPrice + drinkPrice;
            double tax = total * 0.12;
            lblTax.Text = tax.ToString("F2");
            lblTotalPrice.Text = total.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cash = double.Parse(txtPayment.Text);
            }
            catch
            {
                cash = 0;
            }

            if (cash >= total)
            {
                btnPurchase.Enabled = true;
            }
            else
            {
                btnPurchase.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double change = cash - total;
            lblChange.Text = change.ToString();
        }
    }
   }

