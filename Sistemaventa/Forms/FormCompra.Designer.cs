namespace Sistemaventa.Forms
{
    partial class FormCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompra));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.gridCompra = new DevExpress.XtraGrid.GridControl();
            this.xpDetalleCompra = new DevExpress.Xpo.XPCollection(this.components);
            this.SesionVenta = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridViewCompra = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdDetalleCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnModificar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new DevExpress.XtraEditors.SimpleButton();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.comboBoxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.searchProducto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpProducto = new DevExpress.Xpo.XPCollection(this.components);
            this.searchViewProducto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImagenArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaVence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaRegistro1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchProveedor = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpProveedor = new DevExpress.Xpo.XPCollection(this.components);
            this.searchViewProveedor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreProv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumentoProv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocialProv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCorreoProv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefonoProv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoProv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogotipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.xpCompra = new DevExpress.Xpo.XPCollection(this.components);
            this.xpEmpleado = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpDetalleCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SesionVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnGuardar);
            this.layoutControl1.Controls.Add(this.txtMontoTotal);
            this.layoutControl1.Controls.Add(this.gridCompra);
            this.layoutControl1.Controls.Add(this.btnCancelar);
            this.layoutControl1.Controls.Add(this.btnEliminar);
            this.layoutControl1.Controls.Add(this.btnModificar);
            this.layoutControl1.Controls.Add(this.btnAgregar);
            this.layoutControl1.Controls.Add(this.txtSubTotal);
            this.layoutControl1.Controls.Add(this.btnCalcular);
            this.layoutControl1.Controls.Add(this.txtCantidad);
            this.layoutControl1.Controls.Add(this.txtPrecioCompra);
            this.layoutControl1.Controls.Add(this.txtDocumento);
            this.layoutControl1.Controls.Add(this.comboBoxTipoDocumento);
            this.layoutControl1.Controls.Add(this.searchProducto);
            this.layoutControl1.Controls.Add(this.searchProveedor);
            this.layoutControl1.Controls.Add(this.label1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1210, 517);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(880, 461);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(318, 44);
            this.btnGuardar.StyleController = this.layoutControl1;
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Realizar Compra";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Enabled = false;
            this.txtMontoTotal.ForeColor = System.Drawing.Color.Red;
            this.txtMontoTotal.Location = new System.Drawing.Point(127, 289);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(200, 20);
            this.txtMontoTotal.TabIndex = 18;
            this.txtMontoTotal.Text = "0";
            this.txtMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gridCompra
            // 
            this.gridCompra.DataSource = this.xpDetalleCompra;
            this.gridCompra.Location = new System.Drawing.Point(341, 64);
            this.gridCompra.MainView = this.gridViewCompra;
            this.gridCompra.Name = "gridCompra";
            this.gridCompra.Size = new System.Drawing.Size(857, 383);
            this.gridCompra.TabIndex = 12;
            this.gridCompra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCompra});
            // 
            // xpDetalleCompra
            // 
            this.xpDetalleCompra.ObjectType = typeof(Sistemaventa.Sistema_Venta.DetalleCompra);
            this.xpDetalleCompra.Session = this.SesionVenta;
            // 
            // SesionVenta
            // 
            this.SesionVenta.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.SesionVenta.TrackPropertiesModifications = false;
            // 
            // gridViewCompra
            // 
            this.gridViewCompra.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdDetalleCompra,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.colCantidad,
            this.colPrecioCompra,
            this.colSubTotal});
            this.gridViewCompra.GridControl = this.gridCompra;
            this.gridViewCompra.Name = "gridViewCompra";
            this.gridViewCompra.OptionsBehavior.Editable = false;
            this.gridViewCompra.Click += new System.EventHandler(this.gridViewCompra_Click);
            this.gridViewCompra.DoubleClick += new System.EventHandler(this.gridViewCompra_DoubleClick);
            // 
            // colIdDetalleCompra
            // 
            this.colIdDetalleCompra.FieldName = "IdDetalleCompra";
            this.colIdDetalleCompra.Name = "colIdDetalleCompra";
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "IdCompra!";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "IdCompra!Key";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "IdProd!";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Producto";
            this.gridColumn4.FieldName = "IdProd.Nombre";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // colCantidad
            // 
            this.colCantidad.AppearanceCell.Options.UseTextOptions = true;
            this.colCantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCantidad.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colCantidad.AppearanceHeader.Options.UseFont = true;
            this.colCantidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 1;
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
            this.colPrecioCompra.VisibleIndex = 2;
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
            this.colSubTotal.VisibleIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(12, 446);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(315, 35);
            this.btnCancelar.StyleController = this.layoutControl1;
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar Modificación";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Appearance.Options.UseFont = true;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(12, 404);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(315, 38);
            this.btnEliminar.StyleController = this.layoutControl1;
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Quitar registro";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Appearance.Options.UseFont = true;
            this.btnModificar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.ImageOptions.Image")));
            this.btnModificar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnModificar.Location = new System.Drawing.Point(12, 363);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(315, 37);
            this.btnModificar.StyleController = this.layoutControl1;
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.ImageOptions.Image")));
            this.btnAgregar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(12, 323);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(315, 36);
            this.btnAgregar.StyleController = this.layoutControl1;
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtSubTotal.Location = new System.Drawing.Point(127, 255);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(200, 20);
            this.txtSubTotal.TabIndex = 12;
            this.txtSubTotal.Text = "0";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.Appearance.Options.UseFont = true;
            this.btnCalcular.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.ImageOptions.Image")));
            this.btnCalcular.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnCalcular.Location = new System.Drawing.Point(12, 219);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(315, 22);
            this.btnCalcular.StyleController = this.layoutControl1;
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(127, 185);
            this.txtCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(200, 20);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidad.ValueChanged += new System.EventHandler(this.txtCantidad_ValueChanged);
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(127, 161);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(200, 20);
            this.txtPrecioCompra.TabIndex = 4;
            this.txtPrecioCompra.Text = "0";
            this.txtPrecioCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioCompra.Enter += new System.EventHandler(this.txtDocumento_Enter);
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Enabled = false;
            this.txtDocumento.Location = new System.Drawing.Point(127, 137);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(200, 20);
            this.txtDocumento.TabIndex = 3;
            this.txtDocumento.Enter += new System.EventHandler(this.txtDocumento_Enter);
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // comboBoxTipoDocumento
            // 
            this.comboBoxTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoDocumento.FormattingEnabled = true;
            this.comboBoxTipoDocumento.Items.AddRange(new object[] {
            "Factura",
            "Nota de Compra",
            "Recibos",
            "Otros"});
            this.comboBoxTipoDocumento.Location = new System.Drawing.Point(127, 112);
            this.comboBoxTipoDocumento.Name = "comboBoxTipoDocumento";
            this.comboBoxTipoDocumento.Size = new System.Drawing.Size(200, 21);
            this.comboBoxTipoDocumento.TabIndex = 2;
            // 
            // searchProducto
            // 
            this.searchProducto.Location = new System.Drawing.Point(127, 88);
            this.searchProducto.Name = "searchProducto";
            this.searchProducto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchProducto.Properties.DataSource = this.xpProducto;
            this.searchProducto.Properties.DisplayMember = "Nombre";
            this.searchProducto.Properties.PopupView = this.searchViewProducto;
            this.searchProducto.Properties.ValueMember = "IdProd";
            this.searchProducto.Size = new System.Drawing.Size(200, 20);
            this.searchProducto.StyleController = this.layoutControl1;
            this.searchProducto.TabIndex = 1;
            this.searchProducto.Popup += new System.EventHandler(this.searchProducto_Popup);
            // 
            // xpProducto
            // 
            this.xpProducto.ObjectType = typeof(Sistemaventa.Sistema_Venta.Producto);
            this.xpProducto.Session = this.SesionVenta;
            // 
            // searchViewProducto
            // 
            this.searchViewProducto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProd,
            this.colCodigo,
            this.colNombre,
            this.colDescripcion,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.colEstado,
            this.colImagenArticulo,
            this.colFechaVence,
            this.colFechaRegistro1});
            this.searchViewProducto.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchViewProducto.Name = "searchViewProducto";
            this.searchViewProducto.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchViewProducto.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.searchViewProducto.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProd
            // 
            this.colIdProd.FieldName = "IdProd";
            this.colIdProd.Name = "colIdProd";
            // 
            // colCodigo
            // 
            this.colCodigo.AppearanceCell.Options.UseTextOptions = true;
            this.colCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodigo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colCodigo.AppearanceHeader.Options.UseFont = true;
            this.colCodigo.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.AppearanceCell.Options.UseTextOptions = true;
            this.colNombre.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNombre.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNombre.AppearanceHeader.Options.UseFont = true;
            this.colNombre.AppearanceHeader.Options.UseTextOptions = true;
            this.colNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // colDescripcion
            // 
            this.colDescripcion.AppearanceCell.Options.UseTextOptions = true;
            this.colDescripcion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescripcion.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDescripcion.AppearanceHeader.Options.UseFont = true;
            this.colDescripcion.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "IdCateg!";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "Categoria";
            this.gridColumn6.FieldName = "IdCateg.NombreCateg";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "IdMarca!";
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
            this.gridColumn8.Caption = "Marca";
            this.gridColumn8.FieldName = "IdMarca.Nombre";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
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
            // colImagenArticulo
            // 
            this.colImagenArticulo.AppearanceCell.Options.UseTextOptions = true;
            this.colImagenArticulo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colImagenArticulo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colImagenArticulo.AppearanceHeader.Options.UseFont = true;
            this.colImagenArticulo.AppearanceHeader.Options.UseTextOptions = true;
            this.colImagenArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colImagenArticulo.FieldName = "ImagenArticulo";
            this.colImagenArticulo.Name = "colImagenArticulo";
            this.colImagenArticulo.Visible = true;
            this.colImagenArticulo.VisibleIndex = 6;
            // 
            // colFechaVence
            // 
            this.colFechaVence.AppearanceCell.Options.UseTextOptions = true;
            this.colFechaVence.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaVence.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colFechaVence.AppearanceHeader.Options.UseFont = true;
            this.colFechaVence.AppearanceHeader.Options.UseTextOptions = true;
            this.colFechaVence.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaVence.FieldName = "FechaVence";
            this.colFechaVence.Name = "colFechaVence";
            this.colFechaVence.Visible = true;
            this.colFechaVence.VisibleIndex = 7;
            // 
            // colFechaRegistro1
            // 
            this.colFechaRegistro1.AppearanceCell.Options.UseTextOptions = true;
            this.colFechaRegistro1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaRegistro1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colFechaRegistro1.AppearanceHeader.Options.UseFont = true;
            this.colFechaRegistro1.AppearanceHeader.Options.UseTextOptions = true;
            this.colFechaRegistro1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaRegistro1.FieldName = "FechaRegistro";
            this.colFechaRegistro1.Name = "colFechaRegistro1";
            this.colFechaRegistro1.Visible = true;
            this.colFechaRegistro1.VisibleIndex = 8;
            // 
            // searchProveedor
            // 
            this.searchProveedor.Location = new System.Drawing.Point(127, 64);
            this.searchProveedor.Name = "searchProveedor";
            this.searchProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchProveedor.Properties.DataSource = this.xpProveedor;
            this.searchProveedor.Properties.DisplayMember = "NombreProv";
            this.searchProveedor.Properties.PopupView = this.searchViewProveedor;
            this.searchProveedor.Properties.ValueMember = "IdProv";
            this.searchProveedor.Size = new System.Drawing.Size(200, 20);
            this.searchProveedor.StyleController = this.layoutControl1;
            this.searchProveedor.TabIndex = 0;
            this.searchProveedor.Popup += new System.EventHandler(this.searchProveedor_Popup);
            // 
            // xpProveedor
            // 
            this.xpProveedor.ObjectType = typeof(Sistemaventa.Sistema_Venta.Proveedor);
            this.xpProveedor.Session = this.SesionVenta;
            // 
            // searchViewProveedor
            // 
            this.searchViewProveedor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProv,
            this.colNombreProv,
            this.colDireccion,
            this.colDocumentoProv,
            this.colRazonSocialProv,
            this.colCorreoProv,
            this.colTelefonoProv,
            this.colEstadoProv,
            this.colLogotipo,
            this.colFechaRegistro});
            this.searchViewProveedor.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchViewProveedor.Name = "searchViewProveedor";
            this.searchViewProveedor.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchViewProveedor.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.searchViewProveedor.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProv
            // 
            this.colIdProv.FieldName = "IdProv";
            this.colIdProv.Name = "colIdProv";
            // 
            // colNombreProv
            // 
            this.colNombreProv.AppearanceCell.Options.UseTextOptions = true;
            this.colNombreProv.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNombreProv.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNombreProv.AppearanceHeader.Options.UseFont = true;
            this.colNombreProv.AppearanceHeader.Options.UseTextOptions = true;
            this.colNombreProv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNombreProv.FieldName = "NombreProv";
            this.colNombreProv.Name = "colNombreProv";
            this.colNombreProv.Visible = true;
            this.colNombreProv.VisibleIndex = 0;
            // 
            // colDireccion
            // 
            this.colDireccion.AppearanceCell.Options.UseTextOptions = true;
            this.colDireccion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDireccion.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDireccion.AppearanceHeader.Options.UseFont = true;
            this.colDireccion.AppearanceHeader.Options.UseTextOptions = true;
            this.colDireccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDireccion.FieldName = "Direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 1;
            // 
            // colDocumentoProv
            // 
            this.colDocumentoProv.AppearanceCell.Options.UseTextOptions = true;
            this.colDocumentoProv.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDocumentoProv.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDocumentoProv.AppearanceHeader.Options.UseFont = true;
            this.colDocumentoProv.AppearanceHeader.Options.UseTextOptions = true;
            this.colDocumentoProv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDocumentoProv.FieldName = "DocumentoProv";
            this.colDocumentoProv.Name = "colDocumentoProv";
            this.colDocumentoProv.Visible = true;
            this.colDocumentoProv.VisibleIndex = 2;
            // 
            // colRazonSocialProv
            // 
            this.colRazonSocialProv.AppearanceCell.Options.UseTextOptions = true;
            this.colRazonSocialProv.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRazonSocialProv.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colRazonSocialProv.AppearanceHeader.Options.UseFont = true;
            this.colRazonSocialProv.AppearanceHeader.Options.UseTextOptions = true;
            this.colRazonSocialProv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRazonSocialProv.FieldName = "RazonSocialProv";
            this.colRazonSocialProv.Name = "colRazonSocialProv";
            this.colRazonSocialProv.Visible = true;
            this.colRazonSocialProv.VisibleIndex = 3;
            // 
            // colCorreoProv
            // 
            this.colCorreoProv.AppearanceCell.Options.UseTextOptions = true;
            this.colCorreoProv.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCorreoProv.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colCorreoProv.AppearanceHeader.Options.UseFont = true;
            this.colCorreoProv.AppearanceHeader.Options.UseTextOptions = true;
            this.colCorreoProv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCorreoProv.FieldName = "CorreoProv";
            this.colCorreoProv.Name = "colCorreoProv";
            this.colCorreoProv.Visible = true;
            this.colCorreoProv.VisibleIndex = 4;
            // 
            // colTelefonoProv
            // 
            this.colTelefonoProv.AppearanceCell.Options.UseTextOptions = true;
            this.colTelefonoProv.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTelefonoProv.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTelefonoProv.AppearanceHeader.Options.UseFont = true;
            this.colTelefonoProv.AppearanceHeader.Options.UseTextOptions = true;
            this.colTelefonoProv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTelefonoProv.FieldName = "TelefonoProv";
            this.colTelefonoProv.Name = "colTelefonoProv";
            this.colTelefonoProv.Visible = true;
            this.colTelefonoProv.VisibleIndex = 5;
            // 
            // colEstadoProv
            // 
            this.colEstadoProv.AppearanceCell.Options.UseTextOptions = true;
            this.colEstadoProv.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEstadoProv.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colEstadoProv.AppearanceHeader.Options.UseFont = true;
            this.colEstadoProv.AppearanceHeader.Options.UseTextOptions = true;
            this.colEstadoProv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEstadoProv.FieldName = "EstadoProv";
            this.colEstadoProv.Name = "colEstadoProv";
            this.colEstadoProv.Visible = true;
            this.colEstadoProv.VisibleIndex = 6;
            // 
            // colLogotipo
            // 
            this.colLogotipo.AppearanceCell.Options.UseTextOptions = true;
            this.colLogotipo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLogotipo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colLogotipo.AppearanceHeader.Options.UseFont = true;
            this.colLogotipo.AppearanceHeader.Options.UseTextOptions = true;
            this.colLogotipo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLogotipo.FieldName = "Logotipo";
            this.colLogotipo.Name = "colLogotipo";
            this.colLogotipo.Visible = true;
            this.colLogotipo.VisibleIndex = 7;
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
            this.colFechaRegistro.VisibleIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(207)))), ((int)(((byte)(173)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1186, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registro de Compras";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem12,
            this.layoutControlItem13,
            this.emptySpaceItem4,
            this.layoutControlItem7,
            this.emptySpaceItem3,
            this.emptySpaceItem6,
            this.emptySpaceItem7,
            this.emptySpaceItem8,
            this.emptySpaceItem2,
            this.layoutControlItem14,
            this.layoutControlItem15,
            this.emptySpaceItem1,
            this.emptySpaceItem5,
            this.layoutControlItem16,
            this.emptySpaceItem9});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1210, 517);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.label1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1190, 42);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.searchProveedor;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(319, 24);
            this.layoutControlItem2.Text = "Proveedor:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(112, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.searchProducto;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 76);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(319, 24);
            this.layoutControlItem3.Text = "Producto:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(112, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.comboBoxTipoDocumento;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 100);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(319, 25);
            this.layoutControlItem4.Text = "Tipo de Documento:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(112, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.txtDocumento;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 125);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(319, 24);
            this.layoutControlItem5.Text = "Número Factura:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(112, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.txtPrecioCompra;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 149);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(319, 24);
            this.layoutControlItem6.Text = "Precio Compra:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(112, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnCalcular;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 207);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(51, 26);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(319, 26);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem9.AppearanceItemCaption.ForeColor = System.Drawing.Color.LimeGreen;
            this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem9.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem9.Control = this.txtSubTotal;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 243);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(319, 24);
            this.layoutControlItem9.Text = "Subtotal:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(112, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnAgregar;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 311);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(319, 40);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnModificar;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 351);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(319, 41);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.btnEliminar;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 392);
            this.layoutControlItem12.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(319, 42);
            this.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.btnCancelar;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 434);
            this.layoutControlItem13.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(319, 39);
            this.layoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(319, 52);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(10, 445);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.Control = this.txtCantidad;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 173);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(319, 24);
            this.layoutControlItem7.Text = "Cantidad (Stock):";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(112, 13);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 301);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(319, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(0, 233);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(319, 10);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(0, 197);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(319, 10);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.Location = new System.Drawing.Point(329, 449);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(539, 48);
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 42);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(1190, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.gridCompra;
            this.layoutControlItem14.Location = new System.Drawing.Point(329, 52);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(861, 387);
            this.layoutControlItem14.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem14.TextVisible = false;
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem15.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.layoutControlItem15.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem15.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem15.Control = this.txtMontoTotal;
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 277);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(319, 24);
            this.layoutControlItem15.Text = "Monto total:";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(112, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 267);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(319, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 473);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(319, 24);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.btnGuardar;
            this.layoutControlItem16.Location = new System.Drawing.Point(868, 449);
            this.layoutControlItem16.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(322, 48);
            this.layoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem16.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem16.TextVisible = false;
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.AllowHotTrack = false;
            this.emptySpaceItem9.Location = new System.Drawing.Point(329, 439);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Size = new System.Drawing.Size(861, 10);
            this.emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // xpCompra
            // 
            this.xpCompra.ObjectType = typeof(Sistemaventa.Sistema_Venta.Compra);
            this.xpCompra.Session = this.SesionVenta;
            // 
            // xpEmpleado
            // 
            this.xpEmpleado.ObjectType = typeof(Sistemaventa.Sistema_Venta.Empleado);
            this.xpEmpleado.Session = this.SesionVenta;
            // 
            // FormCompra
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1210, 517);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCompra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.FormCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpDetalleCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SesionVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnModificar;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private System.Windows.Forms.TextBox txtSubTotal;
        private DevExpress.XtraEditors.SimpleButton btnCalcular;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.ComboBox comboBoxTipoDocumento;
        private DevExpress.XtraEditors.SearchLookUpEdit searchProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView searchViewProducto;
        private DevExpress.XtraEditors.SearchLookUpEdit searchProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView searchViewProveedor;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraGrid.GridControl gridCompra;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCompra;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.Xpo.UnitOfWork SesionVenta;
        private DevExpress.Xpo.XPCollection xpCompra;
        private DevExpress.Xpo.XPCollection xpDetalleCompra;
        private DevExpress.Xpo.XPCollection xpProveedor;
        private DevExpress.Xpo.XPCollection xpProducto;
        private DevExpress.Xpo.XPCollection xpEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProd;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colImagenArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaVence;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRegistro1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProv;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreProv;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentoProv;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocialProv;
        private DevExpress.XtraGrid.Columns.GridColumn colCorreoProv;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefonoProv;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoProv;
        private DevExpress.XtraGrid.Columns.GridColumn colLogotipo;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDetalleCompra;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotal;
    }
}