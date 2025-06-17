using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_GYM.Models
{
    public class Actividad
    {

        [Key]
        public int id { get; set; }

        [StringLength(50)]
        public string nombre { get; set; } = String.Empty;
    

        public int duracion { get; set; }

        public double precio { get; set; }

        public int capacidad { get; set; }

    
    }
}
