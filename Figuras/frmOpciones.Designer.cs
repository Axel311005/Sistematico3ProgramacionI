namespace Figuras
{
    partial class frmOpciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpciones));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnBi = new Button();
            btnTri = new Button();
            label1 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.figuras2d;
            pictureBox1.Location = new Point(168, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(570, 162);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(238, 132);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnBi
            // 
            btnBi.Location = new Point(184, 333);
            btnBi.Name = "btnBi";
            btnBi.Size = new Size(187, 46);
            btnBi.TabIndex = 2;
            btnBi.Text = "Bidimensional";
            btnBi.UseVisualStyleBackColor = true;
            btnBi.Click += btnBi_Click;
            // 
            // btnTri
            // 
            btnTri.Location = new Point(597, 333);
            btnTri.Name = "btnTri";
            btnTri.Size = new Size(190, 46);
            btnTri.TabIndex = 3;
            btnTri.Text = "Tridimensional";
            btnTri.UseVisualStyleBackColor = true;
            btnTri.Click += btnTri_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(184, 45);
            label1.Name = "label1";
            label1.Size = new Size(637, 45);
            label1.TabIndex = 4;
            label1.Text = "ESCOGE EL TIPO DE FIGURA QUE DESEA";
            // 
            // button3
            // 
            button3.Location = new Point(420, 476);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 5;
            button3.Text = "SALIR";
            button3.UseVisualStyleBackColor = true;
            // 
            // frmOpciones
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 589);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(btnTri);
            Controls.Add(btnBi);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "frmOpciones";
            Text = "Opciones";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnBi;
        private Button btnTri;
        private Label label1;
        private Button button3;
    }
}