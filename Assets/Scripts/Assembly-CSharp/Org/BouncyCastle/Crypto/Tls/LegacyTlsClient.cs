using System;
using System.Collections.Generic;

namespace Org.BouncyCastle.Crypto.Tls
{
	public class LegacyTlsClient : DefaultTlsClient
	{
		public LegacyTlsClient(Uri targetUri, ICertificateVerifyer verifyer, IClientCredentialsProvider prov, List<string> hostNames)
		{
		}

	}
}
