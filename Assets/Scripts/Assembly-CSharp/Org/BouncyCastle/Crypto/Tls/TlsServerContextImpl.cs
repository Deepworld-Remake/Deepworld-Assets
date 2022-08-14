using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Tls
{
	internal class TlsServerContextImpl : AbstractTlsContext
	{
		internal TlsServerContextImpl(SecureRandom secureRandom, SecurityParameters securityParameters) : base(default(SecureRandom), default(SecurityParameters))
		{
		}

	}
}
