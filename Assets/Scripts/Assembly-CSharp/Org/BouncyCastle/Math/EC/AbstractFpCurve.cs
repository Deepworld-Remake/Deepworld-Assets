using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.Field;

namespace Org.BouncyCastle.Math.EC
{
	public class AbstractFpCurve : ECCurve
	{
		protected AbstractFpCurve(BigInteger q) : base(default(IFiniteField))
		{
		}

	}
}
