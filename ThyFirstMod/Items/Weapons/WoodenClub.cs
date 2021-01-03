using Terraria.ID;
using Terraria.ModLoader;

namespace ThyFirstMod.Items.Weapons
{
	public class WoodenClub : ModItem
	{
		public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("WoodenClub"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            NewMethod();
        }

        private void NewMethod()
        {
            Tooltip.SetDefault("grug must destroy!");
        }

        public override void SetDefaults() 
		{
			item.damage = 20;
			item.melee = true;
			item.width = 40;
			item.height = 50;
			item.useTime = 55;
			item.useAnimation = 45;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 8;
			item.value = 100;
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 25);
			recipe.AddIngredient(ItemID.Acorn, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}