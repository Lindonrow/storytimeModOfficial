using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using storytimeModOfficial.Content.Tiles;
using Terraria.ID;


namespace storytimeModOfficial.Content.Items.Placeable
{
    public class UlDahBoxItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            this.DisplayName.SetDefault("Music Box (Ul'Dah Theme)");
            this.Tooltip.SetDefault("'IDK What It's Called' - FFXIV OST\nComposed by Masayoshi Soken probably\n");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[this.Type] = 1;
            MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, "Sounds/Music/UlDahSong"), ModContent.ItemType<UlDahBoxItem>(), ModContent.TileType<UlDahBox>());
        }

        public override void SetDefaults()
        {
            this.Item.useStyle = ItemUseStyleID.Swing;
            this.Item.useTurn = true;
            this.Item.useAnimation = 15;
            this.Item.useTime = 10;
            this.Item.autoReuse = true;
            this.Item.consumable = true;
            this.Item.createTile = (int)((ModBlockType)((ModType)this).Mod.Find<ModTile>(nameof(UlDahBox))).Type;
            ((Entity)this.Item).width = 24;
            ((Entity)this.Item).height = 24;
            Item.rare = ItemRarityID.LightRed;
            this.Item.value = 1;
            this.Item.accessory = true;
        }

    }
}
