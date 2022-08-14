using System.Collections;

namespace Org.BouncyCastle.Crypto.Tls
{
	public class TlsECDheKeyExchange : TlsECDHKeyExchange
	{
		public TlsECDheKeyExchange(int keyExchange, IList supportedSignatureAlgorithms, int[] namedCurves, byte[] clientECPointFormats, byte[] serverECPointFormats) : base(default(int), default(IList), default(int[]), default(byte[]), default(byte[]))
		{
		}

	}
}
