using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.Win32;
using Windows.Storage.Streams;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI;

internal static class WindowsAccountPicture
{
	[CompilerGenerated]
	private static class __O_4
	{
		public static Func<string, bool> _0___Exists;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_18
	{
		public static readonly __c_18 __9;

		public static Func<string, global::System.Collections.Generic.IEnumerable<FileInfo>> __9__9_0;

		public static Func<FileInfo, bool> __9__9_1;

		public static Func<FileInfo, global::__f__AnonymousType9_2<FileInfo, int>> __9__9_2;

		public static Func<global::__f__AnonymousType9_2<FileInfo, int>, bool> __9__9_3;

		public static Func<global::__f__AnonymousType9_2<FileInfo, int>, int> __9__9_4;

		public static Func<global::__f__AnonymousType9_2<FileInfo, int>, int> __9__9_5;

		public static Func<global::__f__AnonymousType9_2<FileInfo, int>, long> __9__9_6;

		[MethodImpl((MethodImplOptions)8)]
		static __c_18()
		{
			__9 = (__c_18)new __c_18();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_18()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Collections.Generic.IEnumerable<FileInfo> _ScanAccountPictureFolders_b__9_0(string folder)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			return new DirectoryInfo(folder).EnumerateFiles("*", (SearchOption)0);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _ScanAccountPictureFolders_b__9_1(FileInfo file)
		{
			return Enumerable.Contains<string>((global::System.Collections.Generic.IEnumerable<string>)ImageExtensions, ((FileSystemInfo)file).Extension.ToLowerInvariant());
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::__f__AnonymousType9_2<FileInfo, int> _ScanAccountPictureFolders_b__9_2(FileInfo file)
		{
			return new global::__f__AnonymousType9_2<FileInfo, int>(file, ParseImageSize(((FileSystemInfo)file).Name));
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _ScanAccountPictureFolders_b__9_3(global::__f__AnonymousType9_2<FileInfo, int> candidate)
		{
			return candidate.Size >= 128;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal int _ScanAccountPictureFolders_b__9_4(global::__f__AnonymousType9_2<FileInfo, int> candidate)
		{
			return candidate.Size;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal int _ScanAccountPictureFolders_b__9_5(global::__f__AnonymousType9_2<FileInfo, int> candidate)
		{
			return candidate.Size;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal long _ScanAccountPictureFolders_b__9_6(global::__f__AnonymousType9_2<FileInfo, int> candidate)
		{
			return candidate.File.Length;
		}
	}

	private const string AccountPictureKeyPath = "Software\\Microsoft\\Windows\\CurrentVersion\\AccountPicture";

	private static readonly string[] SizeValueNames;

	private static readonly string[] ImageExtensions;

	private static readonly Regex ImageSizeSuffix;

	private const int PreferredPixelSize = 128;

	private static BitmapImage? _cached;

	private static bool _resolved;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static async global::System.Threading.Tasks.Task<BitmapImage?> GetAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (_resolved)
		{
			return _cached;
		}
		_resolved = true;
		try
		{
			string text = ResolvePicturePath();
			if (string.IsNullOrWhiteSpace(text))
			{
				return null;
			}
			byte[] array = await File.ReadAllBytesAsync(text, default(CancellationToken));
			InMemoryRandomAccessStream val = new InMemoryRandomAccessStream();
			try
			{
				TaskAwaiter<uint> val2 = WindowsRuntimeSystemExtensions.GetAwaiter<uint, uint>(val.WriteAsync(WindowsRuntimeBufferExtensions.AsBuffer(array)));
				if (!val2.IsCompleted)
				{
					val2.GetResult();
					TaskAwaiter<uint> val3 = default(TaskAwaiter<uint>);
					val2 = val3;
				}
				val2.GetResult();
				val.Seek(0uL);
				BitmapImage val4 = new BitmapImage
				{
					DecodePixelWidth = 96
				};
				TaskAwaiter val5 = WindowsRuntimeSystemExtensions.GetAwaiter(((BitmapSource)val4).SetSourceAsync((IRandomAccessStream)(object)val));
				if (!val5.IsCompleted)
				{
					val5.GetResult();
					TaskAwaiter val6 = default(TaskAwaiter);
					val5 = val6;
				}
				val5.GetResult();
				_cached = val4;
			}
			finally
			{
				((global::System.IDisposable)val)?.Dispose();
			}
		}
		catch (global::System.Exception)
		{
			_cached = null;
		}
		return _cached;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string? ResolvePicturePath()
	{
		try
		{
			RegistryKey val = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\AccountPicture");
			try
			{
				if (val != null)
				{
					string[] sizeValueNames = SizeValueNames;
					foreach (string text in sizeValueNames)
					{
						if (val.GetValue(text) is string text2 && IsUsablePicture(text2))
						{
							return text2;
						}
					}
				}
			}
			finally
			{
				((global::System.IDisposable)val)?.Dispose();
			}
		}
		catch (global::System.Exception)
		{
		}
		return ScanAccountPictureFolders();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string? ScanAccountPictureFolders()
	{
		try
		{
			List<global::__f__AnonymousType9_2<FileInfo, int>> val = Enumerable.ToList<global::__f__AnonymousType9_2<FileInfo, int>>(Enumerable.Select<FileInfo, global::__f__AnonymousType9_2<FileInfo, int>>(Enumerable.Where<FileInfo>(Enumerable.SelectMany<string, FileInfo>(Enumerable.Where<string>(EnumerateCandidateFolders(), (Func<string, bool>)Directory.Exists), (Func<string, global::System.Collections.Generic.IEnumerable<FileInfo>>)([MethodImpl((MethodImplOptions)8)] (string folder) => new DirectoryInfo(folder).EnumerateFiles("*", (SearchOption)0))), (Func<FileInfo, bool>)([MethodImpl((MethodImplOptions)8)] (FileInfo file) => Enumerable.Contains<string>((global::System.Collections.Generic.IEnumerable<string>)ImageExtensions, ((FileSystemInfo)file).Extension.ToLowerInvariant()))), (Func<FileInfo, global::__f__AnonymousType9_2<FileInfo, int>>)([MethodImpl((MethodImplOptions)8)] (FileInfo file) => new global::__f__AnonymousType9_2<FileInfo, int>(file, ParseImageSize(((FileSystemInfo)file).Name)))));
			if (val.Count == 0)
			{
				return null;
			}
			global::__f__AnonymousType9_2<FileInfo, int> _f__AnonymousType9_ = Enumerable.FirstOrDefault<global::__f__AnonymousType9_2<FileInfo, int>>((global::System.Collections.Generic.IEnumerable<global::__f__AnonymousType9_2<FileInfo, int>>)Enumerable.OrderBy<global::__f__AnonymousType9_2<FileInfo, int>, int>(Enumerable.Where<global::__f__AnonymousType9_2<FileInfo, int>>((global::System.Collections.Generic.IEnumerable<global::__f__AnonymousType9_2<FileInfo, int>>)val, (Func<global::__f__AnonymousType9_2<FileInfo, int>, bool>)([MethodImpl((MethodImplOptions)8)] (global::__f__AnonymousType9_2<FileInfo, int> candidate) => candidate.Size >= 128)), (Func<global::__f__AnonymousType9_2<FileInfo, int>, int>)([MethodImpl((MethodImplOptions)8)] (global::__f__AnonymousType9_2<FileInfo, int> candidate) => candidate.Size)));
			if (_f__AnonymousType9_ == null)
			{
				_f__AnonymousType9_ = Enumerable.First<global::__f__AnonymousType9_2<FileInfo, int>>((global::System.Collections.Generic.IEnumerable<global::__f__AnonymousType9_2<FileInfo, int>>)Enumerable.ThenByDescending<global::__f__AnonymousType9_2<FileInfo, int>, long>(Enumerable.OrderByDescending<global::__f__AnonymousType9_2<FileInfo, int>, int>((global::System.Collections.Generic.IEnumerable<global::__f__AnonymousType9_2<FileInfo, int>>)val, (Func<global::__f__AnonymousType9_2<FileInfo, int>, int>)([MethodImpl((MethodImplOptions)8)] (global::__f__AnonymousType9_2<FileInfo, int> candidate) => candidate.Size)), (Func<global::__f__AnonymousType9_2<FileInfo, int>, long>)([MethodImpl((MethodImplOptions)8)] (global::__f__AnonymousType9_2<FileInfo, int> candidate) => candidate.File.Length)));
			}
			return ((FileSystemInfo)_f__AnonymousType9_.File).FullName;
		}
		catch (global::System.Exception)
		{
			return null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int ParseImageSize(string fileName)
	{
		Match val = ImageSizeSuffix.Match(fileName);
		int result = default(int);
		if (!((Group)val).Success || !int.TryParse(((Capture)val.Groups[1]).Value, out result))
		{
			return 0;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	[IteratorStateMachine(typeof(object))]
	private static global::System.Collections.Generic.IEnumerable<string> EnumerateCandidateFolders()
	{
		yield return Path.Combine(Environment.GetFolderPath((System.Environment.SpecialFolder)26), "Microsoft", "Windows", "AccountPictures");
		string environmentVariable = Environment.GetEnvironmentVariable("PUBLIC");
		string text = CurrentUserSid();
		if (!string.IsNullOrWhiteSpace(environmentVariable) && !string.IsNullOrWhiteSpace(text))
		{
			yield return Path.Combine(environmentVariable, "AccountPictures", text);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string? CurrentUserSid()
	{
		try
		{
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			try
			{
				SecurityIdentifier user = current.User;
				return (user != null) ? ((IdentityReference)user).Value : null;
			}
			finally
			{
				((global::System.IDisposable)current)?.Dispose();
			}
		}
		catch (global::System.Exception)
		{
			return null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool IsUsablePicture(string path)
	{
		if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
		{
			return false;
		}
		return path.IndexOf("ProgramData\\Microsoft\\User Account Pictures", (StringComparison)5) < 0;
	}

	[MethodImpl((MethodImplOptions)8)]
	static WindowsAccountPicture()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		SizeValueNames = new string[7] { "Image448", "Image240", "Image192", "Image96", "Image64", "Image48", "Image32" };
		ImageExtensions = new string[4] { ".png", ".jpg", ".jpeg", ".bmp" };
		ImageSizeSuffix = new Regex("-Image(\\d+)\\.", (RegexOptions)1);
	}
}
