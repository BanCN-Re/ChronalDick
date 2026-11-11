using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;
using r5LWFs73eOlXSX66CSK;

namespace LFyacXfSScjMXMO2dlPV;

internal class Ox1dXTfSYfVD5d7166tp
{
	private static object eQgV0LZMTmcXtEEOYxAW;

	[MethodImpl((MethodImplOptions)8)]
	internal static void FHufSc4AUGT(int processId)
	{
		KEFfSCmbSAT(QhsfSy24FJF(processId));
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task<string> hYTfS0woN4W(object process, TimeSpan timeout, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_WaitAsync_d__2_1 waitAsync_d__2_ = default(_WaitAsync_d__2_1);
		waitAsync_d__2_.__t__builder = AsyncTaskMethodBuilder<string>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string FUmfS8MNU4U(int processId)
	{
		string text = CftfSWR4iPV();
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(8, 2);
		(defaultInterpolatedStringHandler).AppendFormatted("status-ui");
		(defaultInterpolatedStringHandler).AppendLiteral("-");
		defaultInterpolatedStringHandler.AppendFormatted<int>(processId);
		(defaultInterpolatedStringHandler).AppendLiteral(".marker");
		return System.IO.Path.Combine(text, (defaultInterpolatedStringHandler).ToStringAndClear());
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string QhsfSy24FJF(int processId)
	{
		string text = CftfSWR4iPV();
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(5, 2);
		(defaultInterpolatedStringHandler).AppendFormatted("status-ui");
		(defaultInterpolatedStringHandler).AppendLiteral("-");
		defaultInterpolatedStringHandler.AppendFormatted<int>(processId);
		(defaultInterpolatedStringHandler).AppendLiteral(".log");
		return System.IO.Path.Combine(text, (defaultInterpolatedStringHandler).ToStringAndClear());
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string CftfSWR4iPV()
	{
		return System.IO.Path.Combine(JNVYTu71oRZRpWuML35.BedrockDataRoot, "instant-runtime");
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string hA4fSJc3vBC(object path)
	{
		int num = 1;
		string result = default(string);
		int num3 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num4);
		global::System.Exception ex = default(global::System.Exception);
		int num6 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num5);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num8 = default(int);
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
					int num2;
					if (System.IO.File.Exists((string)path))
					{
						num2 = 2;
						goto IL_0060;
					}
					goto IL_00a8;
					IL_00e0:
					string text;
					result = (string)text;
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
					{
						num2 = 0;
					}
					goto IL_0060;
					IL_0060:
					while (true)
					{
						switch (num2)
						{
						default:
							if (num3 == 990)
							{
								num2 = num3;
								continue;
							}
							goto end_IL_0034;
						case 1:
							break;
						case 2:
							goto IL_00b7;
						case 0:
							goto end_IL_0034;
						}
						break;
					}
					goto IL_00a8;
					IL_00a8:
					text = string.Empty;
					goto IL_00e0;
					IL_00b7:
					text = ((System.IO.File.ReadAllText((string)path, System.Text.Encoding.UTF8)).Trim()).ToLowerInvariant();
					goto IL_00e0;
					end_IL_0034:;
				}
				catch (global::System.Exception obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj2 = obj as global::System.Exception;
					if (obj2 == null)
					{
						num4 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
						{
							num4 = 7;
						}
					}
					else
					{
						ex = obj2;
						num4 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
						{
							num4 = 1;
						}
					}
					while (true)
					{
						switch (num4)
						{
						default:
							if (num6 != 13)
							{
								if (num6 == 993)
								{
									goto IL_0144;
								}
								goto case 2;
							}
							if (ex is UnauthorizedAccessException)
							{
								num4 = 5;
								continue;
							}
							goto case 0;
						case 0:
							flag = false;
							num4 = 4;
							continue;
						case 1:
							if (!(ex is IOException))
							{
								num5 = 13;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 != 0)
								{
									num5 = 13;
								}
								num6 = num5;
								goto IL_0144;
							}
							goto case 5;
						case 5:
							flag = true;
							num4 = 2;
							continue;
						case 3:
							result2 = 0;
							break;
						case 2:
						case 4:
							{
								result2 = (flag ? 1 : 0);
								break;
							}
							IL_0144:
							num4 = num6;
							continue;
						}
						break;
					}
					return (byte)result2 != 0;
				}).Invoke())
				{
					int num7 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
					{
						num7 = 4;
					}
					while (true)
					{
						switch (num7)
						{
						default:
							if (num8 == 989)
							{
								num7 = num8;
								continue;
							}
							break;
						case 0:
							result = string.Empty;
							num7 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b != 0)
							{
								num7 = 1;
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
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool rCHfSQjA4vQ(object process)
	{
		int num = 1;
		bool result = default(bool);
		int num3 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num4);
		global::System.Exception ex = default(global::System.Exception);
		int num5 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num7 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					result = ((dynamic)(process)).HasExited;
					int num2 = 5;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
					{
						num2 = 0;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							if (num3 == 988)
							{
								num2 = num3;
								continue;
							}
							break;
						case 0:
							break;
						}
						break;
					}
				}
				catch (global::System.Exception obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj2 = obj as global::System.Exception;
					if (obj2 == null)
					{
						num4 = 15;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
						{
							num4 = 7;
						}
					}
					else
					{
						ex = obj2;
						num4 = 2;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							if (num5 != 15)
							{
								if (num5 == 995)
								{
									goto IL_00d1;
								}
								goto case 2;
							}
							goto case 4;
						case 3:
							if (!(ex is NotSupportedException))
							{
								num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
								{
									num4 = 1;
								}
								continue;
							}
							goto case 4;
						case 0:
						case 1:
							flag = false;
							num4 = 5;
							continue;
						case 2:
							if (ex is InvalidOperationException)
							{
								num5 = 15;
								goto IL_00d1;
							}
							goto case 3;
						case 4:
							flag = true;
							num4 = 6;
							continue;
						case 7:
							result2 = 0;
							break;
						case 5:
						case 6:
							{
								result2 = (flag ? 1 : 0);
								break;
							}
							IL_00d1:
							num4 = num5;
							continue;
						}
						break;
					}
					return (byte)result2 != 0;
				}).Invoke())
				{
					int num6 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
					{
						num6 = 4;
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
							result = true;
							num6 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 != 0)
							{
								num6 = 0;
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
	private static void KEFfSCmbSAT(object path)
	{
		int num = 1;
		int num3 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num4);
		global::System.Exception ex = default(global::System.Exception);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num5);
		int num6 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
		int num8 = default(int);
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
				if (!System.IO.File.Exists((string)path))
				{
					return;
				}
				int num2 = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 != 0)
				{
					num2 = 3;
				}
				while (true)
				{
					switch (num2)
					{
					case 0:
						return;
					default:
						if (num3 != 989)
						{
							return;
						}
						num2 = num3;
						break;
					case 1:
						System.IO.File.Delete((string)path);
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
						{
							num2 = 4;
						}
						break;
					}
				}
			}
			catch (global::System.Exception obj) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				obj2 = obj as global::System.Exception;
				if (obj2 == null)
				{
					num4 = 3;
					goto IL_00e2;
				}
				ex = obj2;
				num5 = 5;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
				{
					num5 = 0;
				}
				goto IL_00ea;
				IL_00e6:
				num5 = num6;
				goto IL_00ea;
				IL_00ea:
				while (true)
				{
					switch (num5)
					{
					default:
						if (num6 != 14)
						{
							if (num6 == 994)
							{
								goto IL_00e6;
							}
							goto case 1;
						}
						goto case 4;
					case 1:
						if (ex is UnauthorizedAccessException)
						{
							num5 = 6;
							continue;
						}
						goto case 5;
					case 2:
					case 6:
						break;
					case 5:
						flag = false;
						num5 = 4;
						continue;
					case 0:
						if (ex is IOException)
						{
							num5 = 2;
							continue;
						}
						goto case 1;
					case 3:
						result = 0;
						goto IL_01d1;
					case 4:
						{
							result = (flag ? 1 : 0);
							goto IL_01d1;
						}
						IL_01d1:
						return (byte)result != 0;
					}
					break;
				}
				flag = true;
				num4 = 14;
				goto IL_00e2;
				IL_00e2:
				num6 = num4;
				goto IL_00e6;
			}).Invoke())
			{
				int num7 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
				{
					num7 = 2;
				}
				while (true)
				{
					switch (num7)
					{
					case 0:
						return;
					}
					if (num8 != 988)
					{
						return;
					}
					num7 = num8;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool cGf2xnZMNgM2tbX8UJTZ()
	{
		return eQgV0LZMTmcXtEEOYxAW == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Ox1dXTfSYfVD5d7166tp YRYKMLZMMWxmJ4qCdiTS()
	{
		return (Ox1dXTfSYfVD5d7166tp)eQgV0LZMTmcXtEEOYxAW;
	}
}
