using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Crypto.Parameters
{
	public class ECPublicKeyParameters : ECKeyParameters
	{
		public ECPublicKeyParameters(ECPoint q, ECDomainParameters parameters) : base(default(string), default(bool), default(ECDomainParameters))
		{
		}

	}
}
