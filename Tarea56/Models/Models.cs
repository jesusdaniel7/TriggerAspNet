using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea56.Models
{
    public class Vehiculo
    {
        public int VehiculoID { get; set; }
        public string Chasis { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Placa { get; set; }
        [Display (Name = "Año")]
        [Required(ErrorMessage = "Debe introducir el año")]
        public int Year { get; set; }
        [Display (Name = "Fecha de retención")]
        [Required(ErrorMessage = "Debe introducir una fecha de retención")]
        public DateTime FechaRetencion { get; set; }
        [Required(ErrorMessage = "Debe introducir un lugar")]
        public string Lugar { get; set; }
        [Display (Name = "Latitud")]
        public string Lat { get; set; }
        [Display(Name = "Longitud")]
        public string Long { get; set; }
        [Display(Name = "Nombre del conductor")]
        public string NombreConductor { get; set; }
        [Required (ErrorMessage = "Debe introducir una cedula")]
        public string Cedula { get; set; }
        public string Comentarios { get; set; }

    }
    public class Historico
    {
        public int HistoricoID { get; set; }
        [Display (Name = "Chasis")]
        public string H_Chasis { get; set; }
        [Display(Name = "Marca")]
        public string H_Marca { get; set; }
        [Display(Name = "Modelo")]
        public string H_Modelo { get; set; }
        [Display(Name = "Color")]
        public string H_Color { get; set; }
        [Display(Name = "Placa")]
        public string H_Placa { get; set; }
        [Display(Name = "Año")]
        public int H_Year { get; set; }
        [Display(Name = "Fecha de retención")]
        public DateTime H_FechaRetencion { get; set; }
        [Display(Name = "Fecha de salida")]
        public DateTime H_FechaSalida { get; set; }
        [Display(Name = "Lugar")]
        public string H_Lugar { get; set; }
        [Display(Name = "Latitud")]
        public string H_Lat { get; set; }
        [Display(Name = "Laongitud")]
        public string H_Long { get; set; }
        [Display(Name = "Nombre del conductor")]
        public string H_NombreConductor { get; set; }
        [Display(Name = "Cedula")]
        public string H_Cedula { get; set; }
        [Display(Name = "Comentarios")]
        public string H_Comentarios { get; set; }
    }
}
