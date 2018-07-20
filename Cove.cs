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
    public partial class Cove : Form
    {
        public Cove()
        {
            InitializeComponent();
            Item1Desc.Text = "Medicinal Herbs are extremely\nuseful for debuff traps and attacks, \nalso for the Eerie Coral curios, \nwhich can cure a negative quirk.";
            Item2Desc.Text = "Bringing a few extra Shovels\nis a good idea for extra loot from\nchests and oysters.";
            Item3Desc.Text = "There is a good amount of bleed\nattacks in the Cove, espcially\nfrom Uca Crusher's pinch.";
            Item4Desc.Text = "Holy Water might be useful for \nFish Idols.";
            Desc.Text = "The Cove is the second to last dungeon and is extremely tough.\nKill Thralls quick or they'll explode, and bandage pinches from Uca's quickly.";

            GoodHeroes.Text = "The Occultist and Man at arms are both great for the Cove. Occultist\nhas a myriad of eldritch enemies to harm, and low debuff resist makes\nhim useful for keeping targets locked down. Man at arms can guard the \nteam with high prot to negate hard hitting attacks, while blight dealers \ncan wear down high priority enemies at 3 and 4 due to a low resistance \nto it.";
            BadHeroes.Text = "Bleed is more useless here than blight, that's really it.";
            PersonalHeroes.Text = "Crusader can't guard his allies, but he can mark himself and gain\na high prot, like Man at arms. Also, he and the Jester can single target\nstress heal effectively, which is strong against Shamans. Graverobber\ncan also deal blight, stun, and debuff enemies. Hellion and Leper can \nheal and protect themselves against threats in the Cove (bleed and \ndebuffs respectively).";

        }
    }
}
