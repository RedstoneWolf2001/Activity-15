namespace Activity_15
{
    partial class LuckyNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LuckyNumber));
            this.ResultsLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultsLBL
            // 
            this.ResultsLBL.AutoSize = true;
            this.ResultsLBL.BackColor = System.Drawing.Color.Transparent;
            this.ResultsLBL.Location = new System.Drawing.Point(130, 245);
            this.ResultsLBL.Name = "ResultsLBL";
            this.ResultsLBL.Size = new System.Drawing.Size(0, 13);
            this.ResultsLBL.TabIndex = 0;
            // 
            // LuckyNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 321);
            this.Controls.Add(this.ResultsLBL);
            this.Name = "LuckyNumber";
            this.Text = "Your Lucky Number!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultsLBL;
    }
}