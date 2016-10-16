namespace Decorator
{
    partial class CarShop
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
            this.lblSelectCar = new System.Windows.Forms.Label();
            this.rbVolk = new System.Windows.Forms.RadioButton();
            this.rbFord = new System.Windows.Forms.RadioButton();
            this.lblAddons = new System.Windows.Forms.Label();
            this.lbAvailable = new System.Windows.Forms.ListBox();
            this.lbSelected = new System.Windows.Forms.ListBox();
            this.btnSelectAddon = new System.Windows.Forms.Button();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.btnRemoveAddon = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectCar
            // 
            this.lblSelectCar.AutoSize = true;
            this.lblSelectCar.Location = new System.Drawing.Point(12, 9);
            this.lblSelectCar.Name = "lblSelectCar";
            this.lblSelectCar.Size = new System.Drawing.Size(67, 13);
            this.lblSelectCar.TabIndex = 0;
            this.lblSelectCar.Text = "1. Select car";
            // 
            // rbVolk
            // 
            this.rbVolk.AutoSize = true;
            this.rbVolk.Location = new System.Drawing.Point(14, 51);
            this.rbVolk.Name = "rbVolk";
            this.rbVolk.Size = new System.Drawing.Size(116, 17);
            this.rbVolk.TabIndex = 1;
            this.rbVolk.TabStop = true;
            this.rbVolk.Text = "Volkswagen Beetle";
            this.rbVolk.UseVisualStyleBackColor = true;
            // 
            // rbFord
            // 
            this.rbFord.AutoSize = true;
            this.rbFord.Location = new System.Drawing.Point(14, 74);
            this.rbFord.Name = "rbFord";
            this.rbFord.Size = new System.Drawing.Size(85, 17);
            this.rbFord.TabIndex = 2;
            this.rbFord.TabStop = true;
            this.rbFord.Text = "Ford Taunus";
            this.rbFord.UseVisualStyleBackColor = true;
            // 
            // lblAddons
            // 
            this.lblAddons.AutoSize = true;
            this.lblAddons.Location = new System.Drawing.Point(11, 138);
            this.lblAddons.Name = "lblAddons";
            this.lblAddons.Size = new System.Drawing.Size(133, 13);
            this.lblAddons.TabIndex = 3;
            this.lblAddons.Text = "2. Select addons (optional)";
            // 
            // lbAvailable
            // 
            this.lbAvailable.FormattingEnabled = true;
            this.lbAvailable.Location = new System.Drawing.Point(14, 180);
            this.lbAvailable.Name = "lbAvailable";
            this.lbAvailable.Size = new System.Drawing.Size(161, 121);
            this.lbAvailable.TabIndex = 4;
            // 
            // lbSelected
            // 
            this.lbSelected.FormattingEnabled = true;
            this.lbSelected.Location = new System.Drawing.Point(225, 180);
            this.lbSelected.Name = "lbSelected";
            this.lbSelected.Size = new System.Drawing.Size(161, 121);
            this.lbSelected.TabIndex = 5;
            // 
            // btnSelectAddon
            // 
            this.btnSelectAddon.Location = new System.Drawing.Point(181, 203);
            this.btnSelectAddon.Name = "btnSelectAddon";
            this.btnSelectAddon.Size = new System.Drawing.Size(38, 34);
            this.btnSelectAddon.TabIndex = 6;
            this.btnSelectAddon.Text = ">";
            this.btnSelectAddon.UseVisualStyleBackColor = true;
            this.btnSelectAddon.Click += new System.EventHandler(this.btnSelectAddon_Click);
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(14, 164);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(50, 13);
            this.lblAvailable.TabIndex = 7;
            this.lblAvailable.Text = "Available";
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(225, 164);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(49, 13);
            this.lblSelected.TabIndex = 8;
            this.lblSelected.Text = "Selected";
            // 
            // btnRemoveAddon
            // 
            this.btnRemoveAddon.Location = new System.Drawing.Point(181, 243);
            this.btnRemoveAddon.Name = "btnRemoveAddon";
            this.btnRemoveAddon.Size = new System.Drawing.Size(38, 34);
            this.btnRemoveAddon.TabIndex = 10;
            this.btnRemoveAddon.Text = "<";
            this.btnRemoveAddon.UseVisualStyleBackColor = true;
            this.btnRemoveAddon.Click += new System.EventHandler(this.btnRemoveAddon_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(143, 318);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(108, 44);
            this.btnBuy.TabIndex = 11;
            this.btnBuy.Text = "3. BUY";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // CarShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 374);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnRemoveAddon);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.btnSelectAddon);
            this.Controls.Add(this.lbSelected);
            this.Controls.Add(this.lbAvailable);
            this.Controls.Add(this.lblAddons);
            this.Controls.Add(this.rbFord);
            this.Controls.Add(this.rbVolk);
            this.Controls.Add(this.lblSelectCar);
            this.Name = "CarShop";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectCar;
        private System.Windows.Forms.RadioButton rbVolk;
        private System.Windows.Forms.RadioButton rbFord;
        private System.Windows.Forms.Label lblAddons;
        private System.Windows.Forms.ListBox lbAvailable;
        private System.Windows.Forms.ListBox lbSelected;
        private System.Windows.Forms.Button btnSelectAddon;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Button btnRemoveAddon;
        private System.Windows.Forms.Button btnBuy;
    }
}

