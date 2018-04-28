using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using APIIndicadores.Models;
using APIIndicadores.Data;

namespace APIIndicadores.Controllers
{
    [Route("api/[controller]")]
    public class BolsasController : Controller
    {
        [HttpGet]
        public List<BolsaValores> Get(
            [FromServices]ApplicationDbContext context)
        {
            return (from b in context.BolsasValores
                    select b).ToList();
        }
    }
}