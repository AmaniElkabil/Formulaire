namespace Formulaire
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
            this.components = new System.ComponentModel.Container();
            this.Form1_Load = new System.Windows.Forms.DataGridView();
            this.IDbook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titlebook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bibliolivreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtauthor = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Form1_Load)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliolivreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Form1_Load
            // 
            this.Form1_Load.AutoGenerateColumns = false;
            this.Form1_Load.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Form1_Load.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Form1_Load.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDbook,
            this.Titlebook,
            this.AuthorName,
            this.idbookDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authornameDataGridViewTextBoxColumn});
            this.Form1_Load.DataSource = this.bibliolivreBindingSource;
            this.Form1_Load.Location = new System.Drawing.Point(12, 12);
            this.Form1_Load.Name = "Form1_Load";
            this.Form1_Load.Size = new System.Drawing.Size(345, 296);
            this.Form1_Load.TabIndex = 0;
            this.Form1_Load.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Form1_Load_CellContentClick);
            // 
            // IDbook
            // 
            this.IDbook.DataPropertyName = "id_book";
            this.IDbook.HeaderText = "IDbook";
            this.IDbook.Name = "IDbook";
            this.IDbook.Visible = false;
            // 
            // Titlebook
            // 
            this.Titlebook.DataPropertyName = "title";
            this.Titlebook.HeaderText = "Title";
            this.Titlebook.Name = "Titlebook";
            this.Titlebook.Visible = false;
            // 
            // AuthorName
            // 
            this.AuthorName.DataPropertyName = "author_name";
            this.AuthorName.HeaderText = "Author Name";
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Visible = false;
            // 
            // idbookDataGridViewTextBoxColumn
            // 
            this.idbookDataGridViewTextBoxColumn.DataPropertyName = "id_book";
            this.idbookDataGridViewTextBoxColumn.HeaderText = "id_book";
            this.idbookDataGridViewTextBoxColumn.Name = "idbookDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // authornameDataGridViewTextBoxColumn
            // 
            this.authornameDataGridViewTextBoxColumn.DataPropertyName = "author_name";
            this.authornameDataGridViewTextBoxColumn.HeaderText = "author_name";
            this.authornameDataGridViewTextBoxColumn.Name = "authornameDataGridViewTextBoxColumn";
            // 
            // bibliolivreBindingSource
            // 
            this.bibliolivreBindingSource.DataSource = typeof(Formulaire.biblio_livre);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_insert.Location = new System.Drawing.Point(501, 216);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(89, 33);
            this.btn_insert.TabIndex = 2;
            this.btn_insert.Text = "&Insert";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_delete.Location = new System.Drawing.Point(596, 216);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(89, 33);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "&Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(475, 65);
            this.txttitle.Multiline = true;
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(321, 34);
            this.txttitle.TabIndex = 7;
            // 
            // txtauthor
            // 
            this.txtauthor.Location = new System.Drawing.Point(475, 121);
            this.txtauthor.Multiline = true;
            this.txtauthor.Name = "txtauthor";
            this.txtauthor.Size = new System.Drawing.Size(321, 32);
            this.txtauthor.TabIndex = 10;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(413, 65);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(56, 29);
            this.title.TabIndex = 8;
            this.title.Text = "Title :";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author.Location = new System.Drawing.Point(358, 121);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(111, 25);
            this.author.TabIndex = 9;
            this.author.Text = "Author name :";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(691, 216);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(91, 31);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "&Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_select.Location = new System.Drawing.Point(585, 25);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(84, 34);
            this.btn_select.TabIndex = 12;
            this.btn_select.Text = "&Select";
            this.btn_select.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_save.Location = new System.Drawing.Point(501, 176);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(84, 34);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "&Save";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(808, 309);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.txtauthor);
            this.Controls.Add(this.title);
            this.Controls.Add(this.author);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.Form1_Load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Form1_Load)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliolivreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Form1_Load;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.BindingSource bibliolivreBindingSource;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.TextBox txtauthor;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDbook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titlebook;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_save;
    }
}

