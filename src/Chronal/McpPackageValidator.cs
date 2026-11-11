using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using By1SFsLobKQOZCdh5qRg;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Features.McpStudio.Builder;

internal class McpPackageValidator
{
	internal record struct McpPackageInfo
	{
		public int EntryCount
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _EntryCount_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			init
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
						_EntryCount_k__BackingField = value;
						obj2 = 4;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_861620835107408fad0813077d9e9967 == 0)
						{
							obj2 = 0;
						}
					}
				}
			}
		}

		public long SizeBytes
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _SizeBytes_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			init
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
						_SizeBytes_k__BackingField = value;
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_36a48f7fc5034120a3fadb53ab2f53cc != 0)
						{
							obj2 = 4;
						}
					}
				}
			}
		}

		public string Sha256
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Sha256_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			init
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
							_Sha256_k__BackingField = value;
							obj2 = 4;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e8ca07a3866c4b3b9e07b1ae67715f0c == 0)
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

		public string EntryModule
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _EntryModule_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			init
			{
				//IL_000c: Expected O, but got I4
				//IL_001d: Expected I4, but got O
				//IL_004c->IL0010: Incompatible stack types: I4 vs O
				//IL_0057->IL0010: Incompatible stack types: I4 vs O
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
						_EntryModule_k__BackingField = value;
						obj2 = 2;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_fd6fdaa7d4824d4c9cf1c9399aa7f204 == 0)
						{
							obj2 = 0;
						}
					}
				}
			}
		}

		[CompilerGenerated]
		private int _EntryCount_k__BackingField;

		[CompilerGenerated]
		private long _SizeBytes_k__BackingField;

		[CompilerGenerated]
		private string _Sha256_k__BackingField;

		[CompilerGenerated]
		private string _EntryModule_k__BackingField;

		private static object mR5d0yL2GuqMvDPBIc7i;

		[MethodImpl((MethodImplOptions)8)]
		public void __struct(int EntryCount, long SizeBytes, string Sha256, string EntryModule)
		{
			//IL_000d: Expected O, but got I4
			//IL_002a: Expected I4, but got O
			//IL_00ab->IL0011: Incompatible stack types: I4 vs O
			//IL_00b6->IL0011: Incompatible stack types: I4 vs O
			//IL_0091->IL0011: Incompatible stack types: I4 vs O
			//IL_005a->IL0011: Incompatible stack types: I4 vs O
			//IL_00d1->IL0011: Incompatible stack types: I4 vs O
			//IL_00dc->IL0011: Incompatible stack types: I4 vs O
			//IL_00f8->IL0011: Incompatible stack types: I4 vs O
			//IL_0103->IL0011: Incompatible stack types: I4 vs O
			object obj = 12;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2b2f512a98d548488e5242742b1ff011 == 0)
			{
				obj = 2;
			}
			object obj2 = default(object);
			while (true)
			{
				switch ((int)obj)
				{
				default:
					if ((nint)obj2 != 12)
					{
						if ((nint)obj2 == 992)
						{
							goto IL_000d;
						}
						goto case 3;
					}
					_EntryModule_k__BackingField = EntryModule;
					obj = 0;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1282ca3a3b4d42dea9c5c692937e35bc == 0)
					{
						obj = 10;
					}
					break;
				case 2:
					obj = 1;
					break;
				case 3:
				{
					_Sha256_k__BackingField = Sha256;
					int num = 12;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_db2c7dd1aabc4c9a97a36e710c0128ab == 0)
					{
						num = 12;
					}
					obj2 = num;
					goto IL_000d;
				}
				case 1:
					_EntryCount_k__BackingField = EntryCount;
					obj = 4;
					break;
				case 0:
					return;
				case 4:
					{
						_SizeBytes_k__BackingField = SizeBytes;
						obj = 1;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0c88e6c08eaf4e998e8fdd2c544cee2e != 0)
						{
							obj = 3;
						}
						break;
					}
					IL_000d:
					obj = obj2;
					break;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override string ToString()
		{
			//IL_000c: Expected O, but got I4
			//IL_0031: Expected I4, but got O
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			//IL_014e->IL0010: Incompatible stack types: I4 vs O
			//IL_00e8->IL0010: Incompatible stack types: I4 vs O
			//IL_006d->IL0010: Incompatible stack types: I4 vs O
			//IL_0159->IL0010: Incompatible stack types: I4 vs O
			//IL_0099->IL0010: Incompatible stack types: I4 vs O
			//IL_00f3->IL0010: Incompatible stack types: I4 vs O
			//IL_0078->IL0010: Incompatible stack types: I4 vs O
			//IL_0172->IL0010: Incompatible stack types: I4 vs O
			//IL_00a4->IL0010: Incompatible stack types: I4 vs O
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
							if ((nint)obj != 13)
							{
								goto end_IL_0010;
							}
							goto case 4;
						case 3:
							obj3 = (object)new StringBuilder();
							obj2 = 3;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2b8232439dce49e49a3fdd295da14355 == 0)
							{
								obj2 = 2;
							}
							continue;
						case 1:
							if (!PrintMembers((StringBuilder)obj3))
							{
								obj2 = 4;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0b81b3b6b3bc4c4a8075444d576cb8ec == 0)
								{
									obj2 = 9;
								}
								continue;
							}
							break;
						case 2:
							((dynamic)obj3).Append("McpPackageInfo");
							obj2 = 0;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_a4b5b9d8fe0344d0a0d0c6ee7728050b != 0)
							{
								obj2 = 2;
							}
							continue;
						case 5:
							break;
						case 0:
							((dynamic)obj3).Append(" { ");
							obj2 = 1;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_fd7466ab326a4027abb1e5cf92add793 != 0)
							{
								obj2 = 13;
							}
							continue;
						case 4:
							((dynamic)obj3).Append('}');
							obj2 = 6;
							continue;
						case 6:
							return (obj3).ToString();
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
				while ((nint)obj == 994);
				((dynamic)obj3).Append(' ');
				num = 13;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private unsafe bool PrintMembers(StringBuilder builder)
		{
			//IL_000c: Expected O, but got I4
			//IL_0035: Expected I4, but got O
			//IL_0149: Expected O, but got I8
			//IL_00c3: Expected O, but got I4
			//IL_00ba->IL0010: Incompatible stack types: I4 vs O
			//IL_0093->IL0010: Incompatible stack types: I4 vs O
			//IL_01c2->IL0010: Incompatible stack types: I4 vs O
			//IL_020e->IL0010: Incompatible stack types: I4 vs O
			//IL_016b->IL0010: Incompatible stack types: I4 vs O
			//IL_019c->IL0010: Incompatible stack types: I4 vs O
			//IL_009e->IL0010: Incompatible stack types: I4 vs O
			//IL_01cd->IL0010: Incompatible stack types: I4 vs O
			//IL_0219->IL0010: Incompatible stack types: I4 vs O
			//IL_0135->IL0010: Incompatible stack types: I4 vs O
			//IL_0140->IL0010: Incompatible stack types: I4 vs O
			int num = 7;
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
							(builder).Append(", SizeBytes = ");
							obj2 = 12;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2aab0405e3774254ad8ff3552d808a1d != 0)
							{
								obj2 = 5;
							}
							continue;
						case 1:
							return true;
						case 2:
							(builder).Append(", EntryModule = ");
							obj2 = 3;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5d72748c192f4bab9e19ca961e9277d1 != 0)
							{
								obj2 = 12;
							}
							continue;
						case 0:
							(builder).Append(Sha256);
							obj2 = 2;
							continue;
						case 6:
							break;
						case 5:
						{
							dynamic obj3 = SizeBytes;
							(builder).Append(((object)(obj3)/*cast due to .constrained prefix*/).ToString());
							obj2 = 4;
							continue;
						}
						case 7:
							(builder).Append("EntryCount = ");
							obj2 = 6;
							continue;
						case 3:
							(builder).Append(EntryModule);
							obj2 = 9;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_8cd7f54b623a4d42b1a5e008c75a22ed != 0)
							{
								obj2 = 1;
							}
							continue;
						case 4:
							(builder).Append(", Sha256 = ");
							obj2 = 4;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_24238b39bba94b6aa4d3c2739f061133 == 0)
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
				object obj4 = EntryCount;
				(builder).Append(((object)(obj4)/*cast due to .constrained prefix*/).ToString());
				num = 14;
				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_d9c10084bf5f4a9f947702ad63bef067 != 0)
				{
					num = 1;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<int>.Default.GetHashCode(_EntryCount_k__BackingField) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(_SizeBytes_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_Sha256_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_EntryModule_k__BackingField);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public bool Equals(McpPackageInfo other)
		{
			//IL_000c: Expected O, but got I4
			//IL_0029: Expected I4, but got O
			//IL_00e4->IL0010: Incompatible stack types: I4 vs O
			//IL_006f->IL0010: Incompatible stack types: I4 vs O
			//IL_00ef->IL0010: Incompatible stack types: I4 vs O
			int num = 4;
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
								goto case 4;
							}
							goto case 3;
						case 4:
							if (!EqualityComparer<int>.Default.Equals(_EntryCount_k__BackingField, other._EntryCount_k__BackingField))
							{
								obj2 = 3;
								continue;
							}
							goto case 2;
						case 2:
							if (!EqualityComparer<long>.Default.Equals(_SizeBytes_k__BackingField, other._SizeBytes_k__BackingField))
							{
								break;
							}
							goto case 0;
						case 0:
							if (EqualityComparer<string>.Default.Equals(_Sha256_k__BackingField, other._Sha256_k__BackingField))
							{
								obj2 = 2;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2b2f512a98d548488e5242742b1ff011 == 0)
								{
									obj2 = 1;
								}
								continue;
							}
							goto case 3;
						case 1:
							return EqualityComparer<string>.Default.Equals(_EntryModule_k__BackingField, other._EntryModule_k__BackingField);
						case 3:
							return false;
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
				num = 2;
				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b7393eff3b9049068ae7c92e2e0229a5 == 0)
				{
					num = 11;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public void Deconstruct(out int EntryCount, out long SizeBytes, out string Sha256, out string EntryModule)
		{
			//IL_0009: Expected I8, but got O
			EntryCount = _EntryCount_k__BackingField;
			SizeBytes = _SizeBytes_k__BackingField;
			Sha256 = _Sha256_k__BackingField;
			EntryModule = _EntryModule_k__BackingField;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool ogAZWuL2iNpf8eO671jS()
		{
			return mR5d0yL2GuqMvDPBIc7i == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object ATFMZRL2nIO6TfqR4NtL()
		{
			return mR5d0yL2GuqMvDPBIc7i;
		}
	}

	private const int HeaderSize = 57;

	internal static McpPackageValidator AYAu2wLvitndOpyVXRRB;

	[MethodImpl((MethodImplOptions)8)]
	public static McpPackageInfo Validate(string packagePath, string packageId, string entryModule)
	{
		//IL_000c: Expected O, but got I4
		//IL_00c5: Expected I4, but got O
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected O, but got I4
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Expected O, but got I8
		//IL_0248: Expected O, but got I4
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected I4, but got Unknown
		//IL_0470: Expected O, but got I4
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_075a: Expected O, but got I4
		//IL_072b: Expected I4, but got O
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0630: Expected O, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected I4, but got Unknown
		//IL_041c: Expected O, but got I4
		//IL_033a: Expected O, but got I4
		//IL_023b: Expected O, but got I4
		//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Expected I4, but got Unknown
		//IL_06cf: Expected O, but got I4
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Expected I4, but got Unknown
		//IL_0680: Expected O, but got I4
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected O, but got I4
		//IL_04ee: Expected O, but got I4
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cb: Expected O, but got Unknown
		//IL_073f->IL0010: Incompatible stack types: I4 vs O
		//IL_025c->IL0010: Incompatible stack types: I4 vs O
		//IL_047a->IL0010: Incompatible stack types: I4 vs O
		//IL_0106->IL0010: Incompatible stack types: I4 vs O
		//IL_0644->IL0010: Incompatible stack types: I4 vs O
		//IL_05b2->IL0010: Incompatible stack types: I4 vs O
		//IL_0220->IL0010: Incompatible stack types: I4 vs O
		//IL_0426->IL0010: Incompatible stack types: I4 vs O
		//IL_0344->IL0010: Incompatible stack types: I4 vs O
		//IL_0245->IL0010: Incompatible stack types: I4 vs O
		//IL_06e3->IL0010: Incompatible stack types: I4 vs O
		//IL_068a->IL0010: Incompatible stack types: I4 vs O
		//IL_0325->IL0010: Incompatible stack types: I4 vs O
		//IL_0712->IL0010: Incompatible stack types: I4 vs O
		//IL_0267->IL0010: Incompatible stack types: I4 vs O
		//IL_012e->IL0010: Incompatible stack types: I4 vs O
		//IL_0376->IL0010: Incompatible stack types: I4 vs O
		//IL_01dc->IL0010: Incompatible stack types: I4 vs O
		//IL_048f->IL0010: Incompatible stack types: I4 vs O
		//IL_0205->IL0010: Incompatible stack types: I4 vs O
		//IL_0592->IL0010: Incompatible stack types: I4 vs O
		//IL_0111->IL0010: Incompatible stack types: I4 vs O
		//IL_064f->IL0010: Incompatible stack types: I4 vs O
		//IL_04ac->IL0010: Incompatible stack types: I4 vs O
		//IL_03ce->IL0010: Incompatible stack types: I4 vs O
		//IL_05e0->IL0010: Incompatible stack types: I4 vs O
		//IL_0663->IL0010: Incompatible stack types: I4 vs O
		//IL_0502->IL0010: Incompatible stack types: I4 vs O
		//IL_0448->IL0010: Incompatible stack types: I4 vs O
		//IL_016f->IL0010: Incompatible stack types: I4 vs O
		//IL_02bb->IL0010: Incompatible stack types: I4 vs O
		//IL_03f4->IL0010: Incompatible stack types: I4 vs O
		//IL_06ee->IL0010: Incompatible stack types: I4 vs O
		//IL_028b->IL0010: Incompatible stack types: I4 vs O
		//IL_0330->IL0010: Incompatible stack types: I4 vs O
		//IL_071d->IL0010: Incompatible stack types: I4 vs O
		//IL_0381->IL0010: Incompatible stack types: I4 vs O
		//IL_01e7->IL0010: Incompatible stack types: I4 vs O
		//IL_0210->IL0010: Incompatible stack types: I4 vs O
		//IL_059d->IL0010: Incompatible stack types: I4 vs O
		//IL_055e->IL0010: Incompatible stack types: I4 vs O
		//IL_03d9->IL0010: Incompatible stack types: I4 vs O
		//IL_050d->IL0010: Incompatible stack types: I4 vs O
		//IL_0453->IL0010: Incompatible stack types: I4 vs O
		//IL_017a->IL0010: Incompatible stack types: I4 vs O
		//IL_03ff->IL0010: Incompatible stack types: I4 vs O
		//IL_0296->IL0010: Incompatible stack types: I4 vs O
		//IL_061f->IL0010: Incompatible stack types: I4 vs O
		//IL_07d5->IL0010: Incompatible stack types: I4 vs O
		//IL_0569->IL0010: Incompatible stack types: I4 vs O
		//IL_062a->IL0010: Incompatible stack types: I4 vs O
		int num = 6;
		dynamic obj10 = default(object);
		dynamic obj3 = default(object);
		dynamic obj12 = default(object);
		dynamic obj5 = default(object);
		dynamic obj13 = default(object);
		object obj8 = default(object);
		object obj4 = default(object);
		dynamic obj11 = default(object);
		object obj19 = default(object);
		dynamic obj18 = default(object);
		dynamic obj7 = default(object);
		dynamic obj14 = default(object);
		dynamic obj20 = default(object);
		dynamic obj16 = default(object);
		object sha = default(object);
		dynamic obj6 = default(object);
		dynamic obj17 = default(object);
		dynamic obj15 = default(object);
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
						if ((nint)obj != 50)
						{
							if ((nint)obj == 1031)
							{
								goto end_IL_0010;
							}
							goto case 8;
						}
						if (obj10 <= obj3)
						{
							obj2 = 41;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f102566966284916b14bc7efa63c0f5e == 0)
							{
								obj2 = 8;
							}
							continue;
						}
						goto case 28;
					case 17:
						checked
						{
							obj12 = obj5 + unchecked((long)(ulong)obj13) * 16L;
							obj2 = 15;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1282ca3a3b4d42dea9c5c692937e35bc == 0)
							{
								obj2 = 7;
							}
							continue;
						}
					case 9:
					{
						if ((long)(ulong)obj8 > (long)(((global::System.Array)obj4).Length - 129))
						{
							obj2 = 28;
							continue;
						}
						dynamic obj9 = checked(obj3 - obj10);
						if ((int)obj9 % 12 != 0)
						{
							throw new InvalidDataException("MCPK 目录表损坏");
						}
						obj11 = (int)obj9 / 12;
						obj2 = 7;
						continue;
					}
					case 26:
						throw new InvalidDataException("MCPK 数据区范围无效");
					case 27:
						throw new InvalidDataException("MCPK 不包含任何 Python 模块");
					case 12:
						obj19 = ((System.Text.Encoding.UTF8).GetString((byte[])obj4, 24, 33)).TrimEnd('\0');
						obj2 = 21;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e8864409e70b4d87b4c6598763ad15be == 0)
						{
							obj2 = 16;
						}
						continue;
					case 15:
						if ((long)obj5 < (long)(ulong)obj3)
						{
							obj2 = 4;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3054c4fc69b94a37b21ac42c2099175a != 0)
							{
								obj2 = 43;
							}
							continue;
						}
						goto case 32;
					case 29:
						obj18++;
						obj2 = 14;
						continue;
					case 39:
						obj8 = System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian((System.Span<byte>)(MemoryExtensions.AsSpan<byte>((byte[])obj4, 20, 4)));
						obj2 = 3;
						continue;
					case 7:
						obj7 = 0;
						obj2 = 31;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b45a6b8459fb4961b1724a2890d79f3a == 0)
						{
							obj2 = 22;
						}
						continue;
					case 41:
						if (obj3 <= obj8)
						{
							obj2 = 9;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2b2f512a98d548488e5242742b1ff011 != 0)
							{
								obj2 = 35;
							}
							continue;
						}
						goto case 28;
					case 35:
						if (checked(unchecked((long)(ulong)obj8) + unchecked((long)(ulong)obj14) + unchecked((long)(ulong)obj20)) > ((global::System.Array)obj4).Length - 129)
						{
							obj2 = 26;
							continue;
						}
						obj7++;
						obj2 = 29;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5144ebdc507c41fb87d88fdce3dc76e9 == 0)
						{
							obj2 = 19;
						}
						continue;
					case 0:
						throw new FileNotFoundException("构建输出不存在", packagePath);
					case 5:
						obj4 = System.IO.File.ReadAllBytes(packagePath);
						obj2 = 36;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3d9d86761de84aa48245c594db282bdf != 0)
						{
							obj2 = 34;
						}
						continue;
					case 31:
						obj16 = 0;
						obj2 = 38;
						continue;
					case 10:
						if (MemoryExtensions.SequenceEqual<byte>(MemoryExtensions.AsSpan<byte>((byte[])obj4, 0, 4), "MCPK"u8))
						{
							obj2 = 33;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_d9c10084bf5f4a9f947702ad63bef067 != 0)
							{
								obj2 = 0;
							}
							continue;
						}
						goto case 23;
					case 22:
						throw new InvalidDataException("入口模块不能为空");
					case 24:
						sha = System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData((byte[])obj4));
						obj2 = 24;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1282ca3a3b4d42dea9c5c692937e35bc != 0)
						{
							obj2 = 19;
						}
						continue;
					case 37:
						if (obj7 != null)
						{
							obj2 = 12;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_a39b60a5f46a44329f1ae7a5ef50ae96 == 0)
							{
								obj2 = 32;
							}
							continue;
						}
						goto case 27;
					case 30:
						obj6 = System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian((System.Span<byte>)(MemoryExtensions.AsSpan<byte>((byte[])obj4, (int)obj17 + 4, 4)));
						obj2 = 42;
						continue;
					case 34:
						if (((global::System.Array)obj4).Length >= 186)
						{
							obj2 = 10;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3d9d86761de84aa48245c594db282bdf == 0)
							{
								obj2 = 0;
							}
							continue;
						}
						goto case 23;
					case 8:
						obj20 = System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian((System.Span<byte>)(MemoryExtensions.AsSpan<byte>((byte[])obj4, (int)obj15 + 8, 4)));
						obj2 = 35;
						continue;
					case 13:
					case 14:
						if ((long)obj18 < (long)(ulong)obj13)
						{
							obj2 = 36;
							continue;
						}
						goto case 20;
					case 21:
						if (!string.Equals((string)obj19, packageId, (StringComparison)4))
						{
							obj2 = 2;
							continue;
						}
						if (!string.IsNullOrWhiteSpace(entryModule))
						{
							obj2 = 7;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_12ecff64eea14fe694da7ba4fdd3c628 == 0)
							{
								obj2 = 24;
							}
							continue;
						}
						goto case 22;
					case 23:
						throw new InvalidDataException("输出不是有效的 MCPK 文件");
					case 33:
						obj10 = System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian((System.Span<byte>)(MemoryExtensions.AsSpan<byte>((byte[])obj4, 12, 4)));
						obj2 = 18;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_20242fceb1c648009846fc096f5b9270 == 0)
						{
							obj2 = 34;
						}
						continue;
					case 2:
						throw new InvalidDataException(string.Concat("MCPK 包 ID 不匹配：", (string)obj19));
					case 16:
					case 38:
						if (obj16 >= obj11)
						{
							obj2 = 13;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ff96c054b9a547fc83bea3daf4a435ff != 0)
							{
								obj2 = 37;
							}
							continue;
						}
						goto case 25;
					case 25:
						obj17 = checked(obj10 + (int)obj16 * 12);
						obj2 = 30;
						continue;
					case 11:
					case 43:
						throw new InvalidDataException("MCPK 文件表范围无效");
					case 1:
					case 36:
						checked
						{
							obj15 = (int)(obj5 + unchecked((long)checked((int)obj18 * 16)));
							num = 40;
							break;
						}
					case 20:
						obj16++;
						obj2 = 16;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f3d80f367d504e3d9064e4cfb99ce343 != 0)
						{
							obj2 = 32;
						}
						continue;
					case 32:
						if ((long)obj12 > (long)(ulong)obj8)
						{
							obj2 = 11;
							continue;
						}
						obj18 = 0;
						obj2 = 13;
						continue;
					case 42:
						obj13 = System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian((System.Span<byte>)(MemoryExtensions.AsSpan<byte>((byte[])obj4, (int)obj17 + 8, 4)));
						obj2 = 4;
						continue;
					case 3:
						if ((nint)obj10 == 57)
						{
							num = 20;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1580feae44ff487ab78d80df31c471c0 != 0)
							{
								num = 50;
							}
							break;
						}
						goto case 28;
					case 40:
						obj14 = System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian((System.Span<byte>)(MemoryExtensions.AsSpan<byte>((byte[])obj4, (int)obj15 + 4, 4)));
						obj2 = 28;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ff96c054b9a547fc83bea3daf4a435ff != 0)
						{
							obj2 = 8;
						}
						continue;
					case 6:
						if (System.IO.File.Exists(packagePath))
						{
							obj2 = 5;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4ae4de12ce674c26bc2939a5789df8ab != 0)
							{
								obj2 = 20;
							}
							continue;
						}
						goto case 0;
					case 19:
						return new McpPackageInfo
						{
							EntryCount = (int)obj7,
							SizeBytes = ((global::System.Array)obj4).LongLength,
							Sha256 = (string)sha,
							EntryModule = entryModule
						};
					case 4:
						checked
						{
							obj5 = unchecked((long)(ulong)obj3) + unchecked((long)(ulong)obj6);
							obj2 = 17;
							continue;
						}
					case 18:
						obj3 = System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian((System.Span<byte>)(MemoryExtensions.AsSpan<byte>((byte[])obj4, 16, 4)));
						num = 39;
						break;
					case 28:
						throw new InvalidDataException("MCPK 表偏移无效");
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
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool AqwsJJLvnVcP0ZhbrIoj()
	{
		return AYAu2wLvitndOpyVXRRB == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static McpPackageValidator dDloHJLvzaViR7On84nA()
	{
		return AYAu2wLvitndOpyVXRRB;
	}
}
