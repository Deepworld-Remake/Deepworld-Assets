using Org.BouncyCastle.Asn1;

namespace Org.BouncyCastle.Asn1.X509
{
	public class X509CertificateStructure : Asn1Encodable
	{
		public X509CertificateStructure(TbsCertificateStructure tbsCert, AlgorithmIdentifier sigAlgID, DerBitString sig)
		{
		}

	}
}
