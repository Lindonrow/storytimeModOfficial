using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.GameContent.ObjectInteractions;
using Terraria.Localization;


namespace storytimeModOfficial.Content.Tiles.Furniture
{
	public class BlackFrankStatue : ModTile
	{
		public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[(int)((ModBlockType)this).Type] = true;
            Main.tileLavaDeath[(int)((ModBlockType)this).Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x4);
            TileObjectData.newTile.Width = 3;
            TileObjectData.newTile.Height = 5;
            TileObjectData.newTile.CoordinateHeights = new int[6]
            {
        16,
        16,
        16,
        16,
        16,
        16
            };
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinatePadding = 2;
            TileObjectData.addTile((int)((ModBlockType)this).Type);
            ((ModBlockType)this).DustType = 0;





            ModTranslation mapEntryName = ((ModBlockType)this).CreateMapEntryName((string)null);
            mapEntryName.SetDefault("Monument");
            TileID.Sets.DisableSmartCursor[(int)((ModBlockType)this).Type] = true;
        }

        public override void NumDust(int x, int y, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

		public override void KillMultiTile(int x, int y, int frameX, int frameY)
		{
			Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 48, 32, ModContent.ItemType<Items.Placeable.Furniture.BlackFrankStatueItem>());
		}
	}
}

