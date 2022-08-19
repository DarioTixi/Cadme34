
namespace CadmeNormas
{
    partial class Bienvenida
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cargando = new CircularProgressBar.CircularProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(3)))), ((int)(((byte)(9)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 100);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(135)))));
            this.label2.Location = new System.Drawing.Point(344, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "BIENVENIDOS";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(3)))), ((int)(((byte)(9)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(135)))));
            this.label1.Location = new System.Drawing.Point(0, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1020, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGLAMENTO TÉCNICO ECUATORIANO RTE INEN 034 (4R)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CadmeNormas.Properties.Resources.Otro;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 100);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::CadmeNormas.Properties.Resources.Revision;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.cargando);
            this.panel2.Location = new System.Drawing.Point(0, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 479);
            this.panel2.TabIndex = 2;
            // 
            // cargando
            // 
            this.cargando.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cargando.AnimationSpeed = 500;
            this.cargando.BackColor = System.Drawing.Color.Transparent;
            this.cargando.Font = new System.Drawing.Font("Javanese Text", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargando.ForeColor = System.Drawing.Color.Maroon;
            this.cargando.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cargando.InnerMargin = 2;
            this.cargando.InnerWidth = -1;
            this.cargando.Location = new System.Drawing.Point(828, 300);
            this.cargando.MarqueeAnimationSpeed = 2000;
            this.cargando.Name = "cargando";
            this.cargando.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(3)))), ((int)(((byte)(9)))));
            this.cargando.OuterMargin = -25;
            this.cargando.OuterWidth = 26;
            this.cargando.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(135)))));
            this.cargando.ProgressWidth = 25;
            this.cargando.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cargando.Size = new System.Drawing.Size(164, 155);
            this.cargando.StartAngle = 270;
            this.cargando.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.cargando.SubscriptColor = System.Drawing.Color.Maroon;
            this.cargando.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cargando.SubscriptText = "";
            this.cargando.SuperscriptColor = System.Drawing.Color.Maroon;
            this.cargando.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cargando.SuperscriptText = "%";
            this.cargando.TabIndex = 3;
            this.cargando.Text = "0";
            this.cargando.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cargando.Value = 68;
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1020, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenida";
            this.Load += new System.EventHandler(this.Bienvenida_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel2;
        private CircularProgressBar.CircularProgressBar cargando;
    }
}