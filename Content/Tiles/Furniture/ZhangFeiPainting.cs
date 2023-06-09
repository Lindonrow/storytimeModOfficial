﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace storytimeModOfficial.Content.Tiles.Furniture
{
	// Simple 3x3 tile that can be placed on a wall
	public class ZhangFeiPainting : ModTile
	{
		public override void SetStaticDefaults()
		{
            Main.tileFrameImportant[(int)((ModBlockType)this).Type] = true;
            Main.tileLavaDeath[(int)((ModBlockType)this).Type] = true;
            TileID.Sets.FramesOnKillWall[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.newTile.Width = 6;
            TileObjectData.newTile.Height = 4;
            TileObjectData.newTile.Origin = new Point16(3, 3);
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
            mapEntryName.SetDefault("Painting");
            TileID.Sets.DisableSmartCursor[(int)((ModBlockType)this).Type] = true;
        }

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ModContent.ItemType<Items.Placeable.Furniture.ZhangFeiItem>());
		}
	}
}
