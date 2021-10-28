using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.Interface;
using Infraestructura;

namespace ActivoFijoApp
{
    public partial class Form1 : Form
    {
        IActivoFijo activo;

        public Form1(IActivoFijo a)
        {
            activo = a;
            InitializeComponent();
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            
            FormNew form = new FormNew();
            form.activo = activo;
            form.ShowDialog();
            richTextBox1.Text = activo.mostrar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
