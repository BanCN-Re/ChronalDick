using System;
using System.Runtime.CompilerServices;
using System.Threading;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace ERJ416fPgD8mIlLPsat4;

public class HpFsqcfPB2RknTNMlueF
{
	sealed class VA45MOLWQ2aXYj5ykfrg : global::System.IDisposable
	{
		private bool _disposed;

		internal static object SbwH3kDrHgpkoqHRl8cu;

		[MethodImpl((MethodImplOptions)8)]
		public void Dispose()
		{
			SuppressionDepth.Value = System.Math.Max(0, SuppressionDepth.Value - 1);
		}

		[MethodImpl((MethodImplOptions)8)]
		public VA45MOLWQ2aXYj5ykfrg()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
			{
				num = 6;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 0:
					return;
				}
				if (num2 == 988)
				{
					num = num2;
					continue;
				}
				return;
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
		internal static bool UUa89RDrtPI7XJNQeBAY()
		{
			return SbwH3kDrHgpkoqHRl8cu == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static VA45MOLWQ2aXYj5ykfrg kXGbe7DrOorGB9VaTgKN()
		{
			return (VA45MOLWQ2aXYj5ykfrg)SbwH3kDrHgpkoqHRl8cu;
		}
	}

	private static object? _current;

	private static readonly AsyncLocal<int> SuppressionDepth;

	[CompilerGenerated]
	private static EventHandler? m_Changed;

	internal static object? eNjnqc9jX4WaKuQw6AKj;

	public static string? Current
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Volatile.Read<string>(ref global::System.Runtime.CompilerServices.Unsafe.As<object?, string>(ref _current));
		}
	}

	internal static bool PublishingSuppressed
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return SuppressionDepth.Value > 0;
		}
	}

	public static event EventHandler Changed
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		add
		{
			EventHandler val2 = default(EventHandler);
			EventHandler val3 = default(EventHandler);
			EventHandler val = Interlocked.CompareExchange<EventHandler>(ref HpFsqcfPB2RknTNMlueF.m_Changed, val2, val3);
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		remove
		{
			EventHandler val2 = default(EventHandler);
			EventHandler val3 = default(EventHandler);
			EventHandler val = Interlocked.CompareExchange<EventHandler>(ref HpFsqcfPB2RknTNMlueF.m_Changed, val2, val3);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public static global::System.IDisposable erLfPleUYXa()
	{
		AsyncLocal<int> suppressionDepth = SuppressionDepth;
		int value = suppressionDepth.Value;
		suppressionDepth.Value = value + 1;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void LetfPdB1Tul(object sauthWrapper)
	{
		Volatile.Write<string>(ref global::System.Runtime.CompilerServices.Unsafe.As<object?, string>(ref _current), (string)sauthWrapper);
	}

	[MethodImpl((MethodImplOptions)8)]
	public static void AIefPKllY4o()
	{
		Volatile.Write<string>(ref global::System.Runtime.CompilerServices.Unsafe.As<object?, string>(ref _current), (string)null);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool T9uxHg9jf46pQEM2UFVl()
	{
		return eNjnqc9jX4WaKuQw6AKj == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static HpFsqcfPB2RknTNMlueF? vkUSYw9jL37WGHvTt7ZE()
	{
		return (HpFsqcfPB2RknTNMlueF?)eNjnqc9jX4WaKuQw6AKj;
	}
}
