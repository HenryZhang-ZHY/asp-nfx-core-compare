using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS;

namespace app.Controllers
{
	[Route("api/http-runtime")]
	[ApiController]
	public class HttpRuntimeController : ControllerBase
	{
		[Route("app-domain-id")]
		[HttpGet]
		public string GetAppDomainId(IServer server)
		{
			return server.Features.Get<IIISEnvironmentFeature>().ApplicationId;
		}
	}
}
