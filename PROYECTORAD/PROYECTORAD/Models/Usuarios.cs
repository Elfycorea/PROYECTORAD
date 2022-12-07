using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTORAD.Models
{
    public class Usuarios
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(25)]
        public string email { get; set; }
        [MaxLength(50)]
        public string nombres { get; set; }
        [MaxLength(12)]
        public string contraseña { get; set; }
        [MaxLength(30)]
        public string telefono { get; set; }
        public bool activo { get; set; }
        public string imagen { get; set; }


    }
}
