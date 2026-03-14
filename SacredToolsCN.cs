using Microsoft.Xna.Framework.Graphics;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using System;
using System.Linq;
using System.Reflection;
using Terraria;
using Terraria.GameContent;
using Terraria.Localization;
using Terraria.ModLoader;
using TigerForceLocalizationLib;
using TigerForceLocalizationLib.Filters;
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
	}
}
