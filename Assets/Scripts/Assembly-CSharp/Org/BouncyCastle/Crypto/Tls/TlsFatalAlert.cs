using System.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	public class TlsFatalAlert : IOException
	{
		public TlsFatalAlert(byte alertDescription)
		{
		}

	}
}
