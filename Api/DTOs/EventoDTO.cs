namespace Api.DTOs;

public sealed record EventoDTO
(
    string Titulo,

    string Categoria,

    string Prioridad,

    string PuestoSeguridad,

    string CreadoPor,

    DateTime FechaInicio,

    string CerradoPor,

    DateTime FechaFin,

    string Coordenadas,

    string MapaUrl,

    string TipoEvento,

    string TipoEventoImagen,

    bool Impacto
);

