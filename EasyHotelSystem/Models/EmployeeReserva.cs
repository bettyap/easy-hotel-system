using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyHotelSystem.Models
{
    public class EmployeeReserva
    {
        private int id;

        private int funcID;
        private int resID;

        private Employee recepcionista;
        private Reserva reservas;

        public int FuncID { get => funcID; set => funcID = value; }
        public int ResID { get => resID; set => resID = value; }


        public Employee Recepcionista { get => recepcionista; set => recepcionista = value; }
        public Reserva Reservas { get => reservas; set => reservas = value; }

        [Key]
        public int Id { get => id; set => id = value; }
    }
}
