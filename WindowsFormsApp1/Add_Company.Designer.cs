namespace WindowsFormsApp1
{
    partial class Add_Company
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
            this.text_company_name = new System.Windows.Forms.TextBox();
            this.but_add_company = new System.Windows.Forms.Button();
            this.but_exit = new System.Windows.Forms.Button();
            this.text_company_address = new System.Windows.Forms.TextBox();
            this.text_company_phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(340, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(473, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // text_company_name
            // 
            this.text_company_name.Location = new System.Drawing.Point(30, 59);
            this.text_company_name.Name = "text_company_name";
            this.text_company_name.Size = new System.Drawing.Size(279, 22);
            this.text_company_name.TabIndex = 1;
            // 
            // but_add_company
            // 
            this.but_add_company.Location = new System.Drawing.Point(30, 276);
            this.but_add_company.Name = "but_add_company";
            this.but_add_company.Size = new System.Drawing.Size(140, 57);
            this.but_add_company.TabIndex = 2;
            this.but_add_company.Text = "Добавить";
            this.but_add_company.UseVisualStyleBackColor = true;
            this.but_add_company.Click += new System.EventHandler(this.but_add_company_Click);
            // 
            // but_exit
            // 
            this.but_exit.Location = new System.Drawing.Point(30, 353);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(140, 55);
            this.but_exit.TabIndex = 4;
            this.but_exit.Text = "Назад";
            this.but_exit.UseVisualStyleBackColor = true;
            this.but_exit.Click += new System.EventHandler(this.but_exit_Click);
            // 
            // text_company_address
            // 
            this.text_company_address.Location = new System.Drawing.Point(30, 138);
            this.text_company_address.Name = "text_company_address";
            this.text_company_address.Size = new System.Drawing.Size(279, 22);
            this.text_company_address.TabIndex = 5;
            // 
            // text_company_phone
            // 
            this.text_company_phone.Location = new System.Drawing.Point(30, 212);
            this.text_company_phone.Name = "text_company_phone";
            this.text_company_phone.Size = new System.Drawing.Size(279, 22);
            this.text_company_phone.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите название компании";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введите адрес компании";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Введите номер компании";
            // 
            // Add_Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 430);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_company_phone);
            this.Controls.Add(this.text_company_address);
            this.Controls.Add(this.but_exit);
            this.Controls.Add(this.but_add_company);
            this.Controls.Add(this.text_company_name);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Add_Company";
            this.Text = "Add_company";
            this.Load += new System.EventHandler(this.Add_company_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox text_company_name;
        private System.Windows.Forms.Button but_add_company;
        private System.Windows.Forms.Button but_exit;
        private System.Windows.Forms.TextBox text_company_address;
        private System.Windows.Forms.TextBox text_company_phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}