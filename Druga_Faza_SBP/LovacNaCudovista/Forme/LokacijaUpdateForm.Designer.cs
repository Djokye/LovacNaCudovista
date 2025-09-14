namespace LovacNaCudovista.Forme
{
    partial class LokacijaUpdateForm
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
            txbBlago = new TextBox();
            label2 = new Label();
            txbNazivLok = new TextBox();
            txbTipLok = new TextBox();
            btnAzuriraj = new Button();
            txbZemljaLok = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbBlago);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txbNazivLok);
            groupBox1.Controls.Add(txbTipLok);
            groupBox1.Controls.Add(btnAzuriraj);
            groupBox1.Controls.Add(txbZemljaLok);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Bookman Old Style", 10.2F);
            groupBox1.Location = new Point(39, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(717, 291);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Osnovni podaci o lokaciji";
            // 
            // txbBlago
            // 
            txbBlago.Location = new Point(210, 221);
            txbBlago.Name = "txbBlago";
            txbBlago.Size = new Size(125, 27);
            txbBlago.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 221);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 10;
            label2.Text = "Blago";
            // 
            // txbNazivLok
            // 
            txbNazivLok.Location = new Point(210, 109);
            txbNazivLok.Name = "txbNazivLok";
            txbNazivLok.Size = new Size(203, 27);
            txbNazivLok.TabIndex = 9;
            // 
            // txbTipLok
            // 
            txbTipLok.Location = new Point(210, 63);
            txbTipLok.Name = "txbTipLok";
            txbTipLok.Size = new Size(125, 27);
            txbTipLok.TabIndex = 8;
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.BackColor = Color.Tan;
            btnAzuriraj.Font = new Font("Bookman Old Style", 10.2F);
            btnAzuriraj.Location = new Point(446, 129);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new Size(203, 61);
            btnAzuriraj.TabIndex = 7;
            btnAzuriraj.Text = "Izmeni";
            btnAzuriraj.UseVisualStyleBackColor = false;
            btnAzuriraj.Click += btnAzuriraj_Click;
            // 
            // txbZemljaLok
            // 
            txbZemljaLok.Location = new Point(210, 166);
            txbZemljaLok.Name = "txbZemljaLok";
            txbZemljaLok.Size = new Size(125, 27);
            txbZemljaLok.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 169);
            label4.Name = "label4";
            label4.Size = new Size(137, 21);
            label4.TabIndex = 3;
            label4.Text = "Zemlja lokacije";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 109);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 2;
            label3.Text = "Naziv lokacije";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 63);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 0;
            label1.Text = "Tip lokacije";
            // 
            // LokacijaUpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(793, 347);
            Controls.Add(groupBox1);
            Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "LokacijaUpdateForm";
            Text = "LokacijaUpdateForm";
            Load += LegendaUpdateForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txbBlago;
        private Label label2;
        private TextBox txbNazivLok;
        private TextBox txbTipLok;
        private Button btnAzuriraj;
        private TextBox txbZemljaLok;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}