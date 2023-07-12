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
    public partial class Headphones : Form
    {

        public bool menu_open = true;
        public Headphones()
        {
            InitializeComponent();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            //docker.WindowsState
        }

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

           
        }



        private void FrmMain_Load(object sender, EventArgs e)
        {
            AddItem("ZET", 9280, "ZET GAMING Edge.png", "7.1 Virtual, охватывающие,\n 20 Гц - 20000 Гц, 32Ω, проводной,\n кабель - 1 м");
            AddItem("Razerh2", 8000, "Razerh2 Barracuda X.png", "7.1 Virtual, для Nintendo Switch,\n PS5, Xbox Series X|S, охватывающие,\n 20 Гц - 20000 Гц, 32Ω, радиоканал,\n проводной, кабель - 1.3 м");
            AddItem("Razerh", 7300, "Razerh Kraken X Lite.png", "7.1 Virtual, для PS5,\n Xbox Series X|S, охватывающие,\n 12 Гц - 28000 Гц, 32Ω, проводной,\n кабель - 1.3 м");
            AddItem("Razerh3", 8990, "Razerh3 Blackshark V2 X.png", "7.1 Virtual, для PS5,\n Xbox Series X|S, охватывающие,\n 12 Гц - 28000 Гц, 32Ω, проводной,\n кабель - 1.3 м");
            AddItem("Logitechh", 7286, "Logitechh G PRO X Wireless.png", "7.1 Virtual, охватывающие,\n 20 Гц - 20000 Гц, 32Ω, радиоканал");

        }



        /*private void Finder_TextChanged_1(object sender, EventArgs e)
        {
            foreach (var item in pnl.Controls)
            {
                var wdg = (Widge)item;
                wdg.Visible = wdg.lblTitle.Text.ToLower().ToLower().Contains(Finder.Text.Trim().ToLower());
            }
        }*/

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            foreach (var item in pnl.Controls)
            {
                var wdg = (Widge)item;
                wdg.Visible = wdg.lblTitle.Text.ToLower().ToLower().Contains(Finder.Text.Trim().ToLower());
            }
        }

        
    }
}
        
    

      
    

