using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using AspProject.Models;
namespace AspProject.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "Hello World from HelloController!";
        }
    }
}
