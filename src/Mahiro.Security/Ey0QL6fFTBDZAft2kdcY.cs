using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using VjE5SEfF1jFqoXERFs8D;
using fDAldojjppXrctUVYOJn;

namespace fE4mDAfFNf7wIO5LaufQ;

public sealed class Ey0QL6fFTBDZAft2kdcY : IEquatable<Ey0QL6fFTBDZAft2kdcY>
{
	[CompilerGenerated]
	private string _Name_k__BackingField;

	[CompilerGenerated]
	private Uri _DownloadUri_k__BackingField;

	[CompilerGenerated]
	private long _Size_k__BackingField;

	[CompilerGenerated]
	private string _Md5_k__BackingField;

	[CompilerGenerated]
	private wmcm4tfFaOwY8gi5SEsC _Kind_k__BackingField;

	[CompilerGenerated]
	private string _HashAlgorithm_k__BackingField;

	internal static object A3ebV79ZFPcJkRiBrwHl;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return System.Type.GetTypeFromHandle(typeof(Ey0QL6fFTBDZAft2kdcY).TypeHandle);
		}
	}

	public string Name
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Name_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_Name_k__BackingField = value;
		}
	}

	public Uri DownloadUri
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _DownloadUri_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_DownloadUri_k__BackingField = value;
		}
	}

	public long Size
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Size_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_Size_k__BackingField = value;
		}
	}

	public string Md5
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Md5_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_Md5_k__BackingField = value;
		}
	}

	public wmcm4tfFaOwY8gi5SEsC Kind
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
			_Kind_k__BackingField = value;
		}
	}

	public string HashAlgorithm
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _HashAlgorithm_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_HashAlgorithm_k__BackingField = value;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public Ey0QL6fFTBDZAft2kdcY(string Name, Uri DownloadUri, long Size, string Md5, wmcm4tfFaOwY8gi5SEsC Kind)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private bool JpefFM9vc9a(StringBuilder builder)
	{
		int num = 11;
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
						if (num2 != 19)
						{
							if (num2 == 1000)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						(builder).Append(", Kind = ");
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
						{
							num3 = 13;
						}
						continue;
					case 6:
						(builder).Append(HashAlgorithm);
						num3 = 7;
						continue;
					case 5:
						(builder).Append(", DownloadUri = ");
						num3 = 2;
						continue;
					case 8:
						(builder).Append(", Md5 = ");
						num3 = 4;
						continue;
					case 10:
						(builder).Append("Name = ");
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
						{
							num3 = 1;
						}
						continue;
					case 1:
						(builder).Append(Name);
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 != 0)
						{
							num3 = 16;
						}
						continue;
					case 3:
						(builder).Append(", Size = ");
						num = 12;
						break;
					case 0:
						(builder).Append(((object)Kind/*cast due to .constrained prefix*/).ToString());
						num = 9;
						break;
					case 7:
						return true;
					case 12:
						(builder).Append(((object)Size/*cast due to .constrained prefix*/).ToString());
						num3 = 8;
						continue;
					case 4:
						(builder).Append(Md5);
						num = 19;
						break;
					case 9:
						(builder).Append(", HashAlgorithm = ");
						num3 = 15;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
						{
							num3 = 6;
						}
						continue;
					case 11:
						System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
						num3 = 10;
						continue;
					case 2:
						(builder).Append(DownloadUri);
						num = 3;
						break;
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
	public static bool operator !=(Ey0QL6fFTBDZAft2kdcY? left, Ey0QL6fFTBDZAft2kdcY? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(Ey0QL6fFTBDZAft2kdcY? left, Ey0QL6fFTBDZAft2kdcY? right)
	{
		int num = 1;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return (((((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_Name_k__BackingField)) * -1521134295 + EqualityComparer<Uri>.Default.GetHashCode(_DownloadUri_k__BackingField)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(_Size_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_Md5_k__BackingField)) * -1521134295 + EqualityComparer<wmcm4tfFaOwY8gi5SEsC>.Default.GetHashCode(_Kind_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_HashAlgorithm_k__BackingField);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as Ey0QL6fFTBDZAft2kdcY);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(Ey0QL6fFTBDZAft2kdcY? other)
	{
		int num = 3;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public Ey0QL6fFTBDZAft2kdcY C6ZfFpYa7bM()
	{
		return (Ey0QL6fFTBDZAft2kdcY)new Ey0QL6fFTBDZAft2kdcY(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private Ey0QL6fFTBDZAft2kdcY(Ey0QL6fFTBDZAft2kdcY original)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void jd8fFuFCAk8(out string Name, out Uri DownloadUri, out long Size, out string Md5, out wmcm4tfFaOwY8gi5SEsC Kind)
	{
		Name = default(string);
		DownloadUri = default(Uri);
		Size = default(long);
		Md5 = default(string);
		Kind = default(wmcm4tfFaOwY8gi5SEsC);
		//IL_0008: Expected I8, but got O
Name = this.Name;  // was Unsafe.As<_,long> reinterpret
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool rd58bO9ZstmNafjGfkG7()
	{
		return A3ebV79ZFPcJkRiBrwHl == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Ey0QL6fFTBDZAft2kdcY CRbqGX9ZTs8mPNPrKnkV()
	{
		return (Ey0QL6fFTBDZAft2kdcY)A3ebV79ZFPcJkRiBrwHl;
	}
}
