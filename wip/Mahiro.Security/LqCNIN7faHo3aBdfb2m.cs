using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using DEpkllOxX0SYLtEysJR;
using EOtfAR7ABNkdVw33i8M;
using FmPQGBUV0sfTHbetdiK;
using fDAldojjppXrctUVYOJn;
using knJtsJOEZ9ordiPYxu7;
using rsq4n3UgA8K542GL74j;
using uXZRIQ7H1gCdrF8NnTp;
using zWXEsE7mfOFu8Q9MvyQ;

namespace todNS07L1BTskuVuFU3;

sealed class LqCNIN7faHo3aBdfb2m : global::System.IDisposable
{
	private sealed class AZ5lgWf2n3QhiS6tCkVm : IEquatable<AZ5lgWf2n3QhiS6tCkVm>
	{
		[CompilerGenerated]
		private string _Nonce_k__BackingField;

		[CompilerGenerated]
		private noEahMfqfbR1pWAQcB8a _Envelope_k__BackingField;

		internal static object x5hO4i946el0J67dJUYF;

		[CompilerGenerated]
		private global::System.Type EqualityContract
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return System.Type.GetTypeFromHandle(typeof(AZ5lgWf2n3QhiS6tCkVm).TypeHandle);
			}
		}

		public string Nonce
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Nonce_k__BackingField;
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
							_Nonce_k__BackingField = value;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						break;
					}
				}
				while (num == 989);
			}
		}

		public noEahMfqfbR1pWAQcB8a Envelope
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Envelope_k__BackingField;
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
						case 1:
							_Envelope_k__BackingField = value;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 != 0)
							{
								num2 = 0;
							}
							continue;
						case 0:
							return;
						}
						break;
					}
				}
				while (num == 989);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public AZ5lgWf2n3QhiS6tCkVm(string Nonce, noEahMfqfbR1pWAQcB8a Envelope)
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			_Nonce_k__BackingField = Nonce;
			_Envelope_k__BackingField = Envelope;
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
		private bool TlTf2zwUYni(StringBuilder builder)
		{
			int num = 3;
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
								goto case 4;
							}
							(builder).Append("Nonce = ");
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 != 0)
							{
								num3 = 2;
							}
							continue;
						case 3:
							break;
						case 0:
							(builder).Append(Nonce);
							num3 = 4;
							continue;
						case 1:
							(builder).Append(Envelope);
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
							{
								num3 = 2;
							}
							continue;
						case 2:
							return true;
						case 4:
							(builder).Append(", Envelope = ");
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
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
				System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
				num = 3;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 != 0)
				{
					num = 11;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator !=(AZ5lgWf2n3QhiS6tCkVm? left, AZ5lgWf2n3QhiS6tCkVm? right)
		{
			return !(left == right);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator ==(AZ5lgWf2n3QhiS6tCkVm? left, AZ5lgWf2n3QhiS6tCkVm? right)
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
						goto IL_0021;
					case 0:
						return ((AZ5lgWf2n3QhiS6tCkVm)left).Equals((AZ5lgWf2n3QhiS6tCkVm?)right);
					case 2:
						if (left == right)
						{
							return true;
						}
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
						{
							num2 = 1;
						}
						continue;
					case 1:
						break;
					}
					goto IL_0066;
					IL_0021:
					if (num == 990)
					{
						break;
					}
					goto IL_0066;
					IL_0066:
					if (left == null)
					{
						return false;
					}
					num2 = 4;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
					{
						num2 = 0;
					}
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
			return Equals(obj as AZ5lgWf2n3QhiS6tCkVm);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public bool Equals(AZ5lgWf2n3QhiS6tCkVm? other)
		{
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public AZ5lgWf2n3QhiS6tCkVm cSIfqbTENLW()
		{
			return (AZ5lgWf2n3QhiS6tCkVm)new AZ5lgWf2n3QhiS6tCkVm(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private AZ5lgWf2n3QhiS6tCkVm(AZ5lgWf2n3QhiS6tCkVm original)
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public void cuUfqX3FhTE(out string Nonce, out noEahMfqfbR1pWAQcB8a Envelope)
		{
			//IL_0064: Expected I8, but got O
			//IL_003c: Expected I8, but got O
			int num = 2;
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
						Nonce = default;
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
						{
							num2 = 6;
						}
						continue;
					case 0:
						Envelope = default;
						Nonce = default;
						return;
					case 1:
						break;
					}
					goto IL_005c;
					IL_0021:
					if (num == 990)
					{
						break;
					}
					goto IL_005c;
					IL_005c:
					Envelope = default;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
					{
						num2 = 0;
					}
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
								goto case 2;
							}
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
							{
								num3 = 9;
							}
							continue;
						case 1:
							break;
						case 0:
							return;
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
				num = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool IsCu9R94RWeNISA15YOV()
		{
			return x5hO4i946el0J67dJUYF == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static AZ5lgWf2n3QhiS6tCkVm EDykuP94wZuT77yEDcPb()
		{
			return (AZ5lgWf2n3QhiS6tCkVm)x5hO4i946el0J67dJUYF;
		}
	}

	private sealed class noEahMfqfbR1pWAQcB8a
	{
		[CompilerGenerated]
		private int _Version_k__BackingField;

		[CompilerGenerated]
		private long _Timestamp_k__BackingField;

		[CompilerGenerated]
		private string _Nonce_k__BackingField;

		[CompilerGenerated]
		private string _EncryptedKey_k__BackingField;

		[CompilerGenerated]
		private string _Iv_k__BackingField;

		[CompilerGenerated]
		private string _Ciphertext_k__BackingField;

		[CompilerGenerated]
		private string _Tag_k__BackingField;

		[CompilerGenerated]
		private string _Signature_k__BackingField;

		internal static object iDPeHJ94eN8hOAQKaxm2;

		[JsonPropertyName("version")]
		public int Version
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Version_k__BackingField;
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
						case 1:
							_Version_k__BackingField = value;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
							{
								num2 = 2;
							}
							continue;
						case 0:
							return;
						}
						break;
					}
				}
				while (num == 989);
			}
		}

		[JsonPropertyName("timestamp")]
		public long Timestamp
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Timestamp_k__BackingField;
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
						_Timestamp_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
						{
							num2 = 6;
						}
					}
				}
			}
		}

		[JsonPropertyName("nonce")]
		public string Nonce
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Nonce_k__BackingField;
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
						case 1:
							_Nonce_k__BackingField = value;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 != 0)
							{
								num2 = 6;
							}
							continue;
						case 0:
							return;
						}
						break;
					}
				}
				while (num == 989);
			}
		}

		[JsonPropertyName("encrypted_key")]
		public string EncryptedKey
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _EncryptedKey_k__BackingField;
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
						_EncryptedKey_k__BackingField = value;
						num2 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
						{
							num2 = 0;
						}
					}
				}
			}
		}

		[JsonPropertyName("iv")]
		public string Iv
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Iv_k__BackingField;
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
						_Iv_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
						{
							num2 = 5;
						}
					}
				}
			}
		}

		[JsonPropertyName("ciphertext")]
		public string Ciphertext
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Ciphertext_k__BackingField;
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
						_Ciphertext_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
						{
							num2 = 6;
						}
					}
				}
			}
		}

		[JsonPropertyName("tag")]
		public string Tag
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Tag_k__BackingField;
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
						_Tag_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
						{
							num2 = 5;
						}
					}
				}
			}
		}

		[JsonPropertyName("signature")]
		public string Signature
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Signature_k__BackingField;
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
						_Signature_k__BackingField = value;
						num2 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
						{
							num2 = 0;
						}
					}
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		public noEahMfqfbR1pWAQcB8a()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
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
								goto case 2;
							}
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be != 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							return;
						case 2:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
							{
								num3 = 8;
							}
							continue;
						case 1:
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
				num = 9;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool NdrJs894PVIKmfsZpig8()
		{
			return iDPeHJ94eN8hOAQKaxm2 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static noEahMfqfbR1pWAQcB8a BBBXJD94xAEIjYDrsJ19()
		{
			return (noEahMfqfbR1pWAQcB8a)iDPeHJ94eN8hOAQKaxm2;
		}
	}

	sealed class WsUAosfqLqc0TH68f7h0 : global::System.Exception
	{
		private static object kQyZyF94FVsBNXiV2Uan;

		[MethodImpl((MethodImplOptions)8)]
		public WsUAosfqLqc0TH68f7h0(string message)
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 5;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
			{
				num = 0;
			}
			int num2 = default;
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
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be != 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							goto end_IL_000e;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
							{
								num3 = 0;
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
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
				{
					num = 8;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool TwevRO94sAS14nwEL7x1()
		{
			return kQyZyF94FVsBNXiV2Uan == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static WsUAosfqLqc0TH68f7h0 GxEl8U94TFXc4YblFySp()
		{
			return (WsUAosfqLqc0TH68f7h0)kQyZyF94FVsBNXiV2Uan;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_135
	{
		public static __c_135 __9;

		public static Func<char, bool> __9__21_0;

		private static __c_135 O6tpEp94N6qeSMeJYg9u;

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
								goto case 3;
							}
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
							{
								num3 = 5;
							}
							continue;
						case 1:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
							{
								num3 = 0;
							}
							continue;
						case 3:
							__9 = (__c_135)new __c_135();
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
							{
								num3 = 2;
							}
							continue;
						case 4:
							HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
							{
								num3 = 3;
							}
							continue;
						case 2:
							return;
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
				num = 11;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_135()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool im7fqjnxT6g(char character)
		{
			int num = 6;
			bool flag = default;
			bool flag2 = default;
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
							if (num2 != 14)
							{
								if (num2 == 995)
								{
									goto end_IL_0010;
								}
								goto case 0;
							}
							goto IL_00fc;
						case 6:
							flag = char.IsAsciiLetterOrDigit(character);
							num3 = 5;
							continue;
						case 0:
							if (character == '_')
							{
								num = 14;
								break;
							}
							goto case 2;
						case 5:
							if (!flag)
							{
								num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
								{
									num3 = 7;
								}
								continue;
							}
							goto case 7;
						case 1:
							if (character != '-')
							{
								num3 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto IL_00fc;
						case 3:
						case 4:
							flag = flag2;
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 != 0)
							{
								num3 = 7;
							}
							continue;
						case 7:
							return !flag;
						case 2:
							{
								flag2 = false;
								num3 = 3;
								continue;
							}
							IL_00fc:
							flag2 = true;
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
		internal static bool bddHUG94MQyuWolWeBTn()
		{
			return O6tpEp94N6qeSMeJYg9u == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_135 IKaeAY94pTT2gqiSfiGy()
		{
			return O6tpEp94N6qeSMeJYg9u;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _GetRandomRealNameAsync_d__9 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<nNU9JoUBxAhVHRZ6PhH> __t__builder;

		public LqCNIN7faHo3aBdfb2m __4__this;

		public CancellationToken cancellationToken;

		private X509Certificate2 _certificate_5__2;

		private RSA _clientPrivateKey_5__3;

		private RSA _serverPublicKey_5__4;

		private int _attempt_5__5;

		private ConfiguredTaskAwaitable<nNU9JoUBxAhVHRZ6PhH>.ConfiguredTaskAwaiter __u__1;

		internal static object ShxRiy94u0IQ6QakY6la;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_054f: Expected O, but got Unknown
			//IL_0909: Expected O, but got Unknown
			//IL_0787: Unknown result type (might be due to invalid IL or missing references)
			//IL_0793: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a4: Expected O, but got Ref
			//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_072f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0731: Unknown result type (might be due to invalid IL or missing references)
			//IL_071d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0722: Unknown result type (might be due to invalid IL or missing references)
			//IL_0743: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d2d->IL0cf4: Incompatible stack heights: 0 vs 2
			//IL_0cf8->IL0cf8: Incompatible stack heights: 3 vs 1
			//IL_0e1d->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0e28->IL0010: Incompatible stack heights: 3 vs 1
			//IL_061c->IL0639: Incompatible stack heights: 1 vs 2
			//IL_066e->IL0778: Incompatible stack heights: 1 vs 0
			//IL_0627->IL0639: Incompatible stack heights: 1 vs 2
			int num = 6;
			LqCNIN7faHo3aBdfb2m lqCNIN7faHo3aBdfb2m = default;
			int num4 = default;
			int num7 = default;
			int num10 = default;
			int num34 = default;
			int num14 = default;
			int num13 = default;
			int num26 = default;
			int num28 = default;
			int num30 = default;
			int num17 = default;
			ConfiguredTaskAwaitable<nNU9JoUBxAhVHRZ6PhH>.ConfiguredTaskAwaiter _u__ = default;
			ConfiguredTaskAwaitable<nNU9JoUBxAhVHRZ6PhH> val = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num18);
			OperationCanceledException ex2 = default;
			int num19 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			int num21 = default;
			global::System.Exception ex = default;
			int num23 = default;
			int num25 = default;
			int num33 = default;
			int num36 = default;
			int num38 = default;
			int num40 = default;
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
							if (num2 != 14)
							{
								if (num2 == 995)
								{
									goto end_IL_0010;
								}
								goto case 5;
							}
							_serverPublicKey_5__4 = null;
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
							{
								num3 = 0;
							}
							continue;
						case 4:
							_certificate_5__2 = null;
							num3 = 7;
							continue;
						case 5:
							lqCNIN7faHo3aBdfb2m = __4__this;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
							{
								num3 = 1;
							}
							continue;
						case 7:
							break;
						case 3:
							__1__state = -2;
							num3 = 13;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
							{
								num3 = 4;
							}
							continue;
						case 1:
							try
							{
								int num5;
								if (num4 == 0)
								{
									num5 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
									{
										num5 = 4;
									}
									goto IL_013a;
								}
								goto IL_01ac;
								IL_013a:
								while (true)
								{
									switch (num5)
									{
									default:
										if (num7 != 11)
										{
											if (num7 == 991)
											{
												goto IL_0136;
											}
											goto case 3;
										}
										try
										{
											int num8;
											if (num4 == 0)
											{
												num8 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
												{
													num8 = 0;
												}
												goto IL_0222;
											}
											goto IL_0258;
											IL_0258:
											lqCNIN7faHo3aBdfb2m.UyN7cq76gS(_certificate_5__2);
											int num9 = 11;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 != 0)
											{
												num9 = 11;
											}
											num10 = num9;
											goto IL_021e;
											IL_021e:
											num8 = num10;
											goto IL_0222;
											IL_0222:
											while (true)
											{
												switch (num8)
												{
												case 1:
													goto end_IL_0222;
												case 0:
												case 3:
													num8 = 2;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
													{
														num8 = 3;
													}
													continue;
												case 2:
													goto IL_0318;
												}
												if (num10 != 11)
												{
													if (num10 == 991)
													{
														goto IL_021e;
													}
													goto IL_0318;
												}
												_clientPrivateKey_5__3 = System.Security.Cryptography.X509Certificates.RSACertificateExtensions.GetRSAPrivateKey(_certificate_5__2) ?? throw "pp 客户端证书不包含 RSA 私钥。";
												num8 = 3;
												continue;
												IL_0318:
												try
												{
													int num11;
													if (num4 == 0)
													{
														num11 = 2;
														goto IL_033b;
													}
													goto IL_0363;
													IL_0363:
													_serverPublicKey_5__4 = System.Security.Cryptography.RSA.Create();
													num11 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
													{
														num11 = 1;
													}
													goto IL_033b;
													IL_033b:
													while (true)
													{
														switch (num11)
														{
														default:
															if (num34 == 991)
															{
																num11 = num34;
																continue;
															}
															goto case 1;
														case 0:
															break;
														case 1:
														case 2:
															num11 = 3;
															continue;
														case 3:
															try
															{
																int num12;
																if (num4 != 0)
																{
																	num12 = 9;
																	goto IL_03e5;
																}
																goto IL_0a09;
																IL_0a09:
																num12 = 6;
																goto IL_03e5;
																IL_03e5:
																while (true)
																{
																	switch (num12)
																	{
																	default:
																		if (num14 != 18)
																		{
																			if (num14 == 998)
																			{
																				goto IL_03e1;
																			}
																			goto case 9;
																		}
																		num13 = _attempt_5__5;
																		num12 = 8;
																		continue;
																	case 3:
																	{
																		_ = _attempt_5__5;
																		int num31 = 6;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
																		{
																			num31 = 18;
																		}
																		num14 = num31;
																		goto IL_03e1;
																	}
																	case 5:
																		try
																		{
																			(_serverPublicKey_5__4).ImportSubjectPublicKeyInfo((global::System.ReadOnlySpan<byte>)((T9NRUa7oe4cROQ25AsM)lqCNIN7faHo3aBdfb2m.Ymn7Cr63rZ).ServerPublicKeySpki, ref num26);
																			int num27 = 1;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 != 0)
																			{
																				num27 = 0;
																			}
																			while (true)
																			{
																				switch (num27)
																				{
																				default:
																					if (num28 == 990)
																					{
																						num27 = num28;
																						continue;
																					}
																					break;
																				case 0:
																					if (num26 == ((T9NRUa7oe4cROQ25AsM)lqCNIN7faHo3aBdfb2m.Ymn7Cr63rZ).ServerPublicKeySpki.Length)
																					{
																						num27 = 1;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
																						{
																							num27 = 0;
																						}
																						continue;
																					}
																					break;
																				case 1:
																					if ((_serverPublicKey_5__4).KeySize != 3072)
																					{
																						num27 = 2;
																						continue;
																					}
																					goto end_IL_04ae;
																				case 2:
																					break;
																				}
																				throw new global::System.Exception("pp 服务端公钥无效。");
																				continue;
																				end_IL_04ae:
																				break;
																			}
																		}
																		catch (CryptographicException ex4)
																		{
																			CryptographicException ex5 = ex4;
																			int num29 = 4;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
																			{
																				num29 = 0;
																			}
																			while (true)
																			{
																				switch (num29)
																				{
																				default:
																					if (num30 == 988)
																					{
																						goto IL_057c;
																					}
																					break;
																				case 0:
																					break;
																				}
																				break;
																				IL_057c:
																				num29 = num30;
																			}
																			_ = "pp 服务端公钥无效。";
																			throw ex5;
																		}
																		goto case 7;
																	case 9:
																		num12 = 2;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
																		{
																			num12 = 5;
																		}
																		continue;
																	case 6:
																		try
																		{
																			if (num4 == 0)
																			{
																				_ = 10;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
																				{
																					_ = 7;
																				}
																				goto IL_0639;
																			}
																			goto IL_0778;
																			IL_0639:
																			int num15;
																			while (true)
																			{
																				int num16;
																				switch (num15)
																				{
																				default:
																					if (num17 != 19)
																					{
																						if (num17 == 999)
																						{
																							goto IL_0635;
																						}
																						goto case 11;
																					}
																					return;
																				case 5:
																					num4 = (__1__state = 0);
																					num16 = 4;
																					goto IL_0631;
																				case 3:
																					__u__1 = default;
																					num15 = 12;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
																					{
																						num15 = 0;
																					}
																					continue;
																				case 6:
																					if (&_u__ == null)
																					{
																						num15 = 5;
																						continue;
																					}
																					goto case 2;
																				case 8:
																					__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<nNU9JoUBxAhVHRZ6PhH>.ConfiguredTaskAwaiter, _GetRandomRealNameAsync_d__9>(ref _u__, ref this);
																					num16 = 19;
																					goto IL_0631;
																				case 7:
																				case 9:
																					_u__ = __u__1;
																					num15 = 3;
																					continue;
																				case 4:
																					__u__1 = _u__;
																					num15 = 8;
																					continue;
																				case 11:
																					_u__ = val;
																					num15 = 6;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
																					{
																						num15 = 11;
																					}
																					continue;
																				case 0:
																					num4 = (__1__state = -1);
																					num15 = 2;
																					continue;
																				case 1:
																					break;
																				case 2:
																				{
																					nNU9JoUBxAhVHRZ6PhH nNU9JoUBxAhVHRZ6PhH = (nNU9JoUBxAhVHRZ6PhH)(&_u__);
																					num15 = 10;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
																					{
																						num15 = 18;
																					}
																					continue;
																				}
																				case 10:
																					goto end_IL_0639;
																					IL_0635:
																					num15 = num17;
																					continue;
																					IL_0631:
																					num17 = num16;
																					goto IL_0635;
																				}
																				goto IL_0778;
																				continue;
																				end_IL_0639:
																				break;
																			}
																			goto end_IL_0601;
																			IL_0778:
																			lqCNIN7faHo3aBdfb2m.kmT79R5BgA(_clientPrivateKey_5__3, _serverPublicKey_5__4, cancellationToken);
																			val = (ConfiguredTaskAwaitable<nNU9JoUBxAhVHRZ6PhH>)0;
																			num15 = 11;
																			goto IL_0639;
																			end_IL_0601:;
																		}
																		catch (object obj) when (((Func<bool>)delegate
																		{
																			// Could not convert BlockContainer to single expression
																			obj2 = ((obj is OperationCanceledException) ? obj : null);
																			if (obj2 == null)
																			{
																				num18 = 4;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
																				{
																					num18 = 0;
																				}
																			}
																			else
																			{
																				ex2 = (OperationCanceledException)obj2;
																				num18 = 7;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
																				{
																					num18 = 1;
																				}
																			}
																			while (true)
																			{
																				switch (num18)
																				{
																				default:
																					if (num19 == 989)
																					{
																						goto IL_082a;
																					}
																					goto case 1;
																				case 0:
																					result = 0;
																					break;
																				case 1:
																					result = ((!(cancellationToken).IsCancellationRequested) ? 1 : 0);
																					break;
																				}
																				break;
																				IL_082a:
																				num18 = num19;
																			}
																			return (byte)result != 0;
																		}).Invoke())
																		{
																			int num20 = 7;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
																			{
																				num20 = 0;
																			}
																			while (true)
																			{
																				switch (num20)
																				{
																				case 1:
																					goto end_IL_08bf;
																				default:
																					if (num21 == 989)
																					{
																						num20 = num21;
																						continue;
																					}
																					break;
																				case 0:
																					break;
																				}
																				ex = (global::System.Exception)(object)ex2;
																				num20 = 5;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
																				{
																					num20 = 1;
																				}
																				continue;
																				end_IL_08bf:
																				break;
																			}
																			goto case 3;
																		}
																		catch (HttpRequestException ex3)
																		{
																			ex = (global::System.Exception)ex3;
																			int num22 = 2;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
																			{
																				num22 = 0;
																			}
																			while (true)
																			{
																				switch (num22)
																				{
																				case 0:
																					break;
																				default:
																					if (num23 == 988)
																					{
																						num22 = num23;
																						continue;
																					}
																					break;
																				}
																				break;
																			}
																			goto case 3;
																		}
																		catch (WsUAosfqLqc0TH68f7h0 wsUAosfqLqc0TH68f7h)
																		{
																			ex = wsUAosfqLqc0TH68f7h;
																			int num24 = 5;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
																			{
																				num24 = 0;
																			}
																			while (true)
																			{
																				switch (num24)
																				{
																				case 0:
																					break;
																				default:
																					if (num25 == 988)
																					{
																						num24 = num25;
																						continue;
																					}
																					break;
																				}
																				break;
																			}
																			goto case 3;
																		}
																		goto end_IL_03e5;
																	case 0:
																	case 10:
																		if (_attempt_5__5 >= 2)
																		{
																			num12 = 4;
																			continue;
																		}
																		break;
																	case 8:
																		_attempt_5__5 = num13 + 1;
																		num12 = 5;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
																		{
																			num12 = 0;
																		}
																		continue;
																	case 2:
																		_attempt_5__5 = 0;
																		num12 = 10;
																		continue;
																	case 1:
																		break;
																	case 7:
																		ex = null;
																		num12 = 2;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
																		{
																			num12 = 14;
																		}
																		continue;
																	case 4:
																		{
																			_ = "pp 请求失败，请稍后重试。";
																			throw ex;
																		}
																		IL_03e1:
																		num12 = num14;
																		continue;
																	}
																	goto IL_0a09;
																	continue;
																	end_IL_03e5:
																	break;
																}
															}
															finally
															{
																if (num4 < 0)
																{
																	int num32 = 3;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
																	{
																		num32 = 3;
																	}
																	while (true)
																	{
																		switch (num32)
																		{
																		default:
																			if (num33 == 991)
																			{
																				num32 = num33;
																				continue;
																			}
																			goto end_IL_0aca;
																		case 3:
																			if (_serverPublicKey_5__4 == null)
																			{
																				num32 = 1;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
																				{
																					num32 = 1;
																				}
																				continue;
																			}
																			break;
																		case 2:
																			break;
																		case 1:
																			goto end_IL_0aca;
																		case 0:
																			goto end_IL_0aca;
																		}
																		(_serverPublicKey_5__4).Dispose();
																		num32 = 3;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 != 0)
																		{
																			num32 = 0;
																		}
																		continue;
																		end_IL_0aca:
																		break;
																	}
																}
															}
															goto end_IL_033b;
														}
														goto IL_0363;
														continue;
														end_IL_033b:
														break;
													}
												}
												finally
												{
													if (num4 < 0)
													{
														int num35 = 3;
														while (true)
														{
															switch (num35)
															{
															default:
																if (num36 == 991)
																{
																	num35 = num36;
																	continue;
																}
																goto end_IL_0b7f;
															case 3:
																if (_clientPrivateKey_5__3 == null)
																{
																	num35 = 6;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
																	{
																		num35 = 0;
																	}
																	continue;
																}
																break;
															case 1:
																break;
															case 0:
																goto end_IL_0b7f;
															case 2:
																goto end_IL_0b7f;
															}
															(_clientPrivateKey_5__3).Dispose();
															num35 = 2;
															continue;
															end_IL_0b7f:
															break;
														}
													}
												}
												goto end_IL_01ea;
												continue;
												end_IL_0222:
												break;
											}
											goto IL_0258;
											end_IL_01ea:;
										}
										finally
										{
											int num37;
											if (num4 >= 0)
											{
												num37 = 2;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
												{
													num37 = 6;
												}
												goto IL_0c49;
											}
											goto IL_0c71;
											IL_0c49:
											while (true)
											{
												switch (num37)
												{
												default:
													if (num38 == 991)
													{
														num37 = num38;
														continue;
													}
													goto end_IL_0c49;
												case 3:
													break;
												case 2:
													goto end_IL_0c49;
												case 0:
													(_certificate_5__2).Dispose();
													num37 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
													{
														num37 = 8;
													}
													continue;
												case 1:
													goto end_IL_0c49;
												}
												goto IL_0c71;
												continue;
												end_IL_0c49:
												break;
											}
											goto end_IL_0c10;
											IL_0c71:
											if (_certificate_5__2 != null)
											{
												num37 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
												{
													num37 = 4;
												}
												goto IL_0c49;
											}
											end_IL_0c10:;
										}
										goto end_IL_013a;
									case 3:
										_certificate_5__2 = (X509Certificate2)(object)lqCNIN7faHo3aBdfb2m.pir7hPTBA4;
										num5 = 2;
										continue;
									case 0:
										break;
									case 1:
									case 2:
										{
											int num6 = 5;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e != 0)
											{
												num6 = 11;
											}
											num7 = num6;
											goto IL_0136;
										}
										IL_0136:
										num5 = num7;
										continue;
									}
									goto IL_01ac;
									continue;
									end_IL_013a:
									break;
								}
								goto end_IL_0102;
								IL_01ac:
								System.ObjectDisposedException.ThrowIf(lqCNIN7faHo3aBdfb2m.YjN7rEA51g, lqCNIN7faHo3aBdfb2m);
								num5 = 3;
								goto IL_013a;
								end_IL_0102:;
							}
							catch (global::System.Exception)
							{
								int num39 = 3;
								while (true)
								{
									switch (num39)
									{
									default:
										switch (num40)
										{
										case 992:
											goto end_IL_0cf8;
										case 12:
											return;
										}
										goto case 4;
									case 0:
										_serverPublicKey_5__4 = null;
										num39 = 11;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
										{
											num39 = 2;
										}
										break;
									case 4:
										_certificate_5__2 = null;
										num39 = 10;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
										{
											num39 = 1;
										}
										break;
									case 2:
										_ = __t__builder;
										num40 = 12;
										break;
									case 1:
										_clientPrivateKey_5__3 = null;
										num39 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
										{
											num39 = 9;
										}
										break;
									case 3:
										{
											__1__state = -2;
											num39 = 4;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
											{
												num39 = 6;
											}
											break;
										}
										end_IL_0cf8:
										break;
									}
								}
							}
							goto case 3;
						case 2:
							return;
						case 6:
							num4 = __1__state;
							num3 = 5;
							continue;
						case 0:
							_ = __t__builder;
							_ = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
							{
								_ = 2;
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
				_clientPrivateKey_5__3 = null;
				num = 14;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
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
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 != 0)
							{
								num3 = 4;
							}
							continue;
						case 2:
							break;
						case 1:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
							{
								num3 = 1;
							}
							continue;
						case 0:
							return;
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
				num = 5;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool ohlGgm94aDibO8llntbX()
		{
			return ShxRiy94u0IQ6QakY6la == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object FkCXMn941hgUNQ1BBQWR()
		{
			return ShxRiy94u0IQ6QakY6la;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _SendOnceAsync_d__11 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<nNU9JoUBxAhVHRZ6PhH> __t__builder;

		public LqCNIN7faHo3aBdfb2m __4__this;

		public RSA clientPrivateKey;

		public RSA serverPublicKey;

		public CancellationToken cancellationToken;

		private AZ5lgWf2n3QhiS6tCkVm _requestData_5__2;

		private HttpRequestMessage _request_5__3;

		private HttpResponseMessage _response_5__4;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter __u__2;

		private static object NfYXQ9943RO7qkXJ0HDH;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
		// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
		// semantics of this body (see MAHIRO-V2-BUILD.md).
		throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			int num = 1;
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
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
							{
								num3 = 2;
							}
							continue;
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							return;
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
				num = 9;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool OhkMZW94vMWmdlYbiwcn()
		{
			return NfYXQ9943RO7qkXJ0HDH == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object U88mTI94ElSrXdd9S4T5()
		{
			return NfYXQ9943RO7qkXJ0HDH;
		}
	}

	private readonly object Ymn7Cr63rZ;

	private readonly object pFi74erXRl;

	private readonly Func<X509Certificate2> pir7hPTBA4;

	private readonly bool xi27USL2ji;

	private bool YjN7rEA51g;

	private static object tTWBw9Z8Oo0P5V1IBJMA;

	[MethodImpl((MethodImplOptions)8)]
	public LqCNIN7faHo3aBdfb2m()
	{
		//IL_0053: Expected I4, but got O
		//IL_0038->IL004a: Incompatible stack types: I4 vs O
		//IL_0043->IL004a: Incompatible stack types: I4 vs O
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		LqCNIN7faHo3aBdfb2m(UjWwWv77go4h1O35kEG.Load(), null);
		object obj = 0;
		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
		{
			obj = 5;
		}
		object obj2 = default;
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
	internal LqCNIN7faHo3aBdfb2m(T9NRUa7oe4cROQ25AsM options, HttpClient? httpClient, Func<X509Certificate2>? certificateProvider = null)
	{
		//IL_000a->IL000a: Incompatible stack heights: 1 vs 2
		if (httpClient == null)
		{
		}
		pFi74erXRl = httpClient;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public unsafe global::System.Threading.Tasks.Task<nNU9JoUBxAhVHRZ6PhH> qkt7jcNNqG(CancellationToken cancellationToken = default(CancellationToken))
	{
		object obj = default;
		obj.__4__this = this;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void PB67ZqMIbo()
	{
		//IL_000c: Expected O, but got I4
		//IL_0025: Expected I4, but got O
		//IL_00af->IL0010: Incompatible stack types: I4 vs O
		//IL_0087->IL0010: Incompatible stack types: I4 vs O
		//IL_00ba->IL0010: Incompatible stack types: I4 vs O
		//IL_0092->IL0010: Incompatible stack types: I4 vs O
		object obj = 2;
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
					return;
				case 2:
					System.ObjectDisposedException.ThrowIf(YjN7rEA51g, this);
					obj2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
					{
						obj2 = 7;
					}
					break;
				case 3:
					return;
				case 1:
				{
					object obj3 = uFM7YxbY7j();
					obj2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
					{
						obj2 = 4;
					}
					break;
				}
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe global::System.Threading.Tasks.Task<nNU9JoUBxAhVHRZ6PhH> kmT79R5BgA(RSA clientPrivateKey, RSA serverPublicKey, CancellationToken cancellationToken)
	{
		object obj = default;
		obj.__4__this = this;
		((AsyncTaskMethodBuilder<aS1f1nOvDvWmiknaRRQ>*)2)->AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<HashSet<string>>.ConfiguredTaskAwaiter, pMK19YOP7RWRqnrmhaw._CheckAsync_d__5_1>(ref *(ConfiguredTaskAwaitable<HashSet<string>>.ConfiguredTaskAwaiter*)(&obj.__t__builder), ref *(pMK19YOP7RWRqnrmhaw._CheckAsync_d__5_1*)(&obj));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private AZ5lgWf2n3QhiS6tCkVm Hy67DSDB0v(RSA clientPrivateKey, RSA serverPublicKey)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe nNU9JoUBxAhVHRZ6PhH eK47kA8677(byte[] responseBytes, string requestNonce, RSA clientPrivateKey, RSA serverPublicKey)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		object obj = (object)default(TaskCompletionSource<>);
		(obj).AllowTrailingCommas = false;
		(obj).CommentHandling = (JsonCommentHandling)0;
		(obj).MaxDepth = 32;
		object obj2 = System.Text.Json.JsonDocument.Parse((ReadOnlyMemory<byte>)responseBytes, (JsonDocumentOptions)obj);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static nNU9JoUBxAhVHRZ6PhH o1k7Vtw986(object plaintext)
	{
		//IL_000c: Expected O, but got I4
		//IL_0021: Expected I4, but got O
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Invalid comparison between Unknown and I4
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Invalid comparison between Unknown and I4
		//IL_013d: Expected O, but got I4
		//IL_03c7: Expected O, but got I4
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_00f4: Expected O, but got I4
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Invalid comparison between Unknown and I4
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Invalid comparison between Unknown and I4
		//IL_0255: Expected O, but got I4
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Invalid comparison between Unknown and I4
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Invalid comparison between Unknown and I4
		//IL_0053: Expected O, but got I4
		//IL_00bc: Expected I4, but got O
		//IL_004d->IL0057: Incompatible stack types: I4 vs O
		//IL_0593->IL0010: Incompatible stack types: I4 vs O
		//IL_059e->IL0010: Incompatible stack types: I4 vs O
		//IL_0147->IL0057: Incompatible stack types: I4 vs O
		//IL_03db->IL0057: Incompatible stack types: I4 vs O
		//IL_01a8->IL0057: Incompatible stack types: I4 vs O
		//IL_00fe->IL0057: Incompatible stack types: I4 vs O
		//IL_025f->IL0057: Incompatible stack types: I4 vs O
		//IL_00f1->IL0057: Incompatible stack types: I4 vs O
		//IL_03bd->IL0057: Incompatible stack types: I4 vs O
		//IL_0186->IL0057: Incompatible stack types: I4 vs O
		//IL_0374->IL0057: Incompatible stack types: I4 vs O
		//IL_03e6->IL0057: Incompatible stack types: I4 vs O
		//IL_01b3->IL0057: Incompatible stack types: I4 vs O
		//IL_0124->IL0057: Incompatible stack types: I4 vs O
		//IL_0327->IL0057: Incompatible stack types: I4 vs O
		//IL_0358->IL0057: Incompatible stack types: I4 vs O
		//IL_0385->IL0057: Incompatible stack types: I4 vs O
		//IL_042d->IL0057: Incompatible stack types: I4 vs O
		//IL_048d->IL0057: Incompatible stack types: I4 vs O
		//IL_012f->IL0057: Incompatible stack types: I4 vs O
		//IL_0332->IL0057: Incompatible stack types: I4 vs O
		//IL_0363->IL0057: Incompatible stack types: I4 vs O
		//IL_0498->IL0057: Incompatible stack types: I4 vs O
		//IL_028a->IL0057: Incompatible stack types: I4 vs O
		object obj = 2;
		object obj4 = default;
		object obj15 = default;
		object obj17 = default;
		object obj14 = default;
		object obj10 = default;
		object obj7 = default;
		object obj12 = default;
		object obj9 = default;
		object obj13 = default;
		object obj16 = default;
		object obj8 = default;
		object result = default;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					goto IL_0021;
				case 1:
				{
					object obj5 = (obj4).RootElement;
					object obj6 = 23;
					while (true)
					{
						int num;
						object name;
						object obj11;
						string text;
						object idCard;
						object realNameInfo;
						switch ((int)obj6)
						{
						default:
							if ((nint)obj15 != 31)
							{
								if ((nint)obj15 != 1011)
								{
									break;
								}
								goto IL_0053;
							}
							if ((int)(obj17).ValueKind != 3)
							{
								num = 2;
								goto IL_004f;
							}
							name = (obj17).GetString();
							goto IL_04a4;
						case 4:
							if (obj14 - 5 > 1)
							{
								obj6 = 14;
								continue;
							}
							goto case 15;
						case 15:
							obj10 = 1;
							obj6 = 18;
							continue;
						case 17:
							if ((int)(obj7).ValueKind != 1)
							{
								obj6 = 16;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
								{
									obj6 = 1;
								}
								continue;
							}
							if ((obj7).TryGetProperty("RNAME", ref obj17))
							{
								num = 31;
								goto IL_004f;
							}
							goto case 2;
						case 8:
						case 18:
							obj12 = obj10 == null;
							obj6 = 10;
							continue;
						case 0:
						case 3:
							obj11 = null;
							goto IL_03f2;
						case 9:
							if ((obj5).TryGetProperty("error", ref obj9))
							{
								obj6 = 7;
								continue;
							}
							goto case 0;
						case 13:
							obj14 = (obj13).ValueKind;
							obj6 = 12;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
							{
								obj6 = 4;
							}
							continue;
						case 6:
							throw new global::System.Exception("pp 业务响应缺少状态。");
						case 20:
							text = "pp 返回业务错误。";
							goto IL_0449;
						case 23:
							obj12 = !(obj5).TryGetProperty("success", ref obj13);
							obj6 = 22;
							continue;
						case 5:
							throw new global::System.Exception("pp 返回的 px 格式无效。");
						case 1:
							throw new global::System.Exception("pp 业务响应缺少人员数据。");
						case 19:
							if (!(obj9).TryGetProperty("code", ref obj16))
							{
								obj6 = 28;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
								{
									obj6 = 3;
								}
								continue;
							}
							goto case 21;
						case 21:
							if ((int)(obj16).ValueKind != 3)
							{
								obj6 = 28;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
								{
									obj6 = 0;
								}
								continue;
							}
							obj11 = (obj16).GetString();
							goto IL_03f2;
						case 10:
							if (obj12 == null)
							{
								if ((obj13).GetBoolean())
								{
									num = 16;
									goto IL_004f;
								}
								goto case 9;
							}
							obj6 = 6;
							continue;
						case 22:
							if (obj12 == null)
							{
								obj6 = 13;
								continue;
							}
							goto case 10;
						case 7:
							if ((int)(obj9).ValueKind == 1)
							{
								obj6 = 19;
								continue;
							}
							goto case 0;
						case 2:
							name = null;
							goto IL_04a4;
						case 11:
						case 14:
							obj10 = 0;
							obj6 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
							{
								obj6 = 1;
							}
							continue;
						case 16:
							if ((obj5).TryGetProperty("data", ref obj7))
							{
								obj6 = 17;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
								{
									obj6 = 8;
								}
								continue;
							}
							goto case 1;
						case 12:
							break;
							IL_04a4:
							idCard = (((obj7).TryGetProperty("IDNO", ref obj8) && (int)(obj8).ValueKind == 3) ? (obj8).GetString() : null);
							if (gWSHg1UkPML7xtmFg3Q.c89UYA378p(name, idCard, out realNameInfo))
							{
								result = realNameInfo;
								obj6 = 12;
								continue;
							}
							num = 5;
							goto IL_004f;
							IL_03f2:
							if (!string.Equals((string)obj11, "NO_DATA", (StringComparison)4))
							{
								obj6 = 20;
								continue;
							}
							text = "pp 当前没有可用 px。";
							goto IL_0449;
							IL_0053:
							obj6 = obj15;
							continue;
							IL_0449:
							throw text;
							IL_004f:
							obj15 = num;
							goto IL_0053;
						}
						break;
					}
					break;
				}
				case 2:
				{
					object obj3 = (object)default(TaskCompletionSource<>);
					(obj3).AllowTrailingCommas = false;
					(obj3).CommentHandling = (JsonCommentHandling)0;
					(obj3).MaxDepth = 32;
					obj4 = System.Text.Json.JsonDocument.Parse((ReadOnlyMemory<byte>)plaintext, (JsonDocumentOptions)obj3);
					obj2 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
					{
						obj2 = 1;
					}
					continue;
				}
				case 0:
					break;
				}
				goto IL_059e;
				IL_0021:
				if ((nint)obj == 990)
				{
					break;
				}
				goto IL_059e;
				IL_059e:
				return (nNU9JoUBxAhVHRZ6PhH)result;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private X509Certificate2 uFM7YxbY7j()
	{
		//IL_000c: Expected O, but got I4
		//IL_0029: Expected I4, but got O
		//IL_0082->IL0010: Incompatible stack types: I4 vs O
		//IL_00af->IL0010: Incompatible stack types: I4 vs O
		//IL_00ba->IL0010: Incompatible stack types: I4 vs O
		//IL_00d2->IL0010: Incompatible stack types: I4 vs O
		int num = 4;
		object obj4 = default;
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
							goto case 0;
						}
						akYcBq7KDDkcIVTJT66.hYg7tvgmZr(Ymn7Cr63rZ);
						obj2 = 2;
						continue;
					case 3:
						if (obj4 == null)
						{
							break;
						}
						goto case 1;
					case 4:
						obj4 = Nqe7SkPPXh();
						obj2 = 3;
						continue;
					case 2:
					{
						X509Certificate2? obj3 = Nqe7SkPPXh();
						if (obj3 == null)
						{
							obj2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
							{
								obj2 = 0;
							}
							continue;
						}
						return obj3;
					}
					case 1:
						return (X509Certificate2)obj4;
					case 0:
						throw string.Concat("pp 客户端证书自动安装后仍无法从 Windows 当前用户证书存储读取：", ((T9NRUa7oe4cROQ25AsM)Ymn7Cr63rZ).CertificateSubject);
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
			num = 11;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
			{
				num = 11;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private X509Certificate2? Nqe7SkPPXh()
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return default(X509Certificate2);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UyN7cq76gS(X509Certificate2 certificate)
	{
		System.ArgumentNullException.ThrowIfNull(certificate, "certificate");
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static string jEc70U4lck(JsonElement root, object propertyName)
	{
		//IL_000c: Expected O, but got I4
		//IL_0031: Expected I4, but got O
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_0101->IL0010: Incompatible stack types: I4 vs O
		//IL_006e->IL0010: Incompatible stack types: I4 vs O
		//IL_008c->IL0010: Incompatible stack types: I4 vs O
		//IL_010c->IL0010: Incompatible stack types: I4 vs O
		//IL_0153->IL0010: Incompatible stack types: I4 vs O
		int num = 6;
		object obj3 = default;
		object obj4 = default;
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
						if ((obj3).Length <= 65536)
						{
							obj2 = 4;
							continue;
						}
						goto case 2;
					case 0:
						if ((int)(obj4).ValueKind != 3)
						{
							obj2 = 3;
							continue;
						}
						obj3 = (obj4).GetString();
						obj2 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
						{
							obj2 = 1;
						}
						continue;
					case 6:
						if (!(root).TryGetProperty((string)propertyName, out obj4))
						{
							obj2 = 5;
							continue;
						}
						goto case 0;
					case 2:
						throw string.Concat("pp 响应字段无效：", (string)propertyName);
					case 4:
						return (string)obj3;
					case 3:
					case 5:
						throw string.Concat("pp 响应缺少字段：", (string)propertyName);
					case 1:
						if (!string.IsNullOrWhiteSpace((string)obj3))
						{
							break;
						}
						goto case 2;
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
			num = 13;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] IrF78QBD92(params string[] values)
	{
		return (System.Text.Encoding.UTF8).GetBytes(string.Join('\n', values));
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string AXc7yhWHa9(global::System.ReadOnlySpan<byte> value)
	{
		return (((System.Convert.ToBase64String(value, (Base64FormattingOptions)0)).TrimEnd('=')).Replace('+', '-')).Replace('/', '_');
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] FUj7W3DSBZ(object value, object fieldName)
	{
		object obj = (obj).PadRight((obj).Length + (4 - (obj).Length % 4) % 4, '=');
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_000c: Expected O, but got I4
		//IL_0029: Expected I4, but got O
		//IL_0080->IL0010: Incompatible stack types: I4 vs O
		//IL_00d5->IL0010: Incompatible stack types: I4 vs O
		//IL_00ab->IL0010: Incompatible stack types: I4 vs O
		//IL_008b->IL0010: Incompatible stack types: I4 vs O
		//IL_00e0->IL0010: Incompatible stack types: I4 vs O
		//IL_00b6->IL0010: Incompatible stack types: I4 vs O
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
						if ((nint)obj == 11)
						{
							return;
						}
						goto end_IL_0010;
					case 4:
						break;
					case 0:
						return;
					case 1:
						YjN7rEA51g = true;
						obj2 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
						{
							obj2 = 11;
						}
						continue;
					case 3:
						if (!xi27USL2ji)
						{
							return;
						}
						obj2 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
						{
							obj2 = 2;
						}
						continue;
					case 2:
						if (YjN7rEA51g)
						{
							return;
						}
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
						{
							obj2 = 1;
						}
						continue;
					}
					goto end_IL_000c;
					continue;
					end_IL_0010:
					break;
				}
				if ((nint)obj != 992)
				{
					return;
				}
				continue;
				end_IL_000c:
				break;
			}
			(pFi74erXRl).Dispose();
			num = 11;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_000e: Expected O, but got I4
		//IL_0023: Expected I4, but got O
		//IL_0081->IL0012: Incompatible stack types: I4 vs O
		//IL_005d->IL0012: Incompatible stack types: I4 vs O
		//IL_008c->IL0012: Incompatible stack types: I4 vs O
		//IL_0068->IL0012: Incompatible stack types: I4 vs O
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
						if ((nint)obj != 9)
						{
							if ((nint)obj == 990)
							{
								goto end_IL_0012;
							}
							goto case 2;
						}
						return;
					case 2:
						obj2 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
						{
							obj2 = 1;
						}
						continue;
					case 1:
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
						{
							obj2 = 4;
						}
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
			num = 8;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool OAtnB7Z854UnEL0SlHfd()
	{
		return tTWBw9Z8Oo0P5V1IBJMA == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static LqCNIN7faHo3aBdfb2m cF4DBAZ86waM0MFvfpAW()
	{
		return (LqCNIN7faHo3aBdfb2m)tTWBw9Z8Oo0P5V1IBJMA;
	}
}
