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
    public partial class BonoLoto : Form
    {
        public BonoLoto()
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

        private void button2_Click(object sender, EventArgs e)
        {
            Pagar p = new Pagar();
            p.Show();
            this.Close();
        }

        private void marcar(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
                cb.BackgroundImage = Properties.Resources._Marcar;
            else
                cb.BackgroundImage = null;
        }

        bool isChecked = false;

        private void marcar2(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
                rb.BackgroundImage = Properties.Resources._Marcar;
            else
                rb.BackgroundImage = null;

            isChecked = rb.Checked;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked && !isChecked)
                rb.Checked = false;
            else
            {
                rb.Checked = true;
                isChecked = false;
            }
        }

    }
}
