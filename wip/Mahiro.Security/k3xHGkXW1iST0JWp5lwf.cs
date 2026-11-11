using System;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace fVk0T8XW33OEoFMbe0uo;

internal sealed class k3xHGkXW1iST0JWp5lwf : IEquatable<k3xHGkXW1iST0JWp5lwf>
{
	[CompilerGenerated]
	private int _ProcessId_k__BackingField;

	[CompilerGenerated]
	private bool _AcceptsLoopback_k__BackingField;

	internal static object arkfbKZlNTNnMRRajPsT;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return System.Type.GetTypeFromHandle(typeof(k3xHGkXW1iST0JWp5lwf).TypeHandle);
		}
	}

	public int ProcessId
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _ProcessId_k__BackingField;
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
						_ProcessId_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				}
			}
			while (num == 989);
		}
	}

	public bool AcceptsLoopback
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _AcceptsLoopback_k__BackingField;
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
						_AcceptsLoopback_k__BackingField = value;
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
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

	[MethodImpl((MethodImplOptions)8)]
	public k3xHGkXW1iST0JWp5lwf(int ProcessId, bool AcceptsLoopback)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		_ProcessId_k__BackingField = ProcessId;
		_AcceptsLoopback_k__BackingField = AcceptsLoopback;
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
	private bool t86XWveTMqk(StringBuilder builder)
	{
		System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(k3xHGkXW1iST0JWp5lwf? left, k3xHGkXW1iST0JWp5lwf? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(k3xHGkXW1iST0JWp5lwf? left, k3xHGkXW1iST0JWp5lwf? right)
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
					if (num == 991)
					{
						goto end_IL_0010;
					}
					goto case 1;
				case 1:
					if (left == null)
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 3;
				case 2:
					if (left != right)
					{
						num2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
						{
							num2 = 1;
						}
						break;
					}
					return true;
				case 3:
					return ((k3xHGkXW1iST0JWp5lwf)left).Equals((k3xHGkXW1iST0JWp5lwf?)right);
				case 0:
					return false;
				}
				continue;
				end_IL_0010:
				break;
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
		//IL_002a: Expected I4, but got Unknown
		return (EqualityContract * -1521134295 + _ProcessId_k__BackingField) * -1521134295 + _AcceptsLoopback_k__BackingField;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as k3xHGkXW1iST0JWp5lwf);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(k3xHGkXW1iST0JWp5lwf? other)
	{
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public k3xHGkXW1iST0JWp5lwf S73XWEdhYA5()
	{
		return (k3xHGkXW1iST0JWp5lwf)new k3xHGkXW1iST0JWp5lwf(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private k3xHGkXW1iST0JWp5lwf(k3xHGkXW1iST0JWp5lwf original)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void CsbXW2iG5MR(out int ProcessId, out bool AcceptsLoopback)
	{
		AcceptsLoopback = default;
		ProcessId = default;
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
							goto case 0;
						}
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
						{
							num3 = 8;
						}
						continue;
					case 2:
						break;
					case 1:
						return;
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
			num = 6;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool xJ64a1ZlMLAl4Xm3y9kU()
	{
		return arkfbKZlNTNnMRRajPsT == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static k3xHGkXW1iST0JWp5lwf yDisIEZlp9ssacI5TDcY()
	{
		return (k3xHGkXW1iST0JWp5lwf)arkfbKZlNTNnMRRajPsT;
	}
}
