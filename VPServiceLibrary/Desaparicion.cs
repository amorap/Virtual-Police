//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VPServiceLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class Desaparicion : Denuncia
    {
        public string Descripción_Fisica { get; set; }
        public int CiudadanoID_Ciudadano { get; set; }
    
        public virtual Ciudadano Ciudadano { get; set; }
        public virtual Foto Foto { get; set; }
    }
}
