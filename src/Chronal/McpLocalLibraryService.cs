using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using Mahiro_Account.Features.McpStudio.Models;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Features.McpStudio.Services;

internal sealed class McpLocalLibraryService
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_1
	{
		public static readonly __c_1 __9;

		public static Func<string, string> __9__8_1;

		internal static __c_1 tloUl6L2CsKioHhfURsn;

		[MethodImpl((MethodImplOptions)8)]
		static __c_1()
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
							if (num2 == 10)
							{
								num3 = 0;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b84585b58c384b95b0e0b94c466ccc55 == 0)
								{
									num3 = 5;
								}
								continue;
							}
							goto IL_0035;
						case 2:
							num3 = 0;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bd86dbd500ab43b1bb4264e56ddd52b4 == 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							goto end_IL_000e;
						case 0:
							break;
						case 3:
							return;
						}
						goto IL_009f;
						IL_0035:
						if (num2 == 991)
						{
							break;
						}
						goto IL_009f;
						IL_009f:
						__9 = (__c_1)new __c_1();
						num3 = 3;
					}
					continue;
					end_IL_000e:
					break;
				}
				num = 10;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_1()
		{
			//IL_004c: Expected I4, but got O
			//IL_0031->IL0043: Incompatible stack types: I4 vs O
			//IL_003c->IL0043: Incompatible stack types: I4 vs O
			object obj = 3;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f102566966284916b14bc7efa63c0f5e != 0)
			{
				obj = 0;
			}
			object obj2 = default(object);
			while (true)
			{
				switch ((int)obj)
				{
				case 0:
					return;
				}
				if ((nint)obj2 == 988)
				{
					obj = obj2;
					continue;
				}
				return;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string _ListAsync_b__8_1(string path)
		{
			return path;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool zqwLw1L24Y4kYd6DanLh()
		{
			return tloUl6L2CsKioHhfURsn == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_1 iubmFtL2h0Jk5NV2lURk()
		{
			return tloUl6L2CsKioHhfURsn;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass10_0
	{
		public string path;

		internal static __c__DisplayClass10_0 BMuL91L2UvuxQtAPK8he;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass10_0()
		{
			//IL_004c: Expected I4, but got O
			//IL_0031->IL0043: Incompatible stack types: I4 vs O
			//IL_003c->IL0043: Incompatible stack types: I4 vs O
			object obj = 0;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_6143552ba66645398402f7404618079f == 0)
			{
				obj = 0;
			}
			object obj2 = default(object);
			while (true)
			{
				switch ((int)obj)
				{
				case 0:
					return;
				}
				if ((nint)obj2 == 988)
				{
					obj = obj2;
					continue;
				}
				return;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _RemoveAsync_b__0()
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_0055->IL0010: Incompatible stack types: I4 vs O
			//IL_0060->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			do
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 0:
						return;
					case 1:
						System.IO.File.Delete(path);
						obj2 = 1;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e1a4b1278f5749c28fff394e2932a022 != 0)
						{
							obj2 = 0;
						}
						continue;
					}
					break;
				}
			}
			while ((nint)obj == 989);
		}

		[MethodImpl((MethodImplOptions)8)]
		static __c__DisplayClass10_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool Swfg5uL2r3jojdwvuAKa()
		{
			return BMuL91L2UvuxQtAPK8he == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass10_0 YklbcTL2o4BhKTjcrcUo()
		{
			return BMuL91L2UvuxQtAPK8he;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass8_0_1
	{
		public McpLocalLibraryService __4__this;

		public ISet<string> injectedPaths;

		public Func<string, McpLocalFile> __9__2;

		internal static __c__DisplayClass8_0_1 j3RmnHL2mTPlCMlKr8Iy;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass8_0_1()
		{
			//IL_004c: Expected I4, but got O
			//IL_0031->IL0043: Incompatible stack types: I4 vs O
			//IL_003c->IL0043: Incompatible stack types: I4 vs O
			object obj = 0;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_13568c2ecd3e40679d0e8ed63093dad4 != 0)
			{
				obj = 1;
			}
			object obj2 = default(object);
			while (true)
			{
				switch ((int)obj)
				{
				case 0:
					return;
				}
				if ((nint)obj2 == 988)
				{
					obj = obj2;
					continue;
				}
				return;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Collections.Generic.IReadOnlyList<McpLocalFile> _ListAsync_b__0()
		{
			//IL_000c: Expected O, but got I4
			//IL_0021: Expected I4, but got O
			//IL_0093->IL0010: Incompatible stack types: I4 vs O
			//IL_005e->IL0010: Incompatible stack types: I4 vs O
			//IL_009e->IL0010: Incompatible stack types: I4 vs O
			//IL_0069->IL0010: Incompatible stack types: I4 vs O
			object obj = 2;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj == 990)
						{
							goto end_IL_0010;
						}
						goto case 1;
					case 2:
						System.IO.Directory.CreateDirectory(__4__this.PendingPath);
						obj2 = 1;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9608fe64d13146acb5eaea30e653fb87 != 0)
						{
							obj2 = 2;
						}
						break;
					case 1:
						System.IO.Directory.CreateDirectory(__4__this.InjectedPath);
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0003dce1a8644b9dbbca586828352343 != 0)
						{
							obj2 = 3;
						}
						break;
					case 0:
						return (global::System.Collections.Generic.IReadOnlyList<McpLocalFile>)Enumerable.ToList<McpLocalFile>(Enumerable.Select<string, McpLocalFile>((global::System.Collections.Generic.IEnumerable<string>)Enumerable.ToArray<string>((global::System.Collections.Generic.IEnumerable<string>)Enumerable.OrderBy<string, string>(Enumerable.Concat<string>(System.IO.Directory.EnumerateFiles(__4__this.PendingPath, "*.mcp", (SearchOption)0), System.IO.Directory.EnumerateFiles(__4__this.InjectedPath, "*.mcp", (SearchOption)0)), (Func<string, string>)__c_1.__9._ListAsync_b__8_1, (IComparer<string>)(object)System.StringComparer.OrdinalIgnoreCase)), (Func<string, McpLocalFile>)([MethodImpl((MethodImplOptions)8)] (string path) =>
						{
							//IL_000c: Expected O, but got I4
							//IL_001d: Expected I4, but got O
							//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
							//IL_00a8: Expected O, but got Unknown
							//IL_00bc->IL0010: Incompatible stack types: I4 vs O
							//IL_00c7->IL0010: Incompatible stack types: I4 vs O
							dynamic obj3 = 1;
							dynamic obj5 = default(object);
							while (true)
							{
								dynamic obj4 = obj3;
								while (true)
								{
									switch ((int)obj4)
									{
									default:
										goto IL_001d;
									case 0:
										return (McpLocalFile)new McpLocalFile
										{
											FilePath = ((dynamic)obj5).FullName,
											SizeBytes = ((string)obj5).Length,
											LastWriteTime = ((dynamic)obj5).LastWriteTime,
											EntryModule = McpFileMetadata.ReadEntry(((dynamic)obj5).FullName),
											IsInjected = ((global::System.Collections.Generic.ICollection<string>)injectedPaths).Contains(((dynamic)obj5).FullName)
										};
									case 1:
										break;
									}
									goto IL_00a0;
									IL_001d:
									if ((nint)obj3 == 989)
									{
										break;
									}
									goto IL_00a0;
									IL_00a0:
									obj5 = new FileInfo(path);
									obj4 = 0;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2aab0405e3774254ad8ff3552d808a1d == 0)
									{
										obj4 = 6;
									}
								}
							}
						})));
					}
					continue;
					end_IL_0010:
					break;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal McpLocalFile _ListAsync_b__2(string path)
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			//IL_00bc->IL0010: Incompatible stack types: I4 vs O
			//IL_00c7->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			dynamic obj3 = default(object);
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						goto IL_001d;
					case 0:
						return (McpLocalFile)new McpLocalFile
						{
							FilePath = ((dynamic)obj3).FullName,
							SizeBytes = ((string)obj3).Length,
							LastWriteTime = ((dynamic)obj3).LastWriteTime,
							EntryModule = McpFileMetadata.ReadEntry(((dynamic)obj3).FullName),
							IsInjected = ((global::System.Collections.Generic.ICollection<string>)injectedPaths).Contains(((dynamic)obj3).FullName)
						};
					case 1:
						break;
					}
					goto IL_00a0;
					IL_001d:
					if ((nint)obj == 989)
					{
						break;
					}
					goto IL_00a0;
					IL_00a0:
					obj3 = new FileInfo(path);
					obj2 = 0;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2aab0405e3774254ad8ff3552d808a1d == 0)
					{
						obj2 = 6;
					}
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		static __c__DisplayClass8_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool NedXIZL27EfN9mmoUlJa()
		{
			return j3RmnHL2mTPlCMlKr8Iy == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass8_0_1 MhuTWbL2AqGR6YjXOcOk()
		{
			return j3RmnHL2mTPlCMlKr8Iy;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass9_0_1
	{
		public string target;

		public FileInfo info;

		public string sourcePath;

		public string temporary;

		private static __c__DisplayClass9_0_1 oWwJkQL2ILbft2nXN38F;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass9_0_1()
		{
			//IL_004c: Expected I4, but got O
			//IL_0031->IL0043: Incompatible stack types: I4 vs O
			//IL_003c->IL0043: Incompatible stack types: I4 vs O
			object obj = 0;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_efa7845a846a43508e861e510ac5e1d2 != 0)
			{
				obj = 5;
			}
			object obj2 = default(object);
			while (true)
			{
				switch ((int)obj)
				{
				case 0:
					return;
				}
				if ((nint)obj2 == 988)
				{
					obj = obj2;
					continue;
				}
				return;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _ImportAsync_b__1()
		{
			//IL_000c: Expected O, but got I4
			//IL_0025: Expected I4, but got O
			//IL_003b: Expected I4, but got O
			//IL_0277: Unknown result type (might be due to invalid IL or missing references)
			//IL_0286: Expected O, but got Unknown
			//IL_015c: Expected I4, but got O
			//IL_01e0: Expected I4, but got O
			//IL_00c5: Expected O, but got I4
			//IL_0088: Expected I4, but got O
			//IL_00ff: Expected I4, but got O
			//IL_0132->IL014f: Incompatible stack types: I4 vs O
			//IL_01b6->IL01d3: Incompatible stack types: I4 vs O
			//IL_013d->IL014f: Incompatible stack types: I4 vs O
			//IL_01c1->IL01d3: Incompatible stack types: I4 vs O
			//IL_018f->IL014f: Incompatible stack types: I4 vs O
			//IL_0213->IL01d3: Incompatible stack types: I4 vs O
			//IL_019a->IL014f: Incompatible stack types: I4 vs O
			//IL_021e->IL01d3: Incompatible stack types: I4 vs O
			//IL_0062->IL007f: Incompatible stack types: I4 vs O
			//IL_0266->IL0010: Incompatible stack types: I4 vs O
			//IL_02a5->IL0010: Incompatible stack types: I4 vs O
			//IL_006d->IL007f: Incompatible stack types: I4 vs O
			//IL_0271->IL0010: Incompatible stack types: I4 vs O
			//IL_00d9->IL00f6: Incompatible stack types: I4 vs O
			//IL_00e4->IL00f6: Incompatible stack types: I4 vs O
			object obj = 3;
			dynamic obj6 = default(object);
			dynamic obj5 = default(object);
			dynamic obj7 = default(object);
			object obj9 = default(object);
			object obj11 = default(object);
			dynamic obj13 = default(object);
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						goto IL_0025;
					case 1:
						return (byte)(int)obj6 != 0;
					case 0:
						try
						{
							dynamic obj3 = System.IO.File.OpenRead(target);
							dynamic obj4 = 4;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_20242fceb1c648009846fc096f5b9270 != 0)
							{
								obj4 = 0;
							}
							while (true)
							{
								switch ((int)obj4)
								{
								default:
									if ((nint)obj5 == 988)
									{
										goto IL_007b;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_007b:
								obj4 = obj5;
							}
							try
							{
								obj6 = MemoryExtensions.SequenceEqual<byte>(MemoryExtensions.AsSpan<byte>(System.Security.Cryptography.SHA256.HashData((Stream)obj7)), (global::System.ReadOnlySpan<byte>)System.Security.Cryptography.SHA256.HashData((Stream)obj3));
								dynamic obj8 = 0;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5abcb08dd0ae4b88988bbb89131b0cab == 0)
								{
									obj8 = 2;
								}
								while (true)
								{
									switch ((int)obj8)
									{
									default:
										if ((nint)obj9 == 988)
										{
											obj8 = obj9;
											continue;
										}
										break;
									case 0:
										break;
									}
									break;
								}
							}
							finally
							{
								if (obj3 != null)
								{
									dynamic obj10 = 1;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2ea097de099140f192d12c8111241f4e == 0)
									{
										obj10 = 5;
									}
									while (true)
									{
										switch ((int)obj10)
										{
										default:
											if ((nint)obj11 == 989)
											{
												obj10 = obj11;
												continue;
											}
											break;
										case 1:
											break;
										case 0:
											goto end_IL_014f;
										}
										((dynamic)obj3).Dispose();
										obj10 = 6;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_cc5bd43d70674cf481f40e84bf27aa89 == 0)
										{
											obj10 = 0;
										}
										continue;
										end_IL_014f:
										break;
									}
								}
							}
						}
						finally
						{
							if (obj7 != null)
							{
								dynamic obj12 = 0;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b6e1b24306c5435497967d798ce571fb == 0)
								{
									obj12 = 0;
								}
								while (true)
								{
									switch ((int)obj12)
									{
									default:
										if ((nint)obj13 == 989)
										{
											obj12 = obj13;
											continue;
										}
										break;
									case 0:
										break;
									case 1:
										goto end_IL_01d3;
									}
									((dynamic)obj7).Dispose();
									obj12 = 6;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_28a8309f77124973ab9263f59df1f564 != 0)
									{
										obj12 = 1;
									}
									continue;
									end_IL_01d3:
									break;
								}
							}
						}
						goto case 1;
					case 2:
						return false;
					case 3:
						break;
					}
					goto IL_0271;
					IL_0025:
					if ((nint)obj == 991)
					{
						break;
					}
					goto IL_0271;
					IL_0271:
					if ((new FileInfo(target)).Length != (info).Length)
					{
						obj2 = 2;
						continue;
					}
					obj7 = System.IO.File.OpenRead(sourcePath);
					obj2 = 0;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_db2c7dd1aabc4c9a97a36e710c0128ab == 0)
					{
						obj2 = 1;
					}
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _ImportAsync_b__0()
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_005b->IL0010: Incompatible stack types: I4 vs O
			//IL_0066->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			do
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 1:
						System.IO.File.Copy(sourcePath, temporary, false);
						obj2 = 2;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7d9cb56da18447908e8451f934a19bb2 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 0:
						return;
					}
					break;
				}
			}
			while ((nint)obj == 989);
		}

		[MethodImpl((MethodImplOptions)8)]
		static __c__DisplayClass9_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool TCBiABL2BgNGOxw9mGov()
		{
			return oWwJkQL2ILbft2nXN38F == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass9_0_1 aP1oFUL2gtkhfaRVOM3I()
		{
			return oWwJkQL2ILbft2nXN38F;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ImportAsync_d__9 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<McpLocalFile> __t__builder;

		public string sourcePath;

		public McpLocalLibraryService __4__this;

		private __c__DisplayClass9_0_1 __8__1;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2;

		private static object yrUnayL2leasMQb3EjYI;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_000c: Expected O, but got I4
			//IL_0ef6: Expected O, but got I4
			//IL_002d: Expected I4, but got O
			//IL_0fe6: Expected O, but got I4
			//IL_0639: Expected I4, but got O
			//IL_0f0b: Expected I4, but got O
			//IL_0b50: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b57: Expected O, but got Unknown
			//IL_006e: Expected O, but got I4
			//IL_0d78: Unknown result type (might be due to invalid IL or missing references)
			//IL_0970: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e0e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a33: Unknown result type (might be due to invalid IL or missing references)
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Expected O, but got Unknown
			//IL_0cb0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cb7: Expected O, but got Unknown
			//IL_0247: Unknown result type (might be due to invalid IL or missing references)
			//IL_024e: Expected O, but got Unknown
			//IL_0750: Unknown result type (might be due to invalid IL or missing references)
			//IL_0702: Expected O, but got I4
			//IL_0da7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dae: Expected O, but got Unknown
			//IL_0777: Expected O, but got I4
			//IL_0987: Unknown result type (might be due to invalid IL or missing references)
			//IL_0991: Expected O, but got Unknown
			//IL_012b: Expected I4, but got O
			//IL_0471: Unknown result type (might be due to invalid IL or missing references)
			//IL_0478: Expected O, but got Unknown
			//IL_0279: Expected O, but got I4
			//IL_0359: Expected O, but got I4
			//IL_051f: Expected O, but got I4
			//IL_032e: Unknown result type (might be due to invalid IL or missing references)
			//IL_033d: Expected O, but got Unknown
			//IL_0343: Unknown result type (might be due to invalid IL or missing references)
			//IL_034a: Expected O, but got Unknown
			//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c5: Expected O, but got Unknown
			//IL_05c7: Expected O, but got I8
			//IL_0585: Unknown result type (might be due to invalid IL or missing references)
			//IL_058c: Expected O, but got Unknown
			//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0555: Expected O, but got I4
			//IL_03be: Unknown result type (might be due to invalid IL or missing references)
			//IL_052e: Expected O, but got I4
			//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d6: Expected I4, but got O
			//IL_0edd->IL0efa: Incompatible stack types: I4 vs O
			//IL_0607->IL0624: Incompatible stack types: I4 vs O
			//IL_0ee8->IL0efa: Incompatible stack types: I4 vs O
			//IL_0612->IL0624: Incompatible stack types: I4 vs O
			//IL_0f85->IL0efa: Incompatible stack types: I4 vs O
			//IL_0675->IL0624: Incompatible stack types: I4 vs O
			//IL_0f90->IL0efa: Incompatible stack types: I4 vs O
			//IL_06ae->IL0624: Incompatible stack types: I4 vs O
			//IL_0680->IL0624: Incompatible stack types: I4 vs O
			//IL_0fc7->IL0010: Incompatible stack types: I4 vs O
			//IL_100b->IL0010: Incompatible stack types: I4 vs O
			//IL_1032->IL0010: Incompatible stack types: I4 vs O
			//IL_0ff0->IL0010: Incompatible stack types: I4 vs O
			//IL_06b9->IL0624: Incompatible stack types: I4 vs O
			//IL_1016->IL0010: Incompatible stack types: I4 vs O
			//IL_103d->IL0010: Incompatible stack types: I4 vs O
			//IL_0b61->IL0072: Incompatible stack types: I4 vs O
			//IL_0eb3->IL0072: Incompatible stack types: I4 vs O
			//IL_0185->IL0072: Incompatible stack types: I4 vs O
			//IL_0c98->IL0072: Incompatible stack types: I4 vs O
			//IL_083d->IL0072: Incompatible stack types: I4 vs O
			//IL_0e28->IL0072: Incompatible stack types: I4 vs O
			//IL_0aa4->IL0072: Incompatible stack types: I4 vs O
			//IL_01ac->IL0072: Incompatible stack types: I4 vs O
			//IL_0b35->IL0072: Incompatible stack types: I4 vs O
			//IL_0e48->IL0072: Incompatible stack types: I4 vs O
			//IL_0af0->IL0072: Incompatible stack types: I4 vs O
			//IL_0944->IL0072: Incompatible stack types: I4 vs O
			//IL_0d32->IL0072: Incompatible stack types: I4 vs O
			//IL_07c5->IL0072: Incompatible stack types: I4 vs O
			//IL_0711->IL0072: Incompatible stack types: I4 vs O
			//IL_0db8->IL0072: Incompatible stack types: I4 vs O
			//IL_0790->IL0072: Incompatible stack types: I4 vs O
			//IL_0b95->IL0072: Incompatible stack types: I4 vs O
			//IL_0190->IL0072: Incompatible stack types: I4 vs O
			//IL_0ca3->IL0072: Incompatible stack types: I4 vs O
			//IL_0c07->IL0072: Incompatible stack types: I4 vs O
			//IL_0c76->IL0072: Incompatible stack types: I4 vs O
			//IL_0848->IL0072: Incompatible stack types: I4 vs O
			//IL_0bce->IL0072: Incompatible stack types: I4 vs O
			//IL_0772->IL0072: Incompatible stack types: I4 vs O
			//IL_09d0->IL0072: Incompatible stack types: I4 vs O
			//IL_01d6->IL0072: Incompatible stack types: I4 vs O
			//IL_0e33->IL0072: Incompatible stack types: I4 vs O
			//IL_0225->IL0072: Incompatible stack types: I4 vs O
			//IL_08dc->IL0072: Incompatible stack types: I4 vs O
			//IL_086e->IL0072: Incompatible stack types: I4 vs O
			//IL_0b40->IL0072: Incompatible stack types: I4 vs O
			//IL_0ac4->IL0072: Incompatible stack types: I4 vs O
			//IL_0e53->IL0072: Incompatible stack types: I4 vs O
			//IL_094f->IL0072: Incompatible stack types: I4 vs O
			//IL_09a5->IL0072: Incompatible stack types: I4 vs O
			//IL_0e08->IL0072: Incompatible stack types: I4 vs O
			//IL_0d3d->IL0072: Incompatible stack types: I4 vs O
			//IL_0c36->IL0072: Incompatible stack types: I4 vs O
			//IL_079b->IL0072: Incompatible stack types: I4 vs O
			//IL_0ba0->IL0072: Incompatible stack types: I4 vs O
			//IL_0c12->IL0072: Incompatible stack types: I4 vs O
			//IL_0c81->IL0072: Incompatible stack types: I4 vs O
			//IL_0bd9->IL0072: Incompatible stack types: I4 vs O
			//IL_09db->IL0072: Incompatible stack types: I4 vs O
			//IL_0230->IL0072: Incompatible stack types: I4 vs O
			//IL_0acf->IL0072: Incompatible stack types: I4 vs O
			//IL_0482->IL027d: Incompatible stack types: I4 vs O
			//IL_09b0->IL0072: Incompatible stack types: I4 vs O
			//IL_0372->IL027d: Incompatible stack types: I4 vs O
			//IL_0529->IL027d: Incompatible stack types: I4 vs O
			//IL_0354->IL027d: Incompatible stack types: I4 vs O
			//IL_05a0->IL027d: Incompatible stack types: I4 vs O
			//IL_04ef->IL027d: Incompatible stack types: I4 vs O
			//IL_055f->IL027d: Incompatible stack types: I4 vs O
			//IL_0547->IL027d: Incompatible stack types: I4 vs O
			//IL_0431->IL027d: Incompatible stack types: I4 vs O
			//IL_0317->IL027d: Incompatible stack types: I4 vs O
			//IL_0511->IL027d: Incompatible stack types: I4 vs O
			//IL_03ef->IL027d: Incompatible stack types: I4 vs O
			//IL_0398->IL027d: Incompatible stack types: I4 vs O
			//IL_037d->IL027d: Incompatible stack types: I4 vs O
			//IL_0465->IL027d: Incompatible stack types: I4 vs O
			//IL_05ab->IL027d: Incompatible stack types: I4 vs O
			//IL_0552->IL027d: Incompatible stack types: I4 vs O
			//IL_0322->IL027d: Incompatible stack types: I4 vs O
			//IL_0410->IL027d: Incompatible stack types: I4 vs O
			//IL_051c->IL027d: Incompatible stack types: I4 vs O
			//IL_03a3->IL027d: Incompatible stack types: I4 vs O
			//IL_0470->IL027d: Incompatible stack types: I4 vs O
			//IL_041b->IL027d: Incompatible stack types: I4 vs O
			//IL_049f->IL027d: Incompatible stack types: I4 vs O
			//IL_04aa->IL027d: Incompatible stack types: I4 vs O
			int num = 4;
			object obj4 = default(object);
			dynamic obj5 = default(object);
			dynamic obj6 = default(object);
			dynamic obj10 = default(object);
			dynamic obj12 = default(object);
			dynamic obj3 = default(object);
			dynamic obj13 = default(object);
			object obj15 = default(object);
			dynamic obj16 = default(object);
			dynamic obj17 = default(object);
			object obj18 = default(object);
			object obj20 = default(object);
			object result = default(object);
			dynamic obj8 = default(object);
			object obj22 = default(object);
			object obj24 = default(object);
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
							if ((nint)obj != 12)
							{
								if ((nint)obj == 993)
								{
									goto end_IL_0010;
								}
								goto case 5;
							}
							return;
						case 5:
							try
							{
								int num2;
								if (obj4 != null)
								{
									num2 = 5;
									goto IL_006a;
								}
								goto IL_0b4f;
								IL_0230:
								obj5 = global::System.Threading.Tasks.Task.Run<bool>((Func<bool>)__8__1._ImportAsync_b__1).ConfigureAwait(false);
								num2 = 41;
								goto IL_006a;
								IL_006a:
								obj6 = num2;
								goto IL_006e;
								IL_006e:
								object obj7 = obj6;
								goto IL_0072;
								IL_0072:
								while (true)
								{
									switch ((int)obj7)
									{
									default:
										if ((nint)obj6 != 52)
										{
											if ((nint)obj6 == 1032)
											{
												goto IL_006e;
											}
											goto case 38;
										}
										goto case 16;
									case 30:
										break;
									case 2:
										System.IO.Directory.CreateDirectory((string)obj10);
										obj7 = 10;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_a2042ba402cd4aaf989f075337c5eaf7 == 0)
										{
											obj7 = 35;
										}
										continue;
									case 21:
										obj12 = new FileInfo(__8__1.target);
										obj7 = 32;
										continue;
									case 11:
										if ((__8__1.info).Length <= 52428800)
										{
											obj7 = 8;
											continue;
										}
										goto case 38;
									case 34:
										goto end_IL_004f;
									case 15:
										if (string.Equals(System.IO.Path.GetDirectoryName(__8__1.sourcePath), ((McpLocalLibraryService)obj3).PendingPath, (StringComparison)5))
										{
											obj7 = 36;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e22115a4e7ab476da94f74d7e328d269 == 0)
											{
												obj7 = 16;
											}
											continue;
										}
										goto case 12;
									case 37:
										goto IL_0230;
									case 31:
										try
										{
											int num3;
											if ((nint)obj4 != 1)
											{
												num3 = 6;
												goto IL_0275;
											}
											goto IL_0470;
											IL_0470:
											obj13 = __u__2;
											object obj14 = 18;
											goto IL_027d;
											IL_0275:
											obj15 = num3;
											goto IL_0279;
											IL_0279:
											obj14 = obj15;
											goto IL_027d;
											IL_027d:
											while (true)
											{
												switch ((int)obj14)
												{
												case 18:
													__u__2 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
													obj14 = 16;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f102566966284916b14bc7efa63c0f5e == 0)
													{
														obj14 = 7;
													}
													continue;
												case 6:
													obj16 = (System.Threading.Tasks.Task.Run(new Action(__8__1._ImportAsync_b__0))).ConfigureAwait(false);
													obj14 = 11;
													continue;
												case 3:
													obj4 = 1;
													__1__state = 1;
													obj14 = 13;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_28a8309f77124973ab9263f59df1f564 == 0)
													{
														obj14 = 23;
													}
													continue;
												case 2:
												case 4:
													goto IL_037d;
												case 15:
													throw new InvalidDataException("复制后的 MCP 文件大小无效");
												case 19:
													if ((long)obj17 <= 52428800)
													{
														obj14 = 0;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f47742ba549d4a57a8283970712d2604 != 0)
														{
															obj14 = 6;
														}
														continue;
													}
													goto IL_0552;
												case 1:
												case 17:
													((dynamic)obj13).GetResult();
													obj14 = 10;
													continue;
												case 8:
													if (((dynamic)obj13).IsCompleted)
													{
														obj14 = 1;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f981d20d38124e3ab94f0d411fda50cf == 0)
														{
															obj14 = 17;
														}
														continue;
													}
													goto case 3;
												case 7:
													goto end_IL_027d;
												case 13:
													goto IL_04dd;
												case 20:
													__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, _ImportAsync_d__9>(ref *(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter*)(&obj13), ref this);
													obj14 = 9;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_c3a1ed3f1b10415883902def95e1be62 == 0)
													{
														obj14 = 8;
													}
													continue;
												case 0:
												case 5:
													obj18 = 0;
													obj14 = 2;
													continue;
												case 16:
													obj4 = -1;
													__1__state = -1;
													obj14 = 6;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_067abd05646b4c3c8591d8097b64bf04 == 0)
													{
														obj14 = 17;
													}
													continue;
												case 14:
													goto IL_0552;
												case 9:
													return;
												case 11:
													obj13 = obj16.GetAwaiter();
													obj14 = 25;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2ea097de099140f192d12c8111241f4e != 0)
													{
														obj14 = 8;
													}
													continue;
												case 10:
													goto IL_05ab;
												case 12:
													goto end_IL_0259;
												}
												if ((nint)obj15 != 28)
												{
													if ((nint)obj15 == 1008)
													{
														goto IL_0279;
													}
													goto IL_04dd;
												}
												if ((long)obj17 > 0)
												{
													obj14 = 16;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b28f7b3c5e414da9823acaf82070b1eb == 0)
													{
														obj14 = 19;
													}
													continue;
												}
												goto IL_0552;
												IL_037d:
												if (obj18 != null)
												{
													obj14 = 26;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5616e31a21b646f69463de8959779c49 != 0)
													{
														obj14 = 15;
													}
												}
												else
												{
													System.IO.File.Move(__8__1.temporary, __8__1.target, false);
													obj14 = 12;
												}
												continue;
												IL_04dd:
												__u__2 = (ConfiguredTaskAwaitable.ConfiguredTaskAwaiter)obj13;
												obj14 = 20;
												continue;
												IL_0552:
												obj18 = 1;
												obj14 = 4;
												continue;
												end_IL_027d:
												break;
											}
											goto IL_0470;
											IL_05ab:
											obj17 = (new FileInfo(__8__1.temporary)).Length;
											num3 = 28;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b6e1b24306c5435497967d798ce571fb == 0)
											{
												num3 = 11;
											}
											goto IL_0275;
											end_IL_0259:;
										}
										finally
										{
											if ((nint)obj4 < 0)
											{
												object obj19 = 2;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f651726544964479b0083c2c6dbce1d1 != 0)
												{
													obj19 = 3;
												}
												while (true)
												{
													switch ((int)obj19)
													{
													default:
														if ((nint)obj20 == 991)
														{
															obj19 = obj20;
															continue;
														}
														goto case 3;
													case 3:
														System.IO.File.Delete(__8__1.temporary);
														obj19 = 6;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0609736616ee48cfa58bcf48cbf884e3 == 0)
														{
															obj19 = 0;
														}
														continue;
													case 2:
														if (!System.IO.File.Exists(__8__1.temporary))
														{
															obj19 = 1;
															if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_cb74c857a9564cc0b30907ecfe1e0cdf == 0)
															{
																obj19 = 4;
															}
															continue;
														}
														goto case 3;
													case 1:
														break;
													case 0:
														break;
													}
													break;
												}
											}
										}
										goto case 21;
									case 40:
										obj4 = -1;
										__1__state = -1;
										obj7 = 24;
										continue;
									case 10:
										return;
									case 38:
										throw new InvalidDataException("MCP 文件大小必须在 1 字节到 50 MiB 之间");
									case 8:
										System.IO.Directory.CreateDirectory(((McpLocalLibraryService)obj3).PendingPath);
										obj7 = 44;
										continue;
									case 43:
										obj4 = 0;
										__1__state = 0;
										obj7 = 10;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2b8232439dce49e49a3fdd295da14355 == 0)
										{
											obj7 = 0;
										}
										continue;
									case 36:
										__8__1.sourcePath = sourcePath;
										obj7 = 39;
										continue;
									case 6:
										result = new McpLocalFile
										{
											FilePath = __8__1.target,
											SizeBytes = (__8__1.info).Length,
											LastWriteTime = System.IO.File.GetLastWriteTime(__8__1.target),
											EntryModule = McpFileMetadata.ReadEntry(__8__1.target)
										};
										obj7 = 11;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9925520c809e49e19c0340f5f2a4c15c != 0)
										{
											obj7 = 34;
										}
										continue;
									case 20:
										if ((__8__1.info).Length > 0)
										{
											obj7 = 11;
											continue;
										}
										goto case 38;
									case 16:
										result = new McpLocalFile
										{
											FilePath = __8__1.sourcePath,
											SizeBytes = (__8__1.info).Length,
											LastWriteTime = (__8__1.info).LastWriteTime,
											EntryModule = McpFileMetadata.ReadEntry(__8__1.sourcePath)
										};
										obj7 = 18;
										continue;
									case 32:
										result = new McpLocalFile
										{
											FilePath = ((dynamic)obj12).FullName,
											SizeBytes = ((string)obj12).Length,
											LastWriteTime = ((dynamic)obj12).LastWriteTime,
											EntryModule = McpFileMetadata.ReadEntry(((dynamic)obj12).FullName)
										};
										obj7 = 44;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bd86dbd500ab43b1bb4264e56ddd52b4 == 0)
										{
											obj7 = 42;
										}
										continue;
									case 13:
										throw new InvalidDataException("只支持 .mcp 文件");
									case 9:
										if (!obj8.GetAwaiter().IsCompleted)
										{
											obj7 = 23;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1282ca3a3b4d42dea9c5c692937e35bc != 0)
											{
												obj7 = 43;
											}
											continue;
										}
										goto case 24;
									case 19:
									{
										__c__DisplayClass9_0_1 _c__DisplayClass9_0_2 = __8__1;
										string pendingPath = ((McpLocalLibraryService)obj3).PendingPath;
										global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler obj21 = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(5, 2);
										(obj21).AppendFormatted((string)obj22);
										(obj21).AppendLiteral("-");
										obj21.AppendFormatted<Guid>(System.Guid.NewGuid(), "N");
										(obj21).AppendLiteral(".mcp");
										_c__DisplayClass9_0_2.target = System.IO.Path.Combine(pendingPath, (obj21).ToStringAndClear());
										obj7 = 29;
										continue;
									}
									case 24:
										if (obj8.GetAwaiter().GetResult())
										{
											obj7 = 28;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b84585b58c384b95b0e0b94c466ccc55 != 0)
											{
												obj7 = 6;
											}
											continue;
										}
										goto case 26;
									case 26:
										obj22 = System.IO.Path.GetFileNameWithoutExtension(__8__1.target);
										obj7 = 19;
										continue;
									case 22:
										__8__1.target = System.IO.Path.Combine(((McpLocalLibraryService)obj3).PendingPath, System.IO.Path.GetFileName(__8__1.sourcePath));
										obj7 = 17;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_29300ae0ec1d42aeac4a5187ea9fcbba == 0)
										{
											obj7 = 4;
										}
										continue;
									case 28:
										goto IL_0b4f;
									case 44:
										__8__1.sourcePath = System.IO.Path.GetFullPath(__8__1.sourcePath);
										obj7 = 15;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e1a4b1278f5749c28fff394e2932a022 == 0)
										{
											obj7 = 3;
										}
										continue;
									case 7:
										if (System.IO.File.Exists(__8__1.sourcePath))
										{
											obj7 = 6;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_c3a1ed3f1b10415883902def95e1be62 != 0)
											{
												obj7 = 17;
											}
											continue;
										}
										goto case 3;
									case 4:
										if (System.IO.File.Exists(__8__1.target))
										{
											obj7 = 40;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3d9d86761de84aa48245c594db282bdf != 0)
											{
												obj7 = 37;
											}
											continue;
										}
										goto IL_0d3d;
									case 39:
										if (string.IsNullOrWhiteSpace(__8__1.sourcePath))
										{
											obj7 = 23;
											continue;
										}
										goto case 7;
									case 18:
										goto end_IL_004f;
									case 5:
										if ((nint)obj4 != 1)
										{
											obj7 = 1;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_fd7466ab326a4027abb1e5cf92add793 != 0)
											{
												obj7 = 8;
											}
											continue;
										}
										goto case 25;
									case 3:
									case 23:
										result = null;
										obj7 = 27;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_495680ddee4b4d2499de9ae6f49aa33c != 0)
										{
											obj7 = 31;
										}
										continue;
									case 35:
									{
										__c__DisplayClass9_0_1 _c__DisplayClass9_0_ = __8__1;
										object obj9 = obj10;
										System.Guid obj11 = System.Guid.NewGuid();
										_c__DisplayClass9_0_.temporary = System.IO.Path.Combine((string)obj9, string.Concat((obj11).ToString("N"), ".part"));
										obj7 = 25;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_12ecff64eea14fe694da7ba4fdd3c628 != 0)
										{
											obj7 = 43;
										}
										continue;
									}
									case 29:
										goto IL_0d3d;
									case 0:
										goto IL_0d75;
									case 27:
										goto end_IL_004f;
									case 41:
										obj8 = obj5.GetAwaiter().GetAwaiter();
										obj7 = 9;
										continue;
									case 17:
									case 33:
										goto IL_0db8;
									case 14:
										__u__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
										obj7 = 14;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e8ca07a3866c4b3b9e07b1ae67715f0c == 0)
										{
											obj7 = 40;
										}
										continue;
									case 25:
										obj7 = 31;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4fafd75e484e4b31a74460f9f0d54951 == 0)
										{
											obj7 = 2;
										}
										continue;
									case 12:
										if (!string.Equals(System.IO.Path.GetDirectoryName(__8__1.sourcePath), ((McpLocalLibraryService)obj3).InjectedPath, (StringComparison)5))
										{
											goto case 22;
										}
										goto IL_0e7f;
									case 1:
										__8__1 = (__c__DisplayClass9_0_1)new __c__DisplayClass9_0_1();
										obj7 = 36;
										continue;
									case 42:
										goto end_IL_004f;
									}
									break;
									IL_0db8:
									if (!string.Equals(System.IO.Path.GetExtension(__8__1.sourcePath), ".mcp", (StringComparison)5))
									{
										obj7 = 13;
										continue;
									}
									__8__1.info = new FileInfo(__8__1.sourcePath);
									obj7 = 20;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_861620835107408fad0813077d9e9967 != 0)
									{
										obj7 = 2;
									}
								}
								__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter, _ImportAsync_d__9>(ref *(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter*)(&obj8), ref this);
								num2 = 10;
								goto IL_006a;
								IL_0d75:
								__u__1 = (ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter)obj8;
								num2 = 30;
								goto IL_006a;
								IL_0b4f:
								obj8 = __u__1;
								obj7 = 14;
								goto IL_0072;
								IL_0e7f:
								num2 = 52;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_80fb217b158b48d3aa902bde1388a3c9 == 0)
								{
									num2 = 47;
								}
								goto IL_006a;
								IL_0d3d:
								obj10 = System.IO.Path.Combine(((McpLocalLibraryService)obj3).PendingPath, ".staging");
								num2 = 2;
								goto IL_006a;
								end_IL_004f:;
							}
							catch (global::System.Exception exception)
							{
								object obj23 = 1;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9c15dc17ae4e48a5bd629d141b0ebe29 == 0)
								{
									obj23 = 2;
								}
								while (true)
								{
									int num4;
									switch ((int)obj23)
									{
									default:
										if ((nint)obj24 != 10)
										{
											if ((nint)obj24 == 990)
											{
												goto IL_0ef6;
											}
											goto case 1;
										}
										return;
									case 0:
										__t__builder.SetException(exception);
										num4 = 3;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_a39b60a5f46a44329f1ae7a5ef50ae96 != 0)
										{
											num4 = 10;
										}
										goto IL_0ef2;
									case 1:
										__1__state = -2;
										num4 = 2;
										goto IL_0ef2;
									case 2:
										{
											__8__1 = null;
											obj23 = 2;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e041d974da614bb9aad5f28559bec3d0 == 0)
											{
												obj23 = 0;
											}
											break;
										}
										IL_0ef2:
										obj24 = num4;
										goto IL_0ef6;
										IL_0ef6:
										obj23 = obj24;
										break;
									}
								}
							}
							goto case 1;
						case 1:
							__1__state = -2;
							obj2 = 2;
							continue;
						case 0:
							break;
						case 4:
							obj4 = __1__state;
							obj2 = 3;
							continue;
						case 2:
							__8__1 = null;
							obj2 = 0;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3a9f60458a5840868f1b224a8d25b071 == 0)
							{
								obj2 = 7;
							}
							continue;
						case 3:
							obj3 = __4__this;
							obj2 = 5;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bd86dbd500ab43b1bb4264e56ddd52b4 != 0)
							{
								obj2 = 12;
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
				__t__builder.SetResult((McpLocalFile)result);
				num = 12;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_0051->IL0010: Incompatible stack types: I4 vs O
			//IL_005c->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
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
					if ((nint)obj == 989)
					{
						break;
					}
					goto IL_0031;
					IL_0031:
					__t__builder.SetStateMachine(stateMachine);
					obj2 = 0;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f651726544964479b0083c2c6dbce1d1 == 0)
					{
						obj2 = 0;
					}
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		static _ImportAsync_d__9()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool IYGs79L2dM2PTFEZjraY()
		{
			return yrUnayL2leasMQb3EjYI == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object gm5aVQL2KEZRjLxrXy5N()
		{
			return yrUnayL2leasMQb3EjYI;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ListAsync_d__8 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<global::System.Collections.Generic.IReadOnlyList<McpLocalFile>> __t__builder;

		public McpLocalLibraryService __4__this;

		public ISet<string> injectedPaths;

		private ConfiguredTaskAwaitable<global::System.Collections.Generic.IReadOnlyList<McpLocalFile>>.ConfiguredTaskAwaiter __u__1;

		private static object rx6NJpL2HS0vY6tK5yXW;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_000c: Expected O, but got I4
			//IL_0025: Expected I4, but got O
			//IL_0287: Expected I4, but got O
			//IL_031a: Expected O, but got I4
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a5: Expected O, but got Unknown
			//IL_0178: Unknown result type (might be due to invalid IL or missing references)
			//IL_022f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Expected O, but got Unknown
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Expected O, but got Unknown
			//IL_021d: Expected O, but got I4
			//IL_01f4: Expected O, but got I4
			//IL_007b: Expected O, but got I4
			//IL_00b0: Expected I4, but got O
			//IL_0259->IL0276: Incompatible stack types: I4 vs O
			//IL_0264->IL0276: Incompatible stack types: I4 vs O
			//IL_02e2->IL0276: Incompatible stack types: I4 vs O
			//IL_02bb->IL0276: Incompatible stack types: I4 vs O
			//IL_02ed->IL0276: Incompatible stack types: I4 vs O
			//IL_02c6->IL0276: Incompatible stack types: I4 vs O
			//IL_0357->IL0010: Incompatible stack types: I4 vs O
			//IL_0324->IL0010: Incompatible stack types: I4 vs O
			//IL_0362->IL0010: Incompatible stack types: I4 vs O
			//IL_01b9->IL007f: Incompatible stack types: I4 vs O
			//IL_0062->IL007f: Incompatible stack types: I4 vs O
			//IL_01c4->IL007f: Incompatible stack types: I4 vs O
			//IL_006d->IL007f: Incompatible stack types: I4 vs O
			//IL_0192->IL007f: Incompatible stack types: I4 vs O
			//IL_0132->IL007f: Incompatible stack types: I4 vs O
			//IL_011f->IL007f: Incompatible stack types: I4 vs O
			//IL_022c->IL007f: Incompatible stack types: I4 vs O
			//IL_014f->IL007f: Incompatible stack types: I4 vs O
			//IL_020d->IL007f: Incompatible stack types: I4 vs O
			//IL_019d->IL007f: Incompatible stack types: I4 vs O
			//IL_01e4->IL007f: Incompatible stack types: I4 vs O
			//IL_015a->IL007f: Incompatible stack types: I4 vs O
			//IL_0218->IL007f: Incompatible stack types: I4 vs O
			//IL_0172->IL007f: Incompatible stack types: I4 vs O
			//IL_01ef->IL007f: Incompatible stack types: I4 vs O
			int num = 3;
			dynamic obj3 = default(object);
			object obj7 = default(object);
			dynamic obj5 = default(object);
			dynamic obj6 = default(object);
			object result = default(object);
			object obj9 = default(object);
			while (true)
			{
				object obj = num;
				do
				{
					object obj2 = obj;
					while (true)
					{
						switch ((int)obj2)
						{
						default:
							if ((nint)obj == 10)
							{
								return;
							}
							goto end_IL_0010;
						case 2:
							try
							{
								object obj4;
								if (obj3 != null)
								{
									obj4 = 5;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f651726544964479b0083c2c6dbce1d1 != 0)
									{
										obj4 = 7;
									}
									goto IL_007f;
								}
								goto IL_019d;
								IL_007f:
								while (true)
								{
									switch ((int)obj4)
									{
									default:
										if ((nint)obj7 != 18)
										{
											if ((nint)obj7 == 998)
											{
												goto IL_007b;
											}
											goto case 1;
										}
										__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<global::System.Collections.Generic.IReadOnlyList<McpLocalFile>>.ConfiguredTaskAwaiter, _ListAsync_d__8>(ref *(ConfiguredTaskAwaitable<global::System.Collections.Generic.IReadOnlyList<McpLocalFile>>.ConfiguredTaskAwaiter*)(&obj5), ref this);
										obj4 = 9;
										continue;
									case 9:
										return;
									case 5:
										obj6 = global::System.Threading.Tasks.Task.Run<global::System.Collections.Generic.IReadOnlyList<McpLocalFile>>((Func<global::System.Collections.Generic.IReadOnlyList<McpLocalFile>>)((__c__DisplayClass8_0_1)new __c__DisplayClass8_0_1
										{
											__4__this = __4__this,
											injectedPaths = injectedPaths
										})._ListAsync_b__0).ConfigureAwait(false);
										obj4 = 2;
										continue;
									case 2:
										obj5 = obj6.GetAwaiter().GetAwaiter();
										obj4 = 6;
										continue;
									case 8:
										result = obj5.GetAwaiter().GetResult();
										obj4 = 11;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3a9f60458a5840868f1b224a8d25b071 != 0)
										{
											obj4 = 3;
										}
										continue;
									case 0:
										__u__1 = default(ConfiguredTaskAwaitable<global::System.Collections.Generic.IReadOnlyList<McpLocalFile>>.ConfiguredTaskAwaiter);
										obj4 = 7;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7bc84b0f9b2d4d968eda9f4e194ba82d == 0)
										{
											obj4 = 17;
										}
										continue;
									case 4:
										break;
									case 6:
										if (!obj5.GetAwaiter().IsCompleted)
										{
											obj4 = 7;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4ae4de12ce674c26bc2939a5789df8ab == 0)
											{
												obj4 = 10;
											}
											continue;
										}
										goto case 8;
									case 10:
										obj3 = 0;
										__1__state = 0;
										obj4 = 1;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e8864409e70b4d87b4c6598763ad15be == 0)
										{
											obj4 = 18;
										}
										continue;
									case 7:
										obj3 = -1;
										__1__state = -1;
										obj4 = 8;
										continue;
									case 1:
										__u__1 = (ConfiguredTaskAwaitable<global::System.Collections.Generic.IReadOnlyList<McpLocalFile>>.ConfiguredTaskAwaiter)obj5;
										obj7 = 18;
										goto IL_007b;
									case 3:
										goto end_IL_007f;
										IL_007b:
										obj4 = obj7;
										continue;
									}
									goto IL_019d;
									continue;
									end_IL_007f:
									break;
								}
								goto end_IL_0047;
								IL_019d:
								obj5 = __u__1;
								obj4 = 0;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_fd7466ab326a4027abb1e5cf92add793 != 0)
								{
									obj4 = 18;
								}
								goto IL_007f;
								end_IL_0047:;
							}
							catch (global::System.Exception exception)
							{
								dynamic obj8 = 0;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_d9c10084bf5f4a9f947702ad63bef067 == 0)
								{
									obj8 = 0;
								}
								while (true)
								{
									switch ((int)obj8)
									{
									default:
										if ((nint)obj9 == 990)
										{
											obj8 = obj9;
											continue;
										}
										break;
									case 1:
										__t__builder.SetException(exception);
										obj8 = 2;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7d96de295fba4e09a034ce1853831e68 != 0)
										{
											obj8 = 3;
										}
										continue;
									case 0:
										break;
									case 2:
										return;
									}
									__1__state = -2;
									obj8 = 0;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e3c72d365c184d8193f0594ab3fd4d1f == 0)
									{
										obj8 = 1;
									}
								}
							}
							break;
						case 3:
							obj3 = __1__state;
							obj2 = 2;
							continue;
						case 0:
							goto end_IL_000c;
						case 1:
							break;
						}
						__1__state = -2;
						obj2 = 4;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_527dac5507ee46fcb9d22f9ff955c1d0 == 0)
						{
							obj2 = 0;
						}
						continue;
						end_IL_0010:
						break;
					}
					continue;
					end_IL_000c:
					break;
				}
				while ((nint)obj == 991);
				__t__builder.SetResult((global::System.Collections.Generic.IReadOnlyList<McpLocalFile>)result);
				num = 10;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_0050->IL0010: Incompatible stack types: I4 vs O
			//IL_005b->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			do
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 1:
						__t__builder.SetStateMachine(stateMachine);
						obj2 = 2;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7965c0cf8c924e228a4010c08420db19 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 0:
						return;
					}
					break;
				}
			}
			while ((nint)obj == 989);
		}

		[MethodImpl((MethodImplOptions)8)]
		static _ListAsync_d__8()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool qsY3ckL2tGJrDIx2nSAN()
		{
			return rx6NJpL2HS0vY6tK5yXW == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object TVbPIWL2OcvCaTjPZ11N()
		{
			return rx6NJpL2HS0vY6tK5yXW;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _RemoveAsync_d__10 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public McpLocalFile file;

		public McpLocalLibraryService __4__this;

		private TaskAwaiter __u__1;

		internal static object RUU1u6L25XGGtup2w4SE;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_000c: Expected O, but got I4
			//IL_0029: Expected I4, but got O
			//IL_0530: Expected I4, but got O
			//IL_059d: Expected O, but got I4
			//IL_0371: Unknown result type (might be due to invalid IL or missing references)
			//IL_0378: Expected O, but got Unknown
			//IL_0092: Expected O, but got I4
			//IL_0265: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_047d: Expected O, but got I4
			//IL_03f7: Expected O, but got I4
			//IL_02dc: Expected O, but got I4
			//IL_020f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0216: Expected O, but got Unknown
			//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f6: Expected O, but got Unknown
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0203: Expected O, but got Unknown
			//IL_00ff: Expected I4, but got O
			//IL_0502->IL051f: Incompatible stack types: I4 vs O
			//IL_050d->IL051f: Incompatible stack types: I4 vs O
			//IL_0586->IL051f: Incompatible stack types: I4 vs O
			//IL_0569->IL051f: Incompatible stack types: I4 vs O
			//IL_0574->IL051f: Incompatible stack types: I4 vs O
			//IL_05c1->IL0010: Incompatible stack types: I4 vs O
			//IL_05a7->IL0010: Incompatible stack types: I4 vs O
			//IL_0066->IL0010: Incompatible stack types: I4 vs O
			//IL_0071->IL0010: Incompatible stack types: I4 vs O
			//IL_0382->IL0096: Incompatible stack types: I4 vs O
			//IL_0458->IL0096: Incompatible stack types: I4 vs O
			//IL_02f5->IL0096: Incompatible stack types: I4 vs O
			//IL_031b->IL0096: Incompatible stack types: I4 vs O
			//IL_0370->IL0096: Incompatible stack types: I4 vs O
			//IL_0220->IL0096: Incompatible stack types: I4 vs O
			//IL_02d7->IL0096: Incompatible stack types: I4 vs O
			//IL_03b8->IL0096: Incompatible stack types: I4 vs O
			//IL_03f2->IL0096: Incompatible stack types: I4 vs O
			//IL_0431->IL0096: Incompatible stack types: I4 vs O
			//IL_0463->IL0096: Incompatible stack types: I4 vs O
			//IL_03dc->IL0096: Incompatible stack types: I4 vs O
			//IL_0186->IL0096: Incompatible stack types: I4 vs O
			//IL_04b2->IL0096: Incompatible stack types: I4 vs O
			//IL_020d->IL0096: Incompatible stack types: I4 vs O
			//IL_0161->IL0096: Incompatible stack types: I4 vs O
			//IL_0358->IL0096: Incompatible stack types: I4 vs O
			//IL_0300->IL0096: Incompatible stack types: I4 vs O
			//IL_0326->IL0096: Incompatible stack types: I4 vs O
			//IL_04dc->IL0096: Incompatible stack types: I4 vs O
			//IL_0191->IL0096: Incompatible stack types: I4 vs O
			//IL_02b1->IL0096: Incompatible stack types: I4 vs O
			//IL_04bd->IL0096: Incompatible stack types: I4 vs O
			//IL_04e7->IL0096: Incompatible stack types: I4 vs O
			int num = 2;
			dynamic obj3 = default(object);
			object obj4 = default(object);
			dynamic obj6 = default(object);
			dynamic obj10 = default(object);
			object obj9 = default(object);
			object obj7 = default(object);
			dynamic obj8 = default(object);
			dynamic obj12 = default(object);
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
							if ((nint)obj != 11)
							{
								if ((nint)obj == 992)
								{
									goto end_IL_0010;
								}
							}
							else
							{
								try
								{
									int num2;
									if (obj3 != null)
									{
										num2 = 15;
										goto IL_008e;
									}
									goto IL_0370;
									IL_0370:
									obj4 = __u__1;
									dynamic obj5 = 21;
									goto IL_0096;
									IL_008e:
									obj6 = num2;
									goto IL_0092;
									IL_0092:
									obj5 = obj6;
									goto IL_0096;
									IL_0096:
									while (true)
									{
										switch ((int)obj5)
										{
										case 12:
											return;
										default:
											if ((nint)obj6 != 32)
											{
												goto IL_010d;
											}
											goto case 1;
										case 8:
											break;
										case 6:
											if (((dynamic)obj4).IsCompleted)
											{
												obj5 = 3;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9201b2a1b9374af3a02f4d68ff67dfea == 0)
												{
													obj5 = 1;
												}
												continue;
											}
											goto case 14;
										case 10:
											goto end_IL_0096;
										case 13:
											goto end_IL_0096;
										case 2:
										case 22:
											throw new InvalidOperationException("只能移除文件库中的 MCP 文件");
										case 17:
											obj4 = obj10.GetAwaiter();
											obj5 = 6;
											continue;
										case 0:
											throw new InvalidOperationException("只能移除 MCP 专用目录中的文件");
										case 19:
											((__c__DisplayClass10_0)obj9).path = System.IO.Path.GetFullPath(file.FilePath);
											obj5 = 7;
											continue;
										case 14:
											obj3 = 0;
											__1__state = 0;
											obj5 = 5;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0b81b3b6b3bc4c4a8075444d576cb8ec != 0)
											{
												obj5 = 20;
											}
											continue;
										case 15:
											obj9 = new __c__DisplayClass10_0();
											obj5 = 29;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_33eff53ba43c4c10a4788d4370759667 == 0)
											{
												obj5 = 23;
											}
											continue;
										case 9:
											goto IL_0326;
										case 16:
											__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RemoveAsync_d__10>(ref *(TaskAwaiter*)(&obj4), ref this);
											obj5 = 12;
											continue;
										case 18:
											goto IL_0370;
										case 20:
											__u__1 = (TaskAwaiter)obj4;
											obj5 = 16;
											continue;
										case 5:
											if (string.IsNullOrWhiteSpace(file.FilePath))
											{
												goto end_IL_0096;
											}
											obj5 = 4;
											continue;
										case 21:
											__u__1 = default(TaskAwaiter);
											obj5 = 11;
											continue;
										case 11:
											goto IL_03f2;
										case 1:
											((dynamic)obj4).GetResult();
											obj5 = 24;
											continue;
										case 3:
										case 4:
											obj7 = System.IO.Path.GetFullPath(((McpLocalLibraryService)obj8).RootPath);
											obj5 = 22;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5d72748c192f4bab9e19ca961e9277d1 == 0)
											{
												obj5 = 19;
											}
											continue;
										case 7:
											goto IL_0463;
										case 23:
											if (file == null)
											{
												obj5 = 13;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_c3a1ed3f1b10415883902def95e1be62 == 0)
												{
													obj5 = 20;
												}
												continue;
											}
											goto case 5;
										case 24:
											goto end_IL_0096;
										}
										if (!string.Equals(System.IO.Path.GetDirectoryName(((__c__DisplayClass10_0)obj9).path), ((McpLocalLibraryService)obj8).InjectedPath, (StringComparison)5))
										{
											obj5 = 2;
											continue;
										}
										goto IL_01df;
										IL_0463:
										if ((((__c__DisplayClass10_0)obj9).path).StartsWith(string.Concat(((System.ReadOnlySpan<char>)(string)obj7), new global::System.ReadOnlySpan<char>(new char[1] { Path.DirectorySeparatorChar })), (StringComparison)5))
										{
											if (!string.Equals(System.IO.Path.GetExtension(((__c__DisplayClass10_0)obj9).path), ".mcp", (StringComparison)5))
											{
												obj5 = 22;
												continue;
											}
											goto IL_0326;
										}
										obj5 = 0;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_86f85a596c344fa79bc760622a9efe43 != 0)
										{
											obj5 = 4;
										}
										continue;
										IL_0326:
										if (!string.Equals(System.IO.Path.GetDirectoryName(((__c__DisplayClass10_0)obj9).path), ((McpLocalLibraryService)obj8).PendingPath, (StringComparison)5))
										{
											obj5 = 8;
											continue;
										}
										goto IL_01df;
										IL_01df:
										obj10 = (System.Threading.Tasks.Task.Run(new Action(((__c__DisplayClass10_0)obj9)._RemoveAsync_b__0))).ConfigureAwait(false);
										obj5 = 17;
										continue;
										end_IL_0096:
										break;
									}
									goto end_IL_0073;
									IL_03f2:
									obj3 = -1;
									__1__state = -1;
									num2 = 1;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bd95bcb31f2a40c89aee1548651426a0 == 0)
									{
										num2 = 32;
									}
									goto IL_008e;
									IL_010d:
									if ((nint)obj6 == 1012)
									{
										goto IL_0092;
									}
									goto IL_03f2;
									end_IL_0073:;
								}
								catch (global::System.Exception ex)
								{
									object obj11 = 5;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f981d20d38124e3ab94f0d411fda50cf != 0)
									{
										obj11 = 0;
									}
									while (true)
									{
										switch ((int)obj11)
										{
										case 1:
											return;
										default:
											if ((nint)obj12 != 990)
											{
												return;
											}
											obj11 = obj12;
											break;
										case 2:
											(__t__builder).SetException(ex);
											obj11 = 2;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5d72748c192f4bab9e19ca961e9277d1 == 0)
											{
												obj11 = 1;
											}
											break;
										case 0:
											__1__state = -2;
											obj11 = 2;
											break;
										}
									}
								}
							}
							goto case 3;
						case 3:
							__1__state = -2;
							obj2 = 0;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e8864409e70b4d87b4c6598763ad15be == 0)
							{
								obj2 = 11;
							}
							continue;
						case 4:
							return;
						case 2:
							obj3 = __1__state;
							obj2 = 1;
							continue;
						case 0:
							(__t__builder).SetResult();
							obj2 = 4;
							continue;
						case 1:
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
				obj8 = __4__this;
				num = 11;
				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4783bfa33d264997aac915e5e739dc84 == 0)
				{
					num = 6;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_0055->IL0010: Incompatible stack types: I4 vs O
			//IL_0060->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			do
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 1:
						(__t__builder).SetStateMachine(stateMachine);
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5144ebdc507c41fb87d88fdce3dc76e9 == 0)
						{
							obj2 = 3;
						}
						continue;
					case 0:
						return;
					}
					break;
				}
			}
			while ((nint)obj == 989);
		}

		[MethodImpl((MethodImplOptions)8)]
		static _RemoveAsync_d__10()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool FwHm6bL26o1SJwXNRLHl()
		{
			return RUU1u6L25XGGtup2w4SE == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object jPHxugL2R6JRF5Tp7Hhd()
		{
			return RUU1u6L25XGGtup2w4SE;
		}
	}

	internal static McpLocalLibraryService pUd9y1Lv6BOrCcoN3nyA;

	[field: CompilerGenerated]
	public string RootPath
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	public string PendingPath
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.IO.Path.Combine(RootPath, "Pending");
		}
	}

	public string InjectedPath
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.IO.Path.Combine(RootPath, "Injected");
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public McpLocalLibraryService(string rootPath)
	{
		//IL_0050: Expected I4, but got O
		//IL_0031->IL0043: Incompatible stack types: I4 vs O
		//IL_003c->IL0043: Incompatible stack types: I4 vs O
		//IL_0089->IL0043: Incompatible stack types: I4 vs O
		//IL_0094->IL0043: Incompatible stack types: I4 vs O
		object obj = 0;
		if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_a1a3680c38d4488598afb1defd71e635 != 0)
		{
			obj = 4;
		}
		object obj2 = default(object);
		while (true)
		{
			switch ((int)obj)
			{
			default:
				if ((nint)obj2 == 989)
				{
					obj = obj2;
					break;
				}
				return;
			case 1:
				return;
			case 0:
				this.RootPath = System.IO.Path.GetFullPath(rootPath);
				obj = 4;
				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b6e1b24306c5435497967d798ce571fb != 0)
				{
					obj = 1;
				}
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public unsafe global::System.Threading.Tasks.Task<global::System.Collections.Generic.IReadOnlyList<McpLocalFile>> ListAsync(ISet<string> injectedPaths)
	{
		//IL_000c: Expected O, but got I4
		//IL_0029: Expected I4, but got O
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa->IL0010: Incompatible stack types: I4 vs O
		//IL_00d0->IL0010: Incompatible stack types: I4 vs O
		//IL_0097->IL0010: Incompatible stack types: I4 vs O
		//IL_00b4->IL0010: Incompatible stack types: I4 vs O
		//IL_00db->IL0010: Incompatible stack types: I4 vs O
		//IL_00a2->IL0010: Incompatible stack types: I4 vs O
		int num = 2;
		dynamic obj3 = default(object);
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
						if ((nint)obj != 11)
						{
							if ((nint)obj == 992)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						return ((dynamic)obj3).__t__builder.Task;
					case 3:
						break;
					case 2:
						((dynamic)obj3).__t__builder = AsyncTaskMethodBuilder<global::System.Collections.Generic.IReadOnlyList<McpLocalFile>>.Create();
						obj2 = 1;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_d2995c01469b4ef28b5784f7cbf606e2 == 0)
						{
							obj2 = 10;
						}
						continue;
					case 4:
						((dynamic)obj3).__1__state = -1;
						obj2 = 3;
						continue;
					case 1:
						((dynamic)obj3).__4__this = this;
						obj2 = 8;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4783bfa33d264997aac915e5e739dc84 != 0)
						{
							obj2 = 0;
						}
						continue;
					case 0:
						((dynamic)obj3).injectedPaths = injectedPaths;
						obj2 = 4;
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
			((dynamic)obj3).__t__builder.Start<_ListAsync_d__8>(ref obj3);
			num = 9;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e041d974da614bb9aad5f28559bec3d0 == 0)
			{
				num = 11;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public unsafe global::System.Threading.Tasks.Task<McpLocalFile?> ImportAsync(string sourcePath)
	{
		//IL_000c: Expected O, but got I4
		//IL_0029: Expected I4, but got O
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066->IL0010: Incompatible stack types: I4 vs O
		//IL_00b8->IL0010: Incompatible stack types: I4 vs O
		//IL_0119->IL0010: Incompatible stack types: I4 vs O
		//IL_008d->IL0010: Incompatible stack types: I4 vs O
		//IL_0071->IL0010: Incompatible stack types: I4 vs O
		//IL_00c3->IL0010: Incompatible stack types: I4 vs O
		//IL_0124->IL0010: Incompatible stack types: I4 vs O
		//IL_0098->IL0010: Incompatible stack types: I4 vs O
		int num = 1;
		dynamic obj3 = default(object);
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
						if ((nint)obj != 11)
						{
							if ((nint)obj == 992)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						return ((dynamic)obj3).__t__builder.Task;
					case 0:
						((dynamic)obj3).__4__this = this;
						obj2 = 2;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_a1a3680c38d4488598afb1defd71e635 != 0)
						{
							obj2 = 6;
						}
						continue;
					case 4:
						((dynamic)obj3).__1__state = -1;
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bd86dbd500ab43b1bb4264e56ddd52b4 == 0)
						{
							obj2 = 3;
						}
						continue;
					case 1:
						((dynamic)obj3).__t__builder = AsyncTaskMethodBuilder<McpLocalFile>.Create();
						obj2 = 6;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2ee4c54a6c424cb680cd9d0811cd1011 != 0)
						{
							obj2 = 0;
						}
						continue;
					case 3:
						break;
					case 2:
						((dynamic)obj3).sourcePath = sourcePath;
						obj2 = 4;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_86f85a596c344fa79bc760622a9efe43 == 0)
						{
							obj2 = 4;
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
			((dynamic)obj3).__t__builder.Start<_ImportAsync_d__9>(ref obj3);
			num = 11;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ec9f1bd7108f411daeb83b57baf2dba0 == 0)
			{
				num = 5;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public unsafe global::System.Threading.Tasks.Task RemoveAsync(McpLocalFile file)
	{
		//IL_000c: Expected O, but got I4
		//IL_0029: Expected I4, but got O
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c->IL0010: Incompatible stack types: I4 vs O
		//IL_00c2->IL0010: Incompatible stack types: I4 vs O
		//IL_00dd->IL0010: Incompatible stack types: I4 vs O
		//IL_0077->IL0010: Incompatible stack types: I4 vs O
		//IL_00a5->IL0010: Incompatible stack types: I4 vs O
		//IL_00b0->IL0010: Incompatible stack types: I4 vs O
		int num = 4;
		dynamic obj3 = default(object);
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
						if ((nint)obj != 11)
						{
							if ((nint)obj == 992)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						((dynamic)obj3).__1__state = -1;
						obj2 = 6;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_12ecff64eea14fe694da7ba4fdd3c628 == 0)
						{
							obj2 = 1;
						}
						continue;
					case 1:
						((dynamic)obj3).__t__builder.Start<_RemoveAsync_d__10>(ref obj3);
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b7393eff3b9049068ae7c92e2e0229a5 != 0)
						{
							obj2 = 7;
						}
						continue;
					case 0:
						return (obj3.__t__builder).Task;
					case 3:
						((dynamic)obj3).__4__this = this;
						obj2 = 2;
						continue;
					case 4:
						((dynamic)obj3).__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
						obj2 = 3;
						continue;
					case 2:
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
			((dynamic)obj3).file = file;
			num = 11;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	static McpLocalLibraryService()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool cV0CPjLvRRvkKo9FdUE0()
	{
		return pUd9y1Lv6BOrCcoN3nyA == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static McpLocalLibraryService rwV4s9LvwtdmKliFKBcG()
	{
		return pUd9y1Lv6BOrCcoN3nyA;
	}
}
