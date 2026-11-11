using System;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace Ax89pIHiDsjOjR1Uxrw;

internal struct Ix0cU3HGYPhvnMhKr6q : IEquatable<Ix0cU3HGYPhvnMhKr6q>
{
	[CompilerGenerated]
	private bool rcatXlIsqd;

	[CompilerGenerated]
	private bool iNPtflYl43;

	[CompilerGenerated]
	private bool pe9tLylwYm;

	private static object oM2l4AZJhOKPZQTZY7qx;

	public bool Handshake
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return rcatXlIsqd;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_004c->IL0010: Incompatible stack types: I4 vs O
			//IL_0057->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			do
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 0:
						return;
					case 1:
						rcatXlIsqd = value;
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
						{
							obj2 = 1;
						}
						continue;
					}
					break;
				}
			}
			while ((nint)obj == 989);
		}
	}

	public bool RegisterPolicy
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return iNPtflYl43;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_004b->IL0010: Incompatible stack types: I4 vs O
			//IL_0056->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			do
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 1:
						iNPtflYl43 = value;
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
						{
							obj2 = 4;
						}
						continue;
					case 0:
						return;
					}
					break;
				}
			}
			while ((nint)obj == 989);
		}
	}

	public bool Summary
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return pe9tLylwYm;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_004c->IL0010: Incompatible stack types: I4 vs O
			//IL_0057->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			do
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 0:
						return;
					case 1:
						pe9tLylwYm = value;
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
						{
							obj2 = 1;
						}
						continue;
					}
					break;
				}
			}
			while ((nint)obj == 989);
		}
	}

	internal int UnavailableCount
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return ((!Handshake) ? 1 : 0) + ((!RegisterPolicy) ? 1 : 0) + ((!Summary) ? 1 : 0);
		}
	}

	internal bool IsAvailable
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return UnavailableCount < 2;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public Ix0cU3HGYPhvnMhKr6q(bool Handshake, bool RegisterPolicy, bool Summary)
	{
		//IL_000d: Expected O, but got I4
		//IL_0026: Expected I4, but got O
		//IL_00e2->IL0011: Incompatible stack types: I4 vs O
		//IL_00ed->IL0011: Incompatible stack types: I4 vs O
		//IL_0062->IL0011: Incompatible stack types: I4 vs O
		//IL_00be->IL0011: Incompatible stack types: I4 vs O
		//IL_006d->IL0011: Incompatible stack types: I4 vs O
		//IL_00c9->IL0011: Incompatible stack types: I4 vs O
		//IL_0098->IL0011: Incompatible stack types: I4 vs O
		//IL_00a3->IL0011: Incompatible stack types: I4 vs O
		object obj = 10;
		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
		{
			obj = 3;
		}
		object obj2 = default(object);
		while (true)
		{
			switch ((int)obj)
			{
			default:
				if ((nint)obj2 != 11)
				{
					if ((nint)obj2 != 991)
					{
						break;
					}
					goto IL_000d;
				}
				rcatXlIsqd = Handshake;
				obj = 2;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
				{
					obj = 7;
				}
				continue;
			case 1:
				pe9tLylwYm = Summary;
				obj = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
				{
					obj = 2;
				}
				continue;
			case 3:
				HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
				obj2 = 11;
				goto IL_000d;
			case 0:
				return;
			case 2:
				break;
				IL_000d:
				obj = obj2;
				continue;
			}
			iNPtflYl43 = RegisterPolicy;
			obj = 7;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
			{
				obj = 1;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal Ix0cU3HGYPhvnMhKr6q avpHnw6eTN(Ix0cU3HGYPhvnMhKr6q other)
	{
		//IL_000c: Expected O, but got I4
		//IL_001d: Expected I4, but got O
		//IL_005c->IL0010: Incompatible stack types: I4 vs O
		//IL_0067->IL0010: Incompatible stack types: I4 vs O
		object obj = 1;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				int handshake;
				switch ((int)obj2)
				{
				default:
					if ((nint)obj == 989)
					{
						goto end_IL_0010;
					}
					goto case 1;
				case 0:
					handshake = (other.Handshake ? 1 : 0);
					break;
				case 1:
					if (!Handshake)
					{
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 != 0)
						{
							obj2 = 0;
						}
						continue;
					}
					handshake = 1;
					break;
				}
				return (Ix0cU3HGYPhvnMhKr6q)new Ix0cU3HGYPhvnMhKr6q((byte)handshake != 0, RegisterPolicy || other.RegisterPolicy, Summary || other.Summary);
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override string ToString()
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private bool M8YHzK1CRs(StringBuilder builder)
	{
		//IL_0009: Expected O, but got I4
		object obj = 2;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(Ix0cU3HGYPhvnMhKr6q left, Ix0cU3HGYPhvnMhKr6q right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(Ix0cU3HGYPhvnMhKr6q left, Ix0cU3HGYPhvnMhKr6q right)
	{
		return left.Equals(right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return ((rcatXlIsqd ? 1 : 0) * -1521134295 + (iNPtflYl43 ? 1 : 0)) * -1521134295 + (pe9tLylwYm ? 1 : 0);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object obj)
	{
		//IL_000c: Expected O, but got I4
		//IL_001d: Expected I4, but got O
		//IL_004f->IL0010: Incompatible stack types: I4 vs O
		//IL_005a->IL0010: Incompatible stack types: I4 vs O
		object obj2 = 1;
		while (true)
		{
			object obj3 = obj2;
			while (true)
			{
				switch ((int)obj3)
				{
				default:
					if ((nint)obj2 == 989)
					{
						break;
					}
					goto case 1;
				case 1:
					if (obj is Ix0cU3HGYPhvnMhKr6q)
					{
						obj3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
						{
							obj3 = 0;
						}
						continue;
					}
					return false;
				case 0:
					return Equals((Ix0cU3HGYPhvnMhKr6q)obj);
				}
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(Ix0cU3HGYPhvnMhKr6q other)
	{
		_ = 3;
		_ = rcatXlIsqd;
		_ = other.rcatXlIsqd;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void q9wtbkPNTb(out bool Handshake, out bool RegisterPolicy, out bool Summary)
	{
		//IL_000c: Expected O, but got I4
		//IL_0021: Expected I4, but got O
		//IL_004a: Expected F4, but got I4
		//IL_005d: Expected F4, but got I4
		//IL_0084: Expected F4, but got I4
		//IL_0071->IL0010: Incompatible stack types: I4 vs O
		//IL_007c->IL0010: Incompatible stack types: I4 vs O
		//IL_0098->IL0010: Incompatible stack types: I4 vs O
		//IL_00a3->IL0010: Incompatible stack types: I4 vs O
		int num = 1;
		while (true)
		{
			object obj = num;
			do
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj == 9)
						{
							Summary = default;
							obj2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
							{
								obj2 = 2;
							}
							continue;
						}
						goto end_IL_0010;
					case 0:
						break;
					case 2:
						Handshake = default;
						RegisterPolicy = default;
						Summary = default;
						return;
					case 1:
						Handshake = default;
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
						{
							obj2 = 0;
						}
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
			while ((nint)obj == 990);
			RegisterPolicy = default;
			num = 9;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_000e: Expected O, but got I4
		//IL_0023: Expected I4, but got O
		//IL_0081->IL0012: Incompatible stack types: I4 vs O
		//IL_008c->IL0012: Incompatible stack types: I4 vs O
		//IL_005d->IL0012: Incompatible stack types: I4 vs O
		//IL_0068->IL0012: Incompatible stack types: I4 vs O
		int num = 2;
		while (true)
		{
			object obj = num;
			do
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj == 9)
						{
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							obj2 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
							{
								obj2 = 0;
							}
							continue;
						}
						goto end_IL_0012;
					case 2:
						obj2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
						{
							obj2 = 1;
						}
						continue;
					case 1:
						break;
					case 0:
						return;
					}
					goto end_IL_000e;
					continue;
					end_IL_0012:
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			while ((nint)obj == 990);
			num = 9;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool kD9oT7ZJUmMrFx90TrYx()
	{
		return oM2l4AZJhOKPZQTZY7qx == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object Uq1Th7ZJr3JcutUs1PiW()
	{
		return oM2l4AZJhOKPZQTZY7qx;
	}
}
