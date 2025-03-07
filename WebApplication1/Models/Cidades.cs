using System.ComponentModel.DataAnnotations;

namespace Cidades.Model
{
    public class Cidade
    {
        [Key]
        [StringLength(2,
                       MinimumLength = 2,
                       ErrorMessage ="É obrigatório informar apenas dois caracteres")]
        public string Sigla { get; set; }

        [Required(ErrorMessage ="Nome é obrigatório")]
        [StringLength(100, 
                    MinimumLength = 2, 
                    ErrorMessage ="Informe de 2 a 100 caracteres")]
        public string Nome { get; set; }
        public int Codigo { get; set; }




    }
}