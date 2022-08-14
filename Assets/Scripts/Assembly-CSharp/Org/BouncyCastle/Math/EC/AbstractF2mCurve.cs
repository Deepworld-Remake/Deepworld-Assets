using Org.BouncyCastle.Math.Field;

namespace Org.BouncyCastle.Math.EC
{
	public class AbstractF2mCurve : ECCurve
	{
		protected AbstractF2mCurve(int m, int k1, int k2, int k3) : base(default(IFiniteField))
		{
		}

	}
}
