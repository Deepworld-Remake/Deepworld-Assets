using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Crypto.Paddings
{
	public class PaddedBufferedBlockCipher : BufferedBlockCipher
	{
		public PaddedBufferedBlockCipher(IBlockCipher cipher) : base(default(IBlockCipher))
		{
		}

	}
}
