using System;
using System.Runtime.Serialization;

namespace IPL_TBS.API.Controllers
{
	[Serializable]
	internal class IPLException : Exception
	{
		public IPLException()
		{
		}

		public IPLException(string message) : base(message)
		{
		}

		public IPLException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected IPLException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}