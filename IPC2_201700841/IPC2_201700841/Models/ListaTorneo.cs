//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPC2_201700841.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ListaTorneo
    {
        public int id_listaTorneo { get; set; }
        public Nullable<int> id_torneo { get; set; }
        public Nullable<int> id_us { get; set; }
    
        public virtual Torneo Torneo { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
