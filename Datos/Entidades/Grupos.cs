//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grupos
    {
        public string ClaveEscuela { get; set; }
        public string ClaveMateria { get; set; }
        public string ClaveProfesor { get; set; }
        public string Nombre { get; set; }
        public byte HoraInicio { get; set; }
        public byte HoraFinal { get; set; }
    
        public virtual Escuela Escuela { get; set; }
        public virtual Materias Materias { get; set; }
        public virtual Profesor Profesor { get; set; }
    }
}
