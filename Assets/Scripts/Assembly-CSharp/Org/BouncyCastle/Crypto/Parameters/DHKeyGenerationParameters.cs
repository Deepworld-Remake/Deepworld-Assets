using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	public class DHKeyGenerationParameters : KeyGenerationParameters
	{
		public DHKeyGenerationParameters(SecureRandom random, DHParameters parameters) : base(default(SecureRandom), default(int))
		{
		}

	}
}
