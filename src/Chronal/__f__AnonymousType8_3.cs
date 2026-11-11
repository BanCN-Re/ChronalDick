using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using qS8vkpL43FlTMgcj0rgs;

[CompilerGenerated]
internal sealed class __f__AnonymousType8_3<T_type, T_data, T_name>
{
	private readonly T_type _type_i__Field;

	private readonly T_data _data_i__Field;

	private readonly T_name _name_i__Field;

	private static object AKAQZcL3Hbv6ms3CNFB1;

	public T_type type
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return this._type_i__Field;
		}
	}

	public T_data data
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return this._data_i__Field;
		}
	}

	public T_name name
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return this._name_i__Field;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public __f__AnonymousType8_3(T_type type, T_data data, T_name name)
	{
		this._type_i__Field = type;
		this._data_i__Field = data;
		this._name_i__Field = name;
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public bool Equals(object value)
	{
		//IL_000c: Expected O, but got I4
		//IL_0029: Expected I4, but got O
		//IL_00a8->IL0010: Incompatible stack types: I4 vs O
		//IL_011b->IL0010: Incompatible stack types: I4 vs O
		//IL_0126->IL0010: Incompatible stack types: I4 vs O
		//IL_0065->IL0010: Incompatible stack types: I4 vs O
		//IL_0070->IL0010: Incompatible stack types: I4 vs O
		int num = 2;
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
							goto case 2;
						}
						if (obj3 != null)
						{
							obj2 = 4;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9c15dc17ae4e48a5bd629d141b0ebe29 == 0)
							{
								obj2 = 5;
							}
							continue;
						}
						goto IL_00c0;
					case 4:
						if (EqualityComparer<T_type>.Default.Equals(this._type_i__Field, ((global::__f__AnonymousType8_3<T_type, T_data, T_name>)obj3)._type_i__Field))
						{
							num = 3;
							break;
						}
						goto IL_00c0;
					case 2:
						obj3 = value as global::__f__AnonymousType8_3<T_type, T_data, T_name>;
						obj2 = 1;
						continue;
					case 0:
						return ((EqualityComparer<object>)(object)EqualityComparer<object>.Default).Equals(this._name_i__Field, ((global::__f__AnonymousType8_3<T_type, T_data, T_name>)obj3)._name_i__Field);
					case 1:
						if (this == obj3)
						{
							return true;
						}
						num = 11;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_db2c7dd1aabc4c9a97a36e710c0128ab == 0)
						{
							num = 11;
						}
						break;
					case 3:
						{
							if (((EqualityComparer<object>)(object)EqualityComparer<object>.Default).Equals(this._data_i__Field, ((global::__f__AnonymousType8_3<T_type, T_data, T_name>)obj3)._data_i__Field))
							{
								obj2 = 11;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_d2995c01469b4ef28b5784f7cbf606e2 != 0)
								{
									obj2 = 0;
								}
								continue;
							}
							goto IL_00c0;
						}
						IL_00c0:
						return false;
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
	[DebuggerHidden]
	public int GetHashCode()
	{
		return unchecked((((-828203663 * -1521134295 + EqualityComparer<T_type>.Default.GetHashCode(this._type_i__Field)) * -1521134295 + ((EqualityComparer<object>)(object)EqualityComparer<object>.Default).GetHashCode(this._data_i__Field)) * -1521134295 + ((EqualityComparer<object>)(object)EqualityComparer<object>.Default).GetHashCode(this._name_i__Field)));
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public unsafe string ToString()
	{
		string text = "{{ type = {0}, data = {1}, name = {2} }}";
		object[] array = new object[3];
		object obj = this._type_i__Field;
		array[0] = ((*(T_type*)(&obj) != null) ? ((object)(*(T_type*)(&obj))/*cast due to .constrained prefix*/).ToString() : null);
		object obj2 = this._data_i__Field;
		array[1] = ((*(T_data*)(&obj2) != null) ? ((object)(*(T_data*)(&obj2))/*cast due to .constrained prefix*/).ToString() : null);
		object obj3 = this._name_i__Field;
		array[2] = ((*(T_name*)(&obj3) != null) ? ((object)(*(T_name*)(&obj3))/*cast due to .constrained prefix*/).ToString() : null);
		return string.Format(null, text, array);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool K7mP1mL3tEt9EXGpjPJU()
	{
		return AKAQZcL3Hbv6ms3CNFB1 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object mhQNbFL3OVk7QJpAvXE9()
	{
		return AKAQZcL3Hbv6ms3CNFB1;
	}
}
