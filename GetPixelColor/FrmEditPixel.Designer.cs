namespace GetPixelColor
{
    partial class FrmEditPixel
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
            this.imgPixel = new System.Windows.Forms.PictureBox();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.tShowPixel = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgPixel)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPixel
            // 
            this.imgPixel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPixel.Location = new System.Drawing.Point(81, 50);
            this.imgPixel.Name = "imgPixel";
            this.imgPixel.Size = new System.Drawing.Size(250, 250);
            this.imgPixel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPixel.TabIndex = 0;
            this.imgPixel.TabStop = false;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Font = new System.Drawing.Font("Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMoveRight.Location = new System.Drawing.Point(337, 159);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(44, 33);
            this.btnMoveRight.TabIndex = 1;
            this.btnMoveRight.Text = "Þ";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Font = new System.Drawing.Font("Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.btnMoveLeft.Location = new System.Drawing.Point(31, 159);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(44, 33);
            this.btnMoveLeft.TabIndex = 2;
            this.btnMoveLeft.Text = "Ü";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Font = new System.Drawing.Font("Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.btnMoveUp.Location = new System.Drawing.Point(184, 11);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(44, 33);
            this.btnMoveUp.TabIndex = 3;
            this.btnMoveUp.Text = "Ý";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Font = new System.Drawing.Font("Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.btnMoveDown.Location = new System.Drawing.Point(184, 306);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(44, 33);
            this.btnMoveDown.TabIndex = 4;
            this.btnMoveDown.Text = "ß";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // tShowPixel
            // 
            this.tShowPixel.Tick += new System.EventHandler(this.tShowPixel_Tick);
            // 
            // FrmEditPixel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 350);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.imgPixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmEditPixel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar pixel";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.imgPixel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPixel;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Timer tShowPixel;
    }
}