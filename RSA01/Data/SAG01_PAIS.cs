//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RSA01.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class SAG01_PAIS
    {
        public SAG01_PAIS()
        {
            this.SAG01_RECIBO = new HashSet<SAG01_RECIBO>();
        }
    
        public string PAIS { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<decimal> REGION { get; set; }
        public string ESTADO_REGISTRO { get; set; }
        public string USUARIO_CREACION { get; set; }
        public Nullable<System.DateTime> FECHA_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
    
        public virtual ICollection<SAG01_RECIBO> SAG01_RECIBO { get; set; }
        public virtual SAG01_REGION SAG01_REGION { get; set; }
    }
}