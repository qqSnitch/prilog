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
    public partial class Form3 : Form
    {
        public NpgsqlConnection con;
        public Form3(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void buttonYes_Click_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO Product (name,ed) VALUES (:name,:ed)", con);
                command.Parameters.AddWithValue("name", textBox1.Text);
                command.Parameters.AddWithValue("ed", Convert.ToDouble(textBox2.Text));
                command.ExecuteNonQuery();
            }
            catch { }
        }

        private void buttonNo_Click_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
