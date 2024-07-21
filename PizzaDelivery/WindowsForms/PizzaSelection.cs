using PizzaDelivery.DataAccessObject.Implementations;
using PizzaDelivery.DataAccessObject.Interfaces;
using PizzaDelivery.Entities;
using PizzaDelivery.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PizzaDelivery.WindowsForms
{
    public partial class PizzaSelection : Form
    {
        private Form previousForm;
        private IProductDAO productDAO = new ImplProduct();
        private List<OrderItem> orderItems = new List<OrderItem>();

        public PizzaSelection(Form previusForm)
        {
            InitializeComponent();
            LoadProducts();
            this.previousForm = previusForm;
        }

        private async void LoadProducts()
        {
            List<Product> products = await productDAO.GetProductsFromDatabaseAsync();

            foreach (var product in products)
            {
                var panel = new Panel
                {
                    Width = 200,
                    Height = 300,
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = product
                };

                var pictureBox = new PictureBox
                {
                    Width = 200,
                    Height = 150,
                    ImageLocation = product.ImageUrl,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                var nameLabel = new Label
                {
                    Text = product.Name,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                var descriptionLabel = new Label
                {
                    Text = product.Description,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                var priceLabel = new Label
                {
                    Text = $"Price: {product.Price:C}",
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                panel1.Controls.Add(pictureBox);
                panel1.Controls.Add(nameLabel);
                panel1.Controls.Add(descriptionLabel);
                panel1.Controls.Add(priceLabel);
                panel1.Click += panel1_Click;

                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            var panel = sender as Panel;
            var product = panel.Tag as Product;

            var orderItem = orderItems.FirstOrDefault(item => item.Product.ID == product.ID);

            if (orderItem != null)
            {
                orderItem.Quantity++;
            }
            else
            {
                orderItems.Add(new OrderItem
                {
                    Product = product,
                    Quantity = 1
                });
            }

            MessageBox.Show($"{product.Name} added to the order.");
        }

        private void btnProceedToCheckout_Click(object sender, EventArgs e)
        {
            //Order order = new Order(this, orderItems);
            //order.Show();
            //this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void PizzaSelection_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && (previousForm.Visible || !previousForm.Visible))
                return;

            Application.Exit();
        }
    }
}
