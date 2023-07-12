using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_of_store
{
    public partial class PayForm : Form
    {
        public PayForm()
        {
            InitializeComponent();
        }

        private void bunifuTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void bunifuTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }



        private void CheckBox1_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {
                CheckBox2.Checked = false;
                panel1.Enabled = false;
            }
            else
            {
                CheckBox2.Checked = true;
                panel1.Enabled = true;
            }
        }

        private void CheckBox2_Click(object sender, EventArgs e)
        {
            if (CheckBox2.Checked == true)
            {
                CheckBox1.Checked = false;
                panel1.Enabled = true;
            }
            else
            {
                CheckBox1.Checked = true;
                panel1.Enabled = false;
            }
        }

        private void Pay_button_Click(object sender, EventArgs e)
        {
            if (CheckBox2.Checked == true)
            {
                if (bunifuTextBox5.Text.Length > 2 && bunifuTextBox1.Text.Length > 1 && bunifuTextBox2.Text.Length > 1 && bunifuTextBox3.Text.Length > 1 && FioTextBox4.Text.Length > 5 && StreetTextBox6.Text.Length > 5)
                {
                    MessageBox.Show("Оплата произведена успешно");
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Некорректные данные");
                }
            }
            else
            {
                if (FioTextBox4.Text.Length > 5 && StreetTextBox6.Text.Length > 5)
                {
                    MessageBox.Show("Оплата произведена успешно");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Некорректные данные");
                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.ru/maps/place/"+StreetTextBox6.Text);
        }
    }
}
