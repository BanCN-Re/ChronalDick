using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using Windows.Graphics.Imaging;
using Windows.Storage.Streams;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Services;

sealed class CaptchaOcrService : global::System.IDisposable
{
	private sealed class OcrConfiguration
	{
		[CompilerGenerated]
		private string[] _Charset_k__BackingField;

		[CompilerGenerated]
		private int[] _Image_k__BackingField;

		[CompilerGenerated]
		private int _Channel_k__BackingField;

		[CompilerGenerated]
		private float _Mean_k__BackingField;

		[CompilerGenerated]
		private float _StandardDeviation_k__BackingField;

		private static OcrConfiguration H2fL5WLGViIyvjiwa42U;

		[JsonPropertyName("charset")]
		public string[] Charset
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Charset_k__BackingField;
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
						_Charset_k__BackingField = value;
						obj2 = 1;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1df8e086d5ed471cbc378d2545a921c6 == 0)
						{
							obj2 = 0;
						}
					}
				}
			}
		}

		[JsonPropertyName("image")]
		public int[] Image
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Image_k__BackingField;
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
						_Image_k__BackingField = value;
						obj2 = 1;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7ef2723341c74c2b88836c43256b27b6 != 0)
						{
							obj2 = 0;
						}
					}
				}
			}
		}

		[JsonPropertyName("channel")]
		public int Channel
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Channel_k__BackingField;
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
						_Channel_k__BackingField = value;
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_70c2a79cb96d4e75a079385f00e7bf58 != 0)
						{
							obj2 = 3;
						}
					}
				}
			}
		}

		[JsonPropertyName("mean")]
		public float Mean
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Mean_k__BackingField;
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
						_Mean_k__BackingField = value;
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b45a6b8459fb4961b1724a2890d79f3a == 0)
						{
							obj2 = 1;
						}
					}
				}
			}
		}

		[JsonPropertyName("standardDeviation")]
		public float StandardDeviation
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _StandardDeviation_k__BackingField;
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
						_StandardDeviation_k__BackingField = value;
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_495680ddee4b4d2499de9ae6f49aa33c == 0)
						{
							obj2 = 0;
						}
					}
				}
			}
		}

		public int ModelInputWidth
		{
			[MethodImpl((MethodImplOptions)8)]
			get
			{
				//IL_000c: Expected O, but got I4
				//IL_001d: Expected I4, but got O
				//IL_0052->IL0010: Incompatible stack types: I4 vs O
				//IL_005d->IL0010: Incompatible stack types: I4 vs O
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
							if (((byte[])(object)Image)[0] <= 0)
							{
								obj2 = 0;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5d72748c192f4bab9e19ca961e9277d1 == 0)
								{
									obj2 = 0;
								}
								continue;
							}
							return ((byte[])(object)Image)[0];
						case 0:
							return 160;
						}
						break;
					}
				}
			}
		}

		public int ModelInputHeight
		{
			[MethodImpl((MethodImplOptions)8)]
			get
			{
				return ((byte[])(object)Image)[1];
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Validate()
		{
			//IL_000c: Expected O, but got I4
			//IL_0055: Expected I4, but got O
			//IL_0227: Unknown result type (might be due to invalid IL or missing references)
			//IL_0201->IL0010: Incompatible stack types: I4 vs O
			//IL_00b3->IL0010: Incompatible stack types: I4 vs O
			//IL_0090->IL0010: Incompatible stack types: I4 vs O
			//IL_010a->IL0010: Incompatible stack types: I4 vs O
			//IL_0182->IL0010: Incompatible stack types: I4 vs O
			//IL_00e7->IL0010: Incompatible stack types: I4 vs O
			//IL_01ba->IL0010: Incompatible stack types: I4 vs O
			//IL_0244->IL0010: Incompatible stack types: I4 vs O
			//IL_0160->IL0010: Incompatible stack types: I4 vs O
			//IL_020c->IL0010: Incompatible stack types: I4 vs O
			//IL_00be->IL0010: Incompatible stack types: I4 vs O
			//IL_018d->IL0010: Incompatible stack types: I4 vs O
			//IL_00f2->IL0010: Incompatible stack types: I4 vs O
			//IL_01c5->IL0010: Incompatible stack types: I4 vs O
			//IL_0124->IL0010: Incompatible stack types: I4 vs O
			int num = 12;
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
							if ((nint)obj != 22)
							{
								if ((nint)obj == 1003)
								{
									goto end_IL_0010;
								}
								goto case 7;
							}
							if (!(StandardDeviation <= 0f))
							{
								obj2 = 10;
								continue;
							}
							goto case 4;
						case 2:
							if (ModelInputWidth == 160)
							{
								obj2 = 8;
								continue;
							}
							goto case 4;
						case 1:
							if (((byte[])(object)Image)[1] <= 64)
							{
								obj2 = 17;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1282ca3a3b4d42dea9c5c692937e35bc != 0)
								{
									obj2 = 0;
								}
								continue;
							}
							goto case 4;
						case 8:
							if (float.IsFinite(Mean))
							{
								obj2 = 4;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_06766e6d2ea0449aad87692ee68d5840 == 0)
								{
									obj2 = 7;
								}
								continue;
							}
							goto case 4;
						case 3:
							if (Image.Length == 2)
							{
								obj2 = 15;
								continue;
							}
							goto case 4;
						case 11:
							if ((Charset[0] != " "))
							{
								obj2 = 14;
								continue;
							}
							goto case 3;
						case 6:
							if (((byte[])(object)Image)[1] > 0)
							{
								obj2 = 1;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0b81b3b6b3bc4c4a8075444d576cb8ec != 0)
								{
									obj2 = 1;
								}
								continue;
							}
							goto case 4;
						case 9:
							if (((byte[])(object)Image)[0] == 0)
							{
								obj2 = 10;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_dabc6698d5764018a5f86ef3b5a7871e != 0)
								{
									obj2 = 5;
								}
								continue;
							}
							goto case 6;
						case 15:
							if (((byte[])(object)Image)[0] >= -1)
							{
								num = 9;
								break;
							}
							goto case 4;
						case 0:
							if (64 % ((byte[])(object)Image)[1] != 0)
							{
								obj2 = 3;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_06766e6d2ea0449aad87692ee68d5840 == 0)
								{
									obj2 = 13;
								}
								continue;
							}
							goto case 2;
						case 4:
						case 5:
						case 13:
						case 14:
							throw new InvalidDataException("4399 OCR 配置内容无效");
						case 10:
							if (Channel == 1)
							{
								return;
							}
							obj2 = 4;
							continue;
						case 12:
							if (Charset.Length >= 2)
							{
								num = 11;
								break;
							}
							goto case 4;
						case 7:
							if (float.IsFinite(StandardDeviation))
							{
								num = 22;
								break;
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
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public OcrConfiguration()
		{
			//IL_007c: Expected I4, but got O
			//IL_0061->IL0073: Incompatible stack types: I4 vs O
			//IL_006c->IL0073: Incompatible stack types: I4 vs O
			_Charset_k__BackingField = global::System.Array.Empty<string>();
			_Image_k__BackingField = global::System.Array.Empty<int>();
			_StandardDeviation_k__BackingField = 1f;
			object obj = 0;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_efa7845a846a43508e861e510ac5e1d2 == 0)
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
		internal static bool XVbdEnLGYau9uucZkDkR()
		{
			return H2fL5WLGViIyvjiwa42U == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static OcrConfiguration YBWFvhLGS3mNvWeWKEAF()
		{
			return H2fL5WLGViIyvjiwa42U;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass13_0
	{
		public CaptchaOcrService __4__this;

		public CancellationToken cancellationToken;

		public DenseTensor<float> inputTensor;

		public global::System.Collections.Generic.IReadOnlyList<string> charset;

		public Func<DisposableNamedOnnxValue, bool> __9__1;

		private static __c__DisplayClass13_0 Dss8kALGcinWsXfRhAXt;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass13_0()
		{
			//IL_004c: Expected I4, but got O
			//IL_0031->IL0043: Incompatible stack types: I4 vs O
			//IL_003c->IL0043: Incompatible stack types: I4 vs O
			object obj = 1;
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
		internal unsafe string _RunInferenceAsync_b__0()
		{
			//IL_000c: Expected O, but got I4
			//IL_0025: Expected I4, but got O
			//IL_003b: Expected O, but got I4
			//IL_0498: Expected I4, but got O
			//IL_051c: Expected I4, but got O
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Expected O, but got I4
			//IL_00b2: Expected I4, but got O
			//IL_0432: Unknown result type (might be due to invalid IL or missing references)
			//IL_032d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ec: Expected O, but got I4
			//IL_022d: Expected I4, but got O
			//IL_046e->IL048b: Incompatible stack types: I4 vs O
			//IL_04f2->IL050f: Incompatible stack types: I4 vs O
			//IL_0479->IL048b: Incompatible stack types: I4 vs O
			//IL_04fd->IL050f: Incompatible stack types: I4 vs O
			//IL_04cb->IL048b: Incompatible stack types: I4 vs O
			//IL_054f->IL050f: Incompatible stack types: I4 vs O
			//IL_004f->IL0010: Incompatible stack types: I4 vs O
			//IL_0586->IL0010: Incompatible stack types: I4 vs O
			//IL_04d6->IL048b: Incompatible stack types: I4 vs O
			//IL_055a->IL050f: Incompatible stack types: I4 vs O
			//IL_005a->IL0010: Incompatible stack types: I4 vs O
			//IL_0591->IL0010: Incompatible stack types: I4 vs O
			//IL_0080->IL009d: Incompatible stack types: I4 vs O
			//IL_008b->IL009d: Incompatible stack types: I4 vs O
			//IL_011e->IL009d: Incompatible stack types: I4 vs O
			//IL_014d->IL009d: Incompatible stack types: I4 vs O
			//IL_0158->IL009d: Incompatible stack types: I4 vs O
			//IL_00f9->IL009d: Incompatible stack types: I4 vs O
			//IL_0104->IL009d: Incompatible stack types: I4 vs O
			//IL_01d3->IL01f0: Incompatible stack types: I4 vs O
			//IL_01de->IL01f0: Incompatible stack types: I4 vs O
			//IL_03d0->IL01f0: Incompatible stack types: I4 vs O
			//IL_0373->IL01f0: Incompatible stack types: I4 vs O
			//IL_0276->IL01f0: Incompatible stack types: I4 vs O
			//IL_02a6->IL01f0: Incompatible stack types: I4 vs O
			//IL_03db->IL01f0: Incompatible stack types: I4 vs O
			//IL_034b->IL01f0: Incompatible stack types: I4 vs O
			//IL_037e->IL01f0: Incompatible stack types: I4 vs O
			//IL_0281->IL01f0: Incompatible stack types: I4 vs O
			//IL_044e->IL01f0: Incompatible stack types: I4 vs O
			//IL_0417->IL01f0: Incompatible stack types: I4 vs O
			//IL_0356->IL01f0: Incompatible stack types: I4 vs O
			object obj = 1;
			bool obj3 = default;
			dynamic result = default(object);
			object initializationLock = default(object);
			dynamic obj5 = default(object);
			dynamic obj13 = default(object);
			dynamic obj11 = default(object);
			dynamic obj9 = default(object);
			object obj10 = default(object);
			dynamic obj12 = default(object);
			global::System.ReadOnlySpan<int> dimensions = default(global::System.ReadOnlySpan<int>);
			dynamic obj6 = default(object);
			object obj15 = default(object);
			dynamic obj17 = default(object);
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
						goto case 0;
					case 0:
						obj3 = false;
						obj2 = 2;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_384fbdc0d71943e1a4f9f50f53afad51 != 0)
						{
							obj2 = 4;
						}
						break;
					case 3:
						return (string)result;
					case 2:
						try
						{
							System.Threading.Monitor.Enter(initializationLock, ref obj3);
							dynamic obj4 = 5;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f1dd9923a6bd42d5867c8e2e591d3e3b != 0)
							{
								obj4 = 1;
							}
							while (true)
							{
								switch ((int)obj4)
								{
								default:
									if ((nint)obj5 != 11)
									{
										if ((nint)obj5 == 991)
										{
											goto IL_0099;
										}
										goto case 3;
									}
									try
									{
										(cancellationToken).ThrowIfCancellationRequested();
										dynamic obj7 = 4;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f3d80f367d504e3d9064e4cfb99ce343 == 0)
										{
											obj7 = 3;
										}
										while (true)
										{
											int num;
											switch ((int)obj7)
											{
											default:
												if ((nint)obj13 != 21)
												{
													if ((nint)obj13 == 1001)
													{
														goto IL_01ec;
													}
													goto case 4;
												}
												obj11 = obj9 as Tensor<float>;
												num = 10;
												goto IL_01e8;
											case 11:
												obj10 = DecodeCtcIndices(Enumerable.ToArray<long>((global::System.Collections.Generic.IEnumerable<long>)obj12), charset);
												obj7 = 4;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_a2042ba402cd4aaf989f075337c5eaf7 != 0)
												{
													obj7 = 1;
												}
												continue;
											case 13:
												obj10 = DecodeCtcScores(dimensions.ToArray(), Enumerable.ToArray<float>((global::System.Collections.Generic.IEnumerable<float>)obj11), charset);
												obj7 = 8;
												continue;
											case 10:
												if (obj11 != null)
												{
													num = 7;
													goto IL_01e8;
												}
												goto case 6;
											case 6:
											case 12:
												throw new InvalidDataException("4399 OCR 输出类型无效");
											case 4:
											case 8:
												result = obj10;
												obj7 = 7;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ef04e2823b234f2aa7c3630bcaafe597 == 0)
												{
													obj7 = 1;
												}
												continue;
											case 9:
												obj12 = obj9 as Tensor<long>;
												obj7 = 16;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_916ae56933ff4374af011c79e3cb023a != 0)
												{
													obj7 = 0;
												}
												continue;
											case 0:
												if (obj12 == null)
												{
													num = 4;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_a1a3680c38d4488598afb1defd71e635 == 0)
													{
														num = 21;
													}
													goto IL_01e8;
												}
												goto case 11;
											case 2:
											case 7:
												dimensions = ((Tensor<float>)obj11).Dimensions;
												obj7 = 14;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f3d80f367d504e3d9064e4cfb99ce343 == 0)
												{
													obj7 = 13;
												}
												continue;
											case 3:
											{
												DisposableNamedOnnxValue obj8 = Enumerable.SingleOrDefault<DisposableNamedOnnxValue>((global::System.Collections.Generic.IEnumerable<DisposableNamedOnnxValue>)obj6, (Func<DisposableNamedOnnxValue, bool>)([MethodImpl((MethodImplOptions)8)] (DisposableNamedOnnxValue value) => ((value).Name == __4__this._outputName)));
												if (obj8 == null)
												{
													obj7 = 5;
													continue;
												}
												obj9 = (obj8).Value;
												obj7 = 9;
												continue;
											}
											case 5:
												throw new InvalidDataException("4399 OCR 输出缺失");
											case 1:
												break;
												IL_01ec:
												obj7 = obj13;
												continue;
												IL_01e8:
												obj13 = num;
												goto IL_01ec;
											}
											break;
										}
									}
									finally
									{
										if (obj6 != null)
										{
											dynamic obj14 = 4;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_cb74c857a9564cc0b30907ecfe1e0cdf != 0)
											{
												obj14 = 1;
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
												case 1:
													break;
												case 0:
													goto end_IL_048b;
												}
												((dynamic)obj6).Dispose();
												obj14 = 1;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_db2c7dd1aabc4c9a97a36e710c0128ab != 0)
												{
													obj14 = 0;
												}
												continue;
												end_IL_048b:
												break;
											}
										}
									}
									goto end_IL_009d;
								case 2:
								{
									InferenceSession? session = __4__this._session;
									if (session == null)
									{
										obj4 = 7;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_29300ae0ec1d42aeac4a5187ea9fcbba == 0)
										{
											obj4 = 3;
										}
										break;
									}
									obj6 = (session).Run((global::System.Collections.Generic.IReadOnlyCollection<NamedOnnxValue>)(object)new NamedOnnxValue[1] { NamedOnnxValue.CreateFromTensor<float>(__4__this._inputName, (Tensor<float>)(object)inputTensor) });
									obj5 = 11;
									goto IL_0099;
								}
								case 0:
									(cancellationToken).ThrowIfCancellationRequested();
									obj4 = 2;
									break;
								case 1:
									System.ObjectDisposedException.ThrowIf(__4__this._disposed, __4__this);
									obj4 = 0;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0c88e6c08eaf4e998e8fdd2c544cee2e == 0)
									{
										obj4 = 6;
									}
									break;
								case 3:
									{
										throw new InvalidOperationException("4399 OCR 模型尚未初始化");
									}
									IL_0099:
									obj4 = obj5;
									break;
								}
								continue;
								end_IL_009d:
								break;
							}
						}
						finally
						{
							if (obj3 != null)
							{
								dynamic obj16 = 1;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_28a8309f77124973ab9263f59df1f564 == 0)
								{
									obj16 = 3;
								}
								while (true)
								{
									switch ((int)obj16)
									{
									default:
										if ((nint)obj17 == 989)
										{
											obj16 = obj17;
											continue;
										}
										break;
									case 1:
										break;
									case 0:
										goto end_IL_050f;
									}
									System.Threading.Monitor.Exit(initializationLock);
									obj16 = 0;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_fd6fdaa7d4824d4c9cf1c9399aa7f204 != 0)
									{
										obj16 = 0;
									}
									continue;
									end_IL_050f:
									break;
								}
							}
						}
						goto case 3;
					case 1:
						initializationLock = __4__this._initializationLock;
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_13568c2ecd3e40679d0e8ed63093dad4 != 0)
						{
							obj2 = 6;
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
		internal bool _RunInferenceAsync_b__1(DisposableNamedOnnxValue value)
		{
			return ((value).Name == __4__this._outputName);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool k7xJMoLG0jO1YqOHKe8o()
		{
			return Dss8kALGcinWsXfRhAXt == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass13_0 HIm0WXLG8o5Nleyvpytm()
		{
			return Dss8kALGcinWsXfRhAXt;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass15_0_3
	{
		public global::System.Collections.Generic.IReadOnlyList<string> charset;

		public int classAxis;

		public int[] dimensions;

		public int batchAxis;

		internal static __c__DisplayClass15_0_3 rPPS0SLGyi54QUxwAg0q;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass15_0_3()
		{
			//IL_004c: Expected I4, but got O
			//IL_0031->IL0043: Incompatible stack types: I4 vs O
			//IL_003c->IL0043: Incompatible stack types: I4 vs O
			object obj = 0;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f651726544964479b0083c2c6dbce1d1 != 0)
			{
				obj = 4;
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
		internal bool _DecodeCtcScores_b__0(int dimension)
		{
			return dimension == ((global::System.Collections.Generic.IReadOnlyCollection<string>)charset).Count;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _DecodeCtcScores_b__1(int index)
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_005e->IL0010: Incompatible stack types: I4 vs O
			//IL_0069->IL0010: Incompatible stack types: I4 vs O
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
						return ((byte[])(object)dimensions)[index] == 1;
					case 1:
						break;
					}
					goto IL_003e;
					IL_001d:
					if ((nint)obj == 989)
					{
						break;
					}
					goto IL_003e;
					IL_003e:
					if (index == classAxis)
					{
						return false;
					}
					obj2 = 4;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4fafd75e484e4b31a74460f9f0d54951 != 0)
					{
						obj2 = 0;
					}
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _DecodeCtcScores_b__2(int index)
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
						if ((nint)obj == 989)
						{
							goto end_IL_0010;
						}
						goto case 0;
					case 1:
						if (index == classAxis)
						{
							return false;
						}
						obj2 = 6;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4abb095abaf846009b4cca8873b94957 == 0)
						{
							obj2 = 0;
						}
						break;
					case 0:
						return index != batchAxis;
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
		internal static bool l6h7fcLGWN1JuiaAGh3p()
		{
			return rPPS0SLGyi54QUxwAg0q == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass15_0_3 H8yT8FLGJHJxE2pjdRnB()
		{
			return rPPS0SLGyi54QUxwAg0q;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _CreateInputTensorAsync_d__12 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<DenseTensor<float>> __t__builder;

		public OcrConfiguration configuration;

		public string base64Image;

		public CancellationToken cancellationToken;

		private int _modelInputWidth_5__2;

		private int _modelInputHeight_5__3;

		private int _verticalReduction_5__4;

		private InMemoryRandomAccessStream _stream_5__5;

		private ConfiguredTaskAwaitable<uint>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable<BitmapDecoder>.ConfiguredTaskAwaiter __u__2;

		private ConfiguredTaskAwaitable<PixelDataProvider>.ConfiguredTaskAwaiter __u__3;

		private static object f0umq8LGQJtgIjRL0Mnv;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_000c: Expected O, but got I4
			//IL_0be7: Expected O, but got I4
			//IL_0029: Expected I4, but got O
			//IL_0c98: Expected O, but got I4
			//IL_0b3c: Expected I4, but got O
			//IL_0bfc: Expected I4, but got O
			//IL_00a6: Expected O, but got I4
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected I4, but got O
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Expected O, but got Unknown
			//IL_021a: Expected I4, but got O
			//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0600: Expected O, but got Unknown
			//IL_0965: Unknown result type (might be due to invalid IL or missing references)
			//IL_096c: Expected O, but got Unknown
			//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_07af: Expected O, but got Unknown
			//IL_0232: Expected O, but got I4
			//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ba: Expected O, but got Unknown
			//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_08be: Expected O, but got Unknown
			//IL_067e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0681: Unknown result type (might be due to invalid IL or missing references)
			//IL_0691: Unknown result type (might be due to invalid IL or missing references)
			//IL_069d: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ab: Expected F4, but got Unknown
			//IL_080c: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e9: Expected O, but got I4
			//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d9: Expected O, but got Unknown
			//IL_04bf: Expected O, but got I4
			//IL_0991: Unknown result type (might be due to invalid IL or missing references)
			//IL_0875: Unknown result type (might be due to invalid IL or missing references)
			//IL_0880: Unknown result type (might be due to invalid IL or missing references)
			//IL_0887: Expected O, but got Unknown
			//IL_09d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_09da: Expected O, but got Unknown
			//IL_0a8b: Expected O, but got I4
			//IL_09f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a07: Expected O, but got Unknown
			//IL_0a43: Expected O, but got I4
			//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06db: Expected O, but got Unknown
			//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e8: Expected O, but got Unknown
			//IL_08cb: Expected O, but got I4
			//IL_037a: Unknown result type (might be due to invalid IL or missing references)
			//IL_037d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0380: Expected O, but got Unknown
			//IL_04d3: Expected O, but got I4
			//IL_059f: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a6: Expected O, but got Unknown
			//IL_050a: Expected O, but got I4
			//IL_0458: Unknown result type (might be due to invalid IL or missing references)
			//IL_045b: Expected O, but got Unknown
			//IL_047f: Expected O, but got I4
			//IL_0ab0: Unknown result type (might be due to invalid IL or missing references)
			//IL_063a: Unknown result type (might be due to invalid IL or missing references)
			//IL_077c: Unknown result type (might be due to invalid IL or missing references)
			//IL_073c: Unknown result type (might be due to invalid IL or missing references)
			//IL_073d: Invalid comparison between I4 and Unknown
			//IL_0519: Expected O, but got I4
			//IL_08dc: Expected O, but got F4
			//IL_08a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ac5: Expected O, but got I4
			//IL_0430: Unknown result type (might be due to invalid IL or missing references)
			//IL_0997: Unknown result type (might be due to invalid IL or missing references)
			//IL_099c: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ac: Expected O, but got Unknown
			//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b9: Expected O, but got Unknown
			//IL_09b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c5: Expected O, but got Unknown
			//IL_09c7: Expected O, but got Unknown
			//IL_032b: Expected I4, but got O
			//IL_0bce->IL0beb: Incompatible stack types: I4 vs O
			//IL_0b0a->IL0b27: Incompatible stack types: I4 vs O
			//IL_0bd9->IL0beb: Incompatible stack types: I4 vs O
			//IL_0b15->IL0b27: Incompatible stack types: I4 vs O
			//IL_0c61->IL0beb: Incompatible stack types: I4 vs O
			//IL_0bac->IL0b27: Incompatible stack types: I4 vs O
			//IL_0c6c->IL0beb: Incompatible stack types: I4 vs O
			//IL_0c34->IL0beb: Incompatible stack types: I4 vs O
			//IL_0b64->IL0b27: Incompatible stack types: I4 vs O
			//IL_0bb7->IL0b27: Incompatible stack types: I4 vs O
			//IL_0cc9->IL0010: Incompatible stack types: I4 vs O
			//IL_0cac->IL0010: Incompatible stack types: I4 vs O
			//IL_0065->IL0010: Incompatible stack types: I4 vs O
			//IL_0cb7->IL0010: Incompatible stack types: I4 vs O
			//IL_0070->IL0010: Incompatible stack types: I4 vs O
			//IL_008d->IL00aa: Incompatible stack types: I4 vs O
			//IL_0098->IL00aa: Incompatible stack types: I4 vs O
			//IL_0130->IL00aa: Incompatible stack types: I4 vs O
			//IL_010b->IL00aa: Incompatible stack types: I4 vs O
			//IL_013b->IL00aa: Incompatible stack types: I4 vs O
			//IL_017c->IL00aa: Incompatible stack types: I4 vs O
			//IL_01bb->IL00aa: Incompatible stack types: I4 vs O
			//IL_01ed->IL00aa: Incompatible stack types: I4 vs O
			//IL_0187->IL00aa: Incompatible stack types: I4 vs O
			//IL_0614->IL0236: Incompatible stack types: I4 vs O
			//IL_0224->IL0236: Incompatible stack types: I4 vs O
			//IL_061f->IL0236: Incompatible stack types: I4 vs O
			//IL_03ce->IL0236: Incompatible stack types: I4 vs O
			//IL_08c8->IL0236: Incompatible stack types: I4 vs O
			//IL_06b5->IL0236: Incompatible stack types: I4 vs O
			//IL_0809->IL0236: Incompatible stack types: I4 vs O
			//IL_0825->IL0236: Incompatible stack types: I4 vs O
			//IL_08fd->IL0236: Incompatible stack types: I4 vs O
			//IL_05ed->IL0236: Incompatible stack types: I4 vs O
			//IL_04ce->IL0236: Incompatible stack types: I4 vs O
			//IL_084d->IL0236: Incompatible stack types: I4 vs O
			//IL_089b->IL0236: Incompatible stack types: I4 vs O
			//IL_03ff->IL0236: Incompatible stack types: I4 vs O
			//IL_0a79->IL0236: Incompatible stack types: I4 vs O
			//IL_09e4->IL0236: Incompatible stack types: I4 vs O
			//IL_0a3e->IL0236: Incompatible stack types: I4 vs O
			//IL_0a9f->IL0236: Incompatible stack types: I4 vs O
			//IL_056e->IL0236: Incompatible stack types: I4 vs O
			//IL_0a1b->IL0236: Incompatible stack types: I4 vs O
			//IL_0a52->IL0236: Incompatible stack types: I4 vs O
			//IL_06e5->IL0236: Incompatible stack types: I4 vs O
			//IL_04fc->IL0236: Incompatible stack types: I4 vs O
			//IL_038a->IL0236: Incompatible stack types: I4 vs O
			//IL_04e2->IL0236: Incompatible stack types: I4 vs O
			//IL_05b0->IL0236: Incompatible stack types: I4 vs O
			//IL_0514->IL0236: Incompatible stack types: I4 vs O
			//IL_046f->IL0236: Incompatible stack types: I4 vs O
			//IL_048e->IL0236: Incompatible stack types: I4 vs O
			//IL_0ac0->IL0236: Incompatible stack types: I4 vs O
			//IL_0528->IL0236: Incompatible stack types: I4 vs O
			//IL_08b8->IL0236: Incompatible stack types: I4 vs O
			//IL_093b->IL0236: Incompatible stack types: I4 vs O
			//IL_07cb->IL0236: Incompatible stack types: I4 vs O
			//IL_0ade->IL0236: Incompatible stack types: I4 vs O
			//IL_044a->IL0236: Incompatible stack types: I4 vs O
			//IL_03d9->IL0236: Incompatible stack types: I4 vs O
			//IL_04af->IL0236: Incompatible stack types: I4 vs O
			//IL_0830->IL0236: Incompatible stack types: I4 vs O
			//IL_0908->IL0236: Incompatible stack types: I4 vs O
			//IL_05f8->IL0236: Incompatible stack types: I4 vs O
			//IL_0858->IL0236: Incompatible stack types: I4 vs O
			//IL_072a->IL0236: Incompatible stack types: I4 vs O
			//IL_08a6->IL0236: Incompatible stack types: I4 vs O
			//IL_07a7->IL0236: Incompatible stack types: I4 vs O
			//IL_040a->IL0236: Incompatible stack types: I4 vs O
			//IL_0a84->IL0236: Incompatible stack types: I4 vs O
			//IL_0aaa->IL0236: Incompatible stack types: I4 vs O
			//IL_0579->IL0236: Incompatible stack types: I4 vs O
			//IL_0a26->IL0236: Incompatible stack types: I4 vs O
			//IL_09d1->IL0236: Incompatible stack types: I4 vs O
			//IL_0507->IL0236: Incompatible stack types: I4 vs O
			//IL_0674->IL0236: Incompatible stack types: I4 vs O
			//IL_05d0->IL0236: Incompatible stack types: I4 vs O
			//IL_070a->IL0236: Incompatible stack types: I4 vs O
			//IL_047a->IL0236: Incompatible stack types: I4 vs O
			//IL_091f->IL0236: Incompatible stack types: I4 vs O
			//IL_065e->IL0236: Incompatible stack types: I4 vs O
			//IL_074c->IL0236: Incompatible stack types: I4 vs O
			//IL_03a1->IL0236: Incompatible stack types: I4 vs O
			//IL_0946->IL0236: Incompatible stack types: I4 vs O
			//IL_0ae9->IL0236: Incompatible stack types: I4 vs O
			//IL_0776->IL0236: Incompatible stack types: I4 vs O
			//IL_0455->IL0236: Incompatible stack types: I4 vs O
			//IL_04ba->IL0236: Incompatible stack types: I4 vs O
			//IL_0735->IL0236: Incompatible stack types: I4 vs O
			int num = 3;
			int obj3 = default(int);
			dynamic obj5 = default(object);
			object obj23 = default(object);
			dynamic obj21 = default(object);
			dynamic obj22 = default(object);
			dynamic obj19 = default(object);
			dynamic obj14 = default(object);
			dynamic obj13 = default(object);
			dynamic obj17 = default(object);
			object obj10 = default(object);
			dynamic obj7 = default(object);
			dynamic obj8 = default(object);
			dynamic result = default(object);
			object obj15 = default(object);
			dynamic obj18 = default(object);
			object obj20 = default(object);
			dynamic obj12 = default(object);
			object result2 = default(object);
			object obj16 = default(object);
			dynamic obj11 = default(object);
			dynamic obj9 = default(object);
			object obj25 = default(object);
			object obj27 = default(object);
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
								return;
							}
							goto end_IL_0010;
						case 4:
							_stream_5__5 = null;
							obj2 = 1;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_481dc375f7e24d3cb0e875f941fcda75 != 0)
							{
								obj2 = 2;
							}
							continue;
						case 2:
							try
							{
								object obj4;
								if ((nuint)(nint)obj3 > (nuint)2u)
								{
									obj4 = 1;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ec9f1bd7108f411daeb83b57baf2dba0 == 0)
									{
										obj4 = 4;
									}
									goto IL_00aa;
								}
								goto IL_01bb;
								IL_01ed:
								_verticalReduction_5__4 = 64 / _modelInputHeight_5__3;
								int num2 = 7;
								goto IL_00a2;
								IL_00a2:
								obj5 = num2;
								goto IL_00a6;
								IL_00aa:
								while (true)
								{
									switch ((int)obj4)
									{
									case 4:
										_modelInputHeight_5__3 = configuration.ModelInputHeight;
										obj4 = 3;
										continue;
									case 1:
										_modelInputWidth_5__2 = configuration.ModelInputWidth;
										obj4 = 2;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9a1f67b15040430199ec9dc1289e168b != 0)
										{
											obj4 = 4;
										}
										continue;
									case 5:
										goto IL_013b;
									case 7:
										goto end_IL_00aa;
									case 2:
										goto IL_01a3;
									case 0:
										goto IL_01bb;
									case 6:
										goto IL_01db;
									case 3:
										goto IL_01ed;
									}
									if ((nint)obj5 != 15)
									{
										if ((nint)obj5 == 995)
										{
											goto IL_00a6;
										}
										goto IL_01db;
									}
									try
									{
										object obj6;
										int num3;
										switch ((int)obj3)
										{
										default:
											obj6 = 17;
											goto IL_0236;
										case 0:
											goto IL_05f8;
										case 2:
											goto IL_07a7;
										case 1:
											goto IL_0964;
											IL_0236:
											while (true)
											{
												switch ((int)obj6)
												{
												default:
													if ((nint)obj23 != 67)
													{
														goto IL_0339;
													}
													goto case 46;
												case 51:
													break;
												case 33:
													obj21 += (float)((short[])obj22)[(int)obj19 + 2];
													obj6 = 30;
													continue;
												case 52:
												case 53:
													if ((nint)obj14 >= _modelInputWidth_5__2)
													{
														obj6 = 40;
														continue;
													}
													goto IL_08d5;
												case 2:
													obj19 = ((obj13 * _verticalReduction_5__4 + obj17) * 160 + obj14) * 4;
													obj6 = 26;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_d2995c01469b4ef28b5784f7cbf606e2 != 0)
													{
														obj6 = 33;
													}
													continue;
												case 19:
													(_stream_5__5).Seek(0uL);
													obj6 = 25;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_24238b39bba94b6aa4d3c2739f061133 != 0)
													{
														obj6 = 23;
													}
													continue;
												case 27:
													goto IL_040a;
												case 59:
													__u__2 = default(ConfiguredTaskAwaitable<BitmapDecoder>.ConfiguredTaskAwaiter);
													obj6 = 49;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bb37d0226fdb41f1902e558a997d9dc6 != 0)
													{
														obj6 = 30;
													}
													continue;
												case 40:
													obj13++;
													obj6 = 7;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5616e31a21b646f69463de8959779c49 == 0)
													{
														obj6 = 39;
													}
													continue;
												case 41:
													obj3 = 1;
													__1__state = 1;
													obj6 = 54;
													continue;
												case 7:
												case 43:
													if ((nint)obj13 >= _modelInputHeight_5__3)
													{
														obj6 = 30;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_861620835107408fad0813077d9e9967 == 0)
														{
															obj6 = 5;
														}
														continue;
													}
													goto case 38;
												case 11:
													obj3 = 0;
													__1__state = 0;
													obj6 = 56;
													continue;
												case 35:
													obj3 = 2;
													__1__state = 2;
													obj6 = 8;
													continue;
												case 30:
													obj17++;
													obj6 = 46;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1df8e086d5ed471cbc378d2545a921c6 != 0)
													{
														obj6 = 66;
													}
													continue;
												case 38:
													obj14 = 0;
													obj6 = 52;
													continue;
												case 49:
													obj3 = -1;
													__1__state = -1;
													obj6 = 14;
													continue;
												case 13:
													return;
												case 24:
													__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<uint>.ConfiguredTaskAwaiter, _CreateInputTensorAsync_d__12>(ref __u__1, ref this);
													obj6 = 44;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0d16903d89da4928a5d60c2843281188 == 0)
													{
														obj6 = 15;
													}
													continue;
												case 15:
													return;
												case 37:
													obj7 = ((ConfiguredTaskAwaitable<PixelDataProvider>)obj8).GetAwaiter();
													obj6 = 34;
													continue;
												case 36:
													if (((dynamic)result).PixelWidth <= 2048)
													{
														obj6 = 27;
														continue;
													}
													goto case 12;
												case 10:
													obj10 = ((ConfiguredTaskAwaitable<uint>)obj15).GetAwaiter();
													obj6 = 25;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b8376d7b20c44b95a06e50039002465d != 0)
													{
														obj6 = 39;
													}
													continue;
												case 1:
													goto IL_05f8;
												case 44:
													throw new InvalidDataException("验证码像素数据长度无效");
												case 34:
													if (!((ConfiguredTaskAwaitable<PixelDataProvider>.ConfiguredTaskAwaiter)obj7).IsCompleted)
													{
														obj6 = 35;
														continue;
													}
													goto case 20;
												case 4:
													((float[])obj18)[obj13 * _modelInputWidth_5__2 + obj14] = (obj21 / (255f * (float)_verticalReduction_5__4) - configuration.Mean) / configuration.StandardDeviation;
													obj6 = 3;
													continue;
												case 29:
													obj8 = WindowsRuntimeSystemExtensions.AsTask<PixelDataProvider>(((dynamic)result).GetPixelDataAsync((BitmapPixelFormat)87, (BitmapAlphaMode)2, (BitmapTransform)obj20, (ExifOrientationMode)0, (ColorManagementMode)0), cancellationToken).ConfigureAwait(false);
													obj6 = 37;
													continue;
												case 39:
													if (!((ConfiguredTaskAwaitable<uint>.ConfiguredTaskAwaiter)obj10).IsCompleted)
													{
														obj6 = 11;
														continue;
													}
													goto case 55;
												case 16:
													if (((ConfiguredTaskAwaitable<BitmapDecoder>.ConfiguredTaskAwaiter)obj12).IsCompleted)
													{
														obj6 = 47;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_c4494c1a50534bb9a384a17479cb6f24 != 0)
														{
															obj6 = 3;
														}
														continue;
													}
													goto case 41;
												case 48:
													goto IL_0735;
												case 6:
													return;
												case 58:
													if (((dynamic)result).PixelWidth != 0)
													{
														obj6 = 18;
														continue;
													}
													goto case 12;
												case 45:
													goto IL_0776;
												case 18:
													if (((dynamic)result).PixelHeight != 0)
													{
														obj6 = 36;
														continue;
													}
													goto case 12;
												case 26:
													goto IL_07a7;
												case 56:
													__u__1 = (ConfiguredTaskAwaitable<uint>.ConfiguredTaskAwaiter)obj10;
													obj6 = 24;
													continue;
												case 5:
													result2 = new DenseTensor<float>((global::System.Memory<float>)(float[])obj18, new int[4] { 1, 1, _modelInputHeight_5__3, _modelInputWidth_5__2 }, false);
													obj6 = 31;
													continue;
												case 8:
													__u__3 = (ConfiguredTaskAwaitable<PixelDataProvider>.ConfiguredTaskAwaiter)obj7;
													obj6 = 19;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f9510a76595941f880645fdc764944eb != 0)
													{
														obj6 = 22;
													}
													continue;
												case 14:
												case 47:
													result = ((ConfiguredTaskAwaitable<BitmapDecoder>.ConfiguredTaskAwaiter)obj12).GetResult();
													obj6 = 60;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_d9c10084bf5f4a9f947702ad63bef067 == 0)
													{
														obj6 = 58;
													}
													continue;
												case 17:
													obj15 = WindowsRuntimeSystemExtensions.AsTask<uint, uint>((_stream_5__5).WriteAsync(System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeBufferExtensions.AsBuffer((byte[])obj16)), cancellationToken).ConfigureAwait(false);
													obj6 = 10;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_56220e0912894bf29c75280f6503f965 == 0)
													{
														obj6 = 10;
													}
													continue;
												case 54:
													__u__2 = (ConfiguredTaskAwaitable<BitmapDecoder>.ConfiguredTaskAwaiter)obj12;
													obj6 = 51;
													continue;
												case 3:
													obj14++;
													obj6 = 53;
													continue;
												case 32:
													goto IL_08c8;
												case 50:
													goto IL_08d5;
												case 9:
													obj13 = 0;
													obj6 = 50;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9c15dc17ae4e48a5bd629d141b0ebe29 != 0)
													{
														obj6 = 43;
													}
													continue;
												case 46:
													if ((nint)obj17 >= _verticalReduction_5__4)
													{
														obj6 = 4;
														continue;
													}
													goto case 2;
												case 55:
													((ConfiguredTaskAwaitable<uint>.ConfiguredTaskAwaiter)obj10).GetResult();
													obj6 = 19;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0cbd4cb78159400b923bd185c17f634c != 0)
													{
														obj6 = 63;
													}
													continue;
												case 0:
													goto IL_0964;
												case 12:
													throw new InvalidDataException("验证码图片尺寸无效");
												case 21:
													obj12 = ((ConfiguredTaskAwaitable<BitmapDecoder>)obj11).GetAwaiter();
													obj6 = 16;
													continue;
												case 25:
													obj11 = WindowsRuntimeSystemExtensions.AsTask<BitmapDecoder>(Windows.Graphics.Imaging.BitmapDecoder.CreateAsync((IRandomAccessStream)(object)_stream_5__5), cancellationToken).ConfigureAwait(false);
													obj6 = 21;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b8376d7b20c44b95a06e50039002465d == 0)
													{
														obj6 = 27;
													}
													continue;
												case 22:
													__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<PixelDataProvider>.ConfiguredTaskAwaiter, _CreateInputTensorAsync_d__12>(ref __u__3, ref this);
													obj6 = 6;
													continue;
												case 28:
													obj3 = -1;
													__1__state = -1;
													obj6 = 20;
													continue;
												case 20:
													obj22 = (((ConfiguredTaskAwaitable<PixelDataProvider>.ConfiguredTaskAwaiter)obj7).GetResult()).DetachPixelData();
													obj6 = 30;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1e22fe50e3d646ca9b01633c735c9082 != 0)
													{
														obj6 = 23;
													}
													continue;
												case 23:
													obj9 = 10240;
													obj6 = 48;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_dabc6698d5764018a5f86ef3b5a7871e == 0)
													{
														obj6 = 28;
													}
													continue;
												case 42:
													__u__1 = default(ConfiguredTaskAwaitable<uint>.ConfiguredTaskAwaiter);
													obj6 = 57;
													continue;
												case 57:
													obj3 = -1;
													__1__state = -1;
													obj6 = 55;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bd95bcb31f2a40c89aee1548651426a0 != 0)
													{
														obj6 = 45;
													}
													continue;
												case 31:
													goto end_IL_0209;
												}
												break;
												IL_040a:
												if (((dynamic)result).PixelHeight <= 2048)
												{
													BitmapTransform val = new BitmapTransform();
													((dynamic)val).ScaledWidth = 160u;
													((dynamic)val).ScaledHeight = 64u;
													((dynamic)val).InterpolationMode = (BitmapInterpolationMode)2;
													obj20 = (object)val;
													obj6 = 29;
													continue;
												}
												goto IL_0420;
												IL_0735:
												if (((global::System.Array)obj22).Length != (int)obj9 * 4)
												{
													obj6 = 44;
													continue;
												}
												obj18 = new float[_modelInputWidth_5__2 * _modelInputHeight_5__3];
												obj6 = 9;
												continue;
												IL_0339:
												if ((nint)obj23 == 1047)
												{
													goto IL_0232;
												}
												goto IL_0735;
											}
											__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<BitmapDecoder>.ConfiguredTaskAwaiter, _CreateInputTensorAsync_d__12>(ref __u__2, ref this);
											num3 = 13;
											goto IL_022e;
											IL_0964:
											obj12 = __u__2;
											num3 = 59;
											goto IL_022e;
											IL_08c8:
											obj17 = 0;
											num3 = 67;
											goto IL_022e;
											IL_07a7:
											obj7 = __u__3;
											num3 = 45;
											goto IL_022e;
											IL_0776:
											__u__3 = default(ConfiguredTaskAwaitable<PixelDataProvider>.ConfiguredTaskAwaiter);
											num3 = 28;
											goto IL_022e;
											IL_05f8:
											obj10 = __u__1;
											obj6 = 19;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_c3a1ed3f1b10415883902def95e1be62 != 0)
											{
												obj6 = 42;
											}
											goto IL_0236;
											IL_0232:
											obj6 = obj23;
											goto IL_0236;
											IL_0420:
											num3 = 12;
											goto IL_022e;
											IL_08d5:
											obj21 = 0f;
											num3 = 32;
											goto IL_022e;
											IL_022e:
											obj23 = num3;
											goto IL_0232;
											end_IL_0209:
											break;
										}
									}
									finally
									{
										if ((nint)obj3 < 0)
										{
											object obj24 = 1;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9608fe64d13146acb5eaea30e653fb87 == 0)
											{
												obj24 = 0;
											}
											while (true)
											{
												switch ((int)obj24)
												{
												default:
													if ((nint)obj25 == 991)
													{
														obj24 = obj25;
														continue;
													}
													goto end_IL_0b27;
												case 0:
													if (_stream_5__5 == null)
													{
														obj24 = 3;
														continue;
													}
													break;
												case 3:
													goto end_IL_0b27;
												case 1:
													break;
												case 2:
													goto end_IL_0b27;
												}
												(_stream_5__5).Dispose();
												obj24 = 2;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2ea097de099140f192d12c8111241f4e == 0)
												{
													obj24 = 5;
												}
												continue;
												end_IL_0b27:
												break;
											}
										}
									}
									goto end_IL_0071;
									IL_01a3:
									if (((global::System.Array)obj16).Length > 4194304)
									{
										obj4 = 5;
										continue;
									}
									_stream_5__5 = new InMemoryRandomAccessStream();
									obj4 = 0;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bd95bcb31f2a40c89aee1548651426a0 != 0)
									{
										obj4 = 13;
									}
									continue;
									IL_01db:
									if (((global::System.Array)obj16).Length != 0)
									{
										obj4 = 2;
										continue;
									}
									goto IL_013b;
									IL_013b:
									throw new InvalidDataException("验证码图片大小无效");
									continue;
									end_IL_00aa:
									break;
								}
								obj16 = System.Convert.FromBase64String(base64Image);
								num2 = 6;
								goto IL_00a2;
								IL_01bb:
								num2 = 15;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2b2f512a98d548488e5242742b1ff011 != 0)
								{
									num2 = 0;
								}
								goto IL_00a2;
								IL_00a6:
								obj4 = obj5;
								goto IL_00aa;
								end_IL_0071:;
							}
							catch (global::System.Exception exception)
							{
								object obj26 = 1;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e1a4b1278f5749c28fff394e2932a022 == 0)
								{
									obj26 = 6;
								}
								while (true)
								{
									switch ((int)obj26)
									{
									default:
										if ((nint)obj27 != 10)
										{
											if ((nint)obj27 != 990)
											{
												break;
											}
											goto IL_0be7;
										}
										__t__builder.SetException(exception);
										obj26 = 2;
										continue;
									case 0:
										_stream_5__5 = null;
										obj27 = 10;
										goto IL_0be7;
									case 1:
										break;
									case 2:
										return;
										IL_0be7:
										obj26 = obj27;
										continue;
									}
									__1__state = -2;
									obj26 = 2;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_fd7466ab326a4027abb1e5cf92add793 == 0)
									{
										obj26 = 0;
									}
								}
							}
							break;
						case 3:
							obj3 = __1__state;
							obj2 = 9;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3416b7a32c7341febcabc34f89028832 != 0)
							{
								obj2 = 2;
							}
							continue;
						case 0:
							break;
						case 1:
							goto end_IL_000c;
						}
						__1__state = -2;
						obj2 = 4;
						continue;
						end_IL_0010:
						break;
					}
					continue;
					end_IL_000c:
					break;
				}
				while ((nint)obj == 992);
				__t__builder.SetResult((DenseTensor<float>)result2);
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
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_cb74c857a9564cc0b30907ecfe1e0cdf == 0)
						{
							obj2 = 4;
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
		internal static bool bA9TCULGCSQt0Wi8jskQ()
		{
			return f0umq8LGQJtgIjRL0Mnv == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object aKKdlVLG4x1xstxVbE1Y()
		{
			return f0umq8LGQJtgIjRL0Mnv;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _TryRecognizeAsync_d__10 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<string> __t__builder;

		public CaptchaOcrService __4__this;

		public string base64Image;

		public CancellationToken cancellationToken;

		private OcrConfiguration _configuration_5__2;

		private ConfiguredTaskAwaitable<DenseTensor<float>>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable<string?>.ConfiguredTaskAwaiter __u__2;

		internal static object xmd63vLGhWTJOnJ81LOj;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_000c: Expected O, but got I4
			//IL_0029: Expected I4, but got O
			//IL_073f: Expected I4, but got O
			//IL_07bd: Expected I4, but got O
			//IL_0052: Expected O, but got I4
			//IL_00d0: Expected O, but got I4
			//IL_02df: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e6: Expected O, but got Unknown
			//IL_00f5: Expected I4, but got O
			//IL_0320: Expected O, but got I4
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0502: Unknown result type (might be due to invalid IL or missing references)
			//IL_0509: Expected O, but got Unknown
			//IL_03df: Expected O, but got I4
			//IL_04d8: Expected O, but got I4
			//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ab: Expected O, but got Unknown
			//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05be: Expected O, but got Unknown
			//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0544: Expected O, but got I4
			//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_041c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0423: Expected O, but got Unknown
			//IL_0220: Expected O, but got I4
			//IL_0375: Unknown result type (might be due to invalid IL or missing references)
			//IL_0380: Unknown result type (might be due to invalid IL or missing references)
			//IL_0387: Expected O, but got Unknown
			//IL_0295: Expected I4, but got O
			//IL_0715->IL0732: Incompatible stack types: I4 vs O
			//IL_078f->IL07ac: Incompatible stack types: I4 vs O
			//IL_0720->IL0732: Incompatible stack types: I4 vs O
			//IL_079a->IL07ac: Incompatible stack types: I4 vs O
			//IL_0769->IL0732: Incompatible stack types: I4 vs O
			//IL_07e2->IL07ac: Incompatible stack types: I4 vs O
			//IL_0803->IL07ac: Incompatible stack types: I4 vs O
			//IL_0078->IL0010: Incompatible stack types: I4 vs O
			//IL_0774->IL0732: Incompatible stack types: I4 vs O
			//IL_080e->IL07ac: Incompatible stack types: I4 vs O
			//IL_0083->IL0010: Incompatible stack types: I4 vs O
			//IL_009a->IL0010: Incompatible stack types: I4 vs O
			//IL_084f->IL0010: Incompatible stack types: I4 vs O
			//IL_0172->IL00d4: Incompatible stack types: I4 vs O
			//IL_00b7->IL00d4: Incompatible stack types: I4 vs O
			//IL_085a->IL0010: Incompatible stack types: I4 vs O
			//IL_00c2->IL00d4: Incompatible stack types: I4 vs O
			//IL_012b->IL00d4: Incompatible stack types: I4 vs O
			//IL_01d1->IL00d4: Incompatible stack types: I4 vs O
			//IL_0136->IL00d4: Incompatible stack types: I4 vs O
			//IL_01dc->IL00d4: Incompatible stack types: I4 vs O
			//IL_0207->IL0224: Incompatible stack types: I4 vs O
			//IL_02fa->IL0224: Incompatible stack types: I4 vs O
			//IL_05e4->IL0224: Incompatible stack types: I4 vs O
			//IL_0212->IL0224: Incompatible stack types: I4 vs O
			//IL_0305->IL0224: Incompatible stack types: I4 vs O
			//IL_05ef->IL0224: Incompatible stack types: I4 vs O
			//IL_04c8->IL0224: Incompatible stack types: I4 vs O
			//IL_0339->IL0224: Incompatible stack types: I4 vs O
			//IL_031b->IL0224: Incompatible stack types: I4 vs O
			//IL_0513->IL0224: Incompatible stack types: I4 vs O
			//IL_04a2->IL0224: Incompatible stack types: I4 vs O
			//IL_03f8->IL0224: Incompatible stack types: I4 vs O
			//IL_047a->IL0224: Incompatible stack types: I4 vs O
			//IL_04e7->IL0224: Incompatible stack types: I4 vs O
			//IL_05b5->IL0224: Incompatible stack types: I4 vs O
			//IL_05c8->IL0224: Incompatible stack types: I4 vs O
			//IL_03b6->IL0224: Incompatible stack types: I4 vs O
			//IL_03a4->IL0224: Incompatible stack types: I4 vs O
			//IL_0553->IL0224: Incompatible stack types: I4 vs O
			//IL_02de->IL0224: Incompatible stack types: I4 vs O
			//IL_042d->IL0224: Incompatible stack types: I4 vs O
			//IL_04d3->IL0224: Incompatible stack types: I4 vs O
			//IL_0344->IL0224: Incompatible stack types: I4 vs O
			//IL_04ad->IL0224: Incompatible stack types: I4 vs O
			//IL_0403->IL0224: Incompatible stack types: I4 vs O
			//IL_0485->IL0224: Incompatible stack types: I4 vs O
			//IL_0573->IL0224: Incompatible stack types: I4 vs O
			//IL_044d->IL0224: Incompatible stack types: I4 vs O
			//IL_0391->IL0224: Incompatible stack types: I4 vs O
			//IL_057e->IL0224: Incompatible stack types: I4 vs O
			//IL_0458->IL0224: Incompatible stack types: I4 vs O
			int num = 3;
			object obj10 = default(object);
			object result2 = default(object);
			object obj3 = default(object);
			object obj14 = default(object);
			dynamic obj6 = default(object);
			dynamic obj11 = default(object);
			dynamic obj9 = default(object);
			dynamic result = default(object);
			dynamic obj8 = default(object);
			object obj7 = default(object);
			dynamic obj13 = default(object);
			object obj16 = default(object);
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
								goto case 2;
							}
							obj10 = __4__this;
							obj2 = 1;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e041d974da614bb9aad5f28559bec3d0 != 0)
							{
								obj2 = 8;
							}
							continue;
						case 3:
							break;
						case 0:
							__1__state = -2;
							obj2 = 11;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1e22fe50e3d646ca9b01633c735c9082 != 0)
							{
								obj2 = 2;
							}
							continue;
						case 2:
							__t__builder.SetResult((string)result2);
							obj2 = 4;
							continue;
						case 1:
							try
							{
								object obj4;
								if ((nuint)(nint)obj3 <= (nuint)1u)
								{
									obj4 = 5;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_31a06ac266364bee8fef51fc97395192 == 0)
									{
										obj4 = 11;
									}
									goto IL_00d4;
								}
								goto IL_0155;
								IL_00d4:
								while (true)
								{
									switch ((int)obj4)
									{
									default:
										if ((nint)obj14 != 14)
										{
											if ((nint)obj14 == 994)
											{
												goto IL_00d0;
											}
											goto case 4;
										}
										goto case 3;
									case 3:
									case 5:
										obj4 = 6;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0003dce1a8644b9dbbca586828352343 != 0)
										{
											obj4 = 11;
										}
										continue;
									case 2:
										if (!string.IsNullOrWhiteSpace(base64Image))
										{
											obj14 = 14;
											goto IL_00d0;
										}
										goto case 4;
									case 1:
										break;
									case 0:
										goto end_IL_00d4;
									case 4:
										result2 = null;
										obj4 = 0;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2aab0405e3774254ad8ff3552d808a1d == 0)
										{
											obj4 = 9;
										}
										continue;
									case 6:
										{
											try
											{
												object obj5;
												if (obj3 == null)
												{
													obj5 = 10;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bd95bcb31f2a40c89aee1548651426a0 == 0)
													{
														obj5 = 3;
													}
													goto IL_0224;
												}
												goto IL_05c8;
												IL_02de:
												obj6 = __u__2;
												obj5 = 6;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b8376d7b20c44b95a06e50039002465d == 0)
												{
													obj5 = 32;
												}
												goto IL_0224;
												IL_05c8:
												if ((nint)obj3 != 1)
												{
													obj5 = 4;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b18c9101a9694aa1aae5a0a4ca0f1892 != 0)
													{
														obj5 = 25;
													}
													goto IL_0224;
												}
												goto IL_02de;
												IL_0224:
												while (true)
												{
													int num2;
													switch ((int)obj5)
													{
													default:
														if ((nint)obj11 != 34)
														{
															if ((nint)obj11 == 1014)
															{
																goto IL_0220;
															}
															goto case 18;
														}
														obj9 = CreateInputTensorAsync(base64Image, _configuration_5__2, cancellationToken).ConfigureAwait(false);
														obj5 = 13;
														continue;
													case 17:
														__u__2 = (ConfiguredTaskAwaitable<string?>.ConfiguredTaskAwaiter)obj6;
														num2 = 2;
														goto IL_021c;
													case 25:
														__u__1 = default(ConfiguredTaskAwaitable<DenseTensor<float>>.ConfiguredTaskAwaiter);
														obj5 = 12;
														continue;
													case 24:
														break;
													case 6:
														__u__2 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
														obj5 = 5;
														continue;
													case 5:
														obj3 = -1;
														__1__state = -1;
														obj5 = 31;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ef04e2823b234f2aa7c3630bcaafe597 == 0)
														{
															obj5 = 8;
														}
														continue;
													case 22:
														return;
													case 18:
														result = ((ConfiguredTaskAwaitable<DenseTensor<float>>.ConfiguredTaskAwaiter)obj8).GetResult();
														obj5 = 7;
														continue;
													case 16:
														__u__1 = (ConfiguredTaskAwaitable<DenseTensor<float>>.ConfiguredTaskAwaiter)obj8;
														obj5 = 11;
														continue;
													case 20:
														return;
													case 9:
														obj3 = 0;
														__1__state = 0;
														obj5 = 16;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_8cd7f54b623a4d42b1a5e008c75a22ed == 0)
														{
															obj5 = 22;
														}
														continue;
													case 2:
														__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, _TryRecognizeAsync_d__10>(ref __u__2, ref this);
														num2 = 22;
														goto IL_021c;
													case 3:
													case 26:
														obj8 = __u__1;
														obj5 = 25;
														continue;
													case 23:
														if (!((ConfiguredTaskAwaitable<DenseTensor<float>>.ConfiguredTaskAwaiter)obj8).IsCompleted)
														{
															obj5 = 9;
															if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4f82b5c32b3f4f0289c9a252a3907b21 == 0)
															{
																obj5 = 1;
															}
															continue;
														}
														goto case 18;
													case 11:
														__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<DenseTensor<float>>.ConfiguredTaskAwaiter, _TryRecognizeAsync_d__10>(ref __u__1, ref this);
														obj5 = 18;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bb37d0226fdb41f1902e558a997d9dc6 == 0)
														{
															obj5 = 20;
														}
														continue;
													case 8:
													case 10:
														result2 = ((ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter)obj6).GetResult();
														obj5 = 21;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_499faaea7a6445f1af0f623e48ebbb18 == 0)
														{
															obj5 = 31;
														}
														continue;
													case 4:
														((CaptchaOcrService)obj10).EnsureInitialized();
														obj5 = 17;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_c4494c1a50534bb9a384a17479cb6f24 == 0)
														{
															obj5 = 0;
														}
														continue;
													case 12:
														obj3 = -1;
														__1__state = -1;
														obj5 = 18;
														continue;
													case 7:
														obj7 = ((CaptchaOcrService)obj10).RunInferenceAsync((DenseTensor<float>)result, (global::System.Collections.Generic.IReadOnlyList<string>)_configuration_5__2.Charset, cancellationToken).ConfigureAwait(false);
														obj5 = 14;
														continue;
													case 0:
														_configuration_5__2 = ((CaptchaOcrService)obj10)._configuration;
														num2 = 34;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4ae4de12ce674c26bc2939a5789df8ab != 0)
														{
															num2 = 32;
														}
														goto IL_021c;
													case 19:
														obj3 = 1;
														__1__state = 1;
														obj5 = 17;
														continue;
													case 15:
														if (((ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter)obj6).IsCompleted)
														{
															obj5 = 10;
															if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_c3a1ed3f1b10415883902def95e1be62 == 0)
															{
																obj5 = 7;
															}
															continue;
														}
														goto case 19;
													case 13:
														obj8 = ((ConfiguredTaskAwaitable<DenseTensor<float>>)obj9).GetAwaiter();
														obj5 = 23;
														continue;
													case 14:
														obj6 = ((ConfiguredTaskAwaitable<string>)obj7).GetAwaiter();
														obj5 = 15;
														continue;
													case 1:
														goto IL_05c8;
													case 21:
														goto end_IL_01ec;
														IL_021c:
														obj11 = num2;
														goto IL_0220;
														IL_0220:
														obj5 = obj11;
														continue;
													}
													break;
												}
												goto IL_02de;
												end_IL_01ec:;
											}
											catch (global::System.Exception)
											{
												dynamic obj12 = 6;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bd95bcb31f2a40c89aee1548651426a0 == 0)
												{
													obj12 = 1;
												}
												while (true)
												{
													switch ((int)obj12)
													{
													default:
														if ((nint)obj13 == 989)
														{
															obj12 = obj13;
															continue;
														}
														break;
													case 1:
														result2 = null;
														obj12 = 0;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3d9d86761de84aa48245c594db282bdf == 0)
														{
															obj12 = 0;
														}
														continue;
													case 0:
														break;
													}
													break;
												}
											}
											goto end_IL_00d4;
										}
										IL_00d0:
										obj4 = obj14;
										continue;
									}
									goto IL_0155;
									continue;
									end_IL_00d4:
									break;
								}
								goto end_IL_009b;
								IL_0155:
								System.ObjectDisposedException.ThrowIf(((CaptchaOcrService)obj10)._disposed, obj10);
								obj4 = 2;
								goto IL_00d4;
								end_IL_009b:;
							}
							catch (global::System.Exception exception)
							{
								object obj15 = 0;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b28f7b3c5e414da9823acaf82070b1eb == 0)
								{
									obj15 = 1;
								}
								while (true)
								{
									switch ((int)obj15)
									{
									default:
										if ((nint)obj16 == 990)
										{
											obj15 = obj16;
											break;
										}
										goto case 1;
									case 1:
										__1__state = -2;
										obj15 = 2;
										break;
									case 2:
										__t__builder.SetException(exception);
										obj15 = 0;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0c88e6c08eaf4e998e8fdd2c544cee2e != 0)
										{
											obj15 = 0;
										}
										break;
									case 0:
										return;
									}
								}
							}
							goto case 0;
						case 4:
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
				obj3 = __1__state;
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
					obj2 = 0;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_efa7845a846a43508e861e510ac5e1d2 != 0)
					{
						obj2 = 2;
					}
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool OEPmfQLGUTZYFWaBoWKX()
		{
			return xmd63vLGhWTJOnJ81LOj == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object QHSO3dLGrqbEyyLH5F0E()
		{
			return xmd63vLGhWTJOnJ81LOj;
		}
	}

	private const int MaxImageBytes = 4194304;

	private const uint MaxImageDimension = 2048u;

	private const int PreprocessedImageWidth = 160;

	private const int PreprocessedImageHeight = 64;

	private readonly object _initializationLock;

	private InferenceSession? _session;

	private OcrConfiguration? _configuration;

	private string _inputName;

	private string _outputName;

	private bool _disposed;

	private static CaptchaOcrService qm472iLEQuyUvflXFLew;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public unsafe global::System.Threading.Tasks.Task<string?> TryRecognizeAsync(string base64Image, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_000c: Expected O, but got I4
		//IL_002d: Expected I4, but got O
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076->IL0010: Incompatible stack types: I4 vs O
		//IL_0092->IL0010: Incompatible stack types: I4 vs O
		//IL_0105->IL0010: Incompatible stack types: I4 vs O
		//IL_0064->IL0010: Incompatible stack types: I4 vs O
		//IL_00b9->IL0010: Incompatible stack types: I4 vs O
		//IL_009d->IL0010: Incompatible stack types: I4 vs O
		//IL_0110->IL0010: Incompatible stack types: I4 vs O
		//IL_00c4->IL0010: Incompatible stack types: I4 vs O
		int num = 4;
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
						if ((nint)obj != 12)
						{
							if ((nint)obj == 993)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						return ((dynamic)obj3).__t__builder.Task;
					case 4:
						((dynamic)obj3).__t__builder = AsyncTaskMethodBuilder<string>.Create();
						obj2 = 3;
						continue;
					case 0:
						((dynamic)obj3).base64Image = base64Image;
						obj2 = 2;
						continue;
					case 2:
						((dynamic)obj3).cancellationToken = cancellationToken;
						obj2 = 10;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_06501b7bae1743aa8336fe70312492d7 != 0)
						{
							obj2 = 5;
						}
						continue;
					case 5:
						((dynamic)obj3).__1__state = -1;
						obj2 = 1;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1282ca3a3b4d42dea9c5c692937e35bc == 0)
						{
							obj2 = 0;
						}
						continue;
					case 1:
						break;
					case 3:
						((dynamic)obj3).__4__this = this;
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e8864409e70b4d87b4c6598763ad15be == 0)
						{
							obj2 = 6;
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
			((dynamic)obj3).__t__builder.Start<_TryRecognizeAsync_d__10>(ref obj3);
			num = 12;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe void EnsureInitialized()
	{
		//IL_000c: Expected O, but got I4
		//IL_0025: Expected I4, but got O
		//IL_078a: Expected I4, but got O
		//IL_0049: Expected O, but got I4
		//IL_0813: Expected I4, but got O
		//IL_08a6: Expected I4, but got O
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_01f5: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_010a: Expected I4, but got O
		//IL_00e1: Expected O, but got I4
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected I4, but got O
		//IL_0636: Expected O, but got I4
		//IL_06e1: Expected O, but got I4
		//IL_0433: Expected O, but got I4
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected O, but got I4
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Expected O, but got Unknown
		//IL_03a6: Expected O, but got I4
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_073c: Expected O, but got I4
		//IL_040b: Expected I4, but got O
		//IL_0760->IL077d: Incompatible stack types: I4 vs O
		//IL_076b->IL077d: Incompatible stack types: I4 vs O
		//IL_0855->IL0802: Incompatible stack types: I4 vs O
		//IL_07e5->IL0802: Incompatible stack types: I4 vs O
		//IL_087c->IL0899: Incompatible stack types: I4 vs O
		//IL_07bd->IL077d: Incompatible stack types: I4 vs O
		//IL_0860->IL0802: Incompatible stack types: I4 vs O
		//IL_07f0->IL0802: Incompatible stack types: I4 vs O
		//IL_0887->IL0899: Incompatible stack types: I4 vs O
		//IL_07c8->IL077d: Incompatible stack types: I4 vs O
		//IL_08d9->IL0899: Incompatible stack types: I4 vs O
		//IL_08e4->IL0899: Incompatible stack types: I4 vs O
		//IL_00af->IL0010: Incompatible stack types: I4 vs O
		//IL_0087->IL0010: Incompatible stack types: I4 vs O
		//IL_00ba->IL0010: Incompatible stack types: I4 vs O
		//IL_0092->IL0010: Incompatible stack types: I4 vs O
		//IL_00d3->IL00e5: Incompatible stack types: I4 vs O
		//IL_01be->IL00e5: Incompatible stack types: I4 vs O
		//IL_01ff->IL00e5: Incompatible stack types: I4 vs O
		//IL_01a3->IL00e5: Incompatible stack types: I4 vs O
		//IL_01c9->IL00e5: Incompatible stack types: I4 vs O
		//IL_0328->IL0345: Incompatible stack types: I4 vs O
		//IL_0164->IL00e5: Incompatible stack types: I4 vs O
		//IL_0333->IL0345: Incompatible stack types: I4 vs O
		//IL_02fd->IL00e5: Incompatible stack types: I4 vs O
		//IL_038d->IL03aa: Incompatible stack types: I4 vs O
		//IL_0308->IL00e5: Incompatible stack types: I4 vs O
		//IL_0398->IL03aa: Incompatible stack types: I4 vs O
		//IL_049d->IL03aa: Incompatible stack types: I4 vs O
		//IL_0640->IL03aa: Incompatible stack types: I4 vs O
		//IL_05da->IL03aa: Incompatible stack types: I4 vs O
		//IL_06eb->IL03aa: Incompatible stack types: I4 vs O
		//IL_0588->IL03aa: Incompatible stack types: I4 vs O
		//IL_071f->IL03aa: Incompatible stack types: I4 vs O
		//IL_04a8->IL03aa: Incompatible stack types: I4 vs O
		//IL_05e5->IL03aa: Incompatible stack types: I4 vs O
		//IL_06d0->IL03aa: Incompatible stack types: I4 vs O
		//IL_0520->IL03aa: Incompatible stack types: I4 vs O
		//IL_05f9->IL03aa: Incompatible stack types: I4 vs O
		//IL_0682->IL03aa: Incompatible stack types: I4 vs O
		//IL_0628->IL03aa: Incompatible stack types: I4 vs O
		//IL_04dd->IL03aa: Incompatible stack types: I4 vs O
		//IL_054c->IL03aa: Incompatible stack types: I4 vs O
		//IL_05b3->IL03aa: Incompatible stack types: I4 vs O
		//IL_0532->IL03aa: Incompatible stack types: I4 vs O
		//IL_0570->IL03aa: Incompatible stack types: I4 vs O
		//IL_072a->IL03aa: Incompatible stack types: I4 vs O
		//IL_050c->IL03aa: Incompatible stack types: I4 vs O
		//IL_04fa->IL03aa: Incompatible stack types: I4 vs O
		//IL_06db->IL03aa: Incompatible stack types: I4 vs O
		//IL_068d->IL03aa: Incompatible stack types: I4 vs O
		//IL_0633->IL03aa: Incompatible stack types: I4 vs O
		//IL_05be->IL03aa: Incompatible stack types: I4 vs O
		//IL_057b->IL03aa: Incompatible stack types: I4 vs O
		int num = 1;
		object initializationLock = default(object);
		dynamic obj3 = default(object);
		object obj23 = default(object);
		dynamic obj18 = default(object);
		object obj7 = default(object);
		dynamic obj6 = default(object);
		dynamic obj9 = default(object);
		object obj17 = default(object);
		object obj15 = default(object);
		object obj16 = default(object);
		dynamic obj12 = default(object);
		object obj13 = default(object);
		object obj14 = default(object);
		object obj20 = default(object);
		object obj22 = default(object);
		object obj25 = default(object);
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
						if ((nint)obj != 10)
						{
							goto end_IL_0010;
						}
						try
						{
							bool lockTaken = false;
							System.Threading.Monitor.Enter(initializationLock, ref lockTaken);
							dynamic obj4 = 5;
							while (true)
							{
								switch ((int)obj4)
								{
								default:
									if ((nint)obj23 != 15)
									{
										if ((nint)obj23 == 995)
										{
											goto IL_00e1;
										}
										goto case 1;
									}
									throw new InvalidDataException("4399 OCR 配置文件格式无效");
								case 7:
									if (_session != null)
									{
										return;
									}
									obj4 = 6;
									break;
								case 0:
									return;
								case 5:
									System.ObjectDisposedException.ThrowIf(_disposed, this);
									obj4 = 7;
									break;
								case 2:
									((OcrConfiguration)obj18).Validate();
									obj4 = 3;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ff96c054b9a547fc83bea3daf4a435ff == 0)
									{
										obj4 = 2;
									}
									break;
								case 3:
								{
									SessionOptions val = new SessionOptions();
									((dynamic)val).GraphOptimizationLevel = (GraphOptimizationLevel)99;
									((dynamic)val).IntraOpNumThreads = 1;
									((dynamic)val).InterOpNumThreads = 1;
									obj7 = (object)val;
									obj4 = 4;
									break;
								}
								case 1:
								case 6:
								{
									string text = PublishedFileResolver.Resolve("OCR/4399ocr.json");
									obj6 = PublishedFileResolver.Resolve("OCR/4399ocr.onnx");
									if (!System.IO.File.Exists(text) || !System.IO.File.Exists((string)obj6))
									{
										throw new FileNotFoundException("未找到 4399 验证码 OCR 模型文件");
									}
									OcrConfiguration ocrConfiguration = JsonSerializer.Deserialize<OcrConfiguration>(System.IO.File.ReadAllText(text, (Encoding)new UTF8Encoding(false, true)), (JsonSerializerOptions)null);
									if (ocrConfiguration == null)
									{
										obj23 = 15;
										goto IL_00e1;
									}
									obj18 = ocrConfiguration;
									obj4 = 10;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2aab0405e3774254ad8ff3552d808a1d != 0)
									{
										obj4 = 2;
									}
									break;
								}
								case 4:
									{
										try
										{
											dynamic obj5 = (object)new InferenceSession((string)obj6, (SessionOptions)obj7);
											dynamic obj8 = 0;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3a9f60458a5840868f1b224a8d25b071 == 0)
											{
												obj8 = 5;
											}
											while (true)
											{
												switch ((int)obj8)
												{
												default:
													if ((nint)obj9 == 988)
													{
														goto IL_0341;
													}
													break;
												case 0:
													break;
												}
												break;
												IL_0341:
												obj8 = obj9;
											}
											try
											{
												if (((global::System.Collections.Generic.IReadOnlyCollection<KeyValuePair<string, NodeMetadata>>)((dynamic)obj5).InputMetadata).Count == 1)
												{
													object obj10 = 5;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7880b59a09bf4a2190c2568d83d12e71 == 0)
													{
														obj10 = 15;
													}
													while (true)
													{
														int num2;
														int num3;
														switch ((int)obj10)
														{
														default:
															if ((nint)obj17 != 30)
															{
																if ((nint)obj17 == 1010)
																{
																	goto IL_03a6;
																}
																goto case 16;
															}
															obj15 = (((dynamic)obj16).Value).Dimensions;
															obj10 = 3;
															continue;
														case 9:
														case 13:
															obj12 = obj13 == null;
															num2 = 11;
															goto IL_03a2;
														case 22:
															break;
														case 0:
															_session = (InferenceSession?)obj5;
															obj10 = 10;
															if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_33eff53ba43c4c10a4788d4370759667 != 0)
															{
																obj10 = 11;
															}
															continue;
														case 11:
															if (obj12 == null)
															{
																obj10 = 4;
																continue;
															}
															goto case 14;
														case 21:
															if ((nint)obj14 != -1)
															{
																obj10 = 16;
																continue;
															}
															goto case 19;
														case 4:
															if (((byte[])obj15)[1] == 1)
															{
																obj10 = 18;
																continue;
															}
															goto case 14;
														case 16:
															if ((nint)obj14 == 1)
															{
																obj10 = 19;
																continue;
															}
															goto case 1;
														case 12:
															if (((byte[])obj15)[3] != ((OcrConfiguration)obj18).ModelInputWidth)
															{
																obj10 = 14;
																continue;
															}
															goto case 6;
														case 18:
															if (((byte[])obj15)[2] == ((OcrConfiguration)obj18).ModelInputHeight)
															{
																obj10 = 22;
																if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e8ca07a3866c4b3b9e07b1ae67715f0c == 0)
																{
																	obj10 = 5;
																}
																continue;
															}
															goto case 14;
														case 19:
															obj13 = 1;
															obj10 = 13;
															continue;
														case 15:
															if (((global::System.Collections.Generic.IReadOnlyCollection<KeyValuePair<string, NodeMetadata>>)((dynamic)obj5).OutputMetadata).Count == 1)
															{
																obj16 = Enumerable.Single<KeyValuePair<string, NodeMetadata>>((global::System.Collections.Generic.IEnumerable<KeyValuePair<string, NodeMetadata>>)(((dynamic)obj5).InputMetadata));
																num2 = 30;
																goto IL_03a2;
															}
															obj10 = 18;
															if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9c15dc17ae4e48a5bd629d141b0ebe29 != 0)
															{
																obj10 = 22;
															}
															continue;
														case 2:
															_configuration = (OcrConfiguration?)obj18;
															obj10 = 0;
															if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_d2995c01469b4ef28b5784f7cbf606e2 == 0)
															{
																obj10 = 4;
															}
															continue;
														case 5:
															if (((byte[])obj15)[3] <= 0)
															{
																obj10 = 6;
																continue;
															}
															goto case 12;
														case 17:
															num3 = ((((global::System.Array)obj15).Length != 4) ? 1 : 0);
															goto IL_073a;
														case 7:
															if (obj12 == null)
															{
																obj10 = 8;
																if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_56220e0912894bf29c75280f6503f965 == 0)
																{
																	obj10 = 4;
																}
																continue;
															}
															goto case 11;
														case 1:
															obj13 = 0;
															obj10 = 9;
															continue;
														case 14:
															throw new InvalidDataException("4399 OCR 模型输入与配置不一致");
														case 6:
															_inputName = ((dynamic)obj16).Key;
															obj10 = 20;
															if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_496d0f7c1bde4581a78d6bb0fcab5473 == 0)
															{
																obj10 = 28;
															}
															continue;
														case 3:
															if (((System.Type)(((dynamic)obj16).Value).ElementType) != typeof(float))
															{
																obj10 = 17;
																if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1282ca3a3b4d42dea9c5c692937e35bc == 0)
																{
																	obj10 = 25;
																}
																continue;
															}
															num3 = 1;
															goto IL_073a;
														case 8:
															obj14 = ((byte[])obj15)[0];
															obj10 = 21;
															continue;
														case 20:
														{
															dynamic obj11 = Enumerable.Single<KeyValuePair<string, NodeMetadata>>((global::System.Collections.Generic.IEnumerable<KeyValuePair<string, NodeMetadata>>)(((dynamic)obj5).OutputMetadata));
															_outputName = ((dynamic)obj11).Key;
															obj10 = 2;
															if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0d16903d89da4928a5d60c2843281188 != 0)
															{
																obj10 = 23;
															}
															continue;
														}
														case 10:
															return;
															IL_03a2:
															obj17 = num2;
															goto IL_03a6;
															IL_073a:
															obj12 = num3;
															num2 = 7;
															goto IL_03a2;
															IL_03a6:
															obj10 = obj17;
															continue;
														}
														break;
													}
												}
												throw new InvalidDataException("4399 OCR 模型输入输出数量无效");
											}
											catch (global::System.Exception)
											{
												dynamic obj19 = 1;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9a1f67b15040430199ec9dc1289e168b == 0)
												{
													obj19 = 1;
												}
												while (true)
												{
													switch ((int)obj19)
													{
													default:
														if ((nint)obj20 == 989)
														{
															obj19 = obj20;
															break;
														}
														goto case 1;
													case 1:
														((dynamic)obj5).Dispose();
														obj19 = 3;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e041d974da614bb9aad5f28559bec3d0 == 0)
														{
															obj19 = 0;
														}
														break;
													case 0:
														throw new global::System.Exception();
													}
												}
											}
										}
										finally
										{
											object obj21;
											if (obj7 == null)
											{
												obj21 = 0;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3054c4fc69b94a37b21ac42c2099175a == 0)
												{
													obj21 = 8;
												}
												goto IL_0802;
											}
											goto IL_0835;
											IL_0802:
											while (true)
											{
												switch ((int)obj21)
												{
												default:
													if ((nint)obj22 == 990)
													{
														goto IL_07fe;
													}
													goto end_IL_0802;
												case 0:
													goto end_IL_0802;
												case 2:
													break;
												case 1:
													goto end_IL_0802;
												}
												goto IL_0835;
												IL_07fe:
												obj21 = obj22;
												continue;
												end_IL_0802:
												break;
											}
											goto end_IL_07ca;
											IL_0835:
											((dynamic)obj7).Dispose();
											obj21 = 8;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7965c0cf8c924e228a4010c08420db19 == 0)
											{
												obj21 = 1;
											}
											goto IL_0802;
											end_IL_07ca:;
										}
									}
									IL_00e1:
									obj4 = obj23;
									break;
								}
							}
						}
						finally
						{
							if (obj3 != null)
							{
								object obj24 = 6;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e041d974da614bb9aad5f28559bec3d0 == 0)
								{
									obj24 = 1;
								}
								while (true)
								{
									switch ((int)obj24)
									{
									default:
										if ((nint)obj25 == 989)
										{
											obj24 = obj25;
											continue;
										}
										break;
									case 1:
										break;
									case 0:
										goto end_IL_0899;
									}
									System.Threading.Monitor.Exit(initializationLock);
									obj24 = 2;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_916ae56933ff4374af011c79e3cb023a != 0)
									{
										obj24 = 0;
									}
									continue;
									end_IL_0899:
									break;
								}
							}
						}
					case 3:
						break;
					case 1:
						if (_session != null)
						{
							obj2 = 0;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1e22fe50e3d646ca9b01633c735c9082 == 0)
							{
								obj2 = 7;
							}
							continue;
						}
						initializationLock = _initializationLock;
						obj2 = 3;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7bc84b0f9b2d4d968eda9f4e194ba82d != 0)
						{
							obj2 = 3;
						}
						continue;
					case 0:
						return;
					case 2:
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
			while ((nint)obj == 991);
			obj3 = 0;
			num = 10;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9925520c809e49e19c0340f5f2a4c15c == 0)
			{
				num = 3;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe static global::System.Threading.Tasks.Task<DenseTensor<float>> CreateInputTensorAsync(string base64Image, OcrConfiguration configuration, CancellationToken cancellationToken)
	{
		//IL_000c: Expected O, but got I4
		//IL_002d: Expected I4, but got O
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1->IL0010: Incompatible stack types: I4 vs O
		//IL_00fb->IL0010: Incompatible stack types: I4 vs O
		//IL_0070->IL0010: Incompatible stack types: I4 vs O
		//IL_0097->IL0010: Incompatible stack types: I4 vs O
		//IL_007b->IL0010: Incompatible stack types: I4 vs O
		//IL_00a2->IL0010: Incompatible stack types: I4 vs O
		//IL_00d3->IL0010: Incompatible stack types: I4 vs O
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
						if ((nint)obj != 12)
						{
							if ((nint)obj == 993)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						((dynamic)obj3).__1__state = -1;
						obj2 = 4;
						continue;
					case 4:
						((dynamic)obj3).__t__builder.Start<_CreateInputTensorAsync_d__12>(ref obj3);
						obj2 = 1;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b8376d7b20c44b95a06e50039002465d != 0)
						{
							obj2 = 1;
						}
						continue;
					case 5:
						((dynamic)obj3).configuration = configuration;
						obj2 = 10;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0003dce1a8644b9dbbca586828352343 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 1:
						return ((dynamic)obj3).__t__builder.Task;
					case 2:
						((dynamic)obj3).base64Image = base64Image;
						obj2 = 5;
						continue;
					case 0:
						break;
					case 3:
						((dynamic)obj3).__t__builder = AsyncTaskMethodBuilder<DenseTensor<float>>.Create();
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
			((dynamic)obj3).cancellationToken = cancellationToken;
			num = 12;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private global::System.Threading.Tasks.Task<string?> RunInferenceAsync(DenseTensor<float> inputTensor, global::System.Collections.Generic.IReadOnlyList<string> charset, CancellationToken cancellationToken)
	{
		//IL_000c: Expected O, but got I4
		//IL_0029: Expected I4, but got O
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7->IL0010: Incompatible stack types: I4 vs O
		//IL_0065->IL0010: Incompatible stack types: I4 vs O
		//IL_008c->IL0010: Incompatible stack types: I4 vs O
		//IL_0070->IL0010: Incompatible stack types: I4 vs O
		//IL_0097->IL0010: Incompatible stack types: I4 vs O
		//IL_00d5->IL0010: Incompatible stack types: I4 vs O
		int num = 2;
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
						if ((nint)obj == 11)
						{
							((__c__DisplayClass13_0)obj3).cancellationToken = cancellationToken;
							obj2 = 3;
							continue;
						}
						goto end_IL_0010;
					case 2:
						obj3 = (object)new __c__DisplayClass13_0();
						obj2 = 10;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0003dce1a8644b9dbbca586828352343 == 0)
						{
							obj2 = 1;
						}
						continue;
					case 3:
						((__c__DisplayClass13_0)obj3).inputTensor = inputTensor;
						obj2 = 1;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9608fe64d13146acb5eaea30e653fb87 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 1:
						break;
					case 4:
						return global::System.Threading.Tasks.Task.Run<string>((Func<string>)((__c__DisplayClass13_0)obj3)._RunInferenceAsync_b__0, ((__c__DisplayClass13_0)obj3).cancellationToken);
					case 0:
						((__c__DisplayClass13_0)obj3).charset = charset;
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
			while ((nint)obj == 992);
			((__c__DisplayClass13_0)obj3).__4__this = this;
			num = 11;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string? DecodeCtcIndices(global::System.Collections.Generic.IReadOnlyList<long> indices, global::System.Collections.Generic.IReadOnlyList<string> charset)
	{
		//IL_000c: Expected O, but got I4
		//IL_0025: Expected I4, but got O
		//IL_004a: Expected O, but got I8
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_0243: Expected I4, but got O
		//IL_017d: Expected O, but got I8
		//IL_009c: Expected O, but got I4
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected I4, but got O
		//IL_029a->IL0232: Incompatible stack types: I4 vs O
		//IL_0220->IL0232: Incompatible stack types: I4 vs O
		//IL_02a5->IL0232: Incompatible stack types: I4 vs O
		//IL_02cb->IL0010: Incompatible stack types: I4 vs O
		//IL_02d6->IL0010: Incompatible stack types: I4 vs O
		//IL_02f2->IL0010: Incompatible stack types: I4 vs O
		//IL_02fd->IL0010: Incompatible stack types: I4 vs O
		//IL_0152->IL00a0: Incompatible stack types: I4 vs O
		//IL_01ca->IL00a0: Incompatible stack types: I4 vs O
		//IL_01ff->IL00a0: Incompatible stack types: I4 vs O
		//IL_01d5->IL00a0: Incompatible stack types: I4 vs O
		//IL_019f->IL00a0: Incompatible stack types: I4 vs O
		//IL_020a->IL00a0: Incompatible stack types: I4 vs O
		//IL_0165->IL00a0: Incompatible stack types: I4 vs O
		//IL_012c->IL00a0: Incompatible stack types: I4 vs O
		//IL_01b2->IL00a0: Incompatible stack types: I4 vs O
		//IL_0137->IL00a0: Incompatible stack types: I4 vs O
		int num = 3;
		dynamic enumerator = default(object);
		dynamic obj5 = default(object);
		dynamic obj6 = default(object);
		object obj7 = default(object);
		dynamic obj3 = default(object);
		dynamic obj9 = default(object);
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
							goto case 1;
						}
						enumerator = ((global::System.Collections.Generic.IEnumerable<long>)indices).GetEnumerator();
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4967aebcec78421b855bda2f45c82247 != 0)
						{
							obj2 = 2;
						}
						continue;
					case 2:
						break;
					case 0:
						try
						{
							while (true)
							{
								object obj4;
								if (!((dynamic)enumerator).MoveNext())
								{
									obj4 = 4;
									goto IL_00a0;
								}
								goto IL_0174;
								IL_00d7:
								if ((nint)obj5 != 996)
								{
									break;
								}
								goto IL_009c;
								IL_0174:
								obj6 = ((global::System.Collections.Generic.IEnumerator<long>)enumerator).Current;
								obj5 = 16;
								goto IL_009c;
								IL_009c:
								obj4 = obj5;
								goto IL_00a0;
								IL_00a0:
								while (true)
								{
									switch ((int)obj4)
									{
									case 7:
										goto IL_00ea;
									case 8:
										if (obj6 != null)
										{
											obj4 = 6;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_35f00f496d71423193427920cdcc22f1 == 0)
											{
												obj4 = 16;
											}
											continue;
										}
										goto case 0;
									case 2:
										goto end_IL_00a0;
									case 6:
										if (obj6 != obj7)
										{
											obj4 = 5;
											continue;
										}
										goto case 0;
									case 1:
										goto IL_0174;
									case 3:
										if ((long)obj6 < ((global::System.Collections.Generic.IReadOnlyCollection<string>)charset).Count)
										{
											obj4 = 8;
											continue;
										}
										goto IL_00ea;
									case 0:
										obj7 = obj6;
										obj4 = 7;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1282ca3a3b4d42dea9c5c692937e35bc != 0)
										{
											obj4 = 2;
										}
										continue;
									case 5:
										(obj3).Append(charset[(int)obj6]);
										obj4 = 6;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0003dce1a8644b9dbbca586828352343 == 0)
										{
											obj4 = 0;
										}
										continue;
									case 4:
										goto end_IL_0137;
									}
									if ((nint)obj5 != 16)
									{
										goto IL_00d7;
									}
									if ((long)obj6 >= 0)
									{
										obj4 = 3;
										continue;
									}
									goto IL_00ea;
									IL_00ea:
									throw new InvalidDataException("4399 OCR 输出字符索引无效");
									continue;
									end_IL_00a0:
									break;
								}
								continue;
								end_IL_0137:
								break;
							}
						}
						finally
						{
							object obj8;
							if (enumerator == null)
							{
								obj8 = 2;
								goto IL_0232;
							}
							goto IL_027a;
							IL_027a:
							((dynamic)enumerator).Dispose();
							obj8 = 1;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_499faaea7a6445f1af0f623e48ebbb18 == 0)
							{
								obj8 = 5;
							}
							goto IL_0232;
							IL_0232:
							while (true)
							{
								switch ((int)obj8)
								{
								default:
									if ((nint)obj9 == 990)
									{
										goto IL_022e;
									}
									goto end_IL_0232;
								case 2:
									goto end_IL_0232;
								case 0:
									break;
								case 1:
									goto end_IL_0232;
								}
								goto IL_027a;
								IL_022e:
								obj8 = obj9;
								continue;
								end_IL_0232:
								break;
							}
						}
						goto case 1;
					case 3:
						obj3 = (object)new StringBuilder();
						obj2 = 2;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_fd7466ab326a4027abb1e5cf92add793 != 0)
						{
							obj2 = 3;
						}
						continue;
					case 1:
						return NormalizeRecognizedText((StringBuilder)obj3);
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
			obj7 = 0;
			num = 0;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_33eff53ba43c4c10a4788d4370759667 == 0)
			{
				num = 10;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string? DecodeCtcScores(global::System.Collections.Generic.IReadOnlyList<int> outputShape, global::System.Collections.Generic.IReadOnlyList<float> values, global::System.Collections.Generic.IReadOnlyList<string> charset)
	{
		//IL_000c: Expected O, but got I4
		//IL_009d: Expected I4, but got O
		//IL_00ce: Expected O, but got I4
		//IL_041a: Expected O, but got F4
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got I4
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_03c8: Expected O, but got F4
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected I4, but got O
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got I4
		//IL_049c: Expected I4, but got O
		//IL_0192: Expected I4, but got O
		//IL_00db: Expected O, but got I4
		//IL_0473: Expected O, but got I4
		//IL_00d8->IL0010: Incompatible stack types: I4 vs O
		//IL_02bd->IL0010: Incompatible stack types: I4 vs O
		//IL_0424->IL0010: Incompatible stack types: I4 vs O
		//IL_0382->IL0010: Incompatible stack types: I4 vs O
		//IL_01d7->IL0010: Incompatible stack types: I4 vs O
		//IL_03dc->IL0010: Incompatible stack types: I4 vs O
		//IL_0246->IL0010: Incompatible stack types: I4 vs O
		//IL_00cb->IL0010: Incompatible stack types: I4 vs O
		//IL_0182->IL0010: Incompatible stack types: I4 vs O
		//IL_02f2->IL0010: Incompatible stack types: I4 vs O
		//IL_0174->IL0010: Incompatible stack types: I4 vs O
		//IL_04b0->IL0010: Incompatible stack types: I4 vs O
		//IL_0408->IL0010: Incompatible stack types: I4 vs O
		//IL_022a->IL0010: Incompatible stack types: I4 vs O
		//IL_01b1->IL0010: Incompatible stack types: I4 vs O
		//IL_00e5->IL0010: Incompatible stack types: I4 vs O
		//IL_0275->IL0010: Incompatible stack types: I4 vs O
		//IL_029b->IL0010: Incompatible stack types: I4 vs O
		//IL_038d->IL0010: Incompatible stack types: I4 vs O
		//IL_0158->IL0010: Incompatible stack types: I4 vs O
		//IL_04de->IL0010: Incompatible stack types: I4 vs O
		//IL_02e0->IL0010: Incompatible stack types: I4 vs O
		//IL_01e2->IL0010: Incompatible stack types: I4 vs O
		//IL_03e7->IL0010: Incompatible stack types: I4 vs O
		//IL_0207->IL0010: Incompatible stack types: I4 vs O
		//IL_0263->IL0010: Incompatible stack types: I4 vs O
		//IL_04bb->IL0010: Incompatible stack types: I4 vs O
		//IL_0413->IL0010: Incompatible stack types: I4 vs O
		//IL_0490->IL0010: Incompatible stack types: I4 vs O
		//IL_0235->IL0010: Incompatible stack types: I4 vs O
		//IL_0305->IL0010: Incompatible stack types: I4 vs O
		//IL_01bc->IL0010: Incompatible stack types: I4 vs O
		//IL_0368->IL0010: Incompatible stack types: I4 vs O
		//IL_00fc->IL0010: Incompatible stack types: I4 vs O
		//IL_0163->IL0010: Incompatible stack types: I4 vs O
		//IL_04e9->IL0010: Incompatible stack types: I4 vs O
		//IL_0212->IL0010: Incompatible stack types: I4 vs O
		//IL_03ad->IL0010: Incompatible stack types: I4 vs O
		int num = 22;
		dynamic obj6 = default(object);
		dynamic obj4 = default(object);
		dynamic obj12 = default(object);
		dynamic obj3 = default(object);
		dynamic obj5 = default(object);
		object obj7 = default(object);
		dynamic obj11 = default(object);
		dynamic obj8 = default(object);
		dynamic obj10 = default(object);
		dynamic obj9 = default(object);
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
						if ((nint)obj != 40)
						{
							if ((nint)obj == 1021)
							{
								goto end_IL_0010;
							}
							goto case 15;
						}
						goto case 23;
					case 18:
						obj6 = 0;
						obj2 = 23;
						continue;
					case 0:
						obj4 = 0;
						obj2 = 32;
						continue;
					case 31:
						obj12 = 0;
						obj2 = 12;
						continue;
					case 30:
						if (((__c__DisplayClass15_0_3)obj3).classAxis < 0)
						{
							obj2 = 15;
							continue;
						}
						((__c__DisplayClass15_0_3)obj3).batchAxis = Enumerable.First<int>(Enumerable.DefaultIfEmpty<int>(Enumerable.Where<int>(System.Linq.Enumerable.Range(0, ((__c__DisplayClass15_0_3)obj3).dimensions.Length), (Func<int, bool>)((__c__DisplayClass15_0_3)obj3)._DecodeCtcScores_b__1), -1));
						obj2 = 9;
						continue;
					case 17:
						throw new InvalidDataException("4399 OCR 输出维度无效");
					case 22:
						obj3 = (object)new __c__DisplayClass15_0_3();
						obj2 = 21;
						continue;
					case 19:
						obj5 = obj6;
						obj2 = 7;
						continue;
					case 29:
						((StringBuilder)obj7).Append(((__c__DisplayClass15_0_3)obj3).charset[(int)obj5]);
						obj2 = 27;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3416b7a32c7341febcabc34f89028832 == 0)
						{
							obj2 = 15;
						}
						continue;
					case 11:
						obj7 = (object)new StringBuilder();
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f7bdf7cbba314aacbe28a6672ff5f582 != 0)
						{
							obj2 = 25;
						}
						continue;
					case 12:
					case 14:
						if ((nint)obj12 >= (int)((byte[])(object)((__c__DisplayClass15_0_3)obj3).dimensions)[obj11])
						{
							obj2 = 2;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_fd6fdaa7d4824d4c9cf1c9399aa7f204 != 0)
							{
								obj2 = 26;
							}
							continue;
						}
						goto case 10;
					case 5:
					case 27:
						obj4 = obj5;
						obj2 = 4;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0003dce1a8644b9dbbca586828352343 == 0)
						{
							obj2 = 4;
						}
						continue;
					case 16:
						((int[])obj8)[obj11] = (int)obj12;
						obj2 = 24;
						continue;
					case 20:
						if (obj5 == null)
						{
							obj2 = 5;
							continue;
						}
						goto case 28;
					case 32:
						obj8 = new int[3];
						obj2 = 31;
						continue;
					case 2:
						return NormalizeRecognizedText((StringBuilder)obj7);
					case 7:
						obj6++;
						num = 40;
						break;
					case 33:
						obj10 = obj9;
						obj2 = 19;
						continue;
					case 10:
						obj5 = 0;
						num = 3;
						break;
					case 1:
						((int[])obj8)[((__c__DisplayClass15_0_3)obj3).batchAxis] = 0;
						obj2 = 13;
						continue;
					case 9:
						if (((__c__DisplayClass15_0_3)obj3).batchAxis < 0)
						{
							obj2 = 8;
							continue;
						}
						obj11 = Enumerable.Single<int>(System.Linq.Enumerable.Range(0, ((__c__DisplayClass15_0_3)obj3).dimensions.Length), (Func<int, bool>)((__c__DisplayClass15_0_3)obj3)._DecodeCtcScores_b__2);
						num = 11;
						break;
					case 21:
						((__c__DisplayClass15_0_3)obj3).charset = charset;
						obj2 = 25;
						continue;
					case 28:
						if (obj5 != obj4)
						{
							obj2 = 29;
							continue;
						}
						goto case 5;
					case 15:
						throw new InvalidDataException("4399 OCR 输出字符维度无效");
					case 4:
						obj12++;
						obj2 = 36;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3054c4fc69b94a37b21ac42c2099175a != 0)
						{
							obj2 = 14;
						}
						continue;
					case 23:
						if ((nint)obj6 >= (int)((byte[])(object)((__c__DisplayClass15_0_3)obj3).dimensions)[((__c__DisplayClass15_0_3)obj3).classAxis])
						{
							obj2 = 20;
							continue;
						}
						goto case 16;
					case 13:
						obj9 = values[GetFlatIndex(((__c__DisplayClass15_0_3)obj3).dimensions, new global::System.ReadOnlySpan<int>((int[])obj8))];
						obj2 = 27;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_499faaea7a6445f1af0f623e48ebbb18 != 0)
						{
							obj2 = 26;
						}
						continue;
					case 25:
						((__c__DisplayClass15_0_3)obj3).dimensions = Enumerable.ToArray<int>((global::System.Collections.Generic.IEnumerable<int>)outputShape);
						obj2 = 6;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1df8e086d5ed471cbc378d2545a921c6 == 0)
						{
							obj2 = 6;
						}
						continue;
					case 3:
						obj10 = -1f / 0f;
						obj2 = 18;
						continue;
					case 8:
						throw new InvalidDataException("4399 OCR 输出批次维度无效");
					case 26:
						if (obj9 > obj10)
						{
							obj2 = 33;
							continue;
						}
						goto case 7;
					case 24:
						((int[])obj8)[((__c__DisplayClass15_0_3)obj3).classAxis] = (int)obj6;
						obj2 = 17;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e3c72d365c184d8193f0594ab3fd4d1f == 0)
						{
							obj2 = 1;
						}
						continue;
					case 6:
						if (((__c__DisplayClass15_0_3)obj3).dimensions.Length == 3)
						{
							((__c__DisplayClass15_0_3)obj3).classAxis = global::System.Array.FindIndex<int>(((__c__DisplayClass15_0_3)obj3).dimensions, (Predicate<int>)((__c__DisplayClass15_0_3)obj3)._DecodeCtcScores_b__0);
							obj2 = 17;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_70c2a79cb96d4e75a079385f00e7bf58 == 0)
							{
								obj2 = 30;
							}
						}
						else
						{
							obj2 = 33;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_36a48f7fc5034120a3fadb53ab2f53cc == 0)
							{
								obj2 = 17;
							}
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
	private static string? NormalizeRecognizedText(StringBuilder result)
	{
		//IL_000c: Expected O, but got I4
		//IL_0081: Expected I4, but got O
		//IL_021e: Expected O, but got I4
		//IL_0151: Expected I4, but got O
		//IL_0153: Expected O, but got I4
		//IL_01a8: Expected O, but got I4
		//IL_0173: Expected O, but got I4
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_00c3->IL0010: Incompatible stack types: I4 vs O
		//IL_015d->IL0010: Incompatible stack types: I4 vs O
		//IL_01b2->IL0010: Incompatible stack types: I4 vs O
		//IL_0108->IL0010: Incompatible stack types: I4 vs O
		//IL_0299->IL0010: Incompatible stack types: I4 vs O
		//IL_01e8->IL0010: Incompatible stack types: I4 vs O
		//IL_00e0->IL0010: Incompatible stack types: I4 vs O
		//IL_0210->IL0010: Incompatible stack types: I4 vs O
		//IL_0241->IL0010: Incompatible stack types: I4 vs O
		//IL_019a->IL0010: Incompatible stack types: I4 vs O
		//IL_02ce->IL0010: Incompatible stack types: I4 vs O
		//IL_0113->IL0010: Incompatible stack types: I4 vs O
		//IL_02a4->IL0010: Incompatible stack types: I4 vs O
		//IL_01f3->IL0010: Incompatible stack types: I4 vs O
		//IL_00eb->IL0010: Incompatible stack types: I4 vs O
		//IL_021b->IL0010: Incompatible stack types: I4 vs O
		//IL_01a5->IL0010: Incompatible stack types: I4 vs O
		//IL_02d9->IL0010: Incompatible stack types: I4 vs O
		int num = 8;
		object obj6 = default(object);
		dynamic obj3 = default(object);
		dynamic obj5 = default(object);
		object obj7 = default(object);
		dynamic obj4 = default(object);
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
						if ((nint)obj != 33)
						{
							if ((nint)obj == 1014)
							{
								goto end_IL_0010;
							}
							goto case 23;
						}
						goto case 10;
					case 8:
						obj6 = ((result).ToString()).Trim();
						obj2 = 7;
						continue;
					case 10:
						if ((nint)obj3 < 48)
						{
							obj2 = 33;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f981d20d38124e3ab94f0d411fda50cf != 0)
							{
								obj2 = 0;
							}
							continue;
						}
						goto case 17;
					case 2:
						if ((nint)obj3 > 122)
						{
							obj2 = 30;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ee050290791c4dfbba3a13b8d87cc1bd == 0)
							{
								obj2 = 24;
							}
							continue;
						}
						goto case 3;
					case 6:
					case 19:
						if ((nint)obj5 < ((string)obj7).Length)
						{
							num = 21;
							break;
						}
						goto case 25;
					case 9:
					case 21:
						obj3 = ((dynamic)obj7).Chars;
						obj2 = 5;
						continue;
					case 0:
					case 14:
					case 18:
					case 24:
						obj4 = 1;
						num = 23;
						break;
					case 17:
						if ((nint)obj3 <= 57)
						{
							obj2 = 17;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b7393eff3b9049068ae7c92e2e0229a5 == 0)
							{
								obj2 = 11;
							}
							continue;
						}
						goto case 0;
					case 13:
						obj5 = 0;
						obj2 = 6;
						continue;
					case 7:
						if (((string)obj6).Length != 4)
						{
							num = 22;
							break;
						}
						obj7 = obj6;
						obj2 = 18;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f47742ba549d4a57a8283970712d2604 == 0)
						{
							obj2 = 13;
						}
						continue;
					case 22:
						return null;
					case 12:
						if ((nint)obj3 < 97)
						{
							obj2 = 1;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_06501b7bae1743aa8336fe70312492d7 == 0)
							{
								obj2 = 21;
							}
							continue;
						}
						goto case 2;
					case 3:
					case 11:
					case 16:
						obj4 = 0;
						num = 26;
						break;
					case 20:
						return null;
					case 15:
						obj5++;
						obj2 = 19;
						continue;
					case 5:
						if ((nint)obj3 < 65)
						{
							num = 33;
							break;
						}
						goto case 12;
					case 1:
					case 4:
						if ((nint)obj3 > 90)
						{
							goto case 0;
						}
						obj2 = 7;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_495680ddee4b4d2499de9ae6f49aa33c == 0)
						{
							obj2 = 16;
						}
						continue;
					case 25:
						return (string?)obj6;
					case 23:
					case 26:
						if (obj4 == null)
						{
							obj2 = 15;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_80d00e736d0b4f7dbce583e459774a86 != 0)
							{
								obj2 = 25;
							}
							continue;
						}
						goto case 20;
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
	private unsafe static int GetFlatIndex(global::System.Collections.Generic.IReadOnlyList<int> dimensions, global::System.ReadOnlySpan<int> coordinates)
	{
		//IL_000c: Expected O, but got I4
		//IL_002d: Expected I4, but got O
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_0058: Expected I4, but got O
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected I4, but got O
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I4
		//IL_00bc: Expected O, but got I4
		//IL_0094: Expected I4, but got O
		//IL_00ae->IL0010: Incompatible stack types: I4 vs O
		//IL_007a->IL0010: Incompatible stack types: I4 vs O
		//IL_00ea->IL0010: Incompatible stack types: I4 vs O
		//IL_00b9->IL0010: Incompatible stack types: I4 vs O
		//IL_0085->IL0010: Incompatible stack types: I4 vs O
		int num = 5;
		dynamic obj4 = default(object);
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
						if ((nint)obj != 12)
						{
							if ((nint)obj == 993)
							{
								goto end_IL_0010;
							}
							goto case 2;
						}
						return (int)obj4;
					case 2:
						checked
						{
							obj4 = obj4 * dimensions[unchecked((int)obj3)] + *unchecked((float*)coordinates[(int)obj3]);
							obj2 = 3;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7d9cb56da18447908e8451f934a19bb2 == 0)
							{
								obj2 = 0;
							}
							continue;
						}
					case 0:
						obj3++;
						obj2 = 5;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_31a06ac266364bee8fef51fc97395192 != 0)
						{
							obj2 = 1;
						}
						continue;
					case 5:
						obj4 = 0;
						num = 4;
						break;
					case 1:
					case 3:
						if ((nint)obj3 >= ((global::System.Collections.Generic.IReadOnlyCollection<int>)dimensions).Count)
						{
							num = 12;
							break;
						}
						goto case 2;
					case 4:
						obj3 = 0;
						obj2 = 3;
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
	public unsafe void Dispose()
	{
		//IL_000c: Expected O, but got I4
		//IL_0029: Expected I4, but got O
		//IL_0214: Expected O, but got I4
		//IL_01a4: Expected I4, but got O
		//IL_0086: Expected O, but got I4
		//IL_009f: Expected I4, but got O
		//IL_01cd->IL0193: Incompatible stack types: I4 vs O
		//IL_0176->IL0193: Incompatible stack types: I4 vs O
		//IL_0181->IL0193: Incompatible stack types: I4 vs O
		//IL_021e->IL0010: Incompatible stack types: I4 vs O
		//IL_006d->IL008a: Incompatible stack types: I4 vs O
		//IL_0277->IL0010: Incompatible stack types: I4 vs O
		//IL_024c->IL0010: Incompatible stack types: I4 vs O
		//IL_0078->IL008a: Incompatible stack types: I4 vs O
		//IL_0282->IL0010: Incompatible stack types: I4 vs O
		//IL_0257->IL0010: Incompatible stack types: I4 vs O
		//IL_0101->IL008a: Incompatible stack types: I4 vs O
		//IL_00db->IL008a: Incompatible stack types: I4 vs O
		//IL_010c->IL008a: Incompatible stack types: I4 vs O
		//IL_00e6->IL008a: Incompatible stack types: I4 vs O
		//IL_0156->IL008a: Incompatible stack types: I4 vs O
		int num = 4;
		object initializationLock = default(object);
		dynamic obj3 = default(object);
		object obj5 = default(object);
		object obj7 = default(object);
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
					case 2:
						try
						{
							bool lockTaken = false;
							System.Threading.Monitor.Enter(initializationLock, ref lockTaken);
							object obj4 = 2;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4f82b5c32b3f4f0289c9a252a3907b21 == 0)
							{
								obj4 = 2;
							}
							while (true)
							{
								switch ((int)obj4)
								{
								default:
									if ((nint)obj5 != 11 && (nint)obj5 == 991)
									{
										goto IL_0086;
									}
									goto case 3;
								case 3:
									_session = null;
									obj4 = 11;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f9510a76595941f880645fdc764944eb != 0)
									{
										obj4 = 1;
									}
									break;
								case 1:
									_configuration = null;
									obj4 = 6;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_fd6fdaa7d4824d4c9cf1c9399aa7f204 == 0)
									{
										obj4 = 0;
									}
									break;
								case 2:
								{
									InferenceSession? session = _session;
									if (session == null)
									{
										int num2 = 10;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_06766e6d2ea0449aad87692ee68d5840 == 0)
										{
											num2 = 11;
										}
										obj5 = num2;
										goto IL_0086;
									}
									(session).Dispose();
									obj4 = 3;
									break;
								}
								case 0:
									return;
									IL_0086:
									obj4 = obj5;
									break;
								}
							}
						}
						finally
						{
							object obj6;
							if (obj3 == null)
							{
								obj6 = 1;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7648938319564190ac26c6ec3b0a6621 == 0)
								{
									obj6 = 4;
								}
								goto IL_0193;
							}
							goto IL_01b7;
							IL_0193:
							while (true)
							{
								switch ((int)obj6)
								{
								default:
									if ((nint)obj7 == 990)
									{
										goto IL_018f;
									}
									break;
								case 0:
									break;
								case 1:
									goto end_IL_0193;
								case 2:
									goto end_IL_0193;
								}
								goto IL_01b7;
								IL_018f:
								obj6 = obj7;
								continue;
								end_IL_0193:
								break;
							}
							goto end_IL_015b;
							IL_01b7:
							System.Threading.Monitor.Exit(initializationLock);
							obj6 = 2;
							goto IL_0193;
							end_IL_015b:;
						}
					case 0:
						obj3 = 0;
						obj2 = 2;
						continue;
					case 3:
						return;
					case 1:
						return;
					case 4:
						if (!_disposed)
						{
							_disposed = true;
							num = 11;
							goto end_IL_0010;
						}
						obj2 = 3;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ee050290791c4dfbba3a13b8d87cc1bd != 0)
						{
							obj2 = 4;
						}
						continue;
					}
					if ((nint)obj == 11)
					{
						initializationLock = _initializationLock;
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_56220e0912894bf29c75280f6503f965 == 0)
						{
							obj2 = 3;
						}
						continue;
					}
					goto IL_0037;
					continue;
					end_IL_0010:
					break;
				}
				break;
				IL_0037:
				if ((nint)obj != 992)
				{
					return;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public CaptchaOcrService()
	{
		//IL_007c: Expected I4, but got O
		//IL_0061->IL0073: Incompatible stack types: I4 vs O
		//IL_006c->IL0073: Incompatible stack types: I4 vs O
		_initializationLock = new object();
		_inputName = string.Empty;
		_outputName = string.Empty;
		object obj = 4;
		if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1545a17218a245d6823c855e6a4a65cd == 0)
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
	internal static bool F3VkuGLECptyk7hmvOtc()
	{
		return qm472iLEQuyUvflXFLew == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static CaptchaOcrService AF9apuLE4FoM9QmWyxcN()
	{
		return qm472iLEQuyUvflXFLew;
	}
}
