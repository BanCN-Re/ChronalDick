namespace qS8vkpL43FlTMgcj0rgs
{
	// The Reactor engine type itself is protection-layer code and is intentionally not restored.
	// Only the string-decrypt entry point is referenced by business code; the literal text is
	// encrypted inside the original assembly, so the value is preserved only as its integer id.
	internal class g9MiPrL41bvmHLMo2Exb
	{
		internal static string YoQLhoegTpw(int value) => value.ToString();

		// Substitute for the Reactor resource-stream proxy nested type. The business code only
		// needs "wrap a manifest resource stream, expose it, and read a fixed-length block", so a
		// passthrough wrapper preserves the observable behavior for uncompressed resources.
		internal sealed class YUec0jLr8udpaMfJhw8y
		{
			private readonly global::System.IO.Stream _stream;

			public YUec0jLr8udpaMfJhw8y(global::System.IO.Stream stream)
			{
				_stream = stream;
			}

			internal global::System.IO.Stream KR5785vTkC()
			{
				return _stream;
			}

			internal object IHnLrySmBWA(int count)
			{
				byte[] buffer = new byte[count];
				int offset = 0;
				while (offset < count)
				{
					int read = _stream.Read(buffer, offset, count - offset);
					if (read <= 0)
					{
						break;
					}
					offset += read;
				}
				if (offset != count)
				{
					global::System.Array.Resize(ref buffer, offset);
				}
				return buffer;
			}
		}
	}
}
