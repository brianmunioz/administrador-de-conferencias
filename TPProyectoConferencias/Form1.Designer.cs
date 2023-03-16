namespace TPProyectoConferencias
{
	partial class ConferenciasForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioFem = new System.Windows.Forms.RadioButton();
            this.radioMasc = new System.Windows.Forms.RadioButton();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEstadistica = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelConf = new System.Windows.Forms.Panel();
            this.checkAS = new System.Windows.Forms.CheckBox();
            this.checkBD = new System.Windows.Forms.CheckBox();
            this.checkLenguaje = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panelConf.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sexo";
            // 
            // radioFem
            // 
            this.radioFem.AutoSize = true;
            this.radioFem.Checked = true;
            this.radioFem.Location = new System.Drawing.Point(146, 136);
            this.radioFem.Name = "radioFem";
            this.radioFem.Size = new System.Drawing.Size(71, 17);
            this.radioFem.TabIndex = 4;
            this.radioFem.TabStop = true;
            this.radioFem.Text = "Femenino";
            this.radioFem.UseVisualStyleBackColor = true;
            // 
            // radioMasc
            // 
            this.radioMasc.AutoSize = true;
            this.radioMasc.Location = new System.Drawing.Point(146, 159);
            this.radioMasc.Name = "radioMasc";
            this.radioMasc.Size = new System.Drawing.Size(73, 17);
            this.radioMasc.TabIndex = 5;
            this.radioMasc.Text = "Masculino";
            this.radioMasc.UseVisualStyleBackColor = true;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(414, 71);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(115, 34);
            this.btnRegistro.TabIndex = 9;
            this.btnRegistro.Text = "Registrar Inscripción";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(414, 111);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(115, 33);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEstadistica
            // 
            this.btnEstadistica.Location = new System.Drawing.Point(414, 150);
            this.btnEstadistica.Name = "btnEstadistica";
            this.btnEstadistica.Size = new System.Drawing.Size(115, 35);
            this.btnEstadistica.TabIndex = 11;
            this.btnEstadistica.Text = "Obtener Estadística";
            this.btnEstadistica.UseVisualStyleBackColor = true;
            this.btnEstadistica.Click += new System.EventHandler(this.btnEstadistica_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(414, 191);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 37);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelConf
            // 
            this.panelConf.Controls.Add(this.checkAS);
            this.panelConf.Controls.Add(this.checkBD);
            this.panelConf.Controls.Add(this.checkLenguaje);
            this.panelConf.Controls.Add(this.label5);
            this.panelConf.Location = new System.Drawing.Point(51, 256);
            this.panelConf.Name = "panelConf";
            this.panelConf.Size = new System.Drawing.Size(496, 157);
            this.panelConf.TabIndex = 10;
            // 
            // checkAS
            // 
            this.checkAS.AutoSize = true;
            this.checkAS.Location = new System.Drawing.Point(61, 117);
            this.checkAS.Name = "checkAS";
            this.checkAS.Size = new System.Drawing.Size(121, 17);
            this.checkAS.TabIndex = 8;
            this.checkAS.Text = "Análisis de Sistemas";
            this.checkAS.UseVisualStyleBackColor = true;
            // 
            // checkBD
            // 
            this.checkBD.AutoSize = true;
            this.checkBD.Location = new System.Drawing.Point(61, 80);
            this.checkBD.Name = "checkBD";
            this.checkBD.Size = new System.Drawing.Size(101, 17);
            this.checkBD.TabIndex = 7;
            this.checkBD.Text = "Bases de Datos";
            this.checkBD.UseVisualStyleBackColor = true;
            // 
            // checkLenguaje
            // 
            this.checkLenguaje.AutoSize = true;
            this.checkLenguaje.Location = new System.Drawing.Point(61, 46);
            this.checkLenguaje.Name = "checkLenguaje";
            this.checkLenguaje.Size = new System.Drawing.Size(153, 17);
            this.checkLenguaje.TabIndex = 6;
            this.checkLenguaje.Text = "Lenguaje de Programación";
            this.checkLenguaje.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Conferencia";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(146, 35);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(147, 20);
            this.txtApellido.TabIndex = 1;
            
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(146, 73);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(147, 20);
            this.txtDNI.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(389, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // ConferenciasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 451);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.panelConf);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEstadistica);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.radioMasc);
            this.Controls.Add(this.radioFem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConferenciasForm";
            this.Text = "Conferencias";           
            this.panelConf.ResumeLayout(false);
            this.panelConf.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton radioFem;
		private System.Windows.Forms.RadioButton radioMasc;
		private System.Windows.Forms.Button btnRegistro;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnEstadistica;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Panel panelConf;
		private System.Windows.Forms.CheckBox checkAS;
		private System.Windows.Forms.CheckBox checkBD;
		private System.Windows.Forms.CheckBox checkLenguaje;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtDNI;
		private System.Windows.Forms.TextBox txtNombre;
	}
}

