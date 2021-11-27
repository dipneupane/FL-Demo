using System.Collections.Generic;

namespace FL.Domain.Response
{
	public class ResponseBase
	{
		public ResponseBase()
		{
			Errors = new List<string>();
		}

		public bool Success { get; set; }
		public List<string> Errors { get; set; }
	}
}
