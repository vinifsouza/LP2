using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PAluno {

    
    public partial class frmAluno : Form {
        private BindingSource bnAluno = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsAluno = new DataSet();
        private DataSet dsCidade = new DataSet();
        public frmAluno() {
            InitializeComponent();
        }


        private void btnExcluir_Click(object sender, EventArgs e) {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            
        }

        private void btnSair_Click(object sender, EventArgs e) {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnExcluir_Click_1(object sender, EventArgs e) {

        }

        private void lblNome_Click(object sender, EventArgs e) {

        }

        private void frmAluno_Load(object sender, EventArgs e) {
            try {
                Aluno Alu = new Aluno();
                dsAluno.Tables.Add(Alu.Listar());
                bnAluno.DataSource = dsAluno.Tables["TBALUNO"];
                dvgAluno.DataSource = bnAluno;
                bnvAluno.BindingSource = bnAluno;

                txtRA.DataBindings.Add("TEXT", bnAluno, "ra_aluno");
                txtNomeAluno.DataBindings.Add("TEXT", bnAluno, "nome_aluno");

                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());

                cbxCidadeAluno.DataSource = dsCidade.Tables["TBcidade"];
                cbxCidadeAluno.DisplayMember = "nome_cidade";
                cbxCidadeAluno.ValueMember = "id_cidade";

                cbxCidadeAluno.DataBindings.Add("selectedValue", bnAluno, "cidade_id_cidade");

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void Detalhes_Click(object sender, EventArgs e) {

        }

        private void bnvAluno_RefreshItems(object sender, EventArgs e) {

        }

        private void btnSair_Click_1(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAlterar_Click_1(object sender, EventArgs e) {
            if (tabAlunos.SelectedIndex == 0) {
                tabAlunos.SelectTab(1);
            }

            txtNomeAluno.Focus();
            txtNomeAluno.Enabled = true;
            cbxCidadeAluno.Enabled = true;
            txtRA.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;

            bInclusao = false;
        }

        private void btnExcluir_Click_2(object sender, EventArgs e) {
            if (tabAlunos.SelectedIndex == 0) {
                tabAlunos.SelectTab(1);
            }


            Aluno RegAl = new Aluno();
            RegAl.RaAluno = Convert.ToInt16(txtRA.Text);
            RegAl.NomeAluno = txtNomeAluno.Text;

            if (MessageBox.Show("Confirma Exlusão de " + RegAl.NomeAluno, "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                if (RegAl.RaAluno == 0) {
                    MessageBox.Show("Selecione um Aluno!");
                } else {
                    if (RegAl.Excluir() > 0) {
                        MessageBox.Show("Cidade " + RegAl.NomeAluno + " removido com sucesso!");

                        dsAluno.Tables.Clear();
                        dsAluno.Tables.Add(RegAl.Listar());
                        bnAluno.DataSource = dsAluno.Tables["TBaluno"];

                        tabAlunos.SelectTab(0);

                    } else {
                        MessageBox.Show("Erro ao excluir Aluno!");
                    }
                }

            }
        }

        private void btnNovoRegistro_Click_1(object sender, EventArgs e) {
            if (tabAlunos.SelectedIndex == 0) {
                tabAlunos.SelectTab(1);
            }

            bnAluno.AddNew();
            txtNomeAluno.Focus();
            cbxCidadeAluno.SelectedIndex = 0;
            txtNomeAluno.Enabled = true;
            txtRA.Enabled = true;
            cbxCidadeAluno.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;

            bInclusao = true;
        }

        private void btnSalvar_Click_1(object sender, EventArgs e) {
            if (txtNomeAluno.Text == "") {
                MessageBox.Show("Informe um nome válido para o Aluno!");
            } else {
                Aluno RegAl = new Aluno();
                RegAl.RaAluno = Convert.ToInt16(txtRA.Text);
                RegAl.NomeAluno = txtNomeAluno.Text;
                RegAl.IdCidade = Convert.ToInt32(cbxCidadeAluno.SelectedValue.ToString());

                if (bInclusao) {
                    if (RegAl.Salvar() > 0) {
                        MessageBox.Show("Aluno adicionado com sucesso!");

                        bInclusao = false;

                    } else {
                        MessageBox.Show("Erro ao incluir Aluno!");
                    }
                } else {
                    if (RegAl.Alterar() > 0) {
                        MessageBox.Show("Aluno alterada com sucesso!");

                        bInclusao = false;

                    }
                }
                btnSalvar.Enabled = false;
                txtRA.Enabled = false;
                txtNomeAluno.Enabled = false;
                cbxCidadeAluno.Enabled = false;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;

                btnAlterar.Enabled = true;
                btnNovoRegistro.Enabled = true;
                btnExcluir.Enabled = true;

                dsAluno.Tables.Clear();
                dsAluno.Tables.Add(RegAl.Listar());
                bnAluno.DataSource = dsAluno.Tables["TBaluno"];

                tabAlunos.SelectTab(0);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e) {
            bnAluno.CancelEdit();

            btnSalvar.Enabled = false;
            txtNomeAluno.Enabled = false;
            cbxCidadeAluno.Enabled = false;
            txtRA.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovoRegistro.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void BindingNavigatorMoveNextItem_Click(object sender, EventArgs e) {

        }
    }
}
