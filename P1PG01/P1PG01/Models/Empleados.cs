using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace P1PG01.Models
{
    public class Empleados
    {

        [PrimaryKey, AutoIncrement]
        public int codigo { get; set; }

        [MaxLength(100)]
        public string nombres { get; set;}
        
        [MaxLength(100)]
        public string apellidos { get; set; }
        
        
        public Int32 edad { get; set; }
        public DateTime fecha_nac { get; set; }


        [MaxLength(100)]
        public string ocupacion { get; set; }


    }
}
