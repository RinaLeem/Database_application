namespace WindowsFormsApp1
{
    partial class Disagree_Delivery
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
            this.but_exit = new System.Windows.Forms.Button();
            this.text_delivery = new System.Windows.Forms.TextBox();
            this.but_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(195, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(911, 381);
            this.dataGridView1.TabIndex = 10;
            // 
            // but_exit
            // 
            this.but_exit.Location = new System.Drawing.Point(16, 360);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(157, 52);
            this.but_exit.TabIndex = 9;
            this.but_exit.Text = "Назад";
            this.but_exit.UseVisualStyleBackColor = true;
            this.but_exit.Click += new System.EventHandler(this.but_exit_Click);
            // 
            // text_delivery
            // 
            this.text_delivery.Location = new System.Drawing.Point(16, 67);
            this.text_delivery.Name = "text_delivery";
            this.text_delivery.Size = new System.Drawing.Size(157, 22);
            this.text_delivery.TabIndex = 8;
            // 
            // but_delete
            // 
            this.but_delete.Location = new System.Drawing.Point(16, 288);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(157, 56);
            this.but_delete.TabIndex = 7;
            this.but_delete.Text = "Отменить заказ";
            this.but_delete.UseVisualStyleBackColor = true;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите номер заказа:";
            // 
            // Disagree_Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.but_exit);
            this.Controls.Add(this.text_delivery);
            this.Controls.Add(this.but_delete);
            this.Name = "Disagree_Delivery";
            this.Text = "Disagree_Delivery";
            this.Load += new System.EventHandler(this.Disagree_Delivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button but_exit;
        private System.Windows.Forms.TextBox text_delivery;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Label label1;
    }
}