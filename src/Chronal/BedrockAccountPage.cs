using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using ERJ416fPgD8mIlLPsat4;
using LlvQkpftcKTPAsaRP0ff;
using Mahiro_Account.UI.Controls;
using Mahiro_Account.UI.Controls.Bedrock;
using Mahiro_Account.UI.Navigation;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using MnCNHgfwhm1BlAufHdT1;
using QJ21CkfSL8itNSePE2uS;
using T3KSF1f3LrL7n0SFo0BO;
using Vl4jDMX56cFYkU2Jw1oo;
using WinRT;
using WinRT.ChronalVtableClasses;
using bUfedyCg1PBqhqIkB8r;
using cIPJnxfN1ZkniQxKuAGF;
using dEVUOofwpSJjAgLAYiLV;
using fYjvfFf1p8udxK21D6pd;
using kTwkSAfNM7j6YqFmoQDq;
using kmUWWefNudG9qmX5U4Xf;
using krYsZbfNFb7hi3LZTnl3;
using qS8vkpL43FlTMgcj0rgs;
using upxeYBfDKCIugOs5dAeA;
using wO3EWmfw6peyoPKxQt8p;
using xuiDphfbABsioOFqT68a;

namespace Mahiro_Account.Views.Pages.Bedrock;

[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_Bedrock_BedrockVersionManagementPageWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class BedrockAccountPage : Page, global::System.IDisposable, IComponentConnector
{
	private sealed class ServiceAccessCacheEntry : IEquatable<ServiceAccessCacheEntry>
	{
		[CompilerGenerated]
		private global::System.Type EqualityContract
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockAccountPage.ServiceAccessCacheEntry);
			}
		}

		[field: CompilerGenerated]
		private jvLOtufw5u5UGypgaMFF _Access_k__BackingField;
		public jvLOtufw5u5UGypgaMFF Access
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get;
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		private long _CachedAt_k__BackingField;
		public long CachedAt
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get;
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		private long _Generation_k__BackingField;
		public long Generation
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get;
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		private long _UserId_k__BackingField;
		public long UserId
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get;
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			init;
		}

		[MethodImpl((MethodImplOptions)8)]
		public ServiceAccessCacheEntry(jvLOtufw5u5UGypgaMFF Access, long CachedAt, long Generation, long UserId)
		{
			_Access_k__BackingField = Access;
			_CachedAt_k__BackingField = CachedAt;
			_Generation_k__BackingField = Generation;
			_UserId_k__BackingField = UserId;
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override string ToString()
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Expected O, but got Unknown
			StringBuilder val = new StringBuilder();
			val.Append("ServiceAccessCacheEntry");
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
			builder.Append("Access = ");
			builder.Append((object)Access);
			builder.Append(", CachedAt = ");
			builder.Append(((object)CachedAt/*cast due to .constrained prefix*/).ToString());
			builder.Append(", Generation = ");
			builder.Append(((object)Generation/*cast due to .constrained prefix*/).ToString());
			builder.Append(", UserId = ");
			builder.Append(((object)UserId/*cast due to .constrained prefix*/).ToString());
			return true;
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator !=(ServiceAccessCacheEntry? left, ServiceAccessCacheEntry? right)
		{
			return !(left == right);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator ==(ServiceAccessCacheEntry? left, ServiceAccessCacheEntry? right)
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
			return (((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<jvLOtufw5u5UGypgaMFF>.Default.GetHashCode(_Access_k__BackingField)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(_CachedAt_k__BackingField)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(_Generation_k__BackingField)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(_UserId_k__BackingField);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as ServiceAccessCacheEntry);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public bool Equals(ServiceAccessCacheEntry? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<jvLOtufw5u5UGypgaMFF>.Default.Equals(_Access_k__BackingField, other._Access_k__BackingField) && EqualityComparer<long>.Default.Equals(_CachedAt_k__BackingField, other._CachedAt_k__BackingField) && EqualityComparer<long>.Default.Equals(_Generation_k__BackingField, other._Generation_k__BackingField))
				{
					return EqualityComparer<long>.Default.Equals(_UserId_k__BackingField, other._UserId_k__BackingField);
				}
				return false;
			}
			return true;
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public ServiceAccessCacheEntry _Clone__()
		{
			return (ServiceAccessCacheEntry)new ServiceAccessCacheEntry(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private ServiceAccessCacheEntry(ServiceAccessCacheEntry original)
		{
			_Access_k__BackingField = original._Access_k__BackingField;
			_CachedAt_k__BackingField = original._CachedAt_k__BackingField;
			_Generation_k__BackingField = original._Generation_k__BackingField;
			_UserId_k__BackingField = original._UserId_k__BackingField;
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public void Deconstruct(out jvLOtufw5u5UGypgaMFF Access, out long CachedAt, out long Generation, out long UserId)
		{
			//IL_000b: Expected I8, but got O
			Access = (jvLOtufw5u5UGypgaMFF)this.Access;
			CachedAt = this.CachedAt;
			Generation = this.Generation;
			UserId = this.UserId;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass19_0_2
	{
		[StructLayout((LayoutKind)3)]
		private struct __AuthenticateButton_Click_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass19_0_2 __4__this;

			public CancellationToken cancellationToken;

			private TaskAwaiter<c7lEmkf1MoB1jUf1XEF1> __u__1;

			private TaskAwaiter __u__2;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_0136: Expected O, but got Unknown
				//IL_007b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Unknown result type (might be due to invalid IL or missing references)
				//IL_0087: Unknown result type (might be due to invalid IL or missing references)
				//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
				//IL_00af: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_003b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0045: Unknown result type (might be due to invalid IL or missing references)
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Unknown result type (might be due to invalid IL or missing references)
				//IL_0062: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass19_0_2 _c__DisplayClass19_0_ = __4__this;
				try
				{
					_ = 1;
					try
					{
						TaskAwaiter _u__ = default;
						TaskAwaiter<c7lEmkf1MoB1jUf1XEF1> _u__2 = default;
						if (num != 0)
						{
							if (num == 1)
							{
								_u__ = __u__2;
								__u__2 = default(TaskAwaiter);
								num = (__1__state = -1);
								goto IL_00fe;
							}
							_u__2 = _c__DisplayClass19_0_.__4__this._clientService.AuthenticateAsync(_c__DisplayClass19_0_.sauth, _c__DisplayClass19_0_.preferredNickname, cancellationToken).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<c7lEmkf1MoB1jUf1XEF1>, __AuthenticateButton_Click_b__0_d>(ref _u__2, ref this);
								return;
							}
						}
						else
						{
							_u__2 = __u__1;
							__u__1 = default(TaskAwaiter<c7lEmkf1MoB1jUf1XEF1>);
							num = (__1__state = -1);
						}
						c7lEmkf1MoB1jUf1XEF1 result = _u__2.GetResult();
						_u__ = _c__DisplayClass19_0_.__4__this.SaveBedrockAccountHistoryAsync(result).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __AuthenticateButton_Click_b__0_d>(ref _u__, ref this);
							return;
						}
						goto IL_00fe;
						IL_00fe:
						_u__.GetResult();
						_c__DisplayClass19_0_.__4__this.SauthBox.Password = string.Empty;
						_c__DisplayClass19_0_.__4__this.ShowAccountStatus();
						AppShell.Success("基岩移动端会话已建立");
					}
					catch (v8S9tafSfKHe7BkHpBrA val)
					{
						v8S9tafSfKHe7BkHpBrA challenge = val;
						_c__DisplayClass19_0_.__4__this.ShowSmsVerification(challenge, _c__DisplayClass19_0_.sauth, _c__DisplayClass19_0_.preferredNickname);
						_c__DisplayClass19_0_.__4__this.SauthBox.Password = string.Empty;
					}
					catch
					{
						if (_c__DisplayClass19_0_.usesPastedSauth)
						{
							_c__DisplayClass19_0_.__4__this.SauthBox.Password = string.Empty;
						}
						throw new global::System.Exception();
					}
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

		public BedrockAccountPage __4__this;

		public string sauth;

		public string preferredNickname;

		public bool usesPastedSauth;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass19_0_2()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _AuthenticateButton_Click_b__0(CancellationToken cancellationToken)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			__AuthenticateButton_Click_b__0_d _AuthenticateButton_Click_b__0_d = default(__AuthenticateButton_Click_b__0_d);
			_AuthenticateButton_Click_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_AuthenticateButton_Click_b__0_d.__4__this = this;
			_AuthenticateButton_Click_b__0_d.cancellationToken = cancellationToken;
			_AuthenticateButton_Click_b__0_d.__1__state = -1;
			_AuthenticateButton_Click_b__0_d.__t__builder.Start<__AuthenticateButton_Click_b__0_d>(ref _AuthenticateButton_Click_b__0_d);
			return _AuthenticateButton_Click_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass21_0_1
	{
		[StructLayout((LayoutKind)3)]
		private struct __AccountHistoryBrowser_LoginRequested_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass21_0_1 __4__this;

			public CancellationToken cancellationToken;

			private NhmlV4fNaN5xygQRo7dm _credential_5__2;

			private TaskAwaiter<NhmlV4fNaN5xygQRo7dm> __u__1;

			private c7lEmkf1MoB1jUf1XEF1 _session_5__3;

			private TaskAwaiter<c7lEmkf1MoB1jUf1XEF1> __u__2;

			private TaskAwaiter __u__3;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_021e: Expected O, but got Unknown
				//IL_006b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0070: Unknown result type (might be due to invalid IL or missing references)
				//IL_0077: Unknown result type (might be due to invalid IL or missing references)
				//IL_0035: Unknown result type (might be due to invalid IL or missing references)
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_00af: Unknown result type (might be due to invalid IL or missing references)
				//IL_0051: Unknown result type (might be due to invalid IL or missing references)
				//IL_0052: Unknown result type (might be due to invalid IL or missing references)
				//IL_014d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0152: Unknown result type (might be due to invalid IL or missing references)
				//IL_015a: Unknown result type (might be due to invalid IL or missing references)
				//IL_018b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0190: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_010b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0115: Unknown result type (might be due to invalid IL or missing references)
				//IL_011a: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
				//IL_0132: Unknown result type (might be due to invalid IL or missing references)
				//IL_0134: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass21_0_1 _c__DisplayClass21_0_ = __4__this;
				try
				{
					TaskAwaiter<NhmlV4fNaN5xygQRo7dm> _u__ = default;
					if (num != 0)
					{
						if ((uint)(num - 1) <= 1u)
						{
							goto IL_00e0;
						}
						_u__ = AppShell.Api.QHb07Hixaw(_c__DisplayClass21_0_.e.RecordId).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<NhmlV4fNaN5xygQRo7dm>, __AccountHistoryBrowser_LoginRequested_b__0_d>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<NhmlV4fNaN5xygQRo7dm>);
						num = (__1__state = -1);
					}
					NhmlV4fNaN5xygQRo7dm result = _u__.GetResult();
					_credential_5__2 = result;
					if (string.IsNullOrWhiteSpace(_credential_5__2.Sauth))
					{
						throw new InvalidOperationException("历史账号未保存有效的 SAuth");
					}
					_c__DisplayClass21_0_.__4__this.LoginStatusText.Text = "正在登录 " + _credential_5__2.Account.DisplayName;
					goto IL_00e0;
					IL_00e0:
					try
					{
						TaskAwaiter _u__2 = default;
						TaskAwaiter<c7lEmkf1MoB1jUf1XEF1> _u__3 = default;
						if (num != 1)
						{
							if (num == 2)
							{
								_u__2 = __u__3;
								__u__3 = default(TaskAwaiter);
								num = (__1__state = -1);
								goto IL_01df;
							}
							_u__3 = _c__DisplayClass21_0_.__4__this._clientService.AuthenticateAsync(_credential_5__2.Sauth, _c__DisplayClass21_0_.preferredNickname, cancellationToken).GetAwaiter();
							if (!_u__3.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__3;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<c7lEmkf1MoB1jUf1XEF1>, __AccountHistoryBrowser_LoginRequested_b__0_d>(ref _u__3, ref this);
								return;
							}
						}
						else
						{
							_u__3 = __u__2;
							__u__2 = default(TaskAwaiter<c7lEmkf1MoB1jUf1XEF1>);
							num = (__1__state = -1);
						}
						c7lEmkf1MoB1jUf1XEF1 result2 = _u__3.GetResult();
						_session_5__3 = result2;
						_u__2 = _c__DisplayClass21_0_.__4__this.SaveBedrockAccountHistoryAsync(_session_5__3).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 2);
							__u__3 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __AccountHistoryBrowser_LoginRequested_b__0_d>(ref _u__2, ref this);
							return;
						}
						goto IL_01df;
						IL_01df:
						_u__2.GetResult();
						_c__DisplayClass21_0_.__4__this.ShowAccountStatus();
						AppShell.Success("已使用 " + _session_5__3.Nickname + " 建立游戏会话");
						_session_5__3 = null;
					}
					catch (v8S9tafSfKHe7BkHpBrA val)
					{
						v8S9tafSfKHe7BkHpBrA challenge = val;
						_c__DisplayClass21_0_.__4__this.ShowSmsVerification(challenge, _credential_5__2.Sauth, _c__DisplayClass21_0_.preferredNickname);
					}
				}
				catch (global::System.Exception exception)
				{
					__1__state = -2;
					_credential_5__2 = null;
					__t__builder.SetException(exception);
					return;
				}
				__1__state = -2;
				_credential_5__2 = null;
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

		public BedrockAccountLoginRequestedEventArgs e;

		public BedrockAccountPage __4__this;

		public string preferredNickname;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass21_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _AccountHistoryBrowser_LoginRequested_b__0(CancellationToken cancellationToken)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			__AccountHistoryBrowser_LoginRequested_b__0_d _AccountHistoryBrowser_LoginRequested_b__0_d = default(__AccountHistoryBrowser_LoginRequested_b__0_d);
			_AccountHistoryBrowser_LoginRequested_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_AccountHistoryBrowser_LoginRequested_b__0_d.__4__this = this;
			_AccountHistoryBrowser_LoginRequested_b__0_d.cancellationToken = cancellationToken;
			_AccountHistoryBrowser_LoginRequested_b__0_d.__1__state = -1;
			_AccountHistoryBrowser_LoginRequested_b__0_d.__t__builder.Start<__AccountHistoryBrowser_LoginRequested_b__0_d>(ref _AccountHistoryBrowser_LoginRequested_b__0_d);
			return _AccountHistoryBrowser_LoginRequested_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass27_0
	{
		[StructLayout((LayoutKind)3)]
		private struct __SmsVerificationRetryRequested_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass27_0 __4__this;

			public CancellationToken cancellationToken;

			private TaskAwaiter<c7lEmkf1MoB1jUf1XEF1> __u__1;

			private TaskAwaiter __u__2;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_0152: Expected O, but got Unknown
				//IL_007b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Unknown result type (might be due to invalid IL or missing references)
				//IL_0087: Unknown result type (might be due to invalid IL or missing references)
				//IL_0113: Unknown result type (might be due to invalid IL or missing references)
				//IL_0118: Unknown result type (might be due to invalid IL or missing references)
				//IL_0120: Unknown result type (might be due to invalid IL or missing references)
				//IL_003b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0045: Unknown result type (might be due to invalid IL or missing references)
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_00db: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Unknown result type (might be due to invalid IL or missing references)
				//IL_0062: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass27_0 _c__DisplayClass27_ = __4__this;
				try
				{
					_ = 1;
					try
					{
						TaskAwaiter _u__ = default;
						TaskAwaiter<c7lEmkf1MoB1jUf1XEF1> _u__2 = default;
						if (num != 0)
						{
							if (num == 1)
							{
								_u__ = __u__2;
								__u__2 = default(TaskAwaiter);
								num = (__1__state = -1);
								goto IL_012f;
							}
							_u__2 = _c__DisplayClass27_.__4__this._clientService.AuthenticateAsync(_c__DisplayClass27_.sauth, _c__DisplayClass27_.nickname, cancellationToken).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<c7lEmkf1MoB1jUf1XEF1>, __SmsVerificationRetryRequested_b__0_d>(ref _u__2, ref this);
								return;
							}
						}
						else
						{
							_u__2 = __u__1;
							__u__1 = default(TaskAwaiter<c7lEmkf1MoB1jUf1XEF1>);
							num = (__1__state = -1);
						}
						c7lEmkf1MoB1jUf1XEF1 result = _u__2.GetResult();
						cancellationToken.ThrowIfCancellationRequested();
						if (_c__DisplayClass27_.generation == _c__DisplayClass27_.__4__this._smsVerificationGeneration)
						{
							_c__DisplayClass27_.__4__this.ClearSmsVerification();
							_u__ = _c__DisplayClass27_.__4__this.SaveBedrockAccountHistoryAsync(result).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __SmsVerificationRetryRequested_b__0_d>(ref _u__, ref this);
								return;
							}
							goto IL_012f;
						}
						goto end_IL_0016;
						IL_012f:
						_u__.GetResult();
						_c__DisplayClass27_.__4__this.ShowAccountStatus();
						AppShell.Success("安全验证已通过，基岩移动端会话已建立");
						end_IL_0016:;
					}
					catch (v8S9tafSfKHe7BkHpBrA val)
					{
						v8S9tafSfKHe7BkHpBrA challenge = val;
						cancellationToken.ThrowIfCancellationRequested();
						if (_c__DisplayClass27_.generation == _c__DisplayClass27_.__4__this._smsVerificationGeneration)
						{
							_c__DisplayClass27_.__4__this.ShowSmsVerification(challenge, _c__DisplayClass27_.sauth, _c__DisplayClass27_.nickname);
						}
					}
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

		public BedrockAccountPage __4__this;

		public string sauth;

		public string nickname;

		public long generation;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass27_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _SmsVerificationRetryRequested_b__0(CancellationToken cancellationToken)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			__SmsVerificationRetryRequested_b__0_d _SmsVerificationRetryRequested_b__0_d = default(__SmsVerificationRetryRequested_b__0_d);
			_SmsVerificationRetryRequested_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_SmsVerificationRetryRequested_b__0_d.__4__this = this;
			_SmsVerificationRetryRequested_b__0_d.cancellationToken = cancellationToken;
			_SmsVerificationRetryRequested_b__0_d.__1__state = -1;
			_SmsVerificationRetryRequested_b__0_d.__t__builder.Start<__SmsVerificationRetryRequested_b__0_d>(ref _SmsVerificationRetryRequested_b__0_d);
			return _SmsVerificationRetryRequested_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _AccountHistoryBrowser_LoginRequested_d__21 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockAccountLoginRequestedEventArgs e;

		public BedrockAccountPage __4__this;

		private __c__DisplayClass21_0_1 __8__1;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockAccountPage bedrockAccountPage = __4__this;
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
						goto IL_0149;
					}
					__8__1 = (__c__DisplayClass21_0_1)new __c__DisplayClass21_0_1();
					__8__1.e = e;
					__8__1.__4__this = __4__this;
					_u__2 = bedrockAccountPage.EnsureServiceAccessAsync(navigateWhenDenied: true).GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _AccountHistoryBrowser_LoginRequested_d__21>(ref _u__2, ref this);
						return;
					}
				}
				else
				{
					_u__2 = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
				}
				if (_u__2.GetResult() && bedrockAccountPage.TryGetPreferredNickname(out __8__1.preferredNickname))
				{
					bedrockAccountPage.ClearSmsVerification();
					_u__ = bedrockAccountPage.RunLoginOperationAsync("正在读取已保存的账号凭证", __8__1._AccountHistoryBrowser_LoginRequested_b__0).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _AccountHistoryBrowser_LoginRequested_d__21>(ref _u__, ref this);
						return;
					}
					goto IL_0149;
				}
				goto end_IL_0011;
				IL_0149:
				_u__.GetResult();
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
	private struct _AuthenticateButton_Click_d__19 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockAccountPage __4__this;

		private __c__DisplayClass19_0_2 __8__1;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockAccountPage bedrockAccountPage = __4__this;
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
						goto IL_01d3;
					}
					__8__1 = (__c__DisplayClass19_0_2)new __c__DisplayClass19_0_2();
					__8__1.__4__this = __4__this;
					_u__2 = bedrockAccountPage.EnsureServiceAccessAsync(navigateWhenDenied: true).GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _AuthenticateButton_Click_d__19>(ref _u__2, ref this);
						return;
					}
				}
				else
				{
					_u__2 = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
				}
				if (_u__2.GetResult())
				{
					string current = HpFsqcfPB2RknTNMlueF.Current;
					string password = bedrockAccountPage.SauthBox.Password;
					__8__1.usesPastedSauth = string.IsNullOrWhiteSpace(current) && !string.IsNullOrWhiteSpace(password);
					__8__1.sauth = (string.IsNullOrWhiteSpace(current) ? password : current);
					if (string.IsNullOrWhiteSpace(__8__1.sauth))
					{
						AppShell.Error("请先在转 SAuth 页面生成凭证，或直接粘贴 SAuth");
					}
					else if (bedrockAccountPage.TryGetPreferredNickname(out __8__1.preferredNickname))
					{
						bedrockAccountPage.ClearSmsVerification();
						_u__ = bedrockAccountPage.RunLoginOperationAsync(__8__1.usesPastedSauth ? "正在使用粘贴凭证建立游戏会话" : "正在使用当前工具凭证建立游戏会话", __8__1._AuthenticateButton_Click_b__0).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _AuthenticateButton_Click_d__19>(ref _u__, ref this);
							return;
						}
						goto IL_01d3;
					}
				}
				goto end_IL_0011;
				IL_01d3:
				_u__.GetResult();
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
	private struct _BedrockAccountPage_Loaded_d__12 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockAccountPage __4__this;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockAccountPage bedrockAccountPage = __4__this;
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
						goto IL_0107;
					}
					_u__2 = bedrockAccountPage.EnsureServiceAccessAsync(navigateWhenDenied: true).GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _BedrockAccountPage_Loaded_d__12>(ref _u__2, ref this);
						return;
					}
				}
				else
				{
					_u__2 = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
				}
				if (_u__2.GetResult())
				{
					bedrockAccountPage.RefreshAndroidTouchStatus();
					bedrockAccountPage.ShowAccountStatus();
					bedrockAccountPage.SetOperationState(isRunning: false, string.Empty);
					_u__ = bedrockAccountPage.AccountHistoryBrowser.LoadAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _BedrockAccountPage_Loaded_d__12>(ref _u__, ref this);
						return;
					}
					goto IL_0107;
				}
				goto end_IL_0011;
				IL_0107:
				_u__.GetResult();
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
	private struct _RunLoginOperationAsync_d__32 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockAccountPage __4__this;

		public string status;

		public Func<CancellationToken, global::System.Threading.Tasks.Task> operation;

		private CancellationTokenSource _cancellation_5__2;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockAccountPage bedrockAccountPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0033;
				}
				if (bedrockAccountPage._operationCancellation == null)
				{
					_cancellation_5__2 = new CancellationTokenSource();
					goto IL_0033;
				}
				goto end_IL_0011;
				IL_0033:
				try
				{
					if (num != 0)
					{
						bedrockAccountPage._operationCancellation = _cancellation_5__2;
						bedrockAccountPage.SetOperationState(isRunning: true, status);
					}
					try
					{
						TaskAwaiter _u__ = default;
						if (num != 0)
						{
							_u__ = operation.Invoke(_cancellation_5__2.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RunLoginOperationAsync_d__32>(ref _u__, ref this);
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
					catch (OperationCanceledException)
					{
						AppShell.Warning("建立游戏会话已取消");
					}
					catch (global::System.Exception exception)
					{
						AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "RunLoginOperationAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockAccountPage.xaml.cs", 402));
					}
					finally
					{
						if (num < 0)
						{
							if (bedrockAccountPage._operationCancellation == _cancellation_5__2)
							{
								bedrockAccountPage._operationCancellation = null;
							}
							bedrockAccountPage.SetOperationState(isRunning: false, string.Empty);
						}
					}
				}
				finally
				{
					if (num < 0 && _cancellation_5__2 != null)
					{
						((global::System.IDisposable)_cancellation_5__2).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				_cancellation_5__2 = null;
				__t__builder.SetException(exception2);
				return;
			}
			__1__state = -2;
			_cancellation_5__2 = null;
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
	private struct _SaveBedrockAccountHistoryAsync_d__30 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public c7lEmkf1MoB1jUf1XEF1 session;

		public BedrockAccountPage __4__this;

		private ruUnbDfNNrkVuCWWL1FB _request_5__2;

		private rNa7MJfNpo3qmyG1he2O _response_5__3;

		private int __7__wrap3;

		private UfjqWXfw4LbmaQBvftfE _ex_5__5;

		private TaskAwaiter<rNa7MJfNpo3qmyG1he2O> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Expected O, but got Unknown
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockAccountPage bedrockAccountPage = __4__this;
			try
			{
				_ = 1;
				try
				{
					TaskAwaiter<rNa7MJfNpo3qmyG1he2O> _u__ = default;
					if (num != 0)
					{
						if (num == 1)
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<rNa7MJfNpo3qmyG1he2O>);
							num = (__1__state = -1);
							goto IL_01ee;
						}
						_request_5__2 = new ruUnbDfNNrkVuCWWL1FB
						{
							GameUserId = session.UserId,
							Account = session.Account,
							Nickname = session.Nickname,
							Profile = session.Profile,
							Sauth = session.SauthWrapper
						};
						__7__wrap3 = 0;
					}
					rNa7MJfNpo3qmyG1he2O result;
					ruUnbDfNNrkVuCWWL1FB __requestLocal = _request_5__2;
					UfjqWXfw4LbmaQBvftfE __exLocal = default(UfjqWXfw4LbmaQBvftfE);
					try
					{
						if (num != 0)
						{
							_u__ = AppShell.Api.aN60mNYHDL(_request_5__2).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<rNa7MJfNpo3qmyG1he2O>, _SaveBedrockAccountHistoryAsync_d__30>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<rNa7MJfNpo3qmyG1he2O>);
							num = (__1__state = -1);
						}
						result = _u__.GetResult();
						_response_5__3 = result;
					}
					catch (global::System.Exception obj) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						object obj2 = ((obj is UfjqWXfw4LbmaQBvftfE) ? obj : null);
						global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
						if (obj2 == null)
						{
							result2 = 0;
						}
						else
						{
							__exLocal = (UfjqWXfw4LbmaQBvftfE)obj2;
							result2 = (IsLegacyProfileValidationFailure(__exLocal, __requestLocal) ? 1 : 0);
						}
						return (byte)result2 != 0;
					}).Invoke())
					{
						__7__wrap3 = 1;
					}
					int num2 = __7__wrap3;
					if (num2 == 1)
					{
						_ex_5__5 = __exLocal;
						cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)_ex_5__5, "ui-exception", "SaveBedrockAccountHistoryAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockAccountPage.xaml.cs", 357);
						_request_5__2.Profile = null;
						_u__ = AppShell.Api.aN60mNYHDL(_request_5__2).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<rNa7MJfNpo3qmyG1he2O>, _SaveBedrockAccountHistoryAsync_d__30>(ref _u__, ref this);
							return;
						}
						goto IL_01ee;
					}
					goto IL_01fd;
					IL_01ee:
					result = _u__.GetResult();
					_response_5__3 = result;
					goto IL_01fd;
					IL_01fd:
					_ex_5__5 = null;
					GYf3CQfNxVcknhl8gDAn account = _response_5__3.Account;
					if (account.Profile == null)
					{
						y6sHXkf3fhIBq5aFx6SX val = (account.Profile = session.Profile);
					}
					bedrockAccountPage.AccountHistoryBrowser.Upsert(_response_5__3.Account);
					_request_5__2 = null;
					_response_5__3 = null;
				}
				catch (global::System.Exception exception)
				{
					AppShell.Warning("游戏会话已建立，但历史账号保存失败：" + AppShell.GetExceptionDisplayMessage(exception, "SaveBedrockAccountHistoryAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockAccountPage.xaml.cs", 368));
				}
			}
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				__t__builder.SetException(exception2);
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
	private struct _SmsVerificationRetryRequested_d__27 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockAccountPage __4__this;

		private __c__DisplayClass27_0 __8__1;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockAccountPage bedrockAccountPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				bool flag;
				TaskAwaiter<bool> _u__2 = default;
				if (num != 0)
				{
					if (num == 1)
					{
						_u__ = __u__2;
						__u__2 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_0182;
					}
					__8__1 = (__c__DisplayClass27_0)new __c__DisplayClass27_0();
					__8__1.__4__this = __4__this;
					__8__1.sauth = bedrockAccountPage._pendingVerificationSauth;
					__8__1.nickname = bedrockAccountPage._pendingVerificationNickname;
					__8__1.generation = bedrockAccountPage._smsVerificationGeneration;
					flag = string.IsNullOrWhiteSpace(__8__1.sauth);
					if (flag)
					{
						goto IL_00f1;
					}
					_u__2 = bedrockAccountPage.EnsureServiceAccessAsync(navigateWhenDenied: true).GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _SmsVerificationRetryRequested_d__27>(ref _u__2, ref this);
						return;
					}
				}
				else
				{
					_u__2 = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
				}
				flag = !_u__2.GetResult();
				goto IL_00f1;
				IL_0182:
				_u__.GetResult();
				goto end_IL_0011;
				IL_00f1:
				if (!flag && __8__1.generation == bedrockAccountPage._smsVerificationGeneration)
				{
					_u__ = bedrockAccountPage.RunLoginOperationAsync("正在复查安全验证并建立游戏会话", __8__1._SmsVerificationRetryRequested_b__0).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _SmsVerificationRetryRequested_d__27>(ref _u__, ref this);
						return;
					}
					goto IL_0182;
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

	private static readonly TimeSpan ServiceAccessCacheLifetime;

	private const int MaxServiceAccessGenerationRetries = 2;

	private readonly da18CdX55laNMRKtM3p0 _clientService;

	private readonly SemaphoreSlim _serviceAccessGate;

	private CancellationTokenSource? _operationCancellation;

	private ServiceAccessCacheEntry? _serviceAccessCache;

	private string? _pendingVerificationSauth;

	private string? _pendingVerificationNickname;

	private long _smsVerificationGeneration;

	private long _serviceAccessGeneration;

	private bool _disposed;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border LoginOperationPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private SmsVerificationView SmsVerificationPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private BedrockAccountHistoryView AccountHistoryBrowser;

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
	private TextBox CustomNicknameBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox RandomNicknameCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private PasswordBox SauthBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button ClearSauthButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock AndroidTouchStatusTitle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock AndroidTouchStatusDescription;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button LogoutButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button AuthenticateButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock AccountBadgeText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock AccountStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock AccountProfileText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Image AccountFrameImage;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Image AccountAvatarImage;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressRing LoginProgressRing;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock LoginStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CancelLoginButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock SubscriptionStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock SubscriptionExpiryText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[MethodImpl((MethodImplOptions)8)]
	public BedrockAccountPage()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		_clientService = da18CdX55laNMRKtM3p0.Shared;
		_serviceAccessGate = new SemaphoreSlim(1, 1);
		InitializeComponent();
		AppShell.RegisterDisposable(this);
		AppShell.RegisterDisposable((global::System.IDisposable)_clientService);
		((FrameworkElement)this).Loaded += new RoutedEventHandler(BedrockAccountPage_Loaded);
		AccountHistoryBrowser.LoginRequested += AccountHistoryBrowser_LoginRequested;
		AppShell.SessionCleared += new EventHandler(OnSessionCleared);
		AppShell.Api.AuthenticationUpdated += new EventHandler(OnAuthenticationUpdated);
		HpFsqcfPB2RknTNMlueF.Changed += new EventHandler(X19SauthSession_Changed);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void BedrockAccountPage_Loaded(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_BedrockAccountPage_Loaded_d__12 bedrockAccountPage_Loaded_d__ = default(_BedrockAccountPage_Loaded_d__12);
		bedrockAccountPage_Loaded_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		bedrockAccountPage_Loaded_d__.__4__this = this;
		bedrockAccountPage_Loaded_d__.__1__state = -1;
		bedrockAccountPage_Loaded_d__.__t__builder.Start<_BedrockAccountPage_Loaded_d__12>(ref bedrockAccountPage_Loaded_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void AndroidTouchSettingsButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		AppShell.Navigate(typeof(global::Mahiro_Account.Views.Pages.ToolboxPage));
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshAndroidTouchStatus()
	{
		AndroidTouchStatusTitle.Text = XmZPH6fDdBx0Jhg6ql8p.i3dfD6hQKQA();
		AndroidTouchStatusDescription.Text = XmZPH6fDdBx0Jhg6ql8p.ServerAndroidTouchDescription;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSessionCleared(object? sender, EventArgs e)
	{
		InvalidateServiceAccessCache();
		CancellationTokenSource? operationCancellation = _operationCancellation;
		if (operationCancellation != null)
		{
			operationCancellation.Cancel();
		}
		ClearSmsVerification();
		SauthBox.Password = string.Empty;
		((ToggleButton)RandomNicknameCheckBox).IsChecked = true;
		CustomNicknameBox.Text = string.Empty;
		ShowAccountStatus();
		AccountHistoryBrowser.Clear();
		SetOperationState(isRunning: false, string.Empty);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnAuthenticationUpdated(object? sender, EventArgs e)
	{
		InvalidateServiceAccessCache();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void InvalidateServiceAccessCache()
	{
		Interlocked.Increment(ref _serviceAccessGeneration);
		Volatile.Write<ServiceAccessCacheEntry>(ref _serviceAccessCache, (ServiceAccessCacheEntry)null);
		BedrockAccessGuard.Invalidate();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void X19SauthSession_Changed(object? sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		if (!((DependencyObject)this).DispatcherQueue.TryEnqueue((DispatcherQueueHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] () =>
		{
			ClearSmsVerification();
			SauthBox.Password = string.Empty;
			ShowAccountStatus();
		})))
		{
			_X19SauthSession_Changed_g__Refresh_18_0();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void AuthenticateButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_AuthenticateButton_Click_d__19 authenticateButton_Click_d__ = default(_AuthenticateButton_Click_d__19);
		authenticateButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		authenticateButton_Click_d__.__4__this = this;
		authenticateButton_Click_d__.__1__state = -1;
		authenticateButton_Click_d__.__t__builder.Start<_AuthenticateButton_Click_d__19>(ref authenticateButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void LogoutButton_Click(object sender, RoutedEventArgs e)
	{
		if (_operationCancellation != null || _clientService.CurrentSession == null)
		{
			return;
		}
		try
		{
			_clientService.XxcX6CRAHnY();
			ClearSmsVerification();
			ShowAccountStatus();
			SetOperationState(isRunning: false, string.Empty);
			AppShell.Success("基岩移动端会话已退出");
		}
		catch (global::System.Exception exception)
		{
			AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "LogoutButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockAccountPage.xaml.cs", 174));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void AccountHistoryBrowser_LoginRequested(object? sender, BedrockAccountLoginRequestedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_AccountHistoryBrowser_LoginRequested_d__21 accountHistoryBrowser_LoginRequested_d__ = default(_AccountHistoryBrowser_LoginRequested_d__21);
		accountHistoryBrowser_LoginRequested_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		accountHistoryBrowser_LoginRequested_d__.__4__this = this;
		accountHistoryBrowser_LoginRequested_d__.e = e;
		accountHistoryBrowser_LoginRequested_d__.__1__state = -1;
		accountHistoryBrowser_LoginRequested_d__.__t__builder.Start<_AccountHistoryBrowser_LoginRequested_d__21>(ref accountHistoryBrowser_LoginRequested_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SauthBox_PasswordChanged(object sender, RoutedEventArgs e)
	{
		((Control)ClearSauthButton).IsEnabled = !string.IsNullOrWhiteSpace(SauthBox.Password) && _operationCancellation == null;
		ShowAccountStatus();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ClearSauthButton_Click(object sender, RoutedEventArgs e)
	{
		SauthBox.Password = string.Empty;
		ShowAccountStatus();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ShowSmsVerification(v8S9tafSfKHe7BkHpBrA challenge, string sauth, string? preferredNickname)
	{
		_pendingVerificationSauth = sauth;
		_pendingVerificationNickname = preferredNickname;
		SmsVerificationPanel.Show(challenge.SmsContent, challenge.SmsNumber, challenge.BackupNumber, "请使用任意手机号发送下方短信，完成后点击重试登录。验证成功前不会建立游戏会话。");
		AppShell.Warning("需要上行短信安全验证，请按页面提示完成");
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ClearSmsVerification()
	{
		_smsVerificationGeneration++;
		_pendingVerificationSauth = null;
		_pendingVerificationNickname = null;
		SmsVerificationPanel.Clear();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SmsVerificationCancelRequested(object? sender, EventArgs e)
	{
		if (_pendingVerificationSauth != null)
		{
			CancellationTokenSource? operationCancellation = _operationCancellation;
			if (operationCancellation != null)
			{
				operationCancellation.Cancel();
			}
			ClearSmsVerification();
			ShowAccountStatus();
			AppShell.Info("已取消上行短信验证");
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void SmsVerificationRetryRequested(object? sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SmsVerificationRetryRequested_d__27 smsVerificationRetryRequested_d__ = default(_SmsVerificationRetryRequested_d__27);
		smsVerificationRetryRequested_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		smsVerificationRetryRequested_d__.__4__this = this;
		smsVerificationRetryRequested_d__.__1__state = -1;
		smsVerificationRetryRequested_d__.__t__builder.Start<_SmsVerificationRetryRequested_d__27>(ref smsVerificationRetryRequested_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RandomNicknameCheckBox_Changed(object sender, RoutedEventArgs e)
	{
		if (CustomNicknameBox != null)
		{
			bool valueOrDefault = ((ToggleButton)RandomNicknameCheckBox).IsChecked == true;
			((Control)CustomNicknameBox).IsEnabled = !valueOrDefault && _operationCancellation == null;
			if (!valueOrDefault)
			{
				((UIElement)CustomNicknameBox).Focus((FocusState)3);
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private bool TryGetPreferredNickname(out string? preferredNickname)
	{
		//IL_0006: Expected I8, but got O
		//IL_003c: Expected I8, but got O
		preferredNickname = default;
		if (((ToggleButton)RandomNicknameCheckBox).IsChecked == true)
		{
			return true;
		}
		string text = default(string);
		string message = default(string);
		if (E3ftvZfb7bQT2i1vZYRZ.h1rfbIdnD6g(CustomNicknameBox.Text, out text, out message))
		{
			preferredNickname = default;
			return true;
		}
		AppShell.Error(message);
		((UIElement)CustomNicknameBox).Focus((FocusState)3);
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task SaveBedrockAccountHistoryAsync(c7lEmkf1MoB1jUf1XEF1 session)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SaveBedrockAccountHistoryAsync_d__30 saveBedrockAccountHistoryAsync_d__ = default(_SaveBedrockAccountHistoryAsync_d__30);
		saveBedrockAccountHistoryAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		saveBedrockAccountHistoryAsync_d__.__4__this = this;
		saveBedrockAccountHistoryAsync_d__.session = session;
		saveBedrockAccountHistoryAsync_d__.__1__state = -1;
		saveBedrockAccountHistoryAsync_d__.__t__builder.Start<_SaveBedrockAccountHistoryAsync_d__30>(ref saveBedrockAccountHistoryAsync_d__);
		return saveBedrockAccountHistoryAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool IsLegacyProfileValidationFailure(UfjqWXfw4LbmaQBvftfE exception, ruUnbDfNNrkVuCWWL1FB request)
	{
		if (request.Profile != null && exception.Status == 400 && string.IsNullOrWhiteSpace(exception.Code))
		{
			return string.Equals(((global::System.Exception)(object)exception).Message, "请求参数无效", (StringComparison)4);
		}
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RunLoginOperationAsync(string status, Func<CancellationToken, global::System.Threading.Tasks.Task> operation)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RunLoginOperationAsync_d__32 runLoginOperationAsync_d__ = default(_RunLoginOperationAsync_d__32);
		runLoginOperationAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		runLoginOperationAsync_d__.__4__this = this;
		runLoginOperationAsync_d__.status = status;
		runLoginOperationAsync_d__.operation = operation;
		runLoginOperationAsync_d__.__1__state = -1;
		runLoginOperationAsync_d__.__t__builder.Start<_RunLoginOperationAsync_d__32>(ref runLoginOperationAsync_d__);
		return runLoginOperationAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CancelLoginButton_Click(object sender, RoutedEventArgs e)
	{
		CancellationTokenSource? operationCancellation = _operationCancellation;
		if (operationCancellation != null)
		{
			operationCancellation.Cancel();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SetOperationState(bool isRunning, string status)
	{
		((UIElement)LoginOperationPanel).Visibility = ((!isRunning) ? Visibility.Visible : Visibility.Collapsed);
		LoginProgressRing.IsActive = isRunning;
		LoginStatusText.Text = status;
		((Control)CancelLoginButton).IsEnabled = isRunning;
		((Control)AuthenticateButton).IsEnabled = !isRunning;
		((Control)LogoutButton).IsEnabled = !isRunning && _clientService.CurrentSession != null;
		((Control)SauthBox).IsEnabled = !isRunning;
		((Control)ClearSauthButton).IsEnabled = !isRunning && !string.IsNullOrWhiteSpace(SauthBox.Password);
		((Control)RandomNicknameCheckBox).IsEnabled = !isRunning;
		((Control)CustomNicknameBox).IsEnabled = !isRunning && ((ToggleButton)RandomNicknameCheckBox).IsChecked != true;
		AccountHistoryBrowser.SetOperationRunning(isRunning);
		SmsVerificationPanel.SetOperationRunning(isRunning);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ShowAccountStatus()
	{
		c7lEmkf1MoB1jUf1XEF1 currentSession = _clientService.CurrentSession;
		if (currentSession != null)
		{
			AccountStatusText.Text = (string.IsNullOrWhiteSpace(currentSession.Account) ? currentSession.Nickname : (currentSession.Nickname + " · " + currentSession.Account));
			AccountBadgeText.Text = "已登录";
			ShowProfile(currentSession.Profile);
			return;
		}
		ShowProfile(null);
		if (!string.IsNullOrWhiteSpace(SauthBox.Password))
		{
			AccountStatusText.Text = "将使用输入框中粘贴的凭证";
			AccountBadgeText.Text = "已粘贴";
		}
		else
		{
			AccountStatusText.Text = (string.IsNullOrWhiteSpace(HpFsqcfPB2RknTNMlueF.Current) ? "未建立游戏会话" : "已检测到当前工具登录凭证");
			AccountBadgeText.Text = "未登录";
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ShowProfile(y6sHXkf3fhIBq5aFx6SX? profile)
	{
		AccountAvatarImage.Source = (ImageSource)(object)BedrockAccountHistoryItemViewModel.CreateImageSource((profile != null) ? profile.AvatarUrl : null);
		AccountFrameImage.Source = (ImageSource)(object)BedrockAccountHistoryItemViewModel.CreateImageSource((profile != null) ? profile.FrameUrl : null);
		((UIElement)AccountFrameImage).Visibility = ((AccountFrameImage.Source == null) ? Visibility.Visible : Visibility.Collapsed);
		if (profile == null)
		{
			AccountProfileText.Text = string.Empty;
			((UIElement)AccountProfileText).Visibility = (Visibility)1;
			return;
		}
		string text = ((profile.VipLevel > 0) ? $" · VIP {profile.VipLevel}" : string.Empty);
		string text2 = ((profile.ExperienceNeeded > 0) ? $" · 经验 {profile.Experience}/{profile.ExperienceNeeded}" : string.Empty);
		string text3 = (string.IsNullOrWhiteSpace(profile.Signature) ? string.Empty : (" · " + profile.Signature));
		AccountProfileText.Text = $"Lv.{profile.Level}{text}{text2}{text3}";
		((UIElement)AccountProfileText).Visibility = (Visibility)0;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private async global::System.Threading.Tasks.Task<bool> EnsureServiceAccessAsync(bool navigateWhenDenied, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		UfjqWXfw4LbmaQBvftfE val2 = default(UfjqWXfw4LbmaQBvftfE);
		try
		{
			jvLOtufw5u5UGypgaMFF val = await GetServiceAccessSingleFlightAsync(cancellationToken);
			SubscriptionStatusText.Text = val.StatusText;
			SubscriptionExpiryText.Text = (val.ExpiresAt.HasValue ? ("到期 " + val.ExpiryText + "，剩余 " + val.RemainingText) : val.SummaryText);
			if (val.Allowed)
			{
				BedrockAccessGuard.RecordAllowed(val);
				return true;
			}
			BedrockAccessGuard.Invalidate();
			if (navigateWhenDenied)
			{
				AppShell.Navigate(NavigationRegistry.MainPageType((await AppShell.ConfirmAsync("需要订阅基岩版启动服务", "你的时长已到期或未订阅，请前往服务订阅购买服务", "前往服务订阅")) ? "services" : "home"));
			}
			return false;
		}
		catch (OperationCanceledException)
		{
			throw new global::System.Exception();
		}
		catch (global::System.Exception obj) when (((Func<bool>)delegate
		{
			// Could not convert BlockContainer to single expression
			object obj2 = ((obj is UfjqWXfw4LbmaQBvftfE) ? obj : null);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			if (obj2 == null)
			{
				result = 0;
			}
			else
			{
				val2 = (UfjqWXfw4LbmaQBvftfE)obj2;
				result = ((val2.Code == "SERVICE_SUBSCRIPTION_REQUIRED") ? 1 : 0);
			}
			return (byte)result != 0;
		}).Invoke())
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val2, "ui-exception", "EnsureServiceAccessAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockAccountPage.xaml.cs", 518);
			cIFpEPfwMuX4GIUav4ts val3 = val2.O4ufwUZNxYR<cIFpEPfwMuX4GIUav4ts>("access");
			SubscriptionStatusText.Text = ((val3 != null) ? val3.StatusText : null) ?? "未订阅";
			SubscriptionExpiryText.Text = ((val3 != null && val3.ExpiresAt.HasValue) ? ("原到期时间 " + val3.ExpiryText) : "尚未购买服务时长");
			if (navigateWhenDenied)
			{
				AppShell.Navigate(NavigationRegistry.MainPageType((await AppShell.ConfirmAsync("需要订阅基岩版启动服务", "你的时长已到期或未订阅，请前往服务订阅购买服务", "前往服务订阅")) ? "services" : "home"));
			}
			return false;
		}
		catch (global::System.Exception exception)
		{
			SubscriptionStatusText.Text = "校验失败";
			SubscriptionExpiryText.Text = "当前无法确认服务权益";
			AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "EnsureServiceAccessAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockAccountPage.xaml.cs", 538));
			return false;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private async global::System.Threading.Tasks.Task<jvLOtufw5u5UGypgaMFF> GetServiceAccessSingleFlightAsync(CancellationToken cancellationToken)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		await _serviceAccessGate.WaitAsync(cancellationToken);
		try
		{
			for (int i = 0; i < 2; i++)
			{
				cancellationToken.ThrowIfCancellationRequested();
				long num = Volatile.Read(ref _serviceAccessGeneration);
				dN4xMCftS2WHJlRJeqrU currentUser = AppShell.Api.CurrentUser;
				long num2 = ((currentUser != null) ? currentUser.Id : 0);
				long tickCount = Environment.TickCount64;
				ServiceAccessCacheEntry serviceAccessCacheEntry = Volatile.Read<ServiceAccessCacheEntry>(ref _serviceAccessCache);
				if ((object)serviceAccessCacheEntry != null && serviceAccessCacheEntry.Generation == num && serviceAccessCacheEntry.UserId == num2 && serviceAccessCacheEntry.Access.Allowed && (double)(tickCount - serviceAccessCacheEntry.CachedAt) <= ServiceAccessCacheLifetime.TotalMilliseconds && (!serviceAccessCacheEntry.Access.ExpiresAt.HasValue || serviceAccessCacheEntry.Access.ExpiresAt.Value.ToUniversalTime() > global::System.DateTime.UtcNow))
				{
					return serviceAccessCacheEntry.Access;
				}
				jvLOtufw5u5UGypgaMFF val = await AppShell.Api.ucf8G5snLP("bedrock_launch", cancellationToken);
				cancellationToken.ThrowIfCancellationRequested();
				if (num == Volatile.Read(ref _serviceAccessGeneration))
				{
					dN4xMCftS2WHJlRJeqrU currentUser2 = AppShell.Api.CurrentUser;
					if (num2 == ((currentUser2 != null) ? currentUser2.Id : 0))
					{
						Volatile.Write<ServiceAccessCacheEntry>(ref _serviceAccessCache, (ServiceAccessCacheEntry)(val.Allowed ? new ServiceAccessCacheEntry(val, Environment.TickCount64, num, num2) : null));
						return val;
					}
				}
			}
			throw new InvalidOperationException("登录状态在权益校验期间发生变化，请重新点击");
		}
		finally
		{
			_serviceAccessGate.Release();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		if (!_disposed)
		{
			_disposed = true;
			_pendingVerificationSauth = null;
			_pendingVerificationNickname = null;
			((FrameworkElement)this).Loaded -= new RoutedEventHandler(BedrockAccountPage_Loaded);
			AccountHistoryBrowser.LoginRequested -= AccountHistoryBrowser_LoginRequested;
			AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
			AppShell.Api.AuthenticationUpdated -= new EventHandler(OnAuthenticationUpdated);
			HpFsqcfPB2RknTNMlueF.Changed -= new EventHandler(X19SauthSession_Changed);
			CancellationTokenSource? operationCancellation = _operationCancellation;
			if (operationCancellation != null)
			{
				operationCancellation.Cancel();
			}
			CancellationTokenSource? operationCancellation2 = _operationCancellation;
			if (operationCancellation2 != null)
			{
				operationCancellation2.Dispose();
			}
			_serviceAccessGate.Dispose();
		}
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
			Uri val = new Uri("ms-appx:///Views/Pages/Bedrock/BedrockAccountPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			LoginOperationPanel = CastExtensions.As<Border>(target);
			break;
		case 3:
			SmsVerificationPanel = CastExtensions.As<SmsVerificationView>(target);
			SmsVerificationPanel.RetryRequested += new EventHandler(SmsVerificationRetryRequested);
			SmsVerificationPanel.CancelRequested += new EventHandler(SmsVerificationCancelRequested);
			break;
		case 4:
			AccountHistoryBrowser = CastExtensions.As<BedrockAccountHistoryView>(target);
			break;
		case 5:
			CredentialGrid = CastExtensions.As<Grid>(target);
			break;
		case 6:
			CredentialCompactRow = CastExtensions.As<RowDefinition>(target);
			break;
		case 7:
			NicknameColumn = CastExtensions.As<ColumnDefinition>(target);
			break;
		case 8:
			CompactCredentials = CastExtensions.As<VisualState>(target);
			break;
		case 9:
			WideCredentials = CastExtensions.As<VisualState>(target);
			break;
		case 10:
			NicknamePanel = CastExtensions.As<StackPanel>(target);
			break;
		case 11:
			CustomNicknameBox = CastExtensions.As<TextBox>(target);
			break;
		case 12:
			RandomNicknameCheckBox = CastExtensions.As<CheckBox>(target);
			((ToggleButton)RandomNicknameCheckBox).Checked += new RoutedEventHandler(RandomNicknameCheckBox_Changed);
			((ToggleButton)RandomNicknameCheckBox).Unchecked += new RoutedEventHandler(RandomNicknameCheckBox_Changed);
			break;
		case 13:
			SauthBox = CastExtensions.As<PasswordBox>(target);
			SauthBox.PasswordChanged += new RoutedEventHandler(SauthBox_PasswordChanged);
			break;
		case 14:
			ClearSauthButton = CastExtensions.As<Button>(target);
			((ButtonBase)ClearSauthButton).Click += new RoutedEventHandler(ClearSauthButton_Click);
			break;
		case 15:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(AndroidTouchSettingsButton_Click);
			break;
		case 16:
			AndroidTouchStatusTitle = CastExtensions.As<TextBlock>(target);
			break;
		case 17:
			AndroidTouchStatusDescription = CastExtensions.As<TextBlock>(target);
			break;
		case 18:
			LogoutButton = CastExtensions.As<Button>(target);
			((ButtonBase)LogoutButton).Click += new RoutedEventHandler(LogoutButton_Click);
			break;
		case 19:
			AuthenticateButton = CastExtensions.As<Button>(target);
			((ButtonBase)AuthenticateButton).Click += new RoutedEventHandler(AuthenticateButton_Click);
			break;
		case 20:
			AccountBadgeText = CastExtensions.As<TextBlock>(target);
			break;
		case 21:
			AccountStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 22:
			AccountProfileText = CastExtensions.As<TextBlock>(target);
			break;
		case 23:
			AccountFrameImage = CastExtensions.As<Image>(target);
			break;
		case 24:
			AccountAvatarImage = CastExtensions.As<Image>(target);
			break;
		case 25:
			LoginProgressRing = CastExtensions.As<ProgressRing>(target);
			break;
		case 26:
			LoginStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 27:
			CancelLoginButton = CastExtensions.As<Button>(target);
			((ButtonBase)CancelLoginButton).Click += new RoutedEventHandler(CancelLoginButton_Click);
			break;
		case 28:
			SubscriptionStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 29:
			SubscriptionExpiryText = CastExtensions.As<TextBlock>(target);
			break;
		}
		_contentLoaded = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	static BedrockAccountPage()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		ServiceAccessCacheLifetime = TimeSpan.FromSeconds(15.0);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void _X19SauthSession_Changed_g__Refresh_18_0()
	{
		ClearSmsVerification();
		SauthBox.Password = string.Empty;
		ShowAccountStatus();
	}
}
