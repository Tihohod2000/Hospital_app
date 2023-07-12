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
    public partial class Keyboard : Form
    {

        public bool menu_open = true;
        public Keyboard()
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
            AddItem("ZETk", 4280.50, "ZETk GAMING Blade.png", "Механическая Kailh Red,\n клавиш - 104, USB, черная");
            AddItem("Razerk", 4280.50, "Razerk BlackWidow V3.png", "Механическая Razer Yellow,\n клавиш - 105, USB, черная");
            AddItem("Logitechk", 4280.50, "Logitechk G413 TKL SE.png", "Механическая Kailh Brown,\n клавиш - 87, USB, черная");
            AddItem("Dark Project", 4280.50, "Dark Project KD87A Gateron Teal Cap.png", "Механическая Gateron Cap Teal,\n клавиш - 87, USB, белая");

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
        
    

      
    

