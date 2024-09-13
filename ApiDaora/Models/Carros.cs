using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiDaora.Models
{

    [Table("CarrosBR")]
    public class Carros
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }
        [Required]
        public int Ano { get; set; }
        [Required]
        public string Motorizacao { get; set; }
        [Required]
        public string Carroceria { get; set;}
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Descricao { get; set;}
        [Required]
        public string foto { get; set;}
        [Required]
        public string Status { get; set;}

    }
}
