using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using RyDfSXfPyKj0ty7cSIxY;
using esTqgmfP4oivfMZ0NWmg;
using fDAldojjppXrctUVYOJn;
using lO2F7FfPr06ErwscbOD2;

namespace PsXpS654E57g4aJfi0E;

sealed class p7aMTy5CiDjPcd5Qwt6 : global::System.IDisposable
{
	private sealed class bcATbBfGSAoRYQCqLAfa : IEquatable<bcATbBfGSAoRYQCqLAfa>
	{
		[CompilerGenerated]
		private HttpStatusCode _StatusCode_k__BackingField;

		[CompilerGenerated]
		private bool _IsSuccessStatusCode_k__BackingField;

		[CompilerGenerated]
		private JsonElement _Json_k__BackingField;

		private static object iiwvOm9mmYpagfmFGglI;

		[CompilerGenerated]
		private global::System.Type EqualityContract
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return System.Type.GetTypeFromHandle(typeof(bcATbBfGSAoRYQCqLAfa).TypeHandle);
			}
		}

		public HttpStatusCode StatusCode
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				//IL_0004: Unknown result type (might be due to invalid IL or missing references)
				return _StatusCode_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				_StatusCode_k__BackingField = value;
			}
		}

		public bool IsSuccessStatusCode
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _IsSuccessStatusCode_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				_IsSuccessStatusCode_k__BackingField = value;
			}
		}

		public JsonElement Json
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				//IL_0004: Unknown result type (might be due to invalid IL or missing references)
				return _Json_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				_Json_k__BackingField = value;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public bcATbBfGSAoRYQCqLAfa(HttpStatusCode StatusCode, bool IsSuccessStatusCode, JsonElement Json)
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override string ToString()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			StringBuilder val = new StringBuilder();
			return null;
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private bool xsZfGcb3BXs(StringBuilder builder)
		{
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			int num = 4;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 != 13)
							{
								if (num2 == 994)
								{
									goto end_IL_0010;
								}
								goto case 6;
							}
							return true;
						case 5:
							(builder).Append(", IsSuccessStatusCode = ");
							num3 = 1;
							continue;
						case 6:
							(builder).Append(((object)Json/*cast due to .constrained prefix*/).ToString());
							num = 13;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 != 0)
							{
								num = 4;
							}
							break;
						case 2:
							(builder).Append(", Json = ");
							num = 6;
							break;
						case 0:
							(builder).Append(((object)StatusCode/*cast due to .constrained prefix*/).ToString());
							num3 = 5;
							continue;
						case 4:
							System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
							num = 3;
							break;
						case 3:
							(builder).Append("StatusCode = ");
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 != 0)
							{
								num3 = 13;
							}
							continue;
						case 1:
							(builder).Append(((object)IsSuccessStatusCode/*cast due to .constrained prefix*/).ToString());
							num3 = 2;
							continue;
						}
						goto end_IL_000c;
						continue;
						end_IL_0010:
						break;
					}
					continue;
					end_IL_000c:
					break;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator !=(bcATbBfGSAoRYQCqLAfa? left, bcATbBfGSAoRYQCqLAfa? right)
		{
			return !(left == right);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator ==(bcATbBfGSAoRYQCqLAfa? left, bcATbBfGSAoRYQCqLAfa? right)
		{
			int num = 2;
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			return ((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<HttpStatusCode>.Default.GetHashCode(_StatusCode_k__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(_IsSuccessStatusCode_k__BackingField)) * -1521134295 + EqualityComparer<JsonElement>.Default.GetHashCode(_Json_k__BackingField);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as bcATbBfGSAoRYQCqLAfa);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public bool Equals(bcATbBfGSAoRYQCqLAfa? other)
		{
			int num = 5;
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public bcATbBfGSAoRYQCqLAfa zgufG09uoDG()
		{
			return (bcATbBfGSAoRYQCqLAfa)new bcATbBfGSAoRYQCqLAfa(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private bcATbBfGSAoRYQCqLAfa(bcATbBfGSAoRYQCqLAfa original)
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 1;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
			{
				num = 1;
			}
			int num3 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					if (num3 != 10)
					{
						if (num3 == 990)
						{
							goto IL_0042;
						}
						goto case 1;
					}
					return;
				case 1:
					_StatusCode_k__BackingField = original._StatusCode_k__BackingField;
					num = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
					{
						num = 4;
					}
					break;
				case 0:
					_IsSuccessStatusCode_k__BackingField = original._IsSuccessStatusCode_k__BackingField;
					num = 2;
					break;
				case 2:
					{
						_Json_k__BackingField = original._Json_k__BackingField;
						int num2 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
						{
							num2 = 0;
						}
						num3 = num2;
						goto IL_0042;
					}
					IL_0042:
					num = num3;
					break;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public void y99fG8bs8pt(out HttpStatusCode StatusCode, out bool IsSuccessStatusCode, out JsonElement Json)
		{
		StatusCode = default(HttpStatusCode);
		IsSuccessStatusCode = default(bool);
		Json = default(JsonElement);
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			Json = this.Json;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool aWjaQx9m7kUhqggQtFfa()
		{
			return iiwvOm9mmYpagfmFGglI == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bcATbBfGSAoRYQCqLAfa lHQHbn9mAUZ429nIPadr()
		{
			return (bcATbBfGSAoRYQCqLAfa)iiwvOm9mmYpagfmFGglI;
		}
	}

	[CompilerGenerated]
	private class __O_42
	{
		public static Func<char, bool> _0___IsDigit;

		private static __O_42 pVhwAi9mI8ScRuAhIHx6;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool aGPIMv9mBYVqja0klu50()
		{
			return pVhwAi9mI8ScRuAhIHx6 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __O_42 JwyVgq9mgTynNpQVmV4M()
		{
			return pVhwAi9mI8ScRuAhIHx6;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_154
	{
		public static readonly __c_154 __9;

		public static Func<char, bool> __9__52_0;

		internal static __c_154 Gd35KL9mlwtPbN5sndZd;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_154()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool qPgfGy7GXXV(char c)
		{
			int num = 7;
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool WckX7x9md4PXuS7Cdl3V()
		{
			return Gd35KL9mlwtPbN5sndZd == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_154 iAxWV19mKxNOV0lIPtSv()
		{
			return Gd35KL9mlwtPbN5sndZd;
		}
	}

	private static readonly object mQ36V1uygb;

	private readonly object GUr6YVbDpE;

	private readonly object YYV6SATPrg;

	private readonly object cOo6cHJyIE;

	private readonly object XqZ60CtLHc;

	private object XH168NkoQo;

	private object fNN6yAPsjv;

	private object gRP6W8jTl5;

	private bool e7Z6JwPl1k;

	private static object IIoH2bZQmwO6i2SydWi0;

	[MethodImpl((MethodImplOptions)8)]
	public extern p7aMTy5CiDjPcd5Qwt6();

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public extern global::System.Threading.Tasks.Task<t30hHHfP8gMStFdbd6rB> spo5hfZ6ui(string email, string password, CancellationToken cancellationToken = default(CancellationToken), bool retryOnDeviceError = true);

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private extern global::System.Threading.Tasks.Task<t30hHHfP8gMStFdbd6rB> THy5U3sVTp(string ticket, string verifyUrl, CancellationToken cancellationToken);

	[MethodImpl((MethodImplOptions)8)]
	private static global::System.Text.RegularExpressions.Regex H155rm2NKw()
	{
		return new global::System.Text.RegularExpressions.Regex("请使用任意手机号发送\\s*(?<content>[0-9A-Za-z]+)\\s*至\\s*(?<number>[0-9]+)(?:\\s*[（(](?<backup>[0-9]+)备用)?");
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public extern global::System.Threading.Tasks.Task<t30hHHfP8gMStFdbd6rB> o9e5oE3eau(string ticket, CancellationToken cancellationToken = default(CancellationToken));

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public extern global::System.Threading.Tasks.Task<t30hHHfP8gMStFdbd6rB> lwC5m1qfoG(string ticket, string code, CancellationToken cancellationToken = default(CancellationToken));

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public extern global::System.Threading.Tasks.Task<t30hHHfP8gMStFdbd6rB> hmF57u3jTT(string ticket, CancellationToken cancellationToken = default(CancellationToken));

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private extern global::System.Threading.Tasks.Task<bool> pO85A3kJIY(CancellationToken cancellationToken);

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private extern global::System.Threading.Tasks.Task<bool> GIO5Ioj5WS(CancellationToken cancellationToken);

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private extern global::System.Threading.Tasks.Task<bool> D9X5BlAvG7(CancellationToken cancellationToken);

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private extern global::System.Threading.Tasks.Task UploadDeviceAsync(CancellationToken cancellationToken);

	[MethodImpl((MethodImplOptions)8)]
	private extern VVNUCJfPCAie2vDiULu2 rSa5g9N5ho();

	[MethodImpl((MethodImplOptions)8)]
	private extern void JHw5l0bY0K();

	[MethodImpl((MethodImplOptions)8)]
	private extern Dictionary<string, string> waB5dNs2dA();

	[MethodImpl((MethodImplOptions)8)]
	private extern Dictionary<string, string> SJP5KyTnju();

	[MethodImpl((MethodImplOptions)8)]
	private extern Dictionary<string, string> tIo5HRg8mJ();

	[MethodImpl((MethodImplOptions)8)]
	private extern string U4y5tyE4Xk(string email, string passwordMd5);

	[MethodImpl((MethodImplOptions)8)]
	private static extern byte[]? aRI5OPJ25M(object deviceKey);

	[MethodImpl((MethodImplOptions)8)]
	private extern string K54552rGKc(JsonElement user);

	[MethodImpl((MethodImplOptions)8)]
	private static extern string YFM56yScEw(params string[] values);

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private extern global::System.Threading.Tasks.Task<t30hHHfP8gMStFdbd6rB> RGs5RLk1IF(JsonElement user, CancellationToken cancellationToken);

	[MethodImpl((MethodImplOptions)8)]
	private static extern string j9I5w1GCLw();

	[MethodImpl((MethodImplOptions)8)]
	private static extern int kkT5eBPkNh(object password);

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private extern global::System.Threading.Tasks.Task<JsonElement> dFc5PNEggY(string url, Dictionary<string, string> data, CancellationToken cancellationToken);

	[MethodImpl((MethodImplOptions)8)]
	private static extern string w6t5xxytXp();

	[MethodImpl((MethodImplOptions)8)]
	private static extern bool toF5FUHH8l(JsonElement root, out JsonElement user);

	[MethodImpl((MethodImplOptions)8)]
	private static extern string gZ75s2kGxE(JsonElement element, object name);

	[MethodImpl((MethodImplOptions)8)]
	private static extern int FPX5TrFTeT(JsonElement element, object name);

	[MethodImpl((MethodImplOptions)8)]
	private static extern string oju5N9bflX(string? url, object key);

	[MethodImpl((MethodImplOptions)8)]
	private static extern string VrG5MKqLAi(object value);

	[MethodImpl((MethodImplOptions)8)]
	private static extern string StE5pXxGHo(string? value);

	[MethodImpl((MethodImplOptions)8)]
	private static extern string eNs5uO3PKw(object email);

	[MethodImpl((MethodImplOptions)8)]
	private static extern string hka5aUsctQ(object value);

	[MethodImpl((MethodImplOptions)8)]
	private static extern bool cRL51NZsT0(object value);

	[MethodImpl((MethodImplOptions)8)]
	private static extern long Ub153TOkYK();

	[MethodImpl((MethodImplOptions)8)]
	private extern string zWO5v6bk4l(int length);

	[MethodImpl((MethodImplOptions)8)]
	private extern string iSa5E4LxGR(string alphabet, int length);

	[MethodImpl((MethodImplOptions)8)]
	private extern string Vq152GZMZC();

	[MethodImpl((MethodImplOptions)8)]
	public extern void Dispose();

	[MethodImpl((MethodImplOptions)8)]
	public static extern bool L0h5qD8l7r(string phone);

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public extern global::System.Threading.Tasks.Task<t30hHHfP8gMStFdbd6rB> LoginMobilePasswordAsync(string phone, string password, CancellationToken cancellationToken = default(CancellationToken), bool retryOnDeviceError = true);

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public extern global::System.Threading.Tasks.Task<aGcPkqfPUnlETcp0tP2t> SendMobileLoginSmsAsync(string phone, CancellationToken cancellationToken = default(CancellationToken));

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public extern global::System.Threading.Tasks.Task<t30hHHfP8gMStFdbd6rB> CompleteMobileSmsLoginAsync(string phone, string code, CancellationToken cancellationToken = default(CancellationToken));

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private extern global::System.Threading.Tasks.Task<t30hHHfP8gMStFdbd6rB> J7w5GkAoBW(string phone, string ticket, CancellationToken cancellationToken);

	[MethodImpl((MethodImplOptions)8)]
	private extern Dictionary<string, string> clM5iAschK(string phone);

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private extern global::System.Threading.Tasks.Task<bcATbBfGSAoRYQCqLAfa> jWu5nHHn1o(string path, Dictionary<string, string> data, CancellationToken cancellationToken);

	[MethodImpl((MethodImplOptions)8)]
	private static extern void _cctor();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern bool hflBMcZQ7vIEGdFSiO7F();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern p7aMTy5CiDjPcd5Qwt6 hhD9V8ZQAMs33XVVafdR();
}
