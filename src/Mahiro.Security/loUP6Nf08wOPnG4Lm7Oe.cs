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
			public static readonly __c __9;

			public static Func<p80fpELccok56mN2TuN2, bool> __9__26_0;

			internal static __c gyB2ZLD7DIiqh3WMZfpL;

			[MethodImpl((MethodImplOptions)8)]
			private static void _cctor()
			{
				// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
				// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
				throw new global::System.NotSupportedException();
			}

			[MethodImpl((MethodImplOptions)8)]
			public __c()
			{
				HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
				int num = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
				{
					num = 1;
				}
				int num2 = default(int);
				while (true)
				{
					switch (num)
					{
					case 0:
						return;
					}
					if (num2 == 988)
					{
						num = num2;
						continue;
					}
					return;
				}
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
				_ArchivePath_k__BackingField = value;
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
				_DestinationPath_k__BackingField = value;
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
				_Files_k__BackingField = value;
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
				_Directories_k__BackingField = value;
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
				_TotalBytes_k__BackingField = value;
			}
		}

		internal int FileCount
		{
			[MethodImpl((MethodImplOptions)8)]
			get
			{
				return ((global::System.Collections.Generic.IReadOnlyCollection<p80fpELccok56mN2TuN2>)Files).Count;
			}
		}

		internal int VerifiedFileCount
		{
			[MethodImpl((MethodImplOptions)8)]
			get
			{
				return Enumerable.Count<p80fpELccok56mN2TuN2>((global::System.Collections.Generic.IEnumerable<p80fpELccok56mN2TuN2>)Files, (Func<p80fpELccok56mN2TuN2, bool>)([MethodImpl((MethodImplOptions)8)] (p80fpELccok56mN2TuN2 file) => file.ExpectedMd5 != null));
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
			int num = 1;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 != 0)
			{
				num = 0;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 0:
					return;
				}
				if (num2 == 988)
				{
					num = num2;
					continue;
				}
				return;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override string ToString()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			StringBuilder val = new StringBuilder();
			return null;
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
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_ArchivePath_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_DestinationPath_k__BackingField)) * -1521134295 + EqualityComparer<global::System.Collections.Generic.IReadOnlyList<p80fpELccok56mN2TuN2>>.Default.GetHashCode(_Files_k__BackingField)) * -1521134295 + EqualityComparer<global::System.Collections.Generic.IReadOnlyList<string>>.Default.GetHashCode(_Directories_k__BackingField)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(_TotalBytes_k__BackingField);
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
			int num = 2;
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					if (num2 != 12)
					{
						if (num2 == 992)
						{
							goto IL_002d;
						}
						goto case 2;
					}
					_Directories_k__BackingField = original._Directories_k__BackingField;
					num = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
					{
						num = 4;
					}
					break;
				case 3:
					_Files_k__BackingField = original._Files_k__BackingField;
					num2 = 12;
					goto IL_002d;
				case 2:
					_ArchivePath_k__BackingField = original._ArchivePath_k__BackingField;
					num = 9;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
					{
						num = 0;
					}
					break;
				case 1:
					return;
				case 4:
					_TotalBytes_k__BackingField = original._TotalBytes_k__BackingField;
					num = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db != 0)
					{
						num = 12;
					}
					break;
				case 0:
					{
						_DestinationPath_k__BackingField = original._DestinationPath_k__BackingField;
						num = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
						{
							num = 12;
						}
						break;
					}
					IL_002d:
					num = num2;
					break;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public void BumLcShO0cJ(out string ArchivePath, out string DestinationPath, out global::System.Collections.Generic.IReadOnlyList<p80fpELccok56mN2TuN2> Files, out global::System.Collections.Generic.IReadOnlyList<string> Directories, out long TotalBytes)
		{
		ArchivePath = default(string);
		DestinationPath = default(string);
		Files = default(global::System.Collections.Generic.IReadOnlyList<p80fpELccok56mN2TuN2>);
		Directories = default(global::System.Collections.Generic.IReadOnlyList<string>);
		TotalBytes = default(long);
			//IL_0009: Expected I8, but got O
Directories = this.Directories;  // was Unsafe.As<_,long> reinterpret
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
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
				_EntryIndex_k__BackingField = value;
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
				_ArchiveRelativePath_k__BackingField = value;
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
				_TargetPath_k__BackingField = value;
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
				_ExpectedMd5_k__BackingField = value;
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
			int num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea != 0)
			{
				num = 0;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 0:
					return;
				}
				if (num2 == 988)
				{
					num = num2;
					continue;
				}
				return;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override string ToString()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			StringBuilder val = new StringBuilder();
			return null;
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
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(_EntryIndex_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_ArchiveRelativePath_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_TargetPath_k__BackingField)) * -1521134295 + EqualityComparer<byte[]>.Default.GetHashCode(_ExpectedMd5_k__BackingField);
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
			int num = 7;
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
			int num = 2;
			int num3 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					if (num3 != 11)
					{
						if (num3 == 991)
						{
							goto IL_002d;
						}
						goto case 2;
					}
					_ExpectedMd5_k__BackingField = original._ExpectedMd5_k__BackingField;
					num = 3;
					break;
				case 2:
					_EntryIndex_k__BackingField = original._EntryIndex_k__BackingField;
					num = 11;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
					{
						num = 0;
					}
					break;
				case 3:
					return;
				case 0:
					_ArchiveRelativePath_k__BackingField = original._ArchiveRelativePath_k__BackingField;
					num = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
					{
						num = 5;
					}
					break;
				case 1:
					{
						_TargetPath_k__BackingField = original._TargetPath_k__BackingField;
						int num2 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
						{
							num2 = 11;
						}
						num3 = num2;
						goto IL_002d;
					}
					IL_002d:
					num = num3;
					break;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public void stuLcyE9451(out int EntryIndex, out string ArchiveRelativePath, out string TargetPath, out byte[]? ExpectedMd5)
		{
		EntryIndex = default(int);
		ArchiveRelativePath = default(string);
		TargetPath = default(string);
		ExpectedMd5 = default(byte[]?);
			//IL_0009: Expected I8, but got O
ExpectedMd5 = this.ExpectedMd5;  // was Unsafe.As<_,long> reinterpret
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
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
		public static readonly __c_92 __9;

		public static Func<string, int> __9__6_0;

		public static Func<string, bool> __9__9_0;

		internal static __c_92 ACd0rCDJXLxrNwB35vXs;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_92()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 4;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
			{
				num = 0;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 0:
					return;
				}
				if (num2 == 988)
				{
					num = num2;
					continue;
				}
				return;
			}
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
			int num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
			{
				num = 1;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 0:
					return;
				}
				if (num2 == 988)
				{
					num = num2;
					continue;
				}
				return;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void lZqLcQ76aAG(bool force)
		{
			int num = 2;
			bool flag = default(bool);
			object obj = default(object);
			int num9 = default(int);
			long num5 = default(long);
			long num7 = default(long);
			int num6 = default(int);
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
										reportProgress.Invoke(num5, num6);
										num4 = 18;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
										{
											num4 = 0;
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
										num6 = System.Threading.Volatile.Read(ref extractedFiles);
										num4 = 9;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
										{
											num4 = 3;
										}
										break;
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
									goto IL_02e8;
								}
								goto IL_0310;
								IL_0310:
								System.Threading.Monitor.Exit(obj);
								int num11 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
								{
									num11 = 1;
								}
								goto IL_02ec;
								IL_02e8:
								num11 = num10;
								goto IL_02ec;
								IL_02ec:
								switch (num11)
								{
								case 0:
									goto IL_0310;
								case 2:
									goto end_IL_02c9;
								case 1:
									goto end_IL_02c9;
								}
								if (num10 == 990)
								{
									goto IL_02e8;
								}
								end_IL_02c9:;
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
			//IL_06af: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Expected O, but got Unknown
			//IL_0403: Unknown result type (might be due to invalid IL or missing references)
			int num = 2;
			int num7 = default(int);
			p80fpELccok56mN2TuN2 p80fpELccok56mN2TuN = default(p80fpELccok56mN2TuN2);
			ZipArchiveEntry val2 = default(ZipArchiveEntry);
			ZipArchive val = default(ZipArchive);
			int num10 = default(int);
			int num12 = default(int);
			int num15 = default(int);
			int num14 = default(int);
			IncrementalHash val5 = default(IncrementalHash);
			int num17 = default(int);
			int num19 = default(int);
			int num21 = default(int);
			int num23 = default(int);
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
							int num3 = ((global::System.Collections.Generic.IReadOnlyCollection<p80fpELccok56mN2TuN2>)plan.Files).Count * workerIndex / workerCount;
							int num4 = ((global::System.Collections.Generic.IReadOnlyCollection<p80fpELccok56mN2TuN2>)plan.Files).Count * (workerIndex + 1) / workerCount;
							byte[] array = new byte[1048576];
							int num5 = num3;
							int num6 = 15;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
							{
								num6 = 7;
							}
							while (true)
							{
								object obj;
								switch (num6)
								{
								default:
									if (num7 != 17)
									{
										if (num7 == 997)
										{
											goto IL_00a6;
										}
										goto case 3;
									}
									p80fpELccok56mN2TuN = plan.Files[num5];
									num6 = 1;
									continue;
								case 1:
									val2 = (val).Entries[p80fpELccok56mN2TuN.EntryIndex];
									num6 = 12;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
									{
										num6 = 4;
									}
									continue;
								case 5:
									num5++;
									num6 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
									{
										num6 = 8;
									}
									continue;
								case 0:
									try
									{
										Stream val3 = (val2).Open();
										int num9 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
										{
											num9 = 0;
										}
										while (true)
										{
											switch (num9)
											{
											default:
												if (num10 == 988)
												{
													goto IL_0192;
												}
												break;
											case 0:
												break;
											}
											break;
											IL_0192:
											num9 = num10;
										}
										try
										{
											FileStream val4 = new FileStream(p80fpELccok56mN2TuN.TargetPath, (FileMode)1, (FileAccess)2, (FileShare)0, 1048576, (FileOptions)134217728);
											int num11 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
											{
												num11 = 0;
											}
											while (true)
											{
												switch (num11)
												{
												default:
													if (num12 == 988)
													{
														goto IL_01fb;
													}
													break;
												case 0:
													break;
												}
												break;
												IL_01fb:
												num11 = num12;
											}
											try
											{
												while (true)
												{
													IL_021c:
													(cancellationToken).ThrowIfCancellationRequested();
													int num13 = 10;
													while (true)
													{
														switch (num13)
														{
														case 0:
															break;
														default:
															if (num15 != 20)
															{
																if (num15 == 1000)
																{
																	goto IL_0244;
																}
																goto case 8;
															}
															if (num14 != 0)
															{
																num13 = 11;
																continue;
															}
															goto case 3;
														case 9:
															if (val5 != null)
															{
																num13 = 4;
																continue;
															}
															goto case 7;
														case 2:
															lZqLcQ76aAG(force: false);
															num13 = 6;
															continue;
														case 11:
															(val4).Write(array, 0, num14);
															num13 = 9;
															continue;
														case 10:
															num14 = (val3).Read(array, 0, array.Length);
															num15 = 20;
															goto IL_0244;
														case 3:
															if (val5 == null)
															{
																num13 = 5;
																continue;
															}
															goto case 1;
														case 7:
															System.Threading.Interlocked.Add(ref extractedBytes, num14);
															num13 = 12;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
															{
																num13 = 15;
															}
															continue;
														case 1:
															if (!System.Security.Cryptography.CryptographicOperations.FixedTimeEquals(((global::System.ReadOnlySpan<byte>)(val5).GetHashAndReset()), p80fpELccok56mN2TuN.ExpectedMd5))
															{
																num13 = 8;
																continue;
															}
															goto case 5;
														case 8:
															throw new InvalidDataException(string.Concat("游戏包文件校验失败：", p80fpELccok56mN2TuN.ArchiveRelativePath));
														case 5:
															System.Threading.Interlocked.Increment(ref extractedFiles);
															num13 = 2;
															continue;
														case 12:
															lZqLcQ76aAG(force: false);
															num13 = 19;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
															{
																num13 = 0;
															}
															continue;
														case 4:
															(val5).AppendData(array, 0, num14);
															num13 = 7;
															continue;
														case 6:
															goto end_IL_0248;
															IL_0244:
															num13 = num15;
															continue;
														}
														goto IL_021c;
														continue;
														end_IL_0248:
														break;
													}
													break;
												}
											}
											finally
											{
												int num16;
												if (val4 == null)
												{
													num16 = 2;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
													{
														num16 = 6;
													}
													goto IL_04a2;
												}
												goto IL_04ea;
												IL_04a2:
												while (true)
												{
													switch (num16)
													{
													default:
														if (num17 == 990)
														{
															goto IL_049e;
														}
														goto end_IL_04a2;
													case 2:
														goto end_IL_04a2;
													case 0:
														break;
													case 1:
														goto end_IL_04a2;
													}
													goto IL_04ea;
													IL_049e:
													num16 = num17;
													continue;
													end_IL_04a2:
													break;
												}
												goto end_IL_046a;
												IL_04ea:
												(val4).Dispose();
												num16 = 4;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
												{
													num16 = 1;
												}
												goto IL_04a2;
												end_IL_046a:;
											}
										}
										finally
										{
											int num18;
											if (val3 == null)
											{
												num18 = 2;
												goto IL_0539;
											}
											goto IL_055d;
											IL_055d:
											(val3).Dispose();
											num18 = 2;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f != 0)
											{
												num18 = 0;
											}
											goto IL_0539;
											IL_0539:
											while (true)
											{
												switch (num18)
												{
												default:
													if (num19 == 990)
													{
														goto IL_0535;
													}
													goto end_IL_0539;
												case 1:
													break;
												case 2:
													goto end_IL_0539;
												case 0:
													goto end_IL_0539;
												}
												goto IL_055d;
												IL_0535:
												num18 = num19;
												continue;
												end_IL_0539:
												break;
											}
										}
									}
									finally
									{
										int num20;
										if (val5 == null)
										{
											num20 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 != 0)
											{
												num20 = 1;
											}
											goto IL_05e5;
										}
										goto IL_0618;
										IL_05e5:
										while (true)
										{
											switch (num20)
											{
											default:
												if (num21 == 990)
												{
													goto IL_05e1;
												}
												break;
											case 1:
												goto end_IL_05e5;
											case 2:
												break;
											case 0:
												goto end_IL_05e5;
											}
											goto IL_0618;
											IL_05e1:
											num20 = num21;
											continue;
											end_IL_05e5:
											break;
										}
										goto end_IL_05ad;
										IL_0618:
										(val5).Dispose();
										num20 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
										{
											num20 = 0;
										}
										goto IL_05e5;
										end_IL_05ad:;
									}
									goto case 5;
								case 7:
								case 8:
									if (num5 >= num4)
									{
										num6 = 9;
										continue;
									}
									goto case 6;
								case 4:
									if (p80fpELccok56mN2TuN.ExpectedMd5 == null)
									{
										num6 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 != 0)
										{
											num6 = 9;
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
									int num8 = 14;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
									{
										num8 = 17;
									}
									num7 = num8;
									goto IL_00a6;
								}
								case 3:
									obj = null;
									break;
								case 9:
									return;
									IL_00a6:
									num6 = num7;
									continue;
								}
								val5 = (IncrementalHash)obj;
								num6 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
								{
									num6 = 3;
								}
							}
						}
						finally
						{
							if (val != null)
							{
								int num22 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
								{
									num22 = 1;
								}
								while (true)
								{
									switch (num22)
									{
									default:
										if (num23 == 989)
										{
											num22 = num23;
											continue;
										}
										break;
									case 1:
										break;
									case 0:
										goto end_IL_0774;
									}
									(val).Dispose();
									num22 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
									{
										num22 = 0;
									}
									continue;
									end_IL_0774:
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
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
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
		System.ArgumentException.ThrowIfNullOrWhiteSpace((string)archivePath, "archivePath");
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static D03AJVLckTZErjaSvxTe aM0f0J28T0s(object archivePath, object destinationPath, int maximumEntryCount, long maximumEntryBytes, long maximumExpandedBytes, CancellationToken cancellationToken)
	{
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_083f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		int num = 5;
		HashSet<string> val5 = default(HashSet<string>);
		string text = default(string);
		long num4 = default(long);
		string destinationPath2 = default(string);
		HashSet<string> val2 = default(HashSet<string>);
		ZipArchive val = default(ZipArchive);
		D03AJVLckTZErjaSvxTe result = default(D03AJVLckTZErjaSvxTe);
		int num8 = default(int);
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		string text4 = default(string);
		List<p80fpELccok56mN2TuN2> val4 = default(List<p80fpELccok56mN2TuN2>);
		int num6 = default(int);
		ZipArchiveEntry val3 = default(ZipArchiveEntry);
		string text2 = default(string);
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
						if (num2 != 15)
						{
							if (num2 == 996)
							{
								goto end_IL_0010;
							}
							goto case 8;
						}
						val5 = new HashSet<string>((IEqualityComparer<string>)(object)System.StringComparer.OrdinalIgnoreCase);
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
						{
							num3 = 0;
						}
						continue;
					case 5:
						text = System.IO.Path.GetFullPath((string)archivePath);
						num3 = 4;
						continue;
					case 2:
						num4 = 0L;
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
						{
							num3 = 0;
						}
						continue;
					case 4:
						if (!System.IO.File.Exists(text))
						{
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
							{
								num3 = 8;
							}
							continue;
						}
						destinationPath2 = System.IO.Path.GetFullPath((string)destinationPath);
						num3 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
						{
							num3 = 3;
						}
						continue;
					case 0:
						val2 = new HashSet<string>((IEqualityComparer<string>)(object)System.StringComparer.OrdinalIgnoreCase);
						num3 = 2;
						continue;
					case 6:
						throw new FileNotFoundException("客户端 ZIP 不存在", text);
					case 1:
						val = tGef0CeRuFb(text);
						num3 = 12;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
						{
							num3 = 8;
						}
						continue;
					case 3:
						break;
					case 7:
						return result;
					case 8:
						try
						{
							if ((val).Entries.Count == 0)
							{
								goto IL_03c3;
							}
							int num5 = 17;
							while (true)
							{
								int num7;
								switch (num5)
								{
								default:
									if (num8 == 43)
									{
										goto case 24;
									}
									if (num8 == 1023)
									{
										goto IL_01df;
									}
									goto case 1;
								case 18:
								case 19:
									(cancellationToken).ThrowIfCancellationRequested();
									num5 = 29;
									continue;
								case 24:
									throw new InvalidDataException("客户端压缩包包含超大单文件");
								case 6:
									defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(15, 1);
									num5 = 38;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
									{
										num5 = 15;
									}
									continue;
								case 16:
									val5.Add(text4);
									num7 = 4;
									goto IL_01db;
								case 4:
									val4.Add((p80fpELccok56mN2TuN2)new p80fpELccok56mN2TuN2(num6, ((val3).FullName).Replace('\\', '/'), text2, (byte[]?)null));
									num5 = 35;
									continue;
								case 31:
									if ((val3).Length <= maximumEntryBytes)
									{
										num4 = checked(num4 + (val3).Length);
										num5 = 25;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
										{
											num5 = 11;
										}
										continue;
									}
									num7 = 43;
									goto IL_01db;
								case 20:
									if (!string.IsNullOrEmpty((val3).Name))
									{
										num5 = 22;
										continue;
									}
									goto case 2;
								case 9:
									break;
								case 17:
									if ((val).Entries.Count <= maximumEntryCount)
									{
										num5 = 27;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
										{
											num5 = 3;
										}
										continue;
									}
									goto case 6;
								case 7:
									if (!((val3).FullName).EndsWith("\\", (StringComparison)4))
									{
										goto case 30;
									}
									goto case 2;
								case 32:
									if (val4.Count == 0)
									{
										num5 = 21;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
										{
											num5 = 26;
										}
										continue;
									}
									result = (D03AJVLckTZErjaSvxTe)new D03AJVLckTZErjaSvxTe(text, destinationPath2, (global::System.Collections.Generic.IReadOnlyList<p80fpELccok56mN2TuN2>)val4, (global::System.Collections.Generic.IReadOnlyList<string>)Enumerable.ToArray<string>((global::System.Collections.Generic.IEnumerable<string>)Enumerable.OrderBy<string, int>((global::System.Collections.Generic.IEnumerable<string>)val5, (Func<string, int>)([MethodImpl((MethodImplOptions)8)] (string path) => (path).Length))), num4);
									num5 = 13;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
									{
										num5 = 25;
									}
									continue;
								case 34:
									throw new InvalidDataException("客户端 ZIP 包含重复文件路径");
								case 8:
									defaultInterpolatedStringHandler.AppendFormatted<int>(maximumEntryCount, "N0");
									num5 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
									{
										num5 = 31;
									}
									continue;
								case 28:
									text2 = Y9Yf04NLDCN(destinationPath2, (val3).FullName);
									num5 = 20;
									continue;
								case 1:
								case 11:
									if (num6 < (val).Entries.Count)
									{
										num5 = 18;
										continue;
									}
									goto case 32;
								case 10:
									if (val2.Add(text2))
									{
										num5 = 12;
										continue;
									}
									goto case 26;
								case 14:
									throw new InvalidDataException((defaultInterpolatedStringHandler).ToStringAndClear());
								case 27:
									num6 = 0;
									num5 = 11;
									continue;
								case 26:
									throw new InvalidDataException("客户端 ZIP 包含重复路径");
								case 12:
									val5.Add(text2);
									num5 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
									{
										num5 = 34;
									}
									continue;
								case 23:
									throw new InvalidDataException("客户端压缩包解压后体积超过限制");
								case 0:
									(defaultInterpolatedStringHandler).AppendLiteral(" 个");
									num5 = 14;
									continue;
								case 25:
									if (num4 <= maximumExpandedBytes)
									{
										if (val2.Add(text2))
										{
											string text3 = System.IO.Path.GetDirectoryName(text2);
											if (text3 == null)
											{
												num5 = 33;
												continue;
											}
											text4 = text3;
											num5 = 16;
										}
										else
										{
											num5 = 13;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
											{
												num5 = 34;
											}
										}
									}
									else
									{
										num5 = 23;
									}
									continue;
								case 22:
									if (((val3).FullName).EndsWith("/", (StringComparison)4))
									{
										num5 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
										{
											num5 = 12;
										}
										continue;
									}
									goto case 7;
								case 30:
									if ((val3).Length < 0)
									{
										num5 = 24;
										continue;
									}
									goto case 31;
								case 15:
									(defaultInterpolatedStringHandler).AppendLiteral("客户端压缩包文件数量超过 ");
									num5 = 8;
									continue;
								case 3:
								case 35:
									num6++;
									num5 = 30;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de != 0)
									{
										num5 = 1;
									}
									continue;
								case 29:
									val3 = (val).Entries[num6];
									num7 = 5;
									goto IL_01db;
								case 5:
									Jp1f0h1O9Oa(val3);
									num5 = 13;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
									{
										num5 = 28;
									}
									continue;
								case 2:
									num5 = 10;
									continue;
								case 33:
									throw new InvalidDataException("无法确定客户端文件目标目录");
								case 21:
									throw new InvalidDataException("客户端压缩包不包含文件");
								case 13:
									goto end_IL_01e3;
									IL_01df:
									num5 = num8;
									continue;
									IL_01db:
									num8 = num7;
									goto IL_01df;
								}
								goto IL_03c3;
								continue;
								end_IL_01e3:
								break;
							}
							goto end_IL_01b1;
							IL_03c3:
							throw new InvalidDataException("客户端压缩包内容为空");
							end_IL_01b1:;
						}
						finally
						{
							if (val != null)
							{
								int num9 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
								{
									num9 = 1;
								}
								while (true)
								{
									switch (num9)
									{
									default:
										if (num10 == 989)
										{
											num9 = num10;
											continue;
										}
										break;
									case 1:
										break;
									case 0:
										goto end_IL_090c;
									}
									(val).Dispose();
									num9 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
									{
										num9 = 2;
									}
									continue;
									end_IL_090c:
									break;
								}
							}
						}
						goto case 7;
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
			val4 = new List<p80fpELccok56mN2TuN2>();
			num = 15;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
			{
				num = 15;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void dvlf0Q7drL9(object plan, Action<long, int>? reportProgress, CancellationToken cancellationToken)
	{
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_01a6: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		int num = 5;
		__c__DisplayClass7_0_7 _c__DisplayClass7_0_ = default(__c__DisplayClass7_0_7);
		global::System.Collections.Generic.IEnumerator<string> enumerator = default(global::System.Collections.Generic.IEnumerator<string>);
		int num5 = default(int);
		int num7 = default(int);
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
					{
						if (num2 != 22)
						{
							if (num2 == 1003)
							{
								goto end_IL_0010;
							}
							goto case 14;
						}
						int num8 = _c__DisplayClass7_0_.workerCount;
						ParallelOptions val = new ParallelOptions();
						((dynamic)((object)val)).MaxDegreeOfParallelism = _c__DisplayClass7_0_.workerCount;
						((dynamic)((object)val)).CancellationToken = _c__DisplayClass7_0_.cancellationToken;
						System.Threading.Tasks.Parallel.For(0, num8, val, _c__DisplayClass7_0_.kgiLcCbkB4U);
						num3 = 8;
						continue;
					}
					case 8:
						_c__DisplayClass7_0_.lZqLcQ76aAG(force: true);
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
						{
							num3 = 11;
						}
						continue;
					case 7:
						_c__DisplayClass7_0_.extractedBytes = 0L;
						num3 = 12;
						continue;
					case 10:
						_c__DisplayClass7_0_.lastReportedBytes = 0L;
						num3 = 9;
						continue;
					case 14:
						_c__DisplayClass7_0_.reportSync = new object();
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
						{
							num3 = 0;
						}
						continue;
					case 6:
						System.ArgumentNullException.ThrowIfNull(_c__DisplayClass7_0_.plan, "plan");
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 != 0)
						{
							num3 = 2;
						}
						continue;
					case 4:
						_c__DisplayClass7_0_.reportProgress = reportProgress;
						num3 = 11;
						continue;
					case 11:
						_c__DisplayClass7_0_.plan = (D03AJVLckTZErjaSvxTe)plan;
						num3 = 15;
						continue;
					case 2:
						System.IO.Directory.CreateDirectory(_c__DisplayClass7_0_.plan.DestinationPath);
						num3 = 13;
						continue;
					case 12:
						_c__DisplayClass7_0_.extractedFiles = 0;
						num3 = 10;
						continue;
					case 1:
						return;
					case 5:
						_c__DisplayClass7_0_ = (__c__DisplayClass7_0_7)new __c__DisplayClass7_0_7();
						num3 = 4;
						continue;
					case 13:
						enumerator = ((global::System.Collections.Generic.IEnumerable<string>)_c__DisplayClass7_0_.plan.Directories).GetEnumerator();
						num = 3;
						break;
					case 15:
						_c__DisplayClass7_0_.cancellationToken = cancellationToken;
						num3 = 6;
						continue;
					case 9:
						_c__DisplayClass7_0_.lastReportTimestamp = System.Environment.TickCount64;
						num3 = 14;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
						{
							num3 = 1;
						}
						continue;
					case 3:
						try
						{
							while (true)
							{
								IL_02dd:
								int num4;
								if (!(enumerator).MoveNext())
								{
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
									{
										num4 = 7;
									}
									goto IL_028c;
								}
								goto IL_02b0;
								IL_02b0:
								string current = enumerator.Current;
								(_c__DisplayClass7_0_.cancellationToken).ThrowIfCancellationRequested();
								System.IO.Directory.CreateDirectory(current);
								num4 = 2;
								goto IL_028c;
								IL_028c:
								while (true)
								{
									switch (num4)
									{
									default:
										if (num5 == 990)
										{
											num4 = num5;
											continue;
										}
										goto end_IL_02dd;
									case 1:
										break;
									case 2:
										goto IL_02dd;
									case 0:
										goto end_IL_02dd;
									}
									break;
								}
								goto IL_02b0;
								continue;
								end_IL_02dd:
								break;
							}
						}
						finally
						{
							int num6;
							if (enumerator == null)
							{
								num6 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 != 0)
								{
									num6 = 4;
								}
								goto IL_034a;
							}
							goto IL_036e;
							IL_034a:
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 990)
									{
										goto IL_0346;
									}
									goto end_IL_034a;
								case 2:
									break;
								case 0:
									goto end_IL_034a;
								case 1:
									goto end_IL_034a;
								}
								goto IL_036e;
								IL_0346:
								num6 = num7;
								continue;
								end_IL_034a:
								break;
							}
							goto end_IL_0312;
							IL_036e:
							(enumerator).Dispose();
							num6 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
							{
								num6 = 1;
							}
							goto IL_034a;
							end_IL_0312:;
						}
						goto case 7;
					case 0:
						_c__DisplayClass7_0_.workerCount = System.Math.Min(System.Math.Min(8, System.Math.Max(1, System.Environment.ProcessorCount)), System.Math.Max(1, (int)System.Math.Ceiling((double)((global::System.Collections.Generic.IReadOnlyCollection<p80fpELccok56mN2TuN2>)_c__DisplayClass7_0_.plan.Files).Count / 512.0)));
						num = 22;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 != 0)
						{
							num = 21;
						}
						break;
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
	private static ZipArchive tGef0CeRuFb(object archivePath)
	{
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		int num = 2;
		ZipArchive result = default(ZipArchive);
		FileStream val = default(FileStream);
		int num4 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0021;
				case 0:
					return result;
				case 1:
					try
					{
						result = new ZipArchive((Stream)(object)val, (ZipArchiveMode)0, false);
						int num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 == 988)
								{
									num3 = num4;
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
						int num5 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
						{
							num5 = 3;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								if (num6 == 989)
								{
									num5 = num6;
									break;
								}
								goto case 1;
							case 1:
								(val).Dispose();
								num5 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
								{
									num5 = 0;
								}
								break;
							case 0:
								throw;
							}
						}
					}
					goto case 0;
				case 2:
					break;
				}
				goto IL_0133;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_0133;
				IL_0133:
				val = new FileStream((string)archivePath, (FileMode)3, (FileAccess)1, (FileShare)1, 1048576, (FileOptions)268435456);
				num2 = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
				{
					num2 = 1;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string Y9Yf04NLDCN(object destinationPath, object entryName)
	{
		string text = string.Concat(((System.ReadOnlySpan<char>)((dynamic)(destinationPath)).TrimEnd(new char[2]
		{
			Path.DirectorySeparatorChar,
			Path.AltDirectorySeparatorChar
		})), new global::System.ReadOnlySpan<char>(new char[] { Path.DirectorySeparatorChar }));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void Jp1f0h1O9Oa(object entry)
	{
		int num = 1;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
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
