using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	public class DsaPublicKeyParameters : DsaKeyParameters
	{
		public DsaPublicKeyParameters(BigInteger y, DsaParameters parameters) : base(default(bool), default(DsaParameters))
		{
		}

	}
}
