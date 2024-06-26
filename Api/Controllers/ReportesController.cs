using Api.DTOs;
using Api.Reportes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[ApiController]
[Route("api/reportes")]
public class ReportesController : ControllerBase
{
    private readonly ApplicationDbContext _dbContext;

    public ReportesController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult> GetAll()
    {
        var eventos = await _dbContext.Eventos.ToListAsync();

        var avisosSapPm = await _dbContext.AvisosSapPm.ToListAsync();

        var avisosY2 = await _dbContext.AvisosY2.ToListAsync();

        var firmas = await _dbContext.Firmas.ToListAsync();

        var data = new Dictionary<string, IEnumerable<object>>();

        data.Add("eventos", eventos);
        data.Add("avisosSapPm", avisosSapPm);
        data.Add("avisosY2", avisosY2);
        data.Add("firmas", firmas);


        return Ok(data);
    }

    [HttpPost("save_evento")]
    public async Task<IActionResult> SaveEvento(EventoDTO request)
    {
        var evento = Evento.CrearEvento(request);

        _dbContext.Add(evento);

        await _dbContext.SaveChangesAsync();

        return Ok(evento);
    }

    [HttpPost("save_aviso_sap_pm")]
    public async Task<IActionResult> SaveSapPm(AvisoSapPmDTO request)
    {
        var aviso = AvisoSapPm.CrearAviso(request);

        _dbContext.Add(aviso);

        await _dbContext.SaveChangesAsync();

        return Ok(aviso);
    }

    [HttpPost("save_aviso_y2")]
    public async Task<IActionResult> SaveY2(AvisoY2DTO request)
    {
        var aviso = AvisoY2.CrearAviso(request);

        _dbContext.Add(aviso);

        await _dbContext.SaveChangesAsync();

        return Ok(aviso);
    }

    [HttpPost("save_firma")]
    public async Task<IActionResult> SaveFirma(FirmaDTO request)
    {
        var firma = Firma.CrearFirma(request);

        _dbContext.Add(firma);

        await _dbContext.SaveChangesAsync();

        return Ok(firma);
    }

    


}
