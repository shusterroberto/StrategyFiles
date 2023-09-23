using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using System.Threading;

namespace Application.Web.Api.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    //[RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class ManagerBinController : ControllerBase
    {
        [HttpPut(Name = "FileProcessDXC")]
        public bool FileProcessDXC(string filepath)
        {
            FileProcessDXC dxc = new(filepath);
            return true;
        }
    }
}