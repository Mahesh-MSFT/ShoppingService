using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingService.Models;

namespace ShoppingService.Controllers
{
    [Route("api/[controller]")]
    public class ShoppingCartController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { ((ShoppingCategoryEnum)new Random().Next(0, 10)).ToString(), Environment.MachineName };
        }
    }
}
