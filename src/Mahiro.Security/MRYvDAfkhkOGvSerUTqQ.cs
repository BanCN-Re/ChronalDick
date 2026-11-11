using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using CdEjKjX5XwI8HIEc5VXp;
using fDAldojjppXrctUVYOJn;
using gjyRx5f1wubbeI3q2eIF;
using iac1UWf17xUpoD7r1ZnK;

namespace sNao0sfkUbEh0g4Pg2tQ;

internal sealed class MRYvDAfkhkOGvSerUTqQ
{
	private static readonly object tkpfk5Ktv2i;

	private readonly object LKpfk671NOy;

	private static object PEblxZZNn1hhO0fAvtkM;

	[MethodImpl((MethodImplOptions)8)]
	internal MRYvDAfkhkOGvSerUTqQ(LixQVCX5bgefMapc3r7K paths)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal string ly0fkrtfGQj(string serverId, cpFof3f1mS0j06Q2dp3s resource)
	{
		return System.IO.Path.Combine(((LixQVCX5bgefMapc3r7K)LKpfk671NOy).ServerResourcesPath, sgFfkHLXM8H(serverId), sgFfkHLXM8H(resource.ItemId), alLfkKuXdwj(resource.Md5));
	}

	[MethodImpl((MethodImplOptions)8)]
	internal string LJQfkouSIYc(string entryPath)
	{
		return System.IO.Path.Combine(entryPath, "resource.download");
	}

	[MethodImpl((MethodImplOptions)8)]
	internal string kTufkmtulvh(string entryPath)
	{
		return System.IO.Path.Combine(entryPath, "resource.download.partial");
	}

	[MethodImpl((MethodImplOptions)8)]
	internal string JPMfk7DdO4p(string entryPath)
	{
		return System.IO.Path.Combine(entryPath, "content");
	}

	[MethodImpl((MethodImplOptions)8)]
	internal string FKNfkA7yOkO(string entryPath)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		string text = "staging-";
		Guid val = System.Guid.NewGuid();
		return System.IO.Path.Combine(entryPath, string.Concat(text, (val).ToString("N")));
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task<E9A673f1RYqU3JaH0aLP?> sB7fkIyIyWt(string entryPath, cpFof3f1mS0j06Q2dp3s resource, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_TryLoadAsync_d__9 tryLoadAsync_d__ = default(_TryLoadAsync_d__9);
		tryLoadAsync_d__.__t__builder = AsyncTaskMethodBuilder<E9A673f1RYqU3JaH0aLP>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task WX4fkBjBLyA(string entryPath, E9A673f1RYqU3JaH0aLP state, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_SaveAsync_d__10 saveAsync_d__ = default(_SaveAsync_d__10);
		saveAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void QfjfkguF014(object stagingPath, object contentPath)
	{
		System.IO.Directory.Delete((string)contentPath, true);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void n2KfklUZ57S(object path)
	{
		int num = 1;
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 0:
				return;
			}
			try
			{
				int num2;
				if (!System.IO.Directory.Exists((string)path))
				{
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
					{
						num2 = 0;
					}
					goto IL_0073;
				}
				goto IL_00bb;
				IL_0073:
				while (true)
				{
					switch (num2)
					{
					case 1:
						return;
					case 2:
						return;
					default:
						if (num3 == 990)
						{
							goto IL_006f;
						}
						return;
					case 0:
						break;
					}
					break;
					IL_006f:
					num2 = num3;
				}
				goto IL_00bb;
				IL_00bb:
				System.IO.Directory.Delete((string)path, true);
				num2 = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
				{
					num2 = 4;
				}
				goto IL_0073;
			}
			catch (global::System.Exception)
			{
				int num4 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
				{
					num4 = 4;
				}
				while (true)
				{
					switch (num4)
					{
					case 0:
						return;
					}
					if (num5 != 988)
					{
						return;
					}
					num4 = num5;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void L6efkdWs2fC(object path)
	{
		int num = 1;
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				break;
			case 1:
				try
				{
					if (!System.IO.File.Exists((string)path))
					{
						return;
					}
					int num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 != 0)
					{
						num2 = 5;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							if (num3 == 989)
							{
								num2 = num3;
								continue;
							}
							break;
						case 0:
							break;
						case 1:
							return;
						}
						System.IO.File.Delete((string)path);
						num2 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be != 0)
						{
							num2 = 1;
						}
					}
				}
				catch (global::System.Exception)
				{
					int num4 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
					{
						num4 = 6;
					}
					while (true)
					{
						switch (num4)
						{
						case 0:
							return;
						}
						if (num5 == 988)
						{
							num4 = num5;
							continue;
						}
						return;
					}
				}
			default:
				return;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string alLfkKuXdwj(object value)
	{
		int num = 2;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string sgFfkHLXM8H(object value)
	{
		string text = ((dynamic)(value)).Trim();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool lgXfktOjbk4(object value)
	{
		int num = 0;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool LaupaXZNzaOIh17jx7Ky()
	{
		return PEblxZZNn1hhO0fAvtkM == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static MRYvDAfkhkOGvSerUTqQ WmHB2yZMb53sGQCr2w4M()
	{
		return (MRYvDAfkhkOGvSerUTqQ)PEblxZZNn1hhO0fAvtkM;
	}
}
