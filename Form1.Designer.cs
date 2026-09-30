namespace Cifrador_Cesar
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
            label1 = new Label();
            titulo1 = new Label();
            MensajeACifrar = new TextBox();
            buttonCifrar = new Button();
            numericUpDown1 = new NumericUpDown();
            titulo2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(292, 221);
            label1.Name = "label1";
            label1.Size = new Size(0, 37);
            label1.TabIndex = 0;
            // 
            // titulo1
            // 
            titulo1.AutoSize = true;
            titulo1.Font = new Font("Segoe UI", 20F);
            titulo1.Location = new Point(292, 160);
            titulo1.Name = "titulo1";
            titulo1.Size = new Size(173, 37);
            titulo1.TabIndex = 1;
            titulo1.Text = "Texto Cifrado";
            // 
            // MensajeACifrar
            // 
            MensajeACifrar.Location = new Point(304, 64);
            MensajeACifrar.Name = "MensajeACifrar";
            MensajeACifrar.Size = new Size(161, 23);
            MensajeACifrar.TabIndex = 2;
            MensajeACifrar.Text = "Texto a Cifrar";
            // 
            // buttonCifrar
            // 
            buttonCifrar.Location = new Point(322, 106);
            buttonCifrar.Name = "buttonCifrar";
            buttonCifrar.Size = new Size(110, 35);
            buttonCifrar.TabIndex = 3;
            buttonCifrar.Text = "Calcular";
            buttonCifrar.UseVisualStyleBackColor = true;
            buttonCifrar.Click += buttonCifrar_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 15F);
            numericUpDown1.Location = new Point(585, 64);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 34);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // titulo2
            // 
            titulo2.AutoSize = true;
            titulo2.Font = new Font("Segoe UI", 20F);
            titulo2.Location = new Point(494, 9);
            titulo2.Name = "titulo2";
            titulo2.Size = new Size(176, 37);
            titulo2.TabIndex = 5;
            titulo2.Text = "Clave Cifrado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(titulo2);
            Controls.Add(numericUpDown1);
            Controls.Add(buttonCifrar);
            Controls.Add(MensajeACifrar);
            Controls.Add(titulo1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label titulo1;
        private TextBox MensajeACifrar;
        private Button buttonCifrar;
        private NumericUpDown numericUpDown1;
        private Label titulo2;
    }
}
