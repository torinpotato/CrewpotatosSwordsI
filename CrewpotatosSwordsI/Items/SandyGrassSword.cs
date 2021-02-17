using Terraria.ID;
using Terraria.ModLoader;

namespace CrewpotatosSwordsI.Items
{
	public class SandyGrassSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Sandy Grass Sword");
			Tooltip.SetDefault("Sir, there's some sand in my grass sword!");
		}

		public override void SetDefaults() 
		{
			item.damage = 6;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 16;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SandBlock, 2);
            recipe.AddIngredient(mod, "GrassSword");
            recipe.AddIngredient(mod, "SandSword");
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}