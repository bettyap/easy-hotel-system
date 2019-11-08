using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyHotelSystem.Models
{
    public class GuestEscorts
    {
        private int id;

        private int hosID;
        private int pagID;

        private Guest hospede;
        private Escorts acompanhantes;

        public int HosID { get => hosID; set => hosID = value; }
        public int PagID { get => pagID; set => pagID = value; }


        public Guest Hospede { get => hospede; set => hospede = value; }
        public Escorts Acompanhantes { get => acompanhantes; set => acompanhantes = value; }

        [Key]
        public int Id { get => id; set => id = value; }
    }
}
