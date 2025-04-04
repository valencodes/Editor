﻿using ElFormulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Editor
{
    public partial class fmEditor : Form
    {
        string[] linea; // Vector para contener las líneas
        int totalLineasImpresas; // Controla líneas impresas
        FontStyle miestilo = new FontStyle();
        string mifuente;
        float mitamanyo;
        Color micolor;
        public fmEditor()
        {
            InitializeComponent();
            Application.Idle += AplicacionOciosa;
        }

        fmDatos VentanaIntroduccion = new fmDatos();
        fmMargenes VentanaMargenes = new fmMargenes();
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
        private void itNuevo_Click(object sender, EventArgs e)
        {
            stEstadoEditor.Items[0].Text = "Generando un documento nuevo, guardando el anterior si procede";
            if (rtbEditor.Modified) // True si ha habido cambios en el editor
            {
                DialogResult resultado = MessageBox.Show("Hay Cambios pendientes de Guardar.Guardas ? ", "Guardar Cambios", MessageBoxButtons.YesNoCancel);
                switch (resultado)
                {
                    case DialogResult.Yes: //Si contesta sí guardamos
                        itGuardar.PerformClick();//De guardar puede ir a Guarda como
                        break;
                    case DialogResult.Cancel: //Cancela operación de nuevo documento
                        rtbEditor.Focus();
                        return; // Salimos de la función
                }
            } // Si ha contestado si o no, iniciamos nuevo documento
            rtbEditor.Clear(); //Borra todo el contenido del editor
            Text = "Documento2"; //Propone un nuevo nombre y lo asigna al título
            itQuitarFormatos.PerformClick(); // Ponemos valores por defecto
            rtbEditor.Modified = false; // De momento no hay cambios pendientes
            stEstadoEditor.Items[0].Text = "";
        }


        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Asignamos tipo de fuente y color al dialogo para que el 
            // diálogo los muestre y estén marcados
            dlgFuentes.Color = rtbEditor.SelectionColor;
            dlgFuentes.Font = rtbEditor.SelectionFont;
            if (dlgFuentes.ShowDialog() == DialogResult.OK)
            { // Si pulsa Aceptar aplicamos cambios al texto seleccionado
                rtbEditor.SelectionFont = dlgFuentes.Font;
                rtbEditor.SelectionColor = dlgFuentes.Color;
                rtbEditor_SelectionChanged(sender, e);//Marcamos controles 
                                                      // con cambios elegidos en diálogo 
                rtbEditor.Modified = true;
            }
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

        private void itGuardar_Click(object sender, EventArgs e)
        {
            if (Text == "Documento1")
            {
                itGuardarComo.PerformClick();
            }
            else
            { // La comprobación, si es texto plano o rtf en guardar como
                rtbEditor.SaveFile(Text);
                rtbEditor.Modified = false;
                rtbEditor.Focus();
            }
        }

        private void itGuardarComo_Click(object sender, EventArgs e)
        {
            dlgGuardar.FileName = Text; //Asignamos nombre del text del formulario 
                                        // a la propiedad FileName del diálogo
            if (dlgGuardar.ShowDialog() == DialogResult.OK && //Si pulsa Aceptar 
             dlgGuardar.FileName.Length > 0) // y hay nombre asignado
            {
                if (dlgGuardar.FilterIndex == 1) //Averiguamos formato elegido
                {
                    rtbEditor.SaveFile(dlgGuardar.FileName, //Texto plano
                    RichTextBoxStreamType.PlainText);
                }
                else
                {
                    rtbEditor.SaveFile(dlgGuardar.FileName, // Texto enriquecido
                    RichTextBoxStreamType.RichText);
                }
                Text = dlgGuardar.FileName; //Ponemos en barra de título del 
                                            // formulario el nombre por si ha cambiado
                rtbEditor.Modified = false;
            }

        }

        private void fmEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Si hay cambios pendientes y hay algo escrito en el editor
            if ((rtbEditor.Modified) && (rtbEditor.Text.Length > 0))
            {
                DialogResult resultado = MessageBox.Show("Hay Cambios pendientes de Guardar.Guardas ? ", "Guardar Cambios", MessageBoxButtons.YesNoCancel);
                switch (resultado)
                {
                    case DialogResult.Yes:
                        itGuardar.PerformClick();
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true; //anula el cierre del formulario
                        rtbEditor.Focus();
                        break;
                }

            }
        }

        private void itImprimir_Click(object sender, EventArgs e)
        {
            if (dlgImprimir.ShowDialog() == DialogResult.OK)
            { // Si se pulsó el botón "Aceptar" , entonces imprimir.
                string texto = rtbEditor.Text;
                char[] seps = { '\n', '\r' }; // LF y CR separadores de líneas
                linea = texto.Split(seps); //Convertimos texto en vector
                totalLineasImpresas = 0;
                prindocEditor.Print(); //invoca al otro componente necesario
            }
        }

        private void prindocEditor_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Variables para líneas por página, posición línea Y , márgenes
            float lineasPorPag;
            float pos_Y;
            float margenIzq = e.MarginBounds.Left; //Obtenemos estos datos por 
            float margenSup = e.MarginBounds.Top; // defecto del parámetro
                                                  // Calculamos el número de líneas por página según tamaño fuente. 
                                                  // Los datos de la fuente son los de rtbEditor.Font,salvo el color
            Font fuente = rtbEditor.Font;
            float altoFuente = fuente.GetHeight(e.Graphics);
            lineasPorPag = e.MarginBounds.Height / altoFuente;
            int lineasImpresasPorPag = 0;//Contador de líneas impresas en 1 página
            while (totalLineasImpresas < linea.Length &&
            lineasImpresasPorPag < lineasPorPag)
            { // Imprimir cada una de las líneas
                pos_Y = margenSup + (lineasImpresasPorPag * altoFuente); //Pos.Línea 

                // Método que Dibuja la cadena de texto indicada en la ubicación 
                //seleccionada, con objetos brush, Font y format pasados como parámetros
                e.Graphics.DrawString(linea[totalLineasImpresas], fuente,
                Brushes.Black, margenIzq, pos_Y, new StringFormat());
                lineasImpresasPorPag += 1; // Líneas en una pág.
                totalLineasImpresas += 1; // Total líneas impresas
            }
            // Si quedan líneas por imprimir, siguiente página
            if (totalLineasImpresas < linea.Length)
                e.HasMorePages = true; // se invoca de nuevo prinDocEditor_PrintPage
            else
                e.HasMorePages = false; // finaliza la impresión
        }

        private void itFormatoPagina_Click(object sender, EventArgs e)
        {
            dlgFuentes.Color = rtbEditor.ForeColor;
            dlgFuentes.Font = rtbEditor.Font;

            if (dlgFuentes.ShowDialog() == DialogResult.OK)
            {
                // Aplicamos cambios
                rtbEditor.Font = dlgFuentes.Font;
                rtbEditor.ForeColor = dlgFuentes.Color;
                rtbEditor.Modified = true;
            }
        }

        private void rtbEditor_SelectionChanged(object sender, EventArgs e)
        {
            try// Asignamos valores de tamaño, viñetas, estilo y fuente a botones
            { // e ítems de menú correspondientes, extraídos de Selection y ……. 
                cbTamanyo.Text =
                Convert.ToString(Math.Truncate(rtbEditor.SelectionFont.Size));
                itVietas.Checked = rtbEditor.SelectionBullet;
                tsbNegrita.Checked = rtbEditor.SelectionFont.Bold;
                tsbSubrayado.Checked = rtbEditor.SelectionFont.Underline;
                tsbTachado.Checked = rtbEditor.SelectionFont.Strikeout;
                tsbCursiva.Checked = rtbEditor.SelectionFont.Italic;
                cbFuentes.SelectedIndex =
                cbFuentes.Items.IndexOf(rtbEditor.SelectionFont.Name);
            }
            catch
            {
                return;
            }
            // Marcamos botones e ítems de menú de alineación, según esté en el 
            // párrafo o línea.
            tsbIzquierda.Checked = rtbEditor.SelectionAlignment ==
            HorizontalAlignment.Left;
            tsbDerecha.Checked = rtbEditor.SelectionAlignment ==
            HorizontalAlignment.Right;
            tsbCentrado.Checked = rtbEditor.SelectionAlignment ==
            HorizontalAlignment.Center;
            itIzquierda.Checked = tsbIzquierda.Checked;
            itDerecha.Checked = tsbDerecha.Checked;
            itCentrado.Checked = tsbCentrado.Checked;

        }

        private void itCortar_Click(object sender, EventArgs e)
        {
            rtbEditor.Cut();
        }

        private void itCopiar_Click(object sender, EventArgs e)
        {
            rtbEditor.Copy();
        }

        private void itPegar_Click(object sender, EventArgs e)
        {
            rtbEditor.Paste();
        }

        private void itDeshacer_Click(object sender, EventArgs e)
        {
            if (rtbEditor.CanUndo)
            {
                rtbEditor.Undo();
            }
        }

        private void itRehacer_Click(object sender, EventArgs e)
        {
            if (rtbEditor.CanRedo)
            {
                rtbEditor.Redo();
            }
        }

        private void itSeleccionar_Click(object sender, EventArgs e)
        {
            rtbEditor.SelectAll();
        }

        private void itBorrar_Click(object sender, EventArgs e)
        {
            if (rtbEditor.SelectionLength > 0)
            {
                rtbEditor.SelectedText = "";
            }

        }

        private void itIr_Click(object sender, EventArgs e)
        {
            VentanaIntroduccion.tbDato.Clear();// TextBox de fmDatos recordar debe 
                                               // estar modifiers=public
            if (VentanaIntroduccion.ShowDialog() == DialogResult.OK)
            {
                int numlinea = 0, conta = 0, acumula = 0;
                try
                { // Convertimos a entero número línea tecleado
                    numlinea = Convert.ToInt32(VentanaIntroduccion.tbDato.Text);
                }
                catch (Exception mierror)
                {
                    MessageBox.Show(mierror.Message);
                }
                // Mientras es menor que número de línea tecleado y hay líneas
                while ((conta < (numlinea - 1)) && (conta <
                (rtbEditor.Lines.Length - 1)))
                {//Acumulamos los caracteres +1 <intro> de las líneas anteriores a 
                    acumula += ((rtbEditor.Lines[conta].Length) + 1);//la solicitada
                    conta++;
                } // Enviamos cursor al primer carácter de la línea
                rtbEditor.SelectionStart = acumula;
            }
        }

        private void itMargenes_Click(object sender, EventArgs e)
        {
            // Ponemos valores actuales de márgenes en los comboBox del 
            // formulario antes de que se muestre
            VentanaMargenes.cbIzquierdo.Text =
            Convert.ToString(rtbEditor.SelectionIndent);
            VentanaMargenes.cbDerecho.Text =
            Convert.ToString(rtbEditor.SelectionRightIndent);
            // Mostramos formulario
            if (VentanaMargenes.ShowDialog() == DialogResult.OK)
            { // Si el usuario ha pulsado Aceptar aplicamos márgenes con 
              // los valores tecleados en el formulario indicado 
                rtbEditor.SelectionRightIndent =
                Convert.ToInt32(VentanaMargenes.cbDerecho.Text);
                rtbEditor.SelectionIndent =
                Convert.ToInt32(VentanaMargenes.cbIzquierdo.Text);
                rtbEditor.Modified = true;
            }
        }

        private void itVietas_Click(object sender, EventArgs e)
        {
            itVietas.Checked = !itVietas.Checked;
            rtbEditor.SelectionBullet = itVietas.Checked;
            rtbEditor.Modified = true;
        }

        private void itBarraEstandar_Click(object sender, EventArgs e)
        {
            // Marcamos ítems de ambos menús
            itBarraEstandar.Checked = !itBarraEstandar.Checked;
            itcBarraEstandar.Checked = !itcBarraEstandar.Checked;
            // Mostramos barra correspondiente o no
            tsBarraEstandar.Visible = itBarraEstandar.Checked;
        }

        private void itBarraFormato_Click(object sender, EventArgs e)
        {
            // Marcamos ítems de ambos menús
            itBarraFormato.Checked = !itBarraFormato.Checked;
            itcBarraFormato.Checked = !itcBarraFormato.Checked;
            // Mostramos barra correspondiente o no
            tsBarraFormato.Visible = itBarraFormato.Checked;

        }

        private void itBarraEstado_Click(object sender, EventArgs e)
        {
            // Marcamos ítems de ambos menús
            itBarraEstado.Checked = !itBarraEstado.Checked;
            itcBarraEstado.Checked = !itcBarraEstado.Checked;
            // Mostramos barra correspondiente o no
            stEstadoEditor.Visible = itBarraEstado.Checked;

        }

        private void tsbCopiarFormatos_Click(object sender, EventArgs e)
        {
            //Poner propiedad CheckOnClick=true para evitar poner código de marcado
            if (tsbCopiarFormatos.Checked)
            { // Aviso en barra de estado de botón pulsado y acción a realizar
                stEstadoEditor.Items[0].Text = "Vas a copiar formato a la nueva ubicación, donde hagas click"; 
            }
            else
            {
                stEstadoEditor.Items[0].Text = "";
            }
            //Si el botón de copiar formatos está pulsado, guardamos los formatos
            miestilo = rtbEditor.SelectionFont.Style; //Variables globales
            mifuente = rtbEditor.SelectionFont.Name;
            mitamanyo = rtbEditor.SelectionFont.Size;
            micolor = rtbEditor.SelectionColor;
        }

        private void rtbEditor_MouseDown(object sender, MouseEventArgs e)
        {
            stEstadoEditor.Items[0].Text = "Si el botón de copiar formatos está pulsado se aplicarán los formatos copiados"; 
            if (tsbCopiarFormatos.Checked) //Si está pulsado se aplicarán formatos
            {
                rtbEditor.SelectionFont = new Font(mifuente, mitamanyo, miestilo);
                rtbEditor.SelectionColor = micolor;
            }

        }

        private void tsbNegrita_MouseHover(object sender, EventArgs e)
        {
            if (sender == tsbNegrita)
            {
                stEstadoEditor.Items[0].Text = "Aplica Negrita al Texto";
            }
            else if (sender == tsbSubrayado)
            {
                stEstadoEditor.Items[0].Text = "Aplica Subrayado al Texto";
            }
            else if (sender == tsbTachado)
            {
                stEstadoEditor.Items[0].Text = "Aplica Tachado al Texto";
            }
            else if (sender == tsbCursiva)
            {
                stEstadoEditor.Items[0].Text = "Aplica Cursiva al Texto";
            }
            else if (sender == tsbIzquierda)
            {
                stEstadoEditor.Items[0].Text = "Justifica el texto a la izquierda";
            }
            else if (sender == tsbCentrado)
            {
                stEstadoEditor.Items[0].Text = "Justifica el texto al centro";
            }
            else if (sender == tsbDerecha)
            {
                stEstadoEditor.Items[0].Text = "Justifica el texto a la derecha";
            }
            else if (sender == cbFuentes)
            {
                stEstadoEditor.Items[0].Text = "Selecciona una fuente para el texto";
            }
            else if (sender == cbTamanyo)
            {
                stEstadoEditor.Items[0].Text = "Selecciona un tamaño para el texto";
            }
            else if (sender == tsbColores)
            {
                stEstadoEditor.Items[0].Text = "Selecciona un color para el texto";
            }
            else if (sender == tsbNuevo)
            {
                stEstadoEditor.Items[0].Text = "Crea un nuevo documento";
            }
            else if (sender == tsbAbrir)
            {
                stEstadoEditor.Items[0].Text = "Abre un documento existente";
            }
            else if (sender == tsbGuardar)
            {
                stEstadoEditor.Items[0].Text = "Guarda los cambios";
            }
            else if (sender == tsbImprimir)
            {
                stEstadoEditor.Items[0].Text = "Imprime el documento";
            }
            else if (sender == tsbCortar)
            {
                stEstadoEditor.Items[0].Text = "Corta el texto seleccionado";
            }
            else if (sender == tsbCopiar)
            {
                stEstadoEditor.Items[0].Text = "Copia el texto selecionado";
            }
            else if (sender == tsbPegar)
            {
                stEstadoEditor.Items[0].Text = "Pega el texto del portapapeles";
            }
            else if (sender == tsbDeshacer)
            {
                stEstadoEditor.Items[0].Text = "Deshace los cambios";
            }
            else if (sender == tsbRehacer)
            {
                stEstadoEditor.Items[0].Text = "Rehace los cambios";
            }
            else if (sender == tsbCopiarFormatos)
            {
                stEstadoEditor.Items[0].Text = "Copia el formato del texto";
            }
            else if (sender == tsbQuitarFormatos)
            {
                stEstadoEditor.Items[0].Text = "Quita el formato al texto";
            }
        }

        private void sl3_Click(object sender, EventArgs e)
        {

        }

        private void itAcercaDe_Click(object sender, EventArgs e)
        {
            new fmAcercade().ShowDialog();
        }

        private void itAyuda_Click(object sender, EventArgs e)
        {
            
        }

        private void itAyudaGeneral_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"AyudaDanielaVGaleote.chm");
        }

        private void itIndiceAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelpIndex(this, @"AyudaDanielaVGaleote.chm");
        }
    }
}
