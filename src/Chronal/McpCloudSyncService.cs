using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using Ho1Bbrf69UmDWyTf7WZ4;
using VW5x9Sf6Yl3Avl436WrG;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Features.McpStudio.Services;

internal sealed class McpCloudSyncService
{
	internal sealed class SyncResult
	{
		[CompilerGenerated]
		private int _Downloaded_k__BackingField;

		[CompilerGenerated]
		private int _Existing_k__BackingField;

		private static SyncResult c3XAEbLEMjE7NSQP2rEh;

		public int Downloaded
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Downloaded_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				//IL_000c: Expected O, but got I4
				//IL_001d: Expected I4, but got O
				//IL_004b->IL0010: Incompatible stack types: I4 vs O
				//IL_0056->IL0010: Incompatible stack types: I4 vs O
				object obj = 1;
				while (true)
				{
					object obj2 = obj;
					while (true)
					{
						switch ((int)obj2)
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
						if ((nint)obj == 989)
						{
							break;
						}
						goto IL_0030;
						IL_0030:
						_Downloaded_k__BackingField = value;
						obj2 = 6;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7965c0cf8c924e228a4010c08420db19 == 0)
						{
							obj2 = 0;
						}
					}
				}
			}
		}

		public int Existing
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Existing_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				//IL_000c: Expected O, but got I4
				//IL_001d: Expected I4, but got O
				//IL_004c->IL0010: Incompatible stack types: I4 vs O
				//IL_0057->IL0010: Incompatible stack types: I4 vs O
				object obj = 1;
				do
				{
					object obj2 = obj;
					while (true)
					{
						switch ((int)obj2)
						{
						case 0:
							return;
						case 1:
							_Existing_k__BackingField = value;
							obj2 = 2;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2ee4c54a6c424cb680cd9d0811cd1011 != 0)
							{
								obj2 = 0;
							}
							continue;
						}
						break;
					}
				}
				while ((nint)obj == 989);
			}
		}

		[CompilerGenerated]
		private readonly List<string> _Errors_k__BackingField;

		[field: CompilerGenerated]
		public List<string> Errors
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Errors_k__BackingField;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public SyncResult()
		{
			//IL_005c: Expected I4, but got O
			//IL_0041->IL0053: Incompatible stack types: I4 vs O
			//IL_004c->IL0053: Incompatible stack types: I4 vs O
			_Errors_k__BackingField = new List<string>();
			object obj = 0;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_401ab1a410ca4fdcae9d2ecf627c5703 == 0)
			{
				obj = 3;
			}
			object obj2 = default(object);
			while (true)
			{
				switch ((int)obj)
				{
				case 0:
					return;
				}
				if ((nint)obj2 == 988)
				{
					obj = obj2;
					continue;
				}
				return;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool h54dtOLEpC5Ix3YllVOu()
		{
			return c3XAEbLEMjE7NSQP2rEh == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static SyncResult gPA4G6LEuHgtqb0swlpm()
		{
			return c3XAEbLEMjE7NSQP2rEh;
		}
	}

	[CompilerGenerated]
	private static class __O_1
	{
		public static Func<char, bool> _0___IsHexDigit;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_5
	{
		public static readonly __c_5 __9;

		public static Func<JEDl1cf6VmwwyP6UuZ5V, long> __9__4_0;

		public static Func<IGrouping<long, JEDl1cf6VmwwyP6UuZ5V>, JEDl1cf6VmwwyP6UuZ5V> __9__4_1;

		public static Func<char, bool> __9__5_0;

		private static __c_5 eiFVYLLEvBmsH6rm1326;

		[MethodImpl((MethodImplOptions)8)]
		static __c_5()
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
							if (num2 != 10)
							{
								if (num2 == 991)
								{
									goto end_IL_0012;
								}
								goto case 0;
							}
							return;
						case 1:
							num3 = 0;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1e22fe50e3d646ca9b01633c735c9082 == 0)
							{
								num3 = 5;
							}
							continue;
						case 2:
							num3 = 3;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5abcb08dd0ae4b88988bbb89131b0cab == 0)
							{
								num3 = 1;
							}
							continue;
						case 3:
							break;
						case 0:
							num3 = 2;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_30453b5c95424721b20dac45933b18fc == 0)
							{
								num3 = 7;
							}
							continue;
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
				__9 = (__c_5)new __c_5();
				num = 10;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_5()
		{
			//IL_004c: Expected I4, but got O
			//IL_0031->IL0043: Incompatible stack types: I4 vs O
			//IL_003c->IL0043: Incompatible stack types: I4 vs O
			object obj = 6;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_6883c26806134cb3b7f5e7b631c19374 == 0)
			{
				obj = 0;
			}
			object obj2 = default(object);
			while (true)
			{
				switch ((int)obj)
				{
				case 0:
					return;
				}
				if ((nint)obj2 == 988)
				{
					obj = obj2;
					continue;
				}
				return;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal long _SyncAsync_b__4_0(JEDl1cf6VmwwyP6UuZ5V item)
		{
			return (item).BlobId;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal JEDl1cf6VmwwyP6UuZ5V _SyncAsync_b__4_1(IGrouping<long, JEDl1cf6VmwwyP6UuZ5V> group)
		{
			return Enumerable.First<JEDl1cf6VmwwyP6UuZ5V>((global::System.Collections.Generic.IEnumerable<JEDl1cf6VmwwyP6UuZ5V>)group);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _DownloadAsync_b__5_0(char ch)
		{
			return !Enumerable.Contains<char>((global::System.Collections.Generic.IEnumerable<char>)System.IO.Path.GetInvalidFileNameChars(), ch);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool tH1utGLEErFQVUbt8YmM()
		{
			return eiFVYLLEvBmsH6rm1326 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_5 yLq3C9LE2PtV3aunC0Jm()
		{
			return eiFVYLLEvBmsH6rm1326;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _DownloadAsync_d__5 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<bool> __t__builder;

		public JEDl1cf6VmwwyP6UuZ5V item;

		public string pendingPath;

		public CancellationToken cancellationToken;

		public string staging;

		public McpCloudSyncService __4__this;

		private string _stem_5__2;

		private string _target_5__3;

		private string _temporary_5__4;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1;

		private global::System.Collections.Generic.IEnumerator<string> __7__wrap4;

		private FileStream _output_5__6;

		private object __7__wrap6;

		private int __7__wrap7;

		private long _offset_5__9;

		private int _length_5__10;

		private byte[] _bytes_5__11;

		private ConfiguredTaskAwaitable<blITQ5f6ZD0ur9oMSjQ5>.ConfiguredTaskAwaiter __u__2;

		private object __u__3;

		private ValueTaskAwaiter __u__4;

		internal static object HsEvmNLEqX41bFU70PDo;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_000c: Expected O, but got I4
			//IL_0029: Expected I4, but got O
			//IL_15d2: Expected I4, but got O
			//IL_1a5a: Expected I4, but got O
			//IL_1afe: Expected O, but got I4
			//IL_1b3c: Expected I4, but got O
			//IL_0ae4: Expected I4, but got O
			//IL_19a5: Expected I4, but got O
			//IL_006a: Expected I4, but got O
			//IL_0e50: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e84: Unknown result type (might be due to invalid IL or missing references)
			//IL_1736: Unknown result type (might be due to invalid IL or missing references)
			//IL_1740: Expected O, but got Unknown
			//IL_1673: Unknown result type (might be due to invalid IL or missing references)
			//IL_1901: Expected O, but got I4
			//IL_0e77: Expected O, but got I4
			//IL_0e0d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e14: Expected O, but got Unknown
			//IL_18c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_18c9: Expected O, but got Unknown
			//IL_1716: Unknown result type (might be due to invalid IL or missing references)
			//IL_0db1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dbc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dc3: Expected O, but got Unknown
			//IL_17de: Unknown result type (might be due to invalid IL or missing references)
			//IL_17e5: Expected O, but got Unknown
			//IL_18ed: Expected O, but got I4
			//IL_1915: Expected O, but got I4
			//IL_1849: Unknown result type (might be due to invalid IL or missing references)
			//IL_1632: Unknown result type (might be due to invalid IL or missing references)
			//IL_1639: Expected O, but got Unknown
			//IL_0e65: Expected O, but got I4
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Expected O, but got Unknown
			//IL_0cde: Expected O, but got I4
			//IL_1527: Unknown result type (might be due to invalid IL or missing references)
			//IL_152e: Expected O, but got Unknown
			//IL_05af: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f0: Expected O, but got I4
			//IL_0708: Unknown result type (might be due to invalid IL or missing references)
			//IL_0713: Unknown result type (might be due to invalid IL or missing references)
			//IL_071a: Expected O, but got Unknown
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bf2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0316: Unknown result type (might be due to invalid IL or missing references)
			//IL_031d: Expected O, but got Unknown
			//IL_0428: Expected O, but got I4
			//IL_03d4: Expected O, but got I4
			//IL_0d83: Expected I4, but got O
			//IL_0c9b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cb1: Expected I4, but got Unknown
			//IL_0097: Expected O, but got I4
			//IL_037f: Unknown result type (might be due to invalid IL or missing references)
			//IL_136c: Unknown result type (might be due to invalid IL or missing references)
			//IL_14ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_14d1: Expected O, but got Unknown
			//IL_127f: Expected O, but got I4
			//IL_104c: Expected O, but got I4
			//IL_141b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1422: Expected O, but got Unknown
			//IL_1322: Expected O, but got I4
			//IL_0ffe: Unknown result type (might be due to invalid IL or missing references)
			//IL_1009: Unknown result type (might be due to invalid IL or missing references)
			//IL_1010: Expected O, but got Unknown
			//IL_1459: Unknown result type (might be due to invalid IL or missing references)
			//IL_11f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_11f9: Expected O, but got Unknown
			//IL_12c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_12c8: Expected O, but got Unknown
			//IL_11be: Unknown result type (might be due to invalid IL or missing references)
			//IL_118d: Unknown result type (might be due to invalid IL or missing references)
			//IL_121f: Unknown result type (might be due to invalid IL or missing references)
			//IL_140a: Unknown result type (might be due to invalid IL or missing references)
			//IL_142f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a80: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a87: Expected O, but got Unknown
			//IL_0ec3: Expected O, but got I4
			//IL_146b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1471: Unknown result type (might be due to invalid IL or missing references)
			//IL_14e0: Expected O, but got I4
			//IL_0138: Expected I4, but got O
			//IL_0a2d: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_09aa: Expected O, but got Unknown
			//IL_0951: Unknown result type (might be due to invalid IL or missing references)
			//IL_095c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0963: Expected O, but got Unknown
			//IL_09f6: Expected O, but got I4
			//IL_09b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ed: Expected O, but got I4
			//IL_0f74: Expected I4, but got O
			//IL_0882: Expected O, but got I4
			//IL_0a08: Expected O, but got I4
			//IL_08c7: Expected I4, but got O
			//IL_15a8->IL15c5: Incompatible stack types: I4 vs O
			//IL_1a2c->IL1a49: Incompatible stack types: I4 vs O
			//IL_0abd->IL0acf: Incompatible stack types: I4 vs O
			//IL_15b3->IL15c5: Incompatible stack types: I4 vs O
			//IL_1973->IL1990: Incompatible stack types: I4 vs O
			//IL_1a37->IL1a49: Incompatible stack types: I4 vs O
			//IL_0b16->IL0acf: Incompatible stack types: I4 vs O
			//IL_1601->IL15c5: Incompatible stack types: I4 vs O
			//IL_19fb->IL1990: Incompatible stack types: I4 vs O
			//IL_197e->IL1990: Incompatible stack types: I4 vs O
			//IL_1aab->IL1a49: Incompatible stack types: I4 vs O
			//IL_1a8e->IL1a49: Incompatible stack types: I4 vs O
			//IL_0b21->IL0acf: Incompatible stack types: I4 vs O
			//IL_0b54->IL0acf: Incompatible stack types: I4 vs O
			//IL_160c->IL15c5: Incompatible stack types: I4 vs O
			//IL_1a15->IL1990: Incompatible stack types: I4 vs O
			//IL_1a99->IL1a49: Incompatible stack types: I4 vs O
			//IL_0b5f->IL0acf: Incompatible stack types: I4 vs O
			//IL_1792->IL0ce2: Incompatible stack types: I4 vs O
			//IL_1823->IL0ce2: Incompatible stack types: I4 vs O
			//IL_1aeb->IL0010: Incompatible stack types: I4 vs O
			//IL_1b50->IL0010: Incompatible stack types: I4 vs O
			//IL_182e->IL0ce2: Incompatible stack types: I4 vs O
			//IL_1af6->IL0010: Incompatible stack types: I4 vs O
			//IL_1b5b->IL0010: Incompatible stack types: I4 vs O
			//IL_1b24->IL0010: Incompatible stack types: I4 vs O
			//IL_0e60->IL0ce2: Incompatible stack types: I4 vs O
			//IL_1846->IL0ce2: Incompatible stack types: I4 vs O
			//IL_1910->IL0ce2: Incompatible stack types: I4 vs O
			//IL_0e81->IL0ce2: Incompatible stack types: I4 vs O
			//IL_17d2->IL0ce2: Incompatible stack types: I4 vs O
			//IL_0e1e->IL0ce2: Incompatible stack types: I4 vs O
			//IL_18dd->IL0ce2: Incompatible stack types: I4 vs O
			//IL_1726->IL0ce2: Incompatible stack types: I4 vs O
			//IL_0dcd->IL0ce2: Incompatible stack types: I4 vs O
			//IL_17f9->IL0ce2: Incompatible stack types: I4 vs O
			//IL_18bb->IL0ce2: Incompatible stack types: I4 vs O
			//IL_18fc->IL0ce2: Incompatible stack types: I4 vs O
			//IL_0e2f->IL0ce2: Incompatible stack types: I4 vs O
			//IL_1924->IL0ce2: Incompatible stack types: I4 vs O
			//IL_1858->IL0ce2: Incompatible stack types: I4 vs O
			//IL_164d->IL0ce2: Incompatible stack types: I4 vs O
			//IL_18aa->IL0ce2: Incompatible stack types: I4 vs O
			//IL_1883->IL0ce2: Incompatible stack types: I4 vs O
			//IL_0e00->IL0ce2: Incompatible stack types: I4 vs O
			//IL_17b2->IL0ce2: Incompatible stack types: I4 vs O
			//IL_175b->IL0ce2: Incompatible stack types: I4 vs O
			//IL_01b1->IL009b: Incompatible stack types: I4 vs O
			//IL_0399->IL009b: Incompatible stack types: I4 vs O
			//IL_034b->IL009b: Incompatible stack types: I4 vs O
			//IL_007e->IL009b: Incompatible stack types: I4 vs O
			//IL_1b2f->IL0010: Incompatible stack types: I4 vs O
			//IL_17dd->IL0ce2: Incompatible stack types: I4 vs O
			//IL_18e8->IL0ce2: Incompatible stack types: I4 vs O
			//IL_0e4a->IL0ce2: Incompatible stack types: I4 vs O
			//IL_1804->IL0ce2: Incompatible stack types: I4 vs O
			//IL_1631->IL0ce2: Incompatible stack types: I4 vs O
			//IL_169d->IL0ce2: Incompatible stack types: I4 vs O
			//IL_1710->IL0ce2: Incompatible stack types: I4 vs O
			//IL_1658->IL0ce2: Incompatible stack types: I4 vs O
			//IL_188e->IL0ce2: Incompatible stack types: I4 vs O
			//IL_1952->IL0ce2: Incompatible stack types: I4 vs O
			//IL_0e0b->IL0ce2: Incompatible stack types: I4 vs O
			//IL_17bd->IL0ce2: Incompatible stack types: I4 vs O
			//IL_0356->IL009b: Incompatible stack types: I4 vs O
			//IL_0089->IL009b: Incompatible stack types: I4 vs O
			//IL_1538->IL0ec7: Incompatible stack types: I4 vs O
			//IL_0eb5->IL0ec7: Incompatible stack types: I4 vs O
			//IL_16a8->IL0ce2: Incompatible stack types: I4 vs O
			//IL_1771->IL0ce2: Incompatible stack types: I4 vs O
			//IL_0626->IL009b: Incompatible stack types: I4 vs O
			//IL_084c->IL009b: Incompatible stack types: I4 vs O
			//IL_0309->IL009b: Incompatible stack types: I4 vs O
			//IL_0582->IL009b: Incompatible stack types: I4 vs O
			//IL_0724->IL009b: Incompatible stack types: I4 vs O
			//IL_02b2->IL009b: Incompatible stack types: I4 vs O
			//IL_0327->IL009b: Incompatible stack types: I4 vs O
			//IL_0371->IL009b: Incompatible stack types: I4 vs O
			//IL_0432->IL009b: Incompatible stack types: I4 vs O
			//IL_0219->IL009b: Incompatible stack types: I4 vs O
			//IL_01d3->IL009b: Incompatible stack types: I4 vs O
			//IL_0287->IL009b: Incompatible stack types: I4 vs O
			//IL_0453->IL009b: Incompatible stack types: I4 vs O
			//IL_017e->IL009b: Incompatible stack types: I4 vs O
			//IL_03c4->IL009b: Incompatible stack types: I4 vs O
			//IL_0598->IL009b: Incompatible stack types: I4 vs O
			//IL_0314->IL009b: Incompatible stack types: I4 vs O
			//IL_02eb->IL009b: Incompatible stack types: I4 vs O
			//IL_02bd->IL009b: Incompatible stack types: I4 vs O
			//IL_025c->IL009b: Incompatible stack types: I4 vs O
			//IL_037c->IL009b: Incompatible stack types: I4 vs O
			//IL_0224->IL009b: Incompatible stack types: I4 vs O
			//IL_01de->IL009b: Incompatible stack types: I4 vs O
			//IL_038e->IL009b: Incompatible stack types: I4 vs O
			//IL_137c->IL0ec7: Incompatible stack types: I4 vs O
			//IL_14db->IL0ec7: Incompatible stack types: I4 vs O
			//IL_149d->IL0ec7: Incompatible stack types: I4 vs O
			//IL_13d1->IL0ec7: Incompatible stack types: I4 vs O
			//IL_1160->IL0ec7: Incompatible stack types: I4 vs O
			//IL_10f9->IL0ec7: Incompatible stack types: I4 vs O
			//IL_128e->IL0ec7: Incompatible stack types: I4 vs O
			//IL_1047->IL0ec7: Incompatible stack types: I4 vs O
			//IL_142c->IL0ec7: Incompatible stack types: I4 vs O
			//IL_1331->IL0ec7: Incompatible stack types: I4 vs O
			//IL_12f9->IL0ec7: Incompatible stack types: I4 vs O
			//IL_1024->IL0ec7: Incompatible stack types: I4 vs O
			//IL_13fc->IL0ec7: Incompatible stack types: I4 vs O
			//IL_135b->IL0ec7: Incompatible stack types: I4 vs O
			//IL_12dc->IL0ec7: Incompatible stack types: I4 vs O
			//IL_119d->IL0ec7: Incompatible stack types: I4 vs O
			//IL_1419->IL0ec7: Incompatible stack types: I4 vs O
			//IL_143e->IL0ec7: Incompatible stack types: I4 vs O
			//IL_151b->IL0ec7: Incompatible stack types: I4 vs O
			//IL_0cc5->IL0ce2: Incompatible stack types: I4 vs O
			//IL_0292->IL009b: Incompatible stack types: I4 vs O
			//IL_0c97->IL009b: Incompatible stack types: I4 vs O
			//IL_0b90->IL009b: Incompatible stack types: I4 vs O
			//IL_03cf->IL009b: Incompatible stack types: I4 vs O
			//IL_0c2e->IL009b: Incompatible stack types: I4 vs O
			//IL_0a9b->IL0886: Incompatible stack types: I4 vs O
			//IL_0869->IL0886: Incompatible stack types: I4 vs O
			//IL_0267->IL009b: Incompatible stack types: I4 vs O
			//IL_10a5->IL0ec7: Incompatible stack types: I4 vs O
			//IL_13dc->IL0ec7: Incompatible stack types: I4 vs O
			//IL_117c->IL0ec7: Incompatible stack types: I4 vs O
			//IL_11ea->IL0ec7: Incompatible stack types: I4 vs O
			//IL_155d->IL0ec7: Incompatible stack types: I4 vs O
			//IL_127a->IL0ec7: Incompatible stack types: I4 vs O
			//IL_102f->IL0ec7: Incompatible stack types: I4 vs O
			//IL_1407->IL0ec7: Incompatible stack types: I4 vs O
			//IL_10c1->IL0ec7: Incompatible stack types: I4 vs O
			//IL_1366->IL0ec7: Incompatible stack types: I4 vs O
			//IL_12e7->IL0ec7: Incompatible stack types: I4 vs O
			//IL_13ad->IL0ec7: Incompatible stack types: I4 vs O
			//IL_148c->IL0ec7: Incompatible stack types: I4 vs O
			//IL_0fcf->IL0ec7: Incompatible stack types: I4 vs O
			//IL_12b5->IL0ec7: Incompatible stack types: I4 vs O
			//IL_1148->IL0ec7: Incompatible stack types: I4 vs O
			//IL_158d->IL0ec7: Incompatible stack types: I4 vs O
			//IL_1526->IL0ec7: Incompatible stack types: I4 vs O
			//IL_14ef->IL0ec7: Incompatible stack types: I4 vs O
			//IL_0cd0->IL0ce2: Incompatible stack types: I4 vs O
			//IL_0bd7->IL009b: Incompatible stack types: I4 vs O
			//IL_0aa6->IL0886: Incompatible stack types: I4 vs O
			//IL_0874->IL0886: Incompatible stack types: I4 vs O
			//IL_10b0->IL0ec7: Incompatible stack types: I4 vs O
			//IL_1187->IL0ec7: Incompatible stack types: I4 vs O
			//IL_1568->IL0ec7: Incompatible stack types: I4 vs O
			//IL_0fda->IL0ec7: Incompatible stack types: I4 vs O
			//IL_12c0->IL0ec7: Incompatible stack types: I4 vs O
			//IL_1240->IL0ec7: Incompatible stack types: I4 vs O
			//IL_0a47->IL0886: Incompatible stack types: I4 vs O
			//IL_096d->IL0886: Incompatible stack types: I4 vs O
			//IL_0a05->IL0886: Incompatible stack types: I4 vs O
			//IL_09c6->IL0886: Incompatible stack types: I4 vs O
			//IL_08fc->IL0886: Incompatible stack types: I4 vs O
			//IL_0a74->IL0886: Incompatible stack types: I4 vs O
			//IL_0a52->IL0886: Incompatible stack types: I4 vs O
			//IL_0996->IL0886: Incompatible stack types: I4 vs O
			//IL_0930->IL0886: Incompatible stack types: I4 vs O
			//IL_0a7f->IL0886: Incompatible stack types: I4 vs O
			//IL_0a1c->IL0886: Incompatible stack types: I4 vs O
			//IL_09a1->IL0886: Incompatible stack types: I4 vs O
			//IL_0a27->IL0886: Incompatible stack types: I4 vs O
			int num = 3;
			object obj4 = default(object);
			dynamic obj5 = default(object);
			dynamic obj7 = default(object);
			object obj29 = default(object);
			dynamic obj12 = default(object);
			dynamic obj3 = default(object);
			object obj25 = default(object);
			object obj27 = default(object);
			global::System.Runtime.CompilerServices.ValueTaskAwaiter obj9 = default(global::System.Runtime.CompilerServices.ValueTaskAwaiter);
			object obj13 = default(object);
			object obj15 = default(object);
			object obj18 = default(object);
			dynamic result = default(object);
			object obj17 = default(object);
			dynamic obj16 = default(object);
			object obj19 = default(object);
			object obj10 = default(object);
			dynamic obj11 = default(object);
			object obj21 = default(object);
			object obj23 = default(object);
			object obj34 = default(object);
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
							if ((nint)obj == 11)
							{
								obj4 = __4__this;
								obj2 = 4;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_384fbdc0d71943e1a4f9f50f53afad51 == 0)
								{
									obj2 = 2;
								}
								continue;
							}
							goto end_IL_0010;
						case 2:
							try
							{
								object obj6;
								switch ((int)obj5)
								{
								default:
									obj6 = 11;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3054c4fc69b94a37b21ac42c2099175a == 0)
									{
										obj6 = 38;
									}
									goto IL_009b;
								case 0:
									obj7 = __u__1;
									obj6 = 23;
									goto IL_009b;
								case 2:
								case 3:
								case 4:
								case 5:
									goto IL_0336;
								case 1:
									goto IL_038e;
									IL_009b:
									while (true)
									{
										int num4;
										switch ((int)obj6)
										{
										default:
											if ((nint)obj29 != 45)
											{
												if ((nint)obj29 == 1025)
												{
													goto IL_0097;
												}
												goto case 2;
											}
											__u__1 = (ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter)obj7;
											obj6 = 36;
											continue;
										case 10:
											if ((item).SizeBytes > 52428800)
											{
												obj6 = 22;
												continue;
											}
											goto case 4;
										case 20:
											if ((item).SizeBytes <= 0)
											{
												num4 = 19;
												goto IL_0093;
											}
											goto case 10;
										case 37:
											break;
										case 36:
											__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter, _DownloadAsync_d__5>(ref *(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter*)(&obj7), ref this);
											obj6 = 20;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_dbb7d0b4e7ca46959ea177dcc91c1f0e != 0)
											{
												obj6 = 15;
											}
											continue;
										case 35:
											_stem_5__2 = "module";
											obj6 = 16;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7880b59a09bf4a2190c2568d83d12e71 != 0)
											{
												obj6 = 30;
											}
											continue;
										case 28:
											if (!System.IO.File.Exists(_target_5__3))
											{
												obj6 = 4;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_db2c7dd1aabc4c9a97a36e710c0128ab != 0)
												{
													obj6 = 24;
												}
												continue;
											}
											goto case 5;
										case 2:
											if (!((ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter*)(&obj7))->IsCompleted)
											{
												obj6 = 45;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_07c1f539d4f94d95bde09a0fba07dbbc != 0)
												{
													obj6 = 32;
												}
												continue;
											}
											goto case 13;
										case 23:
											__u__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
											obj6 = 14;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ff96c054b9a547fc83bea3daf4a435ff == 0)
											{
												obj6 = 17;
											}
											continue;
										case 21:
											if (string.IsNullOrEmpty(_stem_5__2))
											{
												obj6 = 35;
												continue;
											}
											goto case 16;
										case 14:
											obj5 = -1;
											__1__state = -1;
											obj6 = 13;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3054c4fc69b94a37b21ac42c2099175a == 0)
											{
												obj6 = 21;
											}
											continue;
										case 29:
											obj7 = ((ConfiguredTaskAwaitable<bool>*)(&obj12))->GetAwaiter();
											obj6 = 2;
											continue;
										case 34:
											goto IL_0336;
										case 30:
											__7__wrap4 = null;
											obj6 = 28;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_c3a1ed3f1b10415883902def95e1be62 == 0)
											{
												obj6 = 2;
											}
											continue;
										case 6:
											goto IL_038e;
										case 11:
											if ((item).BlobId <= 0)
											{
												obj6 = 43;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f1dd9923a6bd42d5867c8e2e591d3e3b != 0)
												{
													obj6 = 0;
												}
												continue;
											}
											goto case 20;
										case 32:
											obj5 = 0;
											__1__state = 0;
											num4 = 45;
											goto IL_0093;
										case 33:
											goto end_IL_004d;
										case 31:
											obj3 = 0;
											obj6 = 33;
											continue;
										case 4:
										{
											string text2 = (item).Sha256;
											if (text2 == null)
											{
												obj6 = 8;
												continue;
											}
											if ((text2).Length != 64)
											{
												goto case 8;
											}
											goto case 18;
										}
										case 16:
										{
											string text4 = pendingPath;
											global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler obj31 = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(12, 3);
											(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj31)).AppendLiteral("cloud-");
											((global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj31))->AppendFormatted<long>((item).BlobId);
											(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj31)).AppendLiteral("-");
											(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj31)).AppendFormatted((((item).Sha256).Substring(0, 12)).ToLowerInvariant());
											(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj31)).AppendLiteral("-");
											(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj31)).AppendFormatted(_stem_5__2);
											(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj31)).AppendLiteral(".mcp");
											_target_5__3 = System.IO.Path.Combine(text4, (*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj31)).ToStringAndClear());
											obj6 = 17;
											continue;
										}
										case 13:
											if (((ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter*)(&obj7))->GetResult())
											{
												obj6 = 31;
												continue;
											}
											goto case 27;
										case 3:
										case 24:
										{
											string text = staging;
											global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler obj28 = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(5, 1);
											((global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj28))->AppendFormatted<Guid>(System.Guid.NewGuid(), "N");
											(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj28)).AppendLiteral(".part");
											_temporary_5__4 = System.IO.Path.Combine(text, (*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj28)).ToStringAndClear());
											obj6 = 34;
											continue;
										}
										case 15:
											return;
										case 27:
										{
											string text3 = pendingPath;
											global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler obj30 = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(12, 1);
											(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj30)).AppendLiteral("cloud-");
											((global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj30))->AppendFormatted<long>((item).BlobId);
											(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj30)).AppendLiteral("-*.mcp");
											__7__wrap4 = System.IO.Directory.EnumerateFiles(text3, (*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj30)).ToStringAndClear()).GetEnumerator();
											num4 = 6;
											goto IL_0093;
										}
										case 17:
											obj12 = MatchesAsync(_target_5__3, item, cancellationToken).ConfigureAwait(false);
											obj6 = 29;
											continue;
										case 5:
										{
											string text5 = pendingPath;
											global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler obj32 = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(12, 3);
											(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj32)).AppendLiteral("cloud-");
											((global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj32))->AppendFormatted<long>((item).BlobId);
											(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj32)).AppendLiteral("-");
											((global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj32))->AppendFormatted<Guid>(System.Guid.NewGuid(), "N");
											(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj32)).AppendLiteral("-");
											(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj32)).AppendFormatted(_stem_5__2);
											(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj32)).AppendLiteral(".mcp");
											_target_5__3 = System.IO.Path.Combine(text5, (*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj32)).ToStringAndClear());
											obj6 = 3;
											continue;
										}
										case 25:
											try
											{
												object obj24;
												if ((nint)obj5 != 1)
												{
													obj24 = 8;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4967aebcec78421b855bda2f45c82247 == 0)
													{
														obj24 = 14;
													}
													goto IL_0886;
												}
												goto IL_0a7f;
												IL_0886:
												while (true)
												{
													int num5;
													switch ((int)obj24)
													{
													case 0:
														goto end_IL_0886;
													default:
														if ((nint)obj25 != 22)
														{
															if ((nint)obj25 == 1002)
															{
																goto IL_0882;
															}
															goto case 8;
														}
														obj3 = 0;
														obj24 = 16;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bd754e211a3740b7abeee191b9ceae68 != 0)
														{
															obj24 = 4;
														}
														continue;
													case 11:
														obj5 = -1;
														__1__state = -1;
														obj24 = 10;
														continue;
													case 1:
														return;
													case 4:
														goto end_IL_084d;
													case 8:
														if (!((ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter*)(&obj7))->IsCompleted)
														{
															obj24 = 7;
															continue;
														}
														goto case 10;
													case 5:
														obj12 = MatchesAsync(__7__wrap4.Current, item, cancellationToken).ConfigureAwait(false);
														obj24 = 3;
														continue;
													case 6:
													case 14:
														if (!(__7__wrap4).MoveNext())
														{
															obj24 = 15;
															if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0c88e6c08eaf4e998e8fdd2c544cee2e != 0)
															{
																obj24 = 0;
															}
															continue;
														}
														goto case 5;
													case 3:
														obj7 = ((ConfiguredTaskAwaitable<bool>*)(&obj12))->GetAwaiter();
														num5 = 8;
														goto IL_087e;
													case 9:
														__u__1 = (ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter)obj7;
														obj24 = 13;
														continue;
													case 10:
														if (((ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter*)(&obj7))->GetResult())
														{
															num5 = 22;
															if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0c88e6c08eaf4e998e8fdd2c544cee2e == 0)
															{
																num5 = 18;
															}
															goto IL_087e;
														}
														goto case 6;
													case 7:
														obj5 = 1;
														__1__state = 1;
														obj24 = 9;
														continue;
													case 2:
														__u__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
														obj24 = 4;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_80d00e736d0b4f7dbce583e459774a86 == 0)
														{
															obj24 = 11;
														}
														continue;
													case 13:
														__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter, _DownloadAsync_d__5>(ref *(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter*)(&obj7), ref this);
														obj24 = 1;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7ef2723341c74c2b88836c43256b27b6 == 0)
														{
															obj24 = 12;
														}
														continue;
													case 12:
														break;
														IL_0882:
														obj24 = obj25;
														continue;
														IL_087e:
														obj25 = num5;
														goto IL_0882;
													}
													goto IL_0a7f;
													continue;
													end_IL_0886:
													break;
												}
												goto case 30;
												IL_0a7f:
												obj7 = __u__1;
												obj24 = 2;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_861620835107408fad0813077d9e9967 != 0)
												{
													obj24 = 5;
												}
												goto IL_0886;
												end_IL_084d:;
											}
											finally
											{
												object obj26;
												if ((nint)obj5 >= 0)
												{
													obj26 = 3;
													goto IL_0acf;
												}
												goto IL_0af7;
												IL_0af7:
												if (__7__wrap4 != null)
												{
													obj26 = 5;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_07c1f539d4f94d95bde09a0fba07dbbc != 0)
													{
														obj26 = 1;
													}
													goto IL_0acf;
												}
												goto end_IL_0aab;
												IL_0acf:
												while (true)
												{
													switch ((int)obj26)
													{
													default:
														if ((nint)obj27 == 991)
														{
															obj26 = obj27;
															continue;
														}
														goto case 1;
													case 2:
														break;
													case 3:
														goto end_IL_0acf;
													case 1:
														(__7__wrap4).Dispose();
														obj26 = 0;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4ae4de12ce674c26bc2939a5789df8ab == 0)
														{
															obj26 = 0;
														}
														continue;
													case 0:
														goto end_IL_0acf;
													}
													goto IL_0af7;
													continue;
													end_IL_0acf:
													break;
												}
												end_IL_0aab:;
											}
											goto end_IL_004d;
										case 8:
											obj6 = 9;
											continue;
										case 18:
											if (Enumerable.All<char>((global::System.Collections.Generic.IEnumerable<char>)(item).Sha256, (Func<char, bool>)Uri.IsHexDigit))
											{
												obj6 = 12;
												continue;
											}
											goto case 0;
										case 0:
										case 9:
										case 19:
										case 22:
										case 26:
											throw new InvalidDataException("云端文件信息无效或超过 50 MiB");
										case 12:
											_stem_5__2 = System.IO.Path.GetFileNameWithoutExtension((item).OriginalName ?? string.Empty);
											obj6 = 7;
											continue;
										case 7:
											_stem_5__2 = ((new string(Enumerable.ToArray<char>(Enumerable.Take<char>(Enumerable.Where<char>((global::System.Collections.Generic.IEnumerable<char>)_stem_5__2, (Func<char, bool>)__c_5.__9._DownloadAsync_b__5_0), 70)))).Trim()).TrimEnd('.');
											obj6 = 21;
											continue;
										case 1:
											{
												try
												{
													object obj8;
													switch ((int)obj5 - 2)
													{
													default:
														obj8 = 4;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1282ca3a3b4d42dea9c5c692937e35bc == 0)
														{
															obj8 = 34;
														}
														goto IL_0ce2;
													case 2:
														obj9 = __u__4;
														obj8 = 13;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_a7be2a0b610d44259bd8ade7bca91da3 == 0)
														{
															obj8 = 38;
														}
														goto IL_0ce2;
													case 0:
													case 1:
														goto IL_17bd;
													case 3:
														goto IL_17dd;
														IL_17bd:
														obj8 = 9;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_33eff53ba43c4c10a4788d4370759667 == 0)
														{
															obj8 = 1;
														}
														goto IL_0ce2;
														IL_0ce2:
														while (true)
														{
															int num2;
															switch ((int)obj8)
															{
															default:
																if ((nint)obj13 != 46)
																{
																	if ((nint)obj13 == 1026)
																	{
																		goto IL_0cde;
																	}
																	goto case 4;
																}
																goto case 37;
															case 14:
																obj12 = MatchesAsync(_temporary_5__4, item, cancellationToken).ConfigureAwait(false);
																obj8 = 10;
																continue;
															case 16:
																_output_5__6 = null;
																num2 = 14;
																goto IL_0cda;
															case 35:
																__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter, _DownloadAsync_d__5>(ref *(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter*)(&obj7), ref this);
																obj8 = 34;
																if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ee050290791c4dfbba3a13b8d87cc1bd != 0)
																{
																	obj8 = 29;
																}
																continue;
															case 10:
																obj7 = ((ConfiguredTaskAwaitable<bool>*)(&obj12))->GetAwaiter();
																obj8 = 19;
																continue;
															case 23:
																__7__wrap6 = null;
																obj8 = 38;
																continue;
															case 12:
																if (!((dynamic)obj9).IsCompleted)
																{
																	obj8 = 6;
																	continue;
																}
																goto case 36;
															case 0:
																__u__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
																obj8 = 27;
																continue;
															case 27:
																obj5 = -1;
																__1__state = -1;
																num2 = 46;
																goto IL_0cda;
															case 7:
																obj3 = 1;
																obj8 = 9;
																continue;
															case 3:
																__u__4 = (ValueTaskAwaiter)obj9;
																num2 = 2;
																goto IL_0cda;
															case 1:
																try
																{
																	object obj14;
																	if ((nint)obj5 != 2)
																	{
																		obj14 = 8;
																		goto IL_0ec7;
																	}
																	goto IL_1526;
																	IL_1526:
																	obj15 = __u__2;
																	obj14 = 32;
																	goto IL_0ec7;
																	IL_0ec7:
																	while (true)
																	{
																		int num3;
																		switch ((int)obj14)
																		{
																		default:
																			if ((nint)obj18 != 49)
																			{
																				if ((nint)obj18 == 1029)
																				{
																					goto IL_0ec3;
																				}
																				goto case 3;
																			}
																			obj5 = 2;
																			__1__state = 2;
																			obj14 = 40;
																			continue;
																		case 5:
																			return;
																		case 36:
																			if (((dynamic)result).Offset == _offset_5__9)
																			{
																				obj14 = 38;
																				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4fafd75e484e4b31a74460f9f0d54951 == 0)
																				{
																					obj14 = 43;
																				}
																				continue;
																			}
																			goto case 34;
																		case 22:
																			obj17 = ((McpCloudSyncService)obj4)._download.Invoke((item).BlobId, _offset_5__9, _length_5__10, cancellationToken).ConfigureAwait(false);
																			obj14 = 5;
																			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3a9f60458a5840868f1b224a8d25b071 != 0)
																			{
																				obj14 = 17;
																			}
																			continue;
																		case 13:
																			__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<blITQ5f6ZD0ur9oMSjQ5>.ConfiguredTaskAwaiter, _DownloadAsync_d__5>(ref *(ConfiguredTaskAwaitable<blITQ5f6ZD0ur9oMSjQ5>.ConfiguredTaskAwaiter*)(&obj15), ref this);
																			obj14 = 5;
																			continue;
																		case 12:
																			obj5 = 3;
																			__1__state = 3;
																			num3 = 35;
																			goto IL_0ebf;
																		case 0:
																			if (string.Equals(System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(_bytes_5__11)), ((dynamic)result).Sha256, (StringComparison)5))
																			{
																				obj14 = 33;
																				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e041d974da614bb9aad5f28559bec3d0 != 0)
																				{
																					obj14 = 2;
																				}
																				continue;
																			}
																			goto case 23;
																		case 25:
																			if (result != null)
																			{
																				obj14 = 20;
																				continue;
																			}
																			goto case 34;
																		case 9:
																			_length_5__10 = (int)System.Math.Min(524288L, (item).SizeBytes - _offset_5__9);
																			obj14 = 22;
																			continue;
																		case 27:
																			return;
																		case 38:
																			if (((dynamic)result).TotalBytes != (item).SizeBytes)
																			{
																				obj14 = 34;
																				continue;
																			}
																			if (((dynamic)result).Data != null)
																			{
																				obj14 = 30;
																				continue;
																			}
																			goto case 31;
																		case 7:
																			__t__builder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, _DownloadAsync_d__5>(ref *(ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter*)(&obj16), ref this);
																			obj14 = 27;
																			continue;
																		case 8:
																			if ((nint)obj5 != 3)
																			{
																				obj14 = 21;
																				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_70c2a79cb96d4e75a079385f00e7bf58 != 0)
																				{
																					obj14 = 49;
																				}
																				continue;
																			}
																			goto case 29;
																		case 32:
																			__u__2 = default(ConfiguredTaskAwaitable<blITQ5f6ZD0ur9oMSjQ5>.ConfiguredTaskAwaiter);
																			obj14 = 19;
																			continue;
																		case 31:
																			throw new InvalidDataException("下载分块大小无效");
																		case 10:
																			_bytes_5__11 = System.Convert.FromBase64String((((dynamic)result).Data));
																			obj14 = 37;
																			continue;
																		case 26:
																			obj19 = (*(global::System.Threading.Tasks.ValueTask*)(&obj10)).ConfigureAwait(false);
																			num3 = 3;
																			goto IL_0ebf;
																		case 34:
																			throw new InvalidDataException("下载分块的文件标识、位置或大小不一致");
																		case 20:
																			if (((dynamic)result).BlobId == (item).BlobId)
																			{
																				obj14 = 36;
																				continue;
																			}
																			goto case 34;
																		case 11:
																			obj5 = -1;
																			__1__state = -1;
																			obj14 = 24;
																			continue;
																		case 37:
																			if (_bytes_5__11.Length == _length_5__10)
																			{
																				obj14 = 0;
																				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_efa7845a846a43508e861e510ac5e1d2 != 0)
																				{
																					obj14 = 16;
																				}
																				continue;
																			}
																			goto case 23;
																		case 29:
																			obj16 = __u__3;
																			obj14 = 1;
																			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5e5cf2db569941efa91d919db7fefba0 == 0)
																			{
																				obj14 = 30;
																			}
																			continue;
																		case 21:
																			_offset_5__9 = 0L;
																			obj14 = 16;
																			continue;
																		case 19:
																			obj5 = -1;
																			__1__state = -1;
																			obj14 = 41;
																			continue;
																		case 28:
																			_offset_5__9 += _bytes_5__11.Length;
																			obj14 = 4;
																			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f102566966284916b14bc7efa63c0f5e == 0)
																			{
																				obj14 = 37;
																			}
																			continue;
																		case 1:
																			__u__3 = default(object);
																			obj14 = 11;
																			continue;
																		case 30:
																			if ((((dynamic)result).Data).Length <= (_length_5__10 + 2) / 3 * 4)
																			{
																				obj14 = 10;
																				continue;
																			}
																			goto case 31;
																		case 6:
																			(cancellationToken).ThrowIfCancellationRequested();
																			obj14 = 43;
																			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_28a8309f77124973ab9263f59df1f564 != 0)
																			{
																				obj14 = 9;
																			}
																			continue;
																		case 24:
																			((dynamic)obj16).GetResult();
																			obj14 = 28;
																			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b28f7b3c5e414da9823acaf82070b1eb != 0)
																			{
																				obj14 = 32;
																			}
																			continue;
																		case 35:
																			__u__3 = (object)obj16;
																			obj14 = 7;
																			continue;
																		case 17:
																			obj15 = ((ConfiguredTaskAwaitable<blITQ5f6ZD0ur9oMSjQ5>*)(&obj17))->GetAwaiter();
																			obj14 = 15;
																			continue;
																		case 40:
																			__u__2 = (ConfiguredTaskAwaitable<blITQ5f6ZD0ur9oMSjQ5>.ConfiguredTaskAwaiter)obj15;
																			obj14 = 13;
																			continue;
																		case 23:
																			throw new InvalidDataException("下载分块 SHA-256 校验失败");
																		case 33:
																			obj10 = (_output_5__6).WriteAsync(new ReadOnlyMemory<byte>(_bytes_5__11), cancellationToken);
																			obj14 = 26;
																			continue;
																		case 4:
																			_bytes_5__11 = null;
																			obj14 = 39;
																			continue;
																		case 15:
																			if (!((ConfiguredTaskAwaitable<blITQ5f6ZD0ur9oMSjQ5>.ConfiguredTaskAwaiter*)(&obj15))->IsCompleted)
																			{
																				num3 = 49;
																				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7965c0cf8c924e228a4010c08420db19 != 0)
																				{
																					num3 = 49;
																				}
																				goto IL_0ebf;
																			}
																			goto case 41;
																		case 3:
																			obj16 = ((global::System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable)obj19).GetAwaiter();
																			obj14 = 14;
																			continue;
																		case 41:
																			result = ((ConfiguredTaskAwaitable<blITQ5f6ZD0ur9oMSjQ5>.ConfiguredTaskAwaiter*)(&obj15))->GetResult();
																			obj14 = 25;
																			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1580feae44ff487ab78d80df31c471c0 == 0)
																			{
																				obj14 = 27;
																			}
																			continue;
																		case 2:
																			break;
																		case 14:
																			if (!((dynamic)obj16).IsCompleted)
																			{
																				obj14 = 12;
																				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1df8e086d5ed471cbc378d2545a921c6 != 0)
																				{
																					obj14 = 14;
																				}
																				continue;
																			}
																			goto case 24;
																		case 16:
																		case 39:
																			if (_offset_5__9 >= (item).SizeBytes)
																			{
																				obj14 = 18;
																				continue;
																			}
																			goto case 6;
																		case 18:
																			goto end_IL_0ec7;
																			IL_0ec3:
																			obj14 = obj18;
																			continue;
																			IL_0ebf:
																			obj18 = num3;
																			goto IL_0ec3;
																		}
																		goto IL_1526;
																		continue;
																		end_IL_0ec7:
																		break;
																	}
																}
																catch (global::System.Exception ex)
																{
																	obj11 = ex;
																	object obj20 = 1;
																	if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_28a8309f77124973ab9263f59df1f564 == 0)
																	{
																		obj20 = 5;
																	}
																	while (true)
																	{
																		switch ((int)obj20)
																		{
																		default:
																			if ((nint)obj21 == 989)
																			{
																				obj20 = obj21;
																				continue;
																			}
																			break;
																		case 1:
																			break;
																		case 0:
																			goto end_IL_15c5;
																		}
																		__7__wrap6 = obj11;
																		obj20 = 3;
																		if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3416b7a32c7341febcabc34f89028832 != 0)
																		{
																			obj20 = 0;
																		}
																		continue;
																		end_IL_15c5:
																		break;
																	}
																}
																goto case 32;
															case 19:
																if (((ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter*)(&obj7))->IsCompleted)
																{
																	obj8 = 37;
																	continue;
																}
																goto case 21;
															case 26:
																break;
															case 5:
																throw new InvalidDataException("MCP 文件 SHA-256 校验失败");
															case 20:
																(cancellationToken).ThrowIfCancellationRequested();
																obj8 = 42;
																if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f47742ba549d4a57a8283970712d2604 == 0)
																{
																	obj8 = 29;
																}
																continue;
															case 30:
																return;
															case 34:
																return;
															case 22:
																if (obj11 == null)
																{
																	obj8 = 15;
																	continue;
																}
																goto IL_1924;
															case 13:
																__u__4 = default(ValueTaskAwaiter);
																obj8 = 24;
																continue;
															case 4:
																_output_5__6 = new FileStream(_temporary_5__4, (FileMode)1, (FileAccess)2, (FileShare)0, 524288, true);
																num2 = 23;
																goto IL_0cda;
															case 38:
																__7__wrap7 = 0;
																obj8 = 8;
																continue;
															case 37:
																if (((ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter*)(&obj7))->GetResult())
																{
																	obj8 = 20;
																	continue;
																}
																goto case 5;
															case 33:
																obj11 = __7__wrap6;
																obj8 = 22;
																continue;
															case 36:
																((dynamic)obj9).GetResult();
																obj8 = 17;
																if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_86f85a596c344fa79bc760622a9efe43 == 0)
																{
																	obj8 = 33;
																}
																continue;
															case 8:
																goto IL_17bd;
															case 17:
																goto IL_17dd;
															case 32:
																if (_output_5__6 != null)
																{
																	obj8 = 44;
																	if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b6e1b24306c5435497967d798ce571fb != 0)
																	{
																		obj8 = 28;
																	}
																	continue;
																}
																goto case 33;
															case 2:
																__t__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, _DownloadAsync_d__5>(ref obj9, ref this);
																obj8 = 30;
																continue;
															case 25:
																__u__1 = (ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter)obj7;
																obj8 = 35;
																continue;
															case 29:
																System.IO.File.Move(_temporary_5__4, _target_5__3, false);
																obj8 = 7;
																if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_6d6b99fc4578413f8bc3bdf9db0e7260 == 0)
																{
																	obj8 = 28;
																}
																continue;
															case 28:
																obj10 = (_output_5__6).DisposeAsync();
																obj8 = 11;
																continue;
															case 15:
															case 18:
																__7__wrap6 = null;
																obj8 = 16;
																continue;
															case 11:
																obj9 = (*(global::System.Threading.Tasks.ValueTask*)(&obj10)).GetAwaiter();
																obj8 = 12;
																if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7965c0cf8c924e228a4010c08420db19 != 0)
																{
																	obj8 = 8;
																}
																continue;
															case 21:
																obj5 = 5;
																__1__state = 5;
																obj8 = 25;
																continue;
															case 6:
																obj5 = 4;
																__1__state = 4;
																obj8 = 3;
																continue;
															case 24:
																obj5 = -1;
																__1__state = -1;
																obj8 = 36;
																continue;
															case 31:
																goto IL_1924;
															case 9:
																goto end_IL_0c9c;
																IL_0cda:
																obj13 = num2;
																goto IL_0cde;
																IL_0cde:
																obj8 = obj13;
																continue;
															}
															break;
															IL_1924:
															(System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture((obj11 as global::System.Exception) ?? throw obj11)).Throw();
															obj8 = 18;
														}
														goto case 2;
														IL_17dd:
														obj7 = __u__1;
														obj8 = 35;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_24238b39bba94b6aa4d3c2739f061133 == 0)
														{
															obj8 = 0;
														}
														goto IL_0ce2;
														end_IL_0c9c:
														break;
													}
												}
												finally
												{
													object obj22;
													if ((nint)obj5 >= 0)
													{
														obj22 = 4;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_06501b7bae1743aa8336fe70312492d7 != 0)
														{
															obj22 = 1;
														}
														goto IL_1990;
													}
													goto IL_19dc;
													IL_1990:
													while (true)
													{
														switch ((int)obj22)
														{
														default:
															if ((nint)obj23 == 991)
															{
																obj22 = obj23;
																continue;
															}
															goto case 2;
														case 1:
															goto end_IL_1990;
														case 0:
															break;
														case 2:
															System.IO.File.Delete(_temporary_5__4);
															obj22 = 3;
															continue;
														case 3:
															goto end_IL_1990;
														}
														goto IL_19dc;
														continue;
														end_IL_1990:
														break;
													}
													goto end_IL_1957;
													IL_19dc:
													if (System.IO.File.Exists(_temporary_5__4))
													{
														obj22 = 2;
														goto IL_1990;
													}
													end_IL_1957:;
												}
												goto end_IL_004d;
											}
											IL_0097:
											obj6 = obj29;
											continue;
											IL_0093:
											obj29 = num4;
											goto IL_0097;
										}
										break;
									}
									goto case 0;
									IL_038e:
									obj6 = 25;
									goto IL_009b;
									IL_0336:
									obj6 = 1;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5144ebdc507c41fb87d88fdce3dc76e9 == 0)
									{
										obj6 = 13;
									}
									goto IL_009b;
									end_IL_004d:
									break;
								}
							}
							catch (global::System.Exception exception)
							{
								object obj33 = 2;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bd86dbd500ab43b1bb4264e56ddd52b4 == 0)
								{
									obj33 = 0;
								}
								while (true)
								{
									switch ((int)obj33)
									{
									default:
										if ((nint)obj34 == 990)
										{
											obj33 = obj34;
											break;
										}
										return;
									case 2:
										__t__builder.SetException(exception);
										obj33 = 1;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_86f85a596c344fa79bc760622a9efe43 == 0)
										{
											obj33 = 1;
										}
										break;
									case 0:
										__1__state = -2;
										obj33 = 2;
										break;
									case 1:
										return;
									}
								}
							}
							goto case 1;
						case 1:
							__1__state = -2;
							obj2 = 7;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_efa7845a846a43508e861e510ac5e1d2 == 0)
							{
								obj2 = 4;
							}
							continue;
						case 3:
							break;
						case 4:
							__t__builder.SetResult((byte)(int)obj3 != 0);
							obj2 = 0;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b28f7b3c5e414da9823acaf82070b1eb != 0)
							{
								obj2 = 0;
							}
							continue;
						case 0:
							return;
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
				while ((nint)obj == 992);
				obj5 = __1__state;
				num = 11;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_0050->IL0010: Incompatible stack types: I4 vs O
			//IL_005b->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
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
					if ((nint)obj == 989)
					{
						break;
					}
					goto IL_0030;
					IL_0030:
					__t__builder.SetStateMachine(stateMachine);
					obj2 = 1;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_84adde53dc7e4a5fa7522d701cb0013d == 0)
					{
						obj2 = 0;
					}
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool Nk79TQLEG00bwLMb3sXG()
		{
			return HsEvmNLEqX41bFU70PDo == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object xEuYrBLEi8Nb3U2J3O2A()
		{
			return HsEvmNLEqX41bFU70PDo;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _MatchesAsync_d__6 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<bool> __t__builder;

		public string path;

		public JEDl1cf6VmwwyP6UuZ5V item;

		public CancellationToken cancellationToken;

		private FileStream _input_5__2;

		private object __7__wrap2;

		private int __7__wrap3;

		private bool __7__wrap4;

		private ConfiguredValueTaskAwaitable<byte[]> __u__1;

		private ValueTaskAwaiter __u__2;

		internal static object nCpD0qLEnA4rhL2vMmBf;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_000c: Expected O, but got I4
			//IL_0025: Expected I4, but got O
			//IL_0612: Expected I4, but got O
			//IL_083f: Expected I4, but got O
			//IL_08bc: Expected O, but got I4
			//IL_0093: Expected O, but got I4
			//IL_0053: Expected I4, but got O
			//IL_0124: Expected I4, but got O
			//IL_06f0: Expected O, but got I4
			//IL_02f2: Expected O, but got I4
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_0241: Expected O, but got Unknown
			//IL_0771: Unknown result type (might be due to invalid IL or missing references)
			//IL_0686: Unknown result type (might be due to invalid IL or missing references)
			//IL_068d: Expected O, but got Unknown
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Expected O, but got Unknown
			//IL_02a8: Expected O, but got I4
			//IL_0353: Unknown result type (might be due to invalid IL or missing references)
			//IL_0302: Unknown result type (might be due to invalid IL or missing references)
			//IL_0311: Expected O, but got Unknown
			//IL_02e0: Expected O, but got I4
			//IL_0268: Expected O, but got I4
			//IL_0479: Unknown result type (might be due to invalid IL or missing references)
			//IL_0397: Expected O, but got I4
			//IL_056f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0576: Expected O, but got Unknown
			//IL_0510: Unknown result type (might be due to invalid IL or missing references)
			//IL_0517: Expected O, but got Unknown
			//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f2: Expected O, but got Unknown
			//IL_04c4: Expected O, but got I4
			//IL_05be: Expected O, but got I4
			//IL_055e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0527: Unknown result type (might be due to invalid IL or missing references)
			//IL_03dc: Expected I4, but got O
			//IL_05e8->IL0605: Incompatible stack types: I4 vs O
			//IL_081c->IL082e: Incompatible stack types: I4 vs O
			//IL_05f3->IL0605: Incompatible stack types: I4 vs O
			//IL_0641->IL0605: Incompatible stack types: I4 vs O
			//IL_0873->IL082e: Incompatible stack types: I4 vs O
			//IL_089a->IL082e: Incompatible stack types: I4 vs O
			//IL_064c->IL0605: Incompatible stack types: I4 vs O
			//IL_087e->IL082e: Incompatible stack types: I4 vs O
			//IL_08a5->IL082e: Incompatible stack types: I4 vs O
			//IL_08d0->IL0010: Incompatible stack types: I4 vs O
			//IL_08db->IL0010: Incompatible stack types: I4 vs O
			//IL_0067->IL0010: Incompatible stack types: I4 vs O
			//IL_0735->IL0097: Incompatible stack types: I4 vs O
			//IL_0085->IL0097: Incompatible stack types: I4 vs O
			//IL_0072->IL0010: Incompatible stack types: I4 vs O
			//IL_0740->IL0097: Incompatible stack types: I4 vs O
			//IL_0350->IL0097: Incompatible stack types: I4 vs O
			//IL_018b->IL0097: Incompatible stack types: I4 vs O
			//IL_06fa->IL0097: Incompatible stack types: I4 vs O
			//IL_02fc->IL0097: Incompatible stack types: I4 vs O
			//IL_0255->IL0097: Incompatible stack types: I4 vs O
			//IL_01d2->IL0097: Incompatible stack types: I4 vs O
			//IL_02a3->IL0097: Incompatible stack types: I4 vs O
			//IL_078b->IL0097: Incompatible stack types: I4 vs O
			//IL_0715->IL0097: Incompatible stack types: I4 vs O
			//IL_0697->IL0097: Incompatible stack types: I4 vs O
			//IL_0157->IL0097: Incompatible stack types: I4 vs O
			//IL_02c1->IL0097: Incompatible stack types: I4 vs O
			//IL_036c->IL0097: Incompatible stack types: I4 vs O
			//IL_02ef->IL0097: Incompatible stack types: I4 vs O
			//IL_06ba->IL0097: Incompatible stack types: I4 vs O
			//IL_0760->IL0097: Incompatible stack types: I4 vs O
			//IL_027c->IL0097: Incompatible stack types: I4 vs O
			//IL_0196->IL0097: Incompatible stack types: I4 vs O
			//IL_07bb->IL0097: Incompatible stack types: I4 vs O
			//IL_0260->IL0097: Incompatible stack types: I4 vs O
			//IL_01dd->IL0097: Incompatible stack types: I4 vs O
			//IL_0169->IL0097: Incompatible stack types: I4 vs O
			//IL_06a9->IL0097: Incompatible stack types: I4 vs O
			//IL_0796->IL0097: Incompatible stack types: I4 vs O
			//IL_0720->IL0097: Incompatible stack types: I4 vs O
			//IL_06e8->IL0097: Incompatible stack types: I4 vs O
			//IL_02cc->IL0097: Incompatible stack types: I4 vs O
			//IL_0377->IL0097: Incompatible stack types: I4 vs O
			//IL_0330->IL0097: Incompatible stack types: I4 vs O
			//IL_076b->IL0097: Incompatible stack types: I4 vs O
			//IL_0287->IL0097: Incompatible stack types: I4 vs O
			//IL_0494->IL039b: Incompatible stack types: I4 vs O
			//IL_07c6->IL0097: Incompatible stack types: I4 vs O
			//IL_0803->IL0097: Incompatible stack types: I4 vs O
			//IL_0207->IL0097: Incompatible stack types: I4 vs O
			//IL_080e->IL0097: Incompatible stack types: I4 vs O
			//IL_0212->IL0097: Incompatible stack types: I4 vs O
			//IL_058a->IL039b: Incompatible stack types: I4 vs O
			//IL_04fc->IL039b: Incompatible stack types: I4 vs O
			//IL_0472->IL039b: Incompatible stack types: I4 vs O
			//IL_04dd->IL039b: Incompatible stack types: I4 vs O
			//IL_056d->IL039b: Incompatible stack types: I4 vs O
			//IL_0541->IL039b: Incompatible stack types: I4 vs O
			//IL_050f->IL039b: Incompatible stack types: I4 vs O
			//IL_0418->IL039b: Incompatible stack types: I4 vs O
			//IL_0595->IL039b: Incompatible stack types: I4 vs O
			//IL_04e8->IL039b: Incompatible stack types: I4 vs O
			//IL_04b4->IL039b: Incompatible stack types: I4 vs O
			//IL_054c->IL039b: Incompatible stack types: I4 vs O
			//IL_0423->IL039b: Incompatible stack types: I4 vs O
			//IL_04bf->IL039b: Incompatible stack types: I4 vs O
			int num = 1;
			object obj8 = default(object);
			dynamic obj3 = default(object);
			object obj6 = default(object);
			dynamic obj7 = default(object);
			global::System.Runtime.CompilerServices.ValueTaskAwaiter obj5 = default(global::System.Runtime.CompilerServices.ValueTaskAwaiter);
			object obj17 = default(object);
			dynamic obj9 = default(object);
			object obj10 = default(object);
			object obj11 = default(object);
			dynamic result = default(object);
			object obj13 = default(object);
			object obj14 = default(object);
			dynamic obj16 = default(object);
			object obj19 = default(object);
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
							if ((nint)obj == 10)
							{
								__t__builder.SetResult((byte)(int)obj8 != 0);
								obj2 = 2;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7ef2723341c74c2b88836c43256b27b6 == 0)
								{
									obj2 = 4;
								}
								continue;
							}
							goto IL_0033;
						case 2:
							return;
						case 0:
							try
							{
								object obj4;
								if (obj3 != null)
								{
									obj4 = 13;
									goto IL_0097;
								}
								goto IL_0720;
								IL_0720:
								obj4 = 4;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e3c72d365c184d8193f0594ab3fd4d1f == 0)
								{
									obj4 = 0;
								}
								goto IL_0097;
								IL_0097:
								while (true)
								{
									int num2;
									switch ((int)obj4)
									{
									case 32:
										return;
									default:
										if ((nint)obj6 != 41)
										{
											if ((nint)obj6 == 1021)
											{
												goto IL_0093;
											}
											goto case 10;
										}
										if (obj7 == null)
										{
											obj4 = 25;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b6e1b24306c5435497967d798ce571fb == 0)
											{
												obj4 = 25;
											}
											continue;
										}
										goto case 23;
									case 18:
										obj5 = __u__2;
										obj4 = 15;
										continue;
									case 12:
										if ((nint)obj17 == 1)
										{
											obj4 = 4;
											continue;
										}
										goto case 29;
									case 2:
										__t__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, _MatchesAsync_d__6>(ref obj5, ref this);
										obj4 = 32;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_d2995c01469b4ef28b5784f7cbf606e2 == 0)
										{
											obj4 = 40;
										}
										continue;
									case 6:
										obj7 = __7__wrap2;
										num2 = 41;
										goto IL_008f;
									case 9:
										_input_5__2 = null;
										obj4 = 14;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_06766e6d2ea0449aad87692ee68d5840 == 0)
										{
											obj4 = 28;
										}
										continue;
									case 33:
										if (_input_5__2 != null)
										{
											num2 = 14;
											goto IL_008f;
										}
										goto case 6;
									case 8:
										_input_5__2 = new FileStream(path, (FileMode)3, (FileAccess)1, (FileShare)1, 524288, true);
										obj4 = 36;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_24238b39bba94b6aa4d3c2739f061133 == 0)
										{
											obj4 = 1;
										}
										continue;
									case 25:
									case 31:
										obj17 = __7__wrap3;
										obj4 = 12;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1df8e086d5ed471cbc378d2545a921c6 != 0)
										{
											obj4 = 25;
										}
										continue;
									case 14:
										obj9 = (_input_5__2).DisposeAsync();
										obj4 = 17;
										continue;
									case 20:
										obj3 = -1;
										__1__state = -1;
										obj4 = 30;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_6d6b99fc4578413f8bc3bdf9db0e7260 == 0)
										{
											obj4 = 14;
										}
										continue;
									case 26:
										goto end_IL_0097;
									case 27:
										obj3 = 1;
										__1__state = 1;
										obj4 = 22;
										continue;
									case 7:
									case 11:
										obj8 = 0;
										obj4 = 26;
										continue;
									case 24:
										if (new FileInfo(path).Length != (item).SizeBytes)
										{
											obj4 = 7;
											continue;
										}
										goto case 8;
									case 21:
										goto end_IL_0097;
									case 1:
										__7__wrap2 = null;
										obj4 = 16;
										continue;
									case 22:
										__u__2 = (ValueTaskAwaiter)obj5;
										obj4 = 2;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f47742ba549d4a57a8283970712d2604 != 0)
										{
											obj4 = 1;
										}
										continue;
									case 0:
										try
										{
											int num3;
											if (obj3 == null)
											{
												num3 = 2;
												goto IL_0393;
											}
											goto IL_0472;
											IL_050f:
											obj10 = __u__1;
											num3 = 12;
											goto IL_0393;
											IL_0393:
											obj11 = num3;
											goto IL_0397;
											IL_0397:
											dynamic obj12 = obj11;
											goto IL_039b;
											IL_039b:
											while (true)
											{
												switch ((int)obj12)
												{
												default:
													if ((nint)obj11 == 22)
													{
														return;
													}
													if ((nint)obj11 == 1002)
													{
														goto IL_0397;
													}
													goto case 11;
												case 14:
													__7__wrap3 = 1;
													obj12 = 2;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3416b7a32c7341febcabc34f89028832 != 0)
													{
														obj12 = 0;
													}
													continue;
												case 5:
													break;
												case 7:
													__7__wrap4 = string.Equals(System.Convert.ToHexString((byte[])result), (item).Sha256, (StringComparison)5);
													obj12 = 14;
													continue;
												case 1:
													goto IL_0472;
												case 11:
													if (!((ConfiguredValueTaskAwaitable<byte[]>.ConfiguredValueTaskAwaiter*)(&obj10))->IsCompleted)
													{
														obj12 = 9;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_84adde53dc7e4a5fa7522d701cb0013d != 0)
														{
															obj12 = 1;
														}
														continue;
													}
													goto case 13;
												case 8:
													obj3 = -1;
													__1__state = -1;
													obj12 = 11;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7965c0cf8c924e228a4010c08420db19 == 0)
													{
														obj12 = 13;
													}
													continue;
												case 6:
													obj13 = ((global::System.Threading.Tasks.ValueTask<byte[]>*)(&obj14))->ConfigureAwait(false);
													obj12 = 3;
													continue;
												case 13:
													result = ((ConfiguredValueTaskAwaitable<byte[]>.ConfiguredValueTaskAwaiter*)(&obj10))->GetResult();
													obj12 = 7;
													continue;
												case 2:
												case 4:
													goto IL_050f;
												case 12:
													__u__1 = default(ConfiguredValueTaskAwaitable<byte[]>);
													obj12 = 8;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_56220e0912894bf29c75280f6503f965 == 0)
													{
														obj12 = 2;
													}
													continue;
												case 10:
													__u__1 = (ConfiguredValueTaskAwaitable<byte[]>)obj10;
													obj12 = 5;
													continue;
												case 3:
													obj10 = ((ConfiguredValueTaskAwaitable<byte[]>*)(&obj13))->GetAwaiter();
													obj12 = 14;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_09be964badeb4066912116bbb7cb20e9 != 0)
													{
														obj12 = 11;
													}
													continue;
												case 9:
													goto IL_05b9;
												case 0:
													goto end_IL_0378;
												}
												break;
											}
											__t__builder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable<byte[]>.ConfiguredValueTaskAwaiter, _MatchesAsync_d__6>(ref *(ConfiguredValueTaskAwaitable<byte[]>.ConfiguredValueTaskAwaiter*)(&obj10), ref this);
											num3 = 22;
											goto IL_0393;
											IL_0472:
											obj14 = System.Security.Cryptography.SHA256.HashDataAsync((Stream)(object)_input_5__2, cancellationToken);
											obj12 = 6;
											goto IL_039b;
											IL_05b9:
											obj3 = 0;
											__1__state = 0;
											num3 = 10;
											goto IL_0393;
											end_IL_0378:;
										}
										catch (global::System.Exception ex)
										{
											obj7 = ex;
											object obj15 = 7;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_499faaea7a6445f1af0f623e48ebbb18 != 0)
											{
												obj15 = 1;
											}
											while (true)
											{
												switch ((int)obj15)
												{
												default:
													if ((nint)obj16 == 989)
													{
														obj15 = obj16;
														continue;
													}
													break;
												case 1:
													break;
												case 0:
													goto end_IL_0605;
												}
												__7__wrap2 = obj7;
												obj15 = 7;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2ee4c54a6c424cb680cd9d0811cd1011 != 0)
												{
													obj15 = 0;
												}
												continue;
												end_IL_0605:
												break;
											}
										}
										goto case 33;
									case 17:
										obj5 = (*(global::System.Threading.Tasks.ValueTask*)(&obj9)).GetAwaiter();
										obj4 = 5;
										continue;
									case 13:
										if ((nint)obj3 != 1)
										{
											obj4 = 19;
											continue;
										}
										goto case 18;
									case 29:
										__7__wrap2 = null;
										obj4 = 9;
										continue;
									case 19:
										if (!System.IO.File.Exists(path))
										{
											obj4 = 11;
											continue;
										}
										goto case 24;
									case 4:
										obj8 = __7__wrap4;
										obj4 = 21;
										continue;
									case 16:
										__7__wrap3 = 0;
										obj4 = 3;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b45a6b8459fb4961b1724a2890d79f3a == 0)
										{
											obj4 = 31;
										}
										continue;
									case 3:
										break;
									case 10:
									case 30:
										((dynamic)obj5).GetResult();
										obj4 = 24;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9925520c809e49e19c0340f5f2a4c15c != 0)
										{
											obj4 = 6;
										}
										continue;
									case 15:
										__u__2 = default(ValueTaskAwaiter);
										obj4 = 18;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_496d0f7c1bde4581a78d6bb0fcab5473 != 0)
										{
											obj4 = 20;
										}
										continue;
									case 5:
										if (((dynamic)obj5).IsCompleted)
										{
											obj4 = 10;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7880b59a09bf4a2190c2568d83d12e71 != 0)
											{
												obj4 = 25;
											}
											continue;
										}
										goto case 27;
									case 23:
										(System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture((obj7 as global::System.Exception) ?? throw obj7)).Throw();
										obj4 = 31;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b84585b58c384b95b0e0b94c466ccc55 == 0)
										{
											obj4 = 5;
										}
										continue;
									case 28:
										{
											throw null;
										}
										IL_0093:
										obj4 = obj6;
										continue;
										IL_008f:
										obj6 = num2;
										goto IL_0093;
									}
									goto IL_0720;
									continue;
									end_IL_0097:
									break;
								}
							}
							catch (global::System.Exception exception)
							{
								object obj18 = 2;
								while (true)
								{
									switch ((int)obj18)
									{
									case 1:
										return;
									default:
										if ((nint)obj19 != 990)
										{
											return;
										}
										obj18 = obj19;
										break;
									case 0:
										__t__builder.SetException(exception);
										obj18 = 1;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_28a8309f77124973ab9263f59df1f564 == 0)
										{
											obj18 = 2;
										}
										break;
									case 2:
										__1__state = -2;
										obj18 = 8;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_d9c10084bf5f4a9f947702ad63bef067 == 0)
										{
											obj18 = 0;
										}
										break;
									}
								}
							}
							goto end_IL_000c;
						case 1:
							break;
						case 3:
							goto end_IL_000c;
						}
						goto IL_08b4;
						IL_0033:
						if ((nint)obj == 991)
						{
							break;
						}
						goto IL_08b4;
						IL_08b4:
						obj3 = __1__state;
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1df8e086d5ed471cbc378d2545a921c6 != 0)
						{
							obj2 = 3;
						}
					}
					continue;
					end_IL_000c:
					break;
				}
				__1__state = -2;
				num = 10;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_0051->IL0010: Incompatible stack types: I4 vs O
			//IL_005c->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
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
					if ((nint)obj == 989)
					{
						break;
					}
					goto IL_0031;
					IL_0031:
					__t__builder.SetStateMachine(stateMachine);
					obj2 = 2;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7880b59a09bf4a2190c2568d83d12e71 == 0)
					{
						obj2 = 0;
					}
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool tULD7LLEzuUml7k58F8j()
		{
			return nCpD0qLEnA4rhL2vMmBf == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object BRJxm2L2bSNgMPjq2UZn()
		{
			return nCpD0qLEnA4rhL2vMmBf;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _SyncAsync_d__4 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<SyncResult> __t__builder;

		public string pendingPath;

		public global::System.Collections.Generic.IEnumerable<JEDl1cf6VmwwyP6UuZ5V> items;

		public CancellationToken cancellationToken;

		public IProgress<string> progress;

		public McpCloudSyncService __4__this;

		private SyncResult _result_5__2;

		private string _staging_5__3;

		private global::System.Collections.Generic.IEnumerator<JEDl1cf6VmwwyP6UuZ5V> __7__wrap3;

		private JEDl1cf6VmwwyP6UuZ5V _item_5__5;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1;

		internal static object IyVtg0L2X5twkM5HDsaS;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_000c: Expected O, but got I4
			//IL_0900: Expected O, but got I4
			//IL_0031: Expected I4, but got O
			//IL_05e7: Expected I4, but got O
			//IL_0640: Expected I4, but got O
			//IL_0092: Expected O, but got I4
			//IL_07a3: Expected I4, but got O
			//IL_0919: Expected I4, but got O
			//IL_01fd: Expected O, but got I4
			//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e9: Expected O, but got Unknown
			//IL_0310: Expected O, but got I4
			//IL_0226: Expected I4, but got O
			//IL_044d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Expected O, but got I4
			//IL_038b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0391: Expected I4, but got Unknown
			//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d8: Expected O, but got Unknown
			//IL_04bc: Expected O, but got I4
			//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c5: Expected I4, but got Unknown
			//IL_040d: Expected O, but got I4
			//IL_04fc: Expected O, but got I4
			//IL_0533: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Expected O, but got I4
			//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c2: Expected O, but got Unknown
			//IL_0359: Expected I4, but got O
			//IL_00e9: Expected I4, but got O
			//IL_05c1->IL05de: Incompatible stack types: I4 vs O
			//IL_0612->IL062f: Incompatible stack types: I4 vs O
			//IL_08f2->IL0904: Incompatible stack types: I4 vs O
			//IL_05cc->IL05de: Incompatible stack types: I4 vs O
			//IL_061d->IL062f: Incompatible stack types: I4 vs O
			//IL_077c->IL078e: Incompatible stack types: I4 vs O
			//IL_06c6->IL062f: Incompatible stack types: I4 vs O
			//IL_073c->IL062f: Incompatible stack types: I4 vs O
			//IL_07ef->IL078e: Incompatible stack types: I4 vs O
			//IL_09a7->IL0904: Incompatible stack types: I4 vs O
			//IL_095b->IL0904: Incompatible stack types: I4 vs O
			//IL_06d1->IL062f: Incompatible stack types: I4 vs O
			//IL_0747->IL062f: Incompatible stack types: I4 vs O
			//IL_0258->IL0201: Incompatible stack types: I4 vs O
			//IL_0813->IL078e: Incompatible stack types: I4 vs O
			//IL_09b2->IL0904: Incompatible stack types: I4 vs O
			//IL_0966->IL0904: Incompatible stack types: I4 vs O
			//IL_0981->IL0904: Incompatible stack types: I4 vs O
			//IL_081e->IL078e: Incompatible stack types: I4 vs O
			//IL_098c->IL0904: Incompatible stack types: I4 vs O
			//IL_008a->IL0010: Incompatible stack types: I4 vs O
			//IL_09fa->IL0010: Incompatible stack types: I4 vs O
			//IL_009c->IL0010: Incompatible stack types: I4 vs O
			//IL_0a42->IL0010: Incompatible stack types: I4 vs O
			//IL_02e5->IL0201: Incompatible stack types: I4 vs O
			//IL_0a4d->IL0010: Incompatible stack types: I4 vs O
			//IL_006d->IL0010: Incompatible stack types: I4 vs O
			//IL_01c0->IL00c0: Incompatible stack types: I4 vs O
			//IL_0291->IL0201: Incompatible stack types: I4 vs O
			//IL_02f0->IL0201: Incompatible stack types: I4 vs O
			//IL_02b5->IL0201: Incompatible stack types: I4 vs O
			//IL_0853->IL00c0: Incompatible stack types: I4 vs O
			//IL_00ae->IL00c0: Incompatible stack types: I4 vs O
			//IL_0078->IL0010: Incompatible stack types: I4 vs O
			//IL_03fd->IL0314: Incompatible stack types: I4 vs O
			//IL_01cb->IL00c0: Incompatible stack types: I4 vs O
			//IL_02c0->IL0201: Incompatible stack types: I4 vs O
			//IL_085e->IL00c0: Incompatible stack types: I4 vs O
			//IL_0408->IL0314: Incompatible stack types: I4 vs O
			//IL_01dd->IL00c0: Incompatible stack types: I4 vs O
			//IL_012f->IL00c0: Incompatible stack types: I4 vs O
			//IL_014f->IL00c0: Incompatible stack types: I4 vs O
			//IL_0467->IL0314: Incompatible stack types: I4 vs O
			//IL_039b->IL0314: Incompatible stack types: I4 vs O
			//IL_04ec->IL0314: Incompatible stack types: I4 vs O
			//IL_04cf->IL0314: Incompatible stack types: I4 vs O
			//IL_050b->IL0314: Incompatible stack types: I4 vs O
			//IL_0494->IL0314: Incompatible stack types: I4 vs O
			//IL_0542->IL0314: Incompatible stack types: I4 vs O
			//IL_013a->IL00c0: Incompatible stack types: I4 vs O
			//IL_01a5->IL00c0: Incompatible stack types: I4 vs O
			//IL_0472->IL0314: Incompatible stack types: I4 vs O
			//IL_055e->IL0314: Incompatible stack types: I4 vs O
			//IL_03d6->IL0314: Incompatible stack types: I4 vs O
			//IL_04f7->IL0314: Incompatible stack types: I4 vs O
			//IL_043c->IL0314: Incompatible stack types: I4 vs O
			//IL_049f->IL0314: Incompatible stack types: I4 vs O
			//IL_0521->IL0314: Incompatible stack types: I4 vs O
			//IL_01ef->IL0201: Incompatible stack types: I4 vs O
			//IL_03e1->IL0314: Incompatible stack types: I4 vs O
			//IL_0447->IL0314: Incompatible stack types: I4 vs O
			//IL_08d6->IL00c0: Incompatible stack types: I4 vs O
			//IL_08e1->IL00c0: Incompatible stack types: I4 vs O
			int num = 3;
			dynamic obj3 = default(object);
			object obj6 = default(object);
			dynamic result = default(object);
			object obj18 = default(object);
			object obj8 = default(object);
			object obj10 = default(object);
			object obj11 = default(object);
			object obj4 = default(object);
			object obj15 = default(object);
			object obj17 = default(object);
			object obj20 = default(object);
			object obj22 = default(object);
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
								goto case 3;
							}
							_staging_5__3 = null;
							obj2 = 6;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_dabc6698d5764018a5f86ef3b5a7871e == 0)
							{
								obj2 = 6;
							}
							continue;
						case 1:
							__1__state = -2;
							obj2 = 4;
							continue;
						case 3:
							obj3 = __1__state;
							obj2 = 2;
							continue;
						case 5:
							try
							{
								object obj5;
								if (obj3 != null)
								{
									obj5 = 8;
									goto IL_00c0;
								}
								goto IL_083e;
								IL_083e:
								obj5 = 6;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_33eff53ba43c4c10a4788d4370759667 != 0)
								{
									obj5 = 3;
								}
								goto IL_00c0;
								IL_00c0:
								while (true)
								{
									switch ((int)obj5)
									{
									default:
										if ((nint)obj6 != 16)
										{
											if ((nint)obj6 == 996)
											{
												goto IL_00bc;
											}
											goto case 7;
										}
										_staging_5__3 = System.IO.Path.Combine(pendingPath, ".staging");
										obj5 = 7;
										continue;
									case 7:
										System.IO.Directory.CreateDirectory(_staging_5__3);
										obj5 = 0;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9925520c809e49e19c0340f5f2a4c15c == 0)
										{
											obj5 = 8;
										}
										continue;
									case 8:
										_result_5__2 = (SyncResult)new SyncResult();
										obj5 = 2;
										continue;
									case 2:
										System.IO.Directory.CreateDirectory(pendingPath);
										obj6 = 16;
										goto IL_00bc;
									case 1:
										__7__wrap3 = null;
										obj5 = 5;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9a1f67b15040430199ec9dc1289e168b == 0)
										{
											obj5 = 12;
										}
										continue;
									case 5:
										result = _result_5__2;
										obj5 = 4;
										continue;
									case 6:
										try
										{
											object obj7;
											if (obj3 == null)
											{
												obj7 = 7;
												goto IL_0201;
											}
											goto IL_0272;
											IL_02c0:
											_item_5__5 = __7__wrap3.Current;
											obj7 = 1;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_24238b39bba94b6aa4d3c2739f061133 != 0)
											{
												obj7 = 4;
											}
											goto IL_0201;
											IL_0201:
											while (true)
											{
												switch ((int)obj7)
												{
												default:
													if ((nint)obj18 != 15)
													{
														if ((nint)obj18 == 995)
														{
															goto IL_01fd;
														}
														goto case 6;
													}
													goto case 7;
												case 6:
													_item_5__5 = null;
													obj7 = 3;
													continue;
												case 1:
													(cancellationToken).ThrowIfCancellationRequested();
													obj18 = 15;
													goto IL_01fd;
												case 3:
												case 5:
													break;
												case 7:
													obj7 = 7;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_31a06ac266364bee8fef51fc97395192 != 0)
													{
														obj7 = 0;
													}
													continue;
												case 4:
													goto IL_02c0;
												case 0:
													try
													{
														int num2;
														if (obj3 != null)
														{
															num2 = 3;
															goto IL_030c;
														}
														goto IL_03e1;
														IL_03e1:
														obj8 = __u__1;
														object obj9 = 17;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e22115a4e7ab476da94f74d7e328d269 == 0)
														{
															obj9 = 0;
														}
														goto IL_0314;
														IL_030c:
														obj10 = num2;
														goto IL_0310;
														IL_0310:
														obj9 = obj10;
														goto IL_0314;
														IL_0314:
														IProgress<string> obj13;
														while (true)
														{
															switch ((int)obj9)
															{
															default:
																if ((nint)obj10 != 23)
																{
																	goto IL_0367;
																}
																goto case 4;
															case 1:
															{
																SyncResult syncResult2 = _result_5__2;
																object obj12 = syncResult2.Downloaded;
																syncResult2.Downloaded = (int)obj12 + 1;
																obj9 = 12;
																continue;
															}
															case 4:
																obj11 = ((McpCloudSyncService)obj4).DownloadAsync(_item_5__5, pendingPath, _staging_5__3, cancellationToken).ConfigureAwait(false);
																obj9 = 13;
																if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5616e31a21b646f69463de8959779c49 != 0)
																{
																	obj9 = 5;
																}
																continue;
															case 2:
																break;
															case 7:
																goto IL_0408;
															case 9:
																if (((ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter*)(&obj8))->GetResult())
																{
																	obj9 = 11;
																	if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b18c9101a9694aa1aae5a0a4ca0f1892 == 0)
																	{
																		obj9 = 1;
																	}
																	continue;
																}
																goto case 6;
															case 0:
																__u__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
																obj9 = 7;
																if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7880b59a09bf4a2190c2568d83d12e71 != 0)
																{
																	obj9 = 5;
																}
																continue;
															case 13:
																__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter, _SyncAsync_d__4>(ref *(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter*)(&obj8), ref this);
																obj9 = 11;
																if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_dbb7d0b4e7ca46959ea177dcc91c1f0e == 0)
																{
																	obj9 = 8;
																}
																continue;
															case 11:
																return;
															case 6:
															{
																SyncResult syncResult = _result_5__2;
																object obj12 = syncResult.Existing;
																syncResult.Existing = (int)obj12 + 1;
																obj9 = 8;
																continue;
															}
															case 5:
																obj8 = ((ConfiguredTaskAwaitable<bool>*)(&obj11))->GetAwaiter();
																obj9 = 18;
																if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e041d974da614bb9aad5f28559bec3d0 == 0)
																{
																	obj9 = 15;
																}
																continue;
															case 10:
																obj3 = 0;
																__1__state = 0;
																obj9 = 14;
																continue;
															case 15:
																if (!((ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter*)(&obj8))->IsCompleted)
																{
																	obj9 = 10;
																	continue;
																}
																goto case 9;
															case 12:
																goto end_IL_02f1;
															case 14:
																__u__1 = (ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter)obj8;
																obj9 = 13;
																continue;
															case 3:
																goto IL_0542;
															case 8:
																goto end_IL_02f1;
															}
															break;
															IL_0542:
															obj13 = progress;
															if (obj13 != null)
															{
																goto IL_0563;
															}
															obj9 = 4;
														}
														goto IL_03e1;
														IL_0367:
														if ((nint)obj10 == 1003)
														{
															goto IL_0310;
														}
														goto end_IL_02f1;
														IL_0563:
														obj13.Report(string.Concat("正在同步：", (_item_5__5).OriginalName));
														num2 = 23;
														goto IL_030c;
														IL_0408:
														obj3 = -1;
														__1__state = -1;
														num2 = 9;
														goto IL_030c;
														end_IL_02f1:;
													}
													catch (global::System.Exception ex2)
													{
														object obj16 = 5;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9608fe64d13146acb5eaea30e653fb87 == 0)
														{
															obj16 = 0;
														}
														while (true)
														{
															switch ((int)obj16)
															{
															default:
																if ((nint)obj17 == 990)
																{
																	obj16 = obj17;
																	continue;
																}
																break;
															case 0:
																global::System.Diagnostics.Debug.WriteLine(ex2);
																obj16 = 6;
																if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b28f7b3c5e414da9823acaf82070b1eb == 0)
																{
																	obj16 = 1;
																}
																continue;
															case 1:
																_result_5__2.Errors.Add(string.Concat((_item_5__5).OriginalName, "：", (ex2).Message));
																obj16 = 2;
																if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f3d80f367d504e3d9064e4cfb99ce343 != 0)
																{
																	obj16 = 3;
																}
																continue;
															case 2:
																break;
															}
															break;
														}
													}
													goto case 6;
												case 2:
													goto end_IL_01de;
													IL_01fd:
													obj7 = obj18;
													continue;
												}
												break;
											}
											goto IL_0272;
											IL_0272:
											if (!(__7__wrap3).MoveNext())
											{
												obj7 = 2;
												goto IL_0201;
											}
											goto IL_02c0;
											end_IL_01de:;
										}
										finally
										{
											object obj19;
											if ((nint)obj3 >= 0)
											{
												obj19 = 2;
												goto IL_078e;
											}
											goto IL_07da;
											IL_07da:
											if (__7__wrap3 != null)
											{
												obj19 = 3;
												goto IL_078e;
											}
											goto end_IL_076a;
											IL_078e:
											while (true)
											{
												switch ((int)obj19)
												{
												default:
													if ((nint)obj20 == 991)
													{
														obj19 = obj20;
														continue;
													}
													goto case 3;
												case 2:
													goto end_IL_078e;
												case 0:
													break;
												case 3:
													(__7__wrap3).Dispose();
													obj19 = 1;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9c15dc17ae4e48a5bd629d141b0ebe29 == 0)
													{
														obj19 = 4;
													}
													continue;
												case 1:
													goto end_IL_078e;
												}
												goto IL_07da;
												continue;
												end_IL_078e:
												break;
											}
											end_IL_076a:;
										}
										goto case 1;
									case 3:
										break;
									case 0:
										__7__wrap3 = Enumerable.Select<IGrouping<long, JEDl1cf6VmwwyP6UuZ5V>, JEDl1cf6VmwwyP6UuZ5V>(Enumerable.GroupBy<JEDl1cf6VmwwyP6UuZ5V, long>(items, (Func<JEDl1cf6VmwwyP6UuZ5V, long>)__c_5.__9._SyncAsync_b__4_0), (Func<IGrouping<long, JEDl1cf6VmwwyP6UuZ5V>, JEDl1cf6VmwwyP6UuZ5V>)__c_5.__9._SyncAsync_b__4_1).GetEnumerator();
										obj5 = 10;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_33eff53ba43c4c10a4788d4370759667 == 0)
										{
											obj5 = 3;
										}
										continue;
									case 4:
										goto end_IL_00c0;
										IL_00bc:
										obj5 = obj6;
										continue;
									}
									goto IL_083e;
									continue;
									end_IL_00c0:
									break;
								}
							}
							catch (global::System.Exception exception)
							{
								object obj21 = 3;
								while (true)
								{
									switch ((int)obj21)
									{
									default:
										if ((nint)obj22 != 11)
										{
											if ((nint)obj22 != 991)
											{
												break;
											}
											goto IL_0900;
										}
										_result_5__2 = null;
										obj21 = 0;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0003dce1a8644b9dbbca586828352343 != 0)
										{
											obj21 = 5;
										}
										continue;
									case 1:
										__t__builder.SetException(exception);
										obj21 = 2;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_33eff53ba43c4c10a4788d4370759667 == 0)
										{
											obj21 = 2;
										}
										continue;
									case 0:
										break;
									case 3:
										__1__state = -2;
										obj22 = 11;
										goto IL_0900;
									case 2:
										return;
										IL_0900:
										obj21 = obj22;
										continue;
									}
									_staging_5__3 = null;
									obj21 = 0;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_916ae56933ff4374af011c79e3cb023a != 0)
									{
										obj21 = 1;
									}
								}
							}
							goto case 1;
						case 2:
							obj4 = __4__this;
							obj2 = 5;
							continue;
						case 0:
							return;
						case 4:
							break;
						case 6:
							__t__builder.SetResult((SyncResult)result);
							obj2 = 5;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7ef2723341c74c2b88836c43256b27b6 != 0)
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
				_result_5__2 = null;
				num = 10;
				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_28a8309f77124973ab9263f59df1f564 != 0)
				{
					num = 13;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_0050->IL0010: Incompatible stack types: I4 vs O
			//IL_005b->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
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
					if ((nint)obj == 989)
					{
						break;
					}
					goto IL_0030;
					IL_0030:
					__t__builder.SetStateMachine(stateMachine);
					obj2 = 0;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b18c9101a9694aa1aae5a0a4ca0f1892 != 0)
					{
						obj2 = 5;
					}
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool fdJcJPL2f7A61jnn2Ttf()
		{
			return IyVtg0L2X5twkM5HDsaS == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object QSVS8BL2L7Mw0D8G1LVl()
		{
			return IyVtg0L2X5twkM5HDsaS;
		}
	}

	private const int ChunkBytes = 524288;

	private const long MaxFileBytes = 52428800L;

	private readonly Func<long, long, int, CancellationToken, global::System.Threading.Tasks.Task<blITQ5f6ZD0ur9oMSjQ5>> _download;

	internal static McpCloudSyncService EtD3kZLvBjICxNYvrtFD;

	[MethodImpl((MethodImplOptions)8)]
	public McpCloudSyncService(Func<long, long, int, CancellationToken, global::System.Threading.Tasks.Task<blITQ5f6ZD0ur9oMSjQ5>> download)
	{
		//IL_0050: Expected I4, but got O
		//IL_0031->IL0043: Incompatible stack types: I4 vs O
		//IL_003c->IL0043: Incompatible stack types: I4 vs O
		//IL_007e->IL0043: Incompatible stack types: I4 vs O
		//IL_0089->IL0043: Incompatible stack types: I4 vs O
		object obj = 4;
		if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_09be964badeb4066912116bbb7cb20e9 != 0)
		{
			obj = 0;
		}
		object obj2 = default(object);
		while (true)
		{
			switch ((int)obj)
			{
			default:
				if ((nint)obj2 == 989)
				{
					obj = obj2;
					break;
				}
				return;
			case 0:
				_download = download;
				obj = 7;
				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7880b59a09bf4a2190c2568d83d12e71 == 0)
				{
					obj = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public unsafe global::System.Threading.Tasks.Task<SyncResult> SyncAsync(global::System.Collections.Generic.IEnumerable<JEDl1cf6VmwwyP6UuZ5V> items, string pendingPath, IProgress<string>? progress = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_000c: Expected O, but got I4
		//IL_0035: Expected I4, but got O
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119->IL0010: Incompatible stack types: I4 vs O
		//IL_013d->IL0010: Incompatible stack types: I4 vs O
		//IL_00ba->IL0010: Incompatible stack types: I4 vs O
		//IL_0076->IL0010: Incompatible stack types: I4 vs O
		//IL_009d->IL0010: Incompatible stack types: I4 vs O
		//IL_00d6->IL0010: Incompatible stack types: I4 vs O
		//IL_0081->IL0010: Incompatible stack types: I4 vs O
		//IL_00a8->IL0010: Incompatible stack types: I4 vs O
		//IL_00e1->IL0010: Incompatible stack types: I4 vs O
		int num = 3;
		dynamic obj3 = default(object);
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
						if ((nint)obj != 14)
						{
							if ((nint)obj == 995)
							{
								goto end_IL_0010;
							}
							goto case 5;
						}
						return ((dynamic)obj3).__t__builder.Task;
					case 3:
						((dynamic)obj3).__t__builder = AsyncTaskMethodBuilder<SyncResult>.Create();
						obj2 = 2;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_efa7845a846a43508e861e510ac5e1d2 != 0)
						{
							obj2 = 9;
						}
						continue;
					case 5:
						((dynamic)obj3).items = items;
						obj2 = 1;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3054c4fc69b94a37b21ac42c2099175a == 0)
						{
							obj2 = 7;
						}
						continue;
					case 2:
						((dynamic)obj3).__4__this = this;
						obj2 = 5;
						continue;
					case 7:
						((dynamic)obj3).progress = progress;
						obj2 = 13;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1282ca3a3b4d42dea9c5c692937e35bc != 0)
						{
							obj2 = 0;
						}
						continue;
					case 4:
						((dynamic)obj3).__t__builder.Start<_SyncAsync_d__4>(ref obj3);
						num = 14;
						break;
					case 0:
						((dynamic)obj3).cancellationToken = cancellationToken;
						obj2 = 6;
						continue;
					case 6:
						((dynamic)obj3).__1__state = -1;
						num = 4;
						break;
					case 1:
						((dynamic)obj3).pendingPath = pendingPath;
						obj2 = 7;
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe global::System.Threading.Tasks.Task<bool> DownloadAsync(JEDl1cf6VmwwyP6UuZ5V item, string pendingPath, string staging, CancellationToken cancellationToken)
	{
		//IL_000c: Expected O, but got I4
		//IL_0035: Expected I4, but got O
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a->IL0010: Incompatible stack types: I4 vs O
		//IL_00b7->IL0010: Incompatible stack types: I4 vs O
		//IL_0101->IL0010: Incompatible stack types: I4 vs O
		//IL_0123->IL0010: Incompatible stack types: I4 vs O
		//IL_0073->IL0010: Incompatible stack types: I4 vs O
		//IL_0167->IL0010: Incompatible stack types: I4 vs O
		//IL_0155->IL0010: Incompatible stack types: I4 vs O
		//IL_012e->IL0010: Incompatible stack types: I4 vs O
		//IL_007e->IL0010: Incompatible stack types: I4 vs O
		//IL_009a->IL0010: Incompatible stack types: I4 vs O
		//IL_00a5->IL0010: Incompatible stack types: I4 vs O
		int num = 5;
		dynamic obj3 = default(object);
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
						if ((nint)obj != 14)
						{
							if ((nint)obj == 995)
							{
								goto end_IL_0010;
							}
							goto case 3;
						}
						((dynamic)obj3).__4__this = this;
						obj2 = 1;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1282ca3a3b4d42dea9c5c692937e35bc == 0)
						{
							obj2 = 2;
						}
						continue;
					case 4:
						((dynamic)obj3).cancellationToken = cancellationToken;
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_d9c10084bf5f4a9f947702ad63bef067 != 0)
						{
							obj2 = 13;
						}
						continue;
					case 1:
						((dynamic)obj3).item = item;
						obj2 = 2;
						continue;
					case 5:
						break;
					case 7:
						return ((dynamic)obj3).__t__builder.Task;
					case 2:
						((dynamic)obj3).pendingPath = pendingPath;
						obj2 = 6;
						continue;
					case 3:
						((dynamic)obj3).__t__builder.Start<_DownloadAsync_d__5>(ref obj3);
						obj2 = 7;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9925520c809e49e19c0340f5f2a4c15c == 0)
						{
							obj2 = 9;
						}
						continue;
					case 0:
						((dynamic)obj3).__1__state = -1;
						obj2 = 3;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e041d974da614bb9aad5f28559bec3d0 != 0)
						{
							obj2 = 0;
						}
						continue;
					case 6:
						((dynamic)obj3).staging = staging;
						obj2 = 4;
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
			((dynamic)obj3).__t__builder = AsyncTaskMethodBuilder<bool>.Create();
			num = 14;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e041d974da614bb9aad5f28559bec3d0 == 0)
			{
				num = 14;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe static global::System.Threading.Tasks.Task<bool> MatchesAsync(string path, JEDl1cf6VmwwyP6UuZ5V item, CancellationToken cancellationToken)
	{
		//IL_000c: Expected O, but got I4
		//IL_002d: Expected I4, but got O
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119->IL0010: Incompatible stack types: I4 vs O
		//IL_00c5->IL0010: Incompatible stack types: I4 vs O
		//IL_0091->IL0010: Incompatible stack types: I4 vs O
		//IL_013a->IL0010: Incompatible stack types: I4 vs O
		//IL_0124->IL0010: Incompatible stack types: I4 vs O
		//IL_00d0->IL0010: Incompatible stack types: I4 vs O
		//IL_009c->IL0010: Incompatible stack types: I4 vs O
		//IL_00ec->IL0010: Incompatible stack types: I4 vs O
		//IL_00f7->IL0010: Incompatible stack types: I4 vs O
		int num = 3;
		dynamic obj3 = default(object);
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
						if ((nint)obj == 12)
						{
							((dynamic)obj3).__1__state = -1;
							obj2 = 0;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bd95bcb31f2a40c89aee1548651426a0 != 0)
							{
								obj2 = 6;
							}
							continue;
						}
						goto end_IL_0010;
					case 4:
						break;
					case 2:
						((dynamic)obj3).path = path;
						obj2 = 1;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ec9f1bd7108f411daeb83b57baf2dba0 == 0)
						{
							obj2 = 12;
						}
						continue;
					case 5:
						return ((dynamic)obj3).__t__builder.Task;
					case 1:
						((dynamic)obj3).item = item;
						obj2 = 4;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_a39b60a5f46a44329f1ae7a5ef50ae96 == 0)
						{
							obj2 = 2;
						}
						continue;
					case 0:
						((dynamic)obj3).__t__builder.Start<_MatchesAsync_d__6>(ref obj3);
						obj2 = 11;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e1a4b1278f5749c28fff394e2932a022 != 0)
						{
							obj2 = 5;
						}
						continue;
					case 3:
						((dynamic)obj3).__t__builder = AsyncTaskMethodBuilder<bool>.Create();
						obj2 = 2;
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
			while ((nint)obj == 993);
			((dynamic)obj3).cancellationToken = cancellationToken;
			num = 12;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f1dd9923a6bd42d5867c8e2e591d3e3b == 0)
			{
				num = 6;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool iwAAQULvgVIhOhau4Kky()
	{
		return EtD3kZLvBjICxNYvrtFD == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static McpCloudSyncService X8e4JlLvlSxeb9QmK5su()
	{
		return EtD3kZLvBjICxNYvrtFD;
	}
}
