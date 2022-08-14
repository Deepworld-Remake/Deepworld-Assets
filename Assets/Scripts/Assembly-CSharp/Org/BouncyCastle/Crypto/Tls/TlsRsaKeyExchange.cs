using System.Collections;

namespace Org.BouncyCastle.Crypto.Tls
{
	public class TlsRsaKeyExchange : AbstractTlsKeyExchange
	{
		public TlsRsaKeyExchange(IList supportedSignatureAlgorithms) : base(default(int), default(IList))
		{
		}

	}
}
