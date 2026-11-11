using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using By1SFsLobKQOZCdh5qRg;
using Microsoft.UI.Xaml;
using ROZe5Gf1WgRr9IZ64gbr;
using XwGHm3fuSv9veHkPToT0;
using ajau5tfpTXRk8mjlQPRa;
using i6TlJMfuChv2AjPXr7O8;
using nyJeB7f0q9CPYw2lLbou;
using qS8vkpL43FlTMgcj0rgs;
using tIxGh8f0x0UDnYTxMOJ4;

namespace Mahiro_Account.UI.Controls.Bedrock;

public sealed class BedrockInstanceCardViewModel : INotifyPropertyChanged
{
	private bool _overlayBusy;

	private string _overlayStatus;

	[CompilerGenerated]
	private PropertyChangedEventHandler? m_PropertyChanged;

	[field: CompilerGenerated]
	private zG6ueUfuQUk6CEmxLYji? _Instance_k__BackingField;
	public zG6ueUfuQUk6CEmxLYji? Instance
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	private MFIPycf02g29tSkCEJDk? _Relay_k__BackingField;
	public MFIPycf02g29tSkCEJDk? Relay
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	public int ProcessId
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			zG6ueUfuQUk6CEmxLYji? instance = Instance;
			if (instance == null)
			{
				return 0;
			}
			return instance.ProcessId;
		}
	}

	public string Title
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Invalid comparison between Unknown and I4
			object obj;
			if (Relay == null)
			{
				zG6ueUfuQUk6CEmxLYji? instance = Instance;
				if (instance == null)
				{
					obj = null;
				}
				else
				{
					wjHCLDf1ydVEraHow39U server = instance.Server;
					obj = ((server != null) ? server.Name : null);
				}
				if (obj == null)
				{
					zG6ueUfuQUk6CEmxLYji? instance2 = Instance;
					if (instance2 == null || (int)instance2.Kind != 3)
					{
						return "本地客户端";
					}
					return "外部 Minecraft 客户端";
				}
			}
			else
			{
				obj = "国际版代理服务";
			}
			return (string)obj;
		}
	}

	public string KindText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (Relay == null)
			{
				return SBIftjfuYV0iYXGUYT0K.nacfucjYx21(Instance);
			}
			return "代理服务";
		}
	}

	public string CoverUrl
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			zG6ueUfuQUk6CEmxLYji? instance = Instance;
			object obj;
			if (instance == null)
			{
				obj = null;
			}
			else
			{
				wjHCLDf1ydVEraHow39U server = instance.Server;
				obj = ((server != null) ? server.TitleImageUrl : null);
			}
			if (obj == null)
			{
				obj = string.Empty;
			}
			return (string)obj;
		}
	}

	public string StatusText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected I4, but got Unknown
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Invalid comparison between Unknown and I4
			if (Relay != null)
			{
				MZj5bRf0PSr85C6orTMR state = Relay.State;
				return (state - 2) switch
				{
					(tIxGh8f0x0UDnYTxMOJ4.MZj5bRf0PSr85C6orTMR)2 => "客户端已连接", 
					(tIxGh8f0x0UDnYTxMOJ4.MZj5bRf0PSr85C6orTMR)3 => "代理失败", 
					(tIxGh8f0x0UDnYTxMOJ4.MZj5bRf0PSr85C6orTMR)4 => "已停止", 
					(tIxGh8f0x0UDnYTxMOJ4.MZj5bRf0PSr85C6orTMR)1 => "认证中", 
					0 => "连接中", 
					_ => "等待客户端", 
				};
			}
			zG6ueUfuQUk6CEmxLYji? instance = Instance;
			return (instance != null && (int)instance.State == 1) ? "正在关闭" : "运行中";
		}
	}

	public string StartedText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			MFIPycf02g29tSkCEJDk? relay = Relay;
			object val = null;
			if (relay == null)
			{
				zG6ueUfuQUk6CEmxLYji? instance = Instance;
				val = ((instance != null) ? instance.StartedAt : DateTimeOffset.Now);
			}
			else
			{
				val = relay.StartedAt;
			}
			DateTimeOffset val2 = (DateTimeOffset)val;
			return val2.ToString("yyyy/MM/dd HH:mm:ss");
		}
	}

	public string StartedTimeText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			MFIPycf02g29tSkCEJDk? relay = Relay;
			object val = null;
			if (relay == null)
			{
				zG6ueUfuQUk6CEmxLYji? instance = Instance;
				val = ((instance != null) ? instance.StartedAt : DateTimeOffset.Now);
			}
			else
			{
				val = relay.StartedAt;
			}
			DateTimeOffset val2 = (DateTimeOffset)val;
			return val2.ToString("HH:mm:ss");
		}
	}

	public string AccountText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (Relay == null)
			{
				return SBIftjfuYV0iYXGUYT0K.bMbfu0jKUCk(Instance);
			}
			return "网易基岩会话 · 单客户端连接";
		}
	}

	public string DetailText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Invalid comparison between Unknown and I4
			object obj;
			if (Relay == null)
			{
				zG6ueUfuQUk6CEmxLYji? instance = Instance;
				if (!string.IsNullOrWhiteSpace((instance != null) ? instance.ServerHost : null))
				{
					int? serverPort = Instance.ServerPort;
					if (serverPort.HasValue && serverPort.GetValueOrDefault() > 0)
					{
						return $"{Instance.ServerHost}:{Instance.ServerPort}";
					}
				}
				zG6ueUfuQUk6CEmxLYji? instance2 = Instance;
				if (instance2 != null && (int)instance2.Kind == 3)
				{
					return "账号与服务器信息未知";
				}
				zG6ueUfuQUk6CEmxLYji? instance3 = Instance;
				if (instance3 == null)
				{
					obj = null;
				}
				else
				{
					ejKX8wfpsw8ins4MWI7J skin = instance3.Skin;
					obj = ((skin != null) ? skin.Name : null);
				}
				if (obj == null)
				{
					return "默认 Steve";
				}
			}
			else
			{
				obj = $"监听 {Relay.ListenAddress}:{Relay.LocalPort} → {Relay.RemoteAddress}:{Relay.RemotePort}";
			}
			return (string)obj;
		}
	}

	public string ProcessText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (Relay == null)
			{
				global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(13, 2);
				defaultInterpolatedStringHandler.AppendLiteral("PID ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(ProcessId);
				defaultInterpolatedStringHandler.AppendLiteral("  ·  客户端 ");
				zG6ueUfuQUk6CEmxLYji? instance = Instance;
				defaultInterpolatedStringHandler.AppendFormatted((instance != null) ? instance.ClientVersion : null);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			return $"UDP {Relay.LocalPort}  ·  客户端 {(Relay.HasClient ? "已连接" : "等待连接")}";
		}
	}

	public string ProcessIdText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (Relay == null)
			{
				return ProcessId.ToString();
			}
			return "UDP";
		}
	}

	public string ClientVersionText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			object obj;
			if (Relay == null)
			{
				zG6ueUfuQUk6CEmxLYji? instance = Instance;
				obj = ((instance != null) ? instance.ClientVersion : null);
				if (obj == null)
				{
					return "未知";
				}
			}
			else
			{
				obj = $"v{Relay.FrontendProtocol} → v{Relay.BackendProtocol}";
			}
			return (string)obj;
		}
	}

	public string ProcessLabelText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (Relay == null)
			{
				return "进程";
			}
			return "监听";
		}
	}

	public string ClientLabelText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (Relay == null)
			{
				return "客户端";
			}
			return "协议";
		}
	}

	public string OpenActionText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (Relay == null)
			{
				return "资源目录";
			}
			return "日志目录";
		}
	}

	public string CloseActionText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (Relay == null)
			{
				return "结束实例";
			}
			return "停止代理";
		}
	}

	public string? OpenPath
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (Relay == null)
			{
				zG6ueUfuQUk6CEmxLYji? instance = Instance;
				if (instance == null)
				{
					return null;
				}
				return instance.InstallationPath;
			}
			return Path.GetDirectoryName(Relay.CaptureFilePath);
		}
	}

	public bool CanOpenFolder
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!string.IsNullOrWhiteSpace(OpenPath))
			{
				return Directory.Exists(OpenPath);
			}
			return false;
		}
	}

	public bool CanClose
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Invalid comparison between Unknown and I4
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Invalid comparison between Unknown and I4
			if (Relay == null)
			{
				zG6ueUfuQUk6CEmxLYji? instance = Instance;
				if (instance == null)
				{
					return false;
				}
				return (int)instance.State == 0;
			}
			return (int)Relay.State != 6;
		}
	}

	public Visibility OverlayVisibility
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Invalid comparison between Unknown and I4
			zG6ueUfuQUk6CEmxLYji instance = Instance;
			if (instance != null && (int)instance.Kind != 3)
			{
				return (Visibility)0;
			}
			return (Visibility)1;
		}
	}

	public bool CanLoadOverlay
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Invalid comparison between Unknown and I4
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			zG6ueUfuQUk6CEmxLYji instance = Instance;
			if (instance != null && (int)instance.Kind != 3 && (int)instance.State == 0)
			{
				return !_overlayBusy;
			}
			return false;
		}
	}

	public Visibility OverlayProgressVisibility
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (_overlayBusy)
			{
				return (Visibility)0;
			}
			return (Visibility)1;
		}
	}

	public string OverlayActionText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!_overlayBusy)
			{
				return "加载游戏内面板";
			}
			return "正在加载面板";
		}
	}

	public string OverlayStatusText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return _overlayStatus;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	[MethodImpl((MethodImplOptions)8)]
	public BedrockInstanceCardViewModel(zG6ueUfuQUk6CEmxLYji instance)
	{
		_overlayStatus = "按 Insert 打开，Esc 关闭";
		_Instance_k__BackingField = instance;
	}

	[MethodImpl((MethodImplOptions)8)]
	public BedrockInstanceCardViewModel(MFIPycf02g29tSkCEJDk relay)
	{
		_overlayStatus = "按 Insert 打开，Esc 关闭";
		_Relay_k__BackingField = relay;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void SetOverlayStatus(bool busy, string status)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		_overlayBusy = busy;
		_overlayStatus = status;
		string[] array = new string[4] { "CanLoadOverlay", "OverlayProgressVisibility", "OverlayActionText", "OverlayStatusText" };
		foreach (string text in array)
		{
			PropertyChangedEventHandler? obj = this.PropertyChanged;
			if (obj != null)
			{
				obj.Invoke((object)this, new PropertyChangedEventArgs(text));
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}
