using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lojadejogos.Models
{
    public class Jogo
    {
        [Key]
        [Required(ErrorMessage = "Digite o Código")]
        [Display(Name = "Código")]
        public int JogoID { get; set; }

        [Required(ErrorMessage = "Digite o nome do jogo")]
        [Display(Name = "Nome")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O campo só permite de 3 a 100 caracteres")]
        public string JogoNome { get; set; }

        [Required(ErrorMessage = "Informe a versão do jogo")]
        [Display(Name = "Versão")]
        public string JogoVersao { get; set; }

        [Required(ErrorMessage = "Informe o desenvolvedor do jogo")]
        [Display(Name = "Desenvolvedor")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O campo só permite de 1 a 100 caracteres")]
        public string JogoDev { get; set; }

        [Required(ErrorMessage = "Informe o gênero do jogo")]
        [Display(Name = "Gênero")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "O campo só permite de 2 a 200 caracteres")]
        public string JogoGenero { get; set; }

        [Required(ErrorMessage = "Digite a faixa etária do jogo")]
        [Display(Name = "Faixa etária")]
        [Range(0, 18,
        ErrorMessage = "O valor para {0} deve ser entre {1} e {2}.")]
        public string JogoFaixa { get; set; }

        [Required(ErrorMessage = "Informe a plataforma")]
        [Display(Name = "Plataforma")]
        public string JogoPlataforma { get; set; }

        [Required(ErrorMessage = "Informe a data de lançamento")]
        [Display(Name = "Data de lançamento")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? JogoData { get; set; }

        [Required(ErrorMessage = "Digite a sinopse")]
        [Display(Name = "Sinopse")]
        [StringLength(600, MinimumLength = 3, ErrorMessage = "O campo só permite de 3 a 600 caracteres")]
        public string JogoSinopse { get; set; }
    }
}