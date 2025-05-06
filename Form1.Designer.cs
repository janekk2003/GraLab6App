namespace GraLab6App
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnOpcje = new System.Windows.Forms.Button();
            this.btnOpusc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 35);
            this.label1.MaximumSize = new System.Drawing.Size(170, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 126);
            this.label1.TabIndex = 0;
            this.label1.Text = "GDZIE JEST DYDELF";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(81, 209);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(149, 67);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnOpcje
            // 
            this.btnOpcje.Location = new System.Drawing.Point(81, 282);
            this.btnOpcje.Name = "btnOpcje";
            this.btnOpcje.Size = new System.Drawing.Size(149, 64);
            this.btnOpcje.TabIndex = 2;
            this.btnOpcje.Text = "OPCJE";
            this.btnOpcje.UseVisualStyleBackColor = true;
            this.btnOpcje.Click += new System.EventHandler(this.btnOpcje_Click);
            // 
            // btnOpusc
            // 
            this.btnOpusc.Location = new System.Drawing.Point(81, 352);
            this.btnOpusc.Name = "btnOpusc";
            this.btnOpusc.Size = new System.Drawing.Size(149, 67);
            this.btnOpusc.TabIndex = 3;
            this.btnOpusc.Text = "OPUSC";
            this.btnOpusc.UseVisualStyleBackColor = true;
            this.btnOpusc.Click += new System.EventHandler(this.btnOpusc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 473);
            this.Controls.Add(this.btnOpusc);
            this.Controls.Add(this.btnOpcje);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnOpcje;
        private System.Windows.Forms.Button btnOpusc;
    }
}

