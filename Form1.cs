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
    public partial class Form1 : Form
    {
        db_biblioEntities db;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new db_biblioEntities();
            bibliolivreBindingSource.DataSource = db.biblio_livre.ToList();
        }
    }
}
