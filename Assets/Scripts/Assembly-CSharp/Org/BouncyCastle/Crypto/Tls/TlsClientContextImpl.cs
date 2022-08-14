using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Tls
{
	internal class TlsClientContextImpl : AbstractTlsContext
	{
		internal TlsClientContextImpl(SecureRandom secureRandom, SecurityParameters securityParameters) : base(default(SecureRandom), default(SecurityParameters))
		{
		}

	}
}
