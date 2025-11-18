using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Text; // Necesario para crear el reporte
using System.IO; // Necesario para guardar archivos

namespace OrdenamientoMultihilo
{
    public partial class Form1 : Form
    {
        private int[] datos;
        private Dictionary<string, long> tiempos = new Dictionary<string, long>();
        private bool isRunning = false;

        public Form1()
        {
            InitializeComponent();
            // Inicializar BackgroundWorkers
            backgroundWorkerBurbuja.WorkerReportsProgress = true;
            backgroundWorkerBurbuja.WorkerSupportsCancellation = true;

            backgroundWorkerQuickSort.WorkerReportsProgress = true;
            backgroundWorkerQuickSort.WorkerSupportsCancellation = true;

            backgroundWorkerMergeSort.WorkerReportsProgress = true;
            backgroundWorkerMergeSort.WorkerSupportsCancellation = true;

            backgroundWorkerSelectionSort.WorkerReportsProgress = true;
            backgroundWorkerSelectionSort.WorkerSupportsCancellation = true;

            chartTimes.Titles.Add("Tiempos de Ordenamiento (ms)");
            chartTimes.Series["Tiempos"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chartTimes.Series["Tiempos"].Points.Clear();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidad.Text, out int cantidad) && cantidad > 0)
            {
                // Generar datos aleatorios
                datos = Enumerable.Range(1, cantidad).OrderBy(x => Guid.NewGuid()).ToArray();
                MessageBox.Show($"Se generaron {cantidad} elementos aleatorios.", "Datos Generados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnIniciar.Enabled = true;
                btnGuardarWord.Enabled = false;
                tiempos.Clear();
                UpdateChart();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida (número entero positivo).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (datos == null || datos.Length == 0)
            {
                MessageBox.Show("Primero debe generar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isRunning)
            {
                isRunning = true;
                btnIniciar.Enabled = false;
                btnDetener.Enabled = true;
                btnGenerar.Enabled = false;
                btnGuardarWord.Enabled = false;
                tiempos.Clear();
                ResetProgress();

                // Clonar los datos para cada algoritmo
                int[] datosBurbuja = (int[])datos.Clone();
                int[] datosQuickSort = (int[])datos.Clone();
                int[] datosMergeSort = (int[])datos.Clone();
                int[] datosSelectionSort = (int[])datos.Clone();

                // Iniciar BackgroundWorkers
                backgroundWorkerBurbuja.RunWorkerAsync(datosBurbuja);
                backgroundWorkerQuickSort.RunWorkerAsync(datosQuickSort);
                backgroundWorkerMergeSort.RunWorkerAsync(datosMergeSort);
                backgroundWorkerSelectionSort.RunWorkerAsync(datosSelectionSort);
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                backgroundWorkerBurbuja.CancelAsync();
                backgroundWorkerQuickSort.CancelAsync();
                backgroundWorkerMergeSort.CancelAsync();
                backgroundWorkerSelectionSort.CancelAsync();
                MessageBox.Show("Ordenamiento detenido.", "Detenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FinishRun();
            }
        }

        private void FinishRun()
        {
            isRunning = false;
            btnIniciar.Enabled = true;
            btnDetener.Enabled = false;
            btnGenerar.Enabled = true;
            btnGuardarWord.Enabled = (tiempos.Count == 4); // Solo si los 4 completaron
        }

        private void ResetProgress()
        {
            progressBurbuja.Value = 0;
            progressQuickSort.Value = 0;
            progressMerge.Value = 0;
            progressSelection.Value = 0;

            lblBurbuja.Text = "Burbuja: 0%";
            lblQuickSort.Text = "QuickSort: 0%";
            lblMerge.Text = "Merge: 0%";
            lblSelection.Text = "Selection: 0%";
        }

        private void UpdateChart()
        {
            chartTimes.Series["Tiempos"].Points.Clear();
            foreach (var kvp in tiempos.OrderBy(k => k.Value))
            {
                chartTimes.Series["Tiempos"].Points.AddXY(kvp.Key, kvp.Value);
            }
        }

        // --- Algoritmos de Ordenamiento ---

        // Método de Intercambio (Bubble Sort)
        private void BubbleSort(int[] arr, BackgroundWorker worker, DoWorkEventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                worker.ReportProgress((i * 100) / (n - 1));
            }
            sw.Stop();
            e.Result = sw.ElapsedMilliseconds;
        }

        // QuickSort
        private void QuickSort(int[] arr, int low, int high, BackgroundWorker worker, DoWorkEventArgs e)
        {
            if (worker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1, worker, e);
                QuickSort(arr, pi + 1, high, worker, e);
            }

            // Simular el progreso (estimación)
            int progress = (int)((double)(low + high) / arr.Length * 100);
            worker.ReportProgress(Math.Min(100, progress));
        }

        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp2 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp2;

            return i + 1;
        }

        // MergeSort
        private void MergeSort(int[] arr, int l, int r, BackgroundWorker worker, DoWorkEventArgs e)
        {
            if (worker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            if (l < r)
            {
                int m = l + (r - l) / 2;
                MergeSort(arr, l, m, worker, e);
                MergeSort(arr, m + 1, r, worker, e);
                Merge(arr, l, m, r);
            }

            // Simular el progreso (estimación)
            int totalLength = arr.Length;
            int currentLength = r - l + 1;
            int progress = (int)((double)currentLength / totalLength * 100);
            worker.ReportProgress(Math.Min(100, progress));
        }

        private void Merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            i = 0;
            j = 0;
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        // Selection Sort
        private void SelectionSort(int[] arr, BackgroundWorker worker, DoWorkEventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_idx])
                        min_idx = j;
                }

                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;

                worker.ReportProgress((i * 100) / (n - 1));
            }
            sw.Stop();
            e.Result = sw.ElapsedMilliseconds;
        }

        // --- BackgroundWorker Event Handlers ---

        // 1. BURBUJA (Bubble Sort)
        private void backgroundWorkerBurbuja_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int[] arr = e.Argument as int[];
            BubbleSort(arr, worker, e);
        }

        private void backgroundWorkerBurbuja_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBurbuja.Value = e.ProgressPercentage;
            lblBurbuja.Text = $"Burbuja: {e.ProgressPercentage}%";
        }

        private void backgroundWorkerBurbuja_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblBurbuja.Text = "Burbuja: Cancelado";
            }
            else if (e.Error != null)
            {
                lblBurbuja.Text = "Burbuja: Error";
                MessageBox.Show($"Error en Burbuja: {e.Error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                long tiempo = (long)e.Result;
                tiempos["Burbuja"] = tiempo;
                lblBurbuja.Text = $"Burbuja: Completado ({tiempo} ms)";
                UpdateChart();
            }

            if (!isRunning) return;

            // Verificar si todos han terminado para finalizar
            if (!backgroundWorkerQuickSort.IsBusy && !backgroundWorkerMergeSort.IsBusy && !backgroundWorkerSelectionSort.IsBusy)
            {
                FinishRun();
            }
        }

        // 2. QUICKSORT
        private void backgroundWorkerQuickSort_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int[] arr = e.Argument as int[];
            Stopwatch sw = new Stopwatch();
            sw.Start();
            QuickSort(arr, 0, arr.Length - 1, worker, e);
            sw.Stop();

            if (!e.Cancel)
            {
                e.Result = sw.ElapsedMilliseconds;
            }
        }

        private void backgroundWorkerQuickSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressQuickSort.Value = e.ProgressPercentage;
            lblQuickSort.Text = $"QuickSort: {e.ProgressPercentage}%";
        }

        private void backgroundWorkerQuickSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblQuickSort.Text = "QuickSort: Cancelado";
            }
            else if (e.Error != null)
            {
                lblQuickSort.Text = "QuickSort: Error";
                MessageBox.Show($"Error en QuickSort: {e.Error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                long tiempo = (long)e.Result;
                tiempos["QuickSort"] = tiempo;
                lblQuickSort.Text = $"QuickSort: Completado ({tiempo} ms)";
                UpdateChart();
            }

            if (!isRunning) return;

            if (!backgroundWorkerBurbuja.IsBusy && !backgroundWorkerMergeSort.IsBusy && !backgroundWorkerSelectionSort.IsBusy)
            {
                FinishRun();
            }
        }

        // 3. MERGESORT
        private void backgroundWorkerMergeSort_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int[] arr = e.Argument as int[];
            Stopwatch sw = new Stopwatch();
            sw.Start();
            MergeSort(arr, 0, arr.Length - 1, worker, e);
            sw.Stop();

            if (!e.Cancel)
            {
                e.Result = sw.ElapsedMilliseconds;
            }
        }

        private void backgroundWorkerMergeSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressMerge.Value = e.ProgressPercentage;
            lblMerge.Text = $"Merge: {e.ProgressPercentage}%";
        }

        private void backgroundWorkerMergeSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblMerge.Text = "Merge: Cancelado";
            }
            else if (e.Error != null)
            {
                lblMerge.Text = "Merge: Error";
                MessageBox.Show($"Error en Merge: {e.Error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                long tiempo = (long)e.Result;
                tiempos["Merge"] = tiempo;
                lblMerge.Text = $"Merge: Completado ({tiempo} ms)";
                UpdateChart();
            }

            if (!isRunning) return;

            if (!backgroundWorkerBurbuja.IsBusy && !backgroundWorkerQuickSort.IsBusy && !backgroundWorkerSelectionSort.IsBusy)
            {
                FinishRun();
            }
        }

        // 4. SELECTIONSORT
        private void backgroundWorkerSelectionSort_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int[] arr = e.Argument as int[];
            SelectionSort(arr, worker, e);
        }

        private void backgroundWorkerSelectionSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressSelection.Value = e.ProgressPercentage;
            lblSelection.Text = $"Selection: {e.ProgressPercentage}%";
        }

        private void backgroundWorkerSelectionSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblSelection.Text = "Selection: Cancelado";
            }
            else if (e.Error != null)
            {
                lblSelection.Text = "Selection: Error";
                MessageBox.Show($"Error en Selection: {e.Error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                long tiempo = (long)e.Result;
                tiempos["Selection"] = tiempo;
                lblSelection.Text = $"Selection: Completado ({tiempo} ms)";
                UpdateChart();
            }

            if (!isRunning) return;

            if (!backgroundWorkerBurbuja.IsBusy && !backgroundWorkerQuickSort.IsBusy && !backgroundWorkerMergeSort.IsBusy)
            {
                FinishRun();
            }
        }

        // --- Manejo de Reporte Simple (Guarda a TXT) ---

        private void btnGuardarWord_Click(object sender, EventArgs e)
        {
            if (tiempos.Count < 4)
            {
                MessageBox.Show("Debe completar todos los ordenamientos antes de guardar el reporte.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Usar SaveFileDialog para guardar un archivo de texto simple con los resultados
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Archivo de Texto (*.txt)|*.txt";
            saveDialog.Title = "Guardar Reporte de Tiempos";
            saveDialog.FileName = $"Reporte_Ordenamiento_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var reporte = new StringBuilder();
                    reporte.AppendLine("Reporte de Tiempos de Ordenamiento Multihilo");
                    reporte.AppendLine($"Fecha del Reporte: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
                    reporte.AppendLine($"Cantidad de datos: {(datos != null ? datos.Length.ToString() : "N/A")}");
                    reporte.AppendLine("\nTiempos de Ejecución:");

                    var resultados = tiempos.OrderBy(k => k.Value).ToList();
                    foreach (var res in resultados)
                    {
                        reporte.AppendLine($"- {res.Key}: {res.Value} ms");
                    }

                    // Guardar el texto en el archivo
                    File.WriteAllText(saveDialog.FileName, reporte.ToString());
                    MessageBox.Show("Reporte guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al guardar el reporte: {ex.Message}", "Error de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}