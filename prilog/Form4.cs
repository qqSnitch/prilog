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
        DataTable dt = new DataTable();
        public Form4(NpgsqlConnection con)
        {
            InitializeComponent();
            Update();
            Update1();
        }
        private void Update()
        {
            string sql = "SELECT futura.id, futura.data, client.name FROM futura JOIN client ON futura.idcen = client.id GROUP BY futura.id, futura.data";
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
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO Futura(clientID, data.totalum)"+"VALUES(:clientID,:orderdate,0)",con);
                DateTime dt = this.dateTimePicker1.Value.Date;
                cmd.Parameters.AddWithValue("clientID", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("data", dt);
                cmd.ExecuteNonQuery();
                Close();
            }catch{ }
        }
    }
}
