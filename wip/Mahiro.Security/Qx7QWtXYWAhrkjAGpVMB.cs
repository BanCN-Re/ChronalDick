using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using B1sMsHfszr8btKuT8Q1f;
using CZUx5njfSrbl1tnMcUCO;
using DcVTCSXYtu4eTku0rV9j;
using fDAldojjppXrctUVYOJn;
using fJfNTB3p5nRiIJsrptO;

namespace gCm90lXYJptn2RjHumwY;

sealed class Qx7QWtXYWAhrkjAGpVMB : global::System.IDisposable
{
	private readonly object pT2XYUuXilJ;

	private readonly object mm5XYrxMrEh;

	private readonly Func<GE50SffsnGnn7g3lMZHE, long, bool> zogXYoneT59;

	private readonly Func<GE50SffsnGnn7g3lMZHE, long, GE50SffsnGnn7g3lMZHE, bool> B2uXYm6jgJf;

	private readonly Func<GE50SffsnGnn7g3lMZHE, long, GE50SffsnGnn7g3lMZHE, bool> ocyXY7Yj0Rs;

	private readonly Func<GE50SffsnGnn7g3lMZHE, long, global::System.Exception, bool> QMFXYATD3La;

	private readonly object sAXXYIyo47W;

	private readonly object yKTXYBETwfD;

	private readonly object nd7XYgMWUXD;

	private object d4MXYlrctbD;

	private long kkrXYdfXxcc;

	private int lulXYKMnku8;

	internal static object BCKNXqZIik55HMpjYdNh;

	[MethodImpl((MethodImplOptions)8)]
	internal Qx7QWtXYWAhrkjAGpVMB(RpanX1XYHiWeVytkgQSr transport, oIjXLk3MLAhkiO8QELV interLogin, Func<GE50SffsnGnn7g3lMZHE, long, bool> tryBeginRecovery, Func<GE50SffsnGnn7g3lMZHE, long, GE50SffsnGnn7g3lMZHE, bool> tryMarkAuthenticated, Func<GE50SffsnGnn7g3lMZHE, long, GE50SffsnGnn7g3lMZHE, bool> tryCompleteRecovery, Func<GE50SffsnGnn7g3lMZHE, long, global::System.Exception, bool> tryFailRecovery, Action lifecycleChanged)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal global::System.Threading.Tasks.Task LRBXYQvU4ml(GE50SffsnGnn7g3lMZHE expiredSession, long expectedGeneration, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		int num = 4;
		object obj = default(object);
		bool flag = default(bool);
		int num6 = default(int);
		global::System.Threading.Tasks.Task result = default(global::System.Threading.Tasks.Task);
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
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						try
						{
							System.Threading.Monitor.Enter(obj, ref flag);
							int num4 = 6;
							while (true)
							{
								int num5;
								object obj2;
								switch (num4)
								{
								default:
									if (num6 != 14)
									{
										if (num6 == 994)
										{
											goto IL_011d;
										}
										goto case 3;
									}
									result = (global::System.Threading.Tasks.Task)d4MXYlrctbD;
									num5 = 2;
									goto IL_0119;
								case 4:
									obj2 = System.Threading.Tasks.Task.CompletedTask;
									break;
								case 3:
									if (kkrXYdfXxcc != expectedGeneration)
									{
										num4 = 4;
										continue;
									}
									obj2 = d4MXYlrctbD;
									break;
								case 6:
									if (!(d4MXYlrctbD).IsCompleted)
									{
										num4 = 3;
										continue;
									}
									goto case 1;
								case 1:
									kkrXYdfXxcc = expectedGeneration;
									num4 = 10;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
									{
										num4 = 5;
									}
									continue;
								case 0:
									goto end_IL_0121;
								case 5:
									d4MXYlrctbD = DfdXYCAQPt6(expiredSession, expectedGeneration, cancellationToken);
									num5 = 14;
									goto IL_0119;
								case 2:
									goto end_IL_0121;
									IL_0119:
									num6 = num5;
									goto IL_011d;
									IL_011d:
									num4 = num6;
									continue;
								}
								result = (global::System.Threading.Tasks.Task)obj2;
								num4 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
								{
									num4 = 8;
								}
								continue;
								end_IL_0121:
								break;
							}
						}
						finally
						{
							int num7;
							if (!flag)
							{
								num7 = 2;
								goto IL_0270;
							}
							goto IL_0294;
							IL_0294:
							System.Threading.Monitor.Exit(obj);
							num7 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
							{
								num7 = 5;
							}
							goto IL_0270;
							IL_0270:
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 == 990)
									{
										goto IL_026c;
									}
									break;
								case 0:
									break;
								case 2:
									goto end_IL_0270;
								case 1:
									goto end_IL_0270;
								}
								goto IL_0294;
								IL_026c:
								num7 = num8;
								continue;
								end_IL_0270:
								break;
							}
						}
						goto case 2;
					case 4:
						System.ArgumentNullException.ThrowIfNull(expiredSession, "expiredSession");
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f != 0)
						{
							num3 = 3;
						}
						continue;
					case 2:
						return result;
					case 1:
						obj = yKTXYBETwfD;
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce != 0)
						{
							num3 = 0;
						}
						continue;
					case 3:
						System.ObjectDisposedException.ThrowIf(System.Threading.Volatile.Read(ref lulXYKMnku8) != 0, this);
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
						{
							num3 = 1;
						}
						continue;
					case 0:
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
			flag = false;
			num = 11;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
			{
				num = 0;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task DfdXYCAQPt6(GE50SffsnGnn7g3lMZHE expiredSession, long expectedGeneration, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_RecoverCoreAsync_d__14 recoverCoreAsync_d__ = default(_RecoverCoreAsync_d__14);
		recoverCoreAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool Rb6XY4YR66r(object recovered, object expired)
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
						if (num2 != 12)
						{
							if (num2 == 993)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						return true;
					case 3:
						if (string.Equals(((GE50SffsnGnn7g3lMZHE)recovered).UserId, ((GE50SffsnGnn7g3lMZHE)expired).UserId, (StringComparison)4))
						{
							num3 = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
							{
								num3 = 2;
							}
							break;
						}
						goto case 4;
					case 0:
						if (string.IsNullOrWhiteSpace(((GE50SffsnGnn7g3lMZHE)expired).SdkUid))
						{
							goto end_IL_000c;
						}
						goto case 5;
					case 1:
						if (!string.Equals(((GE50SffsnGnn7g3lMZHE)recovered).LoginAid, ((GE50SffsnGnn7g3lMZHE)expired).LoginAid, (StringComparison)4))
						{
							num3 = 4;
							break;
						}
						goto case 0;
					case 5:
						return string.Equals(((GE50SffsnGnn7g3lMZHE)recovered).SdkUid, ((GE50SffsnGnn7g3lMZHE)expired).SdkUid, (StringComparison)4);
					case 4:
						return false;
					case 2:
						if (!string.IsNullOrWhiteSpace(((GE50SffsnGnn7g3lMZHE)expired).LoginAid))
						{
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
							{
								num3 = 1;
							}
							break;
						}
						goto case 0;
					}
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
	private void oM0XYh2KxJI()
	{
		int num = 1;
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 0:
				return;
			}
			try
			{
				_ = sAXXYIyo47W;
				int num2 = 5;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 != 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 0:
						return;
					}
					if (num3 == 988)
					{
						num2 = num3;
						continue;
					}
					return;
				}
			}
			catch
			{
				int num4 = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
				{
					num4 = 0;
				}
				while (true)
				{
					switch (num4)
					{
					case 0:
						return;
					}
					if (num5 == 988)
					{
						num4 = num5;
						continue;
					}
					return;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		int num = 1;
		int num4 = default(int);
		int num6 = default(int);
		do
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 0:
					return;
				case 1:
					if (System.Threading.Interlocked.Exchange(ref lulXYKMnku8, 1) == 0)
					{
						num2 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
						{
							num2 = 2;
						}
					}
					else
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee != 0)
						{
							num2 = 3;
						}
					}
					continue;
				case 2:
					try
					{
						(nd7XYgMWUXD).Cancel();
						int num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
								return;
							}
							if (num4 != 988)
							{
								return;
							}
							num3 = num4;
						}
					}
					catch (ObjectDisposedException)
					{
						int num5 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							case 0:
								return;
							}
							if (num6 != 988)
							{
								return;
							}
							num5 = num6;
						}
					}
				}
				break;
			}
		}
		while (num == 991);
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
					case 2:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
						{
							num3 = 0;
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
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
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
			num = 2;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool C9oC8BZInSI0kSbr4f7r()
	{
		return BCKNXqZIik55HMpjYdNh == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Qx7QWtXYWAhrkjAGpVMB oDm0mwZIzxoSNexcWumb()
	{
		return (Qx7QWtXYWAhrkjAGpVMB)BCKNXqZIik55HMpjYdNh;
	}
}
