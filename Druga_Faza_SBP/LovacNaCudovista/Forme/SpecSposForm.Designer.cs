namespace LovacNaCudovista.Forme
{
    partial class SpecSposForm
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
            listaSpecSpos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            groupBox2 = new GroupBox();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            btnDodaj = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaSpecSpos);
            groupBox1.Font = new Font("Bookman Old Style", 10.2F);
            groupBox1.Location = new Point(74, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 388);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Specijalne Sposobnosti";
            // 
            // listaSpecSpos
            // 
            listaSpecSpos.BackColor = Color.Tan;
            listaSpecSpos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listaSpecSpos.Dock = DockStyle.Fill;
            listaSpecSpos.Font = new Font("Bookman Old Style", 10.2F);
            listaSpecSpos.ForeColor = Color.DimGray;
            listaSpecSpos.FullRowSelect = true;
            listaSpecSpos.GridLines = true;
            listaSpecSpos.Location = new Point(3, 23);
            listaSpecSpos.Name = "listaSpecSpos";
            listaSpecSpos.Size = new Size(404, 362);
            listaSpecSpos.TabIndex = 4;
            listaSpecSpos.UseCompatibleStateImageBehavior = false;
            listaSpecSpos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Naziv";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 300;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnIzmeni);
            groupBox2.Controls.Add(btnObrisi);
            groupBox2.Controls.Add(btnDodaj);
            groupBox2.Font = new Font("Bookman Old Style", 10.2F);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(554, 90);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // btnIzmeni
            // 
            btnIzmeni.AutoSize = true;
            btnIzmeni.BackColor = Color.Tan;
            btnIzmeni.Font = new Font("Bookman Old Style", 10.2F);
            btnIzmeni.Location = new Point(375, 24);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(140, 45);
            btnIzmeni.TabIndex = 3;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = false;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.AutoSize = true;
            btnObrisi.BackColor = Color.Tan;
            btnObrisi.Font = new Font("Bookman Old Style", 10.2F);
            btnObrisi.Location = new Point(206, 24);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(140, 45);
            btnObrisi.TabIndex = 2;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = false;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.AutoSize = true;
            btnDodaj.BackColor = Color.Tan;
            btnDodaj.Font = new Font("Bookman Old Style", 10.2F);
            btnDodaj.Location = new Point(40, 24);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(140, 45);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // SpecSposForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(583, 552);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SpecSposForm";
            Text = "SpecSposForm";
            Load += SpecSposForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listaSpecSpos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private GroupBox groupBox2;
        private Button btnIzmeni;
        private Button btnObrisi;
        private Button btnDodaj;
    }
}