using api_rest.Models;
using Microsoft.AspNetCore.Mvc;

namespace api_rest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : Controller
    {
        private readonly SistemaVentasContext _context;

        public ClientesController(SistemaVentasContext ctx)
        {
            _context = ctx;
        }

        // 1. SELECT (Obtener todos)
        [HttpGet("ListarUsuarios")]
        public ActionResult<List<Cliente>> ListarClientes()
        {
            return _context.Clientes.ToList();
        }

        // 2. SELECT (Obtener por ID)
        [HttpGet("ObtenerUsuario/{id}")]
        public ActionResult<Cliente> ObtenerUsuario(int id)
        {
            var cliente = _context.Clientes.FirstOrDefault(e => e.IdCliente == id);
            if (cliente == null)
            {
                return NotFound("Cliente no encontrado");
            }
            return cliente;
        }

        // 3. INSERT (Crear nuevo cliente)
        [HttpPost("CrearUsuario")]
        public ActionResult CrearUsuario([FromBody] Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return Ok(cliente);
        }

        // 4. UPDATE (Actualizar cliente existente)
        [HttpPut("ActualizarUsuario/{id}")]
        public ActionResult ActualizarUsuario(int id, [FromBody] Cliente clienteModificado)
        {
            var clienteExistente = _context.Clientes.FirstOrDefault(e => e.IdCliente == id);

            if (clienteExistente == null)
            {
                return NotFound("Cliente no encontrado");
            }

            clienteExistente.Nit = clienteModificado.Nit;
            clienteExistente.Nombre = clienteModificado.Nombre;
            clienteExistente.Apellidos = clienteModificado.Apellidos;
            clienteExistente.Email = clienteModificado.Email;

            _context.SaveChanges();
            return Ok(clienteExistente);
        }
    }
}