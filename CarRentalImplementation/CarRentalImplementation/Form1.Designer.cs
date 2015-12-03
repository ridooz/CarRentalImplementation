namespace CarRentalImplementation
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonChooseCar = new System.Windows.Forms.Button();
            this.textBoxDatoStart = new System.Windows.Forms.TextBox();
            this.textBoxDatoSlut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show cars";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(139, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // buttonChooseCar
            // 
            this.buttonChooseCar.Location = new System.Drawing.Point(295, 32);
            this.buttonChooseCar.Name = "buttonChooseCar";
            this.buttonChooseCar.Size = new System.Drawing.Size(93, 21);
            this.buttonChooseCar.TabIndex = 3;
            this.buttonChooseCar.Text = "Choose car";
            this.buttonChooseCar.UseVisualStyleBackColor = true;
            this.buttonChooseCar.Click += new System.EventHandler(this.buttonChooseCar_Click);
            // 
            // textBoxDatoStart
            // 
            this.textBoxDatoStart.Location = new System.Drawing.Point(139, 77);
            this.textBoxDatoStart.Name = "textBoxDatoStart";
            this.textBoxDatoStart.Size = new System.Drawing.Size(100, 20);
            this.textBoxDatoStart.TabIndex = 4;
            // 
            // textBoxDatoSlut
            // 
            this.textBoxDatoSlut.Location = new System.Drawing.Point(288, 77);
            this.textBoxDatoSlut.Name = "textBoxDatoSlut";
            this.textBoxDatoSlut.Size = new System.Drawing.Size(100, 20);
            this.textBoxDatoSlut.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Loan Duration";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(42, 112);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(346, 199);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDatoSlut);
            this.Controls.Add(this.textBoxDatoStart);
            this.Controls.Add(this.buttonChooseCar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonChooseCar;
        private System.Windows.Forms.TextBox textBoxDatoStart;
        private System.Windows.Forms.TextBox textBoxDatoSlut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

