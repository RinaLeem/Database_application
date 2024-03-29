using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using MySqlX.XDevAPI.Relational;


namespace WindowsFormsApp1
{
    public partial class Data : Form
    {
        static string year = "2023";
        public Data()
        {
            InitializeComponent();
        }

        public class PdfGenerator
        {
            public void GeneratePdf(DataGridView dataGridView, string filePath)
            {
                try
                {
                    string title = "Сведения об исполненных заказах на поставку косметической продукции за " + year + " год:";
                    PdfDocument pdf = new PdfDocument();
                    PdfPage pdfPage = pdf.AddPage();

                    XGraphics gfx = XGraphics.FromPdfPage(pdfPage);
                    XFont font = new XFont("Arial", 12);

                    gfx.DrawString(title, font, XBrushes.Black, new XRect(50, 10, 250, 20), XStringFormats.TopLeft);

                    int x = 10;
                    int rowHeight = 30; // Высота строки
                    int xWidth = 140; // Ширина колонки
                    gfx.DrawLine(XPens.Black, new XPoint(0, rowHeight), new XPoint(pdfPage.Width, rowHeight));

                    // Добавление заголовков таблицы
                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        gfx.DrawString(column.HeaderText, font, XBrushes.Black, new XRect(x, rowHeight, xWidth, rowHeight), XStringFormats.TopLeft);
                        x += xWidth;
                        xWidth = 95;
                    }
                    xWidth = 140;
                    rowHeight += 20;
                    
                    // Добавление данных из DataGridView в таблицу
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        x = 10;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            gfx.DrawString(cell.Value?.ToString() ?? "", font, XBrushes.Black, new XRect(x, rowHeight, xWidth, rowHeight), XStringFormats.TopLeft);
                            x += xWidth;
                            gfx.DrawLine(XPens.Black, new XPoint(0, rowHeight), new XPoint(pdfPage.Width, rowHeight));
                            xWidth = 95;
                        }

                        // Добавление отступа после каждого кортежа
                        rowHeight += 20;
                        xWidth = 140;
                    }

                    x = 145;
                    //Рисование вертикальных линий таблицы
                    for (int i = 0; i <= dataGridView.Columns.Count; i++)
                    {
                        gfx.DrawLine(XPens.Black, new XPoint(x, 30), new XPoint(x, rowHeight - 20));
                        x += 95;
                    }

                    pdf.Save(filePath);

                    //MessageBox.Show("PDF-файл успешно создан.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при создании PDF: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
       
        }

        // Класс для хранения информации о компании и продукте
        public class CompanyProductInfo
        {
            public string Компания { get; set; }
            public string Бренд { get; set; }
            public string Товар { get; set; }
            public int Количество { get; set; }
            public double Цена { get; set; }
            public double Стоимость { get; set; }
        }

        private void but_brand_Click(object sender, EventArgs e)
        {
            BD db = new BD();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.OpenDB();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Brand;", db.GetConnection());
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            db.CloseDB();

            dataGridView1.DataSource = dt;
        }

        private void but_product_Click(object sender, EventArgs e)
        {
            BD db = new BD();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.OpenDB();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Product;", db.GetConnection());
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            db.CloseDB();

            dataGridView1.DataSource = dt;
        }

        private void but_company_Click(object sender, EventArgs e)
        {
            BD db = new BD();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.OpenDB();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Company;", db.GetConnection());
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            db.CloseDB();

            dataGridView1.DataSource = dt;
        }

        private void but_delivery_Click(object sender, EventArgs e)
        {
            BD db = new BD();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.OpenDB();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Delivery;", db.GetConnection());
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            db.CloseDB();

            dataGridView1.DataSource = dt;
        }

        private void but_order_Click(object sender, EventArgs e)
        {
            BD db = new BD();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.OpenDB();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Orders;", db.GetConnection());
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            db.CloseDB();

            dataGridView1.DataSource = dt;
        }

        private void but_data_Click(object sender, EventArgs e)
        {
            BD db = new BD();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.OpenDB();

            //MySqlCommand cmd = new MySqlCommand("SELECT P.product_name  AS 'Товар',B.brand_name as 'Бренд',O.order_date AS 'Дата исполнения заказа',D.delivery_count AS 'Количество товара в доставке',P.product_price AS 'Цена, руб',D.delivery_count * P.product_price AS 'Стоимость, руб' FROM Orders O\r\nJOIN Delivery D ON O.order_id = D.delivery_order_id\r\nJOIN Product P ON O.ordert_product_id = P.product_id\r\nJOIN Brand B ON P.product_brand_id = B.brand_id;", db.GetConnection());
            MySqlCommand cmd = new MySqlCommand(@"SELECT B.brand_name AS 'Бренд',
                                                company_name AS 'Компания',
                                                P.product_name AS 'Товар',
                                                O.order_date AS 'Дата исполнения заказа',
                                                D.delivery_count AS 'Количество товара в доставке',
                                                P.product_price AS 'Цена, руб',
                                                D.delivery_count * P.product_price AS 'Стоимость, руб'
                                                FROM Orders O
                                                JOIN Delivery D ON O.order_id = D.delivery_order_id
                                                JOIN Product P ON O.ordert_product_id = P.product_id
                                                JOIN Brand B ON P.product_brand_id = B.brand_id
                                                JOIN Company C ON O.order_company_id = C.company_id", db.GetConnection());
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            db.CloseDB();

            dataGridView1.DataSource = dt;
        }


        private void otchetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(otchetComboBox.SelectedItem.ToString(), out int selectedYear))
            {
                year = otchetComboBox.SelectedItem.ToString();
                DisplayingData(selectedYear);
                but_save.Visible = true;
            }
            else
            {
                // Обработка ошибки, например, вывод в лог
                Console.WriteLine("Error: Невозможно преобразовать год в число.");
            }

        }

        private void DisplayingData(int year)
        {
            BD db = new BD();

            // Получение данных о выполненных заказах за год по каждой компании
            DataTable dt = db.GetCosmeticOrdersByYear(year);

            var groupedData = from row in dt.AsEnumerable()
                              group row by new
                              {
                                  Company = row.Field<string>("Компания"),
                                  Brand = row.Field<string>("Бренд"),
                                  Product = row.Field<string>("Товар"),
                                  Quantity = GetSafeIntValue(row, "Количество товара в доставке"),
                                  Price = GetSafeDoubleValue(row, "Цена, руб")
                              } into productGroup
                              select new
                              {
                                  Company = productGroup.Key.Company,
                                  Brand = productGroup.Key.Brand,
                                  Product = productGroup.Key.Product,
                                  Quantity = productGroup.Sum(r => GetSafeIntValue(r, "Количество товара в доставке")),
                                  Price = productGroup.Key.Price,
                                  TotalCost = productGroup.Sum(r => GetSafeIntValue(r, "Количество товара в доставке")) * productGroup.Key.Price
                              };

            // Очистка DataGridView перед заполнением новыми данными
            dataGridView1.DataSource = null;

            // Создание нового источника данных для DataGridView
            BindingSource bindingSource = new BindingSource();

            string lastCompanyName = null;
            int companyQuantityTotal = 0; // Сумма количества по текущей компании
            double companyPriceTotal = 0.0; // Сумма цены по текущей компании
            List<double> companyPrices = new List<double>(); // Список цен для каждой компании

            // Вывод данных по каждой компании и продукту
            foreach (var group in groupedData)
            {
                if (lastCompanyName != group.Company) // Если это другая компания
                {
                    // Добавление строки для итога по предыдущей компании
                    if (lastCompanyName != null)
                    {
                        double averagePrice = companyPrices.Count > 0 ? companyPrices.Average() : 0.0;
                        var avg = averagePrice * 1000;
                        avg = (int)avg;
                        averagePrice = avg / 1000;

                        bindingSource.Add(new CompanyProductInfo
                        {
                            Компания = $"Итог по {lastCompanyName}",
                            Количество = companyQuantityTotal,
                            Цена = averagePrice,
                            Стоимость = companyQuantityTotal * averagePrice
                        });

                        // Сброс суммарных значений для новой компании
                        companyQuantityTotal = 0;
                        companyPriceTotal = 0.0;
                        companyPrices.Clear();
                    }

                    // Добавление информации о компании, если это первая запись для компании
                    bindingSource.Add(new CompanyProductInfo
                    {
                        Компания = group.Company,
                        Бренд = group.Brand,
                        Товар = group.Product,
                        Количество = group.Quantity,
                        Цена = group.Price,
                        Стоимость = group.TotalCost
                    });

                    // Суммирование значений для текущей компании
                    companyQuantityTotal += group.Quantity;
                    companyPriceTotal += group.Price;
                    companyPrices.Add(group.Price);

                    lastCompanyName = group.Company;
                }
                else
                {
                    // Добавление информации о продукте, если это продолжение записей для той же компании
                    bindingSource.Add(new CompanyProductInfo
                    {
                        Компания = string.Empty,
                        Бренд = group.Brand,
                        Товар = group.Product,
                        Количество = group.Quantity,
                        Цена = group.Price,
                        Стоимость = group.TotalCost
                    });

                    // Суммирование значений для текущей компании
                    companyQuantityTotal += group.Quantity;
                    companyPriceTotal += group.Price;
                    companyPrices.Add(group.Price);
                }
            }

            // Добавление строки для итога по последней компании
            if (lastCompanyName != null)
            {
                double averagePrice = companyPrices.Count > 0 ? companyPrices.Average() : 0.0;
                var avg = averagePrice * 1000;
                avg = (int)avg;
                averagePrice = avg / 1000;

                bindingSource.Add(new CompanyProductInfo
                {
                    Компания = $"Итог по {lastCompanyName}",
                    Количество = companyQuantityTotal,
                    Цена = averagePrice,
                    Стоимость = companyQuantityTotal * averagePrice
                });
            }

            // Добавление строки для итога по всем компаниям
            var grandTotalQuantity = groupedData.Sum(g => g.Quantity);
            var grandTotalPrice = grandTotalQuantity > 0 ? groupedData.Sum(g => g.TotalCost) / grandTotalQuantity : 0.00;

            var grandTotalPrice2 = grandTotalPrice * 1000;
            grandTotalPrice2 = (int)grandTotalPrice2;
            grandTotalPrice = grandTotalPrice2 / 1000;

            bindingSource.Add(new CompanyProductInfo
            {
                Компания = $"Итог по всем компаниям",
                Количество = grandTotalQuantity,
                Цена = grandTotalPrice,
                Стоимость = groupedData.Sum(g => g.TotalCost)
            });

            // Привязка источника данных к DataGridView
            dataGridView1.DataSource = bindingSource;

            // Вывод общего итога
            labelTotalCost.Visible = true;
            labelTotalCost.Text = $"Общая сумма за {year} год: {groupedData.Sum(g => g.TotalCost)} руб";
        }
               
        
        private void but_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            try
            {
                // Указываете путь, где сохранить PDF-файл
                string savePath = @"F:\5 sem\ЭВМ\Отчет.pdf";

                // Создаете экземпляр PdfGenerator
                PdfGenerator pdfGenerator = new PdfGenerator();

                // Вызываете метод GeneratePdf, передавая DataGridView и путь для сохранения PDF
                pdfGenerator.GeneratePdf(dataGridView1, savePath);

                MessageBox.Show("Отчет сохранен успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении отчета: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Вспомогательные методы для безопасного приведения к int и double
        private int GetSafeIntValue(DataRow row, string columnName)
        {
            return row[columnName] != DBNull.Value ? Convert.ToInt32(row[columnName]) : 0;
        }

        private double GetSafeDoubleValue(DataRow row, string columnName)
        {
            return row[columnName] != DBNull.Value ? Convert.ToDouble(row[columnName]) : 0.0;
        }


    }
}

