using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Map;

namespace Terraria.ModLoader;

[Autoload(false)]
public abstract class VanillaInfoDisplay : InfoDisplay
{
	private protected sealed override string DisplayNameInternal => Language.GetTextValue(LangKey);

	protected abstract string LangKey { get; }

	public override string DisplayValue() => "";
}

public class WatchesInfoDisplay : VanillaInfoDisplay
{
	public override string Texture => $"Terraria/Images/UI/InfoIcon_0";

	protected override string LangKey => "LegacyInterface.95";

	public override bool Active() => Main.player[Main.myPlayer].accWatch > 0;
}

public class WeatherRadioInfoDisplay : VanillaInfoDisplay
{
	public override string Texture => $"Terraria/Images/UI/InfoIcon_1";

	protected override string LangKey => "LegacyInterface.96";

	public override bool Active() => Main.player[Main.myPlayer].accWeatherRadio;
}

public class SextantInfoDisplay : VanillaInfoDisplay
{
	public override string Texture {
		get {
			int index = 7;
			if ((Main.bloodMoon && !Main.dayTime) || (Main.eclipse && Main.dayTime))
				index = 8;
			return $"Terraria/Images/UI/InfoIcon_" + index;
		}
	}

	protected override string LangKey => "LegacyInterface.102";

	public override bool Active() => Main.player[Main.myPlayer].accCalendar;
}

public class FishFinderInfoDisplay : VanillaInfoDisplay
{
	public override string Texture => $"Terraria/Images/UI/InfoIcon_2";

	protected override string LangKey => "LegacyInterface.97";

	public override bool Active() => Main.player[Main.myPlayer].accFishFinder;
}

public class MetalDetectorInfoDisplay : VanillaInfoDisplay
{
	public override string Texture => $"Terraria/Images/UI/InfoIcon_10";

	protected override string LangKey => "LegacyInterface.104";

	public override bool Active() => Main.player[Main.myPlayer].accOreFinder;
}

public class LifeformAnalyzerInfoDisplay : VanillaInfoDisplay
{
	public override string Texture => $"Terraria/Images/UI/InfoIcon_11";

	protected override string LangKey => "LegacyInterface.105";

	public override bool Active() => Main.player[Main.myPlayer].accCritterGuide;
}

public class RadarInfoDisplay : VanillaInfoDisplay
{
	public override string Texture => $"Terraria/Images/UI/InfoIcon_5";

	protected override string LangKey => "LegacyInterface.100";

	public override bool Active() => Main.player[Main.myPlayer].accThirdEye;
}

public class TallyCounterInfoDisplay : VanillaInfoDisplay
{
	public override string Texture => $"Terraria/Images/UI/InfoIcon_6";

	protected override string LangKey => "LegacyInterface.101";

	public override bool Active() => Main.player[Main.myPlayer].accJarOfSouls;
}

public class DummyInfoDisplay : VanillaInfoDisplay
{
	public override string Texture => $"Terraria/Images/UI/InfoIcon_8";

	protected override string LangKey => "LegacyInterface.101";

	public override bool Active() => false;
}

public class DPSMeterInfoDisplay : VanillaInfoDisplay
{
	public override string Texture => $"Terraria/Images/UI/InfoIcon_12";

	protected override string LangKey => "LegacyInterface.106";

	public override bool Active() => Main.player[Main.myPlayer].accDreamCatcher;
}

public class StopwatchInfoDisplay : VanillaInfoDisplay
{
	public override string Texture => $"Terraria/Images/UI/InfoIcon_9";

	protected override string LangKey => "LegacyInterface.103";

	public override bool Active() => Main.player[Main.myPlayer].accStopwatch;
}

public class CompassInfoDisplay : VanillaInfoDisplay
{
	public override string Texture => $"Terraria/Images/UI/InfoIcon_3";

	protected override string LangKey => "LegacyInterface.98";

	public override bool Active() => Main.player[Main.myPlayer].accCompass > 0;
}

public class DepthMeterInfoDisplay : VanillaInfoDisplay
{
	public override string Texture => $"Terraria/Images/UI/InfoIcon_4";

	protected override string LangKey => "LegacyInterface.99";

	public override bool Active() => Main.player[Main.myPlayer].accDepthMeter > 0;
}
