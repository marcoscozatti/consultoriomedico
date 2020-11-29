using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultorioMedico.Controller;
using ConsultorioMedico.View;

namespace ConsultorioMedico.Modelo
{
	public partial class frmPrincipal : Form
	{
		public frmPrincipal()  //frmPrincipal
		{
			InitializeComponent();
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
			

		}

		private void frmPrincipal_Load(object sender, EventArgs e)
		{
			carregaGrid();

		}

		private void carregaGrid()
		{

			using (var tb = new BDSistemaConsultorioEntities()) 
			{
				var result = from agenda in tb.AgendamentoConsultas
							 join cadmedico in tb.CadMedicos
							 on agenda.idMedico equals cadmedico.idMedico
							 join cadpaciente in tb.CadPacientes
							 on agenda.idPaciente equals cadpaciente.idPaciente
							 join cadespecialidade in tb.CadEspecialidades
							 on agenda.idEspecialidade equals cadespecialidade.idEspecialidade
							 //where agenda.DataConsulta >= DateTime.Now
							 orderby  agenda.DataConsulta  descending
							 select new { cadespecialidade.Especialidade, cadmedico.Medico, cadpaciente.Paciente, agenda.DataConsulta };

				dgPrincipalConsultas.DataSource = null;
				dgPrincipalConsultas.DataSource = result.ToList();
			}
		}

		private void manutençãoDeConsultasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmManutConsultas mc = new frmManutConsultas();
			mc.ShowDialog();
		}
	}
}
