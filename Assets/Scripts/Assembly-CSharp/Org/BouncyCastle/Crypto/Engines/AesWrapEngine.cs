using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Crypto.Engines
{
	public class AesWrapEngine : Rfc3394WrapEngine
	{
		public AesWrapEngine() : base(default(IBlockCipher))
		{
		}

	}
}
