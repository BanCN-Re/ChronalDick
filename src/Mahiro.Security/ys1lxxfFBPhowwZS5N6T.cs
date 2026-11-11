using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace bVyVYtfFgCItGPihJweI;

public sealed class ys1lxxfFBPhowwZS5N6T : IEquatable<ys1lxxfFBPhowwZS5N6T>
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_113
	{
		public static readonly __c_113 __9;

		private static __c_113 POAQn1DrTu2mgtHZF6wS;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_113()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal ys1lxxfFBPhowwZS5N6T J69LWmq65Y9(KeyValuePair<int, string> item)
		{
			return (ys1lxxfFBPhowwZS5N6T)new ys1lxxfFBPhowwZS5N6T(item.Key, item.Value);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool V6rbP1DrNIcbks1cFdG9()
		{
			return POAQn1DrTu2mgtHZF6wS == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_113 eUTVwRDrMaqvEK4MKAoQ()
		{
			return POAQn1DrTu2mgtHZF6wS;
		}
	}

	[CompilerGenerated]
	private int _Id_k__BackingField;

	[CompilerGenerated]
	private string _Name_k__BackingField;

	private static readonly IReadOnlyDictionary<int, string> KnownVersions;

	private static object REamUf9Ztp2TY1HpYrnZ;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return System.Type.GetTypeFromHandle(typeof(ys1lxxfFBPhowwZS5N6T).TypeHandle);
		}
	}

	public int Id
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Id_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_Id_k__BackingField = value;
		}
	}

	public string Name
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Name_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_Name_k__BackingField = value;
		}
	}

	[field: CompilerGenerated]
	public static global::System.Collections.Generic.IReadOnlyList<ys1lxxfFBPhowwZS5N6T> SupportedVersions
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[MethodImpl((MethodImplOptions)8)]
	public ys1lxxfFBPhowwZS5N6T(int Id, string Name)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	public static ys1lxxfFBPhowwZS5N6T kXjfFlXk4fU(int id, string? fallback = null)
	{
		string text = default(string);
		return (ys1lxxfFBPhowwZS5N6T)new ys1lxxfFBPhowwZS5N6T(id, KnownVersions.TryGetValue(id, out text) ? text : (string.IsNullOrWhiteSpace(fallback) ? (id).ToString() : (fallback).Trim()));
	}

	[MethodImpl((MethodImplOptions)8)]
	public static int BAhfFdVP9Xy(object version)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		global::System.Collections.Generic.IEnumerator<KeyValuePair<int, string>> enumerator = default(global::System.Collections.Generic.IEnumerator<KeyValuePair<int, string>>);
		KeyValuePair<int, string> current = default(KeyValuePair<int, string>);
		int num4 = default(int);
		int key = default(int);
		int num7 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 990)
					{
						goto end_IL_0010;
					}
					goto case 2;
				case 2:
					throw new ArgumentException(string.Concat("暂不支持 Java ", (string)version), "version");
				case 1:
					enumerator = ((global::System.Collections.Generic.IEnumerable<KeyValuePair<int, string>>)KnownVersions).GetEnumerator();
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					try
					{
						while (true)
						{
							int num3;
							if (!(enumerator).MoveNext())
							{
								num3 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
								{
									num3 = 1;
								}
								goto IL_00e1;
							}
							goto IL_014f;
							IL_014f:
							current = enumerator.Current;
							num3 = 3;
							goto IL_00e1;
							IL_00e1:
							while (true)
							{
								switch (num3)
								{
								default:
									switch (num4)
									{
									case 13:
										return key;
									case 993:
										break;
									default:
										goto end_IL_00e1;
									}
									goto IL_00dd;
								case 2:
								case 4:
									break;
								case 0:
									goto IL_014f;
								case 5:
								{
									key = current.Key;
									int num5 = 13;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
									{
										num5 = 4;
									}
									num4 = num5;
									goto IL_00dd;
								}
								case 3:
									if (!string.Equals(current.Value, (string)version, (StringComparison)5))
									{
										num3 = 2;
										continue;
									}
									goto case 5;
								case 1:
									goto end_IL_011f;
									IL_00dd:
									num3 = num4;
									continue;
									end_IL_00e1:
									break;
								}
								break;
							}
							continue;
							end_IL_011f:
							break;
						}
					}
					finally
					{
						int num6;
						if (enumerator == null)
						{
							num6 = 2;
							goto IL_0207;
						}
						goto IL_022b;
						IL_022b:
						(enumerator).Dispose();
						num6 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 != 0)
						{
							num6 = 1;
						}
						goto IL_0207;
						IL_0207:
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 == 990)
								{
									goto IL_0203;
								}
								goto end_IL_0207;
							case 1:
								break;
							case 2:
								goto end_IL_0207;
							case 0:
								goto end_IL_0207;
							}
							goto IL_022b;
							IL_0203:
							num6 = num7;
							continue;
							end_IL_0207:
							break;
						}
					}
					goto case 2;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public override string ToString()
	{
		return Name;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private bool DK3fFKpZs63(StringBuilder builder)
	{
		System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(ys1lxxfFBPhowwZS5N6T? left, ys1lxxfFBPhowwZS5N6T? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(ys1lxxfFBPhowwZS5N6T? left, ys1lxxfFBPhowwZS5N6T? right)
	{
		int num = 3;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return (EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(_Id_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_Name_k__BackingField);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as ys1lxxfFBPhowwZS5N6T);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(ys1lxxfFBPhowwZS5N6T? other)
	{
		int num = 1;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public ys1lxxfFBPhowwZS5N6T WntfFHlHwae()
	{
		return (ys1lxxfFBPhowwZS5N6T)new ys1lxxfFBPhowwZS5N6T(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private ys1lxxfFBPhowwZS5N6T(ys1lxxfFBPhowwZS5N6T original)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void rKnfFtl819P(out int Id, out string Name)
	{
		Id = default(int);
		Name = default(string);
		//IL_0008: Expected I8, but got O
Name = this.Name;  // was Unsafe.As<_,long> reinterpret
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool Qf41dx9ZOC0Y60T2o9XQ()
	{
		return REamUf9Ztp2TY1HpYrnZ == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static ys1lxxfFBPhowwZS5N6T tSyjJG9Z5076LlcRleFK()
	{
		return (ys1lxxfFBPhowwZS5N6T)REamUf9Ztp2TY1HpYrnZ;
	}
}
