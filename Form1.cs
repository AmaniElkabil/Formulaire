using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Formulaire
{
    public partial class Form1 : Form
    {
        biblio_livre model = new biblio_livre();

        public Form1()
        {
            InitializeComponent();
        }
        static string chaine = @"Server = localhost\SQLEXPRESS;Database=master;Trusted_Connection=True";

        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear() 
        {
            txttitle.Text = txtauthor.Text = "";
            btn_save.Text = "Save";
            btn_delete.Enabled = false;
            model.id_book = 0;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Clear();
            PopulateData();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            model.title = txttitle.Text.Trim();
            model.author_name = txtauthor.Text.Trim();
            using (db_biblioEntities db = new db_biblioEntities()) 
            {
                if (model.id_book == 0)//insert
                    db.biblio_livre.Add(model);
                else //update
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            MessageBox.Show("Submitted Successfully");
        }
        void PopulateData() 
        {
            Form1_Load.AutoGenerateColumns = false;
            using (db_biblioEntities db = new db_biblioEntities())
            {
                Form1_Load.DataSource = db.biblio_livre.ToList<biblio_livre>();
            }
        }

        private void Form1_Load_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Form1_Load.CurrentRow.Index != 1) 
            {
                model.id_book = Convert.ToInt32(Form1_Load.CurrentRow.Cells["IDBook"].Value);
                using (db_biblioEntities db = new db_biblioEntities() ) 
                {
                    model = db.biblio_livre.Where(x => x.id_book == model.id_book).FirstOrDefault();
                    txttitle.Text = model.title;
                    txtauthor.Text = model.author_name;
                }
                btn_save.Text = "Update";
                btn_delete.Enabled = true;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Delete this record?","formulaire Operation", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            using(db_biblioEntities db = new db_biblioEntities())
            {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                        db.biblio_livre.Attach(model);
                    db.biblio_livre.Remove(model);
                    db.SaveChanges();
                    PopulateData();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
            }
        }
    }
}
