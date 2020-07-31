namespace EvoluzeSped
{
    partial class Main
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
            this.btnFileOpen = new System.Windows.Forms.Button();
            this.lbEntrada = new System.Windows.Forms.Label();
            this.txtFileOpen = new System.Windows.Forms.TextBox();
            this.btn_EFD_ICMS_IPI = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.lbPercentual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Location = new System.Drawing.Point(446, 30);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(75, 23);
            this.btnFileOpen.TabIndex = 9;
            this.btnFileOpen.Text = "Abrir Arquivo";
            this.btnFileOpen.UseVisualStyleBackColor = true;
            this.btnFileOpen.Click += new System.EventHandler(this.btnFileOpen_Click);
            // 
            // lbEntrada
            // 
            this.lbEntrada.AutoSize = true;
            this.lbEntrada.Location = new System.Drawing.Point(26, 35);
            this.lbEntrada.Name = "lbEntrada";
            this.lbEntrada.Size = new System.Drawing.Size(44, 13);
            this.lbEntrada.TabIndex = 8;
            this.lbEntrada.Text = "Entrada";
            // 
            // txtFileOpen
            // 
            this.txtFileOpen.Location = new System.Drawing.Point(78, 32);
            this.txtFileOpen.Name = "txtFileOpen";
            this.txtFileOpen.Size = new System.Drawing.Size(362, 20);
            this.txtFileOpen.TabIndex = 7;
            // 
            // btn_EFD_ICMS_IPI
            // 
            this.btn_EFD_ICMS_IPI.Location = new System.Drawing.Point(599, 21);
            this.btn_EFD_ICMS_IPI.Name = "btn_EFD_ICMS_IPI";
            this.btn_EFD_ICMS_IPI.Size = new System.Drawing.Size(95, 40);
            this.btn_EFD_ICMS_IPI.TabIndex = 10;
            this.btn_EFD_ICMS_IPI.Text = "EFD ICMS IPI";
            this.btn_EFD_ICMS_IPI.UseVisualStyleBackColor = true;
            this.btn_EFD_ICMS_IPI.Click += new System.EventHandler(this.btn_EFD_ICMS_IPI_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(51, 390);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(587, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 11;
            this.progressBar.Visible = false;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // lbPercentual
            // 
            this.lbPercentual.AutoSize = true;
            this.lbPercentual.Location = new System.Drawing.Point(654, 395);
            this.lbPercentual.Name = "lbPercentual";
            this.lbPercentual.Size = new System.Drawing.Size(10, 13);
            this.lbPercentual.TabIndex = 12;
            this.lbPercentual.Text = " ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 481);
            this.Controls.Add(this.lbPercentual);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btn_EFD_ICMS_IPI);
            this.Controls.Add(this.btnFileOpen);
            this.Controls.Add(this.lbEntrada);
            this.Controls.Add(this.txtFileOpen);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFileOpen;
        private System.Windows.Forms.Label lbEntrada;
        private System.Windows.Forms.TextBox txtFileOpen;
        private System.Windows.Forms.Button btn_EFD_ICMS_IPI;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label lbPercentual;
    }
}

