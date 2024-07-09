namespace Perro2POO
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblRaza = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAmo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtAmo = new System.Windows.Forms.TextBox();
            this.btnLarar = new System.Windows.Forms.Button();
            this.btnChillar = new System.Windows.Forms.Button();
            this.btnBañar = new System.Windows.Forms.Button();
            this.btnAbandonar = new System.Windows.Forms.Button();
            this.lblPulgas = new System.Windows.Forms.Label();
            this.cbxPulgas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(26, 47);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Location = new System.Drawing.Point(26, 73);
            this.lblRaza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(32, 13);
            this.lblRaza.TabIndex = 1;
            this.lblRaza.Text = "Raza";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(26, 105);
            this.lblColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(26, 139);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblAmo
            // 
            this.lblAmo.AutoSize = true;
            this.lblAmo.Location = new System.Drawing.Point(26, 171);
            this.lblAmo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmo.Name = "lblAmo";
            this.lblAmo.Size = new System.Drawing.Size(28, 13);
            this.lblAmo.TabIndex = 4;
            this.lblAmo.Text = "Amo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(80, 45);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(76, 20);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(80, 136);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(76, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(80, 71);
            this.txtRaza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(76, 20);
            this.txtRaza.TabIndex = 7;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(80, 102);
            this.txtColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(76, 20);
            this.txtColor.TabIndex = 8;
            // 
            // txtAmo
            // 
            this.txtAmo.Location = new System.Drawing.Point(80, 169);
            this.txtAmo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAmo.Name = "txtAmo";
            this.txtAmo.Size = new System.Drawing.Size(76, 20);
            this.txtAmo.TabIndex = 9;
            // 
            // btnLarar
            // 
            this.btnLarar.Location = new System.Drawing.Point(28, 265);
            this.btnLarar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLarar.Name = "btnLarar";
            this.btnLarar.Size = new System.Drawing.Size(71, 19);
            this.btnLarar.TabIndex = 10;
            this.btnLarar.Text = "Ladrar";
            this.btnLarar.UseVisualStyleBackColor = true;
            this.btnLarar.Click += new System.EventHandler(this.btnLarar_Click);
            // 
            // btnChillar
            // 
            this.btnChillar.Location = new System.Drawing.Point(28, 303);
            this.btnChillar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChillar.Name = "btnChillar";
            this.btnChillar.Size = new System.Drawing.Size(71, 19);
            this.btnChillar.TabIndex = 11;
            this.btnChillar.Text = "Chillar";
            this.btnChillar.UseVisualStyleBackColor = true;
            this.btnChillar.Click += new System.EventHandler(this.btnChillar_Click);
            // 
            // btnBañar
            // 
            this.btnBañar.Location = new System.Drawing.Point(117, 265);
            this.btnBañar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBañar.Name = "btnBañar";
            this.btnBañar.Size = new System.Drawing.Size(71, 19);
            this.btnBañar.TabIndex = 12;
            this.btnBañar.Text = "Bañar";
            this.btnBañar.UseVisualStyleBackColor = true;
            this.btnBañar.Click += new System.EventHandler(this.btnBañar_Click);
            // 
            // btnAbandonar
            // 
            this.btnAbandonar.Location = new System.Drawing.Point(117, 303);
            this.btnAbandonar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAbandonar.Name = "btnAbandonar";
            this.btnAbandonar.Size = new System.Drawing.Size(71, 19);
            this.btnAbandonar.TabIndex = 13;
            this.btnAbandonar.Text = "Abandonar";
            this.btnAbandonar.UseVisualStyleBackColor = true;
            this.btnAbandonar.Click += new System.EventHandler(this.btnAbandonar_Click);
            // 
            // lblPulgas
            // 
            this.lblPulgas.AutoSize = true;
            this.lblPulgas.Location = new System.Drawing.Point(26, 212);
            this.lblPulgas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPulgas.Name = "lblPulgas";
            this.lblPulgas.Size = new System.Drawing.Size(39, 13);
            this.lblPulgas.TabIndex = 14;
            this.lblPulgas.Text = "Pulgas";
            // 
            // cbxPulgas
            // 
            this.cbxPulgas.FormattingEnabled = true;
            this.cbxPulgas.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbxPulgas.Location = new System.Drawing.Point(80, 212);
            this.cbxPulgas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxPulgas.Name = "cbxPulgas";
            this.cbxPulgas.Size = new System.Drawing.Size(92, 21);
            this.cbxPulgas.TabIndex = 15;
            this.cbxPulgas.Text = "Tiene Pulgas?";
            this.cbxPulgas.SelectedIndexChanged += new System.EventHandler(this.cbxPulgas_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 406);
            this.Controls.Add(this.cbxPulgas);
            this.Controls.Add(this.lblPulgas);
            this.Controls.Add(this.btnAbandonar);
            this.Controls.Add(this.btnBañar);
            this.Controls.Add(this.btnChillar);
            this.Controls.Add(this.btnLarar);
            this.Controls.Add(this.txtAmo);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblAmo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblRaza);
            this.Controls.Add(this.lblCodigo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAmo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtAmo;
        private System.Windows.Forms.Button btnLarar;
        private System.Windows.Forms.Button btnChillar;
        private System.Windows.Forms.Button btnBañar;
        private System.Windows.Forms.Button btnAbandonar;
        private System.Windows.Forms.Label lblPulgas;
        private System.Windows.Forms.ComboBox cbxPulgas;
    }
}

