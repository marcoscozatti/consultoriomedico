using ConsultorioMedico.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioMedico
{
	public partial class Form1 : Form
	{
		public Form1() // Form1
		{
			InitializeComponent();
		}

		private void btnLogar_Click(object sender, EventArgs e)
		{
			//string nome, senha;
			//nome = txtUsuario.Text;
			//senha = txtSenha.Text;

			//if ((nome == "admin") && (senha == "123"))
			//{
			//	this.Hide();
			//	frmPrincipal tela = new frmPrincipal();
			//	tela.ShowDialog();
			//}
			//else
			//{
			//	MessageBox.Show("Usuário ou senha errado");
			//}

			this.Hide();
			frmPrincipal tela = new frmPrincipal();
			tela.ShowDialog();
		}
	}
}
