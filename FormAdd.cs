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
                
            }
        }

        private void FormAdd_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
