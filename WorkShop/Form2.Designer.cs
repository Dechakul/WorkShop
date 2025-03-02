namespace WorkShop
{
    partial class Form2
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
            txtStart = new TextBox();
            txtEnd = new TextBox();
            btnShow = new Button();
            dgvResult = new DataGridView();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // txtStart
            // 
            txtStart.Location = new Point(142, 55);
            txtStart.Margin = new Padding(3, 2, 3, 2);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(147, 23);
            txtStart.TabIndex = 2;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(397, 55);
            txtEnd.Margin = new Padding(3, 2, 3, 2);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(157, 23);
            txtEnd.TabIndex = 3;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(605, 46);
            btnShow.Margin = new Padding(3, 2, 3, 2);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(116, 38);
            btnShow.TabIndex = 4;
            btnShow.Text = "แสดงข้อมูล";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // dgvResult
            // 
            dgvResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(30, 118);
            dgvResult.Margin = new Padding(3, 2, 3, 2);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.Size = new Size(712, 330);
            dgvResult.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 61);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 6;
            label3.Text = "ราคาเริ่มต้น";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(339, 61);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 7;
            label1.Text = "ถึงราคา";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 458);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(dgvResult);
            Controls.Add(btnShow);
            Controls.Add(txtEnd);
            Controls.Add(txtStart);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Workshop 3 : ค้นหาสินค้าตามช่วงของราคา";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtStart;
        private TextBox txtEnd;
        private Button btnShow;
        private DataGridView dgvResult;
        private Label label3;
        private Label label1;
    }
}