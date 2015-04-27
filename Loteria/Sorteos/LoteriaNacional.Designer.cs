namespace Loteria.Sorteos
{
    partial class LoteriaNacional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoteriaNacional));
            this.MenuPrincipal = new System.Windows.Forms.ToolStrip();
            this.MenuVolver = new System.Windows.Forms.ToolStripButton();
            this.MenuInicio = new System.Windows.Forms.ToolStripButton();
            this.MenuAyuda = new System.Windows.Forms.ToolStripButton();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuVolver,
            this.MenuInicio,
            this.MenuAyuda});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(582, 25);
            this.MenuPrincipal.TabIndex = 5;
            this.MenuPrincipal.Text = "Menú";
            // 
            // MenuVolver
            // 
            this.MenuVolver.Image = global::Loteria.Properties.Resources.MenuVolver;
            this.MenuVolver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuVolver.Name = "MenuVolver";
            this.MenuVolver.Size = new System.Drawing.Size(60, 22);
            this.MenuVolver.Text = "Volver";
            this.MenuVolver.Click += new System.EventHandler(this.MenuVolver_Click);
            // 
            // MenuInicio
            // 
            this.MenuInicio.Image = global::Loteria.Properties.Resources.MenuInicio;
            this.MenuInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuInicio.Name = "MenuInicio";
            this.MenuInicio.Size = new System.Drawing.Size(56, 22);
            this.MenuInicio.Text = "Inicio";
            this.MenuInicio.Click += new System.EventHandler(this.MenuInicio_Click);
            // 
            // MenuAyuda
            // 
            this.MenuAyuda.Image = global::Loteria.Properties.Resources.MenuAyuda;
            this.MenuAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuAyuda.Name = "MenuAyuda";
            this.MenuAyuda.Size = new System.Drawing.Size(61, 22);
            this.MenuAyuda.Text = "Ayuda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(115, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(352, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pulse el número con el que desea jugar:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(112, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 47);
            this.button1.TabIndex = 13;
            this.button1.Text = "45644";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Comprar);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(112, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 47);
            this.button2.TabIndex = 14;
            this.button2.Text = "01217";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Comprar);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(356, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 47);
            this.button3.TabIndex = 15;
            this.button3.Text = "60011";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Comprar);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(112, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 47);
            this.button4.TabIndex = 16;
            this.button4.Text = "64373";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Comprar);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(356, 98);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 47);
            this.button5.TabIndex = 17;
            this.button5.Text = "97821";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Comprar);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(356, 160);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 47);
            this.button6.TabIndex = 18;
            this.button6.Text = "35447";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Comprar);
            // 
            // LoteriaNacional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 345);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(598, 383);
            this.MinimumSize = new System.Drawing.Size(598, 383);
            this.Name = "LoteriaNacional";
            this.Text = "Lotería Nacional";
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripButton MenuVolver;
        private System.Windows.Forms.ToolStripButton MenuInicio;
        private System.Windows.Forms.ToolStripButton MenuAyuda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}