using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyHotelSystem.Models
{
    public class Room
    {
        private int numQuarto;
        private string descQuarto;
        private string statusQuarto;
        private decimal valorDiaria;
        private int codReserva;


        [Key]
        [Display(Name = "Número do quarto:")]
        public int NumQuarto { get => numQuarto; set => numQuarto = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [MaxLength(20, ErrorMessage = "O máximo são 20 caracteres!")]
        [Display(Name = "Tipo do quarto:")]
        public string DescQuarto { get => descQuarto; set => descQuarto = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [MaxLength(15, ErrorMessage = "O máximo são 15 caracteres!")]
        [Display(Name = "Status:")]
        public string StatusQuarto { get => statusQuarto; set => statusQuarto = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [Range(100.00,999.99)]
        [Display(Name = "Valor da diária:")]
        public decimal ValorDiaria { get => valorDiaria; set => valorDiaria = value; }


        public int CodReserva { get => codReserva; set => codReserva = value; }
    }
}
