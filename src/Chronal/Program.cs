using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using By1SFsLobKQOZCdh5qRg;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using qS8vkpL43FlTMgcj0rgs;
using qZYpv7LrBd6PaxEhteoA;

namespace Mahiro_Account;

public static class Program
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_26
	{
		public static __c_26 __9;

		public static ApplicationInitializationCallback __9__0_0;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			__9 = (__c_26)new __c_26();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_26()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _Main_b__0_0(ApplicationInitializationCallbackParams p)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			System.Threading.SynchronizationContext.SetSynchronizationContext((SynchronizationContext)new DispatcherQueueSynchronizationContext(Microsoft.UI.Dispatching.DispatcherQueue.GetForCurrentThread()));
			new App();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	[STAThread]
	private static void Main(string[] args)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		qiPowfLrI8h0QeonOQ0X.gbWjXv8DZtD();
		WinRT.ComWrappersSupport.InitializeComWrappers(null);
		object obj = __c_26.__9__0_0;
		if (obj == null)
		{
			ApplicationInitializationCallback val = [MethodImpl((MethodImplOptions)8)] (ApplicationInitializationCallbackParams p) =>
			{
				//IL_000d: Unknown result type (might be due to invalid IL or missing references)
				//IL_001c: Expected O, but got Unknown
				System.Threading.SynchronizationContext.SetSynchronizationContext((SynchronizationContext)new DispatcherQueueSynchronizationContext(Microsoft.UI.Dispatching.DispatcherQueue.GetForCurrentThread()));
				new App();
			};
			__c_26.__9__0_0 = val;
			obj = (object)val;
		}
		Microsoft.UI.Xaml.Application.Start((ApplicationInitializationCallback)obj);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		qiPowfLrI8h0QeonOQ0X.gbWjXv8DZtD();
	}
}
