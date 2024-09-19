using System.Web;
using System.Web.Http;

namespace app.Controllers
{
    [RoutePrefix("api/http-runtime")]
    public class HttpRuntimeController : ApiController
    {
		[Route("app-domain-id")]
		public string GetAppDomainId()
		{
			return HttpRuntime.AppDomainId;
		}
	}
}
