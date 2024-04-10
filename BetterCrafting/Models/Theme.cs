#nullable enable

using Newtonsoft.Json;

using Microsoft.Xna.Framework;

using Leclair.Stardew.Common.Serialization.Converters;

namespace Leclair.Stardew.BetterCrafting.Models;

public class Theme {

	[JsonConverter(typeof(ColorConverter))]
	public Color? SearchHighlightColor { get; set; }

	[JsonConverter(typeof(ColorConverter))]
	public Color? QuantityCriticalTextColor { get; set; }

	[JsonConverter(typeof(ColorConverter))]
	public Color? QuantityCriticalShadowColor { get; set; }

	[JsonConverter(typeof(ColorConverter))]
	public Color? QuantityWarningTextColor { get; set; }

	[JsonConverter(typeof(ColorConverter))]
	public Color? QuantityWarningShadowColor { get; set; }


	public bool CustomTooltip { get; set; }

	public bool CustomScroll { get; set; }

	[JsonConverter(typeof(ColorConverter))]
	public Color? TextColor { get; set; }

	[JsonConverter(typeof(ColorConverter))]
	public Color? TextShadowColor { get; set; }

}
