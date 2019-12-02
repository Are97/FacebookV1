namespace FacebookV1
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
            this.textBoxCorreoIS = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxContraseñaIS = new System.Windows.Forms.TextBox();
            this.buttonIS = new System.Windows.Forms.Button();
            this.buttonCuentaN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCorreoIS
            // 
            this.textBoxCorreoIS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCorreoIS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCorreoIS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreoIS.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCorreoIS.Location = new System.Drawing.Point(807, 285);
            this.textBoxCorreoIS.Name = "textBoxCorreoIS";
            this.textBoxCorreoIS.Size = new System.Drawing.Size(344, 22);
            this.textBoxCorreoIS.TabIndex = 1;
            this.textBoxCorreoIS.Text = "Correo electrónico";
            this.textBoxCorreoIS.Click += new System.EventHandler(this.textBoxCorreoIS_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1358, 717);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxContraseñaIS
            // 
            this.textBoxContraseñaIS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxContraseñaIS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContraseñaIS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseñaIS.ForeColor = System.Drawing.Color.Gray;
            this.textBoxContraseñaIS.Location = new System.Drawing.Point(807, 346);
            this.textBoxContraseñaIS.Name = "textBoxContraseñaIS";
            this.textBoxContraseñaIS.Size = new System.Drawing.Size(344, 22);
            this.textBoxContraseñaIS.TabIndex = 2;
            this.textBoxContraseñaIS.Text = "Contraseña";
            this.textBoxContraseñaIS.Click += new System.EventHandler(this.textBoxContraseñaIS_Click);
            this.textBoxContraseñaIS.TabIndexChanged += new System.EventHandler(this.textBoxContraseñaIS_TabIndexChanged);
            // 
            // buttonIS
            // 
            this.buttonIS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonIS.BackColor = System.Drawing.Color.Transparent;
            this.buttonIS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonIS.FlatAppearance.BorderSize = 0;
            this.buttonIS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIS.Location = new System.Drawing.Point(792, 396);
            this.buttonIS.Name = "buttonIS";
            this.buttonIS.Size = new System.Drawing.Size(369, 50);
            this.buttonIS.TabIndex = 3;
            this.buttonIS.UseVisualStyleBackColor = true;
            this.buttonIS.Click += new System.EventHandler(this.buttonIS_Click);
            this.buttonIS.MouseEnter += new System.EventHandler(this.buttonIS_MouseEnter);
            // 
            // buttonCuentaN
            // 
            this.buttonCuentaN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCuentaN.BackColor = System.Drawing.Color.Transparent;
            this.buttonCuentaN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCuentaN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCuentaN.FlatAppearance.BorderSize = 0;
            this.buttonCuentaN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCuentaN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCuentaN.Location = new System.Drawing.Point(881, 525);
            this.buttonCuentaN.Name = "buttonCuentaN";
            this.buttonCuentaN.Size = new System.Drawing.Size(190, 50);
            this.buttonCuentaN.TabIndex = 4;
            this.buttonCuentaN.UseVisualStyleBackColor = true;
            this.buttonCuentaN.Click += new System.EventHandler(this.buttonCuentaN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.BackgroundImage = global::FacebookV1.Properties.Resources.Inicio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.buttonCuentaN);
            this.Controls.Add(this.buttonIS);
            this.Controls.Add(this.textBoxContraseñaIS);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxCorreoIS);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " Facebook - Inicia sesión o regístrate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCorreoIS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxContraseñaIS;
        private System.Windows.Forms.Button buttonIS;
        private System.Windows.Forms.Button buttonCuentaN;
    }
}

