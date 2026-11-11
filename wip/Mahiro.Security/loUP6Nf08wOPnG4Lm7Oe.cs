using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace juC9IPf0yHbXVIJyU2NU;

internal class loUP6Nf08wOPnG4Lm7Oe
{
	internal sealed class D03AJVLckTZErjaSvxTe : IEquatable<D03AJVLckTZErjaSvxTe>
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			public static __c __9;

			public static Func<p80fpELccok56mN2TuN2, bool> __9__26_0;

			internal static __c gyB2ZLD7DIiqh3WMZfpL;

			[MethodImpl((MethodImplOptions)8)]
			private static void _cctor()
			{
				int num = 1;
				while (true)
				{
					int num2 = num;
					while (true)
					{
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								if (num2 != 11)
								{
									if (num2 == 992)
									{
										goto end_IL_0012;
									}
									goto case 0;
								}
								HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
								num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
								{
									num3 = 2;
								}
								continue;
							case 1:
								num3 = 10;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
								{
									num3 = 0;
								}
								continue;
							case 2:
								__9 = (__c)new __c();
								num3 = 3;
								continue;
							case 4:
								xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
								num = 11;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
								{
									num = 3;
								}
								break;
							case 3:
								return;
							case 0:
								num = 4;
								break;
							}
							goto end_IL_000e;
							continue;
							end_IL_0012:
							break;
						}
						continue;
						end_IL_000e:
						break;
					}
				}
			}

			[MethodImpl((MethodImplOptions)8)]
			public __c()
			{
				HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			}

			[MethodImpl((MethodImplOptions)8)]
			internal bool tQpLCNDBLbs(p80fpELccok56mN2TuN2 file)
			{
				return file.ExpectedMd5 != null;
			}

			[MethodImpl((MethodImplOptions)8)]
			internal static bool rguOIaD7kSfhlJPuP038()
			{
				return gyB2ZLD7DIiqh3WMZfpL == null;
			}

			[MethodImpl((MethodImplOptions)8)]
			internal static __c zHvTgZD7VubLVOQiCtSv()
			{
				return gyB2ZLD7DIiqh3WMZfpL;
			}
		}

		[CompilerGenerated]
		private string _ArchivePath_k__BackingField;

		[CompilerGenerated]
		private string _DestinationPath_k__BackingField;

		[CompilerGenerated]
		private global::System.Collections.Generic.IReadOnlyList<p80fpELccok56mN2TuN2> _Files_k__BackingField;

		[CompilerGenerated]
		private global::System.Collections.Generic.IReadOnlyList<string> _Directories_k__BackingField;

		[CompilerGenerated]
		private long _TotalBytes_k__BackingField;

		internal static object FYGbxYDWqL66LEsldhb0;

		[CompilerGenerated]
		private global::System.Type EqualityContract
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return System.Type.GetTypeFromHandle(typeof(D03AJVLckTZErjaSvxTe).TypeHandle);
			}
		}

		public string ArchivePath
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _ArchivePath_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				do
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 0:
							return;
						case 1:
							_ArchivePath_k__BackingField = value;
							num2 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					}
				}
				while (num == 989);
			}
		}

		public string DestinationPath
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _DestinationPath_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				do
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 0:
							return;
						case 1:
							_DestinationPath_k__BackingField = value;
							num2 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					}
				}
				while (num == 989);
			}
		}

		public global::System.Collections.Generic.IReadOnlyList<p80fpELccok56mN2TuN2> Files
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Files_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						default:
							goto IL_001d;
						case 0:
							return;
						case 1:
							break;
						}
						goto IL_0031;
						IL_001d:
						if (num == 989)
						{
							break;
						}
						goto IL_0031;
						IL_0031:
						_Files_k__BackingField = value;
						num2 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 != 0)
						{
							num2 = 0;
						}
					}
				}
			}
		}

		public global::System.Collections.Generic.IReadOnlyList<string> Directories
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Directories_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						default:
							goto IL_001d;
						case 0:
							return;
						case 1:
							break;
						}
						goto IL_0031;
						IL_001d:
						if (num == 989)
						{
							break;
						}
						goto IL_0031;
						IL_0031:
						_Directories_k__BackingField = value;
						num2 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
						{
							num2 = 0;
						}
					}
				}
			}
		}

		public long TotalBytes
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _TotalBytes_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				do
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 0:
							return;
						case 1:
							_TotalBytes_k__BackingField = value;
							num2 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					}
				}
				while (num == 989);
			}
		}

		internal int FileCount
		{
			[MethodImpl((MethodImplOptions)8)]
			get
			{
				//IL_000b: Expected I4, but got O
				return (int)Files;
			}
		}

		internal unsafe int VerifiedFileCount
		{
			[MethodImpl((MethodImplOptions)8)]
			get
			{
				//IL_002c: Expected O, but got I
				//IL_0031: Expected O, but got I
				//IL_0019->IL002c: Incompatible stack heights: 2 vs 3
				global::System.Collections.Generic.IReadOnlyList<p80fpELccok56mN2TuN2> file = Files;
				__c _;
				if (__c.__9__26_0 == null)
				{
					_ = __c.__9;
					__c.__9__26_0 = new Func<p80fpELccok56mN2TuN2, bool>(__c.tQpLCNDBLbs);
				}
				return Enumerable.Count<p80fpELccok56mN2TuN2>((global::System.Collections.Generic.IEnumerable<p80fpELccok56mN2TuN2>)(object)_, new Func<p80fpELccok56mN2TuN2, bool>(__c.tQpLCNDBLbs));
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public D03AJVLckTZErjaSvxTe(string ArchivePath, string DestinationPath, global::System.Collections.Generic.IReadOnlyList<p80fpELccok56mN2TuN2> Files, global::System.Collections.Generic.IReadOnlyList<string> Directories, long TotalBytes)
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			_ArchivePath_k__BackingField = ArchivePath;
			_DestinationPath_k__BackingField = DestinationPath;
			_Files_k__BackingField = Files;
			_Directories_k__BackingField = Directories;
			_TotalBytes_k__BackingField = TotalBytes;
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override string ToString()
{
			// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private bool anKLcVYwY3i(StringBuilder builder)
		{
			System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator !=(D03AJVLckTZErjaSvxTe? left, D03AJVLckTZErjaSvxTe? right)
		{
			return !(left == right);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator ==(D03AJVLckTZErjaSvxTe? left, D03AJVLckTZErjaSvxTe? right)
		{
			int num = 3;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						if (num == 991)
						{
							goto end_IL_0010;
						}
						goto case 0;
					case 3:
						if (left != right)
						{
							num2 = 2;
							break;
						}
						return true;
					case 2:
						if (left == null)
						{
							num2 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 1;
					case 1:
						return ((D03AJVLckTZErjaSvxTe)left).Equals((D03AJVLckTZErjaSvxTe?)right);
					case 0:
						return false;
					}
					continue;
					end_IL_0010:
					break;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected I4, but got Unknown
			return (int)(((((EqualityContract * -1521134295 + _ArchivePath_k__BackingField) * -1521134295 + _DestinationPath_k__BackingField) * -1521134295 + _Files_k__BackingField) * -1521134295 + _Directories_k__BackingField) * -1521134295 + _TotalBytes_k__BackingField);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as D03AJVLckTZErjaSvxTe);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public bool Equals(D03AJVLckTZErjaSvxTe? other)
		{
			int num = 1;
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public D03AJVLckTZErjaSvxTe eocLcYSQBKI()
		{
			return (D03AJVLckTZErjaSvxTe)new D03AJVLckTZErjaSvxTe(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private D03AJVLckTZErjaSvxTe(D03AJVLckTZErjaSvxTe original)
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public void BumLcShO0cJ(out string ArchivePath, out string DestinationPath, out global::System.Collections.Generic.IReadOnlyList<p80fpELccok56mN2TuN2> Files, out global::System.Collections.Generic.IReadOnlyList<string> Directories, out long TotalBytes)
		{
			ArchivePath = default;
			DestinationPath = default;
			Directories = default;
			Files = default;
			TotalBytes = default;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						case 0:
							return;
						case 2:
							goto end_IL_000e;
						case 1:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
							{
								num3 = 0;
							}
							continue;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
							{
								num3 = 1;
							}
							continue;
						}
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
				{
					num = 5;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool QYpjEkDWGRZGZDagxGlP()
		{
			return FYGbxYDWqL66LEsldhb0 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static D03AJVLckTZErjaSvxTe DjdfgWDWikkLBvkewums()
		{
			return (D03AJVLckTZErjaSvxTe)FYGbxYDWqL66LEsldhb0;
		}
	}

	internal sealed class p80fpELccok56mN2TuN2 : IEquatable<p80fpELccok56mN2TuN2>
	{
		[CompilerGenerated]
		private int _EntryIndex_k__BackingField;

		[CompilerGenerated]
		private string _ArchiveRelativePath_k__BackingField;

		[CompilerGenerated]
		private string _TargetPath_k__BackingField;

		[CompilerGenerated]
		private byte[]? _ExpectedMd5_k__BackingField;

		internal static object Njs4R5DWnArrOkXVt1Cp;

		[CompilerGenerated]
		private global::System.Type EqualityContract
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return System.Type.GetTypeFromHandle(typeof(p80fpELccok56mN2TuN2).TypeHandle);
			}
		}

		public int EntryIndex
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _EntryIndex_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				do
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 0:
							return;
						case 1:
							_EntryIndex_k__BackingField = value;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
							{
								num2 = 4;
							}
							continue;
						}
						break;
					}
				}
				while (num == 989);
			}
		}

		public string ArchiveRelativePath
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _ArchiveRelativePath_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						default:
							goto IL_001d;
						case 1:
							break;
						case 0:
							return;
						}
						goto IL_0030;
						IL_001d:
						if (num == 989)
						{
							break;
						}
						goto IL_0030;
						IL_0030:
						_ArchiveRelativePath_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
						{
							num2 = 6;
						}
					}
				}
			}
		}

		public string TargetPath
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _TargetPath_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				do
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 0:
							return;
						case 1:
							_TargetPath_k__BackingField = value;
							num2 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					}
				}
				while (num == 989);
			}
		}

		public byte[]? ExpectedMd5
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _ExpectedMd5_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				do
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 0:
							return;
						case 1:
							_ExpectedMd5_k__BackingField = value;
							num2 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					}
				}
				while (num == 989);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public p80fpELccok56mN2TuN2(int EntryIndex, string ArchiveRelativePath, string TargetPath, byte[]? ExpectedMd5)
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			_EntryIndex_k__BackingField = EntryIndex;
			_ArchiveRelativePath_k__BackingField = ArchiveRelativePath;
			_TargetPath_k__BackingField = TargetPath;
			_ExpectedMd5_k__BackingField = ExpectedMd5;
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override string ToString()
{
			// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private bool R6MLc0V86OX(StringBuilder builder)
		{
			System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator !=(p80fpELccok56mN2TuN2? left, p80fpELccok56mN2TuN2? right)
		{
			return !(left == right);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator ==(p80fpELccok56mN2TuN2? left, p80fpELccok56mN2TuN2? right)
		{
			int num = 2;
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
						goto case 0;
					case 2:
						if (left != right)
						{
							num2 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e == 0)
							{
								num2 = 3;
							}
							break;
						}
						return true;
					case 1:
						if (left != null)
						{
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
							{
								num2 = 4;
							}
							break;
						}
						return false;
					case 0:
						return ((p80fpELccok56mN2TuN2)left).Equals((p80fpELccok56mN2TuN2?)right);
					}
					continue;
					end_IL_0010:
					break;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as p80fpELccok56mN2TuN2);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public bool Equals(p80fpELccok56mN2TuN2? other)
		{
			_ = 0;
			_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393;
			_ = 14;
			(EqualityContract == other.EqualityContract);
			_ = 4;
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public p80fpELccok56mN2TuN2 lhCLc8dhibG()
		{
			return (p80fpELccok56mN2TuN2)new p80fpELccok56mN2TuN2(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private p80fpELccok56mN2TuN2(p80fpELccok56mN2TuN2 original)
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public void stuLcyE9451(out int EntryIndex, out string ArchiveRelativePath, out string TargetPath, out byte[]? ExpectedMd5)
		{
			ArchiveRelativePath = default;
			EntryIndex = default;
			TargetPath = default;
			//IL_0009: Expected I8, but got O
			ExpectedMd5 = default;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0012;
								}
								goto case 1;
							}
							return;
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
							{
								num3 = 5;
							}
							continue;
						case 0:
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 != 0)
							{
								num3 = 2;
							}
							continue;
						case 2:
							break;
						}
						goto end_IL_000e;
						continue;
						end_IL_0012:
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
				num = 2;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool z24ahNDWz8KHOJqDy1cD()
		{
			return Njs4R5DWnArrOkXVt1Cp == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static p80fpELccok56mN2TuN2 RCNWUjDJbQDbtuISis2a()
		{
			return (p80fpELccok56mN2TuN2)Njs4R5DWnArrOkXVt1Cp;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_92
	{
		public static __c_92 __9;

		public static Func<string, int> __9__6_0;

		public static Func<string, bool> __9__9_0;

		internal static __c_92 ACd0rCDJXLxrNwB35vXs;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			int num = 4;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 != 11)
							{
								if (num2 == 992)
								{
									goto end_IL_0012;
								}
								goto case 1;
							}
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
							{
								num3 = 9;
							}
							continue;
						case 0:
							HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
							num3 = 3;
							continue;
						case 3:
							__9 = (__c_92)new __c_92();
							num = 2;
							break;
						case 2:
							return;
						case 4:
							num = 11;
							break;
						}
						goto end_IL_000e;
						continue;
						end_IL_0012:
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_92()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal int zfALcWsFfw8(string path)
		{
			return (path).Length;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool zkELcJ65yWq(string segment)
		{
			return (segment).Contains(':');
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool REn1VVDJfBOABk5MkjUv()
		{
			return ACd0rCDJXLxrNwB35vXs == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_92 xFjVYkDJLvuelUdqmR9q()
		{
			return ACd0rCDJXLxrNwB35vXs;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass7_0_7
	{
		public Action<long, int> reportProgress;

		public object reportSync;

		public long extractedBytes;

		public int extractedFiles;

		public long lastReportedBytes;

		public long lastReportTimestamp;

		public D03AJVLckTZErjaSvxTe plan;

		public int workerCount;

		public CancellationToken cancellationToken;

		internal static __c__DisplayClass7_0_7 G02JVdDJj1Pp7rtkN1k0;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass7_0_7()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void lZqLcQ76aAG(bool force)
		{
			//IL_01d4->IL00ec: Incompatible stack heights: 4 vs 1
			//IL_01df->IL00ec: Incompatible stack heights: 4 vs 1
			int num = 2;
			bool flag = default(bool);
			object obj = default(object);
			int num9 = default(int);
			long num5 = default(long);
			long num7 = default(long);
			int num10 = default(int);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 != 11)
							{
								if (num2 == 992)
								{
									goto end_IL_0010;
								}
								goto case 3;
							}
							flag = false;
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
							{
								num3 = 8;
							}
							continue;
						case 0:
							return;
						case 2:
							if (reportProgress != null)
							{
								num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							return;
						case 4:
							return;
						case 1:
							break;
						case 3:
							try
							{
								System.Threading.Monitor.Enter(obj, ref flag);
								int num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 != 0)
								{
									num4 = 5;
								}
								while (true)
								{
									int num8;
									switch (num4)
									{
									case 4:
										return;
									case 8:
										return;
									default:
										if (num9 != 19)
										{
											if (num9 != 999)
											{
												return;
											}
											goto IL_00e8;
										}
										goto case 10;
									case 1:
										num5 = System.Threading.Interlocked.Read(ref extractedBytes);
										num4 = 10;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 != 0)
										{
											num4 = 3;
										}
										break;
									case 2:
										if (num7 - lastReportTimestamp < 250)
										{
											num4 = 4;
											break;
										}
										goto case 10;
									case 10:
									case 11:
										_ = reportProgress;
										_ = 18;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
										{
											_ = 0;
										}
										break;
									case 9:
										num7 = System.Environment.TickCount64;
										num8 = 7;
										goto IL_00e4;
									case 7:
										if (force)
										{
											num8 = 19;
											goto IL_00e4;
										}
										goto case 5;
									case 6:
										lastReportTimestamp = num7;
										num4 = 8;
										break;
									case 5:
										if (num5 - lastReportedBytes >= 4194304)
										{
											num4 = 11;
											break;
										}
										goto case 2;
									case 3:
									{
										int num6 = System.Threading.Volatile.Read(ref extractedFiles);
										num4 = 9;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
										{
											num4 = 3;
										}
										break;
									}
									case 0:
										{
											lastReportedBytes = num5;
											num4 = 6;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 != 0)
											{
												num4 = 3;
											}
											break;
										}
										IL_00e8:
										num4 = num9;
										break;
										IL_00e4:
										num9 = num8;
										goto IL_00e8;
									}
								}
							}
							finally
							{
								if (!flag)
								{
									num10 = 2;
									goto IL_02e4;
								}
								goto IL_030c;
								IL_030c:
								System.Threading.Monitor.Exit(obj);
								int num11 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
								{
									num11 = 1;
								}
								goto IL_02e8;
								IL_02e4:
								num11 = num10;
								goto IL_02e8;
								IL_02e8:
								switch (num11)
								{
								case 0:
									goto IL_030c;
								case 2:
									goto end_IL_02c5;
								case 1:
									goto end_IL_02c5;
								}
								if (num10 == 990)
								{
									goto IL_02e4;
								}
								end_IL_02c5:;
							}
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
				obj = reportSync;
				num = 11;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void kgiLcCbkB4U(int workerIndex)
		{
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected I4, but got Unknown
			//IL_0071: Expected I4, but got Unknown
			//IL_0106: Expected O, but got I4
			//IL_0693: Unknown result type (might be due to invalid IL or missing references)
			//IL_06bc: Expected O, but got I4
			//IL_01be: Expected O, but got I4
			//IL_011a->IL00a2: Incompatible stack heights: 2 vs 1
			//IL_0125->IL00a2: Incompatible stack heights: 2 vs 1
			//IL_06c6->IL00a2: Incompatible stack heights: 2 vs 1
			int num = 2;
			int num6 = default(int);
			p80fpELccok56mN2TuN2 p80fpELccok56mN2TuN = default(p80fpELccok56mN2TuN2);
			ZipArchive val = default(ZipArchive);
			ZipArchiveEntry val3 = default(ZipArchiveEntry);
			int num9 = default(int);
			int num11 = default(int);
			int num14 = default(int);
			int num13 = default(int);
			IncrementalHash val6 = default(IncrementalHash);
			int num16 = default(int);
			int num18 = default(int);
			int num20 = default(int);
			int num22 = default(int);
			do
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						try
						{
							object val2 = plan.Files * workerIndex / workerCount;
							int num3 = plan.Files * (workerIndex + 1) / workerCount;
							byte[] array = new byte[1048576];
							int num4 = (int)val2;
							int num5 = 15;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
							{
								num5 = 7;
							}
							while (true)
							{
								object obj;
								switch (num5)
								{
								default:
									if (num6 != 17)
									{
										if (num6 == 997)
										{
											goto IL_009e;
										}
										goto case 3;
									}
									_ = plan.Files;
									p80fpELccok56mN2TuN = (p80fpELccok56mN2TuN2)num4;
									_ = 1;
									continue;
								case 1:
									(val).Entries;
									val3 = (ZipArchiveEntry)(object)p80fpELccok56mN2TuN.EntryIndex;
									_ = 12;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
									{
										_ = 4;
									}
									continue;
								case 5:
									num4++;
									num5 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
									{
										num5 = 8;
									}
									continue;
								case 0:
									try
									{
										Stream val4 = (val3).Open();
										int num8 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
										{
											num8 = 0;
										}
										while (true)
										{
											switch (num8)
											{
											default:
												if (num9 == 988)
												{
													goto IL_0186;
												}
												break;
											case 0:
												break;
											}
											break;
											IL_0186:
											num8 = num9;
										}
										try
										{
											_ = p80fpELccok56mN2TuN.TargetPath;
											_ = 1;
											_ = 2;
											_ = 0;
											_ = 1048576;
											FileStream val5 = (FileStream)(object)134217728;
											int num10 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
											{
												num10 = 0;
											}
											while (true)
											{
												switch (num10)
												{
												default:
													if (num11 == 988)
													{
														goto IL_01eb;
													}
													break;
												case 0:
													break;
												}
												break;
												IL_01eb:
												num10 = num11;
											}
											try
											{
												while (true)
												{
													IL_020c:
													(cancellationToken).ThrowIfCancellationRequested();
													int num12 = 10;
													while (true)
													{
														switch (num12)
														{
														case 0:
															break;
														default:
															if (num14 != 20)
															{
																if (num14 == 1000)
																{
																	goto IL_0234;
																}
																goto case 8;
															}
															if (num13 != 0)
															{
																num12 = 11;
																continue;
															}
															goto case 3;
														case 9:
															if (val6 != null)
															{
																num12 = 4;
																continue;
															}
															goto case 7;
														case 2:
															lZqLcQ76aAG(force: false);
															num12 = 6;
															continue;
														case 11:
															(val5).Write(array, 0, num13);
															num12 = 9;
															continue;
														case 10:
															num13 = (val4).Read(array, 0, array.Length);
															num14 = 20;
															goto IL_0234;
														case 3:
															if (val6 == null)
															{
																num12 = 5;
																continue;
															}
															goto case 1;
														case 7:
															System.Threading.Interlocked.Add(ref extractedBytes, num13);
															num12 = 12;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
															{
																num12 = 15;
															}
															continue;
														case 1:
															if (!System.Security.Cryptography.CryptographicOperations.FixedTimeEquals((global::System.ReadOnlySpan<byte>)(val6).GetHashAndReset(), (global::System.ReadOnlySpan<byte>)p80fpELccok56mN2TuN.ExpectedMd5))
															{
																num12 = 8;
																continue;
															}
															goto case 5;
														case 8:
															throw string.Concat("游戏包文件校验失败：", p80fpELccok56mN2TuN.ArchiveRelativePath);
														case 5:
															System.Threading.Interlocked.Increment(ref extractedFiles);
															num12 = 2;
															continue;
														case 12:
															lZqLcQ76aAG(force: false);
															num12 = 19;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
															{
																num12 = 0;
															}
															continue;
														case 4:
															(val6).AppendData(array, 0, num13);
															num12 = 7;
															continue;
														case 6:
															goto end_IL_0238;
															IL_0234:
															num12 = num14;
															continue;
														}
														goto IL_020c;
														continue;
														end_IL_0238:
														break;
													}
													break;
												}
											}
											finally
											{
												int num15;
												if (val5 == null)
												{
													num15 = 2;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
													{
														num15 = 6;
													}
													goto IL_0486;
												}
												goto IL_04ce;
												IL_0486:
												while (true)
												{
													switch (num15)
													{
													default:
														if (num16 == 990)
														{
															goto IL_0482;
														}
														goto end_IL_0486;
													case 2:
														goto end_IL_0486;
													case 0:
														break;
													case 1:
														goto end_IL_0486;
													}
													goto IL_04ce;
													IL_0482:
													num15 = num16;
													continue;
													end_IL_0486:
													break;
												}
												goto end_IL_044e;
												IL_04ce:
												(val5).Dispose();
												num15 = 4;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
												{
													num15 = 1;
												}
												goto IL_0486;
												end_IL_044e:;
											}
										}
										finally
										{
											int num17;
											if (val4 == null)
											{
												num17 = 2;
												goto IL_051d;
											}
											goto IL_0541;
											IL_0541:
											(val4).Dispose();
											num17 = 2;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f != 0)
											{
												num17 = 0;
											}
											goto IL_051d;
											IL_051d:
											while (true)
											{
												switch (num17)
												{
												default:
													if (num18 == 990)
													{
														goto IL_0519;
													}
													goto end_IL_051d;
												case 1:
													break;
												case 2:
													goto end_IL_051d;
												case 0:
													goto end_IL_051d;
												}
												goto IL_0541;
												IL_0519:
												num17 = num18;
												continue;
												end_IL_051d:
												break;
											}
										}
									}
									finally
									{
										int num19;
										if (val6 == null)
										{
											num19 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 != 0)
											{
												num19 = 1;
											}
											goto IL_05c9;
										}
										goto IL_05fc;
										IL_05c9:
										while (true)
										{
											switch (num19)
											{
											default:
												if (num20 == 990)
												{
													goto IL_05c5;
												}
												break;
											case 1:
												goto end_IL_05c9;
											case 2:
												break;
											case 0:
												goto end_IL_05c9;
											}
											goto IL_05fc;
											IL_05c5:
											num19 = num20;
											continue;
											end_IL_05c9:
											break;
										}
										goto end_IL_0591;
										IL_05fc:
										(val6).Dispose();
										num19 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
										{
											num19 = 0;
										}
										goto IL_05c9;
										end_IL_0591:;
									}
									goto case 5;
								case 7:
								case 8:
									if (num4 >= num3)
									{
										num5 = 9;
										continue;
									}
									goto case 6;
								case 4:
									if (p80fpELccok56mN2TuN.ExpectedMd5 == null)
									{
										num5 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 != 0)
										{
											num5 = 9;
										}
										continue;
									}
									goto case 2;
								case 2:
									obj = System.Security.Cryptography.IncrementalHash.CreateHash(System.Security.Cryptography.HashAlgorithmName.MD5);
									break;
								case 6:
								{
									(cancellationToken).ThrowIfCancellationRequested();
									int num7 = 14;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
									{
										num7 = 17;
									}
									num6 = num7;
									goto IL_009e;
								}
								case 3:
									obj = null;
									break;
								case 9:
									return;
									IL_009e:
									num5 = num6;
									continue;
								}
								val6 = (IncrementalHash)obj;
								num5 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
								{
									num5 = 3;
								}
							}
						}
						finally
						{
							if (val != null)
							{
								int num21 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
								{
									num21 = 1;
								}
								while (true)
								{
									switch (num21)
									{
									default:
										if (num22 == 989)
										{
											num21 = num22;
											continue;
										}
										break;
									case 1:
										break;
									case 0:
										goto end_IL_0754;
									}
									(val).Dispose();
									num21 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
									{
										num21 = 0;
									}
									continue;
									end_IL_0754:
									break;
								}
							}
						}
					case 0:
						return;
					case 2:
						val = tGef0CeRuFb(plan.ArchivePath);
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				}
			}
			while (num == 990);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 == 9)
							{
								xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
								num3 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
								{
									num3 = 3;
								}
								continue;
							}
							goto IL_0031;
						case 1:
							break;
						case 0:
							goto end_IL_000e;
						case 2:
							return;
						}
						goto IL_0068;
						IL_0031:
						if (num2 == 990)
						{
							break;
						}
						goto IL_0068;
						IL_0068:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
						{
							num3 = 0;
						}
					}
					continue;
					end_IL_000e:
					break;
				}
				num = 9;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool m0vH4NDJZ42Z9ymsBsfr()
		{
			return G02JVdDJj1Pp7rtkN1k0 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass7_0_7 q6b1e4DJ9Fw2RkYy9Orl()
		{
			return G02JVdDJj1Pp7rtkN1k0;
		}
	}

	internal static object z8FiYtZprQI3HpTpfSDd;

	[MethodImpl((MethodImplOptions)8)]
	internal static bool sqcf0WA0Zuw(object archivePath)
	{
		int num = 2;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			do
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						if (num2 != 14)
						{
							goto end_IL_0010;
						}
						if ((text).Equals(".zip", (StringComparison)5))
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
							{
								num3 = 5;
							}
							continue;
						}
						goto case 7;
					case 1:
						break;
					case 2:
						System.ArgumentException.ThrowIfNullOrWhiteSpace((string)archivePath, "archivePath");
						num3 = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
						{
							num3 = 1;
						}
						continue;
					case 6:
						return (text).Equals(".insPack", (StringComparison)5);
					case 0:
					case 3:
					case 5:
						return true;
					case 7:
						if ((text).Equals(".appx", (StringComparison)5))
						{
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
							{
								num3 = 10;
							}
							continue;
						}
						goto case 4;
					case 4:
						if ((text).Equals(".appxbundle", (StringComparison)5))
						{
							num3 = 5;
							continue;
						}
						goto case 6;
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
			while (num2 == 995);
			text = System.IO.Path.GetExtension((string)archivePath);
			num = 3;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
			{
				num = 14;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static D03AJVLckTZErjaSvxTe aM0f0J28T0s(object archivePath, object destinationPath, int maximumEntryCount, long maximumEntryBytes, long maximumExpandedBytes, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static void dvlf0Q7drL9(object plan, Action<long, int>? reportProgress, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static ZipArchive tGef0CeRuFb(object archivePath)
	{
		//IL_0140: Expected O, but got I4
		//IL_003f: Expected O, but got I4
		//IL_0154->IL0010: Incompatible stack heights: 6 vs 1
		//IL_015f->IL0010: Incompatible stack heights: 6 vs 1
		int num = 2;
		ZipArchive result = default(ZipArchive);
		int num3 = default(int);
		int num5 = default(int);
		FileStream val = default(FileStream);
		while (true)
		{
			while (true)
			{
				switch (num)
				{
				default:
					goto IL_0021;
				case 0:
					return result;
				case 1:
					try
					{
						_ = 0;
						result = (ZipArchive)(object)0;
						int num2 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de != 0)
						{
							num2 = 0;
						}
						while (true)
						{
							switch (num2)
							{
							default:
								if (num3 == 988)
								{
									num2 = num3;
									continue;
								}
								break;
							case 0:
								break;
							}
							break;
						}
					}
					catch
					{
						int num4 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
						{
							num4 = 3;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								if (num5 == 989)
								{
									num4 = num5;
									break;
								}
								goto case 1;
							case 1:
								(val).Dispose();
								num4 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
								{
									num4 = 0;
								}
								break;
							case 0:
								throw new global::System.Exception();
							}
						}
					}
					goto case 0;
				case 2:
					break;
				}
				goto IL_012f;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_012f;
				IL_012f:
				_ = 3;
				_ = 1;
				_ = 1;
				_ = 1048576;
				val = (FileStream)(object)268435456;
				_ = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
				{
					_ = 1;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string Y9Yf04NLDCN(object destinationPath, object entryName)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void Jp1f0h1O9Oa(object entry)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 989)
					{
						goto end_IL_0010;
					}
					goto case 0;
				case 1:
					if ((((entry).ExternalAttributes >> 16) & 0xFFFF & 0xF000) == 40960)
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
						{
							num2 = 2;
						}
						break;
					}
					return;
				case 0:
					throw new global::System.Exception("客户端压缩包不能包含符号链接");
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto end_IL_0012;
							}
							goto case 1;
						}
						return;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
						{
							num3 = 6;
						}
						continue;
					case 2:
						num3 = 1;
						continue;
					case 0:
						break;
					}
					goto end_IL_000e;
					continue;
					end_IL_0012:
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
			{
				num = 8;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool z9IyVFZposU99yDnlCKa()
	{
		return z8FiYtZprQI3HpTpfSDd == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static loUP6Nf08wOPnG4Lm7Oe QvCQPxZpmo0HSyZ8f1s9()
	{
		return (loUP6Nf08wOPnG4Lm7Oe)z8FiYtZprQI3HpTpfSDd;
	}
}
