using Terraria;
using Terraria.ModLoader;

namespace CrewpotatosSwordsI.Buffs
{
    public class ExtraSpeedyBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Extra Speedy");
            Description.SetDefault("Speed is increased by 75%");
            Main.debuff[Type] = false;
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = false;
            canBeCleared = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            {
                if (Main.myPlayer == player.whoAmI && Main.time % 1000 == 0)
                {
                }
                player.moveSpeed += 0.75f;
                // Some other effects:
                //player.lifeRegen++;
                //player.meleeCrit += 2;
                //player.meleeDamage += 0.051f;
                //player.meleeSpeed += 0.051f;
                //player.statDefense += 3;
                //player.moveSpeed += 0.05f;
            }
        }
    }
}