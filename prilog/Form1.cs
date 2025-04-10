
using Npgsql;
namespace prilog

{
    public partial class Form1 : Form
    {
        public NpgsqlConnection con;

        public void MyLoad(){
            this.StartPosition = FormStartPosition.CenterScreen;
            con = new NpgsqlConnection("Server=localhost;Port=5432;UserID=postgres;Password=postpass;Database=MyBase");
            con.Open();
        }
        public Form1()
        {
            InitializeComponent();
            MyLoad();
        }

        private void ÚÓ‚‡˚ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(con);
            f.ShowDialog();
        }

        private void Ì‡ÍÎ‡‰Ì˚ÂToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4(con);
            f.ShowDialog();
        }
    }
}