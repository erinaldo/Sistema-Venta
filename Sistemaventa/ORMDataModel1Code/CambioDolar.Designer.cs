//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Sistemaventa.Sistema_Venta
{

    public partial class CambioDolar : XPLiteObject
    {
        int fId;
        [Key(true)]
        public int Id
        {
            get { return fId; }
            set { SetPropertyValue<int>(nameof(Id), ref fId, value); }
        }
        decimal fValorDolar;
        [ColumnDbDefaultValue("((0))")]
        public decimal ValorDolar
        {
            get { return fValorDolar; }
            set { SetPropertyValue<decimal>(nameof(ValorDolar), ref fValorDolar, value); }
        }
        DateTime fFechaRegistro;
        [ColumnDbDefaultValue("(getdate())")]
        public DateTime FechaRegistro
        {
            get { return fFechaRegistro; }
            set { SetPropertyValue<DateTime>(nameof(FechaRegistro), ref fFechaRegistro, value); }
        }
        [Association(@"VentaReferencesCambioDolar")]
        public XPCollection<Venta> Ventas { get { return GetCollection<Venta>(nameof(Ventas)); } }
    }

}
