using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_web_backend_ads.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatorio Informar o Nome")]
        public string Nome  { get; set; }

        [Required(ErrorMessage = "Obrigatorio Informar a Placa")]
        public string Placa { get; set; }
    }
}
