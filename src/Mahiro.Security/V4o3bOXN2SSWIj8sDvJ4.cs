using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;
using qcIZ8lAjAHfMaUh5fOa;

namespace tVXAUMXNqPn0U1CkK2wZ;

internal sealed class V4o3bOXN2SSWIj8sDvJ4
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_49
	{
		public static readonly __c_49 __9;

		public static Func<string, string> __9__11_0;

		public static Func<string, bool> __9__11_1;

		public static Func<string, string> __9__12_0;

		public static Func<string, bool> __9__12_1;

		internal static __c_49 OZ8VnlDfweFyV5GlmiGD;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_49()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string IBYL9I97II9(string path)
		{
			int num = 1;
			return null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool hPjL9BmpWFn(string path)
		{
			return (path).Length > 0;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string oSkL9grMUIC(string path)
		{
			int num = 2;
			return null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool f8jL9lrbr3M(string path)
		{
			return (path).Length > 0;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool SC1SFODfeE66CWj9PfHW()
		{
			return OZ8VnlDfweFyV5GlmiGD == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_49 MYXFcMDfPsZNNu0CiiFO()
		{
			return OZ8VnlDfweFyV5GlmiGD;
		}
	}

	private const string LastUsedVersionKey = "bedrock.client.lastUsedVersion";

	private const string UseCustomClientKey = "bedrock.client.useCustom";

	private const string CustomClientPathsKey = "bedrock.client.customPaths";

	private const string CustomClientSelectedKey = "bedrock.client.customSelected";

	private static object gXSoY4ZwNjYo9lnaKPsO;

	internal string? LastUsedVersion
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			string text = hJOXb0ALfS6Dke4PZFZ.iIGAZT9dtF("bedrock.client.lastUsedVersion");
			return null;
		}
		[MethodImpl((MethodImplOptions)8)]
		set
		{
			hJOXb0ALfS6Dke4PZFZ.LMvA9PbbUQ("bedrock.client.lastUsedVersion", value ?? string.Empty);
		}
	}

	internal bool UseCustomClient
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return !string.Equals(hJOXb0ALfS6Dke4PZFZ.iIGAZT9dtF("bedrock.client.useCustom", "false"), "false", (StringComparison)4);
		}
		[MethodImpl((MethodImplOptions)8)]
		set
		{
		}
	}

	internal global::System.Collections.Generic.IReadOnlyList<string> CustomClientPaths
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 2;
			string text = default(string);
			int num5 = default(int);
			global::System.Collections.Generic.IReadOnlyList<string> result = default(global::System.Collections.Generic.IReadOnlyList<string>);
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
								try
								{
									List<string> obj = JsonSerializer.Deserialize<List<string>>(text, (JsonSerializerOptions)null);
									int num4;
									if (obj == null)
									{
										num4 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
										{
											num4 = 0;
										}
										goto IL_0117;
									}
									goto IL_013c;
									IL_0117:
									while (true)
									{
										switch (num4)
										{
										default:
											if (num5 == 989)
											{
												goto IL_0113;
											}
											goto case 0;
										case 0:
											obj = new List<string>();
											break;
										case 1:
											goto end_IL_0117;
										}
										goto IL_013c;
										IL_0113:
										num4 = num5;
										continue;
										end_IL_0117:
										break;
									}
									goto end_IL_00d7;
									IL_013c:
									result = Enumerable.ToArray<string>(Enumerable.Distinct<string>(Enumerable.Where<string>(Enumerable.Select<string, string>((global::System.Collections.Generic.IEnumerable<string>)obj, (Func<string, string>)([MethodImpl((MethodImplOptions)8)] (string path) =>
									{
										int num8 = 1;
										return (string)null;
									})), (Func<string, bool>)([MethodImpl((MethodImplOptions)8)] (string path) => (path).Length > 0)), (IEqualityComparer<string>)(object)System.StringComparer.OrdinalIgnoreCase));
									num4 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
									{
										num4 = 1;
									}
									goto IL_0117;
									end_IL_00d7:;
								}
								catch (JsonException)
								{
									int num6 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
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
											result = global::System.Array.Empty<string>();
											num6 = 7;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 != 0)
											{
												num6 = 1;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
								break;
							}
							goto IL_0033;
						case 2:
							text = hJOXb0ALfS6Dke4PZFZ.iIGAZT9dtF("bedrock.client.customPaths");
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							if (string.IsNullOrWhiteSpace(text))
							{
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
								{
									num3 = 3;
								}
								continue;
							}
							goto end_IL_000c;
						case 0:
							return global::System.Array.Empty<string>();
						case 3:
							break;
						}
						goto IL_00d3;
						IL_0033:
						if (num2 == 991)
						{
							break;
						}
						goto IL_00d3;
						IL_00d3:
						return result;
					}
					continue;
					end_IL_000c:
					break;
				}
				num = 10;
			}
		}
		[MethodImpl((MethodImplOptions)8)]
		set
		{
			string[] array = Enumerable.ToArray<string>(Enumerable.Distinct<string>(Enumerable.Where<string>(Enumerable.Select<string, string>((global::System.Collections.Generic.IEnumerable<string>)global::System.Array.Empty<string>(), (Func<string, string>)([MethodImpl((MethodImplOptions)8)] (string path) =>
			{
				int num = 2;
				return (string)null;
			})), (Func<string, bool>)([MethodImpl((MethodImplOptions)8)] (string path) => (path).Length > 0)), (IEqualityComparer<string>)(object)System.StringComparer.OrdinalIgnoreCase));
		}
	}

	internal string? CustomClientPath
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			string text = hJOXb0ALfS6Dke4PZFZ.iIGAZT9dtF("bedrock.client.customSelected");
			return null;
		}
		[MethodImpl((MethodImplOptions)8)]
		set
		{
			hJOXb0ALfS6Dke4PZFZ.LMvA9PbbUQ("bedrock.client.customSelected", value ?? string.Empty);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public V4o3bOXN2SSWIj8sDvJ4()
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
	internal static bool w6WD4IZwMFmu97dip81v()
	{
		return gXSoY4ZwNjYo9lnaKPsO == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static V4o3bOXN2SSWIj8sDvJ4 yCEc8aZwpfGFQObVdg2i()
	{
		return (V4o3bOXN2SSWIj8sDvJ4)gXSoY4ZwNjYo9lnaKPsO;
	}
}
