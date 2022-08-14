using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Math.EC.Custom.Djb
{
	internal class Curve25519Point : AbstractFpPoint
	{
		public Curve25519Point(ECCurve curve, ECFieldElement x, ECFieldElement y) : base(default(ECCurve), default(ECFieldElement), default(ECFieldElement), default(bool))
		{
		}

	}
}
