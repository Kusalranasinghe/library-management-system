namespace Librarymngmntsystem
{
    partial class dashboard2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblbookcount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblborrowcount = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblReferencecount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblmembers = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.booksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1180, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.contactUsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(52, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.contactUsToolStripMenuItem.Text = "Contact Us";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.borrowBooksToolStripMenuItem,
            this.returnBooksToolStripMenuItem,
            this.updateStockToolStripMenuItem});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(72, 27);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.bookToolStripMenuItem.Text = "Bookinfo";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // borrowBooksToolStripMenuItem
            // 
            this.borrowBooksToolStripMenuItem.Name = "borrowBooksToolStripMenuItem";
            this.borrowBooksToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.borrowBooksToolStripMenuItem.Text = "BorrowBooks";
            this.borrowBooksToolStripMenuItem.Click += new System.EventHandler(this.borrowBooksToolStripMenuItem_Click);
            // 
            // returnBooksToolStripMenuItem
            // 
            this.returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            this.returnBooksToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.returnBooksToolStripMenuItem.Text = "ReturnBooks";
            this.returnBooksToolStripMenuItem.Click += new System.EventHandler(this.returnBooksToolStripMenuItem_Click);
            // 
            // updateStockToolStripMenuItem
            // 
            this.updateStockToolStripMenuItem.Name = "updateStockToolStripMenuItem";
            this.updateStockToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.updateStockToolStripMenuItem.Text = "Update Stock";
            this.updateStockToolStripMenuItem.Click += new System.EventHandler(this.updateStockToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.lblbookcount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(88, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 193);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblbookcount
            // 
            this.lblbookcount.AutoSize = true;
            this.lblbookcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookcount.Location = new System.Drawing.Point(100, 100);
            this.lblbookcount.Name = "lblbookcount";
            this.lblbookcount.Size = new System.Drawing.Size(66, 46);
            this.lblbookcount.TabIndex = 1;
            this.lblbookcount.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "No of Books";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.lblborrowcount);
            this.panel2.Controls.Add(this.lbl2);
            this.panel2.Location = new System.Drawing.Point(449, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 193);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblborrowcount
            // 
            this.lblborrowcount.AutoSize = true;
            this.lblborrowcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblborrowcount.Location = new System.Drawing.Point(100, 100);
            this.lblborrowcount.Name = "lblborrowcount";
            this.lblborrowcount.Size = new System.Drawing.Size(66, 46);
            this.lblborrowcount.TabIndex = 1;
            this.lblborrowcount.Text = "00";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(34, 50);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(202, 25);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "No of Borrow Books";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Librarymngmntsystem.Properties.Resources._0a40224a8ca79c80af28ac13b8f360670e63b6292;
            this.pictureBox1.Location = new System.Drawing.Point(13, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1155, 697);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.lblReferencecount);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(821, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 193);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblReferencecount
            // 
            this.lblReferencecount.AutoSize = true;
            this.lblReferencecount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencecount.Location = new System.Drawing.Point(102, 100);
            this.lblReferencecount.Name = "lblReferencecount";
            this.lblReferencecount.Size = new System.Drawing.Size(66, 46);
            this.lblReferencecount.TabIndex = 1;
            this.lblReferencecount.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "No of Reference Books";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.lblmembers);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(88, 397);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(269, 193);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lblmembers
            // 
            this.lblmembers.AutoSize = true;
            this.lblmembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmembers.Location = new System.Drawing.Point(100, 100);
            this.lblmembers.Name = "lblmembers";
            this.lblmembers.Size = new System.Drawing.Size(66, 46);
            this.lblmembers.TabIndex = 1;
            this.lblmembers.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "No of Members";
            // 
            // dashboard2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 743);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "dashboard2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblbookcount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblborrowcount;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ToolStripMenuItem returnBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStockToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblReferencecount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblmembers;
        private System.Windows.Forms.Label label4;
    }
}