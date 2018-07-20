using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkestAssistant
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Disclaimer.Text = "All information here is gathered from the\nwiki and my own thoughts, if you have\nany issues with anything presented here \nplease contact me at neirninja@gmail.com \nthank you.";
        }

        private void RuinsInfo_Click(object sender, EventArgs e)
        {
            Ruins RuinsForm = new Ruins();
            RuinsForm.ShowDialog();
        }

        private void WealdInfo_Click(object sender, EventArgs e)
        {
            Weald WealdForm = new Weald();
            WealdForm.ShowDialog();
        }

        private void WarrensInfo_Click(object sender, EventArgs e)
        {
            Warrens WarrensForm = new Warrens();
            WarrensForm.ShowDialog();
        }

        private void CoveInfo_Click(object sender, EventArgs e)
        {
            Cove CoveForm = new Cove();
            CoveForm.ShowDialog();
        }

        private void CourtyardInfo_Click(object sender, EventArgs e)
        {
            Courtyard CourtyardForm = new Courtyard();
            CourtyardForm.ShowDialog();
        }
    }

    class Boss
    {
        public int Health { get; set; }
        public int HealthStygian { get; set; }
        public double Dodge { get; set; }
        public int Protection { get; set; }
        public int Speed { get; set; }

        public int StunResist { get; set; }
        public int BlightResist { get; set; }
        public int BleedResist { get; set; }
        public int DebuffResist { get; set; }
        public int MoveResist { get; set; }
    }

}
