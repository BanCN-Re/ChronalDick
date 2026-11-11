using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using UgQiY1ft9otOGC1t7c69;
using fDAldojjppXrctUVYOJn;
using mxcLK5ftbOSeIbYOjPNf;

namespace LlvQkpftcKTPAsaRP0ff;

public sealed class dN4xMCftS2WHJlRJeqrU
{
	private List<nQWwHEfHzpacwJ7BMYfS>? _roles;

	private List<string>? _permissions;

	internal static object i1gK5iZ2yhObNHiPgVyM;

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

	[JsonPropertyName("email")]
	[field: CompilerGenerated]
	public string? Email
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("emailVerified")]
	[field: CompilerGenerated]
	public bool EmailVerified
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("emailPromptRequired")]
	[field: CompilerGenerated]
	public bool EmailPromptRequired
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("emailPromptMandatory")]
	[field: CompilerGenerated]
	public bool EmailPromptMandatory
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonIgnore]
	public bool IsAdmin
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return mU8ft0PnnBZ("admin.access");
		}
	}

	[JsonIgnore]
	public string PrimaryRoleText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return null;
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
	public string AllRolesText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Yoqps7ftZIAYLEFdjh16.EHEftYPfv6v((global::System.Collections.Generic.IEnumerable<nQWwHEfHzpacwJ7BMYfS>?)_roles);
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

	[JsonIgnore]
	public bool HasVerifiedEmail
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return default(bool);
		}
	}

	[JsonIgnore]
	public string EmailDisplayText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 2;
			return null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public bool mU8ft0PnnBZ(string code)
	{
		return Yoqps7ftZIAYLEFdjh16.m6gftDf1qX7((global::System.Collections.Generic.IEnumerable<string>?)_permissions, code);
	}

	[MethodImpl((MethodImplOptions)8)]
	public bool A9gft8PPVaZ(string code)
	{
		return Yoqps7ftZIAYLEFdjh16.u6wftkJvK7b((global::System.Collections.Generic.IEnumerable<nQWwHEfHzpacwJ7BMYfS>?)_roles, code);
	}

	[MethodImpl((MethodImplOptions)8)]
	public dN4xMCftS2WHJlRJeqrU()
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
	internal static bool py96NDZ2Wsmcrf4XWlgk()
	{
		return i1gK5iZ2yhObNHiPgVyM == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static dN4xMCftS2WHJlRJeqrU MlLcuVZ2Jfg9BjoJeMOm()
	{
		return (dN4xMCftS2WHJlRJeqrU)i1gK5iZ2yhObNHiPgVyM;
	}
}
