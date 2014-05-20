namespace SiEdu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.construirBaseDeConocimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boton_atencion = new System.Windows.Forms.Button();
            this.boton_imitacion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.boton_segins = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.boton_ok = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(351, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.construirBaseDeConocimientosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // construirBaseDeConocimientosToolStripMenuItem
            // 
            this.construirBaseDeConocimientosToolStripMenuItem.Name = "construirBaseDeConocimientosToolStripMenuItem";
            this.construirBaseDeConocimientosToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.construirBaseDeConocimientosToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.construirBaseDeConocimientosToolStripMenuItem.Text = "Construir Base de Conocimientos";
            this.construirBaseDeConocimientosToolStripMenuItem.Click += new System.EventHandler(this.construirBaseDeConocimientosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeyDisplayString = "Alt + F4";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Secciones:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Evaluación de Atención";
            // 
            // boton_atencion
            // 
            this.boton_atencion.Location = new System.Drawing.Point(210, 95);
            this.boton_atencion.Name = "boton_atencion";
            this.boton_atencion.Size = new System.Drawing.Size(129, 23);
            this.boton_atencion.TabIndex = 3;
            this.boton_atencion.Text = "-- :: Comenzar :: --";
            this.boton_atencion.UseVisualStyleBackColor = true;
            this.boton_atencion.Click += new System.EventHandler(this.boton_atencion_Click);
            // 
            // boton_imitacion
            // 
            this.boton_imitacion.Location = new System.Drawing.Point(210, 150);
            this.boton_imitacion.Name = "boton_imitacion";
            this.boton_imitacion.Size = new System.Drawing.Size(129, 23);
            this.boton_imitacion.TabIndex = 5;
            this.boton_imitacion.Text = "-- :: Comenzar :: --";
            this.boton_imitacion.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Imitación";
            // 
            // boton_segins
            // 
            this.boton_segins.Location = new System.Drawing.Point(210, 207);
            this.boton_segins.Name = "boton_segins";
            this.boton_segins.Size = new System.Drawing.Size(129, 23);
            this.boton_segins.TabIndex = 7;
            this.boton_segins.Text = "-- :: Comenzar :: --";
            this.boton_segins.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seguimiento de Instrucciónes";
            // 
            // boton_ok
            // 
            this.boton_ok.Enabled = false;
            this.boton_ok.Location = new System.Drawing.Point(141, 258);
            this.boton_ok.Name = "boton_ok";
            this.boton_ok.Size = new System.Drawing.Size(75, 23);
            this.boton_ok.TabIndex = 8;
            this.boton_ok.Text = "Analizar";
            this.boton_ok.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 401);
            this.Controls.Add(this.boton_ok);
            this.Controls.Add(this.boton_segins);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boton_imitacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boton_atencion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Detección de Problemas de Atención";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem construirBaseDeConocimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boton_atencion;
        private System.Windows.Forms.Button boton_imitacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button boton_segins;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button boton_ok;

    }
}

