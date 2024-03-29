namespace WindowsFormsApp1
{
    partial class Data
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.but_brand = new System.Windows.Forms.Button();
            this.but_product = new System.Windows.Forms.Button();
            this.but_company = new System.Windows.Forms.Button();
            this.but_order = new System.Windows.Forms.Button();
            this.but_data = new System.Windows.Forms.Button();
            this.otchetComboBox = new System.Windows.Forms.ComboBox();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.but_exit = new System.Windows.Forms.Button();
            this.but_delivery = new System.Windows.Forms.Button();
            this.but_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(226, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1048, 589);
            this.dataGridView1.TabIndex = 0;
            // 
            // but_brand
            // 
            this.but_brand.Location = new System.Drawing.Point(15, 36);
            this.but_brand.Name = "but_brand";
            this.but_brand.Size = new System.Drawing.Size(169, 53);
            this.but_brand.TabIndex = 1;
            this.but_brand.Text = "Brand";
            this.but_brand.UseVisualStyleBackColor = true;
            this.but_brand.Click += new System.EventHandler(this.but_brand_Click);
            // 
            // but_product
            // 
            this.but_product.Location = new System.Drawing.Point(15, 115);
            this.but_product.Name = "but_product";
            this.but_product.Size = new System.Drawing.Size(169, 53);
            this.but_product.TabIndex = 2;
            this.but_product.Text = "Product";
            this.but_product.UseVisualStyleBackColor = true;
            this.but_product.Click += new System.EventHandler(this.but_product_Click);
            // 
            // but_company
            // 
            this.but_company.Location = new System.Drawing.Point(15, 190);
            this.but_company.Name = "but_company";
            this.but_company.Size = new System.Drawing.Size(169, 53);
            this.but_company.TabIndex = 3;
            this.but_company.Text = "Company";
            this.but_company.UseVisualStyleBackColor = true;
            this.but_company.Click += new System.EventHandler(this.but_company_Click);
            // 
            // but_order
            // 
            this.but_order.Location = new System.Drawing.Point(15, 260);
            this.but_order.Name = "but_order";
            this.but_order.Size = new System.Drawing.Size(169, 53);
            this.but_order.TabIndex = 4;
            this.but_order.Text = "Order";
            this.but_order.UseVisualStyleBackColor = true;
            this.but_order.Click += new System.EventHandler(this.but_order_Click);
            // 
            // but_data
            // 
            this.but_data.Location = new System.Drawing.Point(15, 401);
            this.but_data.Name = "but_data";
            this.but_data.Size = new System.Drawing.Size(169, 53);
            this.but_data.TabIndex = 5;
            this.but_data.Text = "Data";
            this.but_data.UseVisualStyleBackColor = true;
            this.but_data.Click += new System.EventHandler(this.but_data_Click);
            // 
            // otchetComboBox
            // 
            this.otchetComboBox.FormattingEnabled = true;
            this.otchetComboBox.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023"});
            this.otchetComboBox.Location = new System.Drawing.Point(15, 65);
            this.otchetComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.otchetComboBox.Name = "otchetComboBox";
            this.otchetComboBox.Size = new System.Drawing.Size(169, 24);
            this.otchetComboBox.TabIndex = 36;
            this.otchetComboBox.SelectedIndexChanged += new System.EventHandler(this.otchetComboBox_SelectedIndexChanged);
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalCost.Location = new System.Drawing.Point(221, 634);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(80, 29);
            this.labelTotalCost.TabIndex = 37;
            this.labelTotalCost.Text = "Итог: ";
            this.labelTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTotalCost.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "Отчет за год:";
            // 
            // but_exit
            // 
            this.but_exit.Location = new System.Drawing.Point(1105, 625);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(169, 48);
            this.but_exit.TabIndex = 39;
            this.but_exit.Text = "Назад";
            this.but_exit.UseVisualStyleBackColor = true;
            this.but_exit.Click += new System.EventHandler(this.but_exit_Click);
            // 
            // but_delivery
            // 
            this.but_delivery.Location = new System.Drawing.Point(15, 332);
            this.but_delivery.Name = "but_delivery";
            this.but_delivery.Size = new System.Drawing.Size(169, 53);
            this.but_delivery.TabIndex = 40;
            this.but_delivery.Text = "Delivery";
            this.but_delivery.UseVisualStyleBackColor = true;
            this.but_delivery.Click += new System.EventHandler(this.but_delivery_Click);
            // 
            // but_save
            // 
            this.but_save.Location = new System.Drawing.Point(15, 103);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(169, 48);
            this.but_save.TabIndex = 41;
            this.but_save.Text = "Скачать";
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Visible = false;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_delivery);
            this.groupBox1.Controls.Add(this.but_order);
            this.groupBox1.Controls.Add(this.but_company);
            this.groupBox1.Controls.Add(this.but_product);
            this.groupBox1.Controls.Add(this.but_brand);
            this.groupBox1.Controls.Add(this.but_data);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 479);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Таблицы";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.but_save);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.otchetComboBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 501);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 174);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 681);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.but_exit);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Data";
            this.Text = "Data";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button but_brand;
        private System.Windows.Forms.Button but_product;
        private System.Windows.Forms.Button but_company;
        private System.Windows.Forms.Button but_order;
        private System.Windows.Forms.Button but_data;
        private System.Windows.Forms.ComboBox otchetComboBox;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_exit;
        private System.Windows.Forms.Button but_delivery;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}