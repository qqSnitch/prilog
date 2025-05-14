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
    public partial class Form4 : Form
    {
        public NpgsqlConnection con;
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        DataTable dt = new DataTable();
        public Form4(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            Update();
            Update1();
            Update52();
        }
        private void Update()
        {
            string sql = "SELECT futura.id, futura.data, client.name FROM futura JOIN client ON futura.idcen = client.id GROUP BY client.name, futura.id, futura.data";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }
        private void Update1()
        {
            string sql = "SELECT * FROM client";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds2.Reset();
            da.Fill(ds2);
            dt = ds2.Tables[0];
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "ID";
        }
        private void Update52()
        {
            string sql = "SELECT futurainfo.ID,idfutura,product.name,quantity,price FROM futurainfo JOIN product ON futurainfo.idproduct = product.id GROUP BY product.name, futurainfo.ID";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds1.Reset();
            da.Fill(ds1);
            dt = ds1.Tables[0];
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO futura(idcen, data, totalum)"+"VALUES(:clientID,:orderdate,0)",con);
                DateTime dt = this.dateTimePicker1.Value.Date;
                cmd.Parameters.AddWithValue("clientID", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("orderdate", dt);
                cmd.ExecuteNonQuery();
                Update();

            }catch{ }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
                NpgsqlCommand command = new NpgsqlCommand("Delete from futura where ID =:id", con);
                command.Parameters.AddWithValue("id", id);
                command.ExecuteNonQuery();
                Update();
            }
            catch { }
        }
    }
}
