using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace aW0F63fMUWngPVl8m3f6;

internal sealed class MKAN8afMhxEAVQM7DhOn : IEquatable<MKAN8afMhxEAVQM7DhOn>
{
	[CompilerGenerated]
	private string _Version_k__BackingField;

	[CompilerGenerated]
	private string _ManifestMd5_k__BackingField;

	[CompilerGenerated]
	private string _ManifestUrl_k__BackingField;

	[CompilerGenerated]
	private string _ExecutableMd5_k__BackingField;

	private static object IFA4oE9keoMm2vAJTKOs;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return System.Type.GetTypeFromHandle(typeof(MKAN8afMhxEAVQM7DhOn).TypeHandle);
		}
	}

	[JsonPropertyName("Version")]
	public string Version
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Version_k__BackingField;
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
					_Version_k__BackingField = value;
					num2 = 6;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
					{
						num2 = 0;
					}
				}
			}
		}
	}

	[JsonPropertyName("Md5")]
	public string ManifestMd5
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _ManifestMd5_k__BackingField;
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
					case 1:
						_ManifestMd5_k__BackingField = value;
						num2 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
						{
							num2 = 0;
						}
						continue;
					case 0:
						return;
					}
					break;
				}
			}
			while (num == 989);
		}
	}

	[JsonPropertyName("Url")]
	public string ManifestUrl
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _ManifestUrl_k__BackingField;
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
					case 1:
						_ManifestUrl_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
						{
							num2 = 2;
						}
						continue;
					case 0:
						return;
					}
					break;
				}
			}
			while (num == 989);
		}
	}

	[JsonPropertyName("ExeMd5")]
	public string ExecutableMd5
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _ExecutableMd5_k__BackingField;
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
					case 0:
						return;
					case 1:
						break;
					}
					goto IL_0031;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0031;
					IL_0031:
					_ExecutableMd5_k__BackingField = value;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
					{
						num2 = 3;
					}
				}
			}
		}
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
	private bool DBCfMrQYCTK(StringBuilder builder)
	{
		int num = 1;
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
						if (num2 != 15)
						{
							if (num2 == 996)
							{
								goto end_IL_0010;
							}
							goto case 7;
						}
						(builder).Append(ManifestUrl);
						num3 = 5;
						continue;
					case 5:
						(builder).Append(", ExecutableMd5 = ");
						num3 = 7;
						continue;
					case 3:
						return true;
					case 6:
						(builder).Append(Version);
						num = 4;
						break;
					case 7:
						(builder).Append(ExecutableMd5);
						num3 = 3;
						continue;
					case 8:
						(builder).Append(", ManifestUrl = ");
						num = 15;
						break;
					case 2:
						(builder).Append(ManifestMd5);
						num3 = 8;
						continue;
					case 0:
						(builder).Append("Version = ");
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
						{
							num3 = 15;
						}
						continue;
					case 1:
						System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee != 0)
						{
							num3 = 0;
						}
						continue;
					case 4:
						(builder).Append(", ManifestMd5 = ");
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
						{
							num3 = 2;
						}
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

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(MKAN8afMhxEAVQM7DhOn? left, MKAN8afMhxEAVQM7DhOn? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(MKAN8afMhxEAVQM7DhOn? left, MKAN8afMhxEAVQM7DhOn? right)
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
					if (num == 990)
					{
						goto end_IL_0010;
					}
					goto case 0;
				case 0:
					if (left != null)
					{
						num2 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e != 0)
						{
							num2 = 2;
						}
						break;
					}
					return false;
				case 1:
					if (left != right)
					{
						num2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 != 0)
						{
							num2 = 0;
						}
						break;
					}
					return true;
				case 2:
					return ((MKAN8afMhxEAVQM7DhOn)left).Equals((MKAN8afMhxEAVQM7DhOn?)right);
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
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected I4, but got Unknown
		return (int)((((EqualityContract * -1521134295 + _Version_k__BackingField) * -1521134295 + _ManifestMd5_k__BackingField) * -1521134295 + _ManifestUrl_k__BackingField) * -1521134295 + _ExecutableMd5_k__BackingField);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as MKAN8afMhxEAVQM7DhOn);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(MKAN8afMhxEAVQM7DhOn? other)
	{
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public MKAN8afMhxEAVQM7DhOn dckfMo1RbFK()
	{
		return (MKAN8afMhxEAVQM7DhOn)new MKAN8afMhxEAVQM7DhOn(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[SetsRequiredMembers]
	[CompilerGenerated]
	private MKAN8afMhxEAVQM7DhOn(MKAN8afMhxEAVQM7DhOn original)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	public MKAN8afMhxEAVQM7DhOn()
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
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
					case 0:
						break;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 != 0)
						{
							num3 = 2;
						}
						continue;
					case 2:
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
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
			num = 4;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool Yr73JN9kPlYpv29pMPRv()
	{
		return IFA4oE9keoMm2vAJTKOs == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static MKAN8afMhxEAVQM7DhOn DMBZEW9kxK3xjACtP16X()
	{
		return (MKAN8afMhxEAVQM7DhOn)IFA4oE9keoMm2vAJTKOs;
	}
}
