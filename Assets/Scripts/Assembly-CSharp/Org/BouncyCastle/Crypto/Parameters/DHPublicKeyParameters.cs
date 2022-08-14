using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	public class DHPublicKeyParameters : DHKeyParameters
	{
		public DHPublicKeyParameters(BigInteger y, DHParameters parameters) : base(default(bool), default(DHParameters))
		{
		}

	}
}
