namespace PAluno {
    partial class frmAluno {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAluno));
            this.tabAlunos = new System.Windows.Forms.TabControl();
            this.Dados = new System.Windows.Forms.TabPage();
            this.dvgAluno = new System.Windows.Forms.DataGridView();
            this.Detalhes = new System.Windows.Forms.TabPage();
            this.cbxCidadeAluno = new System.Windows.Forms.ComboBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRA = new System.Windows.Forms.Label();
            this.bnvAluno = new System.Windows.Forms.BindingNavigator(this.components);
            this.BindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.BindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.BindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovoRegistro = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.tabAlunos.SuspendLayout();
            this.Dados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAluno)).BeginInit();
            this.Detalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnvAluno)).BeginInit();
            this.bnvAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAlunos
            // 
            this.tabAlunos.Controls.Add(this.Dados);
            this.tabAlunos.Controls.Add(this.Detalhes);
            this.tabAlunos.Location = new System.Drawing.Point(12, 42);
            this.tabAlunos.Name = "tabAlunos";
            this.tabAlunos.SelectedIndex = 0;
            this.tabAlunos.Size = new System.Drawing.Size(673, 310);
            this.tabAlunos.TabIndex = 0;
            // 
            // Dados
            // 
            this.Dados.Controls.Add(this.dvgAluno);
            this.Dados.Location = new System.Drawing.Point(4, 25);
            this.Dados.Name = "Dados";
            this.Dados.Padding = new System.Windows.Forms.Padding(3);
            this.Dados.Size = new System.Drawing.Size(665, 281);
            this.Dados.TabIndex = 0;
            this.Dados.Text = "Dados";
            this.Dados.UseVisualStyleBackColor = true;
            // 
            // dvgAluno
            // 
            this.dvgAluno.AllowUserToAddRows = false;
            this.dvgAluno.AllowUserToDeleteRows = false;
            this.dvgAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAluno.Location = new System.Drawing.Point(6, 6);
            this.dvgAluno.Name = "dvgAluno";
            this.dvgAluno.RowHeadersWidth = 51;
            this.dvgAluno.RowTemplate.Height = 24;
            this.dvgAluno.Size = new System.Drawing.Size(653, 275);
            this.dvgAluno.TabIndex = 0;
            // 
            // Detalhes
            // 
            this.Detalhes.Controls.Add(this.cbxCidadeAluno);
            this.Detalhes.Controls.Add(this.txtNomeAluno);
            this.Detalhes.Controls.Add(this.txtRA);
            this.Detalhes.Controls.Add(this.lblCidade);
            this.Detalhes.Controls.Add(this.lblNome);
            this.Detalhes.Controls.Add(this.lblRA);
            this.Detalhes.Location = new System.Drawing.Point(4, 25);
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.Padding = new System.Windows.Forms.Padding(3);
            this.Detalhes.Size = new System.Drawing.Size(665, 281);
            this.Detalhes.TabIndex = 1;
            this.Detalhes.Text = "Detalhes";
            this.Detalhes.UseVisualStyleBackColor = true;
            this.Detalhes.Click += new System.EventHandler(this.Detalhes_Click);
            // 
            // cbxCidadeAluno
            // 
            this.cbxCidadeAluno.Enabled = false;
            this.cbxCidadeAluno.FormattingEnabled = true;
            this.cbxCidadeAluno.Location = new System.Drawing.Point(95, 149);
            this.cbxCidadeAluno.Name = "cbxCidadeAluno";
            this.cbxCidadeAluno.Size = new System.Drawing.Size(207, 24);
            this.cbxCidadeAluno.TabIndex = 6;
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Enabled = false;
            this.txtNomeAluno.Location = new System.Drawing.Point(95, 87);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(207, 22);
            this.txtNomeAluno.TabIndex = 5;
            // 
            // txtRA
            // 
            this.txtRA.Enabled = false;
            this.txtRA.Location = new System.Drawing.Point(95, 32);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(207, 22);
            this.txtRA.TabIndex = 4;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(37, 149);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(52, 17);
            this.lblCidade.TabIndex = 2;
            this.lblCidade.Text = "Cidade";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(37, 90);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Location = new System.Drawing.Point(37, 32);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(27, 17);
            this.lblRA.TabIndex = 0;
            this.lblRA.Text = "RA";
            // 
            // bnvAluno
            // 
            this.bnvAluno.AddNewItem = null;
            this.bnvAluno.CountItem = this.BindingNavigatorCountItem;
            this.bnvAluno.DeleteItem = null;
            this.bnvAluno.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bnvAluno.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BindingNavigatorMoveFirstItem,
            this.BindingNavigatorMovePreviousItem,
            this.BindingNavigatorSeparator,
            this.BindingNavigatorPositionItem,
            this.BindingNavigatorCountItem,
            this.BindingNavigatorSeparator1,
            this.BindingNavigatorMoveNextItem,
            this.BindingNavigatorMoveLastItem,
            this.BindingNavigatorSeparator2,
            this.btnNovoRegistro,
            this.btnExcluir,
            this.btnSalvar,
            this.btnAlterar,
            this.btnCancelar,
            this.btnSair});
            this.bnvAluno.Location = new System.Drawing.Point(0, 0);
            this.bnvAluno.MoveFirstItem = this.BindingNavigatorMoveFirstItem;
            this.bnvAluno.MoveLastItem = this.BindingNavigatorMoveLastItem;
            this.bnvAluno.MoveNextItem = this.BindingNavigatorMoveNextItem;
            this.bnvAluno.MovePreviousItem = this.BindingNavigatorMovePreviousItem;
            this.bnvAluno.Name = "bnvAluno";
            this.bnvAluno.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bnvAluno.PositionItem = this.BindingNavigatorPositionItem;
            this.bnvAluno.Size = new System.Drawing.Size(697, 31);
            this.bnvAluno.TabIndex = 4;
            this.bnvAluno.Text = "bnvAluno";
            this.bnvAluno.RefreshItems += new System.EventHandler(this.bnvAluno_RefreshItems);
            // 
            // BindingNavigatorCountItem
            // 
            this.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
            this.BindingNavigatorCountItem.Size = new System.Drawing.Size(48, 28);
            this.BindingNavigatorCountItem.Text = "de {0}";
            this.BindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // BindingNavigatorMoveFirstItem
            // 
            this.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveFirstItem.Image")));
            this.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem";
            this.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.BindingNavigatorMoveFirstItem.Text = "Primeiro registro";
            // 
            // BindingNavigatorMovePreviousItem
            // 
            this.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMovePreviousItem.Image")));
            this.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem";
            this.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.BindingNavigatorMovePreviousItem.Text = "Registro anterior";
            // 
            // BindingNavigatorSeparator
            // 
            this.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
            this.BindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // BindingNavigatorPositionItem
            // 
            this.BindingNavigatorPositionItem.AccessibleName = "Position";
            this.BindingNavigatorPositionItem.AutoSize = false;
            this.BindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem";
            this.BindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.BindingNavigatorPositionItem.Text = "0";
            this.BindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // BindingNavigatorSeparator1
            // 
            this.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1";
            this.BindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // BindingNavigatorMoveNextItem
            // 
            this.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveNextItem.Image")));
            this.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
            this.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.BindingNavigatorMoveNextItem.Text = "Próximo registro";
            this.BindingNavigatorMoveNextItem.Click += new System.EventHandler(this.BindingNavigatorMoveNextItem_Click);
            // 
            // BindingNavigatorMoveLastItem
            // 
            this.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveLastItem.Image")));
            this.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem";
            this.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.BindingNavigatorMoveLastItem.Text = "Último Registro";
            // 
            // BindingNavigatorSeparator2
            // 
            this.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
            this.BindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btnNovoRegistro
            // 
            this.btnNovoRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovoRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoRegistro.Image")));
            this.btnNovoRegistro.Name = "btnNovoRegistro";
            this.btnNovoRegistro.RightToLeftAutoMirrorImage = true;
            this.btnNovoRegistro.Size = new System.Drawing.Size(29, 28);
            this.btnNovoRegistro.Text = "Adicionar Novo Registro";
            this.btnNovoRegistro.Click += new System.EventHandler(this.btnNovoRegistro_Click_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.RightToLeftAutoMirrorImage = true;
            this.btnExcluir.Size = new System.Drawing.Size(29, 28);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_2);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(29, 28);
            this.btnSalvar.Text = "Salvar Registros";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(29, 28);
            this.btnAlterar.Text = "Alterar Registro";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(29, 28);
            this.btnCancelar.Text = "Cancelar Alteração";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(29, 28);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // frmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 364);
            this.Controls.Add(this.bnvAluno);
            this.Controls.Add(this.tabAlunos);
            this.Name = "frmAluno";
            this.Text = "frmAluno";
            this.Load += new System.EventHandler(this.frmAluno_Load);
            this.tabAlunos.ResumeLayout(false);
            this.Dados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgAluno)).EndInit();
            this.Detalhes.ResumeLayout(false);
            this.Detalhes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnvAluno)).EndInit();
            this.bnvAluno.ResumeLayout(false);
            this.bnvAluno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabAlunos;
        private System.Windows.Forms.TabPage Dados;
        private System.Windows.Forms.TabPage Detalhes;
        internal System.Windows.Forms.BindingNavigator bnvAluno;
        internal System.Windows.Forms.ToolStripLabel BindingNavigatorCountItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveFirstItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMovePreviousItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator;
        internal System.Windows.Forms.ToolStripTextBox BindingNavigatorPositionItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator1;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveNextItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveLastItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator2;
        internal System.Windows.Forms.ToolStripButton btnNovoRegistro;
        internal System.Windows.Forms.ToolStripButton btnExcluir;
        internal System.Windows.Forms.ToolStripButton btnSalvar;
        internal System.Windows.Forms.ToolStripButton btnAlterar;
        internal System.Windows.Forms.ToolStripButton btnCancelar;
        internal System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.DataGridView dvgAluno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.ComboBox cbxCidadeAluno;
    }
}