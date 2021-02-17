using Terraria.ID;
using Terraria.ModLoader;

namespace CrewpotatosSwordsI.Items
{
	public class GroundSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Ground Sword");
			Tooltip.SetDefault("Dirt, sand, mud. It's all in this sword.");
		}

		public override void SetDefaults() 
		{
			item.damage = 11;
			item.melee = true;
			item.width = 40;
			item.height = 40;
            item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 20000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SandBlock, 2);
            recipe.AddIngredient(mod, "SandyGrassSword");
            recipe.AddIngredient(mod, "GroundBar", 3);
            recipe.AddIngredient(mod, "JungleGrassSword");
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}