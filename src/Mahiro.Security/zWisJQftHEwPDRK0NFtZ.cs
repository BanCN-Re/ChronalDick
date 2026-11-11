using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using UgQiY1ft9otOGC1t7c69;
using fDAldojjppXrctUVYOJn;
using mxcLK5ftbOSeIbYOjPNf;

namespace kDoWDXfttqYF7ipR22XV;

public sealed class zWisJQftHEwPDRK0NFtZ
{
	private List<nQWwHEfHzpacwJ7BMYfS>? _roles;

	private List<string>? _permissions;

	private static object gYbhubZ2sOUH4gB8QklD;

	[JsonPropertyName("id")]
	[field: CompilerGenerated]
	public long Id
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("username")]
	[field: CompilerGenerated]
	public string Username
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("roles")]
	public List<nQWwHEfHzpacwJ7BMYfS> Roles
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			List<nQWwHEfHzpacwJ7BMYfS> val = (_roles = new List<nQWwHEfHzpacwJ7BMYfS>());
			return null;
		}
		[MethodImpl((MethodImplOptions)8)]
		set
		{
			_roles = value;
		}
	}

	[JsonPropertyName("primaryRole")]
	[field: CompilerGenerated]
	public nQWwHEfHzpacwJ7BMYfS? PrimaryRole
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("permissions")]
	public List<string> Permissions
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			List<string> val = (_permissions = new List<string>());
			return null;
		}
		[MethodImpl((MethodImplOptions)8)]
		set
		{
			_permissions = value;
		}
	}

	[JsonPropertyName("balance")]
	[field: CompilerGenerated]
	public decimal Balance
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("isDisabled")]
	[field: CompilerGenerated]
	public bool IsDisabled
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("machineCount")]
	[field: CompilerGenerated]
	public int MachineCount
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonIgnore]
	public string StatusText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return null;
		}
	}

	[JsonIgnore]
	public bool IsAdmin
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Yoqps7ftZIAYLEFdjh16.m6gftDf1qX7((global::System.Collections.Generic.IEnumerable<string>?)_permissions, "admin.access");
		}
	}

	[JsonIgnore]
	public global::System.Collections.Generic.IReadOnlyList<nQWwHEfHzpacwJ7BMYfS> OrderedRoles
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Yoqps7ftZIAYLEFdjh16.LJxftVtqNhQ((global::System.Collections.Generic.IEnumerable<nQWwHEfHzpacwJ7BMYfS>?)_roles);
		}
	}

	[JsonIgnore]
	public string RoleText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return null;
		}
	}

	[JsonIgnore]
	public string AllRolesText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			string text = Yoqps7ftZIAYLEFdjh16.EHEftYPfv6v((global::System.Collections.Generic.IEnumerable<nQWwHEfHzpacwJ7BMYfS>?)_roles);
			return null;
		}
	}

	[JsonIgnore]
	public string UsernameDisplay
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return null;
		}
	}

	[JsonIgnore]
	public string BalanceText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			decimal balance = Balance;
			return null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public bool GEMftOy0s2m(string code)
	{
		return Yoqps7ftZIAYLEFdjh16.u6wftkJvK7b((global::System.Collections.Generic.IEnumerable<nQWwHEfHzpacwJ7BMYfS>?)_roles, code);
	}

	[MethodImpl((MethodImplOptions)8)]
	public zWisJQftHEwPDRK0NFtZ()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool GiIi6fZ2TYV4QDqbSqyj()
	{
		return gYbhubZ2sOUH4gB8QklD == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static zWisJQftHEwPDRK0NFtZ r6y0xOZ2NDNPRbAIS5Fu()
	{
		return (zWisJQftHEwPDRK0NFtZ)gYbhubZ2sOUH4gB8QklD;
	}
}
