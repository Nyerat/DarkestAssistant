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
    public partial class Courtyard : Form
    {
        public Courtyard()
        {
            InitializeComponent();
            Item1Desc.Text = "Holy Water can be used on fountains\nto boost resistance to Crimson Curse.\nDon't give it to Vampires though\nunless they are in Passive state.";
            Item2Desc.Text = "Torches will increase your Acc for one\nfight and also can be used against\nCocoons and Hives to reduce stress and \ngain tresure respectively, they are also \nneeded to pass Shifting Mist.";
            Item3Desc.Text = "Bandages can be used against Pile of \nStrange Bones.";
            Item4Desc.Text = "The Blood can be given to beggars for \nloot, and used to sedate infected heroes.";
            Item5Desc.Text = "Shovels are used on Caged Skeletons \nand Bloodflowers to get loot. Also \nnotably you can smash Wine Crates to \nget Firewood to extend trips.";
            Desc.Text = "You traverse the Courtyard by using pre-scouted patterns that are revealed at each room.\nLighting is considered to be at 75% for trinkets and the such. \nYour progress is saved when you leave but is considered a Defeat.";

            GoodHeroes.Text = "What's most important here is heroes that are self-reliant, as the Courtyard \nis a sparwling courtyard that is intended to be visited multiple times per \nquest. Stress healers are must, as you gain stress every square (The three \nstress healers also have good bleed damage, which Bloodsuckers are weak \nto). Vestal also like always is amazing, healing her team constantly.";
            BadHeroes.Text = "Occultist is pretty bad for your Courtyard trips, his unreliable heal is made\neven worse by the facts that enemies here lower bleed resist, there aren't any\neldritch to benefit from his damage as well. Blight is also weak because a \nhigh resistance, with Abominations being even worse cause of party wide stress.\nAntiquarians haven't come up much, as they are mostly used for loot runs,\nbut because you need reliable heroes, they aren't too good.";
            PersonalHeroes.Text = "Like stated before, self reliant heroes are key, so Crusader, Hellion,\nand Leper are pretty good due to their self buff and heals, special note to Hellion \nfor having bleed damage. Man at arms is pretty useful because of his team\nwide buffs and good enemy control, which can extend trips.";

        }
    }
}
