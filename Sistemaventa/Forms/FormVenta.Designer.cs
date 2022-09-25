namespace Sistemaventa.Forms
{
    partial class FormVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenta));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtDescuentoTotal = new System.Windows.Forms.TextBox();
            this.btnPagar = new DevExpress.XtraEditors.SimpleButton();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnPegar = new DevExpress.XtraEditors.SimpleButton();
            this.txtMontoPago = new System.Windows.Forms.TextBox();
            this.gridDetalleVenta = new DevExpress.XtraGrid.GridControl();
            this.xpDetalleVenta = new DevExpress.Xpo.XPCollection(this.components);
            this.SesionVenta = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridViewDetalleVenta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdDetalleVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.txtMontototal = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.checkBoxDescuento = new System.Windows.Forms.CheckBox();
            this.txtMontoCambio = new System.Windows.Forms.TextBox();
            this.radioButtonDolar = new System.Windows.Forms.RadioButton();
            this.radioButtonCordoba = new System.Windows.Forms.RadioButton();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtCordoba = new System.Windows.Forms.TextBox();
            this.btnModificar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.txtCalculoSubtotal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new DevExpress.XtraEditors.SimpleButton();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.comboBoxDocumento = new System.Windows.Forms.ComboBox();
            this.searchProducto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpDetalleCompra = new DevExpress.Xpo.XPCollection(this.components);
            this.searchViewProducto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchCliente = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpCliente = new DevExpress.Xpo.XPCollection(this.components);
            this.searchViewCliente = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombre_Completo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidoClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSexoClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumentoCLient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCelularClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCorreoClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem10 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem11 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem12 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem13 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem14 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem23 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem21 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem25 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem26 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem27 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem15 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem19 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem24 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem18 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem28 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem29 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xpProducto = new DevExpress.Xpo.XPCollection(this.components);
            this.xpVenta = new DevExpress.Xpo.XPCollection(this.components);
            this.xpEmpleado = new DevExpress.Xpo.XPCollection(this.components);
            this.xpDolar = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SesionVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpDetalleCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpDolar)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtDescuentoTotal);
            this.layoutControl1.Controls.Add(this.btnPagar);
            this.layoutControl1.Controls.Add(this.txtStock);
            this.layoutControl1.Controls.Add(this.btnPegar);
            this.layoutControl1.Controls.Add(this.txtMontoPago);
            this.layoutControl1.Controls.Add(this.gridDetalleVenta);
            this.layoutControl1.Controls.Add(this.btnGuardar);
            this.layoutControl1.Controls.Add(this.txtMontototal);
            this.layoutControl1.Controls.Add(this.txtSubtotal);
            this.layoutControl1.Controls.Add(this.txtDescuento);
            this.layoutControl1.Controls.Add(this.checkBoxDescuento);
            this.layoutControl1.Controls.Add(this.txtMontoCambio);
            this.layoutControl1.Controls.Add(this.radioButtonDolar);
            this.layoutControl1.Controls.Add(this.radioButtonCordoba);
            this.layoutControl1.Controls.Add(this.txtDolar);
            this.layoutControl1.Controls.Add(this.txtCordoba);
            this.layoutControl1.Controls.Add(this.btnModificar);
            this.layoutControl1.Controls.Add(this.btnCancelar);
            this.layoutControl1.Controls.Add(this.btnEliminar);
            this.layoutControl1.Controls.Add(this.btnAgregar);
            this.layoutControl1.Controls.Add(this.txtCalculoSubtotal);
            this.layoutControl1.Controls.Add(this.btnCalcular);
            this.layoutControl1.Controls.Add(this.txtCantidad);
            this.layoutControl1.Controls.Add(this.txtPrecio);
            this.layoutControl1.Controls.Add(this.txtDocumento);
            this.layoutControl1.Controls.Add(this.comboBoxDocumento);
            this.layoutControl1.Controls.Add(this.searchProducto);
            this.layoutControl1.Controls.Add(this.searchCliente);
            this.layoutControl1.Controls.Add(this.label1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 269, 650, 400);
            this.layoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1210, 517);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtDescuentoTotal
            // 
            this.txtDescuentoTotal.Location = new System.Drawing.Point(1086, 237);
            this.txtDescuentoTotal.Name = "txtDescuentoTotal";
            this.txtDescuentoTotal.ReadOnly = true;
            this.txtDescuentoTotal.Size = new System.Drawing.Size(112, 20);
            this.txtDescuentoTotal.TabIndex = 22;
            // 
            // btnPagar
            // 
            this.btnPagar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnPagar.Appearance.Options.UseFont = true;
            this.btnPagar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPagar.ImageOptions.Image")));
            this.btnPagar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnPagar.Location = new System.Drawing.Point(972, 434);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(226, 29);
            this.btnPagar.StyleController = this.layoutControl1;
            this.btnPagar.TabIndex = 14;
            this.btnPagar.Text = "Realizar pago";
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(493, 106);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(38, 20);
            this.txtStock.TabIndex = 4;
            this.txtStock.Text = "0";
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // btnPegar
            // 
            this.btnPegar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPegar.ImageOptions.Image")));
            this.btnPegar.Location = new System.Drawing.Point(1172, 374);
            this.btnPegar.Name = "btnPegar";
            this.btnPegar.Size = new System.Drawing.Size(26, 22);
            this.btnPegar.StyleController = this.layoutControl1;
            this.btnPegar.TabIndex = 13;
            this.btnPegar.Click += new System.EventHandler(this.btnPegar_Click);
            // 
            // txtMontoPago
            // 
            this.txtMontoPago.Enabled = false;
            this.txtMontoPago.Location = new System.Drawing.Point(1086, 374);
            this.txtMontoPago.Name = "txtMontoPago";
            this.txtMontoPago.Size = new System.Drawing.Size(82, 20);
            this.txtMontoPago.TabIndex = 13;
            this.txtMontoPago.Text = "0";
            // 
            // gridDetalleVenta
            // 
            this.gridDetalleVenta.DataSource = this.xpDetalleVenta;
            this.gridDetalleVenta.Location = new System.Drawing.Point(12, 189);
            this.gridDetalleVenta.MainView = this.gridViewDetalleVenta;
            this.gridDetalleVenta.Name = "gridDetalleVenta";
            this.gridDetalleVenta.Size = new System.Drawing.Size(946, 316);
            this.gridDetalleVenta.TabIndex = 21;
            this.gridDetalleVenta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetalleVenta});
            // 
            // xpDetalleVenta
            // 
            this.xpDetalleVenta.ObjectType = typeof(Sistemaventa.Sistema_Venta.DetalleVenta);
            this.xpDetalleVenta.Session = this.SesionVenta;
            // 
            // SesionVenta
            // 
            this.SesionVenta.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.SesionVenta.TrackPropertiesModifications = false;
            // 
            // gridViewDetalleVenta
            // 
            this.gridViewDetalleVenta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdDetalleVenta,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.colPrecioVenta,
            this.colSubTotal,
            this.colStock});
            this.gridViewDetalleVenta.GridControl = this.gridDetalleVenta;
            this.gridViewDetalleVenta.Name = "gridViewDetalleVenta";
            this.gridViewDetalleVenta.OptionsBehavior.Editable = false;
            this.gridViewDetalleVenta.Click += new System.EventHandler(this.gridViewDetalleVenta_Click);
            this.gridViewDetalleVenta.DoubleClick += new System.EventHandler(this.gridViewDetalleVenta_DoubleClick);
            // 
            // colIdDetalleVenta
            // 
            this.colIdDetalleVenta.FieldName = "IdDetalleVenta";
            this.colIdDetalleVenta.Name = "colIdDetalleVenta";
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "IdVenta!";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "IdVenta!Key";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "IdProd!";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn8.AppearanceHeader.Options.UseFont = true;
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.Caption = "Producto";
            this.gridColumn8.FieldName = "IdProd.Nombre";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            // 
            // colPrecioVenta
            // 
            this.colPrecioVenta.AppearanceCell.Options.UseTextOptions = true;
            this.colPrecioVenta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrecioVenta.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colPrecioVenta.AppearanceHeader.Options.UseFont = true;
            this.colPrecioVenta.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrecioVenta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrecioVenta.FieldName = "PrecioVenta";
            this.colPrecioVenta.Name = "colPrecioVenta";
            this.colPrecioVenta.Visible = true;
            this.colPrecioVenta.VisibleIndex = 1;
            // 
            // colSubTotal
            // 
            this.colSubTotal.AppearanceCell.Options.UseTextOptions = true;
            this.colSubTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubTotal.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSubTotal.AppearanceHeader.Options.UseFont = true;
            this.colSubTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubTotal.FieldName = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.Visible = true;
            this.colSubTotal.VisibleIndex = 2;
            // 
            // colStock
            // 
            this.colStock.AppearanceCell.Options.UseTextOptions = true;
            this.colStock.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colStock.AppearanceHeader.Options.UseFont = true;
            this.colStock.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock.FieldName = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.Visible = true;
            this.colStock.VisibleIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(972, 467);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(226, 38);
            this.btnGuardar.StyleController = this.layoutControl1;
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Realizar venta";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtMontototal
            // 
            this.txtMontototal.Location = new System.Drawing.Point(1086, 261);
            this.txtMontototal.Name = "txtMontototal";
            this.txtMontototal.ReadOnly = true;
            this.txtMontototal.Size = new System.Drawing.Size(112, 20);
            this.txtMontototal.TabIndex = 18;
            this.txtMontototal.Text = "0";
            this.txtMontototal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(1086, 189);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(112, 20);
            this.txtSubtotal.TabIndex = 17;
            this.txtSubtotal.Text = "0";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(1086, 213);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(86, 20);
            this.txtDescuento.TabIndex = 8;
            this.txtDescuento.Text = "0";
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescuento.Enter += new System.EventHandler(this.txtDocumento_Enter);
            // 
            // checkBoxDescuento
            // 
            this.checkBoxDescuento.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDescuento.Location = new System.Drawing.Point(1176, 213);
            this.checkBoxDescuento.Name = "checkBoxDescuento";
            this.checkBoxDescuento.Size = new System.Drawing.Size(22, 20);
            this.checkBoxDescuento.TabIndex = 7;
            this.checkBoxDescuento.UseVisualStyleBackColor = true;
            this.checkBoxDescuento.CheckedChanged += new System.EventHandler(this.checkBoxDescuento_CheckedChanged);
            // 
            // txtMontoCambio
            // 
            this.txtMontoCambio.Location = new System.Drawing.Point(1086, 400);
            this.txtMontoCambio.Name = "txtMontoCambio";
            this.txtMontoCambio.ReadOnly = true;
            this.txtMontoCambio.Size = new System.Drawing.Size(112, 20);
            this.txtMontoCambio.TabIndex = 14;
            this.txtMontoCambio.Text = "0";
            this.txtMontoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radioButtonDolar
            // 
            this.radioButtonDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDolar.Location = new System.Drawing.Point(1087, 345);
            this.radioButtonDolar.Name = "radioButtonDolar";
            this.radioButtonDolar.Size = new System.Drawing.Size(111, 25);
            this.radioButtonDolar.TabIndex = 10;
            this.radioButtonDolar.Text = "Dolar";
            this.radioButtonDolar.UseVisualStyleBackColor = true;
            this.radioButtonDolar.CheckedChanged += new System.EventHandler(this.radioButtonDolar_CheckedChanged);
            // 
            // radioButtonCordoba
            // 
            this.radioButtonCordoba.Checked = true;
            this.radioButtonCordoba.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCordoba.Location = new System.Drawing.Point(972, 345);
            this.radioButtonCordoba.Name = "radioButtonCordoba";
            this.radioButtonCordoba.Size = new System.Drawing.Size(111, 25);
            this.radioButtonCordoba.TabIndex = 9;
            this.radioButtonCordoba.TabStop = true;
            this.radioButtonCordoba.Text = "Cordoba";
            this.radioButtonCordoba.UseVisualStyleBackColor = true;
            this.radioButtonCordoba.CheckedChanged += new System.EventHandler(this.radioButtonCordoba_CheckedChanged);
            // 
            // txtDolar
            // 
            this.txtDolar.Enabled = false;
            this.txtDolar.Location = new System.Drawing.Point(1087, 311);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(111, 20);
            this.txtDolar.TabIndex = 12;
            this.txtDolar.Text = "0";
            this.txtDolar.Enter += new System.EventHandler(this.txtDocumento_Enter);
            this.txtDolar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtCordoba
            // 
            this.txtCordoba.Enabled = false;
            this.txtCordoba.Location = new System.Drawing.Point(972, 311);
            this.txtCordoba.Name = "txtCordoba";
            this.txtCordoba.Size = new System.Drawing.Size(111, 20);
            this.txtCordoba.TabIndex = 11;
            this.txtCordoba.Text = "0";
            this.txtCordoba.Enter += new System.EventHandler(this.txtDocumento_Enter);
            this.txtCordoba.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // btnModificar
            // 
            this.btnModificar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Appearance.Options.UseFont = true;
            this.btnModificar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.ImageOptions.Image")));
            this.btnModificar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnModificar.Location = new System.Drawing.Point(294, 142);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(266, 33);
            this.btnModificar.StyleController = this.layoutControl1;
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(849, 142);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(349, 33);
            this.btnCancelar.StyleController = this.layoutControl1;
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar modificación";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Appearance.Options.UseFont = true;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(574, 142);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(261, 33);
            this.btnEliminar.StyleController = this.layoutControl1;
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Quitar registro";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.ImageOptions.Image")));
            this.btnAgregar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(12, 142);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(268, 33);
            this.btnAgregar.StyleController = this.layoutControl1;
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCalculoSubtotal
            // 
            this.txtCalculoSubtotal.Enabled = false;
            this.txtCalculoSubtotal.Location = new System.Drawing.Point(1080, 106);
            this.txtCalculoSubtotal.Name = "txtCalculoSubtotal";
            this.txtCalculoSubtotal.Size = new System.Drawing.Size(118, 20);
            this.txtCalculoSubtotal.TabIndex = 8;
            this.txtCalculoSubtotal.Text = "0";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.Appearance.Options.UseFont = true;
            this.btnCalcular.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.ImageOptions.Image")));
            this.btnCalcular.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnCalcular.Location = new System.Drawing.Point(879, 106);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(73, 22);
            this.btnCalcular.StyleController = this.layoutControl1;
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(825, 106);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(40, 20);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.ValueChanged += new System.EventHandler(this.txtCantidad_ValueChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(659, 106);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(38, 20);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.Text = "0";
            this.txtPrecio.Enter += new System.EventHandler(this.txtDocumento_Enter);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Enabled = false;
            this.txtDocumento.Location = new System.Drawing.Point(1080, 71);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(118, 20);
            this.txtDocumento.TabIndex = 2;
            this.txtDocumento.Enter += new System.EventHandler(this.txtDocumento_Enter);
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // comboBoxDocumento
            // 
            this.comboBoxDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDocumento.FormattingEnabled = true;
            this.comboBoxDocumento.Items.AddRange(new object[] {
            "Factura",
            "Nota de Venta",
            "Recibos",
            "Otros"});
            this.comboBoxDocumento.Location = new System.Drawing.Point(659, 71);
            this.comboBoxDocumento.Name = "comboBoxDocumento";
            this.comboBoxDocumento.Size = new System.Drawing.Size(293, 21);
            this.comboBoxDocumento.TabIndex = 1;
            // 
            // searchProducto
            // 
            this.searchProducto.Location = new System.Drawing.Point(126, 106);
            this.searchProducto.Name = "searchProducto";
            this.searchProducto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchProducto.Properties.DataSource = this.xpDetalleCompra;
            this.searchProducto.Properties.DisplayMember = "IdProd.Nombre";
            this.searchProducto.Properties.PopupView = this.searchViewProducto;
            this.searchProducto.Properties.ValueMember = "IdProd";
            this.searchProducto.Properties.EditValueChanged += new System.EventHandler(this.searchProducto_Properties_EditValueChanged);
            this.searchProducto.Size = new System.Drawing.Size(239, 20);
            this.searchProducto.StyleController = this.layoutControl1;
            this.searchProducto.TabIndex = 3;
            // 
            // xpDetalleCompra
            // 
            this.xpDetalleCompra.ObjectType = typeof(Sistemaventa.Sistema_Venta.DetalleCompra);
            this.xpDetalleCompra.Session = this.SesionVenta;
            // 
            // searchViewProducto
            // 
            this.searchViewProducto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.colCantidad,
            this.colPrecioCompra,
            this.gridColumn3});
            this.searchViewProducto.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchViewProducto.Name = "searchViewProducto";
            this.searchViewProducto.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchViewProducto.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.searchViewProducto.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "Producto";
            this.gridColumn1.FieldName = "IdProd.Nombre";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Descripción Producto";
            this.gridColumn2.FieldName = "IdProd.Descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // colCantidad
            // 
            this.colCantidad.AppearanceCell.Options.UseTextOptions = true;
            this.colCantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCantidad.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colCantidad.AppearanceHeader.Options.UseFont = true;
            this.colCantidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCantidad.Caption = "Stock";
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 2;
            // 
            // colPrecioCompra
            // 
            this.colPrecioCompra.AppearanceCell.Options.UseTextOptions = true;
            this.colPrecioCompra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrecioCompra.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colPrecioCompra.AppearanceHeader.Options.UseFont = true;
            this.colPrecioCompra.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrecioCompra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrecioCompra.FieldName = "PrecioCompra";
            this.colPrecioCompra.Name = "colPrecioCompra";
            this.colPrecioCompra.Visible = true;
            this.colPrecioCompra.VisibleIndex = 3;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Articulo";
            this.gridColumn3.FieldName = "IdProd.ImagenArticulo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            // 
            // searchCliente
            // 
            this.searchCliente.Location = new System.Drawing.Point(126, 71);
            this.searchCliente.Name = "searchCliente";
            this.searchCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchCliente.Properties.DataSource = this.xpCliente;
            this.searchCliente.Properties.DisplayMember = "NombreClient";
            this.searchCliente.Properties.PopupView = this.searchViewCliente;
            this.searchCliente.Properties.ValueMember = "IdClient";
            this.searchCliente.Size = new System.Drawing.Size(405, 20);
            this.searchCliente.StyleController = this.layoutControl1;
            this.searchCliente.TabIndex = 0;
            this.searchCliente.Popup += new System.EventHandler(this.searchCliente_Popup);
            // 
            // xpCliente
            // 
            this.xpCliente.ObjectType = typeof(Sistemaventa.Sistema_Venta.Cliente);
            this.xpCliente.Session = this.SesionVenta;
            // 
            // searchViewCliente
            // 
            this.searchViewCliente.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombre_Completo,
            this.colIdClient,
            this.colNombreClient,
            this.colApellidoClient,
            this.colSexoClient,
            this.colDocumentoCLient,
            this.colCelularClient,
            this.colCorreoClient,
            this.colEstado,
            this.colFechaRegistro});
            this.searchViewCliente.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchViewCliente.Name = "searchViewCliente";
            this.searchViewCliente.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchViewCliente.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.searchViewCliente.OptionsView.ShowGroupPanel = false;
            // 
            // colNombre_Completo
            // 
            this.colNombre_Completo.AppearanceCell.Options.UseTextOptions = true;
            this.colNombre_Completo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNombre_Completo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNombre_Completo.AppearanceHeader.Options.UseFont = true;
            this.colNombre_Completo.AppearanceHeader.Options.UseTextOptions = true;
            this.colNombre_Completo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNombre_Completo.FieldName = "Nombre_Completo";
            this.colNombre_Completo.Name = "colNombre_Completo";
            this.colNombre_Completo.Visible = true;
            this.colNombre_Completo.VisibleIndex = 0;
            // 
            // colIdClient
            // 
            this.colIdClient.FieldName = "IdClient";
            this.colIdClient.Name = "colIdClient";
            // 
            // colNombreClient
            // 
            this.colNombreClient.FieldName = "NombreClient";
            this.colNombreClient.Name = "colNombreClient";
            // 
            // colApellidoClient
            // 
            this.colApellidoClient.FieldName = "ApellidoClient";
            this.colApellidoClient.Name = "colApellidoClient";
            // 
            // colSexoClient
            // 
            this.colSexoClient.AppearanceCell.Options.UseTextOptions = true;
            this.colSexoClient.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSexoClient.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSexoClient.AppearanceHeader.Options.UseFont = true;
            this.colSexoClient.AppearanceHeader.Options.UseTextOptions = true;
            this.colSexoClient.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSexoClient.FieldName = "SexoClient";
            this.colSexoClient.Name = "colSexoClient";
            this.colSexoClient.Visible = true;
            this.colSexoClient.VisibleIndex = 1;
            // 
            // colDocumentoCLient
            // 
            this.colDocumentoCLient.AppearanceCell.Options.UseTextOptions = true;
            this.colDocumentoCLient.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDocumentoCLient.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDocumentoCLient.AppearanceHeader.Options.UseFont = true;
            this.colDocumentoCLient.AppearanceHeader.Options.UseTextOptions = true;
            this.colDocumentoCLient.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDocumentoCLient.FieldName = "DocumentoCLient";
            this.colDocumentoCLient.Name = "colDocumentoCLient";
            this.colDocumentoCLient.Visible = true;
            this.colDocumentoCLient.VisibleIndex = 2;
            // 
            // colCelularClient
            // 
            this.colCelularClient.AppearanceCell.Options.UseTextOptions = true;
            this.colCelularClient.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCelularClient.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colCelularClient.AppearanceHeader.Options.UseFont = true;
            this.colCelularClient.AppearanceHeader.Options.UseTextOptions = true;
            this.colCelularClient.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCelularClient.FieldName = "CelularClient";
            this.colCelularClient.Name = "colCelularClient";
            this.colCelularClient.Visible = true;
            this.colCelularClient.VisibleIndex = 3;
            // 
            // colCorreoClient
            // 
            this.colCorreoClient.AppearanceCell.Options.UseTextOptions = true;
            this.colCorreoClient.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCorreoClient.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colCorreoClient.AppearanceHeader.Options.UseFont = true;
            this.colCorreoClient.AppearanceHeader.Options.UseTextOptions = true;
            this.colCorreoClient.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCorreoClient.FieldName = "CorreoClient";
            this.colCorreoClient.Name = "colCorreoClient";
            this.colCorreoClient.Visible = true;
            this.colCorreoClient.VisibleIndex = 4;
            // 
            // colEstado
            // 
            this.colEstado.AppearanceCell.Options.UseTextOptions = true;
            this.colEstado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEstado.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colEstado.AppearanceHeader.Options.UseFont = true;
            this.colEstado.AppearanceHeader.Options.UseTextOptions = true;
            this.colEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 5;
            // 
            // colFechaRegistro
            // 
            this.colFechaRegistro.AppearanceCell.Options.UseTextOptions = true;
            this.colFechaRegistro.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaRegistro.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colFechaRegistro.AppearanceHeader.Options.UseFont = true;
            this.colFechaRegistro.AppearanceHeader.Options.UseTextOptions = true;
            this.colFechaRegistro.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaRegistro.FieldName = "FechaRegistro";
            this.colFechaRegistro.Name = "colFechaRegistro";
            this.colFechaRegistro.Visible = true;
            this.colFechaRegistro.VisibleIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(207)))), ((int)(((byte)(173)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1186, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registro de Ventas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem2,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem3,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.emptySpaceItem4,
            this.emptySpaceItem5,
            this.emptySpaceItem6,
            this.emptySpaceItem7,
            this.emptySpaceItem8,
            this.emptySpaceItem9,
            this.emptySpaceItem10,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem12,
            this.layoutControlItem13,
            this.emptySpaceItem11,
            this.emptySpaceItem12,
            this.emptySpaceItem13,
            this.emptySpaceItem14,
            this.layoutControlItem14,
            this.layoutControlItem15,
            this.layoutControlItem16,
            this.layoutControlItem17,
            this.layoutControlItem18,
            this.layoutControlItem23,
            this.emptySpaceItem21,
            this.layoutControlItem25,
            this.layoutControlItem26,
            this.layoutControlItem27,
            this.emptySpaceItem15,
            this.layoutControlItem21,
            this.layoutControlItem22,
            this.emptySpaceItem19,
            this.layoutControlItem20,
            this.layoutControlItem19,
            this.layoutControlItem24,
            this.emptySpaceItem18,
            this.layoutControlItem28,
            this.emptySpaceItem1,
            this.layoutControlItem29});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1210, 517);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.label1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1190, 49);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 49);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(1190, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.searchCliente;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 59);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(523, 25);
            this.layoutControlItem2.Text = "Cliente:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.searchProducto;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 94);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(357, 26);
            this.layoutControlItem3.Text = "Producto:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.comboBoxDocumento;
            this.layoutControlItem4.Location = new System.Drawing.Point(533, 59);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(411, 25);
            this.layoutControlItem4.Text = "Tipo Documento:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.txtDocumento;
            this.layoutControlItem5.Location = new System.Drawing.Point(954, 59);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(236, 25);
            this.layoutControlItem5.Text = "Documento:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(111, 13);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 84);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(1190, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.txtPrecio;
            this.layoutControlItem6.Location = new System.Drawing.Point(533, 94);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(156, 26);
            this.layoutControlItem6.Text = "Precio Venta:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.Control = this.txtCantidad;
            this.layoutControlItem7.Location = new System.Drawing.Point(699, 94);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(158, 26);
            this.layoutControlItem7.Text = "Cantidad:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnCalcular;
            this.layoutControlItem8.Location = new System.Drawing.Point(867, 94);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(77, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem9.Control = this.txtCalculoSubtotal;
            this.layoutControlItem9.Location = new System.Drawing.Point(954, 94);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(236, 26);
            this.layoutControlItem9.Text = "Subtotal:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(111, 13);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(523, 59);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(10, 25);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(944, 59);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(10, 25);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(357, 94);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(10, 26);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(689, 94);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(10, 26);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.Location = new System.Drawing.Point(857, 94);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(10, 26);
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.AllowHotTrack = false;
            this.emptySpaceItem9.Location = new System.Drawing.Point(944, 94);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Size = new System.Drawing.Size(10, 26);
            this.emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem10
            // 
            this.emptySpaceItem10.AllowHotTrack = false;
            this.emptySpaceItem10.Location = new System.Drawing.Point(0, 120);
            this.emptySpaceItem10.Name = "emptySpaceItem10";
            this.emptySpaceItem10.Size = new System.Drawing.Size(1190, 10);
            this.emptySpaceItem10.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnAgregar;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 130);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(272, 37);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnEliminar;
            this.layoutControlItem11.Location = new System.Drawing.Point(562, 130);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(265, 37);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.btnCancelar;
            this.layoutControlItem12.Location = new System.Drawing.Point(837, 130);
            this.layoutControlItem12.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(353, 37);
            this.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.btnModificar;
            this.layoutControlItem13.Location = new System.Drawing.Point(282, 130);
            this.layoutControlItem13.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(270, 37);
            this.layoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextVisible = false;
            // 
            // emptySpaceItem11
            // 
            this.emptySpaceItem11.AllowHotTrack = false;
            this.emptySpaceItem11.Location = new System.Drawing.Point(272, 130);
            this.emptySpaceItem11.Name = "emptySpaceItem11";
            this.emptySpaceItem11.Size = new System.Drawing.Size(10, 37);
            this.emptySpaceItem11.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem12
            // 
            this.emptySpaceItem12.AllowHotTrack = false;
            this.emptySpaceItem12.Location = new System.Drawing.Point(552, 130);
            this.emptySpaceItem12.Name = "emptySpaceItem12";
            this.emptySpaceItem12.Size = new System.Drawing.Size(10, 37);
            this.emptySpaceItem12.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem13
            // 
            this.emptySpaceItem13.AllowHotTrack = false;
            this.emptySpaceItem13.Location = new System.Drawing.Point(827, 130);
            this.emptySpaceItem13.Name = "emptySpaceItem13";
            this.emptySpaceItem13.Size = new System.Drawing.Size(10, 37);
            this.emptySpaceItem13.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem14
            // 
            this.emptySpaceItem14.AllowHotTrack = false;
            this.emptySpaceItem14.Location = new System.Drawing.Point(0, 167);
            this.emptySpaceItem14.Name = "emptySpaceItem14";
            this.emptySpaceItem14.Size = new System.Drawing.Size(1190, 10);
            this.emptySpaceItem14.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem14.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem14.Control = this.txtCordoba;
            this.layoutControlItem14.Location = new System.Drawing.Point(960, 283);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(115, 40);
            this.layoutControlItem14.Text = "Monto Cordoba:";
            this.layoutControlItem14.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem14.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem15.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem15.Control = this.txtDolar;
            this.layoutControlItem15.Location = new System.Drawing.Point(1075, 283);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(115, 40);
            this.layoutControlItem15.Text = "Monto Dolar:";
            this.layoutControlItem15.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem15.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.radioButtonCordoba;
            this.layoutControlItem16.Location = new System.Drawing.Point(960, 333);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(115, 29);
            this.layoutControlItem16.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem16.TextVisible = false;
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.radioButtonDolar;
            this.layoutControlItem17.Location = new System.Drawing.Point(1075, 333);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(115, 29);
            this.layoutControlItem17.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem17.TextVisible = false;
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem18.AppearanceItemCaption.ForeColor = System.Drawing.Color.Green;
            this.layoutControlItem18.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem18.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem18.Control = this.txtMontoCambio;
            this.layoutControlItem18.Location = new System.Drawing.Point(960, 388);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(230, 24);
            this.layoutControlItem18.Text = "Monto Cambio:";
            this.layoutControlItem18.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem23
            // 
            this.layoutControlItem23.Control = this.btnGuardar;
            this.layoutControlItem23.Location = new System.Drawing.Point(960, 455);
            this.layoutControlItem23.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem23.Name = "layoutControlItem23";
            this.layoutControlItem23.Size = new System.Drawing.Size(230, 42);
            this.layoutControlItem23.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem23.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem23.TextVisible = false;
            // 
            // emptySpaceItem21
            // 
            this.emptySpaceItem21.AllowHotTrack = false;
            this.emptySpaceItem21.Location = new System.Drawing.Point(960, 323);
            this.emptySpaceItem21.Name = "emptySpaceItem21";
            this.emptySpaceItem21.Size = new System.Drawing.Size(230, 10);
            this.emptySpaceItem21.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem25
            // 
            this.layoutControlItem25.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem25.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.layoutControlItem25.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem25.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem25.Control = this.txtMontoPago;
            this.layoutControlItem25.Location = new System.Drawing.Point(960, 362);
            this.layoutControlItem25.Name = "layoutControlItem25";
            this.layoutControlItem25.Size = new System.Drawing.Size(200, 26);
            this.layoutControlItem25.Text = "Monto Pago:";
            this.layoutControlItem25.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem26
            // 
            this.layoutControlItem26.Control = this.btnPegar;
            this.layoutControlItem26.Location = new System.Drawing.Point(1160, 362);
            this.layoutControlItem26.Name = "layoutControlItem26";
            this.layoutControlItem26.Size = new System.Drawing.Size(30, 26);
            this.layoutControlItem26.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem26.TextVisible = false;
            // 
            // layoutControlItem27
            // 
            this.layoutControlItem27.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem27.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem27.Control = this.txtStock;
            this.layoutControlItem27.Location = new System.Drawing.Point(367, 94);
            this.layoutControlItem27.Name = "layoutControlItem27";
            this.layoutControlItem27.Size = new System.Drawing.Size(156, 26);
            this.layoutControlItem27.Text = "Stock Producto:";
            this.layoutControlItem27.TextSize = new System.Drawing.Size(111, 13);
            // 
            // emptySpaceItem15
            // 
            this.emptySpaceItem15.AllowHotTrack = false;
            this.emptySpaceItem15.Location = new System.Drawing.Point(523, 94);
            this.emptySpaceItem15.Name = "emptySpaceItem15";
            this.emptySpaceItem15.Size = new System.Drawing.Size(10, 26);
            this.emptySpaceItem15.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem21.AppearanceItemCaption.ForeColor = System.Drawing.Color.Green;
            this.layoutControlItem21.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem21.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem21.Control = this.txtSubtotal;
            this.layoutControlItem21.Location = new System.Drawing.Point(960, 177);
            this.layoutControlItem21.Name = "layoutControlItem21";
            this.layoutControlItem21.Size = new System.Drawing.Size(230, 24);
            this.layoutControlItem21.Text = "Subtotal:";
            this.layoutControlItem21.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem22
            // 
            this.layoutControlItem22.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem22.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.layoutControlItem22.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem22.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem22.Control = this.txtMontototal;
            this.layoutControlItem22.Location = new System.Drawing.Point(960, 249);
            this.layoutControlItem22.Name = "layoutControlItem22";
            this.layoutControlItem22.Size = new System.Drawing.Size(230, 24);
            this.layoutControlItem22.Text = "Monto total:";
            this.layoutControlItem22.TextSize = new System.Drawing.Size(111, 13);
            // 
            // emptySpaceItem19
            // 
            this.emptySpaceItem19.AllowHotTrack = false;
            this.emptySpaceItem19.Location = new System.Drawing.Point(960, 273);
            this.emptySpaceItem19.Name = "emptySpaceItem19";
            this.emptySpaceItem19.Size = new System.Drawing.Size(230, 10);
            this.emptySpaceItem19.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem20.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem20.Control = this.txtDescuento;
            this.layoutControlItem20.Location = new System.Drawing.Point(960, 201);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(204, 24);
            this.layoutControlItem20.Text = "Aplicare descuento:";
            this.layoutControlItem20.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.checkBoxDescuento;
            this.layoutControlItem19.Location = new System.Drawing.Point(1164, 201);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(26, 24);
            this.layoutControlItem19.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem19.TextVisible = false;
            // 
            // layoutControlItem24
            // 
            this.layoutControlItem24.Control = this.gridDetalleVenta;
            this.layoutControlItem24.Location = new System.Drawing.Point(0, 177);
            this.layoutControlItem24.Name = "layoutControlItem24";
            this.layoutControlItem24.Size = new System.Drawing.Size(950, 320);
            this.layoutControlItem24.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem24.TextVisible = false;
            // 
            // emptySpaceItem18
            // 
            this.emptySpaceItem18.AllowHotTrack = false;
            this.emptySpaceItem18.Location = new System.Drawing.Point(950, 177);
            this.emptySpaceItem18.Name = "emptySpaceItem18";
            this.emptySpaceItem18.Size = new System.Drawing.Size(10, 320);
            this.emptySpaceItem18.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem28
            // 
            this.layoutControlItem28.Control = this.btnPagar;
            this.layoutControlItem28.Location = new System.Drawing.Point(960, 422);
            this.layoutControlItem28.MinSize = new System.Drawing.Size(109, 26);
            this.layoutControlItem28.Name = "layoutControlItem28";
            this.layoutControlItem28.Size = new System.Drawing.Size(230, 33);
            this.layoutControlItem28.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem28.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem28.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(960, 412);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(230, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem29
            // 
            this.layoutControlItem29.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem29.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem29.Control = this.txtDescuentoTotal;
            this.layoutControlItem29.Location = new System.Drawing.Point(960, 225);
            this.layoutControlItem29.Name = "layoutControlItem29";
            this.layoutControlItem29.Size = new System.Drawing.Size(230, 24);
            this.layoutControlItem29.Text = "Descuento(Total):";
            this.layoutControlItem29.TextSize = new System.Drawing.Size(111, 13);
            // 
            // xpProducto
            // 
            this.xpProducto.ObjectType = typeof(Sistemaventa.Sistema_Venta.Producto);
            this.xpProducto.Session = this.SesionVenta;
            // 
            // xpVenta
            // 
            this.xpVenta.Session = this.SesionVenta;
            // 
            // xpEmpleado
            // 
            this.xpEmpleado.ObjectType = typeof(Sistemaventa.Sistema_Venta.Empleado);
            this.xpEmpleado.Session = this.SesionVenta;
            // 
            // xpDolar
            // 
            this.xpDolar.ObjectType = typeof(Sistemaventa.Sistema_Venta.CambioDolar);
            this.xpDolar.Session = this.SesionVenta;
            // 
            // FormVenta
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 517);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVenta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SesionVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpDetalleCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpDolar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.TextBox txtCalculoSubtotal;
        private DevExpress.XtraEditors.SimpleButton btnCalcular;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.ComboBox comboBoxDocumento;
        private DevExpress.XtraEditors.SearchLookUpEdit searchProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView searchViewProducto;
        private DevExpress.XtraEditors.SearchLookUpEdit searchCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView searchViewCliente;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraEditors.SimpleButton btnModificar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem11;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem12;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem13;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private System.Windows.Forms.TextBox txtMontototal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.CheckBox checkBoxDescuento;
        private System.Windows.Forms.TextBox txtMontoCambio;
        private System.Windows.Forms.RadioButton radioButtonDolar;
        private System.Windows.Forms.RadioButton radioButtonCordoba;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtCordoba;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem22;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem23;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem19;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem21;
        private DevExpress.XtraGrid.GridControl gridDetalleVenta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetalleVenta;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem24;
        private DevExpress.Xpo.UnitOfWork SesionVenta;
        private DevExpress.Xpo.XPCollection xpCliente;
        private DevExpress.Xpo.XPCollection xpProducto;
        private DevExpress.Xpo.XPCollection xpDetalleVenta;
        private System.Windows.Forms.TextBox txtMontoPago;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem25;
        private DevExpress.Xpo.XPCollection xpVenta;
        private DevExpress.Xpo.XPCollection xpEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDetalleVenta;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colStock;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre_Completo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdClient;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreClient;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidoClient;
        private DevExpress.XtraGrid.Columns.GridColumn colSexoClient;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentoCLient;
        private DevExpress.XtraGrid.Columns.GridColumn colCelularClient;
        private DevExpress.XtraGrid.Columns.GridColumn colCorreoClient;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRegistro;
        private DevExpress.XtraEditors.SimpleButton btnPegar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem26;
        private System.Windows.Forms.TextBox txtStock;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem27;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem15;
        private DevExpress.Xpo.XPCollection xpDetalleCompra;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem18;
        private DevExpress.XtraEditors.SimpleButton btnPagar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem28;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.TextBox txtDescuentoTotal;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem29;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioCompra;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.Xpo.XPCollection xpDolar;
    }
}