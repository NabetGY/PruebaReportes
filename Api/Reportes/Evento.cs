using Api.DTOs;

namespace Api.Reportes;

public sealed class Evento
{
    private Evento()
    {

    }
    
    private Evento(Guid id, string? titulo, string? categoria, string? prioridad, string? puestoSeguridad, string? creadoPor, DateTime fechaInicio, string? cerradoPor, DateTime fechaFin, string? coordenadas, string? mapaUrl, string? tipoEvento, string? tipoEventoImagen, bool impacto)
    {
        Id = id;
        Titulo = titulo;
        Categoria = categoria;
        Prioridad = prioridad;
        PuestoSeguridad = puestoSeguridad;
        CreadoPor = creadoPor;
        FechaInicio = fechaInicio;
        CerradoPor = cerradoPor;
        FechaFin = fechaFin;
        Coordenadas = coordenadas;
        MapaUrl = mapaUrl;
        TipoEvento = tipoEvento;
        TipoEventoImagen = tipoEventoImagen;
        Impacto = impacto;
    }

    public Guid Id { get; private set; }

    public string? Titulo { get; private set; }

    public string? Categoria { get; private set; }

    public string? Prioridad { get; private set; }

    public string? PuestoSeguridad { get; private set; }

    public string? CreadoPor { get; private set; }

    public DateTime FechaInicio { get; private set; }

    public string? CerradoPor { get; private set; }

    public DateTime FechaFin { get; private set; }

    public string? Coordenadas { get; private set; }

    public string? MapaUrl { get; private set; }

    public string? TipoEvento { get; private set; }

    public string? TipoEventoImagen { get; private set; }

    public bool Impacto { get; private set; }

    public static Evento CrearEvento(EventoDTO data)
    {
        var evento = new Evento(
            Guid.NewGuid(),
            data.Titulo,
            data.Categoria,
            data.Prioridad,
            data.PuestoSeguridad,
            data.CreadoPor,
            data.FechaInicio,
            data.CerradoPor,
            data.FechaFin,
            data.Coordenadas,
            data.MapaUrl,
            data.TipoEvento,
            data.TipoEventoImagen,
            data.Impacto
        );

        return evento;
    }
}
