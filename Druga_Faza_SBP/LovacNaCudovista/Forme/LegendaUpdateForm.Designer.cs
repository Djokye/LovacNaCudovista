namespace LovacNaCudovista.Forme
{
    partial class LegendaUpdateForm
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
            txbText = new TextBox();
            txbPrvoPom = new TextBox();
            btnAzuriraj = new Button();
            txbZemljaPorekla = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbText);
            groupBox1.Controls.Add(txbPrvoPom);
            groupBox1.Controls.Add(btnAzuriraj);
            groupBox1.Controls.Add(txbZemljaPorekla);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Bookman Old Style", 10.2F);
            groupBox1.Location = new Point(39, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(703, 257);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Osnovni podaci o legendi";
            // 
            // txbText
            // 
            txbText.Location = new Point(213, 109);
            txbText.Name = "txbText";
            txbText.Size = new Size(203, 27);
            txbText.TabIndex = 9;
            // 
            // txbPrvoPom
            // 
            txbPrvoPom.Location = new Point(213, 56);
            txbPrvoPom.Name = "txbPrvoPom";
            txbPrvoPom.Size = new Size(125, 27);
            txbPrvoPom.TabIndex = 8;
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.BackColor = Color.Tan;
            btnAzuriraj.Font = new Font("Bookman Old Style", 10.2F);
            btnAzuriraj.Location = new Point(460, 92);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new Size(203, 61);
            btnAzuriraj.TabIndex = 7;
            btnAzuriraj.Text = "Azuriraj";
            btnAzuriraj.UseVisualStyleBackColor = false;
            btnAzuriraj.Click += btnAzuriraj_Click;
            // 
            // txbZemljaPorekla
            // 
            txbZemljaPorekla.Location = new Point(213, 177);
            txbZemljaPorekla.Name = "txbZemljaPorekla";
            txbZemljaPorekla.Size = new Size(125, 27);
            txbZemljaPorekla.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 180);
            label4.Name = "label4";
            label4.Size = new Size(136, 21);
            label4.TabIndex = 3;
            label4.Text = "Zemlja porekla";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 116);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 2;
            label3.Text = "Tekst";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 56);
            label1.Name = "label1";
            label1.Size = new Size(146, 21);
            label1.TabIndex = 0;
            label1.Text = "Prvo pominjanje";
            // 
            // LegendaUpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(788, 338);
            Controls.Add(groupBox1);
            Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "LegendaUpdateForm";
            Text = "LegendaUpdateForm";
            Load += LegendaUpdateForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txbPostojanje;
        private Label label2;
        private Button btnAzuriraj;
        private TextBox txbVekPom;
        private TextBox txbNaziv;
        private TextBox txbZemljaPorekla;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txbText;
        private TextBox txbPrvoPom;
    }
}