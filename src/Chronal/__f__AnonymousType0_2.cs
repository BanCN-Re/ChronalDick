using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using qS8vkpL43FlTMgcj0rgs;

[CompilerGenerated]
internal sealed class __f__AnonymousType0_2<T_type, T_requestId>
{
	private readonly T_type _type_i__Field;

	private readonly T_requestId _requestId_i__Field;

	private static object hIgwAML3YopZnjXuqSsS;

	public T_type type
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return this._type_i__Field;
		}
	}

	public T_requestId requestId
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return this._requestId_i__Field;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public __f__AnonymousType0_2(T_type type, T_requestId requestId)
	{
		this._type_i__Field = type;
		this._requestId_i__Field = requestId;
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public bool Equals(object value)
	{
		//IL_000c: Expected O, but got I4
		//IL_0025: Expected I4, but got O
		//IL_009c->IL0010: Incompatible stack types: I4 vs O
		//IL_0076->IL0010: Incompatible stack types: I4 vs O
		//IL_00a7->IL0010: Incompatible stack types: I4 vs O
		//IL_0081->IL0010: Incompatible stack types: I4 vs O
		//IL_00f1->IL0010: Incompatible stack types: I4 vs O
		//IL_00fc->IL0010: Incompatible stack types: I4 vs O
		int num = 2;
		object obj3 = default(object);
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
						if ((nint)obj == 10)
						{
							if (this == obj3)
							{
								return true;
							}
							obj2 = 10;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bb37d0226fdb41f1902e558a997d9dc6 == 0)
							{
								obj2 = 0;
							}
							continue;
						}
						goto end_IL_0010;
					case 1:
						if (EqualityComparer<T_type>.Default.Equals(this._type_i__Field, ((global::__f__AnonymousType0_2<T_type, T_requestId>)obj3)._type_i__Field))
						{
							obj2 = 4;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_80d00e736d0b4f7dbce583e459774a86 == 0)
							{
								obj2 = 3;
							}
							continue;
						}
						break;
					case 0:
						if (obj3 != null)
						{
							obj2 = 1;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_c3a1ed3f1b10415883902def95e1be62 == 0)
							{
								obj2 = 9;
							}
							continue;
						}
						break;
					case 2:
						goto end_IL_000c;
					case 3:
						return ((EqualityComparer<object>)(object)EqualityComparer<object>.Default).Equals(this._requestId_i__Field, ((global::__f__AnonymousType0_2<T_type, T_requestId>)obj3)._requestId_i__Field);
					}
					return false;
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			while ((nint)obj == 991);
			obj3 = value as global::__f__AnonymousType0_2<T_type, T_requestId>;
			num = 10;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public int GetHashCode()
	{
		return unchecked((-931576934 * -1521134295 + EqualityComparer<T_type>.Default.GetHashCode(this._type_i__Field)) * -1521134295 + ((EqualityComparer<object>)(object)EqualityComparer<object>.Default).GetHashCode(this._requestId_i__Field));
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public unsafe string ToString()
	{
		string text = "{{ type = {0}, requestId = {1} }}";
		object[] array = new object[2];
		object obj = this._type_i__Field;
		array[0] = ((*(T_type*)(&obj) != null) ? ((object)(*(T_type*)(&obj))/*cast due to .constrained prefix*/).ToString() : null);
		object obj2 = this._requestId_i__Field;
		array[1] = ((*(T_requestId*)(&obj2) != null) ? ((object)(*(T_requestId*)(&obj2))/*cast due to .constrained prefix*/).ToString() : null);
		return string.Format(null, text, array);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool upQemCL3SCVW80yTEbus()
	{
		return hIgwAML3YopZnjXuqSsS == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object mupcnvL3cF6NapN5AXeZ()
	{
		return hIgwAML3YopZnjXuqSsS;
	}
}
