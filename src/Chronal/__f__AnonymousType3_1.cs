using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using qS8vkpL43FlTMgcj0rgs;

[CompilerGenerated]
internal sealed class __f__AnonymousType3_1<T_type>
{
	private readonly T_type _type_i__Field;

	internal static object h2CffwL3C1hpiLBlkXZf;

	public T_type type
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return this._type_i__Field;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public __f__AnonymousType3_1(T_type type)
	{
		this._type_i__Field = type;
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public bool Equals(object value)
	{
		//IL_000c: Expected O, but got I4
		//IL_0025: Expected I4, but got O
		//IL_0062->IL0010: Incompatible stack types: I4 vs O
		//IL_00d7->IL0010: Incompatible stack types: I4 vs O
		//IL_006d->IL0010: Incompatible stack types: I4 vs O
		//IL_00e2->IL0010: Incompatible stack types: I4 vs O
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
						if ((nint)obj != 10)
						{
							if ((nint)obj == 991)
							{
								goto end_IL_0010;
							}
							goto case 3;
						}
						return false;
					case 3:
						obj3 = value as global::__f__AnonymousType3_1<T_type>;
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ef04e2823b234f2aa7c3630bcaafe597 == 0)
						{
							obj2 = 2;
						}
						continue;
					case 0:
						if (obj3 == null)
						{
							break;
						}
						goto case 1;
					case 1:
						return EqualityComparer<T_type>.Default.Equals(this._type_i__Field, ((global::__f__AnonymousType3_1<T_type>)obj3)._type_i__Field);
					case 2:
						if (this == obj3)
						{
							return true;
						}
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5d72748c192f4bab9e19ca961e9277d1 == 0)
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
			num = 10;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_499faaea7a6445f1af0f623e48ebbb18 == 0)
			{
				num = 6;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public int GetHashCode()
	{
		return unchecked(-21465348 * -1521134295) + EqualityComparer<T_type>.Default.GetHashCode(this._type_i__Field);
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public unsafe string ToString()
	{
		string text = "{{ type = {0} }}";
		object[] array = new object[1];
		object obj = this._type_i__Field;
		array[0] = ((*(T_type*)(&obj) != null) ? ((object)(*(T_type*)(&obj))/*cast due to .constrained prefix*/).ToString() : null);
		return string.Format(null, text, array);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool BDKIQvL34lpnVmKg1UAO()
	{
		return h2CffwL3C1hpiLBlkXZf == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object KIgTBVL3hmpOoARRIJ0y()
	{
		return h2CffwL3C1hpiLBlkXZf;
	}
}
