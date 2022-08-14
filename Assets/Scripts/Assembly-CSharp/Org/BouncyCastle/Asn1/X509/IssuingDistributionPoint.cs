using Org.BouncyCastle.Asn1;

namespace Org.BouncyCastle.Asn1.X509
{
	public class IssuingDistributionPoint : Asn1Encodable
	{
		public IssuingDistributionPoint(DistributionPointName distributionPoint, bool onlyContainsUserCerts, bool onlyContainsCACerts, ReasonFlags onlySomeReasons, bool indirectCRL, bool onlyContainsAttributeCerts)
		{
		}

	}
}
