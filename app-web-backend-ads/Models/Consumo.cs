using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_web_backend_ads.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Descricao" )]
        [Required(ErrorMessage = "obrigatorio informar a descricao")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "obrigatorio informar a data")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "obrigatorio informar kilometragem")]
        public int Km { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "obrigatorio informar o valor")]
        public decimal Valor { get; set; }

       
        [Display(Name = "Tipo de Combustivel")]
        [Required(ErrorMessage = "obrigatorio informar o tipo de combustivel")]
        public TipoCombustivel Tipo { get; set; }


        [Display(Name = "Veiculo")]
        [Required(ErrorMessage = "obrigatorio informar o veiculo")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]

        public Veiculo Veiculo { get; set; }
    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol
    }
}