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
    public partial class WealdBosses : Form
    {
        public WealdBosses()
        {
            InitializeComponent();
        }

        private void Boss1Button_Click(object sender, EventArgs e)
        {
            hp.Text = $"---";
            hpStygian.Text = $"---";
            dodge.Text = $"% ---";
            protection.Text = $"% ---";
            speed.Text = $"---";
            stunResist.Text = $"% ---";
            blightResist.Text = $"% ---";
            bleedResist.Text = $"% ---";
            debuffResist.Text = $"% ---";
            moveResist.Text = $"% ---";

            BossPicture.Image = Properties.Resources.Hag;
            BossName.Text = "Hag";

            BossStrategy.Text = "For this fight you have to target the 3rd and 4th ranks, she \nis pretty weak by herself so it's a good idea to ignore the\nhero in the cauldron (unless it's your main damage dealer). \nHellions are great to consider to this fight, since she is weak to \nbleed and her hard-hitting Iron Swan can be used more \nfrequently. Remember when your hero is placed\nin the cauldron, your heroes fill the gaps, so make sure they\ncan still hit her.";
            //BossStrategy.Text = "The Prophet will remain in rank 4 for the duration of the \nfight, he is extremely hard to move with a move resist of %300\n. His lack of Protection makes him vulnerable to rank 4 \nattacks like from Hellion and Arbalest. In general\nmarking teams work great against the prophet, aswell as \nbleed and blight due to low resistances. Stacking damage \ndebuffs is also reccomended, as it will lessen the damage from \nRubble of Ruin. Speaking of Rubble, it's important to guard \nyour weaker teammates from the devastating effect, \nHoundmaster and Man at arms are good to consider. If \nyou're feeling risky, you can try keep the prophet alive \nwhile you kill his pews, giving you a hefty gold bonus for each \none destroyed. Stress damage is something you don't need to\nworry about, so Jester and Crusafer aren't needed.";


            

            easyButton1.Visible = true;
            mediumButton1.Visible = true;
            hardButton1.Visible = true;
            easyButton2.Visible = false;
            mediumButton2.Visible = false;
            hardButton2.Visible = false;
            StatsStatment.Visible = true;
            StratStatement.Visible = true;
            BossName.Visible = true;
            HPStatement.Visible = true;
            HPStygStatement.Visible = true;
            DodgeStatement.Visible = true;
            ProtStatement.Visible = true;
            SpeedStatement.Visible = true;
            StunStatement.Visible = true;
            BlightStatement.Visible = true;
            BleedStatement.Visible = true;
            DebuffStatement.Visible = true;
            MoveStatement.Visible = true;
            hp.Visible = true;
            hpStygian.Visible = true;
            dodge.Visible = true;
            protection.Visible = true;
            speed.Visible = true;
            stunResist.Visible = true;
            blightResist.Visible = true;
            bleedResist.Visible = true;
            debuffResist.Visible = true;
            moveResist.Visible = true;
            BossStrategy.Visible = true;
            OtherBoss.Visible = false;
        }

        private void Boss2Button_Click(object sender, EventArgs e)
        {
            hp.Text = $"---";
            hpStygian.Text = $"---";
            dodge.Text = $"% ---";
            protection.Text = $"% ---";
            speed.Text = $"---";
            stunResist.Text = $"% ---";
            blightResist.Text = $"% ---";
            bleedResist.Text = $"% ---";
            debuffResist.Text = $"% ---";
            moveResist.Text = $"% ---";

            BossPicture.Image = Properties.Resources.Canon;
            BossName.Text = "B. Pounder";

            BossStrategy.Text = "Do NOT let the matchman take a turn, honestly you \nprevent this and this fight is extremely easy. It's importnt\nto have a party that can hit all ranks. Luckily, the matchman\nhas incredibly low speed, and will always go last.";
            //BossStrategy.Text = "The Prophet will remain in rank 4 for the duration of the \nfight, he is extremely hard to move with a move \nresist of %300. His lack of Protection makes him vulnerable\nto rank 4 attacks like from Hellion and Arbalest. In general\nmarking teams work great against the prophet, aswell as \nbleed and blight due to low resistances. Stacking damage \ndebuffs is also reccomended, as it will lessen the damage from \nRubble of Ruin. Speaking of Rubble, it's important to guard \nyour weaker teammates from the devastating effect, \nHoundmaster and Man at arms are good to consider. If \nyou're feeling risky, you can try keep the prophet alive \nwhile you kill his pews, giving you a hefty gold bonus for each \none destroyed. Stress damage is something you don't need to\nworry about, so Jester and Crusafer aren't needed.";




            easyButton1.Visible = true;
            mediumButton1.Visible = true;
            hardButton1.Visible = true;
            easyButton2.Visible = false;
            mediumButton2.Visible = false;
            hardButton2.Visible = false;
            StatsStatment.Visible = true;
            StratStatement.Visible = true;
            BossName.Visible = true;
            HPStatement.Visible = true;
            HPStygStatement.Visible = true;
            DodgeStatement.Visible = true;
            ProtStatement.Visible = true;
            SpeedStatement.Visible = true;
            StunStatement.Visible = true;
            BlightStatement.Visible = true;
            BleedStatement.Visible = true;
            DebuffStatement.Visible = true;
            MoveStatement.Visible = true;
            hp.Visible = true;
            hpStygian.Visible = true;
            dodge.Visible = true;
            protection.Visible = true;
            speed.Visible = true;
            stunResist.Visible = true;
            blightResist.Visible = true;
            bleedResist.Visible = true;
            debuffResist.Visible = true;
            moveResist.Visible = true;
            BossStrategy.Visible = true;
            OtherBoss.Visible = false;
        }

        private void easyButton1_Click(object sender, EventArgs e)
        {
            Boss HagE= new Boss();
            HagE.Health = 66;
            HagE.HealthStygian = 80;
            HagE.Dodge = 5;
            HagE.Protection = 0;
            HagE.Speed = 5;
            HagE.StunResist = 100;
            HagE.BlightResist = 60;
            HagE.BleedResist = 20;
            HagE.DebuffResist = 40;
            HagE.MoveResist = 200;

            hp.Text = $"{HagE.Health}";
            hpStygian.Text = $"{HagE.HealthStygian}";
            dodge.Text = $"%{HagE.Dodge}";
            protection.Text = $"%{HagE.Protection}";
            speed.Text = $"{HagE.Speed}";
            stunResist.Text = $"%{HagE.StunResist}";
            blightResist.Text = $"%{HagE.BlightResist}";
            bleedResist.Text = $"%{HagE.BleedResist}";
            debuffResist.Text = $"%{HagE.DebuffResist}";
            moveResist.Text = $"%{HagE.MoveResist}";
        }

        private void mediumButton1_Click(object sender, EventArgs e)
        {
            Boss HagM = new Boss();
            HagM.Health = 99;
            HagM.HealthStygian = 119;
            HagM.Dodge = 13.75;
            HagM.Protection = 0;
            HagM.Speed = 6;
            HagM.StunResist = 120;
            HagM.BlightResist = 80;
            HagM.BleedResist = 40;
            HagM.DebuffResist = 60;
            HagM.MoveResist = 220;

            hp.Text = $"{HagM.Health}";
            hpStygian.Text = $"{HagM.HealthStygian}";
            dodge.Text = $"%{HagM.Dodge}";
            protection.Text = $"%{HagM.Protection}";
            speed.Text = $"{HagM.Speed}";
            stunResist.Text = $"%{HagM.StunResist}";
            blightResist.Text = $"%{HagM.BlightResist}";
            bleedResist.Text = $"%{HagM.BleedResist}";
            debuffResist.Text = $"%{HagM.DebuffResist}";
            moveResist.Text = $"%{HagM.MoveResist}";
        }

        private void hardButton1_Click(object sender, EventArgs e)
        {
            Boss HagH = new Boss();
            HagH.Health = 135;
            HagH.HealthStygian = 162;
            HagH.Dodge = 27.5;
            HagH.Protection = 0;
            HagH.Speed = 7;
            HagH.StunResist = 145;
            HagH.BlightResist = 105;
            HagH.BleedResist = 65;
            HagH.DebuffResist = 85;
            HagH.MoveResist = 245;

            hp.Text = $"{HagH.Health}";
            hpStygian.Text = $"{HagH.HealthStygian}";
            dodge.Text = $"%{HagH.Dodge}";
            protection.Text = $"%{HagH.Protection}";
            speed.Text = $"{HagH.Speed}";
            stunResist.Text = $"%{HagH.StunResist}";
            blightResist.Text = $"%{HagH.BlightResist}";
            bleedResist.Text = $"%{HagH.BleedResist}";
            debuffResist.Text = $"%{HagH.DebuffResist}";
            moveResist.Text = $"%{HagH.MoveResist}";
        }

        private void easyButton2_Click(object sender, EventArgs e)
        {
            Boss CanE = new Boss();
            CanE.Health = 76;
            CanE.HealthStygian = 92;
            CanE.Dodge = 0;
            CanE.Protection = 45;
            CanE.Speed = 0;
            CanE.StunResist = 200;
            CanE.BlightResist = 200;
            CanE.BleedResist = 200;
            CanE.DebuffResist = 200;
            CanE.MoveResist = 100;

            hp.Text = $"{CanE.Health}";
            hpStygian.Text = $"{CanE.HealthStygian}";
            dodge.Text = $"%{CanE.Dodge}";
            protection.Text = $"%{CanE.Protection}";
            speed.Text = $"{CanE.Speed}";
            stunResist.Text = $"%{CanE.StunResist}";
            blightResist.Text = $"%{CanE.BlightResist}";
            bleedResist.Text = $"%{CanE.BleedResist}";
            debuffResist.Text = $"%{CanE.DebuffResist}";
            moveResist.Text = $"%{CanE.MoveResist}";
        }

        private void mediumButton2_Click(object sender, EventArgs e)
        {
            Boss CanM = new Boss();
            CanM.Health = 114;
            CanM.HealthStygian = 137;
            CanM.Dodge = 8.75;
            CanM.Protection = 45;
            CanM.Speed = 1;
            CanM.StunResist = 220;
            CanM.BlightResist = 220;
            CanM.BleedResist = 220;
            CanM.DebuffResist = 200;
            CanM.MoveResist = 120;

            hp.Text = $"{CanM.Health}";
            hpStygian.Text = $"{CanM.HealthStygian}";
            dodge.Text = $"%{CanM.Dodge}";
            protection.Text = $"%{CanM.Protection}";
            speed.Text = $"{CanM.Speed}";
            stunResist.Text = $"%{CanM.StunResist}";
            blightResist.Text = $"%{CanM.BlightResist}";
            bleedResist.Text = $"%{CanM.BleedResist}";
            debuffResist.Text = $"%{CanM.DebuffResist}";
            moveResist.Text = $"%{CanM.MoveResist}";
        }

        private void hardButton2_Click(object sender, EventArgs e)
        {
            Boss CanH = new Boss();
            CanH.Health = 156;
            CanH.HealthStygian = 188;
            CanH.Dodge = 22.5;
            CanH.Protection = 2;
            CanH.Speed = 2;
            CanH.StunResist = 245;
            CanH.BlightResist = 245;
            CanH.BleedResist = 245;
            CanH.DebuffResist = 245;
            CanH.MoveResist = 145;

            hp.Text = $"{CanH.Health}";
            hpStygian.Text = $"{CanH.HealthStygian}";
            dodge.Text = $"%{CanH.Dodge}";
            protection.Text = $"%{CanH.Protection}";
            speed.Text = $"{CanH.Speed}";
            stunResist.Text = $"%{CanH.StunResist}";
            blightResist.Text = $"%{CanH.BlightResist}";
            bleedResist.Text = $"%{CanH.BleedResist}";
            debuffResist.Text = $"%{CanH.DebuffResist}";
            moveResist.Text = $"%{CanH.MoveResist}";
        }
    }
}
