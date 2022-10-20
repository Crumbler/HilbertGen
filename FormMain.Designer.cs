namespace HilbertGen
{
    partial class FormMain
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnSaveHorizontal = new System.Windows.Forms.Button();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.upDownSize = new System.Windows.Forms.NumericUpDown();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSize)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMain.Controls.Add(this.btnSaveHorizontal);
            this.panelMain.Controls.Add(this.btnSave1);
            this.panelMain.Controls.Add(this.btnGenerate);
            this.panelMain.Controls.Add(this.upDownSize);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(110, 540);
            this.panelMain.TabIndex = 0;
            // 
            // btnSaveHorizontal
            // 
            this.btnSaveHorizontal.Location = new System.Drawing.Point(3, 106);
            this.btnSaveHorizontal.Name = "btnSaveHorizontal";
            this.btnSaveHorizontal.Size = new System.Drawing.Size(100, 42);
            this.btnSaveHorizontal.TabIndex = 3;
            this.btnSaveHorizontal.Text = "Save horizontal indices as txt";
            this.btnSaveHorizontal.UseVisualStyleBackColor = true;
            this.btnSaveHorizontal.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(3, 61);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(100, 39);
            this.btnSave1.TabIndex = 2;
            this.btnSave1.Text = "Save path as txt";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(3, 32);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // upDownSize
            // 
            this.upDownSize.Location = new System.Drawing.Point(3, 3);
            this.upDownSize.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.upDownSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownSize.Name = "upDownSize";
            this.upDownSize.Size = new System.Drawing.Size(100, 23);
            this.upDownSize.TabIndex = 0;
            this.upDownSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 564);
            this.Controls.Add(this.panelMain);
            this.DoubleBuffered = true;
            this.Name = "FormMain";
            this.Text = "HilbertGen";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upDownSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.NumericUpDown upDownSize;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Button btnSaveHorizontal;
    }
}