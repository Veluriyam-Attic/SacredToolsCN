using Terraria.ModLoader;
using TigerForceLocalizationLib.Filters;
using TigerForceLocalizationLib;

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
