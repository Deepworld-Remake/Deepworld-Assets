using System.Collections;

namespace Org.BouncyCastle.Crypto.Tls
{
	public class TlsECDHKeyExchange : AbstractTlsKeyExchange
	{
		public TlsECDHKeyExchange(int keyExchange, IList supportedSignatureAlgorithms, int[] namedCurves, byte[] clientECPointFormats, byte[] serverECPointFormats) : base(default(int), default(IList))
		{
		}

	}
}
