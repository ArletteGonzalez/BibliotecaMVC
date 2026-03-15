using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

public class Libro
{
    [Required]
    public string Codigo { get; set; }

    [Required]
    [StringLength(100)]
    public string Titulo { get; set; }

    [Required]
    public string Autor { get; set; }

    [DataType(DataType.Date)]
    public DateTime FechaPublicacion { get; set; }
}