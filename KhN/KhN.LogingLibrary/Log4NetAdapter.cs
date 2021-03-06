using Microsoft.AspNetCore.Http;

namespace KhN.LogingLibrary
{
	public class Log4NetAdapter<T> : Logger<T> where T : class
	{
		public Log4NetAdapter (IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
		{
		}

		protected override void LogByFavoriteLibrary(Log log, Exception exception)
		{
			throw new NotImplementedException();
		}
	}
}
