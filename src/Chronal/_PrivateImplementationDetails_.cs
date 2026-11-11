using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using qS8vkpL43FlTMgcj0rgs;

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 5)]
	internal struct __StaticArrayInitTypeSize_5
	{
	}

	[StructLayout((LayoutKind)2, Pack = 1, Size = 6)]
	internal struct __StaticArrayInitTypeSize_6_1
	{
	}

	[StructLayout((LayoutKind)2, Pack = 1, Size = 7)]
	internal struct __StaticArrayInitTypeSize_7
	{
	}

	[StructLayout((LayoutKind)2, Pack = 1, Size = 12)]
	internal struct __StaticArrayInitTypeSize_12_1
	{
	}

	[StructLayout((LayoutKind)2, Pack = 1, Size = 14)]
	internal struct __StaticArrayInitTypeSize_14
	{
	}

	internal static readonly long _046C67DE3F102699A5CE508518E04B32DDB61B6B57CF5918E76E369CFC8095F0/* Not supported: data(0D 00 0A 00 2C 00 3B 00) */;

	internal static readonly __StaticArrayInitTypeSize_14 _3680A43D341D54FAE0940E9D32779169D1DAEB5AD54BB94987DDEB0FC7B4DDD9/* Not supported: data(0D 00 0A 00 0B 00 0C 00 85 00 28 20 29 20) */;

	internal static readonly long _4C4B6A3BE1314AB86138BEF4314DDE022E600960D8689A2C8F8631802D20DAB6/* Not supported: data(89 50 4E 47 0D 0A 1A 0A) */;

	internal static readonly __StaticArrayInitTypeSize_7 _68740DBF56A3B9E6DF2F2182A8622C5B3ACAB17762AD453231753F3F690FA181/* Not supported: data(47 49 46 38 37 61 00) */;

	internal static readonly __StaticArrayInitTypeSize_5 _77901FC7AA784FEED17C96A25828D775B223C82305414A2C9AD72A0B4418B866/* Not supported: data(4D 43 50 4B 00) */;

	internal static readonly __StaticArrayInitTypeSize_7 B3E707E1D324ECEE5097F6FE1570A6AD11EC951ED534DE9F01E1F6793E19FBB0/* Not supported: data(47 49 46 38 39 61 00) */;

	internal static readonly __StaticArrayInitTypeSize_12_1 EBB7B5196384C0F7233887CEBB155BAD86255C206EC6089AAF340E1F97BF994C/* Not supported: data(2C 00 3B 00 0D 00 0A 00 09 00 20 00) */;

	internal static readonly __StaticArrayInitTypeSize_6_1 F4FF6230DB63DF2543EC34E011459DB1650F68AF974CE8CA0F915C442634144B/* Not supported: data(09 00 0D 00 0A 00) */;

	private static _PrivateImplementationDetails_ ONRoBNLEgGC20iimdgpA;

	[MethodImpl((MethodImplOptions)8)]
	internal static uint ComputeStringHash(string s)
	{
		int num = 1;
		uint num5 = default(uint);
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
						if (num2 != 13)
						{
							if (num2 == 994)
							{
								goto end_IL_0010;
							}
							goto case 3;
						}
						num5 = 2166136261u;
						num = 4;
						break;
					case 2:
						return num5;
					case 3:
					case 5:
						if (num4 >= (s).Length)
						{
							num3 = 2;
							continue;
						}
						goto case 6;
					case 0:
						num4++;
						num3 = 3;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e8ca07a3866c4b3b9e07b1ae67715f0c == 0)
						{
							num3 = 5;
						}
						continue;
					case 6:
						num5 = (((dynamic)s).Chars ^ num5) * 16777619;
						num3 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_24238b39bba94b6aa4d3c2739f061133 != 0)
						{
							num3 = 0;
						}
						continue;
					case 1:
						if (s != null)
						{
							num = 7;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9c15dc17ae4e48a5bd629d141b0ebe29 != 0)
							{
								num = 13;
							}
							break;
						}
						goto case 2;
					case 4:
						num4 = 0;
						num3 = 13;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ee050290791c4dfbba3a13b8d87cc1bd == 0)
						{
							num3 = 3;
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool HT1dXBLElOky6liosd23()
	{
		return ONRoBNLEgGC20iimdgpA == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static _PrivateImplementationDetails_ AUuQVbLEdwlCBPOdA769()
	{
		return ONRoBNLEgGC20iimdgpA;
	}
}
