using eCommerce.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository _repository;

        public UsuariosController()
        {
            _repository = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult Get() 
        {
            return Ok(_repository.Get());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id) 
        {
            var usuario = _repository.Get(id);

            if (usuario == null) 
            {
                return NotFound();
            }

            return Ok(usuario);
        }
    }
}
