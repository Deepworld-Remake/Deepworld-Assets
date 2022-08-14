using System.Collections;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Tls
{
	public class TlsDHKeyExchange : AbstractTlsKeyExchange
	{
		public TlsDHKeyExchange(int keyExchange, IList supportedSignatureAlgorithms, DHParameters dhParameters) : base(default(int), default(IList))
		{
		}

	}
}
