namespace WindowsFormsApp1
{
    partial class Add_Brand
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
            this.text_brand_name = new System.Windows.Forms.TextBox();
            this.but_add_brand = new System.Windows.Forms.Button();
            this.but_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Size = new System.Drawing.Size(232, 399);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // text_brand_name
            // 
            this.text_brand_name.Location = new System.Drawing.Point(26, 58);
            this.text_brand_name.Name = "text_brand_name";
            this.text_brand_name.Size = new System.Drawing.Size(185, 22);
            this.text_brand_name.TabIndex = 1;
            // 
            // but_add_brand
            // 
            this.but_add_brand.Location = new System.Drawing.Point(26, 290);
            this.but_add_brand.Name = "but_add_brand";
            this.but_add_brand.Size = new System.Drawing.Size(140, 51);
            this.but_add_brand.TabIndex = 2;
            this.but_add_brand.Text = "Добавить";
            this.but_add_brand.UseVisualStyleBackColor = true;
            this.but_add_brand.Click += new System.EventHandler(this.but_add_brand_Click);
            // 
            // but_exit
            // 
            this.but_exit.Location = new System.Drawing.Point(26, 371);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(140, 52);
            this.but_exit.TabIndex = 3;
            this.but_exit.Text = "Назад";
            this.but_exit.UseVisualStyleBackColor = true;
            this.but_exit.Click += new System.EventHandler(this.but_exit_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите название бренда:";
            // 
            // Add_Brand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_exit);
            this.Controls.Add(this.but_add_brand);
            this.Controls.Add(this.text_brand_name);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Add_Brand";
            this.Text = "Add_Brand";
            this.Load += new System.EventHandler(this.Add_Brand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox text_brand_name;
        private System.Windows.Forms.Button but_add_brand;
        private System.Windows.Forms.Button but_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}