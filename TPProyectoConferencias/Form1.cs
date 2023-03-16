using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPProyectoConferencias
{

	public partial class ConferenciasForm : Form
	{
		//comienzo región de estructura
		public struct tipo_Conferencias
		{
			public  string nombre;
			public  string apellido;
			public  string dni;
			public  string sexos;			
			public  string lenguajes;
			public  string base_de_datos;
			public  string analisis;
		}
		//fin region de estructura 

		 public static tipo_Conferencias[]  asistente;

		public static int topeI;
		public static  int ultimoI;

		public ConferenciasForm()
		{
			InitializeComponent();
			
		// declaro topes de guardar
			topeI = 20;
		 asistente = new  tipo_Conferencias[topeI];
			ultimoI = -1;
		}

	private void btnSalir_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

	

		private void btnEstadistica_Click(object sender, EventArgs e)
		{
			Form2 f = new Form2();
			f.Show();
		}

		private void btnRegistro_Click(object sender, EventArgs e)
		{
            
			
			tipo_Conferencias datos;			
			datos.nombre = txtApellido.Text;
			datos.apellido = txtApellido.Text;
			datos.dni = txtDNI.Text;
			bool existe = false;

			int numerico;
			bool isNumeric = int.TryParse(datos.dni, out numerico);
			int i = 0;

			if (ultimoI+1<= topeI) { 
			while (i <= ultimoI && !existe)
            {
				if (datos.dni == asistente[i].dni)
                {
					existe = true;
                }
				i ++;
            }
			}



			if (ultimoI+1 == topeI)
			{
				MessageBox.Show("No hay espacios disponibles");
				DialogResult agrandarArreglo = MessageBox.Show("Desea agrandar el arreglo?",
					  "Agrandar Arreglo", MessageBoxButtons.YesNo);
				switch (agrandarArreglo)
				{
					case DialogResult.Yes:
						topeI += 20;
						Array.Resize(ref asistente, topeI );
						MessageBox.Show("Ahora tiene 20 luegares más disponibles");
						break;
					case DialogResult.No:
						break;
				}
			}else if (datos.nombre == "")
            {
				MessageBox.Show("Debe completar su nombre","ERROR");
            } else if (datos.apellido == "")
            {
				MessageBox.Show("Debe completar su apellido", "ERROR");

			}
			else if(txtDNI.Text == "")
            {
				MessageBox.Show("Debe completar su DNI", "ERROR");
			}
            else if (!isNumeric)
            {
                MessageBox.Show("Debe escribir solamente numeros", "ERROR");

            }
            else if (existe)
			{
				MessageBox.Show("Usted ya se encuentra registrado en nuestro sistema","ERROR");
			}else if (!checkAS.Checked && !checkBD.Checked && !checkLenguaje.Checked)
            {
				MessageBox.Show("Debe seleccionar una conferencia","ERROR");

            }
            else { 


			if (radioFem.Checked)
				{
				datos.sexos = radioFem.Text;
				} 
				else
				{			
				datos.sexos = radioMasc.Text;
				}
				//CheckBoxes
				if (checkLenguaje.Checked) 
				{ 
					datos.lenguajes = checkLenguaje.Text;
				}
				else
				{datos.lenguajes = "";}

				if (checkBD.Checked){datos.base_de_datos = checkBD.Text;}
				else
				{datos.base_de_datos = "";}

				if (checkAS.Checked){datos.analisis = checkAS.Text;}
				else
				{datos.analisis = "";}

			
			asistente[ultimoI+1] = datos;
				ultimoI += 1;
				MessageBox.Show("Se a registrado con éxito!","Registro");
			}
		}


        private void btnNuevo_Click(object sender, EventArgs e)
        {
			txtNombre.Clear();
			txtApellido.Clear();
			txtDNI.Clear();
			radioFem.Checked = true;
			checkAS.Checked = false;
			checkBD.Checked = false;
			checkLenguaje.Checked = false;
        }
    }
}
