namespace Part_5___Decisions
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblInstuctions = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblHurricaneInstructions = new System.Windows.Forms.Label();
            this.txtHurricaneInput = new System.Windows.Forms.TextBox();
            this.lblHurricaneOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(31, 107);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(268, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblInstuctions
            // 
            this.lblInstuctions.Location = new System.Drawing.Point(9, 51);
            this.lblInstuctions.Name = "lblInstuctions";
            this.lblInstuctions.Size = new System.Drawing.Size(271, 30);
            this.lblInstuctions.TabIndex = 1;
            this.lblInstuctions.Text = "Enter Your Age";
            this.lblInstuctions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(12, 142);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(268, 106);
            this.lblOutput.TabIndex = 2;
            // 
            // lblHurricaneInstructions
            // 
            this.lblHurricaneInstructions.AutoSize = true;
            this.lblHurricaneInstructions.Location = new System.Drawing.Point(418, 60);
            this.lblHurricaneInstructions.Name = "lblHurricaneInstructions";
            this.lblHurricaneInstructions.Size = new System.Drawing.Size(184, 13);
            this.lblHurricaneInstructions.TabIndex = 3;
            this.lblHurricaneInstructions.Text = "Enter The Category Of The Hurricane";
            // 
            // txtHurricaneInput
            // 
            this.txtHurricaneInput.Location = new System.Drawing.Point(369, 107);
            this.txtHurricaneInput.Name = "txtHurricaneInput";
            this.txtHurricaneInput.Size = new System.Drawing.Size(268, 20);
            this.txtHurricaneInput.TabIndex = 4;
            this.txtHurricaneInput.TextChanged += new System.EventHandler(this.txtHurricaneInput_TextChanged);
            // 
            // lblHurricaneOutput
            // 
            this.lblHurricaneOutput.Location = new System.Drawing.Point(369, 142);
            this.lblHurricaneOutput.Name = "lblHurricaneOutput";
            this.lblHurricaneOutput.Size = new System.Drawing.Size(268, 106);
            this.lblHurricaneOutput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 257);
            this.Controls.Add(this.lblHurricaneOutput);
            this.Controls.Add(this.txtHurricaneInput);
            this.Controls.Add(this.lblHurricaneInstructions);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInstuctions);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Part 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblInstuctions;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblHurricaneInstructions;
        private System.Windows.Forms.TextBox txtHurricaneInput;
        private System.Windows.Forms.Label lblHurricaneOutput;
    }
}

