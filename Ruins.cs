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
    public partial class Ruins : Form
    {
        public Ruins()
        {
            InitializeComponent();
            Item1Desc.Text = "Holy water is very useful for\nthe ruins, since there is 5\ncurios that benefit from it.";
            Item2Desc.Text = "Like Holy Water, Skeleton Keys\nare very useful because of\na large amount of curios that are \nlocked.";
            Item3Desc.Text = "Medicinal Herbs have a small\namount of utility from iron maidens\nand alchemy tables.";
            Item4Desc.Text = "Bandages and Antivenom are\nnot quite as useful due to lack of\nDOT attacks and 0 curio applications.";
            Item5Desc.Text = "Consider bringing more food\nas there isn't any food related\ncurios in the Ruins.";
            Desc.Text = "The Ruins is the first and easiest of the dungeons to explore.\nBone Bearers should be killed ASAP. Deal with stress dealers before they become a menance.";

            GoodHeroes.Text = "Crusader is the best class to bring into the Ruins, hands down. His\nbonus damage against undead is amazing, and if needed he can \nstress heal those tempting goblets. Special notice for hero that can \ninflict blight, as most enemies here have low resist to it.";
            BadHeroes.Text = "Enemies in the Ruins cannot be bled, so remember to take of those \nskills if you have to use these heroes, also keep in mind Bounty Hunter \nwill not benefit from the bonus damage against humans.";
            PersonalHeroes.Text = "Ruins may be the easiest dungeon to explore, but the amount of\ncrit Tempting Goblets you will receive might make you question that,\nI try to bring a reliable stress healer and characters who can \nhit the 3 and 4 ranks reliably.";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RuinsBosses RuinsBossesForm = new RuinsBosses();
            RuinsBossesForm.ShowDialog();
        }
    }
}
