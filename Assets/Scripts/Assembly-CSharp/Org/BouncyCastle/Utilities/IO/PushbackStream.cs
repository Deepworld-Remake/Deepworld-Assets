using System.IO;

namespace Org.BouncyCastle.Utilities.IO
{
	public class PushbackStream : FilterStream
	{
		public PushbackStream(Stream s) : base(default(Stream))
		{
		}

	}
}
