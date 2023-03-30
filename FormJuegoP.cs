using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rompecabezas1
{
    public partial class FormJuegoP : Form
    {
        List<Image> imagenes;
        List<PictureBox> res, imgDesordenadas;
        readonly int x, y, col, filas;
        PictureBox pbSeleccionado;
        int posIx, posIy, posX, posY;
        //int 
        public FormJuegoP(Image img, string dificultad)
        {
            InitializeComponent();
            col = filas = 0;
            switch (dificultad)
            {
                case "Fácil":
                    x = 4;
                    y = 4;
                    col = 8;
                    filas = 2;
                    break;
                case "Medio":
                    x = 5;
                    y = 5;
                    col = 9;
                    filas = 3;
                    break;
                case "Difícil":
                    x = 6;
                    y = 6;
                    col = 12;
                    filas = 3;
                    break;
            }
            imagenes = DividirImagen(img, x);
            this.Width = 46 + (210 * y);
            this.Height = 66 + (105 * x) + (filas * 80);
            this.pbcgfImgRef.Size = new Size(105 * x, 105 * y);
            this.pbcgfImgRef.Location = new Point(24 + (105 * y), 12);
            this.pbcgfImgRef.Image = img;
            this.putPictureBoxPos();
            this.putPictureBoxDesordenado();
        }

        public static List<Image> DividirImagen(Image imagen, int numeroDeDivisiones)
        {
            List<Image> listaDeImagenes = new List<Image>();

            int anchoDeImagen = imagen.Width;
            int altoDeImagen = imagen.Height;

            int anchoDeCorte = anchoDeImagen / numeroDeDivisiones;
            int altoDeCorte = altoDeImagen / numeroDeDivisiones;

            int cont1 = 0, cont2;
            for (int y = 0; cont1 < numeroDeDivisiones; y += altoDeCorte)
            {
                for (int x = cont2 = 0; cont2 < numeroDeDivisiones; x += anchoDeCorte)
                {
                    Bitmap corte = new Bitmap(anchoDeCorte, altoDeCorte);

                    using (Graphics grafico = Graphics.FromImage(corte))
                    {
                        grafico.DrawImage(imagen, new Rectangle(0, 0, anchoDeCorte, altoDeCorte), new Rectangle(x, y, anchoDeCorte, altoDeCorte), GraphicsUnit.Pixel);
                    }
                    cont2++;
                    listaDeImagenes.Add(corte);
                }
                cont1++;
            }

            return listaDeImagenes;
        }

        private void putPictureBoxPos()
        {
            res = new();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    PictureBox pic = new PictureBox();
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Size = new Size(100, 100);
                    pic.Location = new Point((j * 105) + 12, (i * 105) + 12);
                    pic.BackColor = Color.White;
                    pic.Tag = "";
                    pic.Enabled = false;
                    res.Add(pic);
                    Controls.Add(pic);
                }
            }
        }

        private void putPictureBoxDesordenado()
        {
            imgDesordenadas = new();
            int num, cont = 0;
            List<int> nums = new();
            Random rng = new();
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    
                    if (cont == (x * y))
                    {
                        return;
                    }
                    cont++;
                    PictureBox pic = new PictureBox();
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Size = new Size(75, 75);
                    pic.Location = new Point(12 + (j * 80), 24 + (105 * y) + (i * 80));
                    pic.Enabled = false;
                    pic.BackColor = Color.White;
                    do
                    {
                        num = rng.Next(0, (x * y));
                    } while (nums.Contains(num));
                    nums.Add(num);
                    pic.Tag = num;
                    pic.Image = imagenes[num];
                    imgDesordenadas.Add(pic);
                    Controls.Add(pic);

                }
            }
        }


        private void FormJuegoP_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formInicio.Show();
        }

        private void FormJuegoP_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (PictureBox pb in imgDesordenadas)
            {
                if (e.X >= pb.Location.X && e.X <= pb.Location.X + pb.Width
                    && e.Y >= pb.Location.Y && e.Y <= pb.Location.Y + pb.Height && pb.Visible)
                {
                    pbSeleccionado = pb;
                    posX = e.X;
                    posIx = pb.Location.X;
                    posIy = pb.Location.Y;
                    posY = e.Y;
                    pb.BringToFront();
                    return;
                }
            }
            foreach (PictureBox pb in res)
            {
                if (e.X >= pb.Location.X && e.X <= pb.Location.X + pb.Width
                    && e.Y >= pb.Location.Y && e.Y <= pb.Location.Y + pb.Height && pb.Image != null)
                {
                    foreach (PictureBox pb2 in imgDesordenadas)
                    {
                        if (pb2.Tag.ToString() == pb.Tag.ToString())
                        {
                            pbSeleccionado = pb2;
                            posX = e.X;
                            posY = e.Y;
                            posIx = pb2.Location.X;
                            posIy = pb2.Location.Y;
                            pb2.Location = new Point(posX, posY);
                            pb2.Visible = true;
                            pb.Image = null;
                            pb.Tag = "";
                            return;
                        }
                    }
                }
            }

        }

        private void FormJuegoP_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbSeleccionado != null)
            {
                int pX = pbSeleccionado.Location.X, pY = pbSeleccionado.Location.Y;
                pbSeleccionado.Location = new Point(pX + (e.X - posX), pY + (e.Y - posY));
                posX = e.X; posY = e.Y;
            }
        }

        private void FormJuegoP_MouseUp(object sender, MouseEventArgs e)
        {
            if (pbSeleccionado != null)
            {
                int cont = 0;
                foreach (PictureBox pb in res)
                {
                    if (e.X >= pb.Location.X && e.X <= pb.Location.X + pb.Width
                        && e.Y >= pb.Location.Y && e.Y <= pb.Location.Y + pb.Height && pb.Image == null)
                    {
                        pb.Tag = pbSeleccionado.Tag;
                        pb.Image = pbSeleccionado.Image;
                        pbSeleccionado.Visible = false;
                        if (win())
                        {
                            DialogResult dr = MessageBox.Show("Felicidades has ganado!!! \n¿Deseas volver a jugar?", "Felicidades", MessageBoxButtons.YesNo);
                            if(dr == DialogResult.No)
                            {
                                Application.Exit();
                            }
                            Program.formInicio.Show();
                            this.Hide();

                        }
                        break;
                    }
                    cont++;
                }
                pbSeleccionado.Location = new Point(posIx, posIy);
                pbSeleccionado = null;
            }
        }

        private bool win()
        {
            int cont = 0;
            foreach(PictureBox pb in res)
            {
                if(!(pb.Tag.ToString() == cont.ToString()))
                {
                    return false;
                }
                cont++;
            }
            return true;
        }
    }
}
