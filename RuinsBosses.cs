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

    public partial class RuinsBosses : Form
    {


        public RuinsBosses()
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

            BossPicture.Image = Properties.Resources.Necromancer;
            BossName.Text = "Necromancer";

            BossStrategy.Text = "The most reccomended way to deal with this boss is to have a\ncharacter deal with the skeleton adds as they spawn, while \nanother stacks bleed and blight onto the Necromancer. \nCrusader is good for this reason, cause of his bonest undead \ndamage. Houndmaster is also good because he can stack \nbleed to any rank. Occultist and Bounty Hunter can drag the \nnecromancer to the front for your heavy hitters aswell. This \nfight gets harder later on due to the addition to armored \nenemies.";
            //BossStrategy.Text = "The Prophet will remain in rank 4 for the duration of the \nfight, he is extremely hard to move with a move \nresist of %300. His lack of Protection makes him vulnerable\nto rank 4 attacks like from Hellion and Arbalest. In general\nmarking teams work great against the prophet, aswell as \nbleed and blight due to low resistances. Stacking damage \ndebuffs is also reccomended, as it will lessen the damage from \nRubble of Ruin. Speaking of Rubble, it's important to guard \nyour weaker teammates from the devastating effect, \nHoundmaster and Man at arms are good to consider. If \nyou're feeling risky, you can try keep the prophet alive \nwhile you kill his pews, giving you a hefty gold bonus for each \none destroyed. Stress damage is something you don't need to\nworry about, so Jester and Crusafer aren't needed.";


            pews.Visible = false;
            pewm.Visible = false;
            pewl.Visible = false;

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

            BossPicture.Image = Properties.Resources.Prophet;
            BossName.Text = "Prophet";

            BossStrategy.Text = "The Prophet will remain in rank 4 for the duration of the \nfight, he is extremely hard to move with a move \nresist of %300. His lack of Protection makes him vulnerable\nto rank 4 attacks like from Hellion and Arbalest. In general\nmarking teams work great against the prophet, aswell as \nbleed and blight due to low resistances. Stacking damage \ndebuffs is also reccomended, as it will lessen the damage from \nRubble of Ruin. Speaking of Rubble, it's important to guard \nyour weaker teammates from the devastating effect, \nHoundmaster and Man at arms are good to consider. If \nyou're feeling risky, you can try keep the prophet alive \nwhile you kill his pews, giving you a hefty gold bonus for each \none destroyed. Stress damage is something you don't need to\nworry about, so Jester and Crusafer aren't needed.";
            //BossStrategy.Text = "The Prophet will remain in rank 4 for the duration of the \nfight, he is extremely hard to move with a move \nresist of %300. His lack of Protection makes him vulnerable\nto rank 4 attacks like from Hellion and Arbalest. In general\nmarking teams work great against the prophet, aswell as \nbleed and blight due to low resistances. Stacking damage \ndebuffs is also reccomended, as it will lessen the damage from \nRubble of Ruin. Speaking of Rubble, it's important to guard \nyour weaker teammates from the devastating effect, \nHoundmaster and Man at arms are good to consider. If \nyou're feeling risky, you can try keep the prophet alive \nwhile you kill his pews, giving you a hefty gold bonus for each \none destroyed. Stress damage is something you don't need to\nworry about, so Jester and Crusafer aren't needed.";

            pews.Visible = true;
            pewm.Visible = true;
            pewl.Visible = true;

            easyButton2.Visible = true;
            mediumButton2.Visible = true;
            hardButton2.Visible = true;
            easyButton1.Visible = false;
            mediumButton1.Visible = false;
            hardButton1.Visible = false;
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
            Boss NecromancerApprentice = new Boss();
            NecromancerApprentice.Health = 105;
            NecromancerApprentice.HealthStygian = 126;
            NecromancerApprentice.Dodge = 0;
            NecromancerApprentice.Protection = 0;
            NecromancerApprentice.Speed = 8;
            NecromancerApprentice.StunResist = 75;
            NecromancerApprentice.BlightResist = 20;
            NecromancerApprentice.BleedResist = 20;
            NecromancerApprentice.DebuffResist = 40;
            NecromancerApprentice.MoveResist = 25;

            hp.Text = $"{NecromancerApprentice.Health}";
            hpStygian.Text = $"{NecromancerApprentice.HealthStygian}";
            dodge.Text = $"%{NecromancerApprentice.Dodge}";
            protection.Text = $"%{NecromancerApprentice.Protection}";
            speed.Text = $"{NecromancerApprentice.Speed}";
            stunResist.Text = $"%{NecromancerApprentice.StunResist}";
            blightResist.Text = $"%{NecromancerApprentice.BlightResist}";
            bleedResist.Text = $"%{NecromancerApprentice.BleedResist}";
            debuffResist.Text = $"%{NecromancerApprentice.DebuffResist}";
            moveResist.Text = $"%{NecromancerApprentice.MoveResist}";
        }

        private void mediumButton1_Click(object sender, EventArgs e)
        {
            Boss Necromancer = new Boss();
            Necromancer.Health = 158;
            Necromancer.HealthStygian = 190;
            Necromancer.Dodge = 8.75;
            Necromancer.Protection = 0;
            Necromancer.Speed = 9;
            Necromancer.StunResist = 95;
            Necromancer.BlightResist = 40;
            Necromancer.BleedResist = 40;
            Necromancer.DebuffResist = 60;
            Necromancer.MoveResist = 45;

            hp.Text = $"{Necromancer.Health}";
            hpStygian.Text = $"{Necromancer.HealthStygian}";
            dodge.Text = $"%{Necromancer.Dodge}";
            protection.Text = $"%{Necromancer.Protection}";
            speed.Text = $"{Necromancer.Speed}";
            stunResist.Text = $"%{Necromancer.StunResist}";
            blightResist.Text = $"%{Necromancer.BlightResist}";
            bleedResist.Text = $"%{Necromancer.BleedResist}";
            debuffResist.Text = $"%{Necromancer.DebuffResist}";
            moveResist.Text = $"%{Necromancer.MoveResist}";
        }

        private void hardButton1_Click(object sender, EventArgs e)
        {
            Boss NecromancerLord = new Boss();
            NecromancerLord.Health = 215;
            NecromancerLord.HealthStygian = 258;
            NecromancerLord.Dodge = 22.50;
            NecromancerLord.Protection = 0;
            NecromancerLord.Speed = 10;
            NecromancerLord.StunResist = 120;
            NecromancerLord.BlightResist = 65;
            NecromancerLord.BleedResist = 65;
            NecromancerLord.DebuffResist = 85;
            NecromancerLord.MoveResist = 70;

            hp.Text = $"{NecromancerLord.Health}";
            hpStygian.Text = $"{NecromancerLord.HealthStygian}";
            dodge.Text = $"%{NecromancerLord.Dodge}";
            protection.Text = $"%{NecromancerLord.Protection}";
            speed.Text = $"{NecromancerLord.Speed}";
            stunResist.Text = $"%{NecromancerLord.StunResist}";
            blightResist.Text = $"%{NecromancerLord.BlightResist}";
            bleedResist.Text = $"%{NecromancerLord.BleedResist}";
            debuffResist.Text = $"%{NecromancerLord.DebuffResist}";
            moveResist.Text = $"%{NecromancerLord.MoveResist}";
        }

        private void easyButton2_Click(object sender, EventArgs e)
        {
            Boss SonorousProphet = new Boss();
            SonorousProphet.Health = 105;
            SonorousProphet.HealthStygian = 126;
            SonorousProphet.Dodge = 5;
            SonorousProphet.Protection = 0;
            SonorousProphet.Speed = 0;
            SonorousProphet.StunResist = 100;
            SonorousProphet.BlightResist = 0;
            SonorousProphet.BleedResist = 0;
            SonorousProphet.DebuffResist = 20;
            SonorousProphet.MoveResist = 300;

            hp.Text = $"{SonorousProphet.Health}";
            hpStygian.Text = $"{SonorousProphet.HealthStygian}";
            dodge.Text = $"%{SonorousProphet.Dodge}";
            protection.Text = $"%{SonorousProphet.Protection}";
            speed.Text = $"{SonorousProphet.Speed}";
            stunResist.Text = $"%{SonorousProphet.StunResist}";
            blightResist.Text = $"%{SonorousProphet.BlightResist}";
            bleedResist.Text = $"%{SonorousProphet.BleedResist}";
            debuffResist.Text = $"%{SonorousProphet.DebuffResist}";
            moveResist.Text = $"%{SonorousProphet.MoveResist}";
        }

        private void mediumButton2_Click(object sender, EventArgs e)
        {
            Boss FulminatingProphet = new Boss();
            FulminatingProphet.Health = 158;
            FulminatingProphet.HealthStygian = 190;
            FulminatingProphet.Dodge = 13.75;
            FulminatingProphet.Protection = 0;
            FulminatingProphet.Speed = 1;
            FulminatingProphet.StunResist = 120;
            FulminatingProphet.BlightResist = 20;
            FulminatingProphet.BleedResist = 20;
            FulminatingProphet.DebuffResist = 40;
            FulminatingProphet.MoveResist = 320;

            hp.Text = $"{FulminatingProphet.Health}";
            hpStygian.Text = $"{FulminatingProphet.HealthStygian}";
            dodge.Text = $"%{FulminatingProphet.Dodge}";
            protection.Text = $"%{FulminatingProphet.Protection}";
            speed.Text = $"{FulminatingProphet.Speed}";
            stunResist.Text = $"%{FulminatingProphet.StunResist}";
            blightResist.Text = $"%{FulminatingProphet.BlightResist}";
            bleedResist.Text = $"%{FulminatingProphet.BleedResist}";
            debuffResist.Text = $"%{FulminatingProphet.DebuffResist}";
            moveResist.Text = $"%{FulminatingProphet.MoveResist}";
        }

        private void hardButton2_Click(object sender, EventArgs e)
        {
            Boss GibberingProphet = new Boss();
            GibberingProphet.Health = 215;
            GibberingProphet.HealthStygian = 258;
            GibberingProphet.Dodge = 27.5;
            GibberingProphet.Protection = 0;
            GibberingProphet.Speed = 2;
            GibberingProphet.StunResist = 145;
            GibberingProphet.BlightResist = 45;
            GibberingProphet.BleedResist = 45;
            GibberingProphet.DebuffResist = 65;
            GibberingProphet.MoveResist = 345;

            hp.Text = $"{GibberingProphet.Health}";
            hpStygian.Text = $"{GibberingProphet.HealthStygian}";
            dodge.Text = $"%{GibberingProphet.Dodge}";
            protection.Text = $"%{GibberingProphet.Protection}";
            speed.Text = $"{GibberingProphet.Speed}";
            stunResist.Text = $"%{GibberingProphet.StunResist}";
            blightResist.Text = $"%{GibberingProphet.BlightResist}";
            bleedResist.Text = $"%{GibberingProphet.BleedResist}";
            debuffResist.Text = $"%{GibberingProphet.DebuffResist}";
            moveResist.Text = $"%{GibberingProphet.MoveResist}";
        }
    }

}
