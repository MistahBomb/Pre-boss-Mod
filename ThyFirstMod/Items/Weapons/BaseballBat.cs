
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThyFirstMod.Items.Weapons
{
	public class BaseballBat : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Press Right Click To Fire Baseball Balls");
		}

		public override void SetDefaults()
		{
			item.damage = 20;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = 1000;
			item.rare = ItemRarityID.Blue;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.useTime = 45;
				item.useAnimation = 45;
				item.damage = 20;
				item.shoot = mod.ProjectileType("BaseBall"); 
				item.shootSpeed = 10f;
				
				
				

			}
			else
			{
				item.useStyle = ItemUseStyleID.SwingThrow;
				item.useTime = 40;
				item.useAnimation = 40;
				item.damage = 20;
				item.shoot = ProjectileID.None;
			}
			return base.CanUseItem(player);
		}


		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Fix the speedX and Y to point them horizontally.

			// Add random Rotation
			Vector2 speed = new Vector2(speedX, speedY);
			speed = speed.RotatedByRandom(MathHelper.ToRadians(30));
			// Change the damage since it is based off the weapons damage and is too high
			damage = (int)(damage * 1.2f);
			speedX = speed.X;
			speedY = speed.Y;
			return true;
		}
	}
}