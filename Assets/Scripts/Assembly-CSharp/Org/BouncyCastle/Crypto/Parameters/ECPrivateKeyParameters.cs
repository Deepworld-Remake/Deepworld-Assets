using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	public class ECPrivateKeyParameters : ECKeyParameters
	{
		public ECPrivateKeyParameters(BigInteger d, ECDomainParameters parameters) : base(default(string), default(bool), default(ECDomainParameters))
		{
		}

	}
}
