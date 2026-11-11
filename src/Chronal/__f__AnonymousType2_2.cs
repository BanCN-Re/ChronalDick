using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using qS8vkpL43FlTMgcj0rgs;

[CompilerGenerated]
internal sealed class __f__AnonymousType2_2<T_type, T_name>
{
	private readonly T_type _type_i__Field;

	private readonly T_name _name_i__Field;

	internal static object MFgZgiL3Wx7mMoObouYo;

	public T_type type
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return this._type_i__Field;
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
	public __f__AnonymousType2_2(T_type type, T_name name)
	{
		this._type_i__Field = type;
		this._name_i__Field = name;
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public bool Equals(object value)
	{
		//IL_000c: Expected O, but got I4
		//IL_0025: Expected I4, but got O
		//IL_00f1->IL0010: Incompatible stack types: I4 vs O
		//IL_0073->IL0010: Incompatible stack types: I4 vs O
		//IL_00fc->IL0010: Incompatible stack types: I4 vs O
		//IL_007e->IL0010: Incompatible stack types: I4 vs O
		//IL_00ae->IL0010: Incompatible stack types: I4 vs O
		//IL_00b9->IL0010: Incompatible stack types: I4 vs O
		int num = 1;
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
						if ((nint)obj != 10)
						{
							if ((nint)obj == 991)
							{
								goto end_IL_0010;
							}
							goto case 2;
						}
						if (EqualityComparer<T_type>.Default.Equals(this._type_i__Field, ((global::__f__AnonymousType2_2<T_type, T_name>)obj3)._type_i__Field))
						{
							obj2 = 2;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9608fe64d13146acb5eaea30e653fb87 != 0)
							{
								obj2 = 4;
							}
							break;
						}
						goto IL_00d1;
					case 3:
						if (obj3 != null)
						{
							goto end_IL_000c;
						}
						goto IL_00d1;
					case 0:
						if (this == obj3)
						{
							return true;
						}
						obj2 = 3;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1580feae44ff487ab78d80df31c471c0 == 0)
						{
							obj2 = 10;
						}
						break;
					case 2:
						return ((EqualityComparer<object>)(object)EqualityComparer<object>.Default).Equals(this._name_i__Field, ((global::__f__AnonymousType2_2<T_type, T_name>)obj3)._name_i__Field);
					case 1:
						{
							obj3 = value as global::__f__AnonymousType2_2<T_type, T_name>;
							obj2 = 5;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5e5cf2db569941efa91d919db7fefba0 != 0)
							{
								obj2 = 0;
							}
							break;
						}
						IL_00d1:
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
			num = 10;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public int GetHashCode()
	{
		return unchecked((1526425653 * -1521134295 + EqualityComparer<T_type>.Default.GetHashCode(this._type_i__Field)) * -1521134295 + ((EqualityComparer<object>)(object)EqualityComparer<object>.Default).GetHashCode(this._name_i__Field));
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public unsafe string ToString()
	{
		string text = "{{ type = {0}, name = {1} }}";
		object[] array = new object[2];
		object obj = this._type_i__Field;
		array[0] = ((*(T_type*)(&obj) != null) ? ((object)(*(T_type*)(&obj))/*cast due to .constrained prefix*/).ToString() : null);
		object obj2 = this._name_i__Field;
		array[1] = ((*(T_name*)(&obj2) != null) ? ((object)(*(T_name*)(&obj2))/*cast due to .constrained prefix*/).ToString() : null);
		return string.Format(null, text, array);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool bKqL6fL3JMybjX3HEXLQ()
	{
		return MFgZgiL3Wx7mMoObouYo == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object rKQoa4L3QCVXhXMXfPgB()
	{
		return MFgZgiL3Wx7mMoObouYo;
	}
}
