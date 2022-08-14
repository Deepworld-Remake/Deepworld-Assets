using Org.BouncyCastle.Utilities.IO;
using System.IO;

namespace Org.BouncyCastle.Asn1
{
	public class Asn1InputStream : FilterStream
	{
		public Asn1InputStream(Stream inputStream) : base(default(Stream))
		{
		}

	}
}
