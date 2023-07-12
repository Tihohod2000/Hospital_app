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
using System.Runtime.Remoting.Lifetime;

namespace Project_of_store
{

    public partial class Mouse : Form
    {
        private string l;
        private string p;
        public bool admin;



        public bool menu_open = true;
        public Mouse(string l, string p)
        {
            InitializeComponent();
            this.l = l;
            this.p = p;

            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `admin` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarString).Value = l;
            command.Parameters.Add("@uP", MySqlDbType.VarString).Value = p;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.admin = true;
            }
        }


        private void show_list_Click(object sender, EventArgs e)
        {
            //Вывод списка пациентов в зависимость от пользователя или администратора
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string query_order = "SELECT `patient`.*, `doctors`.`lastname` as `Доктор` " +
                "FROM `patient` " +
                "JOIN `doctors` ON `patient`.`id_doctor`= `doctors`.`id` " +
                "JOIN `users` ON `doctors`.`login` = `users`.`login`" +
                "WHERE `doctors`.`login` = @uL";
            if (this.admin)
            {
                query_order = "SELECT `patient`.*, `doctors`.`lastname` as `Доктор` " +
                "FROM `patient` " +
                "JOIN `doctors` ON `patient`.`id_doctor`= `doctors`.`id`";
            }

            MySqlCommand command = new MySqlCommand(query_order, db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarString).Value = l;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }



        private void add_patient_Click(object sender, EventArgs e)
        {
            string lastNamebd = lastName.Text;
            string namebd = name.Text;
            string fatherbd = father.Text;
            string citybd = city.Text;
            string oldbd = old.Text;
            string diseasebd = disease.Text;
            string id_doctorbd = id_doctor.Text;

            //Проверка корректности введёных данных
            if (lastNamebd.Length == 0 || namebd.Length == 0 || fatherbd.Length == 0 || citybd.Length == 0 || oldbd.Length == 0 || diseasebd.Length == 0 ||
                id_doctorbd.Length == 0) {
                MessageBox.Show("Error! Не правильно введены данные");
                return;
            }

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();


            //Проверка на валидность введённых данных
            MySqlCommand command3 = new MySqlCommand("SELECT * FROM `patient` WHERE `name` = @uN AND `lastName` = @uLN AND `father` = @uF AND `city` = @uC AND `old` = @uO AND `disease` = @uD", db.getConnection());
            command3.Parameters.Add("@uN", MySqlDbType.VarString).Value = namebd;
            command3.Parameters.Add("@uLN", MySqlDbType.VarString).Value = lastNamebd;
            command3.Parameters.Add("@uF", MySqlDbType.VarString).Value = fatherbd;
            command3.Parameters.Add("@uC", MySqlDbType.VarString).Value = citybd;
            command3.Parameters.Add("@uO", MySqlDbType.VarString).Value = oldbd;
            command3.Parameters.Add("@uD", MySqlDbType.VarString).Value = diseasebd;
            adapter.SelectCommand = command3;
            adapter.Fill(table);

            //Такой пользователь уже существует!
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пациент уже существует!");
                return;
            }


            MySqlCommand command = new MySqlCommand("INSERT INTO `patient` (`id`, `lastName`, `name`, `father`, `city`, `old`, `disease`, `id_doctor` ) VALUES (NULL, @lastNamebd, @namebd, @fatherbd, @citybd, @oldbd, @disease, @id_doctor)", db.getConnection());
            command.Parameters.AddWithValue("@lastNamebd", lastNamebd);
            command.Parameters.AddWithValue("@namebd", namebd);
            command.Parameters.AddWithValue("@fatherbd", fatherbd);
            command.Parameters.AddWithValue("@citybd", citybd);
            command.Parameters.AddWithValue("@oldbd", oldbd);
            command.Parameters.AddWithValue("@disease", diseasebd);
            command.Parameters.AddWithValue("@id_doctor", id_doctorbd);
            adapter.SelectCommand = command;
            adapter.Fill(table);


            //Проверка успешного добавления
            adapter.SelectCommand = command3;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Пациент успешно добавлен");
            }
        }

        private void delete_patient(object sender, EventArgs e)
        {
            string id_patientbd = id_patient.Text;

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();


            //Проверка на валидность введённых данных

            if (id_patientbd.Length == 0) {
                MessageBox.Show("Вы не ввели ID");
                return;
            }

            string delet_order = "DELETE FROM `patient` WHERE `id` = @uID";
            string query_order = "SELECT * FROM `patient` WHERE `id` = @uID";

            MySqlCommand command = new MySqlCommand(query_order, db.getConnection());
            command.Parameters.Add("@uID", MySqlDbType.VarString).Value = id_patientbd;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Нет пациента с данным ID");
                return;
            }

            MySqlCommand command1 = new MySqlCommand(delet_order, db.getConnection());
            command1.Parameters.Add("@uID", MySqlDbType.VarString).Value = id_patientbd;
            adapter.SelectCommand = command1;
            adapter.Fill(table);

            MySqlCommand command2 = new MySqlCommand(query_order, db.getConnection());
            command2.Parameters.Add("@uID", MySqlDbType.VarString).Value = id_patientbd;
            adapter.SelectCommand = command2;
            adapter.Fill(table);


            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Ошибка");
            }
            else if (table.Rows.Count == 0) {
                MessageBox.Show("Пациент успешна удалён");
            }
        }
    }
}
        
    

      
    

