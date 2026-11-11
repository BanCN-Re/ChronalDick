using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using qS8vkpL43FlTMgcj0rgs;

[CompilerGenerated]
internal sealed class __f__AnonymousType1_2<T_type, T_enabled>
{
	private readonly T_type _type_i__Field;

	private readonly T_enabled _enabled_i__Field;

	internal static object OwfSVKL30UDjlqBGDtLS;

	public T_type type
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return this._type_i__Field;
		}
	}

	public T_enabled enabled
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return this._enabled_i__Field;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public __f__AnonymousType1_2(T_type type, T_enabled enabled)
	{
		this._type_i__Field = type;
		this._enabled_i__Field = enabled;
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public bool Equals(object value)
	{
		//IL_000c: Expected O, but got I4
		//IL_0029: Expected I4, but got O
		//IL_00af->IL0010: Incompatible stack types: I4 vs O
		//IL_00cb->IL0010: Incompatible stack types: I4 vs O
		//IL_00d6->IL0010: Incompatible stack types: I4 vs O
		//IL_0092->IL0010: Incompatible stack types: I4 vs O
		//IL_009d->IL0010: Incompatible stack types: I4 vs O
		int num = 3;
		object obj3 = default(object);
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
						if ((nint)obj != 11)
						{
							if ((nint)obj == 992)
							{
								goto end_IL_0010;
							}
						}
						else if (!EqualityComparer<T_type>.Default.Equals(this._type_i__Field, ((global::__f__AnonymousType1_2<T_type, T_enabled>)obj3)._type_i__Field))
						{
							obj2 = 9;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b28f7b3c5e414da9823acaf82070b1eb == 0)
							{
								obj2 = 0;
							}
							break;
						}
						goto case 4;
					case 1:
						if (obj3 != null)
						{
							goto end_IL_000c;
						}
						goto case 0;
					case 3:
						obj3 = value as global::__f__AnonymousType1_2<T_type, T_enabled>;
						obj2 = 2;
						break;
					case 2:
						if (this == obj3)
						{
							return true;
						}
						obj2 = 1;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f47742ba549d4a57a8283970712d2604 != 0)
						{
							obj2 = 3;
						}
						break;
					case 4:
						return ((EqualityComparer<object>)(object)EqualityComparer<object>.Default).Equals(this._enabled_i__Field, ((global::__f__AnonymousType1_2<T_type, T_enabled>)obj3)._enabled_i__Field);
					case 0:
						return false;
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 11;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public int GetHashCode()
	{
		return unchecked((196684597 * -1521134295 + EqualityComparer<T_type>.Default.GetHashCode(this._type_i__Field)) * -1521134295 + ((EqualityComparer<object>)(object)EqualityComparer<object>.Default).GetHashCode(this._enabled_i__Field));
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public unsafe string ToString()
	{
		string text = "{{ type = {0}, enabled = {1} }}";
		object[] array = new object[2];
		object obj = this._type_i__Field;
		array[0] = ((*(T_type*)(&obj) != null) ? ((object)(*(T_type*)(&obj))/*cast due to .constrained prefix*/).ToString() : null);
		object obj2 = this._enabled_i__Field;
		array[1] = ((*(T_enabled*)(&obj2) != null) ? ((object)(*(T_enabled*)(&obj2))/*cast due to .constrained prefix*/).ToString() : null);
		return string.Format(null, text, array);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool zLBofHL38TF66G4qFOsW()
	{
		return OwfSVKL30UDjlqBGDtLS == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object wUJIt6L3yl91aIMqIRen()
	{
		return OwfSVKL30UDjlqBGDtLS;
	}
}
