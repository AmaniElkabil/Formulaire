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
        db_biblioEntities db;

        public Form1()
        {
            InitializeComponent();
        }
        static string chaine = @"Server = localhost\SQLEXPRESS;Database=master;Trusted_Connection=True";
   
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        private void Form1_Load_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new db_biblioEntities();
            bibliolivreBindingSource.DataSource = db.biblio_livre.ToList();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into Dossier(ID_DOSSIER, NOM_DOSSIER) values('" + txtId_dossier.Text + "','" + txtNom_dossier.Text + "') ";
            cnx.Close();
            using (FormAdd frm= new FormAdd(null))
            {
                if (frm.ShowDialog() == DialogResult.OK) 
                {
                    bibliolivreBindingSource.DataSource = db.biblio_livre.ToList();
                }
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "update Dossier set NOM_DOSSIER='" + txtNom_dossier.Text + "' where ID_DOSSIER='" + txtId_dossier.Text + "' ";
            cnx.Close();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "delete from biblio_livre where ID_DOSSIER='" + txtId_dossier.Text + "' ";
            cnx.Close();
            if (bibliolivreBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure want to delete this record", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.biblio_livre.Remove(bibliolivreBindingSource.Current as biblio_livre);
                    bibliolivreBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.CommandText = "select * from biblio_livre";
            cmd.Connection = cnx;
            cnx.Close();
        }
    }
}
