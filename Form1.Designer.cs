
namespace AS2122_3G_INF_IngrassiaSamuele_Pizzeria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEstPizzeria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEstPizzeria
            // 
            this.lblEstPizzeria.AutoSize = true;
            this.lblEstPizzeria.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstPizzeria.ForeColor = System.Drawing.Color.Red;
            this.lblEstPizzeria.Location = new System.Drawing.Point(115, 9);
            this.lblEstPizzeria.Name = "lblEstPizzeria";
            this.lblEstPizzeria.Size = new System.Drawing.Size(253, 80);
            this.lblEstPizzeria.TabIndex = 0;
            this.lblEstPizzeria.Text = "PIZZERIA";
            this.lblEstPizzeria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblEstPizzeria.Click += new System.EventHandler(this.lblEstPizzeria_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.lblEstPizzeria);
            this.Name = "Form1";
            this.Text = "3G | LAB 2.3 | Ingrassia Samuele | Pizzeria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstPizzeria;
    }
}

