using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	public class ECKeyGenerationParameters : KeyGenerationParameters
	{
		public ECKeyGenerationParameters(ECDomainParameters domainParameters, SecureRandom random) : base(default(SecureRandom), default(int))
		{
		}

	}
}
