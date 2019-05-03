namespace ListsTishamI
{
    partial class frmLists
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
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lstMarks = new System.Windows.Forms.ListBox();
            this.btnAverage = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(65, 32);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(100, 20);
            this.txtMarks.TabIndex = 0;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(362, 32);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "ENTER";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lstMarks
            // 
            this.lstMarks.FormattingEnabled = true;
            this.lstMarks.Location = new System.Drawing.Point(65, 156);
            this.lstMarks.Name = "lstMarks";
            this.lstMarks.Size = new System.Drawing.Size(577, 433);
            this.lstMarks.TabIndex = 2;
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(567, 29);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(75, 23);
            this.btnAverage.TabIndex = 3;
            this.btnAverage.Text = "AVERAGE";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(362, 84);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(0, 13);
            this.lblAverage.TabIndex = 4;
            // 
            // frmLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 628);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.lstMarks);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtMarks);
            this.Name = "frmLists";
            this.Text = "Lists by Tisham Islam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ListBox lstMarks;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Label lblAverage;
    }
}

