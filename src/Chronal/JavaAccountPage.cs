using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using B1sMsHfszr8btKuT8Q1f;
using By1SFsLobKQOZCdh5qRg;
using ERJ416fPgD8mIlLPsat4;
using GxkGd8NIqf0OYNxx8A9;
using K5FCrdFj16NFnFBU3KQ;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using MvvAQKfT00pIT9OyGwbr;
using N7C2oTfTSOw34Jog3k20;
using O7oSQyfxiUTrhAE02s2Q;
using UdqkwpfT9sQHP2QlSbNF;
using WP2chpfxfiuBSYyeOFWV;
using WinRT;
using WinRT.ChronalVtableClasses;
using YXMjNoXcouOKeTTRMKFH;
using bUfedyCg1PBqhqIkB8r;
using dwBQfPMXqPDU8deTdOQ;
using fAXRvmNZu6fmaZ5kmc8;
using gh4IKxNGTwx3Xea0FWT;
using hWvPvOqoGjt2MsShCjO;
using lektpxfTtOKy61TYHKdV;
using qS8vkpL43FlTMgcj0rgs;
using w7on9HfTjvytoqRj5MX9;

namespace Mahiro_Account.Views.Pages.Java;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_Bedrock_BedrockVersionManagementPageWinRTTypeDetails))]
public sealed class JavaAccountPage : Page, global::System.IDisposable, IComponentConnector
{
	private sealed class OfficialEnvironmentSnapshot : IEquatable<OfficialEnvironmentSnapshot>
	{
		[CompilerGenerated]
		private global::System.Type EqualityContract
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return typeof(global::Mahiro_Account.Views.Pages.Java.JavaAccountPage.OfficialEnvironmentSnapshot);
			}
		}

		[field: CompilerGenerated]
		private string _HostStatus_k__BackingField;

		public string HostStatus
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get;
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		private string _BridgeStatus_k__BackingField;

		public string BridgeStatus
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get;
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			init;
		}

		[MethodImpl((MethodImplOptions)8)]
		public OfficialEnvironmentSnapshot(string HostStatus, string BridgeStatus)
		{
			_HostStatus_k__BackingField = HostStatus;
			_BridgeStatus_k__BackingField = BridgeStatus;
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override string ToString()
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Expected O, but got Unknown
			StringBuilder val = new StringBuilder();
			val.Append("OfficialEnvironmentSnapshot");
			val.Append(" { ");
			if (PrintMembers(val))
			{
				val.Append(' ');
			}
			val.Append('}');
			return ((object)val).ToString();
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("HostStatus = ");
			builder.Append((object)HostStatus);
			builder.Append(", BridgeStatus = ");
			builder.Append((object)BridgeStatus);
			return true;
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator !=(OfficialEnvironmentSnapshot? left, OfficialEnvironmentSnapshot? right)
		{
			return !(left == right);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator ==(OfficialEnvironmentSnapshot? left, OfficialEnvironmentSnapshot? right)
		{
			if ((object)left != right)
			{
				return left?.Equals(right) ?? false;
			}
			return true;
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_HostStatus_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_BridgeStatus_k__BackingField);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as OfficialEnvironmentSnapshot);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public bool Equals(OfficialEnvironmentSnapshot? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(_HostStatus_k__BackingField, other._HostStatus_k__BackingField))
				{
					return EqualityComparer<string>.Default.Equals(_BridgeStatus_k__BackingField, other._BridgeStatus_k__BackingField);
				}
				return false;
			}
			return true;
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public OfficialEnvironmentSnapshot _Clone__()
		{
			return (OfficialEnvironmentSnapshot)new OfficialEnvironmentSnapshot(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private OfficialEnvironmentSnapshot(OfficialEnvironmentSnapshot original)
		{
			_HostStatus_k__BackingField = original._HostStatus_k__BackingField;
			_BridgeStatus_k__BackingField = original._BridgeStatus_k__BackingField;
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public void Deconstruct(out string HostStatus, out string BridgeStatus)
		{
			//IL_000b: Expected I8, but got O
			//IL_0013: Expected I8, but got O
			HostStatus = default;
			BridgeStatus = default;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass9_0_5
	{
		public CancellationTokenSource operation;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass9_0_5()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal OfficialEnvironmentSnapshot _RefreshOfficialEnvironmentAsync_b__0()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			return InspectOfficialEnvironment(operation.Token);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _AuthenticateButton_Click_d__30 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaAccountPage __4__this;

		private CancellationTokenSource _operation_5__2;

		private bool _replacingSession_5__3;

		private GE50SffsnGnn7g3lMZHE _session_5__4;

		private string _profileError_5__5;

		private TaskAwaiter<GE50SffsnGnn7g3lMZHE> __u__1;

		private TaskAwaiter<cBjn75fTHaWsvHZL0eiQ> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaAccountPage javaAccountPage = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0079;
				}
				string text = default(string);
				if (javaAccountPage._operation == null)
				{
					text = (string.IsNullOrWhiteSpace(javaAccountPage.SauthBox.Password) ? HpFsqcfPB2RknTNMlueF.Current : javaAccountPage.SauthBox.Password);
					if (!string.IsNullOrWhiteSpace(text))
					{
						_operation_5__2 = new CancellationTokenSource();
						goto IL_0079;
					}
					AppShell.Error("请先生成或粘贴 SAuth");
				}
				goto end_IL_0011;
				IL_0079:
					text = default;
				try
				{
					if ((uint)num > 1u)
					{
						javaAccountPage._operation = _operation_5__2;
						_replacingSession_5__3 = javaAccountPage._client.CurrentSession != null;
						javaAccountPage.SetBusy(busy: true, _replacingSession_5__3 ? "正在安全更新 Java 会话" : "正在建立 Java 会话");
					}
					try
					{
						TaskAwaiter<GE50SffsnGnn7g3lMZHE> _u__ = default;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_0156;
							}
							_u__ = javaAccountPage._client.AuthenticateAsync(text, _operation_5__2.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<GE50SffsnGnn7g3lMZHE>, _AuthenticateButton_Click_d__30>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<GE50SffsnGnn7g3lMZHE>);
							num = (__1__state = -1);
						}
						GE50SffsnGnn7g3lMZHE result = _u__.GetResult();
						_session_5__4 = result;
						_profileError_5__5 = null;
						goto IL_0156;
						IL_0156:
						try
						{
							TaskAwaiter<cBjn75fTHaWsvHZL0eiQ> _u__2 = default;
							if (num != 1)
							{
								_u__2 = javaAccountPage._client.EENssHxa5E(_operation_5__2.Token).GetAwaiter();
								if (!_u__2.IsCompleted)
								{
									num = (__1__state = 1);
									__u__2 = _u__2;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<cBjn75fTHaWsvHZL0eiQ>, _AuthenticateButton_Click_d__30>(ref _u__2, ref this);
									return;
								}
							}
							else
							{
								_u__2 = __u__2;
								__u__2 = default(TaskAwaiter<cBjn75fTHaWsvHZL0eiQ>);
								num = (__1__state = -1);
							}
							cBjn75fTHaWsvHZL0eiQ result2 = _u__2.GetResult();
							javaAccountPage.PresentProfile(result2);
						}
						catch (global::System.Exception ex) when (!(ex is OperationCanceledException))
						{
							cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "AuthenticateButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaAccountPage.xaml.cs", 63);
							_profileError_5__5 = pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex, "登录完成后重新刷新用户资料");
						}
						catch (global::System.Exception obj) when (obj is OperationCanceledException && javaAccountPage._client.CurrentSession != null)
						{
							_profileError_5__5 = "用户资料刷新已取消";
						}
						javaAccountPage.SauthBox.Password = string.Empty;
						javaAccountPage.RefreshStatus();
						string text2 = (_replacingSession_5__3 ? ("Java 会话已安全更新，用户 ID：" + _session_5__4.UserId) : ("Java 会话已建立，用户 ID：" + _session_5__4.UserId));
						if (_profileError_5__5 == null)
						{
							AppShell.Success(text2);
						}
						else
						{
							javaAccountPage.ProfileStatusText.Text = "用户资料加载失败 · " + _profileError_5__5;
							AppShell.Warning(text2 + "；用户资料暂未加载");
						}
						_session_5__4 = null;
						_profileError_5__5 = null;
					}
					catch (OperationCanceledException)
					{
						AppShell.Warning("Java 会话建立已取消");
					}
					catch (global::System.Exception ex3)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex3, "ui-exception", "AuthenticateButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaAccountPage.xaml.cs", 91);
						AppShell.Error(pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex3, "检查 SAuth 和网络连接后重新建立会话"));
					}
					finally
					{
						if (num < 0)
						{
							if (javaAccountPage._operation == _operation_5__2)
							{
								javaAccountPage._operation = null;
							}
							javaAccountPage.SetBusy(busy: false);
						}
					}
				}
				finally
				{
					if (num < 0 && _operation_5__2 != null)
					{
						((global::System.IDisposable)_operation_5__2).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_operation_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_operation_5__2 = null;
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
	private struct _ConnectionModeComboBox_SelectionChanged_d__7 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaAccountPage __4__this;

		private r9S4FZfxG0478bdNv59r _requestedMode_5__2;

		private CancellationTokenSource _operation_5__3;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0195: Unknown result type (might be due to invalid IL or missing references)
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Unknown result type (might be due to invalid IL or missing references)
			//IL_0200: Unknown result type (might be due to invalid IL or missing references)
			//IL_0205: Unknown result type (might be due to invalid IL or missing references)
			//IL_0215: Unknown result type (might be due to invalid IL or missing references)
			//IL_0225: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Expected O, but got Unknown
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaAccountPage javaAccountPage = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_00b3;
				}
				bool flag = javaAccountPage._updatingConnectionMode || javaAccountPage._connectionModeOperation != null;
				if (!flag)
				{
					int selectedIndex = ((Selector)javaAccountPage.ConnectionModeComboBox).SelectedIndex;
					bool flag2 = ((selectedIndex < 0 || selectedIndex > 1) ? true : false);
					flag = flag2;
				}
				if (!flag)
				{
					_requestedMode_5__2 = (r9S4FZfxG0478bdNv59r)((((Selector)javaAccountPage.ConnectionModeComboBox).SelectedIndex != 0) ? 1 : 0);
					if (_requestedMode_5__2 != javaAccountPage._connectionCoordinator.SelectedMode)
					{
						_operation_5__3 = new CancellationTokenSource();
						goto IL_00b3;
					}
				}
				goto end_IL_0011;
				IL_00b3:
				try
				{
					if ((uint)num > 1u)
					{
						javaAccountPage._connectionModeOperation = _operation_5__3;
						javaAccountPage.RefreshConnectionModeStatus();
					}
					try
					{
						TaskAwaiter _u__ = default;
						TaskAwaiter<bool> _u__2 = default;
						if (num != 0)
						{
							if (num == 1)
							{
								_u__ = __u__2;
								__u__2 = default(TaskAwaiter);
								num = (__1__state = -1);
								goto IL_01f3;
							}
							qC3ZV7fxXAJqu2TjY3Nc current = javaAccountPage._connectionCoordinator.Current;
							if (current == null || !current.IsActive)
							{
								goto IL_01fa;
							}
							_u__2 = AppShell.ConfirmAsync("切换 Java 连接模式？", "切换前必须停止当前连接实例。停止完成后将保留账号会话，并改用所选模式。", "停止并切换").GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _ConnectionModeComboBox_SelectionChanged_d__7>(ref _u__2, ref this);
								return;
							}
						}
						else
						{
							_u__2 = __u__1;
							__u__1 = default(TaskAwaiter<bool>);
							num = (__1__state = -1);
						}
						bool result = _u__2.GetResult();
						CancellationToken token = _operation_5__3.Token;
						token.ThrowIfCancellationRequested();
						if (result)
						{
							_u__ = javaAccountPage._connectionCoordinator.GGwNtycGrm(_operation_5__3.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ConnectionModeComboBox_SelectionChanged_d__7>(ref _u__, ref this);
								return;
							}
							goto IL_01f3;
						}
						goto end_IL_00cd;
						IL_01fa:
						token = _operation_5__3.Token;
						token.ThrowIfCancellationRequested();
						javaAccountPage._connectionCoordinator.V3WNlk2OMF(_requestedMode_5__2);
						AppShell.Success("Java 连接模式已切换为" + ModeTitle(_requestedMode_5__2));
						goto end_IL_00cd;
						IL_01f3:
						_u__.GetResult();
						goto IL_01fa;
						end_IL_00cd:;
					}
					catch (OperationCanceledException)
					{
						if (!javaAccountPage._disposed)
						{
							AppShell.Warning("Java 连接模式切换已取消");
						}
					}
					catch (global::System.Exception ex2)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "ui-exception", "ConnectionModeComboBox_SelectionChanged", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaAccountPage.ConnectionCenter.cs", 95);
						if (!javaAccountPage._disposed)
						{
							AppShell.Error(pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex2, "停止当前连接后重新切换模式"));
						}
					}
					finally
					{
						if (num < 0)
						{
							if (javaAccountPage._connectionModeOperation == _operation_5__3)
							{
								javaAccountPage._connectionModeOperation = null;
							}
							if (!javaAccountPage._disposed)
							{
								javaAccountPage.RefreshConnectionModeStatus();
							}
						}
					}
				}
				finally
				{
					if (num < 0 && _operation_5__3 != null)
					{
						((global::System.IDisposable)_operation_5__3).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_operation_5__3 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_operation_5__3 = null;
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
	private struct _JavaAccountPage_Loaded_d__29 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaAccountPage __4__this;

		private global::System.Threading.Tasks.Task _environmentRefresh_5__2;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaAccountPage javaAccountPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					if (num == 1)
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_00e6;
					}
					javaAccountPage.RefreshStatus();
					_environmentRefresh_5__2 = javaAccountPage.RefreshOfficialEnvironmentAsync();
					_u__ = javaAccountPage.RefreshProfileAsync(showSuccess: false).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _JavaAccountPage_Loaded_d__29>(ref _u__, ref this);
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
				_u__ = _environmentRefresh_5__2.GetAwaiter();
				if (!_u__.IsCompleted)
				{
					num = (__1__state = 1);
					__u__1 = _u__;
					__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _JavaAccountPage_Loaded_d__29>(ref _u__, ref this);
					return;
				}
				goto IL_00e6;
				IL_00e6:
				_u__.GetResult();
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_environmentRefresh_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_environmentRefresh_5__2 = null;
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
	private struct _LogoutButton_Click_d__31 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaAccountPage __4__this;

		private CancellationTokenSource _operation_5__2;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaAccountPage javaAccountPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0033;
				}
				if (javaAccountPage._operation == null)
				{
					_operation_5__2 = new CancellationTokenSource();
					goto IL_0033;
				}
				goto end_IL_0011;
				IL_0033:
				try
				{
					if (num != 0)
					{
						javaAccountPage._operation = _operation_5__2;
						javaAccountPage.SetBusy(busy: true, "正在退出 Java 会话");
					}
					try
					{
						TaskAwaiter _u__ = default;
						if (num != 0)
						{
							_u__ = javaAccountPage._client.y3QF0xhXVV(_operation_5__2.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _LogoutButton_Click_d__31>(ref _u__, ref this);
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
						javaAccountPage.RefreshStatus();
						AppShell.Success("Java 会话已退出，本地登录状态已清理");
					}
					catch (OperationCanceledException)
					{
						AppShell.Warning((javaAccountPage._client.CurrentSession == null) ? "Java 远程注销已取消，本地登录状态已清理" : "Java 退出登录已取消，当前登录状态未改变");
					}
					catch (global::System.Exception ex2)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "ui-exception", "LogoutButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaAccountPage.xaml.cs", 121);
						string text = ((javaAccountPage._client.CurrentSession == null) ? "；本地登录状态已清理" : "；当前登录状态未改变");
						AppShell.Error(pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex2, "确认登录状态后重新退出") + text);
					}
					finally
					{
						if (num < 0)
						{
							if (javaAccountPage._operation == _operation_5__2)
							{
								javaAccountPage._operation = null;
							}
							javaAccountPage.SetBusy(busy: false);
						}
					}
				}
				finally
				{
					if (num < 0 && _operation_5__2 != null)
					{
						((global::System.IDisposable)_operation_5__2).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_operation_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_operation_5__2 = null;
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
	private struct _RefreshOfficialEnvironmentAsync_d__9 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaAccountPage __4__this;

		private __c__DisplayClass9_0_5 __8__1;

		private TaskAwaiter<OfficialEnvironmentSnapshot> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaAccountPage javaAccountPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_004e;
				}
				__8__1 = (__c__DisplayClass9_0_5)new __c__DisplayClass9_0_5();
				if (!javaAccountPage._disposed && javaAccountPage._officialEnvironmentOperation == null)
				{
					__8__1.operation = new CancellationTokenSource();
					goto IL_004e;
				}
				goto end_IL_0011;
				IL_004e:
				try
				{
					if (num != 0)
					{
						javaAccountPage._officialEnvironmentOperation = __8__1.operation;
						((Control)javaAccountPage.RefreshOfficialEnvironmentButton).IsEnabled = false;
						javaAccountPage.OfficialHostStatusText.Text = "正在检测官方启动器";
						javaAccountPage.BridgeVersionStatusText.Text = "正在读取宿主管道协议与认证桥接组件版本";
					}
					try
					{
						TaskAwaiter<OfficialEnvironmentSnapshot> _u__ = default;
						if (num != 0)
						{
							_u__ = global::System.Threading.Tasks.Task.Run<OfficialEnvironmentSnapshot>((Func<OfficialEnvironmentSnapshot>)__8__1._RefreshOfficialEnvironmentAsync_b__0, __8__1.operation.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<OfficialEnvironmentSnapshot>, _RefreshOfficialEnvironmentAsync_d__9>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<OfficialEnvironmentSnapshot>);
							num = (__1__state = -1);
						}
						OfficialEnvironmentSnapshot result = _u__.GetResult();
						CancellationToken token = __8__1.operation.Token;
						token.ThrowIfCancellationRequested();
						javaAccountPage.OfficialHostStatusText.Text = result.HostStatus;
						javaAccountPage.BridgeVersionStatusText.Text = result.BridgeStatus;
					}
					catch (OperationCanceledException)
					{
						if (!javaAccountPage._disposed)
						{
							javaAccountPage.OfficialHostStatusText.Text = "官方启动器检测已取消";
							javaAccountPage.BridgeVersionStatusText.Text = "宿主管道协议与认证桥接组件尚未检测";
						}
					}
					catch (global::System.Exception)
					{
						if (!javaAccountPage._disposed)
						{
							javaAccountPage.OfficialHostStatusText.Text = "无法读取官方启动器状态";
							javaAccountPage.BridgeVersionStatusText.Text = "宿主管道协议与认证桥接组件状态未知";
						}
					}
					finally
					{
						if (num < 0)
						{
							if (javaAccountPage._officialEnvironmentOperation == __8__1.operation)
							{
								javaAccountPage._officialEnvironmentOperation = null;
							}
							if (!javaAccountPage._disposed)
							{
								((Control)javaAccountPage.RefreshOfficialEnvironmentButton).IsEnabled = true;
							}
						}
					}
				}
				finally
				{
					if (num < 0 && __8__1.operation != null)
					{
						((global::System.IDisposable)__8__1.operation).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__8__1 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__8__1 = null;
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
	private struct _RefreshOfficialEnvironmentButton_Click_d__8 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaAccountPage __4__this;

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
			JavaAccountPage javaAccountPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = javaAccountPage.RefreshOfficialEnvironmentAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshOfficialEnvironmentButton_Click_d__8>(ref _u__, ref this);
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
	private struct _RefreshProfileAsync_d__21 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaAccountPage __4__this;

		public bool showSuccess;

		private CancellationTokenSource _operation_5__2;

		private TaskAwaiter<cBjn75fTHaWsvHZL0eiQ> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaAccountPage javaAccountPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_004e;
				}
				if (!javaAccountPage._disposed && javaAccountPage._operation == null && javaAccountPage._client.CurrentSession != null)
				{
					_operation_5__2 = new CancellationTokenSource();
					goto IL_004e;
				}
				goto end_IL_0011;
				IL_004e:
				try
				{
					if (num != 0)
					{
						javaAccountPage._operation = _operation_5__2;
						javaAccountPage.SetBusy(busy: true, "正在刷新 Java 用户资料");
					}
					try
					{
						TaskAwaiter<cBjn75fTHaWsvHZL0eiQ> _u__ = default;
						if (num != 0)
						{
							_u__ = javaAccountPage._client.EENssHxa5E(_operation_5__2.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<cBjn75fTHaWsvHZL0eiQ>, _RefreshProfileAsync_d__21>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<cBjn75fTHaWsvHZL0eiQ>);
							num = (__1__state = -1);
						}
						cBjn75fTHaWsvHZL0eiQ result = _u__.GetResult();
						javaAccountPage.PresentProfile(result);
						if (showSuccess)
						{
							AppShell.Success("Java 用户资料已刷新");
						}
					}
					catch (OperationCanceledException)
					{
						if (showSuccess && !javaAccountPage._disposed)
						{
							AppShell.Warning("Java 用户资料刷新已取消");
						}
					}
					catch (global::System.Exception ex2)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "ui-exception", "RefreshProfileAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaAccountPage.Profile.cs", 84);
						if (!javaAccountPage._disposed)
						{
							string text = pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex2, "检查登录状态后重新刷新用户资料");
							javaAccountPage.ProfileStatusText.Text = "用户资料加载失败 · " + text;
							if (showSuccess)
							{
								AppShell.Error(text);
							}
						}
					}
					finally
					{
						if (num < 0)
						{
							if (javaAccountPage._operation == _operation_5__2)
							{
								javaAccountPage._operation = null;
							}
							if (!javaAccountPage._disposed)
							{
								javaAccountPage.SetBusy(busy: false);
							}
						}
					}
				}
				finally
				{
					if (num < 0 && _operation_5__2 != null)
					{
						((global::System.IDisposable)_operation_5__2).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_operation_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_operation_5__2 = null;
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
	private struct _RefreshProfileButton_Click_d__19 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaAccountPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaAccountPage javaAccountPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = javaAccountPage.RefreshProfileAsync(showSuccess: true).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshProfileButton_Click_d__19>(ref _u__, ref this);
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
	private struct _SaveNicknameButton_Click_d__20 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaAccountPage __4__this;

		private CancellationTokenSource _operation_5__2;

		private TaskAwaiter<cBjn75fTHaWsvHZL0eiQ> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaAccountPage javaAccountPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0064;
				}
				string text = default(string);
				if (javaAccountPage._operation == null)
				{
					string message = default(string);
					if (rc1ESVqrHUud9e3PiEr.m7bqm7Xjb2(javaAccountPage.NicknameBox.Text, out text, out message))
					{
						_operation_5__2 = new CancellationTokenSource();
						goto IL_0064;
					}
					AppShell.Error(message);
					((UIElement)javaAccountPage.NicknameBox).Focus((FocusState)3);
				}
				goto end_IL_0011;
				IL_0064:
					text = default;
				try
				{
					if (num != 0)
					{
						javaAccountPage._operation = _operation_5__2;
						javaAccountPage.SetBusy(busy: true, "正在修改 Java 昵称");
					}
					try
					{
						TaskAwaiter<cBjn75fTHaWsvHZL0eiQ> _u__ = default;
						if (num != 0)
						{
							_u__ = javaAccountPage._client.iWEsTEoWEO(text, _operation_5__2.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<cBjn75fTHaWsvHZL0eiQ>, _SaveNicknameButton_Click_d__20>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<cBjn75fTHaWsvHZL0eiQ>);
							num = (__1__state = -1);
						}
						cBjn75fTHaWsvHZL0eiQ result = _u__.GetResult();
						javaAccountPage.PresentProfile(result);
						AppShell.Success("Java 昵称已修改为 " + result.Nickname);
					}
					catch (OperationCanceledException)
					{
						AppShell.Warning("Java 昵称修改已取消");
					}
					catch (global::System.Exception ex2)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "ui-exception", "SaveNicknameButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaAccountPage.Profile.cs", 46);
						AppShell.Error(pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex2, "检查昵称格式和登录状态后重新保存"));
					}
					finally
					{
						if (num < 0)
						{
							if (javaAccountPage._operation == _operation_5__2)
							{
								javaAccountPage._operation = null;
							}
							javaAccountPage.SetBusy(busy: false);
						}
					}
				}
				finally
				{
					if (num < 0 && _operation_5__2 != null)
					{
						((global::System.IDisposable)_operation_5__2).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_operation_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_operation_5__2 = null;
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

	private readonly Jj84PVNAj19tCbr5gHp _connectionCoordinator;

	private CancellationTokenSource? _connectionModeOperation;

	private CancellationTokenSource? _officialEnvironmentOperation;

	private bool _accountOperationBusy;

	private bool _updatingConnectionMode;

	private string _presentedProfileUserId;

	private string _presentedNickname;

	private readonly KxOGVaFL8AQcstEY1GC _client;

	private CancellationTokenSource? _operation;

	private bool _disposed;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border OperationPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RefreshProfileButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ProfileStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Grid SessionHeaderGrid;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Grid CredentialGrid;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private RowDefinition CredentialCompactRow;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ColumnDefinition NicknameColumn;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private VisualState CompactCredentials;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private VisualState WideCredentials;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel NicknamePanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox NicknameBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button SaveNicknameButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private PasswordBox SauthBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button ClearSauthButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock HeartbeatStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private RowDefinition SessionBadgeCompactRow;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private RowDefinition SessionActionsCompactRow;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ColumnDefinition SessionBadgeColumn;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ColumnDefinition SessionLogoutColumn;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ColumnDefinition SessionAuthenticateColumn;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private VisualState CompactSessionHeader;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private VisualState WideSessionHeader;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border AccountBadge;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button LogoutButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button AuthenticateButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock AuthenticateButtonText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock AccountBadgeText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock SessionStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Grid OfficialEnvironmentGrid;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private RowDefinition ConnectionModeCompactRow;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ColumnDefinition ConnectionModeSelectorColumn;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private VisualState CompactConnectionMode;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private VisualState WideConnectionMode;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox ConnectionModeComboBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ConnectionModeStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private RowDefinition OfficialEnvironmentCompactRow;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ColumnDefinition OfficialEnvironmentSecondColumn;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private VisualState CompactOfficialEnvironment;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private VisualState WideOfficialEnvironment;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border BridgeStatusPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock BridgeVersionStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock OfficialHostStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RefreshOfficialEnvironmentButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock OperationStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CancelLoginButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[MethodImpl((MethodImplOptions)8)]
	private void InitializeConnectionCenter()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		_connectionCoordinator.Changed += new EventHandler(ConnectionCoordinator_Changed);
		RefreshConnectionModeStatus();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ConnectionCoordinator_Changed(object? sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		if (!_disposed)
		{
			if (((DependencyObject)this).DispatcherQueue.HasThreadAccess)
			{
				RefreshConnectionModeStatus();
			}
			else
			{
				((DependencyObject)this).DispatcherQueue.TryEnqueue(new DispatcherQueueHandler(RefreshConnectionModeStatus));
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ConnectionModeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ConnectionModeComboBox_SelectionChanged_d__7 connectionModeComboBox_SelectionChanged_d__ = default(_ConnectionModeComboBox_SelectionChanged_d__7);
		connectionModeComboBox_SelectionChanged_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		connectionModeComboBox_SelectionChanged_d__.__4__this = this;
		connectionModeComboBox_SelectionChanged_d__.__1__state = -1;
		connectionModeComboBox_SelectionChanged_d__.__t__builder.Start<_ConnectionModeComboBox_SelectionChanged_d__7>(ref connectionModeComboBox_SelectionChanged_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshOfficialEnvironmentButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshOfficialEnvironmentButton_Click_d__8 refreshOfficialEnvironmentButton_Click_d__ = default(_RefreshOfficialEnvironmentButton_Click_d__8);
		refreshOfficialEnvironmentButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshOfficialEnvironmentButton_Click_d__.__4__this = this;
		refreshOfficialEnvironmentButton_Click_d__.__1__state = -1;
		refreshOfficialEnvironmentButton_Click_d__.__t__builder.Start<_RefreshOfficialEnvironmentButton_Click_d__8>(ref refreshOfficialEnvironmentButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RefreshOfficialEnvironmentAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshOfficialEnvironmentAsync_d__9 refreshOfficialEnvironmentAsync_d__ = default(_RefreshOfficialEnvironmentAsync_d__9);
		refreshOfficialEnvironmentAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		refreshOfficialEnvironmentAsync_d__.__4__this = this;
		refreshOfficialEnvironmentAsync_d__.__1__state = -1;
		refreshOfficialEnvironmentAsync_d__.__t__builder.Start<_RefreshOfficialEnvironmentAsync_d__9>(ref refreshOfficialEnvironmentAsync_d__);
		return refreshOfficialEnvironmentAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SetConnectionCenterBusy(bool busy)
	{
		_accountOperationBusy = busy;
		RefreshConnectionModeStatus();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshConnectionModeStatus()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (_disposed)
		{
			return;
		}
		r9S4FZfxG0478bdNv59r selectedMode = _connectionCoordinator.SelectedMode;
		int num = (((int)selectedMode > 0) ? 1 : 0);
		if (((Selector)ConnectionModeComboBox).SelectedIndex != num)
		{
			_updatingConnectionMode = true;
			try
			{
				((Selector)ConnectionModeComboBox).SelectedIndex = num;
			}
			finally
			{
				_updatingConnectionMode = false;
			}
		}
		((Control)ConnectionModeComboBox).IsEnabled = !_accountOperationBusy && _connectionModeOperation == null;
		qC3ZV7fxXAJqu2TjY3Nc current = _connectionCoordinator.Current;
		if (current == null)
		{
			ConnectionModeStatusText.Text = "当前选择：" + ModeTitle(selectedMode) + " · 尚未建立连接";
			return;
		}
		string text = JavaConnectionStatePresentation.TitleOf(current.State);
		ConnectionModeStatusText.Text = (current.IsActive ? $"当前选择：{ModeTitle(selectedMode)} · 活动连接：{ModeTitle(current.Mode)} · {text}" : $"当前选择：{ModeTitle(selectedMode)} · 最近连接：{ModeTitle(current.Mode)} · {text}");
	}

	[MethodImpl((MethodImplOptions)8)]
	private void DisposeConnectionCenter()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		_connectionCoordinator.Changed -= new EventHandler(ConnectionCoordinator_Changed);
		TryCancel(_connectionModeOperation);
		TryCancel(_officialEnvironmentOperation);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static OfficialEnvironmentSnapshot InspectOfficialEnvironment(CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();
		D6WKW6NqlINYgWfn0kj val = c5VToDMbXerfn34rwbG.oumMfiRKjG();
		cancellationToken.ThrowIfCancellationRequested();
		bool num = string.Equals(val.StatusCode, "connection_environment_probe_failed", (StringComparison)4);
		string hostStatus = (num ? "无法读取官方启动器状态" : ((!val.LauncherDetected) ? "未检测到官方启动器" : (val.LauncherRunning ? "官方启动器正在运行 · 登录状态未验证" : "官方启动器已安装 · 当前未运行")));
		string text = $"宿主管道协议 v{val.HostPipeProtocolVersion}";
		string text2 = (string.IsNullOrWhiteSpace(val.AuthBridgeComponentVersion) ? "版本未知" : ("v" + val.AuthBridgeComponentVersion.Trim()));
		string bridgeStatus = (num ? (text + " · 认证桥接组件状态未知") : (val.BridgeInstalled ? string.Concat(new string[5]
		{
			text,
			" · 认证桥接组件 ",
			text2,
			" · ",
			val.BridgeFilesCurrent ? "文件版本匹配" : "文件需要更新"
		}) : (text + " · 认证桥接组件未安装")));
		return (OfficialEnvironmentSnapshot)new OfficialEnvironmentSnapshot(hostStatus, bridgeStatus);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void TryCancel(CancellationTokenSource? source)
	{
		try
		{
			if (source != null)
			{
				source.Cancel();
			}
		}
		catch (ObjectDisposedException)
		{
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string ModeTitle(r9S4FZfxG0478bdNv59r mode)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)mode != 0)
		{
			if ((int)mode == 1)
			{
				return "官方客户端";
			}
			return "未知模式";
		}
		return "外部客户端";
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshProfileButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshProfileButton_Click_d__19 refreshProfileButton_Click_d__ = default(_RefreshProfileButton_Click_d__19);
		refreshProfileButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshProfileButton_Click_d__.__4__this = this;
		refreshProfileButton_Click_d__.__1__state = -1;
		refreshProfileButton_Click_d__.__t__builder.Start<_RefreshProfileButton_Click_d__19>(ref refreshProfileButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void SaveNicknameButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SaveNicknameButton_Click_d__20 saveNicknameButton_Click_d__ = default(_SaveNicknameButton_Click_d__20);
		saveNicknameButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		saveNicknameButton_Click_d__.__4__this = this;
		saveNicknameButton_Click_d__.__1__state = -1;
		saveNicknameButton_Click_d__.__t__builder.Start<_SaveNicknameButton_Click_d__20>(ref saveNicknameButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RefreshProfileAsync(bool showSuccess)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshProfileAsync_d__21 refreshProfileAsync_d__ = default(_RefreshProfileAsync_d__21);
		refreshProfileAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		refreshProfileAsync_d__.__4__this = this;
		refreshProfileAsync_d__.showSuccess = showSuccess;
		refreshProfileAsync_d__.__1__state = -1;
		refreshProfileAsync_d__.__t__builder.Start<_RefreshProfileAsync_d__21>(ref refreshProfileAsync_d__);
		return refreshProfileAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshProfileStatus(GE50SffsnGnn7g3lMZHE? session)
	{
		if (session == null)
		{
			_presentedProfileUserId = string.Empty;
			_presentedNickname = string.Empty;
			ProfileStatusText.Text = "建立会话后可查询用户资料";
			NicknameBox.Text = string.Empty;
			((Control)NicknameBox).IsEnabled = false;
			((Control)RefreshProfileButton).IsEnabled = false;
			((Control)SaveNicknameButton).IsEnabled = false;
			return;
		}
		cBjn75fTHaWsvHZL0eiQ currentUserProfile = _client.CurrentUserProfile;
		if (currentUserProfile == null)
		{
			if (!string.Equals(_presentedProfileUserId, session.UserId, (StringComparison)4))
			{
				_presentedProfileUserId = session.UserId;
				_presentedNickname = string.Empty;
				NicknameBox.Text = string.Empty;
			}
			ProfileStatusText.Text = "用户资料尚未加载";
		}
		else
		{
			bool num = !string.Equals(_presentedProfileUserId, currentUserProfile.UserId, (StringComparison)4);
			bool flag = !string.Equals(_presentedNickname, currentUserProfile.Nickname, (StringComparison)4) && string.Equals(NicknameBox.Text, _presentedNickname, (StringComparison)4);
			if (num || flag)
			{
				PresentProfile(currentUserProfile);
			}
			else
			{
				ProfileStatusText.Text = BuildProfileStatus(currentUserProfile);
			}
		}
		bool isEnabled = _operation == null;
		((Control)NicknameBox).IsEnabled = isEnabled;
		((Control)RefreshProfileButton).IsEnabled = isEnabled;
		((Control)SaveNicknameButton).IsEnabled = isEnabled;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void PresentProfile(cBjn75fTHaWsvHZL0eiQ profile)
	{
		GE50SffsnGnn7g3lMZHE currentSession = _client.CurrentSession;
		if (string.Equals((currentSession != null) ? currentSession.UserId : null, profile.UserId, (StringComparison)4))
		{
			_presentedProfileUserId = profile.UserId;
			_presentedNickname = profile.Nickname;
			NicknameBox.Text = profile.Nickname;
			ProfileStatusText.Text = BuildProfileStatus(profile);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string BuildProfileStatus(cBjn75fTHaWsvHZL0eiQ profile)
	{
		string text = (string.IsNullOrWhiteSpace(profile.Account) ? profile.UserId : (profile.Account + " · " + profile.UserId));
		if (!string.IsNullOrWhiteSpace(profile.Nickname))
		{
			return "当前昵称：" + profile.Nickname + " · " + text;
		}
		return "尚未设置昵称 · " + text;
	}

	[MethodImpl((MethodImplOptions)8)]
	public JavaAccountPage()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		_connectionCoordinator = Yx0jy4NjAWxONbCjY3P.Shared;
		_presentedProfileUserId = string.Empty;
		_presentedNickname = string.Empty;
		_client = KxOGVaFL8AQcstEY1GC.Shared;
		InitializeComponent();
		InitializeConnectionCenter();
		AppShell.RegisterDisposable(this);
		AppShell.RegisterDisposable((global::System.IDisposable)_client);
		((FrameworkElement)this).Loaded += new RoutedEventHandler(JavaAccountPage_Loaded);
		_client.SessionChanged += new EventHandler(Client_SessionChanged);
		_client.UserProfileChanged += new EventHandler(Client_StatusChanged);
		_client.SessionLifecycleChanged += new EventHandler(Client_StatusChanged);
		_client.SessionHeartbeatChanged += new EventHandler(Client_StatusChanged);
		HpFsqcfPB2RknTNMlueF.Changed += new EventHandler(X19SauthSession_Changed);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void JavaAccountPage_Loaded(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_JavaAccountPage_Loaded_d__29 javaAccountPage_Loaded_d__ = default(_JavaAccountPage_Loaded_d__29);
		javaAccountPage_Loaded_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		javaAccountPage_Loaded_d__.__4__this = this;
		javaAccountPage_Loaded_d__.__1__state = -1;
		javaAccountPage_Loaded_d__.__t__builder.Start<_JavaAccountPage_Loaded_d__29>(ref javaAccountPage_Loaded_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void AuthenticateButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_AuthenticateButton_Click_d__30 authenticateButton_Click_d__ = default(_AuthenticateButton_Click_d__30);
		authenticateButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		authenticateButton_Click_d__.__4__this = this;
		authenticateButton_Click_d__.__1__state = -1;
		authenticateButton_Click_d__.__t__builder.Start<_AuthenticateButton_Click_d__30>(ref authenticateButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void LogoutButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LogoutButton_Click_d__31 logoutButton_Click_d__ = default(_LogoutButton_Click_d__31);
		logoutButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		logoutButton_Click_d__.__4__this = this;
		logoutButton_Click_d__.__1__state = -1;
		logoutButton_Click_d__.__t__builder.Start<_LogoutButton_Click_d__31>(ref logoutButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Client_SessionChanged(object? sender, EventArgs e)
	{
		EnqueueSessionRefresh();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Client_StatusChanged(object? sender, EventArgs e)
	{
		EnqueueRefresh();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void X19SauthSession_Changed(object? sender, EventArgs e)
	{
		EnqueueRefresh();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SauthBox_PasswordChanged(object sender, RoutedEventArgs e)
	{
		((Control)ClearSauthButton).IsEnabled = _operation == null && !string.IsNullOrWhiteSpace(SauthBox.Password);
		RefreshStatus();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ClearSauthButton_Click(object sender, RoutedEventArgs e)
	{
		SauthBox.Password = string.Empty;
		((UIElement)SauthBox).Focus((FocusState)3);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CancelLoginButton_Click(object sender, RoutedEventArgs e)
	{
		try
		{
			CancellationTokenSource? operation = _operation;
			if (operation != null)
			{
				operation.Cancel();
			}
			OperationStatusText.Text = "正在取消操作，请稍候";
		}
		catch (ObjectDisposedException)
		{
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void EnqueueSessionRefresh()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		if (!((DependencyObject)this).DispatcherQueue.TryEnqueue((DispatcherQueueHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] () =>
		{
			RefreshStatus();
			if (_operation == null && _client.CurrentSession != null && _client.CurrentUserProfile == null)
			{
				RefreshProfileAsync(showSuccess: false);
			}
		})))
		{
			_EnqueueSessionRefresh_g__RefreshSession_38_0();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void EnqueueRefresh()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		if (!((DependencyObject)this).DispatcherQueue.TryEnqueue(new DispatcherQueueHandler(RefreshStatus)))
		{
			RefreshStatus();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshStatus()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected I4, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		GE50SffsnGnn7g3lMZHE currentSession = _client.CurrentSession;
		pmI30FfTcQ5JMIjPyZww sessionLifecycle = _client.SessionLifecycle;
		TextBlock sessionStatusText = SessionStatusText;
		ApIkaAfTYb5LNELVYIFB state = sessionLifecycle.State;
		string text = default;
		if ((int)state - 2 > 2)
		{
			if ((int)state != 9 || string.IsNullOrWhiteSpace(sessionLifecycle.Message))
			{
				goto IL_0086;
			}
			text = "Java 会话不可用 · " + sessionLifecycle.Message;
		}
		else
		{
			if (string.IsNullOrWhiteSpace(sessionLifecycle.Message))
			{
				goto IL_0086;
			}
			text = sessionLifecycle.Message;
		}
		goto IL_00f5;
		IL_0086:
		text = ((currentSession == null) ? (string.IsNullOrWhiteSpace(HpFsqcfPB2RknTNMlueF.Current) ? "未建立会话，也未检测到当前 SAuth" : "已检测到当前 SAuth，可以建立 Java 会话") : ((!string.IsNullOrWhiteSpace(currentSession.Account)) ? ("已登录 · " + currentSession.Account + " · " + currentSession.UserId) : ("已登录 · " + currentSession.UserId)));
		goto IL_00f5;
		IL_00f5:
		sessionStatusText.Text = text;
		AuthenticateButtonText.Text = ((currentSession == null) ? "建立会话" : "安全更新会话");
		AccountBadgeText.Text = ((currentSession != null) ? "已登录" : ((string.IsNullOrWhiteSpace(SauthBox.Password) && string.IsNullOrWhiteSpace(HpFsqcfPB2RknTNMlueF.Current)) ? "未登录" : "已检测凭证"));
		pxVYf9fTZdaVsRijbk9O sessionHeartbeat = _client.SessionHeartbeat;
		sessionStatusText = HeartbeatStatusText;
		zbZSSSfTLt16J5VDK0Hs state2 = sessionHeartbeat.State;
		switch (state2 - 1)
		{
		case 0:
		{
			DateTimeOffset? lastSucceededAt = sessionHeartbeat.LastSucceededAt;
			if (lastSucceededAt.HasValue)
			{
				DateTimeOffset valueOrDefault = lastSucceededAt.GetValueOrDefault();
				text = $"会话心跳正常 · 最近刷新 {valueOrDefault.ToLocalTime():HH:mm:ss}";
			}
			else
			{
				text = "会话心跳已启动，等待首次刷新";
			}
			break;
		}
		case (w7on9HfTjvytoqRj5MX9.zbZSSSfTLt16J5VDK0Hs)1:
			text = "正在刷新 Java 会话";
			break;
		case (w7on9HfTjvytoqRj5MX9.zbZSSSfTLt16J5VDK0Hs)2:
			text = sessionHeartbeat.Message;
			break;
		case (w7on9HfTjvytoqRj5MX9.zbZSSSfTLt16J5VDK0Hs)3:
			text = "应用已挂起，会话心跳将在恢复后立即刷新";
			break;
		case (w7on9HfTjvytoqRj5MX9.zbZSSSfTLt16J5VDK0Hs)4:
			text = sessionHeartbeat.Message;
			break;
		default:
			text = "会话心跳未启动";
			break;
		}
		sessionStatusText.Text = text;
		RefreshProfileStatus(currentSession);
		((Control)LogoutButton).IsEnabled = currentSession != null && _operation == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SetBusy(bool busy, string? status = null)
	{
		((UIElement)OperationPanel).Visibility = ((!busy) ? Visibility.Visible : Visibility.Collapsed);
		if (!string.IsNullOrWhiteSpace(status))
		{
			OperationStatusText.Text = status;
		}
		((Control)AuthenticateButton).IsEnabled = !busy;
		((Control)SauthBox).IsEnabled = !busy;
		((Control)LogoutButton).IsEnabled = !busy && _client.CurrentSession != null;
		((Control)NicknameBox).IsEnabled = !busy && _client.CurrentSession != null;
		((Control)RefreshProfileButton).IsEnabled = !busy && _client.CurrentSession != null;
		((Control)SaveNicknameButton).IsEnabled = !busy && _client.CurrentSession != null;
		((Control)CancelLoginButton).IsEnabled = busy;
		((Control)ClearSauthButton).IsEnabled = !busy && !string.IsNullOrWhiteSpace(SauthBox.Password);
		SetConnectionCenterBusy(busy);
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		if (!_disposed)
		{
			_disposed = true;
			((FrameworkElement)this).Loaded -= new RoutedEventHandler(JavaAccountPage_Loaded);
			_client.SessionChanged -= new EventHandler(Client_SessionChanged);
			_client.UserProfileChanged -= new EventHandler(Client_StatusChanged);
			_client.SessionLifecycleChanged -= new EventHandler(Client_StatusChanged);
			_client.SessionHeartbeatChanged -= new EventHandler(Client_StatusChanged);
			HpFsqcfPB2RknTNMlueF.Changed -= new EventHandler(X19SauthSession_Changed);
			DisposeConnectionCenter();
			CancellationTokenSource? operation = _operation;
			if (operation != null)
			{
				operation.Cancel();
			}
			CancellationTokenSource? operation2 = _operation;
			if (operation2 != null)
			{
				operation2.Dispose();
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri val = new Uri("ms-appx:///Views/Pages/Java/JavaAccountPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected O, but got Unknown
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected O, but got Unknown
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			OperationPanel = CastExtensions.As<Border>(target);
			break;
		case 3:
			RefreshProfileButton = CastExtensions.As<Button>(target);
			((ButtonBase)RefreshProfileButton).Click += new RoutedEventHandler(RefreshProfileButton_Click);
			break;
		case 4:
			ProfileStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 5:
			SessionHeaderGrid = CastExtensions.As<Grid>(target);
			break;
		case 6:
			CredentialGrid = CastExtensions.As<Grid>(target);
			break;
		case 7:
			CredentialCompactRow = CastExtensions.As<RowDefinition>(target);
			break;
		case 8:
			NicknameColumn = CastExtensions.As<ColumnDefinition>(target);
			break;
		case 9:
			CompactCredentials = CastExtensions.As<VisualState>(target);
			break;
		case 10:
			WideCredentials = CastExtensions.As<VisualState>(target);
			break;
		case 11:
			NicknamePanel = CastExtensions.As<StackPanel>(target);
			break;
		case 12:
			NicknameBox = CastExtensions.As<TextBox>(target);
			break;
		case 13:
			SaveNicknameButton = CastExtensions.As<Button>(target);
			((ButtonBase)SaveNicknameButton).Click += new RoutedEventHandler(SaveNicknameButton_Click);
			break;
		case 14:
			SauthBox = CastExtensions.As<PasswordBox>(target);
			SauthBox.PasswordChanged += new RoutedEventHandler(SauthBox_PasswordChanged);
			break;
		case 15:
			ClearSauthButton = CastExtensions.As<Button>(target);
			((ButtonBase)ClearSauthButton).Click += new RoutedEventHandler(ClearSauthButton_Click);
			break;
		case 16:
			HeartbeatStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 17:
			SessionBadgeCompactRow = CastExtensions.As<RowDefinition>(target);
			break;
		case 18:
			SessionActionsCompactRow = CastExtensions.As<RowDefinition>(target);
			break;
		case 19:
			SessionBadgeColumn = CastExtensions.As<ColumnDefinition>(target);
			break;
		case 20:
			SessionLogoutColumn = CastExtensions.As<ColumnDefinition>(target);
			break;
		case 21:
			SessionAuthenticateColumn = CastExtensions.As<ColumnDefinition>(target);
			break;
		case 22:
			CompactSessionHeader = CastExtensions.As<VisualState>(target);
			break;
		case 23:
			WideSessionHeader = CastExtensions.As<VisualState>(target);
			break;
		case 24:
			AccountBadge = CastExtensions.As<Border>(target);
			break;
		case 25:
			LogoutButton = CastExtensions.As<Button>(target);
			((ButtonBase)LogoutButton).Click += new RoutedEventHandler(LogoutButton_Click);
			break;
		case 26:
			AuthenticateButton = CastExtensions.As<Button>(target);
			((ButtonBase)AuthenticateButton).Click += new RoutedEventHandler(AuthenticateButton_Click);
			break;
		case 27:
			AuthenticateButtonText = CastExtensions.As<TextBlock>(target);
			break;
		case 28:
			AccountBadgeText = CastExtensions.As<TextBlock>(target);
			break;
		case 29:
			SessionStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 30:
			OfficialEnvironmentGrid = CastExtensions.As<Grid>(target);
			break;
		case 31:
			ConnectionModeCompactRow = CastExtensions.As<RowDefinition>(target);
			break;
		case 32:
			ConnectionModeSelectorColumn = CastExtensions.As<ColumnDefinition>(target);
			break;
		case 33:
			CompactConnectionMode = CastExtensions.As<VisualState>(target);
			break;
		case 34:
			WideConnectionMode = CastExtensions.As<VisualState>(target);
			break;
		case 35:
			ConnectionModeComboBox = CastExtensions.As<ComboBox>(target);
			((Selector)ConnectionModeComboBox).SelectionChanged += new SelectionChangedEventHandler(ConnectionModeComboBox_SelectionChanged);
			break;
		case 36:
			ConnectionModeStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 37:
			OfficialEnvironmentCompactRow = CastExtensions.As<RowDefinition>(target);
			break;
		case 38:
			OfficialEnvironmentSecondColumn = CastExtensions.As<ColumnDefinition>(target);
			break;
		case 39:
			CompactOfficialEnvironment = CastExtensions.As<VisualState>(target);
			break;
		case 40:
			WideOfficialEnvironment = CastExtensions.As<VisualState>(target);
			break;
		case 41:
			BridgeStatusPanel = CastExtensions.As<Border>(target);
			break;
		case 42:
			BridgeVersionStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 43:
			OfficialHostStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 44:
			RefreshOfficialEnvironmentButton = CastExtensions.As<Button>(target);
			((ButtonBase)RefreshOfficialEnvironmentButton).Click += new RoutedEventHandler(RefreshOfficialEnvironmentButton_Click);
			break;
		case 45:
			OperationStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 46:
			CancelLoginButton = CastExtensions.As<Button>(target);
			((ButtonBase)CancelLoginButton).Click += new RoutedEventHandler(CancelLoginButton_Click);
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
	[CompilerGenerated]
	private void _EnqueueSessionRefresh_g__RefreshSession_38_0()
	{
		RefreshStatus();
		if (_operation == null && _client.CurrentSession != null && _client.CurrentUserProfile == null)
		{
			RefreshProfileAsync(showSuccess: false);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}
