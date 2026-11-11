using System;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using Microsoft.Win32.SafeHandles;
using eSnvSk4QPk5P8PMlYpC;
using fDAldojjppXrctUVYOJn;
using lohC93f5UaygTd8U978I;
using o77FSD4oMGHGbl44MPR;

namespace LEXZsB4Yr6H3t3TdcX4;

public sealed class M0UKkE4VRxo2p0mlpaw
{
	private sealed class ueDqeNfEgnojShSJGC8A
	{
		[CompilerGenerated]
		private int _Version_k__BackingField;

		[CompilerGenerated]
		private string _RequestId_k__BackingField;

		[CompilerGenerated]
		private string _Operation_k__BackingField;

		[CompilerGenerated]
		private string? _SauthJson_k__BackingField;

		[CompilerGenerated]
		private string? _TransactionId_k__BackingField;

		[CompilerGenerated]
		private string _Challenge_k__BackingField;

		[CompilerGenerated]
		private string _Nonce_k__BackingField;

		[CompilerGenerated]
		private long _Timestamp_k__BackingField;

		private static object qOkQtY9WzaUKmVqSgMsX;

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
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
							{
								num2 = 5;
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

		[JsonPropertyName("requestId")]
		public string RequestId
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _RequestId_k__BackingField;
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
							_RequestId_k__BackingField = value;
							num2 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
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

		[JsonPropertyName("operation")]
		public string Operation
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Operation_k__BackingField;
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
						_Operation_k__BackingField = value;
						num2 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 != 0)
						{
							num2 = 0;
						}
					}
				}
			}
		}

		[JsonPropertyName("sauthJson")]
		public string? SauthJson
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _SauthJson_k__BackingField;
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
						_SauthJson_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
						{
							num2 = 3;
						}
					}
				}
			}
		}

		[JsonPropertyName("transactionId")]
		public string? TransactionId
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _TransactionId_k__BackingField;
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
							_TransactionId_k__BackingField = value;
							num2 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
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

		[JsonPropertyName("challenge")]
		public string Challenge
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Challenge_k__BackingField;
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
							_Challenge_k__BackingField = value;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
							{
								num2 = 3;
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
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
							{
								num2 = 4;
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
				do
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 1:
							_Timestamp_k__BackingField = value;
							num2 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
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
		public ueDqeNfEgnojShSJGC8A()
{
			// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
			throw new global::System.NotSupportedException();
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
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
							{
								num3 = 1;
							}
							continue;
						case 2:
							goto end_IL_000e;
						case 1:
							return;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
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
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool iphC8f9JbOtuKYh119hq()
		{
			return qOkQtY9WzaUKmVqSgMsX == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static ueDqeNfEgnojShSJGC8A yKAfOf9JXcK8bKFMrFNg()
		{
			return (ueDqeNfEgnojShSJGC8A)qOkQtY9WzaUKmVqSgMsX;
		}
	}

	private sealed class kcvQKifElFMT4NHkWe4I
	{
		[CompilerGenerated]
		private int _Version_k__BackingField;

		[CompilerGenerated]
		private string? _Challenge_k__BackingField;

		[CompilerGenerated]
		private long _ExpiresAt_k__BackingField;

		[CompilerGenerated]
		private int _ProcessId_k__BackingField;

		[CompilerGenerated]
		private string? _BridgeVersion_k__BackingField;

		internal static object? nNHTyb9JfGugwQbMbiDQ;

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
						_Version_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
						{
							num2 = 2;
						}
					}
				}
			}
		}

		[JsonPropertyName("challenge")]
		public string? Challenge
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Challenge_k__BackingField;
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
							_Challenge_k__BackingField = value;
							num2 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
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

		[JsonPropertyName("expiresAt")]
		public long ExpiresAt
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _ExpiresAt_k__BackingField;
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
							_ExpiresAt_k__BackingField = value;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
							{
								num2 = 3;
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

		[JsonPropertyName("processId")]
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
							_ProcessId_k__BackingField = value;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
							{
								num2 = 3;
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

		[JsonPropertyName("bridgeVersion")]
		public string? BridgeVersion
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _BridgeVersion_k__BackingField;
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
							_BridgeVersion_k__BackingField = value;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
							{
								num2 = 2;
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
		public kcvQKifElFMT4NHkWe4I()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
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
								goto case 2;
							}
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
							{
								num3 = 2;
							}
							continue;
						case 0:
							return;
						case 2:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
							{
								num3 = 0;
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
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 != 0)
				{
					num = 2;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool fjVEF39JLDeUOu7QiQOi()
		{
			return nNHTyb9JfGugwQbMbiDQ == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static kcvQKifElFMT4NHkWe4I? sgpsWt9Jjo0qY3VIna8w()
		{
			return (kcvQKifElFMT4NHkWe4I?)nNHTyb9JfGugwQbMbiDQ;
		}
	}

	private sealed class Dreuh8fEd8heGAjFdwZ1
	{
		[CompilerGenerated]
		private int _Version_k__BackingField;

		[CompilerGenerated]
		private string? _RequestId_k__BackingField;

		[CompilerGenerated]
		private bool _Success_k__BackingField;

		[CompilerGenerated]
		private string? _Code_k__BackingField;

		[CompilerGenerated]
		private string? _Message_k__BackingField;

		[CompilerGenerated]
		private int _ProcessId_k__BackingField;

		[CompilerGenerated]
		private string? _BridgeVersion_k__BackingField;

		[CompilerGenerated]
		private string? _Account_k__BackingField;

		[CompilerGenerated]
		private string? _UserId_k__BackingField;

		[CompilerGenerated]
		private string? _TransactionId_k__BackingField;

		private static object? Vd8q6q9JZpyuVoGM58V9;

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
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 != 0)
							{
								num2 = 4;
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

		[JsonPropertyName("requestId")]
		public string? RequestId
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _RequestId_k__BackingField;
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
						_RequestId_k__BackingField = value;
						num2 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
						{
							num2 = 0;
						}
					}
				}
			}
		}

		[JsonPropertyName("success")]
		public bool Success
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Success_k__BackingField;
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
							_Success_k__BackingField = value;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
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

		[JsonPropertyName("code")]
		public string? Code
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Code_k__BackingField;
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
							_Code_k__BackingField = value;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
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

		[JsonPropertyName("message")]
		public string? Message
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Message_k__BackingField;
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
							_Message_k__BackingField = value;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
							{
								num2 = 5;
							}
							continue;
						}
						break;
					}
				}
				while (num == 989);
			}
		}

		[JsonPropertyName("processId")]
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
						_ProcessId_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 != 0)
						{
							num2 = 0;
						}
					}
				}
			}
		}

		[JsonPropertyName("bridgeVersion")]
		public string? BridgeVersion
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _BridgeVersion_k__BackingField;
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
							_BridgeVersion_k__BackingField = value;
							num2 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
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

		[JsonPropertyName("account")]
		public string? Account
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Account_k__BackingField;
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
						_Account_k__BackingField = value;
						num2 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
						{
							num2 = 0;
						}
					}
				}
			}
		}

		[JsonPropertyName("userId")]
		public string? UserId
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _UserId_k__BackingField;
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
							_UserId_k__BackingField = value;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
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

		[JsonPropertyName("transactionId")]
		public string? TransactionId
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _TransactionId_k__BackingField;
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
							_TransactionId_k__BackingField = value;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
							{
								num2 = 5;
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
		public Dreuh8fEd8heGAjFdwZ1()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
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
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							num3 = 2;
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
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
				{
					num = 3;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool EGr9nB9J9kjyr3egTwIQ()
		{
			return Vd8q6q9JZpyuVoGM58V9 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static Dreuh8fEd8heGAjFdwZ1? YcRCW09JDMVpxMuN8AEk()
		{
			return (Dreuh8fEd8heGAjFdwZ1?)Vd8q6q9JZpyuVoGM58V9;
		}
	}

	[CompilerGenerated]
	private class __O_34
	{
		public static Func<bKgpy04rH66Wqmd3C4r, bool> _0___IsSame;

		private static __O_34 JE9AS19JkboJWPnMajEv;

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
							switch (num2)
							{
							case 990:
								goto end_IL_0012;
							case 9:
								return;
							}
							goto end_IL_000e;
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
							{
								num3 = 7;
							}
							continue;
						case 2:
							goto end_IL_000e;
						case 0:
							{
								num3 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							end_IL_0012:
							break;
						}
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
				num = 9;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool ISQPO59JVOwpGbaKnFnK()
		{
			return JE9AS19JkboJWPnMajEv == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __O_34 EXODcP9JYEyjurQDTSkI()
		{
			return JE9AS19JkboJWPnMajEv;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_126
	{
		public static __c_126 __9;

		public static Func<int, bKgpy04rH66Wqmd3C4r?> __9__6_0;

		internal static __c_126 zw77sv9JSMCiPvYVnoCV;

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
							if (num2 != 11)
							{
								if (num2 == 992)
								{
									goto end_IL_0012;
								}
								goto case 1;
							}
							num = 4;
							break;
						case 3:
							HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							return;
						case 1:
							__9 = (__c_126)new __c_126();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
							{
								num3 = 9;
							}
							continue;
						case 2:
							num = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
							{
								num = 7;
							}
							break;
						case 4:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 3;
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
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_126()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bKgpy04rH66Wqmd3C4r? __ctor_b__6_0(int processId)
		{
			int num = 2;
			bKgpy04rH66Wqmd3C4r identity = default;
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
					case 0:
						return null;
					case 1:
						return identity;
					case 2:
						if (sopKL04JEumctKDXjEH.TryCapture(processId, out identity))
						{
							num2 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 != 0)
							{
								num2 = 1;
							}
							break;
						}
						goto case 0;
					}
					continue;
					end_IL_0010:
					break;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool ujXEAk9JcupC7rXSdl1i()
		{
			return zw77sv9JSMCiPvYVnoCV == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_126 pmsWGn9J0tqiPM8ynBjA()
		{
			return zw77sv9JSMCiPvYVnoCV;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _LoginAsync_d__9 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<QZp6nEf5hixc2uAIZhmg> __t__builder;

		public M0UKkE4VRxo2p0mlpaw __4__this;

		public int processId;

		public string sauthJson;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<QZp6nEf5hixc2uAIZhmg>.ConfiguredTaskAwaiter __u__1;

		internal static object QQL1m99J8YhvIPEodKlE;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_0295: Unknown result type (might be due to invalid IL or missing references)
			//IL_029a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_023a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0240: Unknown result type (might be due to invalid IL or missing references)
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Expected O, but got Ref
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_019d: Unknown result type (might be due to invalid IL or missing references)
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_032e->IL02ed: Incompatible stack heights: 3 vs 1
			//IL_0339->IL02ed: Incompatible stack heights: 3 vs 1
			//IL_03c9->IL0010: Incompatible stack heights: 3 vs 1
			//IL_03d4->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0262->IL00a7: Incompatible stack heights: 2 vs 1
			//IL_026d->IL00a7: Incompatible stack heights: 2 vs 1
			int num = 1;
			int num4 = default;
			ConfiguredTaskAwaitable<QZp6nEf5hixc2uAIZhmg>.ConfiguredTaskAwaiter _u__ = default;
			int num6 = default;
			ConfiguredTaskAwaitable<QZp6nEf5hixc2uAIZhmg> val = default;
			M0UKkE4VRxo2p0mlpaw m0UKkE4VRxo2p0mlpaw = default;
			int num9 = default;
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
								goto IL_0037;
							}
							try
							{
								int num5;
								if (num4 != 0)
								{
									num5 = 4;
									goto IL_00a7;
								}
								goto IL_0294;
								IL_0294:
								_u__ = __u__1;
								num5 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
								{
									num5 = 9;
								}
								goto IL_00a7;
								IL_00a7:
								while (true)
								{
									switch (num5)
									{
									default:
										if (num6 != 19)
										{
											if (num6 == 999)
											{
												goto IL_00a3;
											}
											goto case 8;
										}
										num4 = (__1__state = -1);
										num5 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
										{
											num5 = 9;
										}
										continue;
									case 3:
										__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<QZp6nEf5hixc2uAIZhmg>.ConfiguredTaskAwaiter, _LoginAsync_d__9>(ref _u__, ref this);
										num5 = 2;
										continue;
									case 6:
									{
										__u__1 = default;
										int num7 = 19;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
										{
											num7 = 9;
										}
										num6 = num7;
										goto IL_00a3;
									}
									case 1:
										_u__ = val;
										num5 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
										{
											num5 = 8;
										}
										continue;
									case 5:
									case 9:
									{
										QZp6nEf5hixc2uAIZhmg qZp6nEf5hixc2uAIZhmg = (QZp6nEf5hixc2uAIZhmg)(&_u__);
										num5 = 10;
										continue;
									}
									case 7:
										__u__1 = _u__;
										num5 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
										{
											num5 = 10;
										}
										continue;
									case 2:
										return;
									case 11:
										num4 = (__1__state = 0);
										num5 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
										{
											num5 = 7;
										}
										continue;
									case 4:
										m0UKkE4VRxo2p0mlpaw.SendAsync(processId, "login", sauthJson, null, s4B40B5YXg, cancellationToken);
										val = (ConfiguredTaskAwaitable<QZp6nEf5hixc2uAIZhmg>)0;
										_ = 18;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 != 0)
										{
											_ = 1;
										}
										continue;
									case 8:
										if (&_u__ != null)
										{
											num5 = 9;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 != 0)
											{
												num5 = 15;
											}
											continue;
										}
										goto case 11;
									case 0:
										break;
									case 10:
										goto end_IL_00a7;
										IL_00a3:
										num5 = num6;
										continue;
									}
									goto IL_0294;
									continue;
									end_IL_00a7:
									break;
								}
							}
							catch (global::System.Exception)
							{
								int num8 = 2;
								while (true)
								{
									switch (num8)
									{
									default:
										if (num9 == 990)
										{
											num8 = num9;
											continue;
										}
										break;
									case 0:
										_ = __t__builder;
										_ = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
										{
											_ = 1;
										}
										continue;
									case 2:
										break;
									case 1:
										return;
									}
									__1__state = -2;
									num8 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 != 0)
									{
										num8 = 8;
									}
								}
							}
							goto case 3;
						case 0:
							goto end_IL_000c;
						case 3:
							__1__state = -2;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
							{
								num3 = 2;
							}
							continue;
						case 4:
							return;
						case 1:
							num4 = __1__state;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
							{
								num3 = 11;
							}
							continue;
						case 2:
							break;
						}
						goto IL_03ac;
						IL_0037:
						if (num2 == 992)
						{
							break;
						}
						goto IL_03ac;
						IL_03ac:
						_ = __t__builder;
						_ = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
						{
							_ = 4;
						}
					}
					continue;
					end_IL_000c:
					break;
				}
				m0UKkE4VRxo2p0mlpaw = __4__this;
				num = 11;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_004c->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0057->IL0010: Incompatible stack heights: 3 vs 1
			int num = 1;
			while (true)
			{
				while (true)
				{
					switch (num)
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
					_ = __t__builder;
					_ = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
					{
						_ = 3;
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
							switch (num2)
							{
							case 990:
								break;
							default:
								goto end_IL_000e;
							case 9:
								goto IL_0078;
							}
							break;
						case 2:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							goto end_IL_000e;
						case 0:
							return;
							IL_0078:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
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
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool Axmj8L9Jy27108GXM5gu()
		{
			return QQL1m99J8YhvIPEodKlE == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object BkmBhM9JWEBH3Vc5DnUc()
		{
			return QQL1m99J8YhvIPEodKlE;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _PingAsync_d__8 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<QZp6nEf5hixc2uAIZhmg> __t__builder;

		public M0UKkE4VRxo2p0mlpaw __4__this;

		public int processId;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<QZp6nEf5hixc2uAIZhmg>.ConfiguredTaskAwaiter __u__1;

		private static object HRNn9t9JJAbk0oUWNA36;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_0187: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_0297: Unknown result type (might be due to invalid IL or missing references)
			//IL_024d: Unknown result type (might be due to invalid IL or missing references)
			//IL_025a: Unknown result type (might be due to invalid IL or missing references)
			//IL_025c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Expected O, but got Ref
			//IL_0320->IL02df: Incompatible stack heights: 3 vs 1
			//IL_032b->IL02df: Incompatible stack heights: 3 vs 1
			//IL_00a0->IL0010: Incompatible stack heights: 3 vs 1
			//IL_00ab->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0203->IL010c: Incompatible stack heights: 2 vs 1
			//IL_020e->IL010c: Incompatible stack heights: 2 vs 1
			int num = 2;
			int num4 = default;
			int num6 = default;
			M0UKkE4VRxo2p0mlpaw m0UKkE4VRxo2p0mlpaw = default;
			ConfiguredTaskAwaitable<QZp6nEf5hixc2uAIZhmg> val = default;
			ConfiguredTaskAwaitable<QZp6nEf5hixc2uAIZhmg>.ConfiguredTaskAwaiter _u__ = default;
			int num8 = default;
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
							goto IL_004a;
						case 2:
							num4 = __1__state;
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
							{
								num3 = 1;
							}
							continue;
						case 0:
							return;
						case 3:
							__1__state = -2;
							num = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
							{
								num = 4;
							}
							goto end_IL_0010;
						case 4:
							try
							{
								int num5;
								if (num4 != 0)
								{
									num5 = 9;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
									{
										num5 = 0;
									}
									goto IL_010c;
								}
								goto IL_0181;
								IL_010c:
								while (true)
								{
									QZp6nEf5hixc2uAIZhmg qZp6nEf5hixc2uAIZhmg;
									switch (num5)
									{
									case 5:
										return;
									default:
										if (num6 == 18)
										{
											goto IL_020e;
										}
										if (num6 == 998)
										{
											goto IL_0108;
										}
										goto case 8;
									case 10:
										num4 = (__1__state = -1);
										num6 = 18;
										goto IL_0108;
									case 2:
										break;
									case 0:
										m0UKkE4VRxo2p0mlpaw.SendAsync(processId, "ping", null, null, System.TimeSpan.FromMilliseconds(2000.0), cancellationToken);
										val = (ConfiguredTaskAwaitable<QZp6nEf5hixc2uAIZhmg>)0;
										_ = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
										{
											_ = 16;
										}
										continue;
									case 3:
										__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<QZp6nEf5hixc2uAIZhmg>.ConfiguredTaskAwaiter, _PingAsync_d__8>(ref _u__, ref this);
										num5 = 5;
										continue;
									case 7:
										_u__ = val;
										num5 = 8;
										continue;
									case 9:
										__u__1 = _u__;
										num5 = 3;
										continue;
									case 8:
										if (&_u__ == null)
										{
											num5 = 4;
											continue;
										}
										goto IL_020e;
									case 4:
										num4 = (__1__state = 0);
										num5 = 9;
										continue;
									case 6:
										__u__1 = default;
										num5 = 10;
										continue;
									case 1:
										goto end_IL_010c;
										IL_020e:
										qZp6nEf5hixc2uAIZhmg = (QZp6nEf5hixc2uAIZhmg)(&_u__);
										num5 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 != 0)
										{
											num5 = 1;
										}
										continue;
										IL_0108:
										num5 = num6;
										continue;
									}
									goto IL_0181;
									continue;
									end_IL_010c:
									break;
								}
								goto end_IL_00d4;
								IL_0181:
								_u__ = __u__1;
								num5 = 15;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
								{
									num5 = 6;
								}
								goto IL_010c;
								end_IL_00d4:;
							}
							catch (global::System.Exception)
							{
								int num7 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
								{
									num7 = 4;
								}
								while (true)
								{
									switch (num7)
									{
									case 2:
										return;
									default:
										if (num8 == 990)
										{
											num7 = num8;
											continue;
										}
										break;
									case 0:
										_ = __t__builder;
										_ = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
										{
											_ = 6;
										}
										continue;
									case 1:
										break;
									}
									__1__state = -2;
									num7 = 8;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
									{
										num7 = 0;
									}
								}
							}
							goto case 3;
						}
						switch (num2)
						{
						case 992:
							break;
						default:
							return;
						case 11:
							_ = __t__builder;
							_ = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
							{
								_ = 2;
							}
							continue;
						}
						goto IL_000c;
						IL_004a:
						m0UKkE4VRxo2p0mlpaw = __4__this;
						num = 4;
						break;
						continue;
						end_IL_0010:
						break;
					}
					break;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_004d->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0058->IL0010: Incompatible stack heights: 3 vs 1
			int num = 1;
			while (true)
			{
				while (true)
				{
					switch (num)
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
					_ = __t__builder;
					_ = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
					{
						_ = 0;
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
						case 2:
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
							{
								num3 = 1;
							}
							continue;
						case 0:
							return;
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
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
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
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
				{
					num = 6;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool heNlDn9JQYydRBrnuCVX()
		{
			return HRNn9t9JJAbk0oUWNA36 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object hbbIqV9JCdBbJaPJs8J4()
		{
			return HRNn9t9JJAbk0oUWNA36;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ReadFrameAsync_d__17 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<byte[]> __t__builder;

		public Stream stream;

		public CancellationToken cancellationToken;

		private byte[] _header_5__2;

		private byte[] _payload_5__3;

		private object __u__1;

		internal static object ewIfCD9Jrscd4lsDnYgg;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0200: Unknown result type (might be due to invalid IL or missing references)
			//IL_0205: Unknown result type (might be due to invalid IL or missing references)
			//IL_0278: Unknown result type (might be due to invalid IL or missing references)
			//IL_027d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_019d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0532: Unknown result type (might be due to invalid IL or missing references)
			//IL_0534: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0414: Unknown result type (might be due to invalid IL or missing references)
			//IL_0438: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ec->IL05b7: Incompatible stack heights: 0 vs 2
			//IL_05bb->IL05bb: Incompatible stack heights: 3 vs 1
			//IL_06db->IL0010: Incompatible stack heights: 3 vs 1
			//IL_06e6->IL0010: Incompatible stack heights: 3 vs 1
			int num = 3;
			int num4 = default;
			object _u__ = default;
			int num8 = default;
			ConfiguredTaskAwaitable val = default;
			int num6 = default;
			int num10 = default;
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
								goto end_IL_0010;
							}
							try
							{
								int num5;
								if (num4 == 0)
								{
									num5 = 21;
									goto IL_00bf;
								}
								goto IL_04f6;
								IL_01ff:
								_u__ = __u__1;
								num5 = 19;
								goto IL_00bf;
								IL_00bf:
								while (true)
								{
									int num7;
									switch (num5)
									{
									default:
										if (num8 != 39)
										{
											if (num8 == 1019)
											{
												goto IL_00bb;
											}
											goto case 31;
										}
										val = (ReadExactlyAsync(stream, _payload_5__3, cancellationToken)).ConfigureAwait(false);
										num5 = 24;
										continue;
									case 19:
										__u__1 = default;
										num5 = 11;
										continue;
									case 6:
										val = (ReadExactlyAsync(stream, _header_5__2, cancellationToken)).ConfigureAwait(false);
										num5 = 20;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
										{
											num5 = 31;
										}
										continue;
									case 23:
										(_u__).GetResult();
										num5 = 4;
										continue;
									case 10:
										__u__1 = default;
										num5 = 14;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 != 0)
										{
											num5 = 24;
										}
										continue;
									case 15:
										break;
									case 12:
										if (!(_u__).IsCompleted)
										{
											num5 = 29;
											continue;
										}
										goto case 23;
									case 22:
										return;
									case 25:
										__t__builder.AwaitUnsafeOnCompleted<object, _ReadFrameAsync_d__17>(ref _u__, ref this);
										num7 = 22;
										goto IL_00b7;
									case 0:
									case 21:
										_u__ = __u__1;
										num5 = 39;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
										{
											num5 = 10;
										}
										continue;
									case 3:
										__t__builder.AwaitUnsafeOnCompleted<object, _ReadFrameAsync_d__17>(ref _u__, ref this);
										num5 = 2;
										continue;
									case 28:
										num6 = System.Buffers.Binary.BinaryPrimitives.ReadInt32LittleEndian((global::System.ReadOnlySpan<byte>)_header_5__2);
										num5 = 27;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
										{
											num5 = 9;
										}
										continue;
									case 2:
										return;
									case 14:
										num4 = (__1__state = -1);
										num5 = 31;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
										{
											num5 = 26;
										}
										continue;
									case 29:
										num4 = (__1__state = 1);
										num5 = 9;
										continue;
									case 13:
									case 18:
										throw new global::System.Exception("Hook 协议帧长度无效");
									case 9:
										__u__1 = _u__;
										num5 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
										{
											num5 = 19;
										}
										continue;
									case 1:
										if ((_u__).IsCompleted)
										{
											num5 = 16;
											continue;
										}
										goto case 31;
									case 20:
										_u__ = val;
										num5 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
										{
											num5 = 12;
										}
										continue;
									case 24:
										_u__ = val;
										num5 = 21;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
										{
											num5 = 12;
										}
										continue;
									case 30:
										if (num6 <= 65536)
										{
											_payload_5__3 = new byte[num6];
											num7 = 39;
											goto IL_00b7;
										}
										num5 = 13;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
										{
											num5 = 39;
										}
										continue;
									case 4:
									{
										byte[] array = _payload_5__3;
										num5 = 39;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
										{
											num5 = 8;
										}
										continue;
									}
									case 27:
										if (num6 <= 0)
										{
											num5 = 18;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
											{
												num5 = 24;
											}
											continue;
										}
										goto case 30;
									case 17:
										goto IL_04f6;
									case 11:
										num4 = (__1__state = -1);
										num5 = 30;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
										{
											num5 = 23;
										}
										continue;
									case 7:
										__u__1 = _u__;
										num7 = 25;
										goto IL_00b7;
									case 31:
										num4 = (__1__state = 0);
										num5 = 7;
										continue;
									case 5:
										_header_5__2 = new byte[4];
										num5 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
										{
											num5 = 21;
										}
										continue;
									case 16:
									case 26:
										(_u__).GetResult();
										num5 = 28;
										continue;
									case 8:
										goto end_IL_009c;
										IL_00b7:
										num8 = num7;
										goto IL_00bb;
										IL_00bb:
										num5 = num8;
										continue;
									}
									break;
								}
								goto IL_01ff;
								IL_04f6:
								if (num4 != 1)
								{
									num5 = 5;
									goto IL_00bf;
								}
								goto IL_01ff;
								end_IL_009c:;
							}
							catch (global::System.Exception)
							{
								int num9 = 3;
								while (true)
								{
									switch (num9)
									{
									default:
										switch (num10)
										{
										case 991:
											goto end_IL_05bb;
										case 11:
											return;
										}
										goto case 3;
									case 3:
										__1__state = -2;
										num9 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b != 0)
										{
											num9 = 1;
										}
										break;
									case 2:
										_payload_5__3 = null;
										num9 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
										{
											num9 = 6;
										}
										break;
									case 0:
										_ = __t__builder;
										num10 = 11;
										break;
									case 1:
										{
											_header_5__2 = null;
											num9 = 3;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
											{
												num9 = 2;
											}
											break;
										}
										end_IL_05bb:
										break;
									}
								}
							}
							goto case 4;
						case 4:
							__1__state = -2;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
							{
								num3 = 4;
							}
							continue;
						case 2:
							_payload_5__3 = null;
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea != 0)
							{
								num3 = 5;
							}
							continue;
						case 0:
							_header_5__2 = null;
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
							{
								num3 = 6;
							}
							continue;
						case 3:
							break;
						case 5:
							_ = __t__builder;
							_ = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
							{
								_ = 1;
							}
							continue;
						case 1:
							return;
						}
						goto end_IL_000c;
						continue;
						end_IL_0010:
						break;
					}
					if (num2 != 993)
					{
						return;
					}
					continue;
					end_IL_000c:
					break;
				}
				num4 = __1__state;
				num = 12;
			}
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
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
							{
								num3 = 2;
							}
							continue;
						case 2:
							return;
						case 0:
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
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
							{
								num3 = 2;
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
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool KCeVHd9JoQZctQJwNdJh()
		{
			return ewIfCD9Jrscd4lsDnYgg == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object AwFDXS9JmTdipxesUhWC()
		{
			return ewIfCD9Jrscd4lsDnYgg;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ResultAsync_d__10 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<QZp6nEf5hixc2uAIZhmg> __t__builder;

		public M0UKkE4VRxo2p0mlpaw __4__this;

		public int processId;

		public string transactionId;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<QZp6nEf5hixc2uAIZhmg>.ConfiguredTaskAwaiter __u__1;

		internal static object Yh950C9J7wsEXnRZdEnf;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_022f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0245: Expected O, but got Ref
			//IL_0209: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c8->IL0287: Incompatible stack heights: 3 vs 1
			//IL_02d3->IL0287: Incompatible stack heights: 3 vs 1
			//IL_0374->IL0010: Incompatible stack heights: 3 vs 1
			//IL_037f->IL0010: Incompatible stack heights: 3 vs 1
			//IL_015e->IL0095: Incompatible stack heights: 2 vs 1
			//IL_0169->IL0095: Incompatible stack heights: 2 vs 1
			int num = 1;
			int num4 = default;
			int num6 = default;
			ConfiguredTaskAwaitable<QZp6nEf5hixc2uAIZhmg>.ConfiguredTaskAwaiter _u__ = default;
			M0UKkE4VRxo2p0mlpaw m0UKkE4VRxo2p0mlpaw = default;
			ConfiguredTaskAwaitable<QZp6nEf5hixc2uAIZhmg> val = default;
			int num8 = default;
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
						case 4:
							goto end_IL_000c;
						case 2:
							try
							{
								int num5;
								if (num4 != 0)
								{
									num5 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
									{
										num5 = 1;
									}
									goto IL_0095;
								}
								goto IL_00e7;
								IL_0095:
								while (true)
								{
									switch (num5)
									{
									default:
										if (num6 != 18)
										{
											if (num6 == 998)
											{
												goto IL_0091;
											}
											goto case 0;
										}
										__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<QZp6nEf5hixc2uAIZhmg>.ConfiguredTaskAwaiter, _ResultAsync_d__10>(ref _u__, ref this);
										num5 = 6;
										continue;
									case 8:
										break;
									case 1:
										m0UKkE4VRxo2p0mlpaw.SendAsync(processId, "result", null, ValidateTransactionId(transactionId), System.TimeSpan.FromMilliseconds(2000.0), cancellationToken);
										val = (ConfiguredTaskAwaitable<QZp6nEf5hixc2uAIZhmg>)0;
										_ = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
										{
											_ = 7;
										}
										continue;
									case 2:
										num4 = (__1__state = 0);
										num5 = 4;
										continue;
									case 0:
										if (&_u__ == null)
										{
											num5 = 2;
											continue;
										}
										goto case 9;
									case 6:
										return;
									case 7:
										_u__ = val;
										num5 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
										{
											num5 = 0;
										}
										continue;
									case 3:
										num4 = (__1__state = -1);
										num5 = 9;
										continue;
									case 10:
										__u__1 = default;
										num5 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
										{
											num5 = 6;
										}
										continue;
									case 4:
										__u__1 = _u__;
										num6 = 18;
										goto IL_0091;
									case 9:
									{
										QZp6nEf5hixc2uAIZhmg qZp6nEf5hixc2uAIZhmg = (QZp6nEf5hixc2uAIZhmg)(&_u__);
										num5 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 != 0)
										{
											num5 = 13;
										}
										continue;
									}
									case 5:
										goto end_IL_0095;
										IL_0091:
										num5 = num6;
										continue;
									}
									goto IL_00e7;
									continue;
									end_IL_0095:
									break;
								}
								goto end_IL_005d;
								IL_00e7:
								_u__ = __u__1;
								num5 = 10;
								goto IL_0095;
								end_IL_005d:;
							}
							catch (global::System.Exception)
							{
								int num7 = 2;
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
									case 0:
										_ = __t__builder;
										_ = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
										{
											_ = 3;
										}
										continue;
									case 2:
										break;
									case 1:
										return;
									}
									__1__state = -2;
									num7 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 != 0)
									{
										num7 = 5;
									}
								}
							}
							goto end_IL_000c;
						case 0:
							m0UKkE4VRxo2p0mlpaw = __4__this;
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
							{
								num3 = 2;
							}
							continue;
						case 1:
							num4 = __1__state;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
							{
								num3 = 0;
							}
							continue;
						case 3:
							return;
						}
						switch (num2)
						{
						case 992:
							break;
						default:
							return;
						case 11:
							_ = __t__builder;
							_ = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
							{
								_ = 8;
							}
							continue;
						}
						break;
					}
					continue;
					end_IL_000c:
					break;
				}
				__1__state = -2;
				num = 11;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_004d->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0058->IL0010: Incompatible stack heights: 3 vs 1
			int num = 1;
			while (true)
			{
				while (true)
				{
					switch (num)
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
					_ = __t__builder;
					_ = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
					{
						_ = 0;
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
								goto case 1;
							}
							return;
						case 2:
							num = 1;
							break;
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce != 0)
							{
								num3 = 9;
							}
							continue;
						case 0:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
							{
								num = 9;
							}
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
		internal static bool yjfPbI9JAMOQZHuSQrlI()
		{
			return Yh950C9J7wsEXnRZdEnf == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object xNtAil9JIN497dmOJ2lV()
		{
			return Yh950C9J7wsEXnRZdEnf;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _SendAsync_d__11 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<QZp6nEf5hixc2uAIZhmg> __t__builder;

		public int processId;

		public string operation;

		public string transactionId;

		public M0UKkE4VRxo2p0mlpaw __4__this;

		public CancellationToken cancellationToken;

		public TimeSpan responseTimeout;

		public string sauthJson;

		private string _requestId_5__2;

		private string _expectedTransactionId_5__3;

		private bKgpy04rH66Wqmd3C4r _serverIdentity_5__4;

		private NamedPipeClientStream _pipe_5__5;

		private CancellationTokenSource _connectCts_5__6;

		private CancellationTokenSource _responseCts_5__7;

		private object __u__1;

		private ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter __u__2;

		internal static object CbQnYU9JB6B7PcETMGN5;

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
			//IL_004d->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0058->IL0010: Incompatible stack heights: 3 vs 1
			int num = 1;
			while (true)
			{
				while (true)
				{
					switch (num)
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
					_ = __t__builder;
					_ = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
					{
						_ = 0;
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
							switch (num2)
							{
							case 990:
								goto end_IL_0012;
							case 9:
								return;
							}
							goto end_IL_000e;
						case 0:
							goto end_IL_000e;
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
							{
								num3 = 7;
							}
							continue;
						case 2:
							{
								num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
								{
									num3 = 0;
								}
								continue;
							}
							end_IL_0012:
							break;
						}
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
				num = 9;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool xul4fp9JghbUN5QVeDfb()
		{
			return CbQnYU9JB6B7PcETMGN5 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object K9jR2Q9JlThsDj49XZtV()
		{
			return CbQnYU9JB6B7PcETMGN5;
		}
	}

	private static readonly TimeSpan s4B40B5YXg;

	private static object RJl48O1nn4;

	private readonly Func<int, bKgpy04rH66Wqmd3C4r?> HBG4yiNaZl;

	private readonly Func<bKgpy04rH66Wqmd3C4r, bool> IU84WAFqFl;

	internal static object CLWwqcZcI1YXfKCkFs5E;

	[MethodImpl((MethodImplOptions)8)]
	public M0UKkE4VRxo2p0mlpaw()
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal M0UKkE4VRxo2p0mlpaw(Func<int, bKgpy04rH66Wqmd3C4r?> captureServerIdentity, Func<bKgpy04rH66Wqmd3C4r, bool> isSameServerIdentity)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public unsafe global::System.Threading.Tasks.Task<QZp6nEf5hixc2uAIZhmg> PingAsync(int processId, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Ref
		object obj = default;
		obj.processId = processId;
		global::System.Runtime.CompilerServices.Unsafe.Write(&((_PingAsync_d__8*)4)->__t__builder, ref obj);
		_ = 12;
		return (global::System.Threading.Tasks.Task<QZp6nEf5hixc2uAIZhmg>)(&obj.__t__builder);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public unsafe global::System.Threading.Tasks.Task<QZp6nEf5hixc2uAIZhmg> LoginAsync(int processId, string sauthJson, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.cancellationToken = cancellationToken;
		global::System.Runtime.CompilerServices.Unsafe.Write(&((_LoginAsync_d__9*)4)->__t__builder, ref obj);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public unsafe global::System.Threading.Tasks.Task<QZp6nEf5hixc2uAIZhmg> ResultAsync(int processId, string transactionId, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0028: Expected O, but got Ref
		object obj = default;
		obj.transactionId = transactionId;
		_ = 11;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76;
		_ = 13;
		return (global::System.Threading.Tasks.Task<QZp6nEf5hixc2uAIZhmg>)(&obj.__t__builder);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe global::System.Threading.Tasks.Task<QZp6nEf5hixc2uAIZhmg> SendAsync(int processId, string operation, string? sauthJson, string? transactionId, TimeSpan responseTimeout, CancellationToken cancellationToken)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.transactionId = transactionId;
		_ = 11;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3;
		global::System.Runtime.CompilerServices.Unsafe.Write(&((_SendAsync_d__11*)8)->__t__builder, ref obj);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string GetPipeName(int processId)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static string ValidateTransactionId(object transactionId)
	{
		//IL_0009: Expected O, but got I4
		//IL_001e: Expected I4, but got O
		//IL_0111->IL000d: Incompatible stack types: I4 vs O
		//IL_011c->IL000d: Incompatible stack types: I4 vs O
		//IL_0076->IL000d: Incompatible stack types: I4 vs O
		int num = 1;
		object obj3 = default;
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
								goto end_IL_000d;
							}
							goto case 1;
						}
						if (!System.Guid.TryParseExact((string)transactionId, "N", out obj3))
						{
							obj2 = 2;
							continue;
						}
						return (string)transactionId;
					case 0:
						if ((transactionId).Length == 32)
						{
							break;
						}
						goto case 2;
					case 2:
						_ = "Hook 登录事务标识无效";
						throw new global::System.Exception("transactionId");
					case 1:
						if (!string.IsNullOrWhiteSpace((string)transactionId))
						{
							obj2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
							{
								obj2 = 1;
							}
							continue;
						}
						goto case 2;
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
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 != 0)
			{
				num = 1;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool IsChallenge(object? value)
	{
		//IL_0009: Expected O, but got I4
		//IL_00a2: Expected I4, but got O
		//IL_00d0: Expected O, but got I4
		//IL_02cb: Expected O, but got I4
		//IL_0153: Expected O, but got I4
		//IL_0138: Expected O, but got I4
		//IL_0255: Expected O, but got I4
		//IL_029f: Expected O, but got I4
		//IL_03b9: Expected O, but got I4
		//IL_037a: Expected I4, but got O
		//IL_037c: Expected O, but got I4
		//IL_03ff: Expected O, but got I4
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_010c->IL000d: Incompatible stack types: I4 vs O
		//IL_01eb->IL000d: Incompatible stack types: I4 vs O
		//IL_00da->IL000d: Incompatible stack types: I4 vs O
		//IL_015d->IL000d: Incompatible stack types: I4 vs O
		//IL_0269->IL000d: Incompatible stack types: I4 vs O
		//IL_02b3->IL000d: Incompatible stack types: I4 vs O
		//IL_03c3->IL000d: Incompatible stack types: I4 vs O
		//IL_0386->IL000d: Incompatible stack types: I4 vs O
		//IL_0247->IL000d: Incompatible stack types: I4 vs O
		//IL_01f6->IL000d: Incompatible stack types: I4 vs O
		//IL_00f3->IL000d: Incompatible stack types: I4 vs O
		//IL_03de->IL000d: Incompatible stack types: I4 vs O
		//IL_0409->IL000d: Incompatible stack types: I4 vs O
		//IL_03fc->IL000d: Incompatible stack types: I4 vs O
		//IL_017a->IL000d: Incompatible stack types: I4 vs O
		//IL_01cc->IL000d: Incompatible stack types: I4 vs O
		//IL_0274->IL000d: Incompatible stack types: I4 vs O
		//IL_03a3->IL000d: Incompatible stack types: I4 vs O
		//IL_02f1->IL000d: Incompatible stack types: I4 vs O
		//IL_01a2->IL000d: Incompatible stack types: I4 vs O
		//IL_033d->IL000d: Incompatible stack types: I4 vs O
		//IL_02be->IL000d: Incompatible stack types: I4 vs O
		//IL_0135->IL000d: Incompatible stack types: I4 vs O
		//IL_0291->IL000d: Incompatible stack types: I4 vs O
		//IL_021f->IL000d: Incompatible stack types: I4 vs O
		//IL_0252->IL000d: Incompatible stack types: I4 vs O
		//IL_00fe->IL000d: Incompatible stack types: I4 vs O
		//IL_03e9->IL000d: Incompatible stack types: I4 vs O
		//IL_0185->IL000d: Incompatible stack types: I4 vs O
		//IL_02fc->IL000d: Incompatible stack types: I4 vs O
		//IL_01ad->IL000d: Incompatible stack types: I4 vs O
		//IL_0348->IL000d: Incompatible stack types: I4 vs O
		//IL_029c->IL000d: Incompatible stack types: I4 vs O
		//IL_022a->IL000d: Incompatible stack types: I4 vs O
		//IL_0359->IL000d: Incompatible stack types: I4 vs O
		int num = 7;
		object obj7 = default;
		object obj4 = default;
		object obj3 = default;
		object obj6 = default;
		object obj5 = default;
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					int num2;
					switch ((int)obj2)
					{
					default:
						if ((nint)obj != 42)
						{
							if ((nint)obj == 1023)
							{
								goto end_IL_000d;
							}
							goto case 30;
						}
						if (obj7 == null)
						{
							obj2 = 5;
							continue;
						}
						goto case 6;
					case 5:
						obj4 = (value).Length;
						obj2 = 30;
						continue;
					case 11:
						return false;
					case 0:
					case 1:
						obj7 = obj3;
						obj2 = 16;
						continue;
					case 8:
						num2 = (((nint)obj6 <= 57) ? 1 : 0);
						goto IL_03fd;
					case 30:
						if ((nint)obj4 < 32)
						{
							obj2 = 23;
							continue;
						}
						goto case 33;
					case 17:
						obj4 = 0;
						num = 3;
						break;
					case 15:
						obj3 = 0;
						obj2 = 4;
						continue;
					case 14:
					case 27:
						if ((nint)obj6 < 48)
						{
							obj2 = 21;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
							{
								obj2 = 38;
							}
							continue;
						}
						goto case 8;
					case 24:
						if ((nint)obj6 != 45)
						{
							obj2 = 26;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
							{
								obj2 = 19;
							}
							continue;
						}
						goto case 19;
					case 29:
						return true;
					case 16:
						if (obj7 != null)
						{
							obj2 = 22;
							continue;
						}
						goto case 9;
					case 4:
					case 18:
						obj7 = obj3;
						obj2 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
						{
							obj2 = 41;
						}
						continue;
					case 34:
						if ((nint)obj6 >= 97)
						{
							obj2 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
							{
								obj2 = 6;
							}
							continue;
						}
						goto case 12;
					case 2:
						if ((nint)obj6 <= 122)
						{
							obj2 = 25;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
							{
								obj2 = 35;
							}
							continue;
						}
						goto case 12;
					case 19:
						obj3 = 1;
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
						{
							obj2 = 8;
						}
						continue;
					case 33:
						if ((nint)obj4 > 64)
						{
							obj2 = 32;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 != 0)
							{
								obj2 = 20;
							}
							continue;
						}
						goto case 15;
					case 28:
						obj3 = 0;
						obj2 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
						{
							obj2 = 1;
						}
						continue;
					case 7:
						obj7 = string.IsNullOrWhiteSpace((string)value);
						num = 42;
						break;
					case 9:
						return false;
					case 22:
						obj4++;
						obj2 = 29;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
						{
							obj2 = 20;
						}
						continue;
					case 10:
						if (obj7 == null)
						{
							num = 24;
							break;
						}
						goto case 16;
					case 21:
						num2 = 0;
						goto IL_03fd;
					case 26:
						if ((nint)obj6 == 95)
						{
							obj2 = 19;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
							{
								obj2 = 6;
							}
							continue;
						}
						goto case 28;
					case 35:
						obj6 = (obj5).Chars;
						obj2 = 34;
						continue;
					case 3:
					case 20:
						if ((nint)obj4 >= (obj5).Length)
						{
							obj2 = 29;
							continue;
						}
						goto case 35;
					case 31:
						if ((nint)obj6 <= 90)
						{
							num = 13;
							break;
						}
						goto case 14;
					case 23:
					case 32:
						obj3 = 1;
						obj2 = 18;
						continue;
					case 6:
						if (obj7 == null)
						{
							obj5 = value;
							obj2 = 17;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
							{
								obj2 = 39;
							}
						}
						else
						{
							obj2 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
							{
								obj2 = 11;
							}
						}
						continue;
					case 12:
						if ((nint)obj6 < 65)
						{
							obj2 = 27;
							continue;
						}
						goto case 31;
					case 13:
					case 25:
						{
							num2 = 1;
							goto IL_03fd;
						}
						IL_03fd:
						obj7 = num2;
						obj2 = 10;
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
	private static QZp6nEf5hixc2uAIZhmg Failure(int processId, object code, object message)
	{
		return (QZp6nEf5hixc2uAIZhmg)new QZp6nEf5hixc2uAIZhmg
		{
			Success = false,
			Code = (string)code,
			Message = (string)message,
			ProcessId = processId
		};
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task WriteFrameAsync(object stream, object payload, CancellationToken cancellationToken)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe static global::System.Threading.Tasks.Task<byte[]> ReadFrameAsync(object stream, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task ReadExactlyAsync(object stream, object buffer, CancellationToken cancellationToken)
	{
		return null;
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool GetNamedPipeServerProcessId(SafePipeHandle pipe, out uint serverProcessId);

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_0029: Expected O, but got I4
		//IL_002e: Expected O, but got I4
		_ = 8;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d;
		(5).PropertyNameCaseInsensitive = true;
		RJl48O1nn4 = 5;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool iMcboaZcB1YLrX45UGJw()
	{
		return CLWwqcZcI1YXfKCkFs5E == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static extern M0UKkE4VRxo2p0mlpaw dV3q6sZcgrRy5hDcLlbk();
}
