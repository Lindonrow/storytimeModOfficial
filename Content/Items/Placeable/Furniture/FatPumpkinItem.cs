using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace storytimeModOfficial.Content.Items.Placeable.Furniture
{
	public class FatPumpkinItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fat Pumpkin");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.FatPumpkin>());
			Item.value = 150;
			Item.maxStack = 99;
			Item.width = 24;
			Item.height = 24;
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.Pumpkin, 15)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
