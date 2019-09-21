namespace Interfaz
{
    partial class Agregar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewclientes = new System.Windows.Forms.DataGridView();
            this.Btnagregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtnombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtapellido = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtcodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtdireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtcorreo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Registro = new System.Windows.Forms.Label();
            this.Genero = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtgenero = new System.Windows.Forms.ComboBox();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            ((System.ComponentModel.ISupportInitialize)(this.viewclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // viewclientes
            // 
            this.viewclientes.AllowUserToAddRows = false;
            this.viewclientes.AllowUserToDeleteRows = false;
            this.viewclientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.viewclientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.viewclientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(41)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewclientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.viewclientes.ColumnHeadersHeight = 30;
            this.viewclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewclientes.DefaultCellStyle = dataGridViewCellStyle6;
            this.viewclientes.EnableHeadersVisualStyles = false;
            this.viewclientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.viewclientes.Location = new System.Drawing.Point(2, 9);
            this.viewclientes.Name = "viewclientes";
            this.viewclientes.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewclientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.viewclientes.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.viewclientes.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.viewclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewclientes.Size = new System.Drawing.Size(615, 475);
            this.viewclientes.TabIndex = 0;
            this.viewclientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewclientes_CellContentDoubleClick);
            // 
            // Btnagregar
            // 
            this.Btnagregar.Depth = 0;
            this.Btnagregar.Location = new System.Drawing.Point(649, 324);
            this.Btnagregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Primary = true;
            this.Btnagregar.Size = new System.Drawing.Size(81, 43);
            this.Btnagregar.TabIndex = 1;
            this.Btnagregar.Text = "Agregar";
            this.Btnagregar.UseVisualStyleBackColor = true;
            this.Btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnombre.Depth = 0;
            this.txtnombre.Hint = "Ingresa nombre";
            this.txtnombre.Location = new System.Drawing.Point(717, 75);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.PasswordChar = '\0';
            this.txtnombre.SelectedText = "";
            this.txtnombre.SelectionLength = 0;
            this.txtnombre.SelectionStart = 0;
            this.txtnombre.Size = new System.Drawing.Size(248, 23);
            this.txtnombre.TabIndex = 2;
            this.txtnombre.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(645, 75);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Nombre:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(645, 116);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(68, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Apellido:";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // txtapellido
            // 
            this.txtapellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtapellido.Depth = 0;
            this.txtapellido.Hint = "Ingresar apellido";
            this.txtapellido.Location = new System.Drawing.Point(717, 116);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtapellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.PasswordChar = '\0';
            this.txtapellido.SelectedText = "";
            this.txtapellido.SelectionLength = 0;
            this.txtapellido.SelectionStart = 0;
            this.txtapellido.Size = new System.Drawing.Size(256, 23);
            this.txtapellido.TabIndex = 5;
            this.txtapellido.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(645, 156);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(113, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "CodigoUsuario:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcodigo.Depth = 0;
            this.txtcodigo.Hint = "C-codigo";
            this.txtcodigo.Location = new System.Drawing.Point(758, 156);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtcodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.PasswordChar = '\0';
            this.txtcodigo.SelectedText = "";
            this.txtcodigo.SelectionLength = 0;
            this.txtcodigo.SelectionStart = 0;
            this.txtcodigo.Size = new System.Drawing.Size(156, 23);
            this.txtcodigo.TabIndex = 7;
            this.txtcodigo.UseSystemPasswordChar = false;
            this.txtcodigo.Click += new System.EventHandler(this.txtcodigo_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(424, 23);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(2);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(659, 11);
            this.materialDivider1.TabIndex = 8;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(645, 195);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(77, 19);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Direccion:";
            this.materialLabel4.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdireccion.Depth = 0;
            this.txtdireccion.Hint = "Insertar direccion";
            this.txtdireccion.Location = new System.Drawing.Point(725, 195);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtdireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.PasswordChar = '\0';
            this.txtdireccion.SelectedText = "";
            this.txtdireccion.SelectionLength = 0;
            this.txtdireccion.SelectionStart = 0;
            this.txtdireccion.Size = new System.Drawing.Size(240, 23);
            this.txtdireccion.TabIndex = 9;
            this.txtdireccion.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(645, 233);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(59, 19);
            this.materialLabel5.TabIndex = 10;
            this.materialLabel5.Text = "Correo:";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcorreo.Depth = 0;
            this.txtcorreo.Hint = "Insertar correo";
            this.txtcorreo.Location = new System.Drawing.Point(708, 233);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtcorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.PasswordChar = '\0';
            this.txtcorreo.SelectedText = "";
            this.txtcorreo.SelectionLength = 0;
            this.txtcorreo.SelectionStart = 0;
            this.txtcorreo.Size = new System.Drawing.Size(257, 23);
            this.txtcorreo.TabIndex = 11;
            this.txtcorreo.UseSystemPasswordChar = false;
            // 
            // Registro
            // 
            this.Registro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Registro.AutoSize = true;
            this.Registro.BackColor = System.Drawing.Color.Tomato;
            this.Registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Registro.Location = new System.Drawing.Point(783, 23);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(87, 24);
            this.Registro.TabIndex = 12;
            this.Registro.Text = "Registro";
            this.Registro.Click += new System.EventHandler(this.Registro_Click);
            // 
            // Genero
            // 
            this.Genero.AutoSize = true;
            this.Genero.Depth = 0;
            this.Genero.Font = new System.Drawing.Font("Roboto", 11F);
            this.Genero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Genero.Location = new System.Drawing.Point(645, 273);
            this.Genero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Genero.MouseState = MaterialSkin.MouseState.HOVER;
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(61, 19);
            this.Genero.TabIndex = 13;
            this.Genero.Text = "Genero:";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(735, 324);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(2);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(90, 43);
            this.materialRaisedButton1.TabIndex = 15;
            this.materialRaisedButton1.Text = "Editar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(829, 324);
            this.materialRaisedButton2.Margin = new System.Windows.Forms.Padding(2);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(85, 43);
            this.materialRaisedButton2.TabIndex = 16;
            this.materialRaisedButton2.Text = "Borrar";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // txtgenero
            // 
            this.txtgenero.BackColor = System.Drawing.Color.White;
            this.txtgenero.FormattingEnabled = true;
            this.txtgenero.Items.AddRange(new object[] {
            "M",
            "H"});
            this.txtgenero.Location = new System.Drawing.Point(708, 272);
            this.txtgenero.Margin = new System.Windows.Forms.Padding(2);
            this.txtgenero.Name = "txtgenero";
            this.txtgenero.Size = new System.Drawing.Size(92, 21);
            this.txtgenero.TabIndex = 17;
            // 
            // materialDivider2
            // 
            this.materialDivider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(437, 383);
            this.materialDivider2.Margin = new System.Windows.Forms.Padding(2);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(659, 11);
            this.materialDivider2.TabIndex = 8;
            this.materialDivider2.Text = "materialDivider1";
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1043, 488);
            this.Controls.Add(this.txtgenero);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.Registro);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.Btnagregar);
            this.Controls.Add(this.viewclientes);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialDivider1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.Agregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewclientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton Btnagregar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.Label Registro;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtnombre;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtapellido;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtcodigo;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtdireccion;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtcorreo;
        private MaterialSkin.Controls.MaterialLabel Genero;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        public System.Windows.Forms.DataGridView viewclientes;
        private System.Windows.Forms.ComboBox txtgenero;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
    }
}