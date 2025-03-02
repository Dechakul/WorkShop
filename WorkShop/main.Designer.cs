namespace WorkShop
{
    partial class main
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
            menuStrip1 = new MenuStrip();
            workShopToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            manageProductToolStripMenuItem = new ToolStripMenuItem();
            workShopViewToolStripMenuItem = new ToolStripMenuItem();
            fromOrderCountryYearToolStripMenuItem = new ToolStripMenuItem();
            workToolStripMenuItem = new ToolStripMenuItem();
            insertProductToolStripMenuItem = new ToolStripMenuItem();
            formAddUserToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { workShopToolStripMenuItem, manageProductToolStripMenuItem, workShopViewToolStripMenuItem, workToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // workShopToolStripMenuItem
            // 
            workShopToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6, toolStripMenuItem7 });
            workShopToolStripMenuItem.Name = "workShopToolStripMenuItem";
            workShopToolStripMenuItem.Size = new Size(74, 20);
            workShopToolStripMenuItem.Text = "WorkShop";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(218, 22);
            toolStripMenuItem2.Text = "1 - 2";
            toolStripMenuItem2.Click += toolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(218, 22);
            toolStripMenuItem3.Text = "3";
            toolStripMenuItem3.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(218, 22);
            toolStripMenuItem4.Text = "4 - 5";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(218, 22);
            toolStripMenuItem5.Text = "6";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(218, 22);
            toolStripMenuItem6.Text = "ข้อมูลใบสั่งซื้อ";
            toolStripMenuItem6.Click += toolStripMenuItem6_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(218, 22);
            toolStripMenuItem7.Text = "ค้นหาข้อมูลการขายของพนักงาน";
            toolStripMenuItem7.Click += toolStripMenuItem7_Click;
            // 
            // manageProductToolStripMenuItem
            // 
            manageProductToolStripMenuItem.Name = "manageProductToolStripMenuItem";
            manageProductToolStripMenuItem.Size = new Size(104, 20);
            manageProductToolStripMenuItem.Text = "ManageProduct";
            manageProductToolStripMenuItem.Click += manageProductToolStripMenuItem_Click;
            // 
            // workShopViewToolStripMenuItem
            // 
            workShopViewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fromOrderCountryYearToolStripMenuItem });
            workShopViewToolStripMenuItem.Name = "workShopViewToolStripMenuItem";
            workShopViewToolStripMenuItem.Size = new Size(99, 20);
            workShopViewToolStripMenuItem.Text = "WorkShopView";
            // 
            // fromOrderCountryYearToolStripMenuItem
            // 
            fromOrderCountryYearToolStripMenuItem.Name = "fromOrderCountryYearToolStripMenuItem";
            fromOrderCountryYearToolStripMenuItem.Size = new Size(212, 22);
            fromOrderCountryYearToolStripMenuItem.Text = "From_Order_Country-Year";
            fromOrderCountryYearToolStripMenuItem.Click += fromOrderCountryYearToolStripMenuItem_Click;
            // 
            // workToolStripMenuItem
            // 
            workToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { insertProductToolStripMenuItem, formAddUserToolStripMenuItem });
            workToolStripMenuItem.Name = "workToolStripMenuItem";
            workToolStripMenuItem.Size = new Size(160, 20);
            workToolStripMenuItem.Text = "Workshop Store Procedure";
            // 
            // insertProductToolStripMenuItem
            // 
            insertProductToolStripMenuItem.Name = "insertProductToolStripMenuItem";
            insertProductToolStripMenuItem.Size = new Size(180, 22);
            insertProductToolStripMenuItem.Text = "Insert Product";
            insertProductToolStripMenuItem.Click += insertProductToolStripMenuItem_Click;
            // 
            // formAddUserToolStripMenuItem
            // 
            formAddUserToolStripMenuItem.Name = "formAddUserToolStripMenuItem";
            formAddUserToolStripMenuItem.Size = new Size(180, 22);
            formAddUserToolStripMenuItem.Text = "Form Add User";
            formAddUserToolStripMenuItem.Click += formAddUserToolStripMenuItem_Click;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "main";
            Text = "main";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem workShopToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem manageProductToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem workShopViewToolStripMenuItem;
        private ToolStripMenuItem fromOrderCountryYearToolStripMenuItem;
        private ToolStripMenuItem workToolStripMenuItem;
        private ToolStripMenuItem insertProductToolStripMenuItem;
        private ToolStripMenuItem formAddUserToolStripMenuItem;
    }
}