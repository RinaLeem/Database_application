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
    public partial class Add_Company : Form
    {
        public Add_Company()
        {
            InitializeComponent();
        }

        private void but_exit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void but_add_company_Click(object sender, EventArgs e)
        {
            BD db = new BD();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.OpenDB();
            int primaryKeyValueToCheck = 10;

            while (true)
            {
                MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM Company WHERE company_id = @primaryKeyValue", db.GetConnection());
                checkCmd.Parameters.Add("@primaryKeyValue", MySqlDbType.Int32).Value = primaryKeyValueToCheck;
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (count > 0)
                {
                    primaryKeyValueToCheck += 1;
                }
                else
                {
                    string company_name = Convert.ToString(text_company_name.Text);
                    string company_address = Convert.ToString(text_company_address.Text);
                    string company_phone = Convert.ToString(text_company_phone.Text);

                    MySqlCommand cmd1 = new MySqlCommand("INSERT INTO Company VALUES(@company_id, @company_name, @company_address, @company_phone)", db.GetConnection());
                    cmd1.Parameters.Add("@company_id", MySqlDbType.Int32).Value = primaryKeyValueToCheck;
                    cmd1.Parameters.Add("@company_name", MySqlDbType.String).Value = company_name;
                    cmd1.Parameters.Add("@company_address", MySqlDbType.String).Value = company_address;
                    cmd1.Parameters.Add("@company_phone", MySqlDbType.String).Value = company_phone;

                    int a = cmd1.ExecuteNonQuery();
                    db.CloseDB();
                    break;
                }
            }
            MessageBox.Show("Успешно!");
            Close();
        }

        private void Add_company_Load(object sender, EventArgs e)
        {
            BD db = new BD();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.OpenDB();

            MySqlCommand cmd = new MySqlCommand("SELECT company_name as 'название компании', company_address as 'адрес компании', company_phone as 'номер телефона компании' FROM Company;", db.GetConnection());
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            db.CloseDB();

            dataGridView1.DataSource = dt;
        }
    }
}
