using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using CdEjKjX5XwI8HIEc5VXp;
using QRgJ6Vf1lrdpBGToI64w;
using fDAldojjppXrctUVYOJn;
using gjyRx5f1wubbeI3q2eIF;
using iac1UWf17xUpoD7r1ZnK;

namespace sNao0sfkUbEh0g4Pg2tQ;

internal sealed class MRYvDAfkhkOGvSerUTqQ
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _TryLoadAsync_d__9 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<E9A673f1RYqU3JaH0aLP> __t__builder;

		public string entryPath;

		public MRYvDAfkhkOGvSerUTqQ __4__this;

		public CancellationToken cancellationToken;

		public cpFof3f1mS0j06Q2dp3s resource;

		private FileStream _stream_5__2;

		private object __7__wrap2;

		private int __7__wrap3;

		private E9A673f1RYqU3JaH0aLP __7__wrap4;

		private ConfiguredValueTaskAwaitable<E9A673f1RYqU3JaH0aLP?>.ConfiguredValueTaskAwaiter __u__1;

		private ValueTaskAwaiter __u__2;

		private static object VgPN0kD8IoNb4sqkSpxB;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_0a82: Expected O, but got I4
			//IL_094f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0951: Unknown result type (might be due to invalid IL or missing references)
			//IL_0990: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b17: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b1c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0384: Unknown result type (might be due to invalid IL or missing references)
			//IL_0389: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_046c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0590: Unknown result type (might be due to invalid IL or missing references)
			//IL_056b: Expected O, but got Ref
			//IL_0dca->IL0d93: Incompatible stack heights: 3 vs 1
			//IL_0e33->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0b28->IL0181: Incompatible stack heights: 1 vs 6
			//IL_0e3e->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0222->IL0185: Incompatible stack heights: 0 vs 5
			//IL_0189->IL0189: Incompatible stack heights: 6 vs 1
			//IL_03ba->IL0260: Incompatible stack heights: 2 vs 1
			int num = 2;
			int num4 = default;
			int num6 = default;
			string text2 = default;
			MRYvDAfkhkOGvSerUTqQ mRYvDAfkhkOGvSerUTqQ = default;
			int num9 = default;
			int num16 = default;
			ConfiguredValueTaskAwaitable<E9A673f1RYqU3JaH0aLP> _u__2 = default;
			ConfiguredValueTaskAwaitable<E9A673f1RYqU3JaH0aLP> val = default;
			E9A673f1RYqU3JaH0aLP e9A673f1RYqU3JaH0aLP2 = default;
			global::System.Threading.Tasks.ValueTask<E9A673f1RYqU3JaH0aLP> valueTask2 = default;
			global::System.Collections.Generic.IEnumerator<KJlRUyf1gXDQ3gU9B09h> packs = default;
			int num11 = default;
			KJlRUyf1gXDQ3gU9B09h kJlRUyf1gXDQ3gU9B09h = default;
			int num14 = default;
			object obj = default;
			int num18 = default;
			ValueTaskAwaiter _u__ = default;
			int num8 = default;
			global::System.Threading.Tasks.ValueTask valueTask = default;
			int num20 = default;
			int num22 = default;
			string text = default;
			int num24 = default;
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
									goto end_IL_0010;
								}
								goto case 1;
							}
							_ = __t__builder;
							_ = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
							{
								_ = 0;
							}
							continue;
						case 3:
							break;
						case 4:
							try
							{
								int num5;
								if ((uint)num4 > 1u)
								{
									num5 = 5;
									goto IL_0096;
								}
								goto IL_0145;
								IL_0145:
								num5 = 8;
								goto IL_0096;
								IL_0096:
								while (true)
								{
									switch (num5)
									{
									default:
										if (num6 != 16)
										{
											if (num6 == 996)
											{
												goto IL_0092;
											}
											goto case 6;
										}
										goto end_IL_0096;
									case 2:
									case 3:
									{
										E9A673f1RYqU3JaH0aLP e9A673f1RYqU3JaH0aLP = null;
										num6 = 16;
										goto IL_0092;
									}
									case 4:
										if (!System.IO.Directory.Exists(text2))
										{
											num5 = 3;
											continue;
										}
										break;
									case 6:
										text2 = mRYvDAfkhkOGvSerUTqQ.JPMfk7DdO4p(entryPath);
										num5 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
										{
											num5 = 8;
										}
										continue;
									case 1:
										break;
									case 8:
										try
										{
											int num7;
											if (num4 != 0)
											{
												num7 = 5;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
												{
													num7 = 23;
												}
												goto IL_0189;
											}
											goto IL_0a29;
											IL_0189:
											while (true)
											{
												switch (num7)
												{
												default:
													switch (num9)
													{
													case 1017:
														continue;
													case 37:
														__7__wrap2 = null;
														num7 = 16;
														continue;
													}
													goto case 4;
												case 7:
													try
													{
														int num10;
														if (num4 != 0)
														{
															num10 = 0;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
															{
																num10 = 18;
															}
															goto IL_0260;
														}
														goto IL_0383;
														IL_0260:
														while (true)
														{
															int num15;
															switch (num10)
															{
															default:
																if (num16 != 32)
																{
																	if (num16 == 1012)
																	{
																		goto IL_025c;
																	}
																	goto case 18;
																}
																goto IL_0566;
															case 4:
																_u__2 = val;
																num10 = 6;
																continue;
															case 7:
															case 11:
																__7__wrap4 = null;
																num10 = 3;
																continue;
															case 0:
																num4 = (__1__state = -1);
																num15 = 32;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
																{
																	num15 = 2;
																}
																goto IL_0258;
															case 22:
																if (!string.Equals(e9A673f1RYqU3JaH0aLP2.Md5, resource.Md5, (StringComparison)5))
																{
																	num15 = 11;
																	goto IL_0258;
																}
																goto case 12;
															case 24:
																break;
															case 8:
																_ = valueTask2;
																val = (ConfiguredValueTaskAwaitable<E9A673f1RYqU3JaH0aLP>)0;
																_ = 4;
																continue;
															case 13:
																__u__1 = _u__2;
																num10 = 28;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
																{
																	num10 = 9;
																}
																continue;
															case 23:
																packs = (global::System.Collections.Generic.IEnumerator<KJlRUyf1gXDQ3gU9B09h>)e9A673f1RYqU3JaH0aLP2.Packs;
																num10 = 11;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
																{
																	num10 = 15;
																}
																continue;
															case 9:
																__t__builder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable<E9A673f1RYqU3JaH0aLP>.ConfiguredValueTaskAwaiter, _TryLoadAsync_d__9>(ref _u__2, ref this);
																num10 = 21;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
																{
																	num10 = 2;
																}
																continue;
															case 17:
																num4 = (__1__state = 0);
																num10 = 30;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
																{
																	num10 = 13;
																}
																continue;
															case 18:
																valueTask2 = JsonSerializer.DeserializeAsync<E9A673f1RYqU3JaH0aLP>((Stream)(object)_stream_5__2, (JsonSerializerOptions)tkpfk5Ktv2i, cancellationToken);
																num10 = 5;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
																{
																	num10 = 8;
																}
																continue;
															case 5:
																if ((object)e9A673f1RYqU3JaH0aLP2 != null)
																{
																	num10 = 21;
																	continue;
																}
																goto case 7;
															case 19:
																goto IL_04a8;
															case 2:
																return;
															case 12:
																if (e9A673f1RYqU3JaH0aLP2.Size == resource.Size)
																{
																	num10 = 23;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
																	{
																		num10 = 1;
																	}
																	continue;
																}
																goto case 7;
															case 1:
																if (e9A673f1RYqU3JaH0aLP2.Packs == null)
																{
																	num10 = 7;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee != 0)
																	{
																		num10 = 12;
																	}
																	continue;
																}
																goto case 23;
															case 21:
																if (e9A673f1RYqU3JaH0aLP2.FormatVersion == 3)
																{
																	num10 = 10;
																	continue;
																}
																goto case 7;
															case 20:
																__u__1 = default;
																num10 = 0;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
																{
																	num10 = 0;
																}
																continue;
															case 15:
																try
																{
																	while (true)
																	{
																		IL_062e:
																		if (!(packs).MoveNext())
																		{
																			num11 = 14;
																			goto IL_05e8;
																		}
																		goto IL_0649;
																		IL_05ec:
																		int num12;
																		while (true)
																		{
																			switch (num12)
																			{
																			case 4:
																				goto IL_062e;
																			case 0:
																				goto IL_0649;
																			case 3:
																				if (!string.IsNullOrWhiteSpace(kJlRUyf1gXDQ3gU9B09h.ResourceUuid))
																				{
																					num12 = 1;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
																					{
																						num12 = 5;
																					}
																					continue;
																				}
																				goto case 5;
																			case 5:
																				__7__wrap4 = null;
																				num12 = 2;
																				continue;
																			case 1:
																				if (System.IO.Directory.Exists(kJlRUyf1gXDQ3gU9B09h.Path))
																				{
																					num12 = 6;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
																					{
																						num12 = 1;
																					}
																					continue;
																				}
																				goto case 5;
																			case 2:
																				goto end_IL_062e;
																			case 6:
																				if (!((LixQVCX5bgefMapc3r7K)mRYvDAfkhkOGvSerUTqQ.LKpfk671NOy).BQlX5YqJ5tO(kJlRUyf1gXDQ3gU9B09h.Path))
																				{
																					num12 = 5;
																					continue;
																				}
																				goto IL_062e;
																			}
																			break;
																		}
																		switch (num11)
																		{
																		case 14:
																			goto IL_04a8;
																		case 994:
																			break;
																		default:
																			goto end_IL_062e;
																		}
																		goto IL_05e8;
																		IL_0649:
																		kJlRUyf1gXDQ3gU9B09h = (KJlRUyf1gXDQ3gU9B09h)(object)packs;
																		num12 = 1;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
																		{
																			num12 = 3;
																		}
																		goto IL_05ec;
																		IL_05e8:
																		num12 = num11;
																		goto IL_05ec;
																		continue;
																		end_IL_062e:
																		break;
																	}
																}
																finally
																{
																	int num13;
																	if (num4 >= 0)
																	{
																		num13 = 8;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
																		{
																			num13 = 1;
																		}
																		goto IL_0757;
																	}
																	goto IL_07cc;
																	IL_07cc:
																	if (packs == null)
																	{
																		num13 = 2;
																		goto IL_0757;
																	}
																	goto IL_0792;
																	IL_0792:
																	(packs).Dispose();
																	num13 = 3;
																	goto IL_0757;
																	IL_0757:
																	while (true)
																	{
																		switch (num13)
																		{
																		default:
																			if (num14 == 992)
																			{
																				num13 = num14;
																				continue;
																			}
																			goto IL_07cc;
																		case 1:
																			break;
																		case 0:
																			goto IL_0792;
																		case 2:
																			break;
																		case 4:
																			goto IL_07cc;
																		case 3:
																			break;
																		}
																		break;
																	}
																}
																goto case 3;
															case 10:
																if (string.Equals(e9A673f1RYqU3JaH0aLP2.ItemId, resource.ItemId, (StringComparison)4))
																{
																	num10 = 22;
																	continue;
																}
																goto case 7;
															case 3:
															case 14:
																__7__wrap3 = 1;
																num15 = 16;
																goto IL_0258;
															case 6:
																if (&_u__2 == null)
																{
																	num10 = 17;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 != 0)
																	{
																		num10 = 4;
																	}
																	continue;
																}
																goto IL_0566;
															case 16:
																goto end_IL_0260;
																IL_025c:
																num10 = num16;
																continue;
																IL_04a8:
																__7__wrap4 = e9A673f1RYqU3JaH0aLP2;
																num10 = 14;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
																{
																	num10 = 21;
																}
																continue;
																IL_0566:
																e9A673f1RYqU3JaH0aLP2 = (E9A673f1RYqU3JaH0aLP)(&_u__2);
																num10 = 5;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
																{
																	num10 = 19;
																}
																continue;
																IL_0258:
																num16 = num15;
																goto IL_025c;
															}
															goto IL_0383;
															continue;
															end_IL_0260:
															break;
														}
														goto end_IL_0228;
														IL_0383:
														_u__2 = __u__1;
														num10 = 31;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
														{
															num10 = 20;
														}
														goto IL_0260;
														end_IL_0228:;
													}
													catch (object obj2)
													{
														obj = obj2;
														int num17 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
														{
															num17 = 4;
														}
														while (true)
														{
															switch (num17)
															{
															default:
																if (num18 == 989)
																{
																	num17 = num18;
																	continue;
																}
																break;
															case 1:
																__7__wrap2 = obj;
																num17 = 0;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
																{
																	num17 = 3;
																}
																continue;
															case 0:
																break;
															}
															break;
														}
													}
													goto case 12;
												case 17:
													_u__ = __u__2;
													num7 = 2;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
													{
														num7 = 15;
													}
													continue;
												case 11:
													__7__wrap4 = null;
													num7 = 3;
													continue;
												case 6:
													if (num8 == 1)
													{
														num7 = 3;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
														{
															num7 = 8;
														}
														continue;
													}
													goto case 28;
												case 1:
													__u__2 = _u__;
													num7 = 25;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
													{
														num7 = 19;
													}
													continue;
												case 12:
													if (_stream_5__2 == null)
													{
														num7 = 29;
														continue;
													}
													goto case 27;
												case 15:
													__u__2 = default;
													num7 = 14;
													continue;
												case 14:
													num4 = (__1__state = -1);
													num7 = 26;
													continue;
												case 28:
													__7__wrap2 = null;
													num7 = 11;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 != 0)
													{
														num7 = 21;
													}
													continue;
												case 16:
													__7__wrap3 = 0;
													num7 = 10;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
													{
														num7 = 11;
													}
													continue;
												case 13:
													num4 = (__1__state = 1);
													num7 = 26;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
													{
														num7 = 1;
													}
													continue;
												case 10:
													break;
												case 22:
												case 29:
													obj = __7__wrap2;
													num7 = 2;
													continue;
												case 2:
													if (obj != null)
													{
														num7 = 4;
														continue;
													}
													goto case 24;
												case 0:
													_ = 3;
													_ = 1;
													_ = 1;
													global::System.Runtime.CompilerServices.Unsafe.Write(&((_TryLoadAsync_d__9*)16384)->_stream_5__2, (object)1207959552);
													goto IL_0181;
												case 3:
													_stream_5__2 = null;
													num7 = 23;
													continue;
												case 20:
													goto end_IL_0189;
												case 27:
													valueTask = (_stream_5__2).DisposeAsync();
													num7 = 21;
													continue;
												case 24:
													num8 = __7__wrap3;
													num7 = 6;
													continue;
												case 9:
												case 26:
													(_u__).GetResult();
													num7 = 22;
													continue;
												case 21:
													_u__ = (valueTask).GetAwaiter();
													_ = 18;
													goto IL_0181;
												case 5:
													if (num4 != 1)
													{
														num7 = 8;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
														{
															num7 = 0;
														}
														continue;
													}
													goto case 17;
												case 8:
												{
													E9A673f1RYqU3JaH0aLP e9A673f1RYqU3JaH0aLP = __7__wrap4;
													num7 = 20;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
													{
														num7 = 30;
													}
													continue;
												}
												case 19:
													return;
												case 18:
													if ((_u__).IsCompleted)
													{
														num7 = 9;
														continue;
													}
													goto case 13;
												case 25:
													__t__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, _TryLoadAsync_d__9>(ref _u__, ref this);
													num7 = 11;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
													{
														num7 = 19;
													}
													continue;
												case 4:
													(System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture((obj as global::System.Exception) ?? throw obj)).Throw();
													num7 = 24;
													continue;
												case 23:
													goto IL_0d5e;
													IL_0181:
													num9 = 37;
													continue;
												}
												goto IL_0a29;
												continue;
												end_IL_0189:
												break;
											}
											goto end_IL_0151;
											IL_0a29:
											num7 = 15;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
											{
												num7 = 7;
											}
											goto IL_0189;
											end_IL_0151:;
										}
										catch (OperationCanceledException)
										{
											int num19 = 3;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
											{
												num19 = 0;
											}
											while (true)
											{
												switch (num19)
												{
												default:
													if (num20 == 988)
													{
														goto IL_0c3d;
													}
													break;
												case 0:
													break;
												}
												break;
												IL_0c3d:
												num19 = num20;
											}
											throw new global::System.Exception();
										}
										catch (global::System.Exception)
										{
											int num21 = 7;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
											{
												num21 = 0;
											}
											while (true)
											{
												switch (num21)
												{
												default:
													if (num22 == 989)
													{
														num21 = num22;
														continue;
													}
													break;
												case 0:
													break;
												case 1:
													goto end_IL_0c91;
												}
												E9A673f1RYqU3JaH0aLP e9A673f1RYqU3JaH0aLP = null;
												num21 = 5;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
												{
													num21 = 1;
												}
												continue;
												end_IL_0c91:
												break;
											}
										}
										goto end_IL_0096;
									case 5:
										text = System.IO.Path.Combine(entryPath, "installed.json");
										num5 = 6;
										continue;
									case 0:
										if (!System.IO.File.Exists(text))
										{
											num5 = 2;
											continue;
										}
										goto case 4;
									case 7:
										goto IL_0d5e;
										IL_0092:
										num5 = num6;
										continue;
										IL_0d5e:
										throw null;
									}
									goto IL_0145;
									continue;
									end_IL_0096:
									break;
								}
							}
							catch (global::System.Exception)
							{
								int num23 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 != 0)
								{
									num23 = 1;
								}
								while (true)
								{
									switch (num23)
									{
									default:
										if (num24 == 990)
										{
											num23 = num24;
											break;
										}
										goto case 0;
									case 0:
										_ = __t__builder;
										_ = 2;
										break;
									case 1:
										__1__state = -2;
										num23 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
										{
											num23 = 8;
										}
										break;
									case 2:
										return;
									}
								}
							}
							break;
						case 0:
							return;
						case 2:
							num4 = __1__state;
							num3 = 1;
							continue;
						case 1:
							mRYvDAfkhkOGvSerUTqQ = __4__this;
							num3 = 4;
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
				__1__state = -2;
				num = 5;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de != 0)
				{
					num = 11;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_ = __t__builder;
		}

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
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0012;
								}
								goto case 1;
							}
							return;
						case 0:
							num3 = 2;
							continue;
						case 1:
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
							{
								num3 = 0;
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
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
				{
					num = 2;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool S0bYNVD8BdFUlapp5EGE()
		{
			return VgPN0kD8IoNb4sqkSpxB == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object GySEctD8g3HMPog5QVAY()
		{
			return VgPN0kD8IoNb4sqkSpxB;
		}
	}

	private static readonly object tkpfk5Ktv2i;

	private readonly object LKpfk671NOy;

	private static object PEblxZZNn1hhO0fAvtkM;

	[MethodImpl((MethodImplOptions)8)]
	internal MRYvDAfkhkOGvSerUTqQ(LixQVCX5bgefMapc3r7K paths)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal string ly0fkrtfGQj(string serverId, cpFof3f1mS0j06Q2dp3s resource)
	{
		return System.IO.Path.Combine(((LixQVCX5bgefMapc3r7K)LKpfk671NOy).ServerResourcesPath, sgFfkHLXM8H(serverId), sgFfkHLXM8H(resource.ItemId), alLfkKuXdwj(resource.Md5));
	}

	[MethodImpl((MethodImplOptions)8)]
	internal string LJQfkouSIYc(string entryPath)
	{
		return System.IO.Path.Combine(entryPath, "resource.download");
	}

	[MethodImpl((MethodImplOptions)8)]
	internal string kTufkmtulvh(string entryPath)
	{
		return System.IO.Path.Combine(entryPath, "resource.download.partial");
	}

	[MethodImpl((MethodImplOptions)8)]
	internal string JPMfk7DdO4p(string entryPath)
	{
		return System.IO.Path.Combine(entryPath, "content");
	}

	[MethodImpl((MethodImplOptions)8)]
	internal string FKNfkA7yOkO(string entryPath)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		string text = "staging-";
		Guid val = System.Guid.NewGuid();
		return System.IO.Path.Combine(entryPath, string.Concat(text, (val).ToString("N")));
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe global::System.Threading.Tasks.Task<E9A673f1RYqU3JaH0aLP?> sB7fkIyIyWt(string entryPath, cpFof3f1mS0j06Q2dp3s resource, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task WX4fkBjBLyA(string entryPath, E9A673f1RYqU3JaH0aLP state, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_SaveAsync_d__10 saveAsync_d__ = default;
		saveAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void QfjfkguF014(object stagingPath, object contentPath)
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
						if (num2 != 10)
						{
							goto end_IL_0010;
						}
						goto case 0;
					case 3:
						return;
					case 2:
						break;
					case 0:
						System.IO.Directory.Move((string)stagingPath, (string)contentPath);
						num3 = 3;
						continue;
					case 1:
						if (!System.IO.Directory.Exists((string)contentPath))
						{
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						break;
					}
					goto end_IL_000c;
					continue;
					end_IL_0010:
					break;
				}
				if (num2 != 991)
				{
					return;
				}
				continue;
				end_IL_000c:
				break;
			}
			System.IO.Directory.Delete((string)contentPath, true);
			num = 10;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
			{
				num = 6;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void n2KfklUZ57S(object path)
	{
		int num = 1;
		int num3 = default;
		int num5 = default;
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 0:
				return;
			}
			try
			{
				int num2;
				if (!System.IO.Directory.Exists((string)path))
				{
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
					{
						num2 = 0;
					}
					goto IL_0073;
				}
				goto IL_00bb;
				IL_0073:
				while (true)
				{
					switch (num2)
					{
					case 1:
						return;
					case 2:
						return;
					default:
						if (num3 == 990)
						{
							goto IL_006f;
						}
						return;
					case 0:
						break;
					}
					break;
					IL_006f:
					num2 = num3;
				}
				goto IL_00bb;
				IL_00bb:
				System.IO.Directory.Delete((string)path, true);
				num2 = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
				{
					num2 = 4;
				}
				goto IL_0073;
			}
			catch (global::System.Exception)
			{
				int num4 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
				{
					num4 = 4;
				}
				while (true)
				{
					switch (num4)
					{
					case 0:
						return;
					}
					if (num5 != 988)
					{
						return;
					}
					num4 = num5;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void L6efkdWs2fC(object path)
	{
		int num = 1;
		int num3 = default;
		int num5 = default;
		while (true)
		{
			switch (num)
			{
			case 989:
				break;
			case 1:
				try
				{
					if (!System.IO.File.Exists((string)path))
					{
						return;
					}
					int num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 != 0)
					{
						num2 = 5;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							if (num3 == 989)
							{
								num2 = num3;
								continue;
							}
							break;
						case 0:
							break;
						case 1:
							return;
						}
						System.IO.File.Delete((string)path);
						num2 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be != 0)
						{
							num2 = 1;
						}
					}
				}
				catch (global::System.Exception)
				{
					int num4 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
					{
						num4 = 6;
					}
					while (true)
					{
						switch (num4)
						{
						case 0:
							return;
						}
						if (num5 == 988)
						{
							num4 = num5;
							continue;
						}
						return;
					}
				}
			default:
				return;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string alLfkKuXdwj(object value)
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 991)
					{
						goto end_IL_0010;
					}
					goto case 2;
				case 3:
					_ = "资源 MD5 无效";
					throw new global::System.Exception("value");
				case 0:
					return (value).ToLowerInvariant();
				case 2:
					if ((value).Length == 32)
					{
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				case 1:
					if (lgXfktOjbk4(value))
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
						{
							num2 = 8;
						}
						break;
					}
					goto case 3;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string sgFfkHLXM8H(object value)
	{
		int num = 25;
		bool flag = default;
		string text2 = default;
		char c = default;
		string text = default;
		int num4 = default;
		bool flag2 = default;
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
						if (num2 != 35)
						{
							if (num2 == 1016)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						_ = "资源缓存路径段不能为空";
						throw new global::System.Exception("value");
					case 2:
					case 13:
						flag = true;
						num = 14;
						break;
					case 7:
						return text2;
					case 20:
						_ = "资源缓存路径段无效";
						throw new global::System.Exception("value");
					case 18:
						if (!(text2 == ".."))
						{
							num3 = 19;
							continue;
						}
						goto case 2;
					case 17:
						if ((text2 == "."))
						{
							num3 = 2;
							continue;
						}
						goto case 18;
					case 8:
					case 24:
						c = (text).Chars;
						num3 = 16;
						continue;
					case 4:
					case 9:
						flag = !flag2;
						num3 = 28;
						continue;
					case 26:
						if (c == '_')
						{
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
							{
								num3 = 5;
							}
							continue;
						}
						goto case 11;
					case 16:
						flag = !char.IsLetterOrDigit(c);
						num3 = 23;
						continue;
					case 11:
						flag2 = false;
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
						{
							num3 = 25;
						}
						continue;
					case 19:
					case 22:
						flag = false;
						num3 = 27;
						continue;
					case 25:
						if (string.IsNullOrWhiteSpace((string)value))
						{
							num = 35;
							break;
						}
						text2 = (value).Trim();
						num3 = 16;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
						{
							num3 = 10;
						}
						continue;
					case 5:
					case 6:
						if (num4 < (text).Length)
						{
							num3 = 13;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
							{
								num3 = 24;
							}
							continue;
						}
						goto case 17;
					case 1:
						if (c != '-')
						{
							num3 = 21;
							continue;
						}
						goto case 3;
					case 14:
					case 27:
						if (flag)
						{
							num3 = 20;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
							{
								num3 = 22;
							}
							continue;
						}
						goto case 7;
					case 23:
						if (flag)
						{
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto case 28;
					case 10:
						text = text2;
						num3 = 35;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
						{
							num3 = 0;
						}
						continue;
					case 12:
						_ = "资源缓存路径段包含无效字符";
						throw new global::System.Exception("value");
					case 15:
						num4++;
						num3 = 24;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 != 0)
						{
							num3 = 5;
						}
						continue;
					case 21:
						if (c != '.')
						{
							num3 = 26;
							continue;
						}
						goto case 3;
					case 0:
						num4 = 0;
						num = 6;
						break;
					case 3:
						flag2 = true;
						num3 = 9;
						continue;
					case 28:
						if (!flag)
						{
							num3 = 15;
							continue;
						}
						goto case 12;
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
	private static bool lgXfktOjbk4(object value)
	{
		int num = 3;
		int num4 = default;
		string text = default;
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
						if (num2 != 14)
						{
							if (num2 == 995)
							{
								goto end_IL_0010;
							}
							goto case 6;
						}
						goto case 0;
					case 6:
						return false;
					case 5:
						break;
					case 7:
						return true;
					case 0:
						if (num4 < (text).Length)
						{
							num3 = 1;
							continue;
						}
						goto case 7;
					case 2:
						num4 = 0;
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
						{
							num3 = 0;
						}
						continue;
					case 1:
					case 4:
						if (System.Uri.IsHexDigit((text).Chars))
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
							{
								num3 = 5;
							}
							continue;
						}
						goto case 6;
					case 3:
						text = (string)value;
						num3 = 2;
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
			num4++;
			num = 14;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
			{
				num = 12;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 4;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool LaupaXZNzaOIh17jx7Ky()
	{
		return PEblxZZNn1hhO0fAvtkM == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static MRYvDAfkhkOGvSerUTqQ WmHB2yZMb53sGQCr2w4M()
	{
		return (MRYvDAfkhkOGvSerUTqQ)PEblxZZNn1hhO0fAvtkM;
	}
}
