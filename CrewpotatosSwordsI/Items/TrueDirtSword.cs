using Terraria.ID;
using Terraria.ModLoader;

namespace CrewpotatosSwordsI.Items
{
	public class TrueDirtSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("True Dirt Sword");
            Tooltip.SetDefault("It's amazing. Shoots a Dirt Sword.");
		}

		public override void SetDefaults() 
		{
			item.damage = 15;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.shoot = mod.ProjectileType("TrueDirtSwordProjectile");
            item.shootSpeed = 4f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddIngredient(mod, "DirtSword");
            recipe.AddIngredient(mod, "PiranhaSword");
            recipe.AddIngredient(mod, "FishBar");
            recipe.AddIngredient(mod, "GroundBar", 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}