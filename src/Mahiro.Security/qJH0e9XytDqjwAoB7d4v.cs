using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using Vmo4hVXyvmIwyQZjF3Zr;
using fDAldojjppXrctUVYOJn;

namespace PyjoTWXyOLcrwNbVqhBg;

internal sealed class qJH0e9XytDqjwAoB7d4v : IEquatable<qJH0e9XytDqjwAoB7d4v>
{
	[CompilerGenerated]
	private int MD4XyP1VWJk;

	[CompilerGenerated]
	private string xaJXyx59g0G;

	[CompilerGenerated]
	private string ArCXyFKM616;

	[CompilerGenerated]
	private string nJnXys5jfFX;

	[CompilerGenerated]
	private string[] gRJXyTKr8nr;

	[CompilerGenerated]
	private string lMbXyNZrrDf;

	[CompilerGenerated]
	private string rKbXyMHYmKj;

	internal static object IfGqALZl82NuQgi7a7hw;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return System.Type.GetTypeFromHandle(typeof(qJH0e9XytDqjwAoB7d4v).TypeHandle);
		}
	}

	public int Schema
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return MD4XyP1VWJk;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			MD4XyP1VWJk = value;
		}
	}

	public string Version
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return xaJXyx59g0G;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			xaJXyx59g0G = value;
		}
	}

	public string InjectorSha256
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return ArCXyFKM616;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			ArCXyFKM616 = value;
		}
	}

	public string LibrarySha256
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return nJnXys5jfFX;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			nJnXys5jfFX = value;
		}
	}

	public string[] LogPaths
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return gRJXyTKr8nr;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			gRJXyTKr8nr = value;
		}
	}

	public string InjectorFileName
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return lMbXyNZrrDf;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			lMbXyNZrrDf = value;
		}
	}

	public string LibraryFileName
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return rKbXyMHYmKj;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			rKbXyMHYmKj = value;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public qJH0e9XytDqjwAoB7d4v(int Schema, string Version, string InjectorSha256, string LibrarySha256, string[] LogPaths)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static qJH0e9XytDqjwAoB7d4v QcyXy55kZtS(object bundle)
	{
		qJH0e9XytDqjwAoB7d4v qJH0e9XytDqjwAoB7d4v2 = default(qJH0e9XytDqjwAoB7d4v);
		dc4Xy6MDxU5(((lZn07CXy3xSIHfSN5qv4)bundle).LibraryPath, qJH0e9XytDqjwAoB7d4v2.LibrarySha256);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void dc4Xy6MDxU5(object path, object expected)
	{
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		FileStream val = default(FileStream);
		int num4 = default(int);
		int num6 = default(int);
		do
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					try
					{
						if ((System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData((Stream)(object)val))).Equals((string)expected, (StringComparison)4))
						{
							return;
						}
						int num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 == 988)
								{
									goto IL_0089;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_0089:
							num3 = num4;
						}
						throw new InvalidDataException(string.Concat("Java 组件 SHA-256 不匹配：", System.IO.Path.GetFileName((string)path), "。请恢复同一配对版本的完整组件包。"));
					}
					finally
					{
						int num5;
						if (val == null)
						{
							num5 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
							{
								num5 = 7;
							}
							goto IL_013d;
						}
						goto IL_0161;
						IL_013d:
						while (true)
						{
							switch (num5)
							{
							default:
								if (num6 == 990)
								{
									goto IL_0139;
								}
								goto end_IL_013d;
							case 0:
								break;
							case 1:
								goto end_IL_013d;
							case 2:
								goto end_IL_013d;
							}
							goto IL_0161;
							IL_0139:
							num5 = num6;
							continue;
							end_IL_013d:
							break;
						}
						goto end_IL_0105;
						IL_0161:
						(val).Dispose();
						num5 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
						{
							num5 = 0;
						}
						goto IL_013d;
						end_IL_0105:;
					}
				case 2:
					val = System.IO.File.Open((string)path, (FileMode)3, (FileAccess)1, (FileShare)1);
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
					{
						num2 = 5;
					}
					continue;
				case 0:
					return;
				}
				break;
			}
		}
		while (num == 990);
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
	private bool gk8XyR2vnKg(StringBuilder builder)
	{
		System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(qJH0e9XytDqjwAoB7d4v? left, qJH0e9XytDqjwAoB7d4v? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(qJH0e9XytDqjwAoB7d4v? left, qJH0e9XytDqjwAoB7d4v? right)
	{
		int num = 2;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return ((((((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MD4XyP1VWJk)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(xaJXyx59g0G)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ArCXyFKM616)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nJnXys5jfFX)) * -1521134295 + EqualityComparer<string[]>.Default.GetHashCode(gRJXyTKr8nr)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(lMbXyNZrrDf)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(rKbXyMHYmKj);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as qJH0e9XytDqjwAoB7d4v);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(qJH0e9XytDqjwAoB7d4v? other)
	{
		int num = 6;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public qJH0e9XytDqjwAoB7d4v fNsXywKhm7c()
	{
		return (qJH0e9XytDqjwAoB7d4v)new qJH0e9XytDqjwAoB7d4v(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private qJH0e9XytDqjwAoB7d4v(qJH0e9XytDqjwAoB7d4v original)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void uoiXyeq679X(out int Schema, out string Version, out string InjectorSha256, out string LibrarySha256, out string[] LogPaths)
	{
		Schema = default(int);
		Version = default(string);
		InjectorSha256 = default(string);
		LibrarySha256 = default(string);
		LogPaths = default(string[]);
		//IL_0008: Expected I8, but got O
Version = this.Version;  // was Unsafe.As<_,long> reinterpret
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool NYjQvIZly8bBapSZVbSc()
	{
		return IfGqALZl82NuQgi7a7hw == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static qJH0e9XytDqjwAoB7d4v tFKFqyZlW6YR9xIfMgWI()
	{
		return (qJH0e9XytDqjwAoB7d4v)IfGqALZl82NuQgi7a7hw;
	}
}
