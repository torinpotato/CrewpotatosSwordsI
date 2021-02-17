using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace CrewpotatosSwordsI.Items
{
    public class StoneMeleeCharm : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stone Melee Charm");
            Tooltip.SetDefault("You feel like you can swing swords harder with this. +10% melee damage.");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 28;
            item.value = 10000;
            item.rare = 1;
            item.accessory = true;
            item.defense = 2;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.meleeDamage += 0.10f;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
            recipe.AddIngredient(mod, "WoodenMeleeCharm");
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}