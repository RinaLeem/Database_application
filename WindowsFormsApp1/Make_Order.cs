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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void but_make_order_Click(object sender, EventArgs e)
        {
            BD db = new BD();
            db.OpenDB();

            // Получаем ordert_product_id по названию продукта
            int ordert_product_id = GetProductIdByName(Convert.ToString(text_product_name.Text), db);

            if (ordert_product_id != -1)
            {
                // Если продукт существует, продолжаем добавление записи в таблицу Order

                // Получаем order_company_id по названию компании
                int order_company_id = GetCompanyIdByName(Convert.ToString(text_company_name.Text), db);

                if (order_company_id != -1)
                {
                    // Если компания существует, добавляем запись в таблицу Order
                    int order_count = Convert.ToInt32(numericUpDown1.Value);
                    DateTime order_date = DateTime.Now;
                    DateTime order_deadline = order_date.AddMonths(1);

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Orders (order_count, order_date, order_deadline, ordert_product_id, order_company_id) VALUES (@order_count, @order_date, @order_deadline, @ordert_product_id, @order_company_id)", db.GetConnection());
                    cmd.Parameters.Add("@order_count", MySqlDbType.Int32).Value = order_count;
                    cmd.Parameters.Add("@order_date", MySqlDbType.DateTime).Value = order_date;
                    cmd.Parameters.Add("@order_deadline", MySqlDbType.DateTime).Value = order_deadline;
                    cmd.Parameters.Add("@ordert_product_id", MySqlDbType.Int32).Value = ordert_product_id;
                    cmd.Parameters.Add("@order_company_id", MySqlDbType.Int32).Value = order_company_id;

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
                    MessageBox.Show("Компания не найдена.");
                }
            }
            else
            {
                MessageBox.Show("Продукт не найден.");
            }

            db.CloseDB();
            Close();
        }


        private int GetProductIdByName(string productName, BD db)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT product_id FROM Product WHERE product_name = @product_name", db.GetConnection());
            cmd.Parameters.Add("@product_name", MySqlDbType.VarChar).Value = productName;

            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                return Convert.ToInt32(result);
            }
            else
            {
                return -1; // Возвращает -1, если продукт не найден
            }
        }

        private int GetCompanyIdByName(string companyName, BD db)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT company_id FROM Company WHERE company_name = @company_name", db.GetConnection());
            cmd.Parameters.Add("@company_name", MySqlDbType.VarChar).Value = companyName;

            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                return Convert.ToInt32(result);
            }
            else
            {
                return -1; // Возвращает -1, если компания не найдена
            }
        }
        private void but_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BD db = new BD();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.OpenDB();

            MySqlCommand cmd = new MySqlCommand("SELECT product_name as 'название товара', product_count as 'количество', product_price as 'цена товара' FROM Product;", db.GetConnection());
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            db.CloseDB();

            data_product.DataSource = dt;

            BD db1 = new BD();
            DataTable dt1 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter();
            db1.OpenDB();

            MySqlCommand cmd1 = new MySqlCommand("SELECT company_name as 'название компании' FROM Company;", db1.GetConnection());
            adapter1.SelectCommand = cmd1;
            adapter1.Fill(dt1);

            db1.CloseDB();

            data_company.DataSource = dt1;
        }

    }
}
