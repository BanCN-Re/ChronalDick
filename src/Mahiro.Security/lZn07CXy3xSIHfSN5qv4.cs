using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using PyjoTWXyOLcrwNbVqhBg;
using fDAldojjppXrctUVYOJn;
using q3ClWrILK8ws5weUMbd;

namespace Vmo4hVXyvmIwyQZjF3Zr;

internal sealed class lZn07CXy3xSIHfSN5qv4 : IEquatable<lZn07CXy3xSIHfSN5qv4>
{
	[CompilerGenerated]
	private string otHXyz1PjoB;

	[CompilerGenerated]
	private string rKKXWbOHsuM;

	[CompilerGenerated]
	private string XMWXWXc9fBL;

	internal static object MAS5CIZlJ8hWeDDRtjc8;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return System.Type.GetTypeFromHandle(typeof(lZn07CXy3xSIHfSN5qv4).TypeHandle);
		}
	}

	public string Directory
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return otHXyz1PjoB;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			otHXyz1PjoB = value;
		}
	}

	public string InjectorPath
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return rKKXWbOHsuM;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			rKKXWbOHsuM = value;
		}
	}

	public string LibraryPath
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return XMWXWXc9fBL;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			XMWXWXc9fBL = value;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public lZn07CXy3xSIHfSN5qv4(string Directory, string InjectorPath, string LibraryPath)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static lZn07CXy3xSIHfSN5qv4 WB4XyEajPgQ()
	{
		return (lZn07CXy3xSIHfSN5qv4)new lZn07CXy3xSIHfSN5qv4(UE5yLvIfTpJPlib3pkR.pSsIZ2IP8u("Assets/JavaNativeBridge"), UE5yLvIfTpJPlib3pkR.SlmIjZNXXD("Assets/JavaNativeBridge/Chronal.JavaInjector.exe"), UE5yLvIfTpJPlib3pkR.SlmIjZNXXD("Assets/JavaNativeBridge/Chronal.JavaProxy.dll"));
	}

	[MethodImpl((MethodImplOptions)8)]
	internal qJH0e9XytDqjwAoB7d4v JsIXy2Iwd9n()
	{
		XUnXyqgWquI(LibraryPath);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void XUnXyqgWquI(object path)
	{
		//IL_0411: Expected O, but got Unknown
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num3 = default(int);
		int num5 = default(int);
		int num7 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num8);
		global::System.Exception ex = default(global::System.Exception);
		int num9 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num10);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
		int num12 = default(int);
		int num14 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				break;
			default:
				return;
			case 1:
				try
				{
					FileStream val = System.IO.File.Open((string)path, (FileMode)3, (FileAccess)1, (FileShare)1);
					int num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
					{
						num2 = 1;
					}
					while (true)
					{
						switch (num2)
						{
						case 0:
							return;
						default:
							if (num3 == 989)
							{
								goto IL_006f;
							}
							break;
						case 1:
							break;
						}
						break;
						IL_006f:
						num2 = num3;
					}
					try
					{
						if ((val).Length != 0L)
						{
							int num4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									return;
								default:
									if (num5 == 989)
									{
										goto IL_00d2;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_00d2:
								num4 = num5;
							}
						}
						throw new InvalidDataException(string.Concat("Java 注入组件为空文件：", (string)path));
					}
					finally
					{
						if (val != null)
						{
							int num6 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
							{
								num6 = 6;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 989)
									{
										num6 = num7;
										continue;
									}
									break;
								case 0:
									(val).Dispose();
									num6 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
									{
										num6 = 6;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				}
				catch (global::System.Exception obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj2 = obj as global::System.Exception;
					if (obj2 == null)
					{
						num8 = 4;
					}
					else
					{
						ex = obj2;
						num8 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
						{
							num8 = 3;
						}
					}
					while (true)
					{
						switch (num8)
						{
						default:
							if (num9 != 15)
							{
								if (num9 == 995)
								{
									goto IL_0222;
								}
								goto case 0;
							}
							goto case 6;
						case 5:
							if (!(ex is DirectoryNotFoundException))
							{
								num10 = 15;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
								{
									num10 = 8;
								}
								num9 = num10;
								goto IL_0222;
							}
							goto case 0;
						case 0:
						case 7:
							flag = true;
							num8 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
							{
								num8 = 1;
							}
							continue;
						case 3:
							if (ex is FileNotFoundException)
							{
								num8 = 14;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
								{
									num8 = 0;
								}
								continue;
							}
							goto case 5;
						case 6:
							flag = false;
							num8 = 14;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
							{
								num8 = 2;
							}
							continue;
						case 4:
							result = 0;
							break;
						case 1:
						case 2:
							{
								result = (flag ? 1 : 0);
								break;
							}
							IL_0222:
							num8 = num9;
							continue;
						}
						break;
					}
					return (byte)result != 0;
				}).Invoke())
				{
					int num11 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
					{
						num11 = 0;
					}
					while (true)
					{
						switch (num11)
						{
						default:
							if (num12 == 988)
							{
								goto IL_03a4;
							}
							break;
						case 0:
							break;
						}
						break;
						IL_03a4:
						num11 = num12;
					}
					throw new FileNotFoundException(string.Concat("应用缺少 Java 注入组件：", (string)path, "。本次尚未启动注入器；需要包含配对组件的完整应用包，重新登录不能解决此问题。"), (string)path, ex);
				}
				catch (UnauthorizedAccessException ex2)
				{
					UnauthorizedAccessException ex3 = ex2;
					int num13 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d != 0)
					{
						num13 = 1;
					}
					while (true)
					{
						switch (num13)
						{
						default:
							if (num14 == 988)
							{
								goto IL_043e;
							}
							break;
						case 0:
							break;
						}
						break;
						IL_043e:
						num13 = num14;
					}
					throw new UnauthorizedAccessException(string.Concat("系统拒绝读取 Java 注入组件：", (string)path, "。请检查文件访问权限和系统拦截记录。"), (global::System.Exception)(object)ex3);
				}
			}
		}
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
	private bool redXyG4mkpe(StringBuilder builder)
	{
		System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(lZn07CXy3xSIHfSN5qv4? left, lZn07CXy3xSIHfSN5qv4? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(lZn07CXy3xSIHfSN5qv4? left, lZn07CXy3xSIHfSN5qv4? right)
	{
		int num = 3;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return ((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(otHXyz1PjoB)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(rKKXWbOHsuM)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(XMWXWXc9fBL);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as lZn07CXy3xSIHfSN5qv4);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(lZn07CXy3xSIHfSN5qv4? other)
	{
		int num = 3;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public lZn07CXy3xSIHfSN5qv4 A7MXyiFx5Ok()
	{
		return (lZn07CXy3xSIHfSN5qv4)new lZn07CXy3xSIHfSN5qv4(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private lZn07CXy3xSIHfSN5qv4(lZn07CXy3xSIHfSN5qv4 original)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void yEpXynAIZyT(out string Directory, out string InjectorPath, out string LibraryPath)
	{
		Directory = default(string);
		InjectorPath = default(string);
		LibraryPath = default(string);
		//IL_0008: Expected I8, but got O
Directory = this.Directory;  // was Unsafe.As<_,long> reinterpret
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool g5NqTEZlQn1NPiTTJUNL()
	{
		return MAS5CIZlJ8hWeDDRtjc8 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static lZn07CXy3xSIHfSN5qv4 DilqtXZlC7FeCmZ3sQtR()
	{
		return (lZn07CXy3xSIHfSN5qv4)MAS5CIZlJ8hWeDDRtjc8;
	}
}
