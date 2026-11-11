using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using qS8vkpL43FlTMgcj0rgs;

[CompilerGenerated]
internal sealed class __f__AnonymousType9_2<T_File, T_Size>
{
	private readonly T_File _File_i__Field;

	private readonly T_Size _Size_i__Field;

	internal static object KeafNtL35BDbpqfxuH6D;

	public T_File File
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return this._File_i__Field;
		}
	}

	public T_Size Size
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return this._Size_i__Field;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public __f__AnonymousType9_2(T_File File, T_Size Size)
	{
		this._File_i__Field = File;
		this._Size_i__Field = Size;
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public bool Equals(object value)
	{
		//IL_000c: Expected O, but got I4
		//IL_002d: Expected I4, but got O
		//IL_00cc->IL0010: Incompatible stack types: I4 vs O
		//IL_00a3->IL0010: Incompatible stack types: I4 vs O
		//IL_0088->IL0010: Incompatible stack types: I4 vs O
		//IL_00ae->IL0010: Incompatible stack types: I4 vs O
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
						goto case 1;
					case 0:
						return ((EqualityComparer<object>)(object)EqualityComparer<object>.Default).Equals(this._Size_i__Field, ((global::__f__AnonymousType9_2<T_File, T_Size>)obj3)._Size_i__Field);
					case 1:
						return false;
					case 4:
						if (this == obj3)
						{
							return true;
						}
						obj2 = 2;
						break;
					case 2:
						if (obj3 == null)
						{
							obj2 = 5;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f3d80f367d504e3d9064e4cfb99ce343 == 0)
							{
								obj2 = 1;
							}
							break;
						}
						goto case 3;
					case 5:
						obj3 = value as global::__f__AnonymousType9_2<T_File, T_Size>;
						obj2 = 4;
						break;
					case 3:
						if (!EqualityComparer<T_File>.Default.Equals(this._File_i__Field, ((global::__f__AnonymousType9_2<T_File, T_Size>)obj3)._File_i__Field))
						{
							goto end_IL_000c;
						}
						goto case 0;
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
		return unchecked((-1465681479 * -1521134295 + EqualityComparer<T_File>.Default.GetHashCode(this._File_i__Field)) * -1521134295 + ((EqualityComparer<object>)(object)EqualityComparer<object>.Default).GetHashCode(this._Size_i__Field));
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public unsafe string ToString()
	{
		string text = "{{ File = {0}, Size = {1} }}";
		object[] array = new object[2];
		object obj = this._File_i__Field;
		array[0] = ((*(T_File*)(&obj) != null) ? ((object)(*(T_File*)(&obj))/*cast due to .constrained prefix*/).ToString() : null);
		object obj2 = this._Size_i__Field;
		array[1] = ((*(T_Size*)(&obj2) != null) ? ((object)(*(T_Size*)(&obj2))/*cast due to .constrained prefix*/).ToString() : null);
		return string.Format(null, text, array);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool W5QeZQL36j3AlXewaJKZ()
	{
		return KeafNtL35BDbpqfxuH6D == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object bSABvfL3RWgdcsk2PGdu()
	{
		return KeafNtL35BDbpqfxuH6D;
	}
}
