using Terraria.ModLoader;
using TigerForceLocalizationLib.Filters;
using TigerForceLocalizationLib;
using Terraria.GameContent;
using Microsoft.Xna.Framework.Graphics;

namespace SacredToolsCN
{
	public class SacredToolsCN : Mod
	{
		public override void PostSetupContent()
		{
			TigerForceLocalizationHelper.LocalizeAll("SacredToolsCN", "SacredTools", false);
		}
	}
}
