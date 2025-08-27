namespace IMC
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
            tbPesoLibra = new TextBox();
            tbAlturaPies = new TextBox();
            label1 = new Label();
            label2 = new Label();
            labelIMC = new Label();
            btCalcular = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // tbPesoLibra
            // 
            tbPesoLibra.Location = new Point(226, 86);
            tbPesoLibra.Name = "tbPesoLibra";
            tbPesoLibra.Size = new Size(150, 39);
            tbPesoLibra.TabIndex = 0;
            // 
            // tbAlturaPies
            // 
            tbAlturaPies.Location = new Point(226, 165);
            tbAlturaPies.Name = "tbAlturaPies";
            tbAlturaPies.Size = new Size(150, 39);
            tbAlturaPies.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 89);
            label1.Name = "label1";
            label1.Size = new Size(165, 32);
            label1.TabIndex = 2;
            label1.Text = "Peso en Libras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 168);
            label2.Name = "label2";
            label2.Size = new Size(160, 32);
            label2.TabIndex = 2;
            label2.Text = "Altura en Pies";
            // 
            // labelIMC
            // 
            labelIMC.AutoSize = true;
            labelIMC.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIMC.Location = new Point(226, 267);
            labelIMC.Name = "labelIMC";
            labelIMC.Size = new Size(78, 45);
            labelIMC.TabIndex = 2;
            labelIMC.Text = "IMC";
            // 
            // btCalcular
            // 
            btCalcular.Location = new Point(495, 100);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(142, 91);
            btCalcular.TabIndex = 3;
            btCalcular.Text = "Calcular";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(129, 9);
            label3.Name = "label3";
            label3.Size = new Size(369, 54);
            label3.TabIndex = 2;
            label3.Text = "Calculadora de IMC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 267);
            label4.Name = "label4";
            label4.Size = new Size(167, 45);
            label4.TabIndex = 2;
            label4.Text = "Resultado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 351);
            Controls.Add(btCalcular);
            Controls.Add(labelIMC);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(tbAlturaPies);
            Controls.Add(tbPesoLibra);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPesoLibra;
        private TextBox tbAlturaPies;
        private Label label1;
        private Label label2;
        private Label labelIMC;
        private Button btCalcular;
        private Label label3;
        private Label label4;
    }
}
