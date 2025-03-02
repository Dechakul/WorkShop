namespace WorkShop
{
    partial class frmManageProduct
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
            txtDes = new TextBox();
            txtPid = new TextBox();
            txtPname = new TextBox();
            txtPrice = new TextBox();
            groupBox1 = new GroupBox();
            cboCid = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnDelete = new Button();
            BtnUpdate = new Button();
            BtnAdd = new Button();
            btnClear = new Button();
            groupBox2 = new GroupBox();
            dgvResult = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // txtDes
            // 
            txtDes.Location = new Point(119, 125);
            txtDes.Multiline = true;
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(228, 71);
            txtDes.TabIndex = 0;
            // 
            // txtPid
            // 
            txtPid.Location = new Point(119, 36);
            txtPid.Name = "txtPid";
            txtPid.Size = new Size(95, 23);
            txtPid.TabIndex = 1;
            // 
            // txtPname
            // 
            txtPname.Location = new Point(119, 80);
            txtPname.Name = "txtPname";
            txtPname.Size = new Size(228, 23);
            txtPname.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(119, 218);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 23);
            txtPrice.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboCid);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BtnDelete);
            groupBox1.Controls.Add(BtnUpdate);
            groupBox1.Controls.Add(BtnAdd);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(txtPid);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtDes);
            groupBox1.Controls.Add(txtPname);
            groupBox1.Location = new Point(18, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(371, 390);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // cboCid
            // 
            cboCid.FormattingEnabled = true;
            cboCid.Location = new Point(119, 268);
            cboCid.Name = "cboCid";
            cboCid.Size = new Size(192, 23);
            cboCid.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 271);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 13;
            label5.Text = "ประเถท :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 221);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 12;
            label4.Text = "ราคา :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 128);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 11;
            label3.Text = "รายละเอียด :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 83);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 10;
            label2.Text = "ชื่อสินค้า :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 39);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 9;
            label1.Text = "รหัสสินค้า :";
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(285, 326);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 39);
            BtnDelete.TabIndex = 8;
            BtnDelete.Text = "ลบ";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click_1;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(194, 326);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(75, 39);
            BtnUpdate.TabIndex = 7;
            BtnUpdate.Text = "แก้ไข";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(103, 326);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(75, 39);
            BtnAdd.TabIndex = 6;
            BtnAdd.Text = "เพิ่ม";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 326);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 39);
            btnClear.TabIndex = 5;
            btnClear.Text = "เคลียร์";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvResult);
            groupBox2.Location = new Point(395, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(855, 390);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // dgvResult
            // 
            dgvResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(11, 22);
            dgvResult.Name = "dgvResult";
            dgvResult.Size = new Size(838, 362);
            dgvResult.TabIndex = 0;
            dgvResult.CellContentClick += dgvResult_CellContentClick;
            // 
            // frmManageProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 414);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmManageProduct";
            Text = "จัดการข้อมูลสินค้า";
            Load += frmManageProduct_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtDes;
        private TextBox txtPid;
        private TextBox txtPname;
        private TextBox txtPrice;
        private GroupBox groupBox1;
        private Button BtnAdd;
        private Button btnClear;
        private GroupBox groupBox2;
        private DataGridView dgvResult;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnDelete;
        private Button BtnUpdate;
        private ComboBox cboCid;
    }
}