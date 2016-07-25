using System.Collections.Generic;

namespace Colligo.REST
{
	/// <summary>
	/// Forms the comma delimited query parameter specifying the image sizes to return with the call
	/// </summary>
	public class Image : IQueryParameter
	{
		static string _key = "image_sizes";
		List<Types> _values = new List<Types>(); 

		public enum Types
		{
			BlackBorder250,
			BlackBorder500,
			Block,
			Block100,
			Block107,
			Block16,
			Block178,
			Block188,
			Block200,
			Block250,
			Block67,
			Block95,
			DropShadow118,
			DropShadow118Grey,
			DropShadow170,
			DropShadow250,
			DropShadow48,
			DropShadow48Grey,
			DropShadow92Blue,
			EDPBorder250,
			EDPBorder300,
			EDPBorder500,
			Large,
			Medium,
			Small,
			Thumb,
			PDPBorder250,
			PDPBorder500,
			PerspectiveCrop176by124,
			PerspectiveCrop290by250,
			VDPBorder250,
			VDPBorder500,
			WhiteBorder500
		}

		public Dictionary<Types, string> Sizes = new Dictionary<Types, string>()
		{
			{Types.BlackBorder250,	"blackborder250" },
			{Types.BlackBorder500,	"blackborder500" },
			{Types.Block,			"block" },
			{Types.Block100,		"block100" },
			{Types.Block107,		"block107" },
			{Types.Block16,			"block16"},
			{Types.Block178,		"block178" },
			{Types.Block188,		"block188"},
			{Types.Block200,		"block200"},
			{Types.Block250,		"block250"},
			{Types.Block67,			"block67"},
			{Types.Block95,			"block95"},
			{Types.DropShadow118,   "dropshadow118"},
			{Types.DropShadow118Grey,"dropshadow118grey"},
			{Types.DropShadow170,   "dropshadow170"},
			{Types.DropShadow250,   "dropshadow250"},
			{Types.DropShadow48,    "dropshadow48"},
			{Types.DropShadow48Grey,"dropshadow48grey"},
			{Types.DropShadow92Blue,"dropshadow92blue"},
			{Types.EDPBorder250,	"edpborder250"},
			{Types.EDPBorder300,    "edpborder300"},
			{Types.EDPBorder500,    "edpborder500"},
			{Types.Large,			"large"},
			{Types.Medium,			"medium" },
			{Types.Small,			"small"},
			{Types.Thumb,			"thumb"},
			{Types.PDPBorder250,	"pdpborder250"},
			{Types.PDPBorder500,    "pdpborder500"},
			{Types.PerspectiveCrop176by124, "perspectivecrop176by124"},
			{Types.PerspectiveCrop290by250, "perspectivecrop290by250"},
			{Types.VDPBorder250,	"vdpborder250"},
			{Types.VDPBorder500,    "vdpborder500"},
			{Types.WhiteBorder500,	"whiteborder500"}
		};

		public void AddValues(params Types[] sizes)
		{
			foreach (Types type in sizes)
			{
				_values.Add(type);
			}
		}

		public string GetQuery()
		{
			return QueryTools.GetQuery(_key, ValuesToString());
		}

		string ValuesToString()
		{
			if (_values.Count < 1)
				return null;
			string value = Sizes[_values[0]];
			for (int i = 1; i < _values.Count; i++)
			{
				value += "," + Sizes[_values[i]];
			}
			return value;
		}
	}
}
