using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using NiE0orfhjEwcWUDkCndi;
using R2PdoCXB02FAdCljtHb2;
using T4Mj3tf4RemhVMgXlewO;
using TdQhOgfAI9Rngp46SBAy;
using V4sdXyf4Krfx4OiV2unk;
using VCFmlEfhekD30m3fSKlw;
using VjvmXEfhkkns3ZRaJhNJ;
using bUfedyCg1PBqhqIkB8r;
using cNcEm6fmp9kQApOhUoVW;
using fBY7VYf4BbXwyEfdFkWM;
using fDAldojjppXrctUVYOJn;
using iJXuu1f4trUfDfuqFlsj;
using mdXrpVf4xrJgmIWAd0EM;
using mtlA7efyMYGWkHnY8kS6;
using nlcTPCf4auiT2KYnbeja;
using q3qem4f45QsWhDFSdMl2;
using qFTnN9fWCLGPpXU6fRrH;
using r8IBAqfWmsX5Q657ItyO;
using xHfZwVfWegoMRYhf0neX;
using xMk5tkfUVNH7XY6TZJsA;

namespace FSw4J3fW1htliab5uZTN;

sealed class sNLGTJfWaoJbt7Xwwgik : global::System.IDisposable
{
	private sealed class C0bnUBLcdulm1GSDbYP8 : IEquatable<C0bnUBLcdulm1GSDbYP8>
	{
		[CompilerGenerated]
		private uint _PacketId_k__BackingField;

		[CompilerGenerated]
		private byte[] _HeaderBytes_k__BackingField;

		[CompilerGenerated]
		private byte[] _Body_k__BackingField;

		private static object mf1nESDQJiiSixtl8dRq;

		[CompilerGenerated]
		private global::System.Type EqualityContract
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return System.Type.GetTypeFromHandle(typeof(C0bnUBLcdulm1GSDbYP8).TypeHandle);
			}
		}

		public uint PacketId
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _PacketId_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				_PacketId_k__BackingField = value;
			}
		}

		public byte[] HeaderBytes
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _HeaderBytes_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				_HeaderBytes_k__BackingField = value;
			}
		}

		public byte[] Body
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Body_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				_Body_k__BackingField = value;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public C0bnUBLcdulm1GSDbYP8(uint PacketId, byte[] HeaderBytes, byte[] Body)
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
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
		private bool Ws0LcKLWJkm(StringBuilder builder)
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
							if (num2 != 13)
							{
								if (num2 == 994)
								{
									goto end_IL_0010;
								}
								goto case 2;
							}
							(builder).Append(", HeaderBytes = ");
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
							{
								num3 = 6;
							}
							continue;
						case 2:
							System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
							{
								num3 = 11;
							}
							continue;
						case 4:
							(builder).Append(", Body = ");
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
							{
								num3 = 5;
							}
							continue;
						case 3:
							return true;
						case 0:
							(builder).Append(Body);
							num3 = 3;
							continue;
						case 5:
							(builder).Append(HeaderBytes);
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
							{
								num3 = 4;
							}
							continue;
						case 1:
							(builder).Append("PacketId = ");
							num3 = 6;
							continue;
						case 6:
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
				(builder).Append(((object)PacketId/*cast due to .constrained prefix*/).ToString());
				num = 13;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator !=(C0bnUBLcdulm1GSDbYP8? left, C0bnUBLcdulm1GSDbYP8? right)
		{
			return !(left == right);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator ==(C0bnUBLcdulm1GSDbYP8? left, C0bnUBLcdulm1GSDbYP8? right)
		{
			int num = 2;
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<uint>.Default.GetHashCode(_PacketId_k__BackingField)) * -1521134295 + EqualityComparer<byte[]>.Default.GetHashCode(_HeaderBytes_k__BackingField)) * -1521134295 + EqualityComparer<byte[]>.Default.GetHashCode(_Body_k__BackingField);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as C0bnUBLcdulm1GSDbYP8);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public bool Equals(C0bnUBLcdulm1GSDbYP8? other)
		{
			int num = 5;
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public C0bnUBLcdulm1GSDbYP8 EYfLcHn23nK()
		{
			return (C0bnUBLcdulm1GSDbYP8)new C0bnUBLcdulm1GSDbYP8(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private C0bnUBLcdulm1GSDbYP8(C0bnUBLcdulm1GSDbYP8 original)
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 3;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
			{
				num = 2;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					switch (num2)
					{
					case 990:
						break;
					default:
						return;
					case 10:
						_Body_k__BackingField = original._Body_k__BackingField;
						num = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
						{
							num = 0;
						}
						goto end_IL_0046;
					}
					goto IL_0042;
				case 1:
				{
					_HeaderBytes_k__BackingField = original._HeaderBytes_k__BackingField;
					int num3 = 10;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
					{
						num3 = 3;
					}
					num2 = num3;
					goto IL_0042;
				}
				case 2:
					_PacketId_k__BackingField = original._PacketId_k__BackingField;
					num = 8;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
					{
						num = 1;
					}
					break;
				case 0:
					return;
					IL_0042:
					num = num2;
					break;
					end_IL_0046:
					break;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public void LJsLctE0yYB(out uint PacketId, out byte[] HeaderBytes, out byte[] Body)
		{
		PacketId = default(uint);
		HeaderBytes = default(byte[]);
		Body = default(byte[]);
			//IL_0008: Expected I8, but got O
Body = this.Body;  // was Unsafe.As<_,long> reinterpret
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool TVXNtGDQQW0BgijXEchy()
		{
			return mf1nESDQJiiSixtl8dRq == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static C0bnUBLcdulm1GSDbYP8 AGYgnqDQCbB5Bmk7bmpa()
		{
			return (C0bnUBLcdulm1GSDbYP8)mf1nESDQJiiSixtl8dRq;
		}
	}

	private sealed class IRDioILcOhJp3huAFEli : IEquatable<IRDioILcOhJp3huAFEli>
	{
		[CompilerGenerated]
		private byte? _PrefixByte_k__BackingField;

		[CompilerGenerated]
		private S3TYvPf4dw0Js0IbGOQN _Algo_k__BackingField;

		[CompilerGenerated]
		private bool _RawDeflate_k__BackingField;

		[CompilerGenerated]
		private List<C0bnUBLcdulm1GSDbYP8> _Packets_k__BackingField;

		private static object HkUXu8DQ4ytuEW4khyNY;

		[CompilerGenerated]
		private global::System.Type EqualityContract
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return System.Type.GetTypeFromHandle(typeof(IRDioILcOhJp3huAFEli).TypeHandle);
			}
		}

		public byte? PrefixByte
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _PrefixByte_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				_PrefixByte_k__BackingField = value;
			}
		}

		public S3TYvPf4dw0Js0IbGOQN Algo
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Algo_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				_Algo_k__BackingField = value;
			}
		}

		public bool RawDeflate
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _RawDeflate_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				_RawDeflate_k__BackingField = value;
			}
		}

		public List<C0bnUBLcdulm1GSDbYP8> Packets
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Packets_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				_Packets_k__BackingField = value;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public IRDioILcOhJp3huAFEli(byte? PrefixByte, S3TYvPf4dw0Js0IbGOQN Algo, bool RawDeflate, List<C0bnUBLcdulm1GSDbYP8> Packets)
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
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
		private bool QuZLc5vl9Wk(StringBuilder builder)
		{
			int num = 5;
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
								goto case 0;
							}
							return true;
						case 2:
							(builder).Append(", Packets = ");
							num = 3;
							break;
						case 7:
							(builder).Append(((object)RawDeflate/*cast due to .constrained prefix*/).ToString());
							num3 = 2;
							continue;
						case 4:
							(builder).Append("PrefixByte = ");
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
							{
								num3 = 4;
							}
							continue;
						case 6:
							(builder).Append(", Algo = ");
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
							{
								num3 = 7;
							}
							continue;
						case 1:
							(builder).Append(((object)PrefixByte/*cast due to .constrained prefix*/).ToString());
							num3 = 6;
							continue;
						case 3:
							(builder).Append(Packets);
							num = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
							{
								num = 15;
							}
							break;
						case 8:
							(builder).Append(", RawDeflate = ");
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
							{
								num3 = 7;
							}
							continue;
						case 0:
							(builder).Append(((object)Algo/*cast due to .constrained prefix*/).ToString());
							num3 = 15;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
							{
								num3 = 8;
							}
							continue;
						case 5:
							System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
							num = 4;
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
		public static bool operator !=(IRDioILcOhJp3huAFEli? left, IRDioILcOhJp3huAFEli? right)
		{
			return !(left == right);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator ==(IRDioILcOhJp3huAFEli? left, IRDioILcOhJp3huAFEli? right)
		{
			int num = 2;
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<byte?>.Default.GetHashCode(_PrefixByte_k__BackingField)) * -1521134295 + EqualityComparer<S3TYvPf4dw0Js0IbGOQN>.Default.GetHashCode(_Algo_k__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(_RawDeflate_k__BackingField)) * -1521134295 + EqualityComparer<List<C0bnUBLcdulm1GSDbYP8>>.Default.GetHashCode(_Packets_k__BackingField);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as IRDioILcOhJp3huAFEli);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public bool Equals(IRDioILcOhJp3huAFEli? other)
		{
			int num = 5;
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public IRDioILcOhJp3huAFEli PXNLc6XSCCC()
		{
			return (IRDioILcOhJp3huAFEli)new IRDioILcOhJp3huAFEli(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private IRDioILcOhJp3huAFEli(IRDioILcOhJp3huAFEli original)
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 5;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
			{
				num = 1;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					switch (num2)
					{
					case 991:
						break;
					default:
						return;
					case 11:
						_RawDeflate_k__BackingField = original._RawDeflate_k__BackingField;
						num = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
						{
							num = 3;
						}
						goto end_IL_0046;
					}
					goto IL_0042;
				case 2:
					return;
				case 3:
					_Packets_k__BackingField = original._Packets_k__BackingField;
					num = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
					{
						num = 2;
					}
					break;
				case 1:
					_PrefixByte_k__BackingField = original._PrefixByte_k__BackingField;
					num = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
					{
						num = 2;
					}
					break;
				case 0:
					{
						_Algo_k__BackingField = original._Algo_k__BackingField;
						num2 = 11;
						goto IL_0042;
					}
					IL_0042:
					num = num2;
					break;
					end_IL_0046:
					break;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public void MkeLcR1rdN5(out byte? PrefixByte, out S3TYvPf4dw0Js0IbGOQN Algo, out bool RawDeflate, out List<C0bnUBLcdulm1GSDbYP8> Packets)
		{
		PrefixByte = default(byte?);
		Algo = default(S3TYvPf4dw0Js0IbGOQN);
		RawDeflate = default(bool);
		Packets = default(List<C0bnUBLcdulm1GSDbYP8>);
			PrefixByte = this.PrefixByte;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool MVdJgTDQhBXBbUUM9NLB()
		{
			return HkUXu8DQ4ytuEW4khyNY == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static IRDioILcOhJp3huAFEli D66RlYDQU84QroB8B49X()
		{
			return (IRDioILcOhJp3huAFEli)HkUXu8DQ4ytuEW4khyNY;
		}
	}

	private sealed class ST9PBRLcw5s1twpPIgr6 : IEquatable<ST9PBRLcw5s1twpPIgr6>
	{
		[CompilerGenerated]
		private string _Label_k__BackingField;

		[CompilerGenerated]
		private byte[] _SessionKey_k__BackingField;

		private static object OvgT5BDQrOgrrRTWpiMK;

		[CompilerGenerated]
		private global::System.Type EqualityContract
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return System.Type.GetTypeFromHandle(typeof(ST9PBRLcw5s1twpPIgr6).TypeHandle);
			}
		}

		public string Label
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Label_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				_Label_k__BackingField = value;
			}
		}

		public byte[] SessionKey
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _SessionKey_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				_SessionKey_k__BackingField = value;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public ST9PBRLcw5s1twpPIgr6(string Label, byte[] SessionKey)
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
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
		private bool hbRLceAKKF2(StringBuilder builder)
		{
			System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator !=(ST9PBRLcw5s1twpPIgr6? left, ST9PBRLcw5s1twpPIgr6? right)
		{
			return !(left == right);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator ==(ST9PBRLcw5s1twpPIgr6? left, ST9PBRLcw5s1twpPIgr6? right)
		{
			int num = 1;
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_Label_k__BackingField)) * -1521134295 + EqualityComparer<byte[]>.Default.GetHashCode(_SessionKey_k__BackingField);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as ST9PBRLcw5s1twpPIgr6);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public bool Equals(ST9PBRLcw5s1twpPIgr6? other)
		{
			int num = 5;
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public ST9PBRLcw5s1twpPIgr6 pB7LcP8ZAhF()
		{
			return (ST9PBRLcw5s1twpPIgr6)new ST9PBRLcw5s1twpPIgr6(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private ST9PBRLcw5s1twpPIgr6(ST9PBRLcw5s1twpPIgr6 original)
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
			{
				num = 1;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					if (num2 == 990)
					{
						num = num2;
						continue;
					}
					break;
				case 1:
					return;
				case 2:
					_SessionKey_k__BackingField = original._SessionKey_k__BackingField;
					num = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
					{
						num = 7;
					}
					continue;
				case 0:
					break;
				}
				_Label_k__BackingField = original._Label_k__BackingField;
				num = 2;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public void gxLLcxLQBc3(out string Label, out byte[] SessionKey)
		{
		Label = default(string);
		SessionKey = default(byte[]);
			//IL_0008: Expected I8, but got O
Label = this.Label;  // was Unsafe.As<_,long> reinterpret
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool lj9NM2DQoNqtnHcQ4QhC()
		{
			return OvgT5BDQrOgrrRTWpiMK == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static ST9PBRLcw5s1twpPIgr6 EdVif2DQmNUZf6DTX1D7()
		{
			return (ST9PBRLcw5s1twpPIgr6)OvgT5BDQrOgrrRTWpiMK;
		}
	}

	private struct WRVTklLcFMXgaYLUqPlB : IEquatable<WRVTklLcFMXgaYLUqPlB>
	{
		[CompilerGenerated]
		private N3Mce4f4O1LbsKljGcTC _PrefixKind_k__BackingField;

		[CompilerGenerated]
		private int _LengthFieldOffset_k__BackingField;

		[CompilerGenerated]
		private int _PayloadOffset_k__BackingField;

		[CompilerGenerated]
		private int _PayloadLength_k__BackingField;

		[CompilerGenerated]
		private JsonObject _Root_k__BackingField;

		[CompilerGenerated]
		private JsonArray _Chain_k__BackingField;

		[CompilerGenerated]
		private JsonObject? _CertificateRoot_k__BackingField;

		internal static object NqgfKFDQ7QbXYRBNvELo;

		public N3Mce4f4O1LbsKljGcTC PrefixKind
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _PrefixKind_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				_PrefixKind_k__BackingField = value;
			}
		}

		public int LengthFieldOffset
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _LengthFieldOffset_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				_LengthFieldOffset_k__BackingField = value;
			}
		}

		public int PayloadOffset
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _PayloadOffset_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				_PayloadOffset_k__BackingField = value;
			}
		}

		public int PayloadLength
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _PayloadLength_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				_PayloadLength_k__BackingField = value;
			}
		}

		public JsonObject Root
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Root_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				_Root_k__BackingField = value;
			}
		}

		public JsonArray Chain
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Chain_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				_Chain_k__BackingField = value;
			}
		}

		public JsonObject? CertificateRoot
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _CertificateRoot_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				_CertificateRoot_k__BackingField = value;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public WRVTklLcFMXgaYLUqPlB(N3Mce4f4O1LbsKljGcTC PrefixKind, int LengthFieldOffset, int PayloadOffset, int PayloadLength, JsonObject Root, JsonArray Chain, JsonObject? CertificateRoot)
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
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
		private bool yYLLcs0b1nx(StringBuilder builder)
		{
			int num = 13;
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
							if (num2 != 20)
							{
								if (num2 == 1001)
								{
									goto end_IL_0010;
								}
								goto case 11;
							}
							(builder).Append(((object)PayloadOffset/*cast due to .constrained prefix*/).ToString());
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
							{
								num3 = 10;
							}
							continue;
						case 10:
							(builder).Append(", PayloadLength = ");
							num3 = 11;
							continue;
						case 2:
							(builder).Append(Chain);
							num3 = 9;
							continue;
						case 0:
							(builder).Append(Root);
							num3 = 5;
							continue;
						case 13:
							(builder).Append("PrefixKind = ");
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
							{
								num3 = 12;
							}
							continue;
						case 9:
							(builder).Append(", CertificateRoot = ");
							num3 = 3;
							continue;
						case 12:
							(builder).Append(((object)PrefixKind/*cast due to .constrained prefix*/).ToString());
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
							{
								num3 = 10;
							}
							continue;
						case 7:
							(builder).Append(", Root = ");
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 != 0)
							{
								num3 = 15;
							}
							continue;
						case 11:
							(builder).Append(((object)PayloadLength/*cast due to .constrained prefix*/).ToString());
							num3 = 7;
							continue;
						case 3:
							(builder).Append(CertificateRoot);
							num3 = 8;
							continue;
						case 1:
							break;
						case 8:
							return true;
						case 4:
							(builder).Append(", LengthFieldOffset = ");
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea != 0)
							{
								num3 = 6;
							}
							continue;
						case 5:
							(builder).Append(", Chain = ");
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
							{
								num3 = 2;
							}
							continue;
						case 6:
							(builder).Append(((object)LengthFieldOffset/*cast due to .constrained prefix*/).ToString());
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
							{
								num3 = 17;
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
				(builder).Append(", PayloadOffset = ");
				num = 20;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator !=(WRVTklLcFMXgaYLUqPlB left, WRVTklLcFMXgaYLUqPlB right)
		{
			return !(left == right);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator ==(WRVTklLcFMXgaYLUqPlB left, WRVTklLcFMXgaYLUqPlB right)
		{
			return left.Equals(right);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((EqualityComparer<N3Mce4f4O1LbsKljGcTC>.Default.GetHashCode(_PrefixKind_k__BackingField) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(_LengthFieldOffset_k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(_PayloadOffset_k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(_PayloadLength_k__BackingField)) * -1521134295 + EqualityComparer<JsonObject>.Default.GetHashCode(_Root_k__BackingField)) * -1521134295 + EqualityComparer<JsonArray>.Default.GetHashCode(_Chain_k__BackingField)) * -1521134295 + EqualityComparer<JsonObject>.Default.GetHashCode(_CertificateRoot_k__BackingField);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			int num = 1;
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public bool Equals(WRVTklLcFMXgaYLUqPlB other)
		{
			int num = 5;
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public void dLvLcT4ye4s(out N3Mce4f4O1LbsKljGcTC PrefixKind, out int LengthFieldOffset, out int PayloadOffset, out int PayloadLength, out JsonObject Root, out JsonArray Chain, out JsonObject? CertificateRoot)
		{
		PrefixKind = default(N3Mce4f4O1LbsKljGcTC);
		LengthFieldOffset = default(int);
		PayloadOffset = default(int);
		PayloadLength = default(int);
		Root = default(JsonObject);
		Chain = default(JsonArray);
		CertificateRoot = default(JsonObject?);
			//IL_0009: Expected I8, but got O
			Root = (JsonObject)(long)this.Root;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool en13SMDQAjL7ORyxGZRc()
		{
			return NqgfKFDQ7QbXYRBNvELo == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object TlaQUlDQItTvhmLZJN4B()
		{
			return NqgfKFDQ7QbXYRBNvELo;
		}
	}

	private sealed class LGs51pLcNObAM6UTLTsO
	{
		[CompilerGenerated]
		private readonly byte SpcLcpL8mQi;

		[CompilerGenerated]
		private readonly byte[] h7iLcuhkExS;

		[CompilerGenerated]
		private byte[] wZkLca3LHH5;

		[CompilerGenerated]
		private Jgaq6ef4PuO0JxER8Odt? GEcLc18q31d;

		internal static object Moxj4pDQBIsyjx1oUS9p;

		public byte Flags
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return SpcLcpL8mQi;
			}
		}

		public byte[] HeaderSuffix
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return h7iLcuhkExS;
			}
		}

		public byte[] Payload
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return wZkLca3LHH5;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				wZkLca3LHH5 = value;
			}
		}

		public Jgaq6ef4PuO0JxER8Odt? Fragment
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return GEcLc18q31d;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			private set
			{
				GEcLc18q31d = value;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public LGs51pLcNObAM6UTLTsO(byte flags, byte[] headerSuffix, byte[] payload, Jgaq6ef4PuO0JxER8Odt? fragment)
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public void zEKLcMUZTN5(Jgaq6ef4PuO0JxER8Odt fragment)
		{
			int num = default(int);
			System.Buffers.Binary.BinaryPrimitives.WriteUInt32BigEndian(MemoryExtensions.AsSpan<byte>(HeaderSuffix, num, 4), fragment.CompoundSize);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool YKlTmODQg9h2QmdnoI96()
		{
			return Moxj4pDQBIsyjx1oUS9p == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static LGs51pLcNObAM6UTLTsO lBhU2RDQl697ATFKUGtl()
		{
			return (LGs51pLcNObAM6UTLTsO)Moxj4pDQBIsyjx1oUS9p;
		}
	}

	private struct ktoDtILc38S9Lmcxx778 : IEquatable<ktoDtILc38S9Lmcxx778>
	{
		[CompilerGenerated]
		private bool _Single_k__BackingField;

		[CompilerGenerated]
		private uint _Start_k__BackingField;

		[CompilerGenerated]
		private uint _End_k__BackingField;

		private static object Y2LLFYDQdUkPC0VDoqOp;

		public bool Single
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Single_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				_Single_k__BackingField = value;
			}
		}

		public uint Start
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Start_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				_Start_k__BackingField = value;
			}
		}

		public uint End
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _End_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				_End_k__BackingField = value;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public ktoDtILc38S9Lmcxx778(bool Single, uint Start, uint End)
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
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
		private bool GXeLcvGoxjh(StringBuilder builder)
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
							if (num2 != 12)
							{
								if (num2 == 993)
								{
									goto end_IL_0010;
								}
								goto case 5;
							}
							return true;
						case 3:
							(builder).Append(((object)Start/*cast due to .constrained prefix*/).ToString());
							num3 = 4;
							continue;
						case 2:
							break;
						case 5:
							(builder).Append(", Start = ");
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
							{
								num3 = 1;
							}
							continue;
						case 4:
							(builder).Append(", End = ");
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
							{
								num3 = 2;
							}
							continue;
						case 1:
							(builder).Append("Single = ");
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 != 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							(builder).Append(((object)Single/*cast due to .constrained prefix*/).ToString());
							num3 = 5;
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
				(builder).Append(((object)End/*cast due to .constrained prefix*/).ToString());
				num = 12;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
				{
					num = 7;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator !=(ktoDtILc38S9Lmcxx778 left, ktoDtILc38S9Lmcxx778 right)
		{
			return !(left == right);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator ==(ktoDtILc38S9Lmcxx778 left, ktoDtILc38S9Lmcxx778 right)
		{
			return left.Equals(right);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<bool>.Default.GetHashCode(_Single_k__BackingField) * -1521134295 + EqualityComparer<uint>.Default.GetHashCode(_Start_k__BackingField)) * -1521134295 + EqualityComparer<uint>.Default.GetHashCode(_End_k__BackingField);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			int num = 1;
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public bool Equals(ktoDtILc38S9Lmcxx778 other)
		{
			int num = 4;
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public void jKHLcEFR4ZE(out bool Single, out uint Start, out uint End)
		{
		Single = default(bool);
		Start = default(uint);
		End = default(uint);
			//IL_0008: Expected F4, but got I4
			global::System.Runtime.CompilerServices.Unsafe.As<bool, float>(ref Single) = (this.Single ? 1 : 0);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool lx6DWCDQKVxsPQlfxkWM()
		{
			return Y2LLFYDQdUkPC0VDoqOp == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object NjYDZXDQHPiyOFLICnhp()
		{
			return Y2LLFYDQdUkPC0VDoqOp;
		}
	}

	sealed class TdTSlkLc2StmA5SrVSYT : global::System.IDisposable
	{
		[CompilerGenerated]
		private readonly IncrementalHash ioALcqyKljX;

		[CompilerGenerated]
		private readonly IncrementalHash cGwLcGWRdWr;

		private static object pFr0N5DQttSVvIXn9Itp;

		public IncrementalHash SourceHash
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return ioALcqyKljX;
			}
		}

		public IncrementalHash DestHash
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return cGwLcGWRdWr;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public TdTSlkLc2StmA5SrVSYT(ulong sourceCounter, ulong destCounter)
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Dispose()
		{
			(SourceHash).Dispose();
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool KA1HUXDQOi15LOet2p0E()
		{
			return pFr0N5DQttSVvIXn9Itp == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static TdTSlkLc2StmA5SrVSYT PO932SDQ5uH6TiyTJ9Xx()
		{
			return (TdTSlkLc2StmA5SrVSYT)pFr0N5DQttSVvIXn9Itp;
		}
	}

	private sealed class TNklJaLcijACavTXFn8J
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class __c_1
		{
			public static readonly __c_1 __9;

			public static Comparison<ValueTuple<LGs51pLcNObAM6UTLTsO, int>> __9__2_0;

			public static Comparison<gmRncnL0L6qQC50Niggx> __9__2_1;

			internal static __c_1 OukDsmD7Yp0jmn73qH9G;

			[MethodImpl((MethodImplOptions)8)]
			private static void _cctor()
			{
				// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
				// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
				throw new global::System.NotSupportedException();
			}

			[MethodImpl((MethodImplOptions)8)]
			public __c_1()
			{
				// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
				// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
				throw new global::System.NotSupportedException();
			}

			[MethodImpl((MethodImplOptions)8)]
			internal int U1FLCMcNKLf(ValueTuple<LGs51pLcNObAM6UTLTsO, int> a, ValueTuple<LGs51pLcNObAM6UTLTsO, int> b)
			{
				Jgaq6ef4PuO0JxER8Odt jgaq6ef4PuO0JxER8Odt = default(Jgaq6ef4PuO0JxER8Odt);
				uint fragmentIndex = jgaq6ef4PuO0JxER8Odt.FragmentIndex;
				return default(int);
			}

			[MethodImpl((MethodImplOptions)8)]
			internal int mSDLCpUJMJP(gmRncnL0L6qQC50Niggx left, gmRncnL0L6qQC50Niggx right)
			{
				uint num = oGWL0Xx7crZ(left);
				return default(int);
			}

			[MethodImpl((MethodImplOptions)8)]
			internal static bool xhMpHsD7Sur6Zcsp8dyk()
			{
				return OukDsmD7Yp0jmn73qH9G == null;
			}

			[MethodImpl((MethodImplOptions)8)]
			internal static __c_1 L8oywlD7cD3ebpGPGro0()
			{
				return OukDsmD7Yp0jmn73qH9G;
			}
		}

		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0
		{
			public HashSet<LGs51pLcNObAM6UTLTsO> selectedFrames;

			public Predicate<LGs51pLcNObAM6UTLTsO> __9__2;

			internal static __c__DisplayClass2_0 RaoQ5YD70JmNghORv1eK;

			[MethodImpl((MethodImplOptions)8)]
			public __c__DisplayClass2_0()
			{
				// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
				// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
				throw new global::System.NotSupportedException();
			}

			[MethodImpl((MethodImplOptions)8)]
			internal bool addLCuUJOnK(LGs51pLcNObAM6UTLTsO frame)
			{
				return !selectedFrames.Contains(frame);
			}

			[MethodImpl((MethodImplOptions)8)]
			private static void _cctor()
			{
				// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
				// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
				throw new global::System.NotSupportedException();
			}

			[MethodImpl((MethodImplOptions)8)]
			internal static bool E6jMJ0D78NBKPZPRGhwf()
			{
				return RaoQ5YD70JmNghORv1eK == null;
			}

			[MethodImpl((MethodImplOptions)8)]
			internal static __c__DisplayClass2_0 NDf3ysD7yUFubqFbQw2s()
			{
				return RaoQ5YD70JmNghORv1eK;
			}
		}

		private readonly List<gmRncnL0L6qQC50Niggx> H81L0fbm264;

		internal static object iC6103DQ6xF11IQmPCTi;

		[MethodImpl((MethodImplOptions)8)]
		public void fFcLcnFJui5(byte packetId, uint sequenceNumber, List<LGs51pLcNObAM6UTLTsO> frames)
		{
			H81L0fbm264.Add((gmRncnL0L6qQC50Niggx)new gmRncnL0L6qQC50Niggx(packetId, sequenceNumber, frames));
		}

		[MethodImpl((MethodImplOptions)8)]
		public List<byte[]> FQaLczskCYQ(byte[] assembledPayload, out int forwardedSplitFragments, out int sequencePaddingDatagrams)
		{
		// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
		// semantics of this body (see MAHIRO-V2-BUILD.md).
		throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		private static LGs51pLcNObAM6UTLTsO vU8L0bBCyOT()
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			byte[] array = default(byte[]);
			global::System.Span<byte> span = MemoryExtensions.AsSpan<byte>(array, 1);
			DateTimeOffset val = System.DateTimeOffset.UtcNow;
			System.Buffers.Binary.BinaryPrimitives.WriteInt64BigEndian(span, (val).ToUnixTimeMilliseconds());
			return null;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static uint oGWL0Xx7crZ(object datagram)
		{
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			int num = 3;
			uint num4 = default(uint);
			global::System.Collections.Generic.IEnumerator<LGs51pLcNObAM6UTLTsO> enumerator = default(global::System.Collections.Generic.IEnumerator<LGs51pLcNObAM6UTLTsO>);
			Jgaq6ef4PuO0JxER8Odt? fragment = default(Jgaq6ef4PuO0JxER8Odt?);
			int num5 = default(int);
			Jgaq6ef4PuO0JxER8Odt valueOrDefault = default(Jgaq6ef4PuO0JxER8Odt);
			int num7 = default(int);
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
						goto case 1;
					case 1:
						return num4;
					case 2:
						enumerator = ((gmRncnL0L6qQC50Niggx)datagram).Frames.GetEnumerator();
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 != 0)
						{
							num2 = 7;
						}
						break;
					case 3:
						num4 = 4294967295u;
						num2 = 2;
						break;
					case 0:
						try
						{
							while (true)
							{
								IL_013e:
								int num3;
								if (!enumerator.MoveNext())
								{
									num3 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 != 0)
									{
										num3 = 2;
									}
									goto IL_0096;
								}
								goto IL_00dc;
								IL_00dc:
								fragment = enumerator.Current.Fragment;
								num3 = 4;
								goto IL_0096;
								IL_0096:
								while (true)
								{
									switch (num3)
									{
									default:
										if (num5 == 15)
										{
											goto IL_013e;
										}
										if (num5 == 995)
										{
											goto IL_0092;
										}
										goto case 6;
									case 2:
										break;
									case 6:
										num4 = valueOrDefault.FragmentIndex;
										num5 = 15;
										goto IL_0092;
									case 3:
										valueOrDefault = fragment.GetValueOrDefault();
										num3 = 12;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
										{
											num3 = 5;
										}
										continue;
									case 0:
									case 7:
										goto IL_013e;
									case 4:
										if (!fragment.HasValue)
										{
											num3 = 7;
											continue;
										}
										goto case 3;
									case 5:
										if (valueOrDefault.FragmentIndex >= num4)
										{
											num3 = 3;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
											{
												num3 = 0;
											}
											continue;
										}
										goto case 6;
									case 1:
										goto end_IL_013e;
										IL_0092:
										num3 = num5;
										continue;
									}
									break;
								}
								goto IL_00dc;
								continue;
								end_IL_013e:
								break;
							}
						}
						finally
						{
							((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
							int num6 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
							{
								num6 = 3;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 988)
									{
										num6 = num7;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 1;
					}
					continue;
					end_IL_0010:
					break;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public TNklJaLcijACavTXFn8J()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool xuWJTlDQRknXENdp0iBB()
		{
			return iC6103DQ6xF11IQmPCTi == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static TNklJaLcijACavTXFn8J GMbZ81DQwP47ptnSAeB2()
		{
			return (TNklJaLcijACavTXFn8J)iC6103DQ6xF11IQmPCTi;
		}
	}

	private sealed class gmRncnL0L6qQC50Niggx
	{
		internal static object RhPwmNDQeDlVy3XL3V9d;

		[field: CompilerGenerated]
		public byte PacketId
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get;
		}

		[field: CompilerGenerated]
		public uint SequenceNumber
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get;
		}

		[field: CompilerGenerated]
		public List<LGs51pLcNObAM6UTLTsO> Frames
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get;
		}

		[MethodImpl((MethodImplOptions)8)]
		public gmRncnL0L6qQC50Niggx(byte packetId, uint sequenceNumber, List<LGs51pLcNObAM6UTLTsO> frames)
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool K06rJaDQPvXOUOEoY3AO()
		{
			return RhPwmNDQeDlVy3XL3V9d == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static gmRncnL0L6qQC50Niggx a3NsiMDQxXpc2qFp38qQ()
		{
			return (gmRncnL0L6qQC50Niggx)RhPwmNDQeDlVy3XL3V9d;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_95
	{
		public static readonly __c_95 __9;

		public static Predicate<LGs51pLcNObAM6UTLTsO> __9__87_0;

		public static Func<JsonProperty, string> __9__188_0;

		internal static __c_95 NXAUscDQFBs5U3XKxmgw;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_95()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool yRmL0jUJPPQ(LGs51pLcNObAM6UTLTsO frame)
		{
			Jgaq6ef4PuO0JxER8Odt? fragment = frame.Fragment;
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string ymUL0ZuxvbM(JsonProperty property)
		{
			return (property).Name;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool xkTZprDQsXc2VBOxgFNj()
		{
			return NXAUscDQFBs5U3XKxmgw == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_95 ciVZCNDQTWRvtnp06iAy()
		{
			return NXAUscDQFBs5U3XKxmgw;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass87_0
	{
		public Jgaq6ef4PuO0JxER8Odt firstFragment;

		internal static __c__DisplayClass87_0 TNk5OXDQNbwt3qCqfZR5;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass87_0()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool CHsL09j6gRL(LGs51pLcNObAM6UTLTsO frame)
		{
			Jgaq6ef4PuO0JxER8Odt jgaq6ef4PuO0JxER8Odt = DiBfWnJCKkV(frame);
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool xyOhXoDQMEmkI3BYU8Kj()
		{
			return TNk5OXDQNbwt3qCqfZR5 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass87_0 PW7cMNDQpxX4By83iy1N()
		{
			return TNk5OXDQNbwt3qCqfZR5;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct __c__DisplayClass91_0
	{
		public sNLGTJfWaoJbt7Xwwgik __4__this;

		public byte[] saltBytes;

		public HashSet<string> seenSessionKeys;

		public List<KeyValuePair<string, string>> publicKeys;
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct __c__DisplayClass91_1
	{
		public byte[] publicKeyDer;

		public string label2;
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass91_2
	{
		public string text;

		internal static __c__DisplayClass91_2 MWRuZcDQ29h9xDWHhvuY;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass91_2()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool SDlL0DyLsLV(KeyValuePair<string, string> x)
		{
			return string.Equals(x.Value, text, (StringComparison)4);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool NrAFl2DQqCrHdjN5jXIY()
		{
			return MWRuZcDQ29h9xDWHhvuY == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass91_2 qL5cgFDQGelekjqUsK39()
		{
			return MWRuZcDQ29h9xDWHhvuY;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct __c__DisplayClass99_0
	{
		public bool[] translated;

		public C0bnUBLcdulm1GSDbYP8[] sourcePackets;

		public sNLGTJfWaoJbt7Xwwgik __4__this;

		public bool c2s;

		public KWU3k1f4uMUKFgICVU5I[] results;

		public StringBuilder analysis;
	}

	[CompilerGenerated]
	sealed class _FindLoginChainSegments_d__125 : global::System.Collections.Generic.IEnumerable<WRVTklLcFMXgaYLUqPlB>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<WRVTklLcFMXgaYLUqPlB>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int __1__state;

		private WRVTklLcFMXgaYLUqPlB __2__current;

		private int __l__initialThreadId;

		private byte[] body;

		public byte[] __3__body;

		private HashSet<ValueTuple<int, int>> _seen_5__2;

		private int _offset_5__3;

		private static _FindLoginChainSegments_d__125 okfBNjDCbwSwTLAv4UYL;

		WRVTklLcFMXgaYLUqPlB System.Collections.Generic.IEnumerator<WRVTklLcFMXgaYLUqPlB>.Current
		{
			[MethodImpl((MethodImplOptions)8)]
			[DebuggerHidden]
			get
			{
				return __2__current;
			}
		}

		object System.Collections.IEnumerator.Current
		{
			[MethodImpl((MethodImplOptions)8)]
			[DebuggerHidden]
			get
			{
				return __2__current;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public _FindLoginChainSegments_d__125(int __1__state)
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		private void System_IDisposable_Dispose()
		{
			_seen_5__2 = null;
		}

		void global::System.IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in System_IDisposable_Dispose
			this.System_IDisposable_Dispose();
		}

		[MethodImpl((MethodImplOptions)8)]
		private bool MoveNext()
		{
			_seen_5__2 = new HashSet<ValueTuple<int, int>>();
			return default(bool);
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		private void System_Collections_IEnumerator_Reset()
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException();
		}

		void global::System.Collections.IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in System_Collections_IEnumerator_Reset
			this.System_Collections_IEnumerator_Reset();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		private global::System.Collections.Generic.IEnumerator<WRVTklLcFMXgaYLUqPlB> System_Collections_Generic_IEnumerable_Mahiro_Account_Services_Bedrock_Relay_Protocol_BedrockMitmSession_LoginChainSegment__GetEnumerator()
		{
			_FindLoginChainSegments_d__125 findLoginChainSegments_d__ = (_FindLoginChainSegments_d__125)new _FindLoginChainSegments_d__125(0);
			return null;
		}

		global::System.Collections.Generic.IEnumerator<WRVTklLcFMXgaYLUqPlB> global::System.Collections.Generic.IEnumerable<WRVTklLcFMXgaYLUqPlB>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in System_Collections_Generic_IEnumerable_Mahiro_Account_Services_Bedrock_Relay_Protocol_BedrockMitmSession_LoginChainSegment__GetEnumerator
			return this.System_Collections_Generic_IEnumerable_Mahiro_Account_Services_Bedrock_Relay_Protocol_BedrockMitmSession_LoginChainSegment__GetEnumerator();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		private global::System.Collections.IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			return (global::System.Collections.IEnumerator)System_Collections_Generic_IEnumerable_Mahiro_Account_Services_Bedrock_Relay_Protocol_BedrockMitmSession_LoginChainSegment__GetEnumerator();
		}

		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in System_Collections_IEnumerable_GetEnumerator
			return this.System_Collections_IEnumerable_GetEnumerator();
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool N3iTSGDCXW4XHB2x7nVo()
		{
			return okfBNjDCbwSwTLAv4UYL == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static _FindLoginChainSegments_d__125 jeKHOFDCfrVB7oUOwCl0()
		{
			return okfBNjDCbwSwTLAv4UYL;
		}
	}

	private readonly object fthfCwc1duK;

	private readonly object M0AfCeKI42F;

	private readonly object awwfCPcCEoS;

	private readonly object olWfCxPw4SR;

	private readonly object T5ffCFa1903;

	private readonly object F9lfCss8Rat;

	private readonly object C0cfCTPVGfV;

	private readonly object PcWfCNRDxqh;

	private sh6KmlfWoQNMIWAdC2mj? zoifCMkSLAU;

	private sh6KmlfWoQNMIWAdC2mj? esVfCpjrrLM;

	private sh6KmlfWoQNMIWAdC2mj? X6efCu4PvqJ;

	private sh6KmlfWoQNMIWAdC2mj? l0DfCa7vHBs;

	private byte[]? DPXfC1btUWN;

	private byte[]? l2hfC3f9Yo3;

	private readonly Dictionary<string, string> vaJfCv76F2u;

	private readonly List<ST9PBRLcw5s1twpPIgr6> upHfCE6U85R;

	private bool yjcfC2WK8O6;

	private ulong MINfCqnuiQs;

	private ulong mtXfCGmZ6JL;

	private ulong i1LfCiVqcno;

	private ulong pOEfCnMd44e;

	private readonly object EPvfCz7N4Im;

	private readonly object Hh7f4blmSDY;

	private readonly HashSet<uint> WbUf4XIyEo8;

	private readonly Dictionary<uint, byte[]> EhCf4fc6SYe;

	private readonly Dictionary<uint, byte[]> zoHf4LGKUWa;

	private readonly Dictionary<ushort, TNklJaLcijACavTXFn8J> oA9f4j5QSUj;

	private readonly Dictionary<ushort, TdTSlkLc2StmA5SrVSYT> oYjf4ZO3kab;

	private readonly Dictionary<ushort, TdTSlkLc2StmA5SrVSYT> sJgf49LkTeN;

	private S3TYvPf4dw0Js0IbGOQN xLIf4D9F3Tr;

	private bool Exwf4k344JG;

	private ulong? zdaf4VhUaTq;

	private string? tkwf4YlXghl;

	private byte[]? hsDf4SaVhIn;

	private byte[]? nIvf4caLfd6;

	private xpINlYf4H5yETjq1oUnp A0lf40iMjfy;

	private string? VHif48EsEGT;

	private string? vT3f4yI9KRH;

	private string? IAwf4WhcoVs;

	private string? Hb8f4JT36ie;

	private string? r13f4QPrnUA;

	private bool SWFf4Cn7WLl;

	private bool MAgf44lhStI;

	private byte[]? crIf4hG4XyI;

	private bool GW0f4UYDH7O;

	private WgPlTNfmMCnOeo4nahmF? fZqf4rTyIgN;

	private bool Y97f4oS6vDf;

	private vJHp2SXBc1bWEKoxdDKg? Lknf4mhiFjU;

	private static readonly object OQ6f47BfhfX;

	[CompilerGenerated]
	private Action<d07Je7fhL7tE6inRqNZK>? qyXf4AK7vS5;

	internal static object v3XbnIZuc4vGjOahs4gq;

	internal XsLTEjfWQvNnI0yxDDFu AuthContext
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return (XsLTEjfWQvNnI0yxDDFu)PcWfCNRDxqh;
		}
	}

	internal bool ProtocolBridgeEnabled
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return fZqf4rTyIgN != null;
		}
	}

	internal bool IsActive
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return A0lf40iMjfy == xpINlYf4H5yETjq1oUnp.Active;
		}
	}

	internal event Action<d07Je7fhL7tE6inRqNZK>? DecodedPacket
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		add
		{
			Action<d07Je7fhL7tE6inRqNZK> val2 = default(Action<d07Je7fhL7tE6inRqNZK>);
			Action<d07Je7fhL7tE6inRqNZK> val3 = default(Action<d07Je7fhL7tE6inRqNZK>);
			Action<d07Je7fhL7tE6inRqNZK> val = Interlocked.CompareExchange<Action<d07Je7fhL7tE6inRqNZK>>(ref qyXf4AK7vS5, val2, val3);
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		remove
		{
			Action<d07Je7fhL7tE6inRqNZK> val2 = default(Action<d07Je7fhL7tE6inRqNZK>);
			Action<d07Je7fhL7tE6inRqNZK> val3 = default(Action<d07Je7fhL7tE6inRqNZK>);
			Action<d07Je7fhL7tE6inRqNZK> val = Interlocked.CompareExchange<Action<d07Je7fhL7tE6inRqNZK>>(ref qyXf4AK7vS5, val2, val3);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public sNLGTJfWaoJbt7Xwwgik()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void kFvfW3xTrYI(string neteaseAuthEnvelopeJson, string neteaseDisplayName, int frontendProtocol, int frontendListenPort, bool androidTouchEnabled = false, vJHp2SXBc1bWEKoxdDKg? androidDevice = null)
	{
		fZqf4rTyIgN = (WgPlTNfmMCnOeo4nahmF?)new WgPlTNfmMCnOeo4nahmF(neteaseAuthEnvelopeJson, neteaseDisplayName, frontendProtocol)
		{
			FrontendListenPort = frontendListenPort
		};
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void QCefWvai8hU()
	{
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		int num = 26;
		global::System.Collections.Generic.IEnumerator<ST9PBRLcw5s1twpPIgr6> enumerator = default(global::System.Collections.Generic.IEnumerator<ST9PBRLcw5s1twpPIgr6>);
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
						if (num2 != 49)
						{
							if (num2 == 1030)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						MINfCqnuiQs = 0uL;
						num3 = 29;
						continue;
					case 40:
						return;
					case 30:
						try
						{
							while (true)
							{
								IL_0163:
								int num4;
								if (!enumerator.MoveNext())
								{
									num4 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de != 0)
									{
										num4 = 0;
									}
									goto IL_0105;
								}
								goto IL_0129;
								IL_0129:
								System.Security.Cryptography.CryptographicOperations.ZeroMemory(enumerator.Current.SessionKey);
								num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e == 0)
								{
									num4 = 7;
								}
								goto IL_0105;
								IL_0105:
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
										goto end_IL_0163;
									case 2:
										break;
									case 1:
										goto IL_0163;
									case 0:
										goto end_IL_0163;
									}
									break;
								}
								goto IL_0129;
								continue;
								end_IL_0163:
								break;
							}
						}
						finally
						{
							((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
							int num6 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
							{
								num6 = 3;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 988)
									{
										num6 = num7;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 11;
					case 18:
						((emOnaRfhwVdB0ZtjxgFR)EPvfCz7N4Im).awWfhxarSBU();
						num3 = 17;
						continue;
					case 8:
						Hb8f4JT36ie = null;
						num3 = 15;
						continue;
					case 6:
						oA9f4j5QSUj.Clear();
						num3 = 48;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
						{
							num3 = 35;
						}
						continue;
					case 38:
						xLIf4D9F3Tr = S3TYvPf4dw0Js0IbGOQN.Zlib;
						num3 = 24;
						continue;
					case 35:
						g8OfWqWWTcT(oYjf4ZO3kab);
						num3 = 43;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 != 0)
						{
							num3 = 28;
						}
						continue;
					case 28:
						g8OfWqWWTcT(sJgf49LkTeN);
						num3 = 21;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
						{
							num3 = 38;
						}
						continue;
					case 33:
						((qvOAd3fhDVEGFJKiNw0e)fthfCwc1duK).WBEfhVRx4bY();
						num3 = 23;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
						{
							num3 = 49;
						}
						continue;
					case 5:
						zdaf4VhUaTq = null;
						num = 7;
						break;
					case 27:
						esVfCpjrrLM = null;
						num3 = 38;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
						{
							num3 = 4;
						}
						continue;
					case 0:
						WbUf4XIyEo8.Clear();
						num3 = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
						{
							num3 = 37;
						}
						continue;
					case 7:
						tkwf4YlXghl = null;
						num3 = 42;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
						{
							num3 = 42;
						}
						continue;
					case 23:
					{
						WgPlTNfmMCnOeo4nahmF? wgPlTNfmMCnOeo4nahmF = fZqf4rTyIgN;
						if (wgPlTNfmMCnOeo4nahmF == null)
						{
							num3 = 14;
							continue;
						}
						wgPlTNfmMCnOeo4nahmF.FWmfm119KAW();
						num3 = 36;
						continue;
					}
					case 19:
						MAgf44lhStI = false;
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 != 0)
						{
							num3 = 21;
						}
						continue;
					case 14:
					case 36:
						A0lf40iMjfy = xpINlYf4H5yETjq1oUnp.Passive;
						num3 = 40;
						continue;
					case 24:
						Exwf4k344JG = false;
						num3 = 5;
						continue;
					case 25:
						NJNfW2GKPSi(ref l2hfC3f9Yo3);
						num3 = 37;
						continue;
					case 32:
						SWFf4Cn7WLl = false;
						num3 = 19;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
						{
							num3 = 31;
						}
						continue;
					case 1:
						zoHf4LGKUWa.Clear();
						num3 = 6;
						continue;
					case 3:
						((XsLTEjfWQvNnI0yxDDFu)PcWfCNRDxqh).TZXfWhiPNK8();
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
						{
							num3 = 33;
						}
						continue;
					case 16:
						GW0f4UYDH7O = false;
						num3 = 3;
						continue;
					case 29:
						mtXfCGmZ6JL = 0uL;
						num3 = 9;
						continue;
					case 26:
						NJNfW2GKPSi(ref DPXfC1btUWN);
						num3 = 25;
						continue;
					case 21:
						crIf4hG4XyI = null;
						num3 = 16;
						continue;
					case 11:
						zoifCMkSLAU = null;
						num3 = 27;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
						{
							num3 = 7;
						}
						continue;
					case 39:
						yjcfC2WK8O6 = false;
						num = 49;
						break;
					case 2:
						vT3f4yI9KRH = null;
						num3 = 22;
						continue;
					case 34:
						vaJfCv76F2u.Clear();
						num3 = 41;
						continue;
					case 22:
						IAwf4WhcoVs = null;
						num3 = 43;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
						{
							num3 = 8;
						}
						continue;
					case 12:
						l0DfCa7vHBs = null;
						num = 34;
						break;
					case 4:
						X6efCu4PvqJ = null;
						num3 = 12;
						continue;
					case 13:
						EhCf4fc6SYe.Clear();
						num3 = 25;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
						{
							num3 = 1;
						}
						continue;
					case 31:
						nIvf4caLfd6 = null;
						num = 20;
						break;
					case 42:
						hsDf4SaVhIn = null;
						num3 = 31;
						continue;
					case 10:
						pOEfCnMd44e = 0uL;
						num3 = 26;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b != 0)
						{
							num3 = 18;
						}
						continue;
					case 20:
						VHif48EsEGT = null;
						num3 = 2;
						continue;
					case 17:
						((emOnaRfhwVdB0ZtjxgFR)Hh7f4blmSDY).awWfhxarSBU();
						num3 = 27;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
						{
							num3 = 0;
						}
						continue;
					case 41:
						upHfCE6U85R.Clear();
						num3 = 22;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
						{
							num3 = 39;
						}
						continue;
					case 37:
						enumerator = upHfCE6U85R.GetEnumerator();
						num3 = 34;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 != 0)
						{
							num3 = 30;
						}
						continue;
					case 15:
						r13f4QPrnUA = null;
						num3 = 27;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
						{
							num3 = 32;
						}
						continue;
					case 9:
						i1LfCiVqcno = 0uL;
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
						{
							num3 = 32;
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
	internal bool vcUfWEYcpBa()
	{
		GW0f4UYDH7O = false;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void NJNfW2GKPSi(ref byte[]? key)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void g8OfWqWWTcT(Dictionary<ushort, TdTSlkLc2StmA5SrVSYT> splits)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal byte[] ELhfWGPJDpk(byte[] datagram, bool c2s, out string? note)
	{
		note = default(string?);
		int num = 1;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] Il7fWim7HP3(object datagram, out string? note)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static Jgaq6ef4PuO0JxER8Odt DiBfWnJCKkV(object frame)
	{
		Jgaq6ef4PuO0JxER8Odt? fragment = ((LGs51pLcNObAM6UTLTsO)frame).Fragment;
		return default(Jgaq6ef4PuO0JxER8Odt);
	}

	[MethodImpl((MethodImplOptions)8)]
	public ValueTuple<List<byte[]>?, byte[]?, string?> sCkfWzWiF80(byte[] datagram)
	{
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		int num = 20;
		int num4 = default(int);
		StringBuilder val2 = default(StringBuilder);
		bool flag = default(bool);
		StringBuilder val = default(StringBuilder);
		string text = default(string);
		byte[] array2 = default(byte[]);
		uint sequenceNumber = default(uint);
		global::System.Collections.Generic.IEnumerator<LGs51pLcNObAM6UTLTsO> enumerator = default(global::System.Collections.Generic.IEnumerator<LGs51pLcNObAM6UTLTsO>);
		int num7 = default(int);
		Jgaq6ef4PuO0JxER8Odt? fragment = default(Jgaq6ef4PuO0JxER8Odt?);
		LGs51pLcNObAM6UTLTsO current = default(LGs51pLcNObAM6UTLTsO);
		byte[] array3 = default(byte[]);
		byte[] ackToClient2 = default(byte[]);
		byte[] rewrittenPayload = default(byte[]);
		int num9 = default(int);
		List<byte[]> toServerPackets = default(List<byte[]>);
		byte[] ackToClient = default(byte[]);
		string analysis = default(string);
		List<LGs51pLcNObAM6UTLTsO> frames = default(List<LGs51pLcNObAM6UTLTsO>);
		byte[] array4 = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					byte[] array5;
					byte[] array;
					switch (num3)
					{
					default:
						if (num2 == 32)
						{
							goto IL_00f2;
						}
						if (num2 == 1013)
						{
							goto end_IL_0010;
						}
						goto case 25;
					case 13:
					{
						List<byte[]> obj4 = new List<byte[]>(num4);
						CollectionsMarshal.SetCount<byte[]>(obj4, num4);
						CollectionsMarshal.AsSpan<byte[]>(obj4)[0] = datagram;
						return new ValueTuple<List<byte[]>, byte[], string>(obj4, (byte[])null, (string)null);
					}
					case 14:
						val2 = new StringBuilder();
						num3 = 16;
						continue;
					case 7:
						if (!flag)
						{
							num3 = 22;
							continue;
						}
						goto case 11;
					case 25:
					{
						List<byte[]> obj2 = new List<byte[]>(num4);
						CollectionsMarshal.SetCount<byte[]>(obj2, num4);
						CollectionsMarshal.AsSpan<byte[]>(obj2)[0] = datagram;
						return new ValueTuple<List<byte[]>, byte[], string>(obj2, (byte[])null, (string)null);
					}
					case 19:
						if (SmeeQEfUk1LOYNogcnC0.b6UfU08Ojcm(datagram[0]))
						{
							num = 9;
							break;
						}
						goto IL_00f2;
					case 1:
						val = new StringBuilder();
						num3 = 18;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
						{
							num3 = 18;
						}
						continue;
					case 3:
					case 22:
						text = R5qfCypmOj8(((qvOAd3fhDVEGFJKiNw0e)fthfCwc1duK).AlkfhYwJ2YP("C→S", array2), i1YfC8N6iE3(val2));
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
						{
							num3 = 6;
						}
						continue;
					case 11:
						EhCf4fc6SYe[sequenceNumber] = array2;
						num3 = 21;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
						{
							num3 = 3;
						}
						continue;
					case 12:
						try
						{
							while (true)
							{
								IL_03df:
								int num5;
								if (!enumerator.MoveNext())
								{
									num5 = 12;
									goto IL_0247;
								}
								goto IL_0321;
								IL_0247:
								while (true)
								{
									switch (num5)
									{
									default:
										if (num7 != 20)
										{
											if (num7 == 1000)
											{
												goto IL_0243;
											}
											goto case 0;
										}
										fragment = current.Fragment;
										OeQfJLAIWXE(fragment.Value, current.Payload, c2s: true, val2);
										num5 = 11;
										continue;
									case 8:
										array3 = ackToClient2;
										num5 = 11;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
										{
											num5 = 1;
										}
										continue;
									case 9:
										flag = true;
										num5 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
										{
											num5 = 0;
										}
										continue;
									case 0:
										if (array3 == null)
										{
											num5 = 8;
											continue;
										}
										goto IL_03df;
									case 3:
										break;
									case 6:
										if (current.Payload.Length != 0)
										{
											num5 = 2;
											continue;
										}
										goto IL_03df;
									case 10:
										if (OPPfJ9MBJym(current.Payload, c2s: true, sequenceNumber, allowRewrite: true, out rewrittenPayload, out ackToClient2, val2))
										{
											num5 = 5;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
											{
												num5 = 4;
											}
											continue;
										}
										goto case 0;
									case 2:
										if (current.Payload[0] == 254)
										{
											num5 = 10;
											continue;
										}
										goto IL_03df;
									case 7:
										fragment = current.Fragment;
										num5 = 5;
										continue;
									case 1:
									case 11:
										goto IL_03df;
									case 4:
										current.Payload = rewrittenPayload;
										num5 = 9;
										continue;
									case 5:
										if (fragment.HasValue)
										{
											int num6 = 20;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
											{
												num6 = 7;
											}
											num7 = num6;
											goto IL_0243;
										}
										goto case 6;
									case 12:
										goto end_IL_03df;
										IL_0243:
										num5 = num7;
										continue;
									}
									break;
								}
								goto IL_0321;
								IL_0321:
								current = enumerator.Current;
								num5 = 7;
								goto IL_0247;
								continue;
								end_IL_03df:
								break;
							}
						}
						finally
						{
							((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
							int num8 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
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
										num8 = num9;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 15;
					case 17:
						return new ValueTuple<List<byte[]>, byte[], string>(toServerPackets, ackToClient, analysis);
					case 23:
						array3 = null;
						num3 = 14;
						continue;
					case 21:
						array5 = datagram;
						goto IL_06d6;
					case 0:
						array = datagram;
						goto IL_06ee;
					case 9:
						if (F7PfCfZnexY(datagram, out sequenceNumber, out frames))
						{
							if (A0lf40iMjfy == xpINlYf4H5yETjq1oUnp.Active)
							{
								num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
								{
									num3 = 21;
								}
								continue;
							}
							if (!PbbfJjmMHZj(datagram[0], sequenceNumber, frames, out toServerPackets, out ackToClient, out analysis))
							{
								num3 = 23;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
								{
									num3 = 4;
								}
								continue;
							}
							goto case 17;
						}
						num = 32;
						break;
					case 18:
						if (!VljfJftovm5(frames, c2s: true, val))
						{
							num3 = 21;
							continue;
						}
						array5 = a9QfCLELlSh(datagram[0], sequenceNumber, frames);
						goto IL_06d6;
					case 8:
						num4 = 1;
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
						{
							num3 = 6;
						}
						continue;
					case 24:
					{
						List<byte[]> obj3 = new List<byte[]>(num4);
						CollectionsMarshal.SetCount<byte[]>(obj3, num4);
						CollectionsMarshal.AsSpan<byte[]>(obj3)[0] = array4;
						return new ValueTuple<List<byte[]>, byte[], string>(obj3, (byte[])null, i1YfC8N6iE3(val));
					}
					case 10:
						num4 = 1;
						num3 = 25;
						continue;
					case 15:
						if (flag)
						{
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
							{
								num3 = 6;
							}
							continue;
						}
						goto case 0;
					case 20:
						if (datagram.Length != 0)
						{
							num3 = 28;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
							{
								num3 = 19;
							}
							continue;
						}
						goto case 10;
					case 2:
					{
						List<byte[]> obj = new List<byte[]>(num4);
						CollectionsMarshal.SetCount<byte[]>(obj, num4);
						CollectionsMarshal.AsSpan<byte[]>(obj)[0] = array2;
						return new ValueTuple<List<byte[]>, byte[], string>(obj, array3, text);
					}
					case 4:
						enumerator = frames.GetEnumerator();
						num3 = 12;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
						{
							num3 = 15;
						}
						continue;
					case 5:
						num4 = 1;
						num3 = 24;
						continue;
					case 16:
						flag = false;
						num3 = 4;
						continue;
					case 6:
						{
							array = a9QfCLELlSh(datagram[0], sequenceNumber, frames);
							goto IL_06ee;
						}
						IL_06ee:
						array2 = array;
						num3 = 7;
						continue;
						IL_00f2:
						num4 = 1;
						num3 = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 != 0)
						{
							num3 = 7;
						}
						continue;
						IL_06d6:
						array4 = array5;
						num = 5;
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
	public ValueTuple<byte[]?, string?> LxdfJbk4JNs(byte[] datagram)
	{
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		int num = 17;
		StringBuilder val = default(StringBuilder);
		List<LGs51pLcNObAM6UTLTsO> frames = default(List<LGs51pLcNObAM6UTLTsO>);
		uint sequenceNumber = default(uint);
		StringBuilder val2 = default(StringBuilder);
		byte[] array5 = default(byte[]);
		string text = default(string);
		bool flag = default(bool);
		byte[] array2 = default(byte[]);
		byte[] array6 = default(byte[]);
		global::System.Collections.Generic.IEnumerator<LGs51pLcNObAM6UTLTsO> enumerator = default(global::System.Collections.Generic.IEnumerator<LGs51pLcNObAM6UTLTsO>);
		int num6 = default(int);
		Jgaq6ef4PuO0JxER8Odt? fragment = default(Jgaq6ef4PuO0JxER8Odt?);
		LGs51pLcNObAM6UTLTsO current = default(LGs51pLcNObAM6UTLTsO);
		byte[] rewrittenPayload = default(byte[]);
		int num8 = default(int);
		int removedCount = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					byte[] array4;
					byte[] array3;
					switch (num3)
					{
					default:
						if (num2 != 25)
						{
							if (num2 == 1006)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						val = new StringBuilder();
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
						{
							num3 = 7;
						}
						continue;
					case 7:
						if (!VljfJftovm5(frames, c2s: false, val))
						{
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 != 0)
							{
								num3 = 15;
							}
							continue;
						}
						array4 = a9QfCLELlSh(datagram[0], sequenceNumber, frames);
						goto IL_06cb;
					case 18:
						if (!F7PfCfZnexY(datagram, out sequenceNumber, out frames))
						{
							num3 = 14;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
							{
								num3 = 16;
							}
							continue;
						}
						if (A0lf40iMjfy == xpINlYf4H5yETjq1oUnp.Active)
						{
							num3 = 10;
							continue;
						}
						val2 = new StringBuilder();
						num = 11;
						break;
					case 5:
						return new ValueTuple<byte[], string>(array5, text);
					case 12:
						text = R5qfCypmOj8(((qvOAd3fhDVEGFJKiNw0e)fthfCwc1duK).AlkfhYwJ2YP("S→C", array5), i1YfC8N6iE3(val2));
						num3 = 5;
						continue;
					case 6:
						if (!flag)
						{
							num3 = 15;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
							{
								num3 = 14;
							}
							continue;
						}
						array3 = a9QfCLELlSh(datagram[0], sequenceNumber, frames);
						goto IL_06f5;
					case 17:
						if (datagram.Length != 0)
						{
							num3 = 16;
							continue;
						}
						goto case 4;
					case 2:
						if (array2 != datagram)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
							{
								num3 = 8;
							}
							continue;
						}
						return new ValueTuple<byte[], string>(datagram, (string)null);
					case 10:
						if (!zoHf4LGKUWa.TryGetValue(sequenceNumber, out array6))
						{
							num = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
							{
								num = 25;
							}
							break;
						}
						goto case 13;
					case 11:
						flag = false;
						num3 = 14;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
						{
							num3 = 9;
						}
						continue;
					case 14:
						return new ValueTuple<byte[], string>(datagram, (string)null);
					case 13:
						return new ValueTuple<byte[], string>(array6, "    -> [MITM] replayed cached forged ServerToClientHandshakePacket retransmit");
					case 9:
						enumerator = frames.GetEnumerator();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
						{
							num3 = 20;
						}
						continue;
					case 4:
						return new ValueTuple<byte[], string>(datagram, (string)null);
					case 16:
						if (datagram[0] == 160)
						{
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
							{
								num3 = 13;
							}
							continue;
						}
						if (SmeeQEfUk1LOYNogcnC0.b6UfU08Ojcm(datagram[0]))
						{
							num3 = 18;
							continue;
						}
						goto case 14;
					case 0:
						try
						{
							while (true)
							{
								int num4;
								if (!enumerator.MoveNext())
								{
									num4 = 7;
									goto IL_0310;
								}
								goto IL_040d;
								IL_0310:
								while (true)
								{
									int num5;
									switch (num4)
									{
									default:
										if (num6 != 21)
										{
											if (num6 == 1001)
											{
												goto IL_030c;
											}
											goto case 4;
										}
										break;
									case 11:
										if (A0lf40iMjfy == xpINlYf4H5yETjq1oUnp.Active)
										{
											num4 = 12;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
											{
												num4 = 0;
											}
											continue;
										}
										break;
									case 5:
									case 9:
										break;
									case 13:
										if (fragment.HasValue)
										{
											num4 = 2;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
											{
												num4 = 16;
											}
											continue;
										}
										goto case 4;
									case 12:
										goto IL_040d;
									case 6:
									{
										if (OPPfJ9MBJym(current.Payload, c2s: false, sequenceNumber, allowRewrite: true, out rewrittenPayload, out byte[] _, val2))
										{
											num4 = 3;
											continue;
										}
										break;
									}
									case 4:
										if (current.Payload.Length == 0)
										{
											num5 = 7;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
											{
												num5 = 21;
											}
											goto IL_0308;
										}
										goto case 1;
									case 2:
										fragment = current.Fragment;
										OeQfJLAIWXE(fragment.Value, current.Payload, c2s: false, val2);
										num4 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
										{
											num4 = 14;
										}
										continue;
									case 10:
										flag = true;
										num5 = 11;
										goto IL_0308;
									case 0:
										zoHf4LGKUWa[sequenceNumber] = a9QfCLELlSh(datagram[0], sequenceNumber, frames);
										num5 = 9;
										goto IL_0308;
									case 8:
										fragment = current.Fragment;
										num4 = 20;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
										{
											num4 = 13;
										}
										continue;
									case 3:
										current.Payload = rewrittenPayload;
										num4 = 10;
										continue;
									case 1:
										if (current.Payload[0] == 254)
										{
											num4 = 6;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
											{
												num4 = 11;
											}
											continue;
										}
										break;
									case 7:
										goto end_IL_03bd;
										IL_030c:
										num4 = num6;
										continue;
										IL_0308:
										num6 = num5;
										goto IL_030c;
									}
									break;
								}
								continue;
								IL_040d:
								current = enumerator.Current;
								num4 = 8;
								goto IL_0310;
								continue;
								end_IL_03bd:
								break;
							}
						}
						finally
						{
							((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
							int num7 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
							{
								num7 = 0;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 == 988)
									{
										num7 = num8;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 6;
					case 15:
						array3 = datagram;
						goto IL_06f5;
					case 3:
						array2 = bAcfCjqxm7v(datagram, out removedCount);
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
						{
							num3 = 22;
						}
						continue;
					case 8:
						array4 = datagram;
						goto IL_06cb;
					case 1:
						{
							byte[] array = array2;
							object obj;
							if (removedCount <= 0)
							{
								obj = null;
							}
							else
							{
								global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(70, 1);
								(defaultInterpolatedStringHandler).AppendLiteral("    ↳ [MITM] filtered ");
								defaultInterpolatedStringHandler.AppendFormatted<int>(removedCount);
								(defaultInterpolatedStringHandler).AppendLiteral(" intercepted sequence number(s) from server NACK");
								obj = (defaultInterpolatedStringHandler).ToStringAndClear();
							}
							return new ValueTuple<byte[], string>(array, (string)obj);
						}
						IL_06cb:
						return new ValueTuple<byte[], string>(array4, i1YfC8N6iE3(val));
						IL_06f5:
						array5 = array3;
						num3 = 12;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
						{
							num3 = 22;
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
	internal bool NOPfJXGtXe7(byte[] datagram, bool c2s, [NotNullWhen(true)] out byte[]? rewritten, [NotNullWhen(true)] out string? analysis)
	{
		rewritten = default(byte[]?);
		analysis = default(string?);
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private bool VljfJftovm5(List<LGs51pLcNObAM6UTLTsO> frames, bool c2s, StringBuilder analysis)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		global::System.Collections.Generic.IEnumerator<LGs51pLcNObAM6UTLTsO> enumerator = default(global::System.Collections.Generic.IEnumerator<LGs51pLcNObAM6UTLTsO>);
		bool result = default(bool);
		int num5 = default(int);
		AppendInterpolatedStringHandler val = default(AppendInterpolatedStringHandler);
		LGs51pLcNObAM6UTLTsO current = default(LGs51pLcNObAM6UTLTsO);
		Jgaq6ef4PuO0JxER8Odt? fragment = default(Jgaq6ef4PuO0JxER8Odt?);
		int num7 = default(int);
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
					goto case 2;
				case 2:
					enumerator = frames.GetEnumerator();
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return result;
				case 1:
					try
					{
						while (true)
						{
							IL_02be:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 9;
								goto IL_0099;
							}
							goto IL_015a;
							IL_0099:
							while (true)
							{
								int num4;
								switch (num3)
								{
								default:
									if (num5 != 24)
									{
										if (num5 == 1004)
										{
											goto IL_0095;
										}
										goto case 4;
									}
									(val).AppendLiteral("[");
									num4 = 2;
									goto IL_0091;
								case 16:
									result = true;
									num3 = 18;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
									{
										num3 = 15;
									}
									continue;
								case 14:
									current.Payload = I7KfJDKKdfc(current.Payload, c2s, analysis);
									num3 = 12;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
									{
										num3 = 16;
									}
									continue;
								case 1:
									break;
								case 10:
									analysis.AppendLine(val.ToString());
									num4 = 7;
									goto IL_0091;
								case 2:
									fragment = current.Fragment;
									val.AppendFormatted<uint>(fragment.Value.FragmentIndex);
									num3 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
									{
										num3 = 11;
									}
									continue;
								case 4:
									fragment = current.Fragment;
									val.AppendFormatted<ushort>(fragment.Value.CompoundId);
									num4 = 24;
									goto IL_0091;
								case 5:
									(val).AppendLiteral("] reached ProcessActiveFrames; skipped (should have been reassembled by RakNetReceiveSession)");
									num3 = 10;
									continue;
								case 0:
									(val).AppendLiteral("    ↳ [MITM] WARNING: split fragment ");
									num3 = 4;
									continue;
								case 13:
									if (current.Payload[0] == 254)
									{
										num3 = 14;
										continue;
									}
									goto IL_02be;
								case 3:
								case 7:
								case 15:
									goto IL_02be;
								case 12:
									val = new AppendInterpolatedStringHandler(131, 2, analysis);
									num3 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
									{
										num3 = 6;
									}
									continue;
								case 8:
									fragment = current.Fragment;
									num3 = 11;
									continue;
								case 11:
									if (fragment.HasValue)
									{
										num3 = 12;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
										{
											num3 = 13;
										}
										continue;
									}
									goto case 6;
								case 6:
									if (current.Payload.Length == 0)
									{
										num3 = 12;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
										{
											num3 = 3;
										}
										continue;
									}
									goto case 13;
								case 9:
									goto end_IL_02be;
									IL_0095:
									num3 = num5;
									continue;
									IL_0091:
									num5 = num4;
									goto IL_0095;
								}
								break;
							}
							goto IL_015a;
							IL_015a:
							current = enumerator.Current;
							num3 = 8;
							goto IL_0099;
							continue;
							end_IL_02be:
							break;
						}
					}
					finally
					{
						((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						int num6 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
						{
							num6 = 6;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 == 988)
								{
									num6 = num7;
									continue;
								}
								break;
							case 0:
								break;
							}
							break;
						}
					}
					goto case 0;
				case 3:
					result = false;
					num2 = 2;
					break;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OeQfJLAIWXE(Jgaq6ef4PuO0JxER8Odt fragment, byte[] payloadChunk, bool c2s, StringBuilder notes)
	{
		byte[] array = ((emOnaRfhwVdB0ZtjxgFR)EPvfCz7N4Im).PKhfhPmHPKL(fragment.CompoundId, fragment.CompoundSize, fragment.FragmentIndex, payloadChunk);
	}

	[MethodImpl((MethodImplOptions)8)]
	private bool PbbfJjmMHZj(byte packetId, uint sequenceNumber, List<LGs51pLcNObAM6UTLTsO> frames, out List<byte[]>? toServerPackets, out byte[]? ackToClient, out string? analysis)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private bool CrxfJZyP8lm(byte[] payload, StringBuilder notes, out byte[]? rewrittenPayload)
	{
		rewrittenPayload = default(byte[]?);
		C0bnUBLcdulm1GSDbYP8 c0bnUBLcdulm1GSDbYP = default(C0bnUBLcdulm1GSDbYP8);
		PLOfJ8uQhwy(c0bnUBLcdulm1GSDbYP.PacketId, c0bnUBLcdulm1GSDbYP.Body);
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe bool OPPfJ9MBJym(byte[] payload, bool c2s, uint? sequenceNumber, bool allowRewrite, [NotNullWhen(true)] out byte[]? rewrittenPayload, out byte[]? ackToClient, StringBuilder notes)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private byte[] I7KfJDKKdfc(byte[] payload, bool c2s, StringBuilder analysis)
	{
		byte[] array = default(byte[]);
		int num = default(int);
		global::System.ReadOnlySpan<byte> readOnlySpan = ((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>(array, num, 8));
		ulong counter = default(ulong);
		byte[] plaintextBatch = default(byte[]);
		byte[] sessionKey = default(byte[]);
		byte[] array2 = tkHfCD0u9cn(counter, plaintextBatch, sessionKey);
		bool flag = System.Security.Cryptography.CryptographicOperations.FixedTimeEquals(readOnlySpan, default(global::System.ReadOnlySpan<byte>));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void dRSfJkmX4Mv(byte[] saltBytes)
	{
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		global::System.Collections.Generic.Dictionary<string, string>.Enumerator enumerator2 = default(global::System.Collections.Generic.Dictionary<string, string>.Enumerator);
		KeyValuePair<string, string> current = default(KeyValuePair<string, string>);
		int num5 = default(int);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string key = default(string);
		__c__DisplayClass91_0 _c__DisplayClass91_ = default(__c__DisplayClass91_0);
		int num7 = default(int);
		global::System.Collections.Generic.IEnumerator<KeyValuePair<string, string>> enumerator = default(global::System.Collections.Generic.IEnumerator<KeyValuePair<string, string>>);
		int num15 = default(int);
		string value = default(string);
		KeyValuePair<string, string> current2 = default(KeyValuePair<string, string>);
		__c__DisplayClass91_1 _c__DisplayClass91_2 = default(__c__DisplayClass91_1);
		int num12 = default(int);
		int num14 = default(int);
		int num17 = default(int);
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
					case 12:
						upHfCE6U85R.Clear();
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
						{
							num3 = 0;
						}
						continue;
					case 6:
						try
						{
							while (true)
							{
								IL_011c:
								int num4;
								if (!enumerator2.MoveNext())
								{
									num4 = 9;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
									{
										num4 = 0;
									}
									goto IL_00cb;
								}
								goto IL_0109;
								IL_0109:
								current = enumerator2.Current;
								num4 = 4;
								goto IL_00cb;
								IL_00cb:
								while (true)
								{
									switch (num4)
									{
									default:
										if (num5 == 13)
										{
											goto IL_011c;
										}
										if (num5 == 993)
										{
											goto IL_00c7;
										}
										goto case 2;
									case 1:
										break;
									case 3:
										text = text2;
										num4 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
										{
											num4 = 2;
										}
										continue;
									case 4:
										current.Deconstruct(out text2, out text3);
										num4 = 3;
										continue;
									case 5:
										NLFfCd67cfZ(key, text, ref _c__DisplayClass91_);
										num5 = 13;
										goto IL_00c7;
									case 2:
										key = text3;
										num4 = 5;
										continue;
									case 0:
										goto end_IL_00cb;
										IL_00c7:
										num4 = num5;
										continue;
									}
									goto IL_0109;
									continue;
									end_IL_00cb:
									break;
								}
								break;
							}
						}
						finally
						{
							((global::System.IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
							int num6 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 988)
									{
										num6 = num7;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 9;
					case 10:
						goto end_IL_000c;
					case 1:
						SO6fJBQN3ox("auth-request-key", ((XsLTEjfWQvNnI0yxDDFu)PcWfCNRDxqh).ClientPublicKeyB64);
						num3 = 8;
						continue;
					case 0:
						SO6fJBQN3ox("selected-login-key", tkwf4YlXghl);
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
						{
							num3 = 5;
						}
						continue;
					case 8:
						_c__DisplayClass91_.publicKeys = new List<KeyValuePair<string, string>>();
						num3 = 17;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
						{
							num3 = 10;
						}
						continue;
					case 11:
						enumerator2 = vaJfCv76F2u.GetEnumerator();
						num3 = 6;
						continue;
					case 4:
						try
						{
							while (true)
							{
								int num8;
								if (!enumerator.MoveNext())
								{
									num8 = 5;
									goto IL_0336;
								}
								goto IL_05d1;
								IL_0336:
								while (true)
								{
									int num9;
									switch (num8)
									{
									default:
										if (num15 != 13)
										{
											if (num15 == 993)
											{
												goto IL_0332;
											}
											goto case 3;
										}
										value = text2;
										num9 = 3;
										goto IL_032e;
									case 1:
										current2.Deconstruct(out text3, out text2);
										num8 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 != 0)
										{
											num8 = 4;
										}
										continue;
									case 3:
										try
										{
											_c__DisplayClass91_2.publicKeyDer = fWwfCkAVZoN(value);
											int num10 = 11;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
											{
												num10 = 1;
											}
											while (true)
											{
												switch (num10)
												{
												default:
													if (num12 != 11)
													{
														if (num12 != 991)
														{
															break;
														}
														goto IL_03da;
													}
													goto end_IL_03de;
												case 3:
												{
													FlDfClRROcZ("reverse(secret)+salt", true, true, ref _c__DisplayClass91_, ref _c__DisplayClass91_2);
													int num11 = 3;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
													{
														num11 = 11;
													}
													num12 = num11;
													goto IL_03da;
												}
												case 0:
													FlDfClRROcZ("secret+salt", false, true, ref _c__DisplayClass91_, ref _c__DisplayClass91_2);
													num10 = 3;
													continue;
												case 1:
													FlDfClRROcZ("salt+secret", false, false, ref _c__DisplayClass91_, ref _c__DisplayClass91_2);
													num10 = 2;
													continue;
												case 2:
													break;
													IL_03da:
													num10 = num12;
													continue;
												}
												FlDfClRROcZ("salt+reverse(secret)", true, false, ref _c__DisplayClass91_, ref _c__DisplayClass91_2);
												num10 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 != 0)
												{
													num10 = 10;
												}
												continue;
												end_IL_03de:
												break;
											}
										}
										catch
										{
											int num13 = 5;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
											{
												num13 = 0;
											}
											while (true)
											{
												switch (num13)
												{
												default:
													if (num14 == 988)
													{
														num13 = num14;
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
									case 0:
										break;
									case 4:
										_c__DisplayClass91_2.label2 = text3;
										num9 = 13;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
										{
											num9 = 11;
										}
										goto IL_032e;
									case 2:
										goto IL_05d1;
									case 5:
										return;
										IL_0332:
										num8 = num15;
										continue;
										IL_032e:
										num15 = num9;
										goto IL_0332;
									}
									break;
								}
								continue;
								IL_05d1:
								current2 = enumerator.Current;
								num8 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
								{
									num8 = 2;
								}
								goto IL_0336;
							}
						}
						finally
						{
							((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
							int num16 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
							{
								num16 = 0;
							}
							while (true)
							{
								switch (num16)
								{
								default:
									if (num17 == 988)
									{
										num16 = num17;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
					case 2:
						_c__DisplayClass91_.saltBytes = saltBytes;
						num3 = 12;
						continue;
					case 9:
						_c__DisplayClass91_.seenSessionKeys = new HashSet<string>((IEqualityComparer<string>)(object)System.StringComparer.Ordinal);
						num3 = 5;
						continue;
					case 7:
						return;
					case 3:
						_c__DisplayClass91_.__4__this = this;
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
						{
							num3 = 17;
						}
						continue;
					case 5:
						enumerator = _c__DisplayClass91_.publicKeys.GetEnumerator();
						num3 = 4;
						continue;
					}
					switch (num2)
					{
					case 1000:
						break;
					default:
						return;
					case 19:
						NLFfCd67cfZ("auth-request-key", ((XsLTEjfWQvNnI0yxDDFu)PcWfCNRDxqh).ClientPublicKeyB64, ref _c__DisplayClass91_);
						num3 = 11;
						continue;
					}
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			NLFfCd67cfZ("selected-login-key", tkwf4YlXghl, ref _c__DisplayClass91_);
			num = 10;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
			{
				num = 19;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void mwYfJVEwm5l(global::System.ReadOnlySpan<byte> ciphertext, StringBuilder analysis)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		int num = 6;
		StringBuilder val = default(StringBuilder);
		global::System.Collections.Generic.IEnumerator<ST9PBRLcw5s1twpPIgr6> enumerator = default(global::System.Collections.Generic.IEnumerator<ST9PBRLcw5s1twpPIgr6>);
		int num8 = default(int);
		ValueTuple<sh6KmlfWoQNMIWAdC2mj, sh6KmlfWoQNMIWAdC2mj> val3 = default(ValueTuple<sh6KmlfWoQNMIWAdC2mj, sh6KmlfWoQNMIWAdC2mj>);
		ulong num5 = default(ulong);
		byte[] array2 = default(byte[]);
		byte[] subArray = default(byte[]);
		ST9PBRLcw5s1twpPIgr6 current = default(ST9PBRLcw5s1twpPIgr6);
		global::System.ReadOnlySpan<byte> readOnlySpan = default(global::System.ReadOnlySpan<byte>);
		AppendInterpolatedStringHandler val2 = default(AppendInterpolatedStringHandler);
		int num10 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IL_000c:
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 1:
						return;
					case 3:
						val = analysis;
						num3 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
						{
							num3 = 0;
						}
						continue;
					case 4:
						goto end_IL_0010;
					case 7:
						try
						{
							while (true)
							{
								IL_0426:
								int num4;
								if (!enumerator.MoveNext())
								{
									num4 = 13;
									goto IL_0105;
								}
								goto IL_023d;
								IL_0105:
								while (true)
								{
									int num6;
									switch (num4)
									{
									default:
										if (num8 != 26)
										{
											if (num8 == 1006)
											{
												goto IL_0101;
											}
											goto case 4;
										}
										val3 = sh6KmlfWoQNMIWAdC2mj.NKnfWBJAuLZ(l2hfC3f9Yo3);
										num4 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
										{
											num4 = 0;
										}
										continue;
									case 5:
									case 15:
										if (num5 <= 3)
										{
											num4 = 17;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
											{
												num4 = 12;
											}
											continue;
										}
										goto IL_0426;
									case 3:
										pOEfCnMd44e = num5;
										num4 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
										{
											num4 = 13;
										}
										continue;
									case 6:
									case 17:
										array2 = tkHfCD0u9cn(num5, subArray, current.SessionKey);
										num4 = 10;
										continue;
									case 10:
										if (System.Security.Cryptography.CryptographicOperations.FixedTimeEquals(readOnlySpan, default(global::System.ReadOnlySpan<byte>)))
										{
											num4 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
											{
												num4 = 12;
											}
											continue;
										}
										goto case 11;
									case 18:
										break;
									case 0:
										l2hfC3f9Yo3 = (byte[])(current.SessionKey).Clone();
										num6 = 26;
										goto IL_00fd;
									case 14:
										X6efCu4PvqJ = val3.Item2;
										num4 = 3;
										continue;
									case 2:
									{
										byte[] array = sh6KmlfWoQNMIWAdC2mj.NKnfWBJAuLZ(current.SessionKey).Item2.LmMfWAahyIv(ciphertext);
										int num7 = array.Length - 8;
										subArray = array[System.Range.EndAt(((System.Index)num7))];
										readOnlySpan = ((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>(array, num7, 8));
										num4 = 7;
										continue;
									}
									case 7:
										num5 = 0uL;
										num4 = 5;
										continue;
									case 9:
										val = analysis;
										num4 = 16;
										continue;
									case 12:
										return;
									case 16:
									{
										StringBuilder obj2 = val;
										val2 = new AppendInterpolatedStringHandler(50, 2, val);
										(val2).AppendLiteral("    ↳ [MITM] client crypto auto-selected ");
										(val2).AppendFormatted(current.Label);
										(val2).AppendLiteral(" counter=");
										val2.AppendFormatted<ulong>(num5);
										obj2.AppendLine(val2.ToString());
										num6 = 12;
										goto IL_00fd;
									}
									case 11:
										num5++;
										num4 = 15;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 != 0)
										{
											num4 = 12;
										}
										continue;
									case 4:
										i1LfCiVqcno = 0uL;
										num4 = 9;
										continue;
									case 8:
										l0DfCa7vHBs = val3.Item1;
										num4 = 14;
										continue;
									case 1:
										goto IL_0426;
									case 13:
										goto end_IL_0426;
										IL_00fd:
										num8 = num6;
										goto IL_0101;
										IL_0101:
										num4 = num8;
										continue;
									}
									break;
								}
								goto IL_023d;
								IL_023d:
								current = enumerator.Current;
								num4 = 2;
								goto IL_0105;
								continue;
								end_IL_0426:
								break;
							}
						}
						finally
						{
							((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
							int num9 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
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
										num9 = num10;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 3;
					case 2:
						return;
					case 5:
						goto IL_04bc;
					case 0:
					{
						StringBuilder obj = val;
						val2 = new AppendInterpolatedStringHandler(79, 1, val);
						(val2).AppendLiteral("    ↳ [MITM] client crypto probe found no checksum match across ");
						val2.AppendFormatted<int>(upHfCE6U85R.Count);
						(val2).AppendLiteral(" key variant(s)");
						obj.AppendLine(val2.ToString());
						num3 = 2;
						continue;
					}
					case 6:
						yjcfC2WK8O6 = false;
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 != 0)
						{
							num3 = 9;
						}
						continue;
					}
					switch (num2)
					{
					case 995:
						break;
					default:
						return;
					case 14:
						enumerator = upHfCE6U85R.GetEnumerator();
						num3 = 7;
						continue;
					}
					goto IL_000c;
					continue;
					end_IL_0010:
					break;
				}
				if (upHfCE6U85R.Count == 0)
				{
					return;
				}
				num = 14;
				break;
				IL_04bc:
				if (ciphertext.Length < 8)
				{
					return;
				}
				num = 4;
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal ValueTuple<byte[], string?> K0JfJYFJ77p(byte[] payload, bool c2s)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		StringBuilder val = default(StringBuilder);
		string text = ((val).ToString()).TrimEnd();
		return default(ValueTuple<byte[], string>);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal ValueTuple<byte[], vsLN01fAAtgyqA711AeX, string?> OF5fJShcldl(byte[] plaintext, bool c2s)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		byte[] array = default(byte[]);
		System.Buffers.Binary.BinaryPrimitives.WriteInt32BigEndian(default(global::System.Span<byte>), fZqf4rTyIgN.FrontendProtocol);
		return default(ValueTuple<byte[], vsLN01fAAtgyqA711AeX, string>);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal ValueTuple<byte[], string?> wWLfJcvgnb0(byte[] payloadChunk, Jgaq6ef4PuO0JxER8Odt fragment, bool c2s)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		StringBuilder val = default(StringBuilder);
		string text = ((val).ToString()).TrimEnd();
		return default(ValueTuple<byte[], string>);
	}

	[MethodImpl((MethodImplOptions)8)]
	private byte[] qaefJ0ZnPN4(byte[] payloadChunk, Jgaq6ef4PuO0JxER8Odt fragment, bool c2s, StringBuilder analysis)
	{
		TdTSlkLc2StmA5SrVSYT tdTSlkLc2StmA5SrVSYT = default(TdTSlkLc2StmA5SrVSYT);
		byte[] array = (tdTSlkLc2StmA5SrVSYT.DestHash).GetHashAndReset();
		global::System.ReadOnlySpan<byte> readOnlySpan = default(global::System.ReadOnlySpan<byte>);
		byte[] array2 = default(byte[]);
		bool flag = System.Security.Cryptography.CryptographicOperations.FixedTimeEquals(readOnlySpan, ((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>(array2, 0, 8)));
		byte[] array4 = default(byte[]);
		byte[] array3 = new byte[array4.Length + 8];
		System.Buffer.BlockCopy(array4, 0, array3, 0, array4.Length);
		System.Buffer.BlockCopy(array, 0, array3, array4.Length, 8);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void PLOfJ8uQhwy(uint packetId, byte[] body)
	{
		ulong num = default(ulong);
		zdaf4VhUaTq = num;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] V4UfJyVtQc0(object plaintext, bool c2s, object analysis)
	{
		return (byte[])plaintext;
	}

	[MethodImpl((MethodImplOptions)8)]
	private byte[] iG8fJW5lOA1(byte[] plaintext, bool c2s, StringBuilder analysis)
	{
		//IL_085e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Expected O, but got Unknown
		//IL_0ac5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aca: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		int num = 21;
		fcEMWWf461Vje0aoly46 disposition = default(fcEMWWf461Vje0aoly46);
		KWU3k1f4uMUKFgICVU5I result = default(KWU3k1f4uMUKFgICVU5I);
		int num7 = default(int);
		MemoryStream val = default(MemoryStream);
		uint packetId = default(uint);
		StringBuilder val2 = default(StringBuilder);
		string note = default(string);
		IRDioILcOhJp3huAFEli envelope = default(IRDioILcOhJp3huAFEli);
		byte[] body = default(byte[]);
		__c__DisplayClass99_0 _c__DisplayClass99_ = default(__c__DisplayClass99_0);
		int num15 = default(int);
		C0bnUBLcdulm1GSDbYP8 c0bnUBLcdulm1GSDbYP = default(C0bnUBLcdulm1GSDbYP8);
		int num5 = default(int);
		uint? prefixPacketId = default(uint?);
		int num4 = default(int);
		int num8 = default(int);
		int num10 = default(int);
		int num6 = default(int);
		ValueTuple<uint, byte[]>[] array = default(ValueTuple<uint, byte[]>[]);
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
						if (num2 != 80)
						{
							if (num2 == 1061)
							{
								goto end_IL_0010;
							}
							goto case 71;
						}
						disposition = result.Disposition;
						num3 = 33;
						continue;
					case 7:
						num7++;
						num3 = 60;
						continue;
					case 41:
						try
						{
							GZ3fCgR9gcD(val, packetId);
							int num11 = 3;
							while (true)
							{
								IL_01b0:
								int num12 = num11;
								while (true)
								{
									IL_01b4:
									int num13 = num12;
									while (true)
									{
										switch (num13)
										{
										default:
										{
											if (num12 != 11)
											{
												if (num12 == 991)
												{
													goto IL_01b4;
												}
												goto case 0;
											}
											StringBuilder obj = val2;
											AppendInterpolatedStringHandler val3 = new AppendInterpolatedStringHandler(14, 1, val2);
											(val3).AppendLiteral("    ↳ [Relay] ");
											(val3).AppendFormatted(note);
											obj.AppendLine(val3.ToString());
											num13 = 2;
											continue;
										}
										case 0:
											num7++;
											num13 = 11;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
											{
												num13 = 1;
											}
											continue;
										case 3:
											envelope.Packets.Add((C0bnUBLcdulm1GSDbYP8)new C0bnUBLcdulm1GSDbYP8(packetId, (val).ToArray(), body));
											num13 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
											{
												num13 = 2;
											}
											continue;
										case 1:
											val2 = _c__DisplayClass99_.analysis;
											num11 = 11;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
											{
												num11 = 11;
											}
											break;
										case 2:
											goto end_IL_01b8;
										}
										goto IL_01b0;
										continue;
										end_IL_01b8:
										break;
									}
									break;
								}
								break;
							}
						}
						finally
						{
							int num14;
							if (val == null)
							{
								num14 = 2;
								goto IL_02f9;
							}
							goto IL_031d;
							IL_031d:
							(val).Dispose();
							num14 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
							{
								num14 = 3;
							}
							goto IL_02f9;
							IL_02f9:
							while (true)
							{
								switch (num14)
								{
								default:
									if (num15 == 990)
									{
										goto IL_02f5;
									}
									goto end_IL_02f9;
								case 0:
									break;
								case 2:
									goto end_IL_02f9;
								case 1:
									goto end_IL_02f9;
								}
								goto IL_031d;
								IL_02f5:
								num14 = num15;
								continue;
								end_IL_02f9:
								break;
							}
						}
						goto case 2;
					case 14:
					case 30:
						c0bnUBLcdulm1GSDbYP = _c__DisplayClass99_.sourcePackets[num5];
						num3 = 25;
						continue;
					case 29:
						if (!prefixPacketId.HasValue)
						{
							num3 = 19;
							continue;
						}
						goto case 55;
					case 70:
						envelope.Packets.Add(c0bnUBLcdulm1GSDbYP);
						num3 = 57;
						continue;
					case 18:
						num4++;
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
						{
							num3 = 20;
						}
						continue;
					case 37:
						num8 = 0;
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
						{
							num3 = 27;
						}
						continue;
					case 42:
						_c__DisplayClass99_.translated = new bool[_c__DisplayClass99_.sourcePackets.Length];
						num3 = 22;
						continue;
					case 50:
						num10 = -1;
						num3 = 12;
						continue;
					case 54:
						if (envelope.Packets.Count != 0)
						{
							num3 = 5;
							continue;
						}
						goto case 11;
					case 15:
						num10 = num8;
						num3 = 63;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
						{
							num3 = 76;
						}
						continue;
					case 34:
						num7++;
						num3 = 48;
						continue;
					case 10:
					case 45:
						if (num8 >= _c__DisplayClass99_.sourcePackets.Length)
						{
							num3 = 49;
							continue;
						}
						goto case 69;
					case 11:
					case 27:
						return plaintext;
					case 5:
						_c__DisplayClass99_.sourcePackets = envelope.Packets.ToArray();
						num3 = 56;
						continue;
					case 9:
					{
						List<C0bnUBLcdulm1GSDbYP8> packets = envelope.Packets;
						int num9 = envelope.Packets.Count - 1;
						prefixPacketId = result.PrefixPacketId;
						packets.Insert(num9, ux0fJQCcbmm(prefixPacketId.Value, result.PrefixBody));
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
						{
							num3 = 22;
						}
						continue;
					}
					case 33:
						if (disposition != fcEMWWf461Vje0aoly46.Replace)
						{
							num3 = 8;
							continue;
						}
						goto case 16;
					case 71:
						if (num6 != num10)
						{
							num3 = 13;
							continue;
						}
						goto case 4;
					case 39:
						return M0sfJaxDaEL(envelope);
					case 4:
					case 36:
					case 46:
						I11fCKsa55k(num6, ref _c__DisplayClass99_);
						num = 67;
						break;
					case 51:
						num6 = 0;
						num3 = 6;
						continue;
					case 49:
					case 63:
						array = new ValueTuple<uint, byte[]>[_c__DisplayClass99_.sourcePackets.Length];
						num3 = 72;
						continue;
					case 38:
						PLOfJ8uQhwy(_c__DisplayClass99_.sourcePackets[num8].PacketId, _c__DisplayClass99_.sourcePackets[num8].Body);
						num3 = 15;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
						{
							num3 = 6;
						}
						continue;
					case 67:
						num6++;
						num3 = 31;
						continue;
					case 28:
					case 73:
						if (num5 < _c__DisplayClass99_.sourcePackets.Length)
						{
							num3 = 30;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
							{
								num3 = 52;
							}
							continue;
						}
						goto case 68;
					case 8:
						if (disposition == fcEMWWf461Vje0aoly46.Drop)
						{
							num3 = 34;
							continue;
						}
						goto case 70;
					case 61:
						_c__DisplayClass99_.analysis = analysis;
						num3 = 27;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
						{
							num3 = 23;
						}
						continue;
					case 53:
					case 58:
						if (_c__DisplayClass99_.c2s)
						{
							num3 = 46;
							continue;
						}
						goto case 52;
					case 62:
						if (fZqf4rTyIgN.Negotiated)
						{
							num = 64;
							break;
						}
						goto case 11;
					case 6:
					case 31:
						if (num6 < _c__DisplayClass99_.sourcePackets.Length)
						{
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
							{
								num3 = 58;
							}
							continue;
						}
						goto case 59;
					case 56:
						_c__DisplayClass99_.results = new KWU3k1f4uMUKFgICVU5I[_c__DisplayClass99_.sourcePackets.Length];
						num = 42;
						break;
					case 13:
						if (_c__DisplayClass99_.translated[num6])
						{
							num3 = 4;
							continue;
						}
						goto case 65;
					case 35:
						num7++;
						num3 = 3;
						continue;
					case 64:
						if (!LFbfJu4L6tb(plaintext, out envelope))
						{
							num3 = 27;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
							{
								num3 = 62;
							}
							continue;
						}
						goto case 54;
					case 1:
						val = new MemoryStream();
						num3 = 77;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
						{
							num3 = 41;
						}
						continue;
					case 40:
						num8++;
						num3 = 45;
						continue;
					case 0:
					case 47:
						if (num4 >= _c__DisplayClass99_.sourcePackets.Length)
						{
							num3 = 26;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
							{
								num3 = 53;
							}
							continue;
						}
						goto case 17;
					case 22:
						num7 = 0;
						num3 = 50;
						continue;
					case 68:
						if (!_c__DisplayClass99_.c2s)
						{
							num3 = 2;
							continue;
						}
						goto case 44;
					case 44:
						if (!fZqf4rTyIgN.wEZf7k9KlnP(out packetId, out body, out note))
						{
							num3 = 50;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
							{
								num3 = 32;
							}
							continue;
						}
						goto case 1;
					case 69:
						if (_c__DisplayClass99_.sourcePackets[num8].PacketId == 11)
						{
							num3 = 38;
							continue;
						}
						goto case 40;
					case 55:
						if (result.PrefixBody == null)
						{
							num3 = 24;
							continue;
						}
						goto case 9;
					case 12:
						if (!_c__DisplayClass99_.c2s)
						{
							num3 = 28;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
							{
								num3 = 37;
							}
							continue;
						}
						goto case 51;
					case 66:
						num5 = 0;
						num = 73;
						break;
					case 26:
						fZqf4rTyIgN.DGjfmEfSd3P(array);
						num3 = 51;
						continue;
					case 16:
						envelope.Packets.Add(QYQfJJFhPPm(c0bnUBLcdulm1GSDbYP, result));
						num3 = 45;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 != 0)
						{
							num3 = 35;
						}
						continue;
					case 2:
					case 32:
					case 43:
						if (num7 == 0)
						{
							return plaintext;
						}
						num3 = 39;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
						{
							num3 = 13;
						}
						continue;
					case 65:
						PLOfJ8uQhwy(_c__DisplayClass99_.sourcePackets[num6].PacketId, _c__DisplayClass99_.sourcePackets[num6].Body);
						num3 = 36;
						continue;
					case 23:
						if (fZqf4rTyIgN != null)
						{
							num3 = 62;
							continue;
						}
						goto case 11;
					case 17:
						array[num4] = new ValueTuple<uint, byte[]>(_c__DisplayClass99_.sourcePackets[num4].PacketId, _c__DisplayClass99_.sourcePackets[num4].Body);
						num3 = 18;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
						{
							num3 = 8;
						}
						continue;
					case 25:
						result = _c__DisplayClass99_.results[num5];
						num = 74;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
						{
							num = 80;
						}
						break;
					case 21:
						_c__DisplayClass99_.__4__this = this;
						num3 = 20;
						continue;
					case 19:
					case 24:
					case 48:
					case 57:
					case 60:
						num5++;
						num3 = 28;
						continue;
					case 72:
						num4 = 0;
						num3 = 47;
						continue;
					case 59:
						envelope.Packets.Clear();
						num3 = 66;
						continue;
					case 52:
						if (_c__DisplayClass99_.sourcePackets[num6].PacketId == 11)
						{
							num3 = 71;
							continue;
						}
						goto case 4;
					case 20:
						_c__DisplayClass99_.c2s = c2s;
						num3 = 56;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
						{
							num3 = 61;
						}
						continue;
					case 3:
						prefixPacketId = result.PrefixPacketId;
						num3 = 29;
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
	private static C0bnUBLcdulm1GSDbYP8 QYQfJJFhPPm(object packet, KWU3k1f4uMUKFgICVU5I result)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		int num = 7;
		uint? replacementPacketId = default(uint?);
		uint value = default(uint);
		byte[] body2 = default(byte[]);
		C0bnUBLcdulm1GSDbYP8 result2 = default(C0bnUBLcdulm1GSDbYP8);
		MemoryStream val = default(MemoryStream);
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
						if (num2 != 16)
						{
							if (num2 == 997)
							{
								goto end_IL_0010;
							}
							goto case 6;
						}
						replacementPacketId = result.ReplacementPacketId;
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
						{
							num3 = 4;
						}
						break;
					case 4:
						if (replacementPacketId.Value == ((C0bnUBLcdulm1GSDbYP8)packet).PacketId)
						{
							num3 = 9;
							break;
						}
						replacementPacketId = result.ReplacementPacketId;
						num3 = 3;
						break;
					case 3:
						value = replacementPacketId.Value;
						num3 = 5;
						break;
					case 0:
						if (replacementPacketId.HasValue)
						{
							goto end_IL_000c;
						}
						goto case 9;
					case 9:
					{
						C0bnUBLcdulm1GSDbYP8 c0bnUBLcdulm1GSDbYP = ((C0bnUBLcdulm1GSDbYP8)packet).EYfLcHn23nK();
						c0bnUBLcdulm1GSDbYP.Body = body2;
						return c0bnUBLcdulm1GSDbYP;
					}
					case 2:
						return result2;
					case 5:
						val = new MemoryStream();
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
						{
							num3 = 1;
						}
						break;
					case 8:
						replacementPacketId = result.ReplacementPacketId;
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
						{
							num3 = 8;
						}
						break;
					case 1:
						try
						{
							GZ3fCgR9gcD(val, value);
							int num4 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 989)
									{
										num4 = num5;
										continue;
									}
									break;
								case 0:
									break;
								case 1:
									goto end_IL_0179;
								}
								result2 = (C0bnUBLcdulm1GSDbYP8)new C0bnUBLcdulm1GSDbYP8(value, (val).ToArray(), body2);
								num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
								{
									num4 = 4;
								}
								continue;
								end_IL_0179:
								break;
							}
						}
						finally
						{
							if (val != null)
							{
								int num6 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
								{
									num6 = 0;
								}
								while (true)
								{
									switch (num6)
									{
									default:
										if (num7 == 989)
										{
											num6 = num7;
											continue;
										}
										break;
									case 0:
										break;
									case 1:
										goto end_IL_020c;
									}
									(val).Dispose();
									num6 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
									{
										num6 = 1;
									}
									continue;
									end_IL_020c:
									break;
								}
							}
						}
						goto case 2;
					case 7:
					{
						byte[]? body = result.Body;
						if (body == null)
						{
							num3 = 6;
							break;
						}
						body2 = body;
						num3 = 8;
						break;
					}
					case 6:
						throw new InvalidDataException("Protocol bridge replacement result is missing its body");
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 16;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static C0bnUBLcdulm1GSDbYP8 ux0fJQCcbmm(uint packetId, object body)
	{
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		int num = 2;
		MemoryStream val = default(MemoryStream);
		int num4 = default(int);
		C0bnUBLcdulm1GSDbYP8 result = default(C0bnUBLcdulm1GSDbYP8);
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
				case 1:
					try
					{
						GZ3fCgR9gcD(val, packetId);
						int num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 == 989)
								{
									num3 = num4;
									continue;
								}
								break;
							case 0:
								break;
							case 1:
								goto end_IL_006e;
							}
							result = (C0bnUBLcdulm1GSDbYP8)new C0bnUBLcdulm1GSDbYP8(packetId, (val).ToArray(), (byte[])body);
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
							{
								num3 = 1;
							}
							continue;
							end_IL_006e:
							break;
						}
					}
					finally
					{
						if (val != null)
						{
							int num5 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d != 0)
							{
								num5 = 4;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									if (num6 == 989)
									{
										num5 = num6;
										continue;
									}
									break;
								case 0:
									break;
								case 1:
									goto end_IL_00ff;
								}
								(val).Dispose();
								num5 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
								{
									num5 = 1;
								}
								continue;
								end_IL_00ff:
								break;
							}
						}
					}
					break;
				case 2:
					val = new MemoryStream();
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
					{
						num2 = 3;
					}
					continue;
				case 0:
					break;
				}
				goto IL_0190;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_0190;
				IL_0190:
				return result;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] gNRfJCt4HAy(object plaintext, object analysis)
	{
		return (byte[])plaintext;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static C0bnUBLcdulm1GSDbYP8 FlLfJ4tiGUx(ulong runtimeEntityId, bool enabled)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		int num = 1;
		C0bnUBLcdulm1GSDbYP8 result = default(C0bnUBLcdulm1GSDbYP8);
		MemoryStream val = default(MemoryStream);
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
					if (num == 990)
					{
						goto end_IL_0010;
					}
					goto case 0;
				case 2:
					return result;
				case 1:
					val = new MemoryStream();
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					try
					{
						HSlfJhNVskF(val, runtimeEntityId);
						int num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
						{
							num3 = 3;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 != 14)
								{
									if (num4 == 994)
									{
										goto IL_0093;
									}
									goto case 4;
								}
								SCEfJUMPmwU(val, enabled ? 360000 : 0);
								num3 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
								{
									num3 = 3;
								}
								continue;
							case 6:
								result = (C0bnUBLcdulm1GSDbYP8)new C0bnUBLcdulm1GSDbYP8(28u, new byte[1] { 28 }, (val).ToArray());
								num3 = 14;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
								{
									num3 = 0;
								}
								continue;
							case 3:
								HSlfJhNVskF(val, 0uL);
								num3 = 6;
								continue;
							case 1:
								SCEfJUMPmwU(val, 0);
								num3 = 5;
								continue;
							case 5:
								(val).WriteByte(0);
								num4 = 14;
								goto IL_0093;
							case 2:
								SCEfJUMPmwU(val, 16);
								num3 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
								{
									num3 = 1;
								}
								continue;
							case 4:
								(val).WriteByte((byte)(enabled ? 1u : 3u));
								num3 = 2;
								continue;
							case 0:
								break;
								IL_0093:
								num3 = num4;
								continue;
							}
							break;
						}
					}
					finally
					{
						if (val != null)
						{
							int num5 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
							{
								num5 = 1;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									if (num6 == 989)
									{
										num5 = num6;
										continue;
									}
									break;
								case 0:
									(val).Dispose();
									num5 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
									{
										num5 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 2;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void HSlfJhNVskF(object stream, ulong value)
	{
		((dynamic)(stream)).WriteByte((byte)value);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void SCEfJUMPmwU(object stream, int value)
	{
		uint value2 = default(uint);
		GZ3fCgR9gcD(stream, value2);
	}

	[MethodImpl((MethodImplOptions)8)]
	private bool MBefJriQHJN(byte[] body, [NotNullWhen(true)] out byte[]? newBody, [NotNullWhen(true)] out string? originalPubKeyB64)
	{
		newBody = default(byte[]?);
		originalPubKeyB64 = default(string?);
		Hb8f4JT36ie = null;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private bool aWPfJoekEJr(byte[] body, [NotNullWhen(true)] out byte[]? newBody, [NotNullWhen(true)] out string? originalPubKeyB64)
	{
		newBody = default(byte[]?);
		originalPubKeyB64 = default(string?);
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		int num = 3;
		MemoryStream val = default(MemoryStream);
		byte[] array = default(byte[]);
		int authJsonByteLength = default(int);
		int pos = default(int);
		int lengthFieldOffset = default(int);
		int payloadOffset = default(int);
		int byteLength = default(int);
		bool result = default(bool);
		string publicKeyB = default(string);
		int num5 = default(int);
		JsonObject root = default(JsonObject);
		JsonObject certificateRoot = default(JsonObject);
		int num4 = default(int);
		int num7 = default(int);
		int value = default(int);
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
						if (num2 != 28)
						{
							if (num2 == 1009)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						goto case 6;
					case 18:
						val = new MemoryStream(body.Length + (array.Length - authJsonByteLength));
						num3 = 15;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
						{
							num3 = 8;
						}
						continue;
					case 9:
					{
						if (KxtfJpOENwj(body, ref pos, out string _, out lengthFieldOffset, out payloadOffset, out byteLength))
						{
							num3 = 10;
							continue;
						}
						goto case 11;
					}
					case 3:
						newBody = null;
						num3 = 2;
						continue;
					case 12:
						return result;
					case 4:
						tkwf4YlXghl = publicKeyB;
						num3 = 25;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
						{
							num3 = 16;
						}
						continue;
					case 5:
						num5 = byteLength - authJsonByteLength;
						num3 = 7;
						continue;
					case 13:
						return ae7fCWmPDkX("netease connection request did not start with a valid auth JSON");
					case 14:
						originalPubKeyB64 = publicKeyB;
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e != 0)
						{
							num3 = 4;
						}
						continue;
					case 6:
						array = (System.Text.Encoding.UTF8).GetBytes((root).ToJsonString(null));
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
						{
							num3 = 17;
						}
						continue;
					case 8:
						if (certificateRoot == null)
						{
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 != 0)
							{
								num3 = 3;
							}
							continue;
						}
						goto case 20;
					case 2:
						originalPubKeyB64 = null;
						num3 = 17;
						continue;
					case 21:
						return false;
					case 19:
						num4 = payloadOffset + authJsonByteLength;
						num3 = 5;
						continue;
					case 15:
						try
						{
							(val).Write(body, 0, lengthFieldOffset);
							int num6 = 2;
							while (true)
							{
								int num8;
								switch (num6)
								{
								default:
									if (num7 != 13)
									{
										if (num7 == 993)
										{
											goto IL_0268;
										}
										goto case 2;
									}
									(val).Write(array, 0, array.Length);
									num8 = 4;
									goto IL_0264;
								case 2:
									GZ3fCgR9gcD(val, (uint)value);
									num8 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 != 0)
									{
										num8 = 13;
									}
									goto IL_0264;
								case 0:
									result = true;
									num8 = 5;
									goto IL_0264;
								case 3:
									newBody = (val).ToArray();
									num6 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
									{
										num6 = 0;
									}
									continue;
								case 1:
									(val).Write(body, payloadOffset + byteLength, body.Length - (payloadOffset + byteLength));
									num6 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
									{
										num6 = 8;
									}
									continue;
								case 4:
									(val).Write(body, num4, num5);
									num6 = 13;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
									{
										num6 = 1;
									}
									continue;
								case 5:
									break;
									IL_0264:
									num7 = num8;
									goto IL_0268;
									IL_0268:
									num6 = num7;
									continue;
								}
								break;
							}
						}
						finally
						{
							if (val != null)
							{
								int num9 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 != 0)
								{
									num9 = 0;
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
									case 0:
										break;
									case 1:
										goto end_IL_03d0;
									}
									(val).Dispose();
									num9 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
									{
										num9 = 1;
									}
									continue;
									end_IL_03d0:
									break;
								}
							}
						}
						goto case 12;
					case 17:
						if (body.Length < 5)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
							{
								num3 = 9;
							}
							continue;
						}
						pos = 4;
						num = 9;
						break;
					case 20:
						((dynamic)(root)).Item = "Certificate";
						num = 28;
						break;
					case 11:
						return ae7fCWmPDkX("netease connection request could not be decoded");
					case 10:
					{
						if (DiJfJNFrruj(body, payloadOffset, byteLength, out root, out JsonArray chain, out certificateRoot, out authJsonByteLength))
						{
							if (WasfJOOH62j(chain, out originalPubKeyB64))
							{
								num3 = 19;
								continue;
							}
							goto case 21;
						}
						num3 = 13;
						continue;
					}
					case 0:
						value = checked(array.Length + num5);
						num3 = 18;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
						{
							num3 = 28;
						}
						continue;
					case 7:
						if (OoIfJmvvLNk(root, body, num4, num5, out publicKeyB))
						{
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
							{
								num3 = 14;
							}
							continue;
						}
						goto case 8;
					case 1:
						return ae7fCWmPDkX("netease connection request login body is too short");
					case 16:
						vT3f4yI9KRH = (string.IsNullOrWhiteSpace(vT3f4yI9KRH) ? "client ECDH key from NetEase client token" : string.Concat(vT3f4yI9KRH, "; client ECDH key from NetEase client token"));
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
						{
							num3 = 4;
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
	private static bool OoIfJmvvLNk(object requestRoot, object body, int trailingOffset, int trailingLength, [NotNullWhen(true)] out string? publicKeyB64)
	{
		publicKeyB64 = default(string?);
		int num = 20;
		uint num10 = default(uint);
		int num11 = default(int);
		int num8 = default(int);
		int pos = default(int);
		int num17 = default(int);
		bool result = default(bool);
		int num15 = default(int);
		int num19 = default(int);
		int num12 = default(int);
		int num9 = default(int);
		int num4 = default(int);
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
						if (num2 != 28)
						{
							if (num2 == 1009)
							{
								goto end_IL_0010;
							}
							goto case 3;
						}
						goto case 1;
					case 13:
						num10 = System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>((byte[])body, num11, 4)));
						num3 = 16;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e != 0)
						{
							num3 = 7;
						}
						continue;
					case 8:
					case 18:
						if (num11 + 4 <= num8)
						{
							num3 = 14;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
							{
								num3 = 13;
							}
							continue;
						}
						goto case 6;
					case 12:
						if (!ywhfJ79b6Pm(body, num11, num8 - num11, out publicKeyB64))
						{
							num = 10;
							break;
						}
						goto case 15;
					case 14:
						try
						{
							uint num13 = Xk4pP4fWwOTHm3UjNabK.q4xfWFFivJy(body, ref pos);
							int num14 = 9;
							while (true)
							{
								int num16;
								switch (num14)
								{
								default:
									if (num17 != 17)
									{
										if (num17 == 997)
										{
											goto IL_0141;
										}
										goto case 5;
									}
									goto IL_03fe;
								case 5:
									result = true;
									num16 = 17;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
									{
										num16 = 12;
									}
									goto IL_013d;
								case 0:
									num15 = (int)num13;
									num14 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d != 0)
									{
										num14 = 17;
									}
									continue;
								case 3:
									break;
								case 8:
									break;
								case 9:
									if (num13 == 0)
									{
										num14 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
										{
											num14 = 12;
										}
										continue;
									}
									goto case 4;
								case 4:
									if (num13 <= 2147483647)
									{
										num14 = 12;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
										{
											num14 = 0;
										}
										continue;
									}
									break;
								case 6:
									if (!s6UfJg2cb68((System.Text.Encoding.UTF8).GetString((byte[])body, pos, num15), out publicKeyB64))
									{
										num14 = 2;
										continue;
									}
									goto case 5;
								case 2:
									break;
								case 7:
									if (pos + num15 > num8)
									{
										num16 = 8;
										goto IL_013d;
									}
									goto case 6;
								case 1:
									break;
									IL_0141:
									num14 = num17;
									continue;
									IL_013d:
									num17 = num16;
									goto IL_0141;
								}
								break;
							}
						}
						catch
						{
							int num18 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
							{
								num18 = 0;
							}
							while (true)
							{
								switch (num18)
								{
								default:
									if (num19 == 988)
									{
										num18 = num19;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 12;
					case 16:
						if (s6UfJg2cb68((System.Text.Encoding.UTF8).GetString((byte[])body, num12, num9), out publicKeyB64))
						{
							num3 = 5;
							continue;
						}
						goto case 6;
					case 0:
						if (num10 <= 2147483647)
						{
							num3 = 2;
							continue;
						}
						goto case 6;
					case 5:
						return true;
					case 6:
						pos = num11;
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
						{
							num3 = 14;
						}
						continue;
					case 7:
						if (num10 != 0)
						{
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 != 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto case 6;
					case 9:
						num11++;
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
						{
							num3 = 8;
						}
						continue;
					case 15:
						return true;
					case 10:
						return false;
					case 4:
						num11 = trailingOffset;
						num = 28;
						break;
					case 1:
						if (num11 >= num8)
						{
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
							{
								num3 = 6;
							}
							continue;
						}
						goto case 11;
					case 17:
						num12 = num11 + 4;
						num3 = 3;
						continue;
					case 20:
						publicKeyB64 = null;
						num3 = 19;
						continue;
					case 2:
						num9 = (int)num10;
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
						{
							num3 = 17;
						}
						continue;
					case 19:
						try
						{
							JsonNode obj = ((dynamic)(requestRoot)).Item;
							if (obj == null)
							{
								num4 = 2;
								goto IL_04cd;
							}
							object jwt = obj.GetValue<string>();
							goto IL_054a;
							IL_054a:
							int num5;
							if (s6UfJg2cb68(jwt, out publicKeyB64))
							{
								num5 = 3;
								goto IL_04d1;
							}
							goto IL_05ed;
							IL_053f:
							jwt = null;
							goto IL_054a;
							IL_04cd:
							num5 = num4;
							goto IL_04d1;
							IL_04d1:
							while (true)
							{
								switch (num5)
								{
								default:
									if (num4 == 991)
									{
										goto IL_04cd;
									}
									goto case 3;
								case 1:
									break;
								case 3:
									result = true;
									num5 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
									{
										num5 = 5;
									}
									continue;
								case 2:
									goto IL_053f;
								case 0:
									goto IL_05ed;
								}
								break;
							}
						}
						catch
						{
							int num6 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 988)
									{
										num6 = num7;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
							goto IL_05ed;
						}
						goto IL_03fe;
					case 3:
						if (num12 + num9 > num8)
						{
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
							{
								num3 = 22;
							}
							continue;
						}
						goto case 16;
					case 21:
						goto IL_05ed;
					case 11:
						{
							if (!S6MfJFmQCDd(((byte[])body)[num11]))
							{
								num3 = 18;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee != 0)
								{
									num3 = 3;
								}
								continue;
							}
							goto case 9;
						}
						IL_05ed:
						num8 = System.Math.Min(((global::System.Array)body).Length, checked(trailingOffset + trailingLength));
						num3 = 4;
						continue;
						IL_03fe:
						return result;
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
	private static bool ywhfJ79b6Pm(object data, int offset, int length, [NotNullWhen(true)] out string? publicKeyB64)
	{
		publicKeyB64 = default(string?);
		string text = (System.Text.Encoding.UTF8).GetString((byte[])data, offset, length);
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool IOkfJAjAXTI(char value)
	{
		int num = 1;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void YTNfJIc0SOt(byte[] data)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(10, 1);
		(defaultInterpolatedStringHandler).AppendLiteral("login-jwt-");
		int num = default(int);
		defaultInterpolatedStringHandler.AppendFormatted<int>(num++);
		string publicKeyB = default(string);
		SO6fJBQN3ox((defaultInterpolatedStringHandler).ToStringAndClear(), publicKeyB);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SO6fJBQN3ox(string label, string? publicKeyB64)
	{
		vaJfCv76F2u[publicKeyB64] = label;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool s6UfJg2cb68(object? jwt, [NotNullWhen(true)] out string? publicKeyB64)
	{
		publicKeyB64 = default(string?);
		int num = 5;
		bool result = default(bool);
		JsonObject header = default(JsonObject);
		string text = default(string);
		int num10 = default(int);
		byte[] array = default(byte[]);
		ECDiffieHellman val = default(ECDiffieHellman);
		int num5 = default(int);
		int num7 = default(int);
		int num9 = default(int);
		int num12 = default(int);
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
						if (num2 != 12)
						{
							goto IL_003b;
						}
						goto case 3;
					case 4:
						if (!string.IsNullOrWhiteSpace((string)jwt))
						{
							break;
						}
						goto end_IL_000c;
					case 0:
						return result;
					case 1:
						try
						{
							JsonNode obj = ((dynamic)(header)).Item;
							int num4;
							if (obj == null)
							{
								num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
								{
									num4 = 7;
								}
								goto IL_00df;
							}
							object obj2 = obj.GetValue<string>();
							goto IL_01b2;
							IL_01b2:
							text = (string)obj2;
							num4 = 4;
							goto IL_00df;
							IL_00df:
							while (true)
							{
								switch (num4)
								{
								default:
									if (num10 != 13)
									{
										if (num10 == 993)
										{
											goto IL_00db;
										}
										goto case 1;
									}
									result = false;
									num4 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
									{
										num4 = 11;
									}
									continue;
								case 4:
									if (string.IsNullOrWhiteSpace(text))
									{
										num10 = 13;
										goto IL_00db;
									}
									goto case 0;
								case 0:
									array = fWwfCkAVZoN(text);
									num4 = 3;
									continue;
								case 3:
									val = System.Security.Cryptography.ECDiffieHellman.Create();
									num4 = 5;
									continue;
								case 2:
									goto end_IL_00df;
								case 1:
									obj2 = null;
									break;
								case 5:
									{
										try
										{
											(val).ImportSubjectPublicKeyInfo(default(global::System.ReadOnlySpan<byte>), out num5);
											int num6 = 4;
											while (true)
											{
												switch (num6)
												{
												default:
													if (num7 != 13)
													{
														if (num7 == 993)
														{
															goto IL_01ec;
														}
														goto case 3;
													}
													goto end_IL_01f0;
												case 3:
													if ((val).KeySize != 384)
													{
														num6 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
														{
															num6 = 3;
														}
														continue;
													}
													break;
												case 4:
													if (num5 == array.Length)
													{
														num6 = 3;
														continue;
													}
													goto case 1;
												case 2:
													goto end_IL_01f0;
												case 1:
													result = false;
													num6 = 2;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
													{
														num6 = 1;
													}
													continue;
												case 0:
													break;
												case 5:
													{
														result = true;
														num7 = 13;
														goto IL_01ec;
													}
													IL_01ec:
													num6 = num7;
													continue;
												}
												publicKeyB64 = text;
												num6 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
												{
													num6 = 5;
												}
												continue;
												end_IL_01f0:
												break;
											}
										}
										finally
										{
											if (val != null)
											{
												int num8 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
												{
													num8 = 1;
												}
												while (true)
												{
													switch (num8)
													{
													default:
														if (num9 == 989)
														{
															num8 = num9;
															continue;
														}
														break;
													case 1:
														break;
													case 0:
														goto end_IL_032b;
													}
													(val).Dispose();
													num8 = 4;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
													{
														num8 = 0;
													}
													continue;
													end_IL_032b:
													break;
												}
											}
										}
										goto end_IL_00df;
									}
									IL_00db:
									num4 = num10;
									continue;
								}
								goto IL_01b2;
								continue;
								end_IL_00df:
								break;
							}
						}
						catch
						{
							int num11 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
							{
								num11 = 1;
							}
							while (true)
							{
								switch (num11)
								{
								default:
									if (num12 == 989)
									{
										num11 = num12;
										continue;
									}
									break;
								case 1:
									break;
								case 0:
									goto end_IL_03a9;
								}
								result = false;
								num11 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
								{
									num11 = 6;
								}
								continue;
								end_IL_03a9:
								break;
							}
						}
						goto case 0;
					case 5:
						publicKeyB64 = null;
						num3 = 4;
						continue;
					case 3:
						return false;
					case 2:
						break;
					}
					goto IL_043e;
					IL_003b:
					if (num2 == 993)
					{
						break;
					}
					goto IL_043e;
					IL_043e:
					if (Mw4fQqKMB1W((string)jwt, out header, out JsonObject _))
					{
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
						{
							num3 = 1;
						}
					}
					else
					{
						num3 = 3;
					}
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 12;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private bool TryBuildProtocolBridgeLoginBody(byte[] body, string neteaseAuthEnvelopeJson, [NotNullWhen(true)] out byte[]? newBody, [NotNullWhen(true)] out string? originalPubKeyB64)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private bool FrufJlNvcV7(byte[] body, [NotNullWhen(true)] out byte[]? newBody, [NotNullWhen(true)] out string? originalPubKeyB64)
	{
		newBody = default(byte[]?);
		originalPubKeyB64 = default(string?);
		//IL_0ade: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae5: Expected O, but got Unknown
		//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ad: Expected O, but got Unknown
		//IL_0cf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0821: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		int num = 81;
		JsonObject val = default(JsonObject);
		string text6 = default(string);
		string text4 = default(string);
		MemoryStream val6 = default(MemoryStream);
		int num33 = default(int);
		int num36 = default(int);
		byte[] array4 = default(byte[]);
		int value = default(int);
		bool result = default(bool);
		byte[] array = default(byte[]);
		int num4 = default(int);
		int num38 = default(int);
		int pos = default(int);
		uint num25 = default(uint);
		int num18 = default(int);
		MemoryStream val3 = default(MemoryStream);
		int num21 = default(int);
		byte[] array5 = default(byte[]);
		int num23 = default(int);
		JsonValue val4 = default(JsonValue);
		string text5 = default(string);
		int num40 = default(int);
		int num42 = default(int);
		int num26 = default(int);
		int num14 = default(int);
		global::System.Span<byte> span = default(global::System.Span<byte>);
		int num5 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		string text2 = default(string);
		string text = default(string);
		int num12 = default(int);
		uint num6 = default(uint);
		uint num24 = default(uint);
		int num8 = default(int);
		int num10 = default(int);
		JsonArray val2 = default(JsonArray);
		string value2 = default(string);
		JsonObject val7 = default(JsonObject);
		int num44 = default(int);
		int num46 = default(int);
		JsonValue val5 = default(JsonValue);
		int num11 = default(int);
		int num28 = default(int);
		int num30 = default(int);
		int num15 = default(int);
		string publicKeyB = default(string);
		string rewrittenJwt = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					byte[] array2;
					object obj3;
					string text3;
					object obj;
					byte[] array3;
					object obj2;
					switch (num3)
					{
					default:
						if (num2 != 104)
						{
							if (num2 == 1085)
							{
								goto end_IL_0010;
							}
							goto case 74;
						}
						((dynamic)(val)).Item = "Token";
						num3 = 37;
						continue;
					case 51:
						return ae7fCWmPDkX("cloudburst login client JWT is empty");
					case 89:
						return ae7fCWmPDkX("cloudburst login auth JWT is truncated");
					case 83:
						num3 = 63;
						continue;
					case 97:
						((dynamic)(val)).Item = "Token";
						num3 = 53;
						continue;
					case 25:
						if (text4 != null)
						{
							num3 = 23;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
							{
								num3 = 14;
							}
							continue;
						}
						goto case 5;
					case 88:
						try
						{
							(val6).Write(body, 0, num33);
							int num34 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e == 0)
							{
								num34 = 12;
							}
							while (true)
							{
								int num35;
								switch (num34)
								{
								default:
									if (num36 != 15)
									{
										if (num36 == 995)
										{
											goto IL_030c;
										}
										goto case 6;
									}
									(val6).Write(array4, 0, array4.Length);
									num34 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
									{
										num34 = 2;
									}
									continue;
								case 1:
									GZ3fCgR9gcD(val6, (uint)value);
									num34 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
									{
										num34 = 3;
									}
									continue;
								case 7:
									newBody = (val6).ToArray();
									num34 = 2;
									continue;
								case 2:
									result = true;
									num34 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
									{
										num34 = 8;
									}
									continue;
								case 6:
									mgUfCIYECmF(val6, (uint)array4.Length);
									num35 = 15;
									goto IL_0308;
								case 4:
									(val6).Write(array, 0, array.Length);
									num34 = 6;
									continue;
								case 5:
									(val6).Write(body, num4, body.Length - num4);
									num34 = 7;
									continue;
								case 3:
									mgUfCIYECmF(val6, (uint)array.Length);
									num35 = 4;
									goto IL_0308;
								case 0:
									break;
									IL_0308:
									num36 = num35;
									goto IL_030c;
									IL_030c:
									num34 = num36;
									continue;
								}
								break;
							}
						}
						finally
						{
							int num37;
							if (val6 == null)
							{
								num37 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
								{
									num37 = 7;
								}
								goto IL_048d;
							}
							goto IL_04b1;
							IL_048d:
							while (true)
							{
								switch (num37)
								{
								default:
									if (num38 == 990)
									{
										goto IL_0489;
									}
									goto end_IL_048d;
								case 1:
									break;
								case 2:
									goto end_IL_048d;
								case 0:
									goto end_IL_048d;
								}
								goto IL_04b1;
								IL_0489:
								num37 = num38;
								continue;
								end_IL_048d:
								break;
							}
							goto end_IL_0455;
							IL_04b1:
							(val6).Dispose();
							num37 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
							{
								num37 = 6;
							}
							goto IL_048d;
							end_IL_0455:;
						}
						goto case 42;
					case 45:
						array2 = (System.Text.Encoding.UTF8).GetBytes((val).ToJsonString(null));
						goto IL_1bf6;
					case 48:
						pos = 4;
						num = 65;
						break;
					case 1:
						num25 = System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>(body, num18, 4)));
						num3 = 57;
						continue;
					case 73:
						try
						{
							ut4fCBflpP6(val3, 819u);
							int num19 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d != 0)
							{
								num19 = 6;
							}
							while (true)
							{
								int num20;
								switch (num19)
								{
								default:
									if (num21 != 12)
									{
										if (num21 == 992)
										{
											goto IL_05d4;
										}
										goto case 4;
									}
									goto end_IL_05d8;
								case 0:
									GZ3fCgR9gcD(val3, (uint)array5.Length);
									num19 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 != 0)
									{
										num19 = 8;
									}
									break;
								case 1:
									(val3).Write(array5, 0, array5.Length);
									num19 = 2;
									break;
								case 3:
									result = true;
									num20 = 12;
									goto IL_05d0;
								case 2:
									newBody = (val3).ToArray();
									num20 = 4;
									goto IL_05d0;
								case 4:
									{
										vT3f4yI9KRH = (string.IsNullOrWhiteSpace(vT3f4yI9KRH) ? "converted Cloudburst LoginPacket to NetEase 819 ConnectionRequest with client token" : string.Concat(vT3f4yI9KRH, "; converted Cloudburst LoginPacket to NetEase 819 ConnectionRequest with client token"));
										num20 = 3;
										goto IL_05d0;
									}
									IL_05d0:
									num21 = num20;
									goto IL_05d4;
									IL_05d4:
									num19 = num21;
									break;
								}
								continue;
								end_IL_05d8:
								break;
							}
						}
						finally
						{
							int num22;
							if (val3 == null)
							{
								num22 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
								{
									num22 = 1;
								}
								goto IL_0736;
							}
							goto IL_075a;
							IL_0736:
							while (true)
							{
								switch (num22)
								{
								default:
									if (num23 == 990)
									{
										goto IL_0732;
									}
									goto end_IL_0736;
								case 2:
									break;
								case 1:
									goto end_IL_0736;
								case 0:
									goto end_IL_0736;
								}
								goto IL_075a;
								IL_0732:
								num22 = num23;
								continue;
								end_IL_0736:
								break;
							}
							goto end_IL_06fe;
							IL_075a:
							(val3).Dispose();
							num22 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
							{
								num22 = 3;
							}
							goto IL_0736;
							end_IL_06fe:;
						}
						goto case 42;
					case 62:
						val3 = new MemoryStream(9 + array5.Length);
						num = 73;
						break;
					case 13:
						text4 = null;
						num3 = 60;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
						{
							num3 = 80;
						}
						continue;
					case 3:
						value = checked(4 + array.Length + 4 + array4.Length);
						num = 52;
						break;
					case 96:
						if (val4 == null)
						{
							num3 = 17;
							continue;
						}
						goto case 21;
					case 46:
						try
						{
							JsonNode obj10 = System.Text.Json.Nodes.JsonNode.Parse(text5, null, default(JsonDocumentOptions));
							int num39;
							if (obj10 == null)
							{
								num39 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
								{
									num39 = 0;
								}
								goto IL_0870;
							}
							object obj11 = (obj10).AsObject();
							goto IL_08a0;
							IL_08a0:
							val = (JsonObject)obj11;
							num39 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
							{
								num39 = 1;
							}
							goto IL_0870;
							IL_0870:
							while (true)
							{
								switch (num39)
								{
								default:
									if (num40 == 989)
									{
										goto IL_086c;
									}
									goto end_IL_0870;
								case 0:
									obj11 = null;
									break;
								case 1:
									goto end_IL_0870;
								}
								goto IL_08a0;
								IL_086c:
								num39 = num40;
								continue;
								end_IL_0870:
								break;
							}
						}
						catch
						{
							int num41 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
							{
								num41 = 1;
							}
							while (true)
							{
								switch (num41)
								{
								default:
									if (num42 == 989)
									{
										num41 = num42;
										continue;
									}
									break;
								case 1:
									break;
								case 0:
									goto end_IL_08f8;
								}
								result = ae7fCWmPDkX("cloudburst login auth JWT JSON could not be parsed");
								num41 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 != 0)
								{
									num41 = 0;
								}
								continue;
								end_IL_08f8:
								break;
							}
							goto case 42;
						}
						goto case 66;
					case 47:
					case 59:
						num18 = num26 + num14;
						num3 = 15;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
						{
							num3 = 1;
						}
						continue;
					case 2:
						span = MemoryExtensions.AsSpan<byte>(body, num26, num14);
						num = 38;
						break;
					case 57:
						if (num25 <= 2147483647)
						{
							num3 = 34;
							continue;
						}
						goto case 4;
					case 5:
					case 17:
					case 91:
						if (num5 == 819)
						{
							num3 = 33;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
							{
								num3 = 75;
							}
							continue;
						}
						goto case 87;
					case 95:
						flag = false;
						num3 = 64;
						continue;
					case 11:
						if (flag2)
						{
							num = 43;
							break;
						}
						goto case 3;
					case 28:
						num3 = 46;
						continue;
					case 65:
						num33 = pos;
						num3 = 39;
						continue;
					case 58:
						return ae7fCWmPDkX("cloudburst login client JWT is truncated");
					case 44:
						text2 = null;
						num3 = 22;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
						{
							num3 = 13;
						}
						continue;
					case 31:
						if (string.Equals(text, text2, (StringComparison)4))
						{
							num3 = 97;
							continue;
						}
						goto case 5;
					case 26:
					case 27:
						return ae7fCWmPDkX("cloudburst login auth JWT length is invalid");
					case 52:
						val6 = new MemoryStream(body.Length + (array.Length - num14) + (array4.Length - num12));
						num3 = 88;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 != 0)
						{
							num3 = 33;
						}
						continue;
					case 19:
						if (num6 > 2147483647)
						{
							num3 = 40;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
							{
								num3 = 71;
							}
						}
						else
						{
							int num31 = pos;
							int num32 = (int)num6;
							num4 = num31 + num32;
							num3 = 84;
						}
						continue;
					case 90:
						num14 = (int)num24;
						num3 = 63;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
						{
							num3 = 70;
						}
						continue;
					case 39:
						try
						{
							num6 = Xk4pP4fWwOTHm3UjNabK.q4xfWFFivJy(body, ref pos);
							int num7 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 != 0)
							{
								num7 = 5;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 == 988)
									{
										num7 = num8;
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
							int num9 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
							{
								num9 = 7;
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
									goto end_IL_0bf0;
								}
								result = ae7fCWmPDkX("cloudburst login JWT payload length could not be decoded");
								num9 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 != 0)
								{
									num9 = 6;
								}
								continue;
								end_IL_0bf0:
								break;
							}
							goto case 42;
						}
						goto case 69;
					case 69:
						if (num6 != 0)
						{
							num3 = 19;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
							{
								num3 = 80;
							}
							continue;
						}
						goto case 71;
					case 81:
						newBody = null;
						num3 = 80;
						continue;
					case 21:
						if (!val4.TryGetValue<string>(out text))
						{
							num = 5;
							break;
						}
						goto case 31;
					case 49:
						flag = true;
						num3 = 68;
						continue;
					case 16:
						if ((val2).Count != 0)
						{
							num3 = 20;
							continue;
						}
						goto case 23;
					case 41:
						try
						{
							JsonNode obj14 = System.Text.Json.Nodes.JsonNode.Parse(value2, null, default(JsonDocumentOptions));
							int num43;
							if (obj14 == null)
							{
								num43 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
								{
									num43 = 0;
								}
								goto IL_0d47;
							}
							object obj15 = (obj14).AsObject();
							goto IL_0d77;
							IL_0d77:
							val7 = (JsonObject)obj15;
							num43 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
							{
								num43 = 1;
							}
							goto IL_0d47;
							IL_0d47:
							while (true)
							{
								switch (num43)
								{
								default:
									if (num44 == 989)
									{
										goto IL_0d43;
									}
									goto case 0;
								case 0:
									obj15 = null;
									break;
								case 1:
									goto end_IL_0d47;
								}
								goto IL_0d77;
								IL_0d43:
								num43 = num44;
								continue;
								end_IL_0d47:
								break;
							}
						}
						catch
						{
							int num45 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
							{
								num45 = 1;
							}
							while (true)
							{
								switch (num45)
								{
								default:
									if (num46 == 989)
									{
										num45 = num46;
										continue;
									}
									break;
								case 1:
									result = ae7fCWmPDkX("cloudburst login Certificate JSON could not be parsed");
									num45 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
									{
										num45 = 1;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
							goto case 42;
						}
						goto case 50;
					case 40:
						if (val5 != null)
						{
							num3 = 70;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
							{
								num3 = 36;
							}
							continue;
						}
						goto case 74;
					case 72:
						if (num24 <= 2147483647)
						{
							num26 = pos;
							num3 = 91;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 != 0)
							{
								num3 = 90;
							}
						}
						else
						{
							num3 = 26;
						}
						continue;
					case 6:
					{
						JsonNode obj9 = ((dynamic)(val)).Item;
						if (obj9 == null)
						{
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
							{
								num3 = 57;
							}
							continue;
						}
						obj3 = (obj9).AsArray();
						goto IL_1ad6;
					}
					case 0:
						if (num24 == 0)
						{
							num = 27;
							break;
						}
						goto case 72;
					case 55:
						pos += 4;
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
						{
							num3 = 74;
						}
						continue;
					case 33:
						return ae7fCWmPDkX("cloudburst login auth JWT length is missing");
					case 22:
						num24 = System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>(body, pos, 4)));
						num3 = 55;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
						{
							num3 = 36;
						}
						continue;
					case 86:
						if (!flag)
						{
							num = 59;
							break;
						}
						goto case 93;
					case 70:
						if (num26 + num14 + 4 <= num4)
						{
							num3 = 83;
							continue;
						}
						goto case 89;
					case 18:
						((dynamic)(val)).Item = "Certificate";
						num3 = 47;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
						{
							num3 = 0;
						}
						continue;
					case 42:
						return result;
					case 60:
						if (num12 > 0)
						{
							num3 = 29;
							continue;
						}
						goto case 25;
					case 78:
						if (!string.IsNullOrWhiteSpace(value2))
						{
							num3 = 41;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e == 0)
							{
								num3 = 21;
							}
							continue;
						}
						goto case 6;
					case 36:
						value2 = ((JsonNode)val5).GetValue<string>();
						num3 = 78;
						continue;
					case 84:
						if (num4 <= body.Length)
						{
							num3 = 36;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
							{
								num3 = 76;
							}
							continue;
						}
						goto case 12;
					case 71:
						return ae7fCWmPDkX("cloudburst login JWT payload length is invalid");
					case 14:
						if (text2 != null)
						{
							num3 = 77;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
							{
								num3 = 16;
							}
							continue;
						}
						goto case 5;
					case 67:
						return ae7fCWmPDkX("cloudburst login body is too short");
					case 53:
						flag2 = false;
						num3 = 54;
						continue;
					case 8:
						if (text4 == null)
						{
							span = MemoryExtensions.AsSpan<byte>(body, num11, num12);
							num3 = 30;
						}
						else
						{
							num3 = 94;
						}
						continue;
					case 75:
						text3 = text4;
						if (text3 == null)
						{
							num3 = 79;
							continue;
						}
						goto IL_1be3;
					case 64:
					{
						JsonNode obj8 = ((dynamic)(val)).Item;
						val5 = (JsonValue)(object)((obj8 is JsonValue) ? obj8 : null);
						num3 = 16;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
						{
							num3 = 40;
						}
						continue;
					}
					case 77:
					{
						JsonNode obj7 = ((dynamic)(val)).Item;
						val4 = (JsonValue)(object)((obj7 is JsonValue) ? obj7 : null);
						num = 96;
						break;
					}
					case 61:
					case 68:
					case 92:
						if (val2 != null)
						{
							num3 = 57;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 != 0)
							{
								num3 = 16;
							}
							continue;
						}
						goto case 23;
					case 80:
						originalPubKeyB64 = null;
						num3 = 56;
						continue;
					case 24:
						if (!string.IsNullOrEmpty(text6))
						{
							num = 104;
							break;
						}
						goto case 51;
					case 85:
						obj = null;
						goto IL_1aba;
					case 63:
						try
						{
							text5 = (System.Text.Encoding.UTF8).GetString(body, num26, num14);
							int num27 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
							{
								num27 = 0;
							}
							while (true)
							{
								switch (num27)
								{
								default:
									if (num28 == 988)
									{
										num27 = num28;
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
							int num29 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
							{
								num29 = 2;
							}
							while (true)
							{
								switch (num29)
								{
								case 0:
									break;
								default:
									if (num30 == 989)
									{
										num29 = num30;
										continue;
									}
									break;
								case 1:
									result = ae7fCWmPDkX("cloudburst login auth JWT is not valid UTF-8");
									num29 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
									{
										num29 = 0;
									}
									continue;
								}
								break;
							}
							goto case 42;
						}
						goto case 28;
					case 9:
						num12 = (int)num25;
						num = 10;
						break;
					case 23:
						return ae7fCWmPDkX("cloudburst login auth JWT did not contain a certificate chain");
					case 20:
						if (!WasfJOOH62j(val2, out originalPubKeyB64))
						{
							num3 = 35;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 != 0)
							{
								num3 = 53;
							}
						}
						else
						{
							flag2 = SWFf4Cn7WLl;
							num3 = 86;
						}
						continue;
					case 10:
						if (num11 + num12 <= num4)
						{
							num3 = 44;
							continue;
						}
						goto case 58;
					case 50:
					{
						if (val7 == null)
						{
							num3 = 85;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 != 0)
							{
								num3 = 57;
							}
							continue;
						}
						JsonNode obj17 = ((dynamic)(val7)).Item;
						if (obj17 == null)
						{
							num3 = 82;
							continue;
						}
						obj = (obj17).AsArray();
						goto IL_1aba;
					}
					case 4:
						return ae7fCWmPDkX("cloudburst login client JWT length is invalid");
					case 34:
						num11 = num18 + 4;
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
						{
							num3 = 61;
						}
						continue;
					case 29:
						try
						{
							text2 = (System.Text.Encoding.UTF8).GetString(body, num11, num12);
							int num13 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
							{
								num13 = 0;
							}
							while (true)
							{
								switch (num13)
								{
								default:
									if (num15 != 19)
									{
										if (num15 == 999)
										{
											goto IL_1528;
										}
										goto case 7;
									}
									vT3f4yI9KRH = (string.IsNullOrWhiteSpace(vT3f4yI9KRH) ? "client ECDH key from Cloudburst client JWT" : string.Concat(vT3f4yI9KRH, "; client ECDH key from Cloudburst client JWT"));
									num13 = 9;
									continue;
								case 7:
									if (!s6UfJg2cb68(text2, out publicKeyB))
									{
										num13 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e != 0)
										{
											num13 = 10;
										}
										continue;
									}
									goto case 2;
								case 11:
									break;
								case 0:
								{
									global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(16, 1);
									(defaultInterpolatedStringHandler).AppendLiteral("netease-v");
									defaultInterpolatedStringHandler.AppendFormatted<int>(num5);
									(defaultInterpolatedStringHandler).AppendLiteral("-c2mitm");
									IAwf4WhcoVs = q0YfCXb4Y4I((defaultInterpolatedStringHandler).ToStringAndClear(), num5, num14, text2);
									num13 = 7;
									continue;
								}
								case 6:
									originalPubKeyB64 = publicKeyB;
									num13 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
									{
										num13 = 2;
									}
									continue;
								case 3:
								case 9:
									if (!nykfJdasDYP(text2, out rewrittenJwt))
									{
										num13 = 11;
										continue;
									}
									goto case 10;
								case 5:
									tkwf4YlXghl = publicKeyB;
									num15 = 19;
									goto IL_1528;
								case 8:
									SWFf4Cn7WLl = false;
									num13 = 9;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
									{
										num13 = 4;
									}
									continue;
								case 2:
									SO6fJBQN3ox("client-jwt", publicKeyB);
									num13 = 6;
									continue;
								case 10:
									text4 = rewrittenJwt;
									num13 = 8;
									continue;
								case 4:
									vT3f4yI9KRH = (string.IsNullOrWhiteSpace(vT3f4yI9KRH) ? "client JWT re-signed for proxy identity" : string.Concat(vT3f4yI9KRH, "; client JWT re-signed for proxy identity"));
									num13 = 16;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
									{
										num13 = 1;
									}
									continue;
								case 1:
									break;
									IL_1528:
									num13 = num15;
									continue;
								}
								break;
							}
						}
						catch
						{
							int num16 = 3;
							while (true)
							{
								IL_181e:
								int num17 = num16;
								while (true)
								{
									switch (num17)
									{
									case 0:
										goto end_IL_1822;
									default:
										if (num16 == 991)
										{
											break;
										}
										goto end_IL_1805;
									case 2:
										result = ae7fCWmPDkX("cloudburst login client JWT is not valid UTF-8");
										num17 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
										{
											num17 = 9;
										}
										continue;
									case 3:
										if (num5 == 819)
										{
											num17 = 2;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 != 0)
											{
												num17 = 7;
											}
											continue;
										}
										goto end_IL_1805;
									case 1:
										goto end_IL_1805;
									}
									goto IL_181e;
									continue;
									end_IL_1822:
									break;
								}
								break;
							}
							goto case 42;
							end_IL_1805:;
						}
						goto case 25;
					case 93:
						if (val7 != null)
						{
							num3 = 18;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
							{
								num3 = 90;
							}
							continue;
						}
						goto case 47;
					case 87:
						if (flag2)
						{
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
							{
								num3 = 47;
							}
							continue;
						}
						goto case 45;
					case 15:
						return ae7fCWmPDkX("cloudburst login auth JWT JSON is empty");
					case 35:
						return false;
					case 56:
						if (body.Length >= 13)
						{
							num5 = System.Buffers.Binary.BinaryPrimitives.ReadInt32BigEndian(((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>(body, 0, 4)));
							num3 = 48;
						}
						else
						{
							num3 = 67;
						}
						continue;
					case 66:
						if (val != null)
						{
							val7 = null;
							num3 = 66;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
							{
								num3 = 95;
							}
						}
						else
						{
							num3 = 15;
						}
						continue;
					case 94:
						array3 = (System.Text.Encoding.UTF8).GetBytes(text4);
						goto IL_1c09;
					case 37:
						array5 = (System.Text.Encoding.UTF8).GetBytes((val).ToJsonString(null));
						num3 = 62;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
						{
							num3 = 76;
						}
						continue;
					case 12:
						return ae7fCWmPDkX("cloudburst login JWT payload is truncated");
					case 76:
						if (pos + 4 <= num4)
						{
							num3 = 22;
							continue;
						}
						goto case 33;
					case 82:
						obj = null;
						goto IL_1aba;
					case 7:
						obj3 = null;
						goto IL_1ad6;
					case 74:
					{
						JsonNode obj13 = ((dynamic)(val)).Item;
						if (obj13 == null)
						{
							num3 = 32;
							continue;
						}
						obj2 = (obj13).AsArray();
						goto IL_1b35;
					}
					case 32:
						obj2 = null;
						goto IL_1b35;
					case 54:
						vT3f4yI9KRH = (string.IsNullOrWhiteSpace(vT3f4yI9KRH) ? "mirrored auth Token re-signed for proxy identity" : string.Concat(vT3f4yI9KRH, "; mirrored auth Token re-signed for proxy identity"));
						num3 = 84;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
						{
							num3 = 91;
						}
						continue;
					case 79:
						text3 = text2;
						goto IL_1be3;
					case 38:
						array2 = span.ToArray();
						goto IL_1bf6;
					case 30:
						array3 = span.ToArray();
						goto IL_1c09;
					case 43:
						{
							vT3f4yI9KRH = (string.IsNullOrWhiteSpace(vT3f4yI9KRH) ? "original AuthV2 envelope bytes preserved" : string.Concat(vT3f4yI9KRH, "; original AuthV2 envelope bytes preserved"));
							num3 = 3;
							continue;
						}
						IL_1bf6:
						array = array2;
						num3 = 8;
						continue;
						IL_1aba:
						val2 = (JsonArray)obj;
						num = 49;
						break;
						IL_1c09:
						array4 = array3;
						num3 = 95;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
						{
							num3 = 11;
						}
						continue;
						IL_1be3:
						text6 = text3;
						num3 = 24;
						continue;
						IL_1ad6:
						val2 = (JsonArray)obj3;
						num3 = 61;
						continue;
						IL_1b35:
						val2 = (JsonArray)obj2;
						num3 = 84;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
						{
							num3 = 92;
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
	private bool nykfJdasDYP(string? jwt, [NotNullWhen(true)] out string? rewrittenJwt, bool normalizeForProtocolBridge = false)
	{
		rewrittenJwt = default(string?);
		int num = 5;
		JsonObject header = default(JsonObject);
		int num6 = default(int);
		bool result = default(bool);
		JsonObject payload = default(JsonObject);
		int num8 = default(int);
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
						if (num2 != 13 && num2 == 994)
						{
							goto end_IL_0010;
						}
						goto case 6;
					case 4:
						if (string.IsNullOrWhiteSpace(jwt))
						{
							goto end_IL_000c;
						}
						goto case 0;
					case 5:
						rewrittenJwt = null;
						num3 = 4;
						break;
					case 1:
						try
						{
							((dynamic)(header)).Item = "x5u";
							int num4 = 3;
							while (true)
							{
								int num5;
								switch (num4)
								{
								default:
									if (num6 != 13)
									{
										if (num6 == 993)
										{
											goto IL_0102;
										}
										goto case 3;
									}
									goto IL_01b5;
								case 0:
									if (normalizeForProtocolBridge)
									{
										num5 = 2;
										goto IL_00fe;
									}
									goto IL_01b5;
								case 1:
									result = true;
									num4 = 4;
									continue;
								case 2:
									r13f4QPrnUA = KyMfQGPqPWY(payload);
									num5 = 13;
									goto IL_00fe;
								case 3:
									if (((dynamic)(payload)).Item != null)
									{
										num5 = 5;
										goto IL_00fe;
									}
									goto case 0;
								case 5:
									((dynamic)(payload)).Item = "identityPublicKey";
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
									{
										num4 = 9;
									}
									continue;
								case 4:
									break;
									IL_01b5:
									rewrittenJwt = UvXfQ3WcHEl(header, payload, awwfCPcCEoS);
									num4 = 12;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
									{
										num4 = 1;
									}
									continue;
									IL_00fe:
									num6 = num5;
									goto IL_0102;
									IL_0102:
									num4 = num6;
									continue;
								}
								break;
							}
						}
						catch
						{
							int num7 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 != 0)
							{
								num7 = 3;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 == 990)
									{
										num7 = num8;
										continue;
									}
									break;
								case 1:
									result = false;
									num7 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
									{
										num7 = 2;
									}
									continue;
								case 0:
									break;
								case 2:
									goto end_IL_0272;
								}
								rewrittenJwt = null;
								num7 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
								{
									num7 = 1;
								}
								continue;
								end_IL_0272:
								break;
							}
						}
						goto case 3;
					case 3:
						return result;
					case 6:
						return false;
					case 2:
						num3 = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
						{
							num3 = 1;
						}
						break;
					case 0:
						if (Mw4fQqKMB1W(jwt, out header, out payload))
						{
							num3 = 2;
							break;
						}
						goto case 6;
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
	private bool oJ5fJKSnQwP(byte[] body, [NotNullWhen(true)] out byte[]? newBody, [NotNullWhen(true)] out string? originalPubKeyB64)
	{
		newBody = default(byte[]?);
		originalPubKeyB64 = default(string?);
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_083a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		int num = 4;
		string value = default(string);
		JsonArray val4 = default(JsonArray);
		MemoryStream val6 = default(MemoryStream);
		byte[] array = default(byte[]);
		int byteLength = default(int);
		int num13 = default(int);
		int pos = default(int);
		bool result = default(bool);
		int num15 = default(int);
		JsonArray val5 = default(JsonArray);
		JsonObject val2 = default(JsonObject);
		JsonValue val3 = default(JsonValue);
		JsonObject val = default(JsonObject);
		string value2 = default(string);
		int num9 = default(int);
		int num11 = default(int);
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
					object obj2;
					object obj;
					switch (num3)
					{
					default:
						if (num2 != 42)
						{
							if (num2 == 1023)
							{
								goto end_IL_0010;
							}
							goto case 13;
						}
						if (string.IsNullOrWhiteSpace(value))
						{
							num3 = 27;
							continue;
						}
						num = 32;
						break;
					case 8:
					case 15:
						return ae7fCWmPDkX("modern login identity did not contain a certificate chain");
					case 24:
						if (val4 == null)
						{
							num3 = 29;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
							{
								num3 = 40;
							}
							continue;
						}
						goto case 9;
					case 3:
						originalPubKeyB64 = null;
						num3 = 31;
						continue;
					case 27:
						return ae7fCWmPDkX("modern login identity Certificate is empty");
					case 13:
						val6 = new MemoryStream(body.Length + (array.Length - byteLength));
						num3 = 2;
						continue;
					case 2:
						try
						{
							(val6).Write(body, 0, 4);
							int num12 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
							{
								num12 = 6;
							}
							while (true)
							{
								switch (num12)
								{
								default:
									if (num13 != 12)
									{
										if (num13 == 992)
										{
											goto IL_0207;
										}
										goto case 4;
									}
									newBody = (val6).ToArray();
									num12 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
									{
										num12 = 4;
									}
									continue;
								case 4:
									GZ3fCgR9gcD(val6, (uint)array.Length);
									num12 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
									{
										num12 = 1;
									}
									continue;
								case 1:
									(val6).Write(array, 0, array.Length);
									num12 = 2;
									continue;
								case 2:
									(val6).Write(body, pos, body.Length - pos);
									num13 = 12;
									goto IL_0207;
								case 0:
									result = true;
									num12 = 3;
									continue;
								case 3:
									break;
									IL_0207:
									num12 = num13;
									continue;
								}
								break;
							}
						}
						finally
						{
							int num14;
							if (val6 == null)
							{
								num14 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
								{
									num14 = 7;
								}
								goto IL_0322;
							}
							goto IL_036a;
							IL_0322:
							while (true)
							{
								switch (num14)
								{
								default:
									if (num15 == 990)
									{
										goto IL_031e;
									}
									goto end_IL_0322;
								case 1:
									goto end_IL_0322;
								case 2:
									break;
								case 0:
									goto end_IL_0322;
								}
								goto IL_036a;
								IL_031e:
								num14 = num15;
								continue;
								end_IL_0322:
								break;
							}
							goto end_IL_02ea;
							IL_036a:
							(val6).Dispose();
							num14 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
							{
								num14 = 6;
							}
							goto IL_0322;
							end_IL_02ea:;
						}
						goto case 7;
					case 21:
						if (val5 == null)
						{
							num3 = 8;
							continue;
						}
						goto case 23;
					case 25:
					{
						if (val2 == null)
						{
							num3 = 16;
							continue;
						}
						JsonNode obj4 = ((dynamic)(val2)).Item;
						val3 = (JsonValue)(object)((obj4 is JsonValue) ? obj4 : null);
						num3 = 12;
						continue;
					}
					case 4:
						newBody = null;
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 != 0)
						{
							num3 = 41;
						}
						continue;
					case 28:
						if (val != null)
						{
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
							{
								num3 = 30;
							}
							continue;
						}
						goto case 1;
					case 9:
						if ((val4).Count == 0)
						{
							num3 = 21;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
							{
								num3 = 34;
							}
						}
						else if (WasfJOOH62j(val4, out originalPubKeyB64))
						{
							((dynamic)(val2)).Item = "Certificate";
							num3 = 41;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
							{
								num3 = 6;
							}
						}
						else
						{
							num3 = 22;
						}
						continue;
					case 33:
						return ae7fCWmPDkX("modern login body is too short");
					case 5:
						pos = 4;
						num3 = 10;
						continue;
					case 23:
						if ((val5).Count != 0)
						{
							if (WasfJOOH62j(val5, out originalPubKeyB64))
							{
								num = 26;
								break;
							}
							goto case 20;
						}
						num3 = 15;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
						{
							num3 = 12;
						}
						continue;
					case 12:
						if (val3 != null)
						{
							num3 = 36;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
							{
								num3 = 35;
							}
							continue;
						}
						goto case 19;
					case 16:
						return ae7fCWmPDkX("modern login identity JSON is empty");
					case 31:
						if (body.Length >= 5)
						{
							num = 5;
							break;
						}
						goto case 33;
					case 20:
						return false;
					case 6:
					case 26:
						array = (System.Text.Encoding.UTF8).GetBytes((val2).ToJsonString(null));
						num3 = 13;
						continue;
					case 35:
						value = ((JsonNode)val3).GetValue<string>();
						num = 42;
						break;
					case 22:
						return false;
					case 17:
						try
						{
							JsonNode obj8 = System.Text.Json.Nodes.JsonNode.Parse(value2, null, default(JsonDocumentOptions));
							int num8;
							if (obj8 == null)
							{
								num8 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
								{
									num8 = 3;
								}
								goto IL_06b3;
							}
							object obj9 = (obj8).AsObject();
							goto IL_06e3;
							IL_06e3:
							val2 = (JsonObject)obj9;
							num8 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
							{
								num8 = 1;
							}
							goto IL_06b3;
							IL_06b3:
							while (true)
							{
								switch (num8)
								{
								default:
									if (num9 == 989)
									{
										goto IL_06af;
									}
									goto case 0;
								case 0:
									obj9 = null;
									break;
								case 1:
									goto end_IL_06b3;
								}
								goto IL_06e3;
								IL_06af:
								num8 = num9;
								continue;
								end_IL_06b3:
								break;
							}
						}
						catch
						{
							int num10 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
							{
								num10 = 5;
							}
							while (true)
							{
								switch (num10)
								{
								default:
									if (num11 == 989)
									{
										num10 = num11;
										continue;
									}
									break;
								case 1:
									break;
								case 0:
									goto end_IL_073b;
								}
								result = ae7fCWmPDkX("modern login identity JSON could not be parsed");
								num10 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 != 0)
								{
									num10 = 5;
								}
								continue;
								end_IL_073b:
								break;
							}
							goto case 7;
						}
						goto case 25;
					case 18:
						return ae7fCWmPDkX("modern login body identity token could not be decoded");
					case 0:
						num3 = 32;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
						{
							num3 = 17;
						}
						continue;
					case 10:
					{
						if (KxtfJpOENwj(body, ref pos, out value2, out int _, out int _, out byteLength))
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
							{
								num3 = 20;
							}
							continue;
						}
						goto case 18;
					}
					case 7:
						return result;
					case 32:
						try
						{
							JsonNode obj5 = System.Text.Json.Nodes.JsonNode.Parse(value, null, default(JsonDocumentOptions));
							int num4;
							if (obj5 == null)
							{
								num4 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
								{
									num4 = 6;
								}
								goto IL_0889;
							}
							object obj6 = (obj5).AsObject();
							goto IL_08b9;
							IL_08b9:
							val = (JsonObject)obj6;
							num4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
							{
								num4 = 0;
							}
							goto IL_0889;
							IL_0889:
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 989)
									{
										goto IL_0885;
									}
									goto case 0;
								case 0:
									obj6 = null;
									break;
								case 1:
									goto end_IL_0889;
								}
								goto IL_08b9;
								IL_0885:
								num4 = num5;
								continue;
								end_IL_0889:
								break;
							}
						}
						catch
						{
							int num6 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
							{
								num6 = 6;
							}
							while (true)
							{
								switch (num6)
								{
								case 0:
									goto end_IL_0911;
								default:
									if (num7 == 989)
									{
										num6 = num7;
										continue;
									}
									break;
								case 1:
									break;
								}
								result = ae7fCWmPDkX("modern login Certificate JSON could not be parsed");
								num6 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
								{
									num6 = 0;
								}
								continue;
								end_IL_0911:
								break;
							}
							goto case 7;
						}
						goto case 28;
					case 29:
					case 34:
						return ae7fCWmPDkX("modern login Certificate did not contain a certificate chain");
					case 1:
						return ae7fCWmPDkX("modern login Certificate JSON is empty");
					case 30:
					{
						JsonNode obj3 = ((dynamic)(val)).Item;
						if (obj3 == null)
						{
							num3 = 11;
							continue;
						}
						obj2 = (obj3).AsArray();
						goto IL_0a4d;
					}
					case 11:
						obj2 = null;
						goto IL_0a4d;
					case 19:
					{
						JsonNode obj11 = ((dynamic)(val2)).Item;
						if (obj11 == null)
						{
							num3 = 14;
							continue;
						}
						obj = (obj11).AsArray();
						goto IL_0aac;
					}
					case 14:
						{
							obj = null;
							goto IL_0aac;
						}
						IL_0a4d:
						val4 = (JsonArray)obj2;
						num3 = 24;
						continue;
						IL_0aac:
						val5 = (JsonArray)obj;
						num3 = 21;
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
	private bool t8TfJH17TEK(byte[] body, [NotNullWhen(true)] out byte[]? newBody, [NotNullWhen(true)] out string? originalPubKeyB64)
	{
		newBody = default(byte[]?);
		originalPubKeyB64 = default(string?);
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		int num = 4;
		JsonArray chain = default(JsonArray);
		N3Mce4f4O1LbsKljGcTC prefixKind = default(N3Mce4f4O1LbsKljGcTC);
		int chainPayloadOffset = default(int);
		int chainLength = default(int);
		JsonObject root = default(JsonObject);
		byte[] array = default(byte[]);
		MemoryStream val = default(MemoryStream);
		int num5 = default(int);
		bool result = default(bool);
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
						if (num2 != 15)
						{
							if (num2 == 996)
							{
								goto end_IL_0010;
							}
						}
						else if (WasfJOOH62j(chain, out originalPubKeyB64))
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto case 5;
					case 4:
						newBody = null;
						num3 = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
						{
							num3 = 3;
						}
						continue;
					case 7:
					{
						if (MySfJ682rjr(body, out prefixKind, out int _, out chainPayloadOffset, out chainLength, out root, out chain))
						{
							goto end_IL_000c;
						}
						goto case 6;
					}
					case 5:
						return false;
					case 1:
						array = (System.Text.Encoding.UTF8).GetBytes((root).ToJsonString(null));
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
						{
							num3 = 10;
						}
						continue;
					case 3:
						originalPubKeyB64 = null;
						num3 = 7;
						continue;
					case 0:
						val = new MemoryStream(body.Length + (array.Length - chainLength));
						num3 = 8;
						continue;
					case 6:
						return false;
					case 2:
						break;
					case 8:
						try
						{
							(val).Write(body, 0, 4);
							int num4 = 4;
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 != 12)
									{
										if (num5 == 992)
										{
											goto IL_0198;
										}
										goto case 2;
									}
									(val).Write(body, chainPayloadOffset + chainLength, body.Length - (chainPayloadOffset + chainLength));
									num4 = 2;
									continue;
								case 2:
									newBody = (val).ToArray();
									num4 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
									{
										num4 = 1;
									}
									continue;
								case 4:
									WqFfCAJOsqy(val, prefixKind, (uint)array.Length);
									num4 = 3;
									continue;
								case 3:
									(val).Write(array, 0, array.Length);
									num5 = 12;
									goto IL_0198;
								case 1:
									result = true;
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
									{
										num4 = 8;
									}
									continue;
								case 0:
									break;
									IL_0198:
									num4 = num5;
									continue;
								}
								break;
							}
						}
						finally
						{
							if (val != null)
							{
								int num6 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
								{
									num6 = 0;
								}
								while (true)
								{
									switch (num6)
									{
									default:
										if (num7 == 989)
										{
											num6 = num7;
											continue;
										}
										break;
									case 0:
										(val).Dispose();
										num6 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
										{
											num6 = 3;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
						}
						break;
					}
					return result;
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 15;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private bool KVHfJtlsxZF(byte[] body, [NotNullWhen(true)] out byte[]? newBody, [NotNullWhen(true)] out string? originalPubKeyB64)
	{
		newBody = default(byte[]?);
		originalPubKeyB64 = default(string?);
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		int num = 1;
		global::System.Collections.Generic.IEnumerator<WRVTklLcFMXgaYLUqPlB> enumerator = default(global::System.Collections.Generic.IEnumerator<WRVTklLcFMXgaYLUqPlB>);
		int num5 = default(int);
		WRVTklLcFMXgaYLUqPlB current = default(WRVTklLcFMXgaYLUqPlB);
		MemoryStream val = default(MemoryStream);
		byte[] array = default(byte[]);
		int num8 = default(int);
		bool result = default(bool);
		int num11 = default(int);
		int num13 = default(int);
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
							goto case 0;
						}
						return ae7fCWmPDkX("login body is too short for scanned certificate-chain search");
					case 4:
						if (body.Length >= 8)
						{
							enumerator = JBGfJey1Skp(body).GetEnumerator();
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
							{
								num3 = 2;
							}
							continue;
						}
						goto end_IL_000c;
					case 0:
						originalPubKeyB64 = null;
						num3 = 4;
						continue;
					case 1:
						newBody = null;
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
						{
							num3 = 6;
						}
						continue;
					case 2:
						try
						{
							while (true)
							{
								int num4;
								if (!(enumerator).MoveNext())
								{
									num4 = 2;
									goto IL_00c3;
								}
								goto IL_043e;
								IL_00bf:
								num4 = num5;
								goto IL_00c3;
								IL_043e:
								current = enumerator.Current;
								int num6 = 15;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
								{
									num6 = 16;
								}
								num5 = num6;
								goto IL_00bf;
								IL_00fa:
								if (num5 != 996)
								{
									continue;
								}
								goto IL_00bf;
								IL_00c3:
								while (true)
								{
									switch (num4)
									{
									case 7:
										val = new MemoryStream(body.Length + (array.Length - current.PayloadLength));
										num4 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
										{
											num4 = 6;
										}
										continue;
									case 4:
									case 5:
										goto end_IL_00c3;
									case 3:
										goto IL_0190;
									case 6:
										try
										{
											(val).Write(body, 0, current.LengthFieldOffset);
											int num7 = 8;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
											{
												num7 = 2;
											}
											while (true)
											{
												switch (num7)
												{
												default:
													if (num8 != 12)
													{
														if (num8 == 992)
														{
															goto IL_021a;
														}
														goto case 0;
													}
													return result;
												case 3:
													(val).Write(body, current.PayloadOffset + current.PayloadLength, body.Length - (current.PayloadOffset + current.PayloadLength));
													num7 = 4;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
													{
														num7 = 6;
													}
													break;
												case 2:
													WqFfCAJOsqy(val, current.PrefixKind, (uint)array.Length);
													num7 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
													{
														num7 = 0;
													}
													break;
												case 0:
												{
													result = true;
													int num9 = 12;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
													{
														num9 = 12;
													}
													num8 = num9;
													goto IL_021a;
												}
												case 1:
													(val).Write(array, 0, array.Length);
													num7 = 3;
													break;
												case 4:
													{
														newBody = (val).ToArray();
														num7 = 10;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
														{
															num7 = 0;
														}
														break;
													}
													IL_021a:
													num7 = num8;
													break;
												}
											}
										}
										finally
										{
											int num10;
											if (val == null)
											{
												num10 = 2;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
												{
													num10 = 8;
												}
												goto IL_0380;
											}
											goto IL_03c8;
											IL_0380:
											while (true)
											{
												switch (num10)
												{
												default:
													if (num11 == 990)
													{
														goto IL_037c;
													}
													break;
												case 2:
													goto end_IL_0380;
												case 0:
													break;
												case 1:
													goto end_IL_0380;
												}
												goto IL_03c8;
												IL_037c:
												num10 = num11;
												continue;
												end_IL_0380:
												break;
											}
											goto end_IL_0348;
											IL_03c8:
											(val).Dispose();
											num10 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
											{
												num10 = 1;
											}
											goto IL_0380;
											end_IL_0348:;
										}
									case 0:
										goto IL_0413;
									case 1:
										goto IL_043e;
									case 8:
										((dynamic)(current.Root)).Item = "Certificate";
										num4 = 3;
										continue;
									case 2:
										goto end_IL_0143;
									}
									if (num5 != 16)
									{
										goto IL_00fa;
									}
									if (!WasfJOOH62j(current.Chain, out originalPubKeyB64))
									{
										num4 = 12;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
										{
											num4 = 4;
										}
										continue;
									}
									goto IL_0413;
									IL_0413:
									if (current.CertificateRoot != null)
									{
										num4 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d != 0)
										{
											num4 = 10;
										}
										continue;
									}
									goto IL_0190;
									IL_0190:
									array = (System.Text.Encoding.UTF8).GetBytes((current.Root).ToJsonString(null));
									num4 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
									{
										num4 = 1;
									}
									continue;
									end_IL_00c3:
									break;
								}
								continue;
								end_IL_0143:
								break;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								int num12 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
								{
									num12 = 1;
								}
								while (true)
								{
									switch (num12)
									{
									default:
										if (num13 == 989)
										{
											num12 = num13;
											continue;
										}
										break;
									case 1:
										(enumerator).Dispose();
										num12 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
										{
											num12 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						break;
					case 3:
						break;
					}
					return ae7fCWmPDkX("login certificate chain was not found by scanned UInt32LE/UInt32BE/VarInt JSON search");
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 11;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private bool WasfJOOH62j(JsonArray chain, [NotNullWhen(true)] out string? originalPubKeyB64)
	{
		originalPubKeyB64 = default(string?);
		vT3f4yI9KRH = HhHfCCG6DNo((chain).Count);
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private bool VAXfJ54Q6r3(string jwt, string originalPubKeyB64, out string newJwt)
	{
		newJwt = default(string);
		JsonObject val = default(JsonObject);
		((dynamic)(val)).Item = "x5u";
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private bool MySfJ682rjr(byte[] body, out N3Mce4f4O1LbsKljGcTC prefixKind, out int chainLengthFieldOffset, out int chainPayloadOffset, out int chainLength, [NotNullWhen(true)] out JsonObject? root, [NotNullWhen(true)] out JsonArray? chain)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool KwHfJRXQTvq(byte[] body, out int chainPayloadOffset, out int chainLength, [NotNullWhen(true)] out JsonObject? root, [NotNullWhen(true)] out JsonArray? chain)
	{
		chainPayloadOffset = default(int);
		chainLength = default(int);
		root = default(JsonObject?);
		chain = default(JsonArray?);
		int pos = default(int);
		uint num = Xk4pP4fWwOTHm3UjNabK.H8lfWMJJwUX(body, ref pos);
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool fd5fJwuH5VQ(byte[] body, out int chainPayloadOffset, out int chainLength, [NotNullWhen(true)] out JsonObject? root, [NotNullWhen(true)] out JsonArray? chain)
	{
		chainPayloadOffset = default(int);
		chainLength = default(int);
		root = default(JsonObject?);
		chain = default(JsonArray?);
		int pos = default(int);
		uint num = Xk4pP4fWwOTHm3UjNabK.q4xfWFFivJy(body, ref pos);
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[IteratorStateMachine(typeof(object))]
	private static global::System.Collections.Generic.IEnumerable<WRVTklLcFMXgaYLUqPlB> JBGfJey1Skp(object body)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return (global::System.Collections.Generic.IEnumerable<WRVTklLcFMXgaYLUqPlB>)new _FindLoginChainSegments_d__125(-2)
		{
			__3__body = (byte[])body
		};
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool kKufJPyF3qi(object body, int lengthFieldOffset, N3Mce4f4O1LbsKljGcTC prefixKind, out WRVTklLcFMXgaYLUqPlB segment)
	{
		segment = default(WRVTklLcFMXgaYLUqPlB);
		int num = 20;
		int pos = default(int);
		int num9 = default(int);
		uint num4 = default(uint);
		int num6 = default(int);
		bool result = default(bool);
		int num8 = default(int);
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
						if (num2 != 30)
						{
							if (num2 == 1011)
							{
								goto end_IL_0010;
							}
							goto IL_0274;
						}
						if (AF7fJTd21RI((byte[])body, pos, num9, out JsonObject root, out JsonArray chain, out JsonObject certificateRoot))
						{
							segment = (WRVTklLcFMXgaYLUqPlB)new WRVTklLcFMXgaYLUqPlB(prefixKind, lengthFieldOffset, pos, num9, root, chain, certificateRoot);
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d != 0)
							{
								num3 = 20;
							}
						}
						else
						{
							num3 = 17;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea != 0)
							{
								num3 = 0;
							}
						}
						continue;
					}
					case 0:
						return false;
					case 4:
						return true;
					case 8:
						if (pos >= 0)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
							{
								num3 = 23;
							}
							continue;
						}
						goto case 17;
					case 12:
						pos += 4;
						num3 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
						{
							num3 = 3;
						}
						continue;
					case 21:
						return false;
					case 6:
						return false;
					case 5:
					case 22:
						return false;
					case 7:
					case 11:
						if (num4 != 0)
						{
							num = 15;
							break;
						}
						goto case 3;
					case 2:
						if (lengthFieldOffset + 4 <= ((global::System.Array)body).Length)
						{
							num4 = System.Buffers.Binary.BinaryPrimitives.ReadUInt32BigEndian(((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>((byte[])body, lengthFieldOffset, 4)));
							num3 = 16;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
							{
								num3 = 9;
							}
						}
						else
						{
							num3 = 26;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
							{
								num3 = 21;
							}
						}
						continue;
					case 16:
						return false;
					case 15:
						if (num4 > 2147483647)
						{
							num3 = 3;
							continue;
						}
						num9 = (int)num4;
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
						{
							num3 = 6;
						}
						continue;
					case 3:
						return false;
					case 14:
						goto IL_025f;
					case 18:
						goto IL_0274;
					case 9:
						pos += 4;
						num3 = 7;
						continue;
					case 20:
						segment = default(WRVTklLcFMXgaYLUqPlB);
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
						{
							num3 = 19;
						}
						continue;
					case 17:
						return false;
					case 1:
						if (GdHfJxR85p7(body, pos, num9))
						{
							num = 30;
							break;
						}
						goto case 16;
					case 13:
						switch (prefixKind)
						{
						case N3Mce4f4O1LbsKljGcTC.UInt32BE:
							break;
						case N3Mce4f4O1LbsKljGcTC.UInt32LE:
							goto IL_025f;
						case N3Mce4f4O1LbsKljGcTC.VarInt:
							goto IL_0274;
						default:
							goto IL_0315;
						}
						goto case 2;
					case 23:
						if (pos + num9 <= ((global::System.Array)body).Length)
						{
							num3 = 27;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto case 17;
					case 19:
						pos = lengthFieldOffset;
						num3 = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
						{
							num3 = 13;
						}
						continue;
					case 10:
						{
							try
							{
								num4 = Xk4pP4fWwOTHm3UjNabK.q4xfWFFivJy(body, ref pos);
								int num5 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
								{
									num5 = 0;
								}
								while (true)
								{
									switch (num5)
									{
									default:
										if (num6 == 988)
										{
											num5 = num6;
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
								int num7 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
								{
									num7 = 2;
								}
								while (true)
								{
									switch (num7)
									{
									case 0:
										return result;
									default:
										if (num8 == 989)
										{
											num7 = num8;
											continue;
										}
										break;
									case 1:
										break;
									}
									result = false;
									num7 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 != 0)
									{
										num7 = 4;
									}
								}
							}
							goto case 7;
						}
						IL_0274:
						num3 = 21;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
						{
							num3 = 10;
						}
						continue;
						IL_0315:
						num3 = 22;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 != 0)
						{
							num3 = 12;
						}
						continue;
						IL_025f:
						if (lengthFieldOffset + 4 <= ((global::System.Array)body).Length)
						{
							num4 = System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>((byte[])body, lengthFieldOffset, 4)));
							num3 = 12;
						}
						else
						{
							num3 = 6;
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
	private static bool GdHfJxR85p7(object body, int offset, int length)
	{
		int num = 6;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool S6MfJFmQCDd(byte value)
	{
		int num = 2;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool P0dfJsySJ6i(byte[] body, int chainPayloadOffset, int chainLength, [NotNullWhen(true)] out JsonObject? root, [NotNullWhen(true)] out JsonArray? chain)
	{
		JsonObject certificateRoot;
		return AF7fJTd21RI(body, chainPayloadOffset, chainLength, out root, out chain, out certificateRoot);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool AF7fJTd21RI(byte[] body, int chainPayloadOffset, int chainLength, [NotNullWhen(true)] out JsonObject? root, [NotNullWhen(true)] out JsonArray? chain, out JsonObject? certificateRoot)
	{
		root = default(JsonObject?);
		chain = default(JsonArray?);
		certificateRoot = default(JsonObject?);
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		bool result = default(bool);
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
						if (num2 != 10)
						{
							if (num2 == 991)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						certificateRoot = null;
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						try
						{
							string text = (System.Text.Encoding.UTF8).GetString(body, chainPayloadOffset, chainLength);
							int num4 = 2;
							while (true)
							{
								IL_0078:
								int num5 = num4;
								while (true)
								{
									switch (num5)
									{
									default:
										goto IL_008d;
									case 0:
										result = z9tfJMTAm7a(root, out chain, out certificateRoot);
										num5 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
										{
											num5 = 0;
										}
										continue;
									case 2:
										break;
									case 1:
										goto end_IL_007c;
									}
									goto IL_00cc;
									IL_008d:
									if (num4 == 990)
									{
										goto IL_0078;
									}
									goto IL_00cc;
									IL_00cc:
									JsonNode obj = System.Text.Json.Nodes.JsonNode.Parse(text, null, default(JsonDocumentOptions));
									root = ((obj != null) ? (obj).AsObject() : null);
									num5 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 != 0)
									{
										num5 = 3;
									}
									continue;
									end_IL_007c:
									break;
								}
								break;
							}
						}
						catch
						{
							int num6 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
							{
								num6 = 5;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 989)
									{
										num6 = num7;
										continue;
									}
									break;
								case 1:
									break;
								case 0:
									goto end_IL_0160;
								}
								result = false;
								num6 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
								{
									num6 = 3;
								}
								continue;
								end_IL_0160:
								break;
							}
						}
						goto case 3;
					case 2:
						root = null;
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
						{
							num3 = 1;
						}
						continue;
					case 3:
						return result;
					case 1:
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
			chain = null;
			num = 7;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
			{
				num = 10;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool DiJfJNFrruj(byte[] body, int payloadOffset, int payloadLength, [NotNullWhen(true)] out JsonObject? root, [NotNullWhen(true)] out JsonArray? chain, out JsonObject? certificateRoot, out int authJsonByteLength)
	{
		root = default(JsonObject?);
		chain = default(JsonArray?);
		certificateRoot = default(JsonObject?);
		authJsonByteLength = default(int);
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Invalid comparison between Unknown and I4
		int num = 15;
		int num4 = default(int);
		int num5 = default(int);
		Utf8JsonReader val2 = default(Utf8JsonReader);
		int num11 = default(int);
		JsonDocument val4 = default(JsonDocument);
		int num8 = default(int);
		bool result = default(bool);
		int num10 = default(int);
		int num13 = default(int);
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
						if (num2 != 25)
						{
							if (num2 == 1006)
							{
								goto end_IL_0010;
							}
							goto case 5;
						}
						goto case 8;
					case 6:
						try
						{
							global::System.ReadOnlySpan<byte> readOnlySpan = ((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>(body, num4, num5 - num4));
							JsonReaderOptions val = default(JsonReaderOptions);
							(val).AllowTrailingCommas = true;
							(val).CommentHandling = (JsonCommentHandling)1;
							val2 = new Utf8JsonReader(readOnlySpan, val);
							int num6 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num11 == 989)
									{
										num6 = num11;
										continue;
									}
									goto case 1;
								case 1:
									val4 = System.Text.Json.JsonDocument.ParseValue(ref val2);
									num6 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
									{
										num6 = 0;
									}
									continue;
								case 0:
									try
									{
										JsonElement val3 = (val4).RootElement;
										int num7 = 5;
										while (true)
										{
											switch (num7)
											{
											default:
												if (num8 != 13)
												{
													if (num8 == 993)
													{
														goto IL_0189;
													}
													goto case 1;
												}
												break;
											case 4:
												result = false;
												num8 = 13;
												goto IL_0189;
											case 2:
												result = z9tfJMTAm7a(root, out chain, out certificateRoot);
												num7 = 2;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 != 0)
												{
													num7 = 3;
												}
												continue;
											case 1:
												authJsonByteLength = checked(num4 - payloadOffset + (int)(val2).BytesConsumed);
												num7 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
												{
													num7 = 13;
												}
												continue;
											case 5:
												if ((int)(val3).ValueKind != 1)
												{
													num7 = 6;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
													{
														num7 = 4;
													}
													continue;
												}
												goto case 1;
											case 0:
											{
												val3 = (val4).RootElement;
												JsonNode obj = System.Text.Json.Nodes.JsonNode.Parse((val3).GetRawText(), null, default(JsonDocumentOptions));
												root = ((obj != null) ? (obj).AsObject() : null);
												num7 = 11;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
												{
													num7 = 2;
												}
												continue;
											}
											case 3:
												break;
												IL_0189:
												num7 = num8;
												continue;
											}
											break;
										}
									}
									finally
									{
										int num9;
										if (val4 == null)
										{
											num9 = 2;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
											{
												num9 = 8;
											}
											goto IL_033a;
										}
										goto IL_0382;
										IL_033a:
										while (true)
										{
											switch (num9)
											{
											default:
												if (num10 == 990)
												{
													goto IL_0336;
												}
												goto end_IL_033a;
											case 2:
												goto end_IL_033a;
											case 1:
												break;
											case 0:
												goto end_IL_033a;
											}
											goto IL_0382;
											IL_0336:
											num9 = num10;
											continue;
											end_IL_033a:
											break;
										}
										goto end_IL_0302;
										IL_0382:
										(val4).Dispose();
										num9 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
										{
											num9 = 5;
										}
										goto IL_033a;
										end_IL_0302:;
									}
									break;
								}
								break;
							}
						}
						catch
						{
							int num12 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
							{
								num12 = 2;
							}
							while (true)
							{
								int num14;
								switch (num12)
								{
								default:
									if (num13 != 12)
									{
										if (num13 == 992)
										{
											goto IL_03dc;
										}
										goto case 2;
									}
									chain = null;
									num12 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
									{
										num12 = 3;
									}
									continue;
								case 4:
									root = null;
									num14 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
									{
										num14 = 12;
									}
									goto IL_03d8;
								case 2:
									result = false;
									num12 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
									{
										num12 = 0;
									}
									continue;
								case 3:
									certificateRoot = null;
									num14 = 1;
									goto IL_03d8;
								case 1:
									authJsonByteLength = 0;
									num12 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
									{
										num12 = 2;
									}
									continue;
								case 0:
									break;
									IL_03dc:
									num12 = num13;
									continue;
									IL_03d8:
									num13 = num14;
									goto IL_03dc;
								}
								break;
							}
						}
						goto case 0;
					case 11:
						authJsonByteLength = 0;
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
						{
							num3 = 23;
						}
						continue;
					case 9:
						break;
					case 2:
						if (payloadLength > 0)
						{
							num3 = 3;
							continue;
						}
						goto case 16;
					case 4:
						certificateRoot = null;
						num3 = 11;
						continue;
					case 10:
					case 18:
						if (num4 < num5)
						{
							num3 = 17;
							continue;
						}
						goto case 5;
					case 7:
						if (payloadOffset >= 0)
						{
							num3 = 2;
							continue;
						}
						goto case 16;
					case 8:
						if (num4 >= num5)
						{
							num3 = 10;
							continue;
						}
						goto case 12;
					case 15:
						root = null;
						num3 = 14;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
						{
							num3 = 14;
						}
						continue;
					case 5:
						return false;
					case 17:
						if (body[num4] == 123)
						{
							num3 = 6;
							continue;
						}
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
						{
							num3 = 5;
						}
						continue;
					case 12:
						if (S6MfJFmQCDd(body[num4]))
						{
							num3 = 13;
							continue;
						}
						goto case 10;
					case 14:
						chain = null;
						num3 = 4;
						continue;
					case 16:
						return false;
					case 0:
						return result;
					case 3:
						if (payloadOffset + payloadLength <= body.Length)
						{
							num4 = payloadOffset;
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
							{
								num3 = 22;
							}
						}
						else
						{
							num3 = 16;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
							{
								num3 = 3;
							}
						}
						continue;
					case 1:
					case 13:
						num4++;
						num3 = 8;
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
			num5 = payloadOffset + payloadLength;
			num = 25;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool z9tfJMTAm7a(object? root, [NotNullWhen(true)] out JsonArray? chain, out JsonObject? certificateRoot)
	{
		chain = default(JsonArray?);
		certificateRoot = default(JsonObject?);
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		int num = 12;
		string value = default(string);
		JsonValue val = default(JsonValue);
		int num9 = default(int);
		int num11 = default(int);
		bool result = default(bool);
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
					JsonNode obj;
					switch (num3)
					{
					default:
						if (num2 != 21)
						{
							if (num2 == 1002)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						return false;
					case 10:
						break;
					case 5:
						return false;
					case 8:
						try
						{
							value = ((JsonNode)val).GetValue<string>();
							int num8 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
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
										num8 = num9;
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
							int num10 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
							{
								num10 = 7;
							}
							while (true)
							{
								switch (num10)
								{
								default:
									if (num11 == 989)
									{
										num10 = num11;
										continue;
									}
									break;
								case 1:
									break;
								case 0:
									goto end_IL_0147;
								}
								result = false;
								num10 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
								{
									num10 = 0;
								}
								continue;
								end_IL_0147:
								break;
							}
							goto IL_0417;
						}
						goto case 2;
					case 13:
						if (chain != null)
						{
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
							{
								num3 = 9;
							}
							continue;
						}
						goto IL_03b9;
					case 4:
						if (val != null)
						{
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 != 0)
							{
								num3 = 6;
							}
						}
						else
						{
							num3 = 5;
						}
						continue;
					case 2:
						if (string.IsNullOrWhiteSpace(value))
						{
							num3 = 9;
							continue;
						}
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
						{
							num3 = 7;
						}
						continue;
					case 12:
						chain = null;
						num3 = 11;
						continue;
					case 14:
						if (chain != null)
						{
							num3 = 13;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						return false;
					case 9:
						return false;
					case 7:
						try
						{
							JsonNode obj2 = System.Text.Json.Nodes.JsonNode.Parse(value, null, default(JsonDocumentOptions));
							certificateRoot = ((obj2 != null) ? (obj2).AsObject() : null);
							int num4 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 988)
									{
										num4 = num5;
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
							int num6 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 990)
									{
										num6 = num7;
										continue;
									}
									break;
								case 0:
									certificateRoot = null;
									num6 = 2;
									continue;
								case 2:
									break;
								case 1:
									goto end_IL_0302;
								}
								result = false;
								num6 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 != 0)
								{
									num6 = 4;
								}
								continue;
								end_IL_0302:
								break;
							}
							goto IL_0417;
						}
						goto case 3;
					case 11:
						certificateRoot = null;
						num3 = 19;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
						{
							num3 = 10;
						}
						continue;
					case 6:
						if ((chain).Count > 0)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 != 0)
							{
								num3 = 12;
							}
							continue;
						}
						goto IL_03b9;
					case 1:
						return true;
					case 0:
						return (chain).Count > 0;
					case 3:
						{
							JsonObject? obj4 = certificateRoot;
							object obj5;
							if (obj4 == null)
							{
								obj5 = null;
							}
							else
							{
								JsonNode obj6 = ((dynamic)(obj4)).Item;
								obj5 = ((obj6 != null) ? (obj6).AsArray() : null);
							}
							chain = (JsonArray?)obj5;
							num3 = 14;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 != 0)
							{
								num3 = 20;
							}
							continue;
						}
						IL_0417:
						return result;
						IL_03b9:
						obj = ((dynamic)(root)).Item;
						val = (JsonValue)(object)((obj is JsonValue) ? obj : null);
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
						{
							num3 = 7;
						}
						continue;
					}
					if (root == null)
					{
						goto end_IL_000c;
					}
					JsonNode obj8 = ((dynamic)(root)).Item;
					chain = ((obj8 != null) ? (obj8).AsArray() : null);
					num3 = 8;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
					{
						num3 = 13;
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 4;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
			{
				num = 21;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool KxtfJpOENwj(object data, ref int pos, [NotNullWhen(true)] out string? value, out int lengthFieldOffset, out int payloadOffset, out int byteLength)
	{
		value = default(string?);
		lengthFieldOffset = default(int);
		payloadOffset = default(int);
		byteLength = default(int);
		int num = 2;
		bool result = default(bool);
		int num10 = default(int);
		int num12 = default(int);
		uint num4 = default(uint);
		int num6 = default(int);
		int num8 = default(int);
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
						if (num2 == 20)
						{
							goto IL_0267;
						}
						if (num2 == 1001)
						{
							goto end_IL_0010;
						}
						goto case 3;
					case 12:
						return false;
					case 7:
						payloadOffset = pos;
						num3 = 13;
						continue;
					case 10:
						return false;
					case 4:
						if (payloadOffset + byteLength <= ((global::System.Array)data).Length)
						{
							num3 = 9;
							continue;
						}
						num3 = 12;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
						{
							num3 = 0;
						}
						continue;
					case 5:
						if (pos >= ((global::System.Array)data).Length)
						{
							num = 15;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
							{
								num = 20;
							}
							break;
						}
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
						{
							num3 = 10;
						}
						continue;
					case 2:
						value = null;
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
						{
							num3 = 19;
						}
						continue;
					case 8:
						return result;
					case 1:
						lengthFieldOffset = pos;
						num = 7;
						break;
					case 11:
						if (pos >= 0)
						{
							num3 = 5;
							continue;
						}
						goto IL_0267;
					case 9:
						try
						{
							value = (System.Text.Encoding.UTF8).GetString((byte[])data, payloadOffset, byteLength);
							int num9 = 2;
							while (true)
							{
								switch (num9)
								{
								default:
									if (num10 == 990)
									{
										num9 = num10;
										continue;
									}
									goto case 0;
								case 0:
									result = true;
									num9 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
									{
										num9 = 1;
									}
									continue;
								case 2:
									pos = payloadOffset + byteLength;
									num9 = 8;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
									{
										num9 = 0;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
						catch
						{
							int num11 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
							{
								num11 = 1;
							}
							while (true)
							{
								switch (num11)
								{
								default:
									if (num12 == 989)
									{
										num11 = num12;
										continue;
									}
									break;
								case 1:
									break;
								case 0:
									goto end_IL_0216;
								}
								result = false;
								num11 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
								{
									num11 = 1;
								}
								continue;
								end_IL_0216:
								break;
							}
						}
						goto case 8;
					case 3:
						if (num4 <= 2147483647)
						{
							byteLength = (int)num4;
							num = 6;
							break;
						}
						num3 = 10;
						continue;
					case 13:
						byteLength = 0;
						num3 = 11;
						continue;
					case 0:
						try
						{
							num4 = Xk4pP4fWwOTHm3UjNabK.q4xfWFFivJy(data, ref pos);
							int num5 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
							{
								num5 = 2;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									if (num6 == 988)
									{
										num5 = num6;
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
							int num7 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
							{
								num7 = 0;
							}
							while (true)
							{
								switch (num7)
								{
								case 1:
									break;
								default:
									if (num8 == 989)
									{
										num7 = num8;
										continue;
									}
									break;
								case 0:
									result = false;
									num7 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
									{
										num7 = 4;
									}
									continue;
								}
								break;
							}
							goto case 8;
						}
						goto case 3;
					case 6:
						{
							payloadOffset = pos;
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
							{
								num3 = 15;
							}
							continue;
						}
						IL_0267:
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private bool TryForgeServerHandshakeBody(byte[] body, [NotNullWhen(true)] out byte[]? newBody)
	{
		newBody = default(byte[]?);
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected O, but got Unknown
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected O, but got Unknown
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected O, but got Unknown
		//IL_0570: Expected O, but got Unknown
		//IL_057d: Expected O, but got Unknown
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Expected O, but got Unknown
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		int num = 15;
		string text = default(string);
		int num10 = default(int);
		ValueTuple<sh6KmlfWoQNMIWAdC2mj, sh6KmlfWoQNMIWAdC2mj> val3 = default(ValueTuple<sh6KmlfWoQNMIWAdC2mj, sh6KmlfWoQNMIWAdC2mj>);
		JsonNodeOptions? val2 = default(JsonNodeOptions?);
		bool result = default(bool);
		byte[] array = default(byte[]);
		string text3 = default(string);
		byte[] array2 = default(byte[]);
		MemoryStream val = default(MemoryStream);
		string text2 = default(string);
		int num6 = default(int);
		int num8 = default(int);
		int num12 = default(int);
		int pos = default(int);
		uint num13 = default(uint);
		JsonObject header = default(JsonObject);
		JsonObject payload2 = default(JsonObject);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					object obj2;
					object obj;
					switch (num3)
					{
					default:
						if (num2 != 25)
						{
							if (num2 == 1006)
							{
								goto end_IL_0010;
							}
							goto case 17;
						}
						try
						{
							hsDf4SaVhIn = fWwfCkAVZoN(text);
							int num4 = 19;
							while (true)
							{
								int num9;
								switch (num4)
								{
								default:
									if (num10 != 30)
									{
										if (num10 == 1010)
										{
											goto IL_028d;
										}
										goto case 20;
									}
									val3 = sh6KmlfWoQNMIWAdC2mj.NKnfWBJAuLZ(DPXfC1btUWN);
									num4 = 6;
									continue;
								case 22:
									val2 = null;
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
									{
										num4 = 19;
									}
									continue;
								case 21:
									l0DfCa7vHBs = val3.Item1;
									num9 = 5;
									goto IL_0289;
								case 1:
									l2hfC3f9Yo3 = (byte[])(upHfCE6U85R[0].SessionKey).Clone();
									num9 = 20;
									goto IL_0289;
								case 2:
									MINfCqnuiQs = 0uL;
									num4 = 18;
									continue;
								case 4:
									result = ae7fCWmPDkX("no usable P-384 client public key candidates were found");
									num4 = 3;
									continue;
								case 9:
									zoifCMkSLAU = val3.Item2;
									num4 = 18;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
									{
										num4 = 8;
									}
									continue;
								case 13:
									pOEfCnMd44e = 0uL;
									num4 = 22;
									continue;
								case 7:
									array = (System.Text.Encoding.UTF8).GetBytes(text3);
									num4 = 15;
									continue;
								case 18:
									mtXfCGmZ6JL = 0uL;
									num4 = 12;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 != 0)
									{
										num4 = 22;
									}
									continue;
								case 17:
									dRSfJkmX4Mv(array2);
									num4 = 16;
									continue;
								case 0:
								{
									JsonObject val4 = new JsonObject(val2);
									((dynamic)((object)val4)).Item = "alg";
									((dynamic)((object)val4)).Item = "x5u";
									val2 = null;
									JsonObject val5 = new JsonObject(val2);
									((dynamic)((object)val5)).Item = "salt";
									((dynamic)((object)val5)).Item = "signedToken";
									JsonObject payload = val5;
									text3 = UvXfQ3WcHEl((object)val4, payload, F9lfCss8Rat);
									num4 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
									{
										num4 = 26;
									}
									continue;
								}
								case 15:
									val = new MemoryStream();
									num4 = 11;
									continue;
								case 6:
									esVfCpjrrLM = val3.Item1;
									num4 = 9;
									continue;
								case 5:
									X6efCu4PvqJ = val3.Item2;
									num4 = 10;
									continue;
								case 19:
									nIvf4caLfd6 = fWwfCkAVZoN(text2);
									num4 = 14;
									continue;
								case 8:
									array2 = System.Security.Cryptography.RandomNumberGenerator.GetBytes(16);
									num4 = 17;
									continue;
								case 12:
									i1LfCiVqcno = 0uL;
									num4 = 13;
									continue;
								case 10:
									yjcfC2WK8O6 = true;
									num9 = 2;
									goto IL_0289;
								case 16:
									if (upHfCE6U85R.Count == 0)
									{
										num9 = 4;
										goto IL_0289;
									}
									goto case 1;
								case 14:
									DPXfC1btUWN = sh6KmlfWoQNMIWAdC2mj.I7dfWdVAwuj(M0AfCeKI42F, hsDf4SaVhIn, nIvf4caLfd6);
									num9 = 13;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
									{
										num9 = 30;
									}
									goto IL_0289;
								case 3:
									break;
								case 20:
									val3 = sh6KmlfWoQNMIWAdC2mj.NKnfWBJAuLZ(l2hfC3f9Yo3);
									num4 = 28;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
									{
										num4 = 21;
									}
									continue;
								case 11:
									{
										try
										{
											GZ3fCgR9gcD(val, (uint)array.Length);
											int num5 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
											{
												num5 = 6;
											}
											while (true)
											{
												switch (num5)
												{
												default:
													if (num6 != 10)
													{
														if (num6 == 990)
														{
															goto IL_0725;
														}
														goto case 2;
													}
													result = true;
													num5 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
													{
														num5 = 0;
													}
													continue;
												case 1:
													(val).Write(array, 0, array.Length);
													num5 = 6;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
													{
														num5 = 2;
													}
													continue;
												case 2:
													newBody = (val).ToArray();
													num6 = 10;
													goto IL_0725;
												case 0:
													break;
													IL_0725:
													num5 = num6;
													continue;
												}
												break;
											}
										}
										finally
										{
											int num7;
											if (val == null)
											{
												num7 = 3;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
												{
													num7 = 0;
												}
												goto IL_0804;
											}
											goto IL_084c;
											IL_0804:
											while (true)
											{
												switch (num7)
												{
												default:
													if (num8 == 990)
													{
														goto IL_0800;
													}
													goto end_IL_0804;
												case 0:
													goto end_IL_0804;
												case 2:
													break;
												case 1:
													goto end_IL_0804;
												}
												goto IL_084c;
												IL_0800:
												num7 = num8;
												continue;
												end_IL_0804:
												break;
											}
											goto end_IL_07cc;
											IL_084c:
											(val).Dispose();
											num7 = 8;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
											{
												num7 = 1;
											}
											goto IL_0804;
											end_IL_07cc:;
										}
										break;
									}
									IL_0289:
									num10 = num9;
									goto IL_028d;
									IL_028d:
									num4 = num10;
									continue;
								}
								break;
							}
						}
						catch (global::System.Exception ex)
						{
							int num11 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be != 0)
							{
								num11 = 2;
							}
							while (true)
							{
								switch (num11)
								{
								default:
									if (num12 == 990)
									{
										num11 = num12;
										continue;
									}
									break;
								case 0:
									result = ae7fCWmPDkX((ex).Message);
									num11 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
									{
										num11 = 1;
									}
									continue;
								case 2:
									cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "caught-exception", "TryForgeServerHandshakeBody", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Bedrock\\Relay\\Protocol\\BedrockMitmSession.cs", 2804);
									num11 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
									{
										num11 = 0;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
						goto case 7;
					case 8:
						if (tkwf4YlXghl == null)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 != 0)
							{
								num3 = 14;
							}
							continue;
						}
						pos = 0;
						num3 = 16;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
						{
							num3 = 14;
						}
						continue;
					case 6:
						if (!string.IsNullOrWhiteSpace(text2))
						{
							num = 12;
							break;
						}
						goto case 13;
					case 17:
						if (pos + num13 > body.Length)
						{
							num3 = 18;
							continue;
						}
						if (Mw4fQqKMB1W((System.Text.Encoding.UTF8).GetString(body, pos, (int)num13), out header, out payload2))
						{
							num3 = 10;
							continue;
						}
						goto case 5;
					case 7:
						return result;
					case 13:
						return ae7fCWmPDkX("handshake JWT is missing x5u or salt");
					case 12:
						num = 25;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
						{
							num = 8;
						}
						break;
					case 5:
						return ae7fCWmPDkX("handshake JWT could not be parsed");
					case 10:
					{
						JsonNode obj4 = ((dynamic)(header)).Item;
						if (obj4 == null)
						{
							num3 = 4;
							continue;
						}
						obj2 = obj4.GetValue<string>();
						goto IL_0a82;
					}
					case 11:
						if (num13 != 0)
						{
							num3 = 17;
							continue;
						}
						goto case 18;
					case 14:
						newBody = null;
						num3 = 8;
						continue;
					case 18:
						return ae7fCWmPDkX("handshake JWT length is invalid");
					case 16:
						if (body.Length == 0)
						{
							num3 = 19;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f != 0)
							{
								num3 = 2;
							}
							continue;
						}
						num13 = Xk4pP4fWwOTHm3UjNabK.q4xfWFFivJy(body, ref pos);
						num3 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
						{
							num3 = 17;
						}
						continue;
					case 9:
					{
						JsonNode obj3 = ((dynamic)(payload2)).Item;
						if (obj3 == null)
						{
							num3 = 3;
							continue;
						}
						obj = obj3.GetValue<string>();
						goto IL_0a99;
					}
					case 15:
						VHif48EsEGT = null;
						num = 14;
						break;
					case 2:
						return ae7fCWmPDkX("handshake body is empty");
					case 0:
						if (!string.IsNullOrWhiteSpace(text))
						{
							num3 = 6;
							continue;
						}
						goto case 13;
					case 1:
						return ae7fCWmPDkX("client identity key is unavailable; split LoginPacket was likely not intercepted");
					case 4:
						obj2 = null;
						goto IL_0a82;
					case 3:
						{
							obj = null;
							goto IL_0a99;
						}
						IL_0a82:
						text = (string)obj2;
						num3 = 9;
						continue;
						IL_0a99:
						text2 = (string)obj;
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
						{
							num3 = 0;
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
	private bool LFbfJu4L6tb(byte[] payload, [NotNullWhen(true)] out IRDioILcOhJp3huAFEli? envelope)
	{
		envelope = default(IRDioILcOhJp3huAFEli?);
		int num = 28;
		bool rawDeflate = default(bool);
		S3TYvPf4dw0Js0IbGOQN s3TYvPf4dw0Js0IbGOQN = default(S3TYvPf4dw0Js0IbGOQN);
		byte? prefixByte = default(byte?);
		List<C0bnUBLcdulm1GSDbYP8> packets = default(List<C0bnUBLcdulm1GSDbYP8>);
		byte[] raw = default(byte[]);
		int num5 = default(int);
		byte b = default(byte);
		int num6 = default(int);
		byte[] array = default(byte[]);
		int num8 = default(int);
		bool result = default(bool);
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
						if (num2 != 37)
						{
							if (num2 == 1018)
							{
								goto end_IL_0010;
							}
							goto case 7;
						}
						rawDeflate = false;
						num3 = 19;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
						{
							num3 = 13;
						}
						continue;
					case 6:
						s3TYvPf4dw0Js0IbGOQN = S3TYvPf4dw0Js0IbGOQN.None;
						num3 = 12;
						continue;
					case 17:
						envelope = (IRDioILcOhJp3huAFEli?)new IRDioILcOhJp3huAFEli(prefixByte, s3TYvPf4dw0Js0IbGOQN, rawDeflate, packets);
						num3 = 26;
						continue;
					case 28:
						envelope = null;
						num3 = 21;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
						{
							num3 = 27;
						}
						continue;
					case 27:
						prefixByte = null;
						num3 = 13;
						continue;
					case 30:
						s3TYvPf4dw0Js0IbGOQN = S3TYvPf4dw0Js0IbGOQN.Zlib;
						num3 = 20;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
						{
							num3 = 8;
						}
						continue;
					case 3:
						prefixByte = (byte)1;
						num3 = 11;
						continue;
					case 21:
						raw = payload;
						num3 = 29;
						continue;
					case 13:
						s3TYvPf4dw0Js0IbGOQN = S3TYvPf4dw0Js0IbGOQN.None;
						num = 37;
						break;
					case 15:
						num5 = 1;
						num3 = 25;
						continue;
					case 1:
					case 29:
						packets = Qr3fJ1tTPnf(raw);
						num3 = 17;
						continue;
					case 18:
						if (b != 1)
						{
							num3 = 24;
							continue;
						}
						goto case 3;
					case 14:
						prefixByte = (byte)0;
						num3 = 30;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
						{
							num3 = 9;
						}
						continue;
					case 19:
						if (!Exwf4k344JG)
						{
							num3 = 21;
							continue;
						}
						goto case 16;
					case 0:
						if (payload.Length == 0)
						{
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
							{
								num3 = 9;
							}
							continue;
						}
						goto case 2;
					case 2:
						b = payload[0];
						num3 = 10;
						continue;
					case 24:
						if (b != 255)
						{
							num3 = 20;
							continue;
						}
						goto case 4;
					case 23:
						s3TYvPf4dw0Js0IbGOQN = xLIf4D9F3Tr;
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
						{
							num3 = 12;
						}
						continue;
					case 11:
						s3TYvPf4dw0Js0IbGOQN = S3TYvPf4dw0Js0IbGOQN.Snappy;
						num3 = 15;
						continue;
					case 7:
					case 9:
					case 20:
					case 22:
					case 25:
						num = 5;
						break;
					case 8:
						num5 = 1;
						num3 = 7;
						continue;
					case 12:
						num5 = 1;
						num3 = 22;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
						{
							num3 = 6;
						}
						continue;
					case 5:
						try
						{
							int num4;
							if (s3TYvPf4dw0Js0IbGOQN != S3TYvPf4dw0Js0IbGOQN.Zlib)
							{
								num4 = 15;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
								{
									num4 = 0;
								}
								goto IL_0343;
							}
							goto IL_040b;
							IL_040b:
							raw = THIfCSKjY3q(payload, num5, out rawDeflate);
							num6 = 15;
							goto IL_033f;
							IL_033f:
							num4 = num6;
							goto IL_0343;
							IL_0343:
							while (true)
							{
								switch (num4)
								{
								case 0:
									if (s3TYvPf4dw0Js0IbGOQN != S3TYvPf4dw0Js0IbGOQN.Snappy)
									{
										num4 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
										{
											num4 = 1;
										}
										continue;
									}
									goto case 3;
								case 1:
								case 5:
									array = payload[System.Range.StartAt(((System.Index)num5))];
									num4 = 11;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
									{
										num4 = 7;
									}
									continue;
								case 6:
									goto IL_040b;
								case 4:
								case 7:
									raw = array;
									num4 = 2;
									continue;
								case 3:
									array = Snappier.Snappy.DecompressToArray(((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>(payload, num5)));
									num4 = 4;
									continue;
								case 2:
									goto end_IL_030a;
								}
								break;
							}
							if (num6 != 15)
							{
								if (num6 == 995)
								{
									goto IL_033f;
								}
								goto IL_040b;
							}
							end_IL_030a:;
						}
						catch
						{
							int num7 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce != 0)
							{
								num7 = 3;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 == 989)
									{
										num7 = num8;
										continue;
									}
									break;
								case 0:
									result = false;
									num7 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
									{
										num7 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
							goto IL_056d;
						}
						goto case 1;
					case 16:
						num5 = 0;
						num3 = 23;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
						{
							num3 = 20;
						}
						continue;
					case 10:
						if (b != 0)
						{
							num3 = 18;
							continue;
						}
						goto case 14;
					case 4:
						prefixByte = (byte)255;
						num3 = 6;
						continue;
					case 26:
						{
							return true;
						}
						IL_056d:
						return result;
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
	private byte[] M0sfJaxDaEL(IRDioILcOhJp3huAFEli envelope)
	{
		//IL_067c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		byte[] array2 = default(byte[]);
		int num10 = default(int);
		byte[] array6 = default(byte[]);
		S3TYvPf4dw0Js0IbGOQN algo = default(S3TYvPf4dw0Js0IbGOQN);
		byte[] array3 = default(byte[]);
		byte[] array4 = default(byte[]);
		byte? prefixByte = default(byte?);
		int num5 = default(int);
		C0bnUBLcdulm1GSDbYP8 current = default(C0bnUBLcdulm1GSDbYP8);
		MemoryStream val = default(MemoryStream);
		int num8 = default(int);
		byte[] array = default(byte[]);
		int num12 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0021;
				case 2:
					return array2;
				case 0:
					try
					{
						global::System.Collections.Generic.IEnumerator<C0bnUBLcdulm1GSDbYP8> enumerator = envelope.Packets.GetEnumerator();
						int num3 = 17;
						while (true)
						{
							byte[] array7;
							int num9;
							switch (num3)
							{
							default:
								if (num10 != 30)
								{
									if (num10 == 1010)
									{
										goto IL_005d;
									}
									goto case 9;
								}
								goto case 1;
							case 6:
								array2 = array6;
								num3 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
								{
									num3 = 21;
								}
								continue;
							case 9:
								if (algo != S3TYvPf4dw0Js0IbGOQN.Snappy)
								{
									num3 = 22;
									continue;
								}
								goto case 7;
							case 18:
								array7 = PUqfC06xbfu(array3);
								break;
							case 1:
							case 10:
								array2 = array4;
								num3 = 11;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
								{
									num3 = 23;
								}
								continue;
							case 16:
							{
								byte[] array5 = array6;
								prefixByte = envelope.PrefixByte;
								array5[0] = prefixByte.Value;
								num3 = 20;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 != 0)
								{
									num3 = 0;
								}
								continue;
							}
							case 17:
								try
								{
									while (true)
									{
										int num4;
										if (!enumerator.MoveNext())
										{
											num4 = 12;
											goto IL_0198;
										}
										goto IL_028c;
										IL_0198:
										num5 = num4;
										goto IL_019c;
										IL_028c:
										current = enumerator.Current;
										int num6 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
										{
											num6 = 2;
										}
										goto IL_01a0;
										IL_019c:
										num6 = num5;
										goto IL_01a0;
										IL_01a0:
										while (true)
										{
											switch (num6)
											{
											default:
												if (num5 != 12)
												{
													if (num5 == 992)
													{
														goto IL_019c;
													}
													goto case 2;
												}
												goto end_IL_024f;
											case 0:
												GZ3fCgR9gcD(val, (uint)(current.HeaderBytes.Length + current.Body.Length));
												num6 = 3;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e == 0)
												{
													num6 = 2;
												}
												continue;
											case 2:
												(val).Write(current.Body, 0, current.Body.Length);
												num6 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
												{
													num6 = 1;
												}
												continue;
											case 1:
												break;
											case 3:
												goto IL_0265;
											case 4:
												goto IL_028c;
											}
											break;
										}
										continue;
										IL_0265:
										(val).Write(current.HeaderBytes, 0, current.HeaderBytes.Length);
										num4 = 2;
										goto IL_0198;
										continue;
										end_IL_024f:
										break;
									}
								}
								finally
								{
									((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
									int num7 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
									{
										num7 = 1;
									}
									while (true)
									{
										switch (num7)
										{
										default:
											if (num8 == 988)
											{
												num7 = num8;
												continue;
											}
											break;
										case 0:
											break;
										}
										break;
									}
								}
								goto case 14;
							case 20:
								System.Buffer.BlockCopy(array, 0, array6, 1, array.Length);
								num3 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
								{
									num3 = 22;
								}
								continue;
							case 12:
								algo = envelope.Algo;
								num3 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e != 0)
								{
									num3 = 25;
								}
								continue;
							case 4:
							case 19:
								array6 = new byte[1 + array.Length];
								num3 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f != 0)
								{
									num3 = 16;
								}
								continue;
							case 15:
								array2 = array;
								num3 = 5;
								continue;
							case 2:
								if (algo != S3TYvPf4dw0Js0IbGOQN.Zlib)
								{
									num3 = 13;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
									{
										num3 = 9;
									}
									continue;
								}
								goto case 8;
							case 14:
								array3 = (val).ToArray();
								num3 = 12;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
								{
									num3 = 20;
								}
								continue;
							case 5:
								goto end_IL_0061;
							case 0:
							case 22:
								array4 = array3;
								num9 = 10;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
								{
									num9 = 30;
								}
								goto IL_0059;
							case 3:
								if (prefixByte.HasValue)
								{
									num3 = 19;
									continue;
								}
								goto case 15;
							case 8:
								if (!envelope.RawDeflate)
								{
									num3 = 18;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 != 0)
									{
										num3 = 11;
									}
									continue;
								}
								array7 = z6NfCcAfpEq(array3);
								break;
							case 11:
								array = array2;
								num9 = 13;
								goto IL_0059;
							case 13:
								prefixByte = envelope.PrefixByte;
								num3 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
								{
									num3 = 3;
								}
								continue;
							case 7:
								array4 = Snappier.Snappy.CompressToArray(default(global::System.ReadOnlySpan<byte>));
								num9 = 10;
								goto IL_0059;
							case 21:
								goto end_IL_0061;
								IL_0059:
								num10 = num9;
								goto IL_005d;
								IL_005d:
								num3 = num10;
								continue;
							}
							array4 = array7;
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
							{
								num3 = 11;
							}
							continue;
							end_IL_0061:
							break;
						}
					}
					finally
					{
						int num11;
						if (val == null)
						{
							num11 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
							{
								num11 = 2;
							}
							goto IL_05e9;
						}
						goto IL_060d;
						IL_05e9:
						while (true)
						{
							switch (num11)
							{
							default:
								if (num12 == 990)
								{
									goto IL_05e5;
								}
								break;
							case 0:
								break;
							case 1:
								goto end_IL_05e9;
							case 2:
								goto end_IL_05e9;
							}
							goto IL_060d;
							IL_05e5:
							num11 = num12;
							continue;
							end_IL_05e9:
							break;
						}
						goto end_IL_05b1;
						IL_060d:
						(val).Dispose();
						num11 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
						{
							num11 = 5;
						}
						goto IL_05e9;
						end_IL_05b1:;
					}
					goto case 2;
				case 1:
					break;
				}
				goto IL_067c;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_067c;
				IL_067c:
				val = new MemoryStream();
				num2 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
				{
					num2 = 4;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static List<C0bnUBLcdulm1GSDbYP8> Qr3fJ1tTPnf(object raw)
	{
		int num = default(int);
		int num2 = default(int);
		byte[] subArray = ((byte[])raw)[((System.Index)num)..((System.Index)num2)];
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void EgyfJ3eyjnP(byte[] plaintextBatch, bool checksumOk, bool c2s, StringBuilder output)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SZufJvehcva(string phase, bool c2s, C0bnUBLcdulm1GSDbYP8 packet, string name, string details, bool checksumOk)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string qlAfJEJ1k6p(object data, int maxBytes)
	{
		int num = default(int);
		string text = System.Convert.ToHexString(((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>((byte[])data, 0, num)));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string ParsePacketDetails(uint packetId, object body)
	{
		int num = 1;
		string text = default(string);
		int num4 = default(int);
		string result = default(string);
		int num6 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 0:
				break;
			default:
				try
				{
					int num2;
					if (packetId <= 107)
					{
						num2 = 29;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
						{
							num2 = 76;
						}
						goto IL_006d;
					}
					goto IL_0e70;
					IL_0c69:
					text = ns0fQs6n1EA(body);
					int num3 = 33;
					goto IL_0065;
					IL_07db:
					text = JV3fQUtFp5L(body);
					num3 = 127;
					goto IL_0065;
					IL_006d:
					while (true)
					{
						switch (num2)
						{
						default:
							if (num4 != 135)
							{
								if (num4 == 1115)
								{
									goto IL_0069;
								}
								goto IL_0a41;
							}
							goto IL_0aa1;
						case 115:
							text = KgafQKiGN43(body);
							num2 = 61;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
							{
								num2 = 28;
							}
							continue;
						case 99:
							text = VvufQQpZCK5(body);
							num2 = 80;
							continue;
						case 85:
							if (packetId != 326)
							{
								num2 = 114;
								continue;
							}
							goto IL_07db;
						case 4:
						case 6:
						case 8:
						case 11:
						case 13:
						case 14:
						case 15:
						case 19:
						case 22:
						case 25:
						case 27:
						case 28:
						case 29:
						case 31:
						case 33:
						case 38:
						case 39:
						case 43:
						case 46:
						case 52:
						case 54:
						case 56:
						case 59:
						case 65:
						case 69:
						case 73:
						case 80:
						case 81:
						case 82:
						case 84:
						case 87:
						case 93:
						case 107:
						case 110:
						case 116:
						case 118:
						case 120:
						case 122:
						case 123:
						case 127:
							result = text;
							num2 = 101;
							continue;
						case 35:
							switch (packetId)
							{
							case 30u:
								goto IL_0895;
							case 33u:
								goto IL_0a0b;
							case 31u:
							case 32u:
								goto IL_0aa1;
							case 29u:
								goto IL_0de6;
							}
							num2 = 45;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
							{
								num2 = 125;
							}
							continue;
						case 20:
							text = H0efQfiWEKL(body);
							num2 = 25;
							continue;
						case 96:
							text = tYWfQxeToxK(body);
							num2 = 27;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
							{
								num2 = 13;
							}
							continue;
						case 88:
							if (packetId != 86)
							{
								num2 = 50;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
								{
									num2 = 100;
								}
								continue;
							}
							goto case 58;
						case 2:
							if (packetId != 135)
							{
								goto IL_041d;
							}
							goto case 32;
						case 74:
							text = hBcfQC0R6yp(body);
							num2 = 31;
							continue;
						case 17:
							text = NmYfQewAWYt(body);
							num2 = 56;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
							{
								num2 = 58;
							}
							continue;
						case 47:
							break;
						case 124:
							if (packetId != 70)
							{
								goto IL_0489;
							}
							goto case 67;
						case 57:
						case 94:
							if (packetId <= 228)
							{
								num2 = 63;
								continue;
							}
							goto case 55;
						case 117:
							text = k2ofQhSxMO1(body);
							num2 = 120;
							continue;
						case 16:
						case 66:
							if (packetId != 25)
							{
								num2 = 71;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
								{
									num2 = 35;
								}
								continue;
							}
							goto case 125;
						case 119:
							goto IL_0505;
						case 55:
							if (packetId != 312)
							{
								num2 = 85;
								continue;
							}
							goto case 37;
						case 0:
							goto IL_0550;
						case 92:
							if (packetId != 58)
							{
								num2 = 77;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
								{
									num2 = 82;
								}
								continue;
							}
							goto case 26;
						case 41:
							goto IL_0598;
						case 75:
							goto IL_05bf;
						case 44:
							text = nBGfQJOlXm5(body);
							num2 = 93;
							continue;
						case 9:
							text = OHGfQMcQQYY(body);
							num2 = 22;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
							{
								num2 = 85;
							}
							continue;
						case 68:
							text = vhPfJi3Wfpv(body);
							num2 = 116;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
							{
								num2 = 55;
							}
							continue;
						case 42:
							text = BAYfQYhPiNv(body);
							num2 = 54;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 != 0)
							{
								num2 = 50;
							}
							continue;
						case 60:
							if (packetId > 21)
							{
								num2 = 16;
								continue;
							}
							goto case 71;
						case 10:
						case 61:
							if (packetId > 203)
							{
								num2 = 57;
								continue;
							}
							goto case 23;
						case 90:
							if (packetId > 70)
							{
								goto case 88;
							}
							goto IL_0711;
						case 34:
							goto IL_071b;
						case 58:
							text = UGZfQ8NJdrJ(body);
							num2 = 107;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
							{
								num2 = 52;
							}
							continue;
						case 32:
							text = Sj9fQ40sLVE(body);
							num2 = 69;
							continue;
						case 49:
							goto IL_07db;
						case 112:
							text = oPlfQFwT5Cy(body);
							num2 = 118;
							continue;
						case 37:
							text = Ll8fJntLSa0(body);
							num2 = 13;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
							{
								num2 = 22;
							}
							continue;
						case 106:
							if (packetId != 121)
							{
								num2 = 111;
								continue;
							}
							goto case 99;
						case 62:
							if (packetId != 193)
							{
								num2 = 121;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
								{
									num2 = 5;
								}
								continue;
							}
							goto case 96;
						case 102:
							goto IL_0895;
						case 70:
							goto IL_08a7;
						case 23:
							if (packetId == 144)
							{
								goto case 117;
							}
							goto IL_08d9;
						case 53:
							switch (packetId)
							{
							case 18u:
								break;
							case 19u:
								goto IL_0505;
							default:
								goto IL_090b;
							case 20u:
								goto IL_0aa1;
							case 21u:
								goto IL_0c42;
							}
							goto case 20;
						case 64:
							if (packetId != 69)
							{
								num2 = 26;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
								{
									num2 = 124;
								}
								continue;
							}
							goto case 104;
						case 105:
							if (packetId != 143)
							{
								num2 = 15;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
								{
									num2 = 18;
								}
								continue;
							}
							goto case 112;
						case 63:
							if (packetId != 208)
							{
								num2 = 48;
								continue;
							}
							goto case 36;
						case 77:
							if (packetId != 61)
							{
								num2 = 135;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
								{
									num2 = 3;
								}
								continue;
							}
							goto case 68;
						case 100:
							if (packetId != 107)
							{
								num2 = 97;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
								{
									num2 = 98;
								}
								continue;
							}
							goto case 51;
						case 72:
							goto IL_0a0b;
						case 40:
							goto IL_0a41;
						case 51:
							text = PqhfQy50XIL(body);
							num2 = 82;
							continue;
						case 3:
						case 5:
						case 18:
						case 86:
						case 91:
						case 95:
						case 98:
						case 111:
						case 113:
						case 114:
							goto IL_0aa1;
						case 109:
							goto IL_0ac7;
						case 78:
							goto IL_0ad9;
						case 7:
							text = rfnfJGx4gkS(body);
							num2 = 19;
							continue;
						case 121:
							switch (packetId)
							{
							case 200u:
								break;
							case 202u:
								goto IL_0598;
							case 201u:
								goto IL_0aa1;
							default:
								goto IL_0b2e;
							case 203u:
								goto IL_0c30;
							}
							goto case 115;
						case 26:
							text = yndfQSp7Csc(body);
							num2 = 84;
							continue;
						case 71:
							switch (packetId)
							{
							case 5u:
								break;
							case 4u:
								goto IL_0aa1;
							case 2u:
								goto IL_0ac7;
							case 3u:
								goto IL_0ad9;
							default:
								goto IL_0b66;
							case 1u:
								goto IL_0c69;
							}
							goto case 9;
						case 36:
							text = S5ofJzZRMvK(body);
							num2 = 81;
							continue;
						case 48:
							if (packetId != 228)
							{
								num2 = 113;
								continue;
							}
							goto case 17;
						case 21:
							if (packetId != 113)
							{
								num2 = 106;
								continue;
							}
							goto case 44;
						case 103:
							goto IL_0c0f;
						case 50:
							goto IL_0c30;
						case 24:
							goto IL_0c42;
						case 12:
							goto IL_0c69;
						case 126:
							if (packetId <= 61)
							{
								num2 = 79;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
								{
									num2 = 104;
								}
								continue;
							}
							goto case 90;
						case 83:
							goto IL_0cf3;
						case 79:
							if (packetId != 45)
							{
								num2 = 92;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
								{
									num2 = 58;
								}
								continue;
							}
							goto case 7;
						case 108:
							switch (packetId)
							{
							case 10u:
								break;
							case 14u:
								goto IL_071b;
							case 13u:
								goto IL_0a41;
							case 11u:
							case 12u:
								goto IL_0aa1;
							default:
								goto IL_0db5;
							}
							goto IL_0550;
						case 76:
							if (packetId > 40)
							{
								goto case 126;
							}
							goto IL_0ddc;
						case 89:
							goto IL_0de6;
						case 45:
							switch (packetId)
							{
							case 40u:
								break;
							case 37u:
							case 38u:
								goto IL_0aa1;
							case 36u:
								goto IL_0c0f;
							case 39u:
								goto IL_0cf3;
							default:
								goto IL_0e54;
							}
							goto case 42;
						case 104:
							text = ztkfQcS5apx(body);
							num2 = 43;
							continue;
						case 1:
							goto IL_0e70;
						case 67:
							text = cbCfQ0tRZc4(body);
							num2 = 6;
							continue;
						case 30:
						case 97:
							if (packetId != 129)
							{
								num2 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
								{
									num2 = 9;
								}
								continue;
							}
							goto case 74;
						case 125:
							text = C8LfQZAbiGa(body);
							num2 = 15;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 != 0)
							{
								num2 = 41;
							}
							continue;
						case 101:
							goto end_IL_0034;
							IL_0aa1:
							text = string.Empty;
							num2 = 117;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
							{
								num2 = 39;
							}
							continue;
							IL_0e54:
							num2 = 95;
							continue;
							IL_0db5:
							num2 = 53;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 != 0)
							{
								num2 = 111;
							}
							continue;
							IL_0505:
							text = mU3fQLVDL6p(body);
							num2 = 123;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 != 0)
							{
								num2 = 39;
							}
							continue;
							IL_0cf3:
							text = TNMfQVg1jYI(body);
							num2 = 11;
							continue;
							IL_0c0f:
							text = t3UfJqKQVrR(body);
							num2 = 65;
							continue;
							IL_0de6:
							text = snvfQ9lWuc1(body, "attributes");
							num2 = 18;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
							{
								num2 = 14;
							}
							continue;
							IL_0c30:
							text = UdvfQRbFTgF(body);
							num2 = 107;
							continue;
							IL_0a41:
							text = m8nfQbQ5Ffj(body);
							num2 = 87;
							continue;
							IL_0a0b:
							text = SMFfQDSF7ta(body);
							num2 = 59;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
							{
								num2 = 121;
							}
							continue;
							IL_0895:
							text = xbUfQkEfDXL(body);
							num2 = 122;
							continue;
							IL_0c42:
							text = UYNfQjDv7f8(body);
							num2 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
							{
								num2 = 33;
							}
							continue;
							IL_090b:
							num2 = 91;
							continue;
							IL_071b:
							text = chcfQXBClju(body);
							num2 = 33;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
							{
								num2 = 110;
							}
							continue;
							IL_0b66:
							num2 = 108;
							continue;
							IL_0ad9:
							text = Y60fQNaBNSu(body);
							num2 = 60;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 != 0)
							{
								num2 = 29;
							}
							continue;
							IL_0ac7:
							text = A22fQThLOpc(body);
							num2 = 46;
							continue;
							IL_0598:
							text = "empty";
							num2 = 73;
							continue;
						}
						break;
					}
					goto IL_0460;
					IL_0e70:
					if (packetId > 143)
					{
						num2 = 51;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
						{
							num2 = 61;
						}
						goto IL_006d;
					}
					goto IL_08a7;
					IL_0069:
					num2 = num4;
					goto IL_006d;
					IL_0ddc:
					num3 = 60;
					goto IL_0065;
					IL_08d9:
					num3 = 62;
					goto IL_0065;
					IL_041d:
					num3 = 105;
					goto IL_0065;
					IL_08a7:
					if (packetId > 121)
					{
						num2 = 97;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
						{
							num2 = 50;
						}
						goto IL_006d;
					}
					goto IL_05bf;
					IL_0711:
					num3 = 64;
					goto IL_0065;
					IL_0489:
					num3 = 118;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 != 0)
					{
						num3 = 135;
					}
					goto IL_0065;
					IL_0550:
					text = TQQfJ2ERTKa(body);
					num3 = 38;
					goto IL_0065;
					IL_05bf:
					if (packetId != 111)
					{
						num3 = 21;
						goto IL_0065;
					}
					goto IL_0460;
					IL_0b2e:
					num3 = 86;
					goto IL_0065;
					IL_0065:
					num4 = num3;
					goto IL_0069;
					IL_0460:
					text = lMMfQWeMb9v(body);
					num2 = 8;
					goto IL_006d;
					end_IL_0034:;
				}
				catch (global::System.Exception ex)
				{
					int num5 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							if (num6 == 990)
							{
								num5 = num6;
								continue;
							}
							break;
						case 2:
							result = string.Concat("[parse error: ", (ex).Message, "]");
							num5 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
							{
								num5 = 8;
							}
							continue;
						case 1:
							break;
						case 0:
							goto end_IL_0fb9;
						}
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "caught-exception", "ParsePacketDetails", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Bedrock\\Relay\\Protocol\\BedrockMitmSession.cs", 3055);
						num5 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
						{
							num5 = 2;
						}
						continue;
						end_IL_0fb9:
						break;
					}
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string TQQfJ2ERTKa(object body)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		uint value = default(uint);
		defaultInterpolatedStringHandler.AppendFormatted<int>(bwxfQmLsRN6(value));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string t3UfJqKQVrR(object body)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		(defaultInterpolatedStringHandler).AppendLiteral(" action=");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string rfnfJGx4gkS(object body)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		float x = default(float);
		float y = default(float);
		float z = default(float);
		(defaultInterpolatedStringHandler).AppendFormatted(dSafQdA8vHL(x, y, z));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string vhPfJi3Wfpv(object body)
	{
		int num2 = default(int);
		int num = System.Buffers.Binary.BinaryPrimitives.ReadInt32LittleEndian(((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>((byte[])body, num2, 4)));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string Ll8fJntLSa0(object body)
	{
		int num2 = default(int);
		int num = System.Buffers.Binary.BinaryPrimitives.ReadInt32LittleEndian(((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>((byte[])body, num2, 4)));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string S5ofJzZRMvK(object body)
	{
		int num = default(int);
		string text = System.Convert.ToHexString(((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>((byte[])body, num)));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string m8nfQbQ5Ffj(object body)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		ulong value = default(ulong);
		defaultInterpolatedStringHandler.AppendFormatted<long>(ddTfQ7VkHsR(value));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string chcfQXBClju(object body)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		ulong value = default(ulong);
		defaultInterpolatedStringHandler.AppendFormatted<long>(ddTfQ7VkHsR(value));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string H0efQfiWEKL(object body)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		float x = default(float);
		float y = default(float);
		float z = default(float);
		(defaultInterpolatedStringHandler).AppendFormatted(dSafQdA8vHL(x, y, z));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string mU3fQLVDL6p(object body)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		float x = default(float);
		float y = default(float);
		float z = default(float);
		(defaultInterpolatedStringHandler).AppendFormatted(dSafQdA8vHL(x, y, z));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string UYNfQjDv7f8(object body)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		uint num = default(uint);
		defaultInterpolatedStringHandler.AppendFormatted<uint>(num, "X");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string C8LfQZAbiGa(object body)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		uint value = default(uint);
		defaultInterpolatedStringHandler.AppendFormatted<int>(bwxfQmLsRN6(value));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string snvfQ9lWuc1(object body, object countName)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		(defaultInterpolatedStringHandler).AppendLiteral("runtimeId=");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string SMFfQDSF7ta(object body)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		(defaultInterpolatedStringHandler).AppendLiteral("action=");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string xbUfQkEfDXL(object body)
	{
		int num = 2;
		int p = default(int);
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		int num5 = default(int);
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		uint value5 = default(uint);
		bool flag = default(bool);
		uint value2 = default(uint);
		string result = default(string);
		uint num7 = default(uint);
		List<string> val = default(List<string>);
		uint value4 = default(uint);
		uint num6 = default(uint);
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0021;
				case 2:
					p = 0;
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
					{
						num2 = 1;
					}
					continue;
				case 0:
					break;
				case 1:
					try
					{
						int num3;
						if (!UEnfQrlbeeq(((global::System.ReadOnlySpan<byte>)(byte[])body), ref p, out var value))
						{
							num3 = 50;
							goto IL_008a;
						}
						goto IL_04b0;
						IL_07d5:
						defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(21, 2);
						num3 = 28;
						goto IL_008a;
						IL_008a:
						while (true)
						{
							uint value3;
							int num4;
							switch (num3)
							{
							default:
								if (num5 != 61)
								{
									if (num5 == 1041)
									{
										goto IL_0086;
									}
									goto case 14;
								}
								goto case 7;
							case 43:
								defaultInterpolatedStringHandler2.AppendFormatted<uint>(value5);
								num3 = 12;
								continue;
							case 41:
								(defaultInterpolatedStringHandler2).AppendLiteral("/");
								num3 = 9;
								continue;
							case 36:
							case 42:
								if (flag)
								{
									num3 = 39;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto case 24;
							case 10:
								flag = true;
								num3 = 36;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
								{
									num3 = 1;
								}
								continue;
							case 33:
								if (!UEnfQrlbeeq(((global::System.ReadOnlySpan<byte>)(byte[])body), ref p, out value2))
								{
									num3 = 17;
									continue;
								}
								goto case 53;
							case 52:
								result = (defaultInterpolatedStringHandler2).ToStringAndClear();
								num3 = 8;
								continue;
							case 20:
								num7 = 0u;
								num3 = 51;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 != 0)
								{
									num3 = 43;
								}
								continue;
							case 14:
								flag = true;
								num3 = 40;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
								{
									num3 = 38;
								}
								continue;
							case 21:
								if (!UEnfQrlbeeq(((global::System.ReadOnlySpan<byte>)(byte[])body), ref p, out value3))
								{
									num4 = 21;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
									{
										num4 = 61;
									}
									goto IL_0082;
								}
								goto case 6;
							case 6:
							case 26:
								if (value2 != 100)
								{
									num4 = 49;
									goto IL_0082;
								}
								goto case 10;
							case 1:
								(defaultInterpolatedStringHandler2).AppendLiteral(" sources=[");
								num3 = 13;
								continue;
							case 9:
								defaultInterpolatedStringHandler2.AppendFormatted<int>(((global::System.Array)body).Length);
								num3 = 52;
								continue;
							case 34:
								(defaultInterpolatedStringHandler2).AppendLiteral("] parseOffset=");
								num3 = 23;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
								{
									num3 = 0;
								}
								continue;
							case 24:
								if (!UEnfQrlbeeq(((global::System.ReadOnlySpan<byte>)(byte[])body), ref p, out value3))
								{
									num3 = 27;
									continue;
								}
								goto case 2;
							case 44:
								(defaultInterpolatedStringHandler2).AppendLiteral("legacyRequestId=");
								num3 = 32;
								continue;
							case 53:
								val.Add((value2).ToString((IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture));
								num3 = 19;
								continue;
							case 12:
								(defaultInterpolatedStringHandler2).AppendLiteral(" actions=");
								num3 = 29;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
								{
									num3 = 13;
								}
								continue;
							case 11:
								result = (defaultInterpolatedStringHandler).ToStringAndClear();
								num3 = 15;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
								{
									num3 = 20;
								}
								continue;
							case 35:
								break;
							case 32:
								defaultInterpolatedStringHandler2.AppendFormatted<int>(bwxfQmLsRN6(value));
								num3 = 30;
								continue;
							case 13:
								(defaultInterpolatedStringHandler2).AppendFormatted(string.Join(",", (global::System.Collections.Generic.IEnumerable<string>)val));
								num3 = 32;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
								{
									num3 = 34;
								}
								continue;
							case 37:
							case 48:
								val = new List<string>(System.Math.Min((int)value4, 8));
								num3 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
								{
									num3 = 2;
								}
								continue;
							case 47:
								if (value2 != 100)
								{
									num4 = 18;
									goto IL_0082;
								}
								goto case 14;
							case 45:
								defaultInterpolatedStringHandler.AppendFormatted<int>(((global::System.Array)body).Length);
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
								{
									num3 = 29;
								}
								continue;
							case 29:
								defaultInterpolatedStringHandler2.AppendFormatted<uint>(value4);
								num3 = 60;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
								{
									num3 = 1;
								}
								continue;
							case 0:
								(defaultInterpolatedStringHandler).AppendLiteral(" parseOffset=");
								num3 = 16;
								continue;
							case 19:
								if (value2 != 0)
								{
									num3 = 47;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
									{
										num3 = 25;
									}
									continue;
								}
								goto case 14;
							case 2:
								num7++;
								num3 = 38;
								continue;
							case 16:
								defaultInterpolatedStringHandler.AppendFormatted<int>(p);
								num3 = 37;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
								{
									num3 = 11;
								}
								continue;
							case 31:
								flag = false;
								num3 = 42;
								continue;
							case 5:
								flag = false;
								num3 = 22;
								continue;
							case 38:
							case 51:
								if (num7 >= num6)
								{
									num3 = 56;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
									{
										num3 = 25;
									}
									continue;
								}
								goto case 33;
							case 28:
								(defaultInterpolatedStringHandler).AppendLiteral("bodyLen=");
								num4 = 45;
								goto IL_0082;
							case 7:
							case 17:
							case 25:
							case 27:
								defaultInterpolatedStringHandler2 = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(56, 6);
								num3 = 44;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
								{
									num3 = 23;
								}
								continue;
							case 22:
							case 40:
								if (!flag)
								{
									num3 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
									{
										num3 = 47;
									}
									continue;
								}
								goto case 21;
							case 3:
								if (UEnfQrlbeeq(((global::System.ReadOnlySpan<byte>)(byte[])body), ref p, out value4))
								{
									num3 = 35;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
									{
										num3 = 48;
									}
									continue;
								}
								goto IL_07d5;
							case 46:
							case 50:
								goto IL_07d5;
							case 30:
								(defaultInterpolatedStringHandler2).AppendLiteral(" type=");
								num3 = 43;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
								{
									num3 = 28;
								}
								continue;
							case 15:
								goto end_IL_005a;
							case 4:
								num6 = System.Math.Min(value4, 8u);
								num3 = 20;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
								{
									num3 = 36;
								}
								continue;
							case 18:
								if (value2 == 99999)
								{
									num3 = 14;
									continue;
								}
								goto case 5;
							case 23:
								defaultInterpolatedStringHandler2.AppendFormatted<int>(p);
								num3 = 41;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
								{
									num3 = 41;
								}
								continue;
							case 39:
								if (!UEnfQrlbeeq(((global::System.ReadOnlySpan<byte>)(byte[])body), ref p, out value3))
								{
									num3 = 7;
									continue;
								}
								goto case 24;
							case 49:
								if (value2 == 99999)
								{
									num4 = 10;
									goto IL_0082;
								}
								goto case 31;
							case 8:
								goto end_IL_005a;
								IL_0086:
								num3 = num5;
								continue;
								IL_0082:
								num5 = num4;
								goto IL_0086;
							}
							break;
						}
						goto IL_04b0;
						IL_04b0:
						if (UEnfQrlbeeq(((global::System.ReadOnlySpan<byte>)(byte[])body), ref p, out value5))
						{
							num3 = 3;
							goto IL_008a;
						}
						goto IL_07d5;
						end_IL_005a:;
					}
					catch
					{
						int num8 = 3;
						while (true)
						{
							IL_091c:
							int num9 = num8;
							while (true)
							{
								IL_0920:
								int num10 = num9;
								while (true)
								{
									switch (num10)
									{
									case 2:
										defaultInterpolatedStringHandler3.AppendFormatted<int>(((global::System.Array)body).Length);
										num10 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
										{
											num10 = 0;
										}
										continue;
									case 1:
										goto end_IL_0924;
									case 0:
										(defaultInterpolatedStringHandler3).AppendLiteral(" parseOffset=");
										num10 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
										{
											num10 = 13;
										}
										continue;
									case 5:
										(defaultInterpolatedStringHandler3).AppendLiteral("bodyLen=");
										num10 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
										{
											num10 = 3;
										}
										continue;
									case 3:
										defaultInterpolatedStringHandler3 = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(21, 2);
										num10 = 5;
										continue;
									case 4:
										goto end_IL_0920;
									}
									switch (num9)
									{
									case 993:
										break;
									default:
										goto end_IL_0920;
									case 13:
										result = (defaultInterpolatedStringHandler3).ToStringAndClear();
										num10 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
										{
											num10 = 9;
										}
										continue;
									}
									goto IL_0920;
									continue;
									end_IL_0924:
									break;
								}
								defaultInterpolatedStringHandler3.AppendFormatted<int>(p);
								num8 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
								{
									num8 = 13;
								}
								goto IL_091c;
								continue;
								end_IL_0920:
								break;
							}
							break;
						}
					}
					break;
				}
				goto IL_0056;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_0056;
				IL_0056:
				return result;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string TNMfQVg1jYI(object body)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		(defaultInterpolatedStringHandler).AppendLiteral("runtimeId=");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string BAYfQYhPiNv(object body)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		float x = default(float);
		float y = default(float);
		float z = default(float);
		(defaultInterpolatedStringHandler).AppendFormatted(dSafQdA8vHL(x, y, z));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string yndfQSp7Csc(object body)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		(defaultInterpolatedStringHandler).AppendLiteral(") dim=");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string ztkfQcS5apx(object body)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		uint value = default(uint);
		defaultInterpolatedStringHandler.AppendFormatted<int>(bwxfQmLsRN6(value));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string cbCfQ0tRZc4(object body)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		uint value = default(uint);
		defaultInterpolatedStringHandler.AppendFormatted<int>(bwxfQmLsRN6(value));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string UGZfQ8NJdrJ(object body)
	{
		float value = default(float);
		float value2 = default(float);
		string text = string.Concat(" volume=", GmxfQgR2HYg(value), " pitch=", GmxfQgR2HYg(value2));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string PqhfQy50XIL(object body)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		string text = default(string);
		(defaultInterpolatedStringHandler).AppendFormatted(McSfC4N0cF6(UQ2fQPkKkil(text ?? string.Empty), 96));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string lMMfQWeMb9v(object body)
	{
		int num2 = default(int);
		ushort num = System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>((byte[])body, num2, 2)));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string nBGfQJOlXm5(object body)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		(defaultInterpolatedStringHandler).AppendLiteral("runtimeId=");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string VvufQQpZCK5(object body)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		(defaultInterpolatedStringHandler).AppendLiteral(") radiusBlocks=");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string hBcfQC0R6yp(object body)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		(defaultInterpolatedStringHandler).AppendLiteral("enabled=");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string Sj9fQ40sLVE(object body)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		(defaultInterpolatedStringHandler).AppendLiteral("misses=");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string k2ofQhSxMO1(object body)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		float value = default(float);
		(defaultInterpolatedStringHandler).AppendFormatted(GmxfQgR2HYg(value));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string JV3fQUtFp5L(object body)
	{
		float x = default(float);
		float y = default(float);
		float z = default(float);
		string text = string.Concat(" pos=", dSafQdA8vHL(x, y, z));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool UEnfQrlbeeq(global::System.ReadOnlySpan<byte> data, ref int p, out uint value)
	{
		value = default(uint);
		int num = 0;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool sqXfQoKMDsD(global::System.ReadOnlySpan<byte> data, ref int p, out ulong value)
	{
		value = default(ulong);
		int num = 0;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int bwxfQmLsRN6(uint value)
	{
		return (int)((value >> 1) ^ (0 - (value & 1)));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static long ddTfQ7VkHsR(ulong value)
	{
		return (long)((value >> 1) ^ (0 - (value & 1)));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool EGgfQAIKWK9(global::System.ReadOnlySpan<byte> data, ref int p, out float value)
	{
		value = default(float);
		int num = 2;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool DLbfQIXwIsO(global::System.ReadOnlySpan<byte> data, ref int p, out float x, out float y, out float z)
	{
		x = default(float);
		y = default(float);
		z = default(float);
		int num = 1;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool pNTfQBlVp7j(global::System.ReadOnlySpan<byte> data, ref int p, out int x, out uint y, out int z)
	{
		x = default(int);
		y = default(uint);
		z = default(int);
		int num = 5;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string GmxfQgR2HYg(float value)
	{
		return (value).ToString("0.###", (IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string aiqfQlgh5DL(float? value)
	{
		int num = 1;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string dSafQdA8vHL(float x, float y, float z)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		(defaultInterpolatedStringHandler).AppendFormatted(GmxfQgR2HYg(z));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string KgafQKiGN43(object body)
	{
		List<string> val = default(List<string>);
		string text = string.Concat(" path=\"", McSfC4N0cF6(UQ2fQPkKkil(string.Join(" / ", (global::System.Collections.Generic.IEnumerable<string>)val)), 220), "\"");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool KkofQH4TSpm(global::System.ReadOnlySpan<byte> data, ref int p, List<string> strings, int depth, int maxStrings)
	{
		int num = 4;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool jlOfQtggNH2(global::System.ReadOnlySpan<byte> data, ref int p, List<string> strings, int depth, int maxStrings, int count)
	{
		int num = 0;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool YgFfQOR9gnV(global::System.ReadOnlySpan<byte> data, ref int p, int length, List<string> strings, int maxStrings)
	{
		//IL_0014: Expected I4, but got F4
		string text = (System.Text.Encoding.UTF8).GetString(data.Slice((int)global::System.Runtime.CompilerServices.Unsafe.As<int, float>(ref p), length));
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool GDyfQ5IcHVs(global::System.ReadOnlySpan<byte> data, ref int p, int bytes, out int length)
	{
		length = default(int);
		//IL_0009: Expected I4, but got F4
		uint num = System.Buffers.Binary.BinaryPrimitives.ReadUInt16BigEndian(data.Slice((int)global::System.Runtime.CompilerServices.Unsafe.As<int, float>(ref p)));
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool ugPfQ6PJomc(global::System.ReadOnlySpan<byte> data, ref int p, int bytes)
	{
		int num = 1;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string UdvfQRbFTgF(object body)
	{
		int num = 0;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string DTRfQwBdf5Q(string? value)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Invalid comparison between Unknown and I4
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		int num4 = default(int);
		int num7 = default(int);
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		global::System.Collections.Generic.IEnumerable<string> enumerable = default(global::System.Collections.Generic.IEnumerable<string>);
		string result = default(string);
		int num9 = default(int);
		int num11 = default(int);
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0025;
				case 0:
					try
					{
						JsonDocument val = System.Text.Json.JsonDocument.Parse(value, default(JsonDocumentOptions));
						int num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
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
									goto IL_007d;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_007d:
							num3 = num4;
						}
						try
						{
							JsonElement val2 = (val).RootElement;
							int num5 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
							{
								num5 = 17;
							}
							while (true)
							{
								int num6;
								switch (num5)
								{
								default:
									if (num7 != 22)
									{
										if (num7 == 1002)
										{
											goto IL_00d9;
										}
										goto case 2;
									}
									(defaultInterpolatedStringHandler).AppendLiteral("] chars=");
									num5 = 5;
									continue;
								case 13:
									defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(16, 2);
									num5 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 != 0)
									{
										num5 = 7;
									}
									continue;
								case 4:
									defaultInterpolatedStringHandler2.AppendFormatted<int>((value).Length);
									num6 = 11;
									goto IL_00d5;
								case 10:
									(defaultInterpolatedStringHandler).AppendFormatted(string.Join<string>(',', enumerable));
									num6 = 22;
									goto IL_00d5;
								case 9:
									defaultInterpolatedStringHandler2 = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(12, 2);
									num5 = 12;
									continue;
								case 2:
									(defaultInterpolatedStringHandler2).AppendLiteral(" chars=");
									num6 = 4;
									goto IL_00d5;
								case 3:
									(defaultInterpolatedStringHandler).AppendLiteral("fields=[");
									num5 = 10;
									continue;
								case 0:
									if ((int)(val2).ValueKind == 1)
									{
										num5 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
										{
											num5 = 1;
										}
										continue;
									}
									goto case 9;
								case 12:
									(defaultInterpolatedStringHandler2).AppendLiteral("kind=");
									num5 = 14;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
									{
										num5 = 9;
									}
									continue;
								case 11:
									result = (defaultInterpolatedStringHandler2).ToStringAndClear();
									num5 = 6;
									continue;
								case 8:
									result = (defaultInterpolatedStringHandler).ToStringAndClear();
									num5 = 7;
									continue;
								case 7:
									break;
								case 5:
									defaultInterpolatedStringHandler.AppendFormatted<int>((value).Length);
									num5 = 14;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 != 0)
									{
										num5 = 8;
									}
									continue;
								case 14:
									defaultInterpolatedStringHandler2.AppendFormatted<JsonValueKind>((val2).ValueKind);
									num5 = 2;
									continue;
								case 1:
									enumerable = Enumerable.Take<string>(Enumerable.Select<JsonProperty, string>((global::System.Collections.Generic.IEnumerable<JsonProperty>)(object)val2.EnumerateObject(), (Func<JsonProperty, string>)([MethodImpl((MethodImplOptions)8)] (JsonProperty property) => (property).Name)), 32);
									num5 = 13;
									continue;
								case 6:
									break;
									IL_00d5:
									num7 = num6;
									goto IL_00d9;
									IL_00d9:
									num5 = num7;
									continue;
								}
								break;
							}
						}
						finally
						{
							int num8;
							if (val == null)
							{
								num8 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
								{
									num8 = 1;
								}
								goto IL_03e4;
							}
							goto IL_0408;
							IL_03e4:
							while (true)
							{
								switch (num8)
								{
								default:
									if (num9 == 990)
									{
										goto IL_03e0;
									}
									break;
								case 0:
									break;
								case 2:
									goto end_IL_03e4;
								case 1:
									goto end_IL_03e4;
								}
								goto IL_0408;
								IL_03e0:
								num8 = num9;
								continue;
								end_IL_03e4:
								break;
							}
							goto end_IL_03ac;
							IL_0408:
							(val).Dispose();
							num8 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
							{
								num8 = 6;
							}
							goto IL_03e4;
							end_IL_03ac:;
						}
					}
					catch (JsonException)
					{
						int num10 = 6;
						while (true)
						{
							int num12;
							switch (num10)
							{
							default:
								if (num11 != 14)
								{
									if (num11 == 994)
									{
										goto IL_0471;
									}
									goto case 3;
								}
								(defaultInterpolatedStringHandler3).AppendLiteral(" sha256=");
								num10 = 4;
								continue;
							case 0:
								defaultInterpolatedStringHandler3.AppendFormatted<int>((value).Length);
								num12 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
								{
									num12 = 14;
								}
								goto IL_046d;
							case 4:
								(defaultInterpolatedStringHandler3).AppendFormatted((text).Substring(0, 16));
								num10 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
								{
									num10 = 1;
								}
								continue;
							case 1:
								result = (defaultInterpolatedStringHandler3).ToStringAndClear();
								num12 = 2;
								goto IL_046d;
							case 5:
								defaultInterpolatedStringHandler3 = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(24, 2);
								num10 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
								{
									num10 = 3;
								}
								continue;
							case 3:
								(defaultInterpolatedStringHandler3).AppendLiteral("[invalid] chars=");
								num10 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 != 0)
								{
									num10 = 10;
								}
								continue;
							case 6:
								text = System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData((System.Text.Encoding.UTF8).GetBytes(value)));
								num10 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
								{
									num10 = 2;
								}
								continue;
							case 2:
								break;
								IL_046d:
								num11 = num12;
								goto IL_0471;
								IL_0471:
								num10 = num11;
								continue;
							}
							break;
						}
					}
					goto case 3;
				case 1:
					return "[empty]";
				case 3:
					return result;
				case 2:
					break;
				}
				goto IL_068d;
				IL_0025:
				if (num == 991)
				{
					break;
				}
				goto IL_068d;
				IL_068d:
				if (!string.IsNullOrWhiteSpace(value))
				{
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 != 0)
					{
						num2 = 7;
					}
				}
				else
				{
					num2 = 4;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
					{
						num2 = 1;
					}
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string NmYfQewAWYt(object body)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		(defaultInterpolatedStringHandler).AppendLiteral(" bodyLen=");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string UQ2fQPkKkil(object value)
	{
		return ((((dynamic)(value)).Replace("\r", "\\r")).Replace("\n", "\\n")).Replace("\t", "\\t");
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string tYWfQxeToxK(object body)
	{
		int pos = default(int);
		int num = Xk4pP4fWwOTHm3UjNabK.ngmfWuvY3PV(((global::System.ReadOnlySpan<byte>)(byte[])body), ref pos);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string oPlfQFwT5Cy(object body)
	{
		int pos = default(int);
		ushort num = Xk4pP4fWwOTHm3UjNabK.IurfWpXOSKP(((global::System.ReadOnlySpan<byte>)(byte[])body), ref pos);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string ns0fQs6n1EA(object body)
	{
		int num = 2;
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		int num4 = default(int);
		JsonObject root = default(JsonObject);
		int? num10 = default(int?);
		int num11 = default(int);
		int num5 = default(int);
		int num14 = default(int);
		int pos2 = default(int);
		int num6 = default(int);
		int byteLength = default(int);
		int authJsonByteLength = default(int);
		int pos = default(int);
		int payloadOffset = default(int);
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		string chainJson = default(string);
		uint num7 = default(uint);
		JsonArray chain = default(JsonArray);
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
						if (num2 != 47)
						{
							if (num2 == 1028)
							{
								goto end_IL_0010;
							}
							goto case 12;
						}
						return (defaultInterpolatedStringHandler).ToStringAndClear();
					case 0:
						defaultInterpolatedStringHandler2.AppendFormatted<int>(num4);
						num3 = 41;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
						{
							num3 = 35;
						}
						continue;
					case 39:
						try
						{
							int num8;
							int? num9;
							if (root == null)
							{
								num8 = 12;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
								{
									num8 = 6;
								}
							}
							else
							{
								JsonNode obj = ((dynamic)(root)).Item;
								if (obj == null)
								{
									num8 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
									{
										num8 = 14;
									}
								}
								else
								{
									string value2 = obj.GetValue<string>();
									if (value2 != null)
									{
										num9 = (value2).Length;
										goto IL_02ac;
									}
									num8 = 9;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
									{
										num8 = 4;
									}
								}
							}
							goto IL_013b;
							IL_02ac:
							num10 = num9;
							num8 = 2;
							goto IL_013b;
							IL_013b:
							while (true)
							{
								switch (num8)
								{
								default:
									if (num11 != 14)
									{
										if (num11 == 994)
										{
											goto IL_0137;
										}
										goto case 0;
									}
									num9 = num10;
									break;
								case 4:
								{
									num10 = null;
									int num12 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
									{
										num12 = 14;
									}
									num11 = num12;
									goto IL_0137;
								}
								case 6:
									num10 = null;
									num8 = 1;
									continue;
								case 0:
									num10 = null;
									num8 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
									{
										num8 = 10;
									}
									continue;
								case 1:
									num9 = num10;
									break;
								case 2:
									num5 = num10.GetValueOrDefault();
									num8 = 8;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 != 0)
									{
										num8 = 5;
									}
									continue;
								case 3:
									num9 = num10;
									break;
								case 5:
									goto end_IL_013b;
									IL_0137:
									num8 = num11;
									continue;
								}
								goto IL_02ac;
								continue;
								end_IL_013b:
								break;
							}
						}
						catch
						{
							int num13 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
							{
								num13 = 0;
							}
							while (true)
							{
								switch (num13)
								{
								default:
									if (num14 == 989)
									{
										num13 = num14;
										continue;
									}
									break;
								case 0:
									break;
								case 1:
									goto end_IL_02ef;
								}
								num5 = -1;
								num13 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
								{
									num13 = 5;
								}
								continue;
								end_IL_02ef:
								break;
							}
						}
						goto case 28;
					case 2:
						if (((global::System.Array)body).Length < 5)
						{
							num3 = 20;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e != 0)
							{
								num3 = 1;
							}
						}
						else
						{
							pos2 = 0;
							num3 = 5;
						}
						continue;
					case 7:
						num5 = 0;
						num3 = 39;
						continue;
					case 8:
						num6 = byteLength - authJsonByteLength;
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
						{
							num3 = 42;
						}
						continue;
					case 32:
					{
						if (!KxtfJpOENwj(body, ref pos, out string _, out int _, out payloadOffset, out byteLength))
						{
							num3 = 31;
							continue;
						}
						goto case 19;
					}
					case 12:
						defaultInterpolatedStringHandler4.AppendFormatted<int>(num4);
						num3 = 34;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
						{
							num3 = 18;
						}
						continue;
					case 16:
						defaultInterpolatedStringHandler2 = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(17, 2);
						num3 = 29;
						continue;
					case 13:
						defaultInterpolatedStringHandler3.AppendFormatted<int>(authJsonByteLength);
						num3 = 21;
						continue;
					case 6:
						defaultInterpolatedStringHandler3.AppendFormatted<int>(num4);
						num3 = 10;
						continue;
					case 40:
						(defaultInterpolatedStringHandler).AppendLiteral(" [chain unreadable]");
						num = 47;
						break;
					case 38:
						return (defaultInterpolatedStringHandler4).ToStringAndClear();
					case 33:
						pos = pos2;
						num3 = 32;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
						{
							num3 = 38;
						}
						continue;
					case 22:
						chainJson = (System.Text.Encoding.UTF8).GetString((byte[])body, pos2, (int)num7);
						num3 = 16;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
						{
							num3 = 40;
						}
						continue;
					case 37:
						pos2 = 4;
						num3 = 18;
						continue;
					case 18:
						num7 = Xk4pP4fWwOTHm3UjNabK.H8lfWMJJwUX(((global::System.ReadOnlySpan<byte>)(byte[])body), ref pos2);
						num = 4;
						break;
					case 15:
						(defaultInterpolatedStringHandler4).AppendLiteral("protocolVersion=");
						num3 = 27;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
						{
							num3 = 12;
						}
						continue;
					case 1:
						return string.Empty;
					case 20:
						(defaultInterpolatedStringHandler3).AppendLiteral(" clientDataLen=");
						num3 = 17;
						continue;
					case 14:
						return (defaultInterpolatedStringHandler2).ToStringAndClear();
					case 29:
						(defaultInterpolatedStringHandler2).AppendLiteral("protocolVersion=");
						num3 = 32;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
						{
							num3 = 0;
						}
						continue;
					case 30:
						(defaultInterpolatedStringHandler3).AppendLiteral("protocolVersion=");
						num3 = 6;
						continue;
					case 23:
						if (pos2 + num7 <= ((global::System.Array)body).Length)
						{
							num = 22;
							break;
						}
						goto IL_05fe;
					case 11:
						return (defaultInterpolatedStringHandler3).ToStringAndClear();
					case 3:
					case 31:
						if (((global::System.Array)body).Length < 8)
						{
							defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(35, 1);
							num3 = 24;
						}
						else
						{
							num3 = 37;
						}
						continue;
					case 36:
						defaultInterpolatedStringHandler.AppendFormatted<int>(num4);
						num3 = 40;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
						{
							num3 = 15;
						}
						continue;
					case 4:
						if (num7 != 0)
						{
							num = 23;
							break;
						}
						goto IL_05fe;
					case 35:
						(defaultInterpolatedStringHandler2).AppendLiteral(" ");
						num3 = 26;
						continue;
					case 19:
					{
						if (!DiJfJNFrruj((byte[])body, payloadOffset, byteLength, out root, out chain, out JsonObject _, out authJsonByteLength))
						{
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e != 0)
							{
								num3 = 6;
							}
							continue;
						}
						goto case 8;
					}
					case 17:
						defaultInterpolatedStringHandler3.AppendFormatted<int>(num6);
						num3 = 27;
						continue;
					case 9:
						defaultInterpolatedStringHandler3.AppendFormatted<int>(num5);
						num3 = 20;
						continue;
					case 26:
						(defaultInterpolatedStringHandler2).AppendFormatted(fvtfQpqFnnA(chainJson));
						num3 = 14;
						continue;
					case 10:
						(defaultInterpolatedStringHandler3).AppendLiteral(" format=NetEaseConnectionRequest authJsonLen=");
						num3 = 13;
						continue;
					case 5:
						num4 = Xk4pP4fWwOTHm3UjNabK.ngmfWuvY3PV(((global::System.ReadOnlySpan<byte>)(byte[])body), ref pos2);
						num3 = 33;
						continue;
					case 25:
						(defaultInterpolatedStringHandler3).AppendFormatted(diyfQu3ohVs(chain));
						num3 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
						{
							num3 = 38;
						}
						continue;
					case 21:
						(defaultInterpolatedStringHandler3).AppendLiteral(" tokenLen=");
						num3 = 9;
						continue;
					case 28:
						defaultInterpolatedStringHandler3 = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(87, 5);
						num3 = 30;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
						{
							num3 = 21;
						}
						continue;
					case 34:
						(defaultInterpolatedStringHandler4).AppendLiteral(" [chain unreadable]");
						num3 = 38;
						continue;
					case 27:
						(defaultInterpolatedStringHandler3).AppendLiteral(" ");
						num3 = 25;
						continue;
					case 24:
						{
							(defaultInterpolatedStringHandler).AppendLiteral("protocolVersion=");
							num3 = 36;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
							{
								num3 = 16;
							}
							continue;
						}
						IL_05fe:
						defaultInterpolatedStringHandler4 = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(35, 1);
						num3 = 15;
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
	private static string A22fQThLOpc(object body)
	{
		int pos = default(int);
		int num = Xk4pP4fWwOTHm3UjNabK.ngmfWuvY3PV(((global::System.ReadOnlySpan<byte>)(byte[])body), ref pos);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string Y60fQNaBNSu(object body)
	{
		int pos = default(int);
		uint num = Xk4pP4fWwOTHm3UjNabK.q4xfWFFivJy(body, ref pos);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string OHGfQMcQQYY(object body)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		string text = default(string);
		(defaultInterpolatedStringHandler).AppendFormatted(UQ2fQPkKkil(text ?? string.Empty));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string fvtfQpqFnnA(object chainJson)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		string result = default(string);
		int num3 = default(int);
		JsonArray chain = default(JsonArray);
		int num5 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					JsonNode obj = System.Text.Json.Nodes.JsonNode.Parse((string)chainJson, null, default(JsonDocumentOptions));
					int num2;
					if (obj == null)
					{
						num2 = 3;
						goto IL_0078;
					}
					object root = (obj).AsObject();
					goto IL_0132;
					IL_0122:
					root = null;
					goto IL_0132;
					IL_0078:
					while (true)
					{
						switch (num2)
						{
						case 0:
							result = "[no chain]";
							num2 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
							{
								num2 = 1;
							}
							continue;
						case 2:
							goto IL_00eb;
						case 1:
							goto end_IL_0031;
						case 3:
							goto IL_0122;
						}
						break;
					}
					if (num3 != 11)
					{
						if (num3 == 991)
						{
							goto IL_0074;
						}
						goto IL_0122;
					}
					goto end_IL_0031;
					IL_0132:
					if (!z9tfJMTAm7a(root, out chain, out JsonObject _))
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
						{
							num2 = 6;
						}
						goto IL_0078;
					}
					goto IL_00eb;
					IL_0074:
					num2 = num3;
					goto IL_0078;
					IL_00eb:
					result = diyfQu3ohVs(chain);
					num3 = 11;
					goto IL_0074;
					end_IL_0031:;
				}
				catch
				{
					int num4 = 4;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							if (num5 == 989)
							{
								num4 = num5;
								continue;
							}
							break;
						case 0:
							break;
						case 1:
							goto end_IL_0196;
						}
						result = "[chain parse error]";
						num4 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 != 0)
						{
							num4 = 1;
						}
						continue;
						end_IL_0196:
						break;
					}
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string diyfQu3ohVs(object chain)
	{
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num3 = default(int);
		string[] array = default(string[]);
		int num10 = default(int);
		string text7 = default(string);
		JsonDocument val2 = default(JsonDocument);
		int num6 = default(int);
		string result = default(string);
		string value = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string value2 = default(string);
		JsonElement val3 = default(JsonElement);
		JsonElement val4 = default(JsonElement);
		JsonElement val5 = default(JsonElement);
		JsonElement val7 = default(JsonElement);
		JsonElement val6 = default(JsonElement);
		int num9 = default(int);
		int num12 = default(int);
		int num14 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					global::System.Collections.Generic.IEnumerator<JsonNode> enumerator = ((dynamic)(chain)).GetEnumerator();
					int num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
					{
						num2 = 1;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							if (num3 == 990)
							{
								num2 = num3;
								continue;
							}
							goto case 1;
						case 0:
							break;
						case 1:
							try
							{
								while (true)
								{
									IL_071e:
									int num4;
									if (!(enumerator).MoveNext())
									{
										num4 = 2;
										goto IL_00f7;
									}
									goto IL_0145;
									IL_07a3:
									object obj = string.Empty;
									goto IL_07a8;
									IL_0145:
									JsonNode current = enumerator.Current;
									if (current == null)
									{
										num4 = 6;
										goto IL_00f7;
									}
									obj = current.GetValue<string>();
									goto IL_077d;
									IL_07a8:
									array = ((dynamic)(obj)).Split('.', (StringSplitOptions)0);
									num4 = 9;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
									{
										num4 = 13;
									}
									goto IL_00f7;
									IL_0772:
									obj = null;
									goto IL_077d;
									IL_077d:
									if (obj == null)
									{
										num4 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 != 0)
										{
											num4 = 8;
										}
										goto IL_00f7;
									}
									goto IL_07a8;
									IL_00f7:
									while (true)
									{
										switch (num4)
										{
										default:
											switch (num10)
											{
											case 997:
												break;
											default:
												goto end_IL_071e;
											case 17:
												text7 = FvRfCV2yXRK(array[1]);
												num4 = 3;
												continue;
											}
											goto IL_00f3;
										case 1:
											break;
										case 9:
											if (array.Length < 2)
											{
												goto IL_071e;
											}
											num10 = 17;
											goto IL_00f3;
										case 3:
											if (text7 == null)
											{
												num4 = 5;
												continue;
											}
											goto case 0;
										case 0:
											val2 = System.Text.Json.JsonDocument.Parse(text7, default(JsonDocumentOptions));
											num4 = 7;
											continue;
										case 7:
											try
											{
												JsonElement val = (val2).RootElement;
												int num5 = 15;
												while (true)
												{
													string text5;
													string text6;
													string text;
													string text2;
													int num7;
													switch (num5)
													{
													default:
														if (num6 != 25)
														{
															if (num6 == 1005)
															{
																goto IL_01cb;
															}
															goto case 4;
														}
														result = string.Concat(new string[6]
														{
															string.Empty,
															string.Empty,
															string.Empty,
															string.Empty,
															string.Empty,
															string.Empty,
														}, default);
														num5 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
														{
															num5 = 13;
														}
														continue;
													case 5:
														if ((val).TryGetProperty("identityPublicKey", out val3))
														{
															num5 = 17;
															continue;
														}
														goto case 7;
													case 13:
														if ((val4).TryGetProperty("identity", out val5))
														{
															num5 = 11;
															continue;
														}
														goto case 8;
													case 14:
														text5 = string.Empty;
														goto IL_0489;
													case 2:
														text6 = string.Empty;
														goto IL_0456;
													case 7:
														text = string.Empty;
														goto IL_0519;
													case 15:
														if (!(val).TryGetProperty("extraData", out val4))
														{
															num5 = 16;
															continue;
														}
														goto case 6;
													case 6:
														if (!(val4).TryGetProperty("displayName", out val7))
														{
															num5 = 2;
															continue;
														}
														text6 = (val7).GetString();
														if (text6 == null)
														{
															num5 = 9;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee != 0)
															{
																num5 = 15;
															}
															continue;
														}
														goto IL_0456;
													case 12:
														if ((val4).TryGetProperty("XUID", out val6))
														{
															num5 = 3;
															continue;
														}
														goto case 14;
													case 8:
														text2 = string.Empty;
														goto IL_04e6;
													case 16:
														break;
													case 9:
														text6 = string.Empty;
														goto IL_0456;
													case 3:
														text5 = (val6).GetString();
														if (text5 != null)
														{
															goto IL_0489;
														}
														num5 = 4;
														continue;
													case 4:
														text5 = string.Empty;
														goto IL_0489;
													case 11:
														text2 = (val5).GetString();
														if (text2 != null)
														{
															goto IL_04e6;
														}
														num5 = 15;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be != 0)
														{
															num5 = 0;
														}
														continue;
													case 0:
														text2 = string.Empty;
														goto IL_04e6;
													case 17:
														text = (val3).GetString();
														if (text != null)
														{
															goto IL_0519;
														}
														num5 = 10;
														continue;
													case 10:
														text = string.Empty;
														goto IL_0519;
													case 1:
														goto end_IL_006f;
														IL_04e6:
														text4 = text2;
														num5 = 5;
														continue;
														IL_01cb:
														num5 = num6;
														continue;
														IL_0519:
														value2 = text;
														num7 = 25;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
														{
															num7 = 1;
														}
														num6 = num7;
														goto IL_01cb;
														IL_0489:
														text3 = text5;
														num5 = 13;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
														{
															num5 = 7;
														}
														continue;
														IL_0456:
														value = text6;
														num5 = 12;
														continue;
													}
													break;
												}
											}
											finally
											{
												int num8;
												if (val2 == null)
												{
													num8 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea != 0)
													{
														num8 = 1;
													}
													goto IL_06a0;
												}
												goto IL_06c4;
												IL_06a0:
												while (true)
												{
													switch (num8)
													{
													default:
														if (num9 == 990)
														{
															goto IL_069c;
														}
														goto end_IL_06a0;
													case 0:
														break;
													case 1:
														goto end_IL_06a0;
													case 2:
														goto end_IL_06a0;
													}
													goto IL_06c4;
													IL_069c:
													num8 = num9;
													continue;
													end_IL_06a0:
													break;
												}
												goto end_IL_0668;
												IL_06c4:
												(val2).Dispose();
												num8 = 2;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 != 0)
												{
													num8 = 1;
												}
												goto IL_06a0;
												end_IL_0668:;
											}
											goto IL_071e;
										case 5:
										case 8:
											goto IL_071e;
										case 6:
											goto IL_0772;
										case 4:
											goto IL_07a3;
										case 2:
											goto end_IL_071e;
											IL_00f3:
											num4 = num10;
											continue;
										}
										break;
									}
									goto IL_0145;
									continue;
									end_IL_071e:
									break;
								}
							}
							finally
							{
								int num11;
								if (enumerator == null)
								{
									num11 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
									{
										num11 = 0;
									}
									goto IL_0813;
								}
								goto IL_0837;
								IL_0813:
								while (true)
								{
									switch (num11)
									{
									default:
										if (num12 == 990)
										{
											goto IL_080f;
										}
										goto end_IL_0813;
									case 1:
										break;
									case 0:
										goto end_IL_0813;
									case 2:
										goto end_IL_0813;
									}
									goto IL_0837;
									IL_080f:
									num11 = num12;
									continue;
									end_IL_0813:
									break;
								}
								goto end_IL_07db;
								IL_0837:
								(enumerator).Dispose();
								num11 = 2;
								goto IL_0813;
								end_IL_07db:;
							}
							break;
						case 2:
							goto end_IL_006f;
						}
						result = "[identity JWT not found]";
						num2 = 2;
						continue;
						end_IL_006f:
						break;
					}
				}
				catch
				{
					int num13 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
					{
						num13 = 4;
					}
					while (true)
					{
						switch (num13)
						{
						default:
							if (num14 == 989)
							{
								num13 = num14;
								continue;
							}
							break;
						case 1:
							result = "[chain parse error]";
							num13 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
							{
								num13 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe bool AsJfQauhkUu(bool c2s, [NotNullWhen(true)] out sh6KmlfWoQNMIWAdC2mj? decrypt, [NotNullWhen(true)] out sh6KmlfWoQNMIWAdC2mj? encrypt, [NotNullWhen(true)] out byte[]? sourceKey, [NotNullWhen(true)] out byte[]? destKey)
	{
		decrypt = default(sh6KmlfWoQNMIWAdC2mj?);
		encrypt = default(sh6KmlfWoQNMIWAdC2mj?);
		sourceKey = default(byte[]?);
		destKey = default(byte[]?);
		//IL_0008: Expected I8, but got O
encrypt = l0DfCa7vHBs;  // was Unsafe.As<_,long> reinterpret
		_ = 20;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f;
		*(int*)1 = (int)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref sourceKey);
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static ValueTuple<ECDiffieHellman, ECDsa, string> RRxfQ1EV3U9()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		ECDiffieHellman obj = System.Security.Cryptography.ECDiffieHellman.Create(System.Security.Cryptography.ECCurve.NamedCurves.nistP384);
		ECDsa val = System.Security.Cryptography.ECDsa.Create((obj).ExportParameters(true));
		string text = System.Convert.ToBase64String((obj).ExportSubjectPublicKeyInfo());
		return new ValueTuple<ECDiffieHellman, ECDsa, string>(obj, val, text);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string UvXfQ3WcHEl(object header, object payload, object signer)
	{
		string text = MXsfCY2QIq6(((global::System.ReadOnlySpan<byte>)(System.Text.Encoding.UTF8).GetBytes(((dynamic)(header)).ToJsonString(null))));
		string text2 = MXsfCY2QIq6(((global::System.ReadOnlySpan<byte>)(System.Text.Encoding.UTF8).GetBytes(((dynamic)(payload)).ToJsonString(null))));
		string text3 = string.Concat(text, ".", text2);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private string S5ZfQvW64vf(string authV2Json, out string profile)
	{
		profile = default(string);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string? m1KfQE8UvbQ(object rawEnvelope, object finalEnvelope, object profile)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num3 = default(int);
		int num5 = default(int);
		int num8 = default(int);
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		int num10 = default(int);
		string result = default(string);
		int num12 = default(int);
		int num14 = default(int);
		int num16 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			default:
				try
				{
					JsonDocument val = System.Text.Json.JsonDocument.Parse((string)rawEnvelope, default(JsonDocumentOptions));
					int num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
					{
						num2 = 4;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							if (num3 == 988)
							{
								goto IL_0075;
							}
							break;
						case 0:
							break;
						}
						break;
						IL_0075:
						num2 = num3;
					}
					try
					{
						JsonDocument val2 = System.Text.Json.JsonDocument.Parse((string)finalEnvelope, default(JsonDocumentOptions));
						int num4 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
						{
							num4 = 6;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								if (num5 == 988)
								{
									goto IL_00da;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_00da:
							num4 = num5;
						}
						try
						{
							JsonElement root = (val).RootElement;
							JsonElement root2 = (val2).RootElement;
							int num6 = v3TfQ2xUMJK(root);
							int num7 = 9;
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 != 20)
									{
										if (num8 == 1000)
										{
											goto IL_0134;
										}
										goto case 2;
									}
									(defaultInterpolatedStringHandler).AppendFormatted((string)profile);
									num7 = 2;
									continue;
								case 10:
								{
									(defaultInterpolatedStringHandler).AppendLiteral("memory:authv2:profile=");
									int num9 = 20;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
									{
										num9 = 14;
									}
									num8 = num9;
									goto IL_0134;
								}
								case 7:
									(defaultInterpolatedStringHandler).AppendLiteral(":final_chain=");
									num7 = 4;
									continue;
								case 5:
									(defaultInterpolatedStringHandler).AppendLiteral(":raw_chain=");
									num7 = 11;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
									{
										num7 = 18;
									}
									continue;
								case 2:
									(defaultInterpolatedStringHandler).AppendLiteral(":raw_bytes=");
									num7 = 16;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
									{
										num7 = 0;
									}
									continue;
								case 4:
									defaultInterpolatedStringHandler.AppendFormatted<int>(num10);
									num7 = 8;
									continue;
								case 0:
									defaultInterpolatedStringHandler.AppendFormatted<int>((System.Text.Encoding.UTF8).GetByteCount((string)rawEnvelope));
									num7 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
									{
										num7 = 3;
									}
									continue;
								case 9:
									num10 = v3TfQ2xUMJK(root2);
									num7 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
									{
										num7 = 14;
									}
									continue;
								case 3:
									(defaultInterpolatedStringHandler).AppendLiteral(":final_bytes=");
									num7 = 12;
									continue;
								case 11:
									defaultInterpolatedStringHandler.AppendFormatted<int>(num6);
									num7 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
									{
										num7 = 20;
									}
									continue;
								case 6:
									defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(70, 5);
									num7 = 10;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
									{
										num7 = 7;
									}
									continue;
								case 12:
									defaultInterpolatedStringHandler.AppendFormatted<int>((System.Text.Encoding.UTF8).GetByteCount((string)finalEnvelope));
									num7 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
									{
										num7 = 15;
									}
									continue;
								case 8:
									result = (defaultInterpolatedStringHandler).ToStringAndClear();
									num7 = 15;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
									{
										num7 = 1;
									}
									continue;
								case 1:
									break;
									IL_0134:
									num7 = num8;
									continue;
								}
								break;
							}
						}
						finally
						{
							int num11;
							if (val2 == null)
							{
								num11 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
								{
									num11 = 8;
								}
								goto IL_0456;
							}
							goto IL_047a;
							IL_0456:
							while (true)
							{
								switch (num11)
								{
								default:
									if (num12 == 990)
									{
										goto IL_0452;
									}
									goto end_IL_0456;
								case 1:
									break;
								case 2:
									goto end_IL_0456;
								case 0:
									goto end_IL_0456;
								}
								goto IL_047a;
								IL_0452:
								num11 = num12;
								continue;
								end_IL_0456:
								break;
							}
							goto end_IL_041e;
							IL_047a:
							(val2).Dispose();
							num11 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
							{
								num11 = 0;
							}
							goto IL_0456;
							end_IL_041e:;
						}
					}
					finally
					{
						int num13;
						if (val == null)
						{
							num13 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
							{
								num13 = 1;
							}
							goto IL_0502;
						}
						goto IL_054a;
						IL_0502:
						while (true)
						{
							switch (num13)
							{
							default:
								if (num14 == 990)
								{
									goto IL_04fe;
								}
								goto end_IL_0502;
							case 1:
								goto end_IL_0502;
							case 2:
								break;
							case 0:
								goto end_IL_0502;
							}
							goto IL_054a;
							IL_04fe:
							num13 = num14;
							continue;
							end_IL_0502:
							break;
						}
						goto end_IL_04ca;
						IL_054a:
						(val).Dispose();
						num13 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
						{
							num13 = 0;
						}
						goto IL_0502;
						end_IL_04ca:;
					}
				}
				catch
				{
					int num15 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
					{
						num15 = 0;
					}
					while (true)
					{
						switch (num15)
						{
						default:
							if (num16 == 989)
							{
								num15 = num16;
								continue;
							}
							break;
						case 0:
							break;
						case 1:
							goto end_IL_05a8;
						}
						result = null;
						num15 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
						{
							num15 = 7;
						}
						continue;
						end_IL_05a8:
						break;
					}
				}
				break;
			case 0:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int v3TfQ2xUMJK(JsonElement root)
	{
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Invalid comparison between Unknown and I4
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Invalid comparison between Unknown and I4
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Invalid comparison between Unknown and I4
		int num = 3;
		JsonElement val = default(JsonElement);
		JsonElement val2 = default(JsonElement);
		int num5 = default(int);
		JsonDocument val4 = default(JsonDocument);
		int num8 = default(int);
		JsonElement val5 = default(JsonElement);
		int result = default(int);
		int num11 = default(int);
		int num13 = default(int);
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
						if (num2 != 12)
						{
							if (num2 == 993)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						return (val).GetArrayLength();
					case 0:
						try
						{
							string text = (val2).GetString();
							int num4;
							if (text == null)
							{
								num4 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
								{
									num4 = 0;
								}
								goto IL_0093;
							}
							goto IL_00b8;
							IL_0093:
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 989)
									{
										goto IL_008f;
									}
									goto case 1;
								case 0:
									break;
								case 1:
									try
									{
										JsonElement val3 = (val4).RootElement;
										int num6 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
										{
											num6 = 1;
										}
										while (true)
										{
											int num9;
											switch (num6)
											{
											default:
												if (num8 != 10)
												{
													if (num8 == 990)
													{
														goto IL_0129;
													}
													goto case 0;
												}
												if ((int)(val5).ValueKind != 2)
												{
													num6 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
													{
														num6 = 7;
													}
													break;
												}
												num9 = (val5).GetArrayLength();
												goto IL_01f4;
											case 0:
												num9 = 0;
												goto IL_01f4;
											case 1:
												if ((val3).TryGetProperty("chain", out val5))
												{
													int num7 = 7;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
													{
														num7 = 10;
													}
													num8 = num7;
													goto IL_0129;
												}
												goto case 0;
											case 2:
												{
													return result;
												}
												IL_01f4:
												result = num9;
												num6 = 2;
												break;
												IL_0129:
												num6 = num8;
												break;
											}
										}
									}
									finally
									{
										if (val4 != null)
										{
											int num10 = 7;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 != 0)
											{
												num10 = 1;
											}
											while (true)
											{
												switch (num10)
												{
												default:
													if (num11 == 989)
													{
														num10 = num11;
														continue;
													}
													break;
												case 1:
													(val4).Dispose();
													num10 = 2;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
													{
														num10 = 0;
													}
													continue;
												case 0:
													break;
												}
												break;
											}
										}
									}
								}
								break;
								IL_008f:
								num4 = num5;
							}
							text = string.Empty;
							goto IL_00b8;
							IL_00b8:
							val4 = System.Text.Json.JsonDocument.Parse(text, default(JsonDocumentOptions));
							num4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 != 0)
							{
								num4 = 4;
							}
							goto IL_0093;
						}
						catch (JsonException)
						{
							int num12 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 != 0)
							{
								num12 = 0;
							}
							while (true)
							{
								switch (num12)
								{
								default:
									if (num13 == 988)
									{
										num12 = num13;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 1;
					case 3:
						if ((root).TryGetProperty("chain", out val))
						{
							num3 = 2;
							continue;
						}
						goto IL_0354;
					case 1:
					case 5:
						return 0;
					case 4:
						if ((int)(val2).ValueKind == 3)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
							{
								num3 = 6;
							}
							continue;
						}
						goto case 1;
					case 2:
						{
							if ((int)(val).ValueKind == 2)
							{
								break;
							}
							goto IL_0354;
						}
						IL_0354:
						if (!(root).TryGetProperty("Certificate", out val2))
						{
							num3 = 5;
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
			num = 12;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool Mw4fQqKMB1W(string jwt, [NotNullWhen(true)] out JsonObject? header, [NotNullWhen(true)] out JsonObject? payload)
	{
		header = default(JsonObject?);
		payload = default(JsonObject?);
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num5 = default(int);
		string text = default(string);
		bool result = default(bool);
		string text2 = default(string);
		int num7 = default(int);
		int num9 = default(int);
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
				case 0:
					payload = null;
					num2 = 4;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					try
					{
						string[] array = (jwt).Split('.', (StringSplitOptions)0);
						int num3 = 12;
						while (true)
						{
							int num4;
							switch (num3)
							{
							default:
								if (num5 != 21)
								{
									if (num5 == 1001)
									{
										goto IL_0083;
									}
									goto case 12;
								}
								goto end_IL_0087;
							case 12:
								if (array.Length != 3)
								{
									num3 = 19;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
									{
										num3 = 5;
									}
									continue;
								}
								goto case 4;
							case 8:
								goto end_IL_0087;
							case 2:
								if (text == null)
								{
									num3 = 10;
									continue;
								}
								goto case 3;
							case 10:
								result = false;
								num3 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
								{
									num3 = 8;
								}
								continue;
							case 7:
								if (header == null)
								{
									num3 = 11;
									continue;
								}
								goto case 1;
							case 9:
								if (text2 != null)
								{
									num3 = 2;
									continue;
								}
								goto case 10;
							case 4:
								text2 = FvRfCV2yXRK(array[0]);
								num3 = 15;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 != 0)
								{
									num3 = 6;
								}
								continue;
							case 1:
								num4 = ((payload != null) ? 1 : 0);
								break;
							case 6:
								text = FvRfCV2yXRK(array[1]);
								num3 = 9;
								continue;
							case 5:
								result = false;
								num5 = 21;
								goto IL_0083;
							case 3:
							{
								JsonNode obj2 = System.Text.Json.Nodes.JsonNode.Parse(text2, null, default(JsonDocumentOptions));
								header = ((obj2 != null) ? (obj2).AsObject() : null);
								num3 = 13;
								continue;
							}
							case 13:
							{
								JsonNode obj = System.Text.Json.Nodes.JsonNode.Parse(text, null, default(JsonDocumentOptions));
								payload = ((obj != null) ? (obj).AsObject() : null);
								num3 = 7;
								continue;
							}
							case 11:
								num4 = 0;
								break;
							case 0:
								goto end_IL_0087;
								IL_0083:
								num3 = num5;
								continue;
							}
							result = (byte)num4 != 0;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 != 0)
							{
								num3 = 20;
							}
							continue;
							end_IL_0087:
							break;
						}
					}
					catch (JsonException)
					{
						int num6 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
						{
							num6 = 2;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								switch (num7)
								{
								case 990:
									break;
								default:
									goto end_IL_02ec;
								case 10:
									result = false;
									num6 = 8;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
									{
										num6 = 1;
									}
									continue;
								}
								goto IL_02e8;
							case 0:
								payload = null;
								num7 = 10;
								goto IL_02e8;
							case 2:
								header = null;
								num6 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
								{
									num6 = 5;
								}
								continue;
							case 1:
								break;
								IL_02e8:
								num6 = num7;
								continue;
								end_IL_02ec:
								break;
							}
							break;
						}
					}
					catch (InvalidOperationException)
					{
						int num8 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
						{
							num8 = 0;
						}
						while (true)
						{
							switch (num8)
							{
							default:
								if (num9 != 10)
								{
									if (num9 == 990)
									{
										goto IL_03a2;
									}
									goto case 1;
								}
								goto end_IL_03a6;
							case 2:
								result = false;
								num9 = 10;
								goto IL_03a2;
							case 1:
								payload = null;
								num8 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
								{
									num8 = 1;
								}
								break;
							case 0:
								{
									header = null;
									num8 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
									{
										num8 = 1;
									}
									break;
								}
								IL_03a2:
								num8 = num9;
								break;
							}
							continue;
							end_IL_03a6:
							break;
						}
					}
					break;
				case 1:
					header = null;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
					{
						num2 = 4;
					}
					continue;
				case 3:
					break;
				}
				return result;
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private string KyMfQGPqPWY(JsonObject payload)
	{
		string[] array = new string[26]
		{
			"AnimatedImageData",
			"ArmSize",
			"BloomData",
			"CapeData",
			"CapeId",
			"CapeImageHeight",
			"CapeImageWidth",
			"CapeOnClassicSkin",
			"GrowthLevel",
			"IsReconnect",
			"OverrideSkin",
			"PersonaPieces",
			"PersonaSkin",
			"PieceTintColors",
			"PremiumSkin",
			"SkinAnimationData",
			"SkinColor",
			"SkinData",
			"SkinGeometryData",
			"SkinGeometryDataEngineVersion",
			"SkinIID",
			"SkinId",
			"SkinImageHeight",
			"SkinImageWidth",
			"SkinResourcePatch",
			"TrustedSkin"
		};
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static JsonObject? EfxfQilLQqH(out string? templateName)
	{
		templateName = default(string?);
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		int num5 = default(int);
		JsonObject result = default(JsonObject);
		JsonObject val = default(JsonObject);
		global::System.DateTime dateTime2 = default(global::System.DateTime);
		string text2 = default(string);
		global::System.Collections.Generic.IEnumerator<string> enumerator = default(global::System.Collections.Generic.IEnumerator<string>);
		string current = default(string);
		global::System.DateTime dateTime = default(global::System.DateTime);
		int num7 = default(int);
		int num9 = default(int);
		int num11 = default(int);
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
					goto case 1;
				case 2:
					templateName = null;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e != 0)
					{
						num2 = 1;
					}
					continue;
				case 0:
					break;
				case 1:
					try
					{
						string text = System.IO.Path.Combine(System.AppContext.BaseDirectory, "data", "pe_captures", "client_data");
						int num3 = 16;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
						{
							num3 = 10;
						}
						while (true)
						{
							int num4;
							object obj;
							JsonObject? obj2;
							switch (num3)
							{
							default:
								if (num5 != 30)
								{
									if (num5 == 1010)
									{
										goto IL_00f5;
									}
									goto case 10;
								}
								goto end_IL_00f9;
							case 16:
								goto end_IL_00f9;
							case 3:
								goto end_IL_00f9;
							case 11:
								result = val;
								num3 = 21;
								continue;
							case 10:
								if (!System.IO.Directory.Exists(text))
								{
									num4 = 5;
									goto IL_00f1;
								}
								goto case 14;
							case 7:
								dateTime2 = global::System.DateTime.MinValue;
								num3 = 15;
								continue;
							case 4:
							case 13:
							{
								JsonNode obj3 = System.Text.Json.Nodes.JsonNode.Parse(System.IO.File.ReadAllText(text2, System.Text.Encoding.UTF8), null, default(JsonDocumentOptions));
								JsonNode obj4 = ((obj3 is JsonObject) ? obj3 : null);
								if (obj4 == null)
								{
									num3 = 28;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
									{
										num3 = 1;
									}
									continue;
								}
								obj = ((dynamic)(obj4)).Item;
								break;
							}
							case 22:
								try
								{
									while (true)
									{
										IL_0392:
										int num6;
										if (!(enumerator).MoveNext())
										{
											num6 = 4;
											goto IL_029c;
										}
										goto IL_037f;
										IL_029c:
										while (true)
										{
											switch (num6)
											{
											case 3:
												text2 = current;
												num6 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
												{
													num6 = 11;
												}
												continue;
											case 1:
												goto IL_032a;
											case 5:
												if (!(dateTime <= dateTime2))
												{
													num6 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
													{
														num6 = 13;
													}
													continue;
												}
												goto IL_0392;
											case 2:
												goto end_IL_029c;
											case 0:
												goto IL_0392;
											case 4:
												goto end_IL_0392;
											}
											if (num7 != 13)
											{
												if (num7 == 993)
												{
													goto IL_0298;
												}
												goto IL_032a;
											}
											dateTime = System.IO.File.GetLastWriteTimeUtc(current);
											num6 = 2;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
											{
												num6 = 5;
											}
											continue;
											IL_032a:
											dateTime2 = dateTime;
											num6 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
											{
												num6 = 3;
											}
											continue;
											end_IL_029c:
											break;
										}
										goto IL_037f;
										IL_037f:
										current = enumerator.Current;
										num7 = 13;
										goto IL_0298;
										IL_0298:
										num6 = num7;
										goto IL_029c;
										continue;
										end_IL_0392:
										break;
									}
								}
								finally
								{
									int num8;
									if (enumerator == null)
									{
										num8 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be != 0)
										{
											num8 = 0;
										}
										goto IL_03ea;
									}
									goto IL_040e;
									IL_03ea:
									while (true)
									{
										switch (num8)
										{
										default:
											if (num9 == 990)
											{
												goto IL_03e6;
											}
											goto end_IL_03ea;
										case 1:
											break;
										case 0:
											goto end_IL_03ea;
										case 2:
											goto end_IL_03ea;
										}
										goto IL_040e;
										IL_03e6:
										num8 = num9;
										continue;
										end_IL_03ea:
										break;
									}
									goto end_IL_03b2;
									IL_040e:
									(enumerator).Dispose();
									num8 = 2;
									goto IL_03ea;
									end_IL_03b2:;
								}
								goto case 0;
							case 0:
								if (text2 != null)
								{
									num3 = 11;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
									{
										num3 = 4;
									}
									continue;
								}
								goto case 12;
							case 18:
								if (val != null)
								{
									num3 = 21;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
									{
										num3 = 19;
									}
									continue;
								}
								goto case 2;
							case 5:
								result = null;
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
								{
									num3 = 16;
								}
								continue;
							case 15:
								enumerator = System.IO.Directory.EnumerateFiles(text, "client_data_*_netease-v860-c2mitm_*.json").GetEnumerator();
								num3 = 22;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
								{
									num3 = 23;
								}
								continue;
							case 2:
							case 6:
								result = null;
								num3 = 3;
								continue;
							case 20:
								if (((dynamic)(val)).Item != null)
								{
									num3 = 9;
									continue;
								}
								goto case 2;
							case 12:
								obj2 = TcdfQzQiA8H(out templateName);
								if (obj2 == null)
								{
									num3 = 8;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
									{
										num3 = 17;
									}
									continue;
								}
								goto IL_0632;
							case 8:
							case 9:
								templateName = System.IO.Path.GetFileName(text2);
								num3 = 11;
								continue;
							case 14:
								text2 = null;
								num3 = 7;
								continue;
							case 19:
								if (((dynamic)(val)).Item == null)
								{
									num3 = 6;
									continue;
								}
								goto case 20;
							case 17:
								obj2 = niXfCboMLkD(out templateName);
								goto IL_0632;
							case 1:
								obj = null;
								break;
							case 21:
								goto end_IL_00f9;
								IL_0632:
								result = obj2;
								num4 = 30;
								goto IL_00f1;
								IL_00f1:
								num5 = num4;
								goto IL_00f5;
								IL_00f5:
								num3 = num5;
								continue;
							}
							val = (JsonObject)((obj is JsonObject) ? obj : null);
							num3 = 18;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
							{
								num3 = 0;
							}
							continue;
							end_IL_00f9:
							break;
						}
					}
					catch
					{
						int num10 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
						{
							num10 = 1;
						}
						while (true)
						{
							switch (num10)
							{
							default:
								if (num11 == 989)
								{
									num10 = num11;
									continue;
								}
								break;
							case 1:
								result = null;
								num10 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
								{
									num10 = 7;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					break;
				}
				return result;
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string? amIfQn3vufB()
	{
		int num = 1;
		string result = default(string);
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 0:
				break;
			default:
				try
				{
					result = System.IO.Path.Combine(new string[5]
					{
						System.AppContext.BaseDirectory,
						"data",
						"pe_captures",
						"client_data",
						"netease_v860_client_data.json"
					});
					int num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
					{
						num2 = 2;
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
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 != 0)
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
								continue;
							}
							break;
						case 1:
							break;
						case 0:
							goto end_IL_0156;
						}
						result = null;
						num4 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
						{
							num4 = 7;
						}
						continue;
						end_IL_0156:
						break;
					}
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void MirrorNativeClientDataTemplate(object snapshot)
	{
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0136: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num4 = default(int);
		int num6 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				break;
			default:
				return;
			case 1:
				try
				{
					string text = amIfQn3vufB();
					int num2 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
					{
						num2 = 11;
					}
					while (true)
					{
						switch (num2)
						{
						case 1:
							return;
						case 4:
							return;
						default:
							switch (num4)
							{
							default:
								return;
							case 992:
								break;
							case 12:
								WxrTMvfyNwIYq3E6jqT8.HPAfypOI73d("Mirrored native NetEase client-data template");
								num2 = 4;
								continue;
							}
							goto IL_0066;
						case 3:
							if (text == null)
							{
								num2 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
								{
									num2 = 1;
								}
								continue;
							}
							break;
						case 2:
						{
							JsonSerializerOptions val = new JsonSerializerOptions();
							((dynamic)((object)val)).WriteIndented = true;
							System.IO.File.WriteAllText(text, ((dynamic)(snapshot)).ToJsonString(val), (Encoding)new UTF8Encoding(false));
							int num3 = 12;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e != 0)
							{
								num3 = 6;
							}
							num4 = num3;
							goto IL_0066;
						}
						case 0:
							break;
							IL_0066:
							num2 = num4;
							continue;
						}
						string text2 = System.IO.Path.GetDirectoryName(text);
						if (string.IsNullOrWhiteSpace(text2))
						{
							break;
						}
						System.IO.Directory.CreateDirectory(text2);
						num2 = 2;
					}
					throw new InvalidOperationException("Shared client-data template path has no parent directory");
				}
				catch (global::System.Exception ex)
				{
					int num5 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
					{
						num5 = 2;
					}
					while (true)
					{
						switch (num5)
						{
						case 0:
							return;
						default:
							if (num6 == 990)
							{
								num5 = num6;
								continue;
							}
							break;
						case 1:
							WxrTMvfyNwIYq3E6jqT8.zoSfyugkx0O(string.Concat("Failed to mirror native client-data template: ", ((ex).GetType()).Name));
							num5 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
							{
								num5 = 0;
							}
							continue;
						case 2:
							break;
						}
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "caught-exception", "MirrorNativeClientDataTemplate", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Bedrock\\Relay\\Protocol\\BedrockMitmSession.cs", 4518);
						num5 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
						{
							num5 = 4;
						}
					}
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static JsonObject? TcdfQzQiA8H(out string? templateName)
	{
		templateName = default(string?);
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		int num5 = default(int);
		JsonObject result = default(JsonObject);
		JsonObject val = default(JsonObject);
		int num7 = default(int);
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
				case 1:
					try
					{
						string text = amIfQn3vufB();
						int num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 != 0)
						{
							num3 = 13;
						}
						while (true)
						{
							int num4;
							object obj;
							switch (num3)
							{
							default:
								if (num5 != 22)
								{
									if (num5 == 1002)
									{
										goto IL_0069;
									}
									goto case 8;
								}
								goto case 14;
							case 14:
								result = null;
								num3 = 4;
								continue;
							case 2:
								goto end_IL_006d;
							case 6:
								if (((dynamic)(val)).Item == null)
								{
									num3 = 14;
									continue;
								}
								goto case 10;
							case 11:
								result = null;
								num3 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
								{
									num3 = 10;
								}
								continue;
							case 13:
								result = val;
								num3 = 12;
								continue;
							case 1:
								if (text != null)
								{
									num3 = 9;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
									{
										num3 = 6;
									}
									continue;
								}
								goto case 11;
							case 0:
								if (val != null)
								{
									num3 = 8;
									continue;
								}
								goto case 14;
							case 4:
								goto end_IL_006d;
							case 10:
								templateName = string.Concat("shared:", System.IO.Path.GetFileName(text));
								num3 = 13;
								continue;
							case 9:
								if (System.IO.File.Exists(text))
								{
									num3 = 3;
									continue;
								}
								goto case 11;
							case 8:
								if (((dynamic)(val)).Item == null)
								{
									num4 = 22;
									goto IL_0065;
								}
								goto case 6;
							case 3:
							case 7:
							{
								JsonNode obj2 = System.Text.Json.Nodes.JsonNode.Parse(System.IO.File.ReadAllText(text, System.Text.Encoding.UTF8), null, default(JsonDocumentOptions));
								JsonNode obj3 = ((obj2 is JsonObject) ? obj2 : null);
								if (obj3 == null)
								{
									num4 = 5;
									goto IL_0065;
								}
								obj = ((dynamic)(obj3)).Item;
								break;
							}
							case 5:
								obj = null;
								break;
							case 12:
								goto end_IL_006d;
								IL_0069:
								num3 = num5;
								continue;
								IL_0065:
								num5 = num4;
								goto IL_0069;
							}
							val = (JsonObject)((obj is JsonObject) ? obj : null);
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
							{
								num3 = 12;
							}
							continue;
							end_IL_006d:
							break;
						}
					}
					catch
					{
						int num6 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
						{
							num6 = 4;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 == 989)
								{
									num6 = num7;
									continue;
								}
								break;
							case 0:
								result = null;
								num6 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
								{
									num6 = 7;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 0;
				case 0:
					return result;
				case 2:
					templateName = null;
					num2 = 7;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
					{
						num2 = 1;
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
	private static JsonObject? niXfCboMLkD(out string? templateName)
	{
		templateName = default(string?);
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		int num4 = default(int);
		int num11 = default(int);
		StreamReader val2 = default(StreamReader);
		int num7 = default(int);
		JsonObject val3 = default(JsonObject);
		JsonObject result = default(JsonObject);
		int num10 = default(int);
		int num13 = default(int);
		int num15 = default(int);
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
				case 1:
					try
					{
						Stream val = (System.Reflection.Assembly.GetExecutingAssembly()).GetManifestResourceStream("Mahiro_Account.Resources.Bedrock.NeteaseClientData.v860.json");
						int num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 == 988)
								{
									goto IL_0094;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_0094:
							num3 = num4;
						}
						try
						{
							int num5;
							if (val != null)
							{
								num5 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
								{
									num5 = 1;
								}
								goto IL_00ed;
							}
							goto IL_0119;
							IL_00ed:
							while (true)
							{
								switch (num5)
								{
								default:
									if (num11 == 992)
									{
										num5 = num11;
										continue;
									}
									goto end_IL_00ed;
								case 2:
									break;
								case 1:
								case 4:
									val2 = new StreamReader(val, System.Text.Encoding.UTF8);
									num5 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
									{
										num5 = 0;
									}
									continue;
								case 3:
									goto end_IL_00ed;
								case 0:
									try
									{
										JsonNode obj = System.Text.Json.Nodes.JsonNode.Parse((val2).ReadToEnd(), null, default(JsonDocumentOptions));
										JsonNode obj2 = ((obj is JsonObject) ? obj : null);
										int num6;
										if (obj2 == null)
										{
											num6 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
											{
												num6 = 11;
											}
											goto IL_01f3;
										}
										object obj3 = ((dynamic)(obj2)).Item;
										goto IL_03a7;
										IL_01f3:
										while (true)
										{
											int num8;
											switch (num6)
											{
											default:
												if (num7 != 16)
												{
													if (num7 == 996)
													{
														goto IL_01ef;
													}
													goto case 7;
												}
												goto end_IL_01f3;
											case 7:
												templateName = "embedded:Mahiro_Account.Resources.Bedrock.NeteaseClientData.v860.json";
												num6 = 2;
												continue;
											case 8:
												if (((dynamic)(val3)).Item != null)
												{
													num8 = 6;
													goto IL_01eb;
												}
												goto case 3;
											case 2:
												result = val3;
												num8 = 5;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
												{
													num8 = 16;
												}
												goto IL_01eb;
											case 3:
											case 5:
												result = null;
												num6 = 4;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
												{
													num6 = 0;
												}
												continue;
											case 4:
												if (val3 == null)
												{
													num6 = 3;
													continue;
												}
												goto case 8;
											case 6:
												if (((dynamic)(val3)).Item == null)
												{
													num6 = 5;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
													{
														num6 = 16;
													}
													continue;
												}
												goto case 7;
											case 0:
												goto end_IL_01f3;
											case 1:
												{
													obj3 = null;
													break;
												}
												IL_01eb:
												num7 = num8;
												goto IL_01ef;
												IL_01ef:
												num6 = num7;
												continue;
											}
											goto IL_03a7;
											continue;
											end_IL_01f3:
											break;
										}
										goto end_IL_018c;
										IL_03a7:
										val3 = (JsonObject)((obj3 is JsonObject) ? obj3 : null);
										num6 = 4;
										goto IL_01f3;
										end_IL_018c:;
									}
									finally
									{
										if (val2 != null)
										{
											int num9 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
											{
												num9 = 4;
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
												case 0:
													(val2).Dispose();
													num9 = 3;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
													{
														num9 = 1;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
									}
									goto end_IL_00ed;
								}
								goto IL_0119;
								continue;
								end_IL_00ed:
								break;
							}
							goto end_IL_00b5;
							IL_0119:
							result = null;
							num5 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
							{
								num5 = 3;
							}
							goto IL_00ed;
							end_IL_00b5:;
						}
						finally
						{
							if (val != null)
							{
								int num12 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
								{
									num12 = 1;
								}
								while (true)
								{
									switch (num12)
									{
									default:
										if (num13 == 989)
										{
											num12 = num13;
											continue;
										}
										break;
									case 1:
										break;
									case 0:
										goto end_IL_0479;
									}
									(val).Dispose();
									num12 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
									{
										num12 = 7;
									}
									continue;
									end_IL_0479:
									break;
								}
							}
						}
					}
					catch
					{
						int num14 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
						{
							num14 = 1;
						}
						while (true)
						{
							switch (num14)
							{
							default:
								if (num15 == 989)
								{
									num14 = num15;
									continue;
								}
								break;
							case 1:
								break;
							case 0:
								goto end_IL_04f7;
							}
							result = null;
							num14 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 != 0)
							{
								num14 = 0;
							}
							continue;
							end_IL_04f7:
							break;
						}
					}
					goto case 0;
				case 0:
					return result;
				case 2:
					templateName = null;
					num2 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
					{
						num2 = 1;
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
	private static string? q0YfCXb4Y4I(object source, int protocolVersion, int authPayloadLength, object jwt)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool F7PfCfZnexY(object datagram, out uint sequenceNumber, out List<LGs51pLcNObAM6UTLTsO> frames)
	{
		sequenceNumber = default(uint);
		frames = default(List<LGs51pLcNObAM6UTLTsO>);
		int num = default(int);
		int num2 = default(int);
		byte[] subArray = ((byte[])datagram)[((System.Index)num)..((System.Index)num2)];
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] a9QfCLELlSh(byte packetId, uint sequenceNumber, List<LGs51pLcNObAM6UTLTsO> frames)
	{
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		byte[] result = default(byte[]);
		MemoryStream val = default(MemoryStream);
		int num8 = default(int);
		global::System.Collections.Generic.IEnumerator<LGs51pLcNObAM6UTLTsO> enumerator = default(global::System.Collections.Generic.IEnumerator<LGs51pLcNObAM6UTLTsO>);
		int num5 = default(int);
		LGs51pLcNObAM6UTLTsO current = default(LGs51pLcNObAM6UTLTsO);
		int num7 = default(int);
		int num10 = default(int);
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
				case 0:
					return result;
				case 1:
					try
					{
						(val).WriteByte(packetId);
						int num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num8 != 11)
								{
									if (num8 == 991)
									{
										goto IL_0072;
									}
									goto case 0;
								}
								goto end_IL_0076;
							case 0:
								result = (val).ToArray();
								num8 = 11;
								goto IL_0072;
							case 1:
								yEFfCm7o0ZJ(val, sequenceNumber);
								num3 = 11;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
								{
									num3 = 2;
								}
								break;
							case 2:
								enumerator = frames.GetEnumerator();
								num3 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
								{
									num3 = 3;
								}
								break;
							case 3:
								{
									try
									{
										while (true)
										{
											int num4;
											if (!enumerator.MoveNext())
											{
												num4 = 5;
												goto IL_0149;
											}
											goto IL_023a;
											IL_0149:
											while (true)
											{
												switch (num4)
												{
												default:
													if (num5 != 13)
													{
														if (num5 == 993)
														{
															goto IL_0145;
														}
														goto case 2;
													}
													iVmfC7wj8su(val, checked((ushort)(current.Payload.Length * 8)));
													num4 = 2;
													continue;
												case 4:
													(val).Write(current.Payload, 0, current.Payload.Length);
													num4 = 11;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
													{
														num4 = 3;
													}
													continue;
												case 0:
													(val).WriteByte(current.Flags);
													num5 = 13;
													goto IL_0145;
												case 2:
													(val).Write(current.HeaderSuffix, 0, current.HeaderSuffix.Length);
													num4 = 4;
													continue;
												case 3:
													break;
												case 1:
													goto IL_023a;
												case 5:
													goto end_IL_0207;
													IL_0145:
													num4 = num5;
													continue;
												}
												break;
											}
											continue;
											IL_023a:
											current = enumerator.Current;
											num4 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
											{
												num4 = 0;
											}
											goto IL_0149;
											continue;
											end_IL_0207:
											break;
										}
									}
									finally
									{
										((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
										int num6 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
										{
											num6 = 1;
										}
										while (true)
										{
											switch (num6)
											{
											default:
												if (num7 == 988)
												{
													num6 = num7;
													continue;
												}
												break;
											case 0:
												break;
											}
											break;
										}
									}
									goto case 0;
								}
								IL_0072:
								num3 = num8;
								break;
							}
							continue;
							end_IL_0076:
							break;
						}
					}
					finally
					{
						if (val != null)
						{
							int num9 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
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
									goto end_IL_031e;
								}
								(val).Dispose();
								num9 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
								{
									num9 = 0;
								}
								continue;
								end_IL_031e:
								break;
							}
						}
					}
					goto case 0;
				case 2:
					val = new MemoryStream();
					num2 = 5;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
					{
						num2 = 1;
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
	private byte[]? bAcfCjqxm7v(byte[] datagram, out int removedCount)
	{
		removedCount = default(int);
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		int num = 41;
		int num6 = default(int);
		uint num10 = default(uint);
		MemoryStream val2 = default(MemoryStream);
		int num18 = default(int);
		global::System.Collections.Generic.IEnumerator<ktoDtILc38S9Lmcxx778> enumerator = default(global::System.Collections.Generic.IEnumerator<ktoDtILc38S9Lmcxx778>);
		List<ktoDtILc38S9Lmcxx778> val = default(List<ktoDtILc38S9Lmcxx778>);
		int num14 = default(int);
		ktoDtILc38S9Lmcxx778 current = default(ktoDtILc38S9Lmcxx778);
		int num17 = default(int);
		byte[] result = default(byte[]);
		int num20 = default(int);
		bool flag = default(bool);
		int num9 = default(int);
		uint num5 = default(uint);
		uint num4 = default(uint);
		uint num8 = default(uint);
		ushort num11 = default(ushort);
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
						if (num2 != 51)
						{
							if (num2 == 1032)
							{
								goto end_IL_0010;
							}
							goto case 41;
						}
						if (datagram[num6++] != 0)
						{
							num3 = 37;
							continue;
						}
						goto case 19;
					case 40:
						if (datagram.Length >= 3)
						{
							num3 = 43;
							continue;
						}
						goto case 7;
					case 37:
						if (num6 + 3 > datagram.Length)
						{
							num3 = 23;
							continue;
						}
						num10 = U8TfComUx6M(datagram, num6);
						num3 = 32;
						continue;
					case 36:
						try
						{
							(val2).WriteByte(160);
							int num12 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
							{
								num12 = 0;
							}
							while (true)
							{
								switch (num12)
								{
								default:
									switch (num18)
									{
									case 991:
										break;
									default:
										goto end_IL_0156;
									case 11:
										enumerator = val.GetEnumerator();
										num12 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
										{
											num12 = 1;
										}
										continue;
									}
									goto IL_0152;
								case 3:
									iVmfC7wj8su(val2, checked((ushort)val.Count));
									num18 = 11;
									goto IL_0152;
								case 1:
									try
									{
										while (true)
										{
											IL_02e3:
											if (!enumerator.MoveNext())
											{
												int num13 = 14;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
												{
													num13 = 10;
												}
												num14 = num13;
												goto IL_0200;
											}
											goto IL_030e;
											IL_030e:
											current = enumerator.Current;
											int num15 = 11;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
											{
												num15 = 3;
											}
											goto IL_0204;
											IL_0204:
											while (true)
											{
												switch (num15)
												{
												case 3:
													(val2).WriteByte(current.Single ? ((byte)1) : ((byte)0));
													num15 = 5;
													continue;
												case 0:
													if (current.Single)
													{
														num15 = 3;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
														{
															num15 = 2;
														}
														continue;
													}
													goto case 4;
												case 5:
													yEFfCm7o0ZJ(val2, current.Start);
													num15 = 3;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 != 0)
													{
														num15 = 0;
													}
													continue;
												case 2:
												case 6:
													goto IL_02e3;
												case 1:
													goto IL_030e;
												case 4:
													yEFfCm7o0ZJ(val2, current.End);
													num15 = 3;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
													{
														num15 = 6;
													}
													continue;
												}
												break;
											}
											switch (num14)
											{
											case 994:
												break;
											default:
												continue;
											case 14:
												goto end_IL_02e3;
											}
											goto IL_0200;
											IL_0200:
											num15 = num14;
											goto IL_0204;
											continue;
											end_IL_02e3:
											break;
										}
									}
									finally
									{
										((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
										int num16 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
										{
											num16 = 0;
										}
										while (true)
										{
											switch (num16)
											{
											default:
												if (num17 == 988)
												{
													num16 = num17;
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
								case 0:
									break;
								case 2:
									goto end_IL_0156;
									IL_0152:
									num12 = num18;
									continue;
								}
								result = (val2).ToArray();
								num12 = 2;
								continue;
								end_IL_0156:
								break;
							}
						}
						finally
						{
							if (val2 != null)
							{
								int num19 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
								{
									num19 = 1;
								}
								while (true)
								{
									switch (num19)
									{
									default:
										if (num20 == 989)
										{
											num19 = num20;
											continue;
										}
										break;
									case 0:
										(val2).Dispose();
										num19 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
										{
											num19 = 6;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
						}
						goto case 2;
					case 30:
						if (flag)
						{
							num3 = 39;
							continue;
						}
						goto case 25;
					case 26:
						flag = true;
						num3 = 44;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e != 0)
						{
							num3 = 37;
						}
						continue;
					case 2:
						return result;
					case 28:
						flag = false;
						num3 = 33;
						continue;
					case 8:
						if (WbUf4XIyEo8.Contains(num10))
						{
							num = 9;
							break;
						}
						goto case 14;
					case 1:
					case 3:
					case 27:
					case 42:
						num9++;
						num3 = 5;
						continue;
					case 33:
						num9 = 0;
						num3 = 29;
						continue;
					case 10:
						num6 = 3;
						num3 = 40;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
						{
							num3 = 11;
						}
						continue;
					case 13:
						if (WbUf4XIyEo8.Contains(num5))
						{
							num3 = 30;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
							{
								num3 = 17;
							}
							continue;
						}
						goto case 12;
					case 0:
					case 24:
						removedCount++;
						num = 26;
						break;
					case 9:
						removedCount++;
						num3 = 20;
						continue;
					case 41:
						removedCount = 0;
						num3 = 40;
						continue;
					case 25:
						return datagram;
					case 39:
						if (val.Count != 0)
						{
							num3 = 38;
							continue;
						}
						goto case 18;
					case 18:
						return null;
					case 38:
						val2 = new MemoryStream();
						num3 = 42;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
						{
							num3 = 36;
						}
						continue;
					case 15:
						val.Add((ktoDtILc38S9Lmcxx778)new ktoDtILc38S9Lmcxx778(num4 == num8, num4, num8));
						num3 = 27;
						continue;
					case 11:
						val = new List<ktoDtILc38S9Lmcxx778>();
						num3 = 28;
						continue;
					case 43:
						if (datagram[0] != 160)
						{
							num3 = 7;
							continue;
						}
						num11 = System.Buffers.Binary.BinaryPrimitives.ReadUInt16BigEndian(((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>(datagram, 1)));
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
						{
							num3 = 43;
						}
						continue;
					case 34:
						num5++;
						num3 = 21;
						continue;
					case 32:
						num6 += 3;
						num3 = 8;
						continue;
					case 5:
					case 29:
						if (num9 >= num11)
						{
							num3 = 30;
							continue;
						}
						goto case 6;
					case 14:
						val.Add((ktoDtILc38S9Lmcxx778)new ktoDtILc38S9Lmcxx778(Single: true, num10, num10));
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 != 0)
						{
							num3 = 2;
						}
						continue;
					case 21:
					case 35:
						if (num5 > num8)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
							{
								num3 = 22;
							}
							continue;
						}
						goto case 13;
					case 19:
						if (num6 + 6 <= datagram.Length)
						{
							num3 = 47;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 != 0)
							{
								num3 = 31;
							}
							continue;
						}
						goto case 16;
					case 23:
						return datagram;
					case 17:
						if (num4 >= num5)
						{
							num3 = 24;
							continue;
						}
						goto case 4;
					case 20:
						flag = true;
						num3 = 23;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
						{
							num3 = 1;
						}
						continue;
					case 12:
						if (num5 != 4294967295u)
						{
							num3 = 34;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
							{
								num3 = 43;
							}
							continue;
						}
						goto case 22;
					case 7:
						return datagram;
					case 16:
						return datagram;
					case 31:
					{
						uint num7 = U8TfComUx6M(datagram, num6);
						num8 = U8TfComUx6M(datagram, num6 + 3);
						num6 += 6;
						num4 = num7;
						num5 = num7;
						num3 = 35;
						continue;
					}
					case 22:
						if (num4 > num8)
						{
							num3 = 42;
							continue;
						}
						goto case 15;
					case 44:
						num4 = num5 + 1;
						num3 = 39;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
						{
							num3 = 12;
						}
						continue;
					case 6:
						if (num6 < datagram.Length)
						{
							num = 51;
							break;
						}
						goto case 30;
					case 4:
						val.Add((ktoDtILc38S9Lmcxx778)new ktoDtILc38S9Lmcxx778(num4 == num5 - 1, num4, num5 - 1));
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
						{
							num3 = 38;
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
	private static byte[] gyifCZRTbsN(uint sequenceNumber)
	{
		byte[] array = new byte[7];
		System.Runtime.CompilerServices.RuntimeHelpers.InitializeArray(array, default(RuntimeFieldHandle));
		array[4] = (byte)(sequenceNumber & 0xFF);
		array[5] = (byte)((sequenceNumber >> 8) & 0xFF);
		array[6] = (byte)((sequenceNumber >> 16) & 0xFF);
		return array;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static ulong VOjfC9WaqMR(ref ulong counter)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] tkHfCD0u9cn(ulong counter, object plaintextBatch, object sessionKey)
	{
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		int num5 = default(int);
		IncrementalHash val = default(IncrementalHash);
		byte[] subArray = default(byte[]);
		int num7 = default(int);
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
					goto case 1;
				case 1:
					try
					{
						global::System.Span<byte> span = stackalloc byte[8];
						int num3 = 3;
						while (true)
						{
							switch (num3)
							{
							default:
								if (num5 != 12)
								{
									if (num5 != 992)
									{
										break;
									}
									goto IL_0059;
								}
								goto end_IL_005d;
							case 2:
								(val).AppendData(span);
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
								{
									num3 = 9;
								}
								continue;
							case 4:
							{
								subArray = (val).GetHashAndReset()[System.Range.EndAt(((System.Index)8))];
								int num4 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
								{
									num4 = 12;
								}
								num5 = num4;
								goto IL_0059;
							}
							case 0:
								(val).AppendData((byte[])plaintextBatch);
								num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
								(val).AppendData((byte[])sessionKey);
								num3 = 4;
								continue;
							case 3:
								break;
								IL_0059:
								num3 = num5;
								continue;
							}
							System.Buffers.Binary.BinaryPrimitives.WriteUInt64LittleEndian(span, counter);
							num3 = 2;
							continue;
							end_IL_005d:
							break;
						}
					}
					finally
					{
						int num6;
						if (val == null)
						{
							num6 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed != 0)
							{
								num6 = 0;
							}
							goto IL_01a7;
						}
						goto IL_01ef;
						IL_01a7:
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 == 990)
								{
									goto IL_01a3;
								}
								goto end_IL_01a7;
							case 0:
								goto end_IL_01a7;
							case 1:
								break;
							case 2:
								goto end_IL_01a7;
							}
							goto IL_01ef;
							IL_01a3:
							num6 = num7;
							continue;
							end_IL_01a7:
							break;
						}
						goto end_IL_016f;
						IL_01ef:
						(val).Dispose();
						num6 = 2;
						goto IL_01a7;
						end_IL_016f:;
					}
					break;
				case 2:
					val = System.Security.Cryptography.IncrementalHash.CreateHash(System.Security.Cryptography.HashAlgorithmName.SHA256);
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
					{
						num2 = 6;
					}
					continue;
				case 0:
					break;
				}
				return subArray;
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] fWwfCkAVZoN(object value)
	{
		int num = ((dynamic)(value)).Length % 4;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string? FvRfCV2yXRK(object base64Url)
	{
		int num = 1;
		int num5 = default(int);
		int num4 = default(int);
		string result = default(string);
		int num7 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					string text = (((dynamic)(base64Url)).Replace('-', '+')).Replace('_', '/');
					int num2 = 6;
					while (true)
					{
						int num3;
						switch (num2)
						{
						default:
							if (num5 != 15)
							{
								if (num5 == 995)
								{
									goto IL_006b;
								}
								goto case 0;
							}
							if (num4 != 2)
							{
								num2 = 3;
								continue;
							}
							break;
						case 0:
							text = string.Concat(text, "=");
							num2 = 4;
							continue;
						case 3:
							if (num4 != 3)
							{
								num3 = 7;
								goto IL_0067;
							}
							goto case 0;
						case 6:
							num4 = (text).Length % 4;
							num3 = 15;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
							{
								num3 = 12;
							}
							goto IL_0067;
						case 1:
							break;
						case 2:
						case 4:
						case 7:
							result = (System.Text.Encoding.UTF8).GetString(System.Convert.FromBase64String(text));
							num3 = 5;
							goto IL_0067;
						case 5:
							goto end_IL_006f;
							IL_006b:
							num2 = num5;
							continue;
							IL_0067:
							num5 = num3;
							goto IL_006b;
						}
						text = string.Concat(text, "==");
						num2 = 2;
						continue;
						end_IL_006f:
						break;
					}
				}
				catch
				{
					int num6 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
					{
						num6 = 0;
					}
					while (true)
					{
						switch (num6)
						{
						default:
							if (num7 == 989)
							{
								num6 = num7;
								continue;
							}
							break;
						case 0:
							result = null;
							num6 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
							{
								num6 = 6;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string MXsfCY2QIq6(global::System.ReadOnlySpan<byte> data)
	{
		return (((System.Convert.ToBase64String(data, (Base64FormattingOptions)0)).TrimEnd('=')).Replace('+', '-')).Replace('/', '_');
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] THIfCSKjY3q(object data, int start, out bool rawDeflate)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] z6NfCcAfpEq(object data)
	{
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		int num = 2;
		byte[] result = default(byte[]);
		MemoryStream val = default(MemoryStream);
		int num8 = default(int);
		int num5 = default(int);
		int num7 = default(int);
		int num10 = default(int);
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
				case 0:
					return result;
				case 1:
					try
					{
						DeflateStream val2 = new DeflateStream((Stream)(object)val, (CompressionLevel)3, true);
						int num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num8 == 990)
								{
									num3 = num8;
									continue;
								}
								goto end_IL_0074;
							case 1:
								try
								{
									(val2).Write((byte[])data, 0, ((global::System.Array)data).Length);
									int num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
									{
										num4 = 2;
									}
									while (true)
									{
										switch (num4)
										{
										default:
											if (num5 == 988)
											{
												num4 = num5;
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
									if (val2 != null)
									{
										int num6 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
										{
											num6 = 0;
										}
										while (true)
										{
											switch (num6)
											{
											default:
												if (num7 == 989)
												{
													num6 = num7;
													continue;
												}
												break;
											case 0:
												(val2).Dispose();
												num6 = 3;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
												{
													num6 = 1;
												}
												continue;
											case 1:
												break;
											}
											break;
										}
									}
								}
								break;
							case 0:
								break;
							case 2:
								goto end_IL_0074;
							}
							result = (val).ToArray();
							num3 = 2;
							continue;
							end_IL_0074:
							break;
						}
					}
					finally
					{
						int num9;
						if (val == null)
						{
							num9 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
							{
								num9 = 1;
							}
							goto IL_01f4;
						}
						goto IL_023c;
						IL_01f0:
						num9 = num10;
						goto IL_01f4;
						IL_023c:
						(val).Dispose();
						num10 = 2;
						goto IL_01f0;
						IL_01f4:
						switch (num9)
						{
						case 1:
							goto end_IL_01bc;
						case 0:
							goto IL_023c;
						case 2:
							goto end_IL_01bc;
						}
						if (num10 == 990)
						{
							goto IL_01f0;
						}
						goto IL_023c;
						end_IL_01bc:;
					}
					goto case 0;
				case 2:
					val = new MemoryStream();
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
					{
						num2 = 0;
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
	private static byte[] PUqfC06xbfu(object data)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		int num = 1;
		MemoryStream val2 = default(MemoryStream);
		int num4 = default(int);
		int num6 = default(int);
		int num8 = default(int);
		byte[] result = default(byte[]);
		int num10 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0021;
				case 1:
					val2 = new MemoryStream();
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					try
					{
						ZLibStream val = new ZLibStream((Stream)(object)val2, (CompressionLevel)3, true);
						int num3 = 2;
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 == 990)
								{
									num3 = num4;
									continue;
								}
								goto case 2;
							case 1:
								break;
							case 2:
								try
								{
									(val).Write((byte[])data, 0, ((global::System.Array)data).Length);
									int num5 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
									{
										num5 = 2;
									}
									while (true)
									{
										switch (num5)
										{
										default:
											if (num6 == 988)
											{
												num5 = num6;
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
									int num7;
									if (val == null)
									{
										num7 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
										{
											num7 = 8;
										}
										goto IL_016f;
									}
									goto IL_01b7;
									IL_016f:
									while (true)
									{
										switch (num7)
										{
										default:
											if (num8 == 990)
											{
												goto IL_016b;
											}
											break;
										case 0:
											goto end_IL_016f;
										case 2:
											break;
										case 1:
											goto end_IL_016f;
										}
										goto IL_01b7;
										IL_016b:
										num7 = num8;
										continue;
										end_IL_016f:
										break;
									}
									goto end_IL_0137;
									IL_01b7:
									(val).Dispose();
									num7 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
									{
										num7 = 8;
									}
									goto IL_016f;
									end_IL_0137:;
								}
								break;
							case 0:
								goto end_IL_0082;
							}
							result = (val2).ToArray();
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
							{
								num3 = 0;
							}
							continue;
							end_IL_0082:
							break;
						}
					}
					finally
					{
						if (val2 != null)
						{
							int num9 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
							{
								num9 = 2;
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
								case 0:
									(val2).Dispose();
									num9 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
									{
										num9 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					break;
				case 2:
					break;
				}
				goto IL_02aa;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_02aa;
				IL_02aa:
				return result;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string? i1YfC8N6iE3(object builder)
	{
		string text = ((builder).ToString()).TrimEnd();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string? R5qfCypmOj8(object? first, object? second)
	{
		int num = 1;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private bool ae7fCWmPDkX(string reason)
	{
		VHif48EsEGT = reason;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private string N1jfCJT8pFS()
	{
		int num = 2;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private string YI4fCQ9wDSI()
	{
		int num = 2;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string HhHfCCG6DNo(int chainCount)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		(defaultInterpolatedStringHandler).AppendLiteral("chain links=");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string McSfC4N0cF6(object value, int len)
	{
		int num = 1;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string FOkfCh7OANQ(string? value)
	{
		string text = System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData((System.Text.Encoding.UTF8).GetBytes(value)));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] PqOfCUj2Zdm(object data)
	{
		byte[] array = default(byte[]);
		System.Buffer.BlockCopy((global::System.Array)data, 0, array, 1, ((global::System.Array)data).Length);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static List<LGs51pLcNObAM6UTLTsO> CKbfCrKWNOt(List<LGs51pLcNObAM6UTLTsO> frames)
	{
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		global::System.Collections.Generic.IEnumerator<LGs51pLcNObAM6UTLTsO> enumerator = default(global::System.Collections.Generic.IEnumerator<LGs51pLcNObAM6UTLTsO>);
		int num5 = default(int);
		List<LGs51pLcNObAM6UTLTsO> val = default(List<LGs51pLcNObAM6UTLTsO>);
		LGs51pLcNObAM6UTLTsO current = default(LGs51pLcNObAM6UTLTsO);
		int num7 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0025;
				case 0:
					try
					{
						while (true)
						{
							IL_012e:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 2;
								goto IL_006f;
							}
							goto IL_0106;
							IL_006f:
							while (true)
							{
								switch (num3)
								{
								default:
									switch (num5)
									{
									case 990:
										goto IL_006b;
									default:
										goto end_IL_012e;
									case 10:
										break;
									}
									goto IL_012e;
								case 0:
								{
									val.Add((LGs51pLcNObAM6UTLTsO)new LGs51pLcNObAM6UTLTsO(current.Flags, (byte[])(current.HeaderSuffix).Clone(), (byte[])(current.Payload).Clone(), current.Fragment));
									int num4 = 10;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 != 0)
									{
										num4 = 7;
									}
									num5 = num4;
									goto IL_006b;
								}
								case 1:
									break;
								case 2:
									goto end_IL_012e;
									IL_006b:
									num3 = num5;
									continue;
								}
								break;
							}
							goto IL_0106;
							IL_0106:
							current = enumerator.Current;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
							{
								num3 = 9;
							}
							goto IL_006f;
							continue;
							end_IL_012e:
							break;
						}
					}
					finally
					{
						((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						int num6 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 == 988)
								{
									num6 = num7;
									continue;
								}
								break;
							case 0:
								break;
							}
							break;
						}
					}
					goto case 3;
				case 2:
					val = new List<LGs51pLcNObAM6UTLTsO>(frames.Count);
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
					{
						num2 = 5;
					}
					continue;
				case 3:
					return val;
				case 1:
					break;
				}
				goto IL_01dd;
				IL_0025:
				if (num == 991)
				{
					break;
				}
				goto IL_01dd;
				IL_01dd:
				enumerator = frames.GetEnumerator();
				num2 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
				{
					num2 = 3;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static uint U8TfComUx6M(object data, int offset)
	{
		return (uint)(((short[])data)[offset] | (((short[])data)[offset + 1] << 8) | (((short[])data)[offset + 2] << 16));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void yEFfCm7o0ZJ(object stream, uint value)
	{
		((dynamic)(stream)).WriteByte((byte)(value & 0xFF));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void iVmfC7wj8su(object stream, ushort value)
	{
		global::System.Span<byte> span = default(global::System.Span<byte>);
		((global::System.IO.Stream)(stream)).Write(span);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void WqFfCAJOsqy(object stream, N3Mce4f4O1LbsKljGcTC prefixKind, uint value)
	{
		ut4fCBflpP6(stream, value);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void mgUfCIYECmF(object stream, uint value)
	{
		global::System.Span<byte> span = default(global::System.Span<byte>);
		((global::System.IO.Stream)(stream)).Write(span);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void ut4fCBflpP6(object stream, uint value)
	{
		global::System.Span<byte> span = default(global::System.Span<byte>);
		((global::System.IO.Stream)(stream)).Write(span);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void GZ3fCgR9gcD(object stream, uint value)
	{
		((dynamic)(stream)).WriteByte((byte)value);
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		QCefWvai8hU();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void FlDfClRROcZ(string variant, bool reverseSecret, bool secretFirst, ref __c__DisplayClass91_0 P_3, ref __c__DisplayClass91_1 P_4)
	{
		int num = 1;
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				break;
			default:
				return;
			case 1:
				try
				{
					byte[] array = sh6KmlfWoQNMIWAdC2mj.F7MfWKTnB7I(T5ffCFa1903, P_4.publicKeyDer, P_3.saltBytes, reverseSecret, secretFirst);
					int num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
					{
						num2 = 4;
					}
					while (true)
					{
						switch (num2)
						{
						case 2:
							return;
						case 3:
							return;
						default:
							if (num3 == 991)
							{
								num2 = num3;
								break;
							}
							goto case 1;
						case 1:
							upHfCE6U85R.Add((ST9PBRLcw5s1twpPIgr6)new ST9PBRLcw5s1twpPIgr6(string.Concat(P_4.label2, "/", variant), array));
							num2 = 3;
							break;
						case 0:
							if (!P_3.seenSessionKeys.Add(System.Convert.ToBase64String(array)))
							{
								num2 = 2;
								break;
							}
							goto case 1;
						}
					}
				}
				catch
				{
					int num4 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
					{
						num4 = 2;
					}
					while (true)
					{
						switch (num4)
						{
						case 0:
							return;
						}
						if (num5 != 988)
						{
							return;
						}
						num4 = num5;
					}
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void NLFfCd67cfZ(string key3, string? text, ref __c__DisplayClass91_0 P_2)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		__c__DisplayClass91_2 _c__DisplayClass91_ = default(__c__DisplayClass91_2);
		P_2.publicKeys.Add(new KeyValuePair<string, string>(key3, _c__DisplayClass91_.text));
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void I11fCKsa55k(int index, ref __c__DisplayClass99_0 P_1)
	{
		C0bnUBLcdulm1GSDbYP8 c0bnUBLcdulm1GSDbYP = default(C0bnUBLcdulm1GSDbYP8);
		KWU3k1f4uMUKFgICVU5I kWU3k1f4uMUKFgICVU5I = fZqf4rTyIgN.QHefm2iWCsC(c0bnUBLcdulm1GSDbYP.PacketId, c0bnUBLcdulm1GSDbYP.Body, P_1.c2s, preEncryption: false);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool VFD8fKZu0KMUXaQdTHuH()
	{
		return v3XbnIZuc4vGjOahs4gq == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static sNLGTJfWaoJbt7Xwwgik rpyNWeZu8ulcKh5eDGo6()
	{
		return (sNLGTJfWaoJbt7Xwwgik)v3XbnIZuc4vGjOahs4gq;
	}
}
