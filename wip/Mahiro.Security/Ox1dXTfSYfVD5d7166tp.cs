using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using JvgQTDcbARdEdTAk7GE;
using PJFIn6fwNw3W82OxkWAg;
using fDAldojjppXrctUVYOJn;
using r5LWFs73eOlXSX66CSK;

namespace LFyacXfSScjMXMO2dlPV;

internal class Ox1dXTfSYfVD5d7166tp
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _WaitAsync_d__2_1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<string> __t__builder;

		public Process process;

		public TimeSpan timeout;

		public CancellationToken cancellationToken;

		private string _markerPath_5__2;

		private DateTimeOffset _deadline_5__3;

		private object __u__1;

		internal static object AGnOL0DWKdBFUslnd9Vb;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_042d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0505: Unknown result type (might be due to invalid IL or missing references)
			//IL_050b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0451: Unknown result type (might be due to invalid IL or missing references)
			//IL_0456: Unknown result type (might be due to invalid IL or missing references)
			//IL_0253: Unknown result type (might be due to invalid IL or missing references)
			//IL_0268: Unknown result type (might be due to invalid IL or missing references)
			//IL_026d: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_038e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0419: Unknown result type (might be due to invalid IL or missing references)
			//IL_041b: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ca->IL0599: Incompatible stack heights: 0 vs 2
			//IL_059d->IL059d: Incompatible stack heights: 3 vs 1
			//IL_067b->IL0008: Incompatible stack heights: 3 vs 1
			int num3 = default;
			int num6 = default;
			object _u__ = default;
			string text4 = default;
			ConfiguredTaskAwaitable val = default;
			string text3 = default;
			int num8 = default;
			while (true)
			{
				int num = 4;
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						default:
							if (num != 11)
							{
								if (num == 992)
								{
									goto end_IL_0010;
								}
								goto case 2;
							}
							return;
						case 0:
							_markerPath_5__2 = null;
							num2 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 != 0)
							{
								num2 = 4;
							}
							continue;
						case 3:
							try
							{
								int num4;
								if (num3 == 0)
								{
									num4 = 7;
									goto IL_0094;
								}
								goto IL_013a;
								IL_013a:
								System.ArgumentNullException.ThrowIfNull(process, "process");
								num4 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
								{
									num4 = 6;
								}
								goto IL_0094;
								IL_0094:
								while (true)
								{
									int num5;
									string text;
									string text2;
									switch (num4)
									{
									default:
										if (num6 != 39)
										{
											if (num6 == 1019)
											{
												goto IL_0090;
											}
											goto case 23;
										}
										_markerPath_5__2 = FUmfS8MNU4U((process).Id);
										num4 = 23;
										continue;
									case 26:
										break;
									case 0:
									case 19:
										(_u__).GetResult();
										num4 = 3;
										continue;
									case 4:
										goto end_IL_0094;
									case 25:
										if ((_u__).IsCompleted)
										{
											num4 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
											{
												num4 = 32;
											}
											continue;
										}
										goto case 9;
									case 28:
										goto end_IL_0094;
									case 5:
										text2 = text4;
										num4 = 28;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
										{
											num4 = 2;
										}
										continue;
									case 10:
										throw new global::System.Exception("timeout");
									case 11:
										val = (System.Threading.Tasks.Task.Delay(200, cancellationToken)).ConfigureAwait(false);
										num4 = 2;
										continue;
									case 31:
										(cancellationToken).ThrowIfCancellationRequested();
										num4 = 1;
										continue;
									case 21:
										__t__builder.AwaitUnsafeOnCompleted<object, _WaitAsync_d__2_1>(ref _u__, ref this);
										num5 = 30;
										goto IL_008c;
									case 13:
										text = text3;
										goto IL_0559;
									case 23:
										_deadline_5__3 = (System.DateTimeOffset.UtcNow + timeout);
										num4 = 27;
										continue;
									case 30:
										return;
									case 18:
										if ((text4).Equals("completed", (StringComparison)4))
										{
											num4 = 36;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
											{
												num4 = 5;
											}
											continue;
										}
										goto case 22;
									case 9:
										num3 = (__1__state = 0);
										num4 = 29;
										continue;
									case 22:
										if (rCHfSQjA4vQ(process))
										{
											num4 = 14;
											continue;
										}
										goto case 11;
									case 20:
										__u__1 = default;
										num4 = 24;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
										{
											num4 = 9;
										}
										continue;
									case 15:
										if ((text3).Length == 0)
										{
											num4 = 17;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
											{
												num4 = 16;
											}
											continue;
										}
										goto case 13;
									case 1:
										text4 = hA4fSJc3vBC(_markerPath_5__2);
										num4 = 18;
										continue;
									case 29:
										__u__1 = _u__;
										num5 = 21;
										goto IL_008c;
									case 2:
										_u__ = val;
										num4 = 25;
										continue;
									case 6:
										text3 = hA4fSJc3vBC(_markerPath_5__2);
										num5 = 15;
										goto IL_008c;
									case 8:
										if (!(timeout <= TimeSpan.Zero))
										{
											num5 = 39;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
											{
												num5 = 14;
											}
											goto IL_008c;
										}
										goto case 10;
									case 24:
										num3 = (__1__state = -1);
										num4 = 19;
										continue;
									case 7:
									case 12:
										_u__ = __u__1;
										num4 = 20;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
										{
											num4 = 18;
										}
										continue;
									case 14:
										text2 = "process-exited";
										num4 = 4;
										continue;
									case 3:
									case 27:
										if (!(System.DateTimeOffset.UtcNow < _deadline_5__3))
										{
											num4 = 6;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
											{
												num4 = 9;
											}
											continue;
										}
										goto case 31;
									case 17:
										text = "missing";
										goto IL_0559;
									case 16:
										goto end_IL_0094;
										IL_008c:
										num6 = num5;
										goto IL_0090;
										IL_0090:
										num4 = num6;
										continue;
										IL_0559:
										text2 = text;
										num4 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
										{
											num4 = 16;
										}
										continue;
									}
									goto IL_013a;
									continue;
									end_IL_0094:
									break;
								}
							}
							catch (global::System.Exception)
							{
								int num7 = 2;
								while (true)
								{
									switch (num7)
									{
									default:
										switch (num8)
										{
										case 990:
											goto end_IL_059d;
										case 10:
											return;
										}
										goto case 1;
									case 1:
										_markerPath_5__2 = null;
										num7 = 10;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
										{
											num7 = 0;
										}
										break;
									case 0:
									{
										_ = __t__builder;
										int num9 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
										{
											num9 = 10;
										}
										num8 = num9;
										break;
									}
									case 2:
										{
											__1__state = -2;
											num7 = 9;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
											{
												num7 = 1;
											}
											break;
										}
										end_IL_059d:
										break;
									}
								}
							}
							goto case 2;
						case 1:
							break;
						case 2:
							__1__state = -2;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
							{
								num2 = 9;
							}
							continue;
						case 4:
							num3 = __1__state;
							num2 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
							{
								num2 = 2;
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
				_ = __t__builder;
				_ = 11;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			int num = 1;
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
							switch (num2)
							{
							case 990:
								break;
							case 9:
								goto IL_0045;
							default:
								goto end_IL_000e;
							}
							break;
						case 0:
							return;
						case 1:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
							{
								num3 = 2;
							}
							continue;
						case 2:
							goto end_IL_000e;
							IL_0045:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
							{
								num3 = 1;
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
		internal static bool cxb11ZDWHToES4s2j0Cn()
		{
			return AGnOL0DWKdBFUslnd9Vb == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object pNNk1ADWtgUJm6dpRbNw()
		{
			return AGnOL0DWKdBFUslnd9Vb;
		}
	}

	private static object eQgV0LZMTmcXtEEOYxAW;

	[MethodImpl((MethodImplOptions)8)]
	internal static void FHufSc4AUGT(int processId)
	{
		int num = 1;
		do
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 0:
					KEFfSCmbSAT(QhsfSy24FJF(processId));
					num2 = 4;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 != 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					return;
				case 1:
					KEFfSCmbSAT(FUmfS8MNU4U(processId));
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
		while (num == 990);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task<string> hYTfS0woN4W(object process, TimeSpan timeout, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static string FUmfS8MNU4U(int processId)
	{
		//IL_0064: Expected O, but got I4
		//IL_0064: Expected O, but got I4
		//IL_0064: Expected O, but got Ref
		CftfSWR4iPV();
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default;
		(defaultInterpolatedStringHandler).AppendFormatted("status-ui");
		(defaultInterpolatedStringHandler).AppendLiteral("-");
		global::System.Threading.Tasks.Task<S9HINnfwTP9GO76XPCkJ> task = ((v5OiSQSzC8GipXkQ3VG)(&defaultInterpolatedStringHandler)).wDn87ymIHB<S9HINnfwTP9GO76XPCkJ>((string)8, (object)2, (byte)(&defaultInterpolatedStringHandler) != 0, (CancellationToken)processId);
		(defaultInterpolatedStringHandler).AppendLiteral(".marker");
		return System.IO.Path.Combine((string)(object)task, (defaultInterpolatedStringHandler).ToStringAndClear());
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static string QhsfSy24FJF(int processId)
	{
		//IL_006f: Expected O, but got I4
		//IL_006f: Expected O, but got I4
		//IL_006f: Expected O, but got Ref
		CftfSWR4iPV();
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default;
		(defaultInterpolatedStringHandler).AppendFormatted("status-ui");
		(defaultInterpolatedStringHandler).AppendLiteral("-");
		global::System.Threading.Tasks.Task<S9HINnfwTP9GO76XPCkJ> task = ((v5OiSQSzC8GipXkQ3VG)(&defaultInterpolatedStringHandler)).wDn87ymIHB<S9HINnfwTP9GO76XPCkJ>((string)5, (object)2, (byte)(&defaultInterpolatedStringHandler) != 0, (CancellationToken)processId);
		(defaultInterpolatedStringHandler).AppendLiteral(".log");
		return System.IO.Path.Combine((string)(object)task, (defaultInterpolatedStringHandler).ToStringAndClear());
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
		string result = default;
		int num3 = default;
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num4);
		global::System.Exception ex = default;
		int num6 = default;
		bool flag = default;
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num5);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num8 = default;
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
				catch (object obj) when (((Func<bool>)delegate
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
		bool result = default;
		int num3 = default;
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num4);
		global::System.Exception ex = default;
		int num5 = default;
		bool flag = default;
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num7 = default;
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					result = (process).HasExited;
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
				catch (object obj) when (((Func<bool>)delegate
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
		int num3 = default;
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num4);
		global::System.Exception ex = default;
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num5);
		int num6 = default;
		bool flag = default;
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
		int num8 = default;
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
			catch (object obj) when (((Func<bool>)delegate
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
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e != 0)
							{
								num3 = 8;
							}
							continue;
						}
						goto IL_0031;
					case 2:
						goto end_IL_000e;
					case 1:
						break;
					case 0:
						return;
					}
					goto IL_0077;
					IL_0031:
					if (num2 == 990)
					{
						break;
					}
					goto IL_0077;
					IL_0077:
					xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
					num3 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
					{
						num3 = 1;
					}
				}
				continue;
				end_IL_000e:
				break;
			}
			num = 9;
		}
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
