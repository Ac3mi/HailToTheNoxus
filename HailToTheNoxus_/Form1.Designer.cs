namespace HailToTheNoxus_
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNick = new System.Windows.Forms.Label();
            this.champPanel = new System.Windows.Forms.Panel();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblBlueAfter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnDisenchant = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblNick
            // 
            this.lblNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNick.Location = new System.Drawing.Point(12, 12);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(325, 85);
            this.lblNick.TabIndex = 0;
            this.lblNick.Text = "Nick";
            this.lblNick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // champPanel
            // 
            this.champPanel.AutoScroll = true;
            this.champPanel.Location = new System.Drawing.Point(343, 12);
            this.champPanel.Name = "champPanel";
            this.champPanel.Size = new System.Drawing.Size(445, 426);
            this.champPanel.TabIndex = 1;
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBlue.Location = new System.Drawing.Point(12, 289);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(156, 25);
            this.lblBlue.TabIndex = 2;
            this.lblBlue.Text = "Blue Essence: ";
            // 
            // lblBlueAfter
            // 
            this.lblBlueAfter.AutoSize = true;
            this.lblBlueAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBlueAfter.Location = new System.Drawing.Point(12, 340);
            this.lblBlueAfter.Name = "lblBlueAfter";
            this.lblBlueAfter.Size = new System.Drawing.Size(207, 25);
            this.lblBlueAfter.TabIndex = 3;
            this.lblBlueAfter.Text = "Blue Essence After: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Green = Profit after patch\r\nRed = No profit after patch\r\nImages temporary disable" +
    "d";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(181, 386);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnDisenchant
            // 
            this.btnDisenchant.Location = new System.Drawing.Point(262, 386);
            this.btnDisenchant.Name = "btnDisenchant";
            this.btnDisenchant.Size = new System.Drawing.Size(75, 23);
            this.btnDisenchant.TabIndex = 6;
            this.btnDisenchant.Text = "Disenchant";
            this.btnDisenchant.UseVisualStyleBackColor = true;
            this.btnDisenchant.Click += new System.EventHandler(this.btnDisenchant_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Discord: Ronaldinho Mielco#2137";
            // 
            // linkLbl
            // 
            this.linkLbl.AutoSize = true;
            this.linkLbl.LinkArea = new System.Windows.Forms.LinkArea(0, 8);
            this.linkLbl.Location = new System.Drawing.Point(731, 452);
            this.linkLbl.Name = "linkLbl";
            this.linkLbl.Size = new System.Drawing.Size(57, 13);
            this.linkLbl.TabIndex = 8;
            this.linkLbl.TabStop = true;
            this.linkLbl.Text = "Donate ❤️";
            this.linkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.linkLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDisenchant);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBlueAfter);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.champPanel);
            this.Controls.Add(this.lblNick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Hail To The Noxus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNick;
        private System.Windows.Forms.Panel champPanel;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblBlueAfter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnDisenchant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLbl;
    }
}

