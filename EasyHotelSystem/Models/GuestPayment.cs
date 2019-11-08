using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyHotelSystem.Models
{
    public class GuestPayment
    {
        private int id;

        private int hosID;
        private int pagID;

        private Guest hospede;
        private Payment pagamento;

        public int HosID { get => hosID; set => hosID = value; }
        public int PagID { get => pagID; set => pagID = value; }


        public Guest Hospede { get => hospede; set => hospede = value; }
        public Payment Pagamento { get => pagamento; set => pagamento = value; }

        [Key]
        public int Id { get => id; set => id = value; }
    }
}
