namespace Org.BouncyCastle.Math.EC
{
	public class AbstractFpPoint : ECPointBase
	{
		protected AbstractFpPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression) : base(default(ECCurve), default(ECFieldElement), default(ECFieldElement), default(bool))
		{
		}

	}
}
