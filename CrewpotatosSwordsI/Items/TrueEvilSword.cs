using Terraria.ID;
using Terraria.ModLoader;

namespace CrewpotatosSwordsI.Items
{
	public class TrueEvilSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("True Evil Sword");
            Tooltip.SetDefault("Well, this is strong. Shoots an Evil Sword.");
		}

		public override void SetDefaults() 
		{
			item.damage = 38;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 35;
			item.useAnimation = 35;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.shoot = mod.ProjectileType("TrueEvilSwordProjectile");
            item.shootSpeed = 8f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltBar, 4);
            recipe.AddIngredient(mod, "MoltenEvilSword");
            recipe.AddIngredient(mod, "TrueDirtSword");
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PalladiumBar, 4);
            recipe.AddIngredient(mod, "MoltenEvilSword");
            recipe.AddIngredient(mod, "TrueDirtSword");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}