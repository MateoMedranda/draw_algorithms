namespace tarea_relleno_circulo
{
    partial class FormHodgman
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
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnReset = new FontAwesome.Sharp.IconButton();
            btnShowCut = new FontAwesome.Sharp.IconButton();
            picCanvas = new PictureBox();
            btnShowOriginal = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            lbY = new Label();
            lbX = new Label();
            lbN = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 138);
            label8.Name = "label8";
            label8.Size = new Size(212, 15);
            label8.TabIndex = 27;
            label8.Text = "-----------------------------------------";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label6.Location = new Point(120, 106);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 26;
            label6.Text = "ymin: 167";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label7.Location = new Point(34, 106);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 25;
            label7.Text = "xmin: 167";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label5.Location = new Point(120, 51);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 24;
            label5.Text = "ymax: 334";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label4.Location = new Point(34, 51);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 23;
            label4.Text = "xmax: 334";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(34, 82);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 22;
            label3.Text = "Punto Mínimo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(34, 24);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 21;
            label2.Text = "Punto Máximo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(232, 24);
            label1.Name = "label1";
            label1.Size = new Size(418, 15);
            label1.TabIndex = 20;
            label1.Text = "Toca la pantalla cada punto de la figura y luego toca el botón \"Mostrar Figura\"";
            // 
            // btnReset
            // 
            btnReset.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnReset.IconColor = Color.Black;
            btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReset.IconSize = 35;
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(34, 504);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(162, 39);
            btnReset.TabIndex = 19;
            btnReset.Text = "Resetear";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnShowCut
            // 
            btnShowCut.IconChar = FontAwesome.Sharp.IconChar.Scissors;
            btnShowCut.IconColor = Color.Black;
            btnShowCut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnShowCut.IconSize = 35;
            btnShowCut.ImageAlign = ContentAlignment.MiddleLeft;
            btnShowCut.Location = new Point(34, 444);
            btnShowCut.Name = "btnShowCut";
            btnShowCut.Size = new Size(162, 39);
            btnShowCut.TabIndex = 18;
            btnShowCut.Text = "Mostrar Recorte";
            btnShowCut.UseVisualStyleBackColor = true;
            btnShowCut.Click += btnShowCut_Click;
            // 
            // picCanvas
            // 
            picCanvas.BackColor = SystemColors.Control;
            picCanvas.BorderStyle = BorderStyle.Fixed3D;
            picCanvas.Location = new Point(232, 42);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(501, 501);
            picCanvas.TabIndex = 17;
            picCanvas.TabStop = false;
            picCanvas.Click += picCanvas_Click;
            // 
            // btnShowOriginal
            // 
            btnShowOriginal.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnShowOriginal.IconColor = Color.Black;
            btnShowOriginal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnShowOriginal.IconSize = 35;
            btnShowOriginal.ImageAlign = ContentAlignment.MiddleLeft;
            btnShowOriginal.Location = new Point(34, 390);
            btnShowOriginal.Name = "btnShowOriginal";
            btnShowOriginal.Size = new Size(162, 39);
            btnShowOriginal.TabIndex = 16;
            btnShowOriginal.Text = "Mostrar Figura";
            btnShowOriginal.UseVisualStyleBackColor = true;
            btnShowOriginal.Click += btnShowOriginal_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lbY);
            panel1.Controls.Add(lbX);
            panel1.Controls.Add(lbN);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(26, 188);
            panel1.Name = "panel1";
            panel1.Size = new Size(187, 196);
            panel1.TabIndex = 28;
            // 
            // lbY
            // 
            lbY.AutoSize = true;
            lbY.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbY.Location = new Point(135, 37);
            lbY.Name = "lbY";
            lbY.Size = new Size(22, 15);
            lbY.TabIndex = 35;
            lbY.Text = "---";
            // 
            // lbX
            // 
            lbX.AutoSize = true;
            lbX.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbX.Location = new Point(73, 37);
            lbX.Name = "lbX";
            lbX.Size = new Size(22, 15);
            lbX.TabIndex = 34;
            lbX.Text = "---";
            // 
            // lbN
            // 
            lbN.AutoSize = true;
            lbN.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbN.Location = new Point(18, 37);
            lbN.Name = "lbN";
            lbN.Size = new Size(22, 15);
            lbN.TabIndex = 33;
            lbN.Text = "---";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label12.Location = new Point(135, 11);
            label12.Name = "label12";
            label12.Size = new Size(14, 15);
            label12.TabIndex = 32;
            label12.Text = "Y";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label11.Location = new Point(73, 11);
            label11.Name = "label11";
            label11.Size = new Size(14, 15);
            label11.TabIndex = 31;
            label11.Text = "X";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label10.Location = new Point(18, 11);
            label10.Name = "label10";
            label10.Size = new Size(24, 15);
            label10.TabIndex = 30;
            label10.Text = "N.-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(26, 170);
            label9.Name = "label9";
            label9.Size = new Size(155, 15);
            label9.TabIndex = 29;
            label9.Text = "Puntos de la figura Convexa";
            // 
            // FormHodgman
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(757, 588);
            Controls.Add(label9);
            Controls.Add(panel1);
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
            Name = "FormHodgman";
            Text = "FormHodgman";
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnReset;
        private FontAwesome.Sharp.IconButton btnShowCut;
        private PictureBox picCanvas;
        private FontAwesome.Sharp.IconButton btnShowOriginal;
        private Panel panel1;
        private Label lbY;
        private Label lbX;
        private Label lbN;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
    }
}