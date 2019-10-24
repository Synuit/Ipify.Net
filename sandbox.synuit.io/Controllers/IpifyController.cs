using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ipify.Net.Controllers
{
    [Produces("application/json")]
    [Route("api/Ipify")]
    public class IpifyController : Controller
    {
 
        // GET: api/Ipify/getAddr
        [HttpGet("{id}", Name = "Get")]
        public string GetAddress()
        {
         var remoteIpAddress = Request.HttpContext.Connection.RemoteIpAddress;
         return remoteIpAddress.ToString();
        }
        
       
        
   
    }
}
