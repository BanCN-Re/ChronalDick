using System;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using HN5yyEfpz8TLMVS2CfPf;
using Microsoft.UI.Xaml;
using a7SGhofapyfcs667hqvi;
using bVpm9ofaNkQaQ1BfGtjU;
using irrAk7fuuIVR5Iy3Ssix;
using q6cFd2fu1TbUdv8pP4I2;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls.Bedrock;

public sealed class BedrockVersionEntryViewModel
{
	[field: CompilerGenerated]
	public wSe3XtfuacgO0nXuwqHe Entry
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	public xssD3cfpnxdefR05FuDD Installation
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Entry.Installation;
		}
	}

	public string Version
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Installation.Version;
		}
	}

	public string InstallationPath
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Installation.InstallationPath;
		}
	}

	public bool IsRegisteredClient
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Entry.IsRegisteredClient;
		}
	}

	public bool IsCorrupt
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Entry.IsCorrupt;
		}
	}

	[field: CompilerGenerated]
	public bool IsSelected
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public svXO9wfaM98XKNvcsrMd? RenderEngine
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	public P0AvWCfaT2GZfGOulKXm RendererTarget
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			svXO9wfaM98XKNvcsrMd? renderEngine = RenderEngine;
			if (renderEngine != null && renderEngine.Engine == (P0AvWCfaT2GZfGOulKXm?)0)
			{
				return (P0AvWCfaT2GZfGOulKXm)1;
			}
			return (P0AvWCfaT2GZfGOulKXm)0;
		}
	}

	public string RendererText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Invalid comparison between Unknown and I4
			svXO9wfaM98XKNvcsrMd? renderEngine = RenderEngine;
			P0AvWCfaT2GZfGOulKXm? val = ((renderEngine != null) ? renderEngine.Engine : ((P0AvWCfaT2GZfGOulKXm?)null));
			if (!val.HasValue)
			{
				goto IL_0064;
			}
			P0AvWCfaT2GZfGOulKXm valueOrDefault = val.GetValueOrDefault();
			string text;
			if ((int)valueOrDefault != 0)
			{
				if ((int)valueOrDefault != 1)
				{
					goto IL_0064;
				}
				text = "渲染龙";
			}
			else
			{
				text = "OpenGL";
			}
			goto IL_006a;
			IL_0064:
			text = "未检测";
			goto IL_006a;
			IL_006a:
			string text2 = text;
			svXO9wfaM98XKNvcsrMd? renderEngine2 = RenderEngine;
			string text3 = ((renderEngine2 != null && renderEngine2.UsesVersionProfile) ? "版本独立" : "全局配置");
			return $"当前渲染：{text2}（{text3}）";
		}
	}

	public string RendererActionText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			if ((int)RendererTarget != 0)
			{
				return "切换到渲染龙";
			}
			return "切换到 OpenGL";
		}
	}

	public Visibility CorruptVisibility
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (IsCorrupt)
			{
				return (Visibility)0;
			}
			return (Visibility)1;
		}
	}

	public Visibility HealthyVisibility
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (IsCorrupt)
			{
				return (Visibility)1;
			}
			return (Visibility)0;
		}
	}

	public Visibility RendererResetVisibility
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!IsCorrupt)
			{
				svXO9wfaM98XKNvcsrMd? renderEngine = RenderEngine;
				if (renderEngine != null && renderEngine.UsesVersionProfile)
				{
					return (Visibility)0;
				}
			}
			return (Visibility)1;
		}
	}

	public Visibility SelectedVisibility
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (IsSelected)
			{
				return (Visibility)0;
			}
			return (Visibility)1;
		}
	}

	public Visibility SelectVisibility
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!IsCorrupt && !IsSelected)
			{
				return (Visibility)0;
			}
			return (Visibility)1;
		}
	}

	public Visibility RepairVisibility
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (IsCorrupt && !IsRegisteredClient)
			{
				return (Visibility)0;
			}
			return (Visibility)1;
		}
	}

	public string IntegrityMessage
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!string.IsNullOrWhiteSpace(Entry.IntegrityMessage))
			{
				return Entry.IntegrityMessage;
			}
			return "客户端文件不完整";
		}
	}

	public string SourceText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected I4, but got Unknown
			eTxO5ffupXPaQFO5K2aV locationKind = Entry.LocationKind;
			string text = (int)locationKind switch
			{
				0 => "默认存储位置", 
				1 => "自定义存储位置", 
				2 => "自定义客户端", 
				_ => "本地客户端", 
			};
			if (!Entry.IsCurrentLocation)
			{
				return text;
			}
			return text + " · 当前存储";
		}
	}

	public string StatusText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!IsCorrupt)
			{
				if (!IsSelected)
				{
					return "客户端文件完整";
				}
				return "当前启动版本";
			}
			return "已损坏：" + IntegrityMessage;
		}
	}

	public string ActionText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!IsRegisteredClient)
			{
				return "删除";
			}
			return "移除登记";
		}
	}

	public string ActionToolTip
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!IsRegisteredClient)
			{
				return "删除此客户端版本";
			}
			return "从客户端列表移除，不会删除本地文件";
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public BedrockVersionEntryViewModel(wSe3XtfuacgO0nXuwqHe entry, bool isSelected = false, svXO9wfaM98XKNvcsrMd? renderEngine = null)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Entry = entry ?? throw new ArgumentNullException("entry");
		IsSelected = isSelected;
		RenderEngine = renderEngine;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}
