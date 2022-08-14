using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Tls
{
	public class TlsClientProtocol : TlsProtocol
	{
		public TlsClientProtocol(SecureRandom secureRandom) : base(default(SecureRandom))
		{
		}

	}
}
