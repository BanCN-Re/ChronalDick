using System;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using Qbu4k2fNGuFUBstTsCYh;
using fDAldojjppXrctUVYOJn;
using v1AhFSfMblmp1q5wGqxg;

namespace cK2p8BfMfgWEdApq7hkm;

public sealed class l6vC8LfMXvCYSRCp4C3a : IEquatable<l6vC8LfMXvCYSRCp4C3a>
{
	[CompilerGenerated]
	private mWGKInfNzSRMjl3TLmeA _Slot_k__BackingField;

	[CompilerGenerated]
	private g41MUMfNq1DR8G8UnC95 _Kind_k__BackingField;

	[CompilerGenerated]
	private string _Message_k__BackingField;

	internal static object IBaeHN9kBXmd5KpPmg0j;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return System.Type.GetTypeFromHandle(typeof(l6vC8LfMXvCYSRCp4C3a).TypeHandle);
		}
	}

	public mWGKInfNzSRMjl3TLmeA Slot
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Slot_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			do
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						_Slot_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
			}
			while (num == 989);
		}
	}

	public g41MUMfNq1DR8G8UnC95 Kind
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Kind_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			do
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						_Kind_k__BackingField = value;
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
			}
			while (num == 989);
		}
	}

	public string Message
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Message_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_001d;
					case 1:
						break;
					case 0:
						return;
					}
					goto IL_0030;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0030;
					IL_0030:
					_Message_k__BackingField = value;
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
					{
						num2 = 0;
					}
				}
			}
		}
	}

	public string CategoryName
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 2;
			g41MUMfNq1DR8G8UnC95 kind = default(g41MUMfNq1DR8G8UnC95);
			string result = default(string);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 != 18)
							{
								if (num2 == 999)
								{
									goto end_IL_0010;
								}
								goto case 2;
							}
							goto case 3;
						case 1:
							switch (kind)
							{
							case g41MUMfNq1DR8G8UnC95.Http:
								goto IL_0087;
							case g41MUMfNq1DR8G8UnC95.Response:
								goto IL_00af;
							case g41MUMfNq1DR8G8UnC95.Network:
								goto IL_0143;
							case g41MUMfNq1DR8G8UnC95.Business:
								goto IL_0191;
							}
							num3 = 6;
							continue;
						case 0:
							goto IL_0087;
						case 7:
							goto IL_00af;
						case 5:
						case 6:
							result = "未知错误";
							num3 = 11;
							continue;
						case 2:
							kind = Kind;
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
							{
								num3 = 1;
							}
							continue;
						case 10:
							goto IL_0143;
						case 4:
							goto IL_0191;
						case 3:
						case 8:
						case 9:
						case 11:
							{
								return result;
							}
							IL_0191:
							result = "业务错误";
							num = 9;
							break;
							IL_0143:
							result = "网络错误";
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
							{
								num3 = 1;
							}
							continue;
							IL_00af:
							result = "响应格式错误";
							num = 18;
							break;
							IL_0087:
							result = "HTTP 错误";
							num3 = 8;
							continue;
						}
						goto end_IL_000c;
						continue;
						end_IL_0010:
						break;
					}
					continue;
					end_IL_000c:
					break;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public l6vC8LfMXvCYSRCp4C3a(mWGKInfNzSRMjl3TLmeA Slot, g41MUMfNq1DR8G8UnC95 Kind, string Message)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		_Slot_k__BackingField = Slot;
		_Kind_k__BackingField = Kind;
		_Message_k__BackingField = Message;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override string ToString()
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private bool t7afMLyjHeD(StringBuilder builder)
	{
		System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(l6vC8LfMXvCYSRCp4C3a? left, l6vC8LfMXvCYSRCp4C3a? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(l6vC8LfMXvCYSRCp4C3a? left, l6vC8LfMXvCYSRCp4C3a? right)
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0021;
				case 1:
					if (left != null)
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return false;
				case 0:
					return ((l6vC8LfMXvCYSRCp4C3a)left).Equals((l6vC8LfMXvCYSRCp4C3a?)right);
				case 2:
					break;
				}
				goto IL_0065;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_0065;
				IL_0065:
				if (left == right)
				{
					return true;
				}
				num2 = 5;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
				{
					num2 = 1;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected I4, but got Unknown
		return (int)(((EqualityContract * -1521134295 + _Slot_k__BackingField) * -1521134295 + _Kind_k__BackingField) * -1521134295 + _Message_k__BackingField);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as l6vC8LfMXvCYSRCp4C3a);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(l6vC8LfMXvCYSRCp4C3a? other)
	{
		int num = 4;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public l6vC8LfMXvCYSRCp4C3a jiOfMjnPLAU()
	{
		return (l6vC8LfMXvCYSRCp4C3a)new l6vC8LfMXvCYSRCp4C3a(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private l6vC8LfMXvCYSRCp4C3a(l6vC8LfMXvCYSRCp4C3a original)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void uUCfMZXGc31(out mWGKInfNzSRMjl3TLmeA Slot, out g41MUMfNq1DR8G8UnC95 Kind, out string Message)
	{
		Kind = default;
		Message = default;
		Slot = default;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto end_IL_0012;
							}
							goto case 1;
						}
						return;
					case 2:
						num3 = 1;
						continue;
					case 0:
						break;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
						{
							num3 = 0;
						}
						continue;
					}
					goto end_IL_000e;
					continue;
					end_IL_0012:
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool AsewAK9kgeXRE8NknIVw()
	{
		return IBaeHN9kBXmd5KpPmg0j == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static l6vC8LfMXvCYSRCp4C3a F4TMYD9klyxbTkeHUMel()
	{
		return (l6vC8LfMXvCYSRCp4C3a)IBaeHN9kBXmd5KpPmg0j;
	}
}
