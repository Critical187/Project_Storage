namespace Observer
{
    partial class PushObserver
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
            this.btnD = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblScale = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(2, 236);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 23);
            this.btnD.TabIndex = 3;
            this.btnD.Text = "Detach";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(2, 207);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 23);
            this.btnA.TabIndex = 2;
            this.btnA.Text = "Attach";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Earthquake happened in";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(13, 37);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 13);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "####";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "with a scale of";
            // 
            // lblScale
            // 
            this.lblScale.AutoSize = true;
            this.lblScale.Location = new System.Drawing.Point(13, 83);
            this.lblScale.Name = "lblScale";
            this.lblScale.Size = new System.Drawing.Size(35, 13);
            this.lblScale.TabIndex = 7;
            this.lblScale.Text = "####";
            // 
            // PushObserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblScale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnA);
            this.Name = "PushObserver";
            this.Text = "PushObserver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblScale;
    }
}