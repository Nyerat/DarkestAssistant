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
    public partial class Warrens : Form
    {
        public Warrens()
        {
            InitializeComponent();
            Item1Desc.Text = "A good amount of Medicinal Herbs\nis great since they can be used for \nthree curios (Dinner Cart, Makeshift \nTable, and Moonshine Barrel.";
            Item2Desc.Text = "Bandages are very useful due\nto the prevalence of bleed traps.\nThey can also be used on the \nRack of Blades curios.";
            Item3Desc.Text = "Holy Water is occasionally used\nfor Altars and Piles of Bones.";
            Item4Desc.Text = "Torches are less useful here since\n the corridors are shorter, but they \ncan be used on Pile of Scrolls to purge \na negative quirk.";
            Desc.Text = "Warrens is host to mostly swinefolk, trinkets that deal bonus damage to beasts and humans are useful.\nLook out for diseases and stress mostly.";

            GoodHeroes.Text = "Houndmaster is fantastic for the Warrens, for multiple reasons. \nHe deals bonus damage to beasts (most common archtype in Warrens), \nscouts well (small corridors gives better results from scouting), \nand relieves stress (Warrens' enemies have a ton of stress dealing attacks).\nOther than that, Bounty Hunter also gets bonus damage, since the swinefolk \nare beast/human hybrid, and enemies have low bleed resist so bringing heroes who \ndeal bleeding is beneficial.";
            BadHeroes.Text = "The two most common enemies in the Warrens have high Prot, so\nheroes that deal raw damage are not suggested. The swinefolk's high blight\nresist also makes bringing blight dealers a bad idea.";
            PersonalHeroes.Text = "The Highway Man is a good alternative to Houndmaster. He\ncan deal bleed damage, and has a high scouting chance as well, I personally\nput him in 1 and use Point Blank Shot first round, as you may\nget lucky and kill their 1 with a crit. Shieldbreaker is also noteworth,\nas she does raw damage not affected by prot, and can hit 4 like Hellion. The\nPlague Doctor can bleed, and can stun multiple enemies due to a low stun resist on\nthe swinefolk.";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WarrensBoss WarrensBossForms = new WarrensBoss();
            WarrensBossForms.ShowDialog();
        }
    }
}
