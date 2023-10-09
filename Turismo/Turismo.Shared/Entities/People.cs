using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turismo.Shared.Entities
{
    public class People
    {
        public int Id { get; set; } // primary key, identity(1,1)


        [Display(Name = "Ciudad")] // Etiquetas nombre campo
        [MaxLength(100, ErrorMessage = "El campo {0} debe contener unicamente 100 caracteres")] //Es la longitud de caracteres del campo
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        public string? NomPer { get; set; }
    }

    
}
