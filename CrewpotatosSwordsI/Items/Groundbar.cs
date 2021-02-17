using Terraria.ID;
using Terraria.ModLoader;

namespace CrewpotatosSwordsI.Items
{
	public class GroundBar : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Ground Bar");
			Tooltip.SetDefault("A bar made with the ground. Or you could just say mud, dirt, and sand. Thats fine too.");
		}

		public override void SetDefaults() 
		{
			item.melee = false;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 0;
            item.maxStack = 999;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SandBlock, 5);
            recipe.AddIngredient(ItemID.MudBlock, 5);
            recipe.AddIngredient(ItemID.DirtBlock, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}