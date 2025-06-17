using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_GYM.Models
{
    public class Gym
    {
        [StringLength(50)]
        public string nombre { get; set; } = String.Empty;

        [StringLength(50)]
        public string direccion { get; set; } = String.Empty;

        public List<Cliente> clientes { get; set; }

        public Cliente cliente { get; set; }

        public List<Plan> planes { get; set; }  

        public Plan plan { get; set; }

    }
}
