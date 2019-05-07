namespace ReadWriteTishamI
{
    partial class frmReadWrite
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
            this.lblRead = new System.Windows.Forms.Label();
            this.lblWrote = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRead
            // 
            this.lblRead.AutoSize = true;
            this.lblRead.Location = new System.Drawing.Point(262, 124);
            this.lblRead.Name = "lblRead";
            this.lblRead.Size = new System.Drawing.Size(277, 17);
            this.lblRead.TabIndex = 1;
            this.lblRead.Text = "Check if the strings within the file are equal";
            // 
            // lblWrote
            // 
            this.lblWrote.AutoSize = true;
            this.lblWrote.Location = new System.Drawing.Point(306, 271);
            this.lblWrote.Name = "lblWrote";
            this.lblWrote.Size = new System.Drawing.Size(183, 17);
            this.lblWrote.TabIndex = 2;
            this.lblWrote.Text = "Output has been generated";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(325, 174);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(143, 54);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "CHECK";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmReadWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblWrote);
            this.Controls.Add(this.lblRead);
            this.Name = "frmReadWrite";
            this.Text = "Read Write by Tisham Islam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRead;
        private System.Windows.Forms.Label lblWrote;
        private System.Windows.Forms.Button btnCheck;
    }
}

