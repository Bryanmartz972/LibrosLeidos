
namespace LibrosLeidos
{
    partial class FrmVisualizarLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisualizarLibros));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIngresarLibro = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLibrosLeidos = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.txtBuscarLibro = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clsIngresoDatosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clsIngresoDatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroidanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrelibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreautorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sagaserietrilogiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerosagaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoleidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrosLeidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsIngresoDatosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsIngresoDatosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibrosLeidos.Properties.Resources.flecha_izquierda;
            this.pictureBox1.Location = new System.Drawing.Point(1121, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 21);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnIngresarLibro
            // 
            this.btnIngresarLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresarLibro.Location = new System.Drawing.Point(935, 18);
            this.btnIngresarLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresarLibro.Name = "btnIngresarLibro";
            this.btnIngresarLibro.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnIngresarLibro.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnIngresarLibro.OverrideDefault.Back.ColorAngle = 45F;
            this.btnIngresarLibro.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnIngresarLibro.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnIngresarLibro.OverrideDefault.Border.ColorAngle = 45F;
            this.btnIngresarLibro.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnIngresarLibro.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnIngresarLibro.OverrideDefault.Border.Rounding = 10;
            this.btnIngresarLibro.OverrideDefault.Border.Width = 1;
            this.btnIngresarLibro.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnIngresarLibro.Size = new System.Drawing.Size(229, 43);
            this.btnIngresarLibro.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnIngresarLibro.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnIngresarLibro.StateCommon.Back.ColorAngle = 45F;
            this.btnIngresarLibro.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnIngresarLibro.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnIngresarLibro.StateCommon.Border.ColorAngle = 45F;
            this.btnIngresarLibro.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnIngresarLibro.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnIngresarLibro.StateCommon.Border.Rounding = 10;
            this.btnIngresarLibro.StateCommon.Border.Width = 1;
            this.btnIngresarLibro.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.btnIngresarLibro.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.btnIngresarLibro.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarLibro.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnIngresarLibro.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnIngresarLibro.StatePressed.Back.ColorAngle = 135F;
            this.btnIngresarLibro.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnIngresarLibro.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnIngresarLibro.StatePressed.Border.ColorAngle = 135F;
            this.btnIngresarLibro.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnIngresarLibro.StatePressed.Border.Rounding = 10;
            this.btnIngresarLibro.StatePressed.Border.Width = 1;
            this.btnIngresarLibro.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnIngresarLibro.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnIngresarLibro.StateTracking.Back.ColorAngle = 45F;
            this.btnIngresarLibro.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnIngresarLibro.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnIngresarLibro.StateTracking.Border.ColorAngle = 45F;
            this.btnIngresarLibro.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnIngresarLibro.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnIngresarLibro.StateTracking.Border.Rounding = 10;
            this.btnIngresarLibro.StateTracking.Border.Width = 1;
            this.btnIngresarLibro.TabIndex = 16;
            this.btnIngresarLibro.Values.Text = "Ingresar libro";
            this.btnIngresarLibro.Click += new System.EventHandler(this.btnIngresarLibro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 44);
            this.label1.TabIndex = 18;
            this.label1.Text = "Libros leidos";
            // 
            // dgvLibrosLeidos
            // 
            this.dgvLibrosLeidos.AllowUserToAddRows = false;
            this.dgvLibrosLeidos.AutoGenerateColumns = false;
            this.dgvLibrosLeidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibrosLeidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.numeroidanoDataGridViewTextBoxColumn,
            this.nombrelibroDataGridViewTextBoxColumn,
            this.nombreautorDataGridViewTextBoxColumn,
            this.sagaserietrilogiaDataGridViewTextBoxColumn,
            this.numerosagaDataGridViewTextBoxColumn,
            this.anoleidoDataGridViewTextBoxColumn,
            this.Edit,
            this.Eliminar});
            this.dgvLibrosLeidos.DataSource = this.clsIngresoDatosBindingSource1;
            this.dgvLibrosLeidos.Location = new System.Drawing.Point(5, 144);
            this.dgvLibrosLeidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLibrosLeidos.Name = "dgvLibrosLeidos";
            this.dgvLibrosLeidos.RowHeadersWidth = 51;
            this.dgvLibrosLeidos.RowTemplate.Height = 24;
            this.dgvLibrosLeidos.Size = new System.Drawing.Size(1152, 431);
            this.dgvLibrosLeidos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvLibrosLeidos.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLibrosLeidos.TabIndex = 19;
            this.dgvLibrosLeidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibrosLeidos_CellContentClick);
            // 
            // txtBuscarLibro
            // 
            this.txtBuscarLibro.Location = new System.Drawing.Point(148, 90);
            this.txtBuscarLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarLibro.Name = "txtBuscarLibro";
            this.txtBuscarLibro.Size = new System.Drawing.Size(609, 29);
            this.txtBuscarLibro.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtBuscarLibro.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtBuscarLibro.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtBuscarLibro.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBuscarLibro.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtBuscarLibro.StateCommon.Border.Rounding = 5;
            this.txtBuscarLibro.StateCommon.Border.Width = 1;
            this.txtBuscarLibro.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtBuscarLibro.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarLibro.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.txtBuscarLibro.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Buscar:";
            // 
            // clsIngresoDatosBindingSource1
            // 
            this.clsIngresoDatosBindingSource1.DataSource = typeof(LibrosLeidos.Domain.ClsIngresoDatos);
            // 
            // clsIngresoDatosBindingSource
            // 
            this.clsIngresoDatosBindingSource.DataSource = typeof(LibrosLeidos.Domain.ClsIngresoDatos);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // numeroidanoDataGridViewTextBoxColumn
            // 
            this.numeroidanoDataGridViewTextBoxColumn.DataPropertyName = "numero_id_ano";
            this.numeroidanoDataGridViewTextBoxColumn.HeaderText = "#";
            this.numeroidanoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroidanoDataGridViewTextBoxColumn.Name = "numeroidanoDataGridViewTextBoxColumn";
            this.numeroidanoDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroidanoDataGridViewTextBoxColumn.Width = 40;
            // 
            // nombrelibroDataGridViewTextBoxColumn
            // 
            this.nombrelibroDataGridViewTextBoxColumn.DataPropertyName = "nombre_libro";
            this.nombrelibroDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombrelibroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombrelibroDataGridViewTextBoxColumn.Name = "nombrelibroDataGridViewTextBoxColumn";
            this.nombrelibroDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombrelibroDataGridViewTextBoxColumn.Width = 255;
            // 
            // nombreautorDataGridViewTextBoxColumn
            // 
            this.nombreautorDataGridViewTextBoxColumn.DataPropertyName = "nombre_autor";
            this.nombreautorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.nombreautorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreautorDataGridViewTextBoxColumn.Name = "nombreautorDataGridViewTextBoxColumn";
            this.nombreautorDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreautorDataGridViewTextBoxColumn.Width = 150;
            // 
            // sagaserietrilogiaDataGridViewTextBoxColumn
            // 
            this.sagaserietrilogiaDataGridViewTextBoxColumn.DataPropertyName = "saga_serie_trilogia";
            this.sagaserietrilogiaDataGridViewTextBoxColumn.HeaderText = "Saga/Serie/Trilogía";
            this.sagaserietrilogiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sagaserietrilogiaDataGridViewTextBoxColumn.Name = "sagaserietrilogiaDataGridViewTextBoxColumn";
            this.sagaserietrilogiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.sagaserietrilogiaDataGridViewTextBoxColumn.Width = 250;
            // 
            // numerosagaDataGridViewTextBoxColumn
            // 
            this.numerosagaDataGridViewTextBoxColumn.DataPropertyName = "numero_saga";
            this.numerosagaDataGridViewTextBoxColumn.HeaderText = "# Saga";
            this.numerosagaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numerosagaDataGridViewTextBoxColumn.Name = "numerosagaDataGridViewTextBoxColumn";
            this.numerosagaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numerosagaDataGridViewTextBoxColumn.Width = 50;
            // 
            // anoleidoDataGridViewTextBoxColumn
            // 
            this.anoleidoDataGridViewTextBoxColumn.DataPropertyName = "ano_leido";
            this.anoleidoDataGridViewTextBoxColumn.HeaderText = "Año leido";
            this.anoleidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.anoleidoDataGridViewTextBoxColumn.Name = "anoleidoDataGridViewTextBoxColumn";
            this.anoleidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.anoleidoDataGridViewTextBoxColumn.Width = 65;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Editar";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Editar";
            this.Edit.UseColumnTextForLinkValue = true;
            this.Edit.Width = 50;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForLinkValue = true;
            this.Eliminar.Width = 65;
            // 
            // FrmVisualizarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1179, 654);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscarLibro);
            this.Controls.Add(this.dgvLibrosLeidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIngresarLibro);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmVisualizarLibros";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros leidos";
            this.Load += new System.EventHandler(this.FrmVisualizarLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrosLeidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsIngresoDatosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsIngresoDatosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnIngresarLibro;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvLibrosLeidos;
        private System.Windows.Forms.BindingSource clsIngresoDatosBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBuscarLibro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource clsIngresoDatosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroidanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrelibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreautorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sagaserietrilogiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerosagaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoleidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
    }
}