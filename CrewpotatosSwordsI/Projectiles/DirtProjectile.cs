using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrewpotatosSwordsI.Projectiles
{
    public class DirtProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("DirtProjectile");
        }

        public override void SetDefaults()
        {
            projectile.arrow = false;
            projectile.width = 10;
            projectile.height = 10;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.ranged = true;
            aiType = ProjectileID.Bullet;
        }
    }
}