
namespace DevMe_v006
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.AbrirArchivo = new System.Windows.Forms.OpenFileDialog();
            this.CrearArchivo = new System.Windows.Forms.SaveFileDialog();
            this.Ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.BtnAjustes = new System.Windows.Forms.PictureBox();
            this.BtnTienda = new System.Windows.Forms.PictureBox();
            this.BtnPerfil = new System.Windows.Forms.PictureBox();
            this.BtnRetos = new System.Windows.Forms.PictureBox();
            this.BtnMenu = new System.Windows.Forms.PictureBox();
            this.PanIzquierdo = new System.Windows.Forms.Panel();
            this.PanDerecho = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAjustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnTienda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRetos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).BeginInit();
            this.PanIzquierdo.SuspendLayout();
            this.SuspendLayout();
            // 
            // AbrirArchivo
            // 
            this.AbrirArchivo.FileName = "openFileDialog1";
            // 
            // BtnAjustes
            // 
            this.BtnAjustes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(104)))), ((int)(((byte)(43)))));
            this.BtnAjustes.Image = ((System.Drawing.Image)(resources.GetObject("BtnAjustes.Image")));
            this.BtnAjustes.Location = new System.Drawing.Point(10, 355);
            this.BtnAjustes.Name = "BtnAjustes";
            this.BtnAjustes.Size = new System.Drawing.Size(76, 76);
            this.BtnAjustes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnAjustes.TabIndex = 4;
            this.BtnAjustes.TabStop = false;
            this.Ayuda.SetToolTip(this.BtnAjustes, "Ajustes.");
            this.BtnAjustes.Click += new System.EventHandler(this.BtnAjustes_Click);
            // 
            // BtnTienda
            // 
            this.BtnTienda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(104)))), ((int)(((byte)(43)))));
            this.BtnTienda.Image = ((System.Drawing.Image)(resources.GetObject("BtnTienda.Image")));
            this.BtnTienda.Location = new System.Drawing.Point(10, 273);
            this.BtnTienda.Name = "BtnTienda";
            this.BtnTienda.Size = new System.Drawing.Size(76, 76);
            this.BtnTienda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnTienda.TabIndex = 3;
            this.BtnTienda.TabStop = false;
            this.Ayuda.SetToolTip(this.BtnTienda, "Tienda.");
            this.BtnTienda.Click += new System.EventHandler(this.BtnTienda_Click);
            // 
            // BtnPerfil
            // 
            this.BtnPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(104)))), ((int)(((byte)(43)))));
            this.BtnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("BtnPerfil.Image")));
            this.BtnPerfil.Location = new System.Drawing.Point(10, 191);
            this.BtnPerfil.Name = "BtnPerfil";
            this.BtnPerfil.Size = new System.Drawing.Size(76, 76);
            this.BtnPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnPerfil.TabIndex = 2;
            this.BtnPerfil.TabStop = false;
            this.Ayuda.SetToolTip(this.BtnPerfil, "Perfil.");
            this.BtnPerfil.Click += new System.EventHandler(this.BtnPerfil_Click);
            // 
            // BtnRetos
            // 
            this.BtnRetos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(104)))), ((int)(((byte)(43)))));
            this.BtnRetos.Image = ((System.Drawing.Image)(resources.GetObject("BtnRetos.Image")));
            this.BtnRetos.Location = new System.Drawing.Point(10, 109);
            this.BtnRetos.Name = "BtnRetos";
            this.BtnRetos.Size = new System.Drawing.Size(76, 76);
            this.BtnRetos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnRetos.TabIndex = 1;
            this.BtnRetos.TabStop = false;
            this.Ayuda.SetToolTip(this.BtnRetos, "Retos.");
            this.BtnRetos.Click += new System.EventHandler(this.BtnRetos_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(104)))), ((int)(((byte)(43)))));
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.Location = new System.Drawing.Point(10, 27);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(76, 76);
            this.BtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnMenu.TabIndex = 0;
            this.BtnMenu.TabStop = false;
            this.Ayuda.SetToolTip(this.BtnMenu, "MenuPrincipal");
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // PanIzquierdo
            // 
            this.PanIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(104)))), ((int)(((byte)(43)))));
            this.PanIzquierdo.Controls.Add(this.BtnAjustes);
            this.PanIzquierdo.Controls.Add(this.BtnTienda);
            this.PanIzquierdo.Controls.Add(this.BtnPerfil);
            this.PanIzquierdo.Controls.Add(this.BtnRetos);
            this.PanIzquierdo.Controls.Add(this.BtnMenu);
            this.PanIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.PanIzquierdo.Name = "PanIzquierdo";
            this.PanIzquierdo.Size = new System.Drawing.Size(96, 624);
            this.PanIzquierdo.TabIndex = 1;
            // 
            // PanDerecho
            // 
            this.PanDerecho.BackColor = System.Drawing.SystemColors.Control;
            this.PanDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanDerecho.Location = new System.Drawing.Point(96, 0);
            this.PanDerecho.Name = "PanDerecho";
            this.PanDerecho.Size = new System.Drawing.Size(1000, 624);
            this.PanDerecho.TabIndex = 3;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 624);
            this.Controls.Add(this.PanDerecho);
            this.Controls.Add(this.PanIzquierdo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DevMe";
            this.SizeChanged += new System.EventHandler(this.MenuPrincipal_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.BtnAjustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnTienda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRetos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).EndInit();
            this.PanIzquierdo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog AbrirArchivo;
        private System.Windows.Forms.SaveFileDialog CrearArchivo;
        private System.Windows.Forms.ToolTip Ayuda;
        private System.Windows.Forms.Panel PanIzquierdo;
        private System.Windows.Forms.PictureBox BtnMenu;
        private System.Windows.Forms.Panel PanDerecho;
        private System.Windows.Forms.PictureBox BtnAjustes;
        private System.Windows.Forms.PictureBox BtnTienda;
        private System.Windows.Forms.PictureBox BtnPerfil;
        private System.Windows.Forms.PictureBox BtnRetos;
    }
}