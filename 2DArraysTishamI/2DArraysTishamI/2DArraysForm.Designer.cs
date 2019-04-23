namespace _2DArraysTishamI
{
    partial class frm2DArrays
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
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(30, 79);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(48, 17);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Width:";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(30, 37);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(56, 17);
            this.lblLength.TabIndex = 1;
            this.lblLength.Text = "Length:";
            // 
            // nudLength
            // 
            this.nudLength.Location = new System.Drawing.Point(110, 37);
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(120, 22);
            this.nudLength.TabIndex = 2;
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(110, 79);
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(120, 22);
            this.nudWidth.TabIndex = 3;
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(33, 125);
            this.txtArray.Multiline = true;
            this.txtArray.Name = "txtArray";
            this.txtArray.ReadOnly = true;
            this.txtArray.Size = new System.Drawing.Size(734, 298);
            this.txtArray.TabIndex = 4;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(512, 37);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(205, 58);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // frm2DArrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtArray);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.nudLength);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblWidth);
            this.Name = "frm2DArrays";
            this.Text = "2D Arrays by Tisham Islam";
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtArray;
    }
}

