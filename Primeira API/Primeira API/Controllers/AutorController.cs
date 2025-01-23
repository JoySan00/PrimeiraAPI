using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Primeira_API.Models;
using Primeira_API.Services.Autor;

namespace Primeira_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly IAutorInterface _autorinterface;
        public AutorController(IAutorInterface autorInterface) 
        {
            _autorinterface = autorInterface;
            
        }
        [HttpGet("ListarAutores")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> ListarAutores()
        {
            var autores = await _autorinterface.ListarAutores();
            return Ok(autores);
        }
    }
}
