using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        //data anotations
        [Display(Name = "País")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

        public ICollection<State> States { get; set; } 

        [Display(Name = "Departamento/Estado")]
        public int StatesNumber => States == null ? 0 : States.Count; // operador ternario con validacion en un if de una sola linea
    }
}
