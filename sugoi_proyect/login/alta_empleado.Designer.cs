﻿namespace login
{
    partial class alta_empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alta_empleado));
            this.usuario = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.MaskedTextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.ap = new System.Windows.Forms.TextBox();
            this.am = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.MaskedTextBox();
            this.dir = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.MaskedTextBox();
            this.horas_trabajo = new System.Windows.Forms.NumericUpDown();
            this.Registrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbo_tur = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.horas_trabajo)).BeginInit();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(473, 196);
            this.usuario.Margin = new System.Windows.Forms.Padding(4);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(324, 30);
            this.usuario.TabIndex = 10;
            // 
            // contraseña
            // 
            this.contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.contraseña.Location = new System.Drawing.Point(473, 235);
            this.contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.contraseña.Name = "contraseña";
            this.contraseña.PasswordChar = '*';
            this.contraseña.Size = new System.Drawing.Size(324, 30);
            this.contraseña.TabIndex = 11;
            this.contraseña.UseWaitCursor = true;
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(473, 277);
            this.nombre.Margin = new System.Windows.Forms.Padding(4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(324, 30);
            this.nombre.TabIndex = 12;
            // 
            // ap
            // 
            this.ap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ap.Location = new System.Drawing.Point(473, 314);
            this.ap.Margin = new System.Windows.Forms.Padding(4);
            this.ap.Name = "ap";
            this.ap.Size = new System.Drawing.Size(324, 30);
            this.ap.TabIndex = 13;
            // 
            // am
            // 
            this.am.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.am.Location = new System.Drawing.Point(473, 352);
            this.am.Margin = new System.Windows.Forms.Padding(4);
            this.am.Name = "am";
            this.am.Size = new System.Drawing.Size(324, 30);
            this.am.TabIndex = 14;
            // 
            // tel
            // 
            this.tel.AsciiOnly = true;
            this.tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel.Location = new System.Drawing.Point(473, 388);
            this.tel.Margin = new System.Windows.Forms.Padding(4);
            this.tel.Mask = "00-00-00-00-00";
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(324, 30);
            this.tel.TabIndex = 15;
            // 
            // dir
            // 
            this.dir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dir.Location = new System.Drawing.Point(473, 423);
            this.dir.Margin = new System.Windows.Forms.Padding(4);
            this.dir.Name = "dir";
            this.dir.Size = new System.Drawing.Size(324, 30);
            this.dir.TabIndex = 16;
            // 
            // mail
            // 
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.Location = new System.Drawing.Point(473, 457);
            this.mail.Margin = new System.Windows.Forms.Padding(4);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(324, 30);
            this.mail.TabIndex = 17;
            // 
            // horas_trabajo
            // 
            this.horas_trabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horas_trabajo.Location = new System.Drawing.Point(473, 494);
            this.horas_trabajo.Margin = new System.Windows.Forms.Padding(4);
            this.horas_trabajo.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.horas_trabajo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.horas_trabajo.Name = "horas_trabajo";
            this.horas_trabajo.Size = new System.Drawing.Size(325, 30);
            this.horas_trabajo.TabIndex = 18;
            this.horas_trabajo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Registrar
            // 
            this.Registrar.BackColor = System.Drawing.Color.Transparent;
            this.Registrar.FlatAppearance.BorderSize = 0;
            this.Registrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar.Location = new System.Drawing.Point(553, 613);
            this.Registrar.Margin = new System.Windows.Forms.Padding(4);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(244, 40);
            this.Registrar.TabIndex = 20;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = false;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(190, 613);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 40);
            this.button1.TabIndex = 21;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbo_tur
            // 
            this.cbo_tur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tur.FormattingEnabled = true;
            this.cbo_tur.Items.AddRange(new object[] {
            "Matutino",
            "Mixto",
            "Vespertino"});
            this.cbo_tur.Location = new System.Drawing.Point(473, 534);
            this.cbo_tur.Name = "cbo_tur";
            this.cbo_tur.Size = new System.Drawing.Size(324, 33);
            this.cbo_tur.Sorted = true;
            this.cbo_tur.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(206, 542);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 25);
            this.label10.TabIndex = 42;
            this.label10.Text = "Turno:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(206, 499);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(250, 25);
            this.label9.TabIndex = 41;
            this.label9.Text = "Horas de Trabajo (por Dia):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(206, 462);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 25);
            this.label8.TabIndex = 40;
            this.label8.Text = "E-mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(206, 428);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 25);
            this.label7.TabIndex = 39;
            this.label7.Text = "Direccion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(206, 393);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(206, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "Apellido Materno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 319);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 282);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Usuario: ";
            // 
            // alta_empleado
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1043, 709);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_tur);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.horas_trabajo);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.dir);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.am);
            this.Controls.Add(this.ap);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.usuario);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1061, 756);
            this.MinimumSize = new System.Drawing.Size(1061, 756);
            this.Name = "alta_empleado";
            this.Text = "alta_empleado";
            this.Load += new System.EventHandler(this.alta_empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.horas_trabajo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.MaskedTextBox contraseña;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox ap;
        private System.Windows.Forms.TextBox am;
        private System.Windows.Forms.MaskedTextBox tel;
        private System.Windows.Forms.TextBox dir;
        private System.Windows.Forms.MaskedTextBox mail;
        private System.Windows.Forms.NumericUpDown horas_trabajo;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbo_tur;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}