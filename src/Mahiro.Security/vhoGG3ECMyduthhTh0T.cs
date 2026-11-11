using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace KXGhCUE4q69ZwaNJlYL;

sealed class vhoGG3ECMyduthhTh0T : global::System.IDisposable
{
	private readonly object SQWEo8LXDq;

	private readonly Stack<Action> o8XEm2Wgax;

	private bool Wj5E7R5die;

	private bool dCoEAPrQym;

	internal static object YLxdqKZrKkdh4NJaKnQS;

	[MethodImpl((MethodImplOptions)8)]
	internal void bHvEh7HxcO(global::System.IDisposable resource)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0021;
				case 1:
					System.ArgumentNullException.ThrowIfNull(resource, "resource");
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
					{
						num2 = 3;
					}
					continue;
				case 0:
					break;
				case 2:
					return;
				}
				goto IL_007f;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_007f;
				IL_007f:
				kRvEUmdiaq(new Action(resource.Dispose));
				num2 = 2;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
				{
					num2 = 1;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void kRvEUmdiaq(Action rollbackAction)
	{
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		object sQWEo8LXDq = default(object);
		bool flag = default(bool);
		int num5 = default(int);
		int num7 = default(int);
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
							sQWEo8LXDq = SQWEo8LXDq;
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 != 0)
							{
								num3 = 8;
							}
							continue;
						}
						goto IL_0033;
					case 2:
						try
						{
							System.Threading.Monitor.Enter(sQWEo8LXDq, ref flag);
							int num4 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 != 11)
									{
										if (num5 == 991)
										{
											goto IL_0082;
										}
										goto case 1;
									}
									return;
								case 2:
									if (!Wj5E7R5die)
									{
										num4 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
										{
											num4 = 3;
										}
										break;
									}
									goto case 3;
								case 3:
									throw new InvalidOperationException("Java 启动事务已经提交");
								case 0:
									o8XEm2Wgax.Push(rollbackAction);
									num5 = 11;
									goto IL_0082;
								case 1:
									{
										System.ObjectDisposedException.ThrowIf(dCoEAPrQym, this);
										num4 = 2;
										break;
									}
									IL_0082:
									num4 = num5;
									break;
								}
							}
						}
						finally
						{
							if (flag)
							{
								int num6 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
								{
									num6 = 6;
								}
								while (true)
								{
									switch (num6)
									{
									default:
										if (num7 == 989)
										{
											num6 = num7;
											continue;
										}
										break;
									case 0:
										break;
									case 1:
										goto end_IL_019f;
									}
									System.Threading.Monitor.Exit(sQWEo8LXDq);
									num6 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
									{
										num6 = 1;
									}
									continue;
									end_IL_019f:
									break;
								}
							}
						}
					case 1:
						break;
					case 0:
						return;
					case 3:
						goto end_IL_000c;
					}
					goto IL_0231;
					IL_0033:
					if (num2 == 991)
					{
						break;
					}
					goto IL_0231;
					IL_0231:
					flag = false;
					num3 = 2;
				}
				continue;
				end_IL_000c:
				break;
			}
			System.ArgumentNullException.ThrowIfNull(rollbackAction, "rollbackAction");
			num = 10;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void NIhErRQJkM()
	{
		int num = 2;
		object sQWEo8LXDq = default(object);
		bool flag = default(bool);
		int num5 = default(int);
		int num7 = default(int);
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
				case 2:
					sQWEo8LXDq = SQWEo8LXDq;
					num2 = 7;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					try
					{
						System.Threading.Monitor.Enter(sQWEo8LXDq, ref flag);
						int num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num5 != 13)
								{
									if (num5 != 993)
									{
										break;
									}
									goto IL_009b;
								}
								o8XEm2Wgax.Clear();
								num3 = 2;
								continue;
							case 1:
								System.ObjectDisposedException.ThrowIf(dCoEAPrQym, this);
								num3 = 4;
								continue;
							case 0:
							case 5:
							{
								Wj5E7R5die = true;
								int num4 = 12;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
								{
									num4 = 13;
								}
								num5 = num4;
								goto IL_009b;
							}
							case 4:
								break;
							case 3:
								return;
							case 2:
								return;
								IL_009b:
								num3 = num5;
								continue;
							}
							if (!Wj5E7R5die)
							{
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
								{
									num3 = 6;
								}
								continue;
							}
							break;
						}
						return;
					}
					finally
					{
						if (flag)
						{
							int num6 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 989)
									{
										num6 = num7;
										continue;
									}
									break;
								case 0:
									break;
								case 1:
									goto end_IL_01cd;
								}
								System.Threading.Monitor.Exit(sQWEo8LXDq);
								num6 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
								{
									num6 = 1;
								}
								continue;
								end_IL_01cd:
								break;
							}
						}
					}
				case 1:
					flag = false;
					num2 = 4;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
					{
						num2 = 3;
					}
					break;
				case 0:
					return;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		int num = 7;
		Action val = default(Action);
		Action[] array2 = default(Action[]);
		int num4 = default(int);
		int num11 = default(int);
		int num13 = default(int);
		object sQWEo8LXDq = default(object);
		bool flag = default(bool);
		Action[] array = default(Action[]);
		int num7 = default(int);
		int num9 = default(int);
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
						if (num2 != 17)
						{
							if (num2 == 998)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						goto case 8;
					case 8:
						val = array2[num4];
						num3 = 4;
						break;
					case 2:
					case 10:
						if (num4 >= array2.Length)
						{
							return;
						}
						goto end_IL_000c;
					case 4:
						try
						{
							val.Invoke();
							int num10 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
							{
								num10 = 0;
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
						catch
						{
							int num12 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
							{
								num12 = 0;
							}
							while (true)
							{
								switch (num12)
								{
								default:
									if (num13 == 988)
									{
										num12 = num13;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 5;
					case 7:
						sQWEo8LXDq = SQWEo8LXDq;
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f != 0)
						{
							num3 = 6;
						}
						break;
					case 5:
						num4++;
						num3 = 10;
						break;
					case 6:
						flag = false;
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
						{
							num3 = 11;
						}
						break;
					case 0:
						array2 = array;
						num3 = 9;
						break;
					case 3:
						return;
					case 1:
						try
						{
							System.Threading.Monitor.Enter(sQWEo8LXDq, ref flag);
							int num5 = 7;
							while (true)
							{
								switch (num5)
								{
								case 6:
									return;
								default:
									if (num7 == 15)
									{
										return;
									}
									if (num7 == 995)
									{
										goto IL_01dd;
									}
									goto case 3;
								case 3:
									array = o8XEm2Wgax.ToArray();
									num5 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 != 0)
									{
										num5 = 0;
									}
									continue;
								case 0:
									o8XEm2Wgax.Clear();
									num5 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
									{
										num5 = 10;
									}
									continue;
								case 7:
									if (dCoEAPrQym)
									{
										return;
									}
									num5 = 4;
									continue;
								case 1:
								case 4:
									dCoEAPrQym = true;
									num5 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
									{
										num5 = 9;
									}
									continue;
								case 2:
									if (Wj5E7R5die)
									{
										int num6 = 15;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
										{
											num6 = 15;
										}
										num7 = num6;
										goto IL_01dd;
									}
									goto case 3;
								case 5:
									break;
									IL_01dd:
									num5 = num7;
									continue;
								}
								break;
							}
						}
						finally
						{
							if (flag)
							{
								int num8 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
								{
									num8 = 0;
								}
								while (true)
								{
									switch (num8)
									{
									default:
										if (num9 == 989)
										{
											num8 = num9;
											continue;
										}
										break;
									case 1:
										break;
									case 0:
										goto end_IL_0376;
									}
									System.Threading.Monitor.Exit(sQWEo8LXDq);
									num8 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
									{
										num8 = 6;
									}
									continue;
									end_IL_0376:
									break;
								}
							}
						}
						goto case 0;
					case 9:
						num4 = 0;
						num3 = 2;
						break;
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 17;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public vhoGG3ECMyduthhTh0T()
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
	internal static bool UKb6ZkZrHUiHwCxmJDP6()
	{
		return YLxdqKZrKkdh4NJaKnQS == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static vhoGG3ECMyduthhTh0T hpMxWsZrtnWxyBnuFcvK()
	{
		return (vhoGG3ECMyduthhTh0T)YLxdqKZrKkdh4NJaKnQS;
	}
}
