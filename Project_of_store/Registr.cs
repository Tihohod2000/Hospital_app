using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_of_store
{
    public partial class Registr : Form
    {

        public bool menu_open = true;
        public Registr()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string loginuser = loginField.Text;
            string password = passField.Text;
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarString).Value = loginuser;
            command.Parameters.Add("@uP", MySqlDbType.VarString).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Вход выполнен, как доктор");

                /*Form1 f2 = new Form1();
                string s = loginField.Text;
                f2.gunaGradientButton8.Text = s;*/
                //f2.Show();



                //Переход в основное окно программы
                
                string s = loginField.Text;
                string l = loginField.Text;
                string p = passField.Text;
                Form1 f = new Form1(p,l);

                f.gunaGradientButton8.Text = s;
                f.Show();
                this.Hide();
            }
            else{
                MySqlCommand command2 = new MySqlCommand("SELECT * FROM `admin` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
                command2.Parameters.Add("@uL", MySqlDbType.VarString).Value = loginuser;
                command2.Parameters.Add("@uP", MySqlDbType.VarString).Value = password;

                adapter.SelectCommand = command2;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Вход выполнен, как Администратор");

                    /*Form1 f2 = new Form1();
                    string s = loginField.Text;
                    f2.gunaGradientButton8.Text = s;*/
                    //f2.Show();



                    //Переход в основное окно программы
                    string l = loginField.Text;
                    string p = passField.Text;
                    Form1 f = new Form1(p, l);
                    string s = "Администратор";
                    f.gunaGradientButton8.Text = s;
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ошибка! Проверьте введённые данные!");
                    return;
                }
            }
            
            //ProgrammForm f = new ProgrammForm();
            //f.Show();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            //Регистрация пользователя
            string loginuser = loginField.Text;
            string password = passField.Text;


            //Проверка корректности введёных данных
            if (loginuser.Length < 2 || password.Length < 2)
            {
                MessageBox.Show("Некорректные данные");
                return;
            }

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();


            //Проверка на валидность введённых данных
            MySqlCommand command3 = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL ", db.getConnection());
            command3.Parameters.Add("@uL", MySqlDbType.VarString).Value = loginuser;
            adapter.SelectCommand = command3;
            adapter.Fill(table);

            //Такой пользователь уже существует!
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь " + loginuser + " уже существует!");
                return;
            }


            MySqlCommand command = new MySqlCommand("INSERT INTO `user` (`id`, `login`, `pass`) VALUES (NULL, '" + loginuser + "', '" + password + "')", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);


            //Проверка успешной регистрации
            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `user` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            command2.Parameters.Add("@uL", MySqlDbType.VarString).Value = loginuser;
            command2.Parameters.Add("@uP", MySqlDbType.VarString).Value = password;
            adapter.SelectCommand = command2;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Пользователь " + loginuser + " успешно добавлен");
            }
        }
    }
}