using System.Linq;
using ProvaFinal.model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;


namespace ProvaFinal.Controllers
{
    [Route("usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly DataContext _context;

        public PacienteController(DataContext context) => _context = context;

        [Route("cadastrar")]
        [HttpPost]
        public IActionResult CadastrarUsuario([FromBody] Usuario usuario)
        {
            _context.Paciente.Add(usuario);
            _context.SaveChanges();
            return Created("", usuario);
        }

        [Route("alterar")]
        [HttpPatch]
        public IActionResult Alterar([FromBody] Usuario usuario)
        {
            _context.Usuario.Update(usuario);
            _context.SaveChanges();
            return Ok(usuario);
        }

    }
}