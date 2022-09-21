namespace Sistemaventa.EstadoSistema
{
    partial class FormEstadoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstadoProducto));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnModificar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.gridEstadoProducto = new DevExpress.XtraGrid.GridControl();
            this.xpEstadoProducto = new DevExpress.Xpo.XPCollection(this.components);
            this.gridViewEstadoProducto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.searchEstadoProducto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpProducto = new DevExpress.Xpo.XPCollection(this.components);
            this.searchViewEstadoProducto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.SesionVenta = new DevExpress.Xpo.UnitOfWork(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEstadoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEstadoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEstadoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchEstadoProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewEstadoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SesionVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnModificar);
            this.layoutControl1.Controls.Add(this.btnGuardar);
            this.layoutControl1.Controls.Add(this.gridEstadoProducto);
            this.layoutControl1.Controls.Add(this.btnCancelar);
            this.layoutControl1.Controls.Add(this.comboBoxEstado);
            this.layoutControl1.Controls.Add(this.searchEstadoProducto);
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
            // btnModificar
            // 
            this.btnModificar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Appearance.Options.UseFont = true;
            this.btnModificar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.ImageOptions.Image")));
            this.btnModificar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnModificar.Location = new System.Drawing.Point(451, 103);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(368, 40);
            this.btnModificar.StyleController = this.layoutControl1;
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(34, 103);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(403, 40);
            this.btnGuardar.StyleController = this.layoutControl1;
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            // 
            // gridEstadoProducto
            // 
            this.gridEstadoProducto.DataSource = this.xpEstadoProducto;
            this.gridEstadoProducto.Location = new System.Drawing.Point(12, 157);
            this.gridEstadoProducto.MainView = this.gridViewEstadoProducto;
            this.gridEstadoProducto.Name = "gridEstadoProducto";
            this.gridEstadoProducto.Size = new System.Drawing.Size(1186, 348);
            this.gridEstadoProducto.TabIndex = 9;
            this.gridEstadoProducto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEstadoProducto});
            // 
            // xpEstadoProducto
            // 
            this.xpEstadoProducto.Session = this.SesionVenta;
            // 
            // gridViewEstadoProducto
            // 
            this.gridViewEstadoProducto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.gridColumn1,
            this.gridColumn2,
            this.colEstado,
            this.colFecha});
            this.gridViewEstadoProducto.GridControl = this.gridEstadoProducto;
            this.gridViewEstadoProducto.Name = "gridViewEstadoProducto";
            this.gridViewEstadoProducto.OptionsBehavior.Editable = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "IdProducto!";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "IdProducto!Key";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 3;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(833, 103);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(344, 40);
            this.btnCancelar.StyleController = this.layoutControl1;
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(799, 68);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(399, 21);
            this.comboBoxEstado.TabIndex = 6;
            // 
            // searchEstadoProducto
            // 
            this.searchEstadoProducto.Location = new System.Drawing.Point(75, 68);
            this.searchEstadoProducto.Name = "searchEstadoProducto";
            this.searchEstadoProducto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchEstadoProducto.Properties.DataSource = this.xpProducto;
            this.searchEstadoProducto.Properties.DisplayMember = "Nombre";
            this.searchEstadoProducto.Properties.PopupView = this.searchViewEstadoProducto;
            this.searchEstadoProducto.Properties.ValueMember = "IdProd";
            this.searchEstadoProducto.Size = new System.Drawing.Size(647, 20);
            this.searchEstadoProducto.StyleController = this.layoutControl1;
            this.searchEstadoProducto.TabIndex = 5;
            // 
            // xpProducto
            // 
            this.xpProducto.Session = this.SesionVenta;
            // 
            // searchViewEstadoProducto
            // 
            this.searchViewEstadoProducto.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchViewEstadoProducto.Name = "searchViewEstadoProducto";
            this.searchViewEstadoProducto.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchViewEstadoProducto.OptionsView.ShowGroupPanel = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(207)))), ((int)(((byte)(173)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1186, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estado de los productos";
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
            this.emptySpaceItem4,
            this.layoutControlItem5,
            this.emptySpaceItem6,
            this.emptySpaceItem7,
            this.layoutControlItem3,
            this.emptySpaceItem3,
            this.emptySpaceItem8,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.emptySpaceItem5});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1210, 517);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.label1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1190, 46);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 46);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(1190, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.searchEstadoProducto;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(714, 25);
            this.layoutControlItem2.Text = "Productos:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 13);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 81);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(1190, 10);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnCancelar;
            this.layoutControlItem5.Location = new System.Drawing.Point(821, 91);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(0, 44);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(80, 44);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(348, 44);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(0, 91);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(22, 44);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(1169, 91);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(21, 44);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.comboBoxEstado;
            this.layoutControlItem3.Location = new System.Drawing.Point(724, 56);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(466, 25);
            this.layoutControlItem3.Text = "Estado:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(60, 13);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(714, 56);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(10, 25);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.Location = new System.Drawing.Point(0, 135);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(1190, 10);
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gridEstadoProducto;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 145);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(1190, 352);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnGuardar;
            this.layoutControlItem7.Location = new System.Drawing.Point(22, 91);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(407, 44);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(429, 91);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 44);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnModificar;
            this.layoutControlItem4.Location = new System.Drawing.Point(439, 91);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(372, 44);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(811, 91);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(10, 44);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // SesionVenta
            // 
            this.SesionVenta.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.SesionVenta.TrackPropertiesModifications = false;
            // 
            // FormEstadoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 517);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEstadoProducto";
            this.Text = "Estado Producto";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEstadoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEstadoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEstadoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchEstadoProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewEstadoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SesionVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridEstadoProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEstadoProducto;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private DevExpress.XtraEditors.SearchLookUpEdit searchEstadoProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView searchViewEstadoProducto;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.Xpo.UnitOfWork SesionVenta;
        private DevExpress.Xpo.XPCollection xpEstadoProducto;
        private DevExpress.Xpo.XPCollection xpProducto;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnModificar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
    }
}