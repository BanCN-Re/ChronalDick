using System;
using System.IO;
using System.Runtime.CompilerServices;
using BCXoLCXUvJyBkqc6IRk2;
using C0RPrLXrEwgooXWbyseV;
using CZUx5njfSrbl1tnMcUCO;
using CunBSaXrO51xPU1EwI3x;
using FGMHGZXrw9UNdK5BkCsX;
using K48WkOXrQUD3xl2yuwa3;
using NMihKtM0aphdgKJa8fc;
using P29MXcXrsa5WI0iVIqAJ;
using UchfG8fTzhAHMiok6Yk0;
using WFnhKyXrlFylPfUY2cRp;
using WO2MwvfTPtUmg3Jb5HFo;
using YphbcNXr3MAYpcL0ofID;
using bwGbOeXrn2An6WX4qGu4;
using fDAldojjppXrctUVYOJn;
using gH3ROWfPu8UsnENpjoGo;
using j0UF4QfN832bb9GMrcTe;
using kDnqtyfNVLomBXTPNmyi;
using ufKW2gfNWtEx5Kth7h2G;

namespace KCUB02Xobpko7G6QhyjY;

internal sealed class v2wCmOXrzswbLaNh7J2E
{
	private readonly object jZ1XoVlEqnC;

	private readonly object StLXoY6kFyB;

	private readonly object dLVXoSKOuIo;

	private readonly object dDfXocFrSSb;

	private bool OmvXo0DGfW1;

	private bool KF3Xo8LH8gE;

	private bool qeiXoyJHG40;

	[CompilerGenerated]
	private zNm36IfN0r4HRnMd2R6W sYJXoWN1WTE;

	private static object K3gwbRZHemJdxcihdaIp;

	internal zNm36IfN0r4HRnMd2R6W State
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return sYJXoWN1WTE;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
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
					if (num == 989)
					{
						break;
					}
					goto IL_0030;
					IL_0030:
					sYJXoWN1WTE = value;
					num2 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
					{
						num2 = 0;
					}
				}
			}
		}
	}

	internal int ProtocolVersion
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return ((OQ423AXrRrW6R3jJZBHr)dDfXocFrSSb).ProtocolVersion;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal v2wCmOXrzswbLaNh7J2E(KKxWUefNkXpsd6v6SISa options, tevrq6fTnmxdv0004lXm localEndpoint)
	{
		dDfXocFrSSb = WWWgjNXrFGLglhTOAh4O.cVtXrTW5VP1(options.ProtocolVersion);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal kkvRUaXrvh8R9Ql3Qx9T DRGXoX7TZbp(UQksENfNyB5duJtOvWxq direction, qAftL0XU3M5I1RIneNTc packet)
	{
		int num = 2;
		object obj = default(object);
		bool flag = default(bool);
		int num5 = default(int);
		zNm36IfN0r4HRnMd2R6W state = default(zNm36IfN0r4HRnMd2R6W);
		kkvRUaXrvh8R9Ql3Qx9T kkvRUaXrvh8R9Ql3Qx9T = default(kkvRUaXrvh8R9Ql3Qx9T);
		kkvRUaXrvh8R9Ql3Qx9T result = default(kkvRUaXrvh8R9Ql3Qx9T);
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
				case 3:
					try
					{
						System.Threading.Monitor.Enter(obj, ref flag);
						int num3 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
						{
							num3 = 4;
						}
						while (true)
						{
							int num4;
							switch (num3)
							{
							default:
								if (num5 != 20)
								{
									if (num5 == 1000)
									{
										goto IL_0074;
									}
									goto IL_0178;
								}
								switch (state)
								{
								case zNm36IfN0r4HRnMd2R6W.Login:
									break;
								case zNm36IfN0r4HRnMd2R6W.Configuration:
									goto IL_010d;
								case zNm36IfN0r4HRnMd2R6W.Status:
									goto IL_0178;
								case zNm36IfN0r4HRnMd2R6W.Handshake:
									goto IL_018a;
								case zNm36IfN0r4HRnMd2R6W.Play:
									goto IL_01c2;
								default:
									goto IL_0223;
								}
								goto case 3;
							case 11:
								state = State;
								num4 = 20;
								goto IL_0070;
							case 3:
								kkvRUaXrvh8R9Ql3Qx9T = NyTXojWaCWl(direction, packet);
								num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
								{
									num3 = 3;
								}
								continue;
							case 12:
								goto IL_010d;
							case 2:
							case 10:
								goto IL_0178;
							case 4:
								goto IL_018a;
							case 6:
								goto IL_01c2;
							case 0:
							case 1:
							case 5:
							case 8:
							case 9:
								result = kkvRUaXrvh8R9Ql3Qx9T;
								num4 = 7;
								goto IL_0070;
							case 7:
								break;
								IL_010d:
								kkvRUaXrvh8R9Ql3Qx9T = EE1XoZP3bSX(direction, packet);
								num4 = 5;
								goto IL_0070;
								IL_0070:
								num5 = num4;
								goto IL_0074;
								IL_0223:
								num3 = 18;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
								{
									num3 = 10;
								}
								continue;
								IL_0074:
								num3 = num5;
								continue;
								IL_01c2:
								kkvRUaXrvh8R9Ql3Qx9T = KQSXo99m81E(direction, packet);
								num3 = 9;
								continue;
								IL_018a:
								kkvRUaXrvh8R9Ql3Qx9T = HhcXoL31VTo(direction, packet);
								num3 = 10;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
								{
									num3 = 0;
								}
								continue;
								IL_0178:
								kkvRUaXrvh8R9Ql3Qx9T = StUXoDk6uVr(packet);
								num3 = 8;
								continue;
							}
							break;
						}
					}
					finally
					{
						if (flag)
						{
							int num6 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
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
								case 1:
									System.Threading.Monitor.Exit(obj);
									num6 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
									{
										num6 = 7;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					break;
				case 2:
					obj = jZ1XoVlEqnC;
					num2 = 6;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					flag = false;
					num2 = 3;
					continue;
				case 0:
					break;
				}
				return result;
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void rtCXofutEiq()
	{
		int num = 1;
		do
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					State = zNm36IfN0r4HRnMd2R6W.Closed;
					num2 = 5;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					return;
				}
				break;
			}
		}
		while (num == 989);
	}

	[MethodImpl((MethodImplOptions)8)]
	private kkvRUaXrvh8R9Ql3Qx9T HhcXoL31VTo(UQksENfNyB5duJtOvWxq direction, qAftL0XU3M5I1RIneNTc packet)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private kkvRUaXrvh8R9Ql3Qx9T NyTXojWaCWl(UQksENfNyB5duJtOvWxq direction, qAftL0XU3M5I1RIneNTc packet)
	{
		KF3Xo8LH8gE = true;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private kkvRUaXrvh8R9Ql3Qx9T EE1XoZP3bSX(UQksENfNyB5duJtOvWxq direction, qAftL0XU3M5I1RIneNTc packet)
	{
		qeiXoyJHG40 = true;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private kkvRUaXrvh8R9Ql3Qx9T KQSXo99m81E(UQksENfNyB5duJtOvWxq direction, qAftL0XU3M5I1RIneNTc packet)
	{
		State = zNm36IfN0r4HRnMd2R6W.Transfer;
		_ = 9;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604;
		_ = 15;
		_ = 1;
		_ = 2;
		int? num = default(int?);
		_ = num;
		_ = 13;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade;
		_ = 3;
		int? num2 = default(int?);
		_ = num2;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static kkvRUaXrvh8R9Ql3Qx9T StUXoDk6uVr(object packet)
	{
		int num = 1;
		z2ypj2XrgrQmJkmrSi5Q message = default(z2ypj2XrgrQmJkmrSi5Q);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_001d;
				case 1:
					SMOWgEXrthGGOPQM3UqG.SBUXr5HDKj5(packet, out message);
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce != 0)
					{
						num2 = 1;
					}
					continue;
				case 0:
					break;
				}
				goto IL_0058;
				IL_001d:
				if (num == 989)
				{
					break;
				}
				goto IL_0058;
				IL_0058:
				return (kkvRUaXrvh8R9Ql3Qx9T)new kkvRUaXrvh8R9Ql3Qx9T((qAftL0XU3M5I1RIneNTc)packet, D7IHSrXr1huMOH1PUcFA.None, -1, (tevrq6fTnmxdv0004lXm?)null, message, SuppressForward: false, UCfDV7XrihrRu9r5WVQZ.Unknown, LoginSucceeded: false);
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private string obQXokunUFg(int protocol, string submittedHost)
	{
		int num = 12;
		string text2 = default(string);
		string text = default(string);
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
						if (num2 != 26)
						{
							if (num2 == 1007)
							{
								goto end_IL_0010;
							}
							goto case 7;
						}
						goto case 4;
					case 4:
					case 10:
					case 13:
						text2 = text;
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
						{
							num3 = 26;
						}
						continue;
					case 5:
						if (num4 < 0)
						{
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
							{
								num3 = 15;
							}
							continue;
						}
						goto case 3;
					case 7:
					case 9:
						text = "\u0000FML2\u0000";
						num3 = 10;
						continue;
					case 3:
						return string.Concat(((KKxWUefNkXpsd6v6SISa)StLXoY6kFyB).RemoteEndpoint.Host, (submittedHost).Substring(num4));
					case 2:
						return ((KKxWUefNkXpsd6v6SISa)StLXoY6kFyB).RemoteEndpoint.Host;
					case 11:
						num4 = (submittedHost).IndexOf('\0');
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
						{
							num3 = 25;
						}
						continue;
					case 12:
						if (((KKxWUefNkXpsd6v6SISa)StLXoY6kFyB).ClientBehavior != J8XESIfTeIfybaQgfekh.OfficialTransparent)
						{
							if (((KKxWUefNkXpsd6v6SISa)StLXoY6kFyB).AppendForgeHandshakeMarker)
							{
								num3 = 14;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
								{
									num3 = 16;
								}
								continue;
							}
							goto case 6;
						}
						num3 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
						{
							num3 = 24;
						}
						continue;
					case 0:
					case 8:
						text = "\u0000FORGE";
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
						{
							num3 = 4;
						}
						continue;
					case 1:
						return string.Concat(((KKxWUefNkXpsd6v6SISa)StLXoY6kFyB).RemoteEndpoint.Host, text2);
					case 16:
						if (protocol <= 766)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de != 0)
							{
								num3 = 17;
							}
							continue;
						}
						goto case 0;
					case 18:
						if (protocol > 340)
						{
							num = 7;
							break;
						}
						goto case 19;
					case 15:
					case 17:
						text = "\u0000FML3\u0000";
						num = 26;
						break;
					case 6:
						return ((KKxWUefNkXpsd6v6SISa)StLXoY6kFyB).RemoteEndpoint.Host;
					case 14:
						if (protocol > 757)
						{
							num3 = 16;
							continue;
						}
						goto case 18;
					case 19:
						text = "\u0000FML\u0000";
						num3 = 13;
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
					case 0:
						goto end_IL_000e;
					case 2:
						return;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 != 0)
						{
							num3 = 9;
						}
						continue;
					}
					switch (num2)
					{
					case 990:
						break;
					default:
						return;
					case 9:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
						{
							num3 = 3;
						}
						continue;
					}
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			num = 9;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool O6tbuCZHP2eLEmTHev9J()
	{
		return K3gwbRZHemJdxcihdaIp == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static v2wCmOXrzswbLaNh7J2E U0JamRZHxYi24H3yBxmF()
	{
		return (v2wCmOXrzswbLaNh7J2E)K3gwbRZHemJdxcihdaIp;
	}
}
