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
        public int CodReserva { get => codReserva; set => codReserva = value; }


        public string NomeHos { get => nomeHos; set => nomeHos = value; }


        public DateTime DataCheckin { get => dataCheckin; set => dataCheckin = value; }


        public DateTime DataCheckout { get => dataCheckout; set => dataCheckout = value; }


        public int QtdAcomp { get => qtdAcomp; set => qtdAcomp = value; }


        public long CpfFunc { get => cpfFunc; set => cpfFunc = value; }


        public long CpfHos { get => cpfHos; set => cpfHos = value; }


        public int NumQuarto { get => numQuarto; set => numQuarto = value; }
    }
}
