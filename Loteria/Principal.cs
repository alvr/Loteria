using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Loteria.Sorteos;

namespace Loteria
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void ImgLoteriaNacional_Click(object sender, EventArgs e)
        {
            LoteriaNacional ln = new LoteriaNacional();
            ln.Show();
        }

        private void ImgLaPrimitiva_Click(object sender, EventArgs e)
        {
            Primitiva p = new Primitiva();
            p.Show();
        }

        private void ImgBonoLoto_Click(object sender, EventArgs e)
        {
            BonoLoto bl = new BonoLoto();
            bl.Show();
        }

        private void ImgLaQuiniela_Click(object sender, EventArgs e)
        {
            Quiniela q = new Quiniela();
            q.Show();
        }

        private void ImgONCE_Click(object sender, EventArgs e)
        {
            ONCE once = new ONCE();
            once.Show();
        }
    }
}
