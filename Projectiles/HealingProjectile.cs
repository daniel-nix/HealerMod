using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HealerMod.Projectiles
{
    class HealingProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Healing Projectile");
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.WaterBolt);
            aiType = ProjectileID.WaterBolt;
        }

        public override Color? GetAlpha(Color lightColor)
        {
            return Color.Red;
        }
    }
}
