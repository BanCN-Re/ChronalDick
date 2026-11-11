using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using NvRlwKfe2JWUcjSpjE3F;
using Tw9bY8feF6dPFc3Fd2aj;
using fDAldojjppXrctUVYOJn;
using l6cmMNfev8gk0sJeqkK4;
using tFQFT3fe188uQQ89O0Xw;

namespace Em73oofeuZ8cicBolFHh;

public sealed class bt5vf8fepM1aCnrtDLQ1
{
	internal static object QQauev9LyuoseJhfCcpB;

	[JsonPropertyName("fingerprint")]
	[field: CompilerGenerated]
	public string Fingerprint
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("expiresAt")]
	[field: CompilerGenerated]
	public DateTimeOffset ExpiresAt
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("summary")]
	[field: CompilerGenerated]
	public WnMuNkfe3VpOTUSWifYh Summary
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("amountCents")]
	[field: CompilerGenerated]
	public long AmountCents
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("requiresReview")]
	[field: CompilerGenerated]
	public bool RequiresReview
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("reviewReasons")]
	[field: CompilerGenerated]
	public List<string> ReviewReasons
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("notices")]
	[field: CompilerGenerated]
	public List<string> Notices
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("actions")]
	[field: CompilerGenerated]
	public List<URB8B2feEZ4MEmZHHlr7> Actions
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("relatedAssetCount")]
	[field: CompilerGenerated]
	public int RelatedAssetCount
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("exceptions")]
	[field: CompilerGenerated]
	public List<IVpYPtfeavX1tOl13yEw> Exceptions
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	public string DisplayText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0402: Unknown result type (might be due to invalid IL or missing references)
			int num = 15;
			List<string> val = default(List<string>);
			global::System.Collections.Generic.IEnumerator<IVpYPtfeavX1tOl13yEw> enumerator = default(global::System.Collections.Generic.IEnumerator<IVpYPtfeavX1tOl13yEw>);
			int num6 = default(int);
			IVpYPtfeavX1tOl13yEw current = default(IVpYPtfeavX1tOl13yEw);
			int num9 = default(int);
			int num4 = default(int);
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
							if (num2 != 22)
							{
								if (num2 == 1003)
								{
									goto end_IL_0010;
								}
								goto case 0;
							}
							goto IL_03e4;
						case 13:
						{
							List<string> obj2 = val;
							global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(35, 1);
							(defaultInterpolatedStringHandler3).AppendLiteral("另涉及 ");
							defaultInterpolatedStringHandler3.AppendFormatted<int>(RelatedAssetCount);
							(defaultInterpolatedStringHandler3).AppendLiteral(" 项其他用户关联资产，将按来源追回；不展示他人身份和逐项资产。");
							obj2.Add((defaultInterpolatedStringHandler3).ToStringAndClear());
							num = 21;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
							{
								num = 22;
							}
							break;
						}
						case 3:
							try
							{
								while (true)
								{
									IL_0167:
									if (!enumerator.MoveNext())
									{
										int num5 = 10;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
										{
											num5 = 6;
										}
										num6 = num5;
										goto IL_0131;
									}
									goto IL_0192;
									IL_0192:
									current = enumerator.Current;
									int num7 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
									{
										num7 = 0;
									}
									goto IL_0135;
									IL_0135:
									while (true)
									{
										switch (num7)
										{
										case 1:
											goto IL_0167;
										case 2:
											goto IL_0192;
										case 0:
											val.Add(string.Concat(current.Message, (current.ValueCents > 0) ? string.Concat(" · 关联金额 ", inelCefex8fdCPrlACDh.gujfeTO17YJ(current.ValueCents)) : string.Empty, default));
											num7 = 5;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
											{
												num7 = 1;
											}
											continue;
										}
										break;
									}
									if (num6 != 10)
									{
										if (num6 == 990)
										{
											goto IL_0131;
										}
										goto IL_0192;
									}
									break;
									IL_0131:
									num7 = num6;
									goto IL_0135;
								}
							}
							finally
							{
								((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
								int num8 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
								{
									num8 = 2;
								}
								while (true)
								{
									switch (num8)
									{
									default:
										if (num9 == 988)
										{
											num8 = num9;
											continue;
										}
										break;
									case 0:
										break;
									}
									break;
								}
							}
							goto case 9;
						case 8:
							return string.Join(string.Concat(System.Environment.NewLine, System.Environment.NewLine), (global::System.Collections.Generic.IEnumerable<string>)val);
						case 1:
							num4 = 0;
							num3 = 7;
							continue;
						case 0:
							enumerator = Exceptions.GetEnumerator();
							num = 3;
							break;
						case 6:
							val.Add("暂无可自动处理的本人资产项目。");
							num3 = 11;
							continue;
						case 4:
						{
							List<string> obj3 = val;
							global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(2, 2);
							defaultInterpolatedStringHandler4.AppendFormatted<int>(num4 + 1);
							(defaultInterpolatedStringHandler4).AppendLiteral(". ");
							(defaultInterpolatedStringHandler4).AppendFormatted(Actions[num4].DisplayText);
							obj3.Add((defaultInterpolatedStringHandler4).ToStringAndClear());
							num3 = 5;
							continue;
						}
						case 11:
							if (RelatedAssetCount > 0)
							{
								num3 = 13;
								continue;
							}
							goto IL_03e4;
						case 10:
							if (Actions.Count == 0)
							{
								num3 = 14;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
								{
									num3 = 6;
								}
								continue;
							}
							goto case 11;
						case 2:
							val.AddRange((global::System.Collections.Generic.IEnumerable<string>)Notices);
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
							{
								num3 = 8;
							}
							continue;
						case 14:
							val.AddRange((global::System.Collections.Generic.IEnumerable<string>)ReviewReasons);
							num = 2;
							break;
						case 9:
						{
							List<string> obj4 = val;
							global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler5 = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(14, 1);
							(defaultInterpolatedStringHandler5).AppendLiteral("本人资产清单（全部 ");
							defaultInterpolatedStringHandler5.AppendFormatted<int>(Actions.Count);
							(defaultInterpolatedStringHandler5).AppendLiteral(" 项）：");
							obj4.Add((defaultInterpolatedStringHandler5).ToStringAndClear());
							num3 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
							{
								num3 = 1;
							}
							continue;
						}
						case 7:
						case 12:
							if (num4 >= Actions.Count)
							{
								num3 = 10;
								continue;
							}
							goto case 4;
						case 5:
							num4++;
							num3 = 12;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
							{
								num3 = 17;
							}
							continue;
						case 15:
							{
								List<string> obj = new List<string>();
								obj.Add(string.Concat("退款金额：", inelCefex8fdCPrlACDh.gujfeTO17YJ(AmountCents)));
								global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(12, 3);
								(defaultInterpolatedStringHandler).AppendLiteral("实际支付：");
								(defaultInterpolatedStringHandler).AppendFormatted(inelCefex8fdCPrlACDh.gujfeTO17YJ(Summary.PaidCents));
								(defaultInterpolatedStringHandler).AppendLiteral("；手续费：");
								(defaultInterpolatedStringHandler).AppendFormatted(inelCefex8fdCPrlACDh.gujfeTO17YJ(Summary.FeeCents));
								(defaultInterpolatedStringHandler).AppendLiteral("（");
								(defaultInterpolatedStringHandler).AppendFormatted(Summary.RefundIncludesFee ? "随整单退回" : "不退");
								(defaultInterpolatedStringHandler).AppendLiteral("）");
								obj.Add((defaultInterpolatedStringHandler).ToStringAndClear());
								obj.Add(string.Concat("历史已退：", inelCefex8fdCPrlACDh.gujfeTO17YJ(Summary.RefundedCents), "；剩余可退：", inelCefex8fdCPrlACDh.gujfeTO17YJ(Summary.RemainingCents)));
								string text;
								if (Summary.WindowMinutes <= 0)
								{
									text = "自助退款时限：不限";
								}
								else
								{
									global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(20, 2);
									(defaultInterpolatedStringHandler2).AppendLiteral("自助退款时限：支付成功后 ");
									defaultInterpolatedStringHandler2.AppendFormatted<int>(Summary.WindowMinutes);
									(defaultInterpolatedStringHandler2).AppendLiteral(" 分钟，截止 ");
									(defaultInterpolatedStringHandler2).AppendFormatted(inelCefex8fdCPrlACDh.XYafeNONrXt(Summary.Deadline));
									text = (defaultInterpolatedStringHandler2).ToStringAndClear();
								}
								obj.Add(text);
								obj.Add(RequiresReview ? "本申请需要管理员审核，提交申请不会立即扣除资产或退款。" : "时限内可自助退款，确认后退回本金并追回来源余额和关联商品剩余权益。");
								val = obj;
								num3 = 14;
								continue;
							}
							IL_03e4:
							val.Add(string.Concat("清单有效至：", inelCefex8fdCPrlACDh.XYafeNONrXt(ExpiresAt), "。提交时重新校验；预览不代表已经扣除。"));
							num3 = 8;
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
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public bt5vf8fepM1aCnrtDLQ1()
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
	internal static bool cjCuk19LWIDjfIywncSP()
	{
		return QQauev9LyuoseJhfCcpB == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bt5vf8fepM1aCnrtDLQ1 AKIcWn9LJksTy3dWCNTV()
	{
		return (bt5vf8fepM1aCnrtDLQ1)QQauev9LyuoseJhfCcpB;
	}
}
