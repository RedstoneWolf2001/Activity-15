namespace Activity_15
{
    partial class LuckyNumberCalc
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
            this.CalcBTN = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LabelTB = new System.Windows.Forms.TextBox();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalcBTN
            // 
            this.CalcBTN.Location = new System.Drawing.Point(13, 65);
            this.CalcBTN.Name = "CalcBTN";
            this.CalcBTN.Size = new System.Drawing.Size(75, 23);
            this.CalcBTN.TabIndex = 0;
            this.CalcBTN.Text = "Calculate";
            this.CalcBTN.UseVisualStyleBackColor = true;
            this.CalcBTN.Click += new System.EventHandler(this.CalcBTN_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // LabelTB
            // 
            this.LabelTB.Location = new System.Drawing.Point(13, 13);
            this.LabelTB.Name = "LabelTB";
            this.LabelTB.ReadOnly = true;
            this.LabelTB.Size = new System.Drawing.Size(231, 20);
            this.LabelTB.TabIndex = 2;
            this.LabelTB.Text = "Enter your Birthday";
            this.LabelTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CloseBTN
            // 
            this.CloseBTN.Location = new System.Drawing.Point(168, 65);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(75, 23);
            this.CloseBTN.TabIndex = 3;
            this.CloseBTN.Text = "Close";
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // LuckyNumberCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 101);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.LabelTB);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CalcBTN);
            this.Name = "LuckyNumberCalc";
            this.Text = "Lucky Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcBTN;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox LabelTB;
        private System.Windows.Forms.Button CloseBTN;
    }
}

