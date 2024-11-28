namespace petel_raziel_ava
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBox1 = new ComboBox();
            button1 = new Button();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Professor", "Aluno" });
            comboBox1.Location = new Point(389, 286);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(346, 28);
            comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(397, 346);
            button1.Name = "button1";
            button1.Size = new Size(327, 29);
            button1.TabIndex = 3;
            button1.Text = "REGISTRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.Controls.Add(guna2HtmlLabel2);
            guna2CustomGradientPanel1.Controls.Add(guna2HtmlLabel1);
            guna2CustomGradientPanel1.Controls.Add(textBox2);
            guna2CustomGradientPanel1.Controls.Add(comboBox1);
            guna2CustomGradientPanel1.Controls.Add(button1);
            guna2CustomGradientPanel1.Controls.Add(textBox1);
            guna2CustomGradientPanel1.Controls.Add(pictureBox1);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges1;
            guna2CustomGradientPanel1.FillColor = Color.Silver;
            guna2CustomGradientPanel1.FillColor2 = Color.Aquamarine;
            guna2CustomGradientPanel1.FillColor3 = Color.MediumTurquoise;
            guna2CustomGradientPanel1.Location = new Point(3, 1);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CustomGradientPanel1.Size = new Size(1056, 607);
            guna2CustomGradientPanel1.TabIndex = 4;
            guna2CustomGradientPanel1.Paint += guna2CustomGradientPanel1_Paint;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.SeaGreen;
            guna2HtmlLabel2.Location = new Point(389, 258);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(82, 22);
            guna2HtmlLabel2.TabIndex = 5;
            guna2HtmlLabel2.Text = "CATEGORIA";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.SeaGreen;
            guna2HtmlLabel1.Font = new Font("Franklin Gothic Medium", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(397, 101);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(338, 45);
            guna2HtmlLabel1.TabIndex = 4;
            guna2HtmlLabel1.Text = "EFETUAR REGISTRO";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(389, 225);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "@Email.com";
            textBox2.Size = new Size(346, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(389, 180);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "NOME";
            textBox1.Size = new Size(346, 27);
            textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1053, 591);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 583);
            Controls.Add(guna2CustomGradientPanel1);
            Name = "Form1";
            Text = "Form1";
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox guna2TextBox1;
        private ComboBox comboBox1;
        private Button button1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
       
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private PictureBox pictureBox1;
    }
}
