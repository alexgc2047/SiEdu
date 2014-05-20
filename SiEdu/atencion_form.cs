using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiEdu
{
    public partial class atencion_form : Form
    {
        public atencion_form()
        {
            InitializeComponent();
        }

        private void atencion_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            double suma = 0;
            suma = (ind1.CheckState == CheckState.Checked) ? suma + 1 : suma;
            suma = (ind2.CheckState == CheckState.Checked) ? suma + 1 : suma;
            suma = (ind3.CheckState == CheckState.Checked) ? suma + 1 : suma;
            suma = (ind4.CheckState == CheckState.Checked) ? suma + 1 : suma;
            suma = (ind5.CheckState == CheckState.Checked) ? suma + 1 : suma;
            suma = (ind6.CheckState == CheckState.Checked) ? suma + 1 : suma;
            suma = (ind7.CheckState == CheckState.Checked) ? suma + 1 : suma;
            suma = (ind8.CheckState == CheckState.Checked) ? suma + 1 : suma;
            suma = (ind9.CheckState == CheckState.Checked) ? suma + 1 : suma;
            suma = (ind10.CheckState == CheckState.Checked) ? suma + 1 : suma;
            p.atencion = suma;
            p.flag_atencion = true;
            this.Close();
        }
    }
}
