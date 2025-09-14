namespace LovacNaCudovista.Forme
{
    partial class SpecSposUpdateForm
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
            txbNaziv = new TextBox();
            btnAzuriraj = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbNaziv);
            groupBox1.Controls.Add(btnAzuriraj);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Bookman Old Style", 10.2F);
            groupBox1.Location = new Point(39, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(643, 141);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Osnovni podaci o sposobnosti";
            // 
            // txbNaziv
            // 
            txbNaziv.Location = new Point(192, 61);
            txbNaziv.Name = "txbNaziv";
            txbNaziv.Size = new Size(125, 27);
            txbNaziv.TabIndex = 8;
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.BackColor = SystemColors.ScrollBar;
            btnAzuriraj.Location = new Point(409, 39);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new Size(203, 64);
            btnAzuriraj.TabIndex = 7;
            btnAzuriraj.Text = "Azuriraj";
            btnAzuriraj.UseVisualStyleBackColor = false;
            btnAzuriraj.Click += btnAzuriraj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 61);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 0;
            label1.Text = "Naziv";
            // 
            // SpecSposUpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(706, 190);
            Controls.Add(groupBox1);
            Font = new Font("Impact", 10.2F);
            Name = "SpecSposUpdateForm";
            Text = "SpecSposUpdateForm";
            Load += SpecSposUpdateForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txbNaziv;
        private Button btnAzuriraj;
        private Label label1;
    }
}