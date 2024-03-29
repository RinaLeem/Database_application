using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void but_make_order_Click(object sender, EventArgs e)
        {
            Form2 make_order = new Form2();
            make_order.Show();
        }

        private void but_add_company_Click(object sender, EventArgs e)
        {
            Add_Company add_Company = new Add_Company();
            add_Company.Show();
        }

        private void but_add_product_Click(object sender, EventArgs e)
        {
            Add_Product add_Product = new Add_Product();
            add_Product.Show();
        }

        private void but_add_brand_Click(object sender, EventArgs e)
        {
            Add_Brand add_Brand = new Add_Brand();
            add_Brand.Show();
        }

        private void but_agree_Click(object sender, EventArgs e)
        {
            Agree_Delivery agree_Delivery = new Agree_Delivery();
            agree_Delivery.Show();
        }

        private void but_data_Click(object sender, EventArgs e)
        {
            Data data = new Data(); 
            data.Show();
        }
         
        private void but_disagree_Click_1(object sender, EventArgs e)
        {
            Disagree_Delivery disagree_Delivery = new Disagree_Delivery();
            disagree_Delivery.Show();
        }
    }
}
