namespace Editor
{
    partial class fmMargenes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbIzquierdo = new System.Windows.Forms.ComboBox();
            this.cbDerecho = new System.Windows.Forms.ComboBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce Márgenes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Izquierdo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Derecho";
            // 
            // cbIzquierdo
            // 
            this.cbIzquierdo.FormattingEnabled = true;
            this.cbIzquierdo.Location = new System.Drawing.Point(54, 97);
            this.cbIzquierdo.Name = "cbIzquierdo";
            this.cbIzquierdo.Size = new System.Drawing.Size(64, 21);
            this.cbIzquierdo.TabIndex = 1;
            // 
            // cbDerecho
            // 
            this.cbDerecho.FormattingEnabled = true;
            this.cbDerecho.Location = new System.Drawing.Point(149, 97);
            this.cbDerecho.Name = "cbDerecho";
            this.cbDerecho.Size = new System.Drawing.Size(64, 21);
            this.cbDerecho.TabIndex = 1;
            // 
            // btAceptar
            // 
            this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(33, 153);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(85, 32);
            this.btAceptar.TabIndex = 2;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(151, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fmMargenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 214);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.cbDerecho);
            this.Controls.Add(this.cbIzquierdo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmMargenes";
            this.Text = "Margenes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox cbDerecho;
        public System.Windows.Forms.ComboBox cbIzquierdo;
    }
}