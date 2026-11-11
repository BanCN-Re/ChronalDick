using System;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using BCXoLCXUvJyBkqc6IRk2;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using OJoUjNXoas1ZnYNAbZSE;
using XIxKxbX4yoNlyaTfGFnT;
using fDAldojjppXrctUVYOJn;

namespace RjxJbhXrbm2w7GFft9Yx;

sealed class FccDXYXUz2hreOnMHmMq : global::System.IDisposable
{
	private readonly int D4YXrV6sM1d;

	private readonly object hAqXrYLjblq;

	private readonly object UiVXrSLxFDe;

	private readonly object LffXrc36auB;

	private K9g5toX48c54q05F6hFX? pQHXr0VDRG7;

	private K9g5toX48c54q05F6hFX? UdaXr88ItBC;

	private int NvsXryj6GB6;

	private bool dTjXrWx2uB3;

	internal static object rMdAPDZH8LWvWvdvWmCH;

	internal int CompressionThreshold
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.Threading.Volatile.Read(ref NvsXryj6GB6);
		}
	}

	internal bool EncryptionEnabled
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Volatile.Read<K9g5toX48c54q05F6hFX>(ref pQHXr0VDRG7) != null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal FccDXYXUz2hreOnMHmMq(int maximumPacketBytes)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void HBvXrXXRovf(int threshold)
	{
		System.Threading.Volatile.Write(ref NvsXryj6GB6, threshold);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void CndXrf25Bl7(global::System.ReadOnlySpan<byte> secret)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		bool flag = default(bool);
		object lffXrc36auB = default(object);
		int num5 = default(int);
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
					goto case 0;
				case 1:
					flag = false;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
					{
						num2 = 5;
					}
					break;
				case 0:
					try
					{
						System.Threading.Monitor.Enter(lffXrc36auB, ref flag);
						int num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
						{
							num3 = 10;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num5 != 13)
								{
									if (num5 == 993)
									{
										goto IL_0096;
									}
									goto case 0;
								}
								UdaXr88ItBC = (K9g5toX48c54q05F6hFX?)new K9g5toX48c54q05F6hFX(secret);
								num3 = 2;
								break;
							case 5:
								System.ObjectDisposedException.ThrowIf(dTjXrWx2uB3, this);
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
								{
									num3 = 2;
								}
								break;
							case 1:
							case 3:
								throw new InvalidOperationException("代理加密状态已经启用");
							case 0:
								if (pQHXr0VDRG7 != null)
								{
									num3 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
									{
										num3 = 1;
									}
									break;
								}
								goto case 4;
							case 4:
								if (UdaXr88ItBC == null)
								{
									pQHXr0VDRG7 = (K9g5toX48c54q05F6hFX?)new K9g5toX48c54q05F6hFX(secret);
									int num4 = 13;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
									{
										num4 = 12;
									}
									num5 = num4;
									goto IL_0096;
								}
								num3 = 3;
								break;
							case 2:
								return;
								IL_0096:
								num3 = num5;
								break;
							}
						}
					}
					finally
					{
						int num6;
						if (!flag)
						{
							num6 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
							{
								num6 = 0;
							}
							goto IL_020a;
						}
						goto IL_022e;
						IL_020a:
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 == 990)
								{
									goto IL_0206;
								}
								goto end_IL_020a;
							case 1:
								break;
							case 2:
								goto end_IL_020a;
							case 0:
								goto end_IL_020a;
							}
							goto IL_022e;
							IL_0206:
							num6 = num7;
							continue;
							end_IL_020a:
							break;
						}
						goto end_IL_01d2;
						IL_022e:
						System.Threading.Monitor.Exit(lffXrc36auB);
						num6 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
						{
							num6 = 0;
						}
						goto IL_020a;
						end_IL_01d2:;
					}
				case 2:
					lffXrc36auB = LffXrc36auB;
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
					{
						num2 = 7;
					}
					break;
				case 3:
					return;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task<qAftL0XU3M5I1RIneNTc?> LvxXrL355ew(Stream stream, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_ReadAsync_d__15 readAsync_d__ = default(_ReadAsync_d__15);
		readAsync_d__.__t__builder = AsyncTaskMethodBuilder<qAftL0XU3M5I1RIneNTc>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task BKPXrjdbSu4(Stream stream, qAftL0XU3M5I1RIneNTc packet, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_WriteAsync_d__16 writeAsync_d__ = default(_WriteAsync_d__16);
		writeAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private byte[] dLdXrZimxAF(byte[] frame)
	{
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		int num = 8;
		byte[] subArray = default(byte[]);
		MemoryStream val = default(MemoryStream);
		int num6 = default(int);
		int num4 = default(int);
		int num8 = default(int);
		int num10 = default(int);
		int num12 = default(int);
		int num11 = default(int);
		byte[] result = default(byte[]);
		int num15 = default(int);
		int num17 = default(int);
		int num18 = default(int);
		int bytesRead = default(int);
		int compressionThreshold = default(int);
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
						if (num2 != 22)
						{
							if (num2 == 1003)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						return subArray;
					case 6:
						try
						{
							ZLibStream val2 = new ZLibStream((Stream)(object)val, (CompressionMode)0);
							int num5 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
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
										goto IL_00d2;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_00d2:
								num5 = num6;
							}
							try
							{
								MemoryStream val3 = new MemoryStream(num4);
								int num7 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
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
											goto IL_0129;
										}
										break;
									case 0:
										break;
									}
									break;
									IL_0129:
									num7 = num8;
								}
								try
								{
									byte[] array = new byte[8192];
									int num9 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
									{
										num9 = 2;
									}
									while (true)
									{
										switch (num9)
										{
										default:
											if (num10 != 17)
											{
												if (num10 == 997)
												{
													goto IL_0183;
												}
												goto case 1;
											}
											goto case 4;
										case 4:
											if ((val3).Length == num4)
											{
												num9 = 12;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
												{
													num9 = 2;
												}
												continue;
											}
											goto case 0;
										case 0:
											throw new InvalidDataException("Minecraft 压缩数据长度不匹配");
										case 9:
											num12 = (int)System.Math.Min(array.Length, num4 - (val3).Length);
											num9 = 6;
											continue;
										case 3:
											if (num11 == 0)
											{
												int num13 = 17;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
												{
													num13 = 7;
												}
												num10 = num13;
												goto IL_0183;
											}
											goto case 7;
										case 1:
										case 5:
											if ((val3).Length >= num4)
											{
												num9 = 4;
												continue;
											}
											goto case 9;
										case 7:
											(val3).Write(array, 0, num11);
											num9 = 5;
											continue;
										case 6:
											num11 = (val2).Read(array, 0, num12);
											num9 = 3;
											continue;
										case 2:
											if ((val2).ReadByte() == -1)
											{
												result = (val3).ToArray();
												num9 = 8;
												continue;
											}
											num9 = 14;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
											{
												num9 = 0;
											}
											continue;
										case 8:
											break;
											IL_0183:
											num9 = num10;
											continue;
										}
										break;
									}
								}
								finally
								{
									if (val3 != null)
									{
										int num14 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
										{
											num14 = 3;
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
												(val3).Dispose();
												num14 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
												{
													num14 = 1;
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
							finally
							{
								int num16;
								if (val2 == null)
								{
									num16 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
									{
										num16 = 0;
									}
									goto IL_03ff;
								}
								goto IL_0432;
								IL_03ff:
								while (true)
								{
									switch (num16)
									{
									default:
										if (num17 == 990)
										{
											goto IL_03fb;
										}
										break;
									case 0:
										goto end_IL_03ff;
									case 2:
										break;
									case 1:
										goto end_IL_03ff;
									}
									goto IL_0432;
									IL_03fb:
									num16 = num17;
									continue;
									end_IL_03ff:
									break;
								}
								goto end_IL_03c7;
								IL_0432:
								(val2).Dispose();
								num16 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
								{
									num16 = 1;
								}
								goto IL_03ff;
								end_IL_03c7:;
							}
						}
						finally
						{
							if (val == null)
							{
								num18 = 2;
								goto IL_047d;
							}
							goto IL_04a5;
							IL_04a5:
							(val).Dispose();
							int num19 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb != 0)
							{
								num19 = 8;
							}
							goto IL_0481;
							IL_047d:
							num19 = num18;
							goto IL_0481;
							IL_0481:
							switch (num19)
							{
							case 1:
								goto IL_04a5;
							case 2:
								goto end_IL_045e;
							case 0:
								goto end_IL_045e;
							}
							if (num18 == 990)
							{
								goto IL_047d;
							}
							goto IL_04a5;
							end_IL_045e:;
						}
						goto case 10;
					case 5:
						subArray = frame[System.Range.StartAt(((System.Index)bytesRead))];
						num3 = 14;
						continue;
					case 0:
						throw new InvalidDataException("Minecraft 解压长度超出允许范围");
					case 12:
						if (num4 == 0)
						{
							num3 = 5;
							continue;
						}
						if (num4 < compressionThreshold)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 != 0)
							{
								num3 = 7;
							}
							continue;
						}
						val = new MemoryStream(frame, bytesRead, frame.Length - bytesRead, false);
						num = 6;
						break;
					case 4:
					case 11:
						throw new InvalidDataException("Minecraft 数据包未遵守压缩阈值");
					case 7:
						if (compressionThreshold >= 0)
						{
							num3 = 13;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 != 0)
							{
								num3 = 19;
							}
							continue;
						}
						goto case 9;
					case 1:
						throw new InvalidDataException("Minecraft 压缩数据包小于压缩阈值");
					case 9:
						return frame;
					case 13:
						num4 = YFkFTdXouTMZ2mVrHfvp.xaUXoE6nf9F(frame, out bytesRead);
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
						{
							num3 = 1;
						}
						continue;
					case 14:
						if (compressionThreshold == 0)
						{
							num3 = 11;
							continue;
						}
						goto case 15;
					case 10:
						return result;
					case 15:
						if (subArray.Length < compressionThreshold)
						{
							num = 22;
							break;
						}
						goto case 4;
					case 3:
						if (num4 >= 0)
						{
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
							{
								num3 = 18;
							}
							continue;
						}
						goto case 0;
					case 8:
						compressionThreshold = CompressionThreshold;
						num3 = 7;
						continue;
					case 2:
						if (num4 <= D4YXrV6sM1d)
						{
							num3 = 12;
							continue;
						}
						goto case 0;
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
	private byte[] brCXr93KhxP(byte[] packetData)
	{
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		byte[] array2 = default(byte[]);
		byte[] array = default(byte[]);
		int num6 = default(int);
		MemoryStream val = default(MemoryStream);
		byte[] result = default(byte[]);
		ZLibStream val2 = default(ZLibStream);
		int num8 = default(int);
		int num10 = default(int);
		int num12 = default(int);
		int compressionThreshold = default(int);
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
							goto case 4;
						}
						(array2).CopyTo(array, 0);
						num3 = 7;
						continue;
					case 9:
						try
						{
							byte[] array3 = YFkFTdXouTMZ2mVrHfvp.uDpXovw8ELs(packetData.Length);
							int num4 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 != 0)
							{
								num4 = 4;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num6 != 12)
									{
										if (num6 == 992)
										{
											goto IL_009a;
										}
										goto case 2;
									}
									throw new InvalidDataException("Minecraft 压缩帧超过允许范围");
								case 1:
									if ((val).Length > D4YXrV6sM1d)
									{
										int num5 = 12;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
										{
											num5 = 0;
										}
										num6 = num5;
										goto IL_009a;
									}
									result = (val).ToArray();
									num4 = 4;
									continue;
								case 3:
									(val).Write(default(global::System.ReadOnlySpan<byte>));
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
									{
										num4 = 0;
									}
									continue;
								case 0:
									val2 = new ZLibStream((Stream)(object)val, (CompressionLevel)1, true);
									num4 = 2;
									continue;
								case 2:
									try
									{
										(val2).Write(packetData);
										int num7 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
										{
											num7 = 6;
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
									finally
									{
										int num9;
										if (val2 == null)
										{
											num9 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
											{
												num9 = 2;
											}
											goto IL_022c;
										}
										goto IL_0250;
										IL_022c:
										while (true)
										{
											switch (num9)
											{
											default:
												if (num10 == 990)
												{
													goto IL_0228;
												}
												goto end_IL_022c;
											case 1:
												break;
											case 0:
												goto end_IL_022c;
											case 2:
												goto end_IL_022c;
											}
											goto IL_0250;
											IL_0228:
											num9 = num10;
											continue;
											end_IL_022c:
											break;
										}
										goto end_IL_01f4;
										IL_0250:
										(val2).Dispose();
										num9 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
										{
											num9 = 3;
										}
										goto IL_022c;
										end_IL_01f4:;
									}
									goto case 1;
								case 4:
									break;
									IL_009a:
									num4 = num6;
									continue;
								}
								break;
							}
						}
						finally
						{
							int num11;
							if (val == null)
							{
								num11 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
								{
									num11 = 5;
								}
								goto IL_02fc;
							}
							goto IL_0320;
							IL_02fc:
							while (true)
							{
								switch (num11)
								{
								default:
									if (num12 == 990)
									{
										goto IL_02f8;
									}
									break;
								case 0:
									break;
								case 2:
									goto end_IL_02fc;
								case 1:
									goto end_IL_02fc;
								}
								goto IL_0320;
								IL_02f8:
								num11 = num12;
								continue;
								end_IL_02fc:
								break;
							}
							goto end_IL_02c4;
							IL_0320:
							(val).Dispose();
							num11 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
							{
								num11 = 2;
							}
							goto IL_02fc;
							end_IL_02c4:;
						}
						goto case 4;
					case 3:
						array2 = YFkFTdXouTMZ2mVrHfvp.uDpXovw8ELs(0);
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
						{
							num3 = 2;
						}
						continue;
					case 7:
						(packetData).CopyTo(array, array2.Length);
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db != 0)
						{
							num3 = 2;
						}
						continue;
					case 0:
						break;
					case 1:
						if (compressionThreshold >= 0)
						{
							num3 = 12;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
							{
								num3 = 8;
							}
							continue;
						}
						goto case 5;
					case 5:
						return packetData;
					case 8:
						if (packetData.Length >= compressionThreshold)
						{
							num3 = 10;
							continue;
						}
						goto case 3;
					case 2:
						compressionThreshold = CompressionThreshold;
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
						{
							num3 = 1;
						}
						continue;
					case 4:
						return result;
					case 6:
						return array;
					case 10:
						val = new MemoryStream();
						num3 = 9;
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
			array = new byte[array2.Length + packetData.Length];
			num = 17;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task<int?> tHMXrDmPEFI(Stream stream, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_ReadVarIntAsync_d__19 readVarIntAsync_d__ = default(_ReadVarIntAsync_d__19);
		readVarIntAsync_d__.__t__builder = AsyncTaskMethodBuilder<int?>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task nYAXrkSWDR7(object stream, global::System.Memory<byte> destination, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_ReadExactlyAsync_d__20 readExactlyAsync_d__ = default(_ReadExactlyAsync_d__20);
		readExactlyAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool GtkdMLZHywHKSnFNoxC9()
	{
		return rMdAPDZH8LWvWvdvWmCH == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static FccDXYXUz2hreOnMHmMq k6Ina4ZHWYO0RKgjJHj7()
	{
		return (FccDXYXUz2hreOnMHmMq)rMdAPDZH8LWvWvdvWmCH;
	}
}
