namespace tarea_relleno_circulo
{
    partial class FormBezier
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
            picCanvas = new PictureBox();
            btnAnimation = new FontAwesome.Sharp.IconButton();
            btnTrace = new FontAwesome.Sharp.IconButton();
            btnCurve = new FontAwesome.Sharp.IconButton();
            btnLinear = new FontAwesome.Sharp.IconButton();
            btnCuadratic = new FontAwesome.Sharp.IconButton();
            btnCubic = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            SuspendLayout();
            // 
            // picCanvas
            // 
            picCanvas.BackColor = SystemColors.Control;
            picCanvas.BorderStyle = BorderStyle.Fixed3D;
            picCanvas.Location = new Point(280, 64);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(543, 433);
            picCanvas.TabIndex = 2;
            picCanvas.TabStop = false;
            picCanvas.MouseDown += picCanvas_MouseDown;
            picCanvas.MouseMove += picCanvas_MouseMove;
            picCanvas.MouseUp += picCanvas_MouseUp;
            // 
            // btnAnimation
            // 
            btnAnimation.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            btnAnimation.IconColor = Color.Black;
            btnAnimation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAnimation.IconSize = 35;
            btnAnimation.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnimation.Location = new Point(44, 343);
            btnAnimation.Name = "btnAnimation";
            btnAnimation.Size = new Size(208, 39);
            btnAnimation.TabIndex = 4;
            btnAnimation.Text = "Mostrar Animación";
            btnAnimation.UseVisualStyleBackColor = true;
            btnAnimation.Click += btnAnimation_Click;
            // 
            // btnTrace
            // 
            btnTrace.IconChar = FontAwesome.Sharp.IconChar.ShoePrints;
            btnTrace.IconColor = Color.Black;
            btnTrace.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTrace.IconSize = 35;
            btnTrace.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrace.Location = new Point(44, 403);
            btnTrace.Name = "btnTrace";
            btnTrace.Size = new Size(208, 39);
            btnTrace.TabIndex = 5;
            btnTrace.Text = "Mostrar Rastro";
            btnTrace.UseVisualStyleBackColor = true;
            btnTrace.Click += btnTrace_Click;
            // 
            // btnCurve
            // 
            btnCurve.IconChar = FontAwesome.Sharp.IconChar.DrawPolygon;
            btnCurve.IconColor = Color.Black;
            btnCurve.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCurve.IconSize = 35;
            btnCurve.ImageAlign = ContentAlignment.MiddleLeft;
            btnCurve.Location = new Point(44, 458);
            btnCurve.Name = "btnCurve";
            btnCurve.Size = new Size(208, 39);
            btnCurve.TabIndex = 6;
            btnCurve.Text = "Mostrar Curva";
            btnCurve.UseVisualStyleBackColor = true;
            btnCurve.Click += btnCurve_Click;
            // 
            // btnLinear
            // 
            btnLinear.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnLinear.IconColor = Color.Navy;
            btnLinear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLinear.IconSize = 35;
            btnLinear.ImageAlign = ContentAlignment.MiddleLeft;
            btnLinear.Location = new Point(280, 12);
            btnLinear.Name = "btnLinear";
            btnLinear.Size = new Size(142, 39);
            btnLinear.TabIndex = 7;
            btnLinear.Text = "Linear";
            btnLinear.UseVisualStyleBackColor = true;
            btnLinear.Click += btnLinear_Click;
            // 
            // btnCuadratic
            // 
            btnCuadratic.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnCuadratic.IconColor = Color.Purple;
            btnCuadratic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCuadratic.IconSize = 35;
            btnCuadratic.ImageAlign = ContentAlignment.MiddleLeft;
            btnCuadratic.Location = new Point(487, 12);
            btnCuadratic.Name = "btnCuadratic";
            btnCuadratic.Size = new Size(142, 39);
            btnCuadratic.TabIndex = 8;
            btnCuadratic.Text = "Cuadrática";
            btnCuadratic.UseVisualStyleBackColor = true;
            btnCuadratic.Click += btnCuadratic_Click;
            // 
            // btnCubic
            // 
            btnCubic.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnCubic.IconColor = Color.Green;
            btnCubic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCubic.IconSize = 35;
            btnCubic.ImageAlign = ContentAlignment.MiddleLeft;
            btnCubic.Location = new Point(681, 12);
            btnCubic.Name = "btnCubic";
            btnCubic.Size = new Size(142, 39);
            btnCubic.TabIndex = 9;
            btnCubic.Text = "Cúbica";
            btnCubic.UseVisualStyleBackColor = true;
            btnCubic.Click += btnCubic_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.FromArgb(64, 0, 64);
            label1.Location = new Point(26, 14);
            label1.Name = "label1";
            label1.Size = new Size(226, 37);
            label1.TabIndex = 10;
            label1.Text = "Curvas de Bezier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            label2.ForeColor = Color.FromArgb(64, 0, 64);
            label2.Location = new Point(44, 261);
            label2.Name = "label2";
            label2.Size = new Size(175, 19);
            label2.TabIndex = 11;
            label2.Text = "Para poder mostrar rastro,";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            label4.ForeColor = Color.FromArgb(64, 0, 64);
            label4.Location = new Point(40, 289);
            label4.Name = "label4";
            label4.Size = new Size(223, 19);
            label4.TabIndex = 13;
            label4.Text = " debe tener activada la animación";
            // 
            // FormBezier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(845, 525);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCubic);
            Controls.Add(btnCuadratic);
            Controls.Add(btnLinear);
            Controls.Add(btnCurve);
            Controls.Add(btnTrace);
            Controls.Add(btnAnimation);
            Controls.Add(picCanvas);
            Name = "FormBezier";
            Text = "FormBezier";
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picCanvas;
        private FontAwesome.Sharp.IconButton btnAnimation;
        private FontAwesome.Sharp.IconButton btnTrace;
        private FontAwesome.Sharp.IconButton btnCurve;
        private FontAwesome.Sharp.IconButton btnLinear;
        private FontAwesome.Sharp.IconButton btnCuadratic;
        private FontAwesome.Sharp.IconButton btnCubic;
        private Label label1;
        private Label label2;
        private Label label4;
    }
}