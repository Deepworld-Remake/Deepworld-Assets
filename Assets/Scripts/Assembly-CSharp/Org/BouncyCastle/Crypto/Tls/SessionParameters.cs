namespace Org.BouncyCastle.Crypto.Tls
{
	public class SessionParameters
	{
		private SessionParameters(int cipherSuite, byte compressionAlgorithm, byte[] masterSecret, Certificate peerCertificate, byte[] pskIdentity, byte[] srpIdentity, byte[] encodedServerExtensions)
		{
		}

	}
}
