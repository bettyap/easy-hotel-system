using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EasyHotelSystem.Models
{
    public class Guest
    {
        private string nome;
        private Int64 cpfHos;
        private int rg;
        private DateTime nascim;
        private string genero;
        private string profissao;
        private string logradouro;
        private string bairro;
        private string complemento;
        private string cidade;
        private int cep;
        private int telefone;
        private Int64 celular;
        private string email;
        private Int64 cpfAcomp;

        private ICollection<GuestPayment> listaPagamentos;
        private ICollection<GuestEscorts> listaAcompanhantes;

        [Key]
        [Range(00000000000, 99999999999)]
        [Display(Name = "CPF:")]
        public long CpfHos { get => cpfHos; set => cpfHos = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [StringLength(50, ErrorMessage = "O máximo são 50 caracteres!")]
        [Display(Name = "Nome do Hóspede:")]
        public string Nome { get => nome; set => nome = value; }

        [Range(000000000, 999999999)]
        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [Display(Name = "RG:")]
        public int Rg { get => rg; set => rg = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de nascimento:")]
        public DateTime Nascim { get => nascim; set => nascim = value; }

        [MaxLength(7, ErrorMessage = "O máximo são 7 caracteres!")]
        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [Display(Name = "Gênero:")]
        public string Genero { get => genero; set => genero = value; }

        [StringLength(20, ErrorMessage = "O máximo são 20 caracteres")]
        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [Display(Name = "Profissão:")]
        public string Profissao { get => profissao; set => profissao = value; }

        [StringLength(40, ErrorMessage = "O máximo são 40 caracteres")]
        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [Display(Name = "Logradouro:")]
        public string Logradouro { get => logradouro; set => logradouro = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [StringLength(30, ErrorMessage = "O máximo são 30 caracteres!")]
        [Display(Name = "Bairro:")]
        public string Bairro { get => bairro; set => bairro = value; }

        [StringLength(10, ErrorMessage = "O máximo são 10 caracteres!")]
        [Display(Name = "Complemento:")]
        public string Complemento { get => complemento; set => complemento = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [StringLength(30, ErrorMessage = "O máximo são 30 caracteres!")]
        [Display(Name = "Cidade:")]
        public string Cidade { get => cidade; set => cidade = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [Range(00000000, 99999999)]
        [Display(Name = "CEP:")]
        public int Cep { get => cep; set => cep = value; }

        [Range(00000000, 99999999)]
        [Display(Name = "Telefone:")]
        public int Telefone { get => telefone; set => telefone = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [Range(00000000000, 99999999999)]
        [Display(Name = "Celular:")]
        public long Celular { get => celular; set => celular = value; }

        [EmailAddress]
        [StringLength(60, ErrorMessage = "O máximo são 60 caracteres!")]
        [Display(Name = "E-Mail:")]
        public string Email { get => email; set => email = value; }


        public long CpfAcomp { get => cpfAcomp; set => cpfAcomp = value; }


        public ICollection<GuestPayment> ListaPagamentos { get => listaPagamentos; set => listaPagamentos = value; }


        public ICollection<GuestEscorts> ListaAcompanhantes { get => listaAcompanhantes; set => listaAcompanhantes = value; }
    }
}
