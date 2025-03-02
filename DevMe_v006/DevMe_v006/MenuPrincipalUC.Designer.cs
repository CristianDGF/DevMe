
namespace DevMe_v006
{
    partial class MenuPrincipalUC
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalUC));
            this.PanMenuPrincipal = new System.Windows.Forms.Panel();
            this.PizarronBug = new System.Windows.Forms.RichTextBox();
            this.ImgPizarron = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Bug = new System.Windows.Forms.PictureBox();
            this.LblCrearArchivo = new System.Windows.Forms.Label();
            this.LblAbrir = new System.Windows.Forms.Label();
            this.PanRecientes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAbrir = new System.Windows.Forms.PictureBox();
            this.BtnCrear = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.PanMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPizarron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bug)).BeginInit();
            this.PanRecientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAbrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCrear)).BeginInit();
            this.SuspendLayout();
            // 
            // PanMenuPrincipal
            // 
            this.PanMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(217)))));
            this.PanMenuPrincipal.Controls.Add(this.PizarronBug);
            this.PanMenuPrincipal.Controls.Add(this.ImgPizarron);
            this.PanMenuPrincipal.Controls.Add(this.Logo);
            this.PanMenuPrincipal.Controls.Add(this.Bug);
            this.PanMenuPrincipal.Controls.Add(this.LblCrearArchivo);
            this.PanMenuPrincipal.Controls.Add(this.LblAbrir);
            this.PanMenuPrincipal.Controls.Add(this.PanRecientes);
            this.PanMenuPrincipal.Controls.Add(this.BtnAbrir);
            this.PanMenuPrincipal.Controls.Add(this.BtnCrear);
            this.PanMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanMenuPrincipal.Name = "PanMenuPrincipal";
            this.PanMenuPrincipal.Size = new System.Drawing.Size(1030, 630);
            this.PanMenuPrincipal.TabIndex = 11;
            this.PanMenuPrincipal.SizeChanged += new System.EventHandler(this.PanMenuPrincipal_SizeChanged);
            // 
            // PizarronBug
            // 
            this.PizarronBug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PizarronBug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(79)))), ((int)(((byte)(58)))));
            this.PizarronBug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PizarronBug.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PizarronBug.ForeColor = System.Drawing.Color.White;
            this.PizarronBug.Location = new System.Drawing.Point(177, 130);
            this.PizarronBug.Name = "PizarronBug";
            this.PizarronBug.ReadOnly = true;
            this.PizarronBug.Size = new System.Drawing.Size(327, 189);
            this.PizarronBug.TabIndex = 8;
            this.PizarronBug.Text = "";
            // 
            // ImgPizarron
            // 
            this.ImgPizarron.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgPizarron.Image = ((System.Drawing.Image)(resources.GetObject("ImgPizarron.Image")));
            this.ImgPizarron.Location = new System.Drawing.Point(164, 118);
            this.ImgPizarron.Name = "ImgPizarron";
            this.ImgPizarron.Size = new System.Drawing.Size(414, 224);
            this.ImgPizarron.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgPizarron.TabIndex = 9;
            this.ImgPizarron.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(217)))));
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(6, 16);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(173, 149);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            this.Ayuda.SetToolTip(this.Logo, "DevMe.");
            // 
            // Bug
            // 
            this.Bug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(217)))));
            this.Bug.Image = ((System.Drawing.Image)(resources.GetObject("Bug.Image")));
            this.Bug.Location = new System.Drawing.Point(581, 298);
            this.Bug.Name = "Bug";
            this.Bug.Size = new System.Drawing.Size(150, 150);
            this.Bug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bug.TabIndex = 7;
            this.Bug.TabStop = false;
            this.Ayuda.SetToolTip(this.Bug, "Hola, yo soy Bug.");
            this.Bug.Click += new System.EventHandler(this.Bug_Click);
            // 
            // LblCrearArchivo
            // 
            this.LblCrearArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblCrearArchivo.AutoSize = true;
            this.LblCrearArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(154)))), ((int)(((byte)(119)))));
            this.LblCrearArchivo.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCrearArchivo.ForeColor = System.Drawing.Color.White;
            this.LblCrearArchivo.Location = new System.Drawing.Point(92, 459);
            this.LblCrearArchivo.Name = "LblCrearArchivo";
            this.LblCrearArchivo.Size = new System.Drawing.Size(49, 21);
            this.LblCrearArchivo.TabIndex = 5;
            this.LblCrearArchivo.Text = "Crear";
            this.LblCrearArchivo.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // LblAbrir
            // 
            this.LblAbrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblAbrir.AutoSize = true;
            this.LblAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(154)))), ((int)(((byte)(119)))));
            this.LblAbrir.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAbrir.ForeColor = System.Drawing.Color.White;
            this.LblAbrir.Location = new System.Drawing.Point(92, 573);
            this.LblAbrir.Name = "LblAbrir";
            this.LblAbrir.Size = new System.Drawing.Size(48, 21);
            this.LblAbrir.TabIndex = 6;
            this.LblAbrir.Text = "Abrir";
            this.LblAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // PanRecientes
            // 
            this.PanRecientes.AutoScroll = true;
            this.PanRecientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(87)))), ((int)(((byte)(202)))));
            this.PanRecientes.Controls.Add(this.label1);
            this.PanRecientes.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanRecientes.Location = new System.Drawing.Point(749, 0);
            this.PanRecientes.Name = "PanRecientes";
            this.PanRecientes.Size = new System.Drawing.Size(281, 630);
            this.PanRecientes.TabIndex = 1;
            this.Ayuda.SetToolTip(this.PanRecientes, "Archivos recientes.");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(32)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recientes:";
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(217)))));
            this.BtnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("BtnAbrir.Image")));
            this.BtnAbrir.Location = new System.Drawing.Point(15, 549);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(224, 71);
            this.BtnAbrir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnAbrir.TabIndex = 4;
            this.BtnAbrir.TabStop = false;
            this.Ayuda.SetToolTip(this.BtnAbrir, "Abrir un archivo ya creado.");
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // BtnCrear
            // 
            this.BtnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(217)))));
            this.BtnCrear.Image = ((System.Drawing.Image)(resources.GetObject("BtnCrear.Image")));
            this.BtnCrear.Location = new System.Drawing.Point(3, 427);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(236, 81);
            this.BtnCrear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnCrear.TabIndex = 3;
            this.BtnCrear.TabStop = false;
            this.Ayuda.SetToolTip(this.BtnCrear, "Crear un archivo nuevo.");
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MenuPrincipalUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanMenuPrincipal);
            this.Name = "MenuPrincipalUC";
            this.Size = new System.Drawing.Size(1030, 630);
            this.Load += new System.EventHandler(this.MenuPrincipalUC_Load);
            this.PanMenuPrincipal.ResumeLayout(false);
            this.PanMenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPizarron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bug)).EndInit();
            this.PanRecientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnAbrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCrear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanMenuPrincipal;
        public System.Windows.Forms.RichTextBox PizarronBug;
        private System.Windows.Forms.PictureBox ImgPizarron;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox Bug;
        private System.Windows.Forms.Label LblCrearArchivo;
        private System.Windows.Forms.Label LblAbrir;
        private System.Windows.Forms.Panel PanRecientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtnAbrir;
        private System.Windows.Forms.PictureBox BtnCrear;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip Ayuda;
        public System.Windows.Forms.Timer timer2;
    }
}
