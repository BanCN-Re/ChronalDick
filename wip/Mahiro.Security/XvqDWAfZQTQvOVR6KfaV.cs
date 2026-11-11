using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using FEKNgafZp91hQm39SkmG;
using LioRGnXnTmo7MsqH4aeD;
using Microsoft.Win32.SafeHandles;
using PyuVEjXnR5rg1eGb5BfU;
using TtThUdXvxUQTO3HwhK6w;
using fDAldojjppXrctUVYOJn;
using fj1JbeXneT9aM4GFvt98;
using oiaeLRfZVoDvSB01scrZ;
using pNnQhOXFHxr1SVMA14mI;

namespace eSYAGxfZCKRIP3ADeYqn;

sealed class XvqDWAfZQTQvOVR6KfaV : global::System.IDisposable
{
	[CompilerGenerated]
	sealed class _ReadExecutableChunks_d__13 : global::System.Collections.Generic.IEnumerable<TIu9nAfZkt3HIeLtaZrq>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<TIu9nAfZkt3HIeLtaZrq>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int __1__state;

		private TIu9nAfZkt3HIeLtaZrq __2__current;

		private int __l__initialThreadId;

		public XvqDWAfZQTQvOVR6KfaV __4__this;

		private CancellationToken cancellationToken;

		public CancellationToken __3__cancellationToken;

		private ulong _moduleEnd_5__2;

		private nuint _informationSize_5__3;

		private ulong _regionEnd_5__4;

		private ulong _scanEnd_5__5;

		private ulong _chunkAddress_5__6;

		private int _length_5__7;

		internal static _ReadExecutableChunks_d__13 HPJBQTD8XUa000mXrux0;

		TIu9nAfZkt3HIeLtaZrq System.Collections.Generic.IEnumerator<TIu9nAfZkt3HIeLtaZrq>.Current
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
		public _ReadExecutableChunks_d__13(int __1__state)
		{
			__l__initialThreadId = System.Environment.CurrentManagedThreadId;
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		private void System_IDisposable_Dispose()
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
						__1__state = -2;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
						{
							num2 = 1;
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

		void global::System.IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in System_IDisposable_Dispose
			this.System_IDisposable_Dispose();
		}

		[MethodImpl((MethodImplOptions)8)]
		private bool MoveNext()
		{
			XvqDWAfZQTQvOVR6KfaV xvqDWAfZQTQvOVR6KfaV = default(XvqDWAfZQTQvOVR6KfaV);
			_moduleEnd_5__2 = checked(xvqDWAfZQTQvOVR6KfaV.ModuleAddress + xvqDWAfZQTQvOVR6KfaV.ModuleSize);
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
			// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
			throw new global::System.NotSupportedException();
		}

		void global::System.Collections.IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in System_Collections_IEnumerator_Reset
			this.System_Collections_IEnumerator_Reset();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		private global::System.Collections.Generic.IEnumerator<TIu9nAfZkt3HIeLtaZrq> System_Collections_Generic_IEnumerable_Mahiro_Account_Services_Bedrock_BedrockRemoteMemoryChunk__GetEnumerator()
		{
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			int num = 6;
			_ReadExecutableChunks_d__13 readExecutableChunks_d__ = default(_ReadExecutableChunks_d__13);
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
								goto case 7;
							}
							return readExecutableChunks_d__;
						case 5:
							if (__l__initialThreadId == System.Environment.CurrentManagedThreadId)
							{
								num3 = 14;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto case 2;
						case 1:
						case 3:
							readExecutableChunks_d__.cancellationToken = __3__cancellationToken;
							num = 14;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
							{
								num = 4;
							}
							break;
						case 7:
							readExecutableChunks_d__ = this;
							num3 = 3;
							continue;
						case 0:
							__1__state = 0;
							num3 = 12;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
							{
								num3 = 7;
							}
							continue;
						case 6:
							if (__1__state == -2)
							{
								num = 5;
								break;
							}
							goto case 2;
						case 4:
							readExecutableChunks_d__.__4__this = __4__this;
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
							{
								num3 = 1;
							}
							continue;
						case 2:
							readExecutableChunks_d__ = (_ReadExecutableChunks_d__13)new _ReadExecutableChunks_d__13(0);
							num3 = 4;
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

		global::System.Collections.Generic.IEnumerator<TIu9nAfZkt3HIeLtaZrq> global::System.Collections.Generic.IEnumerable<TIu9nAfZkt3HIeLtaZrq>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in System_Collections_Generic_IEnumerable_Mahiro_Account_Services_Bedrock_BedrockRemoteMemoryChunk__GetEnumerator
			return this.System_Collections_Generic_IEnumerable_Mahiro_Account_Services_Bedrock_BedrockRemoteMemoryChunk__GetEnumerator();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		private global::System.Collections.IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			return (global::System.Collections.IEnumerator)System_Collections_Generic_IEnumerable_Mahiro_Account_Services_Bedrock_BedrockRemoteMemoryChunk__GetEnumerator();
		}

		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in System_Collections_IEnumerable_GetEnumerator
			return this.System_Collections_IEnumerable_GetEnumerator();
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
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
							{
								num3 = 9;
							}
							continue;
						case 1:
							break;
						case 0:
							return;
						case 2:
							num3 = 1;
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
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
				{
					num = 4;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool L3QVqgD8f5kpu8etdyoK()
		{
			return HPJBQTD8XUa000mXrux0 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static _ReadExecutableChunks_d__13 cKvVZDD8LlGuavKTj5cG()
		{
			return HPJBQTD8XUa000mXrux0;
		}
	}

	[CompilerGenerated]
	sealed class _ReadReadableChunks_d__14 : global::System.Collections.Generic.IEnumerable<TIu9nAfZkt3HIeLtaZrq>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<TIu9nAfZkt3HIeLtaZrq>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int __1__state;

		private TIu9nAfZkt3HIeLtaZrq __2__current;

		private int __l__initialThreadId;

		public XvqDWAfZQTQvOVR6KfaV __4__this;

		private CancellationToken cancellationToken;

		public CancellationToken __3__cancellationToken;

		private ulong _moduleEnd_5__2;

		private nuint _informationSize_5__3;

		private ulong _regionEnd_5__4;

		private ulong _scanEnd_5__5;

		private ulong _chunkAddress_5__6;

		private int _length_5__7;

		internal static _ReadReadableChunks_d__14 Y6N5lhD8jEHEAYEACbtv;

		TIu9nAfZkt3HIeLtaZrq System.Collections.Generic.IEnumerator<TIu9nAfZkt3HIeLtaZrq>.Current
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
		public _ReadReadableChunks_d__14(int __1__state)
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		private void System_IDisposable_Dispose()
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
					__1__state = -2;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
					{
						num2 = 0;
					}
				}
			}
		}

		void global::System.IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in System_IDisposable_Dispose
			this.System_IDisposable_Dispose();
		}

		[MethodImpl((MethodImplOptions)8)]
		private bool MoveNext()
		{
			XvqDWAfZQTQvOVR6KfaV xvqDWAfZQTQvOVR6KfaV = default(XvqDWAfZQTQvOVR6KfaV);
			_moduleEnd_5__2 = checked(xvqDWAfZQTQvOVR6KfaV.ModuleAddress + xvqDWAfZQTQvOVR6KfaV.ModuleSize);
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
			// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
			throw new global::System.NotSupportedException();
		}

		void global::System.Collections.IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in System_Collections_IEnumerator_Reset
			this.System_Collections_IEnumerator_Reset();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		private global::System.Collections.Generic.IEnumerator<TIu9nAfZkt3HIeLtaZrq> System_Collections_Generic_IEnumerable_Mahiro_Account_Services_Bedrock_BedrockRemoteMemoryChunk__GetEnumerator()
		{
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			int num = 4;
			_ReadReadableChunks_d__14 readReadableChunks_d__ = default(_ReadReadableChunks_d__14);
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
								goto case 7;
							}
							return readReadableChunks_d__;
						case 7:
							readReadableChunks_d__.__4__this = __4__this;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 != 0)
							{
								num3 = 9;
							}
							continue;
						case 2:
							readReadableChunks_d__ = this;
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
							{
								num3 = 10;
							}
							continue;
						case 4:
							if (__1__state == -2)
							{
								num3 = 3;
								continue;
							}
							goto case 6;
						case 6:
							readReadableChunks_d__ = (_ReadReadableChunks_d__14)new _ReadReadableChunks_d__14(0);
							num3 = 7;
							continue;
						case 0:
						case 5:
							break;
						case 1:
							__1__state = 0;
							num3 = 2;
							continue;
						case 3:
							if (__l__initialThreadId == System.Environment.CurrentManagedThreadId)
							{
								num3 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto case 6;
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
				readReadableChunks_d__.cancellationToken = __3__cancellationToken;
				num = 14;
			}
		}

		global::System.Collections.Generic.IEnumerator<TIu9nAfZkt3HIeLtaZrq> global::System.Collections.Generic.IEnumerable<TIu9nAfZkt3HIeLtaZrq>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in System_Collections_Generic_IEnumerable_Mahiro_Account_Services_Bedrock_BedrockRemoteMemoryChunk__GetEnumerator
			return this.System_Collections_Generic_IEnumerable_Mahiro_Account_Services_Bedrock_BedrockRemoteMemoryChunk__GetEnumerator();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		private global::System.Collections.IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			return (global::System.Collections.IEnumerator)System_Collections_Generic_IEnumerable_Mahiro_Account_Services_Bedrock_BedrockRemoteMemoryChunk__GetEnumerator();
		}

		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in System_Collections_IEnumerable_GetEnumerator
			return this.System_Collections_IEnumerable_GetEnumerator();
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
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de != 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							return;
						case 1:
							break;
						case 2:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
							{
								num3 = 5;
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
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
				{
					num = 0;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool dP0CnsD8ZVTghHVlEMgQ()
		{
			return Y6N5lhD8jEHEAYEACbtv == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static _ReadReadableChunks_d__14 zdsL0oD89L6PhbJnmE49()
		{
			return Y6N5lhD8jEHEAYEACbtv;
		}
	}

	private readonly object SHsfZPswncO;

	private readonly uint V4EfZxlqjkp;

	private readonly ulong L91fZFsqYWI;

	private bool ImjfZsCDrNp;

	[CompilerGenerated]
	private readonly ulong PA5fZTAl8Mp;

	[CompilerGenerated]
	private readonly ulong qh9fZNnocd4;

	internal static object v4oeFCZNbn5cSlca7ZLU;

	internal ulong ModuleAddress
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return PA5fZTAl8Mp;
		}
	}

	internal ulong ModuleSize
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return qh9fZNnocd4;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private XvqDWAfZQTQvOVR6KfaV(SafeProcessHandle handle, ulong moduleAddress, ulong moduleSize, uint processId, ulong processCreated)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static XvqDWAfZQTQvOVR6KfaV TQ8fZ4fl7N3(object process)
	{
		int num = 1;
		XvqDWAfZQTQvOVR6KfaV result = default(XvqDWAfZQTQvOVR6KfaV);
		SafeProcessHandle val = default(SafeProcessHandle);
		int num11 = default(int);
		ulong created = default(ulong);
		ProcessModule val2 = default(ProcessModule);
		int num8 = default(int);
		ulong num7 = default(ulong);
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
						if (num2 != 16)
						{
							if (num2 == 997)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						num3 = 8;
						continue;
					case 1:
						System.ArgumentNullException.ThrowIfNull(process, "process");
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
						{
							num3 = 2;
						}
						continue;
					case 2:
						return result;
					case 4:
						throw new global::System.Exception("Chronal Bedrock runtime injection requires a 64-bit launcher process");
					case 7:
						if (!(process).HasExited)
						{
							num = 6;
							break;
						}
						goto case 5;
					case 0:
						if (System.Environment.Is64BitProcess)
						{
							num = 7;
							break;
						}
						goto case 4;
					case 5:
						throw new global::System.Exception("Bedrock process exited before runtime injection");
					case 6:
						val = HJc6fUXnsRJpQ1ZM1yft.OpenProcess(1049616u, inheritHandle: false, checked((uint)(process).Id));
						num = 3;
						break;
					case 3:
						if (!(val).IsInvalid)
						{
							num = 16;
							break;
						}
						goto case 9;
					case 9:
						System.Runtime.InteropServices.Marshal.GetLastWin32Error();
						(val).Dispose();
						throw new global::System.Exception("Unable to open Bedrock process");
					case 8:
						try
						{
							UDBfZlnVlFw(val);
							int num4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
							{
								num4 = 3;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num11 != 10)
									{
										if (num11 == 990)
										{
											goto IL_01f2;
										}
										goto case 1;
									}
									System.Runtime.InteropServices.Marshal.GetLastWin32Error();
									throw new global::System.Exception("Unable to identify Bedrock process instance");
								case 1:
								{
									if (!HJc6fUXnsRJpQ1ZM1yft.GetProcessTimes(val, out created, out var _, out var _, out var _))
									{
										num11 = 10;
										goto IL_01f2;
									}
									ProcessModule obj = (process).MainModule;
									if (obj == null)
									{
										num4 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 != 0)
										{
											num4 = 2;
										}
										continue;
									}
									val2 = obj;
									num4 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
									{
										num4 = 8;
									}
									continue;
								}
								case 0:
									throw new U8sPwMXvPwSGfubUVhsO();
								case 2:
									{
										try
										{
											ulong num5 = aGmfZH7mdXb((val2).BaseAddress);
											int num6 = 11;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
											{
												num6 = 0;
											}
											while (true)
											{
												switch (num6)
												{
												default:
													if (num8 == 11)
													{
														goto IL_0345;
													}
													if (num8 == 991)
													{
														goto IL_030b;
													}
													goto case 3;
												case 2:
													if (num5 != 0L)
													{
														num6 = 3;
														continue;
													}
													goto IL_0345;
												case 0:
													num7 = checked((ulong)(val2).ModuleMemorySize);
													num6 = 2;
													continue;
												case 3:
													if (num7 == 0L)
													{
														num8 = 11;
														goto IL_030b;
													}
													result = (XvqDWAfZQTQvOVR6KfaV)new XvqDWAfZQTQvOVR6KfaV(val, num5, num7, checked((uint)(process).Id), created);
													num6 = 2;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
													{
														num6 = 1;
													}
													continue;
												case 1:
													break;
													IL_0345:
													throw new global::System.Exception("Bedrock main module range is invalid");
													IL_030b:
													num6 = num8;
													continue;
												}
												break;
											}
										}
										finally
										{
											if (val2 != null)
											{
												int num9 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
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
														goto end_IL_0415;
													}
													(val2).Dispose();
													num9 = 3;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
													{
														num9 = 0;
													}
													continue;
													end_IL_0415:
													break;
												}
											}
										}
										break;
									}
									IL_01f2:
									num4 = num11;
									continue;
								}
								break;
							}
						}
						catch
						{
							int num12 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
							{
								num12 = 7;
							}
							while (true)
							{
								switch (num12)
								{
								default:
									if (num13 == 989)
									{
										num12 = num13;
										break;
									}
									goto case 0;
								case 0:
									(val).Dispose();
									num12 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
									{
										num12 = 1;
									}
									break;
								case 1:
									throw new global::System.Exception();
								}
							}
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[IteratorStateMachine(typeof(object))]
	internal global::System.Collections.Generic.IEnumerable<TIu9nAfZkt3HIeLtaZrq> MOJfZhbZyyc(CancellationToken cancellationToken)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//yield-return decompiler failed: Could not find stateField
		return (global::System.Collections.Generic.IEnumerable<TIu9nAfZkt3HIeLtaZrq>)new _ReadExecutableChunks_d__13(-2)
		{
			__4__this = this,
			__3__cancellationToken = cancellationToken
		};
	}

	[MethodImpl((MethodImplOptions)8)]
	[IteratorStateMachine(typeof(object))]
	internal global::System.Collections.Generic.IEnumerable<TIu9nAfZkt3HIeLtaZrq> RTHfZUe0N9T(CancellationToken cancellationToken)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//yield-return decompiler failed: Could not find stateField
		return (global::System.Collections.Generic.IEnumerable<TIu9nAfZkt3HIeLtaZrq>)new _ReadReadableChunks_d__14(-2)
		{
			__4__this = this,
			__3__cancellationToken = cancellationToken
		};
	}

	[MethodImpl((MethodImplOptions)8)]
	internal byte[] M5ofZryAQB8(ulong address, int length)
	{
		ArgumentOutOfRangeException.ThrowIfNegativeOrZero<int>(length, "length");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void YGifZoHoHYE(ulong address, byte[] bytes)
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
						if (bytes.Length != 0)
						{
							uKNfZ6Ycavg(V3RCVkXn6cotYi3kDTMp.Write, address, bytes.Length, bytes);
							num3 = 3;
							continue;
						}
						goto end_IL_000c;
					case 3:
						return;
					case 2:
						System.ObjectDisposedException.ThrowIf(ImjfZsCDrNp, this);
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
						{
							num3 = 1;
						}
						continue;
					case 1:
						System.ArgumentNullException.ThrowIfNull(bytes, "bytes");
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
						{
							num3 = 0;
						}
						continue;
					}
					break;
				}
				switch (num2)
				{
				case 991:
					break;
				default:
					return;
				case 10:
					_ = "Remote write cannot be empty";
					throw new global::System.Exception("bytes");
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 10;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private string yuafZmDVHqw(string operation, ulong address, nuint requested, nuint transferred)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		defaultInterpolatedStringHandler.AppendFormatted<ulong>(ModuleAddress, "X");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void e6DfZ7WFDXJ(ulong address, byte[] bytes)
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
						if (num2 != 16)
						{
							if (num2 == 997)
							{
								goto end_IL_0010;
							}
							goto case 6;
						}
						goto case 1;
					case 7:
						if ((ulong)bytes.Length > ModuleSize)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
							{
								num3 = 9;
							}
							break;
						}
						goto case 5;
					case 0:
						if (address - ModuleAddress > (ulong)((long)ModuleSize - (long)bytes.Length))
						{
							num3 = 8;
							break;
						}
						uKNfZ6Ycavg(V3RCVkXn6cotYi3kDTMp.PatchMain, address, bytes.Length, bytes);
						num3 = 4;
						break;
					case 5:
						if (address < ModuleAddress)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
							{
								num3 = 1;
							}
							break;
						}
						goto case 0;
					case 6:
						if (bytes.Length == 0)
						{
							goto end_IL_000c;
						}
						goto case 7;
					case 4:
						return;
					case 2:
						System.ArgumentNullException.ThrowIfNull(bytes, "bytes");
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
						{
							num3 = 12;
						}
						break;
					case 3:
						System.ObjectDisposedException.ThrowIf(ImjfZsCDrNp, this);
						num3 = 2;
						break;
					case 1:
					case 8:
					case 9:
						throw new global::System.Exception("address");
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
	internal GnyHkcfZMulJ9Dgq0ofp wv8fZANcXxt(int length)
	{
		ArgumentOutOfRangeException.ThrowIfNegativeOrZero<int>(length, "length");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal GnyHkcfZMulJ9Dgq0ofp rFgfZIAj6Ul(int length)
	{
		ulong num = System.Math.Min(checked(ModuleAddress + 1610612736), 140737488289792uL);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void cuIfZBtmfGb(GnyHkcfZMulJ9Dgq0ofp allocation)
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
						if (num2 != 10)
						{
							if (num2 == 991)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						if (allocation.Owner != this)
						{
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
							{
								num3 = 3;
							}
							continue;
						}
						uKNfZ6Ycavg(V3RCVkXn6cotYi3kDTMp.ExecuteRead, allocation.Address, allocation.Length);
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
						{
							num3 = 2;
						}
						continue;
					case 2:
						return;
					case 1:
						System.ObjectDisposedException.ThrowIf(ImjfZsCDrNp, this);
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						break;
					case 3:
						_ = "Remote allocation belongs to another process";
						throw new global::System.Exception("allocation");
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
			System.ArgumentNullException.ThrowIfNull(allocation, "allocation");
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
			{
				num = 10;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void QblfZg01iGd(ulong address)
	{
		int num = 1;
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
						if (num2 != 10)
						{
							if (num2 == 991)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						return;
					case 1:
						if (!ImjfZsCDrNp)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
							{
								num3 = 2;
							}
							continue;
						}
						return;
					case 3:
						try
						{
							uKNfZ6Ycavg(V3RCVkXn6cotYi3kDTMp.Free, address, 0);
							int num4 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
							{
								num4 = 5;
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
						catch (global::System.Exception)
						{
							int num6 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
							{
								num6 = 4;
							}
							while (true)
							{
								switch (num6)
								{
								case 0:
									return;
								}
								if (num7 == 988)
								{
									num6 = num7;
									continue;
								}
								return;
							}
						}
					case 2:
						return;
					case 0:
						break;
					}
					if (address == 0L)
					{
						goto end_IL_000c;
					}
					num3 = 3;
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 2;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
			{
				num = 10;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
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
						if (!ImjfZsCDrNp)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
							{
								num3 = 4;
							}
							continue;
						}
						return;
					case 3:
						return;
					case 0:
						return;
					case 1:
						goto end_IL_000c;
					}
					switch (num2)
					{
					case 991:
						break;
					default:
						return;
					case 10:
						(SHsfZPswncO).Dispose();
						num3 = 3;
						continue;
					}
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			ImjfZsCDrNp = true;
			num = 10;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void UDBfZlnVlFw(object handle)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		(defaultInterpolatedStringHandler).AppendLiteral("Bedrock runtime injection only supports AMD64 (machine=0x");
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool HvxfZd1HtWs(HJc6fUXnsRJpQ1ZM1yft.r9hsZrLVGHisQUt0ZQ2N information)
	{
		int num = 3;
		uint num4 = default(uint);
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
						if (num2 != 20)
						{
							if (num2 == 1001)
							{
								goto end_IL_0010;
							}
							goto case 2;
						}
						goto IL_0147;
					case 1:
						if (num4 == 128)
						{
							break;
						}
						goto case 12;
					case 2:
						if ((information.C4MLYLAvk8F & 0x100) == 0)
						{
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
							{
								num3 = 9;
							}
							continue;
						}
						goto case 11;
					case 12:
					case 13:
						result = false;
						num3 = 20;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de != 0)
						{
							num3 = 0;
						}
						continue;
					case 5:
						if (num4 != 32)
						{
							num3 = 13;
							continue;
						}
						goto IL_0147;
					case 9:
						if ((information.C4MLYLAvk8F & 1) != 0)
						{
							num3 = 11;
							continue;
						}
						num4 = information.C4MLYLAvk8F & 0xFF;
						num3 = 8;
						continue;
					case 8:
						if (num4 > 32)
						{
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
							{
								num3 = 4;
							}
							continue;
						}
						goto case 7;
					case 0:
					case 10:
						return result;
					case 3:
						if (information.WscLYfYgn4h == 4096)
						{
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
							{
								num3 = 12;
							}
							continue;
						}
						goto case 11;
					case 4:
					case 6:
						if (num4 != 64)
						{
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f != 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto IL_0147;
					case 11:
						return false;
					case 7:
						{
							if (num4 != 16)
							{
								num3 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
								{
									num3 = 16;
								}
								continue;
							}
							goto IL_0147;
						}
						IL_0147:
						result = true;
						num3 = 10;
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
			num = 20;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
			{
				num = 8;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool AFsfZKpas59(HJc6fUXnsRJpQ1ZM1yft.r9hsZrLVGHisQUt0ZQ2N information)
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
				case 2:
					if (information.WscLYfYgn4h == 4096)
					{
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
						{
							num2 = 7;
						}
						continue;
					}
					break;
				case 1:
					if ((information.C4MLYLAvk8F & 0x100) == 0)
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 0:
					return (information.C4MLYLAvk8F & 1) == 0;
				}
				return false;
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static ulong aGmfZH7mdXb(nint pointer)
	{
		return checked((ulong)(pointer).ToInt64());
	}

	[MethodImpl((MethodImplOptions)8)]
	private static nint N7IfZtwlS9U(ulong address)
	{
		checked
		{
			return (nint)unchecked((long)address);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal GnyHkcfZMulJ9Dgq0ofp bZdfZOnPVHE(ulong target, int length)
	{
		ArgumentOutOfRangeException.ThrowIfNegativeOrZero<int>(length, "length");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void U2TfZ5SlLix(Njbu55XFK3bi5uQwYe9e target, byte[] bytes)
	{
		int num = 3;
		bool flag = default(bool);
		bool flag2 = default(bool);
		int num4 = default(int);
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
						if (num2 != 24)
						{
							if (num2 == 1005)
							{
								goto end_IL_0010;
							}
							goto case 13;
						}
						System.ArgumentNullException.ThrowIfNull(bytes, "bytes");
						num3 = 11;
						continue;
					case 16:
						if (!flag)
						{
							num = 9;
							break;
						}
						goto case 2;
					case 4:
						if ((ulong)bytes.Length > target.ModuleSize)
						{
							num3 = 15;
							continue;
						}
						goto case 7;
					case 6:
						flag2 = false;
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
						{
							num3 = 19;
						}
						continue;
					case 9:
						num4 = bytes.Length;
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
						{
							num3 = 6;
						}
						continue;
					case 2:
						if (!flag)
						{
							num3 = 17;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
							{
								num3 = 2;
							}
							continue;
						}
						goto case 13;
					case 17:
						if (target.Address < target.ModuleBase)
						{
							num = 13;
							break;
						}
						goto case 4;
					case 12:
						if (num4 > 64)
						{
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
							{
								num3 = 2;
							}
							continue;
						}
						goto case 6;
					case 0:
						if (num4 >= 5)
						{
							num3 = 12;
							continue;
						}
						goto case 5;
					case 1:
					case 8:
						flag = flag2;
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 != 0)
						{
							num3 = 7;
						}
						continue;
					case 7:
						if (target.Address - target.ModuleBase > (ulong)((long)target.ModuleSize - (long)bytes.Length))
						{
							num3 = 14;
							continue;
						}
						uKNfZ6Ycavg(V3RCVkXn6cotYi3kDTMp.PatchSystem, target.Address, bytes.Length, bytes);
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
						{
							num3 = 10;
						}
						continue;
					case 3:
						System.ObjectDisposedException.ThrowIf(ImjfZsCDrNp, this);
						num = 16;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
						{
							num = 24;
						}
						break;
					case 5:
						flag2 = true;
						num3 = 17;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
						{
							num3 = 1;
						}
						continue;
					case 11:
						flag = !Njbu55XFK3bi5uQwYe9e.IsAllowedModule(target.Module);
						num3 = 16;
						continue;
					case 13:
					case 14:
					case 15:
						throw new global::System.Exception("target");
					case 10:
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private ulong uKNfZ6Ycavg(V3RCVkXn6cotYi3kDTMp action, ulong address, int length, byte[]? bytes = null)
	{
		return FAcra2XnwoJV0Uxjabqg.uXLXnP9reW5(V4EfZxlqjkp, L91fZFsqYWI, action, address, length, bytes);
	}

	[MethodImpl((MethodImplOptions)8)]
	private ulong nmufZRXMAcZ(ulong address, int length)
	{
		ulong num = uKNfZ6Ycavg(V3RCVkXn6cotYi3kDTMp.Allocate, address, length);
		if (num == 0L)
		{
			throw new global::System.Exception("原生内存操作报告成功，但未返回分配地址。");
		}
		return num;
	}

	[MethodImpl((MethodImplOptions)8)]
	private bool G5tfZw8OYcS(ulong address, int length, out ulong allocated)
	{
		return FAcra2XnwoJV0Uxjabqg.U9MXnxst4IH(V4EfZxlqjkp, L91fZFsqYWI, address, length, out allocated);
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
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
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
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
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
	internal static bool ReJPsoZNXCVFwNE3rZM1()
	{
		return v4oeFCZNbn5cSlca7ZLU == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static XvqDWAfZQTQvOVR6KfaV cGF64uZNfcBs7lYh86MT()
	{
		return (XvqDWAfZQTQvOVR6KfaV)v4oeFCZNbn5cSlca7ZLU;
	}
}
