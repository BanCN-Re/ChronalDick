using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using LlvQkpftcKTPAsaRP0ff;
using MnCNHgfwhm1BlAufHdT1;
using PA3jn5fOY4t0f5M1SwAK;
using WMO32gy5EZANSQKlHAx;
using bUfedyCg1PBqhqIkB8r;
using gea0S3fOc5LElyTCPXin;
using qS8vkpL43FlTMgcj0rgs;
using vc918xfOkSoZQrPJ8T7A;

namespace Mahiro_Account.UI.Shell;

internal static class DesktopWebLoginCoordinator
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _HandleActivationAsync_d__5 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public string requestId;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_014b;
				}
				if (!string.IsNullOrWhiteSpace(requestId))
				{
					bool flag = false;
					object syncRoot = SyncRoot;
					bool flag2 = false;
					try
					{
						Monitor.Enter(syncRoot, ref flag2);
						if (PendingRequestIds.Contains(requestId))
						{
							flag = true;
						}
						else if (PendingRequests.Count < 4)
						{
							PendingRequests.Enqueue(requestId);
							PendingRequestIds.Add(requestId);
							flag = true;
						}
					}
					finally
					{
						if (num < 0 && flag2)
						{
							Monitor.Exit(syncRoot);
						}
					}
					if (!flag)
					{
						AppShell.Warning("待处理的网页登录授权过多，请先完成当前请求");
					}
					else
					{
						gX17swyO7x0JWQxdaD1.IdOy6I4Chb("DesktopWebLogin", "已接收网页登录授权激活");
						if (AppShell.Api.CurrentUser != null)
						{
							_u__ = ProcessPendingAsync().GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _HandleActivationAsync_d__5>(ref _u__, ref this);
								return;
							}
							goto IL_014b;
						}
						AppShell.Host?.EnterAuthenticationState("请先登录桌面客户端，登录后将继续处理网页登录授权");
					}
				}
				goto end_IL_000a;
				IL_014b:
				_u__.GetResult();
				end_IL_000a:;
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
	private struct _ProcessPendingAsync_d__7 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		private TaskAwaiter<bool> __u__1;

		private string _requestId_5__2;

		private a6W5ZTfOVHy0sbBBOxWG _details_5__3;

		private bool _approved_5__4;

		private TaskAwaiter<a6W5ZTfOVHy0sbBBOxWG> __u__2;

		private TaskAwaiter<sBvZdvfOS1druNTuNC0F> __u__3;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0212: Unknown result type (might be due to invalid IL or missing references)
			//IL_0217: Unknown result type (might be due to invalid IL or missing references)
			//IL_021f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			try
			{
				TaskAwaiter<bool> _u__ = default;
				if (num != 0)
				{
					if ((uint)(num - 1) <= 2u)
					{
						goto IL_0087;
					}
					_u__ = ProcessingGate.WaitAsync(0).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _ProcessPendingAsync_d__7>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
				}
				if (_u__.GetResult())
				{
					goto IL_0087;
				}
				goto end_IL_000a;
				IL_0087:
				try
				{
					if ((uint)(num - 1) > 2u)
					{
						goto IL_0090;
					}
					goto IL_00b0;
					IL_0090:
					if (AppShell.Api.CurrentUser != null && TryPeek(out _requestId_5__2))
					{
						goto IL_00b0;
					}
					goto end_IL_0087;
					IL_00b0:
					UfjqWXfw4LbmaQBvftfE val = default(UfjqWXfw4LbmaQBvftfE);
					UfjqWXfw4LbmaQBvftfE val2 = default(UfjqWXfw4LbmaQBvftfE);
					try
					{
						TaskAwaiter<a6W5ZTfOVHy0sbBBOxWG> _u__3 = default;
						TaskAwaiter<sBvZdvfOS1druNTuNC0F> _u__2 = default;
						bool result;
						a6W5ZTfOVHy0sbBBOxWG result2;
						switch (num)
						{
						default:
							_u__3 = AppShell.Api.AkCcdQ683g(_requestId_5__2, default(CancellationToken)).GetAwaiter();
							if (!_u__3.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__3;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<a6W5ZTfOVHy0sbBBOxWG>, _ProcessPendingAsync_d__7>(ref _u__3, ref this);
								return;
							}
							goto IL_012f;
						case 1:
							_u__3 = __u__2;
							__u__2 = default(TaskAwaiter<a6W5ZTfOVHy0sbBBOxWG>);
							num = (__1__state = -1);
							goto IL_012f;
						case 2:
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<bool>);
							num = (__1__state = -1);
							goto IL_01a9;
						case 3:
							{
								_u__2 = __u__3;
								__u__3 = default(TaskAwaiter<sBvZdvfOS1druNTuNC0F>);
								num = (__1__state = -1);
								break;
							}
							IL_01a9:
							result = _u__.GetResult();
							_approved_5__4 = result;
							_u__2 = AppShell.Api.aMwcKC4NvT(_requestId_5__2, _approved_5__4, default(CancellationToken)).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 3);
								__u__3 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<sBvZdvfOS1druNTuNC0F>, _ProcessPendingAsync_d__7>(ref _u__2, ref this);
								return;
							}
							break;
							IL_012f:
							result2 = _u__3.GetResult();
							_details_5__3 = result2;
							gX17swyO7x0JWQxdaD1.IdOy6I4Chb("DesktopWebLogin", "已读取授权详情，正在等待用户确认");
							_u__ = ShowConfirmationAsync(_details_5__3).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 2);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _ProcessPendingAsync_d__7>(ref _u__, ref this);
								return;
							}
							goto IL_01a9;
						}
						_u__2.GetResult();
						RemovePending(_requestId_5__2);
						gX17swyO7x0JWQxdaD1.IdOy6I4Chb("DesktopWebLogin", _approved_5__4 ? "用户已允许网页登录" : "用户已拒绝网页登录");
						if (_approved_5__4)
						{
							AppShell.Success("网页登录已授权", "已允许 " + _details_5__3.Origin + " 使用当前账号登录");
						}
						else
						{
							AppShell.Info("已拒绝本次网页登录请求");
						}
						_details_5__3 = null;
					}
					catch (global::System.Exception obj) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						object obj2 = ((obj is UfjqWXfw4LbmaQBvftfE) ? obj : null);
						global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result3);
						if (obj2 == null)
						{
							result3 = 0;
						}
						else
						{
							val = (UfjqWXfw4LbmaQBvftfE)obj2;
							result3 = ((val.Status == 401) ? 1 : 0);
						}
						return (byte)result3 != 0;
					}).Invoke())
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val, "ui-exception", "ProcessPendingAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\DesktopWebLoginCoordinator.cs", 93);
						goto end_IL_0087;
					}
					catch (global::System.Exception obj3) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						object obj4 = ((obj3 is UfjqWXfw4LbmaQBvftfE) ? obj3 : null);
						global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result4);
						if (obj4 == null)
						{
							result4 = 0;
						}
						else
						{
							val2 = (UfjqWXfw4LbmaQBvftfE)obj4;
							int status = val2.Status;
							result4 = ((((status == 404 || (uint)(status - 409) <= 1u) ? 1 : 0) != 0) ? 1 : 0);
						}
						return (byte)result4 != 0;
					}).Invoke())
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val2, "ui-exception", "ProcessPendingAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\DesktopWebLoginCoordinator.cs", 103);
						RemovePending(_requestId_5__2);
						AppShell.Warning(((global::System.Exception)(object)val2).Message);
					}
					catch (global::System.Exception exception)
					{
						AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "ProcessPendingAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\DesktopWebLoginCoordinator.cs", 110));
						goto end_IL_0087;
					}
					goto IL_0090;
					end_IL_0087:;
				}
				finally
				{
					if (num < 0)
					{
						ProcessingGate.Release();
					}
				}
				end_IL_000a:;
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

	private const int MaximumPendingRequests = 4;

	private static readonly object SyncRoot;

	private static readonly Queue<string> PendingRequests;

	private static readonly HashSet<string> PendingRequestIds;

	private static readonly SemaphoreSlim ProcessingGate;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task HandleActivationAsync(string requestId)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_HandleActivationAsync_d__5 handleActivationAsync_d__ = default(_HandleActivationAsync_d__5);
		handleActivationAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		handleActivationAsync_d__.requestId = requestId;
		handleActivationAsync_d__.__1__state = -1;
		handleActivationAsync_d__.__t__builder.Start<_HandleActivationAsync_d__5>(ref handleActivationAsync_d__);
		return handleActivationAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static global::System.Threading.Tasks.Task ResumeAfterAuthenticationAsync()
	{
		return ProcessPendingAsync();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task ProcessPendingAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ProcessPendingAsync_d__7 processPendingAsync_d__ = default(_ProcessPendingAsync_d__7);
		processPendingAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		processPendingAsync_d__.__1__state = -1;
		processPendingAsync_d__.__t__builder.Start<_ProcessPendingAsync_d__7>(ref processPendingAsync_d__);
		return processPendingAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static async global::System.Threading.Tasks.Task<bool> ShowConfirmationAsync(a6W5ZTfOVHy0sbBBOxWG details)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		dN4xMCftS2WHJlRJeqrU currentUser = AppShell.Api.CurrentUser;
		if (currentUser == null)
		{
			return false;
		}
		If5EyAfODDnTDAkOMkqX val = (If5EyAfODDnTDAkOMkqX)(((object)details.Browser) ?? ((object)new If5EyAfODDnTDAkOMkqX()));
		string message = $"网页地址：{DisplayText(details.Origin, 180)}\n登录账号：{DisplayText(currentUser.Username, 64)}\n设备平台：{DisplayText(val.Platform, 64)}\n浏览器：{DisplayText(val.UserAgent, 180)}\n时区：{DisplayText(val.Timezone, 64)}\n\n" + "仅当这是你刚刚在网页上发起的请求时才允许登录。";
		return await AppShell.ConfirmAsync("允许网页登录？", message, "允许登录");
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string DisplayText(string? value, int maximumLength)
	{
		string text = (value ?? string.Empty).Replace('\r', ' ').Replace('\n', ' ').Trim();
		if (text.Length == 0)
		{
			return "未知";
		}
		if (text.Length > maximumLength)
		{
			return text.Substring(0, maximumLength) + "…";
		}
		return text;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool TryPeek(out string requestId)
	{
		lock (SyncRoot)
		{
			string text = default(string);
			if (PendingRequests.TryPeek(out text))
			{
				requestId = text;
				return true;
			}
		}
		requestId = string.Empty;
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void RemovePending(string requestId)
	{
		lock (SyncRoot)
		{
			string text = default(string);
			if (PendingRequests.TryPeek(out text) && string.Equals(text, requestId, (StringComparison)4))
			{
				PendingRequests.Dequeue();
			}
			PendingRequestIds.Remove(requestId);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	static DesktopWebLoginCoordinator()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		SyncRoot = new object();
		PendingRequests = new Queue<string>();
		PendingRequestIds = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		ProcessingGate = new SemaphoreSlim(1, 1);
	}
}
