using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace CrewpotatosSwordsI.Items
{
    public class LeadMeleeCharm : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lead Melee Charm");
            Tooltip.SetDefault("You feel like you can swing swords alot harder with this. +15% melee damage.");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 28;
            item.value = 10000;
            item.rare = 1;
            item.accessory = true;
            item.defense = 3;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.meleeDamage += 0.15f;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar, 20);
            recipe.AddIngredient(mod, "StoneMeleeCharm");
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}