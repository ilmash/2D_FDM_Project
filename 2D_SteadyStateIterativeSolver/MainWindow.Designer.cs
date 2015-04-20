namespace _2D_SteadyStateIterativeSolver
{
    partial class MainWindow
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
            this.tgv = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveTask = new System.Windows.Forms.Button();
            this.btnBC1 = new System.Windows.Forms.Button();
            this.tbTemp = new System.Windows.Forms.TextBox();
            this.btnBC2 = new System.Windows.Forms.Button();
            this.btnBC3 = new System.Windows.Forms.Button();
            this.btnSetMaterial = new System.Windows.Forms.Button();
            this.btnSetVoid = new System.Windows.Forms.Button();
            this.tbInitTempOptional = new System.Windows.Forms.TextBox();
            this.tbNeumann = new System.Windows.Forms.TextBox();
            this.tbRobin = new System.Windows.Forms.TextBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.tbLambda = new System.Windows.Forms.TextBox();
            this.labelLambda = new System.Windows.Forms.Label();
            this.labelNodeDistance = new System.Windows.Forms.Label();
            this.tbNodeDistance = new System.Windows.Forms.TextBox();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tgv
            // 
            this.tgv.AllowUserToAddRows = false;
            this.tgv.AllowUserToDeleteRows = false;
            this.tgv.AllowUserToResizeColumns = false;
            this.tgv.AllowUserToResizeRows = false;
            this.tgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tgv.ColumnHeadersVisible = false;
            this.tgv.Location = new System.Drawing.Point(12, 12);
            this.tgv.Name = "tgv";
            this.tgv.RowHeadersVisible = false;
            this.tgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tgv.Size = new System.Drawing.Size(603, 403);
            this.tgv.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(635, 389);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSaveTask
            // 
            this.btnSaveTask.Location = new System.Drawing.Point(635, 258);
            this.btnSaveTask.Name = "btnSaveTask";
            this.btnSaveTask.Size = new System.Drawing.Size(97, 35);
            this.btnSaveTask.TabIndex = 2;
            this.btnSaveTask.Text = "Aktualizuj zadanie";
            this.btnSaveTask.UseVisualStyleBackColor = true;
            this.btnSaveTask.Click += new System.EventHandler(this.btnSaveTask_Click);
            // 
            // btnBC1
            // 
            this.btnBC1.Location = new System.Drawing.Point(635, 53);
            this.btnBC1.Name = "btnBC1";
            this.btnBC1.Size = new System.Drawing.Size(97, 35);
            this.btnBC1.TabIndex = 3;
            this.btnBC1.Text = "Ustaw warunek Dirichleta";
            this.btnBC1.UseVisualStyleBackColor = true;
            this.btnBC1.Click += new System.EventHandler(this.btnBC1_Click_1);
            // 
            // tbTemp
            // 
            this.tbTemp.Location = new System.Drawing.Point(738, 61);
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.Size = new System.Drawing.Size(88, 20);
            this.tbTemp.TabIndex = 4;
            this.tbTemp.Text = "0";
            // 
            // btnBC2
            // 
            this.btnBC2.Location = new System.Drawing.Point(635, 94);
            this.btnBC2.Name = "btnBC2";
            this.btnBC2.Size = new System.Drawing.Size(97, 35);
            this.btnBC2.TabIndex = 5;
            this.btnBC2.Text = "Ustaw warunek Neumanna";
            this.btnBC2.UseVisualStyleBackColor = true;
            this.btnBC2.Click += new System.EventHandler(this.btnBC2_Click);
            // 
            // btnBC3
            // 
            this.btnBC3.Location = new System.Drawing.Point(635, 135);
            this.btnBC3.Name = "btnBC3";
            this.btnBC3.Size = new System.Drawing.Size(97, 35);
            this.btnBC3.TabIndex = 6;
            this.btnBC3.Text = "Ustaw warunek Robina";
            this.btnBC3.UseVisualStyleBackColor = true;
            this.btnBC3.Click += new System.EventHandler(this.btnBC3_Click);
            // 
            // btnSetMaterial
            // 
            this.btnSetMaterial.Location = new System.Drawing.Point(635, 12);
            this.btnSetMaterial.Name = "btnSetMaterial";
            this.btnSetMaterial.Size = new System.Drawing.Size(97, 35);
            this.btnSetMaterial.TabIndex = 7;
            this.btnSetMaterial.Text = "Ustaw materiał";
            this.btnSetMaterial.UseVisualStyleBackColor = true;
            this.btnSetMaterial.Click += new System.EventHandler(this.btnSetMaterial_Click);
            // 
            // btnSetVoid
            // 
            this.btnSetVoid.Location = new System.Drawing.Point(635, 176);
            this.btnSetVoid.Name = "btnSetVoid";
            this.btnSetVoid.Size = new System.Drawing.Size(97, 35);
            this.btnSetVoid.TabIndex = 8;
            this.btnSetVoid.Text = "Usuń materiał lub warunek";
            this.btnSetVoid.UseVisualStyleBackColor = true;
            this.btnSetVoid.Click += new System.EventHandler(this.btnSetVoid_Click);
            // 
            // tbInitTempOptional
            // 
            this.tbInitTempOptional.Location = new System.Drawing.Point(738, 20);
            this.tbInitTempOptional.Name = "tbInitTempOptional";
            this.tbInitTempOptional.Size = new System.Drawing.Size(88, 20);
            this.tbInitTempOptional.TabIndex = 9;
            this.tbInitTempOptional.Text = "0";
            // 
            // tbNeumann
            // 
            this.tbNeumann.Location = new System.Drawing.Point(738, 102);
            this.tbNeumann.Name = "tbNeumann";
            this.tbNeumann.Size = new System.Drawing.Size(88, 20);
            this.tbNeumann.TabIndex = 10;
            this.tbNeumann.Text = "0";
            // 
            // tbRobin
            // 
            this.tbRobin.Location = new System.Drawing.Point(738, 143);
            this.tbRobin.Name = "tbRobin";
            this.tbRobin.Size = new System.Drawing.Size(88, 20);
            this.tbRobin.TabIndex = 11;
            this.tbRobin.Text = "25";
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(635, 217);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(97, 35);
            this.btnSolve.TabIndex = 12;
            this.btnSolve.Text = "Oblicz";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(635, 363);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(97, 20);
            this.btnLoadFile.TabIndex = 13;
            this.btnLoadFile.Text = "Wczytaj plik";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click_1);
            // 
            // tbLambda
            // 
            this.tbLambda.Location = new System.Drawing.Point(756, 232);
            this.tbLambda.Name = "tbLambda";
            this.tbLambda.Size = new System.Drawing.Size(70, 20);
            this.tbLambda.TabIndex = 14;
            this.tbLambda.Text = "100";
            // 
            // labelLambda
            // 
            this.labelLambda.AutoSize = true;
            this.labelLambda.Location = new System.Drawing.Point(753, 217);
            this.labelLambda.Name = "labelLambda";
            this.labelLambda.Size = new System.Drawing.Size(45, 13);
            this.labelLambda.TabIndex = 15;
            this.labelLambda.Text = "Lambda";
            // 
            // labelNodeDistance
            // 
            this.labelNodeDistance.AutoSize = true;
            this.labelNodeDistance.Location = new System.Drawing.Point(753, 176);
            this.labelNodeDistance.Name = "labelNodeDistance";
            this.labelNodeDistance.Size = new System.Drawing.Size(16, 13);
            this.labelNodeDistance.TabIndex = 17;
            this.labelNodeDistance.Text = " h";
            // 
            // tbNodeDistance
            // 
            this.tbNodeDistance.Location = new System.Drawing.Point(756, 191);
            this.tbNodeDistance.Name = "tbNodeDistance";
            this.tbNodeDistance.Size = new System.Drawing.Size(70, 20);
            this.tbNodeDistance.TabIndex = 16;
            this.tbNodeDistance.Text = "0.5";
            // 
            // fileDialog
            // 
            this.fileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.fileDialog_FileOk);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 431);
            this.Controls.Add(this.labelNodeDistance);
            this.Controls.Add(this.tbNodeDistance);
            this.Controls.Add(this.labelLambda);
            this.Controls.Add(this.tbLambda);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.tbRobin);
            this.Controls.Add(this.tbNeumann);
            this.Controls.Add(this.tbInitTempOptional);
            this.Controls.Add(this.btnSetVoid);
            this.Controls.Add(this.btnSetMaterial);
            this.Controls.Add(this.btnBC3);
            this.Controls.Add(this.btnBC2);
            this.Controls.Add(this.tbTemp);
            this.Controls.Add(this.btnBC1);
            this.Controls.Add(this.btnSaveTask);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tgv);
            this.Name = "MainWindow";
            this.Text = "2D FDM";
            ((System.ComponentModel.ISupportInitialize)(this.tgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tgv;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSaveTask;
        private System.Windows.Forms.Button btnBC1;
        private System.Windows.Forms.TextBox tbTemp;
        private System.Windows.Forms.Button btnBC2;
        private System.Windows.Forms.Button btnBC3;
        private System.Windows.Forms.Button btnSetMaterial;
        private System.Windows.Forms.Button btnSetVoid;
        private System.Windows.Forms.TextBox tbInitTempOptional;
        private System.Windows.Forms.TextBox tbNeumann;
        private System.Windows.Forms.TextBox tbRobin;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.TextBox tbLambda;
        private System.Windows.Forms.Label labelLambda;
        private System.Windows.Forms.Label labelNodeDistance;
        private System.Windows.Forms.TextBox tbNodeDistance;
        private System.Windows.Forms.OpenFileDialog fileDialog;

    }
}

