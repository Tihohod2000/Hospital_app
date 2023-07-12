using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_of_store.Components
{
    public partial class Widge : UserControl
    {

        private double _cost;

        public event EventHandler OnSelect = null;
        public Widge()
        {
            InitializeComponent();
        }

        public string Title { get => lblTitle.Text; set => lblTitle.Text = value; }
       
        public double Cost { get => _cost; set { _cost = value; lblCost.Text = _cost.ToString("C2"); } }
        public Image Icon { get => imgImage.Image; set => imgImage.Image = value; }

        public string Info { get => lblInfo.Text; set => lblInfo.Text = value; }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }
    }
}
