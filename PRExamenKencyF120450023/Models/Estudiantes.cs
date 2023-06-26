using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace PRExamenKencyF120450023.Models
{
    public class Estudiantes
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(100)]
        public string nombres { get; set; }

        [MaxLength(100)]
        public string Apellidos { get; set; }

        [NotNull]
        public DateTime EDAD { get; set; }


        [NotNull, Unique]
        public string telfono { get; set; }
    }
}
