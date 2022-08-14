using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	public class DsaKeyGenerationParameters : KeyGenerationParameters
	{
		public DsaKeyGenerationParameters(SecureRandom random, DsaParameters parameters) : base(default(SecureRandom), default(int))
		{
		}

	}
}
