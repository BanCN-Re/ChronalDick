using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace e5Wu0CXeClRDwU7shqdf;

internal sealed class TskRBqXeQChlIH5eQbGM : IEquatable<TskRBqXeQChlIH5eQbGM>
{
	[CompilerGenerated]
	private string _ChunkId_k__BackingField;

	[CompilerGenerated]
	private uint _ChunkSize_k__BackingField;

	[CompilerGenerated]
	private uint _DecompressSize_k__BackingField;

	[CompilerGenerated]
	private Uri _Url_k__BackingField;

	internal static object qd48UKZ6OSQcu1m8TcD1;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return System.Type.GetTypeFromHandle(typeof(TskRBqXeQChlIH5eQbGM).TypeHandle);
		}
	}

	public string ChunkId
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _ChunkId_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_ChunkId_k__BackingField = value;
		}
	}

	public uint ChunkSize
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _ChunkSize_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_ChunkSize_k__BackingField = value;
		}
	}

	public uint DecompressSize
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _DecompressSize_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_DecompressSize_k__BackingField = value;
		}
	}

	public Uri Url
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Url_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_Url_k__BackingField = value;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public TskRBqXeQChlIH5eQbGM(string ChunkId, uint ChunkSize, uint DecompressSize, Uri Url)
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
	private bool Wk9Xe4Ihhct(StringBuilder builder)
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
							goto case 8;
						}
						(builder).Append(((object)ChunkSize/*cast due to .constrained prefix*/).ToString());
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
						{
							num3 = 2;
						}
						continue;
					case 6:
						break;
					case 3:
						(builder).Append(Url);
						num3 = 4;
						continue;
					case 1:
						System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
						{
							num3 = 0;
						}
						continue;
					case 2:
						(builder).Append(((object)DecompressSize/*cast due to .constrained prefix*/).ToString());
						num3 = 8;
						continue;
					case 7:
						(builder).Append(ChunkId);
						num3 = 6;
						continue;
					case 0:
						(builder).Append("ChunkId = ");
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
						{
							num3 = 12;
						}
						continue;
					case 5:
						(builder).Append(", DecompressSize = ");
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
						{
							num3 = 2;
						}
						continue;
					case 4:
						return true;
					case 8:
						(builder).Append(", Url = ");
						num3 = 3;
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
			(builder).Append(", ChunkSize = ");
			num = 4;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
			{
				num = 15;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(TskRBqXeQChlIH5eQbGM? left, TskRBqXeQChlIH5eQbGM? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(TskRBqXeQChlIH5eQbGM? left, TskRBqXeQChlIH5eQbGM? right)
	{
		int num = 2;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return (((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_ChunkId_k__BackingField)) * -1521134295 + EqualityComparer<uint>.Default.GetHashCode(_ChunkSize_k__BackingField)) * -1521134295 + EqualityComparer<uint>.Default.GetHashCode(_DecompressSize_k__BackingField)) * -1521134295 + EqualityComparer<Uri>.Default.GetHashCode(_Url_k__BackingField);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as TskRBqXeQChlIH5eQbGM);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(TskRBqXeQChlIH5eQbGM? other)
	{
		int num = 4;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public TskRBqXeQChlIH5eQbGM QBaXehmBXdW()
	{
		return (TskRBqXeQChlIH5eQbGM)new TskRBqXeQChlIH5eQbGM(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private TskRBqXeQChlIH5eQbGM(TskRBqXeQChlIH5eQbGM original)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void VBGXeUuXoMV(out string ChunkId, out uint ChunkSize, out uint DecompressSize, out Uri Url)
	{
		ChunkId = default(string);
		ChunkSize = default(uint);
		DecompressSize = default(uint);
		Url = default(Uri);
		//IL_0009: Expected I8, but got O
		Url = this.Url;  // was (X)(long) cast
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool k8w0anZ65GsEymiGHfgJ()
	{
		return qd48UKZ6OSQcu1m8TcD1 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static TskRBqXeQChlIH5eQbGM XUMDsmZ66f4LbbYdE5wN()
	{
		return (TskRBqXeQChlIH5eQbGM)qd48UKZ6OSQcu1m8TcD1;
	}
}
