using System;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Threading;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace iUvcWjR7kFMiLwhnTbh;

internal class tB4TtRRmIMqW0EPX3jQ
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_156
	{
		public static __c_156 __9;

		public static Func<string, bool> __9__3_0;

		internal static __c_156 qyXq7h97todX8pqxL551;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			int num = 4;
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
						case 0:
							HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							return;
						case 4:
							num3 = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
							{
								num3 = 3;
							}
							continue;
						case 2:
							__9 = (__c_156)new __c_156();
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
							{
								num3 = 0;
							}
							continue;
						case 3:
							goto end_IL_000e;
						}
						switch (num2)
						{
						case 992:
							break;
						default:
							return;
						case 11:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
							{
								num3 = 7;
							}
							continue;
						}
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				num = 11;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
				{
					num = 0;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_156()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool TC5fGJwAS1B(string segment)
		{
			return (segment).Contains(':');
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool VZwqxw97OFpgChnbjcN5()
		{
			return qyXq7h97todX8pqxL551 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_156 kmmc5H975lbH25x7hF6d()
		{
			return qyXq7h97todX8pqxL551;
		}
	}

	private static object BalXdKZQTJm1vmALLsoN;

	[MethodImpl((MethodImplOptions)8)]
	internal static void neIRAZ5SbM(object archivePath, object destinationPath, object limits, CancellationToken cancellationToken)
	{
		object obj = default(object);
		S7gRBZpSMa(destinationPath, (obj).FullName);
		_ = 2;
		B1dRghxEqh(obj);
		_ = 16;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388;
		_ = 8;
		object obj2 = default(object);
		obj = obj2;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void XQWRIsgVir(object archivePath, object destinationPath, CancellationToken cancellationToken)
	{
		object obj = FmLRldMx9u(System.IO.Path.GetFullPath((string)archivePath));
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string S7gRBZpSMa(object destinationPath, object entryName)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void B1dRghxEqh(object entry)
	{
		//IL_000c: Expected O, but got I4
		//IL_001d: Expected I4, but got O
		//IL_0068->IL0010: Incompatible stack types: I4 vs O
		//IL_0073->IL0010: Incompatible stack types: I4 vs O
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
						goto end_IL_0010;
					}
					goto case 0;
				case 1:
					if ((((entry).ExternalAttributes >> 16) & 0xFFFF & 0xF000) != 40960)
					{
						return;
					}
					obj2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
					{
						obj2 = 6;
					}
					break;
				case 0:
					throw new global::System.Exception("ZIP 压缩包不能包含符号链接");
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static ZipArchive FmLRldMx9u(object archivePath)
	{
		//IL_000c: Expected O, but got I4
		//IL_001d: Expected I4, but got O
		//IL_0070: Expected I4, but got O
		//IL_00c5: Expected I4, but got O
		//IL_0055->IL0067: Incompatible stack types: I4 vs O
		//IL_0060->IL0067: Incompatible stack types: I4 vs O
		//IL_00a6->IL00b8: Incompatible stack types: I4 vs O
		//IL_00b1->IL00b8: Incompatible stack types: I4 vs O
		//IL_00f0->IL00b8: Incompatible stack types: I4 vs O
		//IL_00fb->IL00b8: Incompatible stack types: I4 vs O
		object obj = 1;
		object obj4 = default(object);
		object obj6 = default(object);
		object result = default(object);
		do
		{
			switch ((int)obj)
			{
			default:
				continue;
			case 0:
				break;
			case 1:
			{
				object obj2 = System.IO.Compression.ZipFile.OpenRead((string)archivePath);
				object obj3 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
				{
					obj3 = 5;
				}
				while (true)
				{
					switch ((int)obj3)
					{
					default:
						if ((nint)obj4 == 988)
						{
							goto IL_0063;
						}
						break;
					case 0:
						break;
					}
					break;
					IL_0063:
					obj3 = obj4;
				}
				(obj2).Entries;
				object obj5 = 5;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
				{
					obj5 = 0;
				}
				while (true)
				{
					switch ((int)obj5)
					{
					case 1:
						break;
					default:
						if ((nint)obj6 == 989)
						{
							obj5 = obj6;
							continue;
						}
						goto case 0;
					case 0:
						result = obj2;
						obj5 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
						{
							obj5 = 1;
						}
						continue;
					}
					break;
				}
				break;
			}
			}
			break;
		}
		while ((nint)obj == 989);
		return (ZipArchive)result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_000e: Expected O, but got I4
		//IL_0023: Expected I4, but got O
		//IL_0082->IL0012: Incompatible stack types: I4 vs O
		//IL_005d->IL0012: Incompatible stack types: I4 vs O
		//IL_008d->IL0012: Incompatible stack types: I4 vs O
		//IL_0068->IL0012: Incompatible stack types: I4 vs O
		int num = 1;
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj != 9)
						{
							if ((nint)obj == 990)
							{
								goto end_IL_0012;
							}
							goto case 0;
						}
						return;
					case 1:
						obj2 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 != 0)
						{
							obj2 = 0;
						}
						continue;
					case 0:
						obj2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 != 0)
						{
							obj2 = 1;
						}
						continue;
					case 2:
						break;
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
			num = 8;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool U6yVuiZQNuPqW6KT9p1Y()
	{
		return BalXdKZQTJm1vmALLsoN == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static tB4TtRRmIMqW0EPX3jQ O96pyyZQMxj8bvHxmCp7()
	{
		return (tB4TtRRmIMqW0EPX3jQ)BalXdKZQTJm1vmALLsoN;
	}
}
