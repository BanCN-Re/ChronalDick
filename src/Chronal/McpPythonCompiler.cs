using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Features.McpStudio.Builder;

internal class McpPythonCompiler
{
	internal readonly record struct ProcessResult
	{
		public int ExitCode
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _ExitCode_k__BackingField;
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
						_ExitCode_k__BackingField = value;
						obj2 = 2;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_527dac5507ee46fcb9d22f9ff955c1d0 == 0)
						{
							obj2 = 0;
						}
					}
				}
			}
		}

		public string Output
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Output_k__BackingField;
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
						_Output_k__BackingField = value;
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4f82b5c32b3f4f0289c9a252a3907b21 == 0)
						{
							obj2 = 1;
						}
					}
				}
			}
		}

		[CompilerGenerated]
		private readonly int _ExitCode_k__BackingField;

		[CompilerGenerated]
		private readonly string _Output_k__BackingField;

		private static object xwHOECL2zA23rvNrrLOu;

		[MethodImpl((MethodImplOptions)8)]
		public ProcessResult(int ExitCode, string Output)
		{
			//IL_000d: Expected O, but got I4
			//IL_0022: Expected I4, but got O
			//IL_0052->IL0011: Incompatible stack types: I4 vs O
			//IL_00a2->IL0011: Incompatible stack types: I4 vs O
			//IL_00ad->IL0011: Incompatible stack types: I4 vs O
			object obj = 1;
			object obj2 = default(object);
			while (true)
			{
				int num;
				switch ((int)obj)
				{
				default:
					if ((nint)obj2 != 10)
					{
						if ((nint)obj2 != 990)
						{
							return;
						}
						goto IL_000d;
					}
					_Output_k__BackingField = Output;
					obj = 6;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_861620835107408fad0813077d9e9967 == 0)
					{
						obj = 0;
					}
					break;
				case 2:
					_ExitCode_k__BackingField = ExitCode;
					num = 6;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bb37d0226fdb41f1902e558a997d9dc6 == 0)
					{
						num = 10;
					}
					goto IL_0009;
				case 1:
					num = 2;
					goto IL_0009;
				case 0:
					return;
					IL_000d:
					obj = obj2;
					break;
					IL_0009:
					obj2 = num;
					goto IL_000d;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override string ToString()
		{
			//IL_000c: Expected O, but got I4
			//IL_0031: Expected I4, but got O
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Expected O, but got Unknown
			//IL_0108->IL0010: Incompatible stack types: I4 vs O
			//IL_007c->IL0010: Incompatible stack types: I4 vs O
			//IL_00c3->IL0010: Incompatible stack types: I4 vs O
			//IL_0113->IL0010: Incompatible stack types: I4 vs O
			//IL_0087->IL0010: Incompatible stack types: I4 vs O
			//IL_00ce->IL0010: Incompatible stack types: I4 vs O
			//IL_00e5->IL0010: Incompatible stack types: I4 vs O
			int num = 6;
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
							if ((nint)obj != 13)
							{
								if ((nint)obj == 994)
								{
									goto end_IL_0010;
								}
								goto case 4;
							}
							if (!PrintMembers((StringBuilder)obj3))
							{
								obj2 = 2;
								continue;
							}
							goto case 3;
						case 3:
							((dynamic)obj3).Append(' ');
							obj2 = 4;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_36a48f7fc5034120a3fadb53ab2f53cc == 0)
							{
								obj2 = 0;
							}
							continue;
						case 5:
							((dynamic)obj3).Append("ProcessResult");
							obj2 = 5;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_8a5abf847bb54a3aa56e2df86c0b5690 == 0)
							{
								obj2 = 4;
							}
							continue;
						case 0:
						case 2:
							((dynamic)obj3).Append('}');
							obj2 = 4;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e1a4b1278f5749c28fff394e2932a022 != 0)
							{
								obj2 = 1;
							}
							continue;
						case 4:
							((dynamic)obj3).Append(" { ");
							num = 5;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_481dc375f7e24d3cb0e875f941fcda75 == 0)
							{
								num = 13;
							}
							break;
						case 6:
							obj3 = (object)new StringBuilder();
							num = 5;
							break;
						case 1:
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
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private unsafe bool PrintMembers(StringBuilder builder)
		{
			//IL_000c: Expected O, but got I4
			//IL_0025: Expected I4, but got O
			//IL_0097: Expected O, but got I4
			//IL_0083->IL0010: Incompatible stack types: I4 vs O
			//IL_00c3->IL0010: Incompatible stack types: I4 vs O
			//IL_008e->IL0010: Incompatible stack types: I4 vs O
			//IL_00ce->IL0010: Incompatible stack types: I4 vs O
			int num = 3;
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
								goto case 0;
							}
							return true;
						case 1:
							(builder).Append(", Output = ");
							obj2 = 0;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ee050290791c4dfbba3a13b8d87cc1bd != 0)
							{
								obj2 = 10;
							}
							continue;
						case 2:
						{
							dynamic obj3 = ExitCode;
							(builder).Append(((object)(obj3)/*cast due to .constrained prefix*/).ToString());
							obj2 = 9;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4fafd75e484e4b31a74460f9f0d54951 != 0)
							{
								obj2 = 1;
							}
							continue;
						}
						case 3:
							(builder).Append("ExitCode = ");
							num = 2;
							break;
						case 0:
							(builder).Append(Output);
							num = 10;
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
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return EqualityComparer<int>.Default.GetHashCode(_ExitCode_k__BackingField) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_Output_k__BackingField);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public bool Equals(ProcessResult other)
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_005f->IL0010: Incompatible stack types: I4 vs O
			//IL_006a->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj == 989)
						{
							break;
						}
						goto case 1;
					case 1:
						if (EqualityComparer<int>.Default.Equals(_ExitCode_k__BackingField, other._ExitCode_k__BackingField))
						{
							obj2 = 2;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e22115a4e7ab476da94f74d7e328d269 == 0)
							{
								obj2 = 0;
							}
							continue;
						}
						return false;
					case 0:
						return EqualityComparer<string>.Default.Equals(_Output_k__BackingField, other._Output_k__BackingField);
					}
					break;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public void Deconstruct(out int ExitCode, out string Output)
		{
			//IL_0008: Expected I8, but got O
			ExitCode = this.ExitCode;
			Output = this.Output;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool IRKgWSLqbjNJGUfj9NsW()
		{
			return xwHOECL2zA23rvNrrLOu == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object hYkCWnLqX08Tyb7rqRYb()
		{
			return xwHOECL2zA23rvNrrLOu;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _CompileAsync_d__0 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<string> __t__builder;

		public string pythonPath;

		public string scriptPath;

		public string sourceDirectory;

		public CancellationToken cancellationToken;

		public string outputDirectory;

		private ConfiguredTaskAwaitable<ProcessResult>.ConfiguredTaskAwaiter __u__1;

		internal static object fsaV5ULqflFeGnOwXfqD;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_000c: Expected O, but got I4
			//IL_0025: Expected I4, but got O
			//IL_0934: Expected I4, but got O
			//IL_0075: Expected O, but got I4
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_0238: Expected O, but got Unknown
			//IL_04aa: Expected O, but got I4
			//IL_046e: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_078f: Unknown result type (might be due to invalid IL or missing references)
			//IL_04be: Expected O, but got I4
			//IL_037d: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f3: Expected O, but got Unknown
			//IL_051f: Unknown result type (might be due to invalid IL or missing references)
			//IL_030a: Unknown result type (might be due to invalid IL or missing references)
			//IL_05da: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e1: Expected O, but got Unknown
			//IL_05a5: Expected O, but got I4
			//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0838: Unknown result type (might be due to invalid IL or missing references)
			//IL_0330: Unknown result type (might be due to invalid IL or missing references)
			//IL_0337: Expected O, but got Unknown
			//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0715: Expected O, but got I4
			//IL_00cc: Expected O, but got I4
			//IL_0800: Unknown result type (might be due to invalid IL or missing references)
			//IL_080b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0812: Expected O, but got Unknown
			//IL_017d: Expected I4, but got O
			//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_08da: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e1: Expected O, but got Unknown
			//IL_0906->IL0923: Incompatible stack types: I4 vs O
			//IL_0911->IL0923: Incompatible stack types: I4 vs O
			//IL_098f->IL0923: Incompatible stack types: I4 vs O
			//IL_0968->IL0923: Incompatible stack types: I4 vs O
			//IL_099a->IL0923: Incompatible stack types: I4 vs O
			//IL_0973->IL0923: Incompatible stack types: I4 vs O
			//IL_0089->IL0010: Incompatible stack types: I4 vs O
			//IL_0062->IL0010: Incompatible stack types: I4 vs O
			//IL_0094->IL0010: Incompatible stack types: I4 vs O
			//IL_006d->IL0010: Incompatible stack types: I4 vs O
			//IL_00be->IL00d0: Incompatible stack types: I4 vs O
			//IL_0242->IL00d0: Incompatible stack types: I4 vs O
			//IL_049a->IL00d0: Incompatible stack types: I4 vs O
			//IL_04a5->IL00d0: Incompatible stack types: I4 vs O
			//IL_061f->IL00d0: Incompatible stack types: I4 vs O
			//IL_02bf->IL00d0: Incompatible stack types: I4 vs O
			//IL_04b9->IL00d0: Incompatible stack types: I4 vs O
			//IL_047e->IL00d0: Incompatible stack types: I4 vs O
			//IL_03ef->IL00d0: Incompatible stack types: I4 vs O
			//IL_04d7->IL00d0: Incompatible stack types: I4 vs O
			//IL_0459->IL00d0: Incompatible stack types: I4 vs O
			//IL_021d->IL00d0: Incompatible stack types: I4 vs O
			//IL_05fd->IL00d0: Incompatible stack types: I4 vs O
			//IL_0323->IL00d0: Incompatible stack types: I4 vs O
			//IL_05eb->IL00d0: Incompatible stack types: I4 vs O
			//IL_05b4->IL00d0: Incompatible stack types: I4 vs O
			//IL_0283->IL00d0: Incompatible stack types: I4 vs O
			//IL_02e6->IL00d0: Incompatible stack types: I4 vs O
			//IL_0427->IL00d0: Incompatible stack types: I4 vs O
			//IL_0591->IL00d0: Incompatible stack types: I4 vs O
			//IL_034b->IL00d0: Incompatible stack types: I4 vs O
			//IL_0307->IL00d0: Incompatible stack types: I4 vs O
			//IL_062a->IL00d0: Incompatible stack types: I4 vs O
			//IL_02ca->IL00d0: Incompatible stack types: I4 vs O
			//IL_056f->IL00d0: Incompatible stack types: I4 vs O
			//IL_0640->IL00d0: Incompatible stack types: I4 vs O
			//IL_04e2->IL00d0: Incompatible stack types: I4 vs O
			//IL_073a->IL00d0: Incompatible stack types: I4 vs O
			//IL_032e->IL00d0: Incompatible stack types: I4 vs O
			//IL_028e->IL00d0: Incompatible stack types: I4 vs O
			//IL_02f1->IL00d0: Incompatible stack types: I4 vs O
			//IL_04f8->IL00d0: Incompatible stack types: I4 vs O
			//IL_0261->IL00d0: Incompatible stack types: I4 vs O
			//IL_0356->IL00d0: Incompatible stack types: I4 vs O
			//IL_068c->IL00d0: Incompatible stack types: I4 vs O
			//IL_03ac->IL00d0: Incompatible stack types: I4 vs O
			//IL_0710->IL00d0: Incompatible stack types: I4 vs O
			//IL_054e->IL00d0: Incompatible stack types: I4 vs O
			//IL_0697->IL00d0: Incompatible stack types: I4 vs O
			//IL_081c->IL00d0: Incompatible stack types: I4 vs O
			//IL_03b7->IL00d0: Incompatible stack types: I4 vs O
			//IL_0559->IL00d0: Incompatible stack types: I4 vs O
			//IL_08eb->IL00d0: Incompatible stack types: I4 vs O
			int num = 1;
			dynamic obj3 = default(object);
			object obj6 = default(object);
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler obj7 = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
			dynamic result2 = default(object);
			object obj5 = default(object);
			object obj8 = default(object);
			dynamic output = default(object);
			dynamic result = default(object);
			object obj10 = default(object);
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
								goto case 0;
							}
							return;
						case 3:
							__1__state = -2;
							obj2 = 2;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_30453b5c95424721b20dac45933b18fc == 0)
							{
								obj2 = 8;
							}
							continue;
						case 1:
							obj3 = __1__state;
							obj2 = 7;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_527dac5507ee46fcb9d22f9ff955c1d0 == 0)
							{
								obj2 = 0;
							}
							continue;
						case 2:
							break;
						case 0:
							try
							{
								object obj4;
								if (obj3 == null)
								{
									obj4 = 28;
									goto IL_00d0;
								}
								goto IL_047e;
								IL_047e:
								if ((nint)obj3 != 1)
								{
									obj4 = 27;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9201b2a1b9374af3a02f4d68ff67dfea == 0)
									{
										obj4 = 34;
									}
									goto IL_00d0;
								}
								goto IL_0230;
								IL_00d0:
								while (true)
								{
									int num2;
									switch ((int)obj4)
									{
									case 19:
										return;
									case 35:
										return;
									default:
										if ((nint)obj6 == 49)
										{
											goto IL_021d;
										}
										if ((nint)obj6 == 1029)
										{
											goto IL_00cc;
										}
										goto case 13;
									case 17:
										obj7.AppendLiteral("Python 编译失败（退出码 ");
										obj4 = 24;
										continue;
									case 15:
										break;
									case 34:
										if (System.IO.File.Exists(pythonPath))
										{
											obj4 = 31;
											continue;
										}
										goto case 20;
									case 24:
										obj7.AppendFormatted<int>((int)((dynamic)result2).ExitCode);
										obj4 = 35;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_d2995c01469b4ef28b5784f7cbf606e2 != 0)
										{
											obj4 = 13;
										}
										continue;
									case 1:
										__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<ProcessResult>.ConfiguredTaskAwaiter, _CompileAsync_d__0>(ref *(ConfiguredTaskAwaitable<ProcessResult>.ConfiguredTaskAwaiter*)(&obj5), ref this);
										obj4 = 19;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_dbb7d0b4e7ca46959ea177dcc91c1f0e == 0)
										{
											obj4 = 2;
										}
										continue;
									case 25:
										__u__1 = (ConfiguredTaskAwaitable<ProcessResult>.ConfiguredTaskAwaiter)obj5;
										obj4 = 0;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_dabc6698d5764018a5f86ef3b5a7871e == 0)
										{
											obj4 = 14;
										}
										continue;
									case 39:
										__u__1 = default(ConfiguredTaskAwaitable<ProcessResult>.ConfiguredTaskAwaiter);
										obj4 = 11;
										continue;
									case 21:
										__u__1 = (ConfiguredTaskAwaitable<ProcessResult>.ConfiguredTaskAwaiter)obj5;
										obj4 = 37;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4ae4de12ce674c26bc2939a5789df8ab == 0)
										{
											obj4 = 1;
										}
										continue;
									case 37:
										obj5 = ((ConfiguredTaskAwaitable<ProcessResult>*)(&obj8))->GetAwaiter();
										obj4 = 5;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e8864409e70b4d87b4c6598763ad15be == 0)
										{
											obj4 = 33;
										}
										continue;
									case 14:
										throw new FileNotFoundException("Python 编译脚本不存在", scriptPath);
									case 4:
										goto IL_0383;
									case 6:
										throw new InvalidOperationException(obj7.ToStringAndClear());
									case 30:
										output = ((dynamic)result2).Output;
										num2 = 12;
										goto IL_00c8;
									case 10:
										result = __u__1.GetResult();
										obj4 = 16;
										continue;
									case 33:
										obj7 = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(18, 2);
										obj4 = 17;
										continue;
									case 13:
										obj7.AppendLiteral("）：");
										obj4 = 36;
										continue;
									case 3:
										__u__1 = default(ConfiguredTaskAwaitable<ProcessResult>.ConfiguredTaskAwaiter);
										obj4 = 41;
										continue;
									case 9:
										goto IL_047e;
									case 2:
										obj3 = 1;
										__1__state = 1;
										obj4 = 25;
										continue;
									case 11:
										obj3 = -1;
										__1__state = -1;
										obj4 = 10;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b6e1b24306c5435497967d798ce571fb == 0)
										{
											obj4 = 25;
										}
										continue;
									case 27:
										if (((dynamic)result2).ExitCode == 0)
										{
											obj4 = 30;
											continue;
										}
										goto case 33;
									case 20:
										throw new FileNotFoundException("Python 2.7 可执行文件不存在", pythonPath);
									case 31:
										if (System.IO.File.Exists(scriptPath))
										{
											obj4 = 4;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0b81b3b6b3bc4c4a8075444d576cb8ec == 0)
											{
												obj4 = 0;
											}
											continue;
										}
										goto case 14;
									case 5:
										if (!__u__1.IsCompleted)
										{
											obj4 = 2;
											continue;
										}
										goto IL_021d;
									case 36:
										obj7.AppendFormatted(TrimOutput((string)((dynamic)result2).Output));
										obj4 = 6;
										continue;
									case 23:
										obj3 = 0;
										__1__state = 0;
										obj4 = 21;
										continue;
									case 22:
										obj5 = ((ConfiguredTaskAwaitable<ProcessResult>*)(&obj8))->GetAwaiter();
										obj4 = 8;
										continue;
									case 18:
									case 28:
										obj5 = __u__1;
										obj4 = 39;
										continue;
									case 0:
										__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<ProcessResult>.ConfiguredTaskAwaiter, _CompileAsync_d__0>(ref *(ConfiguredTaskAwaitable<ProcessResult>.ConfiguredTaskAwaiter*)(&obj5), ref this);
										obj4 = 5;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0d16903d89da4928a5d60c2843281188 == 0)
										{
											obj4 = 35;
										}
										continue;
									case 8:
										if (!__u__1.IsCompleted)
										{
											obj4 = 23;
											continue;
										}
										goto case 10;
									case 38:
										if ((((dynamic)result).Output).Contains("2.7", (StringComparison)4))
										{
											obj4 = 29;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2b2f512a98d548488e5242742b1ff011 != 0)
											{
												obj4 = 19;
											}
											continue;
										}
										goto case 32;
									case 32:
									case 40:
										throw new InvalidOperationException(string.Concat("必须使用 Python 2.7，当前解释器检测失败：", TrimOutput(((dynamic)result).Output)));
									case 29:
										goto IL_06ce;
									case 41:
										obj3 = -1;
										__1__state = -1;
										num2 = 49;
										goto IL_00c8;
									case 16:
										if (((dynamic)result).ExitCode != 0)
										{
											obj4 = 32;
											continue;
										}
										goto case 38;
									case 7:
										throw new DirectoryNotFoundException(string.Concat("源码目录不存在：", sourceDirectory));
									case 26:
										throw new InvalidOperationException("MCP 构建要求 x64 Python 2.7");
									case 12:
										goto end_IL_00ad;
										IL_00cc:
										obj4 = obj6;
										continue;
										IL_021d:
										result2 = __u__1.GetResult();
										num2 = 27;
										goto IL_00c8;
										IL_00c8:
										obj6 = num2;
										goto IL_00cc;
									}
									break;
									IL_06ce:
									if (!((((dynamic)result).Output).Contains("64-bit", (StringComparison)4)))
									{
										obj4 = 26;
										continue;
									}
									obj8 = RunAsync(pythonPath, new string[5]
									{
										scriptPath,
										"--source-root",
										sourceDirectory,
										"--output-root",
										outputDirectory
									}, System.IO.Path.GetDirectoryName(scriptPath) ?? System.AppContext.BaseDirectory, cancellationToken).ConfigureAwait(false);
									obj4 = 37;
									continue;
									IL_0383:
									if (!System.IO.Directory.Exists(sourceDirectory))
									{
										obj4 = 7;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_a4b5b9d8fe0344d0a0d0c6ee7728050b != 0)
										{
											obj4 = 31;
										}
									}
									else
									{
										obj8 = RunAsync(pythonPath, new string[2]
										{
											"-c",
											"import struct,sys; print('%d.%d %d-bit' % (sys.version_info[0], sys.version_info[1], struct.calcsize('P') * 8))"
										}, System.IO.Path.GetDirectoryName(pythonPath) ?? System.AppContext.BaseDirectory, cancellationToken).ConfigureAwait(false);
										obj4 = 22;
									}
								}
								goto IL_0230;
								IL_0230:
								obj5 = __u__1;
								obj4 = 3;
								goto IL_00d0;
								end_IL_00ad:;
							}
							catch (global::System.Exception exception)
							{
								object obj9 = 0;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ee050290791c4dfbba3a13b8d87cc1bd != 0)
								{
									obj9 = 4;
								}
								while (true)
								{
									switch ((int)obj9)
									{
									case 2:
										return;
									default:
										if ((nint)obj10 == 990)
										{
											obj9 = obj10;
											continue;
										}
										break;
									case 1:
										__t__builder.SetException(exception);
										obj9 = 1;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9201b2a1b9374af3a02f4d68ff67dfea == 0)
										{
											obj9 = 2;
										}
										continue;
									case 0:
										break;
									}
									__1__state = -2;
									obj9 = 5;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7d96de295fba4e09a034ce1853831e68 == 0)
									{
										obj9 = 1;
									}
								}
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
				__t__builder.SetResult((string)output);
				num = 10;
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
			do
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 1:
						__t__builder.SetStateMachine(stateMachine);
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_31a06ac266364bee8fef51fc97395192 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 0:
						return;
					}
					break;
				}
			}
			while ((nint)obj == 989);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool QGR6FyLqL76nmOM55nT6()
		{
			return fsaV5ULqflFeGnOwXfqD == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object lhwEuXLqjTh4ijhEgqjT()
		{
			return fsaV5ULqflFeGnOwXfqD;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _RunAsync_d__1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<ProcessResult> __t__builder;

		public string executable;

		public string workingDirectory;

		public global::System.Collections.Generic.IEnumerable<string> arguments;

		public CancellationToken cancellationToken;

		private Process _process_5__2;

		private global::System.Threading.Tasks.Task<string> _stdout_5__3;

		private global::System.Threading.Tasks.Task<string> _stderr_5__4;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1;

		private string __7__wrap4;

		private string __7__wrap5;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__2;

		internal static object BUCdnTLqZcEqsCLdyh1g;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_000c: Expected O, but got I4
			//IL_0f3c: Expected O, but got I4
			//IL_0031: Expected I4, but got O
			//IL_0d95: Expected I4, but got O
			//IL_0c83: Expected I4, but got O
			//IL_106b: Expected O, but got I4
			//IL_0317: Expected I4, but got O
			//IL_0ea6: Expected I4, but got O
			//IL_0f59: Expected I4, but got O
			//IL_00bf: Expected O, but got I4
			//IL_0cee: Expected I4, but got O
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_0156: Expected O, but got Unknown
			//IL_0156: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Expected O, but got Unknown
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_0173: Expected O, but got Unknown
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Expected O, but got Unknown
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Expected O, but got Unknown
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Expected O, but got Unknown
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Expected O, but got Unknown
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Expected O, but got Unknown
			//IL_01c3: Expected O, but got Unknown
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Expected O, but got Unknown
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Expected O, but got Unknown
			//IL_0121: Expected O, but got Unknown
			//IL_00dc: Expected I4, but got O
			//IL_03ef: Expected I4, but got O
			//IL_0523: Unknown result type (might be due to invalid IL or missing references)
			//IL_052a: Expected O, but got Unknown
			//IL_0e11: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e18: Expected O, but got Unknown
			//IL_041c: Expected O, but got I4
			//IL_0914: Unknown result type (might be due to invalid IL or missing references)
			//IL_091b: Expected O, but got Unknown
			//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f2: Expected O, but got Unknown
			//IL_0962: Unknown result type (might be due to invalid IL or missing references)
			//IL_0594: Unknown result type (might be due to invalid IL or missing references)
			//IL_059b: Expected O, but got Unknown
			//IL_08ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f4: Expected O, but got Unknown
			//IL_0a46: Expected O, but got I4
			//IL_057d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0903: Expected O, but got I4
			//IL_0539: Expected O, but got I4
			//IL_08c2: Expected O, but got I4
			//IL_0899: Unknown result type (might be due to invalid IL or missing references)
			//IL_0200: Expected O, but got I4
			//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0940: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ad: Expected I4, but got O
			//IL_0c19: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c2e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c35: Expected O, but got Unknown
			//IL_0215: Expected I4, but got O
			//IL_0bdc: Expected O, but got I4
			//IL_0b72: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b5e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b65: Expected O, but got Unknown
			//IL_0ad4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0adb: Expected O, but got Unknown
			//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b32: Expected O, but got I4
			//IL_0a75: Expected O, but got I4
			//IL_0650: Expected I4, but got O
			//IL_0ab2: Expected I4, but got O
			//IL_0d6f->IL0d8c: Incompatible stack types: I4 vs O
			//IL_0c59->IL0c76: Incompatible stack types: I4 vs O
			//IL_0f2e->IL0f40: Incompatible stack types: I4 vs O
			//IL_02e1->IL02fe: Incompatible stack types: I4 vs O
			//IL_0d7a->IL0d8c: Incompatible stack types: I4 vs O
			//IL_0c64->IL0c76: Incompatible stack types: I4 vs O
			//IL_0e74->IL0e91: Incompatible stack types: I4 vs O
			//IL_034a->IL02fe: Incompatible stack types: I4 vs O
			//IL_0394->IL02fe: Incompatible stack types: I4 vs O
			//IL_02ec->IL02fe: Incompatible stack types: I4 vs O
			//IL_0e7f->IL0e91: Incompatible stack types: I4 vs O
			//IL_0fd2->IL0f40: Incompatible stack types: I4 vs O
			//IL_0fa6->IL0f40: Incompatible stack types: I4 vs O
			//IL_100a->IL0f40: Incompatible stack types: I4 vs O
			//IL_0355->IL02fe: Incompatible stack types: I4 vs O
			//IL_039f->IL02fe: Incompatible stack types: I4 vs O
			//IL_0f16->IL0e91: Incompatible stack types: I4 vs O
			//IL_0fdd->IL0f40: Incompatible stack types: I4 vs O
			//IL_0fb1->IL0f40: Incompatible stack types: I4 vs O
			//IL_1015->IL0f40: Incompatible stack types: I4 vs O
			//IL_0fee->IL0f40: Incompatible stack types: I4 vs O
			//IL_0d4a->IL0cdd: Incompatible stack types: I4 vs O
			//IL_0cc0->IL0cdd: Incompatible stack types: I4 vs O
			//IL_0ece->IL0e91: Incompatible stack types: I4 vs O
			//IL_0f21->IL0e91: Incompatible stack types: I4 vs O
			//IL_107f->IL0010: Incompatible stack types: I4 vs O
			//IL_109b->IL0010: Incompatible stack types: I4 vs O
			//IL_0093->IL0010: Incompatible stack types: I4 vs O
			//IL_0d55->IL0cdd: Incompatible stack types: I4 vs O
			//IL_0ccb->IL0cdd: Incompatible stack types: I4 vs O
			//IL_108a->IL0010: Incompatible stack types: I4 vs O
			//IL_009e->IL0010: Incompatible stack types: I4 vs O
			//IL_00b1->IL00c3: Incompatible stack types: I4 vs O
			//IL_03d0->IL00c3: Incompatible stack types: I4 vs O
			//IL_01d7->IL00c3: Incompatible stack types: I4 vs O
			//IL_0135->IL00c3: Incompatible stack types: I4 vs O
			//IL_01e2->IL00c3: Incompatible stack types: I4 vs O
			//IL_0140->IL00c3: Incompatible stack types: I4 vs O
			//IL_02b5->IL0204: Incompatible stack types: I4 vs O
			//IL_025b->IL0204: Incompatible stack types: I4 vs O
			//IL_097c->IL0420: Incompatible stack types: I4 vs O
			//IL_0534->IL0420: Incompatible stack types: I4 vs O
			//IL_0403->IL0420: Incompatible stack types: I4 vs O
			//IL_02c0->IL0204: Incompatible stack types: I4 vs O
			//IL_0266->IL0204: Incompatible stack types: I4 vs O
			//IL_040e->IL0420: Incompatible stack types: I4 vs O
			//IL_092f->IL0420: Incompatible stack types: I4 vs O
			//IL_0a0c->IL0420: Incompatible stack types: I4 vs O
			//IL_05fc->IL0420: Incompatible stack types: I4 vs O
			//IL_0e10->IL0420: Incompatible stack types: I4 vs O
			//IL_0971->IL0420: Incompatible stack types: I4 vs O
			//IL_05af->IL0420: Incompatible stack types: I4 vs O
			//IL_056c->IL0420: Incompatible stack types: I4 vs O
			//IL_08fe->IL0420: Incompatible stack types: I4 vs O
			//IL_0e48->IL0420: Incompatible stack types: I4 vs O
			//IL_04e1->IL0420: Incompatible stack types: I4 vs O
			//IL_09a0->IL0420: Incompatible stack types: I4 vs O
			//IL_05d1->IL0420: Incompatible stack types: I4 vs O
			//IL_05e9->IL0420: Incompatible stack types: I4 vs O
			//IL_09b8->IL0420: Incompatible stack types: I4 vs O
			//IL_058d->IL0420: Incompatible stack types: I4 vs O
			//IL_0912->IL0420: Incompatible stack types: I4 vs O
			//IL_0a1d->IL0420: Incompatible stack types: I4 vs O
			//IL_0e33->IL0420: Incompatible stack types: I4 vs O
			//IL_0548->IL0420: Incompatible stack types: I4 vs O
			//IL_08db->IL0420: Incompatible stack types: I4 vs O
			//IL_08b2->IL0420: Incompatible stack types: I4 vs O
			//IL_093a->IL0420: Incompatible stack types: I4 vs O
			//IL_05ba->IL0420: Incompatible stack types: I4 vs O
			//IL_0577->IL0420: Incompatible stack types: I4 vs O
			//IL_0e53->IL0420: Incompatible stack types: I4 vs O
			//IL_0501->IL0420: Incompatible stack types: I4 vs O
			//IL_0626->IL0643: Incompatible stack types: I4 vs O
			//IL_0522->IL0420: Incompatible stack types: I4 vs O
			//IL_08e6->IL0420: Incompatible stack types: I4 vs O
			//IL_08bd->IL0420: Incompatible stack types: I4 vs O
			//IL_0950->IL0420: Incompatible stack types: I4 vs O
			//IL_0c3f->IL0a79: Incompatible stack types: I4 vs O
			//IL_0a67->IL0a79: Incompatible stack types: I4 vs O
			//IL_050c->IL0420: Incompatible stack types: I4 vs O
			//IL_0631->IL0643: Incompatible stack types: I4 vs O
			//IL_0beb->IL0a79: Incompatible stack types: I4 vs O
			//IL_0b81->IL0a79: Incompatible stack types: I4 vs O
			//IL_0b6f->IL0a79: Incompatible stack types: I4 vs O
			//IL_0aef->IL0a79: Incompatible stack types: I4 vs O
			//IL_0ba1->IL0a79: Incompatible stack types: I4 vs O
			//IL_0b41->IL0a79: Incompatible stack types: I4 vs O
			//IL_0bcc->IL0a79: Incompatible stack types: I4 vs O
			//IL_0b5c->IL0a79: Incompatible stack types: I4 vs O
			//IL_0afa->IL0a79: Incompatible stack types: I4 vs O
			//IL_0bac->IL0a79: Incompatible stack types: I4 vs O
			//IL_0bd7->IL0a79: Incompatible stack types: I4 vs O
			int num = 1;
			dynamic result = default(object);
			dynamic obj3 = default(object);
			object obj5 = default(object);
			object obj23 = default(object);
			object obj12 = default(object);
			dynamic result2 = default(object);
			object obj24 = default(object);
			object obj26 = default(object);
			object output = default(object);
			ConfiguredTaskAwaitable obj14 = default(ConfiguredTaskAwaitable);
			object obj16 = default(object);
			ConfiguredTaskAwaitable.ConfiguredTaskAwaiter obj15 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
			object obj22 = default(object);
			object obj19 = default(object);
			object obj21 = default(object);
			object obj28 = default(object);
			dynamic obj7 = default(object);
			dynamic enumerator = default(object);
			object current = default(object);
			object obj8 = default(object);
			object obj10 = default(object);
			object obj30 = default(object);
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
								goto case 1;
							}
							__t__builder.SetResult((ProcessResult)result);
							num = 2;
							break;
						case 3:
							_stderr_5__4 = null;
							num = 11;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f3d80f367d504e3d9064e4cfb99ce343 == 0)
							{
								num = 13;
							}
							break;
						case 5:
							_stdout_5__3 = null;
							obj2 = 3;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_dabc6698d5764018a5f86ef3b5a7871e == 0)
							{
								obj2 = 13;
							}
							continue;
						case 0:
							try
							{
								object obj4;
								if ((nuint)(nint)obj3 > (nuint)2u)
								{
									obj4 = 2;
									goto IL_00c3;
								}
								goto IL_03d0;
								IL_00bf:
								obj4 = obj5;
								goto IL_00c3;
								IL_00c3:
								while (true)
								{
									switch ((int)obj4)
									{
									default:
										if ((nint)obj5 != 12)
										{
											if ((nint)obj5 == 992)
											{
												goto IL_00bf;
											}
											goto case 4;
										}
										try
										{
											object obj11;
											int num3;
											switch ((int)obj3)
											{
											default:
												obj11 = 12;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_80d00e736d0b4f7dbce583e459774a86 == 0)
												{
													obj11 = 15;
												}
												goto IL_0420;
											case 1:
												obj23 = __u__2;
												obj11 = 27;
												goto IL_0420;
											case 0:
												goto IL_0971;
											case 2:
												goto IL_0e10;
												IL_041c:
												obj11 = obj12;
												goto IL_0420;
												IL_0420:
												while (true)
												{
													switch ((int)obj11)
													{
													case 8:
													case 17:
														result2 = __u__2.GetResult();
														obj11 = 19;
														continue;
													case 22:
														if (__u__2.IsCompleted)
														{
															obj11 = 39;
															if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4967aebcec78421b855bda2f45c82247 == 0)
															{
																obj11 = 8;
															}
															continue;
														}
														goto case 32;
													case 25:
														if (!__u__2.IsCompleted)
														{
															obj11 = 14;
															continue;
														}
														goto case 20;
													case 3:
														goto end_IL_0420;
													case 31:
														obj3 = -1;
														__1__state = -1;
														obj11 = 20;
														continue;
													case 11:
														__7__wrap5 = System.Environment.NewLine;
														obj11 = 6;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e3c72d365c184d8193f0594ab3fd4d1f == 0)
														{
															obj11 = 10;
														}
														continue;
													case 27:
														__u__2 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
														obj11 = 31;
														continue;
													case 10:
														obj24 = _stderr_5__4.ConfigureAwait(false);
														obj11 = 0;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2aab0405e3774254ad8ff3552d808a1d == 0)
														{
															obj11 = 17;
														}
														continue;
													case 20:
														__7__wrap4 = __u__2.GetResult();
														obj11 = 11;
														continue;
													case 24:
														__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, _RunAsync_d__1>(ref *(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter*)(&obj23), ref this);
														obj11 = 16;
														continue;
													case 2:
														obj23 = ((ConfiguredTaskAwaitable<string>*)(&obj24))->GetAwaiter();
														obj11 = 25;
														continue;
													case 23:
														if ((_process_5__2).Start())
														{
															object obj25 = 5;
															if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_84adde53dc7e4a5fa7522d701cb0013d == 0)
															{
																obj25 = 1;
															}
															while (true)
															{
																switch ((int)obj25)
																{
																default:
																	if ((nint)obj26 == 989)
																	{
																		obj25 = obj26;
																		continue;
																	}
																	goto IL_09e2;
																case 0:
																	break;
																case 1:
																	goto IL_09e2;
																}
																break;
															}
														}
														throw new InvalidOperationException(string.Concat("无法启动构建工具：", executable));
													case 4:
														return;
													case 33:
														__u__2 = (ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter)obj23;
														obj11 = 26;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9a1f67b15040430199ec9dc1289e168b == 0)
														{
															obj11 = 28;
														}
														continue;
													case 32:
														obj3 = 2;
														__1__state = 2;
														obj11 = 33;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2ee4c54a6c424cb680cd9d0811cd1011 == 0)
														{
															obj11 = 33;
														}
														continue;
													case 12:
														obj24 = _stdout_5__3.ConfigureAwait(false);
														obj11 = 2;
														continue;
													case 28:
														obj3 = -1;
														__1__state = -1;
														obj11 = 17;
														continue;
													case 0:
														obj23 = ((ConfiguredTaskAwaitable<string>*)(&obj24))->GetAwaiter();
														obj11 = 8;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_cc5bd43d70674cf481f40e84bf27aa89 == 0)
														{
															obj11 = 22;
														}
														continue;
													case 9:
														__u__2 = (ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter)obj23;
														obj11 = 24;
														continue;
													case 5:
														goto IL_0971;
													case 19:
														output = string.Concat(__7__wrap4, __7__wrap5, (string)result2);
														obj11 = 30;
														continue;
													case 26:
														__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, _RunAsync_d__1>(ref *(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter*)(&obj23), ref this);
														obj11 = 4;
														continue;
													case 13:
														goto IL_09b8;
													case 1:
														goto IL_09e2;
													case 29:
														__7__wrap5 = null;
														obj11 = 7;
														continue;
													case 16:
														return;
													case 14:
														goto IL_0a41;
													case 6:
														try
														{
															object obj13;
															if (obj3 == null)
															{
																obj13 = 12;
																goto IL_0a79;
															}
															goto IL_0c12;
															IL_0c12:
															obj14 = ((_process_5__2).WaitForExitAsync(cancellationToken)).ConfigureAwait(false);
															obj13 = 6;
															goto IL_0a79;
															IL_0a79:
															while (true)
															{
																switch ((int)obj13)
																{
																default:
																	if ((nint)obj16 != 20)
																	{
																		if ((nint)obj16 == 1000)
																		{
																			goto IL_0a75;
																		}
																		goto case 7;
																	}
																	return;
																case 7:
																case 12:
																	obj15 = __u__1;
																	obj13 = 8;
																	if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_499faaea7a6445f1af0f623e48ebbb18 == 0)
																	{
																		obj13 = 7;
																	}
																	continue;
																case 10:
																	obj3 = 0;
																	__1__state = 0;
																	obj13 = 2;
																	continue;
																case 3:
																	if (((dynamic)obj15).IsCompleted)
																	{
																		obj13 = 5;
																		continue;
																	}
																	goto case 10;
																case 6:
																	obj15 = obj14.GetAwaiter();
																	obj13 = 3;
																	continue;
																case 2:
																	__u__1 = obj15;
																	obj13 = 9;
																	continue;
																case 8:
																	__u__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
																	obj13 = 0;
																	if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_6883c26806134cb3b7f5e7b631c19374 != 0)
																	{
																		obj13 = 14;
																	}
																	continue;
																case 5:
																case 11:
																	((dynamic)obj15).GetResult();
																	obj13 = 1;
																	if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_28a8309f77124973ab9263f59df1f564 == 0)
																	{
																		obj13 = 5;
																	}
																	continue;
																case 0:
																	obj3 = -1;
																	__1__state = -1;
																	obj13 = 11;
																	continue;
																case 9:
																	__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, _RunAsync_d__1>(ref obj15, ref this);
																	obj16 = 20;
																	goto IL_0a75;
																case 4:
																	break;
																case 1:
																	goto end_IL_0a79;
																	IL_0a75:
																	obj13 = obj16;
																	continue;
																}
																goto IL_0c12;
																continue;
																end_IL_0a79:
																break;
															}
														}
														catch (global::System.Exception)
														{
															object obj17 = 0;
															if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_8cd7f54b623a4d42b1a5e008c75a22ed == 0)
															{
																obj17 = 2;
															}
															while (true)
															{
																switch ((int)obj17)
																{
																default:
																	if ((nint)obj22 == 989)
																	{
																		goto IL_0c72;
																	}
																	break;
																case 0:
																	try
																	{
																		object obj18;
																		if ((_process_5__2).HasExited)
																		{
																			obj18 = 5;
																			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5144ebdc507c41fb87d88fdce3dc76e9 != 0)
																			{
																				obj18 = 1;
																			}
																			goto IL_0cdd;
																		}
																		goto IL_0d25;
																		IL_0cdd:
																		while (true)
																		{
																			switch ((int)obj18)
																			{
																			default:
																				if ((nint)obj19 == 990)
																				{
																					goto IL_0cd9;
																				}
																				goto end_IL_0cdd;
																			case 1:
																				goto end_IL_0cdd;
																			case 2:
																				break;
																			case 0:
																				goto end_IL_0cdd;
																			}
																			goto IL_0d25;
																			IL_0cd9:
																			obj18 = obj19;
																			continue;
																			end_IL_0cdd:
																			break;
																		}
																		goto end_IL_0c97;
																		IL_0d25:
																		(_process_5__2).Kill(true);
																		obj18 = 0;
																		if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_12ecff64eea14fe694da7ba4fdd3c628 != 0)
																		{
																			obj18 = 0;
																		}
																		goto IL_0cdd;
																		end_IL_0c97:;
																	}
																	catch (global::System.Exception)
																	{
																		object obj20 = 0;
																		if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0609736616ee48cfa58bcf48cbf884e3 != 0)
																		{
																			obj20 = 4;
																		}
																		while (true)
																		{
																			switch ((int)obj20)
																			{
																			default:
																				if ((nint)obj21 == 988)
																				{
																					obj20 = obj21;
																					continue;
																				}
																				break;
																			case 0:
																				break;
																			}
																			break;
																		}
																	}
																	break;
																case 1:
																	break;
																}
																break;
																IL_0c72:
																obj17 = obj22;
															}
															throw new global::System.Exception();
														}
														goto case 12;
													case 7:
														result = (object)new ProcessResult((_process_5__2).ExitCode, (string)output);
														obj11 = 21;
														continue;
													case 18:
														goto IL_0e10;
													case 30:
														goto IL_0e22;
													case 15:
														obj11 = 1;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_d9c10084bf5f4a9f947702ad63bef067 == 0)
														{
															obj11 = 23;
														}
														continue;
													case 21:
														goto end_IL_03de;
														IL_09e2:
														_stdout_5__3 = ((_process_5__2).StandardOutput).ReadToEndAsync();
														obj11 = 13;
														continue;
													}
													if ((nint)obj12 != 41)
													{
														if ((nint)obj12 == 1021)
														{
															goto IL_041c;
														}
														goto IL_0e22;
													}
													__u__2 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
													obj11 = 28;
													continue;
													IL_0e22:
													__7__wrap4 = null;
													obj11 = 29;
													continue;
													end_IL_0420:
													break;
												}
												goto case 1;
												IL_0e10:
												obj23 = __u__2;
												num3 = 41;
												goto IL_0418;
												IL_0a41:
												obj3 = 1;
												__1__state = 1;
												num3 = 9;
												goto IL_0418;
												IL_09b8:
												_stderr_5__4 = ((_process_5__2).StandardError).ReadToEndAsync();
												num3 = 5;
												goto IL_0418;
												IL_0418:
												obj12 = num3;
												goto IL_041c;
												IL_0971:
												obj11 = 6;
												goto IL_0420;
												end_IL_03de:
												break;
											}
										}
										finally
										{
											if ((nint)obj3 < 0)
											{
												object obj27 = 2;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f9510a76595941f880645fdc764944eb != 0)
												{
													obj27 = 0;
												}
												while (true)
												{
													switch ((int)obj27)
													{
													default:
														if ((nint)obj28 == 991)
														{
															obj27 = obj28;
															continue;
														}
														goto end_IL_0e91;
													case 0:
														if (_process_5__2 == null)
														{
															obj27 = 2;
															continue;
														}
														break;
													case 2:
														goto end_IL_0e91;
													case 3:
														break;
													case 1:
														goto end_IL_0e91;
													}
													(_process_5__2).Dispose();
													obj27 = 5;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b6e1b24306c5435497967d798ce571fb != 0)
													{
														obj27 = 1;
													}
													continue;
													end_IL_0e91:
													break;
												}
											}
										}
										goto end_IL_009f;
									case 4:
									{
										Process val2 = new Process();
										((dynamic)val2).StartInfo = (ProcessStartInfo)obj7;
										((dynamic)val2).EnableRaisingEvents = true;
										_process_5__2 = val2;
										obj4 = 0;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_d9c10084bf5f4a9f947702ad63bef067 != 0)
										{
											obj4 = 0;
										}
										continue;
									}
									case 2:
									{
										ProcessStartInfo val = new ProcessStartInfo();
										((dynamic)val).FileName = executable;
										((dynamic)val).WorkingDirectory = workingDirectory;
										((dynamic)val).UseShellExecute = false;
										((dynamic)val).CreateNoWindow = true;
										((dynamic)val).RedirectStandardOutput = true;
										((dynamic)val).RedirectStandardError = true;
										((dynamic)val).StandardOutputEncoding = System.Text.Encoding.UTF8;
										((dynamic)val).StandardErrorEncoding = System.Text.Encoding.UTF8;
										obj7 = (object)val;
										obj4 = 1;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_70c2a79cb96d4e75a079385f00e7bf58 != 0)
										{
											obj4 = 4;
										}
										continue;
									}
									case 3:
										try
										{
											while (true)
											{
												IL_0236:
												object obj6;
												if (!((dynamic)enumerator).MoveNext())
												{
													obj6 = 1;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0cbd4cb78159400b923bd185c17f634c != 0)
													{
														obj6 = 3;
													}
													goto IL_0204;
												}
												goto IL_0298;
												IL_0298:
												current = ((global::System.Collections.Generic.IEnumerator<string>)enumerator).Current;
												obj6 = 0;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3054c4fc69b94a37b21ac42c2099175a == 0)
												{
													obj6 = 6;
												}
												goto IL_0204;
												IL_0204:
												while (true)
												{
													switch ((int)obj6)
													{
													default:
														goto IL_0215;
													case 0:
													{
														((dynamic)obj7).ArgumentList.Add((string)current);
														int num2 = 10;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5616e31a21b646f69463de8959779c49 == 0)
														{
															num2 = 10;
														}
														obj8 = num2;
														goto IL_0200;
													}
													case 2:
														break;
													case 1:
														goto end_IL_0204;
													}
													goto IL_0298;
													IL_0215:
													if ((nint)obj8 == 10)
													{
														goto IL_0236;
													}
													if ((nint)obj8 == 990)
													{
														goto IL_0200;
													}
													goto IL_0298;
													IL_0200:
													obj6 = obj8;
													continue;
													end_IL_0204:
													break;
												}
												break;
											}
										}
										finally
										{
											object obj9;
											if ((nint)obj3 >= 0)
											{
												obj9 = 9;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f1dd9923a6bd42d5867c8e2e591d3e3b != 0)
												{
													obj9 = 4;
												}
												goto IL_02fe;
											}
											goto IL_0379;
											IL_0379:
											if (enumerator == null)
											{
												obj9 = 1;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2ee4c54a6c424cb680cd9d0811cd1011 == 0)
												{
													obj9 = 0;
												}
												goto IL_02fe;
											}
											goto IL_032a;
											IL_032a:
											((dynamic)enumerator).Dispose();
											obj9 = 2;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_84adde53dc7e4a5fa7522d701cb0013d != 0)
											{
												obj9 = 6;
											}
											goto IL_02fe;
											IL_02fe:
											while (true)
											{
												switch ((int)obj9)
												{
												default:
													if ((nint)obj10 == 992)
													{
														obj9 = obj10;
														continue;
													}
													goto end_IL_02c5;
												case 3:
													break;
												case 4:
													goto end_IL_02c5;
												case 0:
													goto IL_0379;
												case 1:
													goto end_IL_02c5;
												case 2:
													goto end_IL_02c5;
												}
												break;
											}
											goto IL_032a;
											end_IL_02c5:;
										}
										goto case 4;
									case 1:
										enumerator = arguments.GetEnumerator();
										obj4 = 3;
										continue;
									case 0:
										break;
									}
									break;
								}
								goto IL_03d0;
								IL_03d0:
								obj5 = 12;
								goto IL_00bf;
								end_IL_009f:;
							}
							catch (global::System.Exception exception)
							{
								object obj29 = 4;
								while (true)
								{
									switch ((int)obj29)
									{
									default:
										if ((nint)obj30 != 12)
										{
											if ((nint)obj30 == 992)
											{
												goto IL_0f3c;
											}
											goto case 2;
										}
										_stderr_5__4 = null;
										obj29 = 2;
										break;
									case 1:
										_stdout_5__3 = null;
										obj30 = 12;
										goto IL_0f3c;
									case 3:
										_process_5__2 = null;
										obj29 = 1;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_07c1f539d4f94d95bde09a0fba07dbbc == 0)
										{
											obj29 = 1;
										}
										break;
									case 2:
										__t__builder.SetException(exception);
										obj29 = 11;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ef04e2823b234f2aa7c3630bcaafe597 == 0)
										{
											obj29 = 0;
										}
										break;
									case 4:
										__1__state = -2;
										obj29 = 3;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9a1f67b15040430199ec9dc1289e168b == 0)
										{
											obj29 = 11;
										}
										break;
									case 0:
										return;
										IL_0f3c:
										obj29 = obj30;
										break;
									}
								}
							}
							goto case 6;
						case 2:
							return;
						case 6:
							__1__state = -2;
							num = 4;
							break;
						case 1:
							obj3 = __1__state;
							obj2 = 0;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2b8232439dce49e49a3fdd295da14355 != 0)
							{
								obj2 = 11;
							}
							continue;
						case 4:
							_process_5__2 = null;
							obj2 = 5;
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
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_0050->IL0010: Incompatible stack types: I4 vs O
			//IL_005b->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			do
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 1:
						__t__builder.SetStateMachine(stateMachine);
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0b81b3b6b3bc4c4a8075444d576cb8ec == 0)
						{
							obj2 = 6;
						}
						continue;
					case 0:
						return;
					}
					break;
				}
			}
			while ((nint)obj == 989);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool O8LEp3Lq9DAPK3BcAnWJ()
		{
			return BUCdnTLqZcEqsCLdyh1g == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object s9Ws4vLqDarKLS4tNCuk()
		{
			return BUCdnTLqZcEqsCLdyh1g;
		}
	}

	internal static McpPythonCompiler DWVjCOLEbbxg4bqN3sPo;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public unsafe static global::System.Threading.Tasks.Task<string> CompileAsync(string pythonPath, string scriptPath, string sourceDirectory, string outputDirectory, CancellationToken cancellationToken)
	{
		//IL_000c: Expected O, but got I4
		//IL_0035: Expected I4, but got O
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d->IL0010: Incompatible stack types: I4 vs O
		//IL_015c->IL0010: Incompatible stack types: I4 vs O
		//IL_0072->IL0010: Incompatible stack types: I4 vs O
		//IL_00b7->IL0010: Incompatible stack types: I4 vs O
		//IL_00d3->IL0010: Incompatible stack types: I4 vs O
		//IL_0167->IL0010: Incompatible stack types: I4 vs O
		//IL_007d->IL0010: Incompatible stack types: I4 vs O
		//IL_00de->IL0010: Incompatible stack types: I4 vs O
		//IL_00fa->IL0010: Incompatible stack types: I4 vs O
		//IL_0105->IL0010: Incompatible stack types: I4 vs O
		int num = 2;
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
						((dynamic)obj3).outputDirectory = outputDirectory;
						obj2 = 6;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bd754e211a3740b7abeee191b9ceae68 == 0)
						{
							obj2 = 5;
						}
						continue;
					case 5:
						((dynamic)obj3).scriptPath = scriptPath;
						obj2 = 4;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1df8e086d5ed471cbc378d2545a921c6 != 0)
						{
							obj2 = 9;
						}
						continue;
					case 4:
						((dynamic)obj3).sourceDirectory = sourceDirectory;
						num = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_56220e0912894bf29c75280f6503f965 != 0)
						{
							num = 14;
						}
						break;
					case 6:
						((dynamic)obj3).cancellationToken = cancellationToken;
						obj2 = 7;
						continue;
					case 7:
						((dynamic)obj3).__1__state = -1;
						obj2 = 14;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_80d00e736d0b4f7dbce583e459774a86 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 0:
						((dynamic)obj3).__t__builder.Start<_CompileAsync_d__0>(ref obj3);
						obj2 = 3;
						continue;
					case 1:
						((dynamic)obj3).pythonPath = pythonPath;
						num = 5;
						break;
					case 3:
						return ((dynamic)obj3).__t__builder.Task;
					case 2:
						((dynamic)obj3).__t__builder = AsyncTaskMethodBuilder<string>.Create();
						obj2 = 1;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_6143552ba66645398402f7404618079f == 0)
						{
							obj2 = 5;
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task<ProcessResult> RunAsync(string executable, global::System.Collections.Generic.IEnumerable<string> arguments, string workingDirectory, CancellationToken cancellationToken)
	{
		//IL_000c: Expected O, but got I4
		//IL_0031: Expected I4, but got O
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2->IL0010: Incompatible stack types: I4 vs O
		//IL_0111->IL0010: Incompatible stack types: I4 vs O
		//IL_00ce->IL0010: Incompatible stack types: I4 vs O
		//IL_0095->IL0010: Incompatible stack types: I4 vs O
		//IL_012e->IL0010: Incompatible stack types: I4 vs O
		//IL_011c->IL0010: Incompatible stack types: I4 vs O
		//IL_00d9->IL0010: Incompatible stack types: I4 vs O
		//IL_00a0->IL0010: Incompatible stack types: I4 vs O
		//IL_00f1->IL0010: Incompatible stack types: I4 vs O
		int num = 1;
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
						if ((nint)obj != 13)
						{
							if ((nint)obj == 994)
							{
								goto end_IL_0010;
							}
							goto case 6;
						}
						((dynamic)obj3).__t__builder.Start<_RunAsync_d__1>(ref obj3);
						obj2 = 6;
						continue;
					case 2:
						break;
					case 4:
						((dynamic)obj3).workingDirectory = workingDirectory;
						obj2 = 12;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5d72748c192f4bab9e19ca961e9277d1 == 0)
						{
							obj2 = 3;
						}
						continue;
					case 0:
						((dynamic)obj3).executable = executable;
						obj2 = 5;
						continue;
					case 3:
						((dynamic)obj3).cancellationToken = cancellationToken;
						obj2 = 11;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0609736616ee48cfa58bcf48cbf884e3 == 0)
						{
							obj2 = 2;
						}
						continue;
					case 1:
						((dynamic)obj3).__t__builder = AsyncTaskMethodBuilder<ProcessResult>.Create();
						obj2 = 5;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bb37d0226fdb41f1902e558a997d9dc6 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 5:
						((dynamic)obj3).arguments = arguments;
						obj2 = 4;
						continue;
					case 6:
						return ((dynamic)obj3).__t__builder.Task;
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
			((dynamic)obj3).__1__state = -1;
			num = 0;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4fafd75e484e4b31a74460f9f0d54951 != 0)
			{
				num = 13;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string TrimOutput(string value)
	{
		//IL_000c: Expected O, but got I4
		//IL_0025: Expected I4, but got O
		//IL_00bb->IL0010: Incompatible stack types: I4 vs O
		//IL_008f->IL0010: Incompatible stack types: I4 vs O
		//IL_00c6->IL0010: Incompatible stack types: I4 vs O
		//IL_009a->IL0010: Incompatible stack types: I4 vs O
		object obj = 2;
		dynamic obj3 = default(object);
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					if ((nint)obj == 991)
					{
						goto end_IL_0010;
					}
					goto case 1;
				case 3:
				{
					dynamic obj4 = obj3;
					return ((dynamic)obj4).Substring(((string)obj4).Length - 4000);
				}
				case 0:
					return (string)obj3;
				case 1:
					if (((string)obj3).Length <= 4000)
					{
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f1dd9923a6bd42d5867c8e2e591d3e3b == 0)
						{
							obj2 = 7;
						}
						break;
					}
					goto case 3;
				case 2:
					obj3 = (value).Trim();
					obj2 = 2;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7d96de295fba4e09a034ce1853831e68 == 0)
					{
						obj2 = 1;
					}
					break;
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
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool kZ8Vp4LEX0wGPpjbk1QS()
	{
		return DWVjCOLEbbxg4bqN3sPo == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static McpPythonCompiler InNnCYLEfEsfcm0WvY2K()
	{
		return DWVjCOLEbbxg4bqN3sPo;
	}
}
