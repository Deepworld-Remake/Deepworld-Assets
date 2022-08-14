using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	public class RsaKeyParameters : AsymmetricKeyParameter
	{
		public RsaKeyParameters(bool isPrivate, BigInteger modulus, BigInteger exponent) : base(default(bool))
		{
		}

	}
}
