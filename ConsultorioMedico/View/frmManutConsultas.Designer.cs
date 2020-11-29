
namespace ConsultorioMedico.View
{
	partial class frmManutConsultas
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtIDAgendamento = new System.Windows.Forms.TextBox();
			this.txtData = new System.Windows.Forms.MaskedTextBox();
			this.dgManutConsulta = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPesquisaPaciente = new System.Windows.Forms.TextBox();
			this.btnInserir = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnPesquisaIDPaciente = new System.Windows.Forms.Button();
			this.btnMedico = new System.Windows.Forms.Button();
			this.btnEspecialidade = new System.Windows.Forms.Button();
			this.txtPaciente = new System.Windows.Forms.ComboBox();
			this.cmbPaciente = new System.Windows.Forms.TextBox();
			this.txtIDMedico = new System.Windows.Forms.TextBox();
			this.cmbMedico = new System.Windows.Forms.ComboBox();
			this.txtIDEspecialidades = new System.Windows.Forms.TextBox();
			this.cmbEspecialidades = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgManutConsulta)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID Agendamento";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Paciente";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Médico";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 167);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Especialidade";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 219);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(117, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Data da Consulta";
			// 
			// txtIDAgendamento
			// 
			this.txtIDAgendamento.Location = new System.Drawing.Point(155, 20);
			this.txtIDAgendamento.Name = "txtIDAgendamento";
			this.txtIDAgendamento.Size = new System.Drawing.Size(291, 22);
			this.txtIDAgendamento.TabIndex = 1;
			// 
			// txtData
			// 
			this.txtData.Location = new System.Drawing.Point(155, 219);
			this.txtData.Mask = "00/00/0000";
			this.txtData.Name = "txtData";
			this.txtData.Size = new System.Drawing.Size(105, 22);
			this.txtData.TabIndex = 5;
			this.txtData.ValidatingType = typeof(System.DateTime);
			// 
			// dgManutConsulta
			// 
			this.dgManutConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgManutConsulta.Location = new System.Drawing.Point(15, 261);
			this.dgManutConsulta.Name = "dgManutConsulta";
			this.dgManutConsulta.RowHeadersWidth = 51;
			this.dgManutConsulta.RowTemplate.Height = 24;
			this.dgManutConsulta.Size = new System.Drawing.Size(700, 254);
			this.dgManutConsulta.TabIndex = 10;
			this.dgManutConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgManutConsulta_CellClick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(332, 222);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(124, 17);
			this.label6.TabIndex = 4;
			this.label6.Text = "Pesquisa paciente";
			// 
			// txtPesquisaPaciente
			// 
			this.txtPesquisaPaciente.Location = new System.Drawing.Point(462, 219);
			this.txtPesquisaPaciente.Name = "txtPesquisaPaciente";
			this.txtPesquisaPaciente.Size = new System.Drawing.Size(253, 22);
			this.txtPesquisaPaciente.TabIndex = 9;
			// 
			// btnInserir
			// 
			this.btnInserir.Location = new System.Drawing.Point(534, 20);
			this.btnInserir.Name = "btnInserir";
			this.btnInserir.Size = new System.Drawing.Size(128, 33);
			this.btnInserir.TabIndex = 6;
			this.btnInserir.Text = "Inserir";
			this.btnInserir.UseVisualStyleBackColor = true;
			this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
			// 
			// btnAlterar
			// 
			this.btnAlterar.Location = new System.Drawing.Point(534, 65);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(128, 33);
			this.btnAlterar.TabIndex = 7;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = true;
			this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(534, 111);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(128, 33);
			this.btnExcluir.TabIndex = 8;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnPesquisaIDPaciente
			// 
			this.btnPesquisaIDPaciente.Location = new System.Drawing.Point(452, 65);
			this.btnPesquisaIDPaciente.Name = "btnPesquisaIDPaciente";
			this.btnPesquisaIDPaciente.Size = new System.Drawing.Size(31, 24);
			this.btnPesquisaIDPaciente.TabIndex = 8;
			this.btnPesquisaIDPaciente.Text = "...";
			this.btnPesquisaIDPaciente.UseVisualStyleBackColor = true;
			this.btnPesquisaIDPaciente.Click += new System.EventHandler(this.btnPesquisaIDPaciente_Click);
			// 
			// btnMedico
			// 
			this.btnMedico.Location = new System.Drawing.Point(452, 116);
			this.btnMedico.Name = "btnMedico";
			this.btnMedico.Size = new System.Drawing.Size(31, 24);
			this.btnMedico.TabIndex = 9;
			this.btnMedico.Text = "...";
			this.btnMedico.UseVisualStyleBackColor = true;
			this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
			// 
			// btnEspecialidade
			// 
			this.btnEspecialidade.Location = new System.Drawing.Point(452, 167);
			this.btnEspecialidade.Name = "btnEspecialidade";
			this.btnEspecialidade.Size = new System.Drawing.Size(31, 24);
			this.btnEspecialidade.TabIndex = 10;
			this.btnEspecialidade.Text = "...";
			this.btnEspecialidade.UseVisualStyleBackColor = true;
			this.btnEspecialidade.Click += new System.EventHandler(this.btnEspecialidade_Click);
			// 
			// txtPaciente
			// 
			this.txtPaciente.FormattingEnabled = true;
			this.txtPaciente.Location = new System.Drawing.Point(281, 67);
			this.txtPaciente.Name = "txtPaciente";
			this.txtPaciente.Size = new System.Drawing.Size(165, 24);
			this.txtPaciente.TabIndex = 12;
			// 
			// cmbPaciente
			// 
			this.cmbPaciente.Location = new System.Drawing.Point(155, 67);
			this.cmbPaciente.Name = "cmbPaciente";
			this.cmbPaciente.Size = new System.Drawing.Size(105, 22);
			this.cmbPaciente.TabIndex = 1;
			// 
			// txtIDMedico
			// 
			this.txtIDMedico.Location = new System.Drawing.Point(155, 118);
			this.txtIDMedico.Name = "txtIDMedico";
			this.txtIDMedico.Size = new System.Drawing.Size(105, 22);
			this.txtIDMedico.TabIndex = 1;
			// 
			// cmbMedico
			// 
			this.cmbMedico.FormattingEnabled = true;
			this.cmbMedico.Location = new System.Drawing.Point(281, 118);
			this.cmbMedico.Name = "cmbMedico";
			this.cmbMedico.Size = new System.Drawing.Size(165, 24);
			this.cmbMedico.TabIndex = 12;
			// 
			// txtIDEspecialidades
			// 
			this.txtIDEspecialidades.Location = new System.Drawing.Point(155, 169);
			this.txtIDEspecialidades.Name = "txtIDEspecialidades";
			this.txtIDEspecialidades.Size = new System.Drawing.Size(105, 22);
			this.txtIDEspecialidades.TabIndex = 1;
			// 
			// cmbEspecialidades
			// 
			this.cmbEspecialidades.FormattingEnabled = true;
			this.cmbEspecialidades.Location = new System.Drawing.Point(281, 169);
			this.cmbEspecialidades.Name = "cmbEspecialidades";
			this.cmbEspecialidades.Size = new System.Drawing.Size(165, 24);
			this.cmbEspecialidades.TabIndex = 12;
			// 
			// frmManutConsultas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(730, 527);
			this.Controls.Add(this.cmbEspecialidades);
			this.Controls.Add(this.cmbMedico);
			this.Controls.Add(this.txtPaciente);
			this.Controls.Add(this.btnEspecialidade);
			this.Controls.Add(this.btnMedico);
			this.Controls.Add(this.btnPesquisaIDPaciente);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.btnInserir);
			this.Controls.Add(this.dgManutConsulta);
			this.Controls.Add(this.txtData);
			this.Controls.Add(this.txtPesquisaPaciente);
			this.Controls.Add(this.txtIDEspecialidades);
			this.Controls.Add(this.txtIDMedico);
			this.Controls.Add(this.cmbPaciente);
			this.Controls.Add(this.txtIDAgendamento);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmManutConsultas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manutenção de Consultas médicas";
			this.Load += new System.EventHandler(this.frmManutConsultas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgManutConsulta)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtIDAgendamento;
		private System.Windows.Forms.MaskedTextBox txtData;
		private System.Windows.Forms.DataGridView dgManutConsulta;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPesquisaPaciente;
		private System.Windows.Forms.Button btnInserir;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnPesquisaIDPaciente;
		private System.Windows.Forms.Button btnMedico;
		private System.Windows.Forms.Button btnEspecialidade;
		private System.Windows.Forms.ComboBox txtPaciente;
		private System.Windows.Forms.TextBox cmbPaciente;
		private System.Windows.Forms.TextBox txtIDMedico;
		private System.Windows.Forms.ComboBox cmbMedico;
		private System.Windows.Forms.TextBox txtIDEspecialidades;
		private System.Windows.Forms.ComboBox cmbEspecialidades;
	}
}