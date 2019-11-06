using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyHotelSystem.Models
{
    public class Payment
    {
        private int codPagamento;
        private int numQuarto;
        private string tipoQuarto;
        private string nomeHos;
        private int qtdCriancas;
        private int qtdAdu;
        private decimal valor;
        private decimal taxa;
        private string formaPag;
        private DateTime dataCheckin;
        private DateTime dataCheckout;
        private DateTime hrCheckin;
        private DateTime hrCheckout;
        private Int64 cpfFunc;
        private Int64 cpfHos;


        [Key]
        [Range(000000, 999999)]
        [Display(Name = "Código do Pagamento:")]
        public int CodPagamento { get => codPagamento; set => codPagamento = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [MaxLength(4, ErrorMessage = "O máximo são 4 caracteres!")]
        [Display(Name = "Número do Quarto:")]
        public int NumQuarto { get => numQuarto; set => numQuarto = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [MaxLength(20, ErrorMessage = "O máximo são 20 caracteres!")]
        [Display(Name = "Tipo do quarto:")]
        public string TipoQuarto { get => tipoQuarto; set => tipoQuarto = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O máximo são 50 caracteres!")]
        [Display(Name = "Nome do Hóspede:")]
        public string NomeHos { get => nomeHos; set => nomeHos = value; }

        [Range(0,10)]
        [Display(Name = "Quantidade de crianças:")]
        public int QtdCriancas { get => qtdCriancas; set => qtdCriancas = value; }

        [Range(0, 10)]
        [Display(Name = "Quantidade de adultos:")]
        public int QtdAdu { get => qtdAdu; set => qtdAdu = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [Range(00000.00, 99999.99)]
        [Display(Name = "Valor a ser pago:")]
        public decimal Valor { get => valor; set => valor = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [DataType(DataType.Date)]
        [Display(Name = "Data da Entrada:")]
        public DateTime DataCheckin { get => dataCheckin; set => dataCheckin = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [DataType(DataType.Date)]
        [Display(Name = "Data da Saída:")]
        public DateTime DataCheckout { get => dataCheckout; set => dataCheckout = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [DataType(DataType.Time)]
        [Display(Name = "Hora da Entrada:")]
        public DateTime HrCheckin { get => hrCheckin; set => hrCheckin = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [DataType(DataType.Time)]
        [Display(Name = "Hora da Saída:")]
        public DateTime HrCheckout { get => hrCheckout; set => hrCheckout = value; }


        public long CpfFunc { get => cpfFunc; set => cpfFunc = value; }


        public long CpfHos { get => cpfHos; set => cpfHos = value; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [Range(000.00, 999.99)]
        [Display(Name = "Taxas Adicionais:")]
        public decimal Taxa { get => taxa; set => taxa = value; }
        
        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [MaxLength(20, ErrorMessage = "O máximo são 20 caracteres!")]
        [Display(Name = "Forma de Pagamento:")]
        public string FormaPag { get => formaPag; set => formaPag = value; }

    }
}
