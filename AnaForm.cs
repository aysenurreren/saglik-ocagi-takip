using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOHBTS
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void hastaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaIslemleri frm = new HastaIslemleri();
            frm.MdiParent = this; 
            frm.Show();
        }

        private void poliklinikTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPoliklinik frm = new frmPoliklinik();
            frm.MdiParent = this;
            frm.Show();
        }

        private void hastaKabulToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void referanslarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRaporlar frm = new frmRaporlar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void doktorTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoktorTanitma drForm = new frmDoktorTanitma();
            drForm.Show(); 
        }

        private void kullanıcıTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullaniciTanitma klncForm = new frmKullaniciTanitma();
            klncForm.Show();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
