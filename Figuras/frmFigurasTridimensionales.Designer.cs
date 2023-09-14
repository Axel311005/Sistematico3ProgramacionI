namespace Figuras
{
    partial class frmFigurasTridimensionales
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
            groupBox3 = new GroupBox();
            txtVolumenTri = new TextBox();
            txtAreaTri = new TextBox();
            label10 = new Label();
            label9 = new Label();
            btnAtrasTri = new Button();
            btnSalirTri = new Button();
            btnCalcularTri = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtLadoTri = new TextBox();
            txtRadioTri = new TextBox();
            label3 = new Label();
            label2 = new Label();
            cboTri = new ComboBox();
            label1 = new Label();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtVolumenTri);
            groupBox3.Controls.Add(txtAreaTri);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(571, 201);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(473, 232);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resultados";
            // 
            // txtVolumenTri
            // 
            txtVolumenTri.Location = new Point(184, 122);
            txtVolumenTri.Name = "txtVolumenTri";
            txtVolumenTri.Size = new Size(200, 39);
            txtVolumenTri.TabIndex = 3;
            // 
            // txtAreaTri
            // 
            txtAreaTri.Location = new Point(184, 46);
            txtAreaTri.Name = "txtAreaTri";
            txtAreaTri.Size = new Size(200, 39);
            txtAreaTri.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 129);
            label10.Name = "label10";
            label10.Size = new Size(109, 32);
            label10.TabIndex = 1;
            label10.Text = "Volumen";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 55);
            label9.Name = "label9";
            label9.Size = new Size(62, 32);
            label9.TabIndex = 0;
            label9.Text = "Área";
            // 
            // btnAtrasTri
            // 
            btnAtrasTri.Location = new Point(347, 479);
            btnAtrasTri.Name = "btnAtrasTri";
            btnAtrasTri.Size = new Size(150, 46);
            btnAtrasTri.TabIndex = 14;
            btnAtrasTri.Text = "Atrás";
            btnAtrasTri.UseVisualStyleBackColor = true;
            // 
            // btnSalirTri
            // 
            btnSalirTri.Location = new Point(547, 479);
            btnSalirTri.Name = "btnSalirTri";
            btnSalirTri.Size = new Size(150, 46);
            btnSalirTri.TabIndex = 13;
            btnSalirTri.Text = "Salir";
            btnSalirTri.UseVisualStyleBackColor = true;
            // 
            // btnCalcularTri
            // 
            btnCalcularTri.Location = new Point(326, 116);
            btnCalcularTri.Name = "btnCalcularTri";
            btnCalcularTri.Size = new Size(150, 46);
            btnCalcularTri.TabIndex = 12;
            btnCalcularTri.Text = "Calcular";
            btnCalcularTri.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtLadoTri);
            groupBox1.Controls.Add(txtRadioTri);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(24, 201);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(473, 232);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Área";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 233);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 6;
            // 
            // txtLadoTri
            // 
            txtLadoTri.Location = new Point(176, 156);
            txtLadoTri.Name = "txtLadoTri";
            txtLadoTri.Size = new Size(200, 39);
            txtLadoTri.TabIndex = 3;
            // 
            // txtRadioTri
            // 
            txtRadioTri.Location = new Point(176, 81);
            txtRadioTri.Name = "txtRadioTri";
            txtRadioTri.Size = new Size(200, 39);
            txtRadioTri.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 156);
            label3.Name = "label3";
            label3.Size = new Size(65, 32);
            label3.TabIndex = 1;
            label3.Text = "Lado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 81);
            label2.Name = "label2";
            label2.Size = new Size(74, 32);
            label2.TabIndex = 0;
            label2.Text = "Radio";
            // 
            // cboTri
            // 
            cboTri.FormattingEnabled = true;
            cboTri.Location = new Point(24, 116);
            cboTri.Name = "cboTri";
            cboTri.Size = new Size(242, 40);
            cboTri.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(326, 19);
            label1.Name = "label1";
            label1.Size = new Size(413, 45);
            label1.TabIndex = 8;
            label1.Text = "Figuras Tridimensionales";
            // 
            // frmFigurasTridimensionales
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 611);
            Controls.Add(groupBox3);
            Controls.Add(btnAtrasTri);
            Controls.Add(btnSalirTri);
            Controls.Add(btnCalcularTri);
            Controls.Add(groupBox1);
            Controls.Add(cboTri);
            Controls.Add(label1);
            Name = "frmFigurasTridimensionales";
            Text = "frmFigurasTridimensionales";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private TextBox txtVolumenTri;
        private TextBox txtAreaTri;
        private Label label10;
        private Label label9;
        private Button btnAtrasTri;
        private Button btnSalirTri;
        private Button btnCalcularTri;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtLadoTri;
        private TextBox txtRadioTri;
        private Label label3;
        private Label label2;
        private ComboBox cboTri;
        private Label label1;
    }
}