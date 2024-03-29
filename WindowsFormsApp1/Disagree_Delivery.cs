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
    public partial class Disagree_Delivery : Form
    {
        public Disagree_Delivery()
        {
            InitializeComponent();
        }

        private void but_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            BD db = new BD();
            db.OpenDB();

            // Получаем order_id по номеру заказа
            int order_id = GetOrderIdByNumber(Convert.ToString(text_delivery.Text), db);

            if (order_id != -1)
            {
                // Если заказ существует, удаляем запись из таблицы Orders
                
                MySqlCommand cmdDeleteOrder = new MySqlCommand("DELETE FROM Orders WHERE order_id = @order_id", db.GetConnection());
                cmdDeleteOrder.Parameters.Add("@order_id", MySqlDbType.Int32).Value = order_id;

                int rowsAffected = cmdDeleteOrder.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Запись успешно удалена!");
                }
                else
                {
                    MessageBox.Show("Не удалось удалить запись. Возможно, что-то пошло не так.");
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

        private void Disagree_Delivery_Load(object sender, EventArgs e)
        {
            BD db = new BD();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.OpenDB();

            MySqlCommand cmd = new MySqlCommand("select order_id as 'id заказа', order_count as 'количество', order_date as 'дата заказа', order_deadline as 'дата доставки', company_name as 'нзвание компании', product_name as 'название продукта' from Orders\r\njoin Company on company_id = order_company_id\r\njoin Product on ordert_product_id = product_id;", db.GetConnection());
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            db.CloseDB();

            dataGridView1.DataSource = dt;
        }
    }
}
