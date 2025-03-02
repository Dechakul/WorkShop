namespace WorkShop
{
    partial class Form10
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
            label2 = new Label();
            dgvDetail = new DataGridView();
            label1 = new Label();
            DgvOrder = new DataGridView();
            label3 = new Label();
            cboEmployee = new ComboBox();
            label4 = new Label();
            cboCountry = new ComboBox();
            btnShow = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvOrder).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 342);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 7;
            label2.Text = "รายการสั่งซื้อ";
            // 
            // dgvDetail
            // 
            dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetail.Location = new Point(12, 360);
            dgvDetail.Name = "dgvDetail";
            dgvDetail.Size = new Size(776, 150);
            dgvDetail.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 5;
            label1.Text = "ใบสั่งซื้อ";
            // 
            // DgvOrder
            // 
            DgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvOrder.Location = new Point(12, 100);
            DgvOrder.Name = "DgvOrder";
            DgvOrder.Size = new Size(776, 234);
            DgvOrder.TabIndex = 4;
            DgvOrder.CellMouseClick += DgvOrder_CellMouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 32);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 8;
            label3.Text = "เลือกพนักงานขาย :";
            // 
            // cboEmployee
            // 
            cboEmployee.FormattingEnabled = true;
            cboEmployee.Location = new Point(142, 29);
            cboEmployee.Name = "cboEmployee";
            cboEmployee.Size = new Size(202, 23);
            cboEmployee.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(367, 32);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 10;
            label4.Text = "เลือกประเทศจัดส่ง :";
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(470, 29);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(185, 23);
            cboCountry.TabIndex = 11;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(678, 19);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 40);
            btnShow.TabIndex = 12;
            btnShow.Text = "แสดงข้อมูล";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 522);
            Controls.Add(btnShow);
            Controls.Add(cboCountry);
            Controls.Add(label4);
            Controls.Add(cboEmployee);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvDetail);
            Controls.Add(label1);
            Controls.Add(DgvOrder);
            Name = "Form10";
            Text = "ค้นหาข้อมูลการขายของพนักงาน";
            Load += Form10_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dgvDetail;
        private Label label1;
        private DataGridView DgvOrder;
        private Label label3;
        private ComboBox cboEmployee;
        private Label label4;
        private ComboBox cboCountry;
        private Button btnShow;
    }
}