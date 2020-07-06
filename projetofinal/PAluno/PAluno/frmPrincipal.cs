using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PAluno {
    public partial class frmPrincipal : Form {

        public static SqlConnection conexao;

        public frmPrincipal() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            try {
                conexao = new SqlConnection("Data Source=DESKTOP-VINÍCIU;Initial Catalog=LP2;Integrated Security=True");
                conexao.Open();
            }catch (SqlException ex) {
                MessageBox.Show("Erro de banco de dados" + ex.Message);
            }catch (Exception ex) {
                MessageBox.Show("Outros Erros" + ex.Message);
            }

        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e) {
            frmCidade formCidade = new frmCidade();
            formCidade.MdiParent = this;
            formCidade.WindowState = FormWindowState.Maximized;
            formCidade.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Nome: Vinícius Fernando de Souza\nRA: 0030481923025");
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e) {
            frmAluno formAluno = new frmAluno();
            formAluno.MdiParent = this;
            formAluno.WindowState = FormWindowState.Maximized;
            formAluno.Show();
        }
    }
}
