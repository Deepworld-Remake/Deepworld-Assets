using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Crypto.Tls
{
	public class TlsBlockCipher
	{
		public TlsBlockCipher(TlsContext context, IBlockCipher clientWriteCipher, IBlockCipher serverWriteCipher, IDigest clientWriteDigest, IDigest serverWriteDigest, int cipherKeySize)
		{
		}

	}
}
