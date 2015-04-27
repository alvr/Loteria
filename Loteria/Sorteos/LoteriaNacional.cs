using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loteria.Sorteos
{
    public partial class LoteriaNacional : Form
    {
        public LoteriaNacional()
        {
            InitializeComponent();
        }

        private void MenuInicio_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Se perderán todos los datos introducidos, ¿continuar?", "Modo aleatorio", MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                Principal p = new Principal();
                p.Show();
                this.Close();
            }
        }

        private void MenuVolver_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Se perderán todos los datos introducidos, ¿continuar?", "Modo aleatorio", MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                Jugar j = new Jugar();
                j.Show();
                this.Close();
            }
        }

        private void Comprar(object sender, EventArgs e)
        {
            Pagar p = new Pagar();
            p.Show();
            this.Close();
        }
    }
}
