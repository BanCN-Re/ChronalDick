using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using qS8vkpL43FlTMgcj0rgs;

[CompilerGenerated]
internal sealed class __f__AnonymousType4_3<T_type, T_requestId, T_payload>
{
	private readonly T_type _type_i__Field;

	private readonly T_requestId _requestId_i__Field;

	private readonly T_payload _payload_i__Field;

	private static object f0STeaL3U2QkXuvRXVga;

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

	public T_payload payload
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return this._payload_i__Field;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public __f__AnonymousType4_3(T_type type, T_requestId requestId, T_payload payload)
	{
		this._type_i__Field = type;
		this._requestId_i__Field = requestId;
		this._payload_i__Field = payload;
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public bool Equals(object value)
	{
		//IL_000c: Expected O, but got I4
		//IL_002d: Expected I4, but got O
		//IL_0060->IL0010: Incompatible stack types: I4 vs O
		//IL_0082->IL0010: Incompatible stack types: I4 vs O
		//IL_00f6->IL0010: Incompatible stack types: I4 vs O
		//IL_00a9->IL0010: Incompatible stack types: I4 vs O
		//IL_008d->IL0010: Incompatible stack types: I4 vs O
		//IL_00b4->IL0010: Incompatible stack types: I4 vs O
		int num = 5;
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
						if ((nint)obj != 12)
						{
							if ((nint)obj == 993)
							{
								goto end_IL_0010;
							}
							goto case 2;
						}
						return ((EqualityComparer<object>)(object)EqualityComparer<object>.Default).Equals(this._payload_i__Field, ((global::__f__AnonymousType4_3<T_type, T_requestId, T_payload>)obj3)._payload_i__Field);
					case 5:
						obj3 = value as global::__f__AnonymousType4_3<T_type, T_requestId, T_payload>;
						obj2 = 4;
						break;
					case 0:
						if (obj3 != null)
						{
							obj2 = 2;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_481dc375f7e24d3cb0e875f941fcda75 == 0)
							{
								obj2 = 1;
							}
							break;
						}
						goto case 3;
					case 4:
						if (this == obj3)
						{
							return true;
						}
						obj2 = 6;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e8ca07a3866c4b3b9e07b1ae67715f0c == 0)
						{
							obj2 = 0;
						}
						break;
					case 3:
						return false;
					case 1:
						if (!EqualityComparer<T_type>.Default.Equals(this._type_i__Field, ((global::__f__AnonymousType4_3<T_type, T_requestId, T_payload>)obj3)._type_i__Field))
						{
							obj2 = 3;
							break;
						}
						goto case 2;
					case 2:
						if (((EqualityComparer<object>)(object)EqualityComparer<object>.Default).Equals(this._requestId_i__Field, ((global::__f__AnonymousType4_3<T_type, T_requestId, T_payload>)obj3)._requestId_i__Field))
						{
							goto end_IL_000c;
						}
						goto case 3;
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 12;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public int GetHashCode()
	{
		return unchecked(((1459845534 * -1521134295 + EqualityComparer<T_type>.Default.GetHashCode(this._type_i__Field)) * -1521134295 + ((EqualityComparer<object>)(object)EqualityComparer<object>.Default).GetHashCode(this._requestId_i__Field)) * -1521134295 + ((EqualityComparer<object>)(object)EqualityComparer<object>.Default).GetHashCode(this._payload_i__Field));
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public unsafe string ToString()
	{
		string text = "{{ type = {0}, requestId = {1}, payload = {2} }}";
		object[] array = new object[3];
		object obj = this._type_i__Field;
		array[0] = ((*(T_type*)(&obj) != null) ? ((object)(*(T_type*)(&obj))/*cast due to .constrained prefix*/).ToString() : null);
		object obj2 = this._requestId_i__Field;
		array[1] = ((*(T_requestId*)(&obj2) != null) ? ((object)(*(T_requestId*)(&obj2))/*cast due to .constrained prefix*/).ToString() : null);
		object obj3 = this._payload_i__Field;
		array[2] = ((*(T_payload*)(&obj3) != null) ? ((object)(*(T_payload*)(&obj3))/*cast due to .constrained prefix*/).ToString() : null);
		return string.Format(null, text, array);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool SqbBJlL3rpnVf5QR3Sem()
	{
		return f0STeaL3U2QkXuvRXVga == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object emvBdhL3ogI0IZ7tsjiC()
	{
		return f0STeaL3U2QkXuvRXVga;
	}
}
