using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EasyHotelSystem.Models
{
    public class Employee
    {
        private Int64 cpfFunc;
        private string nome;
        private string logradouro;
        private string bairro;
        private string complemento;
        private string cidade;
        private int cep;
        private Int64 telefone;
        private DateTime dtAdmissao;
        private DateTime dtNasc;
        private string email;
        private string cargo;

        private ICollection<Payment> listaChecksRealizados;
        private ICollection<Reserva> listaReservas;

        [Key]
        [Range(00000000000, 99999999999)]
        [Display(Name = "CPF:")]
        public Int64 CpfFunc { get => cpfFunc; set => cpfFunc = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O máximo são 50 caracteres!")]
        [Display(Name = "Nome do Funcionário:")]
        public string Nome { get => nome; set => nome = value; }

        [MaxLength(40, ErrorMessage = "O máximo são 40 caracteres")]
        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [Display(Name = "Logradouro:")]
        public string Logradouro { get => logradouro; set => logradouro = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [MaxLength(30, ErrorMessage = "O máximo são 30 caracteres!")]
        [Display(Name = "Bairro:")]
        public string Bairro { get => bairro; set => bairro = value; }

        [MaxLength(10, ErrorMessage = "O máximo são 10 caracteres!")]
        [Display(Name = "Complemento:")]
        public string Complemento { get => complemento; set => complemento = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [MaxLength(30, ErrorMessage = "O máximo são 30 caracteres!")]
        [Display(Name = "Cidade:")]
        public string Cidade { get => cidade; set => cidade = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [Range(00000000, 99999999)]
        [Display(Name = "CEP:")]
        public int Cep { get => cep; set => cep = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [Range(00000000000, 99999999999)]
        [Display(Name = "Telefone:")]
        public Int64 Telefone { get => telefone; set => telefone = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de nascimento:")]
        public DateTime DtNasc { get => dtNasc; set => dtNasc = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de admissão:")]
        public DateTime DtAdmissao { get => dtAdmissao; set => dtAdmissao = value; }

        [EmailAddress]
        [MaxLength(60, ErrorMessage = "O máximo são 60 caracteres!")]
        [Display(Name = "E-Mail:")]
        public string Email { get => email; set => email = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [MaxLength(15, ErrorMessage = "O máximo são 15 caracteres!")]
        [Display(Name = "Cargo:")]
        public string Cargo { get => cargo; set => cargo = value; }


        public ICollection<Payment> ListaChecksRealizados { get => listaChecksRealizados; set => listaChecksRealizados = value; }


        public ICollection<Reserva> ListaReservas { get => listaReservas; set => listaReservas = value; }
    }
}
