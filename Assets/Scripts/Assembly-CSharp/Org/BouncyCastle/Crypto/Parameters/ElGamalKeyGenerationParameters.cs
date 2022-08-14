using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	public class ElGamalKeyGenerationParameters : KeyGenerationParameters
	{
		public ElGamalKeyGenerationParameters(SecureRandom random, ElGamalParameters parameters) : base(default(SecureRandom), default(int))
		{
		}

	}
}
