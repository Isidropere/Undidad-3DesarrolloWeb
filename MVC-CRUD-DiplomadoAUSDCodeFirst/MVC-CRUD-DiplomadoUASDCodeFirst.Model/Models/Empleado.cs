﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CRUD_DiplomadoUASDCodeFirst.Model.Models
{
   public class Empleado
    {
        public int EmpleadoID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public Nullable<System.DateTime> Fecha_Ingreso  { get; set; }
        public virtual  ICollection<Registro> Registros { get; set; }
    }
}
