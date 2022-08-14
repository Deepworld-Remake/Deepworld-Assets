using System.IO;

namespace Org.BouncyCastle.Asn1
{
	internal class IndefiniteLengthInputStream : LimitedInputStream
	{
		internal IndefiniteLengthInputStream(Stream inStream, int limit) : base(default(Stream), default(int))
		{
		}

	}
}
