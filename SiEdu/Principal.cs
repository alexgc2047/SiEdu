﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiEdu
{
    public partial class Principal : Form
    {
        public double atencion, imitacion, segins;
        public Boolean flag_atencion, flag_imitacion, flag_segins;
        public Principal()
        {
            InitializeComponent();
            flag_atencion = false;
            flag_imitacion = false;
            flag_segins = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void construirBaseDeConocimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "data\\sistema_experto.exe";
            proc.EnableRaisingEvents = true;

            proc.Start();
            proc.WaitForExit();
            //new base_conocimientos().Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema Experto para detección de problemas de atención.\n\nElaborado por:\n  -Arroyo Calero Karla Teresa\n  -Gómez Cruz Alejandro\n\n INSTITUTO TECNOLOGICO DE CELAYA", "Acerca de...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void boton_atencion_Click(object sender, EventArgs e)
        {
            atencion_form af = new atencion_form();
            af.Show();
        }
    }
}
