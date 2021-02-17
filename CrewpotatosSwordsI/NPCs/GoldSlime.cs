using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrewpotatosSwordsI.NPCs
{
	// This ModNPC serves as an example of a complete AI example.
	public class GoldSlime : ModNPC
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Gold Slime");
			Main.npcFrameCount[npc.type] = 6; // make sure to set this for your modnpcs.
		}

		public override void SetDefaults() {
			npc.width = 1;
			npc.height = 1;
			npc.aiStyle = 1; 
			npc.damage = 15;
			npc.defense = 15;
			npc.lifeMax = 50;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			//npc.alpha = 175;
			//npc.color = new Color(0, 80, 255, 100);
			npc.value = 150000f;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = false; // npc default to being immune to the Confused debuff. Allowing confused could be a little more work depending on the AI. npc.confused is true while the npc is confused.
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			// we would like this npc to spawn in the overworld.
			return SpawnCondition.OverworldDaySlime.Chance * 0.1f;
        }
        public override void NPCLoot()
        {
            Item.NewItem(npc.getRect(), ItemID.GoldOre, 1 + Main.rand.Next(4)); // 1-4
            Item.NewItem(npc.getRect(), ItemID.Gel, 1 + Main.rand.Next(2)); // 1-2
            if (Main.rand.Next(10) < 1) // a 1 in 10 chance
                Item.NewItem(npc.getRect(), mod.ItemType("GoldenGel"));;
        }
	}
}