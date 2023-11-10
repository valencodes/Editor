namespace Editor
{
    partial class fmEditor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmEditor));
            this.tsBarraEstandar = new System.Windows.Forms.ToolStrip();
            this.tsBarraFormato = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbAbrir = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCortar = new System.Windows.Forms.ToolStripButton();
            this.tsbCopiar = new System.Windows.Forms.ToolStripButton();
            this.tsbPegar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbsDeshacer = new System.Windows.Forms.ToolStripButton();
            this.tsbRehacer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCopiarFormatos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbQuitarFormatos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNegrita = new System.Windows.Forms.ToolStripButton();
            this.tsbSubrayado = new System.Windows.Forms.ToolStripButton();
            this.tsbTachado = new System.Windows.Forms.ToolStripButton();
            this.tsbCursiva = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbIzquierda = new System.Windows.Forms.ToolStripButton();
            this.tsbCentro = new System.Windows.Forms.ToolStripButton();
            this.tsbDerecha = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.cbFuentes = new System.Windows.Forms.ToolStripComboBox();
            this.cbTamanyo = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbColores = new System.Windows.Forms.ToolStripButton();
            this.stEstadoEditor = new System.Windows.Forms.StatusStrip();
            this.sl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sl2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sl3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sl4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sl5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.itEdicion = new System.Windows.Forms.ToolStripMenuItem();
            this.itFormato = new System.Windows.Forms.ToolStripMenuItem();
            this.itVer = new System.Windows.Forms.ToolStripMenuItem();
            this.itAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBarraEstandar.SuspendLayout();
            this.tsBarraFormato.SuspendLayout();
            this.stEstadoEditor.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsBarraEstandar
            // 
            this.tsBarraEstandar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbAbrir,
            this.tsbGuardar,
            this.tsbImprimir,
            this.toolStripSeparator1,
            this.tsbCortar,
            this.tsbCopiar,
            this.tsbPegar,
            this.toolStripSeparator2,
            this.tbsDeshacer,
            this.tsbRehacer,
            this.toolStripSeparator3,
            this.tsbCopiarFormatos,
            this.toolStripSeparator4,
            this.tsbQuitarFormatos,
            this.toolStripSeparator5});
            this.tsBarraEstandar.Location = new System.Drawing.Point(0, 24);
            this.tsBarraEstandar.Name = "tsBarraEstandar";
            this.tsBarraEstandar.Size = new System.Drawing.Size(800, 25);
            this.tsBarraEstandar.TabIndex = 0;
            this.tsBarraEstandar.Text = "toolStrip1";
            this.tsBarraEstandar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsBarraEstandar_ItemClicked);
            // 
            // tsBarraFormato
            // 
            this.tsBarraFormato.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNegrita,
            this.tsbSubrayado,
            this.tsbTachado,
            this.tsbCursiva,
            this.toolStripSeparator6,
            this.tsbIzquierda,
            this.tsbCentro,
            this.tsbDerecha,
            this.toolStripSeparator7,
            this.cbFuentes,
            this.cbTamanyo,
            this.toolStripSeparator8,
            this.tsbColores});
            this.tsBarraFormato.Location = new System.Drawing.Point(0, 49);
            this.tsBarraFormato.Name = "tsBarraFormato";
            this.tsBarraFormato.Size = new System.Drawing.Size(800, 25);
            this.tsBarraFormato.TabIndex = 1;
            this.tsBarraFormato.Text = "toolStrip2";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "tsbNuevo";
            // 
            // tsbAbrir
            // 
            this.tsbAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAbrir.Image = ((System.Drawing.Image)(resources.GetObject("tsbAbrir.Image")));
            this.tsbAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbrir.Name = "tsbAbrir";
            this.tsbAbrir.Size = new System.Drawing.Size(23, 22);
            this.tsbAbrir.Text = "tsbAbrir";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(23, 22);
            this.tsbGuardar.Text = "tsbGuardar";
            // 
            // tsbImprimir
            // 
            this.tsbImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tsbImprimir.Image")));
            this.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Size = new System.Drawing.Size(23, 22);
            this.tsbImprimir.Text = "tsbImprimir";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbCortar
            // 
            this.tsbCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCortar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCortar.Image")));
            this.tsbCortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCortar.Name = "tsbCortar";
            this.tsbCortar.Size = new System.Drawing.Size(23, 22);
            this.tsbCortar.Text = "toolStripButton1";
            // 
            // tsbCopiar
            // 
            this.tsbCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCopiar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCopiar.Image")));
            this.tsbCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopiar.Name = "tsbCopiar";
            this.tsbCopiar.Size = new System.Drawing.Size(23, 22);
            this.tsbCopiar.Text = "toolStripButton2";
            // 
            // tsbPegar
            // 
            this.tsbPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPegar.Image = ((System.Drawing.Image)(resources.GetObject("tsbPegar.Image")));
            this.tsbPegar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPegar.Name = "tsbPegar";
            this.tsbPegar.Size = new System.Drawing.Size(23, 22);
            this.tsbPegar.Text = "toolStripButton3";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbsDeshacer
            // 
            this.tbsDeshacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsDeshacer.Image = ((System.Drawing.Image)(resources.GetObject("tbsDeshacer.Image")));
            this.tbsDeshacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsDeshacer.Name = "tbsDeshacer";
            this.tbsDeshacer.Size = new System.Drawing.Size(23, 22);
            this.tbsDeshacer.Text = "toolStripButton1";
            // 
            // tsbRehacer
            // 
            this.tsbRehacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRehacer.Image = ((System.Drawing.Image)(resources.GetObject("tsbRehacer.Image")));
            this.tsbRehacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRehacer.Name = "tsbRehacer";
            this.tsbRehacer.Size = new System.Drawing.Size(23, 22);
            this.tsbRehacer.Text = "toolStripButton2";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbCopiarFormatos
            // 
            this.tsbCopiarFormatos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCopiarFormatos.Image = ((System.Drawing.Image)(resources.GetObject("tsbCopiarFormatos.Image")));
            this.tsbCopiarFormatos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopiarFormatos.Name = "tsbCopiarFormatos";
            this.tsbCopiarFormatos.Size = new System.Drawing.Size(23, 22);
            this.tsbCopiarFormatos.Text = "toolStripButton1";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbQuitarFormatos
            // 
            this.tsbQuitarFormatos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbQuitarFormatos.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuitarFormatos.Image")));
            this.tsbQuitarFormatos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuitarFormatos.Name = "tsbQuitarFormatos";
            this.tsbQuitarFormatos.Size = new System.Drawing.Size(23, 22);
            this.tsbQuitarFormatos.Text = "toolStripButton2";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbNegrita
            // 
            this.tsbNegrita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNegrita.Image = ((System.Drawing.Image)(resources.GetObject("tsbNegrita.Image")));
            this.tsbNegrita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNegrita.Name = "tsbNegrita";
            this.tsbNegrita.Size = new System.Drawing.Size(23, 22);
            this.tsbNegrita.Text = "toolStripButton1";
            // 
            // tsbSubrayado
            // 
            this.tsbSubrayado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSubrayado.Image = ((System.Drawing.Image)(resources.GetObject("tsbSubrayado.Image")));
            this.tsbSubrayado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSubrayado.Name = "tsbSubrayado";
            this.tsbSubrayado.Size = new System.Drawing.Size(23, 22);
            this.tsbSubrayado.Text = "toolStripButton1";
            // 
            // tsbTachado
            // 
            this.tsbTachado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTachado.Image = ((System.Drawing.Image)(resources.GetObject("tsbTachado.Image")));
            this.tsbTachado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTachado.Name = "tsbTachado";
            this.tsbTachado.Size = new System.Drawing.Size(23, 22);
            this.tsbTachado.Text = "toolStripButton1";
            // 
            // tsbCursiva
            // 
            this.tsbCursiva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCursiva.Image = ((System.Drawing.Image)(resources.GetObject("tsbCursiva.Image")));
            this.tsbCursiva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCursiva.Name = "tsbCursiva";
            this.tsbCursiva.Size = new System.Drawing.Size(23, 22);
            this.tsbCursiva.Text = "toolStripButton1";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbIzquierda
            // 
            this.tsbIzquierda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbIzquierda.Image = ((System.Drawing.Image)(resources.GetObject("tsbIzquierda.Image")));
            this.tsbIzquierda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIzquierda.Name = "tsbIzquierda";
            this.tsbIzquierda.Size = new System.Drawing.Size(23, 22);
            this.tsbIzquierda.Text = "toolStripButton1";
            // 
            // tsbCentro
            // 
            this.tsbCentro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCentro.Image = ((System.Drawing.Image)(resources.GetObject("tsbCentro.Image")));
            this.tsbCentro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCentro.Name = "tsbCentro";
            this.tsbCentro.Size = new System.Drawing.Size(23, 22);
            this.tsbCentro.Text = "toolStripButton2";
            // 
            // tsbDerecha
            // 
            this.tsbDerecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDerecha.Image = ((System.Drawing.Image)(resources.GetObject("tsbDerecha.Image")));
            this.tsbDerecha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDerecha.Name = "tsbDerecha";
            this.tsbDerecha.Size = new System.Drawing.Size(23, 22);
            this.tsbDerecha.Text = "toolStripButton3";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // cbFuentes
            // 
            this.cbFuentes.Name = "cbFuentes";
            this.cbFuentes.Size = new System.Drawing.Size(121, 25);
            // 
            // cbTamanyo
            // 
            this.cbTamanyo.Name = "cbTamanyo";
            this.cbTamanyo.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbColores
            // 
            this.tsbColores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbColores.Image = ((System.Drawing.Image)(resources.GetObject("tsbColores.Image")));
            this.tsbColores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbColores.Name = "tsbColores";
            this.tsbColores.Size = new System.Drawing.Size(23, 22);
            this.tsbColores.Text = "toolStripButton1";
            // 
            // stEstadoEditor
            // 
            this.stEstadoEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sl1,
            this.sl2,
            this.sl3,
            this.sl4,
            this.sl5});
            this.stEstadoEditor.Location = new System.Drawing.Point(0, 428);
            this.stEstadoEditor.Name = "stEstadoEditor";
            this.stEstadoEditor.Size = new System.Drawing.Size(800, 22);
            this.stEstadoEditor.TabIndex = 2;
            this.stEstadoEditor.Text = "statusStrip1";
            // 
            // sl1
            // 
            this.sl1.AutoSize = false;
            this.sl1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.sl1.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.sl1.Name = "sl1";
            this.sl1.Size = new System.Drawing.Size(118, 17);
            this.sl1.Text = "toolStripStatusLabel1";
            this.sl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sl2
            // 
            this.sl2.AutoSize = false;
            this.sl2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.sl2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.sl2.Name = "sl2";
            this.sl2.Size = new System.Drawing.Size(118, 17);
            this.sl2.Text = "toolStripStatusLabel1";
            this.sl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sl3
            // 
            this.sl3.AutoSize = false;
            this.sl3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.sl3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.sl3.Name = "sl3";
            this.sl3.Size = new System.Drawing.Size(118, 17);
            this.sl3.Text = "toolStripStatusLabel1";
            this.sl3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sl4
            // 
            this.sl4.AutoSize = false;
            this.sl4.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.sl4.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.sl4.Name = "sl4";
            this.sl4.Size = new System.Drawing.Size(118, 17);
            this.sl4.Text = "toolStripStatusLabel2";
            this.sl4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sl5
            // 
            this.sl5.AutoSize = false;
            this.sl5.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.sl5.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.sl5.Name = "sl5";
            this.sl5.Size = new System.Drawing.Size(118, 17);
            this.sl5.Text = "toolStripStatusLabel3";
            this.sl5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 74);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 354);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itArchivo,
            this.itEdicion,
            this.itVer,
            this.itFormato,
            this.itAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itArchivo
            // 
            this.itArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.imprimirToolStripMenuItem,
            this.toolStripMenuItem3,
            this.salirToolStripMenuItem});
            this.itArchivo.Name = "itArchivo";
            this.itArchivo.Size = new System.Drawing.Size(60, 20);
            this.itArchivo.Text = "Archivo";
            // 
            // itEdicion
            // 
            this.itEdicion.Name = "itEdicion";
            this.itEdicion.Size = new System.Drawing.Size(58, 20);
            this.itEdicion.Text = "Edición";
            // 
            // itFormato
            // 
            this.itFormato.Name = "itFormato";
            this.itFormato.Size = new System.Drawing.Size(64, 20);
            this.itFormato.Text = "&Formato";
            // 
            // itVer
            // 
            this.itVer.Name = "itVer";
            this.itVer.Size = new System.Drawing.Size(35, 20);
            this.itVer.Text = "&Ver";
            // 
            // itAyuda
            // 
            this.itAyuda.Name = "itAyuda";
            this.itAyuda.Size = new System.Drawing.Size(53, 20);
            this.itAyuda.Text = "A&yuda";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "&Guardar";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarComoToolStripMenuItem.Text = "&Guardar Como";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimirToolStripMenuItem.Text = "&Imprimir";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            // 
            // fmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.stEstadoEditor);
            this.Controls.Add(this.tsBarraFormato);
            this.Controls.Add(this.tsBarraEstandar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmEditor";
            this.Text = "Editor";
            this.tsBarraEstandar.ResumeLayout(false);
            this.tsBarraEstandar.PerformLayout();
            this.tsBarraFormato.ResumeLayout(false);
            this.tsBarraFormato.PerformLayout();
            this.stEstadoEditor.ResumeLayout(false);
            this.stEstadoEditor.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsBarraEstandar;
        private System.Windows.Forms.ToolStrip tsBarraFormato;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbAbrir;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbCortar;
        private System.Windows.Forms.ToolStripButton tsbCopiar;
        private System.Windows.Forms.ToolStripButton tsbPegar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbsDeshacer;
        private System.Windows.Forms.ToolStripButton tsbRehacer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbCopiarFormatos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbQuitarFormatos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbNegrita;
        private System.Windows.Forms.ToolStripButton tsbSubrayado;
        private System.Windows.Forms.ToolStripButton tsbTachado;
        private System.Windows.Forms.ToolStripButton tsbCursiva;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbIzquierda;
        private System.Windows.Forms.ToolStripButton tsbCentro;
        private System.Windows.Forms.ToolStripButton tsbDerecha;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripComboBox cbFuentes;
        private System.Windows.Forms.ToolStripComboBox cbTamanyo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tsbColores;
        private System.Windows.Forms.StatusStrip stEstadoEditor;
        private System.Windows.Forms.ToolStripStatusLabel sl1;
        private System.Windows.Forms.ToolStripStatusLabel sl2;
        private System.Windows.Forms.ToolStripStatusLabel sl3;
        private System.Windows.Forms.ToolStripStatusLabel sl4;
        private System.Windows.Forms.ToolStripStatusLabel sl5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itArchivo;
        private System.Windows.Forms.ToolStripMenuItem itEdicion;
        private System.Windows.Forms.ToolStripMenuItem itVer;
        private System.Windows.Forms.ToolStripMenuItem itFormato;
        private System.Windows.Forms.ToolStripMenuItem itAyuda;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

