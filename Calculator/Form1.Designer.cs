namespace Calculator
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
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.mulitple = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.meric2 = new System.Windows.Forms.NumericUpDown();
            this.meric1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.meric2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meric1)).BeginInit();
            this.SuspendLayout();
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(173, 65);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 23);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(254, 65);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 1;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // mulitple
            // 
            this.mulitple.Location = new System.Drawing.Point(335, 65);
            this.mulitple.Name = "mulitple";
            this.mulitple.Size = new System.Drawing.Size(75, 23);
            this.mulitple.TabIndex = 2;
            this.mulitple.Text = "*";
            this.mulitple.UseVisualStyleBackColor = true;
            this.mulitple.Click += new System.EventHandler(this.mulitple_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(416, 65);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 23);
            this.div.TabIndex = 3;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(12, 41);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(125, 18);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Enter Number 2";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 1);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(125, 18);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Enter Number 1";
            // 
            // meric2
            // 
            this.meric2.Location = new System.Drawing.Point(158, 33);
            this.meric2.Name = "meric2";
            this.meric2.Size = new System.Drawing.Size(344, 26);
            this.meric2.TabIndex = 6;
            // 
            // meric1
            // 
            this.meric1.Location = new System.Drawing.Point(158, 1);
            this.meric1.Name = "meric1";
            this.meric1.Size = new System.Drawing.Size(344, 26);
            this.meric1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(503, 100);
            this.Controls.Add(this.meric1);
            this.Controls.Add(this.meric2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mulitple);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Saman-Saz";
            ((System.ComponentModel.ISupportInitialize)(this.meric2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meric1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button mulitple;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.NumericUpDown meric2;
        private System.Windows.Forms.NumericUpDown meric1;
    }
}

