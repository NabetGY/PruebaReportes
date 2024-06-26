using Api.DTOs;

namespace Api.Reportes;

public class AvisoY2
{
    public AvisoY2(Guid id, Guid idEvento, int numeroAvisoY2, bool corregidoPorMantenimiento)
    {
        Id = id;
        IdEvento = idEvento;
        NumeroAvisoY2 = numeroAvisoY2;
        CorregidoPorMantenimiento = corregidoPorMantenimiento;
    }

    public Guid Id { get; private set; }

    public Guid IdEvento { get; private set; }

    public int NumeroAvisoY2 { get; private set; }

    public bool CorregidoPorMantenimiento { get; private set; }


    public static AvisoY2 CrearAviso(AvisoY2DTO data)
    {
        var aviso = new AvisoY2(
            Guid.NewGuid(),
            data.IdEvento,
            data.NumeroAvisoY2,
            data.CorregidoPorMantenimiento
        );

        return aviso;
    }
}
