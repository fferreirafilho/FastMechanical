﻿using FastMechanical.Models.Enums;
using System.ComponentModel.DataAnnotations;


namespace FastMechanical.Models {
    public class Servicos {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo não pode ser vazio")]
        [Display(Name = "Nome do serviço")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo não pode ser vazio")]
        [Display(Name = "Valor do serviço")]
        public double Valor { get; set; }
        public Status Status { get; set; }
    }
}
