using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulaire
{

    public partial class FormAdd : Form
    {
        db_biblioEntities db;
        public FormAdd(biblio_livre obj)
        {
            InitializeComponent();
            db = new db_biblioEntities(); 
            if(obj == null) 
            {
                bibliolivreBindingSource.DataSource = new biblio_livre();
                db.biblio_livre.Add(bibliolivreBindingSource.Current as biblio_livre);
            }
            else 
            {
                bibliolivreBindingSource.DataSource = new biblio_livre();
                db.biblio_livre.Attach(bibliolivreBindingSource.Current as biblio_livre);
            }
        }

        private void FormAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK) 
            {
                if (string.IsNullOrEmpty(txttitle.Text)) 
                {
                    MessageBox.Show("!!Please entre book title!!","Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttitle.Focus();
                    e.Cancel = true;
                    return;
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false; 
        }
    }
}
