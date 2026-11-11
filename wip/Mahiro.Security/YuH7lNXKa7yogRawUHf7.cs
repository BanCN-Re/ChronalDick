using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;
using r7Ie1ifM7owYurGstPtD;

namespace uGYGhCXK1nRsID9XQ5mf;

internal class YuH7lNXKa7yogRawUHf7
{
	private static object QZ40d7Z5ZkqF1J09XgAK;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task<bool> O1UXK3LxA3l(object filePath, object package, CancellationToken cancellationToken)
	{
		_MatchesAsync_d__1 matchesAsync_d__ = default(_MatchesAsync_d__1);
		matchesAsync_d__.package = (uY2l6VfMmfM34jZlW4GQ)package;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string tDnXKvJoEDy(object checksum)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static HashAlgorithm ShVXKEyW3la(object algorithm)
	{
		int num = 6;
		HashAlgorithm result = default(HashAlgorithm);
		string text = default(string);
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
							goto case 0;
						}
						goto case 2;
					case 3:
					case 8:
						throw string.Concat("不支持的客户端校验算法：", (string)algorithm);
					case 2:
						return result;
					case 0:
					case 1:
						result = (HashAlgorithm)(object)System.Security.Cryptography.MD5.Create();
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
						{
							num3 = 14;
						}
						continue;
					case 4:
						if ((text == "SHA256"))
						{
							num3 = 9;
							continue;
						}
						goto case 10;
					case 10:
						if (!(text == "SHA-256"))
						{
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
							{
								num3 = 7;
							}
							continue;
						}
						break;
					case 5:
						if ((text == "MD5"))
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto case 4;
					case 6:
						text = ((algorithm).Trim()).ToUpperInvariant();
						num3 = 5;
						continue;
					case 7:
					case 9:
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
			result = (HashAlgorithm)(object)System.Security.Cryptography.SHA256.Create();
			num = 17;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
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
						if (num2 == 9)
						{
							return;
						}
						goto IL_0031;
					case 0:
						goto end_IL_000e;
					case 2:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
						{
							num3 = 1;
						}
						continue;
					case 1:
						break;
					}
					goto IL_0078;
					IL_0031:
					if (num2 == 990)
					{
						break;
					}
					goto IL_0078;
					IL_0078:
					num3 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
					{
						num3 = 2;
					}
				}
				continue;
				end_IL_000e:
				break;
			}
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 9;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool eeihTmZ59m7fnGYV3R9L()
	{
		return QZ40d7Z5ZkqF1J09XgAK == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static YuH7lNXKa7yogRawUHf7 HrEAXgZ5DICpYJlUPwGc()
	{
		return (YuH7lNXKa7yogRawUHf7)QZ40d7Z5ZkqF1J09XgAK;
	}
}
