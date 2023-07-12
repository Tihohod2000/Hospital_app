using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.Adapters;

namespace Project_of_store
{
    public partial class Form1 : Form
    {
        private string l;
        private string p;
        public Form1(string l, string p)
        {
            InitializeComponent();
            this.l = l;
            this.p = p;
            /*PanelForm(new FrmMain());*/
        }


        private Form active;
        private void PanelForm(Form fm)
        {
            if (active != null)
                active.Close();

            active = fm;
            fm.TopLevel = false;
            this.pnl1.Controls.Add(fm);
            this.pnl1.Tag = fm;
            fm.BringToFront();
            fm.Show();

        }

    

        public void gunaGradientButton2_Click(object sender, EventArgs e)
        {

            string loginuser = l;
            string password = p;
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `admin` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            command2.Parameters.Add("@uL", MySqlDbType.VarString).Value = loginuser;
            command2.Parameters.Add("@uP", MySqlDbType.VarString).Value = password;

            adapter.SelectCommand = command2;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Доступ разрешён");
                PanelForm(new Monitor());

            }
            else {
                MessageBox.Show("Доступ запрещён");
            }
            
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            Mouse f = new Mouse(p, l);
            PanelForm(new Mouse(p, l));
        }


        private void gunaGradientButton8_Click(object sender, EventArgs e)
        {
            Form f = new Registr();
            f.Show();
            this.Hide();
        }

    }
}