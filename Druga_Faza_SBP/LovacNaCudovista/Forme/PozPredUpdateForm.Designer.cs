namespace LovacNaCudovista.Forme
{
    partial class PozPredUpdateForm
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
            btnAzuriraj = new Button();
            txbCudId = new TextBox();
            txbJedIme = new TextBox();
            txbStarost = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAzuriraj);
            groupBox1.Controls.Add(txbCudId);
            groupBox1.Controls.Add(txbJedIme);
            groupBox1.Controls.Add(txbStarost);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Bookman Old Style", 10.2F);
            groupBox1.Location = new Point(39, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(655, 239);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Osnovni podaci o poznatom predstavniku";
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.BackColor = SystemColors.ScrollBar;
            btnAzuriraj.Location = new Point(424, 102);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new Size(203, 61);
            btnAzuriraj.TabIndex = 7;
            btnAzuriraj.Text = "Azuriraj";
            btnAzuriraj.UseVisualStyleBackColor = false;
            btnAzuriraj.Click += btnAzuriraj_Click;
            // 
            // txbCudId
            // 
            txbCudId.Location = new Point(187, 102);
            txbCudId.Name = "txbCudId";
            txbCudId.Size = new Size(125, 27);
            txbCudId.TabIndex = 6;
            // 
            // txbJedIme
            // 
            txbJedIme.Location = new Point(187, 52);
            txbJedIme.Name = "txbJedIme";
            txbJedIme.Size = new Size(125, 27);
            txbJedIme.TabIndex = 5;
            // 
            // txbStarost
            // 
            txbStarost.Location = new Point(187, 169);
            txbStarost.Name = "txbStarost";
            txbStarost.Size = new Size(125, 27);
            txbStarost.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 176);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 3;
            label4.Text = "Starost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 109);
            label3.Name = "label3";
            label3.Size = new Size(117, 21);
            label3.TabIndex = 2;
            label3.Text = "Cudoviste Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 55);
            label1.Name = "label1";
            label1.Size = new Size(149, 21);
            label1.TabIndex = 0;
            label1.Text = "Jedinstveno Ime";
            // 
            // PozPredUpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(727, 298);
            Controls.Add(groupBox1);
            Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "PozPredUpdateForm";
            Text = "PozPredUpdateForm";
            Load += PozPredUpdateForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAzuriraj;
        private TextBox txbCudId;
        private TextBox txbJedIme;
        private TextBox txbStarost;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}