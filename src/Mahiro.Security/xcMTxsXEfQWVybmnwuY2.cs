using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using OWRumnXNe7U48tXBXFAY;
using fDAldojjppXrctUVYOJn;
using fL58ItfV1kVf9frJWuxF;
using rsytthXEHIfiBvx9aN2i;

namespace Tlp4VjXELOtTm46Je6at;

internal sealed class xcMTxsXEfQWVybmnwuY2
{
	private readonly Dictionary<string, byte[]?> rGDXEkcdyph;

	private readonly Dictionary<string, byte[]> AHXXEV2mMf7;

	internal static object b3xMcFZxZaP4l6he2BqA;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task<xcMTxsXEfQWVybmnwuY2> f65XEjG74EW(object source, object overlay, IuFb5gfVakTHm3qModnF? resources, global::System.Collections.Generic.IReadOnlyList<string> itemIds, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_CreateAsync_d__3 createAsync_d__ = default(_CreateAsync_d__3);
		createAsync_d__.__t__builder = AsyncTaskMethodBuilder<xcMTxsXEfQWVybmnwuY2>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void KLsXEZnsn7F(string source)
	{
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		global::System.Collections.Generic.Dictionary<string, byte[]>.Enumerator enumerator = default(global::System.Collections.Generic.Dictionary<string, byte[]>.Enumerator);
		int num4 = default(int);
		KeyValuePair<string, byte[]> current = default(KeyValuePair<string, byte[]>);
		string text = default(string);
		int num7 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0021;
				case 0:
					return;
				case 1:
					try
					{
						while (true)
						{
							IL_0183:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 4;
								goto IL_0064;
							}
							goto IL_0199;
							IL_0064:
							num4 = num3;
							goto IL_0068;
							IL_0199:
							current = enumerator.Current;
							int num5 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
							{
								num5 = 14;
							}
							goto IL_006c;
							IL_0068:
							num5 = num4;
							goto IL_006c;
							IL_006c:
							while (true)
							{
								switch (num5)
								{
								case 4:
									return;
								case 7:
									goto IL_00e8;
								case 5:
									goto end_IL_006c;
								case 3:
									text = System.IO.Path.Combine(source, current.Key);
									num5 = 2;
									continue;
								case 0:
									goto IL_0162;
								case 1:
									goto IL_0199;
								case 2:
									KxxYYwXNwodeMw0HASFS.q42XNxRA7U5(text);
									num5 = 6;
									continue;
								case 6:
									goto IL_01d2;
								}
								if (num4 != 15)
								{
									if (num4 == 995)
									{
										goto IL_0068;
									}
									goto IL_01d2;
								}
								if ((System.IO.File.GetAttributes(text) & (FileAttributes)(0x400)) == 0)
								{
									num5 = 13;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
									{
										num5 = 7;
									}
									continue;
								}
								goto IL_0162;
								IL_00e8:
								if (!MemoryExtensions.SequenceEqual<byte>(MemoryExtensions.AsSpan<byte>(System.IO.File.ReadAllBytes(text)), current.Value))
								{
									num5 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
									{
										num5 = 13;
									}
									continue;
								}
								goto IL_0183;
								IL_01d2:
								if (System.IO.File.Exists(text) == (current.Value != null))
								{
									num5 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
									{
										num5 = 13;
									}
									continue;
								}
								goto IL_0162;
								IL_0162:
								throw new IOException("资源包在解密准备期间发生变化，已停止覆盖");
								continue;
								end_IL_006c:
								break;
							}
							if (current.Value == null)
							{
								continue;
							}
							num3 = 15;
							goto IL_0064;
						}
					}
					finally
					{
						((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						int num6 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
						{
							num6 = 2;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 == 988)
								{
									num6 = num7;
									continue;
								}
								break;
							case 0:
								break;
							}
							break;
						}
					}
				case 2:
					break;
				}
				goto IL_028e;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_028e;
				IL_028e:
				enumerator = rGDXEkcdyph.GetEnumerator();
				num2 = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
				{
					num2 = 5;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void wk5XE9icI5I(string source)
	{
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		global::System.Collections.Generic.Dictionary<string, byte[]>.Enumerator enumerator = default(global::System.Collections.Generic.Dictionary<string, byte[]>.Enumerator);
		int num4 = default(int);
		string text2 = default(string);
		KeyValuePair<string, byte[]> current = default(KeyValuePair<string, byte[]>);
		int num6 = default(int);
		string text = default(string);
		int num8 = default(int);
		int num11 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 990)
					{
						goto end_IL_0010;
					}
					goto case 1;
				case 1:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 5;
								goto IL_006b;
							}
							goto IL_026b;
							IL_006b:
							while (true)
							{
								switch (num3)
								{
								default:
									if (num4 != 13)
									{
										if (num4 == 993)
										{
											goto IL_0067;
										}
										goto IL_026b;
									}
									try
									{
										System.IO.File.WriteAllBytes(text2, current.Value);
										int num5 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
										{
											num5 = 0;
										}
										while (true)
										{
											switch (num5)
											{
											default:
												if (num6 == 989)
												{
													num5 = num6;
													continue;
												}
												break;
											case 0:
												System.IO.File.Move(text2, text, true);
												num5 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
												{
													num5 = 6;
												}
												continue;
											case 1:
												break;
											}
											break;
										}
									}
									finally
									{
										mwnlp4XEK0k3Dijk379u.TryDeleteFile(text2);
										int num7 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
										{
											num7 = 0;
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
								case 0:
								{
									string text3 = text;
									string text4 = ".";
									Guid val = System.Guid.NewGuid();
									text2 = string.Concat(text3, text4, (val).ToString("N"), ".merging");
									int num9 = 13;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
									{
										num9 = 2;
									}
									num4 = num9;
									goto IL_0067;
								}
								case 1:
									text = System.IO.Path.Combine(source, current.Key);
									num3 = 4;
									continue;
								case 2:
									break;
								case 3:
									goto IL_026b;
								case 4:
									System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(text));
									num3 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
									{
										num3 = 2;
									}
									continue;
								case 5:
									return;
									IL_0067:
									num3 = num4;
									continue;
								}
								break;
							}
							continue;
							IL_026b:
							current = enumerator.Current;
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
							{
								num3 = 8;
							}
							goto IL_006b;
						}
					}
					finally
					{
						((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						int num10 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
						{
							num10 = 4;
						}
						while (true)
						{
							switch (num10)
							{
							default:
								if (num11 == 988)
								{
									num10 = num11;
									continue;
								}
								break;
							case 0:
								break;
							}
							break;
						}
					}
				case 0:
					return;
				case 2:
					enumerator = AHXXEV2mMf7.GetEnumerator();
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
					{
						num2 = 4;
					}
					break;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public xcMTxsXEfQWVybmnwuY2()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool HbVHG7Zx9U1M9Cx4RcND()
	{
		return b3xMcFZxZaP4l6he2BqA == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static xcMTxsXEfQWVybmnwuY2 XDsh1IZxDa8ka8ubBs35()
	{
		return (xcMTxsXEfQWVybmnwuY2)b3xMcFZxZaP4l6he2BqA;
	}
}
