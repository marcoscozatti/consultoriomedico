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

namespace ConsultorioMedico.View
{
	public partial class frmManutConsultas : Form
	{
		public frmManutConsultas()
		{
			InitializeComponent();

		}


		//preencher combobox

		private void Carrega_cmbPaciente()
		{
			using (var tb = new BDSistemaConsultorioEntities())
			{
				var itemidPaciente = tb.CadPacientes.ToList();
				foreach (var item in itemidPaciente)
				{
					int idpac = txtPaciente.Items.Add(item.Paciente);

				}
			}

		}

		private void Carrega_cmbMedicos()
		{
			using (var tb = new BDSistemaConsultorioEntities())
			{
				var itemMedico = from medico in tb.CadMedicos
								 select new { medico.idMedico, medico.Medico };

				cmbMedico.Items.Clear();
				cmbMedico.DataSource = itemMedico.ToList();
				cmbMedico.DisplayMember = "Medico";



			}
		}

		private void Carrega_cmbEspecialidades()
		{
			using (var tb = new BDSistemaConsultorioEntities())
			{
				var itemEspecialidade = from especialidades in tb.CadEspecialidades
										select new { especialidades.idEspecialidade, especialidades.Especialidade };

				cmbEspecialidades.Items.Clear();
				cmbEspecialidades.DataSource = itemEspecialidade.ToList();
				cmbEspecialidades.DisplayMember = "Especialidade";

			}
		}


		private void frmManutConsultas_Load(object sender, EventArgs e)
		{

			Carrega_cmbPaciente();
			Carrega_cmbMedicos();
			Carrega_cmbEspecialidades();
			limpacampos();
			carregaGrid();

		}

		private void btnInserir_Click(object sender, EventArgs e)
		{
			try
			{
				using (var tb = new BDSistemaConsultorioEntities())
				{
					tb.AgendamentoConsultas.Add(new AgendamentoConsultas
					{
						idPaciente = Convert.ToInt32(cmbPaciente.Text),
						idMedico = Convert.ToInt32(txtIDMedico.Text),
						idEspecialidade = Convert.ToInt32(txtIDEspecialidades.Text),
						DataConsulta = Convert.ToDateTime(txtData.Text)
					});

					tb.SaveChanges();
					limpacampos();
					carregaGrid();

				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}

		}

		private void limpacampos()
		{
			txtIDAgendamento.Text = "";
			txtPaciente.Text = "";
			cmbPaciente.Text = "";
			txtIDMedico.Text = "";
			cmbMedico.Text = "";
			txtIDEspecialidades.Text = "";
			cmbEspecialidades.Text = "";
			txtData.Text = "";
			cmbPaciente.Focus();
		}

		private void btnPesquisaIDPaciente_Click(object sender, EventArgs e)
		{
			try
			{
				using (var tb = new BDSistemaConsultorioEntities())
				{
					var itemPac = tb.CadPacientes.ToList().Where(x => x.Paciente == txtPaciente.Text);
					foreach (var item in itemPac)
					{
						cmbPaciente.Text = Convert.ToString(item.idPaciente);
					}
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}

		}

		private void btnMedico_Click(object sender, EventArgs e)
		{
			try
			{
				using (var tb = new BDSistemaConsultorioEntities())
				{
					var itemMedico = tb.CadMedicos.ToList().Where(y => y.Medico == cmbMedico.Text);
					foreach (var itemM in itemMedico)
					{
						txtIDMedico.Text = Convert.ToString(itemM.idMedico);
					}

				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void btnEspecialidade_Click(object sender, EventArgs e)
		{
			try
			{
				using (var tb = new BDSistemaConsultorioEntities())
				{

					var itemEspecialidades = tb.CadEspecialidades.ToList().Where(w => w.Especialidade == cmbEspecialidades.Text);
					foreach (var itemE in itemEspecialidades)
					{
						txtIDEspecialidades.Text = Convert.ToString(itemE.idEspecialidade);
					}


				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			BDSistemaConsultorioEntities ef = new BDSistemaConsultorioEntities();
			var agenda = ef.AgendamentoConsultas.Find(Convert.ToInt32(txtIDAgendamento.Text));

			agenda.idPaciente = int.Parse(cmbPaciente.Text);
			agenda.idMedico = int.Parse(txtIDMedico.Text);
			agenda.idEspecialidade = int.Parse(txtIDEspecialidades.Text);
			agenda.DataConsulta = DateTime.Parse(txtData.Text);

			ef.SaveChanges();

			limpacampos();
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
							 orderby agenda.DataConsulta descending
							 select new { agenda.idAgendamento, cadpaciente.idPaciente, cadpaciente.Paciente, cadmedico.idMedico, cadmedico.Medico, cadespecialidade.idEspecialidade, cadespecialidade.Especialidade, agenda.DataConsulta };

				dgManutConsulta.DataSource = null;
				dgManutConsulta.DataSource = result.ToList();
			}



		}

		private void dgManutConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtIDAgendamento.Text = dgManutConsulta.CurrentRow.Cells[0].Value.ToString();
			cmbPaciente.Text = dgManutConsulta.CurrentRow.Cells[1].Value.ToString();
			txtPaciente.Text = dgManutConsulta.CurrentRow.Cells[2].Value.ToString();
			txtIDMedico.Text = dgManutConsulta.CurrentRow.Cells[3].Value.ToString();
			cmbMedico.Text = dgManutConsulta.CurrentRow.Cells[4].Value.ToString();
			txtIDEspecialidades.Text = dgManutConsulta.CurrentRow.Cells[5].Value.ToString();
			cmbEspecialidades.Text = dgManutConsulta.CurrentRow.Cells[6].Value.ToString();
			txtData.Text = dgManutConsulta.CurrentRow.Cells[7].Value.ToString();
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			using (var tb = new BDSistemaConsultorioEntities())
			{
				try
				{
					var objeto = tb.AgendamentoConsultas.Find(Convert.ToInt32(txtIDAgendamento.Text));
					tb.AgendamentoConsultas.Remove(objeto);
					tb.SaveChanges();
					MessageBox.Show("Exlcuido com sucesso", "Exclusão");
					limpacampos();
					carregaGrid();

				}
				catch (Exception ex)
				{

					MessageBox.Show(ex.Message);
				}

			}

		}
	}
}
