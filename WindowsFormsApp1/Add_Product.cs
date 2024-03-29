using MySql.Data.MySqlClient;
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
    public partial class Add_Product : Form
    {
        public Add_Product()
        {
            InitializeComponent();
        }

        private void but_exit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void but_add_product_Click(object sender, EventArgs e)
        {
            BD db = new BD();
            db.OpenDB();

            // Получаем id_brand по названию бренда
            int id_brand = GetBrandIdByName(Convert.ToString(text_product_brand.Text), db);

            if (id_brand != -1)
            {
                // Если бренд существует, добавляем запись в таблицу Product
                string product_name = Convert.ToString(text_product_name.Text);
                int product_count = Convert.ToInt32(text_product_count.Text);
                string product_price = Convert.ToString(text_product_price.Text);

                MySqlCommand cmd = new MySqlCommand("INSERT INTO Product (product_name, product_count, product_price, product_brand_id) VALUES (@product_name, @product_count, @product_price, @product_brand_id)", db.GetConnection());
                cmd.Parameters.Add("@product_name", MySqlDbType.VarChar).Value = product_name;
                cmd.Parameters.Add("@product_count", MySqlDbType.Int32).Value = product_count;
                cmd.Parameters.Add("@product_price", MySqlDbType.VarChar).Value = product_price;
                cmd.Parameters.Add("@product_brand_id", MySqlDbType.Int32).Value = id_brand;

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Успешно добавлено!");
                }
                else
                {
                    MessageBox.Show("Не удалось добавить запись.");
                }
            }
            else
            {
                MessageBox.Show("Бренд не найден.");
            }

            db.CloseDB();
            Close();
        }

        private int GetBrandIdByName(string brandName, BD db)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT brand_id FROM Brand WHERE brand_name = @brand_name", db.GetConnection());
            cmd.Parameters.Add("@brand_name", MySqlDbType.VarChar).Value = brandName;

            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                return Convert.ToInt32(result);
            }
            else
            {
                return -1; // Возвращает -1, если бренд не найден
            }
        }

        private void Add_Product_Load(object sender, EventArgs e)
        {
            BD db = new BD();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.OpenDB();

            MySqlCommand cmd = new MySqlCommand("SELECT product_name as 'название товара', product_count as 'количество товара', product_price as 'цена товара', brand_name as 'название бренда' FROM Product, Brand where product_brand_id = brand_id;", db.GetConnection());
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            db.CloseDB();

            dataGridView1.DataSource = dt;
        }
    }
}
