using Terraria.ID;
using Terraria.ModLoader;

namespace CrewpotatosSwordsI.Items
{
	public class MoltenEvilSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Molten Evil Sword");
			Tooltip.SetDefault("Molten evil.");
		}

		public override void SetDefaults() 
		{
			item.damage = 25;
			item.melee = true;
			item.width = 40;
			item.height = 40;
            item.useTime = 28;
			item.useAnimation = 28;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 20000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 2);
            recipe.AddIngredient(mod, "EvilSword");
            recipe.needLava = true;
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}