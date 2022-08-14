using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	public class DHPrivateKeyParameters : DHKeyParameters
	{
		public DHPrivateKeyParameters(BigInteger x, DHParameters parameters) : base(default(bool), default(DHParameters))
		{
		}

	}
}
