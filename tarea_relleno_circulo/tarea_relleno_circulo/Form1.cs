using System.Runtime.Intrinsics.X86;

namespace tarea_relleno_circulo
{
    public partial class Form1 : Form
    {
        FormDDL FormDDL = null;
        FormBresenham FormBresenham = null;
        FormCircunferencia FormCircunferencia = null;
        FormRellenoDibujoLibre Relleno = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void algoritmoDiscretizaciónLíneasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormDDL == null || FormDDL.IsDisposed)
            {
                FormDDL = new FormDDL();
                FormDDL.MdiParent = this;
                FormDDL.Show();
            }
        }

        private void algoritmoBresenhamLíneasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormBresenham == null || FormBresenham.IsDisposed)
            {
                FormBresenham = new FormBresenham();
                FormBresenham.MdiParent = this;
                FormBresenham.Show();
            }
        }

        private void algoritmoBresenhamCircunferenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormCircunferencia == null || FormCircunferencia.IsDisposed)
            {
                FormCircunferencia = new FormCircunferencia();
                FormCircunferencia.MdiParent = this;
                FormCircunferencia.Show();
            }
        }

        private void algoritmoDeRellenadoDibujoLibreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Relleno == null || Relleno.IsDisposed)
            {
                Relleno = new FormRellenoDibujoLibre();
                Relleno.MdiParent = this;
                Relleno.Show();
            }
        }
    }
}
