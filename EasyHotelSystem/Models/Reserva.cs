using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyHotelSystem.Models
{
    public class Reserva
    {
        private int codReserva;
        private string nomeHos;
        private DateTime dataCheckin;
        private DateTime dataCheckout;
        private int qtdAcomp;
        private Int64 cpfFunc;
        private Int64 cpfHos;
        private int numQuarto;

     


        [Key]
        [Range(000000,999999)]
        [Display(Name ="Código da Reserva:")]
        public int CodReserva { get => codReserva; set => codReserva = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [StringLength(50, ErrorMessage = "O máximo são 50 caracteres!")]
        [Display(Name = "Nome do Hóspede:")]
        public string NomeHos { get => nomeHos; set => nomeHos = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [DataType(DataType.Date)]
        [Display(Name = "Data da Entrada:")]
        public DateTime DataCheckin { get => dataCheckin; set => dataCheckin = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [DataType(DataType.Date)]
        [Display(Name = "Data da Saída:")]
        public DateTime DataCheckout { get => dataCheckout; set => dataCheckout = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [Range(0, 10)]
        [Display(Name = "Quantidade de acompanhantes:")]
        public int QtdAcomp { get => qtdAcomp; set => qtdAcomp = value; }


        public long CpfFunc { get => cpfFunc; set => cpfFunc = value; }


        public long CpfHos { get => cpfHos; set => cpfHos = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [Display(Name = "Número do quarto:")]
        public int NumQuarto { get => numQuarto; set => numQuarto = value; }


        
    }
}
