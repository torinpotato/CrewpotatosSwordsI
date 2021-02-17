using Terraria.ID;
using Terraria.ModLoader;

namespace CrewpotatosSwordsI.Items
{
	public class BubbleGel : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Bubble Gel");
			Tooltip.SetDefault("Fragile and transparent!");
		}

		public override void SetDefaults() 
		{
            item.damage = 0;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 0f;
            item.value = 1;
            item.rare = -1;
            item.shoot = mod.ProjectileType("Bubble");
            item.shootSpeed = 0.5f;
            item.ammo = AmmoID.Bullet; //The speed of the projectile
		}
	}
}