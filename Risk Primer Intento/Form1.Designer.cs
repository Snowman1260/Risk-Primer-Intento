namespace Risk_Primer_Intento
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
            this.btnP1FirstCountry = new System.Windows.Forms.Button();
            this.btnP1SecondCountry = new System.Windows.Forms.Button();
            this.btnP1ThirdCountry = new System.Windows.Forms.Button();
            this.btnP1FourthCountry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnP1FirstCountry
            // 
            this.btnP1FirstCountry.Location = new System.Drawing.Point(28, 67);
            this.btnP1FirstCountry.Name = "btnP1FirstCountry";
            this.btnP1FirstCountry.Size = new System.Drawing.Size(104, 73);
            this.btnP1FirstCountry.TabIndex = 0;
            this.btnP1FirstCountry.Text = "0";
            this.btnP1FirstCountry.UseVisualStyleBackColor = true;
            this.btnP1FirstCountry.Click += new System.EventHandler(this.btnP1FirstCountry_Click);
            // 
            // btnP1SecondCountry
            // 
            this.btnP1SecondCountry.Location = new System.Drawing.Point(28, 146);
            this.btnP1SecondCountry.Name = "btnP1SecondCountry";
            this.btnP1SecondCountry.Size = new System.Drawing.Size(104, 73);
            this.btnP1SecondCountry.TabIndex = 1;
            this.btnP1SecondCountry.Text = "0";
            this.btnP1SecondCountry.UseVisualStyleBackColor = true;
            this.btnP1SecondCountry.Click += new System.EventHandler(this.btnP1SecondCountry_Click);
            // 
            // btnP1ThirdCountry
            // 
            this.btnP1ThirdCountry.Location = new System.Drawing.Point(28, 225);
            this.btnP1ThirdCountry.Name = "btnP1ThirdCountry";
            this.btnP1ThirdCountry.Size = new System.Drawing.Size(104, 73);
            this.btnP1ThirdCountry.TabIndex = 2;
            this.btnP1ThirdCountry.Text = "0";
            this.btnP1ThirdCountry.UseVisualStyleBackColor = true;
            this.btnP1ThirdCountry.Click += new System.EventHandler(this.btnP1ThirdCountry_Click);
            // 
            // btnP1FourthCountry
            // 
            this.btnP1FourthCountry.Location = new System.Drawing.Point(28, 304);
            this.btnP1FourthCountry.Name = "btnP1FourthCountry";
            this.btnP1FourthCountry.Size = new System.Drawing.Size(104, 73);
            this.btnP1FourthCountry.TabIndex = 3;
            this.btnP1FourthCountry.Text = "0";
            this.btnP1FourthCountry.UseVisualStyleBackColor = true;
            this.btnP1FourthCountry.Click += new System.EventHandler(this.btnP1FourthCountry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Turno:";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(90, 9);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(16, 17);
            this.lblTurno.TabIndex = 5;
            this.lblTurno.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnP1FourthCountry);
            this.Controls.Add(this.btnP1ThirdCountry);
            this.Controls.Add(this.btnP1SecondCountry);
            this.Controls.Add(this.btnP1FirstCountry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnP1FirstCountry;
        private System.Windows.Forms.Button btnP1SecondCountry;
        private System.Windows.Forms.Button btnP1ThirdCountry;
        private System.Windows.Forms.Button btnP1FourthCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTurno;
    }
}

