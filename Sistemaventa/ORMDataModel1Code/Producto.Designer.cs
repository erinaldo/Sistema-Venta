﻿//------------------------------------------------------------------------------
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

    public partial class Producto : XPLiteObject
    {
        int fIdProd;
        [Key(true)]
        public int IdProd
        {
            get { return fIdProd; }
            set { SetPropertyValue<int>(nameof(IdProd), ref fIdProd, value); }
        }
        string fCodigo;
        [Size(15)]
        public string Codigo
        {
            get { return fCodigo; }
            set { SetPropertyValue<string>(nameof(Codigo), ref fCodigo, value); }
        }
        string fNombre;
        [Size(60)]
        public string Nombre
        {
            get { return fNombre; }
            set { SetPropertyValue<string>(nameof(Nombre), ref fNombre, value); }
        }
        string fDescripcion;
        [Size(120)]
        public string Descripcion
        {
            get { return fDescripcion; }
            set { SetPropertyValue<string>(nameof(Descripcion), ref fDescripcion, value); }
        }
        Categoria fIdCateg;
        [Association(@"ProductoReferencesCategoria")]
        public Categoria IdCateg
        {
            get { return fIdCateg; }
            set { SetPropertyValue<Categoria>(nameof(IdCateg), ref fIdCateg, value); }
        }
        Marca fIdMarca;
        [Association(@"ProductoReferencesMarca")]
        public Marca IdMarca
        {
            get { return fIdMarca; }
            set { SetPropertyValue<Marca>(nameof(IdMarca), ref fIdMarca, value); }
        }
        string fEstado;
        [Size(20)]
        public string Estado
        {
            get { return fEstado; }
            set { SetPropertyValue<string>(nameof(Estado), ref fEstado, value); }
        }
        byte[] fImagenArticulo;
        [Size(SizeAttribute.Unlimited)]
        [MemberDesignTimeVisibility(true)]
        public byte[] ImagenArticulo
        {
            get { return fImagenArticulo; }
            set { SetPropertyValue<byte[]>(nameof(ImagenArticulo), ref fImagenArticulo, value); }
        }
        string fFechaVence;
        public string FechaVence
        {
            get { return fFechaVence; }
            set { SetPropertyValue<string>(nameof(FechaVence), ref fFechaVence, value); }
        }
        DateTime fFechaRegistro;
        [ColumnDbDefaultValue("(getdate())")]
        public DateTime FechaRegistro
        {
            get { return fFechaRegistro; }
            set { SetPropertyValue<DateTime>(nameof(FechaRegistro), ref fFechaRegistro, value); }
        }
        [Association(@"DetalleCompraReferencesProducto")]
        public XPCollection<DetalleCompra> DetalleCompras { get { return GetCollection<DetalleCompra>(nameof(DetalleCompras)); } }
        [Association(@"DetalleVentaReferencesProducto")]
        public XPCollection<DetalleVenta> DetalleVentas { get { return GetCollection<DetalleVenta>(nameof(DetalleVentas)); } }
        [Association(@"EstadoProductoReferencesProducto")]
        public XPCollection<EstadoProducto> EstadoProductoes { get { return GetCollection<EstadoProducto>(nameof(EstadoProductoes)); } }
        [Association(@"EstadoVentaReferencesProducto")]
        public XPCollection<EstadoVenta> EstadoVentas { get { return GetCollection<EstadoVenta>(nameof(EstadoVentas)); } }
    }

}
