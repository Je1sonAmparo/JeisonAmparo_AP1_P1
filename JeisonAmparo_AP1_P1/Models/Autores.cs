using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace JeisonAmparo_AP1_P1.Models;

public class Autores
{
    [Key]
    public int AutoresId { get; set; }

    [Required(ErrorMessage = "Debe ingresar un nombre")]
    public String? Nombres { get; set; }

    [Required(ErrorMessage = "Debe ingresar una nacionalidad")]
    public String? Nacionalidad { get; set; }

    [Required(ErrorMessage = "Debe ingresar una fecha de nacimiento")]    
    public DateTime? FechaNacimiento { get; set; }

    [Required(ErrorMessage = "Debe ingresar un sueldo")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Debe de ingresar un sueldo")]
    public Decimal? Sueldo { get; set; }
}
