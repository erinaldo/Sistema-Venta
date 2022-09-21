using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Sistemaventa.Sistema_Venta
{

    public partial class Marca
    {
        public Marca(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
