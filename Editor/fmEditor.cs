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
    public partial class fmEditor : Form
    {
        public fmEditor()
        {
            InitializeComponent();
            Application.Idle += AplicacionOciosa;
        }
        private void AplicacionOciosa(object sender, EventArgs e)
        {
            // Extraemos número de línea y columna de la posición actual del 
            // cursor en el editor
            int linea = rtbEditor.GetLineFromCharIndex(rtbEditor.SelectionStart);
            int columna = rtbEditor.SelectionStart -
            rtbEditor.GetFirstCharIndexOfCurrentLine();
            // Los Mostramos en el statusLabel 2 de la barra de estado 
            // usando la matriz ítem que forman
            stEstadoEditor.Items[1].Text = "Lín." + Convert.ToString(linea + 1) +
            " Col." + Convert.ToString(columna);

            stEstadoEditor.Items[2].Text = "Car. " + //Posición absoluta del cursor
            Convert.ToString(rtbEditor.SelectionStart);
            // Asignamos valor (true/false) a variable en función de si hay 
            // selección de texto
            bool HaySeleccion = rtbEditor.SelectionLength > 0;
            if (HaySeleccion) // Mostramos mensaje explicativo en barra de estado.
            { // en el primer ítem
                stEstadoEditor.Items[0].Text = "Hay Texto seleccionado";
            }
            // habilitamos botones o no según se dan las condiciones
            tsbCopiar.Enabled = HaySeleccion; //Habilitados si hay 
            tsbCortar.Enabled = HaySeleccion; // texto seleccionado
            tsbDeshacer.Enabled = rtbEditor.CanUndo; // Si hay algo para deshacer
            tsbRehacer.Enabled = rtbEditor.CanRedo; // o rehacer

            tsbPegar.Enabled = Clipboard.ContainsText();//Si hay texto en el 
                                                        // portapapeles
                                                        // También Habilitamos o no los correspondientes ítems de menú
            itBorrar.Enabled = HaySeleccion;
            itPegar.Enabled = tsbPegar.Enabled;
            itCopiar.Enabled = tsbCopiar.Enabled;
            itCortar.Enabled = tsbCortar.Enabled;
            itDeshacer.Enabled = tsbDeshacer.Enabled;
            itRehacer.Enabled = tsbRehacer.Enabled;
        }

        private void tamanyosestado()
        { //Asignamos width a través de la matriz ítem que forman los StatusLabel 
          // en la barra de estado
            stEstadoEditor.Items[0].Width = Width - 350;
            stEstadoEditor.Items[1].Width = 100;
            stEstadoEditor.Items[2].Width = 60;
            stEstadoEditor.Items[3].Width = 70;
            stEstadoEditor.Items[4].Width = 90;
        }

        void desmarca()
        {
            tsbIzquierda.Checked = false;
            tsbCentrado.Checked = false;
            tsbDerecha.Checked = false;
            for (int i = 0; i < itJustificacion.DropDownItems.Count; i++)
            {//recorre los ítems que tiene itJustificacion 
                ((ToolStripMenuItem)itJustificacion.DropDownItems[i]).Checked = false;
            }
        }


        private void fmEditor_Resize(object sender, EventArgs e)
        {
            tamanyosestado();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void tsBarraEstandar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fmEditor_Load(object sender, EventArgs e)
        {

            // Cargamos el combobox de las fuentes con las instaladas en el sistema
            foreach (FontFamily misfuentes in FontFamily.Families)
            {
                cbFuentes.Items.Add(misfuentes.Name);
            }
            // Elegimos una fuente por defecto
            cbFuentes.Text = "Microsoft Sans Serif";

            // Ponemos tamaño elegido 
            cbTamanyo.Text = "8";

            tamanyosestado();
            foreach (FontFamily misfuentes in FontFamily.Families)
            { // Cargamos fuentes del sistema en ComboBox
                cbFuentes.Items.Add(misfuentes.Name);
            }
            Text = "Documento1";//Asignamos nombre por defecto al archivo, 
                                //que se usará al guardar y lo mostramos en la barra de título 
            rtbEditor.ClearUndo(); // limpiamos buffer deshacer
            itQuitarFormatos.PerformClick(); //Invocamos este evento click 
                                             // que asigna valores por defecto iniciales
            rtbEditor.Modified = false; //Modificaciones en editor a false 
                                        // significa que no hay cambios y a true, que se han producido cambios
            rtbEditor.Focus(); //Enviamos foco al Richtextbox
        }

        private void itQuitarFormatos_Click(object sender, EventArgs e)
        {
            // Marcamos y desmarcamos ítems de menú y botones para que 
            // indiquen valores iniciales
            itIzquierda.Checked = true;
            tsbIzquierda.Checked = true;
            tsbNegrita.Checked = false;
            tsbCursiva.Checked = false;
            tsbSubrayado.Checked = false;
            tsbTachado.Checked = false;
            tsbCopiarFormatos.Checked = false;
            // Asignamos a los controles y al RichTextBox los valores 
            // iniciales elegidos para el tipo de fuente
            FontStyle estilo = new FontStyle();
            rtbEditor.SelectionFont = new Font("Arial", 10, estilo);
            rtbEditor.SelectionColor = Color.Black;
            rtbEditor.SelectionAlignment = HorizontalAlignment.Left;
            cbFuentes.SelectedIndex = cbFuentes.Items.IndexOf("Arial");
            cbTamanyo.Text = "10";
            //Lo mismo para el resto de configuraciones del editor 
            rtbEditor.BackColor = Color.White;
            rtbEditor.SelectionRightIndent = 0;
            rtbEditor.SelectionIndent = 0;
            rtbEditor.SelectionBullet = false;
            itVietas.Checked = false;
        }

        private void timeEditor_Tick(object sender, EventArgs e)
        {
            //Obtenemos fecha/hora actual y 
            DateTime fecha = DateTime.Now; // la mostramos formateada 
            stEstadoEditor.Items[3].Text = fecha.ToString("dd/MM/yyyy");
            stEstadoEditor.Items[4].Text = fecha.ToString("HH:mm:ss");
        }

        private void tsbNegrita_Click(object sender, EventArgs e)
        {
            int comienzoSeleccion = rtbEditor.SelectionStart;
            int longitudSeleccion = rtbEditor.SelectionLength;
            int finalSeleccion = comienzoSeleccion + longitudSeleccion;

            // Verifica si hay texto seleccionado
            if (longitudSeleccion > 0)
            {
                FontStyle negrita = new FontStyle();//Variables para establecer el estilo 
                FontStyle subrayado = new FontStyle();//de fuente de un texto seleccionado
                FontStyle tachado = new FontStyle();//FontStyle Define una estructura que 
                FontStyle cursiva = new FontStyle(); // representa el estilo de una fuente

                if (tsbNegrita.Checked)// En función de los checkBox y de su marca 
                { // asignamos valor a variables o no 
                    negrita = FontStyle.Bold;
                }
                if (tsbSubrayado.Checked)
                {
                    subrayado = FontStyle.Underline;
                }
                if (tsbTachado.Checked)
                {
                    tachado = FontStyle.Strikeout;
                }
                if (tsbCursiva.Checked)
                {
                    cursiva = FontStyle.Italic;
                }
                for (int x = comienzoSeleccion; x < finalSeleccion; ++x)
                {
                    rtbEditor.Select(x, 1); // Seleccionamos caracter por caracter

                    // Aplica los estilos al caracter
                    rtbEditor.SelectionFont = 
                        new Font(rtbEditor.SelectionFont.Name, rtbEditor.SelectionFont.Size, negrita | subrayado | tachado | cursiva);
                }
                // Restaura la selección original después de realizar cambios
                rtbEditor.Select(comienzoSeleccion, longitudSeleccion);
            }
            rtbEditor.Focus();
        }

        private void tsbIzquierda_Click(object sender, EventArgs e)
        {
            desmarca();
            tsbIzquierda.Checked = true;
            itIzquierda.Checked = true;
            rtbEditor.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void tsbCentrado_Click(object sender, EventArgs e)
        {
            desmarca();
            tsbCentrado.Checked = true;
            itCentrado.Checked = true;
            rtbEditor.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void tsbDerecha_Click(object sender, EventArgs e)
        {
            desmarca();
            tsbDerecha.Checked = true;
            itDerecha.Checked = true;
            rtbEditor.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void cbFuentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int comienzoSeleccion = rtbEditor.SelectionStart;
            int longitudSeleccion = rtbEditor.SelectionLength;
            int finalSeleccion = comienzoSeleccion + longitudSeleccion;
            for (int x = comienzoSeleccion; x < finalSeleccion; ++x)
            {
                rtbEditor.Select(x, 1); //Seleccionamos caracter por caracter
                                        // Cambiamos la fuente al caracter
                rtbEditor.SelectionFont = new Font(cbFuentes.Text,
             rtbEditor.SelectionFont.Size, rtbEditor.SelectionFont.Style);
            }//Aplicamos nuevo tipo de fuente dejando estilo y tamaño anterior
            rtbEditor.Focus();
        }

        private void cbTamanyo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int comienzoSeleccion = rtbEditor.SelectionStart;
            int longitudSeleccion = rtbEditor.SelectionLength;
            int finalSeleccion = comienzoSeleccion + longitudSeleccion;
            for (int x = comienzoSeleccion; x < finalSeleccion; ++x)
            {
                rtbEditor.Select(x, 1); //Seleccionamos caracter por caracter
                                        // Cambiamos la fuente al caracter
                rtbEditor.SelectionFont = new Font(rtbEditor.SelectionFont.Name,
                Convert.ToInt32(cbTamanyo.Text), rtbEditor.SelectionFont.Style);
            }
        }

        private void cbTamanyo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni Enter, desecha la tecla presionada
                e.Handled = true;
            }

            // Si se presiona Enter, enviar el foco a rtbEditor
            if (e.KeyChar == (char)Keys.Enter)
            {
                rtbEditor.Focus();
            }
        }

        private void cbTamanyo_TextChanged(object sender, EventArgs e)
        {
            int comienzoSeleccion = rtbEditor.SelectionStart;
            int longitudSeleccion = rtbEditor.SelectionLength;
            int finalSeleccion = comienzoSeleccion + longitudSeleccion;
            for (int x = comienzoSeleccion; x < finalSeleccion; ++x)
            {
                rtbEditor.Select(x, 1); //Seleccionamos caracter por caracter
                                        // Cambiamos la fuente al caracter
                rtbEditor.SelectionFont = new Font(rtbEditor.SelectionFont.Name,
                Convert.ToInt32(cbTamanyo.Text), rtbEditor.SelectionFont.Style);
            }
        }

        private void cbTamanyo_Click(object sender, EventArgs e)
        {

        }

        private void tsbColores_Click(object sender, EventArgs e)
        {
            dlgColor.Color = rtbEditor.SelectionColor; //Asignamos color de la 
                                                       // fuente para que el diálogo lo tenga seleccionado
            if (dlgColor.ShowDialog() == DialogResult.OK) //Ejecutamos el diálogo
            { // Si se ha pulsado el botón Aceptar, aplicamos el color del diálogo 
                rtbEditor.SelectionColor = dlgColor.Color; // al texto seleccionado
                rtbEditor.Modified = true;
            }
        }

        private void itColorFondo_Click(object sender, EventArgs e)
        {
            dlgColor.Color = rtbEditor.BackColor;
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                rtbEditor.BackColor = dlgColor.Color;
                rtbEditor.Modified = true;
            }
        }

        private void itAbrir_Click(object sender, EventArgs e)
        {
            stEstadoEditor.Items[0].Text = "Abriendo Archivo de diferentes formatos";
            if (rtbEditor.Modified) // True si hay cambios sobre el editor
            {
                DialogResult resultado = MessageBox.Show("Hay Cambios sin Guardar.Guardas ? ", "Guardar Cambios", MessageBoxButtons.YesNoCancel); 
            switch (resultado)
                {
                    case DialogResult.Yes: // Si contesta si
                        itGuardar.PerformClick();// Invocamos evento botón guardar 
                        break; //Después de Guardar Continuamos con operación de abrir
                    case DialogResult.Cancel: // Si decide cancelar
                        rtbEditor.Focus(); // Enviamos foco al editor
                        return; // Abortamos operación de abrir
                }
            }
            if (dlgAbrir.ShowDialog() == DialogResult.OK // Mostramos diálogo
            && dlgAbrir.FileName.Length > 0)
            { // Si ha pulsado aceptar y elegido un archivo
                if (dlgAbrir.FilterIndex == 1)
                { //Abrimos archivo elegido en el diálogo que tiene FileName
                    rtbEditor.LoadFile(dlgAbrir.FileName, //Parámetro 2 indica 
                    RichTextBoxStreamType.PlainText); //formato contenido 
                }
                else
                {
                    rtbEditor.LoadFile(dlgAbrir.FileName, // Lo mismo con rtf
                    RichTextBoxStreamType.RichText);
                }
                Text = dlgAbrir.FileName; //Mostramos nuevo nombre en barra título
                rtbEditor.Modified = false; //Sin cambios pendientes de guardar
            }
            stEstadoEditor.Items[0].Text = "";
            itQuitarFormatos.PerformClick(); //Asignamos valores iniciales al editor 
            rtbEditor.Focus();
        }
    }
}
