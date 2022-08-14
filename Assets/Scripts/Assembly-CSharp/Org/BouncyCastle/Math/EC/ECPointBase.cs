namespace Org.BouncyCastle.Math.EC
{
	public class ECPointBase : ECPoint
	{
		protected ECPointBase(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression) : base(default(ECCurve), default(ECFieldElement), default(ECFieldElement), default(bool))
		{
		}

	}
}
