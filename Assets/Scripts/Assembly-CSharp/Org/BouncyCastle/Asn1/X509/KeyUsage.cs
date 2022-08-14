using Org.BouncyCastle.Asn1;

namespace Org.BouncyCastle.Asn1.X509
{
	public class KeyUsage : DerBitString
	{
		public KeyUsage(int usage) : base(default(byte[]))
		{
		}

	}
}
