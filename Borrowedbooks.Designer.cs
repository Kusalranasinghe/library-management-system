namespace Librarymngmntsystem
{
    partial class Borrowedbooks
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnborrow = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtduedate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtborrowdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbookid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtuserid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Librarymngmntsystem.Properties.Resources._0a40224a8ca79c80af28ac13b8f360670e63b6291;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1071, 703);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnborrow
            // 
            this.btnborrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrow.Location = new System.Drawing.Point(473, 504);
            this.btnborrow.Name = "btnborrow";
            this.btnborrow.Size = new System.Drawing.Size(149, 42);
            this.btnborrow.TabIndex = 26;
            this.btnborrow.Text = "Borrow";
            this.btnborrow.UseVisualStyleBackColor = true;
            this.btnborrow.Click += new System.EventHandler(this.btnborrow_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(468, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Borrowed Books";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(374, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Due Date :";
            // 
            // txtduedate
            // 
            this.txtduedate.Location = new System.Drawing.Point(531, 431);
            this.txtduedate.Name = "txtduedate";
            this.txtduedate.Size = new System.Drawing.Size(209, 22);
            this.txtduedate.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Borrow Date  :";
            // 
            // txtborrowdate
            // 
            this.txtborrowdate.Location = new System.Drawing.Point(531, 378);
            this.txtborrowdate.Name = "txtborrowdate";
            this.txtborrowdate.Size = new System.Drawing.Size(209, 22);
            this.txtborrowdate.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Book Id :";
            // 
            // txtbookid
            // 
            this.txtbookid.Location = new System.Drawing.Point(531, 322);
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.Size = new System.Drawing.Size(209, 22);
            this.txtbookid.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "User Id :";
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(531, 267);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(209, 22);
            this.txtuserid.TabIndex = 15;
            // 
            // Borrowedbooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 728);
            this.Controls.Add(this.btnborrow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtduedate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtborrowdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbookid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtuserid);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Borrowedbooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrowedbooks";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnborrow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtduedate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtborrowdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbookid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuserid;
    }
}