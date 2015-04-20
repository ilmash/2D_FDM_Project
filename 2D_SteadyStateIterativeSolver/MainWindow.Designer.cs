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
            this.tgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tgv.Location = new System.Drawing.Point(12, 12);
            this.tgv.Name = "tgv";
            this.tgv.RowHeadersVisible = false;
            this.tgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tgv.Size = new System.Drawing.Size(603, 403);
            this.tgv.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(635, 386);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 29);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 431);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tgv);
            this.Name = "MainWindow";
            this.Text = "2D FDM";
            ((System.ComponentModel.ISupportInitialize)(this.tgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tgv;
        private System.Windows.Forms.Button btnClose;

    }
}

