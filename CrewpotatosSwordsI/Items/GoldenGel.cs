using Terraria.ID;
using Terraria.ModLoader;

namespace CrewpotatosSwordsI.Items
{
	public class GoldenGel : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Golden Gel");
			Tooltip.SetDefault("Bite it to see if its real gold! (Probably not a good idea)");
		}

		public override void SetDefaults() 
		{
            item.melee = false;
            item.width = 40;
            item.height = 40;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 139999;
            item.rare = 2;
            item.maxStack = 999;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
		}
	}
}