using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

class MyGlobalNPC : GlobalNPC
{
    public override void NPCLoot(NPC npc)
	{
		if(npc.type == NPCID.Piranha)
		{
            Item.NewItem(npc.getRect(), mod.ItemType("PiranhaTooth"));
		}
		// Addtional if statements here if you would like to add drops to other vanilla npc.
	}
}