namespace CarRentalImplementation
{
    partial class Confirmation
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
            this.buttonJa = new System.Windows.Forms.Button();
            this.buttonNej = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonJa
            // 
            this.buttonJa.Location = new System.Drawing.Point(39, 58);
            this.buttonJa.Name = "buttonJa";
            this.buttonJa.Size = new System.Drawing.Size(75, 23);
            this.buttonJa.TabIndex = 0;
            this.buttonJa.Text = "Ja";
            this.buttonJa.UseVisualStyleBackColor = true;
            this.buttonJa.Click += new System.EventHandler(this.buttonJa_Click);
            // 
            // buttonNej
            // 
            this.buttonNej.Location = new System.Drawing.Point(194, 58);
            this.buttonNej.Name = "buttonNej";
            this.buttonNej.Size = new System.Drawing.Size(75, 23);
            this.buttonNej.TabIndex = 1;
            this.buttonNej.Text = "Nej";
            this.buttonNej.UseVisualStyleBackColor = true;
            this.buttonNej.Click += new System.EventHandler(this.buttonNej_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Er du sikker?";
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 130);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNej);
            this.Controls.Add(this.buttonJa);
            this.Name = "Confirmation";
            this.Text = "Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonJa;
        private System.Windows.Forms.Button buttonNej;
        private System.Windows.Forms.Label label1;
    }
}