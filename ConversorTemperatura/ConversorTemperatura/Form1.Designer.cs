namespace ConversorTemperatura
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
            label2 = new Label();
            button1 = new Button();
            gradoscent = new TextBox();
            resultado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 96);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 0;
            label1.Text = "Grados Centrigados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 211);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 1;
            label2.Text = "Grados Fahrenhet";
            // 
            // button1
            // 
            button1.Location = new Point(90, 329);
            button1.Name = "button1";
            button1.Size = new Size(151, 84);
            button1.TabIndex = 2;
            button1.Text = "Covertir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // gradoscent
            // 
            gradoscent.Location = new Point(339, 90);
            gradoscent.Name = "gradoscent";
            gradoscent.Size = new Size(315, 31);
            gradoscent.TabIndex = 3;
            // 
            // resultado
            // 
            resultado.Location = new Point(339, 205);
            resultado.Name = "resultado";
            resultado.ReadOnly = true;
            resultado.Size = new Size(315, 31);
            resultado.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 625);
            Controls.Add(resultado);
            Controls.Add(gradoscent);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Conversor de Fahrenhet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox gradoscent;
        private TextBox resultado;
    }
}
