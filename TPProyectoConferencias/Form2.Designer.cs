namespace TPProyectoConferencias
{
	partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtVarones = new System.Windows.Forms.TextBox();
            this.txtMujeres = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cbConferencia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.txtVarones);
            this.panel1.Controls.Add(this.txtMujeres);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.cbConferencia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(49, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 310);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Recaudado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad de Varones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cabtidad de Mujeres";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(368, 228);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // txtVarones
            // 
            this.txtVarones.Location = new System.Drawing.Point(368, 186);
            this.txtVarones.Name = "txtVarones";
            this.txtVarones.ReadOnly = true;
            this.txtVarones.Size = new System.Drawing.Size(100, 20);
            this.txtVarones.TabIndex = 4;
            // 
            // txtMujeres
            // 
            this.txtMujeres.Location = new System.Drawing.Point(368, 144);
            this.txtMujeres.Name = "txtMujeres";
            this.txtMujeres.ReadOnly = true;
            this.txtMujeres.Size = new System.Drawing.Size(100, 20);
            this.txtMujeres.TabIndex = 3;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(368, 61);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // cbConferencia
            // 
            this.cbConferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConferencia.FormattingEnabled = true;
            this.cbConferencia.Items.AddRange(new object[] {
            "Seleccione tipo de conferencia",
            "Lenguaje de Programación",
            "Bases de Datos",
            "Análisis de Sistemas"});
            this.cbConferencia.Location = new System.Drawing.Point(35, 61);
            this.cbConferencia.Name = "cbConferencia";
            this.cbConferencia.Size = new System.Drawing.Size(228, 21);
            this.cbConferencia.TabIndex = 1;
            this.cbConferencia.SelectedIndexChanged += new System.EventHandler(this.cbConferencia_SelectedIndexChanged);
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Personas Inscriptas en";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 353);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Estadisticas y consultas";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtVarones;
		private System.Windows.Forms.TextBox txtMujeres;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.ComboBox cbConferencia;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}