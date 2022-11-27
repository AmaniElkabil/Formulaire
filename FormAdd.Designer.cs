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
            this.components = new System.ComponentModel.Container();
            this.author = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txtauthor = new System.Windows.Forms.TextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.bibliolivreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliolivreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bibliolivreBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bibliolivreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliolivreBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliolivreBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Location = new System.Drawing.Point(42, 112);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(73, 13);
            this.author.TabIndex = 1;
            this.author.Text = "Author name :";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(49, 56);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(33, 13);
            this.title.TabIndex = 1;
            this.title.Text = "Title :";
            // 
            // btn_save
            // 
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_save.Location = new System.Drawing.Point(212, 159);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(91, 31);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "&Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(309, 159);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(91, 31);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "&Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // txtauthor
            // 
            this.txtauthor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bibliolivreBindingSource2, "author_name", true));
            this.txtauthor.Location = new System.Drawing.Point(134, 109);
            this.txtauthor.Multiline = true;
            this.txtauthor.Name = "txtauthor";
            this.txtauthor.Size = new System.Drawing.Size(266, 32);
            this.txtauthor.TabIndex = 2;
            // 
            // txttitle
            // 
            this.txttitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bibliolivreBindingSource1, "title", true));
            this.txttitle.Location = new System.Drawing.Point(134, 53);
            this.txttitle.Multiline = true;
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(266, 34);
            this.txttitle.TabIndex = 1;
            // 
            // bibliolivreBindingSource
            // 
            this.bibliolivreBindingSource.DataSource = typeof(Formulaire.biblio_livre);
            // 
            // bibliolivreBindingSource1
            // 
            this.bibliolivreBindingSource1.DataSource = typeof(Formulaire.biblio_livre);
            // 
            // bibliolivreBindingSource2
            // 
            this.bibliolivreBindingSource2.DataSource = typeof(Formulaire.biblio_livre);
            // 
            // FormAdd
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(466, 365);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.txtauthor);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.title);
            this.Controls.Add(this.author);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdd_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bibliolivreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliolivreBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliolivreBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txtauthor;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.BindingSource bibliolivreBindingSource;
        private System.Windows.Forms.BindingSource bibliolivreBindingSource1;
        private System.Windows.Forms.BindingSource bibliolivreBindingSource2;
    }
}