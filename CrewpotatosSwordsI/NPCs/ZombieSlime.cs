using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrewpotatosSwordsI.NPCs
{
	// This ModNPC serves as an example of a complete AI example.
	public class ZombieSlime : ModNPC
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Zombie Slime");
			Main.npcFrameCount[npc.type] = 6; // make sure to set this for your modnpcs.
		}

		public override void SetDefaults() {
			npc.width = 35;
			npc.height = 35;
			npc.aiStyle = 1; 
			npc.damage = 11;
			npc.defense = 8;
			npc.lifeMax = 60;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			//npc.alpha = 175;
			//npc.color = new Color(0, 80, 255, 100);
			npc.value = 40f;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = false; // npc default to being immune to the Confused debuff. Allowing confused could be a little more work depending on the AI. npc.confused is true while the npc is confused.
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			// we would like this npc to spawn in the overworld.
			return SpawnCondition.OverworldNight.Chance * 0.75f;
        }
        public override void NPCLoot()
        {
            Item.NewItem(npc.getRect(), mod.ItemType("ZombieGel"), 1 + Main.rand.Next(3)); // 1-3
            if (Main.rand.Next(3) == 0)
                Item.NewItem(npc.getRect(), ItemID.Gel, 1 + Main.rand.Next(2));;
        }
	}
}