using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading.Tasks;
using AR0yDHKcbVJbe6i6hLY;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;
using fUDsJ6BQ7ckRIATO2pq;
using lAjkfaXVSBCegmUP30wv;

namespace m133jJK4aGTkYCX9JA5;

internal sealed class bjOfPlKCMWgTdY9HF6p
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_146
	{
		public static __c_146 __9;

		public static Func<FileInfo, bool> __9__7_0;

		public static Func<FileInfo, global::System.DateTime> __9__7_1;

		public static Func<FileInfo, long> __9__8_0;

		private static __c_146 oKpOf99reMWQFSAZHj29;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
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
							if (num2 != 11)
							{
								if (num2 == 992)
								{
									goto end_IL_0012;
								}
								goto case 3;
							}
							num = 3;
							break;
						case 3:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
							{
								num3 = 7;
							}
							continue;
						case 0:
							HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
							num3 = 4;
							continue;
						case 4:
							__9 = (__c_146)new __c_146();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
							{
								num3 = 2;
							}
							continue;
						case 2:
							return;
						case 1:
							num = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
							{
								num = 11;
							}
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
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_146()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool fdxfqK47iep(FileInfo file)
		{
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Invalid comparison between Unknown and I4
			int num = 2;
			Guid val = default(Guid);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_0021;
					case 2:
						if (!System.Guid.TryParseExact(System.IO.Path.GetFileNameWithoutExtension((file).Name), "D", out val))
						{
							num2 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 0;
					case 0:
						return ((file).Attributes & 0x400) == 0;
					case 1:
						break;
					}
					goto IL_00bb;
					IL_0021:
					if (num == 990)
					{
						break;
					}
					goto IL_00bb;
					IL_00bb:
					return false;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.DateTime jgUfqHeYvWh(FileInfo file)
		{
			return (file).LastWriteTimeUtc;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal long Q8ifqtGDUW5(FileInfo file)
		{
			return (file).Length;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool OlA7mv9rPcXwIvn7F4P6()
		{
			return oKpOf99reMWQFSAZHj29 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_146 f4k8KX9rxfULPsrmvcuq()
		{
			return oKpOf99reMWQFSAZHj29;
		}
	}

	internal static readonly object IDtK7cNaYD;

	private readonly object RwUKAIuk8C;

	private static object mMtJncZWFpC6qNZ37CmI;

	[MethodImpl((MethodImplOptions)8)]
	internal bjOfPlKCMWgTdY9HF6p(string? directory = null)
	{
		//IL_0051: Expected O, but got I4
		RwUKAIuk8C = System.IO.Path.GetFullPath(directory ?? System.IO.Path.Combine((string)28, "Chronal", "security-decoy-outbox"));
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe string OGMKhlCkF3(string id)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		object rwUKAIuk8C = RwUKAIuk8C;
		object obj = System.Guid.Parse(id);
		return System.IO.Path.Combine((string)rwUKAIuk8C, string.Concat((obj).ToString("D"), ".json"));
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe void Save(vNIX0hKSxIjAmGCLN6M pending)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		string text = ".";
		object obj = System.Guid.NewGuid();
		object obj3 = default(object);
		object obj2 = string.Concat((string)obj3, text, (obj).ToString("N"), ".tmp");
	}

	[MethodImpl((MethodImplOptions)8)]
	internal global::System.Collections.Generic.IReadOnlyList<vNIX0hKSxIjAmGCLN6M> StUKUgC3ci()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		object obj2 = default(object);
		object obj = System.Text.Json.JsonDocument.Parse((ReadOnlyMemory<byte>)System.IO.File.ReadAllBytes((obj2).FullName), (JsonDocumentOptions)default(TaskCompletionSource<>));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void Xo2KrNK8TD(string id)
	{
		//IL_000c: Expected O, but got I4
		//IL_0025: Expected I4, but got O
		//IL_0063->IL0010: Incompatible stack types: I4 vs O
		//IL_007f->IL0010: Incompatible stack types: I4 vs O
		//IL_00d0->IL0010: Incompatible stack types: I4 vs O
		//IL_006e->IL0010: Incompatible stack types: I4 vs O
		//IL_00db->IL0010: Incompatible stack types: I4 vs O
		int num = 1;
		object obj3 = default(object);
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
						if ((nint)obj != 10)
						{
							if ((nint)obj == 991)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						return;
					case 1:
						obj3 = OGMKhlCkF3(id);
						obj2 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 3:
						DVa8HQBJwHORSpqNroT.KbPBrNhrEb(obj3);
						obj2 = 2;
						continue;
					case 2:
						break;
					case 0:
						if (!System.IO.File.Exists((string)obj3))
						{
							return;
						}
						obj2 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
						{
							obj2 = 10;
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
			System.IO.File.Delete((string)obj3);
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
			{
				num = 10;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private FileInfo[] AV2KoVlg45()
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe void JmLKmefN4j()
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool F8LeNDZWsmMsVeMJ8DxA()
	{
		return mMtJncZWFpC6qNZ37CmI == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bjOfPlKCMWgTdY9HF6p zuVJj0ZWT4neK3KYujZS()
	{
		return (bjOfPlKCMWgTdY9HF6p)mMtJncZWFpC6qNZ37CmI;
	}
}
