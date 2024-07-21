using PizzaDelivery.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PizzaDelivery.WindowsForms
{
    public partial class Order : Form
    {
        private Form previousForm;
        private List<OrderItem> orderItems;

    //    public Order(Form previousForm,  List<OrderItem> orderItems)
    //    {
    //        InitializeComponent();
    //        this.previousForm = previousForm;
    //        this.orderItems = orderItems;
    //        DisplayOrderItems();
    //        DisplayTotalAmount();
    //    }

    //    private void DisplayOrderItems()
    //    {
    //        foreach (var item in orderItems)
    //        {
    //            var row = new DataGridViewRow();

    //            row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Product.Name });
    //            row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Quantity });
    //            row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Product.Price });
    //            row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Quantity * item.Product.Price });

    //            dataGridView1.Rows.Add(row);
    //        }
    //    }

    //    private void DisplayTotalAmount()
    //    {
    //        decimal totalAmount = orderItems.Sum(item => item.Quantity * item.Product.Price);
    //        lblTotalAmount.Text = $"Total: {totalAmount:C}";
    //    }

    //    private void btnPlaceOrder_Click(object sender, EventArgs e)
    //    {
    //        // Логика размещения заказа
    //        MessageBox.Show("Order placed successfully!");
    //        this.Close();
    //    }
    }
}
