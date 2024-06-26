namespace Api.DTOs;

public sealed record AvisoSapPmDTO
(
    Guid EventoId,

    string UbicacionTecnica,

    string UbicacionTecnicaImg,

    string ParteObjectoAfectada,

    string ParteObjectoAfectadaImg,

    string ModoFalla,

    string ModoFallaImg,

    string DescripcionCorta,

    DateTime FechaIncioAveria,

    bool EquipoContinuaOperando,

    bool SolucionadoPorBEC
);