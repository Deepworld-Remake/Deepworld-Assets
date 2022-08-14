using BestHTTP;
using System.IO;

namespace BestHTTP.ServerSentEvents
{
	public class EventSourceResponse : HTTPResponse
	{
		public EventSourceResponse(HTTPRequest request, Stream stream, bool isStreamed, bool isFromCache) : base(default(HTTPRequest), default(Stream), default(bool), default(bool))
		{
		}

	}
}
