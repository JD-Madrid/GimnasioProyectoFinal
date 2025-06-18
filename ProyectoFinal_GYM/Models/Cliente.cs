using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace ProyectoFinal_GYM.Models
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }

        [StringLength(50)]
        public string nombre { get; set; } = String.Empty;
        [StringLength(50)]
        public string apellido { get; set; } = String.Empty;
        [StringLength(50)]
        public string documento { get; set; } = String.Empty;

        public string genero { get; set; } = String.Empty;

        public Plan? plan {  get; set; }

        public int? idPlan { get; set; }
    }
}
