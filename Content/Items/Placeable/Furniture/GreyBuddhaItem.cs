using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace storytimeModOfficial.Content.Items.Placeable.Furniture
{
	public class GreyBuddhaItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Grey Fat Buddha");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.GreyBuddha>());
			Item.value = 150;
			Item.maxStack = 99;
			Item.width = 24;
			Item.height = 24;
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.StoneBlock, 75)
				.AddTile(TileID.HeavyWorkBench)
				.Register();
		}
	}
}
