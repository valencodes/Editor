using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class fmPresentacion : Form
    {
        private void Mitimer_Tick(object sender, EventArgs e)
        {
            Close(); //Trancurridos 2 segundos cerramos el formulario 
        }
        public fmPresentacion()
        {
            InitializeComponent();
        }

        private void fmPresentacion_Load(object sender, EventArgs e)
        {
            Timer mitimer = new Timer(); // Creamos objeto temporizador
            mitimer.Tick += Mitimer_Tick; // creamos evento por código
            mitimer.Interval = 2000; //Asignamos intervalo en milésimas de segundo
            mitimer.Enabled = true; //Habilitamos temporizador
            mitimer.Start(); // Iniciamos el temporizador
        }
    }
}
