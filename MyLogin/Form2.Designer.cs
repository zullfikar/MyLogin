namespace MyLogin
{
    partial class MasterProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtItem1 = new System.Windows.Forms.TextBox();
            this.txtDesign1 = new System.Windows.Forms.TextBox();
            this.txtProduk = new System.Windows.Forms.TextBox();
            this.txtItem2 = new System.Windows.Forms.TextBox();
            this.txtDesign2 = new System.Windows.Forms.TextBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.dtExpiredDate = new System.Windows.Forms.DateTimePicker();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Master Produk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Design";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Design";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Item Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Expired Date";
            // 
            // txtItem1
            // 
            this.txtItem1.Location = new System.Drawing.Point(166, 70);
            this.txtItem1.Name = "txtItem1";
            this.txtItem1.Size = new System.Drawing.Size(91, 20);
            this.txtItem1.TabIndex = 10;
            // 
            // txtDesign1
            // 
            this.txtDesign1.Location = new System.Drawing.Point(166, 107);
            this.txtDesign1.Name = "txtDesign1";
            this.txtDesign1.Size = new System.Drawing.Size(91, 20);
            this.txtDesign1.TabIndex = 11;
            // 
            // txtProduk
            // 
            this.txtProduk.Location = new System.Drawing.Point(137, 163);
            this.txtProduk.Name = "txtProduk";
            this.txtProduk.Size = new System.Drawing.Size(168, 20);
            this.txtProduk.TabIndex = 12;
            // 
            // txtItem2
            // 
            this.txtItem2.Location = new System.Drawing.Point(137, 201);
            this.txtItem2.Name = "txtItem2";
            this.txtItem2.Size = new System.Drawing.Size(168, 20);
            this.txtItem2.TabIndex = 13;
            // 
            // txtDesign2
            // 
            this.txtDesign2.Location = new System.Drawing.Point(137, 243);
            this.txtDesign2.Name = "txtDesign2";
            this.txtDesign2.Size = new System.Drawing.Size(168, 20);
            this.txtDesign2.TabIndex = 14;
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Merah ",
            "Biru",
            "Hijau ",
            "Hitam"});
            this.cbColor.Location = new System.Drawing.Point(137, 285);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(121, 21);
            this.cbColor.TabIndex = 15;
            // 
            // dtExpiredDate
            // 
            this.dtExpiredDate.Location = new System.Drawing.Point(137, 326);
            this.dtExpiredDate.Name = "dtExpiredDate";
            this.dtExpiredDate.Size = new System.Drawing.Size(200, 20);
            this.dtExpiredDate.TabIndex = 16;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(343, 70);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 17;
            this.btnCari.Text = "Search";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(219, 372);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(326, 372);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(81, 418);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 121);
            this.dataGridView1.TabIndex = 21;
            // 
            // bttnsave
            // 
            this.bttnsave.Location = new System.Drawing.Point(114, 372);
            this.bttnsave.Name = "bttnsave";
            this.bttnsave.Size = new System.Drawing.Size(75, 23);
            this.bttnsave.TabIndex = 22;
            this.bttnsave.Text = "Save";
            this.bttnsave.UseVisualStyleBackColor = true;
            this.bttnsave.Click += new System.EventHandler(this.bttnsave_Click);
            // 
            // MasterProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 551);
            this.Controls.Add(this.bttnsave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.dtExpiredDate);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.txtDesign2);
            this.Controls.Add(this.txtItem2);
            this.Controls.Add(this.txtProduk);
            this.Controls.Add(this.txtDesign1);
            this.Controls.Add(this.txtItem1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MasterProduct";
            this.Text = "Master Produk";
            this.Load += new System.EventHandler(this.MasterProduct_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtItem1;
        private System.Windows.Forms.TextBox txtDesign1;
        private System.Windows.Forms.TextBox txtProduk;
        private System.Windows.Forms.TextBox txtItem2;
        private System.Windows.Forms.TextBox txtDesign2;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.DateTimePicker dtExpiredDate;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttnsave;
    }
}