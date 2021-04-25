using HealerMod.Projectiles;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HealerMod.Items
{
	public class HealingBolt : ModItem
	{
		private int healProjectileType;
		private int damageProjectileType;
		private int currentProjectileType;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Healing Bolt");
			Tooltip.SetDefault("Shoots damaging bolts on left click and healing bolts on right click.");
		}
		public override void SetDefaults()
		{
			healProjectileType = ModContent.ProjectileType<HealBolt>();
			damageProjectileType = ModContent.ProjectileType<DamageBolt>();
			currentProjectileType = damageProjectileType;
			item.damage = 50;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = currentProjectileType;
			item.shootSpeed = 4;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool AltFunctionUse(Player player)
		{
			if (this.currentProjectileType == damageProjectileType) {
				this.currentProjectileType = healProjectileType;
            } else
            {
				this.currentProjectileType = damageProjectileType;
            }
			item.shoot = this.currentProjectileType;
			mod.Logger.Info(this.currentProjectileType);
			return false;
        }
    }
}
