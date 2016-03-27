using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmCita citas = new frmCita();
            citas.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
            frmPaciente paciente = new frmPaciente();
            paciente.Show();

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
