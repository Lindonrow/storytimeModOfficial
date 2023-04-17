using Terraria.ModLoader;
using Terraria.GameContent.UI;

namespace storytimeModOfficial
{
	public class storytimeModOfficial : Mod
	{
		public const string ASSET_PATH = "storytimeModOfficial/Assets/";

		public static int PebbleCurrencyId;

		public override void Load()
		{
			// Registers a new custom currency
			PebbleCurrencyId = CustomCurrencyManager.RegisterCurrency(new Content.Currencies.PebbleCurrency(ModContent.ItemType<Content.Items.Pebble>(), 999L, "Mods.storytimeModOfficial.Currencies.PebbleCurrency"));
		}
	}
}