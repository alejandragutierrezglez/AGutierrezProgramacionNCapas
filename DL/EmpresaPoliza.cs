//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmpresaPoliza
    {
        public int IdAseguradoraPoliza { get; set; }
        public Nullable<int> IdAseguradora { get; set; }
        public Nullable<int> IdPoliza { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> IdUsuario { get; set; }
    
        public virtual Aseguradora Aseguradora { get; set; }
        public virtual Poliza Poliza { get; set; }
        public virtual usuario usuario { get; set; }
    }
}