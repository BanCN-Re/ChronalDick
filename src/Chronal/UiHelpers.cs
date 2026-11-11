using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Microsoft.Windows.Storage.Pickers;
using Windows.ApplicationModel.DataTransfer;
using Windows.UI;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI;

internal static class UiHelpers
{
	[CompilerGenerated]
	private static class __O_9
	{
		public static Func<string, string> _0___EscapeCsv;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_24
	{
		public static readonly __c_24 __9;

		public static Func<string, bool> __9__8_0;

		[MethodImpl((MethodImplOptions)8)]
		static __c_24()
		{
			__9 = (__c_24)new __c_24();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_24()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _SplitLines_b__8_0(string line)
		{
			return !string.IsNullOrWhiteSpace(line);
		}
	}

	private const char ByteOrderMark = '\ufeff';

	private static readonly char[] LineSeparators;

	[MethodImpl((MethodImplOptions)8)]
	internal static void Replace<T>(ObservableCollection<T> target, global::System.Collections.Generic.IEnumerable<T> values)
	{
		((Collection<T>)(object)target).Clear();
		global::System.Collections.Generic.IEnumerator<T> enumerator = values.GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				T current = enumerator.Current;
				((Collection<T>)(object)target).Add(current);
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string GetMachineValue(Dictionary<string, string> machine, string key)
	{
		string text = default(string);
		if (!machine.TryGetValue(key, out text) || string.IsNullOrWhiteSpace(text))
		{
			return "-";
		}
		return text;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int ParseInt(string value, int fallback)
	{
		int result = default(int);
		if (!int.TryParse(value, (NumberStyles)7, (IFormatProvider)(object)CultureInfo.InvariantCulture, out result))
		{
			return fallback;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static decimal ParseDecimal(string value)
	{
		decimal result = default(decimal);
		if (!decimal.TryParse(value, (NumberStyles)111, (IFormatProvider)(object)CultureInfo.InvariantCulture, out result))
		{
			return 0m;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int RequireInteger(NumberBox input, string fieldName)
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		if (double.IsNaN(input.Value) || double.IsInfinity(input.Value) || input.Value != Math.Truncate(input.Value) || input.Value < input.Minimum || input.Value > input.Maximum)
		{
			throw new InvalidOperationException($"{fieldName}必须是 {input.Minimum:0} 到 {input.Maximum:0} 之间的整数");
		}
		return checked((int)input.Value);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static decimal RequireDecimal(NumberBox input, string fieldName)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		if (double.IsNaN(input.Value) || double.IsInfinity(input.Value) || input.Value < input.Minimum || input.Value > input.Maximum)
		{
			throw new InvalidOperationException($"{fieldName}必须是 {input.Minimum:0.##} 到 {input.Maximum:0.##} 之间的数值");
		}
		decimal num = (decimal)input.Value;
		if (decimal.Round(num, 2) != num)
		{
			throw new InvalidOperationException(fieldName + "最多两位小数");
		}
		return num;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static List<string> SplitLines(string value)
	{
		return Enumerable.ToList<string>(Enumerable.Where<string>((global::System.Collections.Generic.IEnumerable<string>)value.Split(LineSeparators, (StringSplitOptions)3), (Func<string, bool>)([MethodImpl((MethodImplOptions)8)] (string line) => !string.IsNullOrWhiteSpace(line))));
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void CopyToClipboard(string text)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		try
		{
			DataPackage val = new DataPackage();
			val.SetText(text);
			Clipboard.SetContent(val);
		}
		catch
		{
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static SolidColorBrush? TryCreateBrush(string? value)
	{
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		try
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				return null;
			}
			string text = value.Trim();
			if (text.Length < 4 || text[0] != '#')
			{
				return null;
			}
			string text2 = text.Substring(1);
			if (text2.Length == 3)
			{
				text2 = new string(new char[6]
				{
					text2[0],
					text2[0],
					text2[1],
					text2[1],
					text2[2],
					text2[2]
				});
			}
			if (text2.Length == 6)
			{
				text2 = "FF" + text2;
			}
			uint num = default(uint);
			if (text2.Length != 8 || !uint.TryParse(text2, (NumberStyles)515, (IFormatProvider)(object)CultureInfo.InvariantCulture, out num))
			{
				return null;
			}
			return new SolidColorBrush(Color.FromArgb((byte)((num >> 24) & 0xFF), (byte)((num >> 16) & 0xFF), (byte)((num >> 8) & 0xFF), (byte)(num & 0xFF)));
		}
		catch (global::System.Exception)
		{
			return null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string EscapeCsv(string value)
	{
		return "\"" + value.Replace("\"", "\"\"") + "\"";
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static async global::System.Threading.Tasks.Task<int> ExportLinesAsync(nint windowHandle, string prefix, global::System.Collections.Generic.IEnumerable<string> values)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		List<string> val = Enumerable.ToList<string>(values);
		string text = await DesktopFilePicker.PickSaveFileAsync(windowHandle, (PickerLocationId)0, $"{prefix}-{(global::System.DateTime.Now):yyyyMMdd-HHmmss}", new global::__z__ReadOnlyArray_1<DesktopFileTypeChoice>(new DesktopFileTypeChoice[2]
		{
			(DesktopFileTypeChoice)new DesktopFileTypeChoice("TXT", (global::System.Collections.Generic.IReadOnlyList<string>)new global::__z__ReadOnlySingleElementList_1<string>(".txt")),
			(DesktopFileTypeChoice)new DesktopFileTypeChoice("CSV", (global::System.Collections.Generic.IReadOnlyList<string>)new global::__z__ReadOnlySingleElementList_1<string>(".csv"))
		}), "导出文本");
		if (text == null)
		{
			return -1;
		}
		string text2 = (Path.GetExtension(text).Equals(".csv", (StringComparison)5) ? ("\ufeffvalue\r\n" + string.Join("\r\n", Enumerable.Select<string, string>((global::System.Collections.Generic.IEnumerable<string>)val, (Func<string, string>)EscapeCsv))) : string.Join(Environment.NewLine, (global::System.Collections.Generic.IEnumerable<string>)val));
		await File.WriteAllTextAsync(text, text2, (Encoding)new UTF8Encoding(false), default(CancellationToken));
		return val.Count;
	}

	[MethodImpl((MethodImplOptions)8)]
	static UiHelpers()
	{
		char[] array = new char[7];
		LineSeparators = array;
	}
}
