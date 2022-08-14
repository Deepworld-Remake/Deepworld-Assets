using System.IO;

namespace Org.BouncyCastle.Asn1
{
	internal class DefiniteLengthInputStream : LimitedInputStream
	{
		internal DefiniteLengthInputStream(Stream inStream, int length) : base(default(Stream), default(int))
		{
		}

	}
}
