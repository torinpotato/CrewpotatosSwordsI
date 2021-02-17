using Terraria.ID;
using Terraria.ModLoader;

namespace CrewpotatosSwordsI.Items
{
	public class PiranhaSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Piranha Sword");
			Tooltip.SetDefault("It bites!");
		}

        public override void SetDefaults()
        {
            item.damage = 7;
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
            recipe.AddIngredient(mod, "FishBar", 1);
            recipe.AddIngredient(mod, "PiranhaTooth", 3);
            recipe.AddIngredient(mod, "FishSword");
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}