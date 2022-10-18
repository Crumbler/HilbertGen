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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.upDownSize = new System.Windows.Forms.NumericUpDown();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSize)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMain.Controls.Add(this.btnGenerate);
            this.panelMain.Controls.Add(this.upDownSize);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(76, 540);
            this.panelMain.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(3, 32);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(66, 23);
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
            this.upDownSize.Size = new System.Drawing.Size(66, 23);
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
    }
}