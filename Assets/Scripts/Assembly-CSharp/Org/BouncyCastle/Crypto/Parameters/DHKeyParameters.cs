using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Crypto.Parameters
{
	public class DHKeyParameters : AsymmetricKeyParameter
	{
		protected DHKeyParameters(bool isPrivate, DHParameters parameters) : base(default(bool))
		{
		}

	}
}
