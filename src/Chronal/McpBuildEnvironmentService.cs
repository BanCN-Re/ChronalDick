using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using Mahiro_Account.Services;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Features.McpStudio.Builder;

internal sealed class McpBuildEnvironmentService
{
	[CompilerGenerated]
	private sealed class __c__DisplayClass12_0
	{
		public McpBuildEnvironmentService __4__this;

		public string temporaryRoot;

		public CancellationToken cancellationToken;

		private static __c__DisplayClass12_0 EX4Kx8L2TLB1GnOI1VNY;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass12_0()
		{
			//IL_004c: Expected I4, but got O
			//IL_0031->IL0043: Incompatible stack types: I4 vs O
			//IL_003c->IL0043: Incompatible stack types: I4 vs O
			object obj = 5;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_cc5bd43d70674cf481f40e84bf27aa89 == 0)
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
		internal void _EnsureInstalledAsync_b__0()
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060->IL0010: Incompatible stack types: I4 vs O
			//IL_006b->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			do
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 1:
						ExtractArchiveSafely(__4__this.BundledArchivePath, temporaryRoot, cancellationToken);
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_28a8309f77124973ab9263f59df1f564 == 0)
						{
							obj2 = 4;
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
		private static void _cctor()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool lrwJIuL2NeFb8Xp9DFtr()
		{
			return EX4Kx8L2TLB1GnOI1VNY == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass12_0 CE5iqaL2MOfGenPmvIhF()
		{
			return EX4Kx8L2TLB1GnOI1VNY;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _EnsureInstalledAsync_d__12 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<string> __t__builder;

		public McpBuildEnvironmentService __4__this;

		public CancellationToken cancellationToken;

		public IProgress<string> progress;

		private __c__DisplayClass12_0 __8__1;

		private object __u__1;

		internal static object rFS39PL2p1cl0VvOmCli;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_000c: Expected O, but got I4
			//IL_0940: Expected O, but got I4
			//IL_002d: Expected I4, but got O
			//IL_08ee: Expected I4, but got O
			//IL_0082: Expected O, but got I4
			//IL_07fa: Expected I4, but got O
			//IL_0955: Expected I4, but got O
			//IL_02df: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e6: Expected O, but got Unknown
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_036c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0866: Expected I4, but got O
			//IL_0124: Expected O, but got I4
			//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ae: Expected O, but got Unknown
			//IL_015d: Expected I4, but got O
			//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_042c: Unknown result type (might be due to invalid IL or missing references)
			//IL_075e: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_05de: Expected O, but got Unknown
			//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05eb: Expected O, but got Unknown
			//IL_0497: Expected O, but got I4
			//IL_054c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0553: Expected O, but got Unknown
			//IL_0577: Expected O, but got I4
			//IL_0670: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b3: Expected O, but got I4
			//IL_06db: Unknown result type (might be due to invalid IL or missing references)
			//IL_0408: Expected I4, but got O
			//IL_08c8->IL08e5: Incompatible stack types: I4 vs O
			//IL_0932->IL0944: Incompatible stack types: I4 vs O
			//IL_08d3->IL08e5: Incompatible stack types: I4 vs O
			//IL_07d0->IL07ed: Incompatible stack types: I4 vs O
			//IL_07db->IL07ed: Incompatible stack types: I4 vs O
			//IL_0997->IL0944: Incompatible stack types: I4 vs O
			//IL_09a2->IL0944: Incompatible stack types: I4 vs O
			//IL_09bd->IL0944: Incompatible stack types: I4 vs O
			//IL_09c8->IL0944: Incompatible stack types: I4 vs O
			//IL_006f->IL0010: Incompatible stack types: I4 vs O
			//IL_0a2f->IL0010: Incompatible stack types: I4 vs O
			//IL_00bc->IL0010: Incompatible stack types: I4 vs O
			//IL_083c->IL0859: Incompatible stack types: I4 vs O
			//IL_007a->IL0010: Incompatible stack types: I4 vs O
			//IL_0a3a->IL0010: Incompatible stack types: I4 vs O
			//IL_00c7->IL0010: Incompatible stack types: I4 vs O
			//IL_00e3->IL0010: Incompatible stack types: I4 vs O
			//IL_0847->IL0859: Incompatible stack types: I4 vs O
			//IL_021c->IL0128: Incompatible stack types: I4 vs O
			//IL_010b->IL0128: Incompatible stack types: I4 vs O
			//IL_00ee->IL0010: Incompatible stack types: I4 vs O
			//IL_08a3->IL0859: Incompatible stack types: I4 vs O
			//IL_0227->IL0128: Incompatible stack types: I4 vs O
			//IL_0116->IL0128: Incompatible stack types: I4 vs O
			//IL_08ae->IL0859: Incompatible stack types: I4 vs O
			//IL_028c->IL0128: Incompatible stack types: I4 vs O
			//IL_0340->IL0128: Incompatible stack types: I4 vs O
			//IL_0242->IL0128: Incompatible stack types: I4 vs O
			//IL_01a3->IL0128: Incompatible stack types: I4 vs O
			//IL_02b7->IL0128: Incompatible stack types: I4 vs O
			//IL_0279->IL0128: Incompatible stack types: I4 vs O
			//IL_034b->IL0128: Incompatible stack types: I4 vs O
			//IL_01ae->IL0128: Incompatible stack types: I4 vs O
			//IL_0259->IL0128: Incompatible stack types: I4 vs O
			//IL_01f8->IL0128: Incompatible stack types: I4 vs O
			//IL_05b8->IL03b7: Incompatible stack types: I4 vs O
			//IL_039a->IL03b7: Incompatible stack types: I4 vs O
			//IL_03a5->IL03b7: Incompatible stack types: I4 vs O
			//IL_0470->IL03b7: Incompatible stack types: I4 vs O
			//IL_0445->IL03b7: Incompatible stack types: I4 vs O
			//IL_04a6->IL03b7: Incompatible stack types: I4 vs O
			//IL_04c3->IL03b7: Incompatible stack types: I4 vs O
			//IL_0567->IL03b7: Incompatible stack types: I4 vs O
			//IL_062e->IL03b7: Incompatible stack types: I4 vs O
			//IL_0492->IL03b7: Incompatible stack types: I4 vs O
			//IL_047b->IL03b7: Incompatible stack types: I4 vs O
			//IL_0450->IL03b7: Incompatible stack types: I4 vs O
			//IL_05a6->IL03b7: Incompatible stack types: I4 vs O
			//IL_04ce->IL03b7: Incompatible stack types: I4 vs O
			//IL_0572->IL03b7: Incompatible stack types: I4 vs O
			//IL_0527->IL03b7: Incompatible stack types: I4 vs O
			//IL_0639->IL03b7: Incompatible stack types: I4 vs O
			//IL_0532->IL03b7: Incompatible stack types: I4 vs O
			//IL_07af->IL03b7: Incompatible stack types: I4 vs O
			//IL_0743->IL03b7: Incompatible stack types: I4 vs O
			int num = 4;
			object obj9 = default(object);
			object pythonPath = default(object);
			dynamic obj3 = default(object);
			object obj22 = default(object);
			object obj20 = default(object);
			dynamic obj10 = default(object);
			dynamic obj7 = default(object);
			object obj12 = default(object);
			object obj18 = default(object);
			object obj15 = default(object);
			object obj17 = default(object);
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
								goto case 1;
							}
							obj9 = __4__this;
							obj2 = 8;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5616e31a21b646f69463de8959779c49 != 0)
							{
								obj2 = 5;
							}
							continue;
						case 0:
							__t__builder.SetResult((string)pythonPath);
							obj2 = 5;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5616e31a21b646f69463de8959779c49 != 0)
							{
								obj2 = 2;
							}
							continue;
						case 4:
							break;
						case 3:
							__8__1 = null;
							obj2 = 2;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e22115a4e7ab476da94f74d7e328d269 == 0)
							{
								obj2 = 0;
							}
							continue;
						case 2:
							return;
						case 5:
							try
							{
								object obj4;
								if (obj3 != null)
								{
									obj4 = 6;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_24238b39bba94b6aa4d3c2739f061133 == 0)
									{
										obj4 = 7;
									}
									goto IL_0128;
								}
								goto IL_0207;
								IL_0128:
								while (true)
								{
									int num3;
									switch ((int)obj4)
									{
									default:
										if ((nint)obj22 != 19)
										{
											if ((nint)obj22 == 999)
											{
												goto IL_0124;
											}
											goto case 6;
										}
										System.IO.Directory.CreateDirectory((string)obj20);
										obj4 = 5;
										continue;
									case 8:
										__8__1.cancellationToken = cancellationToken;
										obj4 = 9;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5616e31a21b646f69463de8959779c49 != 0)
										{
											obj4 = 1;
										}
										continue;
									case 9:
										throw new FileNotFoundException("客户端未包含 MCP 构建环境压缩包，请安装带构建环境的完整版本", ((McpBuildEnvironmentService)obj9).BundledArchivePath);
									case 3:
										goto end_IL_0128;
									case 0:
										break;
									case 6:
										__8__1.__4__this = __4__this;
										obj4 = 8;
										continue;
									case 2:
										if (System.IO.File.Exists(((McpBuildEnvironmentService)obj9).BundledArchivePath))
										{
											string text2 = System.IO.Path.GetDirectoryName(((McpBuildEnvironmentService)obj9).EnvironmentRoot);
											if (text2 == null)
											{
												obj4 = 10;
												continue;
											}
											obj20 = text2;
											num3 = 19;
											goto IL_0120;
										}
										obj4 = 9;
										continue;
									case 4:
										pythonPath = ((McpBuildEnvironmentService)obj9).PythonPath;
										obj4 = 3;
										continue;
									case 7:
										__8__1 = (__c__DisplayClass12_0)new __c__DisplayClass12_0();
										num3 = 6;
										goto IL_0120;
									case 1:
										if (((McpBuildEnvironmentService)obj9).IsInstalled)
										{
											obj4 = 4;
											continue;
										}
										goto case 2;
									case 5:
									{
										__c__DisplayClass12_0 _c__DisplayClass12_ = __8__1;
										object obj19 = obj20;
										string text = ".build-env-";
										System.Guid obj21 = System.Guid.NewGuid();
										_c__DisplayClass12_.temporaryRoot = System.IO.Path.Combine((string)obj19, string.Concat(text, (obj21).ToString("N")));
										obj4 = 2;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0cbd4cb78159400b923bd185c17f634c == 0)
										{
											obj4 = 0;
										}
										continue;
									}
									case 10:
										throw new InvalidOperationException("无法确定 MCP 环境目录");
									case 11:
										{
											try
											{
												object obj5;
												if (obj3 != null)
												{
													obj5 = 1;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1df8e086d5ed471cbc378d2545a921c6 != 0)
													{
														obj5 = 18;
													}
													goto IL_03b7;
												}
												goto IL_05a6;
												IL_03b7:
												while (true)
												{
													int num2;
													switch ((int)obj5)
													{
													case 12:
														return;
													default:
														if ((nint)obj10 != 26)
														{
															if ((nint)obj10 == 1006)
															{
																goto IL_03b3;
															}
															goto case 4;
														}
														goto case 14;
													case 4:
														__u__1 = (object)obj7;
														obj5 = 15;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_56220e0912894bf29c75280f6503f965 == 0)
														{
															obj5 = 3;
														}
														continue;
													case 2:
														((dynamic)obj7).GetResult();
														obj5 = 2;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9925520c809e49e19c0340f5f2a4c15c != 0)
														{
															obj5 = 0;
														}
														continue;
													case 1:
													{
														IProgress<string> obj11 = progress;
														if (obj11 == null)
														{
															obj5 = 7;
															continue;
														}
														obj11.Report("正在解压内置 Python 2.7 构建环境");
														obj5 = 10;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1282ca3a3b4d42dea9c5c692937e35bc == 0)
														{
															obj5 = 22;
														}
														continue;
													}
													case 11:
														obj3 = -1;
														__1__state = -1;
														obj5 = 2;
														continue;
													case 14:
														pythonPath = ((McpBuildEnvironmentService)obj9).PythonPath;
														obj5 = 5;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e1a4b1278f5749c28fff394e2932a022 == 0)
														{
															obj5 = 6;
														}
														continue;
													case 3:
														__u__1 = default(object);
														num2 = 11;
														goto IL_03af;
													case 18:
														if (!((dynamic)obj7).IsCompleted)
														{
															obj5 = 17;
															if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0cbd4cb78159400b923bd185c17f634c != 0)
															{
																obj5 = 17;
															}
															continue;
														}
														goto case 2;
													case 15:
														__t__builder.AwaitUnsafeOnCompleted<global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, _EnsureInstalledAsync_d__12>(ref *(global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter*)(&obj7), ref this);
														num2 = 12;
														goto IL_03af;
													case 16:
														obj7 = ((global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable)obj12).GetAwaiter();
														obj5 = 7;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_70c2a79cb96d4e75a079385f00e7bf58 == 0)
														{
															obj5 = 18;
														}
														continue;
													case 17:
														obj3 = 0;
														__1__state = 0;
														num2 = 4;
														goto IL_03af;
													case 13:
														if (System.IO.File.Exists(((McpBuildEnvironmentService)obj9).PythonPath))
														{
															obj5 = 6;
															continue;
														}
														goto case 9;
													case 8:
														break;
													case 7:
													case 10:
														obj12 = (System.Threading.Tasks.Task.Run(new Action(__8__1._EnsureInstalledAsync_b__0), __8__1.cancellationToken)).ConfigureAwait(false);
														num2 = 16;
														goto IL_03af;
													case 0:
													{
														string? obj8 = FindPythonExecutable(__8__1.temporaryRoot) ?? throw new InvalidDataException("构建环境压缩包中没有 python.exe");
														if (!System.IO.File.Exists(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(obj8), "mcp-package-tool.exe")))
														{
															throw new InvalidDataException("构建环境压缩包中没有 mcp-package-tool.exe");
														}
														(__8__1.cancellationToken).ThrowIfCancellationRequested();
														if (System.IO.Directory.Exists(((McpBuildEnvironmentService)obj9).EnvironmentRoot))
														{
															System.IO.Directory.Delete(((McpBuildEnvironmentService)obj9).EnvironmentRoot, true);
														}
														System.IO.Directory.Move(System.IO.Path.GetDirectoryName(obj8), ((McpBuildEnvironmentService)obj9).EnvironmentRoot);
														obj5 = 13;
														continue;
													}
													case 9:
														throw new InvalidDataException("构建环境部署后找不到 python.exe");
													case 6:
													{
														IProgress<string> obj6 = progress;
														if (obj6 == null)
														{
															num2 = 26;
															goto IL_03af;
														}
														obj6.Report("MCP 构建环境已部署");
														obj5 = 14;
														continue;
													}
													case 5:
														goto end_IL_03b7;
														IL_03af:
														obj10 = num2;
														goto IL_03b3;
														IL_03b3:
														obj5 = obj10;
														continue;
													}
													goto IL_05a6;
													continue;
													end_IL_03b7:
													break;
												}
												goto end_IL_037f;
												IL_05a6:
												obj7 = __u__1;
												obj5 = 3;
												goto IL_03b7;
												end_IL_037f:;
											}
											finally
											{
												if ((nint)obj3 < 0)
												{
													object obj13 = 1;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_d2995c01469b4ef28b5784f7cbf606e2 == 0)
													{
														obj13 = 3;
													}
													while (true)
													{
														switch ((int)obj13)
														{
														default:
															if ((nint)obj18 == 989)
															{
																goto IL_07e9;
															}
															break;
														case 1:
															try
															{
																if (!System.IO.Directory.Exists(__8__1.temporaryRoot))
																{
																	break;
																}
																object obj14 = 0;
																if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0c88e6c08eaf4e998e8fdd2c544cee2e == 0)
																{
																	obj14 = 1;
																}
																while (true)
																{
																	switch ((int)obj14)
																	{
																	default:
																		if ((nint)obj15 == 989)
																		{
																			obj14 = obj15;
																			continue;
																		}
																		break;
																	case 0:
																		break;
																	case 1:
																		goto end_IL_0859;
																	}
																	System.IO.Directory.Delete(__8__1.temporaryRoot, true);
																	obj14 = 4;
																	if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7d96de295fba4e09a034ce1853831e68 == 0)
																	{
																		obj14 = 1;
																	}
																	continue;
																	end_IL_0859:
																	break;
																}
															}
															catch (global::System.Exception)
															{
																object obj16 = 0;
																if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7ef2723341c74c2b88836c43256b27b6 == 0)
																{
																	obj16 = 1;
																}
																while (true)
																{
																	switch ((int)obj16)
																	{
																	default:
																		if ((nint)obj17 == 988)
																		{
																			obj16 = obj17;
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
														case 0:
															break;
														}
														break;
														IL_07e9:
														obj13 = obj18;
													}
												}
											}
											goto end_IL_0128;
										}
										IL_0120:
										obj22 = num3;
										goto IL_0124;
										IL_0124:
										obj4 = obj22;
										continue;
									}
									goto IL_0207;
									continue;
									end_IL_0128:
									break;
								}
								goto end_IL_00f0;
								IL_0207:
								obj4 = 14;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f3d80f367d504e3d9064e4cfb99ce343 == 0)
								{
									obj4 = 11;
								}
								goto IL_0128;
								end_IL_00f0:;
							}
							catch (global::System.Exception exception)
							{
								object obj23 = 1;
								while (true)
								{
									switch ((int)obj23)
									{
									case 2:
										return;
									default:
										if ((nint)obj24 != 10)
										{
											if ((nint)obj24 == 990)
											{
												goto IL_0940;
											}
											goto case 1;
										}
										__8__1 = null;
										obj23 = 0;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_db2c7dd1aabc4c9a97a36e710c0128ab == 0)
										{
											obj23 = 4;
										}
										break;
									case 0:
										__t__builder.SetException(exception);
										obj23 = 8;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bd86dbd500ab43b1bb4264e56ddd52b4 == 0)
										{
											obj23 = 2;
										}
										break;
									case 1:
										{
											__1__state = -2;
											int num4 = 10;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0b81b3b6b3bc4c4a8075444d576cb8ec == 0)
											{
												num4 = 3;
											}
											obj24 = num4;
											goto IL_0940;
										}
										IL_0940:
										obj23 = obj24;
										break;
									}
								}
							}
							goto case 1;
						case 1:
							__1__state = -2;
							obj2 = 4;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_70c2a79cb96d4e75a079385f00e7bf58 == 0)
							{
								obj2 = 3;
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
				obj3 = __1__state;
				num = 3;
				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3d9d86761de84aa48245c594db282bdf != 0)
				{
					num = 12;
				}
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
						__t__builder.SetStateMachine(stateMachine);
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_6143552ba66645398402f7404618079f == 0)
						{
							obj2 = 1;
						}
						continue;
					}
					break;
				}
			}
			while ((nint)obj == 989);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool HPDY3iL2uRbxok6bvC8P()
		{
			return rFS39PL2p1cl0VvOmCli == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object RF677cL2aPaclgiDeY6t()
		{
			return rFS39PL2p1cl0VvOmCli;
		}
	}

	private static McpBuildEnvironmentService ceQiemLvNR8ktgFmGxve;

	public string EnvironmentRoot
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.IO.Path.Combine(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.LocalApplicationData), "Mcp", "BuildEnvironment");
		}
	}

	public string PythonPath
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.IO.Path.Combine(EnvironmentRoot, "python.exe");
		}
	}

	public string GoPath
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_000c: Expected O, but got I4
			//IL_0029: Expected I4, but got O
			//IL_01d4->IL0010: Incompatible stack types: I4 vs O
			//IL_013d->IL0010: Incompatible stack types: I4 vs O
			//IL_01df->IL0010: Incompatible stack types: I4 vs O
			//IL_0148->IL0010: Incompatible stack types: I4 vs O
			object obj = 4;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj == 992)
						{
							goto end_IL_0010;
						}
						goto case 1;
					case 2:
						return string.Empty;
					case 0:
						return System.IO.Path.Combine(EnvironmentRoot, "go", "bin", "go.exe");
					case 3:
						return System.IO.Path.Combine(EnvironmentRoot, "go.exe");
					case 4:
						if (System.IO.File.Exists(System.IO.Path.Combine(EnvironmentRoot, "go.exe")))
						{
							obj2 = 5;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_527dac5507ee46fcb9d22f9ff955c1d0 == 0)
							{
								obj2 = 3;
							}
							break;
						}
						goto case 1;
					case 1:
						if (System.IO.File.Exists(System.IO.Path.Combine(EnvironmentRoot, "go", "bin", "go.exe")))
						{
							obj2 = 3;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_cb74c857a9564cc0b30907ecfe1e0cdf != 0)
							{
								obj2 = 0;
							}
							break;
						}
						goto case 2;
					}
					continue;
					end_IL_0010:
					break;
				}
			}
		}
	}

	public string PackageToolPath
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.IO.Path.Combine(EnvironmentRoot, "mcp-package-tool.exe");
		}
	}

	public string BundledArchivePath
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return PublishedFileResolver.Resolve("Features/McpStudio/Runtime/mcp-build-env.zip");
		}
	}

	public bool IsInstalled
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_006c->IL0010: Incompatible stack types: I4 vs O
			//IL_0077->IL0010: Incompatible stack types: I4 vs O
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
					case 0:
						return System.IO.File.Exists(PackageToolPath);
					case 1:
						if (!System.IO.File.Exists(PythonPath))
						{
							return false;
						}
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_56220e0912894bf29c75280f6503f965 == 0)
						{
							obj2 = 0;
						}
						break;
					}
					continue;
					end_IL_0010:
					break;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public unsafe global::System.Threading.Tasks.Task<string> EnsureInstalledAsync(IProgress<string>? progress = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_000c: Expected O, but got I4
		//IL_002d: Expected I4, but got O
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1->IL0010: Incompatible stack types: I4 vs O
		//IL_006e->IL0010: Incompatible stack types: I4 vs O
		//IL_009d->IL0010: Incompatible stack types: I4 vs O
		//IL_0105->IL0010: Incompatible stack types: I4 vs O
		//IL_00dc->IL0010: Incompatible stack types: I4 vs O
		//IL_0079->IL0010: Incompatible stack types: I4 vs O
		//IL_0110->IL0010: Incompatible stack types: I4 vs O
		//IL_008b->IL0010: Incompatible stack types: I4 vs O
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
						if ((nint)obj != 12)
						{
							if ((nint)obj == 993)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						((dynamic)obj3).progress = progress;
						obj2 = 3;
						continue;
					case 2:
						((dynamic)obj3).__t__builder = AsyncTaskMethodBuilder<string>.Create();
						obj2 = 10;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_dbb7d0b4e7ca46959ea177dcc91c1f0e != 0)
						{
							obj2 = 1;
						}
						continue;
					case 3:
						((dynamic)obj3).cancellationToken = cancellationToken;
						obj2 = 5;
						continue;
					case 1:
						break;
					case 0:
						((dynamic)obj3).__t__builder.Start<_EnsureInstalledAsync_d__12>(ref obj3);
						obj2 = 4;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0c88e6c08eaf4e998e8fdd2c544cee2e == 0)
						{
							obj2 = 9;
						}
						continue;
					case 4:
						return ((dynamic)obj3).__t__builder.Task;
					case 5:
						((dynamic)obj3).__1__state = -1;
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bd95bcb31f2a40c89aee1548651426a0 != 0)
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
			((dynamic)obj3).__4__this = this;
			num = 12;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void ExtractArchiveSafely(string archivePath, string destination, CancellationToken cancellationToken)
	{
		//IL_000c: Expected O, but got I4
		//IL_0025: Expected I4, but got O
		//IL_0642: Expected O, but got I4
		//IL_0223: Expected I4, but got O
		//IL_02b6: Expected I4, but got O
		//IL_0535: Expected I4, but got O
		//IL_05c8: Expected I4, but got O
		//IL_0094: Expected I4, but got O
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_00c5: Expected O, but got I4
		//IL_00fe: Expected I4, but got O
		//IL_0166: Expected I4, but got O
		//IL_01c2: Expected I4, but got O
		//IL_0265->IL0212: Incompatible stack types: I4 vs O
		//IL_01f5->IL0212: Incompatible stack types: I4 vs O
		//IL_028c->IL02a9: Incompatible stack types: I4 vs O
		//IL_0582->IL0524: Incompatible stack types: I4 vs O
		//IL_0507->IL0524: Incompatible stack types: I4 vs O
		//IL_059e->IL05bb: Incompatible stack types: I4 vs O
		//IL_0270->IL0212: Incompatible stack types: I4 vs O
		//IL_0200->IL0212: Incompatible stack types: I4 vs O
		//IL_0297->IL02a9: Incompatible stack types: I4 vs O
		//IL_0512->IL0524: Incompatible stack types: I4 vs O
		//IL_05a9->IL05bb: Incompatible stack types: I4 vs O
		//IL_02e9->IL02a9: Incompatible stack types: I4 vs O
		//IL_05fb->IL05bb: Incompatible stack types: I4 vs O
		//IL_02f4->IL02a9: Incompatible stack types: I4 vs O
		//IL_0606->IL05bb: Incompatible stack types: I4 vs O
		//IL_06ac->IL0010: Incompatible stack types: I4 vs O
		//IL_06b7->IL0010: Incompatible stack types: I4 vs O
		//IL_006e->IL008b: Incompatible stack types: I4 vs O
		//IL_0680->IL0010: Incompatible stack types: I4 vs O
		//IL_0079->IL008b: Incompatible stack types: I4 vs O
		//IL_068b->IL0010: Incompatible stack types: I4 vs O
		//IL_047a->IL00c9: Incompatible stack types: I4 vs O
		//IL_0452->IL00c9: Incompatible stack types: I4 vs O
		//IL_0485->IL00c9: Incompatible stack types: I4 vs O
		//IL_045d->IL00c9: Incompatible stack types: I4 vs O
		//IL_04e7->IL00c9: Incompatible stack types: I4 vs O
		//IL_04a6->IL00c9: Incompatible stack types: I4 vs O
		//IL_032a->IL00c9: Incompatible stack types: I4 vs O
		//IL_0364->IL00c9: Incompatible stack types: I4 vs O
		//IL_03b7->IL00c9: Incompatible stack types: I4 vs O
		//IL_04b1->IL00c9: Incompatible stack types: I4 vs O
		//IL_0335->IL00c9: Incompatible stack types: I4 vs O
		//IL_036f->IL00c9: Incompatible stack types: I4 vs O
		//IL_03c2->IL00c9: Incompatible stack types: I4 vs O
		//IL_0140->IL015d: Incompatible stack types: I4 vs O
		//IL_014b->IL015d: Incompatible stack types: I4 vs O
		//IL_019c->IL01b9: Incompatible stack types: I4 vs O
		//IL_01a7->IL01b9: Incompatible stack types: I4 vs O
		int num = 1;
		dynamic obj3 = default(object);
		object obj5 = default(object);
		dynamic current = default(object);
		object obj9 = default(object);
		dynamic obj7 = default(object);
		object obj13 = default(object);
		dynamic obj10 = default(object);
		object obj15 = default(object);
		object obj17 = default(object);
		object obj19 = default(object);
		object obj8 = default(object);
		object obj21 = default(object);
		object obj23 = default(object);
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
							obj3 = System.IO.Compression.ZipFile.OpenRead(archivePath);
							obj2 = 3;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2b2f512a98d548488e5242742b1ff011 != 0)
							{
								obj2 = 10;
							}
							continue;
						}
						goto end_IL_0010;
					case 3:
						try
						{
							dynamic enumerator = ((dynamic)obj3).Entries.GetEnumerator();
							object obj4 = 3;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_28a8309f77124973ab9263f59df1f564 != 0)
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
										goto IL_0087;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_0087:
								obj4 = obj5;
							}
							try
							{
								while (true)
								{
									object obj6;
									if (!((dynamic)enumerator).MoveNext())
									{
										obj6 = 3;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_09be964badeb4066912116bbb7cb20e9 != 0)
										{
											obj6 = 2;
										}
										goto IL_00c9;
									}
									goto IL_045d;
									IL_045d:
									current = ((global::System.Collections.Generic.IEnumerator<ZipArchiveEntry>)enumerator).Current;
									obj6 = 6;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_36a48f7fc5034120a3fadb53ab2f53cc == 0)
									{
										obj6 = 8;
									}
									goto IL_00c9;
									IL_00c9:
									while (true)
									{
										int num2;
										switch ((int)obj6)
										{
										default:
											if ((nint)obj9 != 19)
											{
												if ((nint)obj9 == 999)
												{
													goto IL_00c5;
												}
												goto case 1;
											}
											if (!string.IsNullOrEmpty(((dynamic)current).Name))
											{
												break;
											}
											num2 = 3;
											goto IL_00c1;
										case 10:
											try
											{
												dynamic obj11 = (object)new FileStream((string)obj7, (FileMode)1, (FileAccess)2, (FileShare)0);
												object obj12 = 2;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5e5cf2db569941efa91d919db7fefba0 != 0)
												{
													obj12 = 0;
												}
												while (true)
												{
													switch ((int)obj12)
													{
													default:
														if ((nint)obj13 == 988)
														{
															goto IL_0159;
														}
														break;
													case 0:
														break;
													}
													break;
													IL_0159:
													obj12 = obj13;
												}
												try
												{
													((dynamic)obj10).CopyTo((Stream)obj11);
													object obj14 = 5;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_09be964badeb4066912116bbb7cb20e9 != 0)
													{
														obj14 = 0;
													}
													while (true)
													{
														switch ((int)obj14)
														{
														default:
															if ((nint)obj15 == 988)
															{
																obj14 = obj15;
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
													object obj16;
													if (obj11 == null)
													{
														obj16 = 2;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_cb74c857a9564cc0b30907ecfe1e0cdf != 0)
														{
															obj16 = 0;
														}
														goto IL_0212;
													}
													goto IL_0245;
													IL_0212:
													while (true)
													{
														switch ((int)obj16)
														{
														default:
															if ((nint)obj17 == 990)
															{
																goto IL_020e;
															}
															goto end_IL_0212;
														case 0:
															goto end_IL_0212;
														case 2:
															break;
														case 1:
															goto end_IL_0212;
														}
														goto IL_0245;
														IL_020e:
														obj16 = obj17;
														continue;
														end_IL_0212:
														break;
													}
													goto end_IL_01da;
													IL_0245:
													((dynamic)obj11).Dispose();
													obj16 = 1;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9a1f67b15040430199ec9dc1289e168b == 0)
													{
														obj16 = 1;
													}
													goto IL_0212;
													end_IL_01da:;
												}
											}
											finally
											{
												if (obj10 != null)
												{
													object obj18 = 0;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f1dd9923a6bd42d5867c8e2e591d3e3b == 0)
													{
														obj18 = 4;
													}
													while (true)
													{
														switch ((int)obj18)
														{
														default:
															if ((nint)obj19 == 989)
															{
																obj18 = obj19;
																continue;
															}
															break;
														case 0:
															((dynamic)obj10).Dispose();
															obj18 = 6;
															if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e041d974da614bb9aad5f28559bec3d0 == 0)
															{
																obj18 = 1;
															}
															continue;
														case 1:
															break;
														}
														break;
													}
												}
											}
											goto end_IL_00c9;
										case 6:
											break;
										case 8:
											(cancellationToken).ThrowIfCancellationRequested();
											obj6 = 9;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_33eff53ba43c4c10a4788d4370759667 != 0)
											{
												obj6 = 11;
											}
											continue;
										case 9:
											obj7 = System.IO.Path.GetFullPath(System.IO.Path.Combine(destination, (((dynamic)current).FullName).Replace('/', Path.DirectorySeparatorChar)));
											obj6 = 11;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_28a8309f77124973ab9263f59df1f564 == 0)
											{
												obj6 = 18;
											}
											continue;
										case 4:
											throw new InvalidDataException("构建环境压缩包包含越权路径");
										case 0:
										case 5:
											goto end_IL_00c9;
										case 7:
											goto IL_045d;
										case 3:
											System.IO.Directory.CreateDirectory((string)obj7);
											obj6 = 0;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_496d0f7c1bde4581a78d6bb0fcab5473 == 0)
											{
												obj6 = 9;
											}
											continue;
										case 11:
											if ((obj7).StartsWith((string)obj8, (StringComparison)5))
											{
												num2 = 19;
												goto IL_00c1;
											}
											goto case 4;
										case 1:
											obj10 = ((dynamic)current).Open();
											obj6 = 10;
											continue;
										case 2:
											return;
											IL_00c5:
											obj6 = obj9;
											continue;
											IL_00c1:
											obj9 = num2;
											goto IL_00c5;
										}
										System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName((string)obj7));
										obj6 = 19;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e8864409e70b4d87b4c6598763ad15be != 0)
										{
											obj6 = 1;
										}
										continue;
										end_IL_00c9:
										break;
									}
								}
							}
							finally
							{
								object obj20;
								if (enumerator == null)
								{
									obj20 = 0;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0c88e6c08eaf4e998e8fdd2c544cee2e == 0)
									{
										obj20 = 5;
									}
									goto IL_0524;
								}
								goto IL_056c;
								IL_0524:
								while (true)
								{
									switch ((int)obj20)
									{
									default:
										if ((nint)obj21 == 990)
										{
											goto IL_0520;
										}
										goto end_IL_0524;
									case 0:
										goto end_IL_0524;
									case 1:
										break;
									case 2:
										goto end_IL_0524;
									}
									goto IL_056c;
									IL_0520:
									obj20 = obj21;
									continue;
									end_IL_0524:
									break;
								}
								goto end_IL_04ec;
								IL_056c:
								((dynamic)enumerator).Dispose();
								obj20 = 2;
								goto IL_0524;
								end_IL_04ec:;
							}
						}
						finally
						{
							if (obj3 != null)
							{
								object obj22 = 0;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bd95bcb31f2a40c89aee1548651426a0 != 0)
								{
									obj22 = 7;
								}
								while (true)
								{
									switch ((int)obj22)
									{
									default:
										if ((nint)obj23 == 989)
										{
											obj22 = obj23;
											continue;
										}
										break;
									case 0:
										((dynamic)obj3).Dispose();
										obj22 = 6;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7ef2723341c74c2b88836c43256b27b6 != 0)
										{
											obj22 = 1;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
						}
					case 0:
						break;
					case 2:
						return;
					case 1:
						System.IO.Directory.CreateDirectory(destination);
						obj2 = 9;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f651726544964479b0083c2c6dbce1d1 == 0)
						{
							obj2 = 0;
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
			while ((nint)obj == 991);
			obj8 = string.Concat(System.IO.Path.GetFullPath(destination), System.IO.Path.DirectorySeparatorChar.ToString());
			num = 10;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string? FindPythonExecutable(string root)
	{
		//IL_000c: Expected O, but got I4
		//IL_0021: Expected I4, but got O
		//IL_0070->IL0010: Incompatible stack types: I4 vs O
		//IL_00a0->IL0010: Incompatible stack types: I4 vs O
		//IL_007b->IL0010: Incompatible stack types: I4 vs O
		//IL_00ab->IL0010: Incompatible stack types: I4 vs O
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
					if ((nint)obj == 990)
					{
						goto end_IL_0010;
					}
					goto case 2;
				case 1:
					obj3 = System.IO.Path.Combine(root, "python.exe");
					obj2 = 7;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_35f00f496d71423193427920cdcc22f1 != 0)
					{
						obj2 = 0;
					}
					break;
				case 0:
					if (!System.IO.File.Exists((string)obj3))
					{
						return Enumerable.FirstOrDefault<string>(System.IO.Directory.EnumerateFiles(root, "python.exe", (SearchOption)1));
					}
					obj2 = 1;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0cbd4cb78159400b923bd185c17f634c == 0)
					{
						obj2 = 2;
					}
					break;
				case 2:
					return (string?)obj3;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public McpBuildEnvironmentService()
	{
		//IL_004c: Expected I4, but got O
		//IL_0031->IL0043: Incompatible stack types: I4 vs O
		//IL_003c->IL0043: Incompatible stack types: I4 vs O
		object obj = 0;
		if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b18c9101a9694aa1aae5a0a4ca0f1892 != 0)
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
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool EYwAaALvM67mTK8Csw4p()
	{
		return ceQiemLvNR8ktgFmGxve == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static McpBuildEnvironmentService joWWH8Lvp0c87TsRrBJL()
	{
		return ceQiemLvNR8ktgFmGxve;
	}
}
