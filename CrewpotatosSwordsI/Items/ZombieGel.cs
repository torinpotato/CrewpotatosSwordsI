using Terraria.ID;
using Terraria.ModLoader;

namespace CrewpotatosSwordsI.Items
{
    public class ZombieGel : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zombie Gel");
            Tooltip.SetDefault("Both disgusting and not flammable.");
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
            item.value = 2;
            item.rare = 0;
            item.maxStack = 999;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
    }
}