namespace WindowsFormsApp1
{
    partial class Agree_Delivery
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
            this.but_agreee_oreder = new System.Windows.Forms.Button();
            this.text_delivery = new System.Windows.Forms.TextBox();
            this.but_exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // but_agreee_oreder
            // 
            this.but_agreee_oreder.Location = new System.Drawing.Point(12, 286);
            this.but_agreee_oreder.Name = "but_agreee_oreder";
            this.but_agreee_oreder.Size = new System.Drawing.Size(158, 56);
            this.but_agreee_oreder.TabIndex = 0;
            this.but_agreee_oreder.Text = "Подтвердить";
            this.but_agreee_oreder.UseVisualStyleBackColor = true;
            this.but_agreee_oreder.Click += new System.EventHandler(this.but_agreee_oreder_Click);
            // 
            // text_delivery
            // 
            this.text_delivery.Location = new System.Drawing.Point(12, 66);
            this.text_delivery.Name = "text_delivery";
            this.text_delivery.Size = new System.Drawing.Size(158, 22);
            this.text_delivery.TabIndex = 1;
            // 
            // but_exit
            // 
            this.but_exit.Location = new System.Drawing.Point(12, 358);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(158, 52);
            this.but_exit.TabIndex = 4;
            this.but_exit.Text = "Назад";
            this.but_exit.UseVisualStyleBackColor = true;
            this.but_exit.Click += new System.EventHandler(this.but_exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(188, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(911, 381);
            this.dataGridView1.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 115);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(158, 22);
            this.numericUpDown1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите номер заказа:";
            // 
            // Agree_Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.but_exit);
            this.Controls.Add(this.text_delivery);
            this.Controls.Add(this.but_agreee_oreder);
            this.Name = "Agree_Delivery";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Agree_Delivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_agreee_oreder;
        private System.Windows.Forms.TextBox text_delivery;
        private System.Windows.Forms.Button but_exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}