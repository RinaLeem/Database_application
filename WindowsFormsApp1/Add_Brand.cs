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
    public partial class Add_Brand : Form
    {
        public Add_Brand()
        {
            InitializeComponent();
        }

        private void but_exit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void but_add_brand_Click(object sender, EventArgs e)
        {
            BD db = new BD();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.OpenDB();
            int primaryKeyValueToCheck = 10;

            while (true)
            {
                MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM Brand WHERE brand_id = @primaryKeyValue", db.GetConnection());
                checkCmd.Parameters.Add("@primaryKeyValue", MySqlDbType.Int32).Value = primaryKeyValueToCheck;
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (count > 0) {
                    primaryKeyValueToCheck += 1;
                }
                else { 
                    string brand_name = Convert.ToString(text_brand_name.Text);
                    
                    MySqlCommand cmd1 = new MySqlCommand("INSERT INTO Brand VALUES(@brand_id, @brand_name)", db.GetConnection());
                    cmd1.Parameters.Add("@brand_id", MySqlDbType.Int32).Value = primaryKeyValueToCheck;
                    cmd1.Parameters.Add("@brand_name", MySqlDbType.String).Value = brand_name;
                    int a = cmd1.ExecuteNonQuery();
                    db.CloseDB();
                    break;
                }
            }
            MessageBox.Show("Успешно!");
            Close();
        }

        private void Add_Brand_Load(object sender, EventArgs e)
        {
            BD db = new BD();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.OpenDB();

            MySqlCommand cmd = new MySqlCommand("SELECT brand_name as 'название бренда' FROM Brand;", db.GetConnection());
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            db.CloseDB();

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
