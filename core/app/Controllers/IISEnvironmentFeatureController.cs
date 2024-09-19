using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS;

namespace app.Controllers
{
	[Route("api/iis-environment-feature")]
	[ApiController]
	public class IISEnvironmentFeatureController : ControllerBase
	{
		[HttpGet]
		public IIISEnvironmentFeature Get(IServer server)
		{
			return server.Features.Get<IIISEnvironmentFeature>();
		}
	}
}
