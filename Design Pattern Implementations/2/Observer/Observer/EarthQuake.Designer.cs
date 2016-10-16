namespace Observer
{
    partial class EarthQuake
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
            this.components = new System.ComponentModel.Container();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblScale = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbScale = new System.Windows.Forms.TextBox();
            this.btnCPush = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.btnRep = new System.Windows.Forms.Button();
            this.quakeTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(12, 21);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City";
            // 
            // lblScale
            // 
            this.lblScale.AutoSize = true;
            this.lblScale.Location = new System.Drawing.Point(12, 64);
            this.lblScale.Name = "lblScale";
            this.lblScale.Size = new System.Drawing.Size(34, 13);
            this.lblScale.TabIndex = 1;
            this.lblScale.Text = "Scale";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(53, 18);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(100, 20);
            this.tbCity.TabIndex = 2;
            // 
            // tbScale
            // 
            this.tbScale.Location = new System.Drawing.Point(53, 61);
            this.tbScale.Name = "tbScale";
            this.tbScale.Size = new System.Drawing.Size(43, 20);
            this.tbScale.TabIndex = 3;
            // 
            // btnCPush
            // 
            this.btnCPush.Location = new System.Drawing.Point(15, 178);
            this.btnCPush.Name = "btnCPush";
            this.btnCPush.Size = new System.Drawing.Size(125, 23);
            this.btnCPush.TabIndex = 4;
            this.btnCPush.Text = "Create PushObserver";
            this.btnCPush.UseVisualStyleBackColor = true;
            this.btnCPush.Click += new System.EventHandler(this.btnCPush_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Create PullObserver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(50, 218);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(13, 13);
            this.lblNum1.TabIndex = 6;
            this.lblNum1.Text = "0";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(196, 218);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(13, 13);
            this.lblNum2.TabIndex = 7;
            this.lblNum2.Text = "0";
            // 
            // btnRep
            // 
            this.btnRep.Location = new System.Drawing.Point(15, 97);
            this.btnRep.Name = "btnRep";
            this.btnRep.Size = new System.Drawing.Size(138, 38);
            this.btnRep.TabIndex = 8;
            this.btnRep.Text = "Report";
            this.btnRep.UseVisualStyleBackColor = true;
            this.btnRep.Click += new System.EventHandler(this.btnRep_Click);
            // 
            // quakeTimer
            // 
            this.quakeTimer.Enabled = true;
            this.quakeTimer.Interval = 1000;
            this.quakeTimer.Tick += new System.EventHandler(this.quakeTimer_Tick);
            // 
            // EarthQuake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 272);
            this.Controls.Add(this.btnRep);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCPush);
            this.Controls.Add(this.tbScale);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.lblScale);
            this.Controls.Add(this.lblCity);
            this.Name = "EarthQuake";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblScale;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbScale;
        private System.Windows.Forms.Button btnCPush;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Button btnRep;
        private System.Windows.Forms.Timer quakeTimer;
    }
}

