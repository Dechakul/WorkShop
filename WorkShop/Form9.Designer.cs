namespace WorkShop
{
    partial class Form9
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
            DgvOrder = new DataGridView();
            label1 = new Label();
            dgvDetail = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            SuspendLayout();
            // 
            // DgvOrder
            // 
            DgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvOrder.Location = new Point(12, 28);
            DgvOrder.Name = "DgvOrder";
            DgvOrder.Size = new Size(776, 234);
            DgvOrder.TabIndex = 0;
            DgvOrder.CellMouseClick += DgvOrder_CellMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "ใบสั่งซื้อ";
            // 
            // dgvDetail
            // 
            dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetail.Location = new Point(12, 288);
            dgvDetail.Name = "dgvDetail";
            dgvDetail.Size = new Size(776, 150);
            dgvDetail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 270);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "รายการสั่งซื้อ";
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(dgvDetail);
            Controls.Add(label1);
            Controls.Add(DgvOrder);
            Name = "Form9";
            Text = "ข้อมูลใบสั่งซื้อ";
            Load += Form9_Load;
            ((System.ComponentModel.ISupportInitialize)DgvOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvOrder;
        private Label label1;
        private DataGridView dgvDetail;
        private Label label2;
    }
}