using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyHotelSystem.Models
{
    public class EmployeePayment
    {
        private int id;

        private int funcID;
        private int pagID;

        private Employee recepcionista;
        private Payment pagamento;

        public int FuncID { get => funcID; set => funcID = value; }
        public int PagID { get => pagID; set => pagID = value; }


        public Employee Recepcionista { get => recepcionista; set => recepcionista = value; }
        public Payment Pagamento { get => pagamento; set => pagamento = value; }

        [Key]
        public int Id { get => id; set => id = value; }
    }
}
