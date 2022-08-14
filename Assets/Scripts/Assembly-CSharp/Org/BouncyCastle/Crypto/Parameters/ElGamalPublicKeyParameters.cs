using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	public class ElGamalPublicKeyParameters : ElGamalKeyParameters
	{
		public ElGamalPublicKeyParameters(BigInteger y, ElGamalParameters parameters) : base(default(bool), default(ElGamalParameters))
		{
		}

	}
}
