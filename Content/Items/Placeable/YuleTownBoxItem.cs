using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using storytimeModOfficial.Content.Tiles;
using Terraria.ID;


namespace storytimeModOfficial.Content.Items.Placeable
{
    public class YuleTownBoxItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            this.DisplayName.SetDefault("Music Box (Yule Town Theme)");
            this.Tooltip.SetDefault("NEVER FORGET");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[this.Type] = 1;
            MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, "Sounds/Music/YuleTownSong"), ModContent.ItemType<YuleTownBoxItem>(), ModContent.TileType<YuleTownBox>());
        }

        public override void SetDefaults()
        {
            this.Item.useStyle = ItemUseStyleID.Swing;
            this.Item.useTurn = true;
            this.Item.useAnimation = 15;
            this.Item.useTime = 10;
            this.Item.autoReuse = true;
            this.Item.consumable = true;
            this.Item.createTile = (int)((ModBlockType)((ModType)this).Mod.Find<ModTile>(nameof(YuleTownBox))).Type;
            ((Entity)this.Item).width = 24;
            ((Entity)this.Item).height = 24;
            Item.rare = ItemRarityID.LightRed;
            this.Item.value = Item.buyPrice(5, 0, 0, 0);
            this.Item.accessory = true;
        }

    }
}
