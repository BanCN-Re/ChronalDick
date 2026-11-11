using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Features.McpStudio.Services;

internal sealed class McpWorkspaceSettings
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _LoadAsync_d__16 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<McpWorkspaceSettings> __t__builder;

		public string root;

		private TaskAwaiter<string> __u__1;

		internal static object UHpA3cL2wTChZbMyA6yV;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_000c: Expected O, but got I4
			//IL_0025: Expected I4, but got O
			//IL_034f: Expected I4, but got O
			//IL_03cc: Expected O, but got I4
			//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d6: Expected O, but got Unknown
			//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Expected O, but got Unknown
			//IL_0117: Expected O, but got I4
			//IL_012b: Expected O, but got I4
			//IL_00a8: Expected O, but got I4
			//IL_00f1: Expected I4, but got O
			//IL_0321->IL033e: Incompatible stack types: I4 vs O
			//IL_032c->IL033e: Incompatible stack types: I4 vs O
			//IL_037e->IL033e: Incompatible stack types: I4 vs O
			//IL_03aa->IL033e: Incompatible stack types: I4 vs O
			//IL_0389->IL033e: Incompatible stack types: I4 vs O
			//IL_03b5->IL033e: Incompatible stack types: I4 vs O
			//IL_0407->IL0010: Incompatible stack types: I4 vs O
			//IL_0067->IL0010: Incompatible stack types: I4 vs O
			//IL_0412->IL0010: Incompatible stack types: I4 vs O
			//IL_0072->IL0010: Incompatible stack types: I4 vs O
			//IL_02e0->IL00ac: Incompatible stack types: I4 vs O
			//IL_008f->IL00ac: Incompatible stack types: I4 vs O
			//IL_009a->IL00ac: Incompatible stack types: I4 vs O
			//IL_02a0->IL00ac: Incompatible stack types: I4 vs O
			//IL_02ce->IL00ac: Incompatible stack types: I4 vs O
			//IL_022f->IL00ac: Incompatible stack types: I4 vs O
			//IL_018c->IL00ac: Incompatible stack types: I4 vs O
			//IL_0176->IL00ac: Incompatible stack types: I4 vs O
			//IL_0126->IL00ac: Incompatible stack types: I4 vs O
			//IL_0144->IL00ac: Incompatible stack types: I4 vs O
			//IL_01e4->IL00ac: Incompatible stack types: I4 vs O
			//IL_02ab->IL00ac: Incompatible stack types: I4 vs O
			//IL_01a2->IL00ac: Incompatible stack types: I4 vs O
			//IL_0254->IL00ac: Incompatible stack types: I4 vs O
			//IL_014f->IL00ac: Incompatible stack types: I4 vs O
			//IL_025f->IL00ac: Incompatible stack types: I4 vs O
			int num = 1;
			dynamic obj3 = default(object);
			object obj7 = default(object);
			object obj5 = default(object);
			object obj6 = default(object);
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
							if ((nint)obj != 10)
							{
								goto end_IL_0010;
							}
							try
							{
								object obj4;
								if (obj3 != null)
								{
									obj4 = 2;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2ea097de099140f192d12c8111241f4e == 0)
									{
										obj4 = 22;
									}
									goto IL_00ac;
								}
								goto IL_02ce;
								IL_00ac:
								while (true)
								{
									McpWorkspaceSettings mcpWorkspaceSettings;
									int num2;
									switch ((int)obj4)
									{
									case 4:
										return;
									default:
										if ((nint)obj7 != 23)
										{
											if ((nint)obj7 == 1003)
											{
												goto IL_00a8;
											}
											goto case 10;
										}
										goto end_IL_00ac;
									case 14:
										obj3 = -1;
										__1__state = -1;
										obj4 = 1;
										continue;
									case 15:
										obj3 = 0;
										__1__state = 0;
										obj4 = 0;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ef04e2823b234f2aa7c3630bcaafe597 != 0)
										{
											obj4 = 22;
										}
										continue;
									case 11:
									case 12:
										obj5 = System.IO.File.ReadAllTextAsync((string)obj6, default(CancellationToken)).GetAwaiter();
										obj4 = 5;
										continue;
									case 10:
										__u__1 = default(TaskAwaiter<string>);
										obj4 = 14;
										continue;
									case 5:
										if (!((TaskAwaiter<string>*)(&obj5))->IsCompleted)
										{
											obj4 = 15;
											continue;
										}
										goto case 1;
									case 1:
										mcpWorkspaceSettings = JsonSerializer.Deserialize<McpWorkspaceSettings>(((TaskAwaiter<string>*)(&obj5))->GetResult(), (JsonSerializerOptions)null);
										if (mcpWorkspaceSettings == null)
										{
											obj4 = 3;
											continue;
										}
										goto IL_02e5;
									case 7:
										goto end_IL_00ac;
									case 9:
										__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _LoadAsync_d__16>(ref *(TaskAwaiter<string>*)(&obj5), ref this);
										obj4 = 4;
										continue;
									case 6:
										if (System.IO.File.Exists((string)obj6))
										{
											obj4 = 7;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e3c72d365c184d8193f0594ab3fd4d1f == 0)
											{
												obj4 = 11;
											}
											continue;
										}
										goto case 8;
									case 2:
										obj6 = System.IO.Path.Combine(root, "workspace.json");
										obj4 = 2;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3d9d86761de84aa48245c594db282bdf != 0)
										{
											obj4 = 6;
										}
										continue;
									case 0:
										__u__1 = (TaskAwaiter<string>)obj5;
										num2 = 9;
										goto IL_00a4;
									case 8:
										result = (object)new McpWorkspaceSettings();
										obj4 = 7;
										continue;
									case 13:
										break;
									case 3:
										{
											mcpWorkspaceSettings = (McpWorkspaceSettings)new McpWorkspaceSettings();
											goto IL_02e5;
										}
										IL_02e5:
										result = mcpWorkspaceSettings;
										num2 = 7;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4967aebcec78421b855bda2f45c82247 == 0)
										{
											num2 = 23;
										}
										goto IL_00a4;
										IL_00a8:
										obj4 = obj7;
										continue;
										IL_00a4:
										obj7 = num2;
										goto IL_00a8;
									}
									goto IL_02ce;
									continue;
									end_IL_00ac:
									break;
								}
								goto end_IL_0074;
								IL_02ce:
								obj5 = __u__1;
								obj4 = 10;
								goto IL_00ac;
								end_IL_0074:;
							}
							catch (global::System.Exception exception)
							{
								dynamic obj8 = 0;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_13568c2ecd3e40679d0e8ed63093dad4 != 0)
								{
									obj8 = 7;
								}
								while (true)
								{
									switch ((int)obj8)
									{
									case 2:
										return;
									default:
										if ((nint)obj9 != 990)
										{
											return;
										}
										obj8 = obj9;
										break;
									case 0:
										__1__state = -2;
										obj8 = 3;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_fd6fdaa7d4824d4c9cf1c9399aa7f204 == 0)
										{
											obj8 = 1;
										}
										break;
									case 1:
										__t__builder.SetException(exception);
										obj8 = 0;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_07c1f539d4f94d95bde09a0fba07dbbc != 0)
										{
											obj8 = 2;
										}
										break;
									}
								}
							}
							goto case 2;
						case 3:
							__t__builder.SetResult((McpWorkspaceSettings)result);
							obj2 = 3;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2ea097de099140f192d12c8111241f4e != 0)
							{
								obj2 = 0;
							}
							continue;
						case 0:
							return;
						case 1:
							break;
						case 2:
							__1__state = -2;
							obj2 = 1;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_56220e0912894bf29c75280f6503f965 != 0)
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
				while ((nint)obj == 991);
				obj3 = __1__state;
				num = 6;
				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b45a6b8459fb4961b1724a2890d79f3a != 0)
				{
					num = 10;
				}
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
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
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
					if ((nint)obj == 989)
					{
						break;
					}
					goto IL_0030;
					IL_0030:
					__t__builder.SetStateMachine(stateMachine);
					obj2 = 0;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_dabc6698d5764018a5f86ef3b5a7871e == 0)
					{
						obj2 = 3;
					}
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool CbrFsuL2eJq75KtVM3Bg()
		{
			return UHpA3cL2wTChZbMyA6yV == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object M63DgOL2PmDwdTRS2Xro()
		{
			return UHpA3cL2wTChZbMyA6yV;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _SaveAsync_d__17 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public string root;

		public McpWorkspaceSettings __4__this;

		private string _path_5__2;

		private string _temporary_5__3;

		private TaskAwaiter __u__1;

		internal static object RnoWlWL2xeAhCGHcW4ul;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_000c: Expected O, but got I4
			//IL_05c1: Expected O, but got I4
			//IL_0031: Expected I4, but got O
			//IL_007e: Expected O, but got I4
			//IL_03bf: Expected I4, but got O
			//IL_05da: Expected I4, but got O
			//IL_0516: Unknown result type (might be due to invalid IL or missing references)
			//IL_051d: Expected O, but got Unknown
			//IL_00d7: Expected O, but got I4
			//IL_00f8: Expected I4, but got O
			//IL_0255: Unknown result type (might be due to invalid IL or missing references)
			//IL_026c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Expected O, but got Unknown
			//IL_0295: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Expected O, but got I4
			//IL_034c: Expected O, but got I4
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Expected O, but got Unknown
			//IL_014e: Expected O, but got I4
			//IL_018b: Expected I4, but got O
			//IL_05a8->IL05c5: Incompatible stack types: I4 vs O
			//IL_0391->IL03ae: Incompatible stack types: I4 vs O
			//IL_05b3->IL05c5: Incompatible stack types: I4 vs O
			//IL_039c->IL03ae: Incompatible stack types: I4 vs O
			//IL_0617->IL05c5: Incompatible stack types: I4 vs O
			//IL_068a->IL05c5: Incompatible stack types: I4 vs O
			//IL_066e->IL05c5: Incompatible stack types: I4 vs O
			//IL_03f6->IL03ae: Incompatible stack types: I4 vs O
			//IL_0622->IL05c5: Incompatible stack types: I4 vs O
			//IL_0679->IL05c5: Incompatible stack types: I4 vs O
			//IL_042a->IL03ae: Incompatible stack types: I4 vs O
			//IL_0401->IL03ae: Incompatible stack types: I4 vs O
			//IL_06d1->IL0010: Incompatible stack types: I4 vs O
			//IL_00b7->IL0010: Incompatible stack types: I4 vs O
			//IL_06b5->IL0010: Incompatible stack types: I4 vs O
			//IL_0064->IL0010: Incompatible stack types: I4 vs O
			//IL_0435->IL03ae: Incompatible stack types: I4 vs O
			//IL_06c0->IL0010: Incompatible stack types: I4 vs O
			//IL_0076->IL0010: Incompatible stack types: I4 vs O
			//IL_0489->IL00db: Incompatible stack types: I4 vs O
			//IL_00c9->IL00db: Incompatible stack types: I4 vs O
			//IL_0494->IL00db: Incompatible stack types: I4 vs O
			//IL_0582->IL00db: Incompatible stack types: I4 vs O
			//IL_04d9->IL00db: Incompatible stack types: I4 vs O
			//IL_058d->IL00db: Incompatible stack types: I4 vs O
			//IL_04e4->IL00db: Incompatible stack types: I4 vs O
			//IL_0287->IL0152: Incompatible stack types: I4 vs O
			//IL_0135->IL0152: Incompatible stack types: I4 vs O
			//IL_0292->IL0152: Incompatible stack types: I4 vs O
			//IL_0140->IL0152: Incompatible stack types: I4 vs O
			//IL_02de->IL0152: Incompatible stack types: I4 vs O
			//IL_0216->IL0152: Incompatible stack types: I4 vs O
			//IL_01dc->IL0152: Incompatible stack types: I4 vs O
			//IL_0365->IL0152: Incompatible stack types: I4 vs O
			//IL_0347->IL0152: Incompatible stack types: I4 vs O
			//IL_01be->IL0152: Incompatible stack types: I4 vs O
			//IL_0221->IL0152: Incompatible stack types: I4 vs O
			//IL_01e7->IL0152: Incompatible stack types: I4 vs O
			//IL_0370->IL0152: Incompatible stack types: I4 vs O
			//IL_0303->IL0152: Incompatible stack types: I4 vs O
			//IL_030e->IL0152: Incompatible stack types: I4 vs O
			int num = 1;
			object obj10 = default(object);
			dynamic obj3 = default(object);
			object obj6 = default(object);
			object obj9 = default(object);
			dynamic obj8 = default(object);
			object obj12 = default(object);
			object obj14 = default(object);
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
							if ((nint)obj != 13)
							{
								if ((nint)obj == 994)
								{
									goto end_IL_0010;
								}
								goto case 4;
							}
							obj10 = __4__this;
							obj2 = 6;
							continue;
						case 2:
							return;
						case 5:
							_temporary_5__3 = null;
							obj2 = 3;
							continue;
						case 1:
							break;
						case 3:
							(__t__builder).SetResult();
							obj2 = 2;
							continue;
						case 6:
							try
							{
								object obj4;
								if (obj3 == null)
								{
									obj4 = 5;
									goto IL_00db;
								}
								goto IL_0464;
								IL_0464:
								System.IO.Directory.CreateDirectory(root);
								obj4 = 12;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0d16903d89da4928a5d60c2843281188 == 0)
								{
									obj4 = 3;
								}
								goto IL_00db;
								IL_00db:
								while (true)
								{
									switch ((int)obj4)
									{
									default:
										if ((nint)obj6 != 13)
										{
											if ((nint)obj6 == 993)
											{
												goto IL_00d7;
											}
											goto case 3;
										}
										try
										{
											object obj7;
											if (obj3 == null)
											{
												obj7 = 7;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2b2f512a98d548488e5242742b1ff011 != 0)
												{
													obj7 = 5;
												}
												goto IL_0152;
											}
											goto IL_0245;
											IL_0152:
											while (true)
											{
												int num2;
												switch ((int)obj7)
												{
												case 5:
													return;
												default:
													if ((nint)obj9 != 20)
													{
														if ((nint)obj9 == 1000)
														{
															goto IL_014e;
														}
														goto case 12;
													}
													__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _SaveAsync_d__17>(ref __u__1, ref this);
													num2 = 5;
													goto IL_014a;
												case 7:
												case 11:
													obj8 = __u__1;
													obj7 = 2;
													continue;
												case 3:
													obj3 = 0;
													__1__state = 0;
													obj7 = 4;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e3c72d365c184d8193f0594ab3fd4d1f == 0)
													{
														obj7 = 0;
													}
													continue;
												case 2:
													__u__1 = default(TaskAwaiter);
													obj7 = 16;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f1dd9923a6bd42d5867c8e2e591d3e3b != 0)
													{
														obj7 = 4;
													}
													continue;
												case 10:
													break;
												case 0:
													__u__1 = (TaskAwaiter)obj8;
													num2 = 19;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4abb095abaf846009b4cca8873b94957 == 0)
													{
														num2 = 20;
													}
													goto IL_014a;
												case 1:
												case 6:
													((dynamic)obj8).GetResult();
													obj7 = 9;
													continue;
												case 12:
													if (((dynamic)obj8).IsCompleted)
													{
														obj7 = 6;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b45a6b8459fb4961b1724a2890d79f3a == 0)
														{
															obj7 = 10;
														}
														continue;
													}
													goto case 3;
												case 9:
													System.IO.File.Move(_temporary_5__3, _path_5__2, true);
													obj7 = 8;
													continue;
												case 4:
													obj3 = -1;
													__1__state = -1;
													obj7 = 1;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_84adde53dc7e4a5fa7522d701cb0013d != 0)
													{
														obj7 = 0;
													}
													continue;
												case 8:
													goto end_IL_0152;
													IL_014e:
													obj7 = obj9;
													continue;
													IL_014a:
													obj9 = num2;
													goto IL_014e;
												}
												goto IL_0245;
												continue;
												end_IL_0152:
												break;
											}
											goto end_IL_011a;
											IL_0245:
											obj8 = (System.IO.File.WriteAllTextAsync(_temporary_5__3, JsonSerializer.Serialize<McpWorkspaceSettings>((McpWorkspaceSettings)obj10, (JsonSerializerOptions)null), default(CancellationToken))).GetAwaiter();
											obj7 = 12;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_07c1f539d4f94d95bde09a0fba07dbbc == 0)
											{
												obj7 = 0;
											}
											goto IL_0152;
											end_IL_011a:;
										}
										finally
										{
											if ((nint)obj3 < 0)
											{
												object obj11 = 6;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_dbb7d0b4e7ca46959ea177dcc91c1f0e != 0)
												{
													obj11 = 0;
												}
												while (true)
												{
													switch ((int)obj11)
													{
													default:
														if ((nint)obj12 == 990)
														{
															obj11 = obj12;
															continue;
														}
														break;
													case 1:
														System.IO.File.Delete(_temporary_5__3);
														obj11 = 2;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f981d20d38124e3ab94f0d411fda50cf == 0)
														{
															obj11 = 0;
														}
														continue;
													case 0:
														if (System.IO.File.Exists(_temporary_5__3))
														{
															obj11 = 1;
															if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2ee4c54a6c424cb680cd9d0811cd1011 == 0)
															{
																obj11 = 3;
															}
															continue;
														}
														break;
													case 2:
														break;
													}
													break;
												}
											}
										}
										goto end_IL_00db;
									case 4:
										break;
									case 3:
										_path_5__2 = System.IO.Path.Combine(root, "workspace.json");
										obj4 = 2;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f651726544964479b0083c2c6dbce1d1 != 0)
										{
											obj4 = 8;
										}
										continue;
									case 0:
									case 5:
										obj6 = 13;
										goto IL_00d7;
									case 2:
									{
										string text = _path_5__2;
										string text2 = ".";
										System.Guid obj5 = System.Guid.NewGuid();
										_temporary_5__3 = string.Concat(text, text2, (obj5).ToString("N"), ".tmp");
										obj4 = 0;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ee050290791c4dfbba3a13b8d87cc1bd == 0)
										{
											obj4 = 0;
										}
										continue;
									}
									case 1:
										goto end_IL_00db;
										IL_00d7:
										obj4 = obj6;
										continue;
									}
									goto IL_0464;
									continue;
									end_IL_00db:
									break;
								}
							}
							catch (global::System.Exception ex)
							{
								object obj13 = 8;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_13568c2ecd3e40679d0e8ed63093dad4 == 0)
								{
									obj13 = 1;
								}
								while (true)
								{
									switch ((int)obj13)
									{
									default:
										if ((nint)obj14 == 11)
										{
											return;
										}
										if ((nint)obj14 == 991)
										{
											goto IL_05c1;
										}
										goto case 0;
									case 1:
										__1__state = -2;
										obj13 = 9;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2b8232439dce49e49a3fdd295da14355 == 0)
										{
											obj13 = 2;
										}
										break;
									case 0:
									{
										(__t__builder).SetException(ex);
										int num3 = 2;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9eef6557bd0f4e9cabe58f018cd42055 == 0)
										{
											num3 = 11;
										}
										obj14 = num3;
										goto IL_05c1;
									}
									case 3:
										_temporary_5__3 = null;
										obj13 = 1;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5144ebdc507c41fb87d88fdce3dc76e9 != 0)
										{
											obj13 = 0;
										}
										break;
									case 2:
										{
											_path_5__2 = null;
											obj13 = 3;
											break;
										}
										IL_05c1:
										obj13 = obj14;
										break;
									}
								}
							}
							goto case 4;
						case 4:
							__1__state = -2;
							obj2 = 0;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5144ebdc507c41fb87d88fdce3dc76e9 == 0)
							{
								obj2 = 10;
							}
							continue;
						case 0:
							_path_5__2 = null;
							obj2 = 5;
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
				num = 13;
				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_30453b5c95424721b20dac45933b18fc == 0)
				{
					num = 0;
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
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7965c0cf8c924e228a4010c08420db19 != 0)
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
		private static void _cctor()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool JGBtlUL2FeeVqNgRDSG6()
		{
			return RnoWlWL2xeAhCGHcW4ul == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object ORyjAgL2sROCkI0RNZwy()
		{
			return RnoWlWL2xeAhCGHcW4ul;
		}
	}

	[CompilerGenerated]
	private string _SourceDirectory_k__BackingField;

	[CompilerGenerated]
	private string _OutputPath_k__BackingField;

	[CompilerGenerated]
	private string _PackageId_k__BackingField;

	[CompilerGenerated]
	private string _PythonPath_k__BackingField;

	private static McpWorkspaceSettings srwtddLve59LsAQIvqQC;

	public string SourceDirectory
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _SourceDirectory_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_004b->IL0010: Incompatible stack types: I4 vs O
			//IL_0056->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			do
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 1:
						_SourceDirectory_k__BackingField = value;
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_07c1f539d4f94d95bde09a0fba07dbbc == 0)
						{
							obj2 = 1;
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
	}

	public string OutputPath
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _OutputPath_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_004b->IL0010: Incompatible stack types: I4 vs O
			//IL_0056->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			do
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 1:
						_OutputPath_k__BackingField = value;
						obj2 = 5;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e8ca07a3866c4b3b9e07b1ae67715f0c == 0)
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
	}

	public string PackageId
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _PackageId_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_004b->IL0010: Incompatible stack types: I4 vs O
			//IL_0056->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			do
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 1:
						_PackageId_k__BackingField = value;
						obj2 = 3;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9a1f67b15040430199ec9dc1289e168b != 0)
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
	}

	public string PythonPath
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _PythonPath_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_004b->IL0010: Incompatible stack types: I4 vs O
			//IL_0056->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			do
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 1:
						_PythonPath_k__BackingField = value;
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5abcb08dd0ae4b88988bbb89131b0cab == 0)
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
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public unsafe static global::System.Threading.Tasks.Task<McpWorkspaceSettings> LoadAsync(string root)
	{
		//IL_000c: Expected O, but got I4
		//IL_0025: Expected I4, but got O
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4->IL0010: Incompatible stack types: I4 vs O
		//IL_0073->IL0010: Incompatible stack types: I4 vs O
		//IL_007e->IL0010: Incompatible stack types: I4 vs O
		//IL_00c1->IL0010: Incompatible stack types: I4 vs O
		//IL_00cc->IL0010: Incompatible stack types: I4 vs O
		int num = 3;
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
						if ((nint)obj != 10)
						{
							if ((nint)obj == 991)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						((dynamic)obj3).__1__state = -1;
						obj2 = 7;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e1a4b1278f5749c28fff394e2932a022 != 0)
						{
							obj2 = 0;
						}
						continue;
					case 1:
						return ((dynamic)obj3).__t__builder.Task;
					case 3:
						((dynamic)obj3).__t__builder = AsyncTaskMethodBuilder<McpWorkspaceSettings>.Create();
						obj2 = 10;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1df8e086d5ed471cbc378d2545a921c6 == 0)
						{
							obj2 = 2;
						}
						continue;
					case 2:
						break;
					case 0:
						((dynamic)obj3).__t__builder.Start<_LoadAsync_d__16>(ref obj3);
						obj2 = 1;
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
			((dynamic)obj3).root = root;
			num = 10;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_35f00f496d71423193427920cdcc22f1 == 0)
			{
				num = 10;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public unsafe global::System.Threading.Tasks.Task SaveAsync(string root)
	{
		//IL_000c: Expected O, but got I4
		//IL_0029: Expected I4, but got O
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7->IL0010: Incompatible stack types: I4 vs O
		//IL_00e7->IL0010: Incompatible stack types: I4 vs O
		//IL_005c->IL0010: Incompatible stack types: I4 vs O
		//IL_00c2->IL0010: Incompatible stack types: I4 vs O
		//IL_00f2->IL0010: Incompatible stack types: I4 vs O
		//IL_009b->IL0010: Incompatible stack types: I4 vs O
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
						((dynamic)obj3).__t__builder.Start<_SaveAsync_d__17>(ref obj3);
						obj2 = 3;
						continue;
					case 4:
						((dynamic)obj3).root = root;
						obj2 = 2;
						continue;
					case 2:
						break;
					case 0:
						((dynamic)obj3).__4__this = this;
						obj2 = 4;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_481dc375f7e24d3cb0e875f941fcda75 != 0)
						{
							obj2 = 2;
						}
						continue;
					case 1:
						((dynamic)obj3).__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
						obj2 = 4;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2b8232439dce49e49a3fdd295da14355 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 3:
						return (obj3.__t__builder).Task;
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
			((dynamic)obj3).__1__state = -1;
			num = 11;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e8864409e70b4d87b4c6598763ad15be == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public McpWorkspaceSettings()
	{
		//IL_008c: Expected I4, but got O
		//IL_0071->IL0083: Incompatible stack types: I4 vs O
		//IL_007c->IL0083: Incompatible stack types: I4 vs O
		_SourceDirectory_k__BackingField = string.Empty;
		_OutputPath_k__BackingField = string.Empty;
		_PackageId_k__BackingField = string.Empty;
		_PythonPath_k__BackingField = string.Empty;
		object obj = 2;
		if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_dabc6698d5764018a5f86ef3b5a7871e != 0)
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
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool jhQsLBLvP7DvimymiMXJ()
	{
		return srwtddLve59LsAQIvqQC == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static McpWorkspaceSettings UyfrqpLvxNrSTXe8CNa6()
	{
		return srwtddLve59LsAQIvqQC;
	}
}
