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
    public partial class WarrensBoss : Form
    {
        public WarrensBoss()
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

            BossPicture.Image = Properties.Resources.SwinePrince;
            BossName.Text = "Swine Prince";

            BossStrategy.Text = "Swine Prince is always taking up ranks 1-3 with Wilbur taking \nrank 4. Attacking Wilbur is ill-advised, as the Swine Prince\nwill strike back immediately. Wilbur will mark units\nfor Swine Prince to attack, so using Arbalest to clear marks\nis a good idea. Once Swine Prince is dead, Wilbur will\nsqueal constantly, which deals stress damage to the part and\nhas a chance to stun.";
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

            BossPicture.Image = Properties.Resources.Flesh;
            BossName.Text = "Flesh";

            BossStrategy.Text = "Damage over time is king in this fight, since all four targets\nshare a single health bar. DOTs that hit multiple\ntargets are even better cause of this, Houndmaster, Jester\nandPlague Doctor all are ones to note. If the heart appears\nattack it as it takes full damage. For defense, try bringing\nhigh resistances to blight, bleed, and stun.";
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
            Boss SPE = new Boss();
            SPE.Health = 132;
            SPE.HealthStygian = 159;
            SPE.Dodge = 0;
            SPE.Protection = 0;
            SPE.Speed = 0;
            SPE.StunResist = 100;
            SPE.BlightResist = 0;
            SPE.BleedResist = 0;
            SPE.DebuffResist = 20;
            SPE.MoveResist = 100;

            hp.Text = $"{SPE.Health}";
            hpStygian.Text = $"{SPE.HealthStygian}";
            dodge.Text = $"%{SPE.Dodge}";
            protection.Text = $"%{SPE.Protection}";
            speed.Text = $"{SPE.Speed}";
            stunResist.Text = $"%{SPE.StunResist}";
            blightResist.Text = $"%{SPE.BlightResist}";
            bleedResist.Text = $"%{SPE.BleedResist}";
            debuffResist.Text = $"%{SPE.DebuffResist}";
            moveResist.Text = $"%{SPE.MoveResist}";
        }

        private void mediumButton1_Click(object sender, EventArgs e)
        {
            Boss SPM = new Boss();
            SPM.Health = 198;
            SPM.HealthStygian = 238;
            SPM.Dodge = 8.75;
            SPM.Protection = 0;
            SPM.Speed = 1;
            SPM.StunResist = 120;
            SPM.BlightResist = 0;
            SPM.BleedResist = 0;
            SPM.DebuffResist = 40;
            SPM.MoveResist = 120;

            hp.Text = $"{SPM.Health}";
            hpStygian.Text = $"{SPM.HealthStygian}";
            dodge.Text = $"%{SPM.Dodge}";
            protection.Text = $"%{SPM.Protection}";
            speed.Text = $"{SPM.Speed}";
            stunResist.Text = $"%{SPM.StunResist}";
            blightResist.Text = $"%{SPM.BlightResist}";
            bleedResist.Text = $"%{SPM.BleedResist}";
            debuffResist.Text = $"%{SPM.DebuffResist}";
            moveResist.Text = $"%{SPM.MoveResist}";
        }

        private void hardButton1_Click(object sender, EventArgs e)
        {
            Boss SPH = new Boss();
            SPH.Health = 271;
            SPH.HealthStygian = 326;
            SPH.Dodge = 22.5;
            SPH.Protection = 0;
            SPH.Speed = 2;
            SPH.StunResist = 145;
            SPH.BlightResist = 45;
            SPH.BleedResist = 45;
            SPH.DebuffResist = 65;
            SPH.MoveResist = 145;

            hp.Text = $"{SPH.Health}";
            hpStygian.Text = $"{SPH.HealthStygian}";
            dodge.Text = $"%{SPH.Dodge}";
            protection.Text = $"%{SPH.Protection}";
            speed.Text = $"{SPH.Speed}";
            stunResist.Text = $"%{SPH.StunResist}";
            blightResist.Text = $"%{SPH.BlightResist}";
            bleedResist.Text = $"%{SPH.BleedResist}";
            debuffResist.Text = $"%{SPH.DebuffResist}";
            moveResist.Text = $"%{SPH.MoveResist}";
        }

        private void easyButton2_Click(object sender, EventArgs e)
        {
            Boss FleshE = new Boss();
            FleshE.Health = 100;
            FleshE.HealthStygian = 120;
            FleshE.Dodge = 0;
            FleshE.Protection = 50;
            FleshE.Speed = 5;
            FleshE.StunResist = 50;
            FleshE.BlightResist = 20;
            FleshE.BleedResist = 40;
            FleshE.DebuffResist = 20;
            FleshE.MoveResist = 200;

            hp.Text = $"{FleshE.Health}";
            hpStygian.Text = $"{FleshE.HealthStygian}";
            dodge.Text = $"%{FleshE.Dodge}";
            protection.Text = $"%{FleshE.Protection}";
            speed.Text = $"{FleshE.Speed}";
            stunResist.Text = $"%{FleshE.StunResist}";
            blightResist.Text = $"%{FleshE.BlightResist}";
            bleedResist.Text = $"%{FleshE.BleedResist}";
            debuffResist.Text = $"%{FleshE.DebuffResist}";
            moveResist.Text = $"%{FleshE.MoveResist}";
        }

        private void mediumButton2_Click(object sender, EventArgs e)
        {
            Boss FleshM = new Boss();
            FleshM.Health = 152;
            FleshM.HealthStygian = 184;
            FleshM.Dodge = 8.75;
            FleshM.Protection = 60;
            FleshM.Speed = 6;
            FleshM.StunResist = 70;
            FleshM.BlightResist = 40;
            FleshM.BleedResist = 60;
            FleshM.DebuffResist = 40;
            FleshM.MoveResist = 220;

            hp.Text = $"{FleshM.Health}";
            hpStygian.Text = $"{FleshM.HealthStygian}";
            dodge.Text = $"%{FleshM.Dodge}";
            protection.Text = $"%{FleshM.Protection}";
            speed.Text = $"{FleshM.Speed}";
            stunResist.Text = $"%{FleshM.StunResist}";
            blightResist.Text = $"%{FleshM.BlightResist}";
            bleedResist.Text = $"%{FleshM.BleedResist}";
            debuffResist.Text = $"%{FleshM.DebuffResist}";
            moveResist.Text = $"%{FleshM.MoveResist}";
        }

        private void hardButton2_Click(object sender, EventArgs e)
        {
            Boss FleshH = new Boss();
            FleshH.Health = 204;
            FleshH.HealthStygian = 248;
            FleshH.Dodge = 22.5;
            FleshH.Protection = 0;
            FleshH.Speed = 7;
            FleshH.StunResist = 95;
            FleshH.BlightResist = 65;
            FleshH.BleedResist = 85;
            FleshH.DebuffResist = 65;
            FleshH.MoveResist = 245;

            hp.Text = $"{FleshH.Health}";
            hpStygian.Text = $"{FleshH.HealthStygian}";
            dodge.Text = $"%{FleshH.Dodge}";
            protection.Text = $"%{FleshH.Protection}";
            speed.Text = $"{FleshH.Speed}";
            stunResist.Text = $"%{FleshH.StunResist}";
            blightResist.Text = $"%{FleshH.BlightResist}";
            bleedResist.Text = $"%{FleshH.BleedResist}";
            debuffResist.Text = $"%{FleshH.DebuffResist}";
            moveResist.Text = $"%{FleshH.MoveResist}";
        }
    }
}
