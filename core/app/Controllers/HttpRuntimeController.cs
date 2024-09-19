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
		public IActionResult GetAppDomainId(IServer server)
		{
			/*
			 *	Only available in .NET Framework
			 */
			return NotFound();
		}

		[Route("app-domain-app-path")]
		[HttpGet]
		public string GetAppDomainAppPath(IServer server)
		{
			return server.Features.Get<IIISEnvironmentFeature>().ApplicationPhysicalPath;
		}

		[Route("app-domain-app-id")]
		[HttpGet]
		public string GetAppDomainAppId(IServer server)
		{
			return server.Features.Get<IIISEnvironmentFeature>().ApplicationId;
		}
	}
}
