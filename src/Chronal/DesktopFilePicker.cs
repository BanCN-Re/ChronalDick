using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using Microsoft.UI;
using Microsoft.Windows.Storage.Pickers;
using bUfedyCg1PBqhqIkB8r;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI;

internal static class DesktopFilePicker
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_22
	{
		public static __c_22 __9;

		public static Func<string, bool> __9__3_0;

		public static Func<string, string> __9__3_1;

		public static Func<string, bool> __9__3_2;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			__9 = (__c_22)new __c_22();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_22()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _NormalizeFileTypes_b__3_0(string fileType)
		{
			return !string.IsNullOrWhiteSpace(fileType);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string _NormalizeFileTypes_b__3_1(string fileType)
		{
			return fileType.Trim();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _NormalizeFileTypes_b__3_2(string fileType)
		{
			if (fileType != "*")
			{
				return !fileType.StartsWith('.');
			}
			return false;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static async global::System.Threading.Tasks.Task<string?> PickOpenFileAsync(nint windowHandle, PickerLocationId startLocation, global::System.Collections.Generic.IReadOnlyList<string> fileTypes, string title)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ValidateWindowHandle(windowHandle);
			ArgumentNullException.ThrowIfNull((object)fileTypes, "fileTypes");
			FileOpenPicker val = new FileOpenPicker(Win32Interop.GetWindowIdFromWindow((global::System.IntPtr)windowHandle))
			{
				SuggestedStartLocation = startLocation,
				Title = title
			};
			var enumerator = NormalizeFileTypes((global::System.Collections.Generic.IEnumerable<string>)fileTypes).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					((global::System.Collections.Generic.ICollection<string>)val.FileTypeFilter).Add(current);
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
			}
			TaskAwaiter<PickFileResult> val2 = WindowsRuntimeSystemExtensions.GetAwaiter<PickFileResult>(val.PickSingleFileAsync());
			if (!val2.IsCompleted)
			{
				val2.GetResult();
				TaskAwaiter<PickFileResult> val3 = default(TaskAwaiter<PickFileResult>);
				val2 = val3;
			}
			PickFileResult result = val2.GetResult();
			return string.IsNullOrWhiteSpace((result != null) ? result.Path : null) ? null : result.Path;
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "PickOpenFileAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\DesktopFilePicker.cs", 46);
			ReportFailure("打开文件选择器", ex);
			return null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static async global::System.Threading.Tasks.Task<string?> PickFolderAsync(nint windowHandle, PickerLocationId startLocation, string title)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ValidateWindowHandle(windowHandle);
			TaskAwaiter<PickFolderResult> val = WindowsRuntimeSystemExtensions.GetAwaiter<PickFolderResult>(new FolderPicker(Win32Interop.GetWindowIdFromWindow((global::System.IntPtr)windowHandle))
			{
				SuggestedStartLocation = startLocation,
				Title = title
			}.PickSingleFolderAsync());
			if (!val.IsCompleted)
			{
				val.GetResult();
				TaskAwaiter<PickFolderResult> val2 = default(TaskAwaiter<PickFolderResult>);
				val = val2;
			}
			PickFolderResult result = val.GetResult();
			return string.IsNullOrWhiteSpace((result != null) ? result.Path : null) ? null : result.Path;
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "PickFolderAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\DesktopFilePicker.cs", 71);
			ReportFailure("打开文件夹选择器", ex);
			return null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static async global::System.Threading.Tasks.Task<string?> PickSaveFileAsync(nint windowHandle, PickerLocationId startLocation, string suggestedFileName, global::System.Collections.Generic.IReadOnlyList<DesktopFileTypeChoice> fileTypeChoices, string title)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ValidateWindowHandle(windowHandle);
			ArgumentNullException.ThrowIfNull((object)fileTypeChoices, "fileTypeChoices");
			FileSavePicker val = new FileSavePicker(Win32Interop.GetWindowIdFromWindow((global::System.IntPtr)windowHandle))
			{
				SuggestedStartLocation = startLocation,
				SuggestedFileName = (suggestedFileName ?? string.Empty),
				Title = title
			};
			global::System.Collections.Generic.IEnumerator<DesktopFileTypeChoice> enumerator = ((global::System.Collections.Generic.IEnumerable<DesktopFileTypeChoice>)fileTypeChoices).GetEnumerator();
			try
			{
				while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
				{
					DesktopFileTypeChoice current = enumerator.Current;
					if (string.IsNullOrWhiteSpace(current.DisplayName))
					{
						throw new ArgumentException("文件类型名称不能为空", "fileTypeChoices");
					}
					List<string> val2 = NormalizeFileTypes((global::System.Collections.Generic.IEnumerable<string>)current.Extensions);
					val.FileTypeChoices.Add(current.DisplayName.Trim(), (global::System.Collections.Generic.IList<string>)val2);
					if (string.IsNullOrWhiteSpace(val.DefaultFileExtension))
					{
						val.DefaultFileExtension = val2[0];
					}
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator)?.Dispose();
			}
			if (((global::System.Collections.Generic.ICollection<KeyValuePair<string, global::System.Collections.Generic.IList<string>>>)val.FileTypeChoices).Count == 0)
			{
				throw new ArgumentException("至少需要一个保存文件类型", "fileTypeChoices");
			}
			TaskAwaiter<PickFileResult> val3 = WindowsRuntimeSystemExtensions.GetAwaiter<PickFileResult>(val.PickSaveFileAsync());
			if (!val3.IsCompleted)
			{
				val3.GetResult();
				TaskAwaiter<PickFileResult> val4 = default(TaskAwaiter<PickFileResult>);
				val3 = val4;
			}
			PickFileResult result = val3.GetResult();
			return string.IsNullOrWhiteSpace((result != null) ? result.Path : null) ? null : result.Path;
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "PickSaveFileAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\DesktopFilePicker.cs", 121);
			ReportFailure("打开保存文件选择器", ex);
			return null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static List<string> NormalizeFileTypes(global::System.Collections.Generic.IEnumerable<string> fileTypes)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		List<string> obj = Enumerable.ToList<string>(Enumerable.Distinct<string>(Enumerable.Select<string, string>(Enumerable.Where<string>(fileTypes, (Func<string, bool>)([MethodImpl((MethodImplOptions)8)] (string fileType) => !string.IsNullOrWhiteSpace(fileType))), (Func<string, string>)([MethodImpl((MethodImplOptions)8)] (string fileType) => fileType.Trim())), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase));
		if (obj.Count == 0)
		{
			throw new ArgumentException("至少需要一个文件类型", "fileTypes");
		}
		if (Enumerable.Any<string>((global::System.Collections.Generic.IEnumerable<string>)obj, (Func<string, bool>)([MethodImpl((MethodImplOptions)8)] (string fileType) => fileType != "*" && !fileType.StartsWith('.'))))
		{
			throw new ArgumentException("文件扩展名必须以句点开头", "fileTypes");
		}
		return obj;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void ValidateWindowHandle(nint windowHandle)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (windowHandle == 0)
		{
			throw new InvalidOperationException("主窗口句柄尚未初始化");
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void ReportFailure(string operation, global::System.Exception exception)
	{
		try
		{
			AppShell.Error(operation + "失败：" + AppShell.GetExceptionDisplayMessage(exception, "ReportFailure", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\DesktopFilePicker.cs", 157));
		}
		catch
		{
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}
