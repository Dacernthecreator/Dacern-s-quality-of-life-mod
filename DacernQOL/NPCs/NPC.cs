using DacernQOL.Items;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DacernQOL.NPCs
{
	public class ModGlobalNPCDF : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
				if (Main.rand.Next(20) == 0)
				{
					if (npc.type == NPCID.UndeadMiner)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<BoneAxe>());
					}
				}
			
		}
	}
}