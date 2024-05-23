using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapiens.Shared.Models
{
    public record Endereco
    {
        [StringLength(9)]
        public string? Cep { get; set; } //pega por aqui os dados.

        [StringLength(100)]
        public string? Logradouro { get; set; }

        [StringLength(50)]
        public string? Numero { get; set; } //usuario preenche

        [StringLength(100)]
        public string? Complemento { get; set; } //usuario preenche

        [StringLength(100)]
        public string? Bairro { get; set; }

        [StringLength(100)]
        public string? Municipio { get; set; }

        [StringLength(2)]
        public string? Uf { get; set; }

    }

}
