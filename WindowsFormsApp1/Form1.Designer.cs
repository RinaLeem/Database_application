namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.but_make_order = new System.Windows.Forms.Button();
            this.but_add_company = new System.Windows.Forms.Button();
            this.but_add_product = new System.Windows.Forms.Button();
            this.but_add_brand = new System.Windows.Forms.Button();
            this.but_agree = new System.Windows.Forms.Button();
            this.client = new System.Windows.Forms.GroupBox();
            this.admin = new System.Windows.Forms.GroupBox();
            this.group_seller = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_data = new System.Windows.Forms.Button();
            this.but_disagree = new System.Windows.Forms.Button();
            this.client.SuspendLayout();
            this.admin.SuspendLayout();
            this.group_seller.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_make_order
            // 
            this.but_make_order.Location = new System.Drawing.Point(29, 52);
            this.but_make_order.Name = "but_make_order";
            this.but_make_order.Size = new System.Drawing.Size(157, 80);
            this.but_make_order.TabIndex = 0;
            this.but_make_order.Text = "Сделать заказ";
            this.but_make_order.UseVisualStyleBackColor = true;
            this.but_make_order.Click += new System.EventHandler(this.but_make_order_Click);
            // 
            // but_add_company
            // 
            this.but_add_company.Location = new System.Drawing.Point(27, 52);
            this.but_add_company.Name = "but_add_company";
            this.but_add_company.Size = new System.Drawing.Size(157, 80);
            this.but_add_company.TabIndex = 1;
            this.but_add_company.Text = "Добавить компанию";
            this.but_add_company.UseVisualStyleBackColor = true;
            this.but_add_company.Click += new System.EventHandler(this.but_add_company_Click);
            // 
            // but_add_product
            // 
            this.but_add_product.Location = new System.Drawing.Point(27, 160);
            this.but_add_product.Name = "but_add_product";
            this.but_add_product.Size = new System.Drawing.Size(157, 80);
            this.but_add_product.TabIndex = 2;
            this.but_add_product.Text = "Добавить товар";
            this.but_add_product.UseVisualStyleBackColor = true;
            this.but_add_product.Click += new System.EventHandler(this.but_add_product_Click);
            // 
            // but_add_brand
            // 
            this.but_add_brand.Location = new System.Drawing.Point(27, 265);
            this.but_add_brand.Name = "but_add_brand";
            this.but_add_brand.Size = new System.Drawing.Size(157, 80);
            this.but_add_brand.TabIndex = 3;
            this.but_add_brand.Text = "Добавить бренд";
            this.but_add_brand.UseVisualStyleBackColor = true;
            this.but_add_brand.Click += new System.EventHandler(this.but_add_brand_Click);
            // 
            // but_agree
            // 
            this.but_agree.Location = new System.Drawing.Point(29, 52);
            this.but_agree.Name = "but_agree";
            this.but_agree.Size = new System.Drawing.Size(157, 80);
            this.but_agree.TabIndex = 4;
            this.but_agree.Text = "Подтвердить доставку";
            this.but_agree.UseVisualStyleBackColor = true;
            this.but_agree.Click += new System.EventHandler(this.but_agree_Click);
            // 
            // client
            // 
            this.client.Controls.Add(this.but_make_order);
            this.client.Location = new System.Drawing.Point(36, 43);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(213, 179);
            this.client.TabIndex = 5;
            this.client.TabStop = false;
            this.client.Text = "Покупатель";
            // 
            // admin
            // 
            this.admin.Controls.Add(this.but_add_company);
            this.admin.Controls.Add(this.but_add_product);
            this.admin.Controls.Add(this.but_add_brand);
            this.admin.Location = new System.Drawing.Point(532, 43);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(219, 371);
            this.admin.TabIndex = 6;
            this.admin.TabStop = false;
            this.admin.Text = "Администратор";
            // 
            // group_seller
            // 
            this.group_seller.Controls.Add(this.but_disagree);
            this.group_seller.Controls.Add(this.but_agree);
            this.group_seller.Location = new System.Drawing.Point(286, 43);
            this.group_seller.Name = "group_seller";
            this.group_seller.Size = new System.Drawing.Size(214, 271);
            this.group_seller.TabIndex = 7;
            this.group_seller.TabStop = false;
            this.group_seller.Text = "Продавец";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_data);
            this.groupBox1.Location = new System.Drawing.Point(34, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 173);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Бухгалтер";
            // 
            // but_data
            // 
            this.but_data.Location = new System.Drawing.Point(31, 49);
            this.but_data.Name = "but_data";
            this.but_data.Size = new System.Drawing.Size(157, 76);
            this.but_data.TabIndex = 0;
            this.but_data.Text = "Отчет";
            this.but_data.UseVisualStyleBackColor = true;
            this.but_data.Click += new System.EventHandler(this.but_data_Click);
            // 
            // but_disagree
            // 
            this.but_disagree.Location = new System.Drawing.Point(29, 160);
            this.but_disagree.Name = "but_disagree";
            this.but_disagree.Size = new System.Drawing.Size(157, 80);
            this.but_disagree.TabIndex = 5;
            this.but_disagree.Text = "Отменить доставку";
            this.but_disagree.UseVisualStyleBackColor = true;
            this.but_disagree.Click += new System.EventHandler(this.but_disagree_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 444);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.group_seller);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.client);
            this.Name = "Form1";
            this.Text = "Косметическая продукция";
            this.client.ResumeLayout(false);
            this.admin.ResumeLayout(false);
            this.group_seller.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_make_order;
        private System.Windows.Forms.Button but_add_company;
        private System.Windows.Forms.Button but_add_product;
        private System.Windows.Forms.Button but_add_brand;
        private System.Windows.Forms.Button but_agree;
        private System.Windows.Forms.GroupBox client;
        private System.Windows.Forms.GroupBox admin;
        private System.Windows.Forms.GroupBox group_seller;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_data;
        private System.Windows.Forms.Button but_disagree;
    }
}

