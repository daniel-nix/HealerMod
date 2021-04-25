using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;

namespace HealerMod.Projectiles
{
    class DamageBolt : HealingProjectile
    {
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            base.OnHitNPC(target, damage, knockback, crit);
        }

        public override Color? GetAlpha(Color lightColor)
        {
            return Color.Red;
        }
    }
}
