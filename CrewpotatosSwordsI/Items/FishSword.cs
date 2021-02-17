using Terraria.ID;
using Terraria.ModLoader;

namespace CrewpotatosSwordsI.Items
{
	public class FishSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Fish Sword");
			Tooltip.SetDefault("A fishy sword.");
		}

        public override void SetDefaults()
        {
            item.damage = 4;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 16;
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
			recipe.AddIngredient(ItemID.Goldfish, 3);
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}