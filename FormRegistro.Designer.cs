namespace FacebookV1
{
    partial class FormRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistro));
            this.textBoxCorreoIS = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxContraseñaN = new System.Windows.Forms.TextBox();
            this.buttonRegistrate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCorreoIS
            // 
            this.textBoxCorreoIS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCorreoIS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.textBoxCorreoIS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCorreoIS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreoIS.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCorreoIS.Location = new System.Drawing.Point(23, 109);
            this.textBoxCorreoIS.Name = "textBoxCorreoIS";
            this.textBoxCorreoIS.Size = new System.Drawing.Size(174, 22);
            this.textBoxCorreoIS.TabIndex = 2;
            this.textBoxCorreoIS.Text = "Nombre";
            this.textBoxCorreoIS.Click += new System.EventHandler(this.textBoxCorreoIS_Click);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.textBoxApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellido.ForeColor = System.Drawing.Color.Gray;
            this.textBoxApellido.Location = new System.Drawing.Point(232, 109);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(174, 22);
            this.textBoxApellido.TabIndex = 3;
            this.textBoxApellido.Text = "Apellido";
            this.textBoxApellido.Click += new System.EventHandler(this.textBoxApellido_Click);
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.textBoxCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCorreo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreo.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCorreo.Location = new System.Drawing.Point(23, 161);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(370, 22);
            this.textBoxCorreo.TabIndex = 4;
            this.textBoxCorreo.Text = "Correo electrónico";
            this.textBoxCorreo.Click += new System.EventHandler(this.textBoxCorreo_Click);
            // 
            // textBoxContraseñaN
            // 
            this.textBoxContraseñaN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxContraseñaN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.textBoxContraseñaN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContraseñaN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseñaN.ForeColor = System.Drawing.Color.Gray;
            this.textBoxContraseñaN.Location = new System.Drawing.Point(23, 210);
            this.textBoxContraseñaN.Name = "textBoxContraseñaN";
            this.textBoxContraseñaN.Size = new System.Drawing.Size(370, 22);
            this.textBoxContraseñaN.TabIndex = 5;
            this.textBoxContraseñaN.Text = "Contraseña nueva";
            this.textBoxContraseñaN.Click += new System.EventHandler(this.textBoxContraseñaN_Click);
            // 
            // buttonRegistrate
            // 
            this.buttonRegistrate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRegistrate.BackColor = System.Drawing.Color.Transparent;
            this.buttonRegistrate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistrate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRegistrate.FlatAppearance.BorderSize = 0;
            this.buttonRegistrate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonRegistrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrate.Location = new System.Drawing.Point(115, 454);
            this.buttonRegistrate.Name = "buttonRegistrate";
            this.buttonRegistrate.Size = new System.Drawing.Size(201, 40);
            this.buttonRegistrate.TabIndex = 6;
            this.buttonRegistrate.UseVisualStyleBackColor = true;
            this.buttonRegistrate.Click += new System.EventHandler(this.buttonRegistrate_Click);
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FacebookV1.Properties.Resources.Registro;
            this.ClientSize = new System.Drawing.Size(421, 514);
            this.Controls.Add(this.buttonRegistrate);
            this.Controls.Add(this.textBoxContraseñaN);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxCorreoIS);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormRegistro";
            this.ShowInTaskbar = false;
            this.Text = " Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCorreoIS;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxContraseñaN;
        private System.Windows.Forms.Button buttonRegistrate;
    }
}