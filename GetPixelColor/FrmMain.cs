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
    public partial class FrmMain : Form
    {
        public Dictionary<ShowPixel, bool> DictShowPixel { get; set; }
        public List<ShowPixel> ToRemove { get; set; }

        public FrmMain()
        {
            InitializeComponent();
            ToRemove = new List<ShowPixel>();

            tShowPixel.Interval = 50;
            tPosicaoCursor.Interval = 50;

            tShowPixel.Start();
            this.tPosicaoCursor.Start();
        }

        private void btnGetPixel_Click(object sender, EventArgs e)
        {
            Point newPos = Cursor.Position;
            ShowPixel fSP = new ShowPixel(newPos);
            fSP.Disposed += new EventHandler(fSP_Disposed);
            fSP.Show();

            this.lboxShowPixel.Items.Add(fSP);

            if ((this.lboxShowPixel.Items.Count >= 17) && (this.btnGetPixel.Enabled))
            {
                this.btnGetPixel.Enabled = false;
            }

            this.Focus();
        }

        void fSP_Disposed(object sender, EventArgs e)
        {
            lock (this.ToRemove)
            {
                ToRemove.Add((ShowPixel)sender);
            }
        }

        private void tPosicaoCursor_Tick(object sender, EventArgs e)
        {
            Point cursorPosition = Cursor.Position;
            this.txtPosicao.Text = String.Format("X: {0} Y: {1}", cursorPosition.X.ToString(), cursorPosition.Y.ToString());
        }

        private void tShowPixel_Tick(object sender, EventArgs e)
        {
            lock (this.ToRemove)
            {
                if (this.ToRemove.Count > 0)
                {
                    foreach (ShowPixel fSP in this.ToRemove)
                    {
                        this.lboxShowPixel.Items.Remove(fSP);
                        if (!this.btnGetPixel.Enabled)
                        {
                            this.btnGetPixel.Enabled = true;
                        }
                    }
                    this.ToRemove.Clear();
                }
            }

            if (this.lboxShowPixel.Items.Count < 1) return;

            if (this.Visible)
            {
                // Atualiza todos os itens
                // typeof(ListBox).InvokeMember("RefreshItems", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.InvokeMethod, null, this.lboxShowPixel, new object[] { });

                // Atualiza item por item da lista
                for (int i = 0; i < this.lboxShowPixel.Items.Count; i++)
                {
                    typeof(ListBox).InvokeMember("RefreshItem", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.InvokeMethod, null, this.lboxShowPixel, new object[] { i });
                }
            }
        }

        private void lboxShowPixel_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = e.ListItem.ToString();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            foreach (ShowPixel fSP in this.lboxShowPixel.Items)
            {
                if (!fSP.Visible) fSP.Visible = true;
            }
            this.Focus();
        }

        private void btnEsconder_Click(object sender, EventArgs e)
        {
            foreach (ShowPixel fSP in this.lboxShowPixel.Items)
            {
                if (fSP.Visible) fSP.Visible = false;
            }
            this.Focus();
        }

        private void lboxShowPixel_DoubleClick(object sender, EventArgs e)
        {
            if (this.lboxShowPixel.SelectedItem != null)
            {
                ShowPixel fSP = (ShowPixel)this.lboxShowPixel.SelectedItem;
                FrmEditPixel fEP = new FrmEditPixel(fSP);
                fEP.Show();
                this.Visible = false;
                fEP.FormClosed += new FormClosedEventHandler(fEP_FormClosed);
            }
        }

        void fEP_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void lboxShowPixel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ShowPixel fSP = (ShowPixel)this.lboxShowPixel.SelectedItem;
                if (fSP != null) { fSP.Close(); }
            }
        }
    }
}
