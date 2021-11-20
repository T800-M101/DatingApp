using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // [controller is a placeholder that will be switched with the name of the database users]
    public class BaseApiController : ControllerBase
    {
        
    }
}