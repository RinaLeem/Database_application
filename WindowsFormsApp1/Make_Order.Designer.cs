namespace WindowsFormsApp1
{
    partial class Form2
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.but_make_order = new System.Windows.Forms.Button();
            this.text_product_name = new System.Windows.Forms.TextBox();
            this.but_exit = new System.Windows.Forms.Button();
            this.data_product = new System.Windows.Forms.DataGridView();
            this.text_company_name = new System.Windows.Forms.TextBox();
            this.data_company = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_company)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(23, 252);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 4;
            // 
            // but_make_order
            // 
            this.but_make_order.Location = new System.Drawing.Point(23, 306);
            this.but_make_order.Name = "but_make_order";
            this.but_make_order.Size = new System.Drawing.Size(145, 55);
            this.but_make_order.TabIndex = 5;
            this.but_make_order.Text = "Подтвердить заказ";
            this.but_make_order.UseVisualStyleBackColor = true;
            this.but_make_order.Click += new System.EventHandler(this.but_make_order_Click);
            // 
            // text_product_name
            // 
            this.text_product_name.Location = new System.Drawing.Point(23, 192);
            this.text_product_name.Name = "text_product_name";
            this.text_product_name.Size = new System.Drawing.Size(174, 22);
            this.text_product_name.TabIndex = 1;
            // 
            // but_exit
            // 
            this.but_exit.Location = new System.Drawing.Point(23, 383);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(145, 57);
            this.but_exit.TabIndex = 6;
            this.but_exit.Text = "Назад";
            this.but_exit.UseVisualStyleBackColor = true;
            this.but_exit.Click += new System.EventHandler(this.but_exit_Click);
            // 
            // data_product
            // 
            this.data_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_product.Location = new System.Drawing.Point(473, 36);
            this.data_product.Name = "data_product";
            this.data_product.RowHeadersWidth = 51;
            this.data_product.RowTemplate.Height = 24;
            this.data_product.Size = new System.Drawing.Size(486, 404);
            this.data_product.TabIndex = 7;
            // 
            // text_company_name
            // 
            this.text_company_name.Location = new System.Drawing.Point(23, 119);
            this.text_company_name.Name = "text_company_name";
            this.text_company_name.Size = new System.Drawing.Size(174, 22);
            this.text_company_name.TabIndex = 8;
            // 
            // data_company
            // 
            this.data_company.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_company.Location = new System.Drawing.Point(236, 36);
            this.data_company.Name = "data_company";
            this.data_company.RowHeadersWidth = 51;
            this.data_company.RowTemplate.Height = 24;
            this.data_company.Size = new System.Drawing.Size(212, 404);
            this.data_company.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введите название компании:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Введите название продукта:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 475);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_company);
            this.Controls.Add(this.text_company_name);
            this.Controls.Add(this.data_product);
            this.Controls.Add(this.but_exit);
            this.Controls.Add(this.but_make_order);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.text_product_name);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_company)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button but_make_order;
        private System.Windows.Forms.TextBox text_product_name;
        private System.Windows.Forms.Button but_exit;
        private System.Windows.Forms.DataGridView data_product;
        private System.Windows.Forms.TextBox text_company_name;
        private System.Windows.Forms.DataGridView data_company;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}