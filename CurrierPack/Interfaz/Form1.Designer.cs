namespace Interfaz
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtusuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtcontraseña = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Iniciarsesion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(98, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(94, 149);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(90, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Bienvenidos";
            // 
            // txtusuario
            // 
            this.txtusuario.Depth = 0;
            this.txtusuario.Hint = "Insertar Codigo";
            this.txtusuario.Location = new System.Drawing.Point(85, 196);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtusuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PasswordChar = '\0';
            this.txtusuario.SelectedText = "";
            this.txtusuario.SelectionLength = 0;
            this.txtusuario.SelectionStart = 0;
            this.txtusuario.Size = new System.Drawing.Size(185, 23);
            this.txtusuario.TabIndex = 2;
            this.txtusuario.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(22, 238);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Password";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(22, 196);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(61, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Usuario";
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Depth = 0;
            this.txtcontraseña.Hint = "Insertar Password";
            this.txtcontraseña.Location = new System.Drawing.Point(100, 238);
            this.txtcontraseña.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcontraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '\0';
            this.txtcontraseña.SelectedText = "";
            this.txtcontraseña.SelectionLength = 0;
            this.txtcontraseña.SelectionStart = 0;
            this.txtcontraseña.Size = new System.Drawing.Size(170, 23);
            this.txtcontraseña.TabIndex = 5;
            this.txtcontraseña.UseSystemPasswordChar = true;
            // 
            // Iniciarsesion
            // 
            this.Iniciarsesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Iniciarsesion.Depth = 0;
            this.Iniciarsesion.Location = new System.Drawing.Point(85, 313);
            this.Iniciarsesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Iniciarsesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.Iniciarsesion.Name = "Iniciarsesion";
            this.Iniciarsesion.Primary = true;
            this.Iniciarsesion.Size = new System.Drawing.Size(98, 32);
            this.Iniciarsesion.TabIndex = 6;
            this.Iniciarsesion.Text = "Iniciar";
            this.Iniciarsesion.UseVisualStyleBackColor = true;
            this.Iniciarsesion.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(85, 271);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(86, 30);
            this.materialCheckBox1.TabIndex = 7;
            this.materialCheckBox1.Text = "Recordar";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 369);
            this.Controls.Add(this.materialCheckBox1);
            this.Controls.Add(this.Iniciarsesion);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtusuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtcontraseña;
        private MaterialSkin.Controls.MaterialRaisedButton Iniciarsesion;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
    }
}

