using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThyFirstMod.Items.Weapons
{
	public class AcornLongBow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("WoodenClub"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'This probably won't plant anything'");
		}

		public override void SetDefaults() 
		{
            item.useTime = 50;
            item.useAnimation = 35;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.UseSound = SoundID.Item5;
            item.value = 100;
            item.rare = ItemRarityID.White;
            item.width = 80;
            item.height = 100;

            item.noMelee = true;
            item.ranged = true;
            item.damage = 30;

            item.useAmmo = AmmoID.Arrow;
            item.shoot = ProjectileID.WoodenArrowFriendly;
            item.shootSpeed = 10f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Acorn, 10);
            recipe.AddIngredient(ItemID.Silk, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	}