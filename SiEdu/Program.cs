using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiEdu
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Sistema_experto e = new Sistema_experto();
    //        e.construir_base_conocimientos();
    //        e.difusificacion();
    //        e.leer_fam();
    //        e.inferir();
    //        e.desdifusificar();
    //        e.leer_archivos();
    //    }
    //}
}
