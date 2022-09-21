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

    public partial class Categoria : XPLiteObject
    {
        int fIdCateg;
        [Key(true)]
        public int IdCateg
        {
            get { return fIdCateg; }
            set { SetPropertyValue<int>(nameof(IdCateg), ref fIdCateg, value); }
        }
        string fNombreCateg;
        [Size(60)]
        public string NombreCateg
        {
            get { return fNombreCateg; }
            set { SetPropertyValue<string>(nameof(NombreCateg), ref fNombreCateg, value); }
        }
        string fDescripcion;
        [Size(120)]
        public string Descripcion
        {
            get { return fDescripcion; }
            set { SetPropertyValue<string>(nameof(Descripcion), ref fDescripcion, value); }
        }
        string fEstado;
        [Size(25)]
        public string Estado
        {
            get { return fEstado; }
            set { SetPropertyValue<string>(nameof(Estado), ref fEstado, value); }
        }
        DateTime fFechaRegistro;
        [ColumnDbDefaultValue("(getdate())")]
        public DateTime FechaRegistro
        {
            get { return fFechaRegistro; }
            set { SetPropertyValue<DateTime>(nameof(FechaRegistro), ref fFechaRegistro, value); }
        }
        [Association(@"ProductoReferencesCategoria")]
        public XPCollection<Producto> Productoes { get { return GetCollection<Producto>(nameof(Productoes)); } }
    }

}
