using System.IO;

namespace Org.BouncyCastle.Asn1
{
	public class BerOutputStream : DerOutputStream
	{
		public BerOutputStream(Stream os) : base(default(Stream))
		{
		}

	}
}
