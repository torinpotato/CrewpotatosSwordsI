using Terraria.ID;
using Terraria.ModLoader;

namespace CrewpotatosSwordsI.Items
{
	public class JungleGrassSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Jungle Grass Sword");
			Tooltip.SetDefault("Strike with the jungle!");
		}

		public override void SetDefaults() 
		{
			item.damage = 3;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MudBlock, 10);
            recipe.AddIngredient(ItemID.RichMahogany, 2);
            recipe.AddIngredient(mod, "MuddySword");
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}