using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.UI;
using Terraria.Localization;

namespace storytimeModOfficial.Content.Currencies
{
	public class PebbleCurrency : CustomCurrencySingleCoin
	{
		public PebbleCurrency(int coinItemID, long currencyCap, string CurrencyTextKey) : base(coinItemID, currencyCap)
		{
			this.CurrencyTextKey = CurrencyTextKey;
			CurrencyTextColor = Color.LightSeaGreen;
		}
	}
}