namespace Visitor
{
    partial class ClientForm
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
            this.btnBuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbSpecial = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFirst = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clbMenu = new System.Windows.Forms.CheckedListBox();
            this.cbSteak = new System.Windows.Forms.CheckBox();
            this.cbFries = new System.Windows.Forms.CheckBox();
            this.cbTea = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDisc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(274, 237);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(90, 54);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.Text = "Buy!";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "1. I am a ";
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(61, 40);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(102, 17);
            this.rbNormal.TabIndex = 4;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "normal customer";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbSpecial
            // 
            this.rbSpecial.AutoSize = true;
            this.rbSpecial.Location = new System.Drawing.Point(200, 40);
            this.rbSpecial.Name = "rbSpecial";
            this.rbSpecial.Size = new System.Drawing.Size(104, 17);
            this.rbSpecial.TabIndex = 5;
            this.rbSpecial.TabStop = true;
            this.rbSpecial.Text = "special customer";
            this.rbSpecial.UseVisualStyleBackColor = true;
            this.rbSpecial.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "or a";
            // 
            // cbFirst
            // 
            this.cbFirst.AutoSize = true;
            this.cbFirst.Location = new System.Drawing.Point(61, 64);
            this.cbFirst.Name = "cbFirst";
            this.cbFirst.Size = new System.Drawing.Size(140, 17);
            this.cbFirst.TabIndex = 7;
            this.cbFirst.Text = "This is my first time here!";
            this.cbFirst.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "2. I would like to order";
            // 
            // clbMenu
            // 
            this.clbMenu.FormattingEnabled = true;
            this.clbMenu.Location = new System.Drawing.Point(153, 132);
            this.clbMenu.Name = "clbMenu";
            this.clbMenu.Size = new System.Drawing.Size(96, 109);
            this.clbMenu.TabIndex = 12;
            // 
            // cbSteak
            // 
            this.cbSteak.AutoSize = true;
            this.cbSteak.Location = new System.Drawing.Point(285, 132);
            this.cbSteak.Name = "cbSteak";
            this.cbSteak.Size = new System.Drawing.Size(127, 17);
            this.cbSteak.TabIndex = 13;
            this.cbSteak.Text = "with sauce (for steak)";
            this.cbSteak.UseVisualStyleBackColor = true;
            // 
            // cbFries
            // 
            this.cbFries.AutoSize = true;
            this.cbFries.Location = new System.Drawing.Point(286, 152);
            this.cbFries.Name = "cbFries";
            this.cbFries.Size = new System.Drawing.Size(130, 17);
            this.cbFries.TabIndex = 14;
            this.cbFries.Text = "with ketchup (for fries)";
            this.cbFries.UseVisualStyleBackColor = true;
            // 
            // cbTea
            // 
            this.cbTea.AutoSize = true;
            this.cbTea.Location = new System.Drawing.Point(286, 175);
            this.cbTea.Name = "cbTea";
            this.cbTea.Size = new System.Drawing.Size(139, 17);
            this.cbTea.TabIndex = 15;
            this.cbTea.Text = "in a jug (instead of cup).";
            this.cbTea.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Welcome to the very famous  \"I can order only one of each item\" restaurant!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "with a discount of";
            // 
            // cbDisc
            // 
            this.cbDisc.FormattingEnabled = true;
            this.cbDisc.Location = new System.Drawing.Point(397, 39);
            this.cbDisc.Name = "cbDisc";
            this.cbDisc.Size = new System.Drawing.Size(34, 21);
            this.cbDisc.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "euros, for each of the items";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "3. Extra";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 317);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbDisc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTea);
            this.Controls.Add(this.cbFries);
            this.Controls.Add(this.cbSteak);
            this.Controls.Add(this.clbMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbSpecial);
            this.Controls.Add(this.rbNormal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuy);
            this.Name = "ClientForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbSpecial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbFirst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clbMenu;
        private System.Windows.Forms.CheckBox cbSteak;
        private System.Windows.Forms.CheckBox cbFries;
        private System.Windows.Forms.CheckBox cbTea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDisc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

