namespace LovacNaCudovista.Forme
{
    partial class LovacForm
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
            listaLovca = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            groupBox2 = new GroupBox();
            btnIzmeniLovca = new Button();
            btnObrisiLovca = new Button();
            btnDodajLovca = new Button();
            btnSusret = new Button();
            btnPredmet = new Button();
            btnProtivmere = new Button();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaLovca);
            groupBox1.Font = new Font("Bookman Old Style", 10.2F);
            groupBox1.Location = new Point(12, 207);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 177);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lovac";
            // 
            // listaLovca
            // 
            listaLovca.BackColor = Color.Tan;
            listaLovca.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listaLovca.Dock = DockStyle.Fill;
            listaLovca.FullRowSelect = true;
            listaLovca.GridLines = true;
            listaLovca.Location = new Point(3, 23);
            listaLovca.Name = "listaLovca";
            listaLovca.Size = new Size(464, 151);
            listaLovca.TabIndex = 4;
            listaLovca.UseCompatibleStateImageBehavior = false;
            listaLovca.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ime";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 150;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnIzmeniLovca);
            groupBox2.Controls.Add(btnObrisiLovca);
            groupBox2.Controls.Add(btnDodajLovca);
            groupBox2.Font = new Font("Bookman Old Style", 10.2F);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 80);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // btnIzmeniLovca
            // 
            btnIzmeniLovca.AutoSize = true;
            btnIzmeniLovca.BackColor = Color.Tan;
            btnIzmeniLovca.Location = new Point(327, 24);
            btnIzmeniLovca.Name = "btnIzmeniLovca";
            btnIzmeniLovca.Size = new Size(132, 45);
            btnIzmeniLovca.TabIndex = 3;
            btnIzmeniLovca.Text = "Izmeni Lovca";
            btnIzmeniLovca.UseVisualStyleBackColor = false;
            btnIzmeniLovca.Click += btnIzmeniLovca_Click;
            // 
            // btnObrisiLovca
            // 
            btnObrisiLovca.AutoSize = true;
            btnObrisiLovca.BackColor = Color.Tan;
            btnObrisiLovca.Location = new Point(170, 24);
            btnObrisiLovca.Name = "btnObrisiLovca";
            btnObrisiLovca.Size = new Size(132, 45);
            btnObrisiLovca.TabIndex = 2;
            btnObrisiLovca.Text = "Obrisi Lovca";
            btnObrisiLovca.UseVisualStyleBackColor = false;
            btnObrisiLovca.Click += btnObrisiLovca_Click;
            // 
            // btnDodajLovca
            // 
            btnDodajLovca.AutoSize = true;
            btnDodajLovca.BackColor = Color.Tan;
            btnDodajLovca.Location = new Point(16, 24);
            btnDodajLovca.Name = "btnDodajLovca";
            btnDodajLovca.Size = new Size(132, 45);
            btnDodajLovca.TabIndex = 1;
            btnDodajLovca.Text = "Dodaj Lovca";
            btnDodajLovca.UseVisualStyleBackColor = false;
            btnDodajLovca.Click += btnDodajLovca_Click;
            // 
            // btnSusret
            // 
            btnSusret.AutoSize = true;
            btnSusret.BackColor = Color.Tan;
            btnSusret.Location = new Point(16, 27);
            btnSusret.Name = "btnSusret";
            btnSusret.Size = new Size(132, 45);
            btnSusret.TabIndex = 7;
            btnSusret.Text = "Susret";
            btnSusret.UseVisualStyleBackColor = false;
            btnSusret.Click += btnSusret_Click;
            // 
            // btnPredmet
            // 
            btnPredmet.AutoSize = true;
            btnPredmet.BackColor = Color.Tan;
            btnPredmet.Location = new Point(170, 27);
            btnPredmet.Name = "btnPredmet";
            btnPredmet.Size = new Size(132, 45);
            btnPredmet.TabIndex = 8;
            btnPredmet.Text = "Predmet";
            btnPredmet.UseVisualStyleBackColor = false;
            btnPredmet.Click += btnPredmet_Click;
            // 
            // btnProtivmere
            // 
            btnProtivmere.AutoSize = true;
            btnProtivmere.BackColor = Color.Tan;
            btnProtivmere.Location = new Point(327, 27);
            btnProtivmere.Name = "btnProtivmere";
            btnProtivmere.Size = new Size(132, 45);
            btnProtivmere.TabIndex = 9;
            btnProtivmere.Text = "Protivmere";
            btnProtivmere.UseVisualStyleBackColor = false;
            btnProtivmere.Click += btnProtivmere_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnProtivmere);
            groupBox3.Controls.Add(btnPredmet);
            groupBox3.Controls.Add(btnSusret);
            groupBox3.Font = new Font("Bookman Old Style", 10.2F);
            groupBox3.Location = new Point(12, 107);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(470, 94);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            // 
            // LovacForm
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(529, 421);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "LovacForm";
            Text = "LovacForm";
            Load += LovacForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listaLovca;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private GroupBox groupBox2;
        private Button btnIzmeniLovca;
        private Button btnObrisiLovca;
        private Button btnDodajLovca;
        private Button btnSusret;
        private Button btnPredmet;
        private Button btnProtivmere;
        private GroupBox groupBox3;
    }
}