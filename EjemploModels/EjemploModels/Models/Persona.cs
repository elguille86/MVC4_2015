using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace EjemploModels.Models
{
    public class Persona
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Direccion { get; set; }
        [StringLength(8)]
        public string Telefono { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }

    public class PersonasDBContext : DbContext {
        //permite hacer el CRUD
        public DbSet<Persona> Personas { get; set; }
    }

}