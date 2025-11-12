namespace Librarymngmntsystem
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbookid = new System.Windows.Forms.TextBox();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbooktitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbookauthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpages = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radbtnref = new System.Windows.Forms.RadioButton();
            this.radbtnborrow = new System.Windows.Forms.RadioButton();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Id :";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtbookid
            // 
            this.txtbookid.Location = new System.Drawing.Point(564, 263);
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.Size = new System.Drawing.Size(188, 22);
            this.txtbookid.TabIndex = 2;
            // 
            // txtbookname
            // 
            this.txtbookname.Location = new System.Drawing.Point(564, 308);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(188, 22);
            this.txtbookname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Book Name :";
            // 
            // txtbooktitle
            // 
            this.txtbooktitle.Location = new System.Drawing.Point(564, 353);
            this.txtbooktitle.Name = "txtbooktitle";
            this.txtbooktitle.Size = new System.Drawing.Size(188, 22);
            this.txtbooktitle.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Book Title :";
            // 
            // txtbookauthor
            // 
            this.txtbookauthor.Location = new System.Drawing.Point(564, 397);
            this.txtbookauthor.Name = "txtbookauthor";
            this.txtbookauthor.Size = new System.Drawing.Size(188, 22);
            this.txtbookauthor.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Book Author :";
            // 
            // txtpages
            // 
            this.txtpages.Location = new System.Drawing.Point(564, 438);
            this.txtpages.Name = "txtpages";
            this.txtpages.Size = new System.Drawing.Size(188, 22);
            this.txtpages.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(390, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "No of Pages :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Classification :";
            // 
            // radbtnref
            // 
            this.radbtnref.AutoSize = true;
            this.radbtnref.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnref.Location = new System.Drawing.Point(564, 478);
            this.radbtnref.Name = "radbtnref";
            this.radbtnref.Size = new System.Drawing.Size(116, 24);
            this.radbtnref.TabIndex = 12;
            this.radbtnref.TabStop = true;
            this.radbtnref.Text = "Reference";
            this.radbtnref.UseVisualStyleBackColor = true;
            // 
            // radbtnborrow
            // 
            this.radbtnborrow.AutoSize = true;
            this.radbtnborrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnborrow.Location = new System.Drawing.Point(564, 508);
            this.radbtnborrow.Name = "radbtnborrow";
            this.radbtnborrow.Size = new System.Drawing.Size(125, 24);
            this.radbtnborrow.TabIndex = 13;
            this.radbtnborrow.TabStop = true;
            this.radbtnborrow.Text = "Borrowable";
            this.radbtnborrow.UseVisualStyleBackColor = true;
            // 
            // btnregister
            // 
            this.btnregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.Location = new System.Drawing.Point(277, 585);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(122, 35);
            this.btnregister.TabIndex = 14;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(439, 585);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(122, 35);
            this.btnupdate.TabIndex = 15;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(603, 585);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(122, 35);
            this.Search.TabIndex = 16;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(452, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 32);
            this.label7.TabIndex = 17;
            this.label7.Text = "Book Registration";
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(770, 585);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(122, 35);
            this.btndelete.TabIndex = 18;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Librarymngmntsystem.Properties.Resources._0a40224a8ca79c80af28ac13b8f360670e63b629;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1187, 673);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 697);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.radbtnborrow);
            this.Controls.Add(this.radbtnref);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpages);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbookauthor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbooktitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbookname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbookid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbookid;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbooktitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbookauthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radbtnref;
        private System.Windows.Forms.RadioButton radbtnborrow;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btndelete;
    }
}

