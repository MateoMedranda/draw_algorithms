namespace tarea_relleno_circulo
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
            menuStrip1 = new MenuStrip();
            algoritmoDiscretizaciónLíneasToolStripMenuItem = new ToolStripMenuItem();
            algoritmosBresenhamToolStripMenuItem = new ToolStripMenuItem();
            algoritmoBresenhamLíneasToolStripMenuItem = new ToolStripMenuItem();
            algoritmoBresenhamCircunferenciaToolStripMenuItem = new ToolStripMenuItem();
            algoritmoDeRellenadoDibujoLibreToolStripMenuItem = new ToolStripMenuItem();
            algoritmosDeRecorteToolStripMenuItem = new ToolStripMenuItem();
            recorteDeLíneasToolStripMenuItem = new ToolStripMenuItem();
            recorteDeFigurasSutherlandHodgmanToolStripMenuItem = new ToolStripMenuItem();
            curvasDeBezierToolStripMenuItem = new ToolStripMenuItem();
            algoritmoBresenhamElipseToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { algoritmoDiscretizaciónLíneasToolStripMenuItem, algoritmosBresenhamToolStripMenuItem, algoritmoDeRellenadoDibujoLibreToolStripMenuItem, algoritmosDeRecorteToolStripMenuItem, curvasDeBezierToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1064, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // algoritmoDiscretizaciónLíneasToolStripMenuItem
            // 
            algoritmoDiscretizaciónLíneasToolStripMenuItem.Name = "algoritmoDiscretizaciónLíneasToolStripMenuItem";
            algoritmoDiscretizaciónLíneasToolStripMenuItem.Size = new Size(185, 20);
            algoritmoDiscretizaciónLíneasToolStripMenuItem.Text = "Algoritmo Discretización Líneas";
            algoritmoDiscretizaciónLíneasToolStripMenuItem.Click += algoritmoDiscretizaciónLíneasToolStripMenuItem_Click;
            // 
            // algoritmosBresenhamToolStripMenuItem
            // 
            algoritmosBresenhamToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { algoritmoBresenhamLíneasToolStripMenuItem, algoritmoBresenhamCircunferenciaToolStripMenuItem, algoritmoBresenhamElipseToolStripMenuItem });
            algoritmosBresenhamToolStripMenuItem.Name = "algoritmosBresenhamToolStripMenuItem";
            algoritmosBresenhamToolStripMenuItem.Size = new Size(140, 20);
            algoritmosBresenhamToolStripMenuItem.Text = "Algoritmos Bresenham";
            // 
            // algoritmoBresenhamLíneasToolStripMenuItem
            // 
            algoritmoBresenhamLíneasToolStripMenuItem.Name = "algoritmoBresenhamLíneasToolStripMenuItem";
            algoritmoBresenhamLíneasToolStripMenuItem.Size = new Size(270, 22);
            algoritmoBresenhamLíneasToolStripMenuItem.Text = "Algoritmo Bresenham Líneas";
            algoritmoBresenhamLíneasToolStripMenuItem.Click += algoritmoBresenhamLíneasToolStripMenuItem_Click_1;
            // 
            // algoritmoBresenhamCircunferenciaToolStripMenuItem
            // 
            algoritmoBresenhamCircunferenciaToolStripMenuItem.Name = "algoritmoBresenhamCircunferenciaToolStripMenuItem";
            algoritmoBresenhamCircunferenciaToolStripMenuItem.Size = new Size(270, 22);
            algoritmoBresenhamCircunferenciaToolStripMenuItem.Text = "Algoritmo Bresenham Circunferencia";
            algoritmoBresenhamCircunferenciaToolStripMenuItem.Click += algoritmoBresenhamCircunferenciaToolStripMenuItem_Click;
            // 
            // algoritmoDeRellenadoDibujoLibreToolStripMenuItem
            // 
            algoritmoDeRellenadoDibujoLibreToolStripMenuItem.Name = "algoritmoDeRellenadoDibujoLibreToolStripMenuItem";
            algoritmoDeRellenadoDibujoLibreToolStripMenuItem.Size = new Size(216, 20);
            algoritmoDeRellenadoDibujoLibreToolStripMenuItem.Text = "Algoritmo de rellenado (Dibujo Libre)";
            algoritmoDeRellenadoDibujoLibreToolStripMenuItem.Click += algoritmoDeRellenadoDibujoLibreToolStripMenuItem_Click;
            // 
            // algoritmosDeRecorteToolStripMenuItem
            // 
            algoritmosDeRecorteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { recorteDeLíneasToolStripMenuItem, recorteDeFigurasSutherlandHodgmanToolStripMenuItem });
            algoritmosDeRecorteToolStripMenuItem.Name = "algoritmosDeRecorteToolStripMenuItem";
            algoritmosDeRecorteToolStripMenuItem.Size = new Size(137, 20);
            algoritmosDeRecorteToolStripMenuItem.Text = "Algoritmos de Recorte";
            // 
            // recorteDeLíneasToolStripMenuItem
            // 
            recorteDeLíneasToolStripMenuItem.Name = "recorteDeLíneasToolStripMenuItem";
            recorteDeLíneasToolStripMenuItem.Size = new Size(290, 22);
            recorteDeLíneasToolStripMenuItem.Text = "Recorte de Líneas Cohen-Sutherland";
            recorteDeLíneasToolStripMenuItem.Click += recorteDeLíneasToolStripMenuItem_Click;
            // 
            // recorteDeFigurasSutherlandHodgmanToolStripMenuItem
            // 
            recorteDeFigurasSutherlandHodgmanToolStripMenuItem.Name = "recorteDeFigurasSutherlandHodgmanToolStripMenuItem";
            recorteDeFigurasSutherlandHodgmanToolStripMenuItem.Size = new Size(290, 22);
            recorteDeFigurasSutherlandHodgmanToolStripMenuItem.Text = "Recorte de Figuras Sutherland-Hodgman";
            recorteDeFigurasSutherlandHodgmanToolStripMenuItem.Click += recorteDeFigurasSutherlandHodgmanToolStripMenuItem_Click;
            // 
            // curvasDeBezierToolStripMenuItem
            // 
            curvasDeBezierToolStripMenuItem.Name = "curvasDeBezierToolStripMenuItem";
            curvasDeBezierToolStripMenuItem.Size = new Size(105, 20);
            curvasDeBezierToolStripMenuItem.Text = "Curvas de Bezier";
            curvasDeBezierToolStripMenuItem.Click += curvasDeBezierToolStripMenuItem_Click;
            // 
            // algoritmoBresenhamElipseToolStripMenuItem
            // 
            algoritmoBresenhamElipseToolStripMenuItem.Name = "algoritmoBresenhamElipseToolStripMenuItem";
            algoritmoBresenhamElipseToolStripMenuItem.Size = new Size(270, 22);
            algoritmoBresenhamElipseToolStripMenuItem.Text = "Algoritmo Bresenham Elipse";
            algoritmoBresenhamElipseToolStripMenuItem.Click += algoritmoBresenhamElipseToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1064, 681);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem algoritmoDiscretizaciónLíneasToolStripMenuItem;
        private ToolStripMenuItem algoritmosBresenhamToolStripMenuItem;
        private ToolStripMenuItem algoritmoBresenhamLíneasToolStripMenuItem;
        private ToolStripMenuItem algoritmoBresenhamCircunferenciaToolStripMenuItem;
        private ToolStripMenuItem algoritmoDeRellenadoDibujoLibreToolStripMenuItem;
        private ToolStripMenuItem algoritmosDeRecorteToolStripMenuItem;
        private ToolStripMenuItem recorteDeLíneasToolStripMenuItem;
        private ToolStripMenuItem recorteDeFigurasSutherlandHodgmanToolStripMenuItem;
        private ToolStripMenuItem curvasDeBezierToolStripMenuItem;
        private ToolStripMenuItem algoritmoBresenhamElipseToolStripMenuItem;
    }
}
