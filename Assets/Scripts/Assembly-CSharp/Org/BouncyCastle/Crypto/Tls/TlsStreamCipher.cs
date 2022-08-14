using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Crypto.Tls
{
	public class TlsStreamCipher
	{
		public TlsStreamCipher(TlsContext context, IStreamCipher clientWriteCipher, IStreamCipher serverWriteCipher, IDigest clientWriteDigest, IDigest serverWriteDigest, int cipherKeySize, bool usesNonce)
		{
		}

	}
}
