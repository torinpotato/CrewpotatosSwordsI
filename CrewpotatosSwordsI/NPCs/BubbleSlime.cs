using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrewpotatosSwordsI.NPCs
{
	// This ModNPC serves as an example of a complete AI example.
	public class BubbleSlime : ModNPC
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Bubble Slime");
			Main.npcFrameCount[npc.type] = 6; // make sure to set this for your modnpcs.
		}

		public override void SetDefaults() {
			npc.width = 1;
			npc.height = 1;
			npc.aiStyle = 1; 
			npc.damage = 7;
			npc.defense = 5;
			npc.lifeMax = 40;
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
			return SpawnCondition.OverworldDaySlime.Chance * 0.75f;
        }
        public override void NPCLoot()
        {
            Item.NewItem(npc.getRect(), mod.ItemType("BubbleGel"), 1 + Main.rand.Next(4)); // 1-4
        }
	}
}