namespace GetPixelColor
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPosicao = new System.Windows.Forms.TextBox();
            this.btnGetPixel = new System.Windows.Forms.Button();
            this.tPosicaoCursor = new System.Windows.Forms.Timer(this.components);
            this.lboxShowPixel = new System.Windows.Forms.ListBox();
            this.tShowPixel = new System.Windows.Forms.Timer(this.components);
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnEsconder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Posição:";
            // 
            // txtPosicao
            // 
            this.txtPosicao.Location = new System.Drawing.Point(94, 13);
            this.txtPosicao.Name = "txtPosicao";
            this.txtPosicao.ReadOnly = true;
            this.txtPosicao.Size = new System.Drawing.Size(149, 20);
            this.txtPosicao.TabIndex = 2;
            // 
            // btnGetPixel
            // 
            this.btnGetPixel.Location = new System.Drawing.Point(249, 11);
            this.btnGetPixel.Name = "btnGetPixel";
            this.btnGetPixel.Size = new System.Drawing.Size(75, 23);
            this.btnGetPixel.TabIndex = 4;
            this.btnGetPixel.Text = "Adicionar";
            this.btnGetPixel.UseVisualStyleBackColor = true;
            this.btnGetPixel.Click += new System.EventHandler(this.btnGetPixel_Click);
            // 
            // tPosicaoCursor
            // 
            this.tPosicaoCursor.Tick += new System.EventHandler(this.tPosicaoCursor_Tick);
            // 
            // lboxShowPixel
            // 
            this.lboxShowPixel.FormattingEnabled = true;
            this.lboxShowPixel.Location = new System.Drawing.Point(12, 68);
            this.lboxShowPixel.Name = "lboxShowPixel";
            this.lboxShowPixel.Size = new System.Drawing.Size(312, 225);
            this.lboxShowPixel.TabIndex = 5;
            this.lboxShowPixel.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lboxShowPixel_Format);
            this.lboxShowPixel.DoubleClick += new System.EventHandler(this.lboxShowPixel_DoubleClick);
            this.lboxShowPixel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lboxShowPixel_KeyUp);
            // 
            // tShowPixel
            // 
            this.tShowPixel.Tick += new System.EventHandler(this.tShowPixel_Tick);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(168, 39);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnEsconder
            // 
            this.btnEsconder.Location = new System.Drawing.Point(249, 39);
            this.btnEsconder.Name = "btnEsconder";
            this.btnEsconder.Size = new System.Drawing.Size(75, 23);
            this.btnEsconder.TabIndex = 8;
            this.btnEsconder.Text = "Esconder";
            this.btnEsconder.UseVisualStyleBackColor = true;
            this.btnEsconder.Click += new System.EventHandler(this.btnEsconder_Click);
            // 
            // FrmMain
            // 
            this.AcceptButton = this.btnGetPixel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 307);
            this.Controls.Add(this.btnEsconder);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lboxShowPixel);
            this.Controls.Add(this.btnGetPixel);
            this.Controls.Add(this.txtPosicao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Pixel Color";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPosicao;
        private System.Windows.Forms.Button btnGetPixel;
        private System.Windows.Forms.Timer tPosicaoCursor;
        private System.Windows.Forms.ListBox lboxShowPixel;
        private System.Windows.Forms.Timer tShowPixel;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnEsconder;
    }
}

