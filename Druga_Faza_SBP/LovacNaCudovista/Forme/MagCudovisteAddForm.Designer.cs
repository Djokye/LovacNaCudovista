namespace LovacNaCudovista.Forme
{
    partial class MagCudovisteAddForm
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
            groupBox1 = new GroupBox();
            txbPostojanje = new TextBox();
            label2 = new Label();
            btnDodaj = new Button();
            txbVekPom = new TextBox();
            txbNaziv = new TextBox();
            txbPodtip = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbPostojanje);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(txbVekPom);
            groupBox1.Controls.Add(txbNaziv);
            groupBox1.Controls.Add(txbPodtip);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Bookman Old Style", 10.2F);
            groupBox1.Location = new Point(39, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(678, 291);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Osnovni podaci o cudovistu";
            // 
            // txbPostojanje
            // 
            txbPostojanje.Location = new Point(505, 127);
            txbPostojanje.Name = "txbPostojanje";
            txbPostojanje.Size = new Size(125, 27);
            txbPostojanje.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 130);
            label2.Name = "label2";
            label2.Size = new Size(97, 21);
            label2.TabIndex = 8;
            label2.Text = "Postojanje";
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = Color.Tan;
            btnDodaj.Font = new Font("Bookman Old Style", 10.2F);
            btnDodaj.Location = new Point(246, 194);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(203, 61);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // txbVekPom
            // 
            txbVekPom.Location = new Point(505, 50);
            txbVekPom.Name = "txbVekPom";
            txbVekPom.Size = new Size(125, 27);
            txbVekPom.TabIndex = 6;
            // 
            // txbNaziv
            // 
            txbNaziv.Location = new Point(171, 50);
            txbNaziv.Name = "txbNaziv";
            txbNaziv.Size = new Size(125, 27);
            txbNaziv.TabIndex = 5;
            // 
            // txbPodtip
            // 
            txbPodtip.Location = new Point(171, 123);
            txbPodtip.Name = "txbPodtip";
            txbPodtip.Size = new Size(125, 27);
            txbPodtip.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 126);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 3;
            label4.Text = "Podtip";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(349, 50);
            label3.Name = "label3";
            label3.Size = new Size(142, 21);
            label3.TabIndex = 2;
            label3.Text = "Vek pominjanja";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 50);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 0;
            label1.Text = "Naziv";
            // 
            // MagCudovisteAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(769, 369);
            Controls.Add(groupBox1);
            Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MagCudovisteAddForm";
            Text = "MagCudovisteAddForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txbPostojanje;
        private Label label2;
        private Button btnDodaj;
        private TextBox txbVekPom;
        private TextBox txbNaziv;
        private TextBox txbPodtip;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}