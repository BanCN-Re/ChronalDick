using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using qS8vkpL43FlTMgcj0rgs;

[CompilerGenerated]
internal sealed class __f__AnonymousType6_2<T_path, T_content>
{
	private readonly T_path _path_i__Field;

	private readonly T_content _content_i__Field;

	internal static object mV8nJTL3ImJGTx4xMXq2;

	public T_path path
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return this._path_i__Field;
		}
	}

	public T_content content
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return this._content_i__Field;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public __f__AnonymousType6_2(T_path path, T_content content)
	{
		this._path_i__Field = path;
		this._content_i__Field = content;
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public bool Equals(object value)
	{
		//IL_000c: Expected O, but got I4
		//IL_0029: Expected I4, but got O
		//IL_007a->IL0010: Incompatible stack types: I4 vs O
		//IL_00ec->IL0010: Incompatible stack types: I4 vs O
		//IL_0085->IL0010: Incompatible stack types: I4 vs O
		//IL_00f7->IL0010: Incompatible stack types: I4 vs O
		//IL_00a9->IL0010: Incompatible stack types: I4 vs O
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
							goto case 3;
						}
						if (this != obj3)
						{
							obj2 = 4;
							continue;
						}
						return true;
					case 0:
						if (!EqualityComparer<T_path>.Default.Equals(this._path_i__Field, ((global::__f__AnonymousType6_2<T_path, T_content>)obj3)._path_i__Field))
						{
							obj2 = 8;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e22115a4e7ab476da94f74d7e328d269 == 0)
							{
								obj2 = 3;
							}
							continue;
						}
						goto case 1;
					case 2:
						break;
					case 1:
						return ((EqualityComparer<object>)(object)EqualityComparer<object>.Default).Equals(this._content_i__Field, ((global::__f__AnonymousType6_2<T_path, T_content>)obj3)._content_i__Field);
					case 3:
						return false;
					case 4:
						if (obj3 != null)
						{
							obj2 = 7;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ee050290791c4dfbba3a13b8d87cc1bd == 0)
							{
								obj2 = 0;
							}
							continue;
						}
						goto case 3;
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
			obj3 = value as global::__f__AnonymousType6_2<T_path, T_content>;
			num = 11;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public int GetHashCode()
	{
		return unchecked((-1462419582 * -1521134295 + EqualityComparer<T_path>.Default.GetHashCode(this._path_i__Field)) * -1521134295 + ((EqualityComparer<object>)(object)EqualityComparer<object>.Default).GetHashCode(this._content_i__Field));
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	public unsafe string ToString()
	{
		string text = "{{ path = {0}, content = {1} }}";
		object[] array = new object[2];
		object obj = this._path_i__Field;
		array[0] = ((*(T_path*)(&obj) != null) ? ((object)(*(T_path*)(&obj))/*cast due to .constrained prefix*/).ToString() : null);
		object obj2 = this._content_i__Field;
		array[1] = ((*(T_content*)(&obj2) != null) ? ((object)(*(T_content*)(&obj2))/*cast due to .constrained prefix*/).ToString() : null);
		return string.Format(null, text, array);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool FyRUYnL3BZZxTtblMwA3()
	{
		return mV8nJTL3ImJGTx4xMXq2 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object pOPTTYL3gMjADfR7d9lI()
	{
		return mV8nJTL3ImJGTx4xMXq2;
	}
}
