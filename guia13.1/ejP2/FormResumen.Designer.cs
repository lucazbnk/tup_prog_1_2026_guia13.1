namespace ejP2
{
    partial class FormResumen
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
            lsbPatentes = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lsbPatentes
            // 
            lsbPatentes.FormattingEnabled = true;
            lsbPatentes.Location = new Point(12, 12);
            lsbPatentes.Name = "lsbPatentes";
            lsbPatentes.Size = new Size(314, 154);
            lsbPatentes.TabIndex = 0;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(125, 172);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormResumen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 203);
            Controls.Add(button1);
            Controls.Add(lsbPatentes);
            Name = "FormResumen";
            Text = "FormResumen";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        public ListBox lsbPatentes;
    }
}