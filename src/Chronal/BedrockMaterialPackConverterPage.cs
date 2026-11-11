using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using DSkL6sf3pdbXXbyLriYE;
using GkK3arfvSlMtIobI96Lu;
using III7gxfvbKRLnPBcLYQl;
using JHPNEHf3PdjYOFZEfyQ0;
using KmrkUdf36CIZ5b1oiPx2;
using Mahiro_Account.UI;
using Mahiro_Account.UI.Controls.Bedrock;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.Windows.Storage.Pickers;
using Vl4jDMX56cFYkU2Jw1oo;
using WinRT;
using WinRT.ChronalVtableClasses;
using mRSjbcf3FrO7v99LwT5V;
using nW2Sekfay3BSEMMb8toe;
using neNEdCfvDXyU2I12pWCp;
using oJyDVdf3qipJVlWs8wcC;
using qS8vkpL43FlTMgcj0rgs;
using rqqOY2fvf53jrRSbLgIu;

namespace Mahiro_Account.Views.Pages.Bedrock;

[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_Bedrock_BedrockVersionManagementPageWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class BedrockMaterialPackConverterPage : Page, global::System.IDisposable, IComponentConnector
{
	[CompilerGenerated]
	private sealed class __c__DisplayClass8_0
	{
		[StructLayout((LayoutKind)3)]
		private struct __PlanButton_Click_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass8_0 __4__this;

			public CancellationToken cancellationToken;

			private TaskAwaiter<F3aQPNf3M1RFYFFkevLv> __u__1;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_008a: Unknown result type (might be due to invalid IL or missing references)
				//IL_008f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0096: Unknown result type (might be due to invalid IL or missing references)
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_0070: Unknown result type (might be due to invalid IL or missing references)
				//IL_0071: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass8_0 _c__DisplayClass8_ = __4__this;
				try
				{
					TaskAwaiter<F3aQPNf3M1RFYFFkevLv> _u__ = default;
					if (num != 0)
					{
						_u__ = _c__DisplayClass8_.__4__this._service.sodX5p8DRRY(_c__DisplayClass8_.input, _c__DisplayClass8_.__4__this.CreateOptions(), (IProgress<g8K40hf324CAUM803r8n>)(object)new Progress<g8K40hf324CAUM803r8n>((Action<g8K40hf324CAUM803r8n>)_c__DisplayClass8_.__4__this.UpdateProgress), cancellationToken).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<F3aQPNf3M1RFYFFkevLv>, __PlanButton_Click_b__0_d>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<F3aQPNf3M1RFYFFkevLv>);
						num = (__1__state = -1);
					}
					F3aQPNf3M1RFYFFkevLv result = _u__.GetResult();
					_c__DisplayClass8_.__4__this.ReportText.Text = FormatPlan(result);
					_c__DisplayClass8_.__4__this.StatusText.Text = $"计划完成：{((global::System.Collections.Generic.IReadOnlyCollection<utqcfnf3xc1JtxjWO6hw>)result.Actions).Count} 个动作，{((global::System.Collections.Generic.IReadOnlyCollection<iVdeJwfvX704Xagu9W0X>)result.Issues).Count} 个提示";
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

		public BedrockMaterialPackConverterPage __4__this;

		public string input;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass8_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _PlanButton_Click_b__0(CancellationToken cancellationToken)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			__PlanButton_Click_b__0_d _PlanButton_Click_b__0_d = default(__PlanButton_Click_b__0_d);
			_PlanButton_Click_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_PlanButton_Click_b__0_d.__4__this = this;
			_PlanButton_Click_b__0_d.cancellationToken = cancellationToken;
			_PlanButton_Click_b__0_d.__1__state = -1;
			_PlanButton_Click_b__0_d.__t__builder.Start<__PlanButton_Click_b__0_d>(ref _PlanButton_Click_b__0_d);
			return _PlanButton_Click_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass9_0
	{
		[StructLayout((LayoutKind)3)]
		private struct __ConvertButton_Click_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass9_0 __4__this;

			public CancellationToken cancellationToken;

			private TaskAwaiter<PDBt0ofvYOHy1IKynRM4> __u__1;

			private TaskAwaiter<WQh695fa8bRtqyh4inIH> __u__2;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_0097: Unknown result type (might be due to invalid IL or missing references)
				//IL_009c: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_0172: Unknown result type (might be due to invalid IL or missing references)
				//IL_0177: Unknown result type (might be due to invalid IL or missing references)
				//IL_017f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0057: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Unknown result type (might be due to invalid IL or missing references)
				//IL_0066: Unknown result type (might be due to invalid IL or missing references)
				//IL_007d: Unknown result type (might be due to invalid IL or missing references)
				//IL_007e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0130: Unknown result type (might be due to invalid IL or missing references)
				//IL_013a: Unknown result type (might be due to invalid IL or missing references)
				//IL_013f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0157: Unknown result type (might be due to invalid IL or missing references)
				//IL_0159: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass9_0 _c__DisplayClass9_ = __4__this;
				try
				{
					TaskAwaiter<WQh695fa8bRtqyh4inIH> _u__ = default;
					TaskAwaiter<PDBt0ofvYOHy1IKynRM4> _u__2 = default;
					if (num != 0)
					{
						if (num == 1)
						{
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter<WQh695fa8bRtqyh4inIH>);
							num = (__1__state = -1);
							goto IL_018e;
						}
						_u__2 = _c__DisplayClass9_.__4__this._service.dqtX5uXnnhx(_c__DisplayClass9_.input, _c__DisplayClass9_.output, _c__DisplayClass9_.__4__this.CreateOptions(), (IProgress<g8K40hf324CAUM803r8n>)(object)new Progress<g8K40hf324CAUM803r8n>((Action<g8K40hf324CAUM803r8n>)_c__DisplayClass9_.__4__this.UpdateProgress), cancellationToken).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<PDBt0ofvYOHy1IKynRM4>, __ConvertButton_Click_b__0_d>(ref _u__2, ref this);
							return;
						}
					}
					else
					{
						_u__2 = __u__1;
						__u__1 = default(TaskAwaiter<PDBt0ofvYOHy1IKynRM4>);
						num = (__1__state = -1);
					}
					PDBt0ofvYOHy1IKynRM4 result = _u__2.GetResult();
					_c__DisplayClass9_.__4__this.ReportText.Text = FormatReport(result.Report);
					if (result.Success)
					{
						if (((ToggleButton)_c__DisplayClass9_.__4__this.AutoImportCheckBox).IsChecked == true && result.OutputPath != null)
						{
							_c__DisplayClass9_.__4__this.StatusText.Text = "正在导入转换结果到材质包库";
							_u__ = _c__DisplayClass9_.__4__this._service.XPFX5Nqtu34(result.OutputPath, cancellationToken).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<WQh695fa8bRtqyh4inIH>, __ConvertButton_Click_b__0_d>(ref _u__, ref this);
								return;
							}
							goto IL_018e;
						}
						AppShell.Success("材质包转换完成：" + result.OutputPath);
					}
					else
					{
						AppShell.Error("材质包转换失败，请查看报告");
					}
					goto end_IL_0011;
					IL_018e:
					WQh695fa8bRtqyh4inIH result2 = _u__.GetResult();
					AppShell.Success("转换并导入完成：" + result2.Name);
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

		public BedrockMaterialPackConverterPage __4__this;

		public string input;

		public string output;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass9_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _ConvertButton_Click_b__0(CancellationToken cancellationToken)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			__ConvertButton_Click_b__0_d _ConvertButton_Click_b__0_d = default(__ConvertButton_Click_b__0_d);
			_ConvertButton_Click_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_ConvertButton_Click_b__0_d.__4__this = this;
			_ConvertButton_Click_b__0_d.cancellationToken = cancellationToken;
			_ConvertButton_Click_b__0_d.__1__state = -1;
			_ConvertButton_Click_b__0_d.__t__builder.Start<__ConvertButton_Click_b__0_d>(ref _ConvertButton_Click_b__0_d);
			return _ConvertButton_Click_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _BenefitsButton_Click_d__4 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockMaterialPackConverterPage __4__this;

		private TaskAwaiter<ContentDialogResult> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockMaterialPackConverterPage bedrockMaterialPackConverterPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_004e;
				}
				XamlRoot val = AppShell.XamlRoot ?? ((UIElement)bedrockMaterialPackConverterPage).XamlRoot;
				JavaPackConversionBenefitsDialog javaPackConversionBenefitsDialog2 = default(JavaPackConversionBenefitsDialog);
				if (val != null)
				{
					object javaPackConversionBenefitsDialog = (object)new JavaPackConversionBenefitsDialog();
					((UIElement)javaPackConversionBenefitsDialog).XamlRoot = val;
					((FrameworkElement)javaPackConversionBenefitsDialog).RequestedTheme = AppShell.RequestedTheme;
					javaPackConversionBenefitsDialog2 = (JavaPackConversionBenefitsDialog)javaPackConversionBenefitsDialog;
					goto IL_004e;
				}
				goto end_IL_0011;
				IL_004e:
					javaPackConversionBenefitsDialog2 = default;
				try
				{
					TaskAwaiter<ContentDialogResult> _u__ = default;
					if (num != 0)
					{
						_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>(((ContentDialog)javaPackConversionBenefitsDialog2).ShowAsync());
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ContentDialogResult>, _BenefitsButton_Click_d__4>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<ContentDialogResult>);
						num = (__1__state = -1);
					}
					_u__.GetResult();
				}
				catch (global::System.Exception exception)
				{
					AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "BenefitsButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockMaterialPackConverterPage.xaml.cs", 49));
				}
				end_IL_0011:;
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
	private struct _ChooseInputButton_Click_d__5 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockMaterialPackConverterPage __4__this;

		private TaskAwaiter<string?> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockMaterialPackConverterPage bedrockMaterialPackConverterPage = __4__this;
			try
			{
				TaskAwaiter<string> _u__ = default;
				if (num != 0)
				{
					_u__ = DesktopFilePicker.PickOpenFileAsync(AppShell.WindowHandle, (PickerLocationId)3, new global::__z__ReadOnlyArray_1<string>(new string[2] { ".zip", ".rar" }), "选择 Java 材质包").GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _ChooseInputButton_Click_d__5>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<string>);
					num = (__1__state = -1);
				}
				string result = _u__.GetResult();
				if (result != null)
				{
					bedrockMaterialPackConverterPage.InputPathTextBox.Text = result;
					if (string.IsNullOrWhiteSpace(bedrockMaterialPackConverterPage.OutputPathTextBox.Text))
					{
						bedrockMaterialPackConverterPage.OutputPathTextBox.Text = Path.ChangeExtension(result, ".mcpack");
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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ChooseInputFolderButton_Click_d__7 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockMaterialPackConverterPage __4__this;

		private TaskAwaiter<string?> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockMaterialPackConverterPage bedrockMaterialPackConverterPage = __4__this;
			try
			{
				TaskAwaiter<string> _u__ = default;
				if (num != 0)
				{
					_u__ = DesktopFilePicker.PickFolderAsync(AppShell.WindowHandle, (PickerLocationId)3, "选择已解压的 Java 材质包文件夹").GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _ChooseInputFolderButton_Click_d__7>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<string>);
					num = (__1__state = -1);
				}
				string result = _u__.GetResult();
				if (result != null)
				{
					bedrockMaterialPackConverterPage.InputPathTextBox.Text = result;
					if (string.IsNullOrWhiteSpace(bedrockMaterialPackConverterPage.OutputPathTextBox.Text))
					{
						bedrockMaterialPackConverterPage.OutputPathTextBox.Text = Path.Combine(Environment.GetFolderPath((System.Environment.SpecialFolder)5), Path.GetFileName(result) + ".mcpack");
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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ChooseOutputButton_Click_d__6 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockMaterialPackConverterPage __4__this;

		private TaskAwaiter<string?> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockMaterialPackConverterPage bedrockMaterialPackConverterPage = __4__this;
			try
			{
				TaskAwaiter<string> _u__ = default;
				if (num != 0)
				{
					_u__ = DesktopFilePicker.PickSaveFileAsync(AppShell.WindowHandle, (PickerLocationId)3, "converted-pack.mcpack", new global::__z__ReadOnlySingleElementList_1<DesktopFileTypeChoice>((DesktopFileTypeChoice)new DesktopFileTypeChoice("Minecraft 基岩版资源包", (global::System.Collections.Generic.IReadOnlyList<string>)new global::__z__ReadOnlySingleElementList_1<string>(".mcpack"))), "选择输出材质包").GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _ChooseOutputButton_Click_d__6>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<string>);
					num = (__1__state = -1);
				}
				string result = _u__.GetResult();
				if (result != null)
				{
					bedrockMaterialPackConverterPage.OutputPathTextBox.Text = result;
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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ConvertButton_Click_d__9 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockMaterialPackConverterPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockMaterialPackConverterPage bedrockMaterialPackConverterPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00a8;
				}
				__c__DisplayClass9_0 _c__DisplayClass9_ = (__c__DisplayClass9_0)new __c__DisplayClass9_0
				{
					__4__this = __4__this
				};
				if (bedrockMaterialPackConverterPage.TryGetPaths(out _c__DisplayClass9_.input, out _c__DisplayClass9_.output))
				{
					_u__ = bedrockMaterialPackConverterPage.RunAsync(_c__DisplayClass9_._ConvertButton_Click_b__0).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ConvertButton_Click_d__9>(ref _u__, ref this);
						return;
					}
					goto IL_00a8;
				}
				goto end_IL_0011;
				IL_00a8:
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
	private struct _PlanButton_Click_d__8 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockMaterialPackConverterPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockMaterialPackConverterPage bedrockMaterialPackConverterPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00a7;
				}
				__c__DisplayClass8_0 _c__DisplayClass8_ = (__c__DisplayClass8_0)new __c__DisplayClass8_0
				{
					__4__this = __4__this
				};
				if (bedrockMaterialPackConverterPage.TryGetPaths(out _c__DisplayClass8_.input, out string _))
				{
					_u__ = bedrockMaterialPackConverterPage.RunAsync(_c__DisplayClass8_._PlanButton_Click_b__0).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _PlanButton_Click_d__8>(ref _u__, ref this);
						return;
					}
					goto IL_00a7;
				}
				goto end_IL_0011;
				IL_00a7:
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
	private struct _RunAsync_d__10 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockMaterialPackConverterPage __4__this;

		public Func<CancellationToken, global::System.Threading.Tasks.Task> action;

		private CancellationTokenSource _cancellation_5__2;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockMaterialPackConverterPage bedrockMaterialPackConverterPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0033;
				}
				if (bedrockMaterialPackConverterPage._cancellation == null)
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
						bedrockMaterialPackConverterPage._cancellation = _cancellation_5__2;
						((Control)bedrockMaterialPackConverterPage.PlanButton).IsEnabled = false;
						((Control)bedrockMaterialPackConverterPage.ConvertButton).IsEnabled = false;
					}
					try
					{
						TaskAwaiter _u__ = default;
						if (num != 0)
						{
							_u__ = action.Invoke(_cancellation_5__2.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RunAsync_d__10>(ref _u__, ref this);
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
						bedrockMaterialPackConverterPage.StatusText.Text = "转换已取消";
					}
					catch (global::System.Exception exception)
					{
						bedrockMaterialPackConverterPage.StatusText.Text = AppShell.GetExceptionDisplayMessage(exception, "RunAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockMaterialPackConverterPage.xaml.cs", 178);
						AppShell.Error(bedrockMaterialPackConverterPage.StatusText.Text);
					}
					finally
					{
						if (num < 0)
						{
							bedrockMaterialPackConverterPage._cancellation = null;
							((Control)bedrockMaterialPackConverterPage.PlanButton).IsEnabled = true;
							((Control)bedrockMaterialPackConverterPage.ConvertButton).IsEnabled = true;
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

	private readonly da18CdX55laNMRKtM3p0 _service;

	private CancellationTokenSource? _cancellation;

	private bool _disposed;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ReportText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button PlanButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button ConvertButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressBar ProgressBar;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock StatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox PbrCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox AnimationCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox SoundsCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox LegacyTextureSetCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox AutoImportCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox OutputPathTextBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox InputPathTextBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[MethodImpl((MethodImplOptions)8)]
	public BedrockMaterialPackConverterPage()
	{
		_service = da18CdX55laNMRKtM3p0.Shared;
		InitializeComponent();
		AppShell.RegisterDisposable(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void BenefitsButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_BenefitsButton_Click_d__4 benefitsButton_Click_d__ = default(_BenefitsButton_Click_d__4);
		benefitsButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		benefitsButton_Click_d__.__4__this = this;
		benefitsButton_Click_d__.__1__state = -1;
		benefitsButton_Click_d__.__t__builder.Start<_BenefitsButton_Click_d__4>(ref benefitsButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ChooseInputButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ChooseInputButton_Click_d__5 chooseInputButton_Click_d__ = default(_ChooseInputButton_Click_d__5);
		chooseInputButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		chooseInputButton_Click_d__.__4__this = this;
		chooseInputButton_Click_d__.__1__state = -1;
		chooseInputButton_Click_d__.__t__builder.Start<_ChooseInputButton_Click_d__5>(ref chooseInputButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ChooseOutputButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ChooseOutputButton_Click_d__6 chooseOutputButton_Click_d__ = default(_ChooseOutputButton_Click_d__6);
		chooseOutputButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		chooseOutputButton_Click_d__.__4__this = this;
		chooseOutputButton_Click_d__.__1__state = -1;
		chooseOutputButton_Click_d__.__t__builder.Start<_ChooseOutputButton_Click_d__6>(ref chooseOutputButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ChooseInputFolderButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ChooseInputFolderButton_Click_d__7 chooseInputFolderButton_Click_d__ = default(_ChooseInputFolderButton_Click_d__7);
		chooseInputFolderButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		chooseInputFolderButton_Click_d__.__4__this = this;
		chooseInputFolderButton_Click_d__.__1__state = -1;
		chooseInputFolderButton_Click_d__.__t__builder.Start<_ChooseInputFolderButton_Click_d__7>(ref chooseInputFolderButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void PlanButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_PlanButton_Click_d__8 planButton_Click_d__ = default(_PlanButton_Click_d__8);
		planButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		planButton_Click_d__.__4__this = this;
		planButton_Click_d__.__1__state = -1;
		planButton_Click_d__.__t__builder.Start<_PlanButton_Click_d__8>(ref planButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ConvertButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ConvertButton_Click_d__9 convertButton_Click_d__ = default(_ConvertButton_Click_d__9);
		convertButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		convertButton_Click_d__.__4__this = this;
		convertButton_Click_d__.__1__state = -1;
		convertButton_Click_d__.__t__builder.Start<_ConvertButton_Click_d__9>(ref convertButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RunAsync(Func<CancellationToken, global::System.Threading.Tasks.Task> action)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RunAsync_d__10 runAsync_d__ = default(_RunAsync_d__10);
		runAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		runAsync_d__.__4__this = this;
		runAsync_d__.action = action;
		runAsync_d__.__1__state = -1;
		runAsync_d__.__t__builder.Start<_RunAsync_d__10>(ref runAsync_d__);
		return runAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private evOcMdf35MKMKmQuE9Xd CreateOptions()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		evOcMdf35MKMKmQuE9Xd val = new evOcMdf35MKMKmQuE9Xd();
		val.GetType().GetProperty("EnablePbr").SetValue(val, ((ToggleButton)PbrCheckBox).IsChecked == true);
		val.GetType().GetProperty("EnableAnimations").SetValue(val, ((ToggleButton)AnimationCheckBox).IsChecked == true);
		val.GetType().GetProperty("EnableSounds").SetValue(val, ((ToggleButton)SoundsCheckBox).IsChecked == true);
		val.GetType().GetProperty("GenerateLegacyTextureSets").SetValue(val, ((ToggleButton)LegacyTextureSetCheckBox).IsChecked == true);
		return val;
	}

	[MethodImpl((MethodImplOptions)8)]
	private bool TryGetPaths(out string input, out string output)
	{
		//IL_002b: Expected I8, but got O
		//IL_0056: Expected I8, but got O
		input = default;
		output = default;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateProgress(g8K40hf324CAUM803r8n progress)
	{
		((RangeBase)ProgressBar).Value = progress.Percentage;
		StatusText.Text = progress.Message;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string FormatPlan(F3aQPNf3M1RFYFFkevLv plan)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		StringBuilder val = new StringBuilder();
		StringBuilder val2 = val;
		StringBuilder obj = val2;
		StringBuilder.AppendInterpolatedStringHandler val3 = default(StringBuilder.AppendInterpolatedStringHandler);
		val3.AppendLiteral("材质包：");
		val3.AppendFormatted(plan.PackName);
		obj.AppendLine(ref val3);
		val2 = val;
		StringBuilder obj2 = val2;
		val3.AppendLiteral("pack_format：");
		val3.AppendFormatted<int>(plan.PackFormat);
		obj2.AppendLine(ref val3);
		val2 = val;
		StringBuilder obj3 = val2;
		val3.AppendLiteral("贴图：");
		val3.AppendFormatted<int>(plan.TextureCount);
		val3.AppendLiteral("，PBR：");
		val3.AppendFormatted<int>(plan.PbrCount);
		val3.AppendLiteral("，动画：");
		val3.AppendFormatted<int>(plan.AnimationCount);
		val3.AppendLiteral("，音效：");
		val3.AppendFormatted<int>(plan.SoundCount);
		val3.AppendLiteral("，语言：");
		val3.AppendFormatted<int>(plan.LanguageCount);
		obj3.AppendLine(ref val3);
		val.AppendLine();
		global::System.Collections.Generic.IEnumerator<utqcfnf3xc1JtxjWO6hw> enumerator = Enumerable.Take<utqcfnf3xc1JtxjWO6hw>((global::System.Collections.Generic.IEnumerable<utqcfnf3xc1JtxjWO6hw>)plan.Actions, 1000).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				utqcfnf3xc1JtxjWO6hw current = enumerator.Current;
				val2 = val;
				StringBuilder obj4 = val2;
				val3 = new StringBuilder.AppendInterpolatedStringHandler(5, 3, val2);
				val3.AppendFormatted<LfcP8Df3en1WdrLPb50n>(current.Kind, -22);
				val3.AppendLiteral(" ");
				val3.AppendFormatted(current.SourcePath);
				val3.AppendLiteral(" -> ");
				val3.AppendFormatted(current.TargetPath);
				obj4.AppendLine(ref val3);
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		if (((global::System.Collections.Generic.IReadOnlyCollection<utqcfnf3xc1JtxjWO6hw>)plan.Actions).Count > 1000)
		{
			val2 = val;
			StringBuilder obj5 = val2;
			val3.AppendLiteral("其余 ");
			val3.AppendFormatted<int>(((global::System.Collections.Generic.IReadOnlyCollection<utqcfnf3xc1JtxjWO6hw>)plan.Actions).Count - 1000);
			val3.AppendLiteral(" 个动作已写入转换报告");
			obj5.AppendLine(ref val3);
		}
		global::System.Collections.Generic.IEnumerator<iVdeJwfvX704Xagu9W0X> enumerator2 = ((global::System.Collections.Generic.IEnumerable<iVdeJwfvX704Xagu9W0X>)plan.Issues).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
			{
				iVdeJwfvX704Xagu9W0X current2 = enumerator2.Current;
				val2 = val;
				StringBuilder obj6 = val2;
				val3 = new StringBuilder.AppendInterpolatedStringHandler(6, 4, val2);
				val3.AppendLiteral("[");
				val3.AppendFormatted<zAlhhvf3zB4itfsALkpE>(current2.Severity);
				val3.AppendLiteral("] ");
				val3.AppendFormatted(current2.Code);
				val3.AppendLiteral(": ");
				val3.AppendFormatted(current2.Message);
				val3.AppendLiteral(" ");
				val3.AppendFormatted(current2.AssetPath);
				obj6.AppendLine(ref val3);
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator2)?.Dispose();
		}
		return ((object)val).ToString();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string FormatReport(tKfog8fv9JbCtqPFjhFi report)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		StringBuilder val = new StringBuilder();
		val.AppendLine(report.OutputPath);
		StringBuilder val2 = val;
		StringBuilder obj = val2;
		StringBuilder.AppendInterpolatedStringHandler val3 = default(StringBuilder.AppendInterpolatedStringHandler);
		val3.AppendLiteral("贴图 ");
		val3.AppendFormatted<int>(report.ConvertedTextures);
		val3.AppendLiteral(" | PBR ");
		val3.AppendFormatted<int>(report.ConvertedPbrAssets);
		val3.AppendLiteral(" | 动画 ");
		val3.AppendFormatted<int>(report.ConvertedAnimations);
		val3.AppendLiteral(" | 音效 ");
		val3.AppendFormatted<int>(report.ConvertedSounds);
		val3.AppendLiteral(" | 语言 ");
		val3.AppendFormatted<int>(report.ConvertedLanguages);
		obj.AppendLine(ref val3);
		val2 = val;
		StringBuilder obj2 = val2;
		val3.AppendLiteral("SHA-256: ");
		val3.AppendFormatted(report.OutputSha256);
		obj2.AppendLine(ref val3);
		val.AppendLine();
		global::System.Collections.Generic.IEnumerator<iVdeJwfvX704Xagu9W0X> enumerator = ((global::System.Collections.Generic.IEnumerable<iVdeJwfvX704Xagu9W0X>)report.Issues).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				iVdeJwfvX704Xagu9W0X current = enumerator.Current;
				val2 = val;
				StringBuilder obj3 = val2;
				val3 = new StringBuilder.AppendInterpolatedStringHandler(6, 4, val2);
				val3.AppendLiteral("[");
				val3.AppendFormatted<zAlhhvf3zB4itfsALkpE>(current.Severity);
				val3.AppendLiteral("] ");
				val3.AppendFormatted(current.Code);
				val3.AppendLiteral(": ");
				val3.AppendFormatted(current.Message);
				val3.AppendLiteral(" ");
				val3.AppendFormatted(current.AssetPath);
				obj3.AppendLine(ref val3);
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		return ((object)val).ToString();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		if (!_disposed)
		{
			_disposed = true;
			CancellationTokenSource? cancellation = _cancellation;
			if (cancellation != null)
			{
				cancellation.Cancel();
			}
			CancellationTokenSource? cancellation2 = _cancellation;
			if (cancellation2 != null)
			{
				cancellation2.Dispose();
			}
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
			Uri val = new Uri("ms-appx:///Views/Pages/Bedrock/BedrockMaterialPackConverterPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			ReportText = CastExtensions.As<TextBlock>(target);
			break;
		case 3:
			PlanButton = CastExtensions.As<Button>(target);
			((ButtonBase)PlanButton).Click += new RoutedEventHandler(PlanButton_Click);
			break;
		case 4:
			ConvertButton = CastExtensions.As<Button>(target);
			((ButtonBase)ConvertButton).Click += new RoutedEventHandler(ConvertButton_Click);
			break;
		case 5:
			ProgressBar = CastExtensions.As<ProgressBar>(target);
			break;
		case 6:
			StatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 7:
			PbrCheckBox = CastExtensions.As<CheckBox>(target);
			break;
		case 8:
			AnimationCheckBox = CastExtensions.As<CheckBox>(target);
			break;
		case 9:
			SoundsCheckBox = CastExtensions.As<CheckBox>(target);
			break;
		case 10:
			LegacyTextureSetCheckBox = CastExtensions.As<CheckBox>(target);
			break;
		case 11:
			AutoImportCheckBox = CastExtensions.As<CheckBox>(target);
			break;
		case 12:
			OutputPathTextBox = CastExtensions.As<TextBox>(target);
			break;
		case 13:
			InputPathTextBox = CastExtensions.As<TextBox>(target);
			break;
		case 14:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(ChooseInputButton_Click);
			break;
		case 15:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(ChooseInputFolderButton_Click);
			break;
		case 16:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(ChooseOutputButton_Click);
			break;
		case 17:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(BenefitsButton_Click);
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
	private static void _cctor()
	{
	}
}
