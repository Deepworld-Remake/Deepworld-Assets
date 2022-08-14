using Org.BouncyCastle.Asn1;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	public class SignedData : Asn1Encodable
	{
		public SignedData(DerInteger _version, Asn1Set _digestAlgorithms, ContentInfo _contentInfo, Asn1Set _certificates, Asn1Set _crls, Asn1Set _signerInfos)
		{
		}

	}
}
