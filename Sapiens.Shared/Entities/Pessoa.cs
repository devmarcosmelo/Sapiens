using Sapiens.Shared.Enums;
using Sapiens.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapiens.Shared.Entities;

public class Pessoa
{
    [StringLength(255)]
    public string? Nome { get; set; }

    [StringLength(14)]
    public string? Cpf { get; set; }

    [StringLength(100)]
    public string? Email { get; set; }

    [StringLength(20)]
    public string? Telefone { get; set; }
    public TipoSexo? Sexo { get; set; }
    public string? Foto { get; set; } //pode ser byte tbm[]
    public Endereco? Endereco { get; set; }
    public string? EstadoCivil { get; set; }

    [StringLength(5)]
    public TipoSanguineo? TipoSanguinio { get; set; }

    public CorOuRaca? CorOuRaca { get; set; }
    public bool? PCD { get; set; }

    [StringLength(100)]
    public string? Linkedin { get; set; }

    [StringLength(100)]
    public string? Instagram { get; set; }

    [StringLength(100)]
    public string? Twitter { get; set; }









}
