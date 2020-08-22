using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_CRUD_DiplomadoUASDCodeFirst.Model.Models;

namespace MVC_CRUD_DiplomadoUASDCodeFirst.Model.DAL
{
   public class CargarDatosDB : System.Data.Entity.DropCreateDatabaseIfModelChanges<EmpleadoContext>
    {
        protected override void Seed(EmpleadoContext context)
        {
            var Departamentos = new List<Departamento>
            { 
                new Departamento{DepartamentoID=1,Descripcion="Recursos Humano",},
                new Departamento{DepartamentoID=2,Descripcion="Programacion",},
                new Departamento{DepartamentoID=3,Descripcion="Mecadeo",},
                new Departamento{DepartamentoID=4,Descripcion="Ventas",},
                new Departamento{DepartamentoID=5,Descripcion="Compras",}

            };
            Departamentos.ForEach(s => context.Departamentos.Add(s));
            context.SaveChanges();

            var Empleado = new List<Empleado> 
            { 
             new Empleado{Nombre="Julios",      Apellidos="Mrillo santos",          Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="Antonio",     Apellidos="de la cuz guerrero",     Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="Carla",       Apellidos="Gimenez moya",           Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="Sofia",       Apellidos="Salazar cueva",          Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="Isaura",      Apellidos="Roa Rojas",              Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="JUANA",       Apellidos="ROSARIO T",              Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="GLENYS",      Apellidos="MORILLO",                Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="ANA C",       Apellidos="DIAZ T",                 Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="ROSA",        Apellidos="ENUÑEZ P",               Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="JOHANN",      Apellidos="GERARDO P",              Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="ADRIANO",     Apellidos="CRUZ",                   Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="JOSE",        Apellidos="O DIAZ T",               Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="LUIS M",      Apellidos="GARCIA L",               Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="ANDRES M",    Apellidos="GONZALEZ A",             Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="DOLORES",     Apellidos="ARIAS M",                Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="YODALIS",     Apellidos="MANZUETA A",             Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="LESLY D",     Apellidos="VALDEZ E",               Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="NELSON F",    Apellidos="RODRIGUEZ V",            Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="LUISA M",     Apellidos="FRIAS T",                Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="LUIS R",      Apellidos="FIRPO F",                Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="BETTY L",     Apellidos="PUENTE V",               Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="JUAN L",      Apellidos="MARMOL D",               Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="SANTA M",     Apellidos="CASTILLO M",             Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="SUAHIL Y",    Apellidos="DOTEL",                  Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="FLORENTINO",  Apellidos="BAEZ H",                 Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="ANTONIO",     Apellidos="RAMIREZ C",              Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="SEVERIANO",   Apellidos="ALCANTARA G",            Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="ROSA Y",      Apellidos="MEJIA F",                Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="OSCAR L",     Apellidos="RIVERA S",               Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="YELENNY",     Apellidos="ARIAS R",                Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="LANDY J",     Apellidos="DOÑE G",                 Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="EDISON",      Apellidos="SANTOS D",               Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="AUGUSTO C",   Apellidos="CABRERA M ",             Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="YOJAIRA",     Apellidos="VALDEZ M",               Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="NELSON M",    Apellidos="GUILIANI G",             Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="HANSER O",    Apellidos="ESCARRAMAN Q ",          Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="JULIO A",     Apellidos="MARTI P",                Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="CHARINA A",   Apellidos=" MERCEDES ",             Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="LUIS A",      Apellidos="MADERA H",               Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="YURIESMY D",  Apellidos="ESPINOSA C ",            Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="DENNY M",     Apellidos="ESPINAL G ",             Fecha_Ingreso=DateTime.Parse("2011-08-01")},
             new Empleado{Nombre="MIRTA ROSALIA",Apellidos="RAMIREZ ",              Fecha_Ingreso=DateTime.Parse("2011-08-01")}
};
Empleado.ForEach(s => context.Empleados.Add(s));
context.SaveChanges();

var Registro = new List<Registro>
{
          new Registro{EmpleadoID =1,DepartemantoID=1,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =2,DepartemantoID=2,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =3,DepartemantoID=3,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =4,DepartemantoID=4,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =5,DepartemantoID=5,Sueldo =Convert.ToDecimal(10000.00)},

          new Registro{EmpleadoID =6,DepartemantoID=1,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =7,DepartemantoID=2,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =8,DepartemantoID=3,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =9,DepartemantoID=4,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =10,DepartemantoID=5,Sueldo =Convert.ToDecimal(10000.00)},

          new Registro{EmpleadoID =11,DepartemantoID=1,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =12,DepartemantoID=2,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =13,DepartemantoID=3,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =14,DepartemantoID=4,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =15,DepartemantoID=5,Sueldo =Convert.ToDecimal(10000.00)},

          new Registro{EmpleadoID =16,DepartemantoID=1,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =17,DepartemantoID=2,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =18,DepartemantoID=3,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =19,DepartemantoID=4,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =20,DepartemantoID=5,Sueldo =Convert.ToDecimal(10000.00)},

           new Registro{EmpleadoID =21,DepartemantoID=1,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =22,DepartemantoID=2,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =23,DepartemantoID=3,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =24,DepartemantoID=4,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =25,DepartemantoID=5,Sueldo =Convert.ToDecimal(10000.00)},

          new Registro{EmpleadoID =26,DepartemantoID=1,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =27,DepartemantoID=2,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =28,DepartemantoID=3,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =29,DepartemantoID=4,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =30,DepartemantoID=5,Sueldo =Convert.ToDecimal(10000.00)},

          new Registro{EmpleadoID =31,DepartemantoID=1,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =32,DepartemantoID=2,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =33,DepartemantoID=3,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =34,DepartemantoID=4,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =35,DepartemantoID=5,Sueldo =Convert.ToDecimal(10000.00)},

          new Registro{EmpleadoID =36,DepartemantoID=1,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =37,DepartemantoID=2,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =38,DepartemantoID=3,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =39,DepartemantoID=4,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =40,DepartemantoID=5,Sueldo =Convert.ToDecimal(10000.00)},

          new Registro{EmpleadoID =41,DepartemantoID=4,Sueldo =Convert.ToDecimal(10000.00)},
          new Registro{EmpleadoID =42,DepartemantoID=5,Sueldo =Convert.ToDecimal(10000.00)}


};
Registro.ForEach(s => context.Registros.Add(s));
context.SaveChanges();
}
}
}
