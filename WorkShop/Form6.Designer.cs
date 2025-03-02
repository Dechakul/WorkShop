namespace WorkShop
{
    partial class Form6
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
            dgvOrder = new DataGridView();
            btnShow = new Button();
            label1 = new Label();
            label2 = new Label();
            cboCountry = new ComboBox();
            cboYear = new ComboBox();
            dgvorderDetail = new DataGridView();
            Label3 = new Label();
            Label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvorderDetail).BeginInit();
            SuspendLayout();
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(12, 104);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(776, 237);
            dgvOrder.TabIndex = 15;
            dgvOrder.CellMouseClick += dgvOrder_CellMouseClick;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(664, 30);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 14;
            btnShow.Text = "แสดงข้อมูล";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 35);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 18;
            label1.Text = "วันที่สั่งซื้อ : เริ่มจากวันที่";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 35);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 19;
            label2.Text = "ปีที่สั่งซื้อ";
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(176, 32);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(212, 23);
            cboCountry.TabIndex = 20;
            // 
            // cboYear
            // 
            cboYear.FormattingEnabled = true;
            cboYear.Location = new Point(448, 32);
            cboYear.Name = "cboYear";
            cboYear.Size = new Size(210, 23);
            cboYear.TabIndex = 21;
            // 
            // dgvorderDetail
            // 
            dgvorderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvorderDetail.Location = new Point(12, 369);
            dgvorderDetail.Name = "dgvorderDetail";
            dgvorderDetail.Size = new Size(776, 215);
            dgvorderDetail.TabIndex = 22;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(12, 86);
            Label3.Name = "Label3";
            Label3.Size = new Size(67, 15);
            Label3.TabIndex = 23;
            Label3.Text = "ข้อมูลใบสั่งซื้อ";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(12, 351);
            Label4.Name = "Label4";
            Label4.Size = new Size(90, 15);
            Label4.TabIndex = 24;
            Label4.Text = "ข้อมูลรายการสั่งซื้อ";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 596);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(dgvorderDetail);
            Controls.Add(cboYear);
            Controls.Add(cboCountry);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvOrder);
            Controls.Add(btnShow);
            Name = "Form6";
            Text = "FrmOrder_Counrty_Year";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvorderDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvOrder;
        private Button btnShow;
        private Label label1;
        private Label label2;
        private ComboBox cboCountry;
        private ComboBox cboYear;
        private DataGridView dgvorderDetail;
        private Label Label3;
        private Label Label4;
    }
}