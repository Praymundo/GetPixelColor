using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GetPixelColor
{
    public partial class ShowPixel : Form
    {
        public int PixelX { get; private set; }
        public int PixelY { get; private set; }
        public Color Cor { get; private set; }

        public int PosX
        {
            get
            {
                return this.PixelX - 1;
            }
        }

        public int PosY
        {
            get
            {
                return this.PixelY - 1;
            }
        }

        public Point Posicao
        {
            get
            {
                return new Point(this.PosX, this.PosY);
            }
        }

        public Point Pixel
        {
            get
            {
                return new Point(this.PixelX, this.PixelY);
            }
            private set
            {
                this.PixelX = value.X;
                this.PixelY = value.Y;
            }
        }

        public ShowPixel()
        {
            this.InicializarValores(0, 0);
        }

        public ShowPixel(int pPixelX = 0, int pPixelY = 0)
        {
            this.InicializarValores(pPixelX, pPixelY);
        }

        public ShowPixel(Point pPixelPos)
        {
            this.InicializarValores(pPixelPos.X, pPixelPos.Y);
        }

        private void InicializarValores(int pPixelPosX, int pPixelPosY)
        {
            InitializeComponent();

            this.PixelX = pPixelPosX;
            this.PixelY = pPixelPosY;

            this.ShowInTaskbar = false;

            this.Location = this.Posicao;

            this.tUpdateColor.Start();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // turn on WS_EX_TOOLWINDOW style bit
                // Remove do ALT+TAB
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

        public override string ToString()
        {
            return String.Format("X: {0} Y: {1}, Cor: {2}", this.PixelX, this.PixelY, this.Cor.Name);
        }

        public void GetColorFromScreen()
        {
            using (Bitmap bmpScreenCapture = this.GetImage(0))
            {
                this.Cor = bmpScreenCapture.GetPixel(0, 0);
            }
        }

        public Bitmap GetImage(int pArea = 0, bool pDrawPixelBorder = false)
        {
            if (pArea < 0) pArea = 0;

            Bitmap bmpScreenCapture = new Bitmap(1, 1);
            if (pArea > 0)
            {
                bmpScreenCapture = new Bitmap((pArea * 2), (pArea * 2));
            }
            
            using (Graphics g = Graphics.FromImage(bmpScreenCapture))
            {
                int getPosX = (this.PixelX - pArea);
                int getPosY = (this.PixelY - pArea);
                g.CopyFromScreen(getPosX, getPosY, 0, 0, bmpScreenCapture.Size, CopyPixelOperation.SourceCopy);
                if ((pArea > 0) && (pDrawPixelBorder))
                {
                    Color penColor = Color.LimeGreen;
                    Pen objPen = new Pen(penColor);

                    g.DrawLine(objPen, (pArea - 1), (pArea - 1), (pArea + 1), (pArea - 1));
                    g.DrawLine(objPen, (pArea + 1), (pArea - 1), (pArea + 1), (pArea + 1));
                    g.DrawLine(objPen, (pArea + 1), (pArea + 1), (pArea - 1), (pArea + 1));
                    g.DrawLine(objPen, (pArea - 1), (pArea + 1), (pArea - 1), (pArea - 1));
                }

                //if (pArea > 1)
                //{
                //    Color penColor = Color.Red;
                //    Pen objPen = new Pen(penColor);

                //    g.DrawLine(objPen, 0, 0, ((pArea * 2) - 1), 0);
                //    g.DrawLine(objPen, ((pArea * 2) - 1), 0, ((pArea * 2) - 1), ((pArea * 2) - 1));
                //    g.DrawLine(objPen, ((pArea * 2) - 1), ((pArea * 2) - 1), 0, ((pArea * 2) - 1));
                //    g.DrawLine(objPen, 0, ((pArea * 2) - 1), 0, 0);
                //}
            }

            return bmpScreenCapture;
        }

        public void MoveUp(int pPixels = 1)
        {
            this.PixelY -= pPixels;
            this.Location = this.Posicao;
        }

        public void MoveRight(int pPixels = 1)
        {
            this.PixelX += pPixels;
            this.Location = this.Posicao;
        }

        public void MoveDown(int pPixels = 1)
        {
            this.PixelY += pPixels;
            this.Location = this.Posicao;
        }

        public void MoveLeft(int pPixels = 1)
        {
            this.PixelX -= pPixels;
            this.Location = this.Posicao;
        }

        private void tUpdateColor_Tick(object sender, EventArgs e)
        {
            this.GetColorFromScreen();
        }
    }
}
