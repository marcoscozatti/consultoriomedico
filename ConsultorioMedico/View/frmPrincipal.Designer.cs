
namespace ConsultorioMedico.Modelo
{
	partial class frmPrincipal
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manutençõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.médicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.especialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultasMédicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manutençãoDeConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dgPrincipalConsultas = new System.Windows.Forms.DataGridView();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgPrincipalConsultas)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.sairToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1052, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// sistemaToolStripMenuItem
			// 
			this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutençõesToolStripMenuItem,
            this.consultasMédicasToolStripMenuItem});
			this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
			this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
			this.sistemaToolStripMenuItem.Text = "Sistema";
			// 
			// manutençõesToolStripMenuItem
			// 
			this.manutençõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.médicosToolStripMenuItem,
            this.especialidadesToolStripMenuItem});
			this.manutençõesToolStripMenuItem.Name = "manutençõesToolStripMenuItem";
			this.manutençõesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.manutençõesToolStripMenuItem.Text = "Manutenções";
			// 
			// usuáriosToolStripMenuItem
			// 
			this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
			this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
			this.usuáriosToolStripMenuItem.Text = "Usuários";
			// 
			// clientesToolStripMenuItem
			// 
			this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
			this.clientesToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
			this.clientesToolStripMenuItem.Text = "Clientes";
			// 
			// médicosToolStripMenuItem
			// 
			this.médicosToolStripMenuItem.Name = "médicosToolStripMenuItem";
			this.médicosToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
			this.médicosToolStripMenuItem.Text = "Médicos";
			// 
			// especialidadesToolStripMenuItem
			// 
			this.especialidadesToolStripMenuItem.Name = "especialidadesToolStripMenuItem";
			this.especialidadesToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
			this.especialidadesToolStripMenuItem.Text = "Especialidades";
			// 
			// consultasMédicasToolStripMenuItem
			// 
			this.consultasMédicasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutençãoDeConsultasToolStripMenuItem,
            this.toolStripMenuItem2,
            this.relatóriosToolStripMenuItem});
			this.consultasMédicasToolStripMenuItem.Name = "consultasMédicasToolStripMenuItem";
			this.consultasMédicasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.consultasMédicasToolStripMenuItem.Text = "Consultas médicas";
			// 
			// manutençãoDeConsultasToolStripMenuItem
			// 
			this.manutençãoDeConsultasToolStripMenuItem.Name = "manutençãoDeConsultasToolStripMenuItem";
			this.manutençãoDeConsultasToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
			this.manutençãoDeConsultasToolStripMenuItem.Text = "Manutenção de Consultas";
			this.manutençãoDeConsultasToolStripMenuItem.Click += new System.EventHandler(this.manutençãoDeConsultasToolStripMenuItem_Click);
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
			this.sairToolStripMenuItem.Text = "Sair";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
			// 
			// dgPrincipalConsultas
			// 
			this.dgPrincipalConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgPrincipalConsultas.Location = new System.Drawing.Point(12, 83);
			this.dgPrincipalConsultas.Name = "dgPrincipalConsultas";
			this.dgPrincipalConsultas.RowHeadersWidth = 51;
			this.dgPrincipalConsultas.RowTemplate.Height = 24;
			this.dgPrincipalConsultas.Size = new System.Drawing.Size(1028, 415);
			this.dgPrincipalConsultas.TabIndex = 1;
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(259, 6);
			// 
			// relatóriosToolStripMenuItem
			// 
			this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
			this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
			this.relatóriosToolStripMenuItem.Text = "Relatórios";
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1052, 510);
			this.Controls.Add(this.dgPrincipalConsultas);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consultório Médico";
			this.Load += new System.EventHandler(this.frmPrincipal_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgPrincipalConsultas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manutençõesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem médicosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem especialidadesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultasMédicasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		private System.Windows.Forms.DataGridView dgPrincipalConsultas;
		private System.Windows.Forms.ToolStripMenuItem manutençãoDeConsultasToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
	}
}