using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Crypto.Parameters
{
	public class ECKeyParameters : AsymmetricKeyParameter
	{
		protected ECKeyParameters(string algorithm, bool isPrivate, ECDomainParameters parameters) : base(default(bool))
		{
		}

	}
}
