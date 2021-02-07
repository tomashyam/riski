using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using webapi.Models;
using System;

namespace webapi.Controllers
{
    [System.Web.Http.Route("api/[controller]")]
    [ApiController]
    public class ChargeController : ControllerBase
    {
        
        [System.Web.Http.HttpPost]
        public StatusCodeResult ChargeCredit([FromBody] JObject transaction)
        {
            try
            {
                var tran = transaction.ToObject<TransactionInfo>();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }


            return Ok();
        }
    }
}
