using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using qS8vkpL43FlTMgcj0rgs;

[CompilerGenerated]
internal sealed class __f__AnonymousType7_3<T_path, T_mimeType, T_data>
{
	private readonly T_path _path_i__Field;

	private readonly T_mimeType _mimeType_i__Field;

	private readonly T_data _data_i__Field;

	internal static object QRQg8jL3lGOqGNOfEVGT;

	public T_path path
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return this._path_i__Field;
		}
	}

	public T_mimeType mimeType
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return this._mimeType_i__Field;
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

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public __f__AnonymousType7_3(T_path path, T_mimeType mimeType, T_data data)
	{
		this._path_i__Field = path;
		this._mimeType_i__Field = mimeType;
		this._data_i__Field = data;
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public bool Equals(object value)
	{
		//IL_000c: Expected O, but got I4
		//IL_0031: Expected I4, but got O
		//IL_0064->IL0010: Incompatible stack types: I4 vs O
		//IL_00bd->IL0010: Incompatible stack types: I4 vs O
		//IL_0100->IL0010: Incompatible stack types: I4 vs O
		//IL_00da->IL0010: Incompatible stack types: I4 vs O
		//IL_00c8->IL0010: Incompatible stack types: I4 vs O
		int num = 6;
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
						if ((nint)obj != 13)
						{
							if ((nint)obj == 994)
							{
								goto end_IL_0010;
							}
							goto case 6;
						}
						goto case 4;
					case 6:
						obj3 = value as global::__f__AnonymousType7_3<T_path, T_mimeType, T_data>;
						obj2 = 5;
						break;
					case 2:
						if (obj3 == null)
						{
							goto end_IL_000c;
						}
						goto case 3;
					case 0:
						if (((EqualityComparer<object>)(object)EqualityComparer<object>.Default).Equals(this._mimeType_i__Field, ((global::__f__AnonymousType7_3<T_path, T_mimeType, T_data>)obj3)._mimeType_i__Field))
						{
							obj2 = 1;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2ea097de099140f192d12c8111241f4e == 0)
							{
								obj2 = 8;
							}
							break;
						}
						goto case 4;
					case 5:
						if (this == obj3)
						{
							return true;
						}
						obj2 = 2;
						break;
					case 3:
						if (!EqualityComparer<T_path>.Default.Equals(this._path_i__Field, ((global::__f__AnonymousType7_3<T_path, T_mimeType, T_data>)obj3)._path_i__Field))
						{
							obj2 = 4;
							break;
						}
						goto case 0;
					case 1:
						return ((EqualityComparer<object>)(object)EqualityComparer<object>.Default).Equals(this._data_i__Field, ((global::__f__AnonymousType7_3<T_path, T_mimeType, T_data>)obj3)._data_i__Field);
					case 4:
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
			num = 13;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public int GetHashCode()
	{
		return unchecked(((-1557960635 * -1521134295 + EqualityComparer<T_path>.Default.GetHashCode(this._path_i__Field)) * -1521134295 + ((EqualityComparer<object>)(object)EqualityComparer<object>.Default).GetHashCode(this._mimeType_i__Field)) * -1521134295 + ((EqualityComparer<object>)(object)EqualityComparer<object>.Default).GetHashCode(this._data_i__Field));
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public unsafe string ToString()
	{
		string text = "{{ path = {0}, mimeType = {1}, data = {2} }}";
		object[] array = new object[3];
		object obj = this._path_i__Field;
		array[0] = ((*(T_path*)(&obj) != null) ? ((object)(*(T_path*)(&obj))/*cast due to .constrained prefix*/).ToString() : null);
		object obj2 = this._mimeType_i__Field;
		array[1] = ((*(T_mimeType*)(&obj2) != null) ? ((object)(*(T_mimeType*)(&obj2))/*cast due to .constrained prefix*/).ToString() : null);
		object obj3 = this._data_i__Field;
		array[2] = ((*(T_data*)(&obj3) != null) ? ((object)(*(T_data*)(&obj3))/*cast due to .constrained prefix*/).ToString() : null);
		return string.Format(null, text, array);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool heAxSmL3dPXLJAflVpvu()
	{
		return QRQg8jL3lGOqGNOfEVGT == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object EnwsTDL3KBNHwf8AaoQF()
	{
		return QRQg8jL3lGOqGNOfEVGT;
	}
}
