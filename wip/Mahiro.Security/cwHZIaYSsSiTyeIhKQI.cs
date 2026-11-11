using System;
using System.Runtime.CompilerServices;
using System.Threading;
using AWAwFNkh6yEOmYofsXA;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace L50a3HYca3Vi9gFNMF8;

internal sealed class cwHZIaYSsSiTyeIhKQI : global::System.IDisposable
{
	private int jM6Yy9N60l;

	[CompilerGenerated]
	private readonly Rw2xvdk4yUIbmFhBjx8 YefYWFUoHM;

	[CompilerGenerated]
	private readonly CancellationTokenSource UoiYJXMhGZ;

	internal static object qm9SABZVz1NA5eMs7kFd;

	internal Rw2xvdk4yUIbmFhBjx8 Binding
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return YefYWFUoHM;
		}
	}

	internal CancellationTokenSource Cancellation
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return UoiYJXMhGZ;
		}
	}

	internal bool IsCancellationRequested
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_0059->IL0010: Incompatible stack types: I4 vs O
			//IL_0064->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj == 989)
						{
							break;
						}
						goto case 1;
					case 1:
						if (System.Threading.Volatile.Read(ref jM6Yy9N60l) == 0)
						{
							obj2 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
							{
								obj2 = 0;
							}
							continue;
						}
						return true;
					case 0:
						return (Cancellation).IsCancellationRequested;
					}
					break;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal cwHZIaYSsSiTyeIhKQI(Rw2xvdk4yUIbmFhBjx8 binding, CancellationToken cancellationToken)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		UoiYJXMhGZ = System.Threading.CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void rTMY0MiTI1()
	{
		//IL_000c: Expected O, but got I4
		//IL_001d: Expected I4, but got O
		//IL_0056->IL0010: Incompatible stack types: I4 vs O
		//IL_0061->IL0010: Incompatible stack types: I4 vs O
		object obj = 1;
		do
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 1:
					System.Threading.Interlocked.Exchange(ref jM6Yy9N60l, 1);
					obj2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
					{
						obj2 = 0;
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

	[MethodImpl((MethodImplOptions)8)]
	internal void uEdY8auYHl()
	{
		//IL_000c: Expected O, but got I4
		//IL_0021: Expected I4, but got O
		//IL_0074: Expected I4, but got O
		//IL_0059->IL006b: Incompatible stack types: I4 vs O
		//IL_00c0->IL0010: Incompatible stack types: I4 vs O
		//IL_0064->IL006b: Incompatible stack types: I4 vs O
		//IL_00cb->IL0010: Incompatible stack types: I4 vs O
		object obj = 1;
		object obj4 = default(object);
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					goto IL_0021;
				case 0:
				{
					(Cancellation).Cancel();
					object obj3 = 4;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
					{
						obj3 = 0;
					}
					while (true)
					{
						switch ((int)obj3)
						{
						case 0:
							return;
						}
						if ((nint)obj4 == 988)
						{
							obj3 = obj4;
							continue;
						}
						return;
					}
				}
				case 2:
					return;
				case 1:
					break;
				}
				goto IL_00a6;
				IL_0021:
				if ((nint)obj == 990)
				{
					break;
				}
				goto IL_00a6;
				IL_00a6:
				rTMY0MiTI1();
				obj2 = 6;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
				{
					obj2 = 0;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_000c: Expected O, but got I4
		//IL_0021: Expected I4, but got O
		//IL_0058->IL0010: Incompatible stack types: I4 vs O
		//IL_007e->IL0010: Incompatible stack types: I4 vs O
		//IL_0063->IL0010: Incompatible stack types: I4 vs O
		//IL_0089->IL0010: Incompatible stack types: I4 vs O
		object obj = 1;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					goto IL_0021;
				case 0:
					(Cancellation).Dispose();
					obj2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
					{
						obj2 = 4;
					}
					continue;
				case 2:
					return;
				case 1:
					break;
				}
				goto IL_0064;
				IL_0021:
				if ((nint)obj == 990)
				{
					break;
				}
				goto IL_0064;
				IL_0064:
				uEdY8auYHl();
				obj2 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
				{
					obj2 = 0;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_000e: Expected O, but got I4
		//IL_0023: Expected I4, but got O
		//IL_0078->IL0012: Incompatible stack types: I4 vs O
		//IL_005d->IL0012: Incompatible stack types: I4 vs O
		//IL_0068->IL0012: Incompatible stack types: I4 vs O
		int num = 1;
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj != 9)
						{
							if ((nint)obj == 990)
							{
								goto end_IL_0012;
							}
							goto case 0;
						}
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 != 0)
						{
							obj2 = 5;
						}
						continue;
					case 2:
						return;
					case 0:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						obj2 = 2;
						continue;
					case 1:
						break;
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
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool JK7GkeZYb7BdGMI0Zojx()
	{
		return qm9SABZVz1NA5eMs7kFd == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static cwHZIaYSsSiTyeIhKQI FvA9yWZYXbJTAnIodgBR()
	{
		return (cwHZIaYSsSiTyeIhKQI)qm9SABZVz1NA5eMs7kFd;
	}
}
