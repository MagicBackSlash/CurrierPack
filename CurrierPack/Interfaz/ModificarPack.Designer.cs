namespace Interfaz
{
    partial class brpaquete
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablapaquetes = new System.Windows.Forms.DataGridView();
            this.Buscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.brnombre = new MaterialSkin.Controls.MaterialRadioButton();
            this.brestado = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtfiltrar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.btneditar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnguardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Ponerfecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tablapaquetes)).BeginInit();
            this.SuspendLayout();
            // 
            // tablapaquetes
            // 
            this.tablapaquetes.AllowUserToAddRows = false;
            this.tablapaquetes.AllowUserToDeleteRows = false;
            this.tablapaquetes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tablapaquetes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tablapaquetes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(41)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablapaquetes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablapaquetes.ColumnHeadersHeight = 30;
            this.tablapaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablapaquetes.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablapaquetes.EnableHeadersVisualStyles = false;
            this.tablapaquetes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tablapaquetes.Location = new System.Drawing.Point(1, 11);
            this.tablapaquetes.Name = "tablapaquetes";
            this.tablapaquetes.ReadOnly = true;
            this.tablapaquetes.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.tablapaquetes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tablapaquetes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablapaquetes.Size = new System.Drawing.Size(753, 431);
            this.tablapaquetes.TabIndex = 0;
            this.tablapaquetes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Buscar
            // 
            this.Buscar.Depth = 0;
            this.Buscar.Location = new System.Drawing.Point(760, 91);
            this.Buscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Buscar.Name = "Buscar";
            this.Buscar.Primary = true;
            this.Buscar.Size = new System.Drawing.Size(58, 24);
            this.Buscar.TabIndex = 3;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            // 
            // materialDivider2
            // 
            this.materialDivider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(459, 206);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(570, 14);
            this.materialDivider2.TabIndex = 4;
            this.materialDivider2.Text = "materialDivider1";
            this.materialDivider2.Click += new System.EventHandler(this.materialDivider2_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(771, 313);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Estado";
            // 
            // cbestado
            // 
            this.cbestado.BackColor = System.Drawing.Color.White;
            this.cbestado.FormattingEnabled = true;
            this.cbestado.Items.AddRange(new object[] {
            "Disponible",
            "En camino",
            "En aduanas",
            "Entregado",
            "Sin factura"});
            this.cbestado.Location = new System.Drawing.Point(830, 315);
            this.cbestado.Margin = new System.Windows.Forms.Padding(2);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(113, 21);
            this.cbestado.TabIndex = 7;
            // 
            // brnombre
            // 
            this.brnombre.AutoSize = true;
            this.brnombre.Checked = true;
            this.brnombre.Depth = 0;
            this.brnombre.Font = new System.Drawing.Font("Roboto", 10F);
            this.brnombre.Location = new System.Drawing.Point(760, 138);
            this.brnombre.Margin = new System.Windows.Forms.Padding(0);
            this.brnombre.MouseLocation = new System.Drawing.Point(-1, -1);
            this.brnombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.brnombre.Name = "brnombre";
            this.brnombre.Ripple = true;
            this.brnombre.Size = new System.Drawing.Size(78, 30);
            this.brnombre.TabIndex = 8;
            this.brnombre.TabStop = true;
            this.brnombre.Text = "Nombre";
            this.brnombre.UseVisualStyleBackColor = true;
            // 
            // brestado
            // 
            this.brestado.AutoSize = true;
            this.brestado.Depth = 0;
            this.brestado.Font = new System.Drawing.Font("Roboto", 10F);
            this.brestado.Location = new System.Drawing.Point(760, 163);
            this.brestado.Margin = new System.Windows.Forms.Padding(0);
            this.brestado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.brestado.MouseState = MaterialSkin.MouseState.HOVER;
            this.brestado.Name = "brestado";
            this.brestado.Ripple = true;
            this.brestado.Size = new System.Drawing.Size(71, 30);
            this.brestado.TabIndex = 10;
            this.brestado.Text = "Estado";
            this.brestado.UseVisualStyleBackColor = true;
            // 
            // txtfiltrar
            // 
            this.txtfiltrar.Depth = 0;
            this.txtfiltrar.Hint = "Buscar";
            this.txtfiltrar.Location = new System.Drawing.Point(830, 91);
            this.txtfiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.txtfiltrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtfiltrar.Name = "txtfiltrar";
            this.txtfiltrar.PasswordChar = '\0';
            this.txtfiltrar.SelectedText = "";
            this.txtfiltrar.SelectionLength = 0;
            this.txtfiltrar.SelectionStart = 0;
            this.txtfiltrar.Size = new System.Drawing.Size(126, 23);
            this.txtfiltrar.TabIndex = 11;
            this.txtfiltrar.UseSystemPasswordChar = false;
            this.txtfiltrar.Click += new System.EventHandler(this.txtfiltrar_Click);
            this.txtfiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.filtrar_KeyUp);
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(459, 38);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(570, 14);
            this.materialDivider1.TabIndex = 4;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // btneditar
            // 
            this.btneditar.Depth = 0;
            this.btneditar.Location = new System.Drawing.Point(786, 367);
            this.btneditar.Margin = new System.Windows.Forms.Padding(2);
            this.btneditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btneditar.Name = "btneditar";
            this.btneditar.Primary = true;
            this.btneditar.Size = new System.Drawing.Size(75, 38);
            this.btneditar.TabIndex = 12;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(871, 367);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(2);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(0, 0);
            this.materialRaisedButton1.TabIndex = 13;
            this.materialRaisedButton1.Text = "materialRaisedButton1";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Depth = 0;
            this.btnguardar.Location = new System.Drawing.Point(871, 367);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnguardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Primary = true;
            this.btnguardar.Size = new System.Drawing.Size(72, 38);
            this.btnguardar.TabIndex = 14;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // Ponerfecha
            // 
            this.Ponerfecha.Location = new System.Drawing.Point(768, 254);
            this.Ponerfecha.Name = "Ponerfecha";
            this.Ponerfecha.Size = new System.Drawing.Size(200, 20);
            this.Ponerfecha.TabIndex = 15;
            this.Ponerfecha.Value = new System.DateTime(2018, 12, 4, 13, 48, 0, 0);
            // 
            // brpaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(980, 440);
            this.Controls.Add(this.Ponerfecha);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.txtfiltrar);
            this.Controls.Add(this.brestado);
            this.Controls.Add(this.brnombre);
            this.Controls.Add(this.cbestado);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.tablapaquetes);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialDivider2);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "brpaquete";
            this.Text = "ModificarPack";
            this.Load += new System.EventHandler(this.ModificarPack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablapaquetes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton Buscar;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox cbestado;
        private MaterialSkin.Controls.MaterialRadioButton brnombre;
        private MaterialSkin.Controls.MaterialRadioButton brestado;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtfiltrar;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton btneditar;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton btnguardar;
        public System.Windows.Forms.DataGridView tablapaquetes;
        private System.Windows.Forms.DateTimePicker Ponerfecha;
    }
}