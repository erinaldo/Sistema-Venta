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

    public partial class DetalleCompra : XPLiteObject
    {
        int fIdDetalleCompra;
        [Key(true)]
        public int IdDetalleCompra
        {
            get { return fIdDetalleCompra; }
            set { SetPropertyValue<int>(nameof(IdDetalleCompra), ref fIdDetalleCompra, value); }
        }
        Compra fIdCompra;
        [Association(@"DetalleCompraReferencesCompra")]
        public Compra IdCompra
        {
            get { return fIdCompra; }
            set { SetPropertyValue<Compra>(nameof(IdCompra), ref fIdCompra, value); }
        }
        Producto fIdProd;
        [Association(@"DetalleCompraReferencesProducto")]
        public Producto IdProd
        {
            get { return fIdProd; }
            set { SetPropertyValue<Producto>(nameof(IdProd), ref fIdProd, value); }
        }
        int fCantidad;
        public int Cantidad
        {
            get { return fCantidad; }
            set { SetPropertyValue<int>(nameof(Cantidad), ref fCantidad, value); }
        }
        decimal fPrecioCompra;
        [ColumnDbDefaultValue("((0))")]
        public decimal PrecioCompra
        {
            get { return fPrecioCompra; }
            set { SetPropertyValue<decimal>(nameof(PrecioCompra), ref fPrecioCompra, value); }
        }
        decimal fSubTotal;
        [ColumnDbDefaultValue("((0))")]
        public decimal SubTotal
        {
            get { return fSubTotal; }
            set { SetPropertyValue<decimal>(nameof(SubTotal), ref fSubTotal, value); }
        }
    }

}
