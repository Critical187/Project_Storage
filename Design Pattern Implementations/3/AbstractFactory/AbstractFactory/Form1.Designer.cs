namespace AbstractFactory
{
    partial class Form1
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
            this.listViewCars = new System.Windows.Forms.ListView();
            this.cboxFactories = new System.Windows.Forms.ComboBox();
            this.listViewOffers = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.purchaseBtn = new System.Windows.Forms.Button();
            this.lowCostPurchaseBtn = new System.Windows.Forms.Button();
            this.lowCostPB = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lowCostTBox = new System.Windows.Forms.RichTextBox();
            this.medCostTBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.medCostPB = new System.Windows.Forms.PictureBox();
            this.medCostPurchaseBtn = new System.Windows.Forms.Button();
            this.highCostTBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.highCostPB = new System.Windows.Forms.PictureBox();
            this.highCostPurchaseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lowCostPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medCostPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highCostPB)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewCars
            // 
            this.listViewCars.Location = new System.Drawing.Point(5, 11);
            this.listViewCars.Name = "listViewCars";
            this.listViewCars.Size = new System.Drawing.Size(241, 206);
            this.listViewCars.TabIndex = 0;
            this.listViewCars.UseCompatibleStateImageBehavior = false;
            // 
            // cboxFactories
            // 
            this.cboxFactories.FormattingEnabled = true;
            this.cboxFactories.Location = new System.Drawing.Point(247, 248);
            this.cboxFactories.Name = "cboxFactories";
            this.cboxFactories.Size = new System.Drawing.Size(121, 21);
            this.cboxFactories.TabIndex = 1;
            this.cboxFactories.Text = "0";
            this.cboxFactories.SelectedIndexChanged += new System.EventHandler(this.cboxFactories_SelectedIndexChanged);
            // 
            // listViewOffers
            // 
            this.listViewOffers.Location = new System.Drawing.Point(332, 13);
            this.listViewOffers.Name = "listViewOffers";
            this.listViewOffers.Size = new System.Drawing.Size(241, 207);
            this.listViewOffers.TabIndex = 2;
            this.listViewOffers.UseCompatibleStateImageBehavior = false;
            this.listViewOffers.SelectedIndexChanged += new System.EventHandler(this.listViewOffers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your cars";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "All Brand offers";
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.Enabled = false;
            this.purchaseBtn.Location = new System.Drawing.Point(251, 94);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.Size = new System.Drawing.Size(75, 36);
            this.purchaseBtn.TabIndex = 6;
            this.purchaseBtn.Text = "Purchase Selected";
            this.purchaseBtn.UseVisualStyleBackColor = true;
            this.purchaseBtn.Click += new System.EventHandler(this.purchaseBtn_Click);
            // 
            // lowCostPurchaseBtn
            // 
            this.lowCostPurchaseBtn.Enabled = false;
            this.lowCostPurchaseBtn.Location = new System.Drawing.Point(649, 56);
            this.lowCostPurchaseBtn.Name = "lowCostPurchaseBtn";
            this.lowCostPurchaseBtn.Size = new System.Drawing.Size(75, 21);
            this.lowCostPurchaseBtn.TabIndex = 17;
            this.lowCostPurchaseBtn.Text = "Purchase";
            this.lowCostPurchaseBtn.UseVisualStyleBackColor = true;
            this.lowCostPurchaseBtn.Click += new System.EventHandler(this.lowCostPurchaseBtn_Click);
            // 
            // lowCostPB
            // 
            this.lowCostPB.Location = new System.Drawing.Point(579, 13);
            this.lowCostPB.Name = "lowCostPB";
            this.lowCostPB.Size = new System.Drawing.Size(64, 64);
            this.lowCostPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lowCostPB.TabIndex = 18;
            this.lowCostPB.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Low Budget";
            // 
            // lowCostTBox
            // 
            this.lowCostTBox.Enabled = false;
            this.lowCostTBox.Location = new System.Drawing.Point(649, 13);
            this.lowCostTBox.Name = "lowCostTBox";
            this.lowCostTBox.Size = new System.Drawing.Size(140, 36);
            this.lowCostTBox.TabIndex = 21;
            this.lowCostTBox.Text = "";
            // 
            // medCostTBox
            // 
            this.medCostTBox.Enabled = false;
            this.medCostTBox.Location = new System.Drawing.Point(649, 94);
            this.medCostTBox.Name = "medCostTBox";
            this.medCostTBox.Size = new System.Drawing.Size(140, 36);
            this.medCostTBox.TabIndex = 25;
            this.medCostTBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Med Budget";
            // 
            // medCostPB
            // 
            this.medCostPB.Location = new System.Drawing.Point(579, 94);
            this.medCostPB.Name = "medCostPB";
            this.medCostPB.Size = new System.Drawing.Size(64, 64);
            this.medCostPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.medCostPB.TabIndex = 23;
            this.medCostPB.TabStop = false;
            // 
            // medCostPurchaseBtn
            // 
            this.medCostPurchaseBtn.Enabled = false;
            this.medCostPurchaseBtn.Location = new System.Drawing.Point(649, 137);
            this.medCostPurchaseBtn.Name = "medCostPurchaseBtn";
            this.medCostPurchaseBtn.Size = new System.Drawing.Size(75, 21);
            this.medCostPurchaseBtn.TabIndex = 22;
            this.medCostPurchaseBtn.Text = "Purchase";
            this.medCostPurchaseBtn.UseVisualStyleBackColor = true;
            this.medCostPurchaseBtn.Click += new System.EventHandler(this.medCostPurchaseBtn_Click);
            // 
            // highCostTBox
            // 
            this.highCostTBox.Enabled = false;
            this.highCostTBox.Location = new System.Drawing.Point(651, 181);
            this.highCostTBox.Name = "highCostTBox";
            this.highCostTBox.Size = new System.Drawing.Size(140, 36);
            this.highCostTBox.TabIndex = 29;
            this.highCostTBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(579, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "High Budget";
            // 
            // highCostPB
            // 
            this.highCostPB.Location = new System.Drawing.Point(579, 181);
            this.highCostPB.Name = "highCostPB";
            this.highCostPB.Size = new System.Drawing.Size(64, 64);
            this.highCostPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.highCostPB.TabIndex = 27;
            this.highCostPB.TabStop = false;
            // 
            // highCostPurchaseBtn
            // 
            this.highCostPurchaseBtn.Enabled = false;
            this.highCostPurchaseBtn.Location = new System.Drawing.Point(649, 224);
            this.highCostPurchaseBtn.Name = "highCostPurchaseBtn";
            this.highCostPurchaseBtn.Size = new System.Drawing.Size(75, 21);
            this.highCostPurchaseBtn.TabIndex = 26;
            this.highCostPurchaseBtn.Text = "Purchase";
            this.highCostPurchaseBtn.UseVisualStyleBackColor = true;
            this.highCostPurchaseBtn.Click += new System.EventHandler(this.highCostPurchaseBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 292);
            this.Controls.Add(this.highCostTBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.highCostPB);
            this.Controls.Add(this.highCostPurchaseBtn);
            this.Controls.Add(this.medCostTBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.medCostPB);
            this.Controls.Add(this.medCostPurchaseBtn);
            this.Controls.Add(this.lowCostTBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lowCostPB);
            this.Controls.Add(this.lowCostPurchaseBtn);
            this.Controls.Add(this.purchaseBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewOffers);
            this.Controls.Add(this.cboxFactories);
            this.Controls.Add(this.listViewCars);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lowCostPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medCostPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highCostPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCars;
        private System.Windows.Forms.ComboBox cboxFactories;
        private System.Windows.Forms.ListView listViewOffers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button purchaseBtn;
        private System.Windows.Forms.Button lowCostPurchaseBtn;
        private System.Windows.Forms.PictureBox lowCostPB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox lowCostTBox;
        private System.Windows.Forms.RichTextBox medCostTBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox medCostPB;
        private System.Windows.Forms.Button medCostPurchaseBtn;
        private System.Windows.Forms.RichTextBox highCostTBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox highCostPB;
        private System.Windows.Forms.Button highCostPurchaseBtn;
    }
}

