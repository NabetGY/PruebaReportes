using Api.DTOs;

namespace Api.Reportes;

public class Firma
{
    private Firma()
    {

    }
    
    private Firma(Guid id, Guid eventoId, string? firmaImagen)
    {
        Id = id;
        EventoId = eventoId;
        FirmaImagen = firmaImagen;
    }

    public Guid Id { get; private set; }

    public Guid EventoId { get; private set; }

    public string? FirmaImagen { get; private set; }


    public static Firma CrearFirma(FirmaDTO data)
    {
        var firma = new Firma(
            Guid.NewGuid(),
            data.EventoId,
            data.FirmaImagen
        );

        return firma;
    }
}
