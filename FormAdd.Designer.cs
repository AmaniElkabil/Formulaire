namespace Formulaire
{
    partial class FormAdd
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
            this.id_book = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtauthor = new System.Windows.Forms.TextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // id_book
            // 
            this.id_book.AutoSize = true;
            this.id_book.Location = new System.Drawing.Point(47, 56);
            this.id_book.Name = "id_book";
            this.id_book.Size = new System.Drawing.Size(66, 13);
            this.id_book.TabIndex = 0;
            this.id_book.Text = "ID book :     ";
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Location = new System.Drawing.Point(47, 180);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(73, 13);
            this.author.TabIndex = 1;
            this.author.Text = "Author name :";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(47, 112);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(33, 13);
            this.title.TabIndex = 2;
            this.title.Text = "Title :";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(210, 215);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(91, 31);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "&Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(307, 215);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(91, 31);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "&Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(132, 53);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(266, 20);
            this.txtid.TabIndex = 6;
            // 
            // txtauthor
            // 
            this.txtauthor.Location = new System.Drawing.Point(132, 177);
            this.txtauthor.Name = "txtauthor";
            this.txtauthor.Size = new System.Drawing.Size(266, 20);
            this.txtauthor.TabIndex = 7;
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(132, 109);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(266, 20);
            this.txttitle.TabIndex = 8;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 365);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.txtauthor);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.title);
            this.Controls.Add(this.author);
            this.Controls.Add(this.id_book);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_book;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtauthor;
        private System.Windows.Forms.TextBox txttitle;
    }
}