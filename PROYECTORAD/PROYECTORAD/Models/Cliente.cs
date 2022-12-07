using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTORAD.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }

        public DateTime fechanacimiento { get; set; }
        public string pais { get; set; }
        public string departamento { get; set; }
        public string municipio { get; set; }
        public string foto { get; set; }
        public string estadocivil { get; set; }

        public string telefono { get; set; }

        public string password { get; set; }

        public bool active { get; set; }

    }
}
