namespace PassFailTishamI
{
    partial class frmPassFail
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
            this.btnParse = new System.Windows.Forms.Button();
            this.btnCreateAndParse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(295, 158);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(129, 27);
            this.btnParse.TabIndex = 0;
            this.btnParse.Text = "PARSE FILE";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // btnCreateAndParse
            // 
            this.btnCreateAndParse.Location = new System.Drawing.Point(269, 219);
            this.btnCreateAndParse.Name = "btnCreateAndParse";
            this.btnCreateAndParse.Size = new System.Drawing.Size(178, 59);
            this.btnCreateAndParse.TabIndex = 1;
            this.btnCreateAndParse.Text = "CREATE AND PARSE NEW FILE";
            this.btnCreateAndParse.UseVisualStyleBackColor = true;
            this.btnCreateAndParse.Click += new System.EventHandler(this.btnCreateAndParse_Click);
            // 
            // frmPassFail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.btnCreateAndParse);
            this.Controls.Add(this.btnParse);
            this.Name = "frmPassFail";
            this.Text = "Pass Fail by Tisham Islam";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Button btnCreateAndParse;
    }
}

