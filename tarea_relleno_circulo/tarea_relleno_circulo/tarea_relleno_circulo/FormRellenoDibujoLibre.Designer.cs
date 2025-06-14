namespace tarea_relleno_circulo
{
    partial class FormRellenoDibujoLibre
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
            txtRadius = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            label1 = new Label();
            picCanvas = new PictureBox();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            lbY = new Label();
            lbX = new Label();
            lbN = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(61, 20);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(100, 23);
            txtRadius.TabIndex = 38;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(576, 486);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(141, 38);
            iconButton1.TabIndex = 37;
            iconButton1.Text = "Resetear";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(202, 9);
            label3.Name = "label3";
            label3.Size = new Size(456, 15);
            label3.TabIndex = 35;
            label3.Text = "Haga click en cualquier punto del recuadro para usar como centro de la circunferencia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 34;
            label1.Text = "Radio: ";
            // 
            // picCanvas
            // 
            picCanvas.BackColor = SystemColors.Control;
            picCanvas.BorderStyle = BorderStyle.Fixed3D;
            picCanvas.Location = new Point(12, 70);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(705, 395);
            picCanvas.TabIndex = 33;
            picCanvas.TabStop = false;
            picCanvas.Click += picCanvas_ClickAsync;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(733, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(187, 451);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Puntos Dibujados";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(lbY);
            panel1.Controls.Add(lbX);
            panel1.Controls.Add(lbN);
            panel1.Location = new Point(6, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(166, 377);
            panel1.TabIndex = 10;
            // 
            // lbY
            // 
            lbY.AutoSize = true;
            lbY.Location = new Point(109, 13);
            lbY.Name = "lbY";
            lbY.Size = new Size(17, 15);
            lbY.TabIndex = 13;
            lbY.Text = "--";
            // 
            // lbX
            // 
            lbX.AutoSize = true;
            lbX.Location = new Point(59, 13);
            lbX.Name = "lbX";
            lbX.Size = new Size(17, 15);
            lbX.TabIndex = 12;
            lbX.Text = "--";
            // 
            // lbN
            // 
            lbN.AutoSize = true;
            lbN.Location = new Point(14, 13);
            lbN.Name = "lbN";
            lbN.Size = new Size(17, 15);
            lbN.TabIndex = 11;
            lbN.Text = "--";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(115, 28);
            label8.Name = "label8";
            label8.Size = new Size(14, 15);
            label8.TabIndex = 9;
            label8.Text = "Y";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(68, 28);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 8;
            label7.Text = "X";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 28);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 7;
            label6.Text = "N.-";
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 40;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(12, 486);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(160, 38);
            iconButton2.TabIndex = 41;
            iconButton2.Text = "Modo Dibujo";
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton3
            // 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.FillDrip;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 40;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(202, 486);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(160, 38);
            iconButton3.TabIndex = 42;
            iconButton3.Text = "Modo Pintura";
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(202, 28);
            label2.Name = "label2";
            label2.Size = new Size(308, 15);
            label2.TabIndex = 43;
            label2.Text = "Para cambiar de modo use los botones de la parte inferior";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(202, 52);
            label4.Name = "label4";
            label4.Size = new Size(296, 15);
            label4.TabIndex = 44;
            label4.Text = "Para pintar, haga click dentro de los círculos que dibuje";
            // 
            // FormRellenoDibujoLibre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(936, 536);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(iconButton3);
            Controls.Add(iconButton2);
            Controls.Add(txtRadius);
            Controls.Add(iconButton1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(picCanvas);
            Controls.Add(groupBox1);
            Name = "FormRellenoDibujoLibre";
            Text = "FormRellenoDibujoLibre";
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtRadius;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label3;
        private Label label1;
        private PictureBox picCanvas;
        private GroupBox groupBox1;
        private Panel panel1;
        private Label lbY;
        private Label lbX;
        private Label lbN;
        private Label label8;
        private Label label7;
        private Label label6;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Label label2;
        private Label label4;
    }
}