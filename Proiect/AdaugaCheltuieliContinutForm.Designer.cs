namespace Proiect
{
    partial class AdaugaCheltuieliContinutForm
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
            this.btnAdauga = new System.Windows.Forms.Button();
            this.comboboxProdus = new System.Windows.Forms.ComboBox();
            this.comboboxCheltuiala = new System.Windows.Forms.ComboBox();
            this.textBoxPret = new System.Windows.Forms.TextBox();
            this.textBoxCantitate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdauga
            // 
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(47, 290);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(350, 23);
            this.btnAdauga.TabIndex = 0;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // comboboxProdus
            // 
            this.comboboxProdus.FormattingEnabled = true;
            this.comboboxProdus.Location = new System.Drawing.Point(47, 72);
            this.comboboxProdus.Name = "comboboxProdus";
            this.comboboxProdus.Size = new System.Drawing.Size(350, 21);
            this.comboboxProdus.TabIndex = 1;
            // 
            // comboboxCheltuiala
            // 
            this.comboboxCheltuiala.FormattingEnabled = true;
            this.comboboxCheltuiala.Location = new System.Drawing.Point(47, 124);
            this.comboboxCheltuiala.Name = "comboboxCheltuiala";
            this.comboboxCheltuiala.Size = new System.Drawing.Size(350, 21);
            this.comboboxCheltuiala.TabIndex = 2;
            // 
            // textBoxPret
            // 
            this.textBoxPret.Location = new System.Drawing.Point(47, 176);
            this.textBoxPret.Name = "textBoxPret";
            this.textBoxPret.Size = new System.Drawing.Size(350, 20);
            this.textBoxPret.TabIndex = 3;
            // 
            // textBoxCantitate
            // 
            this.textBoxCantitate.Location = new System.Drawing.Point(47, 228);
            this.textBoxCantitate.Name = "textBoxCantitate";
            this.textBoxCantitate.Size = new System.Drawing.Size(350, 20);
            this.textBoxCantitate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adauga produs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adauga data cheltuiala:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adauga pret:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adauga cantitate:";
            // 
            // AdaugaCheltuieliContinutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 359);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCantitate);
            this.Controls.Add(this.textBoxPret);
            this.Controls.Add(this.comboboxCheltuiala);
            this.Controls.Add(this.comboboxProdus);
            this.Controls.Add(this.btnAdauga);
            this.Name = "AdaugaCheltuieliContinutForm";
            this.Text = "AdaugaCheltuieliContinutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.ComboBox comboboxProdus;
        private System.Windows.Forms.ComboBox comboboxCheltuiala;
        private System.Windows.Forms.TextBox textBoxPret;
        private System.Windows.Forms.TextBox textBoxCantitate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}