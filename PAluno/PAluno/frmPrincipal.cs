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

        private void frmPrincipal_Load(object sender, EventArgs e) {

            
            try {
                conexao = new SqlConnection("Data Source=DESKTOP-VINÍCIU;Initial Catalog=LP2;Integrated Security=True");
                conexao.Open();
            }catch (SqlException ex) {
                MessageBox.Show("Erro de SQL" + ex.Message);
            }catch (Exception ex) {
                MessageBox.Show("Erro geral" + ex.Message);
            }

        }
    }
}
