namespace Sistemaventa.Forms
{
    partial class FormEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleado));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.checkBoxMostrar = new System.Windows.Forms.CheckBox();
            this.gridEmpleado = new DevExpress.XtraGrid.GridControl();
            this.xpEmpleado = new DevExpress.Xpo.XPCollection(this.components);
            this.SesionVenta = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridViewEmpleado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombre_Completo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSexo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCelular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreAcceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContrasena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnModificar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.searchRol = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.contextMenuStripClickRigth = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xpRol = new DevExpress.Xpo.XPCollection(this.components);
            this.searchViewRol = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdRol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreRol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuRol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuMantenimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuAlmacen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuReporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaRegistro1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.xpTema = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SesionVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchRol.Properties)).BeginInit();
            this.contextMenuStripClickRigth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpTema)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.checkBoxMostrar);
            this.layoutControl1.Controls.Add(this.gridEmpleado);
            this.layoutControl1.Controls.Add(this.pictureBoxFoto);
            this.layoutControl1.Controls.Add(this.btnCancelar);
            this.layoutControl1.Controls.Add(this.btnModificar);
            this.layoutControl1.Controls.Add(this.btnGuardar);
            this.layoutControl1.Controls.Add(this.btnNuevo);
            this.layoutControl1.Controls.Add(this.comboBoxEstado);
            this.layoutControl1.Controls.Add(this.searchRol);
            this.layoutControl1.Controls.Add(this.txtContraseña);
            this.layoutControl1.Controls.Add(this.txtUsuario);
            this.layoutControl1.Controls.Add(this.txtCorreo);
            this.layoutControl1.Controls.Add(this.txtDireccion);
            this.layoutControl1.Controls.Add(this.comboBoxSexo);
            this.layoutControl1.Controls.Add(this.txtApellido);
            this.layoutControl1.Controls.Add(this.txtNombre);
            this.layoutControl1.Controls.Add(this.txtCelular);
            this.layoutControl1.Controls.Add(this.txtCedula);
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
            // checkBoxMostrar
            // 
            this.checkBoxMostrar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxMostrar.Location = new System.Drawing.Point(330, 283);
            this.checkBoxMostrar.Name = "checkBoxMostrar";
            this.checkBoxMostrar.Size = new System.Drawing.Size(20, 20);
            this.checkBoxMostrar.TabIndex = 22;
            this.checkBoxMostrar.UseVisualStyleBackColor = true;
            this.checkBoxMostrar.CheckedChanged += new System.EventHandler(this.checkBoxMostrar_CheckedChanged);
            // 
            // gridEmpleado
            // 
            this.gridEmpleado.DataSource = this.xpEmpleado;
            this.gridEmpleado.Location = new System.Drawing.Point(364, 66);
            this.gridEmpleado.MainView = this.gridViewEmpleado;
            this.gridEmpleado.Name = "gridEmpleado";
            this.gridEmpleado.Size = new System.Drawing.Size(834, 439);
            this.gridEmpleado.TabIndex = 15;
            this.gridEmpleado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmpleado});
            // 
            // xpEmpleado
            // 
            this.xpEmpleado.ObjectType = typeof(Sistemaventa.Sistema_Venta.Empleado);
            this.xpEmpleado.Session = this.SesionVenta;
            // 
            // SesionVenta
            // 
            this.SesionVenta.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.SesionVenta.OptimisticLockingReadBehavior = DevExpress.Xpo.OptimisticLockingReadBehavior.ReloadObject;
            this.SesionVenta.TrackPropertiesModifications = false;
            // 
            // gridViewEmpleado
            // 
            this.gridViewEmpleado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombre_Completo,
            this.colId,
            this.colNombre,
            this.colApellido,
            this.colSexo,
            this.colCedula,
            this.colCelular,
            this.colDireccion,
            this.colCorreo,
            this.colNombreAcceso,
            this.colContrasena,
            this.gridColumn1,
            this.gridColumn2,
            this.colEstado,
            this.gridColumn3,
            this.gridColumn4,
            this.colFoto,
            this.colFechaRegistro,
            this.gridColumn5});
            this.gridViewEmpleado.GridControl = this.gridEmpleado;
            this.gridViewEmpleado.Name = "gridViewEmpleado";
            this.gridViewEmpleado.OptionsBehavior.Editable = false;
            this.gridViewEmpleado.OptionsFind.AlwaysVisible = true;
            this.gridViewEmpleado.DoubleClick += new System.EventHandler(this.gridViewEmpleado_DoubleClick);
            // 
            // colNombre_Completo
            // 
            this.colNombre_Completo.FieldName = "Nombre_Completo";
            this.colNombre_Completo.Name = "colNombre_Completo";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
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
            this.colNombre.VisibleIndex = 0;
            // 
            // colApellido
            // 
            this.colApellido.AppearanceCell.Options.UseTextOptions = true;
            this.colApellido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colApellido.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colApellido.AppearanceHeader.Options.UseFont = true;
            this.colApellido.AppearanceHeader.Options.UseTextOptions = true;
            this.colApellido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colApellido.FieldName = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.Visible = true;
            this.colApellido.VisibleIndex = 1;
            // 
            // colSexo
            // 
            this.colSexo.AppearanceCell.Options.UseTextOptions = true;
            this.colSexo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSexo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSexo.AppearanceHeader.Options.UseFont = true;
            this.colSexo.AppearanceHeader.Options.UseTextOptions = true;
            this.colSexo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSexo.FieldName = "Sexo";
            this.colSexo.Name = "colSexo";
            this.colSexo.Visible = true;
            this.colSexo.VisibleIndex = 2;
            // 
            // colCedula
            // 
            this.colCedula.AppearanceCell.Options.UseTextOptions = true;
            this.colCedula.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCedula.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colCedula.AppearanceHeader.Options.UseFont = true;
            this.colCedula.AppearanceHeader.Options.UseTextOptions = true;
            this.colCedula.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCedula.FieldName = "Cedula";
            this.colCedula.Name = "colCedula";
            this.colCedula.Visible = true;
            this.colCedula.VisibleIndex = 3;
            // 
            // colCelular
            // 
            this.colCelular.AppearanceCell.Options.UseTextOptions = true;
            this.colCelular.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCelular.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colCelular.AppearanceHeader.Options.UseFont = true;
            this.colCelular.AppearanceHeader.Options.UseTextOptions = true;
            this.colCelular.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCelular.FieldName = "Celular";
            this.colCelular.Name = "colCelular";
            this.colCelular.Visible = true;
            this.colCelular.VisibleIndex = 4;
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
            this.colDireccion.VisibleIndex = 5;
            // 
            // colCorreo
            // 
            this.colCorreo.AppearanceCell.Options.UseTextOptions = true;
            this.colCorreo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCorreo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colCorreo.AppearanceHeader.Options.UseFont = true;
            this.colCorreo.AppearanceHeader.Options.UseTextOptions = true;
            this.colCorreo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCorreo.FieldName = "Correo";
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.Visible = true;
            this.colCorreo.VisibleIndex = 6;
            // 
            // colNombreAcceso
            // 
            this.colNombreAcceso.FieldName = "NombreAcceso";
            this.colNombreAcceso.Name = "colNombreAcceso";
            // 
            // colContrasena
            // 
            this.colContrasena.FieldName = "Contrasena";
            this.colContrasena.Name = "colContrasena";
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "IdRol!";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Rol";
            this.gridColumn2.FieldName = "IdRol.NombreRol";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
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
            this.colEstado.VisibleIndex = 8;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "IdTema!";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "IdTema!Key";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // colFoto
            // 
            this.colFoto.AppearanceCell.Options.UseTextOptions = true;
            this.colFoto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFoto.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colFoto.AppearanceHeader.Options.UseFont = true;
            this.colFoto.AppearanceHeader.Options.UseTextOptions = true;
            this.colFoto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFoto.FieldName = "Foto";
            this.colFoto.Name = "colFoto";
            this.colFoto.Visible = true;
            this.colFoto.VisibleIndex = 9;
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
            this.colFechaRegistro.VisibleIndex = 10;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "IdRol.NombreRol";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Image = global::Sistemaventa.Properties.Resources.subir;
            this.pictureBoxFoto.Location = new System.Drawing.Point(212, 82);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(138, 100);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFoto.TabIndex = 20;
            this.pictureBoxFoto.TabStop = false;
            this.pictureBoxFoto.Click += new System.EventHandler(this.pictureBoxFoto_Click);
            this.pictureBoxFoto.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBoxFoto_DragDrop);
            this.pictureBoxFoto.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBoxFoto_DragEnter);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(12, 472);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(338, 33);
            this.btnCancelar.StyleController = this.layoutControl1;
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Appearance.Options.UseFont = true;
            this.btnModificar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.ImageOptions.Image")));
            this.btnModificar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnModificar.Location = new System.Drawing.Point(12, 438);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(338, 30);
            this.btnModificar.StyleController = this.layoutControl1;
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(12, 404);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(338, 30);
            this.btnGuardar.StyleController = this.layoutControl1;
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.Appearance.Options.UseFont = true;
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnNuevo.Location = new System.Drawing.Point(12, 366);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(338, 34);
            this.btnNuevo.StyleController = this.layoutControl1;
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBoxEstado.Location = new System.Drawing.Point(107, 331);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(243, 21);
            this.comboBoxEstado.TabIndex = 10;
            // 
            // searchRol
            // 
            this.searchRol.Location = new System.Drawing.Point(107, 307);
            this.searchRol.Name = "searchRol";
            this.searchRol.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchRol.Properties.ContextMenuStrip = this.contextMenuStripClickRigth;
            this.searchRol.Properties.DataSource = this.xpRol;
            this.searchRol.Properties.DisplayMember = "NombreRol";
            this.searchRol.Properties.PopupView = this.searchViewRol;
            this.searchRol.Properties.ValueMember = "IdRol";
            this.searchRol.Size = new System.Drawing.Size(243, 20);
            this.searchRol.StyleController = this.layoutControl1;
            this.searchRol.TabIndex = 9;
            this.searchRol.EditValueChanged += new System.EventHandler(this.searchRol_EditValueChanged);
            // 
            // contextMenuStripClickRigth
            // 
            this.contextMenuStripClickRigth.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarToolStripMenuItem});
            this.contextMenuStripClickRigth.Name = "contextMenuStripClickRigth";
            this.contextMenuStripClickRigth.Size = new System.Drawing.Size(127, 26);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // xpRol
            // 
            this.xpRol.ObjectType = typeof(Sistemaventa.Sistema_Venta.Rol);
            this.xpRol.Session = this.SesionVenta;
            // 
            // searchViewRol
            // 
            this.searchViewRol.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdRol,
            this.colNombreRol,
            this.colMenuRol,
            this.colMenuEmpleado,
            this.colMenuMantenimiento,
            this.colMenuAlmacen,
            this.colMenuCompra,
            this.colMenuVenta,
            this.colMenuEstado,
            this.colMenuReporte,
            this.colFechaRegistro1});
            this.searchViewRol.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchViewRol.Name = "searchViewRol";
            this.searchViewRol.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchViewRol.OptionsView.ShowGroupPanel = false;
            // 
            // colIdRol
            // 
            this.colIdRol.FieldName = "IdRol";
            this.colIdRol.Name = "colIdRol";
            // 
            // colNombreRol
            // 
            this.colNombreRol.AppearanceCell.Options.UseTextOptions = true;
            this.colNombreRol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNombreRol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNombreRol.AppearanceHeader.Options.UseFont = true;
            this.colNombreRol.AppearanceHeader.Options.UseTextOptions = true;
            this.colNombreRol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNombreRol.FieldName = "NombreRol";
            this.colNombreRol.Name = "colNombreRol";
            this.colNombreRol.Visible = true;
            this.colNombreRol.VisibleIndex = 0;
            // 
            // colMenuRol
            // 
            this.colMenuRol.AppearanceCell.Options.UseTextOptions = true;
            this.colMenuRol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMenuRol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMenuRol.AppearanceHeader.Options.UseFont = true;
            this.colMenuRol.AppearanceHeader.Options.UseTextOptions = true;
            this.colMenuRol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMenuRol.FieldName = "MenuRol";
            this.colMenuRol.Name = "colMenuRol";
            this.colMenuRol.Visible = true;
            this.colMenuRol.VisibleIndex = 1;
            // 
            // colMenuEmpleado
            // 
            this.colMenuEmpleado.AppearanceCell.Options.UseTextOptions = true;
            this.colMenuEmpleado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMenuEmpleado.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMenuEmpleado.AppearanceHeader.Options.UseFont = true;
            this.colMenuEmpleado.AppearanceHeader.Options.UseTextOptions = true;
            this.colMenuEmpleado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMenuEmpleado.FieldName = "MenuEmpleado";
            this.colMenuEmpleado.Name = "colMenuEmpleado";
            this.colMenuEmpleado.Visible = true;
            this.colMenuEmpleado.VisibleIndex = 2;
            // 
            // colMenuMantenimiento
            // 
            this.colMenuMantenimiento.AppearanceCell.Options.UseTextOptions = true;
            this.colMenuMantenimiento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMenuMantenimiento.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMenuMantenimiento.AppearanceHeader.Options.UseFont = true;
            this.colMenuMantenimiento.AppearanceHeader.Options.UseTextOptions = true;
            this.colMenuMantenimiento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMenuMantenimiento.FieldName = "MenuMantenimiento";
            this.colMenuMantenimiento.Name = "colMenuMantenimiento";
            this.colMenuMantenimiento.Visible = true;
            this.colMenuMantenimiento.VisibleIndex = 3;
            // 
            // colMenuAlmacen
            // 
            this.colMenuAlmacen.AppearanceCell.Options.UseTextOptions = true;
            this.colMenuAlmacen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMenuAlmacen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMenuAlmacen.AppearanceHeader.Options.UseFont = true;
            this.colMenuAlmacen.AppearanceHeader.Options.UseTextOptions = true;
            this.colMenuAlmacen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMenuAlmacen.FieldName = "MenuAlmacen";
            this.colMenuAlmacen.Name = "colMenuAlmacen";
            this.colMenuAlmacen.Visible = true;
            this.colMenuAlmacen.VisibleIndex = 4;
            // 
            // colMenuCompra
            // 
            this.colMenuCompra.AppearanceCell.Options.UseTextOptions = true;
            this.colMenuCompra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMenuCompra.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMenuCompra.AppearanceHeader.Options.UseFont = true;
            this.colMenuCompra.AppearanceHeader.Options.UseTextOptions = true;
            this.colMenuCompra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMenuCompra.FieldName = "MenuCompra";
            this.colMenuCompra.Name = "colMenuCompra";
            this.colMenuCompra.Visible = true;
            this.colMenuCompra.VisibleIndex = 5;
            // 
            // colMenuVenta
            // 
            this.colMenuVenta.AppearanceCell.Options.UseTextOptions = true;
            this.colMenuVenta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMenuVenta.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMenuVenta.AppearanceHeader.Options.UseFont = true;
            this.colMenuVenta.AppearanceHeader.Options.UseTextOptions = true;
            this.colMenuVenta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMenuVenta.FieldName = "MenuVenta";
            this.colMenuVenta.Name = "colMenuVenta";
            this.colMenuVenta.Visible = true;
            this.colMenuVenta.VisibleIndex = 6;
            // 
            // colMenuEstado
            // 
            this.colMenuEstado.AppearanceCell.Options.UseTextOptions = true;
            this.colMenuEstado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMenuEstado.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMenuEstado.AppearanceHeader.Options.UseFont = true;
            this.colMenuEstado.AppearanceHeader.Options.UseTextOptions = true;
            this.colMenuEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMenuEstado.FieldName = "MenuEstado";
            this.colMenuEstado.Name = "colMenuEstado";
            this.colMenuEstado.Visible = true;
            this.colMenuEstado.VisibleIndex = 7;
            // 
            // colMenuReporte
            // 
            this.colMenuReporte.AppearanceCell.Options.UseTextOptions = true;
            this.colMenuReporte.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMenuReporte.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMenuReporte.AppearanceHeader.Options.UseFont = true;
            this.colMenuReporte.AppearanceHeader.Options.UseTextOptions = true;
            this.colMenuReporte.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMenuReporte.FieldName = "MenuReporte";
            this.colMenuReporte.Name = "colMenuReporte";
            this.colMenuReporte.Visible = true;
            this.colMenuReporte.VisibleIndex = 8;
            // 
            // colFechaRegistro1
            // 
            this.colFechaRegistro1.FieldName = "FechaRegistro";
            this.colFechaRegistro1.Name = "colFechaRegistro1";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(107, 283);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(219, 20);
            this.txtContraseña.TabIndex = 8;
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.Enter += new System.EventHandler(this.txtNombre_Enter);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(107, 259);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(243, 20);
            this.txtUsuario.TabIndex = 7;
            this.txtUsuario.Enter += new System.EventHandler(this.txtNombre_Enter);
            // 
            // txtCorreo
            // 
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCorreo.Location = new System.Drawing.Point(107, 235);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(243, 20);
            this.txtCorreo.TabIndex = 6;
            this.txtCorreo.Enter += new System.EventHandler(this.txtNombre_Enter);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(107, 211);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(243, 20);
            this.txtDireccion.TabIndex = 5;
            this.txtDireccion.Enter += new System.EventHandler(this.txtNombre_Enter);
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.comboBoxSexo.Location = new System.Drawing.Point(107, 186);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(243, 21);
            this.comboBoxSexo.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(107, 162);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(101, 20);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 138);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(101, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(107, 114);
            this.txtCelular.Mask = "0000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(101, 20);
            this.txtCelular.TabIndex = 1;
            this.txtCelular.Enter += new System.EventHandler(this.txtCedula_Enter);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(107, 90);
            this.txtCedula.Mask = "000-000000-0000>L";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(101, 20);
            this.txtCedula.TabIndex = 0;
            this.txtCedula.Enter += new System.EventHandler(this.txtCedula_Enter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(207)))), ((int)(((byte)(173)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1186, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista de Empleados";
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
            this.layoutControlItem5,
            this.layoutControlItem11,
            this.layoutControlItem12,
            this.layoutControlItem13,
            this.layoutControlItem14,
            this.layoutControlItem15,
            this.layoutControlItem16,
            this.emptySpaceItem3,
            this.layoutControlItem17,
            this.layoutControlItem18,
            this.layoutControlItem19,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem6,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem4,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1210, 517);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.label1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1190, 44);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 44);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(1190, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txtCedula;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem2.Text = "Cedula de Ident:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(92, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.txtApellido;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 150);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem5.Text = "1er Apellido:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(92, 13);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem11.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem11.Control = this.searchRol;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 295);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(342, 24);
            this.layoutControlItem11.Text = "Rol:";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(92, 13);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem12.Control = this.comboBoxEstado;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 319);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(342, 25);
            this.layoutControlItem12.Text = "Estado:";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(92, 13);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.btnNuevo;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 354);
            this.layoutControlItem13.MaxSize = new System.Drawing.Size(0, 38);
            this.layoutControlItem13.MinSize = new System.Drawing.Size(80, 38);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(342, 38);
            this.layoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextVisible = false;
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.btnGuardar;
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 392);
            this.layoutControlItem14.MaxSize = new System.Drawing.Size(0, 34);
            this.layoutControlItem14.MinSize = new System.Drawing.Size(80, 34);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(342, 34);
            this.layoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem14.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem14.TextVisible = false;
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.btnModificar;
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 426);
            this.layoutControlItem15.MaxSize = new System.Drawing.Size(0, 34);
            this.layoutControlItem15.MinSize = new System.Drawing.Size(80, 34);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(342, 34);
            this.layoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem15.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem15.TextVisible = false;
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.btnCancelar;
            this.layoutControlItem16.Location = new System.Drawing.Point(0, 460);
            this.layoutControlItem16.MaxSize = new System.Drawing.Size(0, 37);
            this.layoutControlItem16.MinSize = new System.Drawing.Size(80, 37);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(342, 37);
            this.layoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem16.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem16.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 344);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(342, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem17.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem17.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem17.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem17.Control = this.pictureBoxFoto;
            this.layoutControlItem17.Location = new System.Drawing.Point(200, 54);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(142, 120);
            this.layoutControlItem17.Text = "Agregar Foto";
            this.layoutControlItem17.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem17.TextSize = new System.Drawing.Size(92, 13);
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.gridEmpleado;
            this.layoutControlItem18.Location = new System.Drawing.Point(352, 54);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(838, 443);
            this.layoutControlItem18.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem18.TextVisible = false;
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.checkBoxMostrar;
            this.layoutControlItem19.Location = new System.Drawing.Point(318, 271);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(24, 24);
            this.layoutControlItem19.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem19.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem9.Control = this.txtUsuario;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 247);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(342, 24);
            this.layoutControlItem9.Text = "Acceso (Login):";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(92, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem10.Control = this.txtContraseña;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 271);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(318, 24);
            this.layoutControlItem10.Text = "Contraseña:";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(92, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.comboBoxSexo;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 174);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(342, 25);
            this.layoutControlItem6.Text = "Sexo:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(92, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.txtNombre;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 126);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.Text = "1er Nombre:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(92, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.txtCelular;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 102);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.Text = "Celular:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(92, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.Control = this.txtDireccion;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 199);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(342, 24);
            this.layoutControlItem7.Text = "Dirección:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(92, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem8.Control = this.txtCorreo;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 223);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(342, 24);
            this.layoutControlItem8.Text = "Correo:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(92, 13);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(342, 54);
            this.emptySpaceItem4.MaxSize = new System.Drawing.Size(10, 0);
            this.emptySpaceItem4.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(10, 443);
            this.emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 54);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(200, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // xpTema
            // 
            this.xpTema.ObjectType = typeof(Sistemaventa.Sistema_Venta.Tema);
            this.xpTema.Session = this.SesionVenta;
            // 
            // FormEmpleado
            // 
            this.AcceptButton = this.btnNuevo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1210, 517);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEmpleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.FormEmpleado_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormEmpleado_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SesionVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchRol.Properties)).EndInit();
            this.contextMenuStripClickRigth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xpRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpTema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnModificar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private DevExpress.XtraEditors.SearchLookUpEdit searchRol;
        private DevExpress.XtraGrid.Views.Grid.GridView searchViewRol;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtCedula;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraGrid.GridControl gridEmpleado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmpleado;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.Xpo.UnitOfWork SesionVenta;
        private DevExpress.Xpo.XPCollection xpEmpleado;
        private DevExpress.Xpo.XPCollection xpRol;
        private DevExpress.Xpo.XPCollection xpTema;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRol;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreRol;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuRol;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuMantenimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuAlmacen;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuReporte;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRegistro1;
        private System.Windows.Forms.CheckBox checkBoxMostrar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre_Completo;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colSexo;
        private DevExpress.XtraGrid.Columns.GridColumn colCedula;
        private DevExpress.XtraGrid.Columns.GridColumn colCelular;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colCorreo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreAcceso;
        private DevExpress.XtraGrid.Columns.GridColumn colContrasena;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colFoto;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripClickRigth;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
    }
}