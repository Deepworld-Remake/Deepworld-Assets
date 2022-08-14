using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Crypto.Parameters
{
	public class DsaKeyParameters : AsymmetricKeyParameter
	{
		protected DsaKeyParameters(bool isPrivate, DsaParameters parameters) : base(default(bool))
		{
		}

	}
}
