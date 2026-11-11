using System;
using System.IO;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;
using fDAldojjppXrctUVYOJn;

namespace NTFE7yf9B5U1ZOAqSfhj;

internal class GxI494f9IymiuqWAmEOR
{
	private static object OoYLpuZNQrOvRbk9dsdG;

	[MethodImpl((MethodImplOptions)8)]
	internal static bool y4tf9ggdufd(object path)
	{
		string text = (System.IO.Path.GetExtension((string)path)).ToLowerInvariant();
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool JGFf9ligvta(ReadOnlyMemory<byte> bytes)
	{
		int num = 1;
		string text = default(string);
		char c = default(char);
		bool result = default(bool);
		bool flag = default(bool);
		int num5 = default(int);
		uint num8 = default(uint);
		ImageInfo val = default(ImageInfo);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj4);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num9);
		global::System.Exception ex = default(global::System.Exception);
		int num10 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num12 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 0:
				break;
			default:
				try
				{
					global::System.ReadOnlySpan<byte> span = bytes.Span;
					int num2 = 6;
					while (true)
					{
						IL_0051:
						int num3 = num2;
						while (true)
						{
							IL_0055:
							int num4 = num3;
							while (true)
							{
								int num7;
								int num6;
								object obj;
								switch (num4)
								{
								default:
									if (num3 != 76)
									{
										if (num3 == 1056)
										{
											goto IL_0055;
										}
										goto case 1;
									}
									goto IL_04ab;
								case 49:
									if ((text == "WEBP"))
									{
										num4 = 58;
										continue;
									}
									goto IL_04ab;
								case 67:
									switch (c)
									{
									case 'M':
										goto IL_0273;
									case 'N':
										goto IL_043c;
									case 'H':
									case 'J':
									case 'K':
									case 'L':
										goto IL_04ab;
									case 'I':
										goto IL_0677;
									case 'O':
										goto IL_070e;
									case 'G':
										goto IL_08d4;
									}
									num2 = 44;
									break;
								case 1:
								case 4:
								case 5:
								case 13:
								case 19:
								case 24:
								case 31:
								case 33:
								case 50:
									result = flag;
									num4 = 20;
									continue;
								case 30:
								case 56:
									flag = MemoryExtensions.LastIndexOf<byte>(span, (byte)59) >= 13;
									num4 = 5;
									continue;
								case 11:
									goto IL_0273;
								case 66:
									num5 = (text).Length;
									num4 = 25;
									continue;
								case 53:
									if (num8 <= span.Length)
									{
										num4 = 68;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
										{
											num4 = 24;
										}
										continue;
									}
									goto case 17;
								case 68:
									num7 = ((System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(span.Slice(10)) < num8) ? 1 : 0);
									goto IL_0a6c;
								case 34:
									flag = true;
									num4 = 71;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
									{
										num4 = 50;
									}
									continue;
								case 39:
									if (!(text == "PBM"))
									{
										num4 = 46;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
										{
											num4 = 22;
										}
										continue;
									}
									goto case 34;
								case 55:
									c = ((dynamic)(text)).Chars;
									num4 = 62;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
									{
										num4 = 63;
									}
									continue;
								case 23:
									goto IL_043c;
								case 7:
								case 12:
								case 15:
								case 21:
								case 22:
								case 26:
								case 27:
								case 29:
								case 41:
								case 44:
								case 61:
								case 65:
									goto IL_04ab;
								case 2:
									if (c != 'B')
									{
										num4 = 61;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
										{
											num4 = 67;
										}
										continue;
									}
									goto case 39;
								case 64:
									if (c != 'W')
									{
										num4 = 7;
										continue;
									}
									goto case 49;
								case 16:
									if (num8 >= 26)
									{
										num4 = 53;
										continue;
									}
									goto case 17;
								case 43:
									if (!(text == "TIFF"))
									{
										num4 = 29;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
										{
											num4 = 27;
										}
										continue;
									}
									goto case 34;
								case 14:
								case 38:
									flag = MemoryExtensions.LastIndexOf<byte>(span, (global::System.ReadOnlySpan<byte>)new byte[2] { 255, 217 }) >= 2;
									num4 = 42;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
									{
										num4 = 4;
									}
									continue;
								case 6:
									val = SixLabors.ImageSharp.Image.Identify(span);
									num4 = 47;
									continue;
								case 9:
									if (!(text == "JPEG"))
									{
										goto IL_04ab;
									}
									num2 = 14;
									break;
								case 62:
									num8 = System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(span.Slice(2));
									num4 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
									{
										num4 = 16;
									}
									continue;
								case 28:
									goto IL_0677;
								case 63:
									if (c != 'J')
									{
										num4 = 40;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
										{
											num4 = 21;
										}
										continue;
									}
									goto case 9;
								case 57:
									goto IL_070e;
								case 18:
									flag = xPYf9dA3EKm(span);
									num4 = 31;
									continue;
								case 45:
									goto end_IL_0059;
								case 25:
									if (num5 != 3)
									{
										num4 = 46;
										continue;
									}
									goto case 48;
								case 51:
									num6 = (MemoryExtensions.SequenceEqual<byte>(span.Slice(span.Length - 8), (global::System.ReadOnlySpan<byte>)new byte[8] { 0, 0, 0, 0, 0, 0, 0, 1 }) ? 1 : 0);
									goto IL_0a79;
								case 47:
									if (val == null)
									{
										num4 = 54;
										continue;
									}
									goto case 37;
								case 8:
									if (text != null)
									{
										num4 = 66;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
										{
											num4 = 64;
										}
										continue;
									}
									goto IL_04ab;
								case 60:
									if (span.Length >= 23)
									{
										num4 = 51;
										continue;
									}
									num6 = 0;
									goto IL_0a79;
								case 10:
								case 42:
									if (span.Length < 26)
									{
										num4 = 17;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
										{
											num4 = 60;
										}
										continue;
									}
									goto case 62;
								case 3:
									if ((val).Height <= 0)
									{
										num4 = 52;
										continue;
									}
									goto case 36;
								case 40:
									if (c != 'T')
									{
										num4 = 64;
										continue;
									}
									goto case 43;
								case 37:
									if ((val).Width > 0)
									{
										num4 = 3;
										continue;
									}
									goto case 52;
								case 0:
									goto IL_08d4;
								case 35:
								case 58:
									flag = Mm7f9KF7VQK(span);
									num4 = 13;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
									{
										num4 = 62;
									}
									continue;
								case 48:
									c = ((dynamic)(text)).Chars;
									num4 = 2;
									continue;
								case 59:
									flag = N9xf9H5x5ZG(span, (val).Width, (val).Height);
									num4 = 33;
									continue;
								case 46:
									if (num5 != 4)
									{
										num2 = 76;
										break;
									}
									goto case 55;
								case 52:
								case 54:
									result = false;
									num4 = 45;
									continue;
								case 36:
								{
									IImageFormat obj2 = ((val).Metadata).DecodedImageFormat;
									if (obj2 == null)
									{
										num4 = 32;
										continue;
									}
									obj = ((obj2).Name).ToUpperInvariant();
									goto IL_0a5f;
								}
								case 32:
									obj = null;
									goto IL_0a5f;
								case 17:
									num7 = 0;
									goto IL_0a6c;
								case 20:
									goto end_IL_0059;
									IL_0a5f:
									text = (string)obj;
									num4 = 8;
									continue;
									IL_0273:
									if ((text == "BMP"))
									{
										num4 = 10;
										continue;
									}
									goto IL_04ab;
									IL_0a79:
									flag = (byte)num6 != 0;
									num4 = 24;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
									{
										num4 = 15;
									}
									continue;
									IL_04ab:
									flag = false;
									num4 = 32;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
									{
										num4 = 1;
									}
									continue;
									IL_0677:
									if ((text == "GIF"))
									{
										num4 = 35;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
										{
											num4 = 56;
										}
										continue;
									}
									goto IL_04ab;
									IL_0a6c:
									flag = (byte)num7 != 0;
									num4 = 19;
									continue;
									IL_08d4:
									if (!(text == "TGA"))
									{
										num4 = 61;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
										{
											num4 = 53;
										}
										continue;
									}
									goto case 59;
									IL_043c:
									if (!(text == "PNG"))
									{
										num4 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
										{
											num4 = 29;
										}
										continue;
									}
									goto case 18;
									IL_070e:
									if (!(text == "QOI"))
									{
										num4 = 12;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
										{
											num4 = 58;
										}
										continue;
									}
									goto case 60;
								}
								goto IL_0051;
								continue;
								end_IL_0059:
								break;
							}
							break;
						}
						break;
					}
				}
				catch (global::System.Exception obj3) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj4 = obj3 as global::System.Exception;
					if (obj4 == null)
					{
						num9 = 5;
					}
					else
					{
						ex = obj4;
						num9 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
						{
							num9 = 12;
						}
					}
					while (true)
					{
						switch (num9)
						{
						default:
							if (num10 != 20)
							{
								if (num10 == 1000)
								{
									goto IL_0ac8;
								}
								goto case 5;
							}
							goto case 6;
						case 11:
							if (!(ex is NotSupportedException))
							{
								num9 = 7;
								continue;
							}
							goto case 0;
						case 3:
							if (ex is InvalidImageContentException)
							{
								num9 = 4;
								continue;
							}
							goto case 11;
						case 12:
							if (!(ex is UnknownImageFormatException))
							{
								num9 = 3;
								continue;
							}
							goto case 0;
						case 10:
							if (ex is ArgumentException)
							{
								num9 = 2;
								continue;
							}
							goto case 9;
						case 1:
							flag = false;
							num9 = 6;
							continue;
						case 9:
							if (ex is OverflowException)
							{
								num9 = 8;
								continue;
							}
							goto case 1;
						case 0:
						case 2:
						case 4:
						case 8:
							flag = true;
							num10 = 20;
							goto IL_0ac8;
						case 7:
							if (ex is IOException)
							{
								num9 = 14;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
								{
									num9 = 0;
								}
								continue;
							}
							goto case 10;
						case 5:
							result2 = 0;
							break;
						case 6:
							{
								result2 = (flag ? 1 : 0);
								break;
							}
							IL_0ac8:
							num9 = num10;
							continue;
						}
						break;
					}
					return (byte)result2 != 0;
				}).Invoke())
				{
					int num11 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
					{
						num11 = 0;
					}
					while (true)
					{
						switch (num11)
						{
						default:
							if (num12 == 989)
							{
								num11 = num12;
								continue;
							}
							break;
						case 1:
							result = false;
							num11 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 != 0)
							{
								num11 = 5;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool xPYf9dA3EKm(global::System.ReadOnlySpan<byte> bytes)
	{
		int num2 = default(int);
		uint num = System.Buffers.Binary.BinaryPrimitives.ReadUInt32BigEndian(bytes.Slice(num2));
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool Mm7f9KF7VQK(global::System.ReadOnlySpan<byte> bytes)
	{
		int num2 = default(int);
		uint num = System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(bytes.Slice(num2 + 4));
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool N9xf9H5x5ZG(global::System.ReadOnlySpan<byte> bytes, int width, int height)
	{
		ushort num = System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(bytes.Slice(5));
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool YBCZZbZNCPIm3VKkOiOI()
	{
		return OoYLpuZNQrOvRbk9dsdG == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static GxI494f9IymiuqWAmEOR sy9YZnZN4verq4kphuci()
	{
		return (GxI494f9IymiuqWAmEOR)OoYLpuZNQrOvRbk9dsdG;
	}
}
