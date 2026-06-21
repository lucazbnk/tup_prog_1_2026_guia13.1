namespace ejP2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRegistrar = new Button();
            btnCargar = new Button();
            btnResumen = new Button();
            btnSalir = new Button();
            lsbPatentes = new ListBox();
            label1 = new Label();
            lbCantViajes = new Label();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(12, 12);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(12, 41);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar viaje";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(12, 70);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(75, 23);
            btnResumen.TabIndex = 2;
            btnResumen.Text = "Resumen final";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click;
            // 
            // btnSalir
            // 
            btnSalir.DialogResult = DialogResult.Cancel;
            btnSalir.Location = new Point(12, 99);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lsbPatentes
            // 
            lsbPatentes.FormattingEnabled = true;
            lsbPatentes.Location = new Point(93, 12);
            lsbPatentes.Name = "lsbPatentes";
            lsbPatentes.Size = new Size(176, 94);
            lsbPatentes.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 109);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Viajes:";
            // 
            // lbCantViajes
            // 
            lbCantViajes.AutoSize = true;
            lbCantViajes.Location = new Point(139, 109);
            lbCantViajes.Name = "lbCantViajes";
            lbCantViajes.Size = new Size(13, 15);
            lbCantViajes.TabIndex = 6;
            lbCantViajes.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 137);
            Controls.Add(lbCantViajes);
            Controls.Add(label1);
            Controls.Add(lsbPatentes);
            Controls.Add(btnSalir);
            Controls.Add(btnResumen);
            Controls.Add(btnCargar);
            Controls.Add(btnRegistrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Button btnCargar;
        private Button btnResumen;
        private Button btnSalir;
        private ListBox lsbPatentes;
        private Label label1;
        private Label lbCantViajes;
    }
}
