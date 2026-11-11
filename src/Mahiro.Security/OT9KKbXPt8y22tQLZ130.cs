using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace fBuYBxXPOMyUrWSb36Fu;

internal sealed class OT9KKbXPt8y22tQLZ130
{
	private readonly string? JbRXPeDpBVg;

	private static object XryaMcZ6nEn9nGivAPvX;

	[MethodImpl((MethodImplOptions)8)]
	internal OT9KKbXPt8y22tQLZ130(string? cachePath)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task<byte[]?> qgQXP5jUtkw(string buildCode, string expectedXxh, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_TryReadAsync_d__2 tryReadAsync_d__ = default(_TryReadAsync_d__2);
		tryReadAsync_d__.__t__builder = AsyncTaskMethodBuilder<byte[]>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task GBCXP6dSq7y(string buildCode, string manifestXxh, byte[] bytes, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_WriteAsync_d__3 writeAsync_d__ = default(_WriteAsync_d__3);
		writeAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private string Te5XPRsabBH(string buildCode, string manifestXxh)
	{
		string text = System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData((System.Text.Encoding.UTF8).GetBytes(string.Concat(buildCode, "\n", manifestXxh))));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void NFWXPwg0qbY(object path)
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
				if (!System.IO.File.Exists((string)path))
				{
					return;
				}
				int num2 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
				{
					num2 = 2;
				}
				while (true)
				{
					switch (num2)
					{
					default:
						if (num3 == 989)
						{
							num2 = num3;
							break;
						}
						return;
					case 0:
						System.IO.File.Delete((string)path);
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 != 0)
						{
							num2 = 3;
						}
						break;
					case 1:
						return;
					}
				}
			}
			catch (global::System.Exception)
			{
				int num4 = 5;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
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
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool SYRk7LZ6z6GQET5Su9JF()
	{
		return XryaMcZ6nEn9nGivAPvX == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static OT9KKbXPt8y22tQLZ130 NKFNUZZRbsIh0MIMnuRT()
	{
		return (OT9KKbXPt8y22tQLZ130)XryaMcZ6nEn9nGivAPvX;
	}
}
