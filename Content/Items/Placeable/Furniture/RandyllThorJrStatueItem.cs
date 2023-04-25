using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace storytimeModOfficial.Content.Items.Placeable.Furniture
{
	public class BlackFrankStatueItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Black Frank Memorial");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.BlackFrankStatue>());
			Item.value = 150;
			Item.maxStack = 99;
			Item.width = 36;
			Item.height = 36;
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.StoneBlock, 150)
				.AddTile(TileID.HeavyWorkBench)
				.Register();
		}
	}
}
