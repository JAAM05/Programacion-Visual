namespace OrdenamientoMultihilo
{
    partial class Form1
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.progressBurbuja = new System.Windows.Forms.ProgressBar();
            this.progressQuickSort = new System.Windows.Forms.ProgressBar();
            this.lblBurbuja = new System.Windows.Forms.Label();
            this.lblQuickSort = new System.Windows.Forms.Label();
            this.backgroundWorkerQuickSort = new System.ComponentModel.BackgroundWorker();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnGuardarWord = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chartTimes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorkerMergeSort = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerSelectionSort = new System.ComponentModel.BackgroundWorker();
            this.progressMerge = new System.Windows.Forms.ProgressBar();
            this.progressSelection = new System.Windows.Forms.ProgressBar();
            this.lblMerge = new System.Windows.Forms.Label();
            this.lblSelection = new System.Windows.Forms.Label();
            this.backgroundWorkerBurbuja = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.chartTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(12, 50);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(110, 30);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar Datos";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(12, 90);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(110, 30);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar Ordenamiento";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // progressBurbuja
            // 
            this.progressBurbuja.Location = new System.Drawing.Point(150, 150);
            this.progressBurbuja.Name = "progressBurbuja";
            this.progressBurbuja.Size = new System.Drawing.Size(350, 23);
            this.progressBurbuja.TabIndex = 2;
            // 
            // progressQuickSort
            // 
            this.progressQuickSort.Location = new System.Drawing.Point(150, 190);
            this.progressQuickSort.Name = "progressQuickSort";
            this.progressQuickSort.Size = new System.Drawing.Size(350, 23);
            this.progressQuickSort.TabIndex = 3;
            // 
            // lblBurbuja
            // 
            this.lblBurbuja.AutoSize = true;
            this.lblBurbuja.Location = new System.Drawing.Point(12, 155);
            this.lblBurbuja.Name = "lblBurbuja";
            this.lblBurbuja.Size = new System.Drawing.Size(65, 17);
            this.lblBurbuja.TabIndex = 4;
            this.lblBurbuja.Text = "Burbuja: 0%";
            // 
            // lblQuickSort
            // 
            this.lblQuickSort.AutoSize = true;
            this.lblQuickSort.Location = new System.Drawing.Point(12, 195);
            this.lblQuickSort.Name = "lblQuickSort";
            this.lblQuickSort.Size = new System.Drawing.Size(79, 17);
            this.lblQuickSort.TabIndex = 5;
            this.lblQuickSort.Text = "QuickSort: 0%";
            // 
            // backgroundWorkerQuickSort
            // 
            this.backgroundWorkerQuickSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerQuickSort_DoWork);
            this.backgroundWorkerQuickSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerQuickSort_ProgressChanged);
            this.backgroundWorkerQuickSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerQuickSort_RunWorkerCompleted);
            // 
            // btnDetener
            // 
            this.btnDetener.Enabled = false;
            this.btnDetener.Location = new System.Drawing.Point(128, 90);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(110, 30);
            this.btnDetener.TabIndex = 6;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnGuardarWord
            // 
            this.btnGuardarWord.Enabled = false;
            this.btnGuardarWord.Location = new System.Drawing.Point(390, 90);
            this.btnGuardarWord.Name = "btnGuardarWord";
            this.btnGuardarWord.Size = new System.Drawing.Size(110, 30);
            this.btnGuardarWord.TabIndex = 7;
            this.btnGuardarWord.Text = "Guardar Reporte";
            this.btnGuardarWord.UseVisualStyleBackColor = true;
            this.btnGuardarWord.Click += new System.EventHandler(this.btnGuardarWord_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(150, 15);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cantidad de Datos:";
            // 
            // chartTimes
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTimes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Tiempos";
            this.chartTimes.Series.Add(series1);
            this.chartTimes.Location = new System.Drawing.Point(12, 310);
            this.chartTimes.Size = new System.Drawing.Size(488, 240);
            this.chartTimes.TabIndex = 10;
            this.chartTimes.Text = "chart1";
            // 
            // backgroundWorkerMergeSort
            // 
            this.backgroundWorkerMergeSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerMergeSort_DoWork);
            this.backgroundWorkerMergeSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerMergeSort_ProgressChanged);
            this.backgroundWorkerMergeSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerMergeSort_RunWorkerCompleted);
            // 
            // backgroundWorkerSelectionSort
            // 
            this.backgroundWorkerSelectionSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSelectionSort_DoWork);
            this.backgroundWorkerSelectionSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerSelectionSort_ProgressChanged);
            this.backgroundWorkerSelectionSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSelectionSort_RunWorkerCompleted);
            // 
            // progressMerge
            // 
            this.progressMerge.Location = new System.Drawing.Point(150, 230);
            this.progressMerge.Name = "progressMerge";
            this.progressMerge.Size = new System.Drawing.Size(350, 23);
            this.progressMerge.TabIndex = 11;
            // 
            // progressSelection
            // 
            this.progressSelection.Location = new System.Drawing.Point(150, 270);
            this.progressSelection.Name = "progressSelection";
            this.progressSelection.Size = new System.Drawing.Size(350, 23);
            this.progressSelection.TabIndex = 12;
            // 
            // lblMerge
            // 
            this.lblMerge.AutoSize = true;
            this.lblMerge.Location = new System.Drawing.Point(12, 235);
            this.lblMerge.Name = "lblMerge";
            this.lblMerge.Size = new System.Drawing.Size(60, 17);
            this.lblMerge.TabIndex = 13;
            this.lblMerge.Text = "Merge: 0%";
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Location = new System.Drawing.Point(12, 275);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(78, 17);
            this.lblSelection.TabIndex = 14;
            this.lblSelection.Text = "Selection: 0%";
            // 
            // backgroundWorkerBurbuja
            // 
            this.backgroundWorkerBurbuja.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerBurbuja_DoWork);
            this.backgroundWorkerBurbuja.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerBurbuja_ProgressChanged);
            this.backgroundWorkerBurbuja.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerBurbuja_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 603);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.lblMerge);
            this.Controls.Add(this.progressSelection);
            this.Controls.Add(this.progressMerge);
            this.Controls.Add(this.chartTimes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnGuardarWord);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.lblQuickSort);
            this.Controls.Add(this.lblBurbuja);
            this.Controls.Add(this.progressQuickSort);
            this.Controls.Add(this.progressBurbuja);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnGenerar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ordenamiento Multihilo";
            ((System.ComponentModel.ISupportInitialize)(this.chartTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ProgressBar progressBurbuja;
        private System.Windows.Forms.ProgressBar progressQuickSort;
        private System.Windows.Forms.Label lblBurbuja;
        private System.Windows.Forms.Label lblQuickSort;
        private System.ComponentModel.BackgroundWorker backgroundWorkerQuickSort;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnGuardarWord;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTimes;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMergeSort;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSelectionSort;
        private System.Windows.Forms.ProgressBar progressMerge;
        private System.Windows.Forms.ProgressBar progressSelection;
        private System.Windows.Forms.Label lblMerge;
        private System.Windows.Forms.Label lblSelection;
        private System.ComponentModel.BackgroundWorker backgroundWorkerBurbuja;
    }
}