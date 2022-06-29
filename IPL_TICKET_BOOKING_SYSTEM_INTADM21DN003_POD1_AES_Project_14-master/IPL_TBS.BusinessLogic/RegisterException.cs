using System;
using System.Runtime.Serialization;

namespace IPL_TBS.BusinessLogic
{
	[Serializable]
	internal class RegisterException : Exception
	{
		public RegisterException()
		{
		}

		public RegisterException(string message) : base(message)
		{
		}

		public RegisterException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/*public RegisterException(string message, Exception innerException) : base(message, innerException)
		{
		}
		*/
		protected RegisterException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}