using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using LlvQkpftcKTPAsaRP0ff;
using MbgJAqLroveeTUtcYc7g;
using MnCNHgfwhm1BlAufHdT1;
using bUfedyCg1PBqhqIkB8r;
using qS8vkpL43FlTMgcj0rgs;
using wO3EWmfw6peyoPKxQt8p;

namespace Mahiro_Account.UI.Navigation;

internal static class BedrockAccessGuard
{
	private sealed class AccessCacheEntry : IEquatable<AccessCacheEntry>
	{
		[CompilerGenerated]
		private global::System.Type EqualityContract
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return typeof(global::Mahiro_Account.UI.Navigation.BedrockAccessGuard.AccessCacheEntry);
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
		public AccessCacheEntry(jvLOtufw5u5UGypgaMFF Access, long UserId)
		{
			_Access_k__BackingField = Access;
			_UserId_k__BackingField = UserId;
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override string ToString()
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Expected O, but got Unknown
			StringBuilder val = new StringBuilder();
			val.Append("AccessCacheEntry");
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
			builder.Append(", UserId = ");
			builder.Append(((object)UserId/*cast due to .constrained prefix*/).ToString());
			return true;
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator !=(AccessCacheEntry? left, AccessCacheEntry? right)
		{
			return !(left == right);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator ==(AccessCacheEntry? left, AccessCacheEntry? right)
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
			return (EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<jvLOtufw5u5UGypgaMFF>.Default.GetHashCode(_Access_k__BackingField)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(_UserId_k__BackingField);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as AccessCacheEntry);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public bool Equals(AccessCacheEntry? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<jvLOtufw5u5UGypgaMFF>.Default.Equals(_Access_k__BackingField, other._Access_k__BackingField))
				{
					return EqualityComparer<long>.Default.Equals(_UserId_k__BackingField, other._UserId_k__BackingField);
				}
				return false;
			}
			return true;
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public AccessCacheEntry _Clone__()
		{
			return (AccessCacheEntry)new AccessCacheEntry(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private AccessCacheEntry(AccessCacheEntry original)
		{
			_Access_k__BackingField = original._Access_k__BackingField;
			_UserId_k__BackingField = original._UserId_k__BackingField;
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public void Deconstruct(out jvLOtufw5u5UGypgaMFF Access, out long UserId)
		{
			//IL_000b: Expected I8, but got O
			Access = (jvLOtufw5u5UGypgaMFF)this.Access;
			UserId = this.UserId;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	private static readonly SemaphoreSlim AccessGate;

	private static AccessCacheEntry? _cache;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static async global::System.Threading.Tasks.Task<bool> EnsureAsync(CancellationToken cancellationToken = default(CancellationToken), bool forceRefresh = false)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (!forceRefresh && TryGetCachedAccess())
		{
			return true;
		}
		UfjqWXfw4LbmaQBvftfE val2 = default(UfjqWXfw4LbmaQBvftfE);
		try
		{
			await AccessGate.WaitAsync(cancellationToken);
			try
			{
				if (!forceRefresh && TryGetCachedAccess())
				{
					return true;
				}
				jvLOtufw5u5UGypgaMFF val = await AppShell.Api.ucf8G5snLP("bedrock_launch", cancellationToken);
				if (val.Allowed)
				{
					RecordAllowed(val);
					return true;
				}
				Invalidate();
			}
			finally
			{
				AccessGate.Release();
			}
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
			cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val2, "ui-exception", "EnsureAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Navigation\\BedrockAccessGuard.cs", 47);
		}
		catch (OperationCanceledException)
		{
			throw new global::System.Exception();
		}
		catch (global::System.Exception exception)
		{
			AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "EnsureAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Navigation\\BedrockAccessGuard.cs", 55));
			return false;
		}
		if (await AppShell.ConfirmAsync("需要订阅基岩版启动服务", "你的时长已到期或未订阅，请前往服务订阅购买服务", "前往服务订阅"))
		{
			AppShell.Navigate(NavigationRegistry.MainPageType("services"));
		}
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void RecordAllowed(jvLOtufw5u5UGypgaMFF access)
	{
		ArgumentNullException.ThrowIfNull((object)access, "access");
		dN4xMCftS2WHJlRJeqrU currentUser = AppShell.Api.CurrentUser;
		long num = ((currentUser != null) ? currentUser.Id : 0);
		if (!access.Allowed || num <= 0)
		{
			Invalidate();
		}
		else
		{
			Volatile.Write<AccessCacheEntry>(ref _cache, (AccessCacheEntry)new AccessCacheEntry(access, num));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void Invalidate()
	{
		Volatile.Write<AccessCacheEntry>(ref _cache, (AccessCacheEntry)null);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool TryGetCachedAccess()
	{
		AccessCacheEntry accessCacheEntry = Volatile.Read<AccessCacheEntry>(ref _cache);
		if ((object)accessCacheEntry != null)
		{
			long userId = accessCacheEntry.UserId;
			dN4xMCftS2WHJlRJeqrU currentUser = AppShell.Api.CurrentUser;
			if (userId == ((currentUser != null) ? currentUser.Id : 0))
			{
				global::System.DateTime? expiresAt = accessCacheEntry.Access.ExpiresAt;
				if (!expiresAt.HasValue || !(expiresAt.GetValueOrDefault().ToUniversalTime() <= global::System.DateTime.UtcNow))
				{
					return accessCacheEntry.Access.Allowed;
				}
			}
		}
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	static BedrockAccessGuard()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		AccessGate = new SemaphoreSlim(1, 1);
	}
}
