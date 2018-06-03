using ControleChamados.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleChamados.Models.Entidades
{
    public class Chamado
    {
        public int Id { get; set; }

        [Required]
        public String NomeDoSistema { get; set; }

        [Required]
        public String ModuloDoSistema { get; set; }

        [Required]
        public Criticidade Criticidade { get; set; }

        [Required]
        public String DescricaoDoSistema { get; set; }

        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}