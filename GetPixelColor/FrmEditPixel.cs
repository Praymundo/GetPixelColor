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
    public partial class FrmEditPixel : Form
    {
        private ShowPixel _fSP { get; set; }

        public FrmEditPixel(ShowPixel pShowPixel)
        {
            InitializeComponent();
            this._fSP = pShowPixel;
            this.tShowPixel.Start();
        }

        private void tShowPixel_Tick(object sender, EventArgs e)
        {
            this.imgPixel.Image = _fSP.GetImage(50, true);
            string newText = "Editando: " + _fSP.ToString();
            if (!this.Text.Equals(newText)) { this.Text = newText; }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            this._fSP.MoveUp();
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            this._fSP.MoveRight();
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            this._fSP.MoveDown();
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            this._fSP.MoveLeft();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    this.btnMoveLeft.Focus();
                    this.btnMoveLeft_Click(new object(), new EventArgs());
                    return true;
                case Keys.Right:
                    this.btnMoveRight.Focus();
                    this.btnMoveRight_Click(new object(), new EventArgs());
                    return true;
                case Keys.Up:
                    this.btnMoveUp.Focus();
                    this.btnMoveUp_Click(new object(), new EventArgs());
                    return true;
                case Keys.Down:
                    this.btnMoveDown.Focus();
                    this.btnMoveDown_Click(new object(), new EventArgs());
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
