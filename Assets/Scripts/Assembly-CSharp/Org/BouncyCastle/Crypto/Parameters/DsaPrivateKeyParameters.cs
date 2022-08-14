using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	public class DsaPrivateKeyParameters : DsaKeyParameters
	{
		public DsaPrivateKeyParameters(BigInteger x, DsaParameters parameters) : base(default(bool), default(DsaParameters))
		{
		}

	}
}
