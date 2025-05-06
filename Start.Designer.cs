namespace GraLab6App
{
    partial class Start
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
            this.btnOpuscStart = new System.Windows.Forms.Button();
            this.opcjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.opcjeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpuscStart
            // 
            this.btnOpuscStart.Location = new System.Drawing.Point(248, 440);
            this.btnOpuscStart.Name = "btnOpuscStart";
            this.btnOpuscStart.Size = new System.Drawing.Size(75, 23);
            this.btnOpuscStart.TabIndex = 0;
            this.btnOpuscStart.Text = "OPUSC";
            this.btnOpuscStart.UseVisualStyleBackColor = true;
            // 
            // opcjeBindingSource
            // 
            this.opcjeBindingSource.DataSource = typeof(GraLab6App.Opcje);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 475);
            this.Controls.Add(this.btnOpuscStart);
            this.Name = "Start";
            this.Text = "Start";
            ((System.ComponentModel.ISupportInitialize)(this.opcjeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpuscStart;
        private System.Windows.Forms.BindingSource opcjeBindingSource;
    }
}