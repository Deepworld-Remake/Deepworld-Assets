using Org.BouncyCastle.Utilities.IO;
using System.IO;

namespace Org.BouncyCastle.Asn1
{
	public class DerOutputStream : FilterStream
	{
		public DerOutputStream(Stream os) : base(default(Stream))
		{
		}

	}
}
