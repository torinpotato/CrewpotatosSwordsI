using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrewpotatosSwordsI.Items
{
    public class DirtBullet : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Doesn't do much damage, but its only a start. Plus its cheap!");
        }

        public override void SetDefaults()
        {
            item.damage = 1;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 0f;
            item.value = 1;
            item.rare = -1;
            item.shoot = mod.ProjectileType("DirtProjectile");
            item.shootSpeed = 0.5f;                  //The speed of the projectile
            item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 10);
            recipe.AddRecipe();
        }
    }
}