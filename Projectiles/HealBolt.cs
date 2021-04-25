using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;

namespace HealerMod.Projectiles
{
    class HealBolt : HealingProjectile
    {
        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            target.HealEffect(damage);
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) { }

        public override Color? GetAlpha(Color lightColor)
        {
            return Color.Green;
        }
    }
}
