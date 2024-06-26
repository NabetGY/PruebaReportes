using Api.DTOs;

namespace Api.Reportes;

public class AvisoSapPm
{

    private AvisoSapPm()
    {

    }

    private AvisoSapPm(Guid id, Guid eventoId, string? ubicacionTecnica, string? ubicacionTecnicaImg,
        string? parteObjectoAfectada, string? parteObjectoAfectadaImg, string? modoFalla, 
        string? modoFallaImg, string? descripcionCorta, DateOnly fechaIncioAveria, TimeOnly horaInicioAveria, bool equipoContinuaOperando, bool solucionadoPorBEC)
    {
        Id = id;
        EventoId = eventoId;
        UbicacionTecnica = ubicacionTecnica;
        UbicacionTecnicaImg = ubicacionTecnicaImg;
        ParteObjectoAfectada = parteObjectoAfectada;
        ParteObjectoAfectadaImg = parteObjectoAfectadaImg;
        ModoFalla = modoFalla;
        ModoFallaImg = modoFallaImg;
        DescripcionCorta = descripcionCorta;
        FechaIncioAveria = fechaIncioAveria;
        HoraInicioAveria = horaInicioAveria;
        EquipoContinuaOperando = equipoContinuaOperando;
        SolucionadoPorBEC = solucionadoPorBEC;
    }

    public Guid Id { get; private set; }

    public Guid EventoId { get; private set; }

    public string? UbicacionTecnica { get; private set; }

    public string? UbicacionTecnicaImg { get; private set; }

    public string? ParteObjectoAfectada { get; private set; }

    public string? ParteObjectoAfectadaImg { get; private set; }

    public string? ModoFalla { get; private set; }

    public string? ModoFallaImg { get; private set; }

    public string? DescripcionCorta { get; private set; }

    public DateOnly FechaIncioAveria { get; private set; }

    public TimeOnly HoraInicioAveria { get; private set; }

    public bool EquipoContinuaOperando { get; private set; }

    public bool SolucionadoPorBEC { get; private set; }

    
    public static AvisoSapPm CrearAviso(AvisoSapPmDTO data)
    {
        var aviso = new AvisoSapPm(
            Guid.NewGuid(),
            data.EventoId,
            data.UbicacionTecnica,
            data.UbicacionTecnicaImg,
            data.ParteObjectoAfectada,
            data.ParteObjectoAfectadaImg,
            data.ModoFalla,
            data.ModoFallaImg,
            data.DescripcionCorta,
            DateOnly.FromDateTime(data.FechaIncioAveria),
            TimeOnly.FromDateTime(data.FechaIncioAveria),
            data.EquipoContinuaOperando,
            data.SolucionadoPorBEC
        );

        return aviso;
    }

}
