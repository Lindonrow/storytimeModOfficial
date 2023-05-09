using storytimeModOfficial.Content.Items.Placeable;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace storytimeModOfficial.Common
{
	class SantaShop : GlobalNPC
	{
		public override void SetupShop(int type, Chest shop, ref int nextSlot)
		{
			// This example does not use the AppliesToEntity hook, as such, we can handle multiple npcs here by using if statements.
			if (type == NPCID.SantaClaus)
			{
				// Adding an item to a vanilla NPC is easy:
				// This item sells for the normal price.
				shop.item[nextSlot].SetDefaults(ModContent.ItemType<YuleTownBoxItem>());
				nextSlot++; // Don't forget this line, it is essential.

			}
		}
	}
}
