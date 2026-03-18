using Terraria.ModLoader;
using TigerForceLocalizationLib;
using VeluriyamLibHjson.Core;
using VeluriyamLibHjson.Destroyer;

namespace SacredToolsCN
{
	public class SacredToolsCN : Mod
	{
		public override void PostSetupContent()
		{
			TigerForceLocalizationHelper.LocalizeAll("SacredToolsCN", "SacredTools", false);
		}

		public override void Load()
		{
			ModifyModName.ModifyManageModName("Shadows of Abaddon [Public Beta]", VLanguage.SafeGetTextValue("Mods.SacredToolsCN.SacredTools"));
			ModifyModName.ModifyConfigName("SacredTools", VLanguage.SafeGetTextValue("Mods.SacredToolsCN.SacredTools"));
        }
	}
}
