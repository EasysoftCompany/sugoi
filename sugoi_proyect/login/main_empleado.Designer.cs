namespace login
{
    partial class main_empleado
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nombre_emp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 120);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mis Pagos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(309, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cerrar Sesion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nombre_emp
            // 
            this.nombre_emp.AutoSize = true;
            this.nombre_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_emp.ForeColor = System.Drawing.SystemColors.Control;
            this.nombre_emp.Location = new System.Drawing.Point(90, 25);
            this.nombre_emp.Name = "nombre_emp";
            this.nombre_emp.Size = new System.Drawing.Size(0, 20);
            this.nombre_emp.TabIndex = 2;
            this.nombre_emp.Click += new System.EventHandler(this.label1_Click);
            // 
            // main_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(548, 307);
            this.Controls.Add(this.nombre_emp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "main_empleado";
            this.Text = "Menu Principal Empleados";
            this.Load += new System.EventHandler(this.main_empleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label nombre_emp;
    }
}