using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleChamados.Models.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        public String Nome { get; set; }

        [Required]
        public String Senha { get; set; }

    }
}