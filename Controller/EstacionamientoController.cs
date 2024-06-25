using Microsoft.AspNetCore.Mvc;
using System;

[Route("api/[controller]")]
[ApiController]
public class EstacionamientoController : ControllerBase
{
    private Estacionamiento estacionamiento;

    public EstacionamientoController()
    {
        
        this.estacionamiento = new Estacionamiento(80);
    }

    [HttpGet("consultar")]
    public ActionResult<int> ConsultarLugaresDisponibles()
    {
        return Ok(estacionamiento.ConsultarLugaresDisponibles());
    }

    [HttpPost("agregar")]
    public ActionResult AgregarLugares([FromBody] int cantidad)
    {
        try
        {
            estacionamiento.AgregarLugares(cantidad);
            return Ok($"Se han agregado {cantidad} lugares correctamente.");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("eliminar")]
    public ActionResult EliminarLugares([FromBody] int cantidad)
    {
        try
        {
            estacionamiento.EliminarLugares(cantidad);
            return Ok($"Se han eliminado {cantidad} lugares correctamente.");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}