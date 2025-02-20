namespace WorkShop
{
    partial class Form5
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
            label1 = new Label();
            dgvResult = new DataGridView();
            btnShow = new Button();
            txtEnd = new TextBox();
            txtStart = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 28);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 11;
            label2.Text = "ถึง";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 29);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 10;
            label1.Text = "ราคาต่อหน่อย : จาก";
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(10, 70);
            dgvResult.Margin = new Padding(3, 2, 3, 2);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.Size = new Size(772, 352);
            dgvResult.TabIndex = 9;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(578, 13);
            btnShow.Margin = new Padding(3, 2, 3, 2);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(138, 44);
            btnShow.TabIndex = 8;
            btnShow.Text = "แสดงข้อมูล";
            btnShow.UseVisualStyleBackColor = true;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(395, 26);
            txtEnd.Margin = new Padding(3, 2, 3, 2);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(142, 23);
            txtEnd.TabIndex = 7;
            // 
            // txtStart
            // 
            txtStart.Location = new Point(216, 25);
            txtStart.Margin = new Padding(3, 2, 3, 2);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(129, 23);
            txtStart.TabIndex = 6;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 433);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvResult);
            Controls.Add(btnShow);
            Controls.Add(txtEnd);
            Controls.Add(txtStart);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DataGridView dgvResult;
        private Button btnShow;
        private TextBox txtEnd;
        private TextBox txtStart;
    }
}