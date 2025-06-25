namespace tarea_relleno_circulo
{
    partial class FormCohen
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
            btnShowOriginal = new FontAwesome.Sharp.IconButton();
            picCanvas = new PictureBox();
            btnShowCut = new FontAwesome.Sharp.IconButton();
            btnReset = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lbPoint1 = new Label();
            lbPoint2 = new Label();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            SuspendLayout();
            // 
            // btnShowOriginal
            // 
            btnShowOriginal.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnShowOriginal.IconColor = Color.Black;
            btnShowOriginal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnShowOriginal.IconSize = 35;
            btnShowOriginal.ImageAlign = ContentAlignment.MiddleLeft;
            btnShowOriginal.Location = new Point(31, 410);
            btnShowOriginal.Name = "btnShowOriginal";
            btnShowOriginal.Size = new Size(162, 39);
            btnShowOriginal.TabIndex = 0;
            btnShowOriginal.Text = "Mostrar Original";
            btnShowOriginal.UseVisualStyleBackColor = true;
            btnShowOriginal.Click += btnShowOriginal_Click;
            // 
            // picCanvas
            // 
            picCanvas.BackColor = SystemColors.Control;
            picCanvas.BorderStyle = BorderStyle.Fixed3D;
            picCanvas.Location = new Point(229, 62);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(501, 501);
            picCanvas.TabIndex = 1;
            picCanvas.TabStop = false;
            picCanvas.Click += picCanvas_Click;
            // 
            // btnShowCut
            // 
            btnShowCut.IconChar = FontAwesome.Sharp.IconChar.Scissors;
            btnShowCut.IconColor = Color.Black;
            btnShowCut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnShowCut.IconSize = 35;
            btnShowCut.ImageAlign = ContentAlignment.MiddleLeft;
            btnShowCut.Location = new Point(31, 464);
            btnShowCut.Name = "btnShowCut";
            btnShowCut.Size = new Size(162, 39);
            btnShowCut.TabIndex = 2;
            btnShowCut.Text = "Mostrar Recorte";
            btnShowCut.UseVisualStyleBackColor = true;
            btnShowCut.Click += btnShowCut_Click;
            // 
            // btnReset
            // 
            btnReset.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnReset.IconColor = Color.Black;
            btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReset.IconSize = 35;
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(31, 524);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(162, 39);
            btnReset.TabIndex = 3;
            btnReset.Text = "Resetear";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(229, 44);
            label1.Name = "label1";
            label1.Size = new Size(252, 15);
            label1.TabIndex = 4;
            label1.Text = "Haga click en dos puntos para graficar la línea";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(31, 75);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 5;
            label2.Text = "Punto Máximo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(31, 142);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 6;
            label3.Text = "Punto Mínimo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label4.Location = new Point(31, 109);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 7;
            label4.Text = "xmax: 334";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label5.Location = new Point(117, 109);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 8;
            label5.Text = "ymax: 334";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label6.Location = new Point(117, 174);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 10;
            label6.Text = "ymin: 167";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label7.Location = new Point(31, 174);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 9;
            label7.Text = "xmin: 167";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 200);
            label8.Name = "label8";
            label8.Size = new Size(212, 15);
            label8.TabIndex = 11;
            label8.Text = "-----------------------------------------";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(31, 299);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 13;
            label9.Text = "Punto Final:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(31, 232);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 12;
            label10.Text = "Punto Inicial:";
            // 
            // lbPoint1
            // 
            lbPoint1.AutoSize = true;
            lbPoint1.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbPoint1.Location = new Point(31, 264);
            lbPoint1.Name = "lbPoint1";
            lbPoint1.Size = new Size(22, 15);
            lbPoint1.TabIndex = 14;
            lbPoint1.Text = "---";
            // 
            // lbPoint2
            // 
            lbPoint2.AutoSize = true;
            lbPoint2.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbPoint2.Location = new Point(31, 330);
            lbPoint2.Name = "lbPoint2";
            lbPoint2.Size = new Size(22, 15);
            lbPoint2.TabIndex = 15;
            lbPoint2.Text = "---";
            // 
            // FormCohen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(757, 588);
            Controls.Add(lbPoint2);
            Controls.Add(lbPoint1);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnReset);
            Controls.Add(btnShowCut);
            Controls.Add(picCanvas);
            Controls.Add(btnShowOriginal);
            Name = "FormCohen";
            Text = "FormCohen";
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnShowOriginal;
        private PictureBox picCanvas;
        private FontAwesome.Sharp.IconButton btnShowCut;
        private FontAwesome.Sharp.IconButton btnReset;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lbPoint1;
        private Label lbPoint2;
    }
}