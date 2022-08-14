using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Crypto.Modes
{
	public class CtsBlockCipher : BufferedBlockCipher
	{
		public CtsBlockCipher(IBlockCipher cipher) : base(default(IBlockCipher))
		{
		}

	}
}
