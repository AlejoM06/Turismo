using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turismo.Shared.Entities
{
    public class City
    {
        public int Id { get; set; } // primary key, identity(1,1)


        [Display (Name = "Ciudad")] // Etiquetas nombre campo
        [MaxLength  (100, ErrorMessage = "El campo {0} debe contener unicamente 100 caracteres")] //Es la longitud de caracteres del campo
        [Required (ErrorMessage = "El campo {0} es obligatorio")]

        public string? Name { get; set; }     //Indica que hace un salto de nulos)
        public int TelefonoDescripcion {  get; set; } // {1}   
        public string? Address { get; set; }// ? Indica que hace un salto de nulo


    }
}
