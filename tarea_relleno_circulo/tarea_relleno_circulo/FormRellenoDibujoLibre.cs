using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea_relleno_circulo
{
    public partial class FormRellenoDibujoLibre : Form
    {
        Circunferencia circunferencia = new Circunferencia();
        FloodFill floodFill = new FloodFill();
        Boolean pintar = false;
        Boolean dibujar = false;

        public FormRellenoDibujoLibre()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            dibujar = true;
            pintar = false;
            iconButton2.BackColor = Color.GreenYellow;
            iconButton3.BackColor = Color.White;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            pintar = true;
            dibujar = false;
            iconButton3.BackColor = Color.GreenYellow;
            iconButton2.BackColor = Color.White;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
        }

        private async void picCanvas_ClickAsync(object sender, EventArgs e)
        {
            int radio;
            string input = txtRadius.Text.Trim();

            if (dibujar)
            {

                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("El campo de radio no puede estar en blanco.");
                }
                else if (!int.TryParse(input, out radio))
                {
                    MessageBox.Show("Ingrese solo números enteros válidos.");
                }
                else
                {
                    radio = Convert.ToInt32(input);

                    MouseEventArgs me = (MouseEventArgs)e;
                    Point coordinates = me.Location;

                    await Task.Run(() =>
                    {
                        circunferencia.readData(coordinates, radio, picCanvas, lbN, lbX, lbY);
                        circunferencia.DrawCircleMidPoint();
                    });
                }
                
            }

            if (pintar)
            {
                MouseEventArgs me = (MouseEventArgs)e;
                Point coordinates = me.Location;
                await Task.Run(() =>
                {
                    floodFill.ReadData(picCanvas, circunferencia.getBorderPoints());
                    floodFill.miFloodFill(coordinates.X, coordinates.Y);
                });
            }
        }

    }
}
