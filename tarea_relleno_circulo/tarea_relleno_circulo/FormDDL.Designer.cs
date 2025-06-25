namespace tarea_relleno_circulo
{
    partial class FormDDL
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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            lbPoint2 = new Label();
            lbPoint1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            picCanvas = new PictureBox();
            lbY = new Label();
            lbX = new Label();
            lbN = new Label();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(557, 20);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(141, 38);
            iconButton1.TabIndex = 15;
            iconButton1.Text = "Resetear";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // lbPoint2
            // 
            lbPoint2.AutoSize = true;
            lbPoint2.Location = new Point(297, 24);
            lbPoint2.Name = "lbPoint2";
            lbPoint2.Size = new Size(27, 15);
            lbPoint2.TabIndex = 14;
            lbPoint2.Text = "----";
            // 
            // lbPoint1
            // 
            lbPoint1.AutoSize = true;
            lbPoint1.Location = new Point(97, 24);
            lbPoint1.Name = "lbPoint1";
            lbPoint1.Size = new Size(27, 15);
            lbPoint1.TabIndex = 13;
            lbPoint1.Text = "----";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(12, 53);
            label3.Name = "label3";
            label3.Size = new Size(305, 15);
            label3.TabIndex = 11;
            label3.Text = "Haga click en 2 puntos del recuadro para dibujar la recta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 24);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 10;
            label2.Text = "Punto Final: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 9;
            label1.Text = "Punto Inicial: ";
            // 
            // picCanvas
            // 
            picCanvas.BackColor = SystemColors.Control;
            picCanvas.BorderStyle = BorderStyle.Fixed3D;
            picCanvas.Location = new Point(12, 71);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(705, 395);
            picCanvas.TabIndex = 8;
            picCanvas.TabStop = false;
            picCanvas.Click += picCanvas_Click;
            // 
            // lbY
            // 
            lbY.AutoSize = true;
            lbY.Location = new Point(109, 14);
            lbY.Name = "lbY";
            lbY.Size = new Size(22, 15);
            lbY.TabIndex = 9;
            lbY.Text = "---";
            lbY.Click += lbY_Click;
            // 
            // lbX
            // 
            lbX.AutoSize = true;
            lbX.Location = new Point(62, 14);
            lbX.Name = "lbX";
            lbX.Size = new Size(22, 15);
            lbX.TabIndex = 8;
            lbX.Text = "---";
            // 
            // lbN
            // 
            lbN.AutoSize = true;
            lbN.Location = new Point(14, 14);
            lbN.Name = "lbN";
            lbN.Size = new Size(22, 15);
            lbN.TabIndex = 7;
            lbN.Text = "---";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(733, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(164, 451);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Puntos Dibujados";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(lbX);
            panel1.Controls.Add(lbN);
            panel1.Controls.Add(lbY);
            panel1.Location = new Point(6, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(152, 382);
            panel1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 28);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 12;
            label4.Text = "Y";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 28);
            label5.Name = "label5";
            label5.Size = new Size(14, 15);
            label5.TabIndex = 11;
            label5.Text = "X";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 28);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 10;
            label6.Text = "N.-";
            // 
            // FormDDL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(918, 504);
            Controls.Add(iconButton1);
            Controls.Add(lbPoint2);
            Controls.Add(lbPoint1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picCanvas);
            Controls.Add(groupBox1);
            Name = "FormDDL";
            Text = "FormDDL";
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private Label lbPoint2;
        private Label lbPoint1;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox picCanvas;
        private Label lbY;
        private Label lbX;
        private Label lbN;
        private GroupBox groupBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
    }
}