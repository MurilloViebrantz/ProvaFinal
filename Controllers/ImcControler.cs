using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ProvaFinal.model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking;


namespace ProvaFinal.Controllers
{
    [Route("imc")]
    [ApiController]
    public class ImcController : ControllerBase
    {
       

        [Route("cadastrar")]
        [HttpPost]
        public IActionResult CadastrarImc([FromBody] Imc Imc)
        {
            _context.Medico.Add(imc);
            _context.SaveChanges();
            return Created("", imc); 
        }

        [Route("listar")]
        [HttpGet]
        public IActionResult ListarImc() {
            return Ok(_context.Imc.ToList());
        }