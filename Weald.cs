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
    public partial class Weald : Form
    {
        public Weald()
        {
            InitializeComponent();
            Item1Desc.Text = "Bandages are good for extra loot from\nMummified Remains and Spiderwebs,\nas well as enemies that inflict bleed.";
            Item2Desc.Text = "Antivenom protects heroes from old\ntrees, also useful for disarming \nLeft Luggage. Ontop of that, many \nenemies inflict blight here.";
            Item3Desc.Text = "Bring extra Shovels because blockages\nare more frequent here, and leftover\nshovels can be used on Shallow Graves\n for loot.";
            Item4Desc.Text = "Bring a few Holy Waters incase you run\ninto a Effigy (positive quirk), \nFountain (stress heal), or an \nAltar (remove negative quirk).";
            Item5Desc.Text = "Medicinal Herbs can be used on \nCarcasses to harvest food safely, and \ncan remove With debuffs at higher \nranks.";
            Desc.Text = "If unprepared, the Weald can be extremely deadly. DEEDS are the most frequent resource here.\nUnclean Giant hits hard, kill him quick. Slimes can merge together, try to get rid of them as well. Dogs can spread disease.";

            GoodHeroes.Text = "I find Plague Doctor the strongest hero in Weald, putting her in 3\nis fantastic due to enemies having low bleed resist (Incision) and her \nBattlefield Medicine is great against the large amount of DOTs. Any hero\nwith bleed skills are good, same with Move and Debuff as they have\nlow resistances against that as well. For pure damage, Bounty Hunter \nworks well since swinefolk are beast/human hybrids, and his other skills \nare bleed, move, and stun are strong against the enemies here.";
            BadHeroes.Text = "The only thing really worth mentioning is enemies in Weald have a\nhigh blight resist, so try to avoid bringing heroes who focus in inflicting \nblight.";
            PersonalHeroes.Text = "Since enemies have low resistances to everything besides blight,\nI try to bring debuff heavy characters to make the opposition useless.\nMan at arms can bellow groups with ease and also brings a reliable \nstun. Occultist is great due to a prominent amount of Eldritch enemies\nand his damage debuff is fantastic against tree smashes. Leper has \na chance to get rabies from the dogs here, which I like on him.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WealdBosses WealdBossesForm = new WealdBosses();
            WealdBossesForm.ShowDialog();
        }
    }
}
