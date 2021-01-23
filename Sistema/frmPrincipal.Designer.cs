namespace MenuDesplegable
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.mzButtonWindows2 = new BWCMM.MZButtonWindows();
            this.mzButtonWindows3 = new BWCMM.MZButtonWindows();
            this.mzButtonWindows1 = new BWCMM.MZButtonWindows();
            this.titulolb = new System.Windows.Forms.Label();
            this.btnBoton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBoton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelBoton2 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelBoton1 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel2.SuspendLayout();
            this.PanelBoton2.SuspendLayout();
            this.PanelBoton1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(273, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 539);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(318, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 45);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Niagara Solid", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(74, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Operaciones";
            // 
            // mzButtonWindows2
            // 
            this.mzButtonWindows2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mzButtonWindows2.BackColor = System.Drawing.Color.Transparent;
            this.mzButtonWindows2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mzButtonWindows2.BackgroundImage")));
            this.mzButtonWindows2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mzButtonWindows2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mzButtonWindows2.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows;
            this.mzButtonWindows2.Location = new System.Drawing.Point(1029, 0);
            this.mzButtonWindows2.Name = "mzButtonWindows2";
            this.mzButtonWindows2.ParentControl = this;
            this.mzButtonWindows2.Size = new System.Drawing.Size(40, 24);
            this.mzButtonWindows2.TabIndex = 8;
            this.mzButtonWindows2.TipoButton = BWCMM.MZButtonWindows.ModeButton.Maximize;
            // 
            // mzButtonWindows3
            // 
            this.mzButtonWindows3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mzButtonWindows3.BackColor = System.Drawing.Color.Transparent;
            this.mzButtonWindows3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mzButtonWindows3.BackgroundImage")));
            this.mzButtonWindows3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mzButtonWindows3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mzButtonWindows3.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows;
            this.mzButtonWindows3.Location = new System.Drawing.Point(989, 0);
            this.mzButtonWindows3.Name = "mzButtonWindows3";
            this.mzButtonWindows3.ParentControl = this;
            this.mzButtonWindows3.Size = new System.Drawing.Size(40, 24);
            this.mzButtonWindows3.TabIndex = 9;
            this.mzButtonWindows3.TipoButton = BWCMM.MZButtonWindows.ModeButton.Minimize;
            // 
            // mzButtonWindows1
            // 
            this.mzButtonWindows1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mzButtonWindows1.BackColor = System.Drawing.Color.Transparent;
            this.mzButtonWindows1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mzButtonWindows1.BackgroundImage")));
            this.mzButtonWindows1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mzButtonWindows1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mzButtonWindows1.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows;
            this.mzButtonWindows1.Location = new System.Drawing.Point(1069, 0);
            this.mzButtonWindows1.Name = "mzButtonWindows1";
            this.mzButtonWindows1.ParentControl = this;
            this.mzButtonWindows1.Size = new System.Drawing.Size(40, 24);
            this.mzButtonWindows1.TabIndex = 7;
            this.mzButtonWindows1.TipoButton = BWCMM.MZButtonWindows.ModeButton.Close;
            this.mzButtonWindows1.Paint += new System.Windows.Forms.PaintEventHandler(this.mzButtonWindows1_Paint);
            // 
            // titulolb
            // 
            this.titulolb.AutoSize = true;
            this.titulolb.BackColor = System.Drawing.Color.Transparent;
            this.titulolb.Font = new System.Drawing.Font("Niagara Solid", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulolb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titulolb.Location = new System.Drawing.Point(599, 7);
            this.titulolb.Name = "titulolb";
            this.titulolb.Size = new System.Drawing.Size(107, 29);
            this.titulolb.TabIndex = 10;
            this.titulolb.Text = "Operaciones";
            // 
            // btnBoton1
            // 
            this.btnBoton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnBoton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(143)))));
            this.btnBoton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBoton1.BorderRadius = 0;
            this.btnBoton1.ButtonText = "Venta y productos";
            this.btnBoton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoton1.DisabledColor = System.Drawing.Color.Gray;
            this.btnBoton1.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBoton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBoton1.Iconimage")));
            this.btnBoton1.Iconimage_right = null;
            this.btnBoton1.Iconimage_right_Selected = null;
            this.btnBoton1.Iconimage_Selected = null;
            this.btnBoton1.IconMarginLeft = 0;
            this.btnBoton1.IconMarginRight = 0;
            this.btnBoton1.IconRightVisible = true;
            this.btnBoton1.IconRightZoom = 0D;
            this.btnBoton1.IconVisible = true;
            this.btnBoton1.IconZoom = 90D;
            this.btnBoton1.IsTab = true;
            this.btnBoton1.Location = new System.Drawing.Point(7, 158);
            this.btnBoton1.Name = "btnBoton1";
            this.btnBoton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(143)))));
            this.btnBoton1.OnHovercolor = System.Drawing.Color.Aqua;
            this.btnBoton1.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBoton1.selected = false;
            this.btnBoton1.Size = new System.Drawing.Size(241, 49);
            this.btnBoton1.TabIndex = 2;
            this.btnBoton1.Text = "Venta y productos";
            this.btnBoton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBoton1.Textcolor = System.Drawing.Color.White;
            this.btnBoton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoton1.Click += new System.EventHandler(this.btnBoton1_Click);
            // 
            // btnBoton2
            // 
            this.btnBoton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBoton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(143)))));
            this.btnBoton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBoton2.BorderRadius = 0;
            this.btnBoton2.ButtonText = "Consulta";
            this.btnBoton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoton2.DisabledColor = System.Drawing.Color.Gray;
            this.btnBoton2.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBoton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBoton2.Iconimage")));
            this.btnBoton2.Iconimage_right = null;
            this.btnBoton2.Iconimage_right_Selected = null;
            this.btnBoton2.Iconimage_Selected = null;
            this.btnBoton2.IconMarginLeft = 0;
            this.btnBoton2.IconMarginRight = 0;
            this.btnBoton2.IconRightVisible = true;
            this.btnBoton2.IconRightZoom = 0D;
            this.btnBoton2.IconVisible = true;
            this.btnBoton2.IconZoom = 90D;
            this.btnBoton2.IsTab = true;
            this.btnBoton2.Location = new System.Drawing.Point(7, 207);
            this.btnBoton2.Name = "btnBoton2";
            this.btnBoton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(143)))));
            this.btnBoton2.OnHovercolor = System.Drawing.Color.Aqua;
            this.btnBoton2.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBoton2.selected = false;
            this.btnBoton2.Size = new System.Drawing.Size(241, 49);
            this.btnBoton2.TabIndex = 3;
            this.btnBoton2.Text = "Consulta";
            this.btnBoton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBoton2.Textcolor = System.Drawing.Color.White;
            this.btnBoton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoton2.Click += new System.EventHandler(this.btnBoton2_Click);
            // 
            // PanelBoton2
            // 
            this.PanelBoton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PanelBoton2.Controls.Add(this.bunifuFlatButton3);
            this.PanelBoton2.Controls.Add(this.bunifuFlatButton4);
            this.PanelBoton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelBoton2.Location = new System.Drawing.Point(7, 407);
            this.PanelBoton2.Name = "PanelBoton2";
            this.PanelBoton2.Size = new System.Drawing.Size(241, 98);
            this.PanelBoton2.TabIndex = 3;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Salir";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 48);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.Red;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(241, 42);
            this.bunifuFlatButton3.TabIndex = 7;
            this.bunifuFlatButton3.Text = "Salir";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Registros de compra";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.Red;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(241, 42);
            this.bunifuFlatButton4.TabIndex = 6;
            this.bunifuFlatButton4.Text = "Registros de compra";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // PanelBoton1
            // 
            this.PanelBoton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PanelBoton1.Controls.Add(this.bunifuFlatButton2);
            this.PanelBoton1.Controls.Add(this.bunifuFlatButton1);
            this.PanelBoton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelBoton1.Location = new System.Drawing.Point(7, 304);
            this.PanelBoton1.Name = "PanelBoton1";
            this.PanelBoton1.Size = new System.Drawing.Size(241, 97);
            this.PanelBoton1.TabIndex = 2;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Productos";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 48);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Red;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(241, 42);
            this.bunifuFlatButton2.TabIndex = 5;
            this.bunifuFlatButton2.Text = "Productos";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Venta";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Red;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(241, 42);
            this.bunifuFlatButton1.TabIndex = 4;
            this.bunifuFlatButton1.Text = "Venta";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Sistema.Properties.Resources.descarga;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(25, 511);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PanelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelMenu.BackgroundImage")));
            this.PanelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelMenu.Controls.Add(this.pictureBox1);
            this.PanelMenu.Controls.Add(this.PanelBoton1);
            this.PanelMenu.Controls.Add(this.PanelBoton2);
            this.PanelMenu.Controls.Add(this.btnBoton2);
            this.PanelMenu.Controls.Add(this.btnBoton1);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.GradientBottomLeft = System.Drawing.SystemColors.GradientActiveCaption;
            this.PanelMenu.GradientBottomRight = System.Drawing.Color.LightGray;
            this.PanelMenu.GradientTopLeft = System.Drawing.Color.LightGray;
            this.PanelMenu.GradientTopRight = System.Drawing.Color.LightGray;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Quality = 10;
            this.PanelMenu.Size = new System.Drawing.Size(255, 651);
            this.PanelMenu.TabIndex = 0;
            this.PanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenu_Paint);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1109, 651);
            this.Controls.Add(this.titulolb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mzButtonWindows2);
            this.Controls.Add(this.mzButtonWindows3);
            this.Controls.Add(this.mzButtonWindows1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelBoton2.ResumeLayout(false);
            this.PanelBoton1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Panel panel2;
        private BWCMM.MZButtonWindows mzButtonWindows2;
        private BWCMM.MZButtonWindows mzButtonWindows3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titulolb;
        public BWCMM.MZButtonWindows mzButtonWindows1;
        public Bunifu.Framework.UI.BunifuGradientPanel PanelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelBoton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel PanelBoton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton btnBoton2;
        private Bunifu.Framework.UI.BunifuFlatButton btnBoton1;
    }
}

