using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lojadejogos.Models
{
    public class Funcionario
    {
        [Key]
        [Display(Name = "Código")]
        public int FuncionarioID { get; set; }

        [Required(ErrorMessage = "Digite o CPF")]
        [Display(Name = "CPF")]
        [RegularExpression("^[0-9]{11}$", ErrorMessage = "Esse não é um CPF válido")]
        public string FuncionarioCPF { get; set; }

        [Required(ErrorMessage = "Digite o RG")]
        [Display(Name = "RG")]
        [RegularExpression("(^[0-9]{2}[.][0-9]{3}[.][0-9]{3}[-][0-9]{2})$",
                            ErrorMessage = "Por favor, preencha o campo no formato: 00.000.000-00")]
        public string FuncionarioRG { get; set; }

        [Required(ErrorMessage = "Digite o nome")]
        [Display(Name = "Nome")]
        [StringLength(300, MinimumLength = 3, ErrorMessage = "O campo só permite de 3 a 100 caracteres")]
        public string FuncionarioNome { get; set; }

        [Required(ErrorMessage = "Digite o cargo")]
        [Display(Name = "Cargo")]
        public string FuncionarioCargo { get; set; }

        [Required(ErrorMessage = "Informe a data de nascimento")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? FuncionarioDataNascimento { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string FuncionarioEmail { get; set; }

        [Required(ErrorMessage = "Informe o celular")]
        [Display(Name = "Celular")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Celular em formato inválido")]
        [RegularExpression("^[(]{1}[1-9]{2}[)]{1}[0-9]{4,5}[-]{1}[0-9]{3,4}$",
                            ErrorMessage = "Por favor, preencha o campo no formato: (00)1234-5678 ou (00)12345-6789")]
        public string FuncionarioCelular { get; set; }

        [Required(ErrorMessage = "Digite o endereço")]
        [Display(Name = "Endereço")]
        [DataType(DataType.PostalCode)]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Digite entre 3 e 100 caracteres.")]
        public string FuncionarioEndereco { get; set; }
    }
}