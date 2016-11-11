namespace login
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.entrar = new System.Windows.Forms.Button();
            this.usr = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.candado = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.candado)).BeginInit();
            this.SuspendLayout();
            // 
            // entrar
            // 
            this.entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrar.Location = new System.Drawing.Point(285, 433);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(271, 30);
            this.entrar.TabIndex = 0;
            this.entrar.Text = "Entrar";
            this.entrar.UseVisualStyleBackColor = true;
            this.entrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // usr
            // 
            this.usr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usr.Location = new System.Drawing.Point(388, 284);
            this.usr.Name = "usr";
            this.usr.Size = new System.Drawing.Size(245, 26);
            this.usr.TabIndex = 1;
            // 
            // pwd
            // 
            this.pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd.Location = new System.Drawing.Point(388, 337);
            this.pwd.Name = "pwd";
            this.pwd.PasswordChar = '*';
            this.pwd.Size = new System.Drawing.Size(245, 26);
            this.pwd.TabIndex = 2;
            // 
            // candado
            // 
            this.candado.BackColor = System.Drawing.Color.Transparent;
            this.candado.Image = ((System.Drawing.Image)(resources.GetObject("candado.Image")));
            this.candado.Location = new System.Drawing.Point(129, 241);
            this.candado.Name = "candado";
            this.candado.Size = new System.Drawing.Size(128, 149);
            this.candado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.candado.TabIndex = 3;
            this.candado.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 584);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.candado);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.usr);
            this.Controls.Add(this.entrar);
            this.HelpButton = true;
            this.MaximumSize = new System.Drawing.Size(800, 623);
            this.MinimumSize = new System.Drawing.Size(800, 623);
            this.Name = "login";
            this.Text = "SUGOI-Login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.candado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.TextBox usr;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.PictureBox candado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

