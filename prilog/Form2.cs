using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace prilog
{
    public partial class Form2 : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public Form2(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            Update();
        }
        public void Update()
        {
            String sql = "Select * from Product";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset(); 
            da.Fill(ds);
            dt=ds.Tables[0];
            DataGridView1.DataSource = dt;
            DataGridView1.Columns[0].HeaderText = "Номер";
            DataGridView1.Columns[0].HeaderText = "Наименование";
            DataGridView1.Columns[0].HeaderText = "Ед изменения";
            DataGridView1.Columns[0].HeaderText = "Номер";
            this.StartPosition= FormStartPosition.CenterScreen;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f =new Form3 (con);
            f.ShowDialog();
            Update();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)DataGridView1.CurrentRow.Cells["ID"].Value;
            NpgsqlCommand command = new NpgsqlCommand("Delete from Product where ID =:id",con);
            command.Parameters.AddWithValue("id", id);
            command.ExecuteNonQuery();
            Update();
        }
    }
}
