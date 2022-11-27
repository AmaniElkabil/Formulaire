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
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txtId_dossier = new System.Windows.Forms.TextBox();
            this.txtNom_dossier = new System.Windows.Forms.TextBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.idbookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bibliolivreBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(38, 295);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(89, 33);
            this.btn_Insert.TabIndex = 1;
            this.btn_Insert.Text = "&Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(204, 295);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(89, 33);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "&Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(396, 295);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(89, 33);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "&Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txtId_dossier
            // 
            this.txtId_dossier.Location = new System.Drawing.Point(559, 113);
            this.txtId_dossier.Name = "txtId_dossier";
            this.txtId_dossier.Size = new System.Drawing.Size(148, 20);
            this.txtId_dossier.TabIndex = 4;
            // 
            // txtNom_dossier
            // 
            this.txtNom_dossier.Location = new System.Drawing.Point(559, 149);
            this.txtNom_dossier.Name = "txtNom_dossier";
            this.txtNom_dossier.Size = new System.Drawing.Size(148, 20);
            this.txtNom_dossier.TabIndex = 5;
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(592, 188);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(89, 33);
            this.btn_select.TabIndex = 6;
            this.btn_select.Text = "&Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 355);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.txtNom_dossier);
            this.Controls.Add(this.txtId_dossier);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Form1_Load;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bibliolivreBindingSource;
        private System.Windows.Forms.TextBox txtId_dossier;
        private System.Windows.Forms.TextBox txtNom_dossier;
        private System.Windows.Forms.Button btn_select;
    }
}

