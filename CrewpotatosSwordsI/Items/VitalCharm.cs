using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace CrewpotatosSwordsI.Items
{
    public class VitalCharm : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vital Charm (lv 1)");
            Tooltip.SetDefault("You feel like you can last longer with this. +5 Max HP.");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 28;
            item.value = 10000;
            item.rare = -1;
            item.accessory = true;
            item.defense = 1;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statLifeMax2 += 5;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddIngredient(ItemID.Mushroom, 3);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}