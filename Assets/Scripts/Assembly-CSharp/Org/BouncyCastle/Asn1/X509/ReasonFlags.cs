using Org.BouncyCastle.Asn1;

namespace Org.BouncyCastle.Asn1.X509
{
	public class ReasonFlags : DerBitString
	{
		public ReasonFlags(int reasons) : base(default(byte[]))
		{
		}

	}
}
