namespace tarea_relleno_circulo
{
    partial class FormElipse
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
            lbPoint = new Label();
            label2 = new Label();
            txtRadiusA = new TextBox();
            btnReset = new FontAwesome.Sharp.IconButton();
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
            txtRadiusB = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbPoint
            // 
            lbPoint.AutoSize = true;
            lbPoint.Location = new Point(441, 31);
            lbPoint.Name = "lbPoint";
            lbPoint.Size = new Size(27, 15);
            lbPoint.TabIndex = 40;
            lbPoint.Text = "----";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 31);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 39;
            label2.Text = "Punto central: ";
            // 
            // txtRadiusA
            // 
            txtRadiusA.Location = new Point(63, 28);
            txtRadiusA.Name = "txtRadiusA";
            txtRadiusA.Size = new Size(72, 23);
            txtRadiusA.TabIndex = 38;
            // 
            // btnReset
            // 
            btnReset.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnReset.IconColor = Color.Black;
            btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReset.IconSize = 40;
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(559, 27);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(141, 38);
            btnReset.TabIndex = 37;
            btnReset.Text = "Resetear";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(14, 60);
            label3.Name = "label3";
            label3.Size = new Size(456, 15);
            label3.TabIndex = 35;
            label3.Text = "Haga click en cualquier punto del recuadro para usar como centro de la circunferencia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 31);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 34;
            label1.Text = "Radio a: ";
            // 
            // picCanvas
            // 
            picCanvas.BackColor = SystemColors.Control;
            picCanvas.BorderStyle = BorderStyle.Fixed3D;
            picCanvas.Location = new Point(14, 78);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(705, 395);
            picCanvas.TabIndex = 33;
            picCanvas.TabStop = false;
            picCanvas.Click += picCanvas_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(735, 22);
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
            // txtRadiusB
            // 
            txtRadiusB.Location = new Point(205, 31);
            txtRadiusB.Name = "txtRadiusB";
            txtRadiusB.Size = new Size(72, 23);
            txtRadiusB.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(156, 34);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 41;
            label4.Text = "Radio b: ";
            // 
            // FormElipse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 494);
            Controls.Add(txtRadiusB);
            Controls.Add(label4);
            Controls.Add(lbPoint);
            Controls.Add(label2);
            Controls.Add(txtRadiusA);
            Controls.Add(btnReset);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(picCanvas);
            Controls.Add(groupBox1);
            Name = "FormElipse";
            Text = "FormElipse";
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPoint;
        private Label label2;
        private TextBox txtRadiusA;
        private FontAwesome.Sharp.IconButton btnReset;
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
        private TextBox txtRadiusB;
        private Label label4;
    }
}