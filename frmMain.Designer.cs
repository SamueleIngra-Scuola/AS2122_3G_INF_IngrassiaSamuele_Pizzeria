
namespace AS2122_3G_INF_IngrassiaSamuele_Pizzeria
{
    partial class frmMain
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
            this.lblTipoPizza = new System.Windows.Forms.Label();
            this.lblQuantita = new System.Windows.Forms.Label();
            this.cmbTipoPizza = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOrdina = new System.Windows.Forms.Button();
            this.lstRiepilogo = new System.Windows.Forms.ListBox();
            this.lblPizzeMargherite = new System.Windows.Forms.Label();
            this.lblPizzeMarinare = new System.Windows.Forms.Label();
            this.lblPizzeWurstel = new System.Windows.Forms.Label();
            this.lblQuantitaMargherite = new System.Windows.Forms.Label();
            this.lblQuantitaMarinare = new System.Windows.Forms.Label();
            this.lblQuantitaWurstel = new System.Windows.Forms.Label();
            this.grpRiepilogo = new System.Windows.Forms.GroupBox();
            this.grpRiepilogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEstPizzeria
            // 
            this.lblEstPizzeria.AutoSize = true;
            this.lblEstPizzeria.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstPizzeria.ForeColor = System.Drawing.Color.Red;
            this.lblEstPizzeria.Location = new System.Drawing.Point(125, 9);
            this.lblEstPizzeria.Name = "lblEstPizzeria";
            this.lblEstPizzeria.Size = new System.Drawing.Size(253, 80);
            this.lblEstPizzeria.TabIndex = 0;
            this.lblEstPizzeria.Text = "PIZZERIA";
            this.lblEstPizzeria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblEstPizzeria.Click += new System.EventHandler(this.lblEstPizzeria_Click);
            // 
            // lblTipoPizza
            // 
            this.lblTipoPizza.AutoSize = true;
            this.lblTipoPizza.Location = new System.Drawing.Point(12, 136);
            this.lblTipoPizza.Name = "lblTipoPizza";
            this.lblTipoPizza.Size = new System.Drawing.Size(75, 15);
            this.lblTipoPizza.TabIndex = 1;
            this.lblTipoPizza.Text = "Tipo di Pizza:";
            // 
            // lblQuantita
            // 
            this.lblQuantita.AutoSize = true;
            this.lblQuantita.Location = new System.Drawing.Point(12, 185);
            this.lblQuantita.Name = "lblQuantita";
            this.lblQuantita.Size = new System.Drawing.Size(56, 15);
            this.lblQuantita.TabIndex = 2;
            this.lblQuantita.Text = "Quantità:";
            // 
            // cmbTipoPizza
            // 
            this.cmbTipoPizza.FormattingEnabled = true;
            this.cmbTipoPizza.Items.AddRange(new object[] {
            "Pizza Margherita",
            "Pizza Marinara",
            "Pizza Wurstel"});
            this.cmbTipoPizza.Location = new System.Drawing.Point(97, 133);
            this.cmbTipoPizza.Name = "cmbTipoPizza";
            this.cmbTipoPizza.Size = new System.Drawing.Size(129, 23);
            this.cmbTipoPizza.TabIndex = 3;
            this.cmbTipoPizza.Text = "Pizza Margherita";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 23);
            this.textBox1.TabIndex = 4;
            // 
            // btnOrdina
            // 
            this.btnOrdina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnOrdina.FlatAppearance.BorderSize = 0;
            this.btnOrdina.ForeColor = System.Drawing.Color.White;
            this.btnOrdina.Location = new System.Drawing.Point(349, 133);
            this.btnOrdina.Name = "btnOrdina";
            this.btnOrdina.Size = new System.Drawing.Size(140, 70);
            this.btnOrdina.TabIndex = 5;
            this.btnOrdina.Text = "Ordina";
            this.btnOrdina.UseVisualStyleBackColor = false;
            // 
            // lstRiepilogo
            // 
            this.lstRiepilogo.FormattingEnabled = true;
            this.lstRiepilogo.ItemHeight = 15;
            this.lstRiepilogo.Location = new System.Drawing.Point(9, 22);
            this.lstRiepilogo.Name = "lstRiepilogo";
            this.lstRiepilogo.Size = new System.Drawing.Size(213, 139);
            this.lstRiepilogo.TabIndex = 6;
            // 
            // lblPizzeMargherite
            // 
            this.lblPizzeMargherite.AutoSize = true;
            this.lblPizzeMargherite.Location = new System.Drawing.Point(309, 43);
            this.lblPizzeMargherite.Name = "lblPizzeMargherite";
            this.lblPizzeMargherite.Size = new System.Drawing.Size(134, 15);
            this.lblPizzeMargherite.TabIndex = 7;
            this.lblPizzeMargherite.Text = "Totale Pizze Margherite: ";
            // 
            // lblPizzeMarinare
            // 
            this.lblPizzeMarinare.AutoSize = true;
            this.lblPizzeMarinare.Location = new System.Drawing.Point(309, 80);
            this.lblPizzeMarinare.Name = "lblPizzeMarinare";
            this.lblPizzeMarinare.Size = new System.Drawing.Size(123, 15);
            this.lblPizzeMarinare.TabIndex = 8;
            this.lblPizzeMarinare.Text = "Totale Pizze Marinare: ";
            // 
            // lblPizzeWurstel
            // 
            this.lblPizzeWurstel.AutoSize = true;
            this.lblPizzeWurstel.Location = new System.Drawing.Point(309, 118);
            this.lblPizzeWurstel.Name = "lblPizzeWurstel";
            this.lblPizzeWurstel.Size = new System.Drawing.Size(116, 15);
            this.lblPizzeWurstel.TabIndex = 9;
            this.lblPizzeWurstel.Text = "Totale Pizze Wurstel: ";
            // 
            // lblQuantitaMargherite
            // 
            this.lblQuantitaMargherite.AutoSize = true;
            this.lblQuantitaMargherite.Location = new System.Drawing.Point(449, 43);
            this.lblQuantitaMargherite.Name = "lblQuantitaMargherite";
            this.lblQuantitaMargherite.Size = new System.Drawing.Size(13, 15);
            this.lblQuantitaMargherite.TabIndex = 10;
            this.lblQuantitaMargherite.Text = "0";
            this.lblQuantitaMargherite.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblQuantitaMargherite.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblQuantitaMarinare
            // 
            this.lblQuantitaMarinare.AutoSize = true;
            this.lblQuantitaMarinare.Location = new System.Drawing.Point(449, 80);
            this.lblQuantitaMarinare.Name = "lblQuantitaMarinare";
            this.lblQuantitaMarinare.Size = new System.Drawing.Size(13, 15);
            this.lblQuantitaMarinare.TabIndex = 11;
            this.lblQuantitaMarinare.Text = "0";
            this.lblQuantitaMarinare.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblQuantitaWurstel
            // 
            this.lblQuantitaWurstel.AutoSize = true;
            this.lblQuantitaWurstel.Location = new System.Drawing.Point(449, 118);
            this.lblQuantitaWurstel.Name = "lblQuantitaWurstel";
            this.lblQuantitaWurstel.Size = new System.Drawing.Size(13, 15);
            this.lblQuantitaWurstel.TabIndex = 12;
            this.lblQuantitaWurstel.Text = "0";
            this.lblQuantitaWurstel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpRiepilogo
            // 
            this.grpRiepilogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpRiepilogo.Controls.Add(this.lblQuantitaWurstel);
            this.grpRiepilogo.Controls.Add(this.lblQuantitaMarinare);
            this.grpRiepilogo.Controls.Add(this.lblQuantitaMargherite);
            this.grpRiepilogo.Controls.Add(this.lblPizzeWurstel);
            this.grpRiepilogo.Controls.Add(this.lblPizzeMarinare);
            this.grpRiepilogo.Controls.Add(this.lblPizzeMargherite);
            this.grpRiepilogo.Controls.Add(this.lstRiepilogo);
            this.grpRiepilogo.Location = new System.Drawing.Point(4, 253);
            this.grpRiepilogo.Name = "grpRiepilogo";
            this.grpRiepilogo.Size = new System.Drawing.Size(485, 173);
            this.grpRiepilogo.TabIndex = 13;
            this.grpRiepilogo.TabStop = false;
            this.grpRiepilogo.Text = "Riepilogo";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(213)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(501, 439);
            this.Controls.Add(this.grpRiepilogo);
            this.Controls.Add(this.btnOrdina);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbTipoPizza);
            this.Controls.Add(this.lblQuantita);
            this.Controls.Add(this.lblTipoPizza);
            this.Controls.Add(this.lblEstPizzeria);
            this.Name = "frmMain";
            this.Text = "3G | LAB 2.3 | Ingrassia Samuele | Pizzeria";
            this.grpRiepilogo.ResumeLayout(false);
            this.grpRiepilogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstPizzeria;
        private System.Windows.Forms.Label lblTipoPizza;
        private System.Windows.Forms.Label lblQuantita;
        private System.Windows.Forms.ComboBox cmbTipoPizza;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOrdina;
        private System.Windows.Forms.ListBox lstRiepilogo;
        private System.Windows.Forms.Label lblPizzeMargherite;
        private System.Windows.Forms.Label lblPizzeMarinare;
        private System.Windows.Forms.Label lblPizzeWurstel;
        private System.Windows.Forms.Label lblQuantitaMargherite;
        private System.Windows.Forms.Label lblQuantitaMarinare;
        private System.Windows.Forms.Label lblQuantitaWurstel;
        private System.Windows.Forms.GroupBox grpRiepilogo;
    }
}

