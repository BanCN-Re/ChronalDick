using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;

namespace MnCNHgfwhm1BlAufHdT1;

sealed class UfjqWXfw4LbmaQBvftfE : global::System.Exception
{
	private static readonly object JsonOptions;

	internal static object lRMGK59Xm5DAcKwuoaTY;

	[field: CompilerGenerated]
	public int Status
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public string Code
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public JsonElement Details
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[MethodImpl((MethodImplOptions)8)]
	public UfjqWXfw4LbmaQBvftfE(string message, int status, string? code, JsonElement details)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	public T? O4ufwUZNxYR<T>(string propertyName) where T : class
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		JsonElement details = Details;
		if ((int)(details).ValueKind == 1)
		{
			details = Details;
			JsonElement val = default(JsonElement);
			if ((details).TryGetProperty(propertyName, out val))
			{
				try
				{
					return JsonSerializer.Deserialize<T>((val).GetRawText(), (JsonSerializerOptions)JsonOptions);
				}
				catch (JsonException)
				{
					return null;
				}
			}
		}
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool tgOELw9X7t73oNtAuYGD()
	{
		return lRMGK59Xm5DAcKwuoaTY == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static UfjqWXfw4LbmaQBvftfE qqEeFx9XAUGfNaShyqPb()
	{
		return (UfjqWXfw4LbmaQBvftfE)lRMGK59Xm5DAcKwuoaTY;
	}
}
