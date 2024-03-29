namespace WindowsFormsApp1
{
    partial class Add_Product
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
            this.text_product_brand = new System.Windows.Forms.TextBox();
            this.text_product_name = new System.Windows.Forms.TextBox();
            this.but_add_product = new System.Windows.Forms.Button();
            this.but_exit = new System.Windows.Forms.Button();
            this.text_product_count = new System.Windows.Forms.TextBox();
            this.text_product_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(256, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(616, 414);
            this.dataGridView1.TabIndex = 0;
            // 
            // text_product_brand
            // 
            this.text_product_brand.Location = new System.Drawing.Point(12, 54);
            this.text_product_brand.Name = "text_product_brand";
            this.text_product_brand.Size = new System.Drawing.Size(217, 22);
            this.text_product_brand.TabIndex = 1;
            // 
            // text_product_name
            // 
            this.text_product_name.Location = new System.Drawing.Point(12, 116);
            this.text_product_name.Name = "text_product_name";
            this.text_product_name.Size = new System.Drawing.Size(217, 22);
            this.text_product_name.TabIndex = 2;
            // 
            // but_add_product
            // 
            this.but_add_product.Location = new System.Drawing.Point(12, 305);
            this.but_add_product.Name = "but_add_product";
            this.but_add_product.Size = new System.Drawing.Size(217, 55);
            this.but_add_product.TabIndex = 3;
            this.but_add_product.Text = "Добавить";
            this.but_add_product.UseVisualStyleBackColor = true;
            this.but_add_product.Click += new System.EventHandler(this.but_add_product_Click);
            // 
            // but_exit
            // 
            this.but_exit.Location = new System.Drawing.Point(12, 384);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(217, 52);
            this.but_exit.TabIndex = 4;
            this.but_exit.Text = "Назад";
            this.but_exit.UseVisualStyleBackColor = true;
            this.but_exit.Click += new System.EventHandler(this.but_exit_Click);
            // 
            // text_product_count
            // 
            this.text_product_count.Location = new System.Drawing.Point(12, 191);
            this.text_product_count.Name = "text_product_count";
            this.text_product_count.Size = new System.Drawing.Size(217, 22);
            this.text_product_count.TabIndex = 5;
            // 
            // text_product_price
            // 
            this.text_product_price.Location = new System.Drawing.Point(12, 258);
            this.text_product_price.Name = "text_product_price";
            this.text_product_price.Size = new System.Drawing.Size(217, 22);
            this.text_product_price.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите бренд";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введите название продукта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Введите кол-во";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Введите цену";
            // 
            // Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_product_price);
            this.Controls.Add(this.text_product_count);
            this.Controls.Add(this.but_exit);
            this.Controls.Add(this.but_add_product);
            this.Controls.Add(this.text_product_name);
            this.Controls.Add(this.text_product_brand);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Add_Product";
            this.Text = "Add_Product";
            this.Load += new System.EventHandler(this.Add_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox text_product_brand;
        private System.Windows.Forms.TextBox text_product_name;
        private System.Windows.Forms.Button but_add_product;
        private System.Windows.Forms.Button but_exit;
        private System.Windows.Forms.TextBox text_product_count;
        private System.Windows.Forms.TextBox text_product_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}