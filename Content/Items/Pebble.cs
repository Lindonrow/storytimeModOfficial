using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace storytimeModOfficial.Content.Items
{
    internal class Pebble : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pebble");
            Tooltip.SetDefault("A damn pebble.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.width = 12;
            Item.height = 12;

            Item.value = Item.buyPrice(copper: 1);
            Item.maxStack = 999;
        }
    }
}
