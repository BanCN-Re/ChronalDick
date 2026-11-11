using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using MSc01sf3DGpdk89SaOBd;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls.Bedrock;

public sealed class BedrockProfileStatisticViewModel
{
	[CompilerGenerated]
	private readonly int _Type_k__BackingField;

	[field: CompilerGenerated]
	public int Type
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Type_k__BackingField;
		}
	}

	[CompilerGenerated]
	private readonly string _Label_k__BackingField;

	[field: CompilerGenerated]
	public string Label
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Label_k__BackingField;
		}
	}

	[CompilerGenerated]
	private readonly string _Value_k__BackingField;

	[field: CompilerGenerated]
	public string Value
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Value_k__BackingField;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal BedrockProfileStatisticViewModel(w6dBwqf3936qgl9ghrK7 statistic)
	{
		_Type_k__BackingField = statistic.Type;
		_Label_k__BackingField = statistic.Type switch
		{
			1 => "游戏时长", 
			2 => "联机模式时长", 
			3 => "生存模式时长", 
			4 => "创造模式时长", 
			5 => "装扮数", 
			6 => "组件数", 
			_ => $"统计类型 {statistic.Type}", 
		};
		_Value_k__BackingField = FormatValue(statistic);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string FormatValue(w6dBwqf3936qgl9ghrK7 statistic)
	{
		if (!statistic.Visible)
		{
			return "未公开";
		}
		int type = statistic.Type;
		double num = default(double);
		if (type >= 1 && type <= 4 && double.TryParse(statistic.Value, (NumberStyles)167, (IFormatProvider)(object)CultureInfo.InvariantCulture, out num))
		{
			return $"{Math.Max(0.0, num) / 3600.0:N1} 小时";
		}
		long num2 = default(long);
		if (long.TryParse(statistic.Value, (NumberStyles)7, (IFormatProvider)(object)CultureInfo.InvariantCulture, out num2))
		{
			return num2.ToString("N0", (IFormatProvider)(object)CultureInfo.CurrentCulture);
		}
		if (!string.IsNullOrWhiteSpace(statistic.Value))
		{
			return statistic.Value;
		}
		return "—";
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}
