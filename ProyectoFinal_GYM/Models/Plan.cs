using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_GYM.Models
{
    public class Plan
    {
        [Key]
        public int id { get; set; }
    
        public string nombre { get; set; } = String.Empty;
    
        public List<Actividad> actividades { get; set; }
    
    }
}
