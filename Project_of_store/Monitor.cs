using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using static Project_of_store.Components.Widge;
using Project_of_store.Components;
using MySql.Data.MySqlClient;

namespace Project_of_store
{
    public partial class Monitor : Form
    {

        public bool menu_open = true;
        public Monitor()
        {
            InitializeComponent();
        }






        private void show_list_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT `doctors`.*, COUNT(`patient`.`id_doctor`) as `Количество пациентов` " +
                "FROM `doctors` JOIN `patient` ON `doctors`.`id` = `patient`.`id_doctor`" +
                "GROUP BY `doctors`.`id`;", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


        }

        private void add_doctor_Click(object sender, EventArgs e)
        {
            string lastNamebd = lastName.Text;
            string namebd = name.Text;
            string fatherbd = father.Text;
            string citybd = city.Text;
            string oldbd = old.Text;
            string specializationbd = specialization.Text;
            //Проверка корректности введёных данных
            /*if (loginuser.Length < 2 || password.Length < 2)
            {
                MessageBox.Show("Некорректные данные");
                return;
            }*/

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();


            //Проверка на валидность введённых данных
            MySqlCommand command3 = new MySqlCommand("SELECT * FROM `doctors` WHERE `name` = @uN AND `lastName` = @uLN AND `father` = @uF AND `city` = @uC AND `old` = @uO AND `specialization` = @uS", db.getConnection());
            command3.Parameters.Add("@uN", MySqlDbType.VarString).Value = namebd;
            command3.Parameters.Add("@uLN", MySqlDbType.VarString).Value = lastNamebd;
            command3.Parameters.Add("@uF", MySqlDbType.VarString).Value = fatherbd;
            command3.Parameters.Add("@uC", MySqlDbType.VarString).Value = citybd;
            command3.Parameters.Add("@uO", MySqlDbType.VarString).Value = oldbd;
            command3.Parameters.Add("@uS", MySqlDbType.VarString).Value = specializationbd;
            adapter.SelectCommand = command3;
            adapter.Fill(table);

            //Такой пользователь уже существует!
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой врач уже существует!");
                return;
            }


            MySqlCommand command = new MySqlCommand("INSERT INTO `doctors` (`id`, `lastName`, `name`, `father`, `city`, `old`, `specialization`) VALUES (NULL, @lastNamebd, @namebd, @fatherbd, @citybd, @oldbd, @specializationbd)", db.getConnection());
            command.Parameters.AddWithValue("@lastNamebd", lastNamebd);
            command.Parameters.AddWithValue("@namebd", namebd);
            command.Parameters.AddWithValue("@fatherbd", fatherbd);
            command.Parameters.AddWithValue("@citybd", citybd);
            command.Parameters.AddWithValue("@oldbd", oldbd);
            command.Parameters.AddWithValue("@specializationbd", specializationbd);
            adapter.SelectCommand = command;
            adapter.Fill(table);


            //Проверка успешной регистрации
            adapter.SelectCommand = command3;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Доктор успешно добавлен");
            }
        }
    }
}
        
    

      
    

