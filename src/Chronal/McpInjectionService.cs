using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using Mahiro_Account.Services;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Features.McpStudio.Services;

internal sealed class McpInjectionService
{
	internal sealed class Submission : IEquatable<Submission>
	{
		[CompilerGenerated]
		private readonly int _ProcessId_k__BackingField;

		[CompilerGenerated]
		private readonly global::System.DateTime _StartedAt_k__BackingField;

		[CompilerGenerated]
		private readonly string _EntryModule_k__BackingField;

		internal static Submission OIBa60L2jCtTk1PJQUdY;

		[CompilerGenerated]
		private global::System.Type EqualityContract
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return System.Type.GetTypeFromHandle(typeof(Submission).TypeHandle);
			}
		}

		public int ProcessId
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _ProcessId_k__BackingField;
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
				do
				{
					object obj2 = obj;
					while (true)
					{
						switch ((int)obj2)
						{
						case 1:
							_ProcessId_k__BackingField = value;
							obj2 = 1;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0003dce1a8644b9dbbca586828352343 == 0)
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
		}

		public global::System.DateTime StartedAt
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _StartedAt_k__BackingField;
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
						_StartedAt_k__BackingField = value;
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_6d6b99fc4578413f8bc3bdf9db0e7260 == 0)
						{
							obj2 = 2;
						}
					}
				}
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
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_d9c10084bf5f4a9f947702ad63bef067 != 0)
						{
							obj2 = 4;
						}
					}
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public Submission(int ProcessId, global::System.DateTime StartedAt, string EntryModule)
		{
			//IL_0070: Expected I4, but got O
			//IL_0055->IL0067: Incompatible stack types: I4 vs O
			//IL_0060->IL0067: Incompatible stack types: I4 vs O
			_ProcessId_k__BackingField = ProcessId;
			_StartedAt_k__BackingField = StartedAt;
			_EntryModule_k__BackingField = EntryModule;
			object obj = 0;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_36a48f7fc5034120a3fadb53ab2f53cc != 0)
			{
				obj = 2;
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
		[CompilerGenerated]
		public override string ToString()
		{
			//IL_000c: Expected O, but got I4
			//IL_0031: Expected I4, but got O
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Expected O, but got Unknown
			//IL_00e3->IL0010: Incompatible stack types: I4 vs O
			//IL_00ca->IL0010: Incompatible stack types: I4 vs O
			//IL_0106->IL0010: Incompatible stack types: I4 vs O
			//IL_0132->IL0010: Incompatible stack types: I4 vs O
			//IL_0111->IL0010: Incompatible stack types: I4 vs O
			//IL_0097->IL0010: Incompatible stack types: I4 vs O
			//IL_013d->IL0010: Incompatible stack types: I4 vs O
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
							if ((nint)obj != 13)
							{
								if ((nint)obj == 994)
								{
									goto end_IL_0010;
								}
								goto case 6;
							}
							((dynamic)obj3).Append("Submission");
							obj2 = 2;
							continue;
						case 5:
							return (obj3).ToString();
						case 2:
							((dynamic)obj3).Append(" { ");
							obj2 = 4;
							continue;
						case 0:
						case 1:
							((dynamic)obj3).Append('}');
							obj2 = 5;
							continue;
						case 6:
							((dynamic)obj3).Append(' ');
							obj2 = 0;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_35f00f496d71423193427920cdcc22f1 == 0)
							{
								obj2 = 1;
							}
							continue;
						case 4:
							if (!PrintMembers((StringBuilder)obj3))
							{
								obj2 = 1;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2ea097de099140f192d12c8111241f4e == 0)
								{
									obj2 = 0;
								}
								continue;
							}
							goto case 6;
						case 3:
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
				obj3 = (object)new StringBuilder();
				num = 13;
				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f651726544964479b0083c2c6dbce1d1 != 0)
				{
					num = 4;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private unsafe bool PrintMembers(StringBuilder builder)
		{
			//IL_000c: Expected O, but got I4
			//IL_0031: Expected I4, but got O
			//IL_00e0: Expected O, but got I4
			//IL_0148->IL0010: Incompatible stack types: I4 vs O
			//IL_01ac->IL0010: Incompatible stack types: I4 vs O
			//IL_00cc->IL0010: Incompatible stack types: I4 vs O
			//IL_0087->IL0010: Incompatible stack types: I4 vs O
			//IL_010c->IL0010: Incompatible stack types: I4 vs O
			//IL_00d7->IL0010: Incompatible stack types: I4 vs O
			//IL_0092->IL0010: Incompatible stack types: I4 vs O
			//IL_0117->IL0010: Incompatible stack types: I4 vs O
			//IL_00ae->IL0010: Incompatible stack types: I4 vs O
			int num = 2;
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
								goto case 0;
							}
							(builder).Append(EntryModule);
							obj2 = 3;
							continue;
						case 5:
						{
							object startedAt = StartedAt;
							(builder).Append(((object)(*(global::System.DateTime*)(&startedAt))/*cast due to .constrained prefix*/).ToString());
							obj2 = 4;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4f82b5c32b3f4f0289c9a252a3907b21 == 0)
							{
								obj2 = 1;
							}
							continue;
						}
						case 2:
							System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
							obj2 = 11;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1282ca3a3b4d42dea9c5c692937e35bc != 0)
							{
								obj2 = 1;
							}
							continue;
						case 6:
						{
							dynamic obj3 = ProcessId;
							(builder).Append(((object)(obj3)/*cast due to .constrained prefix*/).ToString());
							obj2 = 0;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_401ab1a410ca4fdcae9d2ecf627c5703 == 0)
							{
								obj2 = 7;
							}
							continue;
						}
						case 0:
							(builder).Append(", StartedAt = ");
							obj2 = 5;
							continue;
						case 4:
							break;
						case 1:
							(builder).Append("ProcessId = ");
							obj2 = 6;
							continue;
						case 3:
							return true;
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
				(builder).Append(", EntryModule = ");
				num = 13;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator !=(Submission? left, Submission? right)
		{
			return !(left == right);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator ==(Submission? left, Submission? right)
		{
			//IL_000c: Expected O, but got I4
			//IL_0025: Expected I4, but got O
			//IL_0052->IL0010: Incompatible stack types: I4 vs O
			//IL_0078->IL0010: Incompatible stack types: I4 vs O
			//IL_005d->IL0010: Incompatible stack types: I4 vs O
			//IL_0083->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
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
						goto case 2;
					case 0:
						if ((object)left == null)
						{
							obj2 = 2;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0c88e6c08eaf4e998e8fdd2c544cee2e == 0)
							{
								obj2 = 0;
							}
							break;
						}
						goto case 3;
					case 1:
						if ((object)left == right)
						{
							return true;
						}
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3054c4fc69b94a37b21ac42c2099175a == 0)
						{
							obj2 = 5;
						}
						break;
					case 3:
						return left.Equals(right);
					case 2:
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
			return ((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(_ProcessId_k__BackingField)) * -1521134295 + EqualityComparer<global::System.DateTime>.Default.GetHashCode(_StartedAt_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_EntryModule_k__BackingField);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as Submission);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public bool Equals(Submission? other)
		{
			//IL_000c: Expected O, but got I4
			//IL_0035: Expected I4, but got O
			//IL_0158->IL0010: Incompatible stack types: I4 vs O
			//IL_0133->IL0010: Incompatible stack types: I4 vs O
			//IL_008c->IL0010: Incompatible stack types: I4 vs O
			//IL_00d7->IL0010: Incompatible stack types: I4 vs O
			//IL_0163->IL0010: Incompatible stack types: I4 vs O
			//IL_013e->IL0010: Incompatible stack types: I4 vs O
			//IL_0097->IL0010: Incompatible stack types: I4 vs O
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
							if ((nint)obj != 14)
							{
								if ((nint)obj == 995)
								{
									goto end_IL_0010;
								}
								goto case 1;
							}
							goto case 0;
						case 5:
							if (EqualityComparer<global::System.DateTime>.Default.Equals(_StartedAt_k__BackingField, other._StartedAt_k__BackingField))
							{
								obj2 = 1;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_cb74c857a9564cc0b30907ecfe1e0cdf == 0)
								{
									obj2 = 14;
								}
								continue;
							}
							goto case 0;
						case 1:
							return EqualityComparer<string>.Default.Equals(_EntryModule_k__BackingField, other._EntryModule_k__BackingField);
						case 0:
						case 6:
							return false;
						case 7:
							if (!EqualityComparer<int>.Default.Equals(_ProcessId_k__BackingField, other._ProcessId_k__BackingField))
							{
								obj2 = 6;
								continue;
							}
							goto case 5;
						case 4:
							if (!(EqualityContract == other.EqualityContract))
							{
								break;
							}
							goto case 7;
						case 3:
							if ((object)this == other)
							{
								return true;
							}
							obj2 = 2;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_29300ae0ec1d42aeac4a5187ea9fcbba != 0)
							{
								obj2 = 3;
							}
							continue;
						case 2:
							if ((object)other == null)
							{
								obj2 = 8;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2b2f512a98d548488e5242742b1ff011 == 0)
								{
									obj2 = 0;
								}
								continue;
							}
							goto case 4;
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
				num = 14;
				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9c15dc17ae4e48a5bd629d141b0ebe29 == 0)
				{
					num = 2;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public Submission _Clone__()
		{
			return (Submission)new Submission(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private Submission(Submission original)
		{
			//IL_0042: Expected O, but got I4
			//IL_0057: Expected I4, but got O
			//IL_0031->IL0046: Incompatible stack types: I4 vs O
			//IL_003c->IL0046: Incompatible stack types: I4 vs O
			//IL_0098->IL0046: Incompatible stack types: I4 vs O
			//IL_00a3->IL0046: Incompatible stack types: I4 vs O
			//IL_00c3->IL0046: Incompatible stack types: I4 vs O
			//IL_00ce->IL0046: Incompatible stack types: I4 vs O
			object obj = 4;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b7393eff3b9049068ae7c92e2e0229a5 == 0)
			{
				obj = 1;
			}
			object obj2 = default(object);
			while (true)
			{
				switch ((int)obj)
				{
				default:
					if ((nint)obj2 != 10)
					{
						if ((nint)obj2 == 990)
						{
							goto IL_0042;
						}
						goto case 1;
					}
					_EntryModule_k__BackingField = original._EntryModule_k__BackingField;
					obj = 3;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_c3a1ed3f1b10415883902def95e1be62 != 0)
					{
						obj = 0;
					}
					break;
				case 1:
					_ProcessId_k__BackingField = original._ProcessId_k__BackingField;
					obj = 2;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f1dd9923a6bd42d5867c8e2e591d3e3b == 0)
					{
						obj = 1;
					}
					break;
				case 2:
				{
					_StartedAt_k__BackingField = original._StartedAt_k__BackingField;
					int num = 10;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_06501b7bae1743aa8336fe70312492d7 == 0)
					{
						num = 0;
					}
					obj2 = num;
					goto IL_0042;
				}
				case 0:
					return;
					IL_0042:
					obj = obj2;
					break;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public void Deconstruct(out int ProcessId, out global::System.DateTime StartedAt, out string EntryModule)
		{
			ProcessId = this.ProcessId;
			EntryModule = this.EntryModule;
			StartedAt = this.StartedAt;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool wN9yl2L2Z2lUGpKtvP0V()
		{
			return (object)OIBa60L2jCtTk1PJQUdY == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static Submission jg4XnqL2936x7V8JUDTr()
		{
			return OIBa60L2jCtTk1PJQUdY;
		}
	}

	[Flags]
	private enum AllocationType : uint
	{
		Commit = 0x1000u,
		Reserve = 0x2000u
	}

	private enum MemoryProtection : uint
	{
		ReadWrite = 4u
	}

	private enum FreeType : uint
	{
		Release = 0x8000u
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _InjectAndActivateAsync_d__1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<Submission> __t__builder;

		public string mcpPath;

		public string entryModule;

		public string managerAddress;

		public CancellationToken cancellationToken;

		private long _address_5__2;

		private Process _process_5__3;

		private Process _targetProcess_5__4;

		private NamedPipeClientStream _pipe_5__5;

		private CancellationTokenSource _timeout_5__6;

		private object __u__1;

		private object __u__2;

		private static object b7ajLIL2WVtPFxWLZvE9;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_000c: Expected O, but got I4
			//IL_1902: Expected O, but got I4
			//IL_0035: Expected I4, but got O
			//IL_0546: Unknown result type (might be due to invalid IL or missing references)
			//IL_0549: Expected O, but got Unknown
			//IL_03cd: Expected I4, but got O
			//IL_0420: Expected I4, but got O
			//IL_1a31: Expected O, but got I4
			//IL_00fe: Expected O, but got I4
			//IL_04bf: Expected I4, but got O
			//IL_16ae: Expected I4, but got O
			//IL_1778: Expected I4, but got O
			//IL_1857: Expected I4, but got O
			//IL_1923: Expected I4, but got O
			//IL_0163: Expected I4, but got O
			//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_068f: Expected O, but got I4
			//IL_062f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0835: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_058a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0675: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aca: Expected O, but got Unknown
			//IL_0a55: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0926: Expected O, but got I4
			//IL_022e: Expected O, but got I4
			//IL_0963: Expected I4, but got O
			//IL_0253: Expected I4, but got O
			//IL_0be9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bd4: Expected I4, but got O
			//IL_0d47: Expected I4, but got O
			//IL_0cfa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c5d: Expected O, but got I4
			//IL_14ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_14f4: Expected O, but got Unknown
			//IL_120c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1213: Expected O, but got Unknown
			//IL_12a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_12b0: Expected O, but got Unknown
			//IL_0d5f: Expected O, but got I4
			//IL_0c76: Expected I4, but got O
			//IL_0f12: Expected O, but got I4
			//IL_1518: Expected O, but got I4
			//IL_0f61: Expected O, but got I4
			//IL_13ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_13f4: Expected O, but got Unknown
			//IL_13a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_11ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_11b5: Expected O, but got Unknown
			//IL_0fa5: Expected O, but got I4
			//IL_1360: Unknown result type (might be due to invalid IL or missing references)
			//IL_11e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_11fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_1201: Expected O, but got Unknown
			//IL_0efc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f03: Expected O, but got Unknown
			//IL_10d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_1235: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fdf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fe6: Expected O, but got Unknown
			//IL_131d: Unknown result type (might be due to invalid IL or missing references)
			//IL_132d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eeb: Expected O, but got I4
			//IL_102e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1035: Expected O, but got Unknown
			//IL_0e4a: Expected O, but got I4
			//IL_0ec1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e24: Expected I4, but got O
			//IL_03a7->IL03c4: Incompatible stack types: I4 vs O
			//IL_03fa->IL0417: Incompatible stack types: I4 vs O
			//IL_18e9->IL1906: Incompatible stack types: I4 vs O
			//IL_03b2->IL03c4: Incompatible stack types: I4 vs O
			//IL_0405->IL0417: Incompatible stack types: I4 vs O
			//IL_049c->IL04ae: Incompatible stack types: I4 vs O
			//IL_167c->IL1699: Incompatible stack types: I4 vs O
			//IL_1746->IL1763: Incompatible stack types: I4 vs O
			//IL_1825->IL1842: Incompatible stack types: I4 vs O
			//IL_18f4->IL1906: Incompatible stack types: I4 vs O
			//IL_1687->IL1699: Incompatible stack types: I4 vs O
			//IL_1751->IL1763: Incompatible stack types: I4 vs O
			//IL_1830->IL1842: Incompatible stack types: I4 vs O
			//IL_19d4->IL1906: Incompatible stack types: I4 vs O
			//IL_195f->IL1906: Incompatible stack types: I4 vs O
			//IL_19ad->IL1906: Incompatible stack types: I4 vs O
			//IL_051e->IL04ae: Incompatible stack types: I4 vs O
			//IL_16fa->IL1699: Incompatible stack types: I4 vs O
			//IL_17d3->IL1763: Incompatible stack types: I4 vs O
			//IL_18b8->IL1842: Incompatible stack types: I4 vs O
			//IL_19df->IL1906: Incompatible stack types: I4 vs O
			//IL_196a->IL1906: Incompatible stack types: I4 vs O
			//IL_19b8->IL1906: Incompatible stack types: I4 vs O
			//IL_1992->IL1906: Incompatible stack types: I4 vs O
			//IL_0529->IL04ae: Incompatible stack types: I4 vs O
			//IL_04f3->IL04ae: Incompatible stack types: I4 vs O
			//IL_16d6->IL1699: Incompatible stack types: I4 vs O
			//IL_1705->IL1699: Incompatible stack types: I4 vs O
			//IL_17de->IL1763: Incompatible stack types: I4 vs O
			//IL_17fd->IL1763: Incompatible stack types: I4 vs O
			//IL_1889->IL1842: Incompatible stack types: I4 vs O
			//IL_18c3->IL1842: Incompatible stack types: I4 vs O
			//IL_008d->IL0010: Incompatible stack types: I4 vs O
			//IL_00dd->IL0010: Incompatible stack types: I4 vs O
			//IL_0071->IL0010: Incompatible stack types: I4 vs O
			//IL_00a4->IL0010: Incompatible stack types: I4 vs O
			//IL_1a3b->IL0010: Incompatible stack types: I4 vs O
			//IL_04fe->IL04ae: Incompatible stack types: I4 vs O
			//IL_1808->IL1763: Incompatible stack types: I4 vs O
			//IL_1894->IL1842: Incompatible stack types: I4 vs O
			//IL_007c->IL0010: Incompatible stack types: I4 vs O
			//IL_1a4c->IL0010: Incompatible stack types: I4 vs O
			//IL_0199->IL0102: Incompatible stack types: I4 vs O
			//IL_00f0->IL0102: Incompatible stack types: I4 vs O
			//IL_01a4->IL0102: Incompatible stack types: I4 vs O
			//IL_0699->IL0102: Incompatible stack types: I4 vs O
			//IL_075a->IL0102: Incompatible stack types: I4 vs O
			//IL_0734->IL0102: Incompatible stack types: I4 vs O
			//IL_064b->IL0102: Incompatible stack types: I4 vs O
			//IL_06b2->IL0102: Incompatible stack types: I4 vs O
			//IL_07c9->IL0102: Incompatible stack types: I4 vs O
			//IL_068c->IL0102: Incompatible stack types: I4 vs O
			//IL_06c9->IL0102: Incompatible stack types: I4 vs O
			//IL_06e8->IL0102: Incompatible stack types: I4 vs O
			//IL_0765->IL0102: Incompatible stack types: I4 vs O
			//IL_073f->IL0102: Incompatible stack types: I4 vs O
			//IL_0a15->IL092a: Incompatible stack types: I4 vs O
			//IL_090d->IL092a: Incompatible stack types: I4 vs O
			//IL_05fa->IL0102: Incompatible stack types: I4 vs O
			//IL_089b->IL0102: Incompatible stack types: I4 vs O
			//IL_07d4->IL0102: Incompatible stack types: I4 vs O
			//IL_05d0->IL0102: Incompatible stack types: I4 vs O
			//IL_06f3->IL0102: Incompatible stack types: I4 vs O
			//IL_0220->IL0232: Incompatible stack types: I4 vs O
			//IL_0a20->IL092a: Incompatible stack types: I4 vs O
			//IL_0918->IL092a: Incompatible stack types: I4 vs O
			//IL_0605->IL0102: Incompatible stack types: I4 vs O
			//IL_08e5->IL0102: Incompatible stack types: I4 vs O
			//IL_05db->IL0102: Incompatible stack types: I4 vs O
			//IL_0a00->IL092a: Incompatible stack types: I4 vs O
			//IL_0aec->IL092a: Incompatible stack types: I4 vs O
			//IL_08f0->IL0102: Incompatible stack types: I4 vs O
			//IL_0286->IL0232: Incompatible stack types: I4 vs O
			//IL_0a87->IL092a: Incompatible stack types: I4 vs O
			//IL_099f->IL092a: Incompatible stack types: I4 vs O
			//IL_09df->IL092a: Incompatible stack types: I4 vs O
			//IL_0b2c->IL092a: Incompatible stack types: I4 vs O
			//IL_0b89->IL092a: Incompatible stack types: I4 vs O
			//IL_0b6d->IL092a: Incompatible stack types: I4 vs O
			//IL_02ce->IL0232: Incompatible stack types: I4 vs O
			//IL_0c27->IL0bc3: Incompatible stack types: I4 vs O
			//IL_0ba6->IL0bc3: Incompatible stack types: I4 vs O
			//IL_0b78->IL092a: Incompatible stack types: I4 vs O
			//IL_0382->IL0232: Incompatible stack types: I4 vs O
			//IL_0304->IL0232: Incompatible stack types: I4 vs O
			//IL_02d9->IL0232: Incompatible stack types: I4 vs O
			//IL_0357->IL0232: Incompatible stack types: I4 vs O
			//IL_0bb1->IL0bc3: Incompatible stack types: I4 vs O
			//IL_038d->IL0232: Incompatible stack types: I4 vs O
			//IL_030f->IL0232: Incompatible stack types: I4 vs O
			//IL_0362->IL0232: Incompatible stack types: I4 vs O
			//IL_0c11->IL0bc3: Incompatible stack types: I4 vs O
			//IL_0c1c->IL0bc3: Incompatible stack types: I4 vs O
			//IL_0d33->IL0c61: Incompatible stack types: I4 vs O
			//IL_0c44->IL0c61: Incompatible stack types: I4 vs O
			//IL_0c4f->IL0c61: Incompatible stack types: I4 vs O
			//IL_0d1d->IL0c61: Incompatible stack types: I4 vs O
			//IL_1508->IL0d63: Incompatible stack types: I4 vs O
			//IL_1227->IL0d63: Incompatible stack types: I4 vs O
			//IL_12c4->IL0d63: Incompatible stack types: I4 vs O
			//IL_0d28->IL0c61: Incompatible stack types: I4 vs O
			//IL_1513->IL0d63: Incompatible stack types: I4 vs O
			//IL_1232->IL0d63: Incompatible stack types: I4 vs O
			//IL_12cf->IL0d63: Incompatible stack types: I4 vs O
			//IL_0f21->IL0d63: Incompatible stack types: I4 vs O
			//IL_0f51->IL0d63: Incompatible stack types: I4 vs O
			//IL_1527->IL0d63: Incompatible stack types: I4 vs O
			//IL_0f7a->IL0d63: Incompatible stack types: I4 vs O
			//IL_1408->IL0d63: Incompatible stack types: I4 vs O
			//IL_10ca->IL0d63: Incompatible stack types: I4 vs O
			//IL_13bc->IL0d63: Incompatible stack types: I4 vs O
			//IL_12e5->IL0d63: Incompatible stack types: I4 vs O
			//IL_12a8->IL0d63: Incompatible stack types: I4 vs O
			//IL_14e1->IL0d63: Incompatible stack types: I4 vs O
			//IL_1151->IL0d63: Incompatible stack types: I4 vs O
			//IL_1111->IL0d63: Incompatible stack types: I4 vs O
			//IL_1379->IL0d63: Incompatible stack types: I4 vs O
			//IL_120b->IL0d63: Incompatible stack types: I4 vs O
			//IL_0f0d->IL0d63: Incompatible stack types: I4 vs O
			//IL_10e0->IL0d63: Incompatible stack types: I4 vs O
			//IL_11a1->IL0d63: Incompatible stack types: I4 vs O
			//IL_0e85->IL0d63: Incompatible stack types: I4 vs O
			//IL_124e->IL0d63: Incompatible stack types: I4 vs O
			//IL_1061->IL0d63: Incompatible stack types: I4 vs O
			//IL_0ffa->IL0d63: Incompatible stack types: I4 vs O
			//IL_1277->IL0d63: Incompatible stack types: I4 vs O
			//IL_0eb0->IL0d63: Incompatible stack types: I4 vs O
			//IL_139c->IL0d63: Incompatible stack types: I4 vs O
			//IL_1352->IL0d63: Incompatible stack types: I4 vs O
			//IL_1017->IL0d63: Incompatible stack types: I4 vs O
			//IL_0efa->IL0d63: Incompatible stack types: I4 vs O
			//IL_14bf->IL0d63: Incompatible stack types: I4 vs O
			//IL_103f->IL0d63: Incompatible stack types: I4 vs O
			//IL_0e59->IL0d63: Incompatible stack types: I4 vs O
			//IL_0edb->IL0d63: Incompatible stack types: I4 vs O
			//IL_10a7->IL0d63: Incompatible stack types: I4 vs O
			//IL_0f5c->IL0d63: Incompatible stack types: I4 vs O
			//IL_0f85->IL0d63: Incompatible stack types: I4 vs O
			//IL_1413->IL0d63: Incompatible stack types: I4 vs O
			//IL_13c7->IL0d63: Incompatible stack types: I4 vs O
			//IL_14ec->IL0d63: Incompatible stack types: I4 vs O
			//IL_1384->IL0d63: Incompatible stack types: I4 vs O
			//IL_130a->IL0d63: Incompatible stack types: I4 vs O
			//IL_11ac->IL0d63: Incompatible stack types: I4 vs O
			//IL_0e90->IL0d63: Incompatible stack types: I4 vs O
			//IL_1259->IL0d63: Incompatible stack types: I4 vs O
			//IL_1481->IL0d63: Incompatible stack types: I4 vs O
			//IL_106c->IL0d63: Incompatible stack types: I4 vs O
			//IL_1005->IL0d63: Incompatible stack types: I4 vs O
			//IL_1282->IL0d63: Incompatible stack types: I4 vs O
			//IL_0ebb->IL0d63: Incompatible stack types: I4 vs O
			//IL_135d->IL0d63: Incompatible stack types: I4 vs O
			//IL_0ee6->IL0d63: Incompatible stack types: I4 vs O
			//IL_10b2->IL0d63: Incompatible stack types: I4 vs O
			//IL_1315->IL0d63: Incompatible stack types: I4 vs O
			//IL_148c->IL0d63: Incompatible stack types: I4 vs O
			//IL_0fa0->IL0d63: Incompatible stack types: I4 vs O
			int num = 6;
			object result = default(object);
			dynamic obj3 = default(object);
			object obj31 = default(object);
			object obj39 = default(object);
			dynamic obj35 = default(object);
			dynamic obj37 = default(object);
			object obj45 = default(object);
			object obj41 = default(object);
			object obj43 = default(object);
			dynamic obj32 = default(object);
			dynamic obj33 = default(object);
			object obj25 = default(object);
			dynamic obj26 = default(object);
			object obj28 = default(object);
			object obj27 = default(object);
			bool value = default(bool);
			object obj22 = default(object);
			object obj18 = default(object);
			object obj8 = default(object);
			object obj17 = default(object);
			object obj16 = default(object);
			dynamic obj11 = default(object);
			object obj12 = default(object);
			dynamic obj13 = default(object);
			object obj14 = default(object);
			object obj15 = default(object);
			dynamic obj10 = default(object);
			object obj21 = default(object);
			object obj24 = default(object);
			object obj30 = default(object);
			object obj47 = default(object);
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
								goto case 1;
							}
							_targetProcess_5__4 = null;
							obj2 = 2;
							continue;
						case 2:
							_pipe_5__5 = null;
							obj2 = 9;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b18c9101a9694aa1aae5a0a4ca0f1892 == 0)
							{
								obj2 = 0;
							}
							continue;
						case 0:
							_timeout_5__6 = null;
							obj2 = 4;
							continue;
						case 4:
							__t__builder.SetResult((Submission)result);
							obj2 = 3;
							continue;
						case 3:
							return;
						case 7:
							break;
						case 1:
							__1__state = -2;
							obj2 = 7;
							continue;
						case 5:
							try
							{
								object obj4;
								if ((nuint)(nint)obj3 > (nuint)2u)
								{
									obj4 = 2;
									goto IL_0102;
								}
								goto IL_0184;
								IL_0184:
								obj4 = 4;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0003dce1a8644b9dbbca586828352343 != 0)
								{
									obj4 = 23;
								}
								goto IL_0102;
								IL_0102:
								while (true)
								{
									int num4;
									switch ((int)obj4)
									{
									default:
										if ((nint)obj31 == 30)
										{
											goto case 5;
										}
										if ((nint)obj31 == 1010)
										{
											goto IL_00fe;
										}
										goto case 21;
									case 9:
										break;
									case 18:
										throw new PlatformNotSupportedException("MCP 注入要求 x64 客户端");
									case 12:
										if (System.IO.File.Exists(mcpPath))
										{
											num4 = 10;
											goto IL_00fa;
										}
										goto case 20;
									case 19:
										try
										{
											if (_process_5__3 == null)
											{
												object obj34 = 2;
												while (true)
												{
													bool? obj38;
													switch ((int)obj34)
													{
													default:
														if ((nint)obj39 != 14)
														{
															if ((nint)obj39 != 994)
															{
																goto end_IL_0232;
															}
															goto IL_022e;
														}
														obj38 = obj35;
														goto IL_0341;
													case 5:
														_process_5__3 = (Process)obj37;
														obj34 = 6;
														continue;
													case 0:
														goto end_IL_0232;
													case 3:
														*(bool?*)(&obj35) = null;
														obj39 = 14;
														goto IL_022e;
													case 2:
													{
														ProcessModule obj36 = ((dynamic)obj37).MainModule;
														if (obj36 == null)
														{
															obj34 = 4;
															if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_8cd7f54b623a4d42b1a5e008c75a22ed == 0)
															{
																obj34 = 14;
															}
															continue;
														}
														string text2 = (obj36).ModuleName;
														if (text2 == null)
														{
															obj34 = 3;
															if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b6e1b24306c5435497967d798ce571fb == 0)
															{
																obj34 = 11;
															}
															continue;
														}
														obj38 = (text2).Equals("Minecraft.Windows.exe", (StringComparison)5);
														goto IL_0341;
													}
													case 1:
														if (*(bool?*)(&obj35) != true)
														{
															break;
														}
														goto case 5;
													case 4:
														break;
													case 6:
														goto end_IL_0232;
														IL_0341:
														obj35 = obj38;
														obj34 = 9;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_c3a1ed3f1b10415883902def95e1be62 != 0)
														{
															obj34 = 1;
														}
														continue;
														IL_022e:
														obj34 = obj39;
														continue;
													}
													obj34 = 0;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_fd7466ab326a4027abb1e5cf92add793 != 0)
													{
														obj34 = 7;
													}
													continue;
													end_IL_0232:
													break;
												}
											}
										}
										catch (global::System.Exception)
										{
											object obj40 = 0;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_496d0f7c1bde4581a78d6bb0fcab5473 == 0)
											{
												obj40 = 1;
											}
											while (true)
											{
												switch ((int)obj40)
												{
												default:
													if ((nint)obj41 == 988)
													{
														obj40 = obj41;
														continue;
													}
													break;
												case 0:
													break;
												}
												break;
											}
										}
										finally
										{
											if ((nint)obj3 < 0)
											{
												object obj44 = 2;
												while (true)
												{
													switch ((int)obj44)
													{
													default:
														if ((nint)obj45 == 990)
														{
															obj44 = obj45;
															continue;
														}
														break;
													case 2:
														if (obj37 != _process_5__3)
														{
															obj44 = 0;
															if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4783bfa33d264997aac915e5e739dc84 != 0)
															{
																obj44 = 0;
															}
															continue;
														}
														goto end_IL_04ae;
													case 0:
														break;
													case 1:
														goto end_IL_04ae;
													}
													((dynamic)obj37).Dispose();
													obj44 = 1;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_527dac5507ee46fcb9d22f9ff955c1d0 != 0)
													{
														obj44 = 6;
													}
													continue;
													end_IL_04ae:
													break;
												}
											}
										}
										goto case 3;
									case 3:
										obj32++;
										num4 = 30;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4ae4de12ce674c26bc2939a5789df8ab != 0)
										{
											num4 = 0;
										}
										goto IL_00fa;
									case 20:
										throw new FileNotFoundException("MCP 文件不存在", mcpPath);
									case 10:
									{
										string text3 = mcpPath;
										char[] array2 = new char[3] { '\t', '\r', '\n' };
										if ((text3).IndexOfAny(array2) >= 0)
										{
											obj4 = 1;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_29300ae0ec1d42aeac4a5187ea9fcbba != 0)
											{
												obj4 = 10;
											}
											continue;
										}
										if (!string.IsNullOrWhiteSpace(entryModule))
										{
											obj4 = 6;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_28a8309f77124973ab9263f59df1f564 == 0)
											{
												obj4 = 16;
											}
											continue;
										}
										goto case 17;
									}
									case 5:
										if ((nint)obj32 >= ((global::System.Array)obj33).Length)
										{
											obj4 = 28;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7bc84b0f9b2d4d968eda9f4e194ba82d != 0)
											{
												obj4 = 15;
											}
											continue;
										}
										goto case 16;
									case 11:
										throw new InvalidOperationException("未找到 Minecraft.Windows.exe，请先进入已启用 MCP 的服务器");
									case 0:
										_targetProcess_5__4 = _process_5__3;
										obj4 = 9;
										continue;
									case 13:
									case 22:
										throw new InvalidDataException("管理器地址必须是十六进制指针，例如 0x12345678");
									case 8:
										obj32 = 0;
										obj4 = 5;
										continue;
									case 2:
										if (!System.OperatingSystem.IsWindows())
										{
											obj4 = 7;
											continue;
										}
										if (System.Environment.Is64BitProcess)
										{
											num4 = 12;
											goto IL_00fa;
										}
										goto case 18;
									case 14:
										if (_address_5__2 <= 0)
										{
											obj4 = 22;
											continue;
										}
										_process_5__3 = null;
										obj4 = 21;
										continue;
									case 15:
										if (_process_5__3 != null)
										{
											obj4 = 4;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_07c1f539d4f94d95bde09a0fba07dbbc != 0)
											{
												obj4 = 0;
											}
											continue;
										}
										goto case 11;
									case 21:
										obj33 = System.Diagnostics.Process.GetProcessesByName("Minecraft.Windows");
										obj4 = 8;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_8a5abf847bb54a3aa56e2df86c0b5690 != 0)
										{
											obj4 = 7;
										}
										continue;
									case 16:
										obj37 = ((object[])obj33)[obj32];
										obj4 = 28;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bb37d0226fdb41f1902e558a997d9dc6 == 0)
										{
											obj4 = 19;
										}
										continue;
									case 6:
									{
										string text = entryModule;
										char[] array = new char[3] { '\t', '\r', '\n' };
										if ((text).IndexOfAny(array) >= 0)
										{
											obj4 = 26;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_80fb217b158b48d3aa902bde1388a3c9 != 0)
											{
												obj4 = 17;
											}
											continue;
										}
										if (!long.TryParse(((managerAddress).Trim()).Replace("0x", "", (StringComparison)5), (NumberStyles)515, null, out _address_5__2))
										{
											obj4 = 13;
											continue;
										}
										goto case 14;
									}
									case 7:
										throw new PlatformNotSupportedException("MCP 注入仅支持 Windows");
									case 17:
										throw new InvalidDataException("入口模块无效");
									case 1:
										throw new InvalidDataException("文件路径包含无效字符");
									case 4:
										{
											try
											{
												object obj5;
												if ((nuint)(nint)obj3 > (nuint)2u)
												{
													obj5 = 10;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7d96de295fba4e09a034ce1853831e68 != 0)
													{
														obj5 = 20;
													}
													goto IL_092a;
												}
												goto IL_0a00;
												IL_092a:
												while (true)
												{
													int num3;
													switch ((int)obj5)
													{
													default:
														if ((nint)obj25 != 20)
														{
															if ((nint)obj25 == 1000)
															{
																goto IL_0926;
															}
															goto case 8;
														}
														(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj26)).AppendLiteral("GrapeNEL.McpHost5.");
														obj5 = 0;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_07c1f539d4f94d95bde09a0fba07dbbc == 0)
														{
															obj5 = 19;
														}
														continue;
													case 6:
														if (System.IO.File.Exists((string)obj28))
														{
															obj5 = 7;
															continue;
														}
														goto case 9;
													case 9:
														throw new FileNotFoundException("缺少 MCP Host DLL", (string)obj28);
													case 7:
														InjectDll(_process_5__3, (string)obj28);
														obj5 = 8;
														continue;
													case 0:
														((global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj26))->AppendFormatted<int>((_process_5__3).Id);
														obj5 = 3;
														continue;
													case 12:
														break;
													case 8:
														*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj26) = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(18, 1);
														num3 = 20;
														goto IL_0922;
													case 4:
														throw new InvalidOperationException("目标游戏进程不是 x64，已停止注入");
													case 5:
														obj28 = PublishedFileResolver.Resolve("Features/McpStudio/Native/GrapeNelmcpHost_5.dll");
														obj5 = 6;
														continue;
													case 2:
														_pipe_5__5 = new NamedPipeClientStream(".", (string)obj27, (PipeDirection)3, (PipeOptions)1073741824);
														num3 = 12;
														goto IL_0922;
													case 3:
														obj27 = (*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj26)).ToStringAndClear();
														obj5 = 2;
														continue;
													case 10:
														if (TryIs64Bit(_process_5__3, out value))
														{
															obj5 = 11;
															continue;
														}
														goto case 4;
													case 11:
														if (value)
														{
															obj5 = 5;
															continue;
														}
														goto case 4;
													case 1:
														{
															try
															{
																object obj6;
																if ((nuint)(nint)obj3 > (nuint)2u)
																{
																	obj6 = 1;
																	if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4fafd75e484e4b31a74460f9f0d54951 == 0)
																	{
																		obj6 = 3;
																	}
																	goto IL_0bc3;
																}
																goto IL_0c1c;
																IL_0bc3:
																while (true)
																{
																	switch ((int)obj6)
																	{
																	default:
																		if ((nint)obj22 == 990)
																		{
																			obj6 = obj22;
																			continue;
																		}
																		goto case 1;
																	case 1:
																		_timeout_5__6 = System.Threading.CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
																		obj6 = 5;
																		if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_d9c10084bf5f4a9f947702ad63bef067 == 0)
																		{
																			obj6 = 0;
																		}
																		continue;
																	case 0:
																		break;
																	case 2:
																		try
																		{
																			object obj7;
																			if ((nuint)(nint)obj3 > (nuint)2u)
																			{
																				obj7 = 3;
																				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b45a6b8459fb4961b1724a2890d79f3a == 0)
																				{
																					obj7 = 0;
																				}
																				goto IL_0c61;
																			}
																			goto IL_0d28;
																			IL_0c61:
																			while (true)
																			{
																				switch ((int)obj7)
																				{
																				default:
																					if ((nint)obj18 != 11)
																					{
																						if ((nint)obj18 != 991)
																						{
																							break;
																						}
																						goto IL_0c5d;
																					}
																					goto end_IL_0c61;
																				case 1:
																				{
																					int processId = (_process_5__3).Id;
																					object obj19 = (_process_5__3).StartTime;
																					result = (object)new Submission(processId, (*(global::System.DateTime*)(&obj19)).ToUniversalTime(), (entryModule).Trim());
																					obj18 = 11;
																					goto IL_0c5d;
																				}
																				case 3:
																					(_timeout_5__6).CancelAfter(System.TimeSpan.FromSeconds(10.0));
																					obj7 = 0;
																					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b6e1b24306c5435497967d798ce571fb == 0)
																					{
																						obj7 = 7;
																					}
																					continue;
																				case 0:
																					break;
																				case 2:
																					{
																						int num2;
																						object obj9;
																						switch ((int)obj3)
																						{
																						default:
																							num2 = 31;
																							goto IL_0d5b;
																						case 1:
																							goto IL_120b;
																						case 2:
																							goto IL_12a8;
																						case 0:
																							goto IL_14ec;
																							IL_0d5b:
																							obj8 = num2;
																							goto IL_0d5f;
																							IL_0d5f:
																							obj9 = obj8;
																							goto IL_0d63;
																							IL_0d63:
																							while (true)
																							{
																								switch ((int)obj9)
																								{
																								case 6:
																									return;
																								case 20:
																									return;
																								case 38:
																									return;
																								case 17:
																									break;
																								default:
																									goto IL_0e24;
																								case 44:
																									goto IL_0e45;
																								case 25:
																									obj17 = (System.Text.Encoding.UTF8).GetBytes((string)obj16);
																									obj9 = 25;
																									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3054c4fc69b94a37b21ac42c2099175a != 0)
																									{
																										obj9 = 35;
																									}
																									continue;
																								case 1:
																								case 33:
																									((dynamic)obj11).GetResult();
																									obj9 = 13;
																									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_384fbdc0d71943e1a4f9f50f53afad51 == 0)
																									{
																										obj9 = 32;
																									}
																									continue;
																								case 45:
																									__u__2 = default(object);
																									obj9 = 4;
																									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5abcb08dd0ae4b88988bbb89131b0cab != 0)
																									{
																										obj9 = 5;
																									}
																									continue;
																								case 39:
																									obj3 = 0;
																									__1__state = 0;
																									obj9 = 37;
																									continue;
																								case 22:
																									obj11 = ((global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable)obj12).GetAwaiter();
																									obj9 = 27;
																									continue;
																								case 0:
																									obj3 = -1;
																									__1__state = -1;
																									obj9 = 3;
																									continue;
																								case 2:
																									(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj13)).AppendFormatted((entryModule).Trim());
																									obj9 = 2;
																									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_80d00e736d0b4f7dbce583e459774a86 == 0)
																									{
																										obj9 = 46;
																									}
																									continue;
																								case 5:
																									obj3 = -1;
																									__1__state = -1;
																									obj9 = 11;
																									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0609736616ee48cfa58bcf48cbf884e3 != 0)
																									{
																										obj9 = 49;
																									}
																									continue;
																								case 12:
																									goto end_IL_0d63;
																								case 31:
																									obj12 = ((_pipe_5__5).ConnectAsync(5000, (_timeout_5__6).Token)).ConfigureAwait(false);
																									obj9 = 30;
																									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_a2042ba402cd4aaf989f075337c5eaf7 == 0)
																									{
																										obj9 = 22;
																									}
																									continue;
																								case 37:
																									__u__1 = (object)obj11;
																									obj9 = 28;
																									continue;
																								case 42:
																									obj14 = (*(global::System.Threading.Tasks.ValueTask*)(&obj15)).ConfigureAwait(false);
																									obj9 = 10;
																									continue;
																								case 28:
																									global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter cta28 = (global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter)obj11;
																									__t__builder.AwaitUnsafeOnCompleted<global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, _InjectAndActivateAsync_d__1>(ref cta28, ref this);
																									obj9 = 27;
																									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0d16903d89da4928a5d60c2843281188 == 0)
																									{
																										obj9 = 6;
																									}
																									continue;
																								case 46:
																									(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj13)).AppendLiteral("\n");
																									obj9 = 34;
																									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_06766e6d2ea0449aad87692ee68d5840 != 0)
																									{
																										obj9 = 52;
																									}
																									continue;
																								case 8:
																									global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter cta8 = (global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter)obj11;
																									__t__builder.AwaitUnsafeOnCompleted<global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, _InjectAndActivateAsync_d__1>(ref cta8, ref this);
																									obj9 = 38;
																									continue;
																								case 23:
																									__u__1 = default(object);
																									obj9 = 4;
																									continue;
																								case 16:
																									(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj13)).AppendLiteral("\t");
																									obj9 = 2;
																									continue;
																								case 15:
																									(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj13)).AppendLiteral("ACTIVATE\t0x");
																									obj9 = 40;
																									continue;
																								case 24:
																									(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj13)).AppendLiteral("\t");
																									obj9 = 2;
																									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2b2f512a98d548488e5242742b1ff011 == 0)
																									{
																										obj9 = 13;
																									}
																									continue;
																								case 10:
																									goto IL_11ac;
																								case 21:
																									obj12 = ((_pipe_5__5).FlushAsync((_timeout_5__6).Token)).ConfigureAwait(false);
																									obj9 = 7;
																									continue;
																								case 30:
																									goto IL_120b;
																								case 26:
																									__u__1 = (object)obj11;
																									obj9 = 8;
																									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bd95bcb31f2a40c89aee1548651426a0 != 0)
																									{
																										obj9 = 15;
																									}
																									continue;
																								case 32:
																									*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj13) = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(14, 3);
																									obj9 = 15;
																									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_916ae56933ff4374af011c79e3cb023a == 0)
																									{
																										obj9 = 51;
																									}
																									continue;
																								case 13:
																									(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj13)).AppendFormatted(System.IO.Path.GetFullPath(mcpPath));
																									obj9 = 16;
																									continue;
																								case 29:
																									goto IL_12a8;
																								case 11:
																								case 36:
																									((dynamic)obj10).GetResult();
																									obj9 = 21;
																									continue;
																								case 19:
																									if (((dynamic)obj11).IsCompleted)
																									{
																										obj9 = 43;
																										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_80fb217b158b48d3aa902bde1388a3c9 == 0)
																										{
																											obj9 = 10;
																										}
																										continue;
																									}
																									goto end_IL_0d63;
																								case 35:
																									obj15 = (_pipe_5__5).WriteAsync((byte[])obj17, (_timeout_5__6).Token);
																									obj9 = 42;
																									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_496d0f7c1bde4581a78d6bb0fcab5473 == 0)
																									{
																										obj9 = 17;
																									}
																									continue;
																								case 18:
																									__u__2 = (object)obj10;
																									obj9 = 14;
																									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0609736616ee48cfa58bcf48cbf884e3 != 0)
																									{
																										obj9 = 35;
																									}
																									continue;
																								case 34:
																									obj16 = (*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj13)).ToStringAndClear();
																									obj9 = 25;
																									continue;
																								case 9:
																									__u__1 = default(object);
																									obj9 = 14;
																									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1df8e086d5ed471cbc378d2545a921c6 == 0)
																									{
																										obj9 = 0;
																									}
																									continue;
																								case 7:
																									obj11 = ((global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable)obj12).GetAwaiter();
																									obj9 = 0;
																									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4abb095abaf846009b4cca8873b94957 == 0)
																									{
																										obj9 = 19;
																									}
																									continue;
																								case 3:
																								case 43:
																									goto IL_1446;
																								case 27:
																									if (((dynamic)obj11).IsCompleted)
																									{
																										obj9 = 1;
																										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_24238b39bba94b6aa4d3c2739f061133 != 0)
																										{
																											obj9 = 38;
																										}
																										continue;
																									}
																									goto case 39;
																								case 40:
																									((global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj13))->AppendFormatted<long>(_address_5__2, "X");
																									obj9 = 24;
																									continue;
																								case 14:
																									global::System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter cvta14 = (global::System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter)obj10;
																									__t__builder.AwaitUnsafeOnCompleted<global::System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, _InjectAndActivateAsync_d__1>(ref cvta14, ref this);
																									obj9 = 20;
																									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e3c72d365c184d8193f0594ab3fd4d1f != 0)
																									{
																										obj9 = 36;
																									}
																									continue;
																								case 41:
																									goto IL_14ec;
																								case 4:
																									obj3 = -1;
																									__1__state = -1;
																									obj9 = 33;
																									continue;
																								}
																								goto end_IL_0d36;
																								IL_0e24:
																								if ((nint)obj8 != 54)
																								{
																									goto IL_0e32;
																								}
																								if (((dynamic)obj10).IsCompleted)
																								{
																									obj9 = 36;
																									continue;
																								}
																								goto IL_0e45;
																								IL_0e45:
																								obj3 = 1;
																								__1__state = 1;
																								obj9 = 18;
																								continue;
																								end_IL_0d63:
																								break;
																							}
																							goto IL_0fa0;
																							IL_14ec:
																							obj11 = __u__1;
																							obj9 = 23;
																							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0d16903d89da4928a5d60c2843281188 != 0)
																							{
																								obj9 = 49;
																							}
																							goto IL_0d63;
																							IL_11ac:
																							obj10 = ((global::System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable)obj14).GetAwaiter();
																							num2 = 54;
																							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1580feae44ff487ab78d80df31c471c0 == 0)
																							{
																								num2 = 25;
																							}
																							goto IL_0d5b;
																							IL_1446:
																							((dynamic)obj11).GetResult();
																							num2 = 17;
																							goto IL_0d5b;
																							IL_12a8:
																							obj11 = __u__1;
																							obj9 = 8;
																							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5144ebdc507c41fb87d88fdce3dc76e9 != 0)
																							{
																								obj9 = 9;
																							}
																							goto IL_0d63;
																							IL_0e32:
																							if ((nint)obj8 == 1034)
																							{
																								goto IL_0d5f;
																							}
																							goto IL_0fa0;
																							IL_120b:
																							obj10 = __u__2;
																							obj9 = 45;
																							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_c3a1ed3f1b10415883902def95e1be62 == 0)
																							{
																								obj9 = 30;
																							}
																							goto IL_0d63;
																							IL_0fa0:
																							obj3 = 2;
																							__1__state = 2;
																							num2 = 26;
																							goto IL_0d5b;
																							end_IL_0d36:
																							break;
																						}
																						goto case 1;
																					}
																					IL_0c5d:
																					obj7 = obj18;
																					continue;
																				}
																				goto IL_0d28;
																				continue;
																				end_IL_0c61:
																				break;
																			}
																			goto end_IL_0c28;
																			IL_0d28:
																			obj7 = 2;
																			goto IL_0c61;
																			end_IL_0c28:;
																		}
																		finally
																		{
																			if ((nint)obj3 < 0)
																			{
																				object obj20 = 0;
																				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_07c1f539d4f94d95bde09a0fba07dbbc == 0)
																				{
																					obj20 = 9;
																				}
																				while (true)
																				{
																					switch ((int)obj20)
																					{
																					default:
																						if ((nint)obj21 == 991)
																						{
																							obj20 = obj21;
																							continue;
																						}
																						break;
																					case 0:
																						if (_timeout_5__6 == null)
																						{
																							obj20 = 3;
																							continue;
																						}
																						break;
																					case 2:
																						break;
																					case 3:
																						goto end_IL_1699;
																					case 1:
																						goto end_IL_1699;
																					}
																					(_timeout_5__6).Dispose();
																					obj20 = 7;
																					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_d2995c01469b4ef28b5784f7cbf606e2 != 0)
																					{
																						obj20 = 1;
																					}
																					continue;
																					end_IL_1699:
																					break;
																				}
																			}
																		}
																		goto end_IL_0bc3;
																	}
																	goto IL_0c1c;
																	continue;
																	end_IL_0bc3:
																	break;
																}
																goto end_IL_0b8a;
																IL_0c1c:
																obj6 = 2;
																goto IL_0bc3;
																end_IL_0b8a:;
															}
															finally
															{
																if ((nint)obj3 < 0)
																{
																	object obj23 = 5;
																	if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f3d80f367d504e3d9064e4cfb99ce343 == 0)
																	{
																		obj23 = 3;
																	}
																	while (true)
																	{
																		switch ((int)obj23)
																		{
																		default:
																			if ((nint)obj24 == 991)
																			{
																				obj23 = obj24;
																				continue;
																			}
																			goto case 3;
																		case 1:
																			break;
																		case 2:
																			(_pipe_5__5).Dispose();
																			obj23 = 0;
																			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1282ca3a3b4d42dea9c5c692937e35bc == 0)
																			{
																				obj23 = 9;
																			}
																			continue;
																		case 3:
																			if (_pipe_5__5 == null)
																			{
																				obj23 = 8;
																				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9201b2a1b9374af3a02f4d68ff67dfea == 0)
																				{
																					obj23 = 1;
																				}
																				continue;
																			}
																			goto case 2;
																		case 0:
																			break;
																		}
																		break;
																	}
																}
															}
															goto end_IL_092a;
														}
														IL_0926:
														obj5 = obj25;
														continue;
														IL_0922:
														obj25 = num3;
														goto IL_0926;
													}
													goto IL_0a00;
													continue;
													end_IL_092a:
													break;
												}
												goto end_IL_08f1;
												IL_0a00:
												obj5 = 18;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5e5cf2db569941efa91d919db7fefba0 != 0)
												{
													obj5 = 1;
												}
												goto IL_092a;
												end_IL_08f1:;
											}
											finally
											{
												if ((nint)obj3 < 0)
												{
													object obj29 = 0;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e22115a4e7ab476da94f74d7e328d269 != 0)
													{
														obj29 = 4;
													}
													while (true)
													{
														switch ((int)obj29)
														{
														default:
															if ((nint)obj30 == 991)
															{
																obj29 = obj30;
																continue;
															}
															goto end_IL_1842;
														case 0:
															if (_targetProcess_5__4 == null)
															{
																obj29 = 1;
																if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3416b7a32c7341febcabc34f89028832 == 0)
																{
																	obj29 = 8;
																}
																continue;
															}
															break;
														case 2:
															break;
														case 1:
															goto end_IL_1842;
														case 3:
															goto end_IL_1842;
														}
														(_targetProcess_5__4).Dispose();
														obj29 = 3;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_30453b5c95424721b20dac45933b18fc == 0)
														{
															obj29 = 7;
														}
														continue;
														end_IL_1842:
														break;
													}
												}
											}
											goto end_IL_0102;
										}
										IL_00fe:
										obj4 = obj31;
										continue;
										IL_00fa:
										obj31 = num4;
										goto IL_00fe;
									}
									goto IL_0184;
									continue;
									end_IL_0102:
									break;
								}
							}
							catch (global::System.Exception exception)
							{
								object obj46 = 0;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f7bdf7cbba314aacbe28a6672ff5f582 == 0)
								{
									obj46 = 0;
								}
								while (true)
								{
									int num5;
									switch ((int)obj46)
									{
									case 5:
										return;
									default:
										if ((nint)obj47 != 13)
										{
											if ((nint)obj47 == 993)
											{
												goto IL_1902;
											}
											goto case 4;
										}
										_pipe_5__5 = null;
										obj46 = 3;
										break;
									case 1:
										_process_5__3 = null;
										obj46 = 4;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ee050290791c4dfbba3a13b8d87cc1bd == 0)
										{
											obj46 = 4;
										}
										break;
									case 2:
										__t__builder.SetException(exception);
										num5 = 5;
										goto IL_18fe;
									case 3:
										_timeout_5__6 = null;
										obj46 = 2;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0609736616ee48cfa58bcf48cbf884e3 != 0)
										{
											obj46 = 5;
										}
										break;
									case 0:
										__1__state = -2;
										obj46 = 1;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b28f7b3c5e414da9823acaf82070b1eb != 0)
										{
											obj46 = 5;
										}
										break;
									case 4:
										{
											_targetProcess_5__4 = null;
											num5 = 13;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5e5cf2db569941efa91d919db7fefba0 == 0)
											{
												num5 = 3;
											}
											goto IL_18fe;
										}
										IL_18fe:
										obj47 = num5;
										goto IL_1902;
										IL_1902:
										obj46 = obj47;
										break;
									}
								}
							}
							goto case 1;
						case 6:
							obj3 = __1__state;
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
				_process_5__3 = null;
				num = 0;
				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9925520c809e49e19c0340f5f2a4c15c != 0)
				{
					num = 14;
				}
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
					obj2 = 3;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5abcb08dd0ae4b88988bbb89131b0cab != 0)
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
		internal static bool MAhdL6L2JAFXhy6XHHhg()
		{
			return b7ajLIL2WVtPFxWLZvE9 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object VgFhFuL2QSVEmNqrsgbp()
		{
			return b7ajLIL2WVtPFxWLZvE9;
		}
	}

	private const string GameProcessName = "Minecraft.Windows";

	private static McpInjectionService zOvdgFLvtUDbi0KgXf2W;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public unsafe global::System.Threading.Tasks.Task<Submission> InjectAndActivateAsync(string mcpPath, string managerAddress, string entryModule, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0009: Expected O, but got I4
		//IL_002e: Expected I4, but got O
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb->IL000d: Incompatible stack types: I4 vs O
		//IL_0065->IL000d: Incompatible stack types: I4 vs O
		//IL_012e->IL000d: Incompatible stack types: I4 vs O
		//IL_00bb->IL000d: Incompatible stack types: I4 vs O
		//IL_0107->IL000d: Incompatible stack types: I4 vs O
		//IL_0139->IL000d: Incompatible stack types: I4 vs O
		//IL_00c6->IL000d: Incompatible stack types: I4 vs O
		//IL_0112->IL000d: Incompatible stack types: I4 vs O
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
						if ((nint)obj != 13)
						{
							if ((nint)obj == 994)
							{
								goto end_IL_000d;
							}
							goto case 1;
						}
						return ((dynamic)obj3).__t__builder.Task;
					case 3:
						((dynamic)obj3).__t__builder = AsyncTaskMethodBuilder<Submission>.Create();
						obj2 = 2;
						continue;
					case 0:
						((dynamic)obj3).__t__builder.Start<_InjectAndActivateAsync_d__1>(ref obj3);
						num = 13;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b18c9101a9694aa1aae5a0a4ca0f1892 != 0)
						{
							num = 5;
						}
						break;
					case 5:
						((dynamic)obj3).managerAddress = managerAddress;
						obj2 = 4;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_067abd05646b4c3c8591d8097b64bf04 == 0)
						{
							obj2 = 4;
						}
						continue;
					case 1:
						((dynamic)obj3).cancellationToken = cancellationToken;
						num = 6;
						break;
					case 2:
						((dynamic)obj3).mcpPath = mcpPath;
						obj2 = 5;
						continue;
					case 6:
						((dynamic)obj3).__1__state = -1;
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1e22fe50e3d646ca9b01633c735c9082 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 4:
						((dynamic)obj3).entryModule = entryModule;
						obj2 = 1;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_6143552ba66645398402f7404618079f == 0)
						{
							obj2 = 13;
						}
						continue;
					}
					goto end_IL_0009;
					continue;
					end_IL_000d:
					break;
				}
				continue;
				end_IL_0009:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static void InjectDll(Process process, string dllPath)
	{
		//IL_033c: Expected I, but got O
		//IL_0009: Expected O, but got I4
		//IL_0026: Expected I4, but got O
		//IL_03ff: Expected I, but got O
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected I4, but got O
		//IL_0473: Expected O, but got I4
		//IL_0079: Expected I, but got O
		//IL_04b4: Expected O, but got I
		//IL_03d0: Expected I4, but got O
		//IL_0189: Expected O, but got I
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected I, but got O
		//IL_0235: Expected O, but got I4
		//IL_01e5: Expected I, but got O
		//IL_01e5: Expected I, but got O
		//IL_01e7: Expected O, but got I
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected O, but got I4
		//IL_0096: Expected O, but got I4
		//IL_00bb: Expected I4, but got O
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected I4, but got O
		//IL_0351->IL036e: Incompatible stack types: I4 vs O
		//IL_035c->IL036e: Incompatible stack types: I4 vs O
		//IL_03a6->IL03c3: Incompatible stack types: I4 vs O
		//IL_03b1->IL03c3: Incompatible stack types: I4 vs O
		//IL_0414->IL03c3: Incompatible stack types: I4 vs O
		//IL_041f->IL03c3: Incompatible stack types: I4 vs O
		//IL_0487->IL000d: Incompatible stack types: I4 vs O
		//IL_005d->IL000d: Incompatible stack types: I4 vs O
		//IL_04c8->IL000d: Incompatible stack types: I4 vs O
		//IL_0492->IL000d: Incompatible stack types: I4 vs O
		//IL_0088->IL009a: Incompatible stack types: I4 vs O
		//IL_04d3->IL000d: Incompatible stack types: I4 vs O
		//IL_0193->IL009a: Incompatible stack types: I4 vs O
		//IL_0274->IL009a: Incompatible stack types: I4 vs O
		//IL_0249->IL009a: Incompatible stack types: I4 vs O
		//IL_01fb->IL009a: Incompatible stack types: I4 vs O
		//IL_00f2->IL009a: Incompatible stack types: I4 vs O
		//IL_0325->IL02cd: Incompatible stack types: I4 vs O
		//IL_02b0->IL02cd: Incompatible stack types: I4 vs O
		//IL_0254->IL009a: Incompatible stack types: I4 vs O
		//IL_0206->IL009a: Incompatible stack types: I4 vs O
		//IL_0330->IL02cd: Incompatible stack types: I4 vs O
		//IL_02bb->IL02cd: Incompatible stack types: I4 vs O
		int num = 2;
		dynamic obj3 = default(object);
		dynamic obj4 = default(object);
		object obj9 = default(object);
		object obj6 = default(object);
		dynamic obj13 = default(object);
		object obj7 = default(object);
		dynamic obj10 = default(object);
		object obj12 = default(object);
		object obj15 = default(object);
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
								goto end_IL_000d;
							}
							goto case 3;
						}
						obj3 = VirtualAllocEx((process).Handle, global::System.IntPtr.Zero, (nuint)((global::System.Array)obj4).Length, AllocationType.Commit | AllocationType.Reserve, MemoryProtection.ReadWrite);
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9925520c809e49e19c0340f5f2a4c15c == 0)
						{
							obj2 = 5;
						}
						continue;
					case 0:
						if ((nint)obj3 == (nint)global::System.IntPtr.Zero)
						{
							obj2 = 3;
							continue;
						}
						obj9 = 1;
						obj2 = 4;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_6d6b99fc4578413f8bc3bdf9db0e7260 == 0)
						{
							obj2 = 11;
						}
						continue;
					case 4:
						try
						{
							nuint written;
							object obj5;
							if (!WriteProcessMemory((process).Handle, (nint)obj3, (byte[])obj4, (nuint)((global::System.Array)obj4).Length, out written))
							{
								obj5 = 6;
								goto IL_009a;
							}
							goto IL_0254;
							IL_0254:
							if (((dynamic)written).ToUInt64() != (ulong)((global::System.Array)obj4).Length)
							{
								obj5 = 4;
							}
							else
							{
								obj6 = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryW");
								obj5 = 5;
							}
							goto IL_009a;
							IL_009a:
							while (true)
							{
								switch ((int)obj5)
								{
								default:
									if ((nint)obj13 != 14)
									{
										if ((nint)obj13 == 994)
										{
											goto IL_0096;
										}
										goto case 5;
									}
									throw new Win32Exception(System.Runtime.InteropServices.Marshal.GetLastWin32Error(), "CreateRemoteThread 失败");
								case 5:
								{
									if ((nint)obj6 == (nint)global::System.IntPtr.Zero)
									{
										obj5 = 2;
										continue;
									}
									uint threadId;
									obj7 = CreateRemoteThread((process).Handle, global::System.IntPtr.Zero, global::System.UIntPtr.Zero, (nint)obj6, (nint)obj3, 0u, out threadId);
									obj5 = 3;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_861620835107408fad0813077d9e9967 != 0)
									{
										obj5 = 1;
									}
									continue;
								}
								case 4:
								case 6:
									throw new Win32Exception(System.Runtime.InteropServices.Marshal.GetLastWin32Error(), "WriteProcessMemory 失败");
								case 2:
									throw new Win32Exception(System.Runtime.InteropServices.Marshal.GetLastWin32Error(), "LoadLibraryW 地址获取失败");
								case 1:
									break;
								case 3:
									if ((nint)obj7 == (nint)global::System.IntPtr.Zero)
									{
										obj13 = 14;
										goto IL_0096;
									}
									obj9 = 0;
									obj5 = 0;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0b81b3b6b3bc4c4a8075444d576cb8ec == 0)
									{
										obj5 = 1;
									}
									continue;
								case 0:
									{
										try
										{
											object obj8;
											if (WaitForSingleObject((nint)obj7, 10000u) != 0)
											{
												obj8 = 1;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_6883c26806134cb3b7f5e7b631c19374 != 0)
												{
													obj8 = 0;
												}
											}
											else
											{
												obj9 = 1;
												obj8 = 0;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e041d974da614bb9aad5f28559bec3d0 == 0)
												{
													obj8 = 0;
												}
											}
											while (true)
											{
												switch ((int)obj8)
												{
												default:
													if ((nint)obj10 != 989)
													{
														return;
													}
													break;
												case 1:
													throw new TimeoutException("Host DLL 加载超时");
												case 0:
													return;
												}
												obj8 = obj10;
											}
										}
										finally
										{
											CloseHandle((nint)obj7);
											dynamic obj11 = 2;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_36a48f7fc5034120a3fadb53ab2f53cc == 0)
											{
												obj11 = 0;
											}
											while (true)
											{
												switch ((int)obj11)
												{
												default:
													if ((nint)obj12 == 988)
													{
														obj11 = obj12;
														continue;
													}
													break;
												case 0:
													break;
												}
												break;
											}
										}
									}
									IL_0096:
									obj5 = obj13;
									continue;
								}
								break;
							}
							goto IL_0254;
						}
						finally
						{
							if (obj9 != null)
							{
								object obj14 = 0;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1282ca3a3b4d42dea9c5c692937e35bc == 0)
								{
									obj14 = 7;
								}
								while (true)
								{
									switch ((int)obj14)
									{
									default:
										if ((nint)obj15 == 989)
										{
											obj14 = obj15;
											continue;
										}
										break;
									case 0:
										VirtualFreeEx((process).Handle, (nint)obj3, global::System.UIntPtr.Zero, FreeType.Release);
										obj14 = 1;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f981d20d38124e3ab94f0d411fda50cf == 0)
										{
											obj14 = 0;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
						}
					case 3:
						throw new Win32Exception(System.Runtime.InteropServices.Marshal.GetLastWin32Error(), "VirtualAllocEx 失败");
					case 2:
						break;
					case 1:
						return;
					}
					goto end_IL_0009;
					continue;
					end_IL_000d:
					break;
				}
				continue;
				end_IL_0009:
				break;
			}
			obj4 = (System.Text.Encoding.Unicode).GetBytes(string.Concat(dllPath, "\u0000"));
			num = 1;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_c4494c1a50534bb9a384a17479cb6f24 == 0)
			{
				num = 11;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static bool TryIs64Bit(Process process, out bool value)
	{
		//IL_0009: Expected O, but got I4
		//IL_0022: Expected I4, but got O
		//IL_0048: Expected F4, but got I4
		//IL_009b: Expected F4, but got I4
		//IL_00af->IL000d: Incompatible stack types: I4 vs O
		//IL_00ba->IL000d: Incompatible stack types: I4 vs O
		int num = 3;
		ushort processMachine = default(ushort);
		ushort nativeMachine = default(ushort);
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
								goto end_IL_000d;
							}
						}
						else if (IsWow64Process2((process).Handle, out processMachine, out nativeMachine))
						{
							num = 2;
							break;
						}
						goto case 1;
					case 0:
						value = default;
						return true;
					case 3:
						value = default;
						num = 10;
						break;
					case 1:
						value = default;
						return false;
					case 2:
						value = default;
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2aab0405e3774254ad8ff3552d808a1d != 0)
						{
							obj2 = 0;
						}
						continue;
					}
					goto end_IL_0009;
					continue;
					end_IL_000d:
					break;
				}
				continue;
				end_IL_0009:
				break;
			}
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern nint VirtualAllocEx(nint hProcess, nint address, nuint size, AllocationType type, MemoryProtection protection);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool VirtualFreeEx(nint hProcess, nint address, nuint size, FreeType type);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(nint process, nint address, byte[] buffer, nuint size, out nuint written);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern nint CreateRemoteThread(nint process, nint attributes, nuint stackSize, nint startAddress, nint parameter, uint flags, out uint threadId);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern uint WaitForSingleObject(nint handle, uint milliseconds);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool CloseHandle(nint handle);

	[DllImport("kernel32.dll", CharSet = (CharSet)3, SetLastError = true)]
	private static extern nint GetModuleHandle(string moduleName);

	[DllImport("kernel32.dll", CharSet = (CharSet)2, SetLastError = true)]
	private static extern nint GetProcAddress(nint module, string name);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool IsWow64Process2(nint process, out ushort processMachine, out ushort nativeMachine);

	[MethodImpl((MethodImplOptions)8)]
	public McpInjectionService()
	{
		//IL_0049: Expected I4, but got O
		//IL_002e->IL0040: Incompatible stack types: I4 vs O
		//IL_0039->IL0040: Incompatible stack types: I4 vs O
		object obj = 6;
		if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_a4b5b9d8fe0344d0a0d0c6ee7728050b == 0)
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
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool VndUFjLvOyJlQqytVeMX()
	{
		return zOvdgFLvtUDbi0KgXf2W == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static McpInjectionService RXxlFNLv5sO38a72sd4S()
	{
		return null;
	}
}

