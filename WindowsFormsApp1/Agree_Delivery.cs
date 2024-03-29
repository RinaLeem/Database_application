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
    public partial class Agree_Delivery : Form
    {
        public Agree_Delivery()
        {
            InitializeComponent();
        }

        private void but_agreee_oreder_Click(object sender, EventArgs e)
        {
            BD db = new BD();
            db.OpenDB();

            // Получаем delivery_order_id по номеру заказа
            int delivery_order_id = GetOrderIdByNumber(Convert.ToString(text_delivery.Text), db);

            if (delivery_order_id != -1)
            {
                // Если заказ существует, добавляем запись в таблицу Delivery
                DateTime delivery_date = DateTime.Now;
                int delivery_count = Convert.ToInt32(numericUpDown1.Value); // Получаем количество товара, которое пришло

                MySqlCommand cmd = new MySqlCommand("INSERT INTO Delivery (delivery_date, delivery_count, delivery_order_id) VALUES (@delivery_date, @delivery_count, @delivery_order_id)", db.GetConnection());
                cmd.Parameters.Add("@delivery_date", MySqlDbType.DateTime).Value = delivery_date;
                cmd.Parameters.Add("@delivery_count", MySqlDbType.Int32).Value = delivery_count;
                cmd.Parameters.Add("@delivery_order_id", MySqlDbType.Int32).Value = delivery_order_id;

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Успешно!");
                }
                else
                {
                    MessageBox.Show("Не удалось добавить запись.");
                }
            }
            else
            {
                MessageBox.Show("Заказ не найден.");
            }

            db.CloseDB();
            Close();
        }

        private int GetOrderIdByNumber(string orderNumber, BD db)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT order_id FROM Orders WHERE order_id = @order_id", db.GetConnection());
            cmd.Parameters.Add("@order_id", MySqlDbType.Int32).Value = orderNumber;

            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                return Convert.ToInt32(result);
            }
            else
            {
                return -1; // Возвращает -1, если заказ не найден
            }
        }

        private void but_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Agree_Delivery_Load(object sender, EventArgs e)
        {
            BD db = new BD();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.OpenDB();

            MySqlCommand cmd = new MySqlCommand(" SELECT   O.order_id AS 'Номер заказа',   P.product_name AS 'Товар',  O.order_count AS 'Заказано, шт',  SUM(COALESCE(D.delivery_count, 0)) AS 'Доставлено, шт',  O.order_date AS 'Дата заказа',\r\n    O.order_deadline AS 'Крайний срок доставки'\r\nFROM\r\n    Orders O\r\nJOIN\r\n    Product P ON O.ordert_product_id = P.product_id\r\nLEFT JOIN\r\n    Delivery D ON O.order_id = D.delivery_order_id\r\nGROUP BY O.order_id ; ", db.GetConnection());
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            db.CloseDB();

            dataGridView1.DataSource = dt;
        }
    }
}
