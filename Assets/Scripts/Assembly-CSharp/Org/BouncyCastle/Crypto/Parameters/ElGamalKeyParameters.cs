using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Crypto.Parameters
{
	public class ElGamalKeyParameters : AsymmetricKeyParameter
	{
		protected ElGamalKeyParameters(bool isPrivate, ElGamalParameters parameters) : base(default(bool))
		{
		}

	}
}
