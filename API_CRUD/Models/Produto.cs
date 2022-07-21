using System.ComponentModel.DataAnnotations;

namespace API_CRUD.Models
{
    public class Produto
    {
        public int id { get; set; }
        [Required(ErrorMessage ="Insira o Nome do Produto.")]
        [StringLength(50,ErrorMessage ="Numero de Caracteres Inválido")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Insira a Marca do Produto.")]
        [StringLength(50, ErrorMessage = "Numero de Caracteres Inválido")]
        public string marca { get; set; }
        [RegularExpression(@"[0-9]{0,20}[€,$,£]$", ErrorMessage ="Preço Inválido.")]
        [Required(ErrorMessage = "Insira o Preço do Produto.")]
        public string preco { get; set; }
    }
}
