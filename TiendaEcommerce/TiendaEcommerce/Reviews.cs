//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TiendaEcommerce
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reviews
    {
        public int Id { get; set; }
        public int Id_Producto { get; set; }
        public string Email { get; set; }
        public string Detalles { get; set; }
        public System.DateTime Fecha_de_Review { get; set; }
    
        public virtual Productos Productos { get; set; }
    }
}