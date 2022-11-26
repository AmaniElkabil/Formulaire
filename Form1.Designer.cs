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
            this.idbookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bibliolivreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_selecte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Form1_Load)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliolivreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Form1_Load
            // 
            this.Form1_Load.AllowUserToAddRows = false;
            this.Form1_Load.AllowUserToDeleteRows = false;
            this.Form1_Load.AutoGenerateColumns = false;
            this.Form1_Load.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Form1_Load.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbookDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authornameDataGridViewTextBoxColumn});
            this.Form1_Load.DataSource = this.bibliolivreBindingSource;
            this.Form1_Load.Location = new System.Drawing.Point(12, 12);
            this.Form1_Load.Name = "Form1_Load";
            this.Form1_Load.Size = new System.Drawing.Size(507, 259);
            this.Form1_Load.TabIndex = 0;
            this.Form1_Load.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Form1_Load_CellContentClick);
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
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(38, 295);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(89, 33);
            this.btn_Insert.TabIndex = 1;
            this.btn_Insert.Text = "&Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(204, 295);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(89, 33);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "&Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(396, 295);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(89, 33);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "&Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_selecte
            // 
            this.btn_selecte.Location = new System.Drawing.Point(553, 138);
            this.btn_selecte.Name = "btn_selecte";
            this.btn_selecte.Size = new System.Drawing.Size(89, 33);
            this.btn_selecte.TabIndex = 4;
            this.btn_selecte.Text = "&Selecte";
            this.btn_selecte.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 355);
            this.Controls.Add(this.btn_selecte);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.Form1_Load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Form1_Load)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliolivreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Form1_Load;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_selecte;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bibliolivreBindingSource;
    }
}

