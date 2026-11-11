using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace f5MCtYX3KQ3bmxTNKeFA;

internal sealed class BMqtYNX3dibE9UCe1e8O : IEquatable<BMqtYNX3dibE9UCe1e8O>
{
	[CompilerGenerated]
	private string? SliX3e00ZYB;

	[CompilerGenerated]
	private string axrX3PS7Z50;

	internal static object bD0uUdZPCuL5HfTh5qM2;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return System.Type.GetTypeFromHandle(typeof(BMqtYNX3dibE9UCe1e8O).TypeHandle);
		}
	}

	public string? Phase
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return SliX3e00ZYB;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			SliX3e00ZYB = value;
		}
	}

	public string Diagnostic
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return axrX3PS7Z50;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			axrX3PS7Z50 = value;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public BMqtYNX3dibE9UCe1e8O(string? Phase, string Diagnostic)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task<BMqtYNX3dibE9UCe1e8O> FoJX3HyKLN3(object path, CancellationToken token)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_ReadAsync_d__11 readAsync_d__ = default(_ReadAsync_d__11);
		readAsync_d__.__t__builder = AsyncTaskMethodBuilder<BMqtYNX3dibE9UCe1e8O>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static BMqtYNX3dibE9UCe1e8O K61X3t95Vp7(object json)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Invalid comparison between Unknown and I4
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Invalid comparison between Unknown and I4
		//IL_0999: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bb: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num3 = default(int);
		int num7 = default(int);
		string text = default(string);
		JsonElement val2 = default(JsonElement);
		string text2 = default(string);
		int num8 = default(int);
		char c = default(char);
		bool flag2 = default(bool);
		BMqtYNX3dibE9UCe1e8O result = default(BMqtYNX3dibE9UCe1e8O);
		bool flag = default(bool);
		int num10 = default(int);
		int num12 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					JsonDocument val = System.Text.Json.JsonDocument.Parse((string)json, default(JsonDocumentOptions));
					int num2 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
					{
						num2 = 0;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							if (num3 == 988)
							{
								goto IL_0078;
							}
							break;
						case 0:
							break;
						}
						break;
						IL_0078:
						num2 = num3;
					}
					try
					{
						JsonElement root = (val).RootElement;
						int num4 = 32;
						while (true)
						{
							object obj;
							int num6;
							int num5;
							string text3;
							switch (num4)
							{
							default:
								if (num7 != 56)
								{
									if (num7 == 1036)
									{
										goto IL_00bf;
									}
									goto case 17;
								}
								if ((text == "waiting"))
								{
									num4 = 10;
									continue;
								}
								goto case 2;
							case 40:
								goto end_IL_00c3;
							case 14:
								obj = null;
								goto IL_083c;
							case 29:
								if (!(root).TryGetProperty("corrected", out val2))
								{
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
									{
										num4 = 12;
									}
									continue;
								}
								goto case 16;
							case 19:
								if (!(text2 == "setting_not_ready"))
								{
									num4 = 30;
									continue;
								}
								goto case 1;
							case 28:
								if (text2 == null)
								{
									num4 = 19;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
									{
										num4 = 42;
									}
									continue;
								}
								goto case 20;
							case 43:
								switch (num8)
								{
								case 17:
									break;
								default:
									goto IL_0306;
								case 13:
								case 16:
									goto IL_0381;
								case 18:
									goto IL_057e;
								case 19:
									goto IL_0625;
								case 12:
									goto IL_0670;
								case 15:
									goto IL_06a6;
								case 14:
									goto IL_0787;
								}
								goto case 19;
							case 16:
								num6 = (((int)(val2).ValueKind == 5) ? 1 : 0);
								break;
							case 2:
								if (!(text == "ready"))
								{
									num4 = 46;
									continue;
								}
								goto case 3;
							case 5:
								if (c != 'l')
								{
									num5 = 4;
									goto IL_00bb;
								}
								goto case 38;
							case 11:
							case 24:
							case 27:
							case 30:
							case 34:
							case 36:
							case 39:
							case 42:
							case 44:
							case 48:
								goto IL_0381;
							case 47:
								text3 = "none";
								goto IL_084a;
							case 46:
								if (!(text == "failed"))
								{
									num4 = 15;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
									{
										num4 = 6;
									}
									continue;
								}
								goto case 3;
							case 15:
								if (!(text2 == "rollback_failed"))
								{
									num4 = 23;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
									{
										num4 = 44;
									}
									continue;
								}
								goto case 1;
							case 20:
								num8 = (text2).Length;
								num5 = 43;
								goto IL_00bb;
							case 1:
							case 35:
							case 45:
								flag2 = true;
								num4 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
								{
									num4 = 52;
								}
								continue;
							case 17:
							case 18:
								if (flag2)
								{
									num4 = 26;
									continue;
								}
								goto case 14;
							case 23:
								goto IL_057e;
							case 9:
								text = QtdX3OXgIDj(root, "phase");
								num5 = 56;
								goto IL_00bb;
							case 4:
								if (c != 'r')
								{
									num4 = 27;
									continue;
								}
								goto case 15;
							case 12:
								goto IL_0625;
							case 25:
								goto IL_0670;
							case 33:
								goto IL_06a6;
							case 6:
							case 7:
								flag2 = false;
								num4 = 18;
								continue;
							case 21:
								text2 = QtdX3OXgIDj(root, "code");
								num5 = 28;
								goto IL_00bb;
							case 38:
								if (!(text2 == "login_not_ready"))
								{
									goto IL_0381;
								}
								num4 = 45;
								continue;
							case 32:
								if ((int)(root).ValueKind != 1)
								{
									num4 = 41;
									continue;
								}
								goto case 9;
							case 3:
							case 10:
								flag2 = true;
								num4 = 17;
								continue;
							case 37:
								goto IL_0787;
							case 41:
								result = (BMqtYNX3dibE9UCe1e8O)new BMqtYNX3dibE9UCe1e8O((string?)null, "stage=credentials state=invalid");
								num4 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
								{
									num4 = 40;
								}
								continue;
							case 8:
							case 31:
								if (!flag2)
								{
									num4 = 47;
									continue;
								}
								text3 = text2;
								goto IL_084a;
							case 26:
								obj = text;
								goto IL_083c;
							case 0:
								num6 = 0;
								break;
							case 13:
							{
								string phase = text;
								global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(41, 3);
								(defaultInterpolatedStringHandler).AppendLiteral("stage=credentials phase=");
								(defaultInterpolatedStringHandler).AppendFormatted(text ?? "unknown");
								(defaultInterpolatedStringHandler).AppendLiteral(" code=");
								(defaultInterpolatedStringHandler).AppendFormatted(text2);
								(defaultInterpolatedStringHandler).AppendLiteral(" ");
								(defaultInterpolatedStringHandler).AppendLiteral("corrected=");
								(defaultInterpolatedStringHandler).AppendFormatted(((flag).ToString()).ToLowerInvariant());
								result = (BMqtYNX3dibE9UCe1e8O)new BMqtYNX3dibE9UCe1e8O(phase, string.Concat((defaultInterpolatedStringHandler).ToStringAndClear(), Mw6X35NS0WP(root, "login_bytes"), Mw6X35NS0WP(root, "key_bytes")));
								num5 = 22;
								goto IL_00bb;
							}
							case 22:
								goto end_IL_00c3;
								IL_057e:
								if (!(text2 == "credential_changed"))
								{
									num4 = 11;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
									{
										num4 = 37;
									}
									continue;
								}
								goto case 1;
								IL_0381:
								flag2 = false;
								num4 = 31;
								continue;
								IL_0306:
								num4 = 36;
								continue;
								IL_084a:
								text2 = text3;
								num4 = 29;
								continue;
								IL_0787:
								if (!(text2 == "refresh_failed"))
								{
									goto IL_0381;
								}
								num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
								{
									num4 = 40;
								}
								continue;
								IL_083c:
								text = (string)obj;
								num5 = 21;
								goto IL_00bb;
								IL_06a6:
								c = ((dynamic)(text2)).Chars;
								num4 = 5;
								continue;
								IL_0670:
								if ((text2 == "probe_failed"))
								{
									num4 = 35;
									continue;
								}
								goto IL_0381;
								IL_00bb:
								num7 = num5;
								goto IL_00bf;
								IL_0625:
								if (!(text2 == "credential_mismatch"))
								{
									num4 = 19;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
									{
										num4 = 24;
									}
									continue;
								}
								goto case 1;
								IL_00bf:
								num4 = num7;
								continue;
							}
							flag = (byte)num6 != 0;
							num4 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 != 0)
							{
								num4 = 13;
							}
							continue;
							end_IL_00c3:
							break;
						}
					}
					finally
					{
						if (val != null)
						{
							int num9 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
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
									(val).Dispose();
									num9 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
									{
										num9 = 0;
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
				catch (JsonException)
				{
					int num11 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f != 0)
					{
						num11 = 0;
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
						case 0:
							result = (BMqtYNX3dibE9UCe1e8O)new BMqtYNX3dibE9UCe1e8O((string?)null, "stage=credentials state=invalid");
							num11 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
							{
								num11 = 4;
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
	private static string? QtdX3OXgIDj(JsonElement root, object name)
	{
		int num = 2;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string Mw6X35NS0WP(JsonElement root, object name)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		(defaultInterpolatedStringHandler).AppendLiteral("=");
		return null;
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
	private bool cIXX36Rh9io(StringBuilder builder)
	{
		System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(BMqtYNX3dibE9UCe1e8O? left, BMqtYNX3dibE9UCe1e8O? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(BMqtYNX3dibE9UCe1e8O? left, BMqtYNX3dibE9UCe1e8O? right)
	{
		int num = 1;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return (EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SliX3e00ZYB)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(axrX3PS7Z50);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as BMqtYNX3dibE9UCe1e8O);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(BMqtYNX3dibE9UCe1e8O? other)
	{
		int num = 6;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public BMqtYNX3dibE9UCe1e8O RxUX3RRA2On()
	{
		return (BMqtYNX3dibE9UCe1e8O)new BMqtYNX3dibE9UCe1e8O(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private BMqtYNX3dibE9UCe1e8O(BMqtYNX3dibE9UCe1e8O original)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void w1AX3wKrtl0(out string? Phase, out string Diagnostic)
	{
		Phase = default(string?);
		Diagnostic = default(string);
		//IL_0008: Expected I8, but got O
Phase = this.Phase;  // was Unsafe.As<_,long> reinterpret
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool MiF28eZP49GsBXYYIqiL()
	{
		return bD0uUdZPCuL5HfTh5qM2 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static BMqtYNX3dibE9UCe1e8O KeV9ClZPh1EOPGoVZF2R()
	{
		return (BMqtYNX3dibE9UCe1e8O)bD0uUdZPCuL5HfTh5qM2;
	}
}
