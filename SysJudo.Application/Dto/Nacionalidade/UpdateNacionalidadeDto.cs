﻿namespace SysJudo.Application.Dto.Nacionalidade;

public class UpdateNacionalidadeDto
{
    public int Id { get; set; }
    public string Sigla { get; set; } = null!;
    public string Descricao { get; set; } = null!;
    public int ClienteId { get; set; }
}