using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BWttIuf5oBgEbGPnt4sV;
using By1SFsLobKQOZCdh5qRg;
using H32U1qfHnG8nTkv51pwh;
using KQIHrIfH1Wk8PxiLax04;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using SUbEOPfHvdkpFxGsXeRP;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.ApplicationModel.DataTransfer;
using bUfedyCg1PBqhqIkB8r;
using eapMLUfH2g3vj9xJlecH;
using iAkTYfytG7xcSeJIag6;
using qS8vkpL43FlTMgcj0rgs;
using ysi5iWfHGOCWraEC0jGr;

namespace Mahiro_Account.Views.Pages;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_Features_McpStudio_Views_McpStudioPageWinRTTypeDetails))]
public sealed class InvitationPage : Page, IComponentConnector
{
	private sealed class InvitationRow
	{
		private readonly g4MRBsfH3aAZmwoSPTmb _item;

		public long Id
		{
			[MethodImpl((MethodImplOptions)8)]
			get
			{
				return _item.Id;
			}
		}

		public string Code
		{
			[MethodImpl((MethodImplOptions)8)]
			get
			{
				return _item.Code;
			}
		}

		public string Status
		{
			[MethodImpl((MethodImplOptions)8)]
			get
			{
				return TNacVff5rKrNE95GgkHY.NEVf5mw6x9b(_item);
			}
		}

		public string RemainingText
		{
			[MethodImpl((MethodImplOptions)8)]
			get
			{
				return TNacVff5rKrNE95GgkHY.yFff574lIaU(_item);
			}
		}

		public string ExpiryText
		{
			[MethodImpl((MethodImplOptions)8)]
			get
			{
				return TNacVff5rKrNE95GgkHY.lxSf5AV70X7(_item);
			}
		}

		public string ReminderText
		{
			[MethodImpl((MethodImplOptions)8)]
			get
			{
				return TNacVff5rKrNE95GgkHY.NuEf5I7An59(_item);
			}
		}

		public string UserNote
		{
			[MethodImpl((MethodImplOptions)8)]
			get
			{
				return _item.UserNote;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public InvitationRow(g4MRBsfH3aAZmwoSPTmb item)
		{
			_item = item;
		}

		[MethodImpl((MethodImplOptions)8)]
		public InvitationRow WithNote(string note)
		{
			_item.UserNote = note;
			return (InvitationRow)new InvitationRow(_item);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct ___ctor_b__2_0_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public InvitationPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			InvitationPage invitationPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = invitationPage.LoadAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ___ctor_b__2_0_d>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
				}
				_u__.GetResult();
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_17
	{
		public static readonly __c_17 __9;

		public static Func<PhQ0LCfHqyPgc903gIAV, string> __9__10_0;

		static __c_17()
		{
			__9 = (__c_17)new __c_17();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_17()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string _UsageButton_Click_b__10_0(PhQ0LCfHqyPgc903gIAV item)
		{
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(7, 3);
			defaultInterpolatedStringHandler.AppendFormatted(item.Username);
			defaultInterpolatedStringHandler.AppendLiteral("（UID ");
			defaultInterpolatedStringHandler.AppendFormatted<long>(item.UserId);
			defaultInterpolatedStringHandler.AppendLiteral("） ");
			DateTimeOffset usedAt = item.UsedAt;
			defaultInterpolatedStringHandler.AppendFormatted<global::System.DateTime>(usedAt.LocalDateTime, "g");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ExportButton_Click_d__7 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public InvitationPage __4__this;

		private TaskAwaiter<AK0vaXyHwet1aSaprla> __u__1;

		private TaskAwaiter<ContentDialogResult> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Expected O, but got Unknown
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			InvitationPage invitationPage = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0030;
				}
				if (!invitationPage._busy)
				{
					invitationPage.SetBusy(busy: true);
					goto IL_0030;
				}
				goto end_IL_0011;
				IL_0030:
				try
				{
					TaskAwaiter<ContentDialogResult> _u__ = default;
					TaskAwaiter<AK0vaXyHwet1aSaprla> _u__2 = default;
					if (num != 0)
					{
						if (num == 1)
						{
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter<ContentDialogResult>);
							num = (__1__state = -1);
							goto IL_0145;
						}
						_u__2 = AppShell.Api.C608tM0sYQ().GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<AK0vaXyHwet1aSaprla>, _ExportButton_Click_d__7>(ref _u__2, ref this);
							return;
						}
					}
					else
					{
						_u__2 = __u__1;
						__u__1 = default(TaskAwaiter<AK0vaXyHwet1aSaprla>);
						num = (__1__state = -1);
					}
					AK0vaXyHwet1aSaprla result = _u__2.GetResult();
					_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>(new ContentDialog
					{
						Title = "邀请码导出内容",
						Content = (object)new TextBox
						{
							Text = result.Content,
							IsReadOnly = true,
							TextWrapping = (TextWrapping)2
						},
						CloseButtonText = "关闭",
						XamlRoot = ((UIElement)invitationPage).XamlRoot
					}.ShowAsync());
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ContentDialogResult>, _ExportButton_Click_d__7>(ref _u__, ref this);
						return;
					}
					goto IL_0145;
					IL_0145:
					_u__.GetResult();
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "ExportButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\InvitationPage.xaml.cs", 73);
					invitationPage.ShowError(ex);
				}
				finally
				{
					if (num < 0)
					{
						invitationPage.SetBusy(busy: false);
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _LoadAsync_d__5_1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public InvitationPage __4__this;

		private mMoIXmfHaoN10b16FGoI _summary_5__2;

		private TaskAwaiter<mMoIXmfHaoN10b16FGoI> __u__1;

		private TaskAwaiter<Q6BVUIfHEi0ZcbHiHVqA> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			InvitationPage invitationPage = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0030;
				}
				if (!invitationPage._busy)
				{
					invitationPage.SetBusy(busy: true);
					goto IL_0030;
				}
				goto end_IL_0011;
				IL_0030:
				try
				{
					TaskAwaiter<Q6BVUIfHEi0ZcbHiHVqA> _u__ = default;
					TaskAwaiter<mMoIXmfHaoN10b16FGoI> _u__2 = default;
					if (num != 0)
					{
						if (num == 1)
						{
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter<Q6BVUIfHEi0ZcbHiHVqA>);
							num = (__1__state = -1);
							goto IL_010b;
						}
						_u__2 = AppShell.Api.nnr8lO7X2k().GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<mMoIXmfHaoN10b16FGoI>, _LoadAsync_d__5_1>(ref _u__2, ref this);
							return;
						}
					}
					else
					{
						_u__2 = __u__1;
						__u__1 = default(TaskAwaiter<mMoIXmfHaoN10b16FGoI>);
						num = (__1__state = -1);
					}
					mMoIXmfHaoN10b16FGoI result = _u__2.GetResult();
					_summary_5__2 = result;
					_u__ = AppShell.Api.jiK8dr1D5N(1, 50).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Q6BVUIfHEi0ZcbHiHVqA>, _LoadAsync_d__5_1>(ref _u__, ref this);
						return;
					}
					goto IL_010b;
					IL_010b:
					Q6BVUIfHEi0ZcbHiHVqA result2 = _u__.GetResult();
					((Collection<InvitationRow>)(object)invitationPage._items).Clear();
					var enumerator = result2.Items.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							g4MRBsfH3aAZmwoSPTmb current = enumerator.Current;
							((Collection<InvitationRow>)(object)invitationPage._items).Add((InvitationRow)new InvitationRow(current));
						}
					}
					finally
					{
						if (num < 0)
						{
							((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						}
					}
					invitationPage.SummaryText.Text = $"总数 {_summary_5__2.Total} · 可用 {_summary_5__2.Available} · 已用尽 {_summary_5__2.Exhausted} · 即将过期 {_summary_5__2.Expiring}";
					invitationPage.FeedbackBar.Severity = (InfoBarSeverity)2;
					invitationPage.FeedbackBar.Message = "邀请系统已停用，现有邀请码暂时不可使用。";
					invitationPage.FeedbackBar.IsOpen = !result2.InvitationEnabled;
					_summary_5__2 = null;
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "LoadAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\InvitationPage.xaml.cs", 53);
					invitationPage.ShowError(ex);
				}
				finally
				{
					if (num < 0)
					{
						invitationPage.SetBusy(busy: false);
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _NoteButton_Click_d__9 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public InvitationPage __4__this;

		public object sender;

		private InvitationRow _row_5__2;

		private TextBox _box_5__3;

		private TaskAwaiter<ContentDialogResult> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Invalid comparison between Unknown and I4
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Expected O, but got Unknown
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			InvitationPage invitationPage = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0060;
				}
				if (!invitationPage._busy)
				{
					object obj = sender;
					Button val = (Button)((obj is Button) ? obj : null);
					if (val != null)
					{
						object tag = ((FrameworkElement)val).Tag;
						_row_5__2 = tag as InvitationRow;
						if (_row_5__2 != null)
						{
							invitationPage.SetBusy(busy: true);
							goto IL_0060;
						}
					}
				}
				goto end_IL_0011;
				IL_0060:
				try
				{
					TaskAwaiter _u__ = default;
					TaskAwaiter<ContentDialogResult> _u__2 = default;
					if (num != 0)
					{
						if (num == 1)
						{
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter);
							num = (__1__state = -1);
							goto IL_01b7;
						}
						_box_5__3 = new TextBox
						{
							Text = _row_5__2.UserNote,
							PlaceholderText = "备注",
							MaxLength = 255
						};
						_u__2 = WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>(new ContentDialog
						{
							Title = "修改备注",
							Content = _box_5__3,
							PrimaryButtonText = "保存",
							CloseButtonText = "取消",
							XamlRoot = ((UIElement)invitationPage).XamlRoot
						}.ShowAsync());
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ContentDialogResult>, _NoteButton_Click_d__9>(ref _u__2, ref this);
							return;
						}
					}
					else
					{
						_u__2 = __u__1;
						__u__1 = default(TaskAwaiter<ContentDialogResult>);
						num = (__1__state = -1);
					}
					if ((int)_u__2.GetResult() == 1)
					{
						_u__ = AppShell.Api.pXl8KKKLVy(_row_5__2.Id, _box_5__3.Text).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _NoteButton_Click_d__9>(ref _u__, ref this);
							return;
						}
						goto IL_01b7;
					}
					goto IL_0224;
					IL_01b7:
					_u__.GetResult();
					int num2 = ((Collection<InvitationRow>)(object)invitationPage._items).IndexOf(_row_5__2);
					if (num2 >= 0)
					{
						((Collection<InvitationRow>)(object)invitationPage._items)[num2] = _row_5__2.WithNote(_box_5__3.Text);
					}
					invitationPage.FeedbackBar.Severity = (InfoBarSeverity)1;
					invitationPage.FeedbackBar.Message = "备注已保存";
					invitationPage.FeedbackBar.IsOpen = true;
					goto IL_0224;
					IL_0224:
					_box_5__3 = null;
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "NoteButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\InvitationPage.xaml.cs", 114);
					invitationPage.ShowError(ex);
				}
				finally
				{
					if (num < 0)
					{
						invitationPage.SetBusy(busy: false);
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_row_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_row_5__2 = null;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _RefreshButton_Click_d__6_2 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public InvitationPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			InvitationPage invitationPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = invitationPage.LoadAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshButton_Click_d__6_2>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
				}
				_u__.GetResult();
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _UsageButton_Click_d__10 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public InvitationPage __4__this;

		public object sender;

		private TaskAwaiter<zqVJR5fHi59NFUdv1jNy> __u__1;

		private TaskAwaiter<ContentDialogResult> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected O, but got Unknown
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			InvitationPage invitationPage = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0063;
				}
				long num2 = default(long);
				if (!invitationPage._busy)
				{
					object obj = sender;
					Button val = (Button)((obj is Button) ? obj : null);
					if (val != null)
					{
						object tag = ((FrameworkElement)val).Tag;
						if (tag is long)
						{
							num2 = (long)tag;
							invitationPage.SetBusy(busy: true);
							goto IL_0063;
						}
					}
				}
				goto end_IL_0011;
				IL_0063:
					num2 = default;
				try
				{
					TaskAwaiter<ContentDialogResult> _u__ = default;
					TaskAwaiter<zqVJR5fHi59NFUdv1jNy> _u__2 = default;
					if (num != 0)
					{
						if (num == 1)
						{
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter<ContentDialogResult>);
							num = (__1__state = -1);
							goto IL_01ce;
						}
						_u__2 = AppShell.Api.u6l8H0jHjh(num2).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<zqVJR5fHi59NFUdv1jNy>, _UsageButton_Click_d__10>(ref _u__2, ref this);
							return;
						}
					}
					else
					{
						_u__2 = __u__1;
						__u__1 = default(TaskAwaiter<zqVJR5fHi59NFUdv1jNy>);
						num = (__1__state = -1);
					}
					zqVJR5fHi59NFUdv1jNy result = _u__2.GetResult();
					string text = ((result.Usages.Count == 0) ? "暂无使用记录" : string.Join(Environment.NewLine, Enumerable.Select<PhQ0LCfHqyPgc903gIAV, string>((global::System.Collections.Generic.IEnumerable<PhQ0LCfHqyPgc903gIAV>)result.Usages, (Func<PhQ0LCfHqyPgc903gIAV, string>)__c_17.__9._UsageButton_Click_b__10_0)));
					_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>(new ContentDialog
					{
						Title = "注册记录",
						Content = (object)new TextBox
						{
							Text = text,
							IsReadOnly = true,
							TextWrapping = (TextWrapping)2
						},
						CloseButtonText = "关闭",
						XamlRoot = ((UIElement)invitationPage).XamlRoot
					}.ShowAsync());
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ContentDialogResult>, _UsageButton_Click_d__10>(ref _u__, ref this);
						return;
					}
					goto IL_01ce;
					IL_01ce:
					_u__.GetResult();
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "UsageButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\InvitationPage.xaml.cs", 133);
					invitationPage.ShowError(ex);
				}
				finally
				{
					if (num < 0)
					{
						invitationPage.SetBusy(busy: false);
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	private readonly ObservableCollection<InvitationRow> _items;

	private bool _busy;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock SummaryText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private InfoBar FeedbackBar;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView InvitationList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RefreshButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button ExportButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[MethodImpl((MethodImplOptions)8)]
	public InvitationPage()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		_items = new ObservableCollection<InvitationRow>();
		InitializeComponent();
		((ItemsControl)InvitationList).ItemsSource = _items;
		((FrameworkElement)this).Loaded += (RoutedEventHandler)([MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] [CompilerGenerated] (object _, RoutedEventArgs _) =>
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			___ctor_b__2_0_d __ctor_b__2_0_d = default(___ctor_b__2_0_d);
			__ctor_b__2_0_d.__t__builder = AsyncVoidMethodBuilder.Create();
			__ctor_b__2_0_d.__4__this = this;
			__ctor_b__2_0_d.__1__state = -1;
			__ctor_b__2_0_d.__t__builder.Start<___ctor_b__2_0_d>(ref __ctor_b__2_0_d);
		});
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SetBusy(bool busy)
	{
		_busy = busy;
		((Control)RefreshButton).IsEnabled = !busy;
		((Control)ExportButton).IsEnabled = !busy;
		((Control)InvitationList).IsEnabled = !busy;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ShowError(global::System.Exception error)
	{
		FeedbackBar.Severity = (InfoBarSeverity)3;
		FeedbackBar.Message = AppShell.GetExceptionDisplayMessage(error, "ShowError", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\InvitationPage.xaml.cs", 34);
		FeedbackBar.IsOpen = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task LoadAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadAsync_d__5_1 loadAsync_d__5_ = default(_LoadAsync_d__5_1);
		loadAsync_d__5_.__t__builder = AsyncTaskMethodBuilder.Create();
		loadAsync_d__5_.__4__this = this;
		loadAsync_d__5_.__1__state = -1;
		loadAsync_d__5_.__t__builder.Start<_LoadAsync_d__5_1>(ref loadAsync_d__5_);
		return loadAsync_d__5_.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshButton_Click_d__6_2 refreshButton_Click_d__6_ = default(_RefreshButton_Click_d__6_2);
		refreshButton_Click_d__6_.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshButton_Click_d__6_.__4__this = this;
		refreshButton_Click_d__6_.__1__state = -1;
		refreshButton_Click_d__6_.__t__builder.Start<_RefreshButton_Click_d__6_2>(ref refreshButton_Click_d__6_);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ExportButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ExportButton_Click_d__7 exportButton_Click_d__ = default(_ExportButton_Click_d__7);
		exportButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		exportButton_Click_d__.__4__this = this;
		exportButton_Click_d__.__1__state = -1;
		exportButton_Click_d__.__t__builder.Start<_ExportButton_Click_d__7>(ref exportButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CopyButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		try
		{
			Button val = (Button)((sender is Button) ? sender : null);
			if (val != null && ((FrameworkElement)val).Tag is string text && !string.IsNullOrWhiteSpace(text))
			{
				DataPackage val2 = new DataPackage();
				val2.SetText(text);
				Clipboard.SetContent(val2);
				FeedbackBar.Severity = (InfoBarSeverity)1;
				FeedbackBar.Message = "邀请码已复制";
				FeedbackBar.IsOpen = true;
			}
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "CopyButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\InvitationPage.xaml.cs", 89);
			ShowError(ex);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void NoteButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_NoteButton_Click_d__9 noteButton_Click_d__ = default(_NoteButton_Click_d__9);
		noteButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		noteButton_Click_d__.__4__this = this;
		noteButton_Click_d__.sender = sender;
		noteButton_Click_d__.__1__state = -1;
		noteButton_Click_d__.__t__builder.Start<_NoteButton_Click_d__9>(ref noteButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void UsageButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_UsageButton_Click_d__10 usageButton_Click_d__ = default(_UsageButton_Click_d__10);
		usageButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		usageButton_Click_d__.__4__this = this;
		usageButton_Click_d__.sender = sender;
		usageButton_Click_d__.__1__state = -1;
		usageButton_Click_d__.__t__builder.Start<_UsageButton_Click_d__10>(ref usageButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void InitializeComponent()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri val = new Uri("ms-appx:///Views/Pages/InvitationPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			SummaryText = CastExtensions.As<TextBlock>(target);
			break;
		case 3:
			FeedbackBar = CastExtensions.As<InfoBar>(target);
			break;
		case 4:
			InvitationList = CastExtensions.As<ListView>(target);
			break;
		case 6:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(CopyButton_Click);
			break;
		case 7:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(NoteButton_Click);
			break;
		case 8:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(UsageButton_Click);
			break;
		case 9:
			RefreshButton = CastExtensions.As<Button>(target);
			((ButtonBase)RefreshButton).Click += new RoutedEventHandler(RefreshButton_Click);
			break;
		case 10:
			ExportButton = CastExtensions.As<Button>(target);
			((ButtonBase)ExportButton).Click += new RoutedEventHandler(ExportButton_Click);
			break;
		}
		_contentLoaded = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	[CompilerGenerated]
	private void __ctor_b__2_0(object _, RoutedEventArgs _2)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		___ctor_b__2_0_d __ctor_b__2_0_d = default(___ctor_b__2_0_d);
		__ctor_b__2_0_d.__t__builder = AsyncVoidMethodBuilder.Create();
		__ctor_b__2_0_d.__4__this = this;
		__ctor_b__2_0_d.__1__state = -1;
		__ctor_b__2_0_d.__t__builder.Start<___ctor_b__2_0_d>(ref __ctor_b__2_0_d);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}
