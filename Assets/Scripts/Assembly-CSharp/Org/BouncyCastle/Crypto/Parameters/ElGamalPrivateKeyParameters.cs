using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	public class ElGamalPrivateKeyParameters : ElGamalKeyParameters
	{
		public ElGamalPrivateKeyParameters(BigInteger x, ElGamalParameters parameters) : base(default(bool), default(ElGamalParameters))
		{
		}

	}
}
