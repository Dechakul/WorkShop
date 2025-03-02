namespace WorkShop
{
    partial class FrmAddProduct
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
            label1 = new Label();
            label2 = new Label();
            txtPname = new TextBox();
            txtPrice = new TextBox();
            btnInsert = new Button();
            btnClear = new Button();
            dgvProduct = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 32);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "ชื่อสินค้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 33);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "ราคา";
            // 
            // txtPname
            // 
            txtPname.Location = new Point(103, 29);
            txtPname.Name = "txtPname";
            txtPname.Size = new Size(199, 23);
            txtPname.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(372, 30);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(160, 23);
            txtPrice.TabIndex = 3;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(557, 22);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(89, 35);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "เพิ่มข้อมูล";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(670, 23);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(83, 34);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(12, 76);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.Size = new Size(776, 362);
            dgvProduct.TabIndex = 6;
            // 
            // FrmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProduct);
            Controls.Add(btnClear);
            Controls.Add(btnInsert);
            Controls.Add(txtPrice);
            Controls.Add(txtPname);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAddProduct";
            Text = "FrmAddProduct";
            Load += FrmAddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPname;
        private TextBox txtPrice;
        private Button btnInsert;
        private Button btnClear;
        private DataGridView dgvProduct;
    }
}