using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using LYCBRkf5Q9nZvTAYjPMZ;
using cTpd1lf54YS57isqnyoi;
using xajTdrzNJetLp9ykLm0;

namespace I8kVvQmUGdEncAIoxaC;

internal class rDf13emhypQ5FFQEmmM
{
	[StructLayout((LayoutKind)0, CharSet = (CharSet)3)]
	internal struct qbbCDuf2M2VA8gjdtCP1
	{
		public uint vlGf2p5n3Cb;

		public uint jwAf2u8v5n6;

		public uint L4kf2axUPk2;

		public uint Pmqf21e4DmG;

		public uint njVf23xFNeG;

		public uint Viwf2vpEuUh;

		public ulong D7Lf2Eu383t;

		public ulong qN0f22wAsEC;

		[MarshalAs((UnmanagedType)23, SizeConst = 97)]
		public string GIAf2qGShJa;
	}

	private delegate uint znZxKuf2Gx7dhTPpZW0L(ref qbbCDuf2M2VA8gjdtCP1 result);

	private static readonly object GbKmlXAEpF;

	private static nint ntkmdpS7sf;

	private static FileStream? fBVmKq6Crr;

	private static object v2QmH7Z8honHJJDfg8hB;

	internal static string InstallationRoot
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_001a: Expected I4, but got O
			//IL_0057->IL000d: Incompatible stack types: I4 vs O
			//IL_0062->IL000d: Incompatible stack types: I4 vs O
			object obj = 1;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj == 989)
						{
							goto end_IL_000d;
						}
						goto case 0;
					case 1:
					{
						string text = System.Environment.ProcessPath;
						if (text != null)
						{
							return System.IO.Path.GetDirectoryName(text);
						}
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
						{
							obj2 = 2;
						}
						break;
					}
					case 0:
						throw new global::System.Exception("bootstrap_bypass");
					}
					continue;
					end_IL_000d:
					break;
				}
			}
		}
	}

	[DllImport("kernel32.dll", CharSet = (CharSet)3, EntryPoint = "LoadLibraryExW", SetLastError = true)]
	private static extern nint unumryWKjc(string path, nint file, uint flags);

	[DllImport("kernel32.dll", EntryPoint = "GetCurrentProcess")]
	private static extern nint bcamomFs1C();

	[DllImport("kernel32.dll", EntryPoint = "TerminateProcess")]
	private static extern bool iiimmE1FOE(nint process, uint exitCode);

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static qbbCDuf2M2VA8gjdtCP1 mWnm7vuQZN()
	{
		lxWmBMIqyT();
		_ = 4;
		object obj = default(object);
		_ = obj.L4kf2axUPk2;
		((AsyncTaskMethodBuilder<NYI398f5COw5dgT3xbBV>*)11)->AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<Ayjhv8f5JJRpAIerOZpd>.ConfiguredTaskAwaiter, RaH7MLzTeomUtlPYRwZ._EnsureHostCoreAsync_d__34>(ref this, ref this);
		return default(qbbCDuf2M2VA8gjdtCP1);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static qbbCDuf2M2VA8gjdtCP1 lvDmADrKv5()
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static nint pI3mIjtv0a(object name)
	{
		//IL_0009: Expected O, but got I4
		//IL_0022: Expected I4, but got O
		//IL_0136: Expected I, but got O
		//IL_0038: Expected O, but got I4
		//IL_00e3: Expected O, but got I
		//IL_00ae: Expected I4, but got O
		//IL_008b->IL009d: Incompatible stack types: I4 vs O
		//IL_004c->IL000d: Incompatible stack types: I4 vs O
		//IL_0068->IL000d: Incompatible stack types: I4 vs O
		//IL_0096->IL009d: Incompatible stack types: I4 vs O
		//IL_0057->IL000d: Incompatible stack types: I4 vs O
		//IL_00d1->IL009d: Incompatible stack types: I4 vs O
		//IL_00f7->IL009d: Incompatible stack types: I4 vs O
		//IL_0102->IL009d: Incompatible stack types: I4 vs O
		object obj = 3;
		object obj3 = default(object);
		object gbKmlXAEpF = default(object);
		object obj5 = default(object);
		object obj6 = default(object);
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					if ((nint)obj == 991)
					{
						goto end_IL_000d;
					}
					goto case 3;
				case 2:
					obj3 = 0;
					obj2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
					{
						obj2 = 5;
					}
					continue;
				case 3:
					gbKmlXAEpF = GbKmlXAEpF;
					obj2 = 2;
					continue;
				case 0:
				{
					System.Threading.Monitor.Enter(gbKmlXAEpF, ref obj3);
					object obj4 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
					{
						obj4 = 4;
					}
					while (true)
					{
						switch ((int)obj4)
						{
						default:
							if ((nint)obj5 == 990)
							{
								obj4 = obj5;
								continue;
							}
							goto case 2;
						case 0:
							mWnm7vuQZN();
							obj4 = 2;
							continue;
						case 2:
							obj6 = System.Runtime.InteropServices.NativeLibrary.GetExport(ntkmdpS7sf, (string)name);
							obj4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e == 0)
							{
								obj4 = 7;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
					break;
				}
				case 1:
					break;
				}
				return (nint)obj6;
				continue;
				end_IL_000d:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static void lxWmBMIqyT()
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void NxkmgBHGr9()
	{
		//IL_0009: Expected O, but got I4
		//IL_001a: Expected I4, but got O
		//IL_0063: Expected I4, but got O
		//IL_0048->IL005a: Incompatible stack types: I4 vs O
		//IL_0053->IL005a: Incompatible stack types: I4 vs O
		object obj = 1;
		do
		{
			switch ((int)obj)
			{
			default:
				continue;
			case 0:
				return;
			case 1:
				break;
			}
			break;
		}
		while ((nint)obj == 989);
		lxWmBMIqyT();
		object obj2 = 0;
		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
		{
			obj2 = 6;
		}
		object obj3 = default(object);
		while (true)
		{
			switch ((int)obj2)
			{
			case 0:
				return;
			}
			if ((nint)obj3 != 988)
			{
				return;
			}
			obj2 = obj3;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool a1ssZyZ8UDfQaSa2bKo9()
	{
		return v2QmH7Z8honHJJDfg8hB == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static extern rDf13emhypQ5FFQEmmM XXYadqZ8rUxY3qg21gb7();
}
