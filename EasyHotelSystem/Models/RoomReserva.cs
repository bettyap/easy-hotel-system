using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyHotelSystem.Models
{
    public class RoomReserva
    {
        private int id;

        private int quarID;
        private int resID;

        private Room quarto;
        private Reserva reservas;

        public int QuarID { get => quarID; set => quarID = value; }
        public int ResID { get => resID; set => resID = value; }


        public Room Quarto { get => quarto; set => quarto = value; }
        public Reserva Reservas { get => reservas; set => reservas = value; }

        [Key]
        public int Id { get => id; set => id = value; }
    }
}
