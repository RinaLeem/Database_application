using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class BD
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=3001;database=mydb");

        public void OpenDB()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseDB()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public DataTable GetCosmeticOrdersByYear(int year)
        {
            DataTable dt = new DataTable();

            try
            {
                OpenDB();

                MySqlCommand cmd = new MySqlCommand(@"SELECT 
                                                company_name AS 'Компания', 
                                                B.brand_name AS 'Бренд',
                                                P.product_name AS 'Товар',
                                                O.order_date AS 'Дата исполнения заказа',
                                                D.delivery_count AS 'Количество товара в доставке',
                                                P.product_price AS 'Цена, руб',
                                                D.delivery_count * P.product_price AS 'Стоимость, руб'
                                                FROM Orders O
                                                JOIN Delivery D ON O.order_id = D.delivery_order_id
                                                JOIN Product P ON O.ordert_product_id = P.product_id
                                                JOIN Brand B ON P.product_brand_id = B.brand_id
                                                JOIN Company C ON O.order_company_id = C.company_id
                                                WHERE YEAR(O.order_date) = @year
                                                Order BY order_company_id;", GetConnection());

                cmd.Parameters.Add("@year", MySqlDbType.Int32).Value = year;

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок, например, вывод в лог
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                CloseDB();
            }

            return dt;
        }

    }
}
