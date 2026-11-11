using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace SRwlNQf9OPT4S1ITMMiQ;

internal class uhJLCZf9tccNtoSWw6mU
{
	private static readonly object cfVf9wvap9j;

	internal static object IAlWBqZNhNuqIeJGXCDP;

	internal static JsonDocumentOptions Options
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			JsonDocumentOptions val = default(JsonDocumentOptions);
			(val).AllowTrailingCommas = true;
			return default(JsonDocumentOptions);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static ReadOnlyMemory<byte> QdMf95RGUGc(ReadOnlyMemory<byte> bytes)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		return default(ReadOnlyMemory<byte>);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string BdTf96BUDHq(object path)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		return ((global::System.Text.Encoding)(cfVf9wvap9j)).GetString(QdMf95RGUGc(((ReadOnlyMemory<byte>)System.IO.File.ReadAllBytes((string)path))).Span);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static JsonDocument ugxf9RsOEV8(object path)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return System.Text.Json.JsonDocument.Parse(QdMf95RGUGc(((ReadOnlyMemory<byte>)System.IO.File.ReadAllBytes((string)path))), Options);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool mkLg7HZNUCU0OYxWtIsN()
	{
		return IAlWBqZNhNuqIeJGXCDP == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static uhJLCZf9tccNtoSWw6mU wxdQLvZNr4hpJwPZmZVX()
	{
		return (uhJLCZf9tccNtoSWw6mU)IAlWBqZNhNuqIeJGXCDP;
	}
}
