namespace Loteria
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.MenuPrincipal = new System.Windows.Forms.ToolStrip();
            this.MenuVolver = new System.Windows.Forms.ToolStripButton();
            this.MenuInicio = new System.Windows.Forms.ToolStripButton();
            this.MenuAyuda = new System.Windows.Forms.ToolStripButton();
            this.TablaPanelImagenes = new System.Windows.Forms.TableLayoutPanel();
            this.ImgLoteriaNacional = new System.Windows.Forms.PictureBox();
            this.ImgLaPrimitiva = new System.Windows.Forms.PictureBox();
            this.ImgBonoLoto = new System.Windows.Forms.PictureBox();
            this.ImgLaQuiniela = new System.Windows.Forms.PictureBox();
            this.ImgONCE = new System.Windows.Forms.PictureBox();
            this.MenuPrincipal.SuspendLayout();
            this.TablaPanelImagenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLoteriaNacional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLaPrimitiva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBonoLoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLaQuiniela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgONCE)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuVolver,
            this.MenuInicio,
            this.MenuAyuda});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(614, 25);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "Menú";
            // 
            // MenuVolver
            // 
            this.MenuVolver.Image = global::Loteria.Properties.Resources.MenuVolver;
            this.MenuVolver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuVolver.Name = "MenuVolver";
            this.MenuVolver.Size = new System.Drawing.Size(60, 22);
            this.MenuVolver.Text = "Volver";
            // 
            // MenuInicio
            // 
            this.MenuInicio.Image = global::Loteria.Properties.Resources.MenuInicio;
            this.MenuInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuInicio.Name = "MenuInicio";
            this.MenuInicio.Size = new System.Drawing.Size(56, 22);
            this.MenuInicio.Text = "Inicio";
            // 
            // MenuAyuda
            // 
            this.MenuAyuda.Image = global::Loteria.Properties.Resources.MenuAyuda;
            this.MenuAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuAyuda.Name = "MenuAyuda";
            this.MenuAyuda.Size = new System.Drawing.Size(61, 22);
            this.MenuAyuda.Text = "Ayuda";
            // 
            // TablaPanelImagenes
            // 
            this.TablaPanelImagenes.ColumnCount = 3;
            this.TablaPanelImagenes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TablaPanelImagenes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TablaPanelImagenes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TablaPanelImagenes.Controls.Add(this.ImgLoteriaNacional, 0, 0);
            this.TablaPanelImagenes.Controls.Add(this.ImgLaPrimitiva, 1, 0);
            this.TablaPanelImagenes.Controls.Add(this.ImgBonoLoto, 2, 0);
            this.TablaPanelImagenes.Controls.Add(this.ImgLaQuiniela, 0, 1);
            this.TablaPanelImagenes.Controls.Add(this.ImgONCE, 2, 1);
            this.TablaPanelImagenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaPanelImagenes.Location = new System.Drawing.Point(0, 25);
            this.TablaPanelImagenes.Name = "TablaPanelImagenes";
            this.TablaPanelImagenes.RowCount = 2;
            this.TablaPanelImagenes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TablaPanelImagenes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TablaPanelImagenes.Size = new System.Drawing.Size(614, 487);
            this.TablaPanelImagenes.TabIndex = 1;
            // 
            // ImgLoteriaNacional
            // 
            this.ImgLoteriaNacional.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgLoteriaNacional.Image = global::Loteria.Properties.Resources.ImgLoteriaNacional;
            this.ImgLoteriaNacional.Location = new System.Drawing.Point(3, 3);
            this.ImgLoteriaNacional.Name = "ImgLoteriaNacional";
            this.ImgLoteriaNacional.Size = new System.Drawing.Size(198, 237);
            this.ImgLoteriaNacional.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgLoteriaNacional.TabIndex = 0;
            this.ImgLoteriaNacional.TabStop = false;
            this.ImgLoteriaNacional.Click += new System.EventHandler(this.ImgLoteriaNacional_Click);
            // 
            // ImgLaPrimitiva
            // 
            this.ImgLaPrimitiva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgLaPrimitiva.Image = global::Loteria.Properties.Resources.ImgLaPrimitiva;
            this.ImgLaPrimitiva.Location = new System.Drawing.Point(207, 3);
            this.ImgLaPrimitiva.Name = "ImgLaPrimitiva";
            this.ImgLaPrimitiva.Size = new System.Drawing.Size(198, 237);
            this.ImgLaPrimitiva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgLaPrimitiva.TabIndex = 1;
            this.ImgLaPrimitiva.TabStop = false;
            this.ImgLaPrimitiva.Click += new System.EventHandler(this.ImgLaPrimitiva_Click);
            // 
            // ImgBonoLoto
            // 
            this.ImgBonoLoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgBonoLoto.Image = global::Loteria.Properties.Resources.ImgBonoLoto;
            this.ImgBonoLoto.Location = new System.Drawing.Point(411, 3);
            this.ImgBonoLoto.Name = "ImgBonoLoto";
            this.ImgBonoLoto.Size = new System.Drawing.Size(200, 237);
            this.ImgBonoLoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgBonoLoto.TabIndex = 2;
            this.ImgBonoLoto.TabStop = false;
            this.ImgBonoLoto.Click += new System.EventHandler(this.ImgBonoLoto_Click);
            // 
            // ImgLaQuiniela
            // 
            this.ImgLaQuiniela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgLaQuiniela.Image = global::Loteria.Properties.Resources.ImgLaQuiniela;
            this.ImgLaQuiniela.Location = new System.Drawing.Point(3, 246);
            this.ImgLaQuiniela.Name = "ImgLaQuiniela";
            this.ImgLaQuiniela.Size = new System.Drawing.Size(198, 238);
            this.ImgLaQuiniela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgLaQuiniela.TabIndex = 3;
            this.ImgLaQuiniela.TabStop = false;
            this.ImgLaQuiniela.Click += new System.EventHandler(this.ImgLaQuiniela_Click);
            // 
            // ImgONCE
            // 
            this.ImgONCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgONCE.Image = global::Loteria.Properties.Resources.ImgONCE;
            this.ImgONCE.Location = new System.Drawing.Point(411, 246);
            this.ImgONCE.Name = "ImgONCE";
            this.ImgONCE.Size = new System.Drawing.Size(200, 238);
            this.ImgONCE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgONCE.TabIndex = 4;
            this.ImgONCE.TabStop = false;
            this.ImgONCE.Click += new System.EventHandler(this.ImgONCE_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 512);
            this.Controls.Add(this.TablaPanelImagenes);
            this.Controls.Add(this.MenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(630, 550);
            this.Name = "Principal";
            this.Text = "Loteria";
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.TablaPanelImagenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgLoteriaNacional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLaPrimitiva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBonoLoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLaQuiniela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgONCE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripButton MenuVolver;
        private System.Windows.Forms.ToolStripButton MenuInicio;
        private System.Windows.Forms.ToolStripButton MenuAyuda;
        private System.Windows.Forms.TableLayoutPanel TablaPanelImagenes;
        private System.Windows.Forms.PictureBox ImgLoteriaNacional;
        private System.Windows.Forms.PictureBox ImgLaPrimitiva;
        private System.Windows.Forms.PictureBox ImgBonoLoto;
        private System.Windows.Forms.PictureBox ImgLaQuiniela;
        private System.Windows.Forms.PictureBox ImgONCE;
    }
}

