namespace Talker.cs
{
    partial class Talker
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
            this.lblSay = new System.Windows.Forms.Label();
            this.lbltimes = new System.Windows.Forms.Label();
            this.txtinsira = new System.Windows.Forms.TextBox();
            this.btnspeak = new System.Windows.Forms.Button();
            this.nupdtimes = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupdtimes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSay
            // 
            this.lblSay.AutoSize = true;
            this.lblSay.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSay.Location = new System.Drawing.Point(12, 26);
            this.lblSay.Name = "lblSay";
            this.lblSay.Size = new System.Drawing.Size(135, 18);
            this.lblSay.TabIndex = 0;
            this.lblSay.Text = "&Say Something:";
            // 
            // lbltimes
            // 
            this.lbltimes.AutoSize = true;
            this.lbltimes.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimes.Location = new System.Drawing.Point(42, 65);
            this.lbltimes.Name = "lbltimes";
            this.lbltimes.Size = new System.Drawing.Size(105, 18);
            this.lbltimes.TabIndex = 1;
            this.lbltimes.Text = "# Of &Times:";
            // 
            // txtinsira
            // 
            this.txtinsira.Location = new System.Drawing.Point(153, 27);
            this.txtinsira.Name = "txtinsira";
            this.txtinsira.Size = new System.Drawing.Size(100, 20);
            this.txtinsira.TabIndex = 2;
            // 
            // btnspeak
            // 
            this.btnspeak.Location = new System.Drawing.Point(106, 95);
            this.btnspeak.Name = "btnspeak";
            this.btnspeak.Size = new System.Drawing.Size(158, 23);
            this.btnspeak.TabIndex = 4;
            this.btnspeak.Text = "S&peak to me!";
            this.btnspeak.UseVisualStyleBackColor = true;
            this.btnspeak.Click += new System.EventHandler(this.btnspeak_Click);
            // 
            // nupdtimes
            // 
            this.nupdtimes.Location = new System.Drawing.Point(153, 65);
            this.nupdtimes.Name = "nupdtimes";
            this.nupdtimes.Size = new System.Drawing.Size(44, 20);
            this.nupdtimes.TabIndex = 6;
            // 
            // Talker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 126);
            this.Controls.Add(this.nupdtimes);
            this.Controls.Add(this.btnspeak);
            this.Controls.Add(this.txtinsira);
            this.Controls.Add(this.lbltimes);
            this.Controls.Add(this.lblSay);
            this.Name = "Talker";
            this.Text = "Talker Test";
            ((System.ComponentModel.ISupportInitialize)(this.nupdtimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSay;
        private System.Windows.Forms.Label lbltimes;
        private System.Windows.Forms.TextBox txtinsira;
        private System.Windows.Forms.Button btnspeak;
        private System.Windows.Forms.NumericUpDown nupdtimes;
    }
}

