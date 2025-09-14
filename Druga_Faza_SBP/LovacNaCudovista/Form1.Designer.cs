namespace LovacNaCudovista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnPredmet = new Button();
            btnCud = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPredmet
            // 
            btnPredmet.BackColor = SystemColors.ActiveBorder;
            btnPredmet.Location = new Point(151, 372);
            btnPredmet.Name = "btnPredmet";
            btnPredmet.Size = new Size(194, 49);
            btnPredmet.TabIndex = 4;
            btnPredmet.Text = "Predmet";
            btnPredmet.UseVisualStyleBackColor = false;
            btnPredmet.Click += btnPredmet_Click;
            // 
            // btnCud
            // 
            btnCud.BackColor = SystemColors.ScrollBar;
            btnCud.Location = new Point(538, 372);
            btnCud.Margin = new Padding(2, 4, 2, 4);
            btnCud.Name = "btnCud";
            btnCud.Size = new Size(208, 49);
            btnCud.TabIndex = 1;
            btnCud.Text = "Cudovista";
            btnCud.UseVisualStyleBackColor = false;
            btnCud.Click += btnCud_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(325, 151);
            pictureBox1.Margin = new Padding(2, 4, 2, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Harlow Solid Italic", 25.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(258, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(427, 138);
            label1.TabIndex = 3;
            label1.Text = "Lovac na Cudovista";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 506);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnCud);
            Controls.Add(btnPredmet);
            Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2, 4, 2, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPredmet;
        private Button btnCud;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
