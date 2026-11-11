using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;
using irrAk7fuuIVR5Iy3Ssix;
using q6cFd2fu1TbUdv8pP4I2;

namespace WOytwwX3mB2vdxoqjeIN;

internal class l4WCOaX3oQLuT7Hqfrhg
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_56
	{
		public static readonly __c_56 __9;

		public static Func<wSe3XtfuacgO0nXuwqHe, bool> __9__0_0;

		public static Func<wSe3XtfuacgO0nXuwqHe, int> __9__0_1;

		public static Func<wSe3XtfuacgO0nXuwqHe, string> __9__0_2;

		public static Func<wSe3XtfuacgO0nXuwqHe, string> __9__0_3;

		private static __c_56 xnwY4KDZ0TKNNh9o1LMf;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_56()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
			{
				num = 5;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 0:
					return;
				}
				if (num2 == 988)
				{
					num = num2;
					continue;
				}
				return;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool bpjLDs6XkRJ(wSe3XtfuacgO0nXuwqHe item)
		{
			return item.IsCurrentLocation;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal int iP4LDT1CtLF(wSe3XtfuacgO0nXuwqHe item)
		{
			return (item.LocationKind == eTxO5ffupXPaQFO5K2aV.RegisteredClient) ? 1 : 0;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string YhGLDNtA9DG(wSe3XtfuacgO0nXuwqHe item)
		{
			return item.Installation.Version;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string jvLLDM4TiDl(wSe3XtfuacgO0nXuwqHe item)
		{
			return item.Installation.InstallationPath;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool WtrkwTDZ8UtsKimfyNIZ()
		{
			return xnwY4KDZ0TKNNh9o1LMf == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_56 qdFHZQDZyoMqL8OiFWiC()
		{
			return xnwY4KDZ0TKNNh9o1LMf;
		}
	}

	internal static object CdZeB8ZP0C98EiuarulF;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public static global::System.Threading.Tasks.Task<global::System.Collections.Generic.IReadOnlyList<wSe3XtfuacgO0nXuwqHe>> UCOX37eNw4t(object defaultRootPath, object configuredRootPath, global::System.Collections.Generic.IReadOnlyList<string> registeredClientPaths, string? selectedCustomClientPath, bool usesCustomClient, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_ScanAsync_d__0 scanAsync_d__ = default(_ScanAsync_d__0);
		scanAsync_d__.__t__builder = AsyncTaskMethodBuilder<global::System.Collections.Generic.IReadOnlyList<wSe3XtfuacgO0nXuwqHe>>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task ROoX3ApLeG4(object rootPath, eTxO5ffupXPaQFO5K2aV locationKind, bool isCurrentLocation, global::System.Collections.Generic.ICollection<wSe3XtfuacgO0nXuwqHe> results, ISet<string> knownInstallationPaths, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_AddManagedRootAsync_d__1 addManagedRootAsync_d__ = default(_AddManagedRootAsync_d__1);
		addManagedRootAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string X5wX3Iw5ooe(object executablePath)
	{
		int num = 1;
		int num4 = default(int);
		string result = default(string);
		string text2 = default(string);
		int num3 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num5);
		global::System.Exception ex = default(global::System.Exception);
		int num6 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num8 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					FileVersionInfo val = System.Diagnostics.FileVersionInfo.GetVersionInfo((string)executablePath);
					int num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
					{
						num2 = 0;
					}
					while (true)
					{
						string text;
						switch (num2)
						{
						default:
							if (num4 != 17)
							{
								if (num4 == 997)
								{
									goto IL_006b;
								}
								goto case 5;
							}
							return result;
						case 5:
							if (!string.IsNullOrWhiteSpace(text2))
							{
								num2 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
								{
									num2 = 4;
								}
								continue;
							}
							goto case 0;
						case 7:
						case 8:
							if (string.IsNullOrWhiteSpace(text2))
							{
								num2 = 9;
								continue;
							}
							goto case 2;
						case 9:
							break;
						case 1:
							text2 = (val).ProductVersion;
							num2 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
							{
								num2 = 12;
							}
							continue;
						case 2:
							num3 = (text2).IndexOf('+', (StringComparison)4);
							num2 = 4;
							continue;
						case 3:
							text = text2;
							goto IL_0201;
						case 0:
							text2 = (val).FileVersion;
							num2 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
							{
								num2 = 14;
							}
							continue;
						case 4:
							if (num3 <= 0)
							{
								num2 = 3;
								continue;
							}
							text = (text2).Substring(0, num3);
							goto IL_0201;
						case 6:
							break;
							IL_006b:
							num2 = num4;
							continue;
							IL_0201:
							result = text;
							num4 = 17;
							goto IL_006b;
						}
						break;
					}
				}
				catch (global::System.Exception obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj2 = obj as global::System.Exception;
					if (obj2 == null)
					{
						num5 = 3;
					}
					else
					{
						ex = obj2;
						num5 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
						{
							num5 = 1;
						}
					}
					while (true)
					{
						switch (num5)
						{
						default:
							if (num6 != 18)
							{
								if (num6 == 998)
								{
									goto IL_0236;
								}
								goto case 3;
							}
							goto case 1;
						case 0:
							if (ex is IOException)
							{
								num6 = 18;
								goto IL_0236;
							}
							goto case 9;
						case 7:
							if (ex is ArgumentException)
							{
								num5 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
								{
									num5 = 1;
								}
								continue;
							}
							goto case 4;
						case 1:
						case 5:
							flag = true;
							num5 = 6;
							continue;
						case 9:
							if (!(ex is UnauthorizedAccessException))
							{
								num5 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
								{
									num5 = 17;
								}
								continue;
							}
							goto case 1;
						case 4:
							if (!(ex is NotSupportedException))
							{
								num5 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 != 0)
								{
									num5 = 8;
								}
								continue;
							}
							goto case 1;
						case 8:
						case 10:
							flag = false;
							num5 = 2;
							continue;
						case 3:
							result2 = 0;
							break;
						case 2:
						case 6:
							{
								result2 = (flag ? 1 : 0);
								break;
							}
							IL_0236:
							num5 = num6;
							continue;
						}
						break;
					}
					return (byte)result2 != 0;
				}).Invoke())
				{
					int num7 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
					{
						num7 = 1;
					}
					while (true)
					{
						switch (num7)
						{
						default:
							if (num8 == 988)
							{
								num7 = num8;
								continue;
							}
							break;
						case 0:
							break;
						}
						break;
					}
				}
				break;
			}
			break;
		}
		return "自定义客户端";
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool vJ729lZP82xee94f09pE()
	{
		return CdZeB8ZP0C98EiuarulF == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static l4WCOaX3oQLuT7Hqfrhg xclct7ZPykWsQdAfokPZ()
	{
		return (l4WCOaX3oQLuT7Hqfrhg)CdZeB8ZP0C98EiuarulF;
	}
}
