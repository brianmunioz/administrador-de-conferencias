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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void Form2_Load(object sender, EventArgs e)
        {
			cbConferencia.SelectedIndex = 0;
        }      

        private void cbConferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
			string conferencia = cbConferencia.Text;
			int total = 0;
			int mujeres = 0;
			int varones = 0;
			int recaudado ;
			for (int i = 0; i <= ConferenciasForm.ultimoI; i++)
			{			
				
				if (cbConferencia.Text == ConferenciasForm.asistente[i].base_de_datos)
                {
					total += 1;
					if (ConferenciasForm.asistente[i].sexos == "Femenino")
                    {
						mujeres += 1;
                    }
                    else { varones += 1; }

                }
				if (cbConferencia.Text == ConferenciasForm.asistente[i].analisis)
				{
					total += 1;
					if (ConferenciasForm.asistente[i].sexos == "Femenino")
					{
						mujeres += 1;
					}
					else { varones += 1; }
				}
				if (cbConferencia.Text == ConferenciasForm.asistente[i].lenguajes)
				{
					total += 1;
					if (ConferenciasForm.asistente[i].sexos == "Femenino")
					{
						mujeres += 1;
					}
					else { varones += 1; }
				}
			}
			recaudado = total * 50;
			txtCantidad.Text = Convert.ToString(total);
			txtVarones.Text = Convert.ToString(varones);
			txtMujeres.Text = Convert.ToString(mujeres);
			txtTotal.Text = "$ " + Convert.ToString(recaudado);
		}
      
    }
}
