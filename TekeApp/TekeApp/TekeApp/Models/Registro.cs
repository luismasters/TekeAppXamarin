using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TekeApp.Models
{
  public  class Registro
    {
        [PrimaryKey,AutoIncrement] public int IdRegistro { get; set; }
        public DateTime Fecha { get; set; }
        [MaxLength(50)]
        public string Tamaño { get; set; }
        public int Entrada { get; set; }
        public int Salida { get; set; }

    }
}
