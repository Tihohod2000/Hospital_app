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

namespace Project_of_store
{
    public partial class FrmMain : Form
    {

        public bool menu_open = true;
        public FrmMain()
        {
            InitializeComponent();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            //docker.WindowsState
        }

        //Добавление элементов в каталог
        public void AddItem(string name, double cost, string icon, string info)
        {
            var w = new Widge()
            {
                Title = name,
                Cost = cost,
                Icon = Image.FromFile("icons/" + icon),
                Info = info

            };
            pnl.Controls.Add(w);

            w.OnSelect += (ss, ee) =>
            {
                var wdg = (Widge)ss;
                foreach (DataGridViewRow item in grid.Rows)
                {
                    if (item.Cells[0].Value.ToString() == wdg.lblTitle.Text)
                    {
                        item.Cells[1].Value = int.Parse(item.Cells[1].Value.ToString()) + 1;
                        item.Cells[2].Value = (int.Parse(item.Cells[1].Value.ToString()) * double.Parse(wdg.lblCost.Text.Replace("₽", ""))).ToString("C2");
                        CalculateTotal();
                        return;
                    }
                }
                grid.Rows.Add(new object[] { wdg.lblTitle.Text, 1, wdg.lblCost.Text });
                CalculateTotal();
            };
        }

        //Расчёт общей стоимости
        void CalculateTotal()
        {
            double tot = 0;
            foreach (DataGridViewRow item in grid.Rows)
            {
                tot += double.Parse(item.Cells[2].Value.ToString().Replace("₽", ""));
            }
            lblToT.Text = tot.ToString("C2");
        }


        //Общий каталог
        private void FrmMain_Load(object sender, EventArgs e)
        {
            AddItem("Samsung", 14280.50, "Samsung C24RG50FZI.png", "1920x1080@144 Гц, VA,\n 4 мс, 3000 : 1, \n250 Кд/м², 178°/178°,\n DisplayPort, HDMI x2,\n изогнутый, AMD FreeSync");
            AddItem("Philips", 15299.90, "Philips 24M1N3200VS.png", "1920x1080@164 Гц, VA,\n 4 мс, 3000 : 1, \n280 Кд/м², 178°/178°,\n DisplayPort, HDMI x2,\n AMD FreeSync");
            AddItem("Philips2", 13280.90, "Philips 242E1GAJ.png", "1920x1080@120 Гц,\n 4 мс, 2800 : 1, \n250 Кд/м², 168°/168°,\n HDMI x2,\n AMD FreeSync, изогнутый");
            AddItem("AOC", 14500, "AOC E970SWN.png", "1920x1080@144 Гц, VA,\n 4 мс, 3000 : 1, \n250 Кд/м², 178°/178°,\n DisplayPort, HDMI x2,\n изогнутый, AMD FreeSync");
            AddItem("Acer", 14280.90, "Acer Nitro KG242YPbmiipx.png", "1920x1080@300 Гц, \n 4 мс, 2500 : 1, \n270 Кд/м², 178°/178°,\n DisplayPort, HDMI x1,\n AMD FreeSync");

            AddItem("Logitech2", 4280.50, "Logitech B100.png", "800 dpi, светодиодный,\n USB Type-A, кнопки");
            AddItem("Logitech", 3580.50, "Logitech G102 LIGHTSYNC.png", "8000 dpi, светодиодный,\n USB Type-A, кнопки - 6");
            AddItem("Logitech3", 12878, "Logitech G502 HERO.png", "25600 dpi, светодиодный,\n USB Type-A, кнопки - 11");
            AddItem("Logitech4", 1420.50, "Logitech PRO X SUPERLIGHT.png", "25600 dpi, светодиодный,\n USB Type-A, кнопки - 5");
            AddItem("Razer", 1280.50, "Razer DeathAdder Essential.png", "6400 dpi, светодиодный,\n USB Type-A, кнопки - 5");

            AddItem("ZET", 9280, "ZET GAMING Edge.png", "7.1 Virtual, охватывающие,\n 20 Гц - 20000 Гц, 32Ω, проводной,\n кабель - 1 м");
            AddItem("Razerh2", 8000, "Razerh2 Barracuda X.png", "7.1 Virtual, для Nintendo Switch,\n PS5, Xbox Series X|S, охватывающие,\n 20 Гц - 20000 Гц, 32Ω, радиоканал,\n проводной, кабель - 1.3 м");
            AddItem("Razerh", 7300, "Razerh Kraken X Lite.png", "7.1 Virtual, для PS5,\n Xbox Series X|S, охватывающие,\n 12 Гц - 28000 Гц, 32Ω, проводной,\n кабель - 1.3 м");
            AddItem("Razerh3", 8990, "Razerh3 Blackshark V2 X.png", "7.1 Virtual, для PS5,\n Xbox Series X|S, охватывающие,\n 12 Гц - 28000 Гц, 32Ω, проводной,\n кабель - 1.3 м");
            AddItem("Logitechh", 7286, "Logitechh G PRO X Wireless.png", "7.1 Virtual, охватывающие,\n 20 Гц - 20000 Гц, 32Ω, радиоканал");

            AddItem("ZETk", 4280.50, "ZETk GAMING Blade.png", "Механическая Kailh Red,\n клавиш - 104, USB, черная");
            AddItem("Razerk", 4280.50, "Razerk BlackWidow V3.png", "Механическая Razer Yellow,\n клавиш - 105, USB, черная");
            AddItem("Logitechk", 4280.50, "Logitechk G413 TKL SE.png", "Механическая Kailh Brown,\n клавиш - 87, USB, черная");
            AddItem("Dark Project", 4280.50, "Dark Project KD87A Gateron Teal Cap.png", "Механическая Gateron Cap Teal,\n клавиш - 87, USB, белая");
        }


        //Очистка определённого элемента из корзины
        private void gunaGradientButton7_Click(object sender, EventArgs e)
        {
            int delet = grid.SelectedCells[0].RowIndex;
            grid.Rows.RemoveAt(delet);
            CalculateTotal();
        }

        //Очистка всей корзины
        private void gunaGradientButton9_Click(object sender, EventArgs e)
        {
            this.grid.Rows.Clear();
            CalculateTotal();
        }

        //Поиск
        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            foreach (var item in pnl.Controls)
            {
                var wdg = (Widge)item;
                wdg.Visible = wdg.lblTitle.Text.ToLower().ToLower().Contains(Finder.Text.Trim().ToLower());
            }
        }

        //Переход к оплате
        private void Pay_button_Click(object sender, EventArgs e)
        {
            PayForm f2 = new PayForm();
            string s = lblToT.Text;
            f2.label1.Text = s;
            f2.Show();
        }
    }
}
        
    

      
    

