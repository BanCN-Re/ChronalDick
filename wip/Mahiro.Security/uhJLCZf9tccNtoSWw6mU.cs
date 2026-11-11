using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;

namespace SRwlNQf9OPT4S1ITMMiQ;

internal class uhJLCZf9tccNtoSWw6mU
{
	private static readonly object cfVf9wvap9j;

	internal static object IAlWBqZNhNuqIeJGXCDP;

	internal static JsonDocumentOptions Options
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			int num = 1;
			JsonDocumentOptions result = default(JsonDocumentOptions);
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
									goto end_IL_0010;
								}
								goto case 0;
							}
							(result).AllowTrailingCommas = true;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
							break;
						case 0:
							(result).CommentHandling = (JsonCommentHandling)1;
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
							{
								num3 = 2;
							}
							continue;
						case 2:
							return result;
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
				result = (JsonDocumentOptions)default(TaskCompletionSource<>);
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
				{
					num = 2;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static ReadOnlyMemory<byte> QdMf95RGUGc(ReadOnlyMemory<byte> bytes)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		return default(ReadOnlyMemory<byte>);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static string BdTf96BUDHq(object path)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Ref
		object obj = cfVf9wvap9j;
		ReadOnlyMemory<byte> val = QdMf95RGUGc((ReadOnlyMemory<byte>)System.IO.File.ReadAllBytes((string)path));
		return (obj).GetString((global::System.ReadOnlySpan<byte>)(&val));
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static JsonDocument ugxf9RsOEV8(object path)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		return System.Text.Json.JsonDocument.Parse(QdMf95RGUGc((ReadOnlyMemory<byte>)System.IO.File.ReadAllBytes((string)path)), Options);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 2;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool mkLg7HZNUCU0OYxWtIsN()
	{
		return IAlWBqZNhNuqIeJGXCDP == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static uhJLCZf9tccNtoSWw6mU wxdQLvZNr4hpJwPZmZVX()
	{
		return (uhJLCZf9tccNtoSWw6mU)IAlWBqZNhNuqIeJGXCDP;
	}
}
