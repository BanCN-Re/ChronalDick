using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.UI.Xaml.Media.Imaging;
using Windows.Storage.Streams;
using bUfedyCg1PBqhqIkB8r;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI;

internal static class PaymentQrImageDecoder
{
	private const int MaxImageBytes = 524288;

	private const int MaxEncodedLength = 699056;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public static async global::System.Threading.Tasks.Task<BitmapImage> DecodeAsync(string dataUrl)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrWhiteSpace(dataUrl))
		{
			throw new FormatException("支付二维码图片数据为空");
		}
		int num = dataUrl.IndexOf(',');
		if (num <= 0 || num >= dataUrl.Length - 1)
		{
			throw new FormatException("支付二维码图片数据无效");
		}
		string text = dataUrl.Substring(0, num).Trim().ToLowerInvariant();
		string text2 = dataUrl.Substring(num + 1).Trim();
		bool flag = ((text == "data:image/png;base64" || text == "data:image/jpeg;base64" || text == "data:image/gif;base64") ? true : false);
		if (!flag || text2.Length > 699056)
		{
			throw new FormatException("支付二维码图片格式无效或数据过大");
		}
		byte[] array;
		try
		{
			array = Convert.FromBase64String(text2);
		}
		catch (FormatException ex)
		{
			FormatException ex2 = ex;
			cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)ex2, "ui-exception", "DecodeAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\PaymentQrImageDecoder.cs", 41);
			throw new FormatException("支付二维码图片 Base64 数据无效", (global::System.Exception)(object)ex2);
		}
		if (array.Length == 0 || array.Length > 524288 || !HasExpectedSignature(text, array))
		{
			throw new FormatException("支付二维码图片内容无效或数据过大");
		}
		try
		{
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
				BitmapImage val4 = new BitmapImage();
				TaskAwaiter val5 = WindowsRuntimeSystemExtensions.GetAwaiter(((BitmapSource)val4).SetSourceAsync((IRandomAccessStream)(object)val));
				if (!val5.IsCompleted)
				{
					val5.GetResult();
					TaskAwaiter val6 = default(TaskAwaiter);
					val5 = val6;
				}
				val5.GetResult();
				return val4;
			}
			finally
			{
				((global::System.IDisposable)val)?.Dispose();
			}
		}
		catch (global::System.Exception ex3)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex3, "ui-exception", "DecodeAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\PaymentQrImageDecoder.cs", 61);
			throw new InvalidOperationException("支付二维码图片无法解码", ex3);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static bool HasExpectedSignature(string mediaType, global::System.ReadOnlySpan<byte> bytes)
	{
		if (!(mediaType == "data:image/png;base64"))
		{
			if (!(mediaType == "data:image/jpeg;base64"))
			{
				if (mediaType == "data:image/gif;base64")
				{
					return bytes.Length >= 6 && (MemoryExtensions.SequenceEqual<byte>(bytes.Slice(0, 6), "GIF87a"u8) || MemoryExtensions.SequenceEqual<byte>(bytes.Slice(0, 6), "GIF89a"u8));
				}
				return false;
			}
			return bytes.Length >= 3 && *(short*)bytes[0] == 255 && *(short*)bytes[1] == 216 && *(short*)bytes[2] == 255;
		}
		return bytes.Length >= 8 && MemoryExtensions.SequenceEqual<byte>(bytes.Slice(0, 8), (global::System.ReadOnlySpan<byte>)new byte[8] { 137, 80, 78, 71, 13, 10, 26, 10 });
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}
