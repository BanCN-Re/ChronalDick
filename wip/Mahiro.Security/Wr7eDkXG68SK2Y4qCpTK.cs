using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using SGbIBktUlFqKhlivwXd;
using an3gUVq2E3PsvwmPejP;
using cTpd1lf54YS57isqnyoi;
using fDAldojjppXrctUVYOJn;
using rKDmOVtZY1ZXHoht9md;
using xajTdrzNJetLp9ykLm0;

namespace jQtc8sXGR31bMSWlwIh3;

sealed class Wr7eDkXG68SK2Y4qCpTK : global::System.IDisposable
{
	private sealed class XbrZoPLVbYEVmv3QXLio : IEquatable<XbrZoPLVbYEVmv3QXLio>
	{
		[CompilerGenerated]
		private string _Message_k__BackingField;

		private static object PxcKmcDVS4krr8JKSgQj;

		[CompilerGenerated]
		private global::System.Type EqualityContract
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return System.Type.GetTypeFromHandle(typeof(XbrZoPLVbYEVmv3QXLio).TypeHandle);
			}
		}

		[JsonPropertyName("message")]
		public string Message
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
						_Message_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
						{
							num2 = 1;
						}
					}
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public XbrZoPLVbYEVmv3QXLio(string Message)
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			_Message_k__BackingField = Message;
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
		private bool BZsLVXUYrFW(StringBuilder builder)
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
								break;
							case 9:
								goto IL_006b;
							default:
								goto end_IL_000c;
							}
							break;
						case 1:
							System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 != 0)
							{
								num3 = 4;
							}
							continue;
						case 2:
							return true;
						case 0:
							goto end_IL_000c;
							IL_006b:
							(builder).Append(Message);
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
							{
								num3 = 2;
							}
							continue;
						}
						break;
					}
					continue;
					end_IL_000c:
					break;
				}
				(builder).Append("Message = ");
				num = 9;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator !=(XbrZoPLVbYEVmv3QXLio? left, XbrZoPLVbYEVmv3QXLio? right)
		{
			return !(left == right);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator ==(XbrZoPLVbYEVmv3QXLio? left, XbrZoPLVbYEVmv3QXLio? right)
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
					case 1:
						if (left != null)
						{
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
							{
								num2 = 4;
							}
							break;
						}
						return false;
					case 0:
						return ((XbrZoPLVbYEVmv3QXLio)left).Equals((XbrZoPLVbYEVmv3QXLio?)right);
					case 2:
						if (left == right)
						{
							return true;
						}
						num2 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
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
		[CompilerGenerated]
		public override int GetHashCode()
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected I4, but got Unknown
			return (int)(EqualityContract * -1521134295 + _Message_k__BackingField);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as XbrZoPLVbYEVmv3QXLio);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public bool Equals(XbrZoPLVbYEVmv3QXLio? other)
		{
			//IL_009b: Expected I4, but got O
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
									goto end_IL_0010;
								}
								goto case 0;
							}
							if ((object)other != null)
							{
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed != 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto IL_009b;
						case 0:
							if ((EqualityContract == other.EqualityContract))
							{
								num3 = 2;
								continue;
							}
							goto IL_009b;
						case 2:
							_ = _Message_k__BackingField;
							return (byte)(int)other._Message_k__BackingField != 0;
						case 1:
							break;
							IL_009b:
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
				if ((object)this == (object)other)
				{
					break;
				}
				num = 7;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
				{
					num = 9;
				}
			}
			return true;
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public XbrZoPLVbYEVmv3QXLio SidLVfkgHiA()
		{
			return (XbrZoPLVbYEVmv3QXLio)new XbrZoPLVbYEVmv3QXLio(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private XbrZoPLVbYEVmv3QXLio(XbrZoPLVbYEVmv3QXLio original)
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public void QxRLVLydxCN(out string Message)
		{
			//IL_0038: Expected I8, but got O
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
						Message = default;
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
					Message = default;
					num2 = 6;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
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
								goto case 1;
							}
							return;
						case 1:
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							break;
						case 2:
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
							{
								num3 = 1;
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
				xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
				num = 9;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool sVQoxgDVcOguxr9oDK32()
		{
			return PxcKmcDVS4krr8JKSgQj == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static XbrZoPLVbYEVmv3QXLio R5CrCSDV0CEmWD7oMWaw()
		{
			return (XbrZoPLVbYEVmv3QXLio)PxcKmcDVS4krr8JKSgQj;
		}
	}

	private sealed class QlkS51LVjYAgrq49D34N : IEquatable<QlkS51LVjYAgrq49D34N>
	{
		[CompilerGenerated]
		private Uri _Endpoint_k__BackingField;

		[CompilerGenerated]
		private string _KeyId_k__BackingField;

		[CompilerGenerated]
		private byte[] _ApiKey_k__BackingField;

		private static object COvJRsDV8iYtyIBugexN;

		[CompilerGenerated]
		private global::System.Type EqualityContract
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return System.Type.GetTypeFromHandle(typeof(QlkS51LVjYAgrq49D34N).TypeHandle);
			}
		}

		public Uri Endpoint
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Endpoint_k__BackingField;
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
						_Endpoint_k__BackingField = value;
						num2 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
						{
							num2 = 0;
						}
					}
				}
			}
		}

		public string KeyId
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _KeyId_k__BackingField;
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
							_KeyId_k__BackingField = value;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
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

		public byte[] ApiKey
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _ApiKey_k__BackingField;
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
							_ApiKey_k__BackingField = value;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
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

		[MethodImpl((MethodImplOptions)8)]
		public QlkS51LVjYAgrq49D34N(Uri Endpoint, string KeyId, byte[] ApiKey)
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			_Endpoint_k__BackingField = Endpoint;
			_KeyId_k__BackingField = KeyId;
			_ApiKey_k__BackingField = ApiKey;
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
		private bool e8OLVZ0phZr(StringBuilder builder)
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
							if (num2 != 13)
							{
								if (num2 == 994)
								{
									goto end_IL_0010;
								}
								goto case 1;
							}
							(builder).Append(Endpoint);
							num3 = 12;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
							{
								num3 = 6;
							}
							continue;
						case 4:
							break;
						case 2:
							(builder).Append(ApiKey);
							num3 = 12;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							return true;
						case 6:
							(builder).Append(", KeyId = ");
							num3 = 3;
							continue;
						case 0:
							(builder).Append(", ApiKey = ");
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
							{
								num3 = 2;
							}
							continue;
						case 3:
							(builder).Append(KeyId);
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
							{
								num3 = 0;
							}
							continue;
						case 5:
							System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
							{
								num3 = 1;
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
				(builder).Append("Endpoint = ");
				num = 13;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
				{
					num = 2;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator !=(QlkS51LVjYAgrq49D34N? left, QlkS51LVjYAgrq49D34N? right)
		{
			return !(left == right);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator ==(QlkS51LVjYAgrq49D34N? left, QlkS51LVjYAgrq49D34N? right)
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
						goto case 2;
					case 1:
						if (left != null)
						{
							num2 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
							{
								num2 = 0;
							}
							break;
						}
						return false;
					case 2:
						if (left != right)
						{
							num2 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
							{
								num2 = 1;
							}
							break;
						}
						return true;
					case 0:
						return ((QlkS51LVjYAgrq49D34N)left).Equals((QlkS51LVjYAgrq49D34N?)right);
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
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			_ = EqualityContract * -1521134295;
			_ = _Endpoint_k__BackingField;
			return default(int);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as QlkS51LVjYAgrq49D34N);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public bool Equals(QlkS51LVjYAgrq49D34N? other)
		{
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public QlkS51LVjYAgrq49D34N OX8LV9Ei28n()
		{
			return (QlkS51LVjYAgrq49D34N)new QlkS51LVjYAgrq49D34N(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private QlkS51LVjYAgrq49D34N(QlkS51LVjYAgrq49D34N original)
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public void pKoLVDBYUeS(out Uri Endpoint, out string KeyId, out byte[] ApiKey)
		{
			//IL_004b: Expected I8, but got O
			//IL_005d: Expected I8, but got O
			//IL_0084: Expected I8, but got O
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
								goto end_IL_000c;
							case 9:
								goto IL_007c;
							}
							break;
						case 0:
							ApiKey = default;
							Endpoint = default;
							KeyId = default;
							return;
						case 1:
							goto end_IL_000c;
						case 2:
							{
								Endpoint = (Uri)this.Endpoint;
								num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							IL_007c:
							ApiKey = default;
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						break;
					}
					continue;
					end_IL_000c:
					break;
				}
				KeyId = default;
				num = 9;
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
						case 1:
							goto end_IL_000e;
						case 2:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
							{
								num3 = 7;
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
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
							{
								num3 = 9;
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
		internal static bool ABV5hPDVyVNApeJpdYok()
		{
			return COvJRsDV8iYtyIBugexN == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static QlkS51LVjYAgrq49D34N CcukopDVWWwSJUDmG2rw()
		{
			return (QlkS51LVjYAgrq49D34N)COvJRsDV8iYtyIBugexN;
		}
	}

	[CompilerGenerated]
	private class __O_20
	{
		public static Func<char, bool> _0___IsWhiteSpace;

		internal static __O_20 RS8SuvDVJcrYgPHdXmeU;

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
						case 2:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 != 0)
							{
								num3 = 9;
							}
							continue;
						case 1:
							goto end_IL_000e;
						case 0:
							return;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							num3 = 2;
							continue;
						}
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				num = 3;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool fBmBSaDVQLHMuj7QVCvh()
		{
			return RS8SuvDVJcrYgPHdXmeU == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __O_20 nWQ2cqDVC62G0c4IliWx()
		{
			return RS8SuvDVJcrYgPHdXmeU;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_69
	{
		public static __c_69 __9;

		public static Func<AssemblyMetadataAttribute, string> __9__9_0;

		public static Func<AssemblyMetadataAttribute, string> __9__9_1;

		public static Func<char, bool> __9__9_2;

		private static __c_69 dAY9JhDV4g270pUD0Swe;

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
								goto case 2;
							}
							__9 = (__c_69)new __c_69();
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
							{
								num3 = 1;
							}
							continue;
						case 4:
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
							{
								num3 = 3;
							}
							continue;
						case 3:
							num3 = 2;
							continue;
						case 0:
							break;
						case 2:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 != 0)
							{
								num3 = 3;
							}
							continue;
						case 1:
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
				HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
				num = 11;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_69()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string EHXLVku4vXa(AssemblyMetadataAttribute x)
		{
			return (x).Key;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string AawLVV5TIu5(AssemblyMetadataAttribute x)
{
			// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool nmiLVYhdo1a(char character)
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
							if (num2 != 10)
							{
								if (num2 == 991)
								{
									goto end_IL_0010;
								}
								goto case 2;
							}
							return character != '-';
						case 0:
							if (character != '_')
							{
								break;
							}
							goto IL_00b1;
						case 2:
							if (char.IsAsciiLetterOrDigit(character))
							{
								num3 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto case 3;
						case 1:
							return false;
						case 3:
							{
								if (character != '.')
								{
									num3 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto IL_00b1;
							}
							IL_00b1:
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
				num = 10;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 != 0)
				{
					num = 10;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool raxlA3DVhWBTS791vRv1()
		{
			return dAY9JhDV4g270pUD0Swe == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_69 VrcrYoDVU53jmdPLI2AT()
		{
			return dAY9JhDV4g270pUD0Swe;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ComputeAsync_d__8 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<string> __t__builder;

		public Wr7eDkXG68SK2Y4qCpTK __4__this;

		public string message;

		public CancellationToken cancellationToken;

		private QlkS51LVjYAgrq49D34N _settings_5__2;

		private string _timestamp_5__3;

		private string _nonce_5__4;

		private byte[] _body_5__5;

		private HttpRequestMessage _request_5__6;

		private HttpResponseMessage _response_5__7;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__2;

		private static object Rak5o4DVraUbQTC2BUp4;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_12ac: Expected O, but got Unknown
			//IL_0216: Unknown result type (might be due to invalid IL or missing references)
			//IL_021b: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f6: Expected native int or pointer, but got O
			//IL_0325: Unknown result type (might be due to invalid IL or missing references)
			//IL_032a: Unknown result type (might be due to invalid IL or missing references)
			//IL_062a: Unknown result type (might be due to invalid IL or missing references)
			//IL_059a: Expected O, but got Ref
			//IL_055c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0271: Unknown result type (might be due to invalid IL or missing references)
			//IL_027d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0204: Unknown result type (might be due to invalid IL or missing references)
			//IL_0206: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a4e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a53: Unknown result type (might be due to invalid IL or missing references)
			//IL_0801: Unknown result type (might be due to invalid IL or missing references)
			//IL_0812: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a18: Expected O, but got Ref
			//IL_0aa0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d6c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d71: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cf1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e65: Expected O, but got Ref
			//IL_0c95: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ca6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e30: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e32: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c7a: Expected O, but got I4
			//IL_0bb3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bbd: Expected I4, but got Unknown
			//IL_0d19: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ea1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ea7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_116c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1172: Invalid comparison between Unknown and I4
			//IL_15ae->IL14a5: Incompatible stack heights: 3 vs 1
			//IL_15b9->IL14a5: Incompatible stack heights: 3 vs 1
			//IL_0151->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0605->IL0175: Incompatible stack heights: 2 vs 1
			//IL_0289->IL016d: Incompatible stack heights: 2 vs 1
			//IL_081e->IL06e1: Incompatible stack heights: 2 vs 1
			//IL_0cbc->IL0b30: Incompatible stack heights: 2 vs 1
			//IL_0c84->IL0b30: Incompatible stack heights: 2 vs 1
			//IL_0cc7->IL0b30: Incompatible stack heights: 2 vs 1
			int num = 10;
			Wr7eDkXG68SK2Y4qCpTK wr7eDkXG68SK2Y4qCpTK = default;
			int num4 = default;
			int num7 = default;
			ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _u__2 = default;
			string text5 = default;
			string canonical = default;
			ConfiguredTaskAwaitable<string> val4 = default;
			string text7 = default;
			ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter _u__ = default;
			int num25 = default;
			HttpResponseMessage response_5__ = default;
			ConfiguredTaskAwaitable<HttpResponseMessage> val5 = default;
			int num11 = default;
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default;
			string text = default;
			int num13 = default;
			int num15 = default;
			string text4 = default;
			JsonElement val3 = default;
			bool flag = default;
			int num16 = default;
			int num19 = default;
			int num21 = default;
			int num23 = default;
			int num27 = default;
			string text8 = default;
			int num30 = default;
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
							if (num2 != 17)
							{
								if (num2 == 998)
								{
									goto end_IL_0010;
								}
								goto case 0;
							}
							_body_5__5 = null;
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							_request_5__6 = null;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db != 0)
							{
								num3 = 7;
							}
							continue;
						case 4:
							break;
						case 7:
							_timestamp_5__3 = null;
							num3 = 4;
							continue;
						case 9:
							wr7eDkXG68SK2Y4qCpTK = __4__this;
							num3 = 13;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 != 0)
							{
								num3 = 2;
							}
							continue;
						case 3:
							_settings_5__2 = null;
							num3 = 7;
							continue;
						case 8:
							__1__state = -2;
							num3 = 3;
							continue;
						case 6:
							return;
						case 0:
							_response_5__7 = null;
							num3 = 5;
							continue;
						case 10:
							num4 = __1__state;
							num3 = 9;
							continue;
						case 5:
							_ = __t__builder;
							_ = 6;
							continue;
						case 2:
							try
							{
								int num5;
								if (num4 == 0)
								{
									num5 = 17;
									goto IL_016d;
								}
								goto IL_03d1;
								IL_02ff:
								int num6 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
								{
									num6 = 28;
								}
								goto IL_0175;
								IL_016d:
								num7 = num5;
								goto IL_0171;
								IL_0171:
								num6 = num7;
								goto IL_0175;
								IL_0175:
								while (true)
								{
									switch (num6)
									{
									case 5:
										return;
									case 25:
										__u__1 = _u__2;
										num6 = 9;
										continue;
									case 3:
									case 17:
										_u__2 = __u__1;
										num6 = 14;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
										{
											num6 = 13;
										}
										continue;
									case 23:
										goto end_IL_0175;
									case 22:
										goto IL_0298;
									case 2:
										goto IL_02ff;
									case 12:
									{
										DateTimeOffset val6 = System.DateTimeOffset.UtcNow;
										long num28 = (val6).ToUnixTimeSeconds();
										_timestamp_5__3 = (num28).ToString((IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture);
										num6 = 16;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
										{
											num6 = 14;
										}
										continue;
									}
									case 18:
										_body_5__5 = JsonSerializer.SerializeToUtf8Bytes<XbrZoPLVbYEVmv3QXLio>((XbrZoPLVbYEVmv3QXLio)new XbrZoPLVbYEVmv3QXLio(message), (JsonSerializerOptions)null);
										num6 = 33;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
										{
											num6 = 23;
										}
										continue;
									case 7:
										if (&_u__2 != null)
										{
											num6 = 24;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
											{
												num6 = 19;
											}
											continue;
										}
										goto case 21;
									case 15:
										goto IL_03d1;
									case 21:
										num4 = (__1__state = 0);
										num6 = 25;
										continue;
									case 1:
										text5 = yxnXGx3ur7q(_settings_5__2.ApiKey, canonical);
										num6 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
										{
											num6 = 4;
										}
										continue;
									case 0:
										goto IL_0450;
									case 13:
										goto IL_0506;
									case 16:
										_nonce_5__4 = sPTXGFSkEfM(System.Security.Cryptography.RandomNumberGenerator.GetBytes(18));
										num6 = 33;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
										{
											num6 = 18;
										}
										continue;
									case 20:
										_u__2 = val4;
										num6 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 != 0)
										{
											num6 = 27;
										}
										continue;
									case 9:
										__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, _ComputeAsync_d__8>(ref _u__2, ref this);
										num6 = 5;
										continue;
									case 19:
									case 24:
										text7 = (string)(&_u__2);
										num6 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
										{
											num6 = 22;
										}
										continue;
									case 11:
										goto IL_05b9;
									case 4:
									{
										HttpMethod obj3 = System.Net.Http.HttpMethod.Post;
										Uri endpoint = _settings_5__2.Endpoint;
										(endpoint).Content = (HttpContent)(object)_body_5__5;
										global::System.Runtime.CompilerServices.Unsafe.Write(&((_ComputeAsync_d__8*)(nint)obj3)->_request_5__6, endpoint);
										_ = 2;
										continue;
									}
									case 6:
										if (!string.IsNullOrWhiteSpace(message))
										{
											num6 = 22;
											continue;
										}
										goto case 10;
									case 14:
										__u__1 = default;
										num6 = 17;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
										{
											num6 = 11;
										}
										continue;
									case 10:
										_ = "基岩认证签名消息长度无效";
										throw new global::System.Exception("message");
									case 8:
										try
										{
											int num8;
											if (num4 != 1)
											{
												num8 = 9;
												goto IL_06e1;
											}
											goto IL_0a4d;
											IL_0a4d:
											_u__ = __u__2;
											num8 = 8;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
											{
												num8 = 11;
											}
											goto IL_06e1;
											IL_06e1:
											while (true)
											{
												int num24;
												switch (num8)
												{
												case 11:
													return;
												default:
													if (num25 != 27)
													{
														if (num25 == 1007)
														{
															goto IL_06dd;
														}
														goto case 15;
													}
													((_request_5__6).Headers).TryAddWithoutValidation("X-Signature", text5);
													num8 = 2;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 != 0)
													{
														num8 = 18;
													}
													continue;
												case 14:
													__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter, _ComputeAsync_d__8>(ref _u__, ref this);
													num8 = 11;
													continue;
												case 12:
													_response_5__7 = response_5__;
													num8 = 17;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
													{
														num8 = 3;
													}
													continue;
												case 1:
													(wr7eDkXG68SK2Y4qCpTK.SAjXGpFdts0).SendAsync(_request_5__6, cancellationToken);
													val5 = (ConfiguredTaskAwaitable<HttpResponseMessage>)0;
													_ = 7;
													continue;
												case 9:
													if (num4 != 2)
													{
														num8 = 19;
														continue;
													}
													goto case 17;
												case 18:
													((_request_5__6).Headers).TryAddWithoutValidation("X-Chronal-Authorization", text7);
													num8 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
													{
														num8 = 7;
													}
													continue;
												case 15:
													if (&_u__ == null)
													{
														num24 = 10;
														goto IL_06d9;
													}
													goto case 6;
												case 16:
													((_request_5__6).Headers).TryAddWithoutValidation("X-Sign-Timestamp", _timestamp_5__3);
													num24 = 2;
													goto IL_06d9;
												case 17:
													num24 = 13;
													goto IL_06d9;
												case 2:
													((_request_5__6).Headers).TryAddWithoutValidation("X-Sign-Nonce", _nonce_5__4);
													num24 = 27;
													goto IL_06d9;
												case 19:
												{
													HttpContentHeaders obj2 = ((_request_5__6).Content).Headers;
													string text6 = "application/json";
													(text6).CharSet = "utf-8";
													(obj2).ContentType = (MediaTypeHeaderValue)(object)text6;
													num8 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
													{
														num8 = 24;
													}
													continue;
												}
												case 5:
													__u__2 = _u__;
													num8 = 14;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 != 0)
													{
														num8 = 6;
													}
													continue;
												case 6:
													response_5__ = (HttpResponseMessage)(object)(&_u__);
													num8 = 12;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
													{
														num8 = 2;
													}
													continue;
												case 8:
													__u__2 = default;
													num8 = 3;
													continue;
												case 4:
													break;
												case 3:
													num4 = (__1__state = -1);
													num8 = 6;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee != 0)
													{
														num8 = 0;
													}
													continue;
												case 7:
													_u__ = val5;
													num24 = 15;
													goto IL_06d9;
												case 0:
													((_request_5__6).Headers).TryAddWithoutValidation("X-Sign-Key-Id", _settings_5__2.KeyId);
													num8 = 16;
													continue;
												case 10:
													num4 = (__1__state = 1);
													num24 = 5;
													goto IL_06d9;
												case 13:
													{
														try
														{
															int num9;
															if (num4 != 2)
															{
																num9 = 5;
																goto IL_0b28;
															}
															goto IL_0d6b;
															IL_0d6b:
															_u__2 = __u__1;
															int num10 = 26;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
															{
																num10 = 0;
															}
															goto IL_0b30;
															IL_0b28:
															num11 = num9;
															goto IL_0b2c;
															IL_0b2c:
															num10 = num11;
															goto IL_0b30;
															IL_0b30:
															while (true)
															{
																switch (num10)
																{
																case 18:
																	return;
																case 9:
																	goto end_IL_0b30;
																case 19:
																	if (&_u__2 != null)
																	{
																		goto IL_0bcf;
																	}
																	goto case 17;
																case 8:
																	num4 = (__1__state = -1);
																	num10 = 4;
																	continue;
																case 1:
																	(defaultInterpolatedStringHandler).AppendFormatted(ihXXGs8EhGX(text));
																	num10 = 11;
																	continue;
																case 11:
																	(defaultInterpolatedStringHandler).AppendLiteral("）");
																	num10 = 8;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
																	{
																		num10 = 10;
																	}
																	continue;
																case 7:
																	goto IL_0c74;
																case 5:
																	((_response_5__7).Content).ReadAsStringAsync(cancellationToken);
																	val4 = (ConfiguredTaskAwaitable<string>)0;
																	_ = 11;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
																	{
																		_ = 15;
																	}
																	continue;
																case 0:
																	__u__1 = default;
																	num10 = 18;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
																	{
																		num10 = 8;
																	}
																	continue;
																case 15:
																	_u__2 = val4;
																	num10 = 2;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
																	{
																		num10 = 19;
																	}
																	continue;
																case 2:
																	(defaultInterpolatedStringHandler).AppendLiteral("基岩认证签名服务请求失败（HTTP ");
																	num10 = 9;
																	continue;
																case 13:
																	goto IL_0d6b;
																case 17:
																	num4 = (__1__state = 2);
																	num10 = 7;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
																	{
																		num10 = 6;
																	}
																	continue;
																case 10:
																	throw (defaultInterpolatedStringHandler).ToStringAndClear();
																case 6:
																	__u__1 = _u__2;
																	num10 = 16;
																	continue;
																case 14:
																	goto IL_0e41;
																case 4:
																case 12:
																	text = (string)(&_u__2);
																	num10 = 14;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
																	{
																		num10 = 6;
																	}
																	continue;
																case 16:
																	__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, _ComputeAsync_d__8>(ref _u__2, ref this);
																	num10 = 18;
																	continue;
																case 3:
																	try
																	{
																		JsonDocument val = System.Text.Json.JsonDocument.Parse(text, default(JsonDocumentOptions));
																		int num12 = 1;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
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
																					goto IL_0ee2;
																				}
																				break;
																			case 0:
																				break;
																			}
																			break;
																			IL_0ee2:
																			num12 = num13;
																		}
																		try
																		{
																			JsonElement val2 = (val).RootElement;
																			int num14 = 0;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
																			{
																				num14 = 0;
																			}
																			while (true)
																			{
																				int num17;
																				object obj;
																				switch (num14)
																				{
																				default:
																					if (num15 != 24)
																					{
																						if (num15 == 1004)
																						{
																							goto IL_0f3e;
																						}
																						goto case 7;
																					}
																					goto case 11;
																				case 7:
																				case 12:
																					throw new global::System.Exception("基岩认证签名服务返回了无效 sign");
																				case 15:
																				{
																					string text3 = text4;
																					num14 = 1;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 != 0)
																					{
																						num14 = 2;
																					}
																					continue;
																				}
																				case 0:
																					if ((val2).TryGetProperty("sign", ref val3))
																					{
																						num14 = 2;
																						continue;
																					}
																					goto case 14;
																				case 11:
																					flag = true;
																					num14 = 13;
																					continue;
																				case 3:
																					if (num16 > 4096)
																					{
																						num17 = 24;
																						goto IL_0f3a;
																					}
																					goto case 6;
																				case 9:
																					if (num16 < 1)
																					{
																						num14 = 11;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
																						{
																							num14 = 7;
																						}
																						continue;
																					}
																					goto case 3;
																				case 6:
																					flag = false;
																					num14 = 16;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
																					{
																						num14 = 24;
																					}
																					continue;
																				case 5:
																					num16 = (text4).Length;
																					num17 = 9;
																					goto IL_0f3a;
																				case 13:
																				case 16:
																					if (flag)
																					{
																						num14 = 7;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 != 0)
																						{
																							num14 = 23;
																						}
																						continue;
																					}
																					goto case 10;
																				case 14:
																					throw new global::System.Exception("基岩认证签名服务未返回 sign");
																				case 2:
																					if ((int)(val3).ValueKind == 3)
																					{
																						string text2 = (val3).GetString();
																						if (text2 == null)
																						{
																							num14 = 8;
																							continue;
																						}
																						obj = (text2).Trim();
																						goto IL_1191;
																					}
																					num14 = 14;
																					continue;
																				case 8:
																					obj = null;
																					goto IL_1191;
																				case 4:
																					obj = string.Empty;
																					goto IL_11ac;
																				case 10:
																					if (!Enumerable.Any<char>((global::System.Collections.Generic.IEnumerable<char>)text4, __O_20._0___IsWhiteSpace ?? (__O_20._0___IsWhiteSpace = null)))
																					{
																						num14 = 15;
																						continue;
																					}
																					goto case 7;
																				case 1:
																					break;
																					IL_0f3e:
																					num14 = num15;
																					continue;
																					IL_1191:
																					if (obj != null)
																					{
																						goto IL_11ac;
																					}
																					num14 = 4;
																					continue;
																					IL_11ac:
																					text4 = (string)obj;
																					num14 = 5;
																					continue;
																					IL_0f3a:
																					num15 = num17;
																					goto IL_0f3e;
																				}
																				break;
																			}
																		}
																		finally
																		{
																			if (num4 < 0)
																			{
																				int num18 = 3;
																				while (true)
																				{
																					switch (num18)
																					{
																					default:
																						if (num19 == 991)
																						{
																							num18 = num19;
																							continue;
																						}
																						goto end_IL_120c;
																					case 2:
																						goto end_IL_120c;
																					case 3:
																						if (val == null)
																						{
																							num18 = 7;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
																							{
																								num18 = 2;
																							}
																							continue;
																						}
																						break;
																					case 1:
																						break;
																					case 0:
																						goto end_IL_120c;
																					}
																					(val).Dispose();
																					num18 = 0;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
																					{
																						num18 = 3;
																					}
																					continue;
																					end_IL_120c:
																					break;
																				}
																			}
																		}
																	}
																	catch (JsonException ex)
																	{
																		JsonException ex2 = ex;
																		int num20 = 0;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
																		{
																			num20 = 0;
																		}
																		while (true)
																		{
																			switch (num20)
																			{
																			default:
																				if (num21 == 988)
																				{
																					goto IL_12d9;
																				}
																				break;
																			case 0:
																				break;
																			}
																			break;
																			IL_12d9:
																			num20 = num21;
																		}
																		_ = "基岩认证签名服务响应格式无效";
																		throw ex2;
																	}
																	goto end_IL_0b0c;
																}
																if (num11 != 27)
																{
																	if (num11 == 1007)
																	{
																		goto IL_0b2c;
																	}
																	goto IL_0c74;
																}
																(defaultInterpolatedStringHandler).AppendLiteral("，");
																num10 = 1;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
																{
																	num10 = 13;
																}
																continue;
																IL_0e41:
																if ((_response_5__7).IsSuccessStatusCode)
																{
																	num10 = 3;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 != 0)
																	{
																		num10 = 25;
																	}
																}
																else
																{
																	num10 = 7;
																}
																continue;
																IL_0c74:
																_ = 20;
																defaultInterpolatedStringHandler = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)2;
																_ = 2;
																continue;
																end_IL_0b30:
																break;
															}
															defaultInterpolatedStringHandler.AppendFormatted<int>((int)(_response_5__7).StatusCode);
															num9 = 27;
															goto IL_0b28;
															IL_0bcf:
															num9 = 12;
															goto IL_0b28;
															end_IL_0b0c:;
														}
														finally
														{
															if (num4 < 0)
															{
																int num22 = 1;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
																{
																	num22 = 5;
																}
																while (true)
																{
																	switch (num22)
																	{
																	default:
																		if (num23 == 990)
																		{
																			num22 = num23;
																			continue;
																		}
																		break;
																	case 1:
																		if (_response_5__7 != null)
																		{
																			num22 = 7;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
																			{
																				num22 = 2;
																			}
																			continue;
																		}
																		break;
																	case 2:
																		(_response_5__7).Dispose();
																		num22 = 6;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
																		{
																			num22 = 0;
																		}
																		continue;
																	case 0:
																		break;
																	}
																	break;
																}
															}
														}
														goto end_IL_06e1;
													}
													IL_06dd:
													num8 = num25;
													continue;
													IL_06d9:
													num25 = num24;
													goto IL_06dd;
												}
												goto IL_0a4d;
												continue;
												end_IL_06e1:
												break;
											}
										}
										finally
										{
											if (num4 < 0)
											{
												int num26 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
												{
													num26 = 3;
												}
												while (true)
												{
													switch (num26)
													{
													default:
														if (num27 == 990)
														{
															num26 = num27;
															continue;
														}
														break;
													case 1:
														if (_request_5__6 != null)
														{
															num26 = 5;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
															{
																num26 = 0;
															}
															continue;
														}
														break;
													case 0:
														(_request_5__6).Dispose();
														num26 = 2;
														continue;
													case 2:
														break;
													}
													break;
												}
											}
										}
										goto end_IL_0152;
									}
									if (num7 != 33)
									{
										if (num7 == 1013)
										{
											goto IL_0171;
										}
										goto IL_0506;
									}
									canonical = string.Join('\n', new string[5]
									{
										"POST",
										(_settings_5__2.Endpoint).PathAndQuery,
										_timestamp_5__3,
										_nonce_5__4,
										text8
									});
									num6 = 25;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 != 0)
									{
										num6 = 1;
									}
									continue;
									IL_0298:
									if ((System.Text.Encoding.UTF8).GetByteCount(message) > 4096)
									{
										num6 = 29;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
										{
											num6 = 10;
										}
										continue;
									}
									goto IL_068d;
									IL_0506:
									System.ObjectDisposedException.ThrowIf(wr7eDkXG68SK2Y4qCpTK.tvhXG1xhY03, wr7eDkXG68SK2Y4qCpTK);
									num6 = 6;
									continue;
									end_IL_0175:
									break;
								}
								gdN15OthQEGrNdShYKc.Instance.KLVtoXgE6W((string)wr7eDkXG68SK2Y4qCpTK.jWcXGuBMyDo, "signature", xN1aUbtjf5iKKQHfiju.imDtkqLF3g((global::System.ReadOnlySpan<byte>)_body_5__5), cancellationToken);
								val4 = (ConfiguredTaskAwaitable<string>)0;
								_ = 20;
								goto IL_016d;
								IL_0450:
								text8 = (System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(_body_5__5))).ToLowerInvariant();
								num5 = 33;
								goto IL_016d;
								IL_03d1:
								if ((uint)(num4 - 1) > 1u)
								{
									num6 = 13;
									goto IL_0175;
								}
								goto IL_02ff;
								IL_05b9:
								num4 = (__1__state = -1);
								num5 = 19;
								goto IL_016d;
								IL_068d:
								_settings_5__2 = wr7eDkXG68SK2Y4qCpTK.jIFXGadyJvM ?? (wr7eDkXG68SK2Y4qCpTK.jIFXGadyJvM = d4xXGefpYnS());
								num5 = 12;
								goto IL_016d;
								end_IL_0152:;
							}
							catch (global::System.Exception)
							{
								int num29 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
								{
									num29 = 10;
								}
								while (true)
								{
									switch (num29)
									{
									case 6:
										return;
									default:
										if (num30 != 15)
										{
											if (num30 != 995)
											{
												break;
											}
											goto IL_14a1;
										}
										_nonce_5__4 = null;
										num29 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
										{
											num29 = 7;
										}
										continue;
									case 1:
										_response_5__7 = null;
										num29 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 != 0)
										{
											num29 = 8;
										}
										continue;
									case 2:
										_settings_5__2 = null;
										num29 = 3;
										continue;
									case 5:
										_request_5__6 = null;
										num29 = 13;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
										{
											num29 = 1;
										}
										continue;
									case 4:
										__1__state = -2;
										num29 = 2;
										continue;
									case 3:
										_timestamp_5__3 = null;
										num30 = 15;
										goto IL_14a1;
									case 0:
										_ = __t__builder;
										_ = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
										{
											_ = 6;
										}
										continue;
									case 7:
										break;
										IL_14a1:
										num29 = num30;
										continue;
									}
									_body_5__5 = null;
									num29 = 5;
								}
							}
							goto case 8;
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
				_nonce_5__4 = null;
				num = 17;
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
			int num = 2;
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
							if (num2 == 9)
							{
								xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
								num3 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto end_IL_0012;
						case 2:
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
							{
								num3 = 1;
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
				while (num2 == 990);
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
				{
					num = 2;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool OrDdBqDVoGAbmaswPox2()
		{
			return Rak5o4DVraUbQTC2BUp4 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object JSa888DVmJ4XYjaJrE5d()
		{
			return Rak5o4DVraUbQTC2BUp4;
		}
	}

	private readonly object SAjXGpFdts0;

	private readonly object jWcXGuBMyDo;

	private QlkS51LVjYAgrq49D34N? jIFXGadyJvM;

	private bool tvhXG1xhY03;

	internal static object wkfvxUZFLwU2oyOB1Edv;

	[MethodImpl((MethodImplOptions)8)]
	internal Wr7eDkXG68SK2Y4qCpTK(string authorizationServiceCode = "bedrock_launch")
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe global::System.Threading.Tasks.Task<string> wTLXGwo1Dq6(string message, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static QlkS51LVjYAgrq49D34N d4xXGefpYnS()
	{
		string text = default;
		byte[] array = (System.Text.Encoding.UTF8).GetBytes(text);
		((AsyncTaskMethodBuilder<Jx59f3qEugGU1B1mwyt>*)12)->AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<NYI398f5COw5dgT3xbBV>.ConfiguredTaskAwaiter, RaH7MLzTeomUtlPYRwZ._PrepareAuthRelayAsync_d__12>(ref this, ref this);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string K2tXGPhgqVV(object environmentName, object buildValue)
	{
		int num = 4;
		string text = default;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					object obj;
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
						obj = null;
						break;
					case 2:
						return text;
					case 4:
					{
						string text2 = System.Environment.GetEnvironmentVariable((string)environmentName);
						if (text2 != null)
						{
							obj = (text2).Trim();
							break;
						}
						goto end_IL_000c;
					}
					case 3:
						return (buildValue).Trim();
					case 1:
						throw string.Concat("缺少基岩认证签名配置 ", (string)environmentName);
					case 0:
						if (string.IsNullOrEmpty(text))
						{
							if (string.IsNullOrWhiteSpace((string)buildValue))
							{
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto case 3;
						}
						num3 = 2;
						continue;
					}
					text = (string)obj;
					num3 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
					{
						num3 = 8;
					}
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
	private static string yxnXGx3ur7q(object key, object canonical)
	{
		int num = 2;
		string result = default;
		byte[] array = default;
		int num4 = default;
		int num6 = default;
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
						result = (System.Convert.ToHexString(System.Security.Cryptography.HMACSHA256.HashData((byte[])key, array))).ToLowerInvariant();
						int num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 != 0)
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
					finally
					{
						System.Security.Cryptography.CryptographicOperations.ZeroMemory((global::System.Span<byte>)array);
						int num5 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 != 0)
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
					goto case 0;
				case 0:
					return result;
				case 2:
					break;
				}
				goto IL_0127;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_0127;
				IL_0127:
				array = (System.Text.Encoding.UTF8).GetBytes((string)canonical);
				num2 = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
				{
					num2 = 5;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string sPTXGFSkEfM(object value)
	{
		return (((System.Convert.ToBase64String((byte[])value)).TrimEnd('=')).Replace('+', '-')).Replace('/', '_');
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string ihXXGs8EhGX(object responseText)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Invalid comparison between Unknown and I4
		int num = 1;
		int num3 = default;
		int num5 = default;
		string result = default;
		JsonElement val3 = default;
		int num8 = default;
		int num10 = default;
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					JsonDocument val = System.Text.Json.JsonDocument.Parse((string)responseText, default(JsonDocumentOptions));
					int num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
					{
						num2 = 6;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							if (num3 == 989)
							{
								goto IL_0095;
							}
							break;
						case 0:
							break;
						case 1:
							goto end_IL_0099;
						}
						try
						{
							JsonElement val2 = (val).RootElement;
							int num4 = 4;
							while (true)
							{
								switch (num4)
								{
								default:
									switch (num5)
									{
									case 12:
										return result;
									case 992:
										break;
									default:
										goto end_IL_00e4;
									}
									goto IL_00e0;
								case 2:
								{
									result = (val3).GetString();
									int num6 = 12;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
									{
										num6 = 5;
									}
									num5 = num6;
									goto IL_00e0;
								}
								case 3:
									if (!string.IsNullOrWhiteSpace((val3).GetString()))
									{
										num4 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
										{
											num4 = 12;
										}
										continue;
									}
									break;
								case 1:
									if ((int)(val3).ValueKind == 3)
									{
										num4 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 != 0)
										{
											num4 = 3;
										}
										continue;
									}
									break;
								case 4:
									if ((val2).TryGetProperty("error", ref val3))
									{
										num4 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
										{
											num4 = 1;
										}
										continue;
									}
									break;
								case 0:
									break;
									IL_00e0:
									num4 = num5;
									continue;
									end_IL_00e4:
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
								num7 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
								{
									num7 = 2;
								}
								goto IL_0264;
							}
							goto IL_02ac;
							IL_0264:
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 == 990)
									{
										goto IL_0260;
									}
									goto end_IL_0264;
								case 2:
									goto end_IL_0264;
								case 0:
									break;
								case 1:
									goto end_IL_0264;
								}
								goto IL_02ac;
								IL_0260:
								num7 = num8;
								continue;
								end_IL_0264:
								break;
							}
							goto end_IL_022c;
							IL_02ac:
							(val).Dispose();
							num7 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
							{
								num7 = 1;
							}
							goto IL_0264;
							end_IL_022c:;
						}
						break;
						IL_0095:
						num2 = num3;
						continue;
						end_IL_0099:
						break;
					}
				}
				catch (JsonException)
				{
					int num9 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
					{
						num9 = 5;
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
				break;
			}
			break;
		}
		return "unknown_error";
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		_ = 0;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe;
		_ = 5;
		System.Security.Cryptography.CryptographicOperations.ZeroMemory((global::System.Span<byte>)jIFXGadyJvM.ApiKey);
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
							goto case 0;
						}
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
						{
							num3 = 2;
						}
						continue;
					case 2:
						return;
					case 0:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
						{
							num3 = 4;
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
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool RCJ5qGZFjq00Nv4GcCxS()
	{
		return wkfvxUZFLwU2oyOB1Edv == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Wr7eDkXG68SK2Y4qCpTK GBfxq2ZFZhO1g7mltHHd()
	{
		return (Wr7eDkXG68SK2Y4qCpTK)wkfvxUZFLwU2oyOB1Edv;
	}
}
