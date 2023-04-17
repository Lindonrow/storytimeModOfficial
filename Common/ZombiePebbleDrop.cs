using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using storytimeModOfficial.Content.Items;
using Terraria.GameContent.Creative;
using Terraria.GameContent.ItemDropRules;

namespace storytimeModOfficial.Common
{
	public class ZombiePebbleDrop : GlobalNPC
	{
		public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
		{
			if (NPCID.Sets.Zombies[npc.type])
			{
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Pebble>(), chanceDenominator: 4, maximumDropped: 10));
			}
		}
	}
}
