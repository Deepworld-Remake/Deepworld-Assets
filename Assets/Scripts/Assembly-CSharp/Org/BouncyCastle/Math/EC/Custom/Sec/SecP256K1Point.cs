using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	internal class SecP256K1Point : AbstractFpPoint
	{
		public SecP256K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y) : base(default(ECCurve), default(ECFieldElement), default(ECFieldElement), default(bool))
		{
		}

	}
}
