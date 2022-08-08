namespace Vraag_2
{
    partial class Form2
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.rbMana = new System.Windows.Forms.RadioButton();
            this.rbDamage = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(86, 59);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(192, 46);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calculate Stats";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // rbMana
            // 
            this.rbMana.AutoSize = true;
            this.rbMana.Location = new System.Drawing.Point(16, 13);
            this.rbMana.Name = "rbMana";
            this.rbMana.Size = new System.Drawing.Size(249, 17);
            this.rbMana.TabIndex = 3;
            this.rbMana.TabStop = true;
            this.rbMana.Text = "Get 15% more Mana but reduces speed by 10%";
            this.rbMana.UseVisualStyleBackColor = true;
            // 
            // rbDamage
            // 
            this.rbDamage.AutoSize = true;
            this.rbDamage.Location = new System.Drawing.Point(16, 36);
            this.rbDamage.Name = "rbDamage";
            this.rbDamage.Size = new System.Drawing.Size(341, 17);
            this.rbDamage.TabIndex = 4;
            this.rbDamage.TabStop = true;
            this.rbDamage.Text = "Do 20% more Damage but reduces Mana by 5% and speed by 10%";
            this.rbDamage.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(362, 116);
            this.Controls.Add(this.rbDamage);
            this.Controls.Add(this.rbMana);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.RadioButton rbMana;
        private System.Windows.Forms.RadioButton rbDamage;
    }
}